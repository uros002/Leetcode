public class Solution {
    public string IntToRoman(int num) {
        
        var result = new StringBuilder("");

        var map = new (int value, string symbol)[]
        {
            (1000, "M"),
            (900, "CM"),
            (500, "D"),
            (400, "CD"),
            (100, "C"),
            (90, "XC"),
            (50, "L"),
            (40, "XL"),
            (10, "X"),
            (9, "IX"),
            (5, "V"),
            (4, "IV"),
            (1, "I")
        };

        foreach(var (value, symbol) in map){
            while(num >= value){
                result.Append(symbol);
                num -= value;
            }
        }

        return result.ToString();

    }
}