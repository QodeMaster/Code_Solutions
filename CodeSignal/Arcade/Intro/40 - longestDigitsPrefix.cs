// Solution

string longestDigitsPrefix(string inputString) {
    string rt = "";
    if(!Char.IsDigit(inputString[0])) return rt;
    else {
        foreach(char a in inputString) {
            if(!Char.IsDigit(a)) break;
            else rt += a;
        }
    }


    return rt;
}
