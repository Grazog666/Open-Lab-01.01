using System;
namespace Open_Lab_01._01
{
    public class Exercise
    {
        public bool IsLessThan10(string input)
        {
            int gg;
            Int32.TryParse(input, out gg);
            if (gg < 10)
            {
                return true;
            }
            else
            {
                return false;
                ;
            }
        }
    }
}