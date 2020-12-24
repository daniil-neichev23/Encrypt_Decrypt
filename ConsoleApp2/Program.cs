using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   
    class Program
    {
        public static string Encrypt(string text, int n)
        {
            text = text.ToLower();

            if (text == null || text == "" || n <= 0)
            {
                return text;
            }
            for (int i = 0; i < n; i++)
            {
                string even = "";
                string odd = "";
                for (int j = 0; j < text.Length; ++j)
                {
                    if (j % 2 == 0)
                    {
                        odd += text[j];
                    }
                    else
                    {
                        even += text[j];
                    }
                }
                text = even + odd;
                //Console.WriteLine(text);
            }
            Console.WriteLine(text);
            return text;
        }


        public static string Decrypt(string text, int n)
        {
            text = text.ToLower();

            if (text == null || text == "" || n <= 0)
            {
                return text;
            }
            for (int i = 0; i < n; i++)
            {
                int halfSize = text.Length / 2;
                string even = "";
                string odd = "";
                even = text.Substring(0, halfSize);
                //Console.WriteLine(even);
              
                odd = text.Substring(halfSize);
                //Console.WriteLine(odd);
                text = "";
                for (int j = 0; j < odd.Length; ++j)
                {
                    if (odd.Length == even.Length)
                    {
                        text += odd[j];
                        text += even[j];
                    }
                    else
                    {
                        text += odd[j];
                        if (j != even.Length) text += even[j];
                    }
                    //Console.WriteLine(text);
                }
                
            }
            Console.WriteLine(text);
            return text;
        }


        static void Main(string[] args)
        {
            //string original = "Abcdefghij";
            string input = Console.ReadLine();
            //string text1 = "bdfhjacegi";
            //string text2 = "dhaeibfjcg";
            string encr = Encrypt(input, 2);
            string decr = Decrypt(encr, 2);

            //Decrypt(text1, 1);
            //Console.WriteLine(text2.Equals(Encrypt(input,2)));
            Console.ReadLine();
        }
    }
}
