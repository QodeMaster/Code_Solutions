// Basic Solution

string characterParity(char symbol) {
    bool digit = char.IsDigit(symbol);
    
    if(digit) {
        if((symbol - '0') % 2 == 1) {
            return "odd";
        } else {
            return "even";
        }
    }
    
    return "not a digit";
}

/*--------------------------------------------------------*/
/*--------------------------------------------------------*/

// One-liner

string characterParity(char symbol) => (char.IsDigit(symbol) ? ((symbol - '0') % 2 == 1 ? "odd" : "even") : "not a digit");
