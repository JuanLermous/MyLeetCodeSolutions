namespace _9_Palindrome_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(1214));
        }
        public static bool IsPalindrome(int x)
        {
            if(x < 0) return false; 
            List<int> list = new List<int>();
            string backwards = "";
            int length = x.ToString().Length;
            foreach (int c in x.ToString()) {
                list.Add(c);
            }

            for (int i = 0; i < x.ToString().Length; i++){
                length -= 1;
                backwards += list.ElementAt(length).ToString();
                
            }
            

            return (backwards == x.ToString());
        }
    }
}
