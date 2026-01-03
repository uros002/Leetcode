public class Solution {
    public int AlternatingSubarray(int[] nums) {
        var current = 0;
        var max = 0;
        int prev = 0;
        
        for(int i = 1; i < nums.Length; i++){
            int diff = nums[i] - nums[i - 1];
            
            if(diff != 1 && diff != -1){
                current = 0;
                prev = 0;
                continue;
            }
            
            if(diff == -prev || prev == 0){
                if(prev == 0 && diff != 1){
                    current = 0;
                    prev = 0;
                    continue;
                }
                current++;
            }else{
               if(diff == 1){
                    current = 1;
                }else{
                    current = 0;
                    prev = 0;
                    continue;
                }
            }

            prev = diff;
            max = Math.Max(max, current);
        }

        if(max == 0){  // Changed from max < 2
            return -1;
        }

        return max + 1;
    }
}