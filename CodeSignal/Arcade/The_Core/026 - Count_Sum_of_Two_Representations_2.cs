// Solution

int countSumOfTwoRepresentations2(int n, int l, int r) {
    double half = n * 0.5;
    int count = (int)Math.Floor((double)Math.Min(half - l, r - half)) + 1;
    
    
    return (count < 0) ? 0 : count;
}
