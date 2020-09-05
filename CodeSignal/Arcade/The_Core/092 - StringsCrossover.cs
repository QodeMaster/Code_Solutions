// Solution

int stringsCrossover(string[] inputArray, string result) {
    List<string[]> pairs = new List<string[]>();
    int count = 0;
    
    for(int i = 0; i < inputArray.Length; i++) {
        for(int j = i + 1; j < inputArray.Length; j++) {
            pairs.Add(new string[] { inputArray[i], inputArray[j] } );
        }
    }
    
    bool conf;
    foreach(string[] pair in pairs) {
        conf = true;
        for(int i = 0; i < pair[0].Length; i++) {
            if(result[i] != pair[0][i] && result[i] != pair[1][i]) {
                i = pair[0].Length;
                conf = false;
            }
        }
        if(conf) count++;
    }
    
    
    return count;
}
