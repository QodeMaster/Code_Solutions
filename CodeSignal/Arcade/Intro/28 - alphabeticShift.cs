// Solution

string alphabeticShift(string inputString) {
    string ret = "";
    
    foreach(char i in inputString) {
        if(i == 'z') ret += "a";
        else ret += (char)((int)i + 1);
    }
    
    return ret;
}
