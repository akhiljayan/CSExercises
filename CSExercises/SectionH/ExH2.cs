namespace CSExercises
{
    public class ExH2
    {
        //Write a static method: FindWord(string s1, string s2) that would return an integer.  
        //The method should find if the string s2 occurs in s1 and return an integer that would 
        //indicate the starting position of the word s2 in s1.  If the word does not occur 
        //the return value should be –1.

        public static int FindWord(string s1, string s2)
        {
            string s1Lower = s1.ToLower();
            string s2Lower = s2.ToLower();

            bool status = ExH1.InString(s1Lower, s2Lower);
            if (status)
            {
                string substrS2 = s2Lower.Substring(0, 1);
                char frstCharS2 = System.Convert.ToChar(substrS2);
                int position = s1Lower.IndexOf(frstCharS2);
                return position;
            }
            else
            {
                return -1;
            }
            
            
        }
    }
}
