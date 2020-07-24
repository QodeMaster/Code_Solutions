// Solution

int mostFrequentDigitSum(int n) {
    List<int> sum = new List<int>();
    
    while(0 < n) {
        string num = n.ToString();
        int digSum = 0;
        for(int i = 0; i < num.Length; i++) digSum += num[i] - '0';
        sum.Add(digSum);
        n -= digSum;
    }
    
    return sum.GroupBy(i => i).OrderBy(g => g.Count()).Select(g => g.Key).ToList().Last();
}
