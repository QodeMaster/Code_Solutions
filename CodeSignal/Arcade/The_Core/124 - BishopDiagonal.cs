// Solution

string[] solution(string bishop1, string bishop2) {
    int letter1 = bishop1[0] - 'a';
    int digit1  = bishop1[1] - '1';
    
    int letter2 = bishop2[0] - 'a';
    int digit2  = bishop2[1] - '1';
    
    if(Math.Abs(bishop1[0] - bishop2[0]) != Math.Abs(bishop1[1] - bishop2[1])) {
        if(digit1 < digit2) {
            return new string[] { bishop1, bishop2 };
        } else return new string[] { bishop2, bishop1 };
    } else {
        if(letter1 - letter2 < 0 && 0 < digit1 - digit2) {
            // If bishop2 is down-right of bishop1
            while(0 < letter1 && digit1 < 7) {
                letter1--;
                digit1++;
            }
            while(0 < digit2 && letter2 < 7) {
                letter2++;
                digit2--;
            }
        } else if(0 < letter1 - letter2 && 0 < digit1 - digit2) {
            // If bishop2 is down-left of bishop1
            while(letter1 < 7 && digit1 < 7) {
                letter1++;
                digit1++;
            }
            while(0 < digit2 && 0 < letter2) {
                letter2--;
                digit2--;
            }
        } else if(0 < letter1 - letter2 && digit1 - digit2 < 0) {
            // If bishop2 is up-left of bishop1
            while(0 < digit1 && letter1 < 7) {
                letter1++;
                digit1--;
            }
            while(0 < letter2 && digit2 < 7) {
                letter2--;
                digit2++;
            }
        } else {
            // If bishop2 is up-right of bishop1
            while(0 < digit1 && 0 < letter1) {
                letter1--;
                digit1--;
            }
            while(letter2 < 7 && digit2 < 7) {
                letter2++;
                digit2++;
            }
        }
    }
    
    
    if(letter1 < letter2) {
        return new string[] { (char)(letter1 + 97) + "" + ++digit1, (char)(letter2 + 97) + "" + ++digit2 };
    } else {
        return new string[] { (char)(letter2 + 97) + "" + ++digit2, (char)(letter1 + 97) + "" + ++digit1 };
    }
}
