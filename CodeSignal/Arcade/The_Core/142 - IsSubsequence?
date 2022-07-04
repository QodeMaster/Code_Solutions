// Solution

bool solution(string t, string s)
{
  string pattern = "";
  foreach (char ch in s)
  {
    pattern += $"[{ch}].*";
  }
  Regex regex = new Regex(pattern);
  return regex.Match(t).Success;
}
