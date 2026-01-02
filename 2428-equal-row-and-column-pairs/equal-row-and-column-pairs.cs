public class Solution {
    public int EqualPairs(int[][] grid) {
        var result = 0;
        var map = new Dictionary<string,int>();
        for(int i = 0; i < grid.Length; i++){
           string key = string.Join(",",grid[i]);

           if(!map.ContainsKey(key)){
            map[key] = 0;
           }

           map[key]++;
        }

        int counter = 0;

        for(int i = 0; i < grid[0].Length;i++){
            int[] col = new int[grid[0].Length];
            for(int j = 0; j < grid.Length; j++){
                col[j] = grid[j][i];
            }

            string key = string.Join(",",col);

            if(map.ContainsKey(key)){
                counter+= map[key];
            }
        }

        return counter;
    }
}