public class Solution {
    public int RemoveDuplicates(int[] nums) {
        var counter = 1;
        var size = nums.Length;
        
        var writeIndex = 0;
        for(int i = 0; i < nums.Length;i++){
            if(i != 0 && nums[i] == nums[i-1]){
                counter++;
            }else{
                counter = 1;
            }

            if(counter <= 2){
                nums[writeIndex] = nums[i];
                writeIndex++;
            }
        }

        return writeIndex;
    }
}