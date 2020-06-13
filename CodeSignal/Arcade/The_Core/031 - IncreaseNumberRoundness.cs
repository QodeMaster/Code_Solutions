// Solution

bool increaseNumberRoundness(int n) {
    int log = (int)Math.Log10(n) + 1;
    bool strike = false;
    
    for(int i = 1; i <= log; i++) {
        int trailingNums = (int)Math.Pow(10 , i - 1);
        int digit = (n % (trailingNums * 10) - n % trailingNums) / trailingNums;
        
        if(strike && digit == 0) return true;
        if(digit != 0) strike = true;
    }
    
    
    return false;

}
