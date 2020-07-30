// Solution

int minimalNumberOfCoins(int[] coins, int price) {
    int[] dp = new int[price + 1];
    
    for(int i = 1; i <= price; i++) {
        
        for(int j = 0; j < coins.Length && (0 <= i - coins[j]); j++) {
            int placeHolder = (j == 0 ? 1000 : dp[i]);
            dp[i] = Math.Min(dp[i - coins[j]] + 1, placeHolder);
        }
    }
    
    return dp.Last();
}
