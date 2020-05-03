// Solution

string lineEncoding(string s) {
    string newLine = "";
    int len = s.Length;

    for(int i = 0; i < len; i++) {
        char c = s[i];
        int j = i;
        int count = 0;
        bool breaker = true;
        while(breaker) {
            j++;
            if(j - len >= 0) {
                count++;
                newLine += Str(c, count);
                return newLine;
            }
            if(s[j] == c) count++;
            else {
                j--;
                breaker = false;
                count++;
            }
        }
        newLine += Str(c, count);
        i = j;
        breaker = true;
    }

    string Str(char inp, int times) => (times == 1) ? $"{inp}" : $"{times}{inp}";

    return newLine;
}
