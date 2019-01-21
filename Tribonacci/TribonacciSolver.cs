using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;

namespace Tribonacci
{
    public class TribonacciSolver
    {
        public TribonacciSolver()
        {

        }

        public List<BigInteger> GetTribonacciSequence(int sequenceLength)
        {
            try
            {
                List<BigInteger> seq = new List<BigInteger>();
                if (sequenceLength <= 0)
                {
                    return null;
                }
                if (sequenceLength > 0)
                {
                    seq.Add(0);
                }
                if (sequenceLength > 1)
                {
                    seq.Add(0);
                }
                if (sequenceLength > 2)
                {
                    seq.Add(1);
                }
                for (int i = 3; i < sequenceLength; i++)
                {
                    seq.Add(seq[i - 1] + seq[i - 2] + seq[i - 3]);
                }
                return seq;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Ett fel inträffade medan tribonacci-sekvensen räknades ut. Error: " + ex.Message);
                return null;
            }
        }
    }
}

