// Solution

string findEmailDomain(string address) {
    string ret = "";

    for(int i = address.Length - 1; i >= 0; i--) {
        char c = address[i];
        if(c == '@') break;
        ret = c + ret;
    }

    return ret;
}
