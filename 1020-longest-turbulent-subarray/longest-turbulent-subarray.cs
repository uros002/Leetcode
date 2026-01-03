public class Solution {
    public int MaxTurbulenceSize(int[] arr) {
        var maxSubarray = 1;
        var currentMax = 1; 
        var prev = 0;  // less than equals -1, greater than equals 1, are equal is 0
        for(int i = 1; i< arr.Length;i++){
            int curr;
            if(arr[i] > arr[i - 1]) curr = 1;
            else if(arr[i] < arr[i - 1]) curr = -1;
            else curr = 0;

            if(curr == 0){
                currentMax = 1;
            }else if(curr == -prev){
                currentMax++;
            }else{
                currentMax = 2;
            }

            prev = curr;
            maxSubarray = Math.Max(maxSubarray,currentMax);
        }

        return maxSubarray;
    }
}