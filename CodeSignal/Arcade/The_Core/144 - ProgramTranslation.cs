// Solution

string solution(string code, string[] args) {
  string argumentVariants = String.Join("|", args);
  string pattern = "(?<=[^a-zA-Z0-9$_])(" + argumentVariants + ")([^a-zA-Z0-9_])";
  string sub = "$$$1$2";
  return Regex.Replace(code, pattern, sub);
}
