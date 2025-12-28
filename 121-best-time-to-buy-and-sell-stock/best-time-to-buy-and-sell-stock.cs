public class Solution {
    public int MaxProfit(int[] prices) {
        int profit = 0;
        int minPrice = 99999999;

        int maxProfit = 0;
        foreach(int price in prices){
            if(price < minPrice){
                minPrice = price;
            }

            profit = price - minPrice;

            maxProfit = Math.Max(profit,maxProfit);

        }

        return maxProfit;
    }
}