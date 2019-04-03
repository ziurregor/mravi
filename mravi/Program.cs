using System;

namespace mravi
{
    class Program
    {
        static void Main(string[] args)
        {

            string line;
            while ((line = Console.ReadLine()) != null)
            {
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                long a = Int64.Parse(split[0]);
                long b = Int64.Parse(split[1]);
                Console.WriteLine(Math.Abs(a - b));
            }





                //int l;
                //Console.WriteLine("Nvari");

                //l= Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine(l);

            }
    }
}
