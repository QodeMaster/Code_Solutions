// Solution

string solution(string s) {
  return Regex.Replace(s, @"(\w+) (\w+)", "$2 $1");
}
