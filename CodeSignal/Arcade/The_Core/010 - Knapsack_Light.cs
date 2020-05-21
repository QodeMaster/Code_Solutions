// Basic Solution

int knapsackLight(int value1, int weight1, int value2, int weight2, int maxW) {
    if(weight1 + weight2 <= maxW) return value1 + value2;
    if(maxW < weight1 && maxW < weight2) return 0;
    if(weight1 > maxW) return value2;
    if(weight2 > maxW) return value1;
    return Math.Max(value1,value2);
}

/*------------------------------------------------------------------------*/
/*------------------------------------------------------------------------*/

// Dynamic programming solution

int knapsackLight(int value1, int weight1, int value2, int weight2, int maxW) {
    int[] values = new int[] {value1, value2};
    int[] weights = new int[] {weight1, weight2};

    int[][] cap = new int[values.Length + 1][];

    for(int i = 0; i <= weights.Length; i++) {
        int[] row = new int[maxW + 1];
        for(int j = 0; j <= maxW; j++) {
            if(i == 0)  row[j] = 0;
            else {
               row[j] = cap[i - 1][j]
               if(weights[i - 1] <= j) row[j] = Math.Max(values[i - 1] + cap[i - 1][j - weights[i - 1]], cap[i - 1][j]);
            }
        }
        cap[i] = row;
    }

    
    return cap[weights.Length][maxW];
}
