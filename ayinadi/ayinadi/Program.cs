using System;

namespace ayinadi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region season

            string month = "avqust";
            if (month == "dekabr" || month == "yanvar" || month == "fevral")
            {
                Console.WriteLine("qis ayidir");
            }

            else if (month == "mart" || month == "aprel" || month == "may")
            {
                Console.WriteLine("yaz ayidir");
            }

            else if (month == "iyun" || month == "iyul" || month == "avqust")
            {
                Console.WriteLine("yay ayidir");
            }
            else if (month == "sentyabr" || month == "oktyabr" || month == "noyabr")
            {
                Console.WriteLine("payiz ayidir");
            }
            else
            {
                Console.WriteLine("bele bir ay yoxdur");
            }
        }
        #endregion

    }
}

