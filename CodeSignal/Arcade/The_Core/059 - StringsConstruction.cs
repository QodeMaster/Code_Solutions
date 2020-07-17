// Solution

int stringsConstruction(string a, string b) {
    int[] letters = new int[26];
    int[] target = new int[26];
    int count = -1;
    
    foreach(char c in a) letters[c - 'a']++;
    foreach(char c in b) target[c - 'a']++;
    
    while(!target.Any(x => x < 0)) {
        for(int i = 0; i < target.Length; i++) {
            target[i] -= letters[i];
        }
        count++;
    }
    
    return count;
}
