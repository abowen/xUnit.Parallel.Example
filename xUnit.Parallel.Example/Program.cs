using System;
using System.Threading.Tasks;

namespace xUnit.Parallel.Example
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public async static Task<int> LongRunningMethod(int value)
        {
            await Task.Delay(value);
            return value;
        }
    }
}
