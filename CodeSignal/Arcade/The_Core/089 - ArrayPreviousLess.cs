// Solution

int[] arrayPreviousLess(int[] items) {
    
    for(int i = items.Length - 1; 0 <= i; i--) {
        bool breaker = true;
        
        for(int j = i - 1; (0 <= j) && breaker; j--) {
            if(items[j] < items[i]) {
                items[i] = items[j];
                breaker = false;
            }
        }
        if(breaker) items[i] = -1;
    }
    
    return items;
}
