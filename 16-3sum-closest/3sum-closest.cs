public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        int size = nums.Length;
        int minAnswer = int.MaxValue;
        int result = 0;
        Array.Sort(nums);
        for(int i = 0; i < size - 2; i++){
            int left = i + 1;
            int right = size - 1;
            while(left < right){
                int sum = nums[i] + nums[left] + nums[right];
                int difference = Math.Abs(sum - target);
                if(difference == 0){
                    return sum;
                }
                if(minAnswer > difference){
                    result = sum;
                    minAnswer = difference;
                }

                if(sum > target){
                    right--;
                }else{
                    left++;
                }
            }
        }
            return result;
    }
}