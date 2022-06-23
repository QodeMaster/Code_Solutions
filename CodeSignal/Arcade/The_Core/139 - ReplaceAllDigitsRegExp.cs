// Solution

string solution(string input) {
  return new Regex(@"\d").Replace(input, "#");
}
