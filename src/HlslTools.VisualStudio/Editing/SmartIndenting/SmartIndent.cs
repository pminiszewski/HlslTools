﻿using System.Threading;
using HlslTools.Syntax;
using HlslTools.VisualStudio.Text;
using HlslTools.VisualStudio.Util.Extensions;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.TextManager.Interop;

namespace HlslTools.VisualStudio.Editing.SmartIndenting
{
    internal sealed class SmartIndent : ISmartIndent
    {
        private readonly HlslLanguagePreferences _languagePreferences;
        private readonly VisualStudioSourceTextFactory _sourceTextFactory;

        public SmartIndent(SVsServiceProvider serviceProvider, VisualStudioSourceTextFactory sourceTextFactory)
        {
            _languagePreferences = serviceProvider.GetHlslToolsService().LanguagePreferences;
            _sourceTextFactory = sourceTextFactory;
        }

        public int? GetDesiredIndentation(ITextSnapshotLine line)
        {
            switch (_languagePreferences.IndentMode)
            {
                case vsIndentStyle.vsIndentStyleNone:
                    return null;

                case vsIndentStyle.vsIndentStyleDefault:
                    return DoBlockIndent(line);

                case vsIndentStyle.vsIndentStyleSmart:
                    return DoSmartIndent(line);

                default:
                    return null;
            }
        }

        private int? DoSmartIndent(ITextSnapshotLine line)
        {
            var syntaxTree = line.Snapshot.GetSyntaxTree(_sourceTextFactory, CancellationToken.None);
            var root = syntaxTree.Root;
            var lineStartPosition = line.Start.Position;
            var indent = FindTotalParentChainIndent(root, lineStartPosition, 0);
            return indent;
        }

        // From https://github.com/KirillOsenkov/XmlParser/blob/master/src/Microsoft.Language.Xml.Editor/SmartIndent/SmartIndent.cs#L39
        public static int FindTotalParentChainIndent(SyntaxNode node, int position, int indent)
        {
            var textSpan = node.GetTextSpanRoot();

            if (!textSpan.IsInRootFile)
                return indent;

            if (position < textSpan.Start || position > textSpan.End)
                return indent;

            foreach (var child in node.ChildNodes)
            {
                var childSpan = child.GetTextSpanRoot();

                if (!childSpan.IsInRootFile)
                    continue;

                var shouldIndent = ShouldIndent(child);
                if (shouldIndent)
                    indent += 4;

                if (position <= childSpan.End)
                    return FindTotalParentChainIndent(child, position, indent);

                if (shouldIndent)
                    indent -= 4;
            }

            return indent;
        }

        private static bool ShouldIndent(SyntaxNode node)
        {
            if (node.Kind == SyntaxKind.ElseClause)
                return false;

            switch (node.Parent.Kind)
            {
                case SyntaxKind.Block:
                    return true;

                case SyntaxKind.IfStatement:
                case SyntaxKind.DoStatement:
                case SyntaxKind.WhileStatement:
                case SyntaxKind.ForStatement:
                case SyntaxKind.SwitchStatement:
                    return node.Kind != SyntaxKind.Block;

                case SyntaxKind.Namespace:
                case SyntaxKind.ConstantBufferDeclaration:
                case SyntaxKind.ClassType:
                case SyntaxKind.StructType:
                case SyntaxKind.InterfaceType:
                case SyntaxKind.ArrayInitializerExpression:
                    return true;

                default:
                    return false;
            }
        }

        private int? DoBlockIndent(ITextSnapshotLine line)
        {
            for (var lineNumber = line.LineNumber - 1; lineNumber >= 0; --lineNumber)
            {
                var previousLine = line.Snapshot.GetLineFromLineNumber(lineNumber);

                string text = previousLine.GetText();

                if (text.Length > 0)
                {
                    return GetLeadingWhiteSpace(text);
                }
            }

            return null;
        }

        private int GetLeadingWhiteSpace(string text)
        {
            var size = 0;
            foreach (var ch in text)
            {
                if (ch == '\t')
                    size += _languagePreferences.TabSize;
                else if (ch == ' ')
                    size++;
                else
                    break;
            }

            return size;
        }

        public void Dispose()
        {
        }
    }
}