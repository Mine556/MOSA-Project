// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

using System.Collections.Generic;

namespace Mosa.Compiler.Framework.Transform.Auto
{
	/// <summary>
	/// Transformations
	/// </summary>
	public static class AutoTransforms
	{
		public static readonly List<BaseTransformation> List = new List<BaseTransformation> {
			AutoInstance.IR_ConstantFolding_Add32,
			AutoInstance.IR_ConstantFolding_Add64,
			AutoInstance.IR_ConstantFolding_AddR4,
			AutoInstance.IR_ConstantFolding_AddR8,
			AutoInstance.IR_ConstantFolding_AddCarryIn32,
			AutoInstance.IR_ConstantFolding_AddCarryIn64,
			AutoInstance.IR_ConstantFolding_ShiftRight32,
			AutoInstance.IR_ConstantFolding_ShiftRight64,
			AutoInstance.IR_ConstantFolding_ShiftLeft32,
			AutoInstance.IR_ConstantFolding_ShiftLeft64,
			AutoInstance.IR_ConstantFolding_DivUnsigned32,
			AutoInstance.IR_ConstantFolding_DivUnsigned64,
			AutoInstance.IR_ConstantFolding_DivSigned32,
			AutoInstance.IR_ConstantFolding_DivSigned64,
			AutoInstance.IR_ConstantFolding_DivR4,
			AutoInstance.IR_ConstantFolding_DivR8,
			AutoInstance.IR_ConstantFolding_And32,
			AutoInstance.IR_ConstantFolding_And64,
			AutoInstance.IR_ConstantFolding_Or32,
			AutoInstance.IR_ConstantFolding_Or64,
			AutoInstance.IR_ConstantFolding_Xor32,
			AutoInstance.IR_ConstantFolding_Xor64,
			AutoInstance.IR_ConstantFolding_Not32,
			AutoInstance.IR_ConstantFolding_Not64,
			AutoInstance.IR_ConstantFolding_MulUnsigned32,
			AutoInstance.IR_ConstantFolding_MulUnsigned64,
			AutoInstance.IR_ConstantFolding_MulSigned32,
			AutoInstance.IR_ConstantFolding_MulSigned64,
			AutoInstance.IR_ConstantFolding_MulR4,
			AutoInstance.IR_ConstantFolding_MulR8,
			AutoInstance.IR_ConstantFolding_RemUnsigned32,
			AutoInstance.IR_ConstantFolding_RemUnsigned64,
			AutoInstance.IR_ConstantFolding_RemSigned32,
			AutoInstance.IR_ConstantFolding_RemSigned64,
			AutoInstance.IR_ConstantFolding_RemR4,
			AutoInstance.IR_ConstantFolding_RemR8,
			AutoInstance.IR_ConstantFolding_Sub32,
			AutoInstance.IR_ConstantFolding_Sub64,
			AutoInstance.IR_ConstantFolding_SubR4,
			AutoInstance.IR_ConstantFolding_SubR8,
			AutoInstance.IR_ConstantFolding_SubCarryIn32,
			AutoInstance.IR_ConstantFolding_SubCarryIn64,
			AutoInstance.IR_ConstantFolding_IfThenElse32AlwaysTrue,
			AutoInstance.IR_ConstantFolding_IfThenElse64AlwaysTrue,
			AutoInstance.IR_ConstantFolding_IfThenElse32AlwaysFalse,
			AutoInstance.IR_ConstantFolding_IfThenElse64AlwaysFalse,
			AutoInstance.IR_ConstantFolding_SignExtend16x32,
			AutoInstance.IR_ConstantFolding_SignExtend16x64,
			AutoInstance.IR_ConstantFolding_SignExtend32x64,
			AutoInstance.IR_ConstantFolding_SignExtend8x32,
			AutoInstance.IR_ConstantFolding_SignExtend8x64,
			AutoInstance.IR_ConstantFolding_ZeroExtend16x32,
			AutoInstance.IR_ConstantFolding_ZeroExtend16x64,
			AutoInstance.IR_ConstantFolding_ZeroExtend32x64,
			AutoInstance.IR_ConstantFolding_ZeroExtend8x32,
			AutoInstance.IR_ConstantFolding_ZeroExtend8x64,
			AutoInstance.IR_ConstantFolding_Convert32ToR4,
			AutoInstance.IR_ConstantFolding_Convert32ToR8,
			AutoInstance.IR_ConstantFolding_Convert64ToR4,
			AutoInstance.IR_ConstantFolding_Convert64ToR8,
			AutoInstance.IR_ConstantFolding_GetHigh64,
			AutoInstance.IR_ConstantFolding_GetLow64,
			AutoInstance.IR_ConstantFolding_To64,
			AutoInstance.IR_ConstantMove_Add32,
			AutoInstance.IR_ConstantMove_Add64,
			AutoInstance.IR_ConstantMove_AddR4,
			AutoInstance.IR_ConstantMove_AddR8,
			AutoInstance.IR_ConstantMove_MulSigned32,
			AutoInstance.IR_ConstantMove_MulSigned64,
			AutoInstance.IR_ConstantMove_MulUnsigned32,
			AutoInstance.IR_ConstantMove_MulUnsigned64,
			AutoInstance.IR_ConstantMove_MulR4,
			AutoInstance.IR_ConstantMove_MulR8,
			AutoInstance.IR_ConstantMove_And32,
			AutoInstance.IR_ConstantMove_And64,
			AutoInstance.IR_ConstantMove_Or32,
			AutoInstance.IR_ConstantMove_Or64,
			AutoInstance.IR_ConstantMove_Xor32,
			AutoInstance.IR_ConstantMove_Xor64,
			AutoInstance.IR_Simplification_Move32Propagation,
			AutoInstance.IR_Simplification_Move64Propagation,
			AutoInstance.IR_Simplification_Not32Twice,
			AutoInstance.IR_Simplification_Not64Twice,
			AutoInstance.IR_Simplification_GetLow64FromTo64,
			AutoInstance.IR_Simplification_GetHigh64FromTo64,
			AutoInstance.IR_Simplification_GetHigh64To64,
			AutoInstance.IR_Simplification_GetLow64To64,
			AutoInstance.IR_Simplification_To64FromLowHigh,
			AutoInstance.IR_Simplification_GetLow64FromShiftedRight32,
			AutoInstance.IR_Simplification_GetLow64FromRightShiftAndTo64,
			AutoInstance.IR_Simplification_GetHigh64FromRightLeftAndTo64,
			AutoInstance.IR_Simplification_GetHigh64FromShiftedMore32,
			AutoInstance.IR_Simplification_GetLow64FromShiftedMore32,
			AutoInstance.IR_Simplification_Truncate64x32Add64FromZeroExtended32x64,
			AutoInstance.IR_Simplification_Truncate64x32Sub64FromZeroExtended32x64,
			AutoInstance.IR_Simplification_Truncate64x32MulUnsigned64FromZeroExtended32x64,
			AutoInstance.IR_Simplification_Truncate64x32And64FromZeroExtended32x64,
			AutoInstance.IR_Simplification_Truncate64x32Or64FromZeroExtended32x64,
			AutoInstance.IR_Simplification_Truncate64x32Xor64FromZeroExtended32x64,
			AutoInstance.IR_Simplification_Add32MultipleWithCommon,
			AutoInstance.IR_Simplification_Add64MultipleWithCommon,
			AutoInstance.IR_Simplification_Sub32MultipleWithCommon,
			AutoInstance.IR_Simplification_Sub64MultipleWithCommon,
			AutoInstance.IR_Simplification_And32Not32Not32,
			AutoInstance.IR_Simplification_And64Not64Not64,
			AutoInstance.IR_Simplification_Or32Not32Not32,
			AutoInstance.IR_Simplification_Or64Not64Not64,
			AutoInstance.IR_StrengthReduction_Add32Zero,
			AutoInstance.IR_StrengthReduction_Add32Zero_v1,
			AutoInstance.IR_StrengthReduction_Add64Zero,
			AutoInstance.IR_StrengthReduction_Add64Zero_v1,
			AutoInstance.IR_StrengthReduction_And32Zero,
			AutoInstance.IR_StrengthReduction_And32Zero_v1,
			AutoInstance.IR_StrengthReduction_And64Zero,
			AutoInstance.IR_StrengthReduction_And64Zero_v1,
			AutoInstance.IR_StrengthReduction_And32Max,
			AutoInstance.IR_StrengthReduction_And32Max_v1,
			AutoInstance.IR_StrengthReduction_And64Max,
			AutoInstance.IR_StrengthReduction_And64Max_v1,
			AutoInstance.IR_StrengthReduction_Or32Max,
			AutoInstance.IR_StrengthReduction_Or32Max_v1,
			AutoInstance.IR_StrengthReduction_Or64Max,
			AutoInstance.IR_StrengthReduction_Or64Max_v1,
			AutoInstance.IR_StrengthReduction_Or32Zero,
			AutoInstance.IR_StrengthReduction_Or32Zero_v1,
			AutoInstance.IR_StrengthReduction_Or64Zero,
			AutoInstance.IR_StrengthReduction_Or64Zero_v1,
			AutoInstance.IR_StrengthReduction_Xor32Zero,
			AutoInstance.IR_StrengthReduction_Xor32Zero_v1,
			AutoInstance.IR_StrengthReduction_Xor64Zero,
			AutoInstance.IR_StrengthReduction_Xor64Zero_v1,
			AutoInstance.IR_StrengthReduction_Xor32Max,
			AutoInstance.IR_StrengthReduction_Xor32Max_v1,
			AutoInstance.IR_StrengthReduction_Xor64Max,
			AutoInstance.IR_StrengthReduction_Xor64Max_v1,
			AutoInstance.IR_StrengthReduction_ShiftRight32ZeroValue,
			AutoInstance.IR_StrengthReduction_ShiftRight64ZeroValue,
			AutoInstance.IR_StrengthReduction_ShiftRight32ByZero,
			AutoInstance.IR_StrengthReduction_ShiftRight64ByZero,
			AutoInstance.IR_StrengthReduction_ShiftLeft32ByZero,
			AutoInstance.IR_StrengthReduction_ShiftLeft64ByZero,
			AutoInstance.IR_StrengthReduction_Sub32ByZero,
			AutoInstance.IR_StrengthReduction_Sub64ByZero,
			AutoInstance.IR_StrengthReduction_Sub32Same,
			AutoInstance.IR_StrengthReduction_Sub64Same,
			AutoInstance.IR_StrengthReduction_Xor32Same,
			AutoInstance.IR_StrengthReduction_Xor64Same,
			AutoInstance.IR_StrengthReduction_MulSigned32ByZero,
			AutoInstance.IR_StrengthReduction_MulSigned32ByZero_v1,
			AutoInstance.IR_StrengthReduction_MulSigned64ByZero,
			AutoInstance.IR_StrengthReduction_MulSigned64ByZero_v1,
			AutoInstance.IR_StrengthReduction_MulUnsigned32ByZero,
			AutoInstance.IR_StrengthReduction_MulUnsigned32ByZero_v1,
			AutoInstance.IR_StrengthReduction_MulUnsigned64ByZero,
			AutoInstance.IR_StrengthReduction_MulUnsigned64ByZero_v1,
			AutoInstance.IR_StrengthReduction_MulSigned32ByOne,
			AutoInstance.IR_StrengthReduction_MulSigned32ByOne_v1,
			AutoInstance.IR_StrengthReduction_MulSigned64ByOne,
			AutoInstance.IR_StrengthReduction_MulSigned64ByOne_v1,
			AutoInstance.IR_StrengthReduction_MulUnsigned32ByOne,
			AutoInstance.IR_StrengthReduction_MulUnsigned32ByOne_v1,
			AutoInstance.IR_StrengthReduction_MulUnsigned64ByOne,
			AutoInstance.IR_StrengthReduction_MulUnsigned64ByOne_v1,
			AutoInstance.IR_StrengthReduction_MulUnsigned32ByPowerOfTwo,
			AutoInstance.IR_StrengthReduction_MulUnsigned32ByPowerOfTwo_v1,
			AutoInstance.IR_StrengthReduction_MulUnsigned64ByPowerOfTwo,
			AutoInstance.IR_StrengthReduction_MulUnsigned64ByPowerOfTwo_v1,
			AutoInstance.IR_StrengthReduction_MulSigned32ByPowerOfTwo,
			AutoInstance.IR_StrengthReduction_MulSigned32ByPowerOfTwo_v1,
			AutoInstance.IR_StrengthReduction_MulSigned64ByPowerOfTwo,
			AutoInstance.IR_StrengthReduction_MulSigned64ByPowerOfTwo_v1,
			AutoInstance.IR_StrengthReduction_DivSigned32ByZero,
			AutoInstance.IR_StrengthReduction_DivSigned64ByZero,
			AutoInstance.IR_StrengthReduction_DivSigned32ByOne,
			AutoInstance.IR_StrengthReduction_DivSigned64ByOne,
			AutoInstance.IR_StrengthReduction_DivUnsigned32ByOne,
			AutoInstance.IR_StrengthReduction_DivUnsigned64ByOne,
			AutoInstance.IR_StrengthReduction_DivUnsigned32ByPowerOfTwo,
			AutoInstance.IR_StrengthReduction_DivUnsigned64ByPowerOfTwo,
			AutoInstance.IR_StrengthReduction_DivSigned32ByPowerOfTwo,
			AutoInstance.IR_StrengthReduction_DivSigned64ByPowerOfTwo,
			AutoInstance.IR_StrengthReduction_RemUnsigned32ByPowerOfTwo,
			AutoInstance.IR_StrengthReduction_RemUnsigned64ByPowerOfTwo,
			AutoInstance.IR_StrengthReduction_Compare32x32RemUnsigned32Sign,
			AutoInstance.IR_StrengthReduction_Compare32x32RemUnsigned32Sign_v1,
			AutoInstance.IR_StrengthReduction_Compare32x64RemUnsigned64Sign,
			AutoInstance.IR_StrengthReduction_Compare32x64RemUnsigned64Sign_v1,
			AutoInstance.IR_StrengthReduction_Compare64x32RemUnsigned32Sign,
			AutoInstance.IR_StrengthReduction_Compare64x32RemUnsigned32Sign_v1,
			AutoInstance.IR_StrengthReduction_Compare64x64RemUnsigned64Sign,
			AutoInstance.IR_StrengthReduction_Compare64x64RemUnsigned64Sign_v1,
			AutoInstance.IR_StrengthReduction_Compare32x32Add32UnsignedRange,
			AutoInstance.IR_StrengthReduction_Compare32x32Add32UnsignedRange_v1,
			AutoInstance.IR_StrengthReduction_Compare32x64Add64UnsignedRange,
			AutoInstance.IR_StrengthReduction_Compare32x64Add64UnsignedRange_v1,
			AutoInstance.IR_StrengthReduction_Compare64x32Add32UnsignedRange,
			AutoInstance.IR_StrengthReduction_Compare64x32Add32UnsignedRange_v1,
			AutoInstance.IR_StrengthReduction_Compare64x64Add64UnsignedRange,
			AutoInstance.IR_StrengthReduction_Compare64x64Add64UnsignedRange_v1,
			AutoInstance.IR_StrengthReduction_UnlessOr32ShiftRight32,
			AutoInstance.IR_StrengthReduction_UnlessOr32ShiftRight32_v1,
			AutoInstance.IR_StrengthReduction_UnlessOr64ShiftRight64,
			AutoInstance.IR_StrengthReduction_UnlessOr64ShiftRight64_v1,
			AutoInstance.IR_StrengthReduction_UnlessXor32ShiftRight32,
			AutoInstance.IR_StrengthReduction_UnlessXor32ShiftRight32_v1,
			AutoInstance.IR_StrengthReduction_UnlessXor64ShiftRight64,
			AutoInstance.IR_StrengthReduction_UnlessXor64ShiftRight64_v1,
			AutoInstance.IR_StrengthReduction_UnlessOr32ShiftLeft32,
			AutoInstance.IR_StrengthReduction_UnlessOr32ShiftLeft32_v1,
			AutoInstance.IR_StrengthReduction_UnlessOr64ShiftLeft64,
			AutoInstance.IR_StrengthReduction_UnlessOr64ShiftLeft64_v1,
			AutoInstance.IR_StrengthReduction_UnlessXor32ShiftLeft32,
			AutoInstance.IR_StrengthReduction_UnlessXor32ShiftLeft32_v1,
			AutoInstance.IR_StrengthReduction_UnlessXor64ShiftLeft64,
			AutoInstance.IR_StrengthReduction_UnlessXor64ShiftLeft64_v1,
			AutoInstance.IR_Reorder_MulUnsigned32WithShiftLeft32,
			AutoInstance.IR_Reorder_MulUnsigned32WithShiftLeft32_v1,
			AutoInstance.IR_Reorder_MulUnsigned64WithShiftLeft64,
			AutoInstance.IR_Reorder_MulUnsigned64WithShiftLeft64_v1,
			AutoInstance.IR_Reorder_MulSigned32WithShiftLeft32,
			AutoInstance.IR_Reorder_MulSigned32WithShiftLeft32_v1,
			AutoInstance.IR_Reorder_MulSigned64WithShiftLeft64,
			AutoInstance.IR_Reorder_MulSigned64WithShiftLeft64_v1,
			AutoInstance.IR_Reorder_SubToAdd32,
			AutoInstance.IR_Reorder_SubToAdd64,
			AutoInstance.IR_ConstantMove_Add32Expression,
			AutoInstance.IR_ConstantMove_Add32Expression_v1,
			AutoInstance.IR_ConstantMove_Add32Expression_v2,
			AutoInstance.IR_ConstantMove_Add32Expression_v3,
			AutoInstance.IR_ConstantMove_Add64Expression,
			AutoInstance.IR_ConstantMove_Add64Expression_v1,
			AutoInstance.IR_ConstantMove_Add64Expression_v2,
			AutoInstance.IR_ConstantMove_Add64Expression_v3,
			AutoInstance.IR_ConstantMove_AddR4Expression,
			AutoInstance.IR_ConstantMove_AddR4Expression_v1,
			AutoInstance.IR_ConstantMove_AddR4Expression_v2,
			AutoInstance.IR_ConstantMove_AddR4Expression_v3,
			AutoInstance.IR_ConstantMove_AddR8Expression,
			AutoInstance.IR_ConstantMove_AddR8Expression_v1,
			AutoInstance.IR_ConstantMove_AddR8Expression_v2,
			AutoInstance.IR_ConstantMove_AddR8Expression_v3,
			AutoInstance.IR_ConstantMove_And32Expression,
			AutoInstance.IR_ConstantMove_And32Expression_v1,
			AutoInstance.IR_ConstantMove_And32Expression_v2,
			AutoInstance.IR_ConstantMove_And32Expression_v3,
			AutoInstance.IR_ConstantMove_And64Expression,
			AutoInstance.IR_ConstantMove_And64Expression_v1,
			AutoInstance.IR_ConstantMove_And64Expression_v2,
			AutoInstance.IR_ConstantMove_And64Expression_v3,
			AutoInstance.IR_ConstantMove_Or32Expression,
			AutoInstance.IR_ConstantMove_Or32Expression_v1,
			AutoInstance.IR_ConstantMove_Or32Expression_v2,
			AutoInstance.IR_ConstantMove_Or32Expression_v3,
			AutoInstance.IR_ConstantMove_Or64Expression,
			AutoInstance.IR_ConstantMove_Or64Expression_v1,
			AutoInstance.IR_ConstantMove_Or64Expression_v2,
			AutoInstance.IR_ConstantMove_Or64Expression_v3,
			AutoInstance.IR_ConstantMove_Xor32Expression,
			AutoInstance.IR_ConstantMove_Xor32Expression_v1,
			AutoInstance.IR_ConstantMove_Xor32Expression_v2,
			AutoInstance.IR_ConstantMove_Xor32Expression_v3,
			AutoInstance.IR_ConstantMove_Xor64Expression,
			AutoInstance.IR_ConstantMove_Xor64Expression_v1,
			AutoInstance.IR_ConstantMove_Xor64Expression_v2,
			AutoInstance.IR_ConstantMove_Xor64Expression_v3,
			AutoInstance.IR_ConstantMove_MulUnsigned32Expression,
			AutoInstance.IR_ConstantMove_MulUnsigned32Expression_v1,
			AutoInstance.IR_ConstantMove_MulUnsigned32Expression_v2,
			AutoInstance.IR_ConstantMove_MulUnsigned32Expression_v3,
			AutoInstance.IR_ConstantMove_MulUnsigned64Expression,
			AutoInstance.IR_ConstantMove_MulUnsigned64Expression_v1,
			AutoInstance.IR_ConstantMove_MulUnsigned64Expression_v2,
			AutoInstance.IR_ConstantMove_MulUnsigned64Expression_v3,
			AutoInstance.IR_ConstantMove_MulSigned32Expression,
			AutoInstance.IR_ConstantMove_MulSigned32Expression_v1,
			AutoInstance.IR_ConstantMove_MulSigned32Expression_v2,
			AutoInstance.IR_ConstantMove_MulSigned32Expression_v3,
			AutoInstance.IR_ConstantMove_MulSigned64Expression,
			AutoInstance.IR_ConstantMove_MulSigned64Expression_v1,
			AutoInstance.IR_ConstantMove_MulSigned64Expression_v2,
			AutoInstance.IR_ConstantMove_MulSigned64Expression_v3,
			AutoInstance.IR_ConstantMove_MulR4Expression,
			AutoInstance.IR_ConstantMove_MulR4Expression_v1,
			AutoInstance.IR_ConstantMove_MulR4Expression_v2,
			AutoInstance.IR_ConstantMove_MulR4Expression_v3,
			AutoInstance.IR_ConstantMove_MulR8Expression,
			AutoInstance.IR_ConstantMove_MulR8Expression_v1,
			AutoInstance.IR_ConstantMove_MulR8Expression_v2,
			AutoInstance.IR_ConstantMove_MulR8Expression_v3,
			AutoInstance.IR_ConstantFolding_MulSignedShiftLeft32,
			AutoInstance.IR_ConstantFolding_MulSignedShiftLeft32_v1,
			AutoInstance.IR_ConstantFolding_MulSignedShiftLeft64,
			AutoInstance.IR_ConstantFolding_MulSignedShiftLeft64_v1,
			AutoInstance.IR_ConstantFolding_MulUnsignedShiftLeft32,
			AutoInstance.IR_ConstantFolding_MulUnsignedShiftLeft32_v1,
			AutoInstance.IR_ConstantFolding_MulUnsignedShiftLeft64,
			AutoInstance.IR_ConstantFolding_MulUnsignedShiftLeft64_v1,
			AutoInstance.IR_ConstantFolding_AddCarryIn32Inside,
			AutoInstance.IR_ConstantFolding_AddCarryIn64Inside,
			AutoInstance.IR_ConstantFolding_AddCarryIn32Outside1,
			AutoInstance.IR_ConstantFolding_AddCarryIn64Outside1,
			AutoInstance.IR_ConstantFolding_AddCarryIn32Outside2,
			AutoInstance.IR_ConstantFolding_AddCarryIn64Outside2,
			AutoInstance.IR_ConstantFolding_AddCarryIn32NoCarry,
			AutoInstance.IR_ConstantFolding_AddCarryIn64NoCarry,
			AutoInstance.IR_ConstantFolding_SubCarryIn32Inside,
			AutoInstance.IR_ConstantFolding_SubCarryIn64Inside,
			AutoInstance.IR_ConstantFolding_SubCarryIn32Outside1,
			AutoInstance.IR_ConstantFolding_SubCarryIn64Outside1,
			AutoInstance.IR_ConstantFolding_SubCarryIn32Outside2,
			AutoInstance.IR_ConstantFolding_SubCarryIn64Outside2,
			AutoInstance.IR_ConstantFolding_SubCarryIn32NoCarry,
			AutoInstance.IR_ConstantFolding_SubCarryIn64NoCarry,
			AutoInstance.IR_ConstantFolding_Add32x2,
			AutoInstance.IR_ConstantFolding_Add32x2_v1,
			AutoInstance.IR_ConstantFolding_Add32x2_v2,
			AutoInstance.IR_ConstantFolding_Add32x2_v3,
			AutoInstance.IR_ConstantFolding_Add64x2,
			AutoInstance.IR_ConstantFolding_Add64x2_v1,
			AutoInstance.IR_ConstantFolding_Add64x2_v2,
			AutoInstance.IR_ConstantFolding_Add64x2_v3,
			AutoInstance.IR_ConstantFolding_AddR4x2,
			AutoInstance.IR_ConstantFolding_AddR4x2_v1,
			AutoInstance.IR_ConstantFolding_AddR4x2_v2,
			AutoInstance.IR_ConstantFolding_AddR4x2_v3,
			AutoInstance.IR_ConstantFolding_AddR8x2,
			AutoInstance.IR_ConstantFolding_AddR8x2_v1,
			AutoInstance.IR_ConstantFolding_AddR8x2_v2,
			AutoInstance.IR_ConstantFolding_AddR8x2_v3,
			AutoInstance.IR_ConstantFolding_Sub32x2,
			AutoInstance.IR_ConstantFolding_Sub64x2,
			AutoInstance.IR_ConstantFolding_SubR4x2,
			AutoInstance.IR_ConstantFolding_SubR8x2,
			AutoInstance.IR_ConstantFolding_MulSigned32x2,
			AutoInstance.IR_ConstantFolding_MulSigned32x2_v1,
			AutoInstance.IR_ConstantFolding_MulSigned32x2_v2,
			AutoInstance.IR_ConstantFolding_MulSigned32x2_v3,
			AutoInstance.IR_ConstantFolding_MulSigned64x2,
			AutoInstance.IR_ConstantFolding_MulSigned64x2_v1,
			AutoInstance.IR_ConstantFolding_MulSigned64x2_v2,
			AutoInstance.IR_ConstantFolding_MulSigned64x2_v3,
			AutoInstance.IR_ConstantFolding_MulR4x2,
			AutoInstance.IR_ConstantFolding_MulR4x2_v1,
			AutoInstance.IR_ConstantFolding_MulR4x2_v2,
			AutoInstance.IR_ConstantFolding_MulR4x2_v3,
			AutoInstance.IR_ConstantFolding_MulR8x2,
			AutoInstance.IR_ConstantFolding_MulR8x2_v1,
			AutoInstance.IR_ConstantFolding_MulR8x2_v2,
			AutoInstance.IR_ConstantFolding_MulR8x2_v3,
			AutoInstance.IR_ConstantFolding_MulUnsigned32x2,
			AutoInstance.IR_ConstantFolding_MulUnsigned32x2_v1,
			AutoInstance.IR_ConstantFolding_MulUnsigned32x2_v2,
			AutoInstance.IR_ConstantFolding_MulUnsigned32x2_v3,
			AutoInstance.IR_ConstantFolding_MulUnsigned64x2,
			AutoInstance.IR_ConstantFolding_MulUnsigned64x2_v1,
			AutoInstance.IR_ConstantFolding_MulUnsigned64x2_v2,
			AutoInstance.IR_ConstantFolding_MulUnsigned64x2_v3,
			AutoInstance.IR_ConstantFolding_Or32x2,
			AutoInstance.IR_ConstantFolding_Or32x2_v1,
			AutoInstance.IR_ConstantFolding_Or32x2_v2,
			AutoInstance.IR_ConstantFolding_Or32x2_v3,
			AutoInstance.IR_ConstantFolding_Or64x2,
			AutoInstance.IR_ConstantFolding_Or64x2_v1,
			AutoInstance.IR_ConstantFolding_Or64x2_v2,
			AutoInstance.IR_ConstantFolding_Or64x2_v3,
			AutoInstance.IR_ConstantFolding_And32x2,
			AutoInstance.IR_ConstantFolding_And32x2_v1,
			AutoInstance.IR_ConstantFolding_And32x2_v2,
			AutoInstance.IR_ConstantFolding_And32x2_v3,
			AutoInstance.IR_ConstantFolding_And64x2,
			AutoInstance.IR_ConstantFolding_And64x2_v1,
			AutoInstance.IR_ConstantFolding_And64x2_v2,
			AutoInstance.IR_ConstantFolding_And64x2_v3,
			AutoInstance.IR_ConstantFolding_Xor32x2,
			AutoInstance.IR_ConstantFolding_Xor32x2_v1,
			AutoInstance.IR_ConstantFolding_Xor32x2_v2,
			AutoInstance.IR_ConstantFolding_Xor32x2_v3,
			AutoInstance.IR_ConstantFolding_Xor64x2,
			AutoInstance.IR_ConstantFolding_Xor64x2_v1,
			AutoInstance.IR_ConstantFolding_Xor64x2_v2,
			AutoInstance.IR_ConstantFolding_Xor64x2_v3,
			AutoInstance.IR_ConstantFolding_AddSub32,
			AutoInstance.IR_ConstantFolding_AddSub32_v1,
			AutoInstance.IR_ConstantFolding_AddSub64,
			AutoInstance.IR_ConstantFolding_AddSub64_v1,
			AutoInstance.IR_ConstantFolding_AddSubR4,
			AutoInstance.IR_ConstantFolding_AddSubR4_v1,
			AutoInstance.IR_ConstantFolding_AddSubR8,
			AutoInstance.IR_ConstantFolding_AddSubR8_v1,
			AutoInstance.IR_ConstantFolding_SubAdd32,
			AutoInstance.IR_ConstantFolding_SubAdd32_v1,
			AutoInstance.IR_ConstantFolding_SubAdd64,
			AutoInstance.IR_ConstantFolding_SubAdd64_v1,
			AutoInstance.IR_ConstantFolding_SubAddR4,
			AutoInstance.IR_ConstantFolding_SubAddR4_v1,
			AutoInstance.IR_ConstantFolding_SubAddR8,
			AutoInstance.IR_ConstantFolding_SubAddR8_v1,
			AutoInstance.IR_ConstantFolding_ShiftLeft32x2,
			AutoInstance.IR_ConstantFolding_ShiftLeft64x2,
			AutoInstance.IR_ConstantFolding_ShiftRight32x2,
			AutoInstance.IR_ConstantFolding_ShiftRight64x2,
			AutoInstance.IR_ConstantFolding_Load32FoldAdd32,
			AutoInstance.IR_ConstantFolding_Load64FoldAdd32,
			AutoInstance.IR_ConstantFolding_LoadR4FoldAdd32,
			AutoInstance.IR_ConstantFolding_LoadR8FoldAdd32,
			AutoInstance.IR_ConstantFolding_LoadSignExtend8x32FoldAdd32,
			AutoInstance.IR_ConstantFolding_LoadSignExtend16x32FoldAdd32,
			AutoInstance.IR_ConstantFolding_LoadSignExtend8x64FoldAdd32,
			AutoInstance.IR_ConstantFolding_LoadSignExtend16x64FoldAdd32,
			AutoInstance.IR_ConstantFolding_LoadSignExtend32x64FoldAdd32,
			AutoInstance.IR_ConstantFolding_LoadZeroExtend8x32FoldAdd32,
			AutoInstance.IR_ConstantFolding_LoadZeroExtend16x32FoldAdd32,
			AutoInstance.IR_ConstantFolding_LoadZeroExtend8x64FoldAdd32,
			AutoInstance.IR_ConstantFolding_LoadZeroExtend16x64FoldAdd32,
			AutoInstance.IR_ConstantFolding_LoadZeroExtend32x64FoldAdd32,
			AutoInstance.IR_ConstantFolding_Load32FoldAdd64,
			AutoInstance.IR_ConstantFolding_Load64FoldAdd64,
			AutoInstance.IR_ConstantFolding_LoadR4FoldAdd64,
			AutoInstance.IR_ConstantFolding_LoadR8FoldAdd64,
			AutoInstance.IR_ConstantFolding_LoadSignExtend8x32FoldAdd64,
			AutoInstance.IR_ConstantFolding_LoadSignExtend16x32FoldAdd64,
			AutoInstance.IR_ConstantFolding_LoadSignExtend8x64FoldAdd64,
			AutoInstance.IR_ConstantFolding_LoadSignExtend16x64FoldAdd64,
			AutoInstance.IR_ConstantFolding_LoadSignExtend32x64FoldAdd64,
			AutoInstance.IR_ConstantFolding_LoadZeroExtend8x32FoldAdd64,
			AutoInstance.IR_ConstantFolding_LoadZeroExtend16x32FoldAdd64,
			AutoInstance.IR_ConstantFolding_LoadZeroExtend8x64FoldAdd64,
			AutoInstance.IR_ConstantFolding_LoadZeroExtend16x64FoldAdd64,
			AutoInstance.IR_ConstantFolding_LoadZeroExtend32x64FoldAdd64,
			AutoInstance.IR_ConstantFolding_Load32FoldSub32,
			AutoInstance.IR_ConstantFolding_Load64FoldSub32,
			AutoInstance.IR_ConstantFolding_LoadR4FoldSub32,
			AutoInstance.IR_ConstantFolding_LoadR8FoldSub32,
			AutoInstance.IR_ConstantFolding_LoadSignExtend8x32FoldSub32,
			AutoInstance.IR_ConstantFolding_LoadSignExtend16x32FoldSub32,
			AutoInstance.IR_ConstantFolding_LoadSignExtend8x64FoldSub32,
			AutoInstance.IR_ConstantFolding_LoadSignExtend16x64FoldSub32,
			AutoInstance.IR_ConstantFolding_LoadSignExtend32x64FoldSub32,
			AutoInstance.IR_ConstantFolding_LoadZeroExtend8x32FoldSub32,
			AutoInstance.IR_ConstantFolding_LoadZeroExtend16x32FoldSub32,
			AutoInstance.IR_ConstantFolding_LoadZeroExtend8x64FoldSub32,
			AutoInstance.IR_ConstantFolding_LoadZeroExtend16x64FoldSub32,
			AutoInstance.IR_ConstantFolding_LoadZeroExtend32x64FoldSub32,
			AutoInstance.IR_ConstantFolding_Load32FoldSub64,
			AutoInstance.IR_ConstantFolding_Load64FoldSub64,
			AutoInstance.IR_ConstantFolding_LoadR4FoldSub64,
			AutoInstance.IR_ConstantFolding_LoadR8FoldSub64,
			AutoInstance.IR_ConstantFolding_LoadSignExtend8x32FoldSub64,
			AutoInstance.IR_ConstantFolding_LoadSignExtend16x32FoldSub64,
			AutoInstance.IR_ConstantFolding_LoadSignExtend8x64FoldSub64,
			AutoInstance.IR_ConstantFolding_LoadSignExtend16x64FoldSub64,
			AutoInstance.IR_ConstantFolding_LoadSignExtend32x64FoldSub64,
			AutoInstance.IR_ConstantFolding_LoadZeroExtend8x32FoldSub64,
			AutoInstance.IR_ConstantFolding_LoadZeroExtend16x32FoldSub64,
			AutoInstance.IR_ConstantFolding_LoadZeroExtend8x64FoldSub64,
			AutoInstance.IR_ConstantFolding_LoadZeroExtend16x64FoldSub64,
			AutoInstance.IR_ConstantFolding_LoadZeroExtend32x64FoldSub64,
			AutoInstance.IR_ConstantFolding_Store8FoldAdd32,
			AutoInstance.IR_ConstantFolding_Store8FoldAdd64,
			AutoInstance.IR_ConstantFolding_Store8FoldSub32,
			AutoInstance.IR_ConstantFolding_Store8FoldSub64,
			AutoInstance.IR_ConstantFolding_Store16FoldAdd32,
			AutoInstance.IR_ConstantFolding_Store16FoldAdd64,
			AutoInstance.IR_ConstantFolding_Store16FoldSub32,
			AutoInstance.IR_ConstantFolding_Store16FoldSub64,
			AutoInstance.IR_ConstantFolding_Store32FoldAdd32,
			AutoInstance.IR_ConstantFolding_Store32FoldAdd64,
			AutoInstance.IR_ConstantFolding_Store32FoldSub32,
			AutoInstance.IR_ConstantFolding_Store32FoldSub64,
			AutoInstance.IR_ConstantFolding_Store64FoldAdd32,
			AutoInstance.IR_ConstantFolding_Store64FoldAdd64,
			AutoInstance.IR_ConstantFolding_Store64FoldSub32,
			AutoInstance.IR_ConstantFolding_Store64FoldSub64,
			AutoInstance.IR_ConstantFolding_StoreR4FoldAdd32,
			AutoInstance.IR_ConstantFolding_StoreR4FoldAdd64,
			AutoInstance.IR_ConstantFolding_StoreR4FoldSub32,
			AutoInstance.IR_ConstantFolding_StoreR4FoldSub64,
			AutoInstance.IR_ConstantFolding_StoreR8FoldAdd32,
			AutoInstance.IR_ConstantFolding_StoreR8FoldAdd64,
			AutoInstance.IR_ConstantFolding_StoreR8FoldSub32,
			AutoInstance.IR_ConstantFolding_StoreR8FoldSub64,
			AutoInstance.IR_ConstantFolding_Load32AddressFold,
			AutoInstance.IR_ConstantFolding_Load64AddressFold,
			AutoInstance.IR_ConstantFolding_LoadR4AddressFold,
			AutoInstance.IR_ConstantFolding_LoadR8AddressFold,
			AutoInstance.IR_ConstantFolding_LoadSignExtend8x32AddressFold,
			AutoInstance.IR_ConstantFolding_LoadSignExtend16x32AddressFold,
			AutoInstance.IR_ConstantFolding_LoadSignExtend8x64AddressFold,
			AutoInstance.IR_ConstantFolding_LoadSignExtend16x64AddressFold,
			AutoInstance.IR_ConstantFolding_LoadSignExtend32x64AddressFold,
			AutoInstance.IR_ConstantFolding_LoadZeroExtend8x32AddressFold,
			AutoInstance.IR_ConstantFolding_LoadZeroExtend16x32AddressFold,
			AutoInstance.IR_ConstantFolding_LoadZeroExtend8x64AddressFold,
			AutoInstance.IR_ConstantFolding_LoadZeroExtend16x64AddressFold,
			AutoInstance.IR_ConstantFolding_LoadZeroExtend32x64AddressFold,
			AutoInstance.IR_Algebraic_Signed32AAPlusBBPlus2AB,
			AutoInstance.IR_Algebraic_Signed32AAPlusBBPlus2AB_v1,
			AutoInstance.IR_Algebraic_Signed32AAPlusBBPlus2AB_v2,
			AutoInstance.IR_Algebraic_Signed32AAPlusBBPlus2AB_v3,
			AutoInstance.IR_Algebraic_Signed32AAPlusBBPlus2AB_v4,
			AutoInstance.IR_Algebraic_Signed32AAPlusBBPlus2AB_v5,
			AutoInstance.IR_Algebraic_Signed32AAPlusBBPlus2AB_v6,
			AutoInstance.IR_Algebraic_Signed32AAPlusBBPlus2AB_v7,
			AutoInstance.IR_Algebraic_Signed64AAPlusBBPlus2AB,
			AutoInstance.IR_Algebraic_Signed64AAPlusBBPlus2AB_v1,
			AutoInstance.IR_Algebraic_Signed64AAPlusBBPlus2AB_v2,
			AutoInstance.IR_Algebraic_Signed64AAPlusBBPlus2AB_v3,
			AutoInstance.IR_Algebraic_Signed64AAPlusBBPlus2AB_v4,
			AutoInstance.IR_Algebraic_Signed64AAPlusBBPlus2AB_v5,
			AutoInstance.IR_Algebraic_Signed64AAPlusBBPlus2AB_v6,
			AutoInstance.IR_Algebraic_Signed64AAPlusBBPlus2AB_v7,
			AutoInstance.IR_Algebraic_Unsigned32AAPlusBBPlus2AB,
			AutoInstance.IR_Algebraic_Unsigned32AAPlusBBPlus2AB_v1,
			AutoInstance.IR_Algebraic_Unsigned32AAPlusBBPlus2AB_v2,
			AutoInstance.IR_Algebraic_Unsigned32AAPlusBBPlus2AB_v3,
			AutoInstance.IR_Algebraic_Unsigned32AAPlusBBPlus2AB_v4,
			AutoInstance.IR_Algebraic_Unsigned32AAPlusBBPlus2AB_v5,
			AutoInstance.IR_Algebraic_Unsigned32AAPlusBBPlus2AB_v6,
			AutoInstance.IR_Algebraic_Unsigned32AAPlusBBPlus2AB_v7,
			AutoInstance.IR_Algebraic_Unsigned64AAPlusBBPlus2AB,
			AutoInstance.IR_Algebraic_Unsigned64AAPlusBBPlus2AB_v1,
			AutoInstance.IR_Algebraic_Unsigned64AAPlusBBPlus2AB_v2,
			AutoInstance.IR_Algebraic_Unsigned64AAPlusBBPlus2AB_v3,
			AutoInstance.IR_Algebraic_Unsigned64AAPlusBBPlus2AB_v4,
			AutoInstance.IR_Algebraic_Unsigned64AAPlusBBPlus2AB_v5,
			AutoInstance.IR_Algebraic_Unsigned64AAPlusBBPlus2AB_v6,
			AutoInstance.IR_Algebraic_Unsigned64AAPlusBBPlus2AB_v7,
			AutoInstance.IR_Algebraic_Signed32AAPlusBBMinus2AB,
			AutoInstance.IR_Algebraic_Signed32AAPlusBBMinus2AB_v1,
			AutoInstance.IR_Algebraic_Signed32AAPlusBBMinus2AB_v2,
			AutoInstance.IR_Algebraic_Signed32AAPlusBBMinus2AB_v3,
			AutoInstance.IR_Algebraic_Signed64AAPlusBBMinus2AB,
			AutoInstance.IR_Algebraic_Signed64AAPlusBBMinus2AB_v1,
			AutoInstance.IR_Algebraic_Signed64AAPlusBBMinus2AB_v2,
			AutoInstance.IR_Algebraic_Signed64AAPlusBBMinus2AB_v3,
			AutoInstance.IR_Algebraic_Unsigned32AAPlusBBMinus2AB,
			AutoInstance.IR_Algebraic_Unsigned32AAPlusBBMinus2AB_v1,
			AutoInstance.IR_Algebraic_Unsigned32AAPlusBBMinus2AB_v2,
			AutoInstance.IR_Algebraic_Unsigned32AAPlusBBMinus2AB_v3,
			AutoInstance.IR_Algebraic_Unsigned64AAPlusBBMinus2AB,
			AutoInstance.IR_Algebraic_Unsigned64AAPlusBBMinus2AB_v1,
			AutoInstance.IR_Algebraic_Unsigned64AAPlusBBMinus2AB_v2,
			AutoInstance.IR_Algebraic_Unsigned64AAPlusBBMinus2AB_v3,
			AutoInstance.IR_Algebraic_Signed32AAMinusBB,
			AutoInstance.IR_Algebraic_Signed64AAMinusBB,
			AutoInstance.IR_Algebraic_Unsigned32AAMinusBB,
			AutoInstance.IR_Algebraic_Unsigned64AAMinusBB,
			AutoInstance.IR_Algebraic_Unsigned32PerfectSquareFormula,
			AutoInstance.IR_Algebraic_Unsigned32PerfectSquareFormula_v1,
			AutoInstance.IR_Algebraic_Unsigned32PerfectSquareFormula_v2,
			AutoInstance.IR_Algebraic_Unsigned32PerfectSquareFormula_v3,
			AutoInstance.IR_Algebraic_Unsigned32PerfectSquareFormula_v4,
			AutoInstance.IR_Algebraic_Unsigned32PerfectSquareFormula_v5,
			AutoInstance.IR_Algebraic_Unsigned32PerfectSquareFormula_v6,
			AutoInstance.IR_Algebraic_Unsigned32PerfectSquareFormula_v7,
			AutoInstance.IR_Algebraic_Unsigned64PerfectSquareFormula,
			AutoInstance.IR_Algebraic_Unsigned64PerfectSquareFormula_v1,
			AutoInstance.IR_Algebraic_Unsigned64PerfectSquareFormula_v2,
			AutoInstance.IR_Algebraic_Unsigned64PerfectSquareFormula_v3,
			AutoInstance.IR_Algebraic_Unsigned64PerfectSquareFormula_v4,
			AutoInstance.IR_Algebraic_Unsigned64PerfectSquareFormula_v5,
			AutoInstance.IR_Algebraic_Unsigned64PerfectSquareFormula_v6,
			AutoInstance.IR_Algebraic_Unsigned64PerfectSquareFormula_v7,
			AutoInstance.IR_Algebraic_Signed32PerfectSquareFormula,
			AutoInstance.IR_Algebraic_Signed32PerfectSquareFormula_v1,
			AutoInstance.IR_Algebraic_Signed32PerfectSquareFormula_v2,
			AutoInstance.IR_Algebraic_Signed32PerfectSquareFormula_v3,
			AutoInstance.IR_Algebraic_Signed32PerfectSquareFormula_v4,
			AutoInstance.IR_Algebraic_Signed32PerfectSquareFormula_v5,
			AutoInstance.IR_Algebraic_Signed32PerfectSquareFormula_v6,
			AutoInstance.IR_Algebraic_Signed32PerfectSquareFormula_v7,
			AutoInstance.IR_Algebraic_Signed64PerfectSquareFormula,
			AutoInstance.IR_Algebraic_Signed64PerfectSquareFormula_v1,
			AutoInstance.IR_Algebraic_Signed64PerfectSquareFormula_v2,
			AutoInstance.IR_Algebraic_Signed64PerfectSquareFormula_v3,
			AutoInstance.IR_Algebraic_Signed64PerfectSquareFormula_v4,
			AutoInstance.IR_Algebraic_Signed64PerfectSquareFormula_v5,
			AutoInstance.IR_Algebraic_Signed64PerfectSquareFormula_v6,
			AutoInstance.IR_Algebraic_Signed64PerfectSquareFormula_v7,
		};
	}
}
