using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Task1
{
    public class WorkWithArray
    {
        public static long Solve(int[] arr)
        {
            Stopwatch st = new Stopwatch();
            st.Start();
            TreatmentArray(arr);
            st.Stop();
            return st.ElapsedMilliseconds;
        }
        private static int[] TreatmentArray(int[] arr)
        {
            List<int> outArr = new List<int>();
            outArr.Add(arr[0]);
            for (int i = 1; i < arr.Length; i++)
            {
                if (outArr.Last() == arr[i])
                    continue;
                else
                    outArr.Add(arr[i]);
            }
            return outArr.ToArray();
        }
    }
}
