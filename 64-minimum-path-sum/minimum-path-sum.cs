public class Solution {
    public int MinPathSum(int[][] grid) {
        var dp = new int[grid.Length][];
        var gridDim = grid[0].Length;
        for(var i = 0; i< dp.Length;i++){
            dp[i] = new int[gridDim];
        }

        for(var i = 0; i < grid.Length; i++){
            for(var j = 0; j < grid[i].Length; j++){
                if(i==0 && j==0){
                    dp[i][j] = grid[i][j];
                }else{
                    int iTemp = int.MaxValue;
                    int jTemp = int.MaxValue;
                    if(i != 0){
                        iTemp = dp[i-1][j];
                    }
                    if(j != 0){
                        jTemp = dp[i][j-1];
                    }
                    dp[i][j] = grid[i][j] + Math.Min(iTemp,jTemp);
                }
            }
        }

        return dp[dp.Length - 1][gridDim - 1];
    }
}