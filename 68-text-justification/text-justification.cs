public class Solution
{
    public IList<string> FullJustify(string[] words, int maxWidth)
    {
        List<string> result = new List<string>();
        int index = 0;

        while (index < words.Length)
        {
            int lineLength = words[index].Length;
            int last = index + 1;

            
            while (last < words.Length)
            {
                if (lineLength + 1 + words[last].Length > maxWidth)
                    break;

                lineLength += 1 + words[last].Length;
                last++;
            }

            StringBuilder sb = new StringBuilder();

            int numberOfWords = last - index;
            int numberOfSpaces = maxWidth - lineLength + (numberOfWords - 1);

           
            if (last == words.Length || numberOfWords == 1)
            {
                for (int i = index; i < last; i++)
                {
                    sb.Append(words[i]);
                    if (i < last - 1)
                        sb.Append(" ");
                }

                while (sb.Length < maxWidth)
                    sb.Append(" ");
            }
            else
            {
                
                int spacesPerGap = numberOfSpaces / (numberOfWords - 1);
                int extraSpaces = numberOfSpaces % (numberOfWords - 1);

                for (int i = index; i < last; i++)
                {
                    sb.Append(words[i]);

                    if (i < last - 1)
                    {
                        for (int s = 0; s < spacesPerGap; s++)
                            sb.Append(" ");

                        if (extraSpaces > 0)
                        {
                            sb.Append(" ");
                            extraSpaces--;
                        }
                    }
                }
            }

            result.Add(sb.ToString());
            index = last;
        }

        return result;
    }
}
