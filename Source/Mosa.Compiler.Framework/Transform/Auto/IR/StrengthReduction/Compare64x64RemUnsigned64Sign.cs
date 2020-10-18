// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

using Mosa.Compiler.Framework.IR;

namespace Mosa.Compiler.Framework.Transform.Auto.IR.StrengthReduction
{
	/// <summary>
	/// Compare64x64RemUnsigned64Sign
	/// </summary>
	public sealed class Compare64x64RemUnsigned64Sign : BaseTransformation
	{
		public Compare64x64RemUnsigned64Sign() : base(IRInstruction.Compare64x64)
		{
		}

		public override bool Match(Context context, TransformContext transformContext)
		{
			if (context.ConditionCode != ConditionCode.Equal)
				return false;

			if (!context.Operand1.IsVirtualRegister)
				return false;

			if (!context.Operand2.IsResolvedConstant)
				return false;

			if (context.Operand2.ConstantUnsigned64 != 0)
				return false;

			if (context.Operand1.Definitions.Count != 1)
				return false;

			if (context.Operand1.Definitions[0].Instruction != IRInstruction.RemUnsigned64)
				return false;

			if (!context.Operand1.Definitions[0].Operand2.IsResolvedConstant)
				return false;

			if (context.Operand1.Definitions[0].Operand2.ConstantUnsigned64 != 2)
				return false;

			return true;
		}

		public override void Transform(Context context, TransformContext transformContext)
		{
			var result = context.Result;

			var t1 = context.Operand1.Definitions[0].Operand1;

			var c1 = transformContext.CreateConstant(1);

			context.SetInstruction(IRInstruction.And64, result, t1, c1);
		}
	}

	/// <summary>
	/// Compare64x64RemUnsigned64Sign_v1
	/// </summary>
	public sealed class Compare64x64RemUnsigned64Sign_v1 : BaseTransformation
	{
		public Compare64x64RemUnsigned64Sign_v1() : base(IRInstruction.Compare64x64)
		{
		}

		public override bool Match(Context context, TransformContext transformContext)
		{
			if (context.ConditionCode != ConditionCode.Equal)
				return false;

			if (!context.Operand1.IsResolvedConstant)
				return false;

			if (context.Operand1.ConstantUnsigned64 != 0)
				return false;

			if (!context.Operand2.IsVirtualRegister)
				return false;

			if (context.Operand2.Definitions.Count != 1)
				return false;

			if (context.Operand2.Definitions[0].Instruction != IRInstruction.RemUnsigned64)
				return false;

			if (!context.Operand2.Definitions[0].Operand2.IsResolvedConstant)
				return false;

			if (context.Operand2.Definitions[0].Operand2.ConstantUnsigned64 != 2)
				return false;

			return true;
		}

		public override void Transform(Context context, TransformContext transformContext)
		{
			var result = context.Result;

			var t1 = context.Operand2.Definitions[0].Operand1;

			var c1 = transformContext.CreateConstant(1);

			context.SetInstruction(IRInstruction.And64, result, t1, c1);
		}
	}
}
