// Basic Solution

int appleBoxes(int k) {
    int total = 0;
    bool countTurn = true;
    
    for(int i = 1; i <= k; i++) {
        if(countTurn) total -= i * i;
        else total += i * i;
        countTurn = !countTurn;
    }
    
    return total;
}

/*------------------------------------------*/
/*------------------------------------------*/

// Solution with a ternary operator

int appleBoxes(int k) {
    int total = 0;
    bool countTurn = true;
    
    for(int i = 1; i <= k; i++) {
        total += countTurn ? -(i * i) : i * i;
        countTurn = !countTurn;
    }
    
    return total;
}
