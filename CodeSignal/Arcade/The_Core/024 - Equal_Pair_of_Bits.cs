// Solution

int equalPairOfBits(int n, int m)
{
  return ~(n ^= m) & ++n;
}
