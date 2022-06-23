// Solution

string solution(string s, int n)
{
  Regex regex = new Regex(
    @"(?:[^1-9]*(\d+)){" + n + "}"
  );
  return regex.Match(s).Groups[1].Value;
}
