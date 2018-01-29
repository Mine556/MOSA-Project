// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

using Mosa.Compiler.Framework;

namespace Mosa.Platform.x86.Instructions
{
	/// <summary>
	/// Stos
	/// </summary>
	/// <seealso cref="Mosa.Platform.x86.X86Instruction" />
	public sealed class Stos : X86Instruction
	{
		public static readonly byte[] opcode = new byte[] { 0xAB };

		public Stos()
			: base(0, 1)
		{
		}

		public override void Emit(InstructionNode node, BaseCodeEmitter emitter)
		{
			emitter.Write(opcode);
		}

		// The following is used by the automated code generator.

		public override byte[] __opcode { get { return opcode; } }
	}
}

