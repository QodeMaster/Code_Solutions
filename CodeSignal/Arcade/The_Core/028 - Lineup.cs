// Solution

int lineUp(string commands) {
    int count = 0;
    bool direction = true;
    
    foreach(char c in commands) {
        if(c != 'A') direction = !direction;
        if(direction) count++;
    }
    
    return count;
}
