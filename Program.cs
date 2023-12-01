using System;
using System.Collections.Generic;
using System.Text;

namespace Test2
{
    public class Program
    {
       

        public static void Main()
        {
            var set = new[] {
    new
    {
        Arr = new string[] { "abc","xyz"},
        Source = "helloxyzhxyzabc"
    },
    new
    {
        Arr = new string[] { "ab", "bc","cd" },
        Source = "helloabbccd"
    },
    new
    {
        Arr = new string[] { "a", "a", "c", "d" },
        Source = "acdxyzacad"
    },
    new
    {
        Arr = new string[] { "oybek", "akmal" },
        Source = "oybeklakmaloybek"
    },
    new
    {
        Arr = new string[] { "a", "a", "c", "d" },
        Source = "abcadac"
    }
}.ToList();
            set.Add(new
            {
                Arr = Enumerable.Range(0, 5000).Select(x => "a").ToArray(),
                Source = "".PadLeft(10000, 'a')
            });





            Solution solution = new Solution();

            foreach (var item in set)
            {
                var ints = solution.Solve(item.Arr, item.Source);
                var sb = new StringBuilder();
                foreach (var el in item.Arr)
                {
                    sb.Append($"\"{el}\", ");
                }
                sb.AppendLine();
                sb.AppendFormat("Source: {0}", item.Source).AppendLine();
                sb.Append("[");
                foreach (var res in ints)
                {
                    sb.Append(res).Append(", ");
                }
                sb.Append("]").AppendLine();
                Console.WriteLine(sb);
            }


            Console.ReadKey();
        }
    }

}