// Solution

string[] solution(string[] table, int[][] coords) {
    int[] row = Enumerable.Range(0, table.Length).Where(s => table[s][0] == '+').ToArray();
    int[] pos = Enumerable.Range(0, table[0].Length).Where(s => table[0][s] == '+').ToArray();
    
    for(int i = row[coords[1][0]]; i <= row[coords[0][0] + 1]; i++) {
        int coordNWall = pos[coords[0][1]] + 1;
        
        string left   = table[i].Substring(0, coordNWall);
        string middle = table[i].Substring(coordNWall, pos[coords[1][1] + 1] - coordNWall);
        string right  = table[i].Substring(pos[coords[1][1] + 1]);
        
        if (i == 0 || i == table.Length - 1) {
            table[i] = left + new String('-', middle.Length) + right;
        } else if (i != row[coords[1][0]] && i != row[coords[0][0] + 1]) {
            if (left.Length == 1) left   = "|";
            if (right.Length == 1) right = "|";
            table[i] = left + Regex.Replace(middle, "[-+|]", " ") + right;
        }
    }
    return table;
}
