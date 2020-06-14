// Solution

int candles(int candlesNumber, int makeNew) {
    int count = 0;
    int leftOver = 0;
    
    while(true) {
        count += candlesNumber;
        leftOver += candlesNumber;
        candlesNumber = (leftOver - leftOver % makeNew) / makeNew;
        leftOver -= candlesNumber * makeNew;
        
        if(leftOver == 0 && candlesNumber == 0) return count + candlesNumber;
        if(leftOver == leftOver % makeNew && candlesNumber == 0) return count;
    }
}
