public class Solution {
    public string LongestCommonPrefix(string[] strs) {

        string prefix = "";
        string shortestString = strs.MinBy(s=> s.Length);

        if (strs == null || strs.Length == 0 || shortestString.Equals("")){
            return "";
        }
        
        bool flag = false;
        bool shortFlag = false;
        int index = 0;

        while(!flag && !shortFlag){
            

           prefix+= shortestString[index];

            foreach(string str in strs){
                
                if(!str[index].Equals(prefix[index])){
                    flag = true;
                }
                
            }
            Console.WriteLine(prefix.Length);
            Console.WriteLine(index);
            Console.WriteLine(shortestString.Length);
            if(index >= shortestString.Length-1){
                shortFlag = true;
            }

            index++;
        }

        if(flag){
            return prefix.Remove(prefix.Length - 1);
        }

        if(prefix.Equals("") || !shortFlag){
            return prefix;
        }

        return prefix;
        

    }
}