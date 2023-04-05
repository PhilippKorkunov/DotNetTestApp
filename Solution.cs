using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace DotNetTestApp
{
    public class Solution
    {
        public static int[] solution(string[] A, string[] B)
        {
            string pattern = String.Join("|", B.Select(x => $@"\w*{x}$"));
            Regex regex = new(pattern, RegexOptions.Compiled);

            List<int> answer = new();

            for (int i = 0; i < A.Length; i++)
            {
                //Console.WriteLine($"{i}) {A[i]}");
                if (!regex.IsMatch(A[i]))
                {
                    answer.Add(i);
                }
            }

            return answer.ToArray();
        }

    }
}
