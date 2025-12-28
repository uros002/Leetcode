public class Solution {
    public bool CanJump(int[] nums) {
        int lastIndex = nums.Length - 1;
        if(lastIndex == 0 ){
            return true;
        }
        bool result = false;
        int maxReach = 0;

        for(int i = 0; i < nums.Length;i++){
            int currentReach = i + nums[i];
            maxReach = Math.Max(maxReach,currentReach);

            if(nums[i] == 0 && maxReach == i && maxReach != lastIndex){
                return false;
            }

            if(maxReach >= lastIndex){
                result = true;
            }

        }
        
        return result;

    }
}