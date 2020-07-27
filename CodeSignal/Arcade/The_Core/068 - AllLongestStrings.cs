// Basic Solution

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

/*---------------------------------------------------------------------*/
/*---------------------------------------------------------------------*/

// Functional Solution

string[] allLongestStrings(string[] inputArray) {
    int length = inputArray.Max(word => word.Length);
    
    return inputArray.Where(x => x.Length == length).ToArray();
}

/*---------------------------------------------------------------------*/
/*---------------------------------------------------------------------*/

// Less efficient one-liner

string[] allLongestStrings(string[] inputArray) => inputArray.Where(x => x.Length == inputArray.Max(word => word.Length)).ToArray();
