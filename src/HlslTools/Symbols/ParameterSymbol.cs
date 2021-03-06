﻿namespace HlslTools.Symbols
{
    public class ParameterSymbol : LocalVariableSymbol
    {
        public ParameterDirection Direction { get; }

        public ParameterSymbol(string name, string documentation, Symbol parent, TypeSymbol valueType, ParameterDirection direction = ParameterDirection.In)
            : base(SymbolKind.Parameter, name, documentation, parent, valueType)
        {
            Direction = direction;
        }
    }

    public enum ParameterDirection
    {
        In,
        Out,
        Inout
    }
}