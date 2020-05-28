// Basic Solution

int killKthBit(int n, int k)
{
  return n & ~(int)Math.Pow(2, k - 1);
}

/*------------------------------------------------*/
/*------------------------------------------------*/

// Pure Bitwise

int killKthBit(int n, int k)
{
  return n & ~(1 << (k - 1));
}
