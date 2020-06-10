// Solution

int additionWithoutCarrying(int param1, int param2) {
    int newNum = 0;
    int log = (int)Math.Log10(Math.Max(param1, param2)) + 1;
    
    for(int i = 1; i <= log; i++) {
        int trailingNums = (int)Math.Pow(10 , i - 1);
        int par1 = (param1 % (trailingNums * 10) - param1 % trailingNums) / trailingNums;
        int par2 = (param2 % (trailingNums * 10) - param2 % trailingNums) / trailingNums;
        
        newNum += (((par1 + par2) % (trailingNums * 10)) % 10) * trailingNums;
    }
    
    
    return newNum;
}
