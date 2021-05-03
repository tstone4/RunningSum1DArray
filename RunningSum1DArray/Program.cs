using System;

namespace RunningSum1DArray
{
    class Program
    {
        static void Main()
        {
            int[] nums = new int[] { 3, 1, 2, 10, 1 };
            Program program = new Program();
            program.RunningSum(nums);
            for(int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + ",");
            }
            Console.WriteLine("");
        }



        public int[] RunningSum(int[] nums)
        {
            if (nums.Length == 0 || nums.Length == 1)
                return nums;

            int runningTotal = nums[0];
            for(int i = 1; i < nums.Length; i++)
            {
                nums[i] = runningTotal + nums[i];
                runningTotal = nums[i];
            }

            return nums;
        }
    }
}
