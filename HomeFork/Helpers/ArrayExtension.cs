namespace HomeFork.Helpers
{
    public static class ArrayExtension
    {
        public static int[] Swap(this int[] nums, int idx1, int idx2)
        {
            var temp = nums[idx1];
            nums[idx1] = nums[idx2];
            nums[idx2] = temp;

            return nums;
        }
    }
}
