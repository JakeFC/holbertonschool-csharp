using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>MyMath class containing methods for math operations.</summary>
    public class Operations
    {
        /// <summary>Finds the max integer in a list of integers.</summary>
        /// <param name="nums">List of integers.</param>
        /// <returns>Returns the max integer in the list.</returns>
        public static int Max(List<int> nums)
        {
            if (nums.Count == 0)
            {
                return 0;
            }
            int max = nums[0];
            foreach (int x in nums)
            {
                if (x > max)
                    max = x;
            }
            return max;
        }
    }
}
