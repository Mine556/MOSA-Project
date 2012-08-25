﻿/*
 * (c) 2012 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *  Pascal Delprat (pdelprat) <pascal.delprat@online.fr>   
 */

using System;
using Mosa.Compiler.Framework;

namespace Mosa.Platform.AVR32.Instructions
{
	/// <summary>
	/// Add Instruction
	/// Suported format:
	///     add Rd, Rs
	/// </summary>
	public class Add : AVR32Instruction
	{
		
		#region Construction

		/// <summary>
		/// Initializes a new instance of <see cref="Add"/>.
		/// </summary>
		public Add() :
			base(0, 0)
		{
		}

		#endregion // Construction

		#region Methods

		/// <summary>
		/// Emits the specified platform instruction.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="emitter">The emitter.</param>
		protected override void Emit(Context context, MachineCodeEmitter emitter)
		{
			if (context.Result.IsRegister && context.Operand1.IsRegister)
			{
				emitter.EmitTwoRegisterInstructions((byte)0x00, (byte)context.Operand1.Register.RegisterCode, (byte)context.Result.Register.RegisterCode);
			}
			else
			{
				throw new Exception("Not supported combination of operands");
			}
		}

		/// <summary>
		/// Allows visitor based dispatch for this instruction object.
		/// </summary>
		/// <param name="visitor">The visitor object.</param>
		/// <param name="context">The context.</param>
		public override void Visit(IAVR32Visitor visitor, Context context)
		{
			visitor.Add(context);
		}

		#endregion // Methods

	}
}
