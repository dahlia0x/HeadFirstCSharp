using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace List
{
    public class Program
    {
        static void Main(string[] args)
        {
            string zilch = "zero";
            string first = "one";
            string second = "two";
            string third = "three";
            string fourth = "4.2";
            string twopointtwo = "2.2";

            List<string> a = new List<string>();

            a.Add(zilch);
            a.Add(first);
            a.Add(second);
            a.Add(third);

            a.RemoveAt(2);

            if (a.Contains("two"))
                a.Add(twopointtwo);

            if (a.Contains("three"))
            {
                a.Add("four");
            }

            if (a.IndexOf("four") != 4)
            {
                a.Add(fourth);
            }

            PrintL(a);

        }

        public static void PrintL(List<string> a)
        {
            string result = "";

            foreach (string element in a)
            {
                result += "\n" + element;
            }

            Console.Write(result);
        }
    }
}
