// Solution

int pagesNumberingWithInk(int current, int numberOfDigits) {
    while(0 < numberOfDigits) {
        int digits = (int)Math.Log10(current++) + 1;
        numberOfDigits -= digits;
    }
    
    return numberOfDigits < 0 ? --current - 1 : --current;
}
