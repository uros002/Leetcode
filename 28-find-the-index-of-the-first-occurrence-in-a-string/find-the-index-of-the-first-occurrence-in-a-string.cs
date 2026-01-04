public class Solution {
    public int StrStr(string haystack, string needle) {
        var result = -1;
        var flag = true;
        var oneWordNeedle = false;
        var size = haystack.Length;

        if(needle.Length > haystack.Length){
            return -1;
        }

        for(int i = 0; i <= size - needle.Length ;++i){
                for(int j = 0; j < needle.Length; j++){
                        if(haystack[i+j] != needle[j]){
                            break;
                        }
                        if(j == needle.Length - 1) return i;
                    
                }
            }
        
        return -1;
    }
}