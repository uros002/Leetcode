public class Solution {
    public int StrStr(string haystack, string needle) {
        var result = -1;
        var flag = true;
        var oneWordNeedle = false;
        var size = haystack.Length;

        if(needle.Length > haystack.Length){
            return -1;
        }

        if(needle.Length == 1){
            oneWordNeedle = true;
        }

        for(int i = 0; i < size;i++){

            if(haystack[i] == needle[0]){
                if(oneWordNeedle){
                    return i;
                }
                flag = true;
                for(int j = 1; j < needle.Length; j++){
                    if(i+j < size){
                      
                        if(haystack[i+j] != needle[j]){
                            flag = false;
                            break;
                        }
                        if(j == needle.Length - 1 && flag) return i;
                    }
                }
            }
        }

        return result;

    }
}