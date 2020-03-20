// Basic solution

string[] allLongestStrings(string[] inputArray) {
    int maxLen = 0;
    List<string> ret = new List<string>();
    
    for(int i = 0; i < inputArray.Length; i++) {
        if(inputArray[i].Length > maxLen) {
            maxLen = inputArray[i].Length;
        }
    }
    
    for(int j = 0; j < inputArray.Length; j++) {
        if(inputArray[j].Length == maxLen) {
            ret.Add(inputArray[j]);
        }
    }
    
    
    return ret.ToArray();
}

/*-------------------------------------*/
/*-------------------------------------*/

// Shorter foreach solution

string[] allLongestStrings(string[] inputArray) {
    int maxLen = 0;
    List<string> ret = new List<string>();
    
    foreach(string i in inputArray) if(i.Length > maxLen) maxLen = i.Length;
    
    foreach(string j in inputArray) if(j.Length == maxLen) ret.Add(j);
    
    
    return ret.ToArray();
}
