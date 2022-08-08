// Solution
// Inspired by l_aramyan

char[][] solution(int n) {
    char[][] start = new char[3][];
    start[0] = new char[] { ' ', '_', ' ' };
    start[1] = new char[] { ' ', ' ', '|' };
    start[2] = new char[] { ' ', '_', ' ' };
    
    for(int i = 2; i <= n; i++) start = NextIteration(start, i);
    
    return ReturnFinalView(start);
}

static char[][] Rotate(char[][] fr) {
    return Enumerable.Range(0,fr[0].Length).Select
        (j => Enumerable.Range(0,fr.Length).Select (
                i => fr[i][j] =='_' ? '|' : fr[i][j] == '|' ? '_' : ' ')
                .Reverse().ToArray()).ToArray();
}

static char[][] NextIteration(char[][] fr0, int n) {
    int len = fr0.Length;
    var fr1 = Rotate(fr0);
    var fr2 = Rotate(fr1);
    var fr3 = Rotate(fr2);
    char[][] res;
    if (n % 2 == 0) {
        char[] middle = $"|{new string(' ', 2 * len - 1)}|".ToCharArray();
        res = Enumerable.Range(0, len)
            .Select(i => MergeArrays(fr0[i], fr2[i]))
            .Union(new List<char[]>{middle}.Union
                (Enumerable.Range(0, len).Select(j => MergeArrays(fr1[j], fr1[j])))
            ).ToArray();
        res[len + 1][len] = '_';
    } else {
        char[] middle = $"{new string(' ', 2 * len + 1)}".ToCharArray();
        middle[len + 1] = '|';
        res = Enumerable.Range(0, len).Select(i => MergeArrays(fr0[i], fr3[i])).Union(
                new List<char[]> { middle }.Union
                (Enumerable.Range(0, len).Select(j => MergeArrays(fr2[j], fr3[j])))
            ).ToArray();
        res[0][len] = '_';
        res[2 * len][len] = '_';
    }
    
    return res;
}

static char[] MergeArrays(char[] a, char[] b) {
    List<char> res = a.ToList();
    res.Add(' ');
    res.AddRange(b);
    return res.ToArray();
}

static char[][] ReturnFinalView(char[][] input) {
    List<char[]> output = new List<char[]> { input[0] };
    
    for(int i = 2; i < input.Length; i+=2) {
        output.Add(Enumerable.Range(0, input[0].Length).Select
            (j => input[i][j] != ' ' ? input[i][j] : input[i - 1][j]).ToArray());
    }
    
    char[][] res = output.ToArray();
    
    for (int i = 0; i < res.Length; i++) {
        for (int j = 2; j < res[0].Length; j++) {
            if (res[i][j] == '_' 
            && res[i][j - 1] == ' ' 
            && res[i][j - 2] == '_') res[i][j-1] = '_';
        }
    }
    
    return res;
}
