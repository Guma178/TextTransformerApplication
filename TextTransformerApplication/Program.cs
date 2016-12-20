using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextTransformerApp
{
    static class TextTransformer
    {
        public static string TransformTextUsingIterator(string str)
        {
            string outStr = "";
            if (str == null)
                return outStr+" ";
            IEnumerable<char> enumer = TextIterator(str);
            foreach (char c in enumer)
                outStr += c;
            return outStr;
        }

        public static IEnumerable<char> TextIterator(string str)
        {
            if (str == null)
                yield return ' ';
            for (int i = 0; i < str.Length; i++)
                yield return Char.ToUpper(str[i]);
        }

        public static string TransformTextUsingExplictGetEnumerator(string str)
        {
            string outStr = "";
            IEnumerator<char> enumer = str.GetEnumerator();
            while (enumer.MoveNext())
                outStr += Char.ToUpper(enumer.Current);
            return outStr;
        }

        public static string TransformTextUsingImplictGetEnumerator(string str)
        {
            string outStr = "";
            if (str == null)
                return outStr + " ";
            foreach (char c in str)
                outStr += Char.ToUpper(c);
            return outStr;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TextTransformer.TransformTextUsingIterator("dfeecec"));
            Console.WriteLine(TextTransformer.TransformTextUsingExplictGetEnumerator("rvrvdeDfe"));
            Console.WriteLine(TextTransformer.TransformTextUsingImplictGetEnumerator("eedjwkx/d"));
            Console.WriteLine(TextTransformer.TransformTextUsingIterator(null));
            Console.ReadKey();
        }
    }
}
