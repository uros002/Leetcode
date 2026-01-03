public class Solution {
    public int DeleteGreatestValue(int[][] grid) {
        var result = 0 ;

        for(var i = 0; i < grid.Length;i++){
            Array.Sort(grid[i]);
        }

        for(int i = grid[0].Length -1; i >= 0;i--){
            int max = 0;
            for(int j = 0; j < grid.Length; j++){
                max = Math.Max(max,grid[j][i]);
            }

            result += max;
        }

        return result;
    }
}