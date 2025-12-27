public class Solution {
    public int CoinChange(int[] coins, int amount) {
        int[] dp = new int[amount + 1];

        for(int i = 0; i< dp.Length; i++){
            dp[i] = amount + 1;
        }

        dp[0] = 0;

        foreach(int coin in coins){
            for(int i = coin; i<= amount; i++){
                dp[i] = Math.Min( dp[i],dp[i - coin] + 1);
            }
        }

        return dp[amount] <= amount ? dp[amount] : -1;

    }
}