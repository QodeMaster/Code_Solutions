int runnersMeetings(int[] startPosition, int[] speed) {
    int len = startPosition.Length;
    double[] st = startPosition.Select(x => (double)x).ToArray();
    double[] sp = speed.Select(x => (double)x).ToArray();
    
    List<string> value = new List<string>();
    List<int> freq = new List<int>(); 

    for(int i = 0; i < len - 1; i++) {
        for(int j = i + 1; j < len; j++) {
            double x = (sp[i] == sp[j] ? - 1 : ((st[j] - st[i]) / (sp[i] - sp[j])));
            double y = sp[i] * x + st[i];
            x = Math.Round(x, 3);
            y = Math.Round(y, 3);
            
            if(x <= 0) {} 
            else if(value.Contains($"{x},{y}")) {
                freq[value.IndexOf($"{x},{y}")]++;
            } else {
                value.Add($"{x},{y}");
                freq.Add(1);
            }
        }
    }
    return freq.Count == 0 ? -1 : inverseTriangular(freq.Max());
}

public static int inverseTriangular(int f) {
    return (int)((1 + Math.Sqrt(1 + 8 * f)) / 2);
}
