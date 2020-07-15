using System;
using textWriter = System.Console;
using System.Drawing;
using System.IO;
using System.Linq;

namespace HackerRank_Ex
{
    public class Program
    {
        static void Main(string[] args)
        {
            textWriter.WriteLine("Hello World!");
            textWriter.WriteLine("HackerRank excercises!");

            SockMerchant sock = new SockMerchant();
            //SockMerchant.Run();
            //CountingValleys.Run();
            JumpingOnClouds.Run();
        }
    }

    public class SockMerchant
    {
        static public void Run()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = 9;
            //Convert.ToInt32(Console.ReadLine());

            int[] ar = { 10, 20, 20, 10, 10, 30, 50, 10, 20, 20 };
            //Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            Console.WriteLine($"Sending are {ar.Count()} socks");

            int result = sockMerchant(n, ar);

            Console.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
        static private int sockMerchant(int n, int[] ar)
        {
            int numberOfPairs = 0;
            var colors = ar.GroupBy(x => x).OrderByDescending(x => x.Count()).Select(x => x.Key).ToArray();
            foreach (var color in colors)
            {
                int pairsOfCurrentColor = (ar.Where(x => x.Equals(color)).Count() / 2);
                if ((pairsOfCurrentColor) > 0)
                    numberOfPairs = numberOfPairs + (pairsOfCurrentColor);
            }

            return numberOfPairs;
        }
    }
    public class CountingValleys
    {
        static public void Run()
        {
            int n = 8;

            string s = "DDUUDDUDUUUD";

            int result = countingValleys(n, s);

            textWriter.WriteLine(result);

        }
        static private int countingValleys(int n, string s)
        {
            int altitude = 0;
            int numberOfValleys = 0;

            var inputs = s.ToCharArray();
            foreach (var input in inputs)
            {
                if (input.Equals('U'))
                {
                    altitude++;
                    if (altitude == 0) numberOfValleys++;
                }
                else altitude--;
            }

            return numberOfValleys;
        }
    }


    public class JumpingOnClouds
    {
        static public void Run()
        {
            int n = 6;// Convert.ToInt32(Console.ReadLine());

            int[] c = { 0, 0, 0, 0, 1, 0, 0, 1, 0 }; //Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
            ;
            int result = jumpingOnClouds(c);

            textWriter.WriteLine(result);
        }
        static private int jumpingOnClouds(int[] c)
        {
            int jumps = 0;
            int index = 0;
            int goal = c.Count()-1;
            while (index < goal)
            {
                    if ((index + 2) <= goal &&
                        c[index + 2].Equals(0))//Safe superjump
                    index = index + 2;
                else 
                    index = index + 1;
                jumps++;
            }

            return jumps;
        }
    }
}
