namespace ProblemsLib.LeetCode
{
    public class MedianOfTwoSortedArrays
    {
        private bool cursor1Used;
        private bool cursor2Used;
        private bool cursor1Completed;
        private bool cursor2Completed;

        int cursor1 = 0;
        int cursor2 = 0;
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int totalCount = nums1.Length + nums2.Length;
            int medianPosition = (totalCount / 2);

            cursor1Used = true;
            cursor1 = 0;
            cursor2 = 0;
            int currentValue = 0;

            bool even = totalCount % 2 == 0;
            if (even)
            {
                medianPosition--;
            }

            if (nums2.Length == 0 && nums1.Length == 0)
                return 0;

            if (nums2.Length == 0)
                return GetSingleArrayMedian(nums1);
            if (nums1.Length == 0)
                return GetSingleArrayMedian(nums2);

            for (int i = 0; i < totalCount; i++)
            {
                GetNextValue(nums1, nums2, out currentValue);

                if (medianPosition == i)
                {
                    if (even)
                    {
                        int nextVal;
                        GetNextValue(nums1, nums2, out nextVal);

                        return (currentValue + nextVal) / 2d;

                    }
                    else
                    {
                        return currentValue;
                    }
                }
            }

            return 0d;
        }

        private double GetSingleArrayMedian(int[] arr)
        {
            return arr.Length % 2 == 0 ? (arr[arr.Length / 2] + arr[arr.Length / 2 - 1]) / 2d : arr[arr.Length / 2];
        }

        private bool TryLookUpValue(int[] nums, int cursor, out int value)
        {
            if (cursor < nums.Length - 1)
            {
                value = nums[cursor];
                return true;
            }

            value = 0;
            return false;
        }


        private bool GetNextValue(int[] nums1, int[] nums2, out int value)
        {
            value = 0;

            if(!cursor2Completed && !cursor1Completed)
            {
                if (nums1[cursor1] < nums2[cursor2])
                {
                    value = nums1[cursor1];
                    cursor1Used = true;
                    cursor2Used = false;
                } else
                {
                    value = nums2[cursor2];
                    cursor2Used = true;
                    cursor1Used = false;
                }
            }

            if(cursor1Completed && !cursor2Completed)
            {
                value = nums2[cursor2];
                cursor2Used = true;
                cursor1Used = false;
            }

            if (cursor2Completed && !cursor1Completed)
            {
                value = nums1[cursor1];
                cursor1Used = true;
                cursor2Used = false;
            }

            if (cursor1Used)
            {
                if (cursor1 < nums1.Length - 1)
                {
                    cursor1++;
                }
                else
                {
                    cursor1Completed = true;
                }
            }

            if (cursor2Used)
            {
                if (cursor2 < nums2.Length - 1)
                {
                    cursor2++;
                }
                else
                {
                    cursor2Completed = true;
                }
            }

            return !cursor2Completed && !cursor1Completed;
        }
    }

}









/*private IEnumerable<int> IterateArrays(int[] nums1, int[] nums2)
{
    if(nums1[cursor1] < nums2[cursor2])
    {
        if (cursor1 < nums1.Length - 1 && cursor1Changed)
        {
            cursor1++;
            cursor1Changed = true;
        }

        yield return nums1[cursor1];
    }
}*/

