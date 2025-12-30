public class Solution {
    public bool IsValidSudoku(char[][] board) {
        bool[,] rowValid = new bool[9,9];
        bool[,] columnValid = new bool[9,9];
        bool[,] boxValid = new bool[9,9];

        for(int i = 0; i < 9;i++){
            for(int j = 0; j < 9; j++){
                if(board[i][j] != '.'){
                    int num = board[i][j] - '1';
                    int boxIndex = (i/3) * 3 + (j/3);

                    if(rowValid[i,num] || columnValid[j,num] || boxValid[boxIndex,num]){
                        return false;
                    }

                    rowValid[i,num] = columnValid[j,num] = boxValid[boxIndex,num] = true;
                }
            }
        }
        return true;
    }
}