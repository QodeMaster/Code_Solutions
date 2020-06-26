// Solution

int squareDigitsSequence(int a0) {
    int count = 0;
    List<int> uniqeNums = new List<int>();

    int Sum(int num) {
        if(uniqeNums.Contains(num)) return count;
        uniqeNums.Add(num);

        int tot = 0;
        int expon = (int)Math.Log10(num);

        while(expon >= 0) tot += Convert.ToInt32(Math.Pow((num - num % Math.Pow(10, expon)) / Math.Pow(10, expon--) % 10, 2));
        count++;


        return Sum(tot);
    }

    return Sum(a0) + 1;
}
