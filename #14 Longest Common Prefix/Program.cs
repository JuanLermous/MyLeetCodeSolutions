//Write a function to find the longest common prefix string amongst an array of strings.

//If there is no common prefix, return an empty string "".



//Example 1:

//Input: strs = ["flower", "flow", "flight"]
//Output: "fl"

//Example 2:

//Input: strs = ["dog", "racecar", "car"]
//Output: ""
//Explanation: There is no common prefix among the input strings.



//Constraints:

//    1 <= strs.length <= 200
//    0 <= strs[i].length <= 200
//    strs[i] consists of only lowercase English letters if it is non-empty.




using System.Globalization;

namespace _14_Longest_Common_Prefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strs = ["flower", "flow", "flight"];
            Console.WriteLine(LongestCommonPrefix(strs));
        }
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) return "";
            string prefix = strs[0]; //we store the first word of the array here, for further comparassions
            for (int i = 0; i < strs.Length; i++) {
                //we start a loop, to pass each wor of the array
                while (!strs[i].StartsWith(prefix))
                {
                    //this while loop will stop until the current word of the array starts with prefix
                    //if there is no coincidences between all the words, the prefix will be "" and that's the value that will return
                    //when the loops ends, the comoon prefix will be returned
                    prefix = prefix.Substring(0,prefix.Length - 1);
                    if (prefix == "") return "";
                }
            
            }
            return prefix;
           
        }
    }
}
