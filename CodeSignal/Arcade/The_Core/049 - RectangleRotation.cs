// Solution

int rectangleRotation(int a, int b) {
    int big = a < b ? b : a;
    int count = 0;
    double sqroot2 = 1 / Math.Pow(2, 0.5);
    double upperLimit(int c) => Math.Min(-c + a * sqroot2, c + b * sqroot2);
    double lowerLimit(int c) => Math.Max(c - b * sqroot2, -c - a * sqroot2);
    
    for(int i = -big; i <= big; i++) for(int j = -big; j <= big; j++) if(lowerLimit(j) < i && i < upperLimit(j)) count++;
    
    return count;
}
