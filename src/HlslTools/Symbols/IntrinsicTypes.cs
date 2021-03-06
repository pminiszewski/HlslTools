﻿using System;
using System.Collections.Generic;
using System.Linq;
using HlslTools.Syntax;

namespace HlslTools.Symbols
{
    public static class IntrinsicTypes
    {
        public static readonly TypeSymbol Void;
        public static readonly TypeSymbol Bool;
        public static readonly TypeSymbol Int;
        public static readonly TypeSymbol Uint;
        public static readonly TypeSymbol Half;
        public static readonly TypeSymbol Float;
        public static readonly TypeSymbol Double;

        public static readonly TypeSymbol Bool1;
        public static readonly TypeSymbol Bool2;
        public static readonly TypeSymbol Bool3;
        public static readonly TypeSymbol Bool4;

        public static readonly TypeSymbol Int1;
        public static readonly TypeSymbol Int2;
        public static readonly TypeSymbol Int3;
        public static readonly TypeSymbol Int4;

        public static readonly TypeSymbol Uint1;
        public static readonly TypeSymbol Uint2;
        public static readonly TypeSymbol Uint3;
        public static readonly TypeSymbol Uint4;

        public static readonly TypeSymbol Half1;
        public static readonly TypeSymbol Half2;
        public static readonly TypeSymbol Half3;
        public static readonly TypeSymbol Half4;

        public static readonly TypeSymbol Float1;
        public static readonly TypeSymbol Float2;
        public static readonly TypeSymbol Float3;
        public static readonly TypeSymbol Float4;

        public static readonly TypeSymbol Double1;
        public static readonly TypeSymbol Double2;
        public static readonly TypeSymbol Double3;
        public static readonly TypeSymbol Double4;

        public static readonly TypeSymbol Bool1x1;
        public static readonly TypeSymbol Bool1x2;
        public static readonly TypeSymbol Bool1x3;
        public static readonly TypeSymbol Bool1x4;
        public static readonly TypeSymbol Bool2x1;
        public static readonly TypeSymbol Bool2x2;
        public static readonly TypeSymbol Bool2x3;
        public static readonly TypeSymbol Bool2x4;
        public static readonly TypeSymbol Bool3x1;
        public static readonly TypeSymbol Bool3x2;
        public static readonly TypeSymbol Bool3x3;
        public static readonly TypeSymbol Bool3x4;
        public static readonly TypeSymbol Bool4x1;
        public static readonly TypeSymbol Bool4x2;
        public static readonly TypeSymbol Bool4x3;
        public static readonly TypeSymbol Bool4x4;

        public static readonly TypeSymbol Int1x1;
        public static readonly TypeSymbol Int1x2;
        public static readonly TypeSymbol Int1x3;
        public static readonly TypeSymbol Int1x4;
        public static readonly TypeSymbol Int2x1;
        public static readonly TypeSymbol Int2x2;
        public static readonly TypeSymbol Int2x3;
        public static readonly TypeSymbol Int2x4;
        public static readonly TypeSymbol Int3x1;
        public static readonly TypeSymbol Int3x2;
        public static readonly TypeSymbol Int3x3;
        public static readonly TypeSymbol Int3x4;
        public static readonly TypeSymbol Int4x1;
        public static readonly TypeSymbol Int4x2;
        public static readonly TypeSymbol Int4x3;
        public static readonly TypeSymbol Int4x4;

        public static readonly TypeSymbol Uint1x1;
        public static readonly TypeSymbol Uint1x2;
        public static readonly TypeSymbol Uint1x3;
        public static readonly TypeSymbol Uint1x4;
        public static readonly TypeSymbol Uint2x1;
        public static readonly TypeSymbol Uint2x2;
        public static readonly TypeSymbol Uint2x3;
        public static readonly TypeSymbol Uint2x4;
        public static readonly TypeSymbol Uint3x1;
        public static readonly TypeSymbol Uint3x2;
        public static readonly TypeSymbol Uint3x3;
        public static readonly TypeSymbol Uint3x4;
        public static readonly TypeSymbol Uint4x1;
        public static readonly TypeSymbol Uint4x2;
        public static readonly TypeSymbol Uint4x3;
        public static readonly TypeSymbol Uint4x4;

        public static readonly TypeSymbol Half1x1;
        public static readonly TypeSymbol Half1x2;
        public static readonly TypeSymbol Half1x3;
        public static readonly TypeSymbol Half1x4;
        public static readonly TypeSymbol Half2x1;
        public static readonly TypeSymbol Half2x2;
        public static readonly TypeSymbol Half2x3;
        public static readonly TypeSymbol Half2x4;
        public static readonly TypeSymbol Half3x1;
        public static readonly TypeSymbol Half3x2;
        public static readonly TypeSymbol Half3x3;
        public static readonly TypeSymbol Half3x4;
        public static readonly TypeSymbol Half4x1;
        public static readonly TypeSymbol Half4x2;
        public static readonly TypeSymbol Half4x3;
        public static readonly TypeSymbol Half4x4;

        public static readonly TypeSymbol Float1x1;
        public static readonly TypeSymbol Float1x2;
        public static readonly TypeSymbol Float1x3;
        public static readonly TypeSymbol Float1x4;
        public static readonly TypeSymbol Float2x1;
        public static readonly TypeSymbol Float2x2;
        public static readonly TypeSymbol Float2x3;
        public static readonly TypeSymbol Float2x4;
        public static readonly TypeSymbol Float3x1;
        public static readonly TypeSymbol Float3x2;
        public static readonly TypeSymbol Float3x3;
        public static readonly TypeSymbol Float3x4;
        public static readonly TypeSymbol Float4x1;
        public static readonly TypeSymbol Float4x2;
        public static readonly TypeSymbol Float4x3;
        public static readonly TypeSymbol Float4x4;

        public static readonly TypeSymbol Double1x1;
        public static readonly TypeSymbol Double1x2;
        public static readonly TypeSymbol Double1x3;
        public static readonly TypeSymbol Double1x4;
        public static readonly TypeSymbol Double2x1;
        public static readonly TypeSymbol Double2x2;
        public static readonly TypeSymbol Double2x3;
        public static readonly TypeSymbol Double2x4;
        public static readonly TypeSymbol Double3x1;
        public static readonly TypeSymbol Double3x2;
        public static readonly TypeSymbol Double3x3;
        public static readonly TypeSymbol Double3x4;
        public static readonly TypeSymbol Double4x1;
        public static readonly TypeSymbol Double4x2;
        public static readonly TypeSymbol Double4x3;
        public static readonly TypeSymbol Double4x4;

        public static readonly TypeSymbol[] AllScalarTypes;

        public static readonly TypeSymbol[] AllBoolVectorTypes;
        public static readonly TypeSymbol[] AllIntVectorTypes;
        public static readonly TypeSymbol[] AllUintVectorTypes;
        public static readonly TypeSymbol[] AllFloatVectorTypes;
        public static readonly TypeSymbol[] AllDoubleVectorTypes;
        public static readonly TypeSymbol[] AllVectorTypes;

        public static readonly TypeSymbol[] AllBoolMatrixTypes;
        public static readonly TypeSymbol[] AllIntMatrixTypes;
        public static readonly TypeSymbol[] AllFloatMatrixTypes;
        public static readonly TypeSymbol[] AllDoubleMatrixTypes;
        public static readonly TypeSymbol[] AllMatrixTypes;

        public static readonly TypeSymbol[] AllBoolTypes;
        public static readonly TypeSymbol[] AllIntTypes;
        public static readonly TypeSymbol[] AllFloatTypes;
        public static readonly TypeSymbol[] AllDoubleTypes;
        public static readonly TypeSymbol[] AllNumericTypes;

        public static readonly TypeSymbol Sampler1D;
        public static readonly TypeSymbol Sampler2D;
        public static readonly TypeSymbol Sampler3D;
        public static readonly TypeSymbol SamplerCube;
        public static readonly TypeSymbol SamplerState;
        public static readonly TypeSymbol SamplerComparisonState;

        static IntrinsicTypes()
        {
            // Scalar types.
            Void = new IntrinsicTypeSymbol("void", "Represents a void value.");
            Bool = new IntrinsicTypeSymbol("bool", "Represents a boolean value.");
            Int = new IntrinsicTypeSymbol("int", "Represents a 32-bit signed integer value.");
            Uint = new IntrinsicTypeSymbol("uint", "Represents a 32-bit unsigned integer value.");
            Half = new IntrinsicTypeSymbol("half", "Represents a 16-bit floating point value.");
            Float = new IntrinsicTypeSymbol("float", "Represents a 32-bit floating point value.");
            Double = new IntrinsicTypeSymbol("double", "Represents a 64-bit floating point value.");

            // Vector types.
            Bool1 = new IntrinsicTypeSymbol("bool1", "Represents a vector containing 1 boolean component.",  t => CreateVectorTypeFields(1, Bool1, Bool, Bool2, Bool3, Bool4));
            Bool2 = new IntrinsicTypeSymbol("bool2", "Represents a vector containing 2 boolean components.", t => CreateVectorTypeFields(2, Bool2, Bool, Bool2, Bool3, Bool4));
            Bool3 = new IntrinsicTypeSymbol("bool3", "Represents a vector containing 3 boolean components.", t => CreateVectorTypeFields(3, Bool3, Bool, Bool2, Bool3, Bool4));
            Bool4 = new IntrinsicTypeSymbol("bool4", "Represents a vector containing 4 boolean components.", t => CreateVectorTypeFields(4, Bool4, Bool, Bool2, Bool3, Bool4));
            Int1 = new IntrinsicTypeSymbol("int1", "Represents a vector containing 1 signed integer component.",  t => CreateVectorTypeFields(1, Int1, Int, Int2, Int3, Int4));
            Int2 = new IntrinsicTypeSymbol("int2", "Represents a vector containing 2 signed integer components.", t => CreateVectorTypeFields(2, Int2, Int, Int2, Int3, Int4));
            Int3 = new IntrinsicTypeSymbol("int3", "Represents a vector containing 3 signed integer components.", t => CreateVectorTypeFields(3, Int3, Int, Int2, Int3, Int4));
            Int4 = new IntrinsicTypeSymbol("int4", "Represents a vector containing 4 signed integer components.", t => CreateVectorTypeFields(4, Int4, Int, Int2, Int3, Int4));
            Uint1 = new IntrinsicTypeSymbol("uint1", "Represents a vector containing 1 unsigned integer component.", t => CreateVectorTypeFields(1, Uint1, Uint, Uint2, Uint3, Uint4));
            Uint2 = new IntrinsicTypeSymbol("uint2", "Represents a vector containing 2 unsigned integer components.", t => CreateVectorTypeFields(2, Uint2, Uint, Uint2, Uint3, Uint4));
            Uint3 = new IntrinsicTypeSymbol("uint3", "Represents a vector containing 3 unsigned integer components.", t => CreateVectorTypeFields(3, Uint3, Uint, Uint2, Uint3, Uint4));
            Uint4 = new IntrinsicTypeSymbol("uint4", "Represents a vector containing 4 unsigned integer components.", t => CreateVectorTypeFields(4, Uint4, Uint, Uint2, Uint3, Uint4));
            Half1 = new IntrinsicTypeSymbol("half1", "Represents a vector containing 1 floating point component.",  t => CreateVectorTypeFields(1, Half1, Half, Half2, Half3, Half4));
            Half2 = new IntrinsicTypeSymbol("half2", "Represents a vector containing 2 floating point components.", t => CreateVectorTypeFields(2, Half2, Half, Half2, Half3, Half4));
            Half3 = new IntrinsicTypeSymbol("half3", "Represents a vector containing 3 floating point components.", t => CreateVectorTypeFields(3, Half3, Half, Half2, Half3, Half4));
            Half4 = new IntrinsicTypeSymbol("half4", "Represents a vector containing 4 floating point components.", t => CreateVectorTypeFields(4, Half4, Half, Half2, Half3, Half4));
            Float1 = new IntrinsicTypeSymbol("float1", "Represents a vector containing 1 floating point component.",  t => CreateVectorTypeFields(1, Float1, Float, Float2, Float3, Float4));
            Float2 = new IntrinsicTypeSymbol("float2", "Represents a vector containing 2 floating point components.", t => CreateVectorTypeFields(2, Float2, Float, Float2, Float3, Float4));
            Float3 = new IntrinsicTypeSymbol("float3", "Represents a vector containing 3 floating point components.", t => CreateVectorTypeFields(3, Float3, Float, Float2, Float3, Float4));
            Float4 = new IntrinsicTypeSymbol("float4", "Represents a vector containing 4 floating point components.", t => CreateVectorTypeFields(4, Float4, Float, Float2, Float3, Float4));
            Double1 = new IntrinsicTypeSymbol("double1", "Represents a vector containing 1 floating point component.",  t => CreateVectorTypeFields(1, Double1, Double, Double2, Double3, Double4));
            Double2 = new IntrinsicTypeSymbol("double2", "Represents a vector containing 2 floating point components.", t => CreateVectorTypeFields(2, Double2, Double, Double2, Double3, Double4));
            Double3 = new IntrinsicTypeSymbol("double3", "Represents a vector containing 3 floating point components.", t => CreateVectorTypeFields(3, Double3, Double, Double2, Double3, Double4));
            Double4 = new IntrinsicTypeSymbol("double4", "Represents a vector containing 4 floating point components.", t => CreateVectorTypeFields(4, Double4, Double, Double2, Double3, Double4));

            // Matrix types.
            Bool1x1 = new IntrinsicTypeSymbol("bool1x1", "Represents a matrix containing 1 row and 1 column.", t => CreateMatrixTypeMembers(1, 1, Bool1x1, Bool));
            Bool1x2 = new IntrinsicTypeSymbol("bool1x2", "Represents a matrix containing 1 row and 2 columns.", t => CreateMatrixTypeMembers(1, 2, Bool1x2, Bool));
            Bool1x3 = new IntrinsicTypeSymbol("bool1x3", "Represents a matrix containing 1 row and 3 columns.", t => CreateMatrixTypeMembers(1, 3, Bool1x3, Bool));
            Bool1x4 = new IntrinsicTypeSymbol("bool1x4", "Represents a matrix containing 1 row and 4 columns.", t => CreateMatrixTypeMembers(1, 4, Bool1x4, Bool));
            Bool2x1 = new IntrinsicTypeSymbol("bool2x1", "Represents a matrix containing 2 rows and 1 column.", t => CreateMatrixTypeMembers(2, 1, Bool2x1, Bool));
            Bool2x2 = new IntrinsicTypeSymbol("bool2x2", "Represents a matrix containing 2 rows and 2 columns.", t => CreateMatrixTypeMembers(2, 2, Bool2x2, Bool));
            Bool2x3 = new IntrinsicTypeSymbol("bool2x3", "Represents a matrix containing 2 rows and 3 columns.", t => CreateMatrixTypeMembers(2, 3, Bool2x3, Bool));
            Bool2x4 = new IntrinsicTypeSymbol("bool2x4", "Represents a matrix containing 2 rows and 4 columns.", t => CreateMatrixTypeMembers(2, 4, Bool2x4, Bool));
            Bool3x1 = new IntrinsicTypeSymbol("bool3x1", "Represents a matrix containing 3 rows and 1 column.", t => CreateMatrixTypeMembers(3, 1, Bool3x1, Bool));
            Bool3x2 = new IntrinsicTypeSymbol("bool3x2", "Represents a matrix containing 3 rows and 2 columns.", t => CreateMatrixTypeMembers(3, 2, Bool3x2, Bool));
            Bool3x3 = new IntrinsicTypeSymbol("bool3x3", "Represents a matrix containing 3 rows and 3 columns.", t => CreateMatrixTypeMembers(3, 3, Bool3x3, Bool));
            Bool3x4 = new IntrinsicTypeSymbol("bool3x4", "Represents a matrix containing 3 rows and 4 columns.", t => CreateMatrixTypeMembers(3, 4, Bool3x4, Bool));
            Bool4x1 = new IntrinsicTypeSymbol("bool4x1", "Represents a matrix containing 4 rows and 1 column.", t => CreateMatrixTypeMembers(4, 1, Bool4x1, Bool));
            Bool4x2 = new IntrinsicTypeSymbol("bool4x2", "Represents a matrix containing 4 rows and 2 columns.", t => CreateMatrixTypeMembers(4, 2, Bool4x2, Bool));
            Bool4x3 = new IntrinsicTypeSymbol("bool4x3", "Represents a matrix containing 4 rows and 3 columns.", t => CreateMatrixTypeMembers(4, 3, Bool4x3, Bool));
            Bool4x4 = new IntrinsicTypeSymbol("bool4x4", "Represents a matrix containing 4 rows and 4 columns.", t => CreateMatrixTypeMembers(4, 4, Bool4x4, Bool));
            Int1x1 = new IntrinsicTypeSymbol("int1x1", "Represents a matrix containing 1 row and 1 column.", t => CreateMatrixTypeMembers(1, 1, Int1x1, Int));
            Int1x2 = new IntrinsicTypeSymbol("int1x2", "Represents a matrix containing 1 row and 2 columns.", t => CreateMatrixTypeMembers(1, 2, Int1x2, Int));
            Int1x3 = new IntrinsicTypeSymbol("int1x3", "Represents a matrix containing 1 row and 3 columns.", t => CreateMatrixTypeMembers(1, 3, Int1x3, Int));
            Int1x4 = new IntrinsicTypeSymbol("int1x4", "Represents a matrix containing 1 row and 4 columns.", t => CreateMatrixTypeMembers(1, 4, Int1x4, Int));
            Int2x1 = new IntrinsicTypeSymbol("int2x1", "Represents a matrix containing 2 rows and 1 column.", t => CreateMatrixTypeMembers(2, 1, Int2x1, Int));
            Int2x2 = new IntrinsicTypeSymbol("int2x2", "Represents a matrix containing 2 rows and 2 columns.", t => CreateMatrixTypeMembers(2, 2, Int2x2, Int));
            Int2x3 = new IntrinsicTypeSymbol("int2x3", "Represents a matrix containing 2 rows and 3 columns.", t => CreateMatrixTypeMembers(2, 3, Int2x3, Int));
            Int2x4 = new IntrinsicTypeSymbol("int2x4", "Represents a matrix containing 2 rows and 4 columns.", t => CreateMatrixTypeMembers(2, 4, Int2x4, Int));
            Int3x1 = new IntrinsicTypeSymbol("int3x1", "Represents a matrix containing 3 rows and 1 column.", t => CreateMatrixTypeMembers(3, 1, Int3x1, Int));
            Int3x2 = new IntrinsicTypeSymbol("int3x2", "Represents a matrix containing 3 rows and 2 columns.", t => CreateMatrixTypeMembers(3, 2, Int3x2, Int));
            Int3x3 = new IntrinsicTypeSymbol("int3x3", "Represents a matrix containing 3 rows and 3 columns.", t => CreateMatrixTypeMembers(3, 3, Int3x3, Int));
            Int3x4 = new IntrinsicTypeSymbol("int3x4", "Represents a matrix containing 3 rows and 4 columns.", t => CreateMatrixTypeMembers(3, 4, Int3x4, Int));
            Int4x1 = new IntrinsicTypeSymbol("int4x1", "Represents a matrix containing 4 rows and 1 column.", t => CreateMatrixTypeMembers(4, 1, Int4x1, Int));
            Int4x2 = new IntrinsicTypeSymbol("int4x2", "Represents a matrix containing 4 rows and 2 columns.", t => CreateMatrixTypeMembers(4, 2, Int4x2, Int));
            Int4x3 = new IntrinsicTypeSymbol("int4x3", "Represents a matrix containing 4 rows and 3 columns.", t => CreateMatrixTypeMembers(4, 3, Int4x3, Int));
            Int4x4 = new IntrinsicTypeSymbol("int4x4", "Represents a matrix containing 4 rows and 4 columns.", t => CreateMatrixTypeMembers(4, 4, Int4x4, Int));
            Uint1x1 = new IntrinsicTypeSymbol("uint1x1", "Represents a matrix containing 1 row and 1 column.", t => CreateMatrixTypeMembers(1, 1, Uint1x1, Uint));
            Uint1x2 = new IntrinsicTypeSymbol("uint1x2", "Represents a matrix containing 1 row and 2 columns.", t => CreateMatrixTypeMembers(1, 2, Uint1x2, Uint));
            Uint1x3 = new IntrinsicTypeSymbol("uint1x3", "Represents a matrix containing 1 row and 3 columns.", t => CreateMatrixTypeMembers(1, 3, Uint1x3, Uint));
            Uint1x4 = new IntrinsicTypeSymbol("uint1x4", "Represents a matrix containing 1 row and 4 columns.", t => CreateMatrixTypeMembers(1, 4, Uint1x4, Uint));
            Uint2x1 = new IntrinsicTypeSymbol("uint2x1", "Represents a matrix containing 2 rows and 1 column.", t => CreateMatrixTypeMembers(2, 1, Uint2x1, Uint));
            Uint2x2 = new IntrinsicTypeSymbol("uint2x2", "Represents a matrix containing 2 rows and 2 columns.", t => CreateMatrixTypeMembers(2, 2, Uint2x2, Uint));
            Uint2x3 = new IntrinsicTypeSymbol("uint2x3", "Represents a matrix containing 2 rows and 3 columns.", t => CreateMatrixTypeMembers(2, 3, Uint2x3, Uint));
            Uint2x4 = new IntrinsicTypeSymbol("uint2x4", "Represents a matrix containing 2 rows and 4 columns.", t => CreateMatrixTypeMembers(2, 4, Uint2x4, Uint));
            Uint3x1 = new IntrinsicTypeSymbol("uint3x1", "Represents a matrix containing 3 rows and 1 column.", t => CreateMatrixTypeMembers(3, 1, Uint3x1, Uint));
            Uint3x2 = new IntrinsicTypeSymbol("uint3x2", "Represents a matrix containing 3 rows and 2 columns.", t => CreateMatrixTypeMembers(3, 2, Uint3x2, Uint));
            Uint3x3 = new IntrinsicTypeSymbol("uint3x3", "Represents a matrix containing 3 rows and 3 columns.", t => CreateMatrixTypeMembers(3, 3, Uint3x3, Uint));
            Uint3x4 = new IntrinsicTypeSymbol("uint3x4", "Represents a matrix containing 3 rows and 4 columns.", t => CreateMatrixTypeMembers(3, 4, Uint3x4, Uint));
            Uint4x1 = new IntrinsicTypeSymbol("uint4x1", "Represents a matrix containing 4 rows and 1 column.", t => CreateMatrixTypeMembers(4, 1, Uint4x1, Uint));
            Uint4x2 = new IntrinsicTypeSymbol("uint4x2", "Represents a matrix containing 4 rows and 2 columns.", t => CreateMatrixTypeMembers(4, 2, Uint4x2, Uint));
            Uint4x3 = new IntrinsicTypeSymbol("uint4x3", "Represents a matrix containing 4 rows and 3 columns.", t => CreateMatrixTypeMembers(4, 3, Uint4x3, Uint));
            Uint4x4 = new IntrinsicTypeSymbol("uint4x4", "Represents a matrix containing 4 rows and 4 columns.", t => CreateMatrixTypeMembers(4, 4, Uint4x4, Uint));
            Half1x1 = new IntrinsicTypeSymbol("half1x1", "Represents a matrix containing 1 row and 1 column.", t => CreateMatrixTypeMembers(1, 1, Half1x1, Half));
            Half1x2 = new IntrinsicTypeSymbol("half1x2", "Represents a matrix containing 1 row and 2 columns.", t => CreateMatrixTypeMembers(1, 2, Half1x2, Half));
            Half1x3 = new IntrinsicTypeSymbol("half1x3", "Represents a matrix containing 1 row and 3 columns.", t => CreateMatrixTypeMembers(1, 3, Half1x3, Half));
            Half1x4 = new IntrinsicTypeSymbol("half1x4", "Represents a matrix containing 1 row and 4 columns.", t => CreateMatrixTypeMembers(1, 4, Half1x4, Half));
            Half2x1 = new IntrinsicTypeSymbol("half2x1", "Represents a matrix containing 2 rows and 1 column.", t => CreateMatrixTypeMembers(2, 1, Half2x1, Half));
            Half2x2 = new IntrinsicTypeSymbol("half2x2", "Represents a matrix containing 2 rows and 2 columns.", t => CreateMatrixTypeMembers(2, 2, Half2x2, Half));
            Half2x3 = new IntrinsicTypeSymbol("half2x3", "Represents a matrix containing 2 rows and 3 columns.", t => CreateMatrixTypeMembers(2, 3, Half2x3, Half));
            Half2x4 = new IntrinsicTypeSymbol("half2x4", "Represents a matrix containing 2 rows and 4 columns.", t => CreateMatrixTypeMembers(2, 4, Half2x4, Half));
            Half3x1 = new IntrinsicTypeSymbol("half3x1", "Represents a matrix containing 3 rows and 1 column.", t => CreateMatrixTypeMembers(3, 1, Half3x1, Half));
            Half3x2 = new IntrinsicTypeSymbol("half3x2", "Represents a matrix containing 3 rows and 2 columns.", t => CreateMatrixTypeMembers(3, 2, Half3x2, Half));
            Half3x3 = new IntrinsicTypeSymbol("half3x3", "Represents a matrix containing 3 rows and 3 columns.", t => CreateMatrixTypeMembers(3, 3, Half3x3, Half));
            Half3x4 = new IntrinsicTypeSymbol("half3x4", "Represents a matrix containing 3 rows and 4 columns.", t => CreateMatrixTypeMembers(3, 4, Half3x4, Half));
            Half4x1 = new IntrinsicTypeSymbol("half4x1", "Represents a matrix containing 4 rows and 1 column.", t => CreateMatrixTypeMembers(4, 1, Half4x1, Half));
            Half4x2 = new IntrinsicTypeSymbol("half4x2", "Represents a matrix containing 4 rows and 2 columns.", t => CreateMatrixTypeMembers(4, 2, Half4x2, Half));
            Half4x3 = new IntrinsicTypeSymbol("half4x3", "Represents a matrix containing 4 rows and 3 columns.", t => CreateMatrixTypeMembers(4, 3, Half4x3, Half));
            Half4x4 = new IntrinsicTypeSymbol("half4x4", "Represents a matrix containing 4 rows and 4 columns.", t => CreateMatrixTypeMembers(4, 4, Half4x4, Half));
            Float1x1 = new IntrinsicTypeSymbol("float1x1", "Represents a matrix containing 1 row and 1 column.",  t => CreateMatrixTypeMembers(1, 1, Float1x1, Float));
            Float1x2 = new IntrinsicTypeSymbol("float1x2", "Represents a matrix containing 1 row and 2 columns.", t => CreateMatrixTypeMembers(1, 2, Float1x2, Float));
            Float1x3 = new IntrinsicTypeSymbol("float1x3", "Represents a matrix containing 1 row and 3 columns.", t => CreateMatrixTypeMembers(1, 3, Float1x3, Float));
            Float1x4 = new IntrinsicTypeSymbol("float1x4", "Represents a matrix containing 1 row and 4 columns.", t => CreateMatrixTypeMembers(1, 4, Float1x4, Float));
            Float2x1 = new IntrinsicTypeSymbol("float2x1", "Represents a matrix containing 2 rows and 1 column.",  t => CreateMatrixTypeMembers(2, 1, Float2x1, Float));
            Float2x2 = new IntrinsicTypeSymbol("float2x2", "Represents a matrix containing 2 rows and 2 columns.", t => CreateMatrixTypeMembers(2, 2, Float2x2, Float));
            Float2x3 = new IntrinsicTypeSymbol("float2x3", "Represents a matrix containing 2 rows and 3 columns.", t => CreateMatrixTypeMembers(2, 3, Float2x3, Float));
            Float2x4 = new IntrinsicTypeSymbol("float2x4", "Represents a matrix containing 2 rows and 4 columns.", t => CreateMatrixTypeMembers(2, 4, Float2x4, Float));
            Float3x1 = new IntrinsicTypeSymbol("float3x1", "Represents a matrix containing 3 rows and 1 column.",  t => CreateMatrixTypeMembers(3, 1, Float3x1, Float));
            Float3x2 = new IntrinsicTypeSymbol("float3x2", "Represents a matrix containing 3 rows and 2 columns.", t => CreateMatrixTypeMembers(3, 2, Float3x2, Float));
            Float3x3 = new IntrinsicTypeSymbol("float3x3", "Represents a matrix containing 3 rows and 3 columns.", t => CreateMatrixTypeMembers(3, 3, Float3x3, Float));
            Float3x4 = new IntrinsicTypeSymbol("float3x4", "Represents a matrix containing 3 rows and 4 columns.", t => CreateMatrixTypeMembers(3, 4, Float3x4, Float));
            Float4x1 = new IntrinsicTypeSymbol("float4x1", "Represents a matrix containing 4 rows and 1 column.",  t => CreateMatrixTypeMembers(4, 1, Float4x1, Float));
            Float4x2 = new IntrinsicTypeSymbol("float4x2", "Represents a matrix containing 4 rows and 2 columns.", t => CreateMatrixTypeMembers(4, 2, Float4x2, Float));
            Float4x3 = new IntrinsicTypeSymbol("float4x3", "Represents a matrix containing 4 rows and 3 columns.", t => CreateMatrixTypeMembers(4, 3, Float4x3, Float));
            Float4x4 = new IntrinsicTypeSymbol("float4x4", "Represents a matrix containing 4 rows and 4 columns.", t => CreateMatrixTypeMembers(4, 4, Float4x4, Float));
            Double1x1 = new IntrinsicTypeSymbol("double1x1", "Represents a matrix containing 1 row and 1 column.", t => CreateMatrixTypeMembers(1, 1, Double1x1, Double));
            Double1x2 = new IntrinsicTypeSymbol("double1x2", "Represents a matrix containing 1 row and 2 columns.", t => CreateMatrixTypeMembers(1, 2, Double1x2, Double));
            Double1x3 = new IntrinsicTypeSymbol("double1x3", "Represents a matrix containing 1 row and 3 columns.", t => CreateMatrixTypeMembers(1, 3, Double1x3, Double));
            Double1x4 = new IntrinsicTypeSymbol("double1x4", "Represents a matrix containing 1 row and 4 columns.", t => CreateMatrixTypeMembers(1, 4, Double1x4, Double));
            Double2x1 = new IntrinsicTypeSymbol("double2x1", "Represents a matrix containing 2 rows and 1 column.", t => CreateMatrixTypeMembers(2, 1, Double2x1, Double));
            Double2x2 = new IntrinsicTypeSymbol("double2x2", "Represents a matrix containing 2 rows and 2 columns.", t => CreateMatrixTypeMembers(2, 2, Double2x2, Double));
            Double2x3 = new IntrinsicTypeSymbol("double2x3", "Represents a matrix containing 2 rows and 3 columns.", t => CreateMatrixTypeMembers(2, 3, Double2x3, Double));
            Double2x4 = new IntrinsicTypeSymbol("double2x4", "Represents a matrix containing 2 rows and 4 columns.", t => CreateMatrixTypeMembers(2, 4, Double2x4, Double));
            Double3x1 = new IntrinsicTypeSymbol("double3x1", "Represents a matrix containing 3 rows and 1 column.", t => CreateMatrixTypeMembers(3, 1, Double3x1, Double));
            Double3x2 = new IntrinsicTypeSymbol("double3x2", "Represents a matrix containing 3 rows and 2 columns.", t => CreateMatrixTypeMembers(3, 2, Double3x2, Double));
            Double3x3 = new IntrinsicTypeSymbol("double3x3", "Represents a matrix containing 3 rows and 3 columns.", t => CreateMatrixTypeMembers(3, 3, Double3x3, Double));
            Double3x4 = new IntrinsicTypeSymbol("double3x4", "Represents a matrix containing 3 rows and 4 columns.", t => CreateMatrixTypeMembers(3, 4, Double3x4, Double));
            Double4x1 = new IntrinsicTypeSymbol("double4x1", "Represents a matrix containing 4 rows and 1 column.", t => CreateMatrixTypeMembers(4, 1, Double4x1, Double));
            Double4x2 = new IntrinsicTypeSymbol("double4x2", "Represents a matrix containing 4 rows and 2 columns.", t => CreateMatrixTypeMembers(4, 2, Double4x2, Double));
            Double4x3 = new IntrinsicTypeSymbol("double4x3", "Represents a matrix containing 4 rows and 3 columns.", t => CreateMatrixTypeMembers(4, 3, Double4x3, Double));
            Double4x4 = new IntrinsicTypeSymbol("double4x4", "Represents a matrix containing 4 rows and 4 columns.", t => CreateMatrixTypeMembers(4, 4, Double4x4, Double));

            AllScalarTypes = new[]
            {
                Bool,
                Uint,
                Int,
                Half,
                Float,
                Double
            };

            AllBoolVectorTypes = new[]
            {
                Bool1,
                Bool2,
                Bool3,
                Bool4
            };

            AllIntVectorTypes = new[]
            {
                Int1,
                Int2,
                Int3,
                Int4
            };

            AllUintVectorTypes = new[]
            {
                Uint1,
                Uint2,
                Uint3,
                Uint4
            };

            AllFloatVectorTypes = new[]
            {
                Float1,
                Float2,
                Float3,
                Float4
            };

            AllDoubleVectorTypes = new[]
            {
                Double1,
                Double2,
                Double3,
                Double4
            };

            AllVectorTypes = new[]
            {
                Bool1,
                Bool2,
                Bool3,
                Bool4,
                Int1,
                Int2,
                Int3,
                Int4,
                Uint1,
                Uint2,
                Uint3,
                Uint4,
                Half1,
                Half2,
                Half3,
                Half4,
                Float1,
                Float2,
                Float3,
                Float4,
                Double1,
                Double2,
                Double3,
                Double4
            };

            AllBoolMatrixTypes = new[]
            {
                Bool1x1,
                Bool1x2,
                Bool1x3,
                Bool1x4,
                Bool2x1,
                Bool2x2,
                Bool2x3,
                Bool2x4,
                Bool3x1,
                Bool3x2,
                Bool3x3,
                Bool3x4,
                Bool4x1,
                Bool4x2,
                Bool4x3,
                Bool4x4
            };

            AllIntMatrixTypes = new[]
            {
                Int1x1,
                Int1x2,
                Int1x3,
                Int1x4,
                Int2x1,
                Int2x2,
                Int2x3,
                Int2x4,
                Int3x1,
                Int3x2,
                Int3x3,
                Int3x4,
                Int4x1,
                Int4x2,
                Int4x3,
                Int4x4
            };

            AllFloatMatrixTypes = new[]
            {
                Float1x1,
                Float1x2,
                Float1x3,
                Float1x4,
                Float2x1,
                Float2x2,
                Float2x3,
                Float2x4,
                Float3x1,
                Float3x2,
                Float3x3,
                Float3x4,
                Float4x1,
                Float4x2,
                Float4x3,
                Float4x4
            };

            AllDoubleMatrixTypes = new[]
            {
                Double1x1,
                Double1x2,
                Double1x3,
                Double1x4,
                Double2x1,
                Double2x2,
                Double2x3,
                Double2x4,
                Double3x1,
                Double3x2,
                Double3x3,
                Double3x4,
                Double4x1,
                Double4x2,
                Double4x3,
                Double4x4
            };

            AllMatrixTypes = new[]
            {
                Bool1x1,
                Bool1x2,
                Bool1x3,
                Bool1x4,
                Bool2x1,
                Bool2x2,
                Bool2x3,
                Bool2x4,
                Bool3x1,
                Bool3x2,
                Bool3x3,
                Bool3x4,
                Bool4x1,
                Bool4x2,
                Bool4x3,
                Bool4x4,
                Int1x1,
                Int1x2,
                Int1x3,
                Int1x4,
                Int2x1,
                Int2x2,
                Int2x3,
                Int2x4,
                Int3x1,
                Int3x2,
                Int3x3,
                Int3x4,
                Int4x1,
                Int4x2,
                Int4x3,
                Int4x4,
                Uint1x1,
                Uint1x2,
                Uint1x3,
                Uint1x4,
                Uint2x1,
                Uint2x2,
                Uint2x3,
                Uint2x4,
                Uint3x1,
                Uint3x2,
                Uint3x3,
                Uint3x4,
                Uint4x1,
                Uint4x2,
                Uint4x3,
                Uint4x4,
                Half1x1,
                Half1x2,
                Half1x3,
                Half1x4,
                Half2x1,
                Half2x2,
                Half2x3,
                Half2x4,
                Half3x1,
                Half3x2,
                Half3x3,
                Half3x4,
                Half4x1,
                Half4x2,
                Half4x3,
                Half4x4,
                Float1x1,
                Float1x2,
                Float1x3,
                Float1x4,
                Float2x1,
                Float2x2,
                Float2x3,
                Float2x4,
                Float3x1,
                Float3x2,
                Float3x3,
                Float3x4,
                Float4x1,
                Float4x2,
                Float4x3,
                Float4x4,
                Double1x1,
                Double1x2,
                Double1x3,
                Double1x4,
                Double2x1,
                Double2x2,
                Double2x3,
                Double2x4,
                Double3x1,
                Double3x2,
                Double3x3,
                Double3x4,
                Double4x1,
                Double4x2,
                Double4x3,
                Double4x4
            };

            AllBoolTypes = new[] { Bool }
                .Union(AllBoolVectorTypes)
                .Union(AllBoolMatrixTypes)
                .ToArray();

            AllIntTypes = new[] { Int }
                .Union(AllIntVectorTypes)
                .Union(AllIntMatrixTypes)
                .ToArray();

            AllFloatTypes = new[] { Float }
                .Union(AllFloatVectorTypes)
                .Union(AllFloatMatrixTypes)
                .ToArray();

            AllDoubleTypes = new[] { Double }
                .Union(AllDoubleVectorTypes)
                .Union(AllDoubleMatrixTypes)
                .ToArray();

            AllNumericTypes = AllScalarTypes
                .Union(AllVectorTypes)
                .Union(AllMatrixTypes)
                .ToArray();

            Sampler1D = new IntrinsicTypeSymbol("sampler1D", "");
            Sampler2D = new IntrinsicTypeSymbol("sampler2D", "");
            Sampler3D = new IntrinsicTypeSymbol("sampler3D", "");
            SamplerCube = new IntrinsicTypeSymbol("samplerCUBE", "");
            SamplerState = new IntrinsicTypeSymbol("SamplerState", "");
            SamplerComparisonState = new IntrinsicTypeSymbol("SamplerComparisonState", "");
        }

        private static IEnumerable<FieldSymbol> CreateVectorTypeFields(int numComponents,
            TypeSymbol vectorType, TypeSymbol v1, TypeSymbol v2, TypeSymbol v3, TypeSymbol v4)
        {
            var componentNameSets = new[] { "xyzw", "rgba" }.Select(x => x.Substring(0, numComponents).ToCharArray()).ToList();
            var vectorTypes = new[] { v1, v2, v3, v4 };

            foreach (var componentNameSet in componentNameSets)
                for (var i = 0; i < 4; i++)
                    foreach (var namePermutation in GetComponentNamePermutations(componentNameSet, i + 1))
                        yield return new FieldSymbol(namePermutation, "", vectorType, vectorTypes[i]);
        }

        private static IEnumerable<string> GetComponentNamePermutations(char[] components, int num)
        {
            // for example:

            // components = ['x'], num = 1
            // => return ['x']

            // components = ['x'], num = 4
            // => return ['xxxx']

            // components = ['x', 'y'], num = 1
            // => return ['x', 'y']

            // components = ['x', 'y'], num = 2
            // => return ['xx', 'xy', 'yx', 'yy']

            // Yes, I probably should use some kind of clever code to generate the possible combinations.
            switch (num)
            {
                case 1:
                    return from a in components
                        select string.Concat(a);
                case 2:
                    return from a in components
                        from b in components
                        select string.Concat(a, b);
                case 3:
                    return from a in components
                        from b in components
                        from c in components
                        select string.Concat(a, b, c);
                case 4:
                    return from a in components
                        from b in components
                        from c in components
                        from d in components
                        select string.Concat(a, b, c, d);
                default :
                    throw new ArgumentOutOfRangeException("num");
            }
        }

        private static IEnumerable<MemberSymbol> CreateMatrixTypeMembers(int numRows, int numColumns, TypeSymbol matrixType, TypeSymbol fieldType)
        {
            // TODO: Support composite fields like _m00_m01.

            yield return new IndexerSymbol("[]", "", matrixType, fieldType);

            for (var row = 0; row < numRows; row++)
                for (var col = 0; col < numColumns; col++)
                {
                    yield return new FieldSymbol($"_m{row}{col}", "", matrixType, fieldType);
                    yield return new FieldSymbol($"_{row + 1}{col + 1}", "", matrixType, fieldType);
                }
        }

        public static TypeSymbol GetVectorType(ScalarType scalarType, int numComponents)
        {
            return AllVectorTypes[(((int)scalarType - 1) * 4) + numComponents];
        }

        public static TypeSymbol GetMatrixType(ScalarType scalarType, int numRows, int numCols)
        {
            return AllMatrixTypes[(((int)scalarType - 1) * 16) + (numRows * 4) + numCols];
        }

        public static IntrinsicTypeSymbol CreateTextureType(PredefinedObjectType textureType, TypeSymbol valueType, ScalarType scalarType)
        {
            string name, documentation;

            switch (textureType)
            {
                case PredefinedObjectType.Buffer:
                    name = "Buffer";
                    documentation = "A buffer type";
                    break;
                case PredefinedObjectType.Texture1D:
                    name = "Texture1D";
                    documentation = "A 1D texture type";
                    break;
                case PredefinedObjectType.Texture1DArray:
                    name = "Texture1DArray";
                    documentation = "An array of 1D textures";
                    break;
                case PredefinedObjectType.Texture2D:
                    name = "Texture2D";
                    documentation = "A 2D texture type";
                    break;
                case PredefinedObjectType.Texture2DArray:
                    name = "Texture2DArray";
                    documentation = "An array of 2D textures";
                    break;
                case PredefinedObjectType.Texture3D:
                    name = "Texture3D";
                    documentation = "A 3D texture type";
                    break;
                case PredefinedObjectType.TextureCube:
                    name = "TextureCube";
                    documentation = "A cube texture type";
                    break;
                case PredefinedObjectType.TextureCubeArray:
                    name = "TextureCubeArray";
                    documentation = "An array of cube textures";
                    break;
                case PredefinedObjectType.Texture2DMS:
                    name = "Texture2DMS";
                    documentation = "A 2D multisampled texture type";
                    break;
                case PredefinedObjectType.Texture2DMSArray:
                    name = "Texture2DMSArray";
                    documentation = "An array of 2D multisampled textures";
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return new IntrinsicTypeSymbol(name, documentation, t => CreateTextureMethods(textureType, t, valueType, scalarType));
        }

        private static IEnumerable<MethodDeclarationSymbol> CreateTextureMethods(PredefinedObjectType textureType, TypeSymbol parent, TypeSymbol valueType, ScalarType scalarType)
        {
            TypeSymbol locationType = null;
            switch (textureType)
            {
                case PredefinedObjectType.Texture1D:
                    locationType = Float;
                    break;
                case PredefinedObjectType.Texture1DArray:
                case PredefinedObjectType.Texture2D:
                    locationType = Float2;
                    break;
                case PredefinedObjectType.Texture2DArray:
                case PredefinedObjectType.Texture3D:
                case PredefinedObjectType.TextureCube:
                    locationType = Float3;
                    break;
                case PredefinedObjectType.TextureCubeArray:
                    locationType = Float4;
                    break;
            }

            TypeSymbol offsetType = null;
            switch (textureType)
            {
                case PredefinedObjectType.Texture1D:
                case PredefinedObjectType.Texture1DArray:
                    offsetType = Int;
                    break;
                case PredefinedObjectType.Texture2D:
                case PredefinedObjectType.Texture2DArray:
                case PredefinedObjectType.Texture2DMS:
                case PredefinedObjectType.Texture2DMSArray:
                    offsetType = Int2;
                    break;
                case PredefinedObjectType.Texture3D:
                    offsetType = Int3;
                    break;
            }

            switch (textureType)
            {
                case PredefinedObjectType.Buffer:
                case PredefinedObjectType.Texture2DMS:
                case PredefinedObjectType.Texture2DMSArray:
                    break;
                default:
                    TypeSymbol vectorType;
                    switch (textureType)
                    {
                        case PredefinedObjectType.Texture1D:
                        case PredefinedObjectType.Texture1DArray:
                            vectorType = Float1;
                            break;
                        case PredefinedObjectType.Texture2D:
                        case PredefinedObjectType.Texture2DArray:
                            vectorType = Float2;
                            break;
                        case PredefinedObjectType.Texture3D:
                        case PredefinedObjectType.TextureCube:
                        case PredefinedObjectType.TextureCubeArray:
                            vectorType = Float3;
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                    yield return new MethodDeclarationSymbol("CalculateLevelOfDetail", "Calculates the level of detail.", parent,
                        Float, m => new[]
                        {
                            new ParameterSymbol("samplerState", "A sampler state.", m, SamplerState),
                            new ParameterSymbol("x", "The linear interpolation value, which is a floating-point number between 0.0 and 1.0 inclusive.", m, vectorType)
                        });
                    yield return new MethodDeclarationSymbol("CalculateLevelOfDetailUnclamped", "Calculates the LOD without clamping the result.", parent,
                        Float, m => new[]
                        {
                            new ParameterSymbol("samplerState", "A sampler state.", m, SamplerState),
                            new ParameterSymbol("x", "The linear interpolation value, which is a floating-point number between 0.0 and 1.0 inclusive.", m, vectorType)
                        });
                    break;
            }

            switch (textureType)
            {
                case PredefinedObjectType.Texture2D:
                case PredefinedObjectType.Texture2DArray:
                case PredefinedObjectType.TextureCube:
                case PredefinedObjectType.TextureCubeArray:
                    yield return new MethodDeclarationSymbol("Gather", "Gets the four samples (red component only) that would be used for bilinear interpolation when sampling a texture.", parent,
                        GetVectorType(scalarType, 4), m => new[]
                        {
                            new ParameterSymbol("samplerState", "A sampler state.", m, SamplerState),
                            new ParameterSymbol("location", "The texture coordinates.", m, locationType)
                        });
                    if (textureType == PredefinedObjectType.Texture2D || textureType == PredefinedObjectType.Texture2DArray)
                    {
                        yield return new MethodDeclarationSymbol("Gather", "Gets the four samples (red component only) that would be used for bilinear interpolation when sampling a texture.", parent,
                            GetVectorType(scalarType, 4), m => new[]
                            {
                                new ParameterSymbol("samplerState", "A sampler state.", m, SamplerState),
                                new ParameterSymbol("location", "The texture coordinates.", m, locationType),
                                new ParameterSymbol("offset", "An optional texture coordinate offset, which can be used for any texture-object types. The offset is applied to the location before sampling.", m, offsetType)
                            });
                    }
                    break;
            }

            switch (textureType)
            {
                case PredefinedObjectType.Buffer:
                    yield return new MethodDeclarationSymbol("GetDimensions", "Gets the length of the buffer.", parent,
                        Void, m => new[]
                        {
                            new ParameterSymbol("dim", "The length, in bytes, of the buffer.", m, Uint, ParameterDirection.Out)
                        });
                    break;
                default:
                    yield return CreateTextureGetDimensionsWithMipLevelMethod(parent, textureType, Uint);
                    yield return CreateTextureGetDimensionsWithMipLevelMethod(parent, textureType, Float);
                    yield return CreateTextureGetDimensionsMethod(parent, textureType, Uint);
                    yield return CreateTextureGetDimensionsMethod(parent, textureType, Float);
                    break;
            }

            switch (textureType)
            {
                case PredefinedObjectType.Texture2DMS:
                case PredefinedObjectType.Texture2DMSArray:
                    yield return new MethodDeclarationSymbol("GetSamplePosition", "Gets the position of the specified sample.", parent,
                        Float2, m => new[]
                        {
                            new ParameterSymbol("sampleIndex", "The zero-based sample index.", m, Int)
                        });
                    break;
            }

            switch (textureType)
            {
                case PredefinedObjectType.Buffer:
                case PredefinedObjectType.TextureCube:
                case PredefinedObjectType.TextureCubeArray:
                    break;
                default:
                    TypeSymbol intLocationType;
                    switch (textureType)
                    {
                        case PredefinedObjectType.Buffer:
                            intLocationType = Int;
                            break;
                        case PredefinedObjectType.Texture1D:
                        case PredefinedObjectType.Texture2DMS:
                            intLocationType = Int2;
                            break;
                        case PredefinedObjectType.Texture1DArray:
                        case PredefinedObjectType.Texture2D:
                        case PredefinedObjectType.Texture2DMSArray:
                            intLocationType = Int3;
                            break;
                        case PredefinedObjectType.Texture2DArray:
                        case PredefinedObjectType.Texture3D:
                            intLocationType = Int4;
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                    yield return new MethodDeclarationSymbol("Load", "Reads texel data without any filtering or sampling.", parent,
                        valueType, m => new[]
                        {
                            new ParameterSymbol("location", "The texture coordinates; the last component specifies the mipmap level. This method uses a 0-based coordinate system and not a 0.0-1.0 UV system. ", m, intLocationType)
                        });
                    switch (textureType)
                    {
                        case PredefinedObjectType.Texture2DMS:
                        case PredefinedObjectType.Texture2DMSArray:
                            yield return new MethodDeclarationSymbol("Load", "Reads texel data without any filtering or sampling.", parent,
                                valueType, m => new[]
                                {
                                    new ParameterSymbol("location", "The texture coordinates; the last component specifies the mipmap level. This method uses a 0-based coordinate system and not a 0.0-1.0 UV system.", m, intLocationType),
                                    new ParameterSymbol("sampleIndex", "A sampling index.", m, Int),
                                    new ParameterSymbol("offset", "An offset applied to the texture coordinates before sampling.", m, offsetType)
                                });
                            break;
                        default:
                            yield return new MethodDeclarationSymbol("Load", "Reads texel data without any filtering or sampling.", parent,
                                valueType, m => new[]
                                {
                                    new ParameterSymbol("location", "The texture coordinates; the last component specifies the mipmap level. This method uses a 0-based coordinate system and not a 0.0-1.0 UV system.", m, intLocationType),
                                    new ParameterSymbol("offset", "An offset applied to the texture coordinates before sampling.", m, offsetType)
                                });
                            break;
                    }
                    break;
            }

            switch (textureType)
            {
                case PredefinedObjectType.Buffer:
                case PredefinedObjectType.Texture2DMS:
                case PredefinedObjectType.Texture2DMSArray:
                    break;
                default:
                    yield return new MethodDeclarationSymbol("Sample", "Samples a texture.", parent,
                        valueType, m => new[]
                        {
                            new ParameterSymbol("samplerState", "A sampler state.", m, SamplerState), 
                            new ParameterSymbol("location", "The texture coordinates.", m, locationType)
                        });
                    switch (textureType)
                    {
                        case PredefinedObjectType.TextureCube:
                        case PredefinedObjectType.TextureCubeArray:
                            break;
                        default:
                            yield return new MethodDeclarationSymbol("Sample", "Samples a texture.", parent,
                                valueType, m => new[]
                                {
                                    new ParameterSymbol("samplerState", "A sampler state.", m, SamplerState),
                                    new ParameterSymbol("location", "The texture coordinates.", m, locationType),
                                    new ParameterSymbol("offset", "A texture coordinate offset, which can be used for any texture-object type; the offset is applied to the location before sampling. Use an offset only at an integer miplevel; otherwise, you may get results that do not translate well to hardware.", m, offsetType)
                                });
                            break;
                    }
                    break;
            }

            switch (textureType)
            {
                case PredefinedObjectType.Buffer:
                case PredefinedObjectType.Texture2DMS:
                case PredefinedObjectType.Texture2DMSArray:
                    break;
                default:
                    yield return new MethodDeclarationSymbol("SampleBias", "Samples a texture, after applying the input bias to the mipmap level.", parent,
                        valueType, m => new[]
                        {
                            new ParameterSymbol("samplerState", "A sampler state.", m, SamplerState),
                            new ParameterSymbol("location", "The texture coordinates.", m, locationType),
                            new ParameterSymbol("bias", "The bias value, which is a floating-point number between 0.0 and 1.0 inclusive, is applied to a mip level before sampling.", m, Float)
                        });
                    switch (textureType)
                    {
                        case PredefinedObjectType.TextureCube:
                        case PredefinedObjectType.TextureCubeArray:
                            break;
                        default:
                            yield return new MethodDeclarationSymbol("SampleBias", "Samples a texture, after applying the input bias to the mipmap level.", parent,
                                valueType, m => new[]
                                {
                                    new ParameterSymbol("samplerState", "A sampler state.", m, SamplerState),
                                    new ParameterSymbol("location", "The texture coordinates.", m, locationType),
                                    new ParameterSymbol("bias", "The bias value, which is a floating-point number between 0.0 and 1.0 inclusive, is applied to a mip level before sampling.", m, Float),
                                    new ParameterSymbol("offset", "A texture coordinate offset, which can be used for any texture-object type; the offset is applied to the location before sampling. Use an offset only at an integer miplevel; otherwise, you may get results that do not translate well to hardware.", m, offsetType)
                                });
                            break;
                    }
                    break;
            }

            switch (textureType)
            {
                case PredefinedObjectType.Buffer:
                case PredefinedObjectType.Texture2DMS:
                case PredefinedObjectType.Texture2DMSArray:
                case PredefinedObjectType.Texture3D:
                    break;
                default:
                    yield return new MethodDeclarationSymbol("SampleCmp", "Samples a texture and compares a single component against the specified comparison value.", parent,
                        valueType, m => new[]
                        {
                            new ParameterSymbol("samplerState", "A sampler-comparison state, which is the sampler state plus a comparison state (a comparison function and a comparison filter)", m, SamplerComparisonState),
                            new ParameterSymbol("location", "The texture coordinates.", m, locationType),
                            new ParameterSymbol("compareValue", "A floating-point value to use as a comparison value.", m, Float)
                        });
                    yield return new MethodDeclarationSymbol("SampleCmpLevelZero", "Samples a texture on mipmap level 0 only and compares a single component against the specified comparison value.", parent,
                        valueType, m => new[]
                        {
                            new ParameterSymbol("samplerState", "A sampler-comparison state, which is the sampler state plus a comparison state (a comparison function and a comparison filter)", m, SamplerComparisonState),
                            new ParameterSymbol("location", "The texture coordinates.", m, locationType),
                            new ParameterSymbol("compareValue", "A floating-point value to use as a comparison value.", m, Float)
                        });
                    switch (textureType)
                    {
                        case PredefinedObjectType.TextureCube:
                        case PredefinedObjectType.TextureCubeArray:
                            break;
                        default:
                            yield return new MethodDeclarationSymbol("SampleCmp", "Samples a texture and compares a single component against the specified comparison value.", parent,
                                valueType, m => new[]
                                {
                                    new ParameterSymbol("samplerState", "A sampler-comparison state, which is the sampler state plus a comparison state (a comparison function and a comparison filter)", m, SamplerComparisonState),
                                    new ParameterSymbol("location", "The texture coordinates.", m, locationType),
                                    new ParameterSymbol("compareValue", "A floating-point value to use as a comparison value.", m, Float),
                                    new ParameterSymbol("offset", "A texture coordinate offset, which can be used for any texture-object type; the offset is applied to the location before sampling. Use an offset only at an integer miplevel; otherwise, you may get results that do not translate well to hardware.", m, offsetType)
                                });
                            yield return new MethodDeclarationSymbol("SampleCmpLevelZero", "Samples a texture on mipmap level 0 only and compares a single component against the specified comparison value.", parent,
                                valueType, m => new[]
                                {
                                    new ParameterSymbol("samplerState", "A sampler-comparison state, which is the sampler state plus a comparison state (a comparison function and a comparison filter)", m, SamplerComparisonState),
                                    new ParameterSymbol("location", "The texture coordinates.", m, locationType),
                                    new ParameterSymbol("compareValue", "A floating-point value to use as a comparison value.", m, Float),
                                    new ParameterSymbol("offset", "A texture coordinate offset, which can be used for any texture-object type; the offset is applied to the location before sampling. Use an offset only at an integer miplevel; otherwise, you may get results that do not translate well to hardware.", m, offsetType)
                                });
                            break;
                    }
                    break;
            }

            switch (textureType)
            {
                case PredefinedObjectType.Buffer:
                case PredefinedObjectType.Texture2DMS:
                case PredefinedObjectType.Texture2DMSArray:
                    break;
                default:
                    TypeSymbol ddType;
                    switch (textureType)
                    {
                        case PredefinedObjectType.Texture1D:
                        case PredefinedObjectType.Texture1DArray:
                            ddType = Float;
                            break;
                        case PredefinedObjectType.Texture2D:
                        case PredefinedObjectType.Texture2DArray:
                            ddType = Float2;
                            break;
                        case PredefinedObjectType.Texture3D:
                        case PredefinedObjectType.TextureCube:
                        case PredefinedObjectType.TextureCubeArray:
                            ddType = Float3;
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                    yield return new MethodDeclarationSymbol("SampleGrad", "Samples a texture using a gradient to influence the way the sample location is calculated.", parent,
                        valueType, m => new[]
                        {
                            new ParameterSymbol("samplerState", "A sampler state.", m, SamplerState),
                            new ParameterSymbol("location", "The texture coordinates.", m, locationType),
                            new ParameterSymbol("ddx", "The rate of change of the surface geometry in the x direction.", m, ddType),
                            new ParameterSymbol("ddy", "The rate of change of the surface geometry in the y direction.", m, ddType)
                        });
                    switch (textureType)
                    {
                        case PredefinedObjectType.TextureCube:
                        case PredefinedObjectType.TextureCubeArray:
                            break;
                        default:
                            yield return new MethodDeclarationSymbol("SampleGrad", "Samples a texture using a gradient to influence the way the sample location is calculated.", parent,
                                valueType, m => new[]
                                {
                                    new ParameterSymbol("samplerState", "A sampler state.", m, SamplerState),
                                    new ParameterSymbol("location", "The texture coordinates.", m, locationType),
                                    new ParameterSymbol("ddx", "The rate of change of the surface geometry in the x direction.", m, ddType),
                                    new ParameterSymbol("ddy", "The rate of change of the surface geometry in the y direction.", m, ddType),
                                    new ParameterSymbol("offset", "A texture coordinate offset, which can be used for any texture-object type; the offset is applied to the location before sampling. Use an offset only at an integer miplevel; otherwise, you may get results that do not translate well to hardware.", m, offsetType)
                                });
                            break;
                    }
                    break;
            }

            switch (textureType)
            {
                case PredefinedObjectType.Buffer:
                case PredefinedObjectType.Texture2DMS:
                case PredefinedObjectType.Texture2DMSArray:
                    break;
                default:
                    yield return new MethodDeclarationSymbol("SampleLevel", "Samples a texture using a mipmap-level offset.", parent,
                        valueType, m => new[]
                        {
                            new ParameterSymbol("samplerState", "A sampler state.", m, SamplerState),
                            new ParameterSymbol("location", "The texture coordinates.", m, locationType),
                            new ParameterSymbol("lod", "A number that specifies the mipmap level. If the value is ≤ 0, the zero'th (biggest map) is used. The fractional value (if supplied) is used to interpolate between two mipmap levels.", m, Float)
                        });
                    switch (textureType)
                    {
                        case PredefinedObjectType.TextureCube:
                        case PredefinedObjectType.TextureCubeArray:
                            break;
                        default:
                            yield return new MethodDeclarationSymbol("SampleLevel", "Samples a texture using a mipmap-level offset.", parent,
                                valueType, m => new[]
                                {
                                    new ParameterSymbol("samplerState", "A sampler state.", m, SamplerState),
                                    new ParameterSymbol("location", "The texture coordinates.", m, locationType),
                                    new ParameterSymbol("lod", "A number that specifies the mipmap level. If the value is ≤ 0, the zero'th (biggest map) is used. The fractional value (if supplied) is used to interpolate between two mipmap levels.", m, Float),
                                    new ParameterSymbol("offset", "A texture coordinate offset, which can be used for any texture-object type; the offset is applied to the location before sampling. Use an offset only at an integer miplevel; otherwise, you may get results that do not translate well to hardware.", m, offsetType)
                                });
                            break;
                    }
                    break;
            }
        }

        private static MethodDeclarationSymbol CreateTextureGetDimensionsWithMipLevelMethod(TypeSymbol parent, PredefinedObjectType textureType, TypeSymbol parameterType)
        {
            return new MethodDeclarationSymbol("GetDimensions", "Gets texture size information.", parent,
                Void, m =>
                {
                    var result = new List<ParameterSymbol>();
                    result.Add(new ParameterSymbol("mipLevel", "A zero-based index that identifies the mipmap level.", m, Uint));
                    result.Add(new ParameterSymbol("width", "The texture width, in texels.", m, parameterType, ParameterDirection.Out));
                    switch (textureType)
                    {
                        case PredefinedObjectType.Texture2D:
                        case PredefinedObjectType.Texture2DArray:
                        case PredefinedObjectType.Texture3D:
                        case PredefinedObjectType.TextureCube:
                        case PredefinedObjectType.TextureCubeArray:
                            result.Add(new ParameterSymbol("height", "The texture height, in texels.", m, parameterType, ParameterDirection.Out));
                            break;
                    }
                    switch (textureType)
                    {
                        case PredefinedObjectType.Texture3D:
                            result.Add(new ParameterSymbol("depth", "The texture depth, in texels.", m, parameterType, ParameterDirection.Out));
                            break;
                    }
                    switch (textureType)
                    {
                        case PredefinedObjectType.Texture1DArray:
                        case PredefinedObjectType.Texture2DArray:
                        case PredefinedObjectType.TextureCubeArray:
                            result.Add(new ParameterSymbol("elements", "The number of elements in an array.", m, parameterType, ParameterDirection.Out));
                            break;
                    }
                    result.Add(new ParameterSymbol("numberOfLevels", "The number of mipmap levels.", m, parameterType, ParameterDirection.Out));
                    return result;
                });
        }

        private static MethodDeclarationSymbol CreateTextureGetDimensionsMethod(TypeSymbol parent, PredefinedObjectType textureType, TypeSymbol parameterType)
        {
            return new MethodDeclarationSymbol("GetDimensions", "Gets texture size information.", parent,
                Void, m =>
                {
                    var result = new List<ParameterSymbol>();
                    result.Add(new ParameterSymbol("width", "The texture width, in texels.", m, parameterType, ParameterDirection.Out));
                    switch (textureType)
                    {
                        case PredefinedObjectType.Texture2D:
                        case PredefinedObjectType.Texture2DArray:
                        case PredefinedObjectType.Texture3D:
                        case PredefinedObjectType.TextureCube:
                        case PredefinedObjectType.TextureCubeArray:
                            result.Add(new ParameterSymbol("height", "The texture height, in texels.", m, parameterType, ParameterDirection.Out));
                            break;
                    }
                    switch (textureType)
                    {
                        case PredefinedObjectType.Texture3D:
                            result.Add(new ParameterSymbol("depth", "The texture depth, in texels.", m, parameterType, ParameterDirection.Out));
                            break;
                    }
                    switch (textureType)
                    {
                        case PredefinedObjectType.Texture1DArray:
                        case PredefinedObjectType.Texture2DArray:
                        case PredefinedObjectType.TextureCubeArray:
                            result.Add(new ParameterSymbol("elements", "The number of elements in an array.", m, parameterType, ParameterDirection.Out));
                            break;
                    }
                    return result;
                });
        }

        public static TypeSymbol CreateAppendStructuredBufferType(TypeSymbol valueType)
        {
            return new IntrinsicTypeSymbol("AppendStructuredBuffer",
                "Output buffer that appears as a stream the shader may append to. Only structured buffers can take T types that are structures.",
                t => new[]
                {
                    new MethodDeclarationSymbol("Append", "Appends a value to the end of the buffer.", t, Void,
                        m => new[]
                        {
                            new ParameterSymbol("value", "The input value.", m, valueType)
                        }),
                    new MethodDeclarationSymbol("GetDimensions", "Gets the resource dimensions.", t, Void,
                        m => new[]
                        {
                            new ParameterSymbol("numStructs", "The number of structures.", m, Uint, ParameterDirection.Out),
                            new ParameterSymbol("stride", "The number of bytes in each element.", m, Uint, ParameterDirection.Out)
                        })
                });
        }

        public static TypeSymbol CreateByteAddressBufferType()
        {
            return new IntrinsicTypeSymbol("ByteAddressBuffer",
                "A read-only buffer that is indexed in bytes.",
                t => new[]
                {
                    new MethodDeclarationSymbol("GetDimensions", "Gets the resource dimensions.", t, Void,
                        m => new[]
                        {
                            new ParameterSymbol("dim", "The length, in bytes, of the buffer.", m, Uint, ParameterDirection.Out)
                        }),
                    new MethodDeclarationSymbol("Load", "Gets one value and the status of the operation from a read-only buffer indexed in bytes.", t, Uint,
                        m => new[]
                        {
                            new ParameterSymbol("location", "The input address in bytes, which must be a multiple of 4.", m, Int),
                            new ParameterSymbol("status", "The status of the operation.", m, Uint, ParameterDirection.Out)
                        }),
                    new MethodDeclarationSymbol("Load", "Gets one value from a read-only buffer indexed in bytes.", t, Uint,
                        m => new[]
                        {
                            new ParameterSymbol("location", "The input address in bytes, which must be a multiple of 4.", m, Int)
                        }),
                    new MethodDeclarationSymbol("Load2", "Gets two values and the status of the operation from a read-only buffer indexed in bytes.", t, Uint2,
                        m => new[]
                        {
                            new ParameterSymbol("location", "The input address in bytes, which must be a multiple of 4.", m, Int),
                            new ParameterSymbol("status", "The status of the operation.", m, Uint, ParameterDirection.Out)
                        }),
                    new MethodDeclarationSymbol("Load2", "Gets two values from a read-only buffer indexed in bytes.", t, Uint2,
                        m => new[]
                        {
                            new ParameterSymbol("location", "The input address in bytes, which must be a multiple of 4.", m, Int)
                        }),
                    new MethodDeclarationSymbol("Load3", "Gets three values and the status of the operation from a read-only buffer indexed in bytes.", t, Uint3,
                        m => new[]
                        {
                            new ParameterSymbol("location", "The input address in bytes, which must be a multiple of 4.", m, Int),
                            new ParameterSymbol("status", "The status of the operation.", m, Uint, ParameterDirection.Out)
                        }),
                    new MethodDeclarationSymbol("Load3", "Gets three values from a read-only buffer indexed in bytes.", t, Uint3,
                        m => new[]
                        {
                            new ParameterSymbol("location", "The input address in bytes, which must be a multiple of 4.", m, Int)
                        }),
                    new MethodDeclarationSymbol("Load4", "Gets four values and the status of the operation from a read-only buffer indexed in bytes.", t, Uint4,
                        m => new[]
                        {
                            new ParameterSymbol("location", "The input address in bytes, which must be a multiple of 4.", m, Int),
                            new ParameterSymbol("status", "The status of the operation.", m, Uint, ParameterDirection.Out)
                        }),
                    new MethodDeclarationSymbol("Load4", "Gets four values from a read-only buffer indexed in bytes.", t, Uint4,
                        m => new[]
                        {
                            new ParameterSymbol("location", "The input address in bytes, which must be a multiple of 4.", m, Int)
                        }),
                });
        }

        public static TypeSymbol CreateConsumeStructuredBufferType(TypeSymbol valueType)
        {
            return new IntrinsicTypeSymbol("ConsumeStructuredBuffer",
                "An input buffer that appears as a stream the shader may pull values from. Only structured buffers can take T types that are structures.",
                t => new[]
                {
                    new MethodDeclarationSymbol("Consume", "Removes a value from the end of the buffer.", t, valueType,
                        m => Enumerable.Empty<ParameterSymbol>()),
                    new MethodDeclarationSymbol("GetDimensions", "Gets the resource dimensions.", t, Void,
                        m => new[]
                        {
                            new ParameterSymbol("numStructs", "The number of structures.", m, Uint, ParameterDirection.Out),
                            new ParameterSymbol("stride", "The number of bytes in each element.", m, Uint, ParameterDirection.Out)
                        })
                });
        }

        public static TypeSymbol CreateStructuredBufferType(TypeSymbol valueType)
        {
            return new IntrinsicTypeSymbol("StructuredBuffer",
                "A read-only buffer, which can take a T type that is a structure.",
                t => new[]
                {
                    new MethodDeclarationSymbol("GetDimensions", "Gets the resource dimensions.", t, Void,
                        m => new[]
                        {
                            new ParameterSymbol("numStructs", "The number of structures.", m, Uint, ParameterDirection.Out),
                            new ParameterSymbol("stride", "The number of bytes in each element.", m, Uint, ParameterDirection.Out)
                        }),
                    new MethodDeclarationSymbol("Load", "Reads buffer data and returns status about the operation.", t, valueType,
                        m => new[]
                        {
                            new ParameterSymbol("location", "The location of the buffer.", m, Int),
                            new ParameterSymbol("status", "The status of the operation.", m, Uint, ParameterDirection.Out)
                        }),
                    new MethodDeclarationSymbol("Load", "Reads buffer data.", t, valueType,
                        m => new[]
                        {
                            new ParameterSymbol("location", "The location of the buffer.", m, Int)
                        }),
                });
        }
    }
}