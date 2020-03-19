// Simple solution
bool almostIncreasingSequence(int[] sequence) {
    int strike = 0; // Tracks the elements in the array that are deviating from strictly increasing 
    int max = -100000; // Lowest possible value
    int backupMax = -100000;
    
    foreach(int i in sequence) {
        if(i > max) {
            backupMax = max;
            max = i;
        } else if(i > backupMax) {
            strike++;
            max = i;
        } else strike++;
        
    }
    
    return strike <= 1; // Deviation count cannot be greater than 1
}
