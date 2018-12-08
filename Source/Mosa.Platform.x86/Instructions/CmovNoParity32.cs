// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

using Mosa.Compiler.Framework;

namespace Mosa.Platform.x86.Instructions
{
	/// <summary>
	/// CMovNoParity32
	/// </summary>
	/// <seealso cref="Mosa.Platform.x86.X86Instruction" />
	public sealed class CMovNoParity32 : X86Instruction
	{
		public override int ID { get { return 363; } }

		internal CMovNoParity32()
			: base(1, 1)
		{
		}

		public override string AlternativeName { get { return "CMovNP"; } }

		public override bool IsParityFlagUsed { get { return true; } }

		public override BaseInstruction GetOpposite()
		{
			return X86.CMovParity32;
		}

		public override void Emit(InstructionNode node, BaseCodeEmitter emitter)
		{
			System.Diagnostics.Debug.Assert(node.ResultCount == 1);
			System.Diagnostics.Debug.Assert(node.OperandCount == 1);

			emitter.OpcodeEncoder.AppendByte(0x0F);
			emitter.OpcodeEncoder.AppendByte(0x4B);
			emitter.OpcodeEncoder.Append2Bits(0b11);
			emitter.OpcodeEncoder.Append3Bits(node.Result.Register.RegisterCode);
			emitter.OpcodeEncoder.Append3Bits(node.Operand1.Register.RegisterCode);
		}
	}
}
