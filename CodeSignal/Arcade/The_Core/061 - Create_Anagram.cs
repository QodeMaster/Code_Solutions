// Solution

int createAnagram(string s, string t) {
    int[] letters1 = new int[26];
    int[] letters2 = new int[26];
    
    for(int i = 0; i < s.Length; i++) {
        letters1[s[i] - 'A']++;
        letters2[t[i] - 'A']++;
    }
    
    for(int i = 0; i < letters1.Length; i++) {
        while(letters1[i] > 0 && letters2[i] > 0) {
            letters1[i]--;
            letters2[i]--;
        }
    }
    
    return letters1.Concat(letters2).Sum() / 2;
}
