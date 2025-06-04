using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Valid_parentheses
{
    class Class1
    {
        public static void Main(string[] args)
        {
            string s = "([]){";
            Console.WriteLine(IsValid(s));
        }

        public static bool IsValid(string s)
        {              
            if(s.Length == 1) return false;
            var Leftsymbols = new Stack<char>();
            var isTrue = false;
            
            foreach (char c in s)
            {
                if (c.Equals('(') || c.Equals('[') || c.Equals('{'))
                    Leftsymbols.Push(c);
                if (Leftsymbols.Count == 0)
                    return false;
                if (c == ')')
                {
  

                        if (Leftsymbols.First() == '(')
                        {
                            isTrue = true;
                            Leftsymbols.Pop();
                        }
                        else
                            return false;
                }
                if (c == ']') 
                {

                        if (Leftsymbols.First() == '[')
                        {
                            isTrue = true;
                            Leftsymbols.Pop();
                        }
                        else
                            return false;
                }
                if (c == '}') {

                        if (Leftsymbols.First() == '{')
                        {
                            isTrue = true;
                            Leftsymbols.Pop();
                        }
                        else
                            return false;
             
                }
            }
            if(Leftsymbols.Count > 0) 
                return false;
            return isTrue;
        }
    }

}

///if (c == ')')
/{
//    if (symbols.Count == 0)
//        isTrue = false;
//    else
//    {
//        h = symbols.First();
//        if (h == '(')
//        {
//            isTrue = true;
//            symbols.Pop();
//        }
//    }
//}

//if (c == ']')
//{
//    if (symbols.Count == 0)
//        isTrue = false;
//    else
//    {
//        h = symbols.First();
//        if (h == '[')
//        {
//            isTrue = true;
//            symbols.Pop();
//        }
//    }
//}
//if (c == '}')
//{
//    if (symbols.Count == 0)
//        isTrue = false;
//    else
//    {
//        h = symbols.First();
//        if (h == '{')
//        {
//            isTrue = true;
//            symbols.Pop();
//        }
//    }
//}


//if(symbols.Count > 0)
//{
//    return false;
//}