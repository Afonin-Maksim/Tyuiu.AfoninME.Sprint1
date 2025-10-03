using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AfoninME.Sprint1.Task6.V17.Lib
{
    public class DataService : ISprint1Task6V17
    {
        public bool CheckPalindrome(string value)
        {

            string clean = value.Replace(" ", "");

            
            char[] arr = clean.ToCharArray();
            Array.Reverse(arr);
            string reversed = new string(arr);

            return clean == reversed;
        }

    } 
    

    
}
