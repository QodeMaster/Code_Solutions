// Solution

bool isSubstitutionCipher(string string1, string string2) {
    char[] letters = new char[26].Select(x => ' ').ToArray();
    char[] letters2 = letters.ToArray();
    
    for(int i = 0; i < string1.Length; i++) {
        if(letters[string1[i] - 'a'] == ' ') letters[string1[i] - 'a'] = string2[i];
        else if(letters[string1[i] - 'a'] != string2[i]) return false;
    }
    
    for(int i = 0; i < string1.Length; i++) {
        if(letters2[string2[i] - 'a'] == ' ') letters2[string2[i] - 'a'] = string1[i];
        else if(letters2[string2[i] - 'a'] != string1[i]) return false;
    }
    
    return true;
}
