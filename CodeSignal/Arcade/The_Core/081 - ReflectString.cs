// Basic Solution

string reflectString1(string inputString) {
    string str = "";
    
    foreach(char c in inputString) {
        str += (char)('z' - c + 'a');
    }
    
    return str;
}

/*-------------------------------------------------------*/
/*-------------------------------------------------------*/

// One-liner

string reflectString(string inputString) => string.Join("", inputString.ToCharArray().Select(x => (char)('z' - x + 'a')));
