using System;
using System.Text;

namespace defangedIPAddress
{
    class Program
    {
        public static void Main(string[] args)
        {
            string address = "255.100.50.0";
            defangedIPaddress(address);
        }
        static void defangedIPaddress(string S)
        {

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] is '.')
                {
                    sb.Append("[.]");
                }
                else
                {
                    sb.Append(S[i]);
                }
            }

            Console.WriteLine(sb);


        }

    }
}




