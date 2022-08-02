// Solution
// Inspired by chen_c5

string solution(string[] program) {
    char[][] arr = new char[program.Length][];
    for(int i = 0; i < arr.Length; i++) arr[i] = program[i].ToCharArray();
    Stack stack = new Stack();
    string res  = "";
    int symbol  = 0;
    solve(ref stack, arr, 0, 0, 0, ref res, false, symbol);
    return res;
}

void solve(ref Stack st,
            char[][] arr,
            int nr, 
            int nc, 
            int dir, 
            ref string output, 
            bool strMode, 
            int sym){
    if(output.Length == 100) return;
    sym++;
    if(sym == 10000) return;
    if(strMode && arr[nr][nc] != '"') st.Push(arr[nr][nc]);
    else {
    switch(arr[nr][nc]) {
        case '>': 
            dir = 0;  
            break;
        case '<': 
            dir = 1; 
            break;
        case 'v': 
            dir = 2; 
            break;
        case '^': 
            dir = 3; 
            break;
        case '#': 
            getNext(dir, arr, ref nr, ref nc); 
            break;
        case '_': 
            int a = Convert.ToInt32(pop(ref st));
            dir = (a == 0) ? 0 : 1;
            break;
        case '|': 
            dir = (Convert.ToInt32(pop(ref st)) == 0)?2:3;
            break;
        case '+': 
            getMath(ref st, '+');
            break;
        case '-':
            getMath(ref st, '-');
            break;
        case '*':
            getMath(ref st, '*');
            break;
        case '/':
            getMath(ref st, '/');
            break;
        case '%':
            getMath(ref st, '%');
            break;
        case '!':
            int a1 = (Convert.ToInt32(pop(ref st)) == 0) ? 1 : 0;
            st.Push(a1);
            break;
        case '`':
            int a2 = Convert.ToInt32(pop(ref st));
            int b2 = Convert.ToInt32(pop(ref st));
            int c2 = (b2 > a2)?1:0; st.Push(c2); 
            break;
        case ':': 
            st.Push(peek(ref st));
            break;
        case '\\':
            object a3 = pop(ref st);
            object b3 = pop(ref st);
            st.Push(a3); st.Push(b3);
            break;
        case '$':
            pop(ref st);
            break;
        case '.':
            object a4 = pop(ref st);
            output += Convert.ToInt32(a4) +" ";
            break; 
        case ',':
            output += Convert.ToChar(pop(ref st));
            break;
        case '"': 
            strMode = !strMode;
            break;
        case '@': 
            return;
        default: 
            if(Char.IsDigit(arr[nr][nc])) st.Push((int)(arr[nr][nc] - '0')); 
            break;
        }
    }
    getNext(dir, arr, ref nr, ref nc);
    solve(ref st, arr, nr, nc, dir, ref output, strMode, sym);
}

object pop(ref Stack st) => (0 < st.Count ? st.Pop() : 0);

object peek(ref Stack st) => (0 < st.Count ? st.Peek() : 0);

void getNext(int dir, char[][] arr, ref int nr, ref int nc){
    switch(dir){
        case 0: 
            nc++; 
            if(nc == arr[0].Length) nc = 0;
            break;
        case 1: 
            nc--; 
            if(nc == -1) nc = arr[0].Length - 1;
            break;
        case 2: 
            nr++; 
            if(nr == arr.Length) nr = 0; 
            break;
        case 3: 
            nr--; 
            if(nr == -1) nr = arr.Length - 1;
            break;
    }
}

void getMath(ref Stack st, char v){
    int a = Convert.ToInt32(pop(ref st));
    int b = Convert.ToInt32(pop(ref st));
    int c = 0;
    switch(v) {
        case '+': 
            c = a + b; 
            break;
        case '-': 
            c = b - a;
            break;
        case '*': 
            c = a * b;
            break;
        case '/': 
            c = b / a; 
            break;
        case '%':
            c = b % a;
            break;
    }
    st.Push(c);
}
