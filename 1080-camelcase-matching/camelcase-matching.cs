public class Solution {
    public IList<bool> CamelMatch(string[] queries, string pattern) {
        List<bool> result = new List<bool>();
        
        foreach(var querie in queries){
            var index = 0;
            var isValid = true;

            foreach(var c in querie){
                if(index < pattern.Length && c == pattern[index]){
                    index++;   
                }else if(char.IsUpper(c)){
                    isValid = false;
                    break;
                }
            }

            if(index != pattern.Length){
                isValid = false;
            }

            result.Add(isValid);
        }

        return result;
    }
}