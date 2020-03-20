using System;
using System.Linq;

namespace KataDojo
{

    public class Kata
    {
        static void Main(string[] args)
        {
            
        }
        public static int CountBits(int n)
        {
            string binary = Convert.ToString(n, 2);
            int countOnes = binary.Count(x => x == '1');
            return countOnes;
        }
    }
}