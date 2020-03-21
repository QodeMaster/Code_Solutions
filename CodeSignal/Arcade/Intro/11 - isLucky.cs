// Basic solution

bool isLucky(int n) {
    string str = n.ToString();

    string firstHalf = str.Substring(0, str.Length / 2);
    string secondHalf = str.Substring(str.Length / 2);

    int firstSum = 0;
    int secondSum = 0;

    for(int i = 0; i < firstHalf.Length; i++) {
        firstSum += (firstHalf[i] - '0');
        secondSum += (secondHalf[i] - '0');
    }

    return firstSum == secondSum;
}

/*--------------------------------------------------*/
/*--------------------------------------------------*/

// A variant of the solution above

bool isLucky(int n) {
    string str = n.ToString().Substring(0, n.ToString().Length / 2) + "-" + n.ToString().Substring(n.ToString().Length / 2);
    int difference = 0;
    
    bool add = true;
    foreach(char c in str) {
        if(c == '-') {
            add = false;
            continue;
        }
        if(add) difference += (c - '0');
        else difference -= (c - '0');
    }

    return difference == 0;
}

/*--------------------------------------------------*/
/*--------------------------------------------------*/

// An efficient mathematical solution

bool isLucky(int n) {
    int log = (int)Math.Log10(n) + 1;
    int first = 0;
    int sec = 0;
    
    for(int i = log; i > 0; i--) {
        int pow = (int)Math.Pow(10, i - 1);
        n %=  pow * 10;
        int N = (n - n % pow) / pow;
        
        if(i <= (log / 2)) first += N;
        else sec += N;
    }
    
    return first == sec;
}
