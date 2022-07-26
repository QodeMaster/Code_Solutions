// Solution

int solution(string letter)
{
  Regex regex = new Regex(@"(?i)(?<=^|[^A-Za-z])([A-Za-z]+)[^A-Za-z]+\1(?=[^A-Za-z]|$)");
  return regex.Matches(letter).Count;
}
