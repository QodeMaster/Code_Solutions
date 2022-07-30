// Solution

int solution(string expr) {
    int l = 0;

    int m  = -1;
    int p  = -1;
    int mp = -1;
    int pp = -1;

    int i = 0;
    foreach (char t in expr) {
        switch(t) {
            case '(':
                l++;
            break;
            case ')':
                l--;
            break;
            case '*':
                if (l > m) {
                    m  = l;
                    mp = i; 
                }
            break;
            case '+':
                if (l > p) {
                    p  = l;
                    pp = i;
                }
            break;
            default:
                Console.WriteLine("ERROR!");
                break;
        }
        i++;
    }

    return (p > m) ? pp : mp;
}
