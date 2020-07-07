// Solution 

int crosswordFormation(string[] words) {
    return Iteration(words[0], words[1], words[2], words[3]) + 
    Iteration(words[0], words[1], words[3], words[2]) +
    Iteration(words[0], words[2], words[1], words[3]) +
    Iteration(words[0], words[2], words[3], words[1]) +
    Iteration(words[0], words[3], words[1], words[2]) +
    Iteration(words[0], words[3], words[2], words[1]) +
    Iteration(words[1], words[0], words[2], words[3]) +
    Iteration(words[1], words[0], words[3], words[2]) +
    Iteration(words[1], words[2], words[0], words[3]) +
    Iteration(words[1], words[2], words[3], words[0]) +
    Iteration(words[1], words[3], words[0], words[2]) +
    Iteration(words[1], words[3], words[2], words[0]) +
    Iteration(words[2], words[0], words[1], words[3]) +
    Iteration(words[2], words[0], words[3], words[1]) +
    Iteration(words[2], words[1], words[3], words[0]) +
    Iteration(words[2], words[1], words[0], words[3]) +
    Iteration(words[2], words[3], words[0], words[1]) +
    Iteration(words[2], words[3], words[1], words[0]) +
    Iteration(words[3], words[0], words[1], words[2]) +
    Iteration(words[3], words[0], words[2], words[1]) +
    Iteration(words[3], words[1], words[0], words[2]) +
    Iteration(words[3], words[1], words[2], words[0]) +
    Iteration(words[3], words[2], words[0], words[1]) +
    Iteration(words[3], words[2], words[1], words[0]);
    
}


int Iteration(string fWord, string sWord, string tWord, string foWord) {
    int count = 0;
    
    for(int i = 0; i < fWord.Length - 2; i++) {
        
        for(int k = 0; k < tWord.Length - 2; k++) {
            if(fWord[i] == tWord[k]) {
            
                for(int j = i + 2; j < fWord.Length; j++) {
                    
                    for(int l = 0; l < foWord.Length - 2; l++) {
                        if(fWord[j] == foWord[l]) {
                            
                            int hPoint = j - i;
                            int vPoint = l - k;
                            
                            for(int p = 0; p < sWord.Length - hPoint; p++) {
                                
                                for(int q = k + 2; q < tWord.Length; q++) {
                                    if(foWord.Length > q + vPoint) {
                                        if(sWord[p] == tWord[q] && sWord[p + hPoint] == foWord[q + vPoint]) count++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
    
    return count;
}
