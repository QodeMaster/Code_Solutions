// Basic Solution

int digitDegree(int n) {
    int count = 0;

    int Sum(int num) {
        if(num < 10) return count;

        int tot = 0;
        int expon = (int)Math.Log10(n);

        while(expon >= 0) tot += Convert.ToInt32((num - num % Math.Pow(10, expon)) / Math.Pow(10, expon--) % 10);
        count++;


        return Sum(tot);
    }

    return Sum(n);
}
