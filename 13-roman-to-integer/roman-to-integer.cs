public class Solution {

    private int Check(char c) {
        switch (c) {
            case 'I': return 1;
            case 'V': return 5;
            case 'X': return 10;
            case 'L': return 50;
            case 'C': return 100;
            case 'D': return 500;
            case 'M': return 1000;
            default: return 0;
        }
    }

    private bool SpecialCheck(char i, char j,out int result){
        result = 0;
        switch(i){
            case 'I':
                if(j.Equals('V')){
                    result = 4;
                    return true;
                }else if(j.Equals('X')){
                    result = 9;
                    return true;
                }else{
                    return false;
                }
                break;
            case 'X':
                 if(j.Equals('L')){
                    result = 40;
                    return true;
                }else if(j.Equals('C')){
                    result = 90;
                    return true;
                }else{
                    return false;
                }
                break;
            case 'C':
                 if(j.Equals('D')){
                    result = 400;
                    return true;
                }else if(j.Equals('M')){
                    result = 900;
                    return true;
                }else{
                    return false;
                }
                break;
            default:
                return false;

        }
    }

    public int RomanToInt(string s) {
        int result = 0;

        for( int i = 0; i<s.Length;i++){
            if(i+1 < s.Length){
            if(SpecialCheck(s[i],s[i+1],out int num)){
                result += num;
                i++;
                continue;
            }
            }
            result += Check(s[i]);
        }

        return result;
    }
}