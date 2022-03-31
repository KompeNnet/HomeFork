using System;

namespace HomeFork.Helpers
{
    public static class SortingManager
    {
        public static int[] SortWithBubbles(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                throw new ArgumentException("Nothing to sort?");
            }

            var result = (int[]) nums.Clone();

            for (int i = 0, count = result.Length; i < count; i++)
            {
                for (int j = 0; j < count - 1; j++)
                {
                    if (result[j] > result[j + 1])
                    {
                        result.Swap(j, j + 1);
                    }
                }
            }

            return result;
        }

        public static int[] DoDatMergeSort(int[] nums, int s, int f)
        {
            if (nums == null || nums.Length == 0)
            {
                throw new ArgumentException("Nothing to sort?");
            }

            var result = (int[])nums.Clone();

            if (s < f)
            {
                int mid = (s + f) / 2;
                DoDatMergeSort(result, s, mid);
                DoDatMergeSort(result, mid + 1, f);
                Merge(result, s, mid, f);
            }

            return result;
        }

        private static void Merge(int[] nums, int s, int mid, int f)
        {
            int i, j;
            int cL = mid - s + 1;
            int cR = f - mid;

            var arrL = new int[cL];
            var arrR = new int[cR];

            Array.Copy(nums, s, arrL, 0, cL);
            Array.Copy(nums, mid + 1, arrR, 0, cR);

            i = j = 0;
            int k = s;

            while (i < cL && j < cR)
            {
                if (arrL[i] <= arrR[j])
                {
                    nums[k] = arrL[i++];
                }
                else
                {
                    nums[k] = arrR[j++];
                }
                k++;
            }

            while (i < cL)
            {
                nums[k++] = arrL[i++];
            }

            while (j < cR)
            {
                nums[k++] = arrR[j++];
            }
        }
    }
}
