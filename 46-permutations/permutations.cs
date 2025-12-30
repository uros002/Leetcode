public class Solution {

    private void BackTrack(int[] nums, List<int> tempList, IList<IList<int>> result){
        if(tempList.Count == nums.Length){
            result.Add(new List<int>(tempList));
        }else{
            foreach(int num in nums){
                if(tempList.Contains(num)) continue;

                tempList.Add(num);
                BackTrack(nums, tempList, result);
                tempList.RemoveAt(tempList.Count - 1);
            }
        }
    }

    public IList<IList<int>> Permute(int[] nums) {
        var result = new List<IList<int>>();
        BackTrack(nums,new List<int>(), result);
        return result;
    }
}