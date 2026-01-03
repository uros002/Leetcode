public class Solution {
    public int CountWays(int[][] ranges) {
        Array.Sort(ranges, (a,b) => a[0].CompareTo(b[0]));

        int groups = 1;
        int currentEnd = ranges[0][1];

        for(int i = 1; i < ranges.Length; i++){
            if(ranges[i][0] > currentEnd){
                groups++;
                currentEnd = ranges[i][1];
            }else{
                currentEnd = Math.Max(currentEnd,ranges[i][1]);
            }
        }

        long result = 1;
        for(int i = 0; i < groups; i++){
            result = (result * 2) % 1000000007;
        }

        return (int)result;
    }
}