// Solution

string messageFromBinaryCode(string code) {
    string decode = "";

    for(int i = 0; i < code.Length; i += 8) {
        string bin = "";

        for(int j = i; j < i + 8; j++) {
            bin += code[j];
        }

        decode += (char)Convert.ToInt32(bin, 2);
    }

    return decode;
}
