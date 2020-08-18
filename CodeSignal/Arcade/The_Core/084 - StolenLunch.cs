// Solution

string stolenLunch(string note) {
    string dec = "";
    
    foreach(char c in note) {
        if(0 <= c - 'a' && c - 'a' < 10) dec += c - 'a';
        else if(0 <= c - '0' && c - '0' < 10) dec += (char)(c + '1');
        else dec += c;
    }
    
    return dec;
}
