public class Solution {
    public string ReorderSpaces(string text) {

        var words = new List<string>();              
        var currentWord = new StringBuilder();       

        int numOfSpaces = 0;

        for (int i = 0; i < text.Length; i++) {
            if (text[i] == ' ') {
                numOfSpaces++;
                if (currentWord.Length > 0) {
                    words.Add(currentWord.ToString());
                    currentWord.Clear();
                }
            } else {
                currentWord.Append(text[i]);
            }
        }

    
        if (currentWord.Length > 0) {
            words.Add(currentWord.ToString());
        }

        int numOfWords = words.Count;

        if (numOfWords == 1) {
            return words[0] + new string(' ', numOfSpaces);
        }

        int spacesPerGap = numOfSpaces / (numOfWords - 1);
        int extraSpaces = numOfSpaces % (numOfWords - 1);

        var resultSB = new StringBuilder();

        for (int i = 0; i < numOfWords; i++) {
            resultSB.Append(words[i]);

            if (i < numOfWords - 1) {
                for(int j = 0; j < spacesPerGap; j++){
                    resultSB.Append(' ');
                }
            }
        }

        for(int j = 0; j < extraSpaces; j++){
            resultSB.Append(' ');
        }
        

        return resultSB.ToString();
    }
}
