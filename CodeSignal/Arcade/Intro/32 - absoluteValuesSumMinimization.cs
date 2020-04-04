// Solution 

int absoluteValuesSumMinimization(int[] a) {
    int min = -1;
    int ret = 0;

    foreach(int i in a) {
        int sum = 0;

        foreach(int j in a) sum += Math.Abs(i - j);

        if(min == -1 || sum < min) {
            min = sum;
            ret = i;
        }
    }

    return ret;
}
