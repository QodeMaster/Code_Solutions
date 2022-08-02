// Solution
// Inspired by pythagoras_i

int[] solution(string tree) {
    int mostDistant = 0;
    int distance    = 0;
    
    List<int> list = new List<int>();
    for (int i = 0; i < tree.Length; i++) {
        if (tree[i] == '(') {
            if (tree[i + 1] == ')') { i++; continue; }
            distance++;
            if (mostDistant <= distance) {
                if (mostDistant < distance) {
                    mostDistant = distance;
                    list.Clear();
                }
                string s = "";
                i++;
                while ('0' <= tree[i] && tree[i] <= '9') s += tree[i++];
                list.Add(int.Parse(s));
            }
        }
        distance -= (tree[i] == ')' ? 1 : 0);
    }
    
    return list.ToArray();
}
