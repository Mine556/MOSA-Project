﻿/*
 * (c) 2008 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Michael Ruck (grover) <sharpos@michaelruck.de>
 */

using System;
using System.IO;

using Mosa.Runtime.CompilerFramework;
using Mosa.Runtime.Linker;
using Mosa.Runtime.Loader;
using Mosa.Runtime.Vm;

namespace Mosa.Runtime.Jit.SimpleJit
{
    /// <summary>
    /// The simple jit method compiler
    /// </summary>
    sealed class SimpleJitMethodCompiler : BaseMethodCompiler
    {
        #region Data members

        /// <summary>
        /// The code stream, where the final code is emitted to.
        /// </summary>
        private Stream codeStream;

        #endregion // Data members

        #region Construction

        public SimpleJitMethodCompiler(IAssemblyLinker linker, IArchitecture architecture, ICompilationSchedulerStage compilationScheduler, RuntimeType type, RuntimeMethod method, Stream codeStream) :
            base(linker, architecture, compilationScheduler, type, method)
        {
            if (null == codeStream)
                throw new ArgumentNullException(@"codeStream");

            this.codeStream = codeStream;
        }

        #endregion // Construction

        #region MethodCompilerBase Overrides

        #endregion // MethodCompilerBase Overrides
    }
}
