// Solution

bool solution(string pairOfLines)
{
  Regex regex = new Regex("(.{3})\t.*(.{3})$");
  Match match = regex.Match(pairOfLines);
  return match.Groups[1].Value == match.Groups[2].Value;
}
