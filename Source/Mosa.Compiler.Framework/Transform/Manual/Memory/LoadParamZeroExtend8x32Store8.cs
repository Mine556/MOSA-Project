﻿// Copyright (c) MOSA Project. Licensed under the New BSD License.

namespace Mosa.Compiler.Framework.Transform.Manual.Memory
{
	public sealed class LoadParamZeroExtend8x32Store8 : BaseTransformation
	{
		public LoadParamZeroExtend8x32Store8() : base(IRInstruction.LoadParamZeroExtend8x32)
		{
		}

		public override bool Match(Context context, TransformContext transformContext)
		{
			var previous = GetPreviousNodeUntil(context, IRInstruction.StoreParam8, transformContext.Window, out bool immediate);

			if (previous == null)
				return false;

			if (!immediate && !IsSSAForm(previous.Operand2))
				return false;

			if (previous.Operand1 != context.Operand1)
				return false;

			return true;
		}

		public override void Transform(Context context, TransformContext transformContext)
		{
			var previous = GetPreviousNodeUntil(context, IRInstruction.StoreParam8, transformContext.Window);

			context.SetInstruction(IRInstruction.ZeroExtend8x32, context.Result, previous.Operand2);
		}
	}
}
