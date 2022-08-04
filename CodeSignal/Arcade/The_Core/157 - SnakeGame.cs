// Solution
// Inspired by peter_s76

char[][] solution(char[][] gameBoard, string commands) {
    (int, int)[] dirs     = new[] { (-1, 0), (0, -1), (1, 0), (0, 1) };
    string dirchars       = "<^>v";
    List<(int, int)> segs = new List<(int, int)>();
    int head              = 0;
    void put((int, int) p, char ch) => gameBoard[p.Item2][p.Item1] = ch;
    char gt((int, int) p) => gameBoard[p.Item2][p.Item1];
    int dir() => dirchars.IndexOf(gt(segs[head]));
    void setdir(int d) => put(segs[head], dirchars[d]);
    
    int x, y, w = gameBoard[0].Length, h = gameBoard.Length;
    for(y = 0; y < h; ++y) {
        for(x = 0; x < w; ++x) {
            char ch = gameBoard[y][x];
            if(ch == '^' || ch == '>' || ch == 'v' || ch == '<') {
                segs.Add((x, y));
                break;
            }
        }
    }
    
    var cur = segs[0];
    HashSet<(int, int)> marked = new HashSet<(int, int)> { cur };
    (int, int) findUnmarked(int x0, int y0) =>
        dirs.Select(p => (x0 + p.Item1, y0 + p.Item2))
            .Where(p => p.Item1 >= 0 
                && p.Item1 < w && p.Item2 >= 0 
                && p.Item2 < h
                && gt(p) == '*'
                && !marked.Contains(p))
            .Append((-1, -1))
            .First();
    for(;;) {
        cur = findUnmarked(cur.Item1, cur.Item2);
        if(cur.Equals((-1, -1))) break;
        marked.Add(cur);
        segs.Add(cur);
    }
    
    
    bool dead = false;
    void move() {
        
        int curdir = dir();
        cur = segs[head];
        var next = (cur.Item1 + dirs[curdir].Item1, cur.Item2 + dirs[curdir].Item2);
        if(next.Item1 < 0 
        || next.Item1 >= w 
        || next.Item2 < 0 
        || next.Item2 >= h 
        || gt(next) != '.') {
            kill();
            return;
        }
        
        int tail = head == 0 ? segs.Count - 1 : head - 1;
        put(cur, '*');
        put(segs[tail], '.');
        put(next, dirchars[curdir]);
        head       = tail;
        segs[head] = next;
    }
    
    void turn(int cw) {
        int curdir = dir() + cw;
        curdir = curdir >= 0 ? curdir % 4 : 3;
        setdir(curdir);
    }
    
    void kill() {
        dead = true;
        foreach(var p in segs) put(p, 'X');
    }
    
    foreach(char cmd in commands) {
        switch(cmd) {
            case 'F': 
                move(); 
                break;
            case 'L': 
                turn(-1); 
                break;
            case 'R': 
                turn(1); 
                break;
        }
        if(dead) break;
    }
    
    return gameBoard;
}
