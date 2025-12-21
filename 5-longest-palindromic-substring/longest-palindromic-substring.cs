public class Solution {

    private bool Check(string s, int i, int j){
        while(i < j){
            if(!s[i].Equals(s[j])){
                return false;
            }
            i++;
            j--;
        }
        return true;
    }

    public string LongestPalindrome(string s) {
        int max = -1;
        int startIndex = 0;
        int stringSize = s.Length - 1;
        
        if(s.Length == 1){
            return s;
        }

        Console.WriteLine(stringSize);
        

        for(int i = 0; i < stringSize; i++){
            for(int j = i; j <= stringSize; j++){
                if(Check(s,i,j)){
                    int size = j-i + 1;
                    if(size > max){
                        max = size;
                        startIndex = i;
                    }

                }
                
            }
        }

        return s.Substring(startIndex,max);
    }
    
}