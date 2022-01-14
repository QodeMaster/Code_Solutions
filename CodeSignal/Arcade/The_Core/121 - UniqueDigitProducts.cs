// Basic Solution

int solution(int[] a) {
    // Change every number to its digit product
    for(int i = 0; i < a.Length; i++) {
        a[i] = product(a[i]);
    }
    
    // Return distinct number of elements
    return a.Distinct().Count();
}

/*-----------------------------------------------------------------------------------------*/
/*-----------------------------------------------------------------------------------------*/

// Solution using HashSets

int solution(int[] a) {
    HashSet<int> uniqueNumbers = new HashSet<int>();
    int uniqueCount = 0;
    
    for(int i = 0; i < a.Length; i++) {
        if(!uniqueNumbers.Contains(product(a[i]))) {
            uniqueNumbers.Add(product(a[i]));
            uniqueCount++;
        }
    }
    
    return uniqueCount;
}


//---------------------------------------------------------------------------------------------
// Common used functions:

int product(int num) {
    int prod = 1;
    
    int digit = num % 10;
    while(num != 0) {
        prod *= digit;
        
        num /= 10;
        digit = num % 10;
    }
    
    return prod;
}
