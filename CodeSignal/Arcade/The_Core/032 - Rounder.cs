// Basic Solution

int rounders(int n) {
    int log = (int)Math.Log10(n) + 1;
    
    for(int i = 1; i <= log; i++) {
        int trailingNums = (int)Math.Pow(10 , i - 1);
        int digit = (n % (trailingNums * 10)) / trailingNums;
        n -= n % trailingNums;
        if(5 <= digit && log != i) n += trailingNums * 10;
    }
    
    
    return n;
}

/*---------------------------------------------------*/
/*---------------------------------------------------*/

// Recursive solution

int rounders(int n) {
    int log = (int)Math.Log10(n) + 1;
    
    int shrink(int num, int limit) {
        if(log < limit) return num;
        
        int trailingNums = (int)Math.Pow(10 , limit - 1);
        int digit = (num % (trailingNums * 10)) / trailingNums;
        num -= num % trailingNums;
        if(5 <= digit && log != limit) num += trailingNums * 10;
        return shrink(num, limit + 1);
    }
    
    
    return shrink(n, 1);
}
