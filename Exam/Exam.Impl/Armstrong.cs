using System;

namespace Exam.Impl
{
    public class Armstrong
    {
        public bool IsArmstrong(int input)
        {
            int sum = 0;
            for(int i = input; i < 0; i = i / 10)
            {
                sum += (int)Math.Pow(i % 10, 3.0);
            }
            if (input == sum) return true;
            else return false;
        }
    }
}
