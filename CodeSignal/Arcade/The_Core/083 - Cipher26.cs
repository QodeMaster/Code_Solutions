// Solution

string cipher26(string message) {
    string decryp = $"{message[0]}";
    int tot = message[0] - 'a';
    
    for(int i = 1; i < message.Length; i++) {
        decryp += (char)(message[i] - tot + (message[i] - tot - 'a' < 0 ? 26 : 0));
        tot += decryp[i] - 'a';
        tot = tot % 26;
    }
    
    return decryp;
}
