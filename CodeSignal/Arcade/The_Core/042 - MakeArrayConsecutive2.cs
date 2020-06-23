// Basic Solution

int makeArrayConsecutive2(int[] statues) {
    int smallest = statues.Min();
    int biggest = statues.Max();
    
    return biggest - smallest - statues.Length + 1;
}

/*--------------------------------------------------------------------*/
/*--------------------------------------------------------------------*/

// One-liner

int makeArrayConsecutive2(int[] statues) => statues.Max() - statues.Min() - statues.Length + 1;
