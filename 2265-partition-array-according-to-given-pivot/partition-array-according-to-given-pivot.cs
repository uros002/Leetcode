public class Solution {
    public int[] PivotArray(int[] nums, int pivot) {
        var equal = new List<int>();
        var greater = new List<int>();
        var smaller = new List<int>();

        foreach(var num in nums)
        {
            if(num < pivot){
                smaller.Add(num);
            }else if(num > pivot){
                greater.Add(num);
            }else{
                equal.Add(num);
            }
        }

        var result = new int[nums.Length];
        int index = 0;

        foreach(var num in smaller) result[index++] = num;
        foreach(var num in equal) result[index++] = num;
        foreach(var num in greater) result[index++] = num;

        return result;
    }
}