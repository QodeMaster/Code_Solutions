// Solution

int depositProfit(int deposit, int rate, int threshold) {
    int count = 0;
    double dep = deposit * 1.0;

    while(threshold > dep) {
        dep *= 1 + rate * .01;
        count++;
    }

    return count;
}
