// Solution

int commonCharacterCount(string s1, string s2) {
    int[] first = new int[26];
    int[] second = new int[26];
    Array.Fill(first, 0);
    Array.Fill(second, 0);
    
    int commonChar = 0;
    
    foreach(char i in s1) first[(int)i - 97]++; // Counting down how many of each letter
    foreach(char i in s2) second[(int)i - 97]++;
    
    for(int i = 0; i < 26; i++) {
        
        while(first[i] != 0 && second[i] != 0) { // Counting the common letters
            first[i]--;
            second[i]--;
            commonChar++;
        }
    }
    
    return commonChar;
}
