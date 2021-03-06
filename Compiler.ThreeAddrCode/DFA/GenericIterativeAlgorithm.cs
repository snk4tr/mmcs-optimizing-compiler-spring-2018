﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Compiler.ThreeAddrCode.CFG;

namespace Compiler.ThreeAddrCode.DFA
{
    public class GenericIterativeAlgorithm<T> : IAlgorithm<T>
    {
        public Func<T, T, bool> Comparer { get; set; }
        public Func<(T, T)> Fill { get; set; }
        public Func<T, string> DebugToString { get; set; }
        public Func<(T,T), (T,T), bool> Finish { get; set; }
        public bool Reverse { get; set; } = false;

        public InOutData<T> Analyze(
            ControlFlowGraph graph,
            ILatticeOperations<T> ops,
            ITransferFunction<T> f)
        {
            var data = new InOutData<T>();
            data[graph.CFGNodes.ElementAt(0)] = Fill();

            foreach (var node in graph.CFGNodes)
                data[node] = Fill();

            var outChanged = true;
            while (outChanged)
            {
                outChanged = false;
                foreach (var block in graph.CFGNodes)
                {
                    T inset;
                    T outset;

                    if (!Reverse)
                    {
                        inset = block.Parents.Aggregate(Fill().Item1, (x, y)
                            => ops.Operator(x, data[y].Item2));
                        outset = f.Transfer(block, inset, ops);
                    }
                    else
                    {
                        outset = block.Parents.Aggregate(Fill().Item2, (x, y)
                            => ops.Operator(x, data[y].Item1));
                        inset = f.Transfer(block, outset, ops);
                    }
                    
                    if (!Finish((inset,outset), data[block]))
                    {
                        outChanged = true;
                    }
                    data[block] = (inset, outset);
                }
            }
            return data;
        }
    }
}
