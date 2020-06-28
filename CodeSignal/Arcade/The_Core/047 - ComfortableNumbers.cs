// Solution

int comfortableNumbers(int l, int r) {
    int count = 0;
    int Sum(int num) {
        int tot = 0;
        int expon = (int)Math.Log10(num);

        while(expon >= 0) tot += Convert.ToInt32((num - num % Math.Pow(10, expon)) / Math.Pow(10, expon--) % 10);

        return tot;
    }
    
    bool mutualCom(int n, int m, int digSum) => Math.Abs(m - n) <= Math.Min(digSum, Sum(m));
    
    for(int i = l; i <= r; i++) {
        int digit = Sum(i);
        
        int j = 1;
        while(0 <= digit - j && i + j <= r) if(mutualCom(i, i + j++, digit)) count++;
        
        j = 1;
        while(0 <= digit - j && l <= i - j) if(mutualCom(i, i - j++, digit)) count++;
    }
    
    return count / 2;
}
