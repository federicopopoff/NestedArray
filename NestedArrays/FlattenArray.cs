using System;
using System.Collections;
using System.Collections.Generic;

namespace CitrusByte
{
    public static class Exercise
    {
        /// <summary>
        /// Given an array of arbitrarily nested arrays of integers, convert into a flat array of integers. 
        /// e.g. [[1,2,[3]],4] → [1,2,3,4].
        /// </summary>
        public static int[] FlattenArray(ArrayList toFlatten)
        {
            List<int> result = new List<int>();
            try {
                Recursive(toFlatten, ref result);
            }
            catch {
                result.Clear();
            }
            return result.ToArray();
        }

        /// <summary>
        /// Private method to flatten array. 
        /// </summary>
        private static void Recursive(ArrayList toFlatten, ref List<int> result)
        {
            if (result == null)
                result = new List<int>();

            for (int i = 0; i < toFlatten.Count; ++i)
            {
                if (toFlatten[i] is ArrayList) {
                    Recursive(toFlatten[i] as ArrayList, ref result);
                }
                else if (toFlatten[i] is int) {
                    result.Add((int)toFlatten[i]);
                }
                else {
                    throw new Exception("Expected an array of arrays or integers");
                }
            }
        }
    }
}
