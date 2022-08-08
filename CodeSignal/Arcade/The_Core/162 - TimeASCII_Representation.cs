// Solution
// Inspired by casper_h3

char[][] solution(char[][] dtime) {
    TimeSpan time = ReadTime(dtime);
    char[][] result = Round();
    
    SetHand(result, (time.Hours * 60.0 + time.Minutes) / 720.0);
    SetHand(result, (double)time.Minutes / 60.0);
    
    return result;
}

Dictionary<string, int> digits = new Dictionary<string, int>() {
    { "****.**.**.*", 0 },
    { ".*..*..*..*.", 1 },
    { "***..*****..", 2 },
    { "***..****..*", 3 },
    { "*.**.****..*", 4 },
    { "****..***..*", 5 },
    { "****..****.*", 6 },
    { "***..*..*..*", 7 },
    { "****.*****.*", 8 },
    { "****.****..*", 9 },
};

TimeSpan ReadTime(char[][] dtime) {
    int time = 0;
    int[] arr = new int[] { 1, 5, 10, 14 };
    foreach(int num in arr) {
        string key = new string(new [] {0, 7, 8, 9}
            .SelectMany(r => Enumerable.Range(num, 3)
            .Select(c => dtime[r][c]))
            .ToArray());
        
        digits.TryGetValue(key, out int digit);
        time = 10 * time + digit;
    }
    
    return TimeSpan.FromMinutes((time / 100 * 60) + time % 100);
}

char[][] Round() {
    return new char[][] {
        "....*********....".ToArray(),
        "...**.......**...".ToArray(),
        "..**.........**..".ToArray(),
        ".**...........**.".ToArray(),
        "**.............**".ToArray(),
        "*...............*".ToArray(),
        "*...............*".ToArray(),
        "*...............*".ToArray(),
        "*...............*".ToArray(),
        "*...............*".ToArray(),
        "*...............*".ToArray(),
        "*...............*".ToArray(),
        "**.............**".ToArray(),
        ".**...........**.".ToArray(),
        "..**.........**..".ToArray(),
        "...**.......**...".ToArray(),
        "....*********....".ToArray(),
    };
}

double maxDist = Math.Sqrt(0.5);
void SetHand(char[][] clock, double pos) {
    clock[8][8] = '*';
    double sin = Math.Sin(pos * Math.PI * 2.0);
    double cos = -Math.Cos((double) pos * Math.PI * 2.0);
    for (double i = 0.0; i <= 8.0; i += 0.2) {
        double yd = 8 + cos * i;
        double xd = 8 + sin * i;

        for(int y = (int)yd - 1; y <= (int)yd + 1; y++) {
            if (y < 0 || y > 17) continue;
            for (int x = (int)xd - 1; x <= (int)xd + 1; x++) {
                if (x < 0 || x > 17) continue;
                double dist = Math.Abs(Math.Sqrt((yd - y) * (yd - y) + (xd - x) * (xd - x)));
                if (dist < maxDist) clock[y][x] = '*';
            }
        }
    }
}
