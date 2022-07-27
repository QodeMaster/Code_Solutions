// Solution

string solution(string table, int row, int column) {
    var r = Regex.Matches(table, "<tr>.*?</tr>");
    if (r.Count <= row) return "No such cell";
    
    var col = Regex.Matches(r[row].Value, "<td>(.*?)</td>");
    if (col.Count <= column) return "No such cell";
    
    
    return col[column].Groups[1].Value;
}
