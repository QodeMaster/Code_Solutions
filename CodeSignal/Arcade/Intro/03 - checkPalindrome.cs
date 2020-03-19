// Basic solution
// Checks if the reversed string is the same as the original string

bool checkPalindrome(string inputString) {
    string Reverse( string s )
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse( charArray );
        return new string( charArray );
    }
    
    
    return inputString == Reverse(inputString);
}

/*-------------------------------------------*/
/*-------------------------------------------*/

// A faster and more efficient solution
// Checks if the letters on the start/end of the string matches and it moves to the middle of the string where the loop stops

bool checkPalindrome(string inputString) {
    int half = inputString.Length / 2;
    if((inputString.Length % 2) == 0) half--; // We don't want uneven numbers
    
    for(int i = 0; i <= half; i++) {
      if(inputString[i] != inputString[inputString.Length - 1 - i]) { 
          return false;
        }
    }
    
    
    return true;
}

/*------------------------------------------*/
/*------------------------------------------*/

// Same as the one above except the code is shorter

bool checkPalindrome(string inputString) {
    int half = inputString.Length / 2;
    if((inputString.Length & 1) == 0) half--;
    for(int i = 0; i <= half; i++) if(inputString[i] != inputString[inputString.Length - 1 - i]) return false;
    
    
    return true;
}
