// Solution
// Inspired by flatorez

int solution(string[] state) {
    List<string> water    = new List<string>();
    List<string> waterNew = new List<string>();
    List<string> filled   = new List<string>();
    List<char> doneList   = new List<char>();
    int count = 0;
    
    for (var i = 0; i < state.Length; i++) {
        for (var j = 0; j < state[0].Length; j++) {
            char x = state[i][j];
            if (x < 'a' || 'z' < x) continue;
            if (i != 0 && (state[i - 1][j] == '1' 
                || state[i - 1][j] == '3' 
                || state[i - 1][j] == '4' 
                || state[i - 1][j] == '7')) waterNew.Add("3:" + x + ":" + (i - 1) + ":" + j);
            if (i != state.Length - 1  && (state[i + 1][j] == '1' 
                || state[i + 1][j] == '5' 
                || state[i + 1][j] == '6' 
                || state[i + 1][j] == '7')) waterNew.Add("1:" + x + ":" + (i + 1) + ":" + j);
            if (j != 0 && (state[i][j - 1] == '2' 
                || state[i][j - 1] == '3' 
                || state[i][j - 1] == '6' 
                || state[i][j - 1] == '7')) waterNew.Add("2:" + x + ":" + i + ":" + (j - 1));
            if (j != state[0].Length - 1 && (state[i][j + 1] == '2' 
                || state[i][j + 1] == '4' 
                || state[i][j + 1] == '5' 
                || state[i][j + 1] == '7')) waterNew.Add("4:" + x + ":" + i + ":" + (j + 1));
        }
    }
    do {
        water    = waterNew;
        waterNew = new List<string>();
        foreach (string x in water) {
            string[] l  = x.Split(':');
            string dir  = l[0];
            string srcx = l[1];
            int cory    = int.Parse(l[2]);
            int corx    = int.Parse(l[3]);

            if (cory < 0 || state.Length <= cory) return count;
            if (corx < 0 || state[0].Length <= corx) return count;

            if (state[cory][corx] == '0') return count;
            else if (state[cory][corx] == '1') {
                switch (dir) {
                    case "2":
                    case "4": 
                        return count;
                    case "1": 
                        waterNew.Add(dir + ":" + srcx + ":" + (cory + 1) + ":" + corx); 
                        break;
                    default: 
                        waterNew.Add(dir + ":" + srcx + ":" + (cory - 1) + ":" + corx); 
                        break;
                }
            } else if (state[cory][corx] == '2') {
                switch (dir) {
                    case "1":
                    case "3": 
                        return count;
                    case "2": 
                        waterNew.Add(dir + ":" + srcx + ":" + cory + ":" + (corx - 1));
                        break;
                    default: 
                        waterNew.Add(dir + ":" + srcx + ":" + cory + ":" + (corx + 1));
                        break;
                }
            } else if (state[cory][corx] == '3') {
                switch (dir) {
                    case "1":
                    case "4": 
                        return count;
                    case "2": 
                        waterNew.Add("1" + ":" + srcx + ":" + (cory + 1) + ":" + corx);
                        break;
                    default: 
                        waterNew.Add("4" + ":" + srcx + ":" + cory + ":" + (corx + 1));
                        break;
                }
            } else if (state[cory][corx] == '4') {
                switch (dir) {
                    case "1":
                    case "2":
                        return count;
                    case "4": 
                        waterNew.Add("1" + ":" + srcx + ":" + (cory + 1) + ":" + corx);
                        break;
                    default: 
                        waterNew.Add("2" + ":" + srcx + ":" + cory + ":" + (corx - 1));
                        break;
                }
            } else if (state[cory][corx] == '5') {
                switch (dir) {
                    case "2":
                    case "3": 
                        return count;
                    case "4": 
                        waterNew.Add("3" + ":" + srcx + ":" + (cory - 1) + ":" + corx); 
                        break;
                    default: 
                        waterNew.Add("2" + ":" + srcx + ":" + cory + ":" + (corx - 1));
                        break;
                }
            } else if (state[cory][corx] == '6') {
                switch (dir) {
                    case "3":
                    case "4": 
                        return count;
                    case "2": 
                        waterNew.Add("3" + ":" + srcx + ":" + (cory - 1) + ":" + corx); 
                        break;
                    default: 
                        waterNew.Add("4" + ":" + srcx + ":" + cory + ":" + (corx + 1)); 
                        break;
                }
            } else if (state[cory][corx] == '7') {
                switch (dir) {
                    case "1": 
                        waterNew.Add(dir + ":" + srcx + ":" + (cory + 1) + ":" + corx);
                        break;
                    case "4": 
                        waterNew.Add(dir + ":" + srcx + ":" + cory + ":" + (corx + 1));
                        break;
                    case "2": 
                        waterNew.Add(dir + ":" + srcx + ":" + cory + ":" + (corx - 1));
                        break;
                    default: 
                        waterNew.Add(dir + ":" + srcx + ":" + (cory - 1) + ":" + corx);
                        break;
                }
            } else if ('a' <= state[cory][corx] && state[cory][corx] <= 'z') return count;
            else {
                if (srcx[0] != state[cory][corx] - 'A' + 'a') return count;
                else doneList.Add(state[cory][corx]);
            }
        }
        foreach (string x in water) {
            string[] l  = x.Split(':');
            string dir  = l[0];
            string srcx = l[1];
            int cory    = int.Parse(l[2]);
            int corx    = int.Parse(l[3]);
            filled.Add($"{l[2]} {l[3]}");
        }
        filled   = filled.Distinct().ToList();
        doneList = doneList.Distinct().ToList();
        count    = doneList.Count() - filled.Count();
    } while (waterNew.Count() != 0);
    
    return -1 * count;
}
