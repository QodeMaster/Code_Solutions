// Solution

int numberOfClans(int[] divisors, int k) {
    List<string> unique = new List<string>();
    int count = 0;
    
    for(int i = 1; i <= k; i++) {
        string num = "";
        foreach(int n in divisors) num += (i % n == 0 ? "1" : "0");
        count += (unique.Contains(num) ? 0 : 1);
        unique.Add(num);
    }
    
    return count;
}
