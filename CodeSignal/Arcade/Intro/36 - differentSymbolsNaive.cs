// Basic Solution

int differentSymbolsNaive(string s) {
    int[] cab = new int[27];
    int letters = 0;

    for(int i = 0; i < s.Length; i++) { 
        cab[(int)s[i] - 97]++;
    }

    for(int i = 0; i < cab.Length; i++) {
        if(cab[i] > 0) letters++;
    }

    return letters;
}

/*--------------------------------------------------*/
/*--------------------------------------------------*/

// Shorter Solution

int differentSymbolsNaive(string s) {
    int[] cab = new int[27];
    int letters = 0;

    foreach(char a in s) cab[(int)a - 97]++;

    foreach(int i in cab) if(i > 0) letters++;

    return letters;
}
