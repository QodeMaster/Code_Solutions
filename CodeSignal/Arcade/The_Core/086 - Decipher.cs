// Solution

string decipher(string cipher) {
    string decryp = "";
    
    int letter = 0;
    for(int i = 0; i < cipher.Length; i++) {
        letter = letter * 10 + (cipher[i] - '0');
        if(96 < letter) {
            decryp += (char)letter;
            letter = 0;
        }
    }
    
    return decryp;
}
