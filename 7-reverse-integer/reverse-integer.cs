public class Solution {
    public int Reverse(int x) {

        if(x==0){
            return x;
        }

        string numString = x.ToString();

        string result = "";

        bool minusFlag = false;
        if(numString[0] == '-'){
            minusFlag = true;
        }


        int end = 0;
        if(minusFlag){
            end = 1;
            result+= "-";
        }

        int prev = -1;
        
        for(int i = numString.Length -1; i>=end;i--){
            if(prev == -1 || prev == 0){
                if(numString[i].Equals('0')){
                    prev = 0;
                    continue;
                }
            }

            result += numString[i];
            prev = numString[i];
        }
        
        if(int.TryParse(result, out int reversed)){
            return reversed;
        }

        return 0;
    }
}