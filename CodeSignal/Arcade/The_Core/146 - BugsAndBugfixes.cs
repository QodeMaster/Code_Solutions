// Solution

int solution(string rules)
{
  Regex regex = new Regex(@"(\d*)d(\d+)([+-]\d+)*");
  MatchCollection formulas = regex.Matches(rules);

  int res = 0;
  foreach (Match match in formulas)
  {
    GroupCollection formula = match.Groups;
    int rolls = String.IsNullOrEmpty(formula[1].Value) ?
      1 : Int32.Parse(formula[1].Value);
    int dieType = Int32.Parse(formula[2].Value);
    int formulaMax = rolls * dieType;

    if (!String.IsNullOrEmpty(formula[3].Value))
    {
      if (formula[3].Value[0] == '-')
      {
        formulaMax -= Int32.Parse(formula[3].Value.Substring(1));
      }
      else
      {
        formulaMax += Int32.Parse(formula[3].Value.Substring(1));
      }
    }

    res += formulaMax;
  }

  return res;
}
