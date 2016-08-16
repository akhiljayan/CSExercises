namespace CSExercises
{
    public class ExH1
    {
        public static bool InString(string s1, string s2)
        {
            string s1Lower = s1.ToLower();
            string s2Lower = s2.ToLower();

            bool status = s1Lower.Contains(s2Lower);
            return status;
        }
    } 
}
 