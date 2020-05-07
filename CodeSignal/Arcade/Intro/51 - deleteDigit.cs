// Basic Solution

int deleteDigit(int n) {
    string num = n.ToString();
    int max = 0;
    
    for(int i = 0; i < num.Length; i++) {
        int processedNum = int.Parse(num.Remove(i, 1));

        if(max < processedNum) max = processedNum;
    }


    return max;
}


/*-------------------------------------------------------*/
/*-------------------------------------------------------*/

// Non-string solution

int deleteDigit(int n) {
    int l = (int)Math.Log10(n) + 1;
    double max = 0;
    
    for(int i = l; i > 0; i--) {
        double product = (n - (n % Math.Pow(10, i))) / 10 + n % Math.Pow(10, i - 1);
        if(max < product) max = product;
    }


    return (int)max;
}
