using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BdayCandles
{
    public class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(
                @System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();
            int result = Result.birthdayCakeCandles(candles);
          
            textWriter.WriteLine(result);
            textWriter.Flush();
            textWriter.Close();



        }
    }
}
