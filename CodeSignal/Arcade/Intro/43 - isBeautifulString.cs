// Solution

bool isBeautifulString(string inputString) {
    int[] letter = new int[27];

    foreach(char c in inputString) letter[c - 'a']++;
    for(int i = 1; i < letter.Length; i++) if(letter[i - 1] < letter[i]) return false;


    return true;
}
