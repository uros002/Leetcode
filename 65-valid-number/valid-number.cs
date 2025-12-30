public class Solution {
    public bool IsNumber(string s) {
        bool dotFlag = false;
        bool numFlag = false;
        bool eFlag = false;
        bool numAfterEFlag = true;

        s = s.Trim();

        for(int i = 0; i < s.Length; i++){
           if(char.IsDigit(s[i])){
                numFlag = true;
                if(eFlag) numAfterEFlag = true;
           }else if(s[i] == '+' || s[i] == '-'){
            if(i!= 0 && s[i-1] != 'e' && s[i-1] != 'E'){
                return false;
            }
           }else if(s[i] == '.'){
                if(dotFlag || eFlag){
                    return false;
                }
                dotFlag = true;
           }else if( s[i] == 'e' || s[i] == 'E'){
            if(eFlag || !numFlag){
                return false;
            }
            eFlag = true;
            numAfterEFlag = false;
           }else{
            return false;
           }
        }

        return numFlag && numAfterEFlag;
    }
}