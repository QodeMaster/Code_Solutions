// Solution

bool solution(string p) {
    int[] pos1 = new int[] { p[0] - 'a', (int)p[1] };
    int[] pos2 = new int[] { p[3] - 'a', (int)p[4] };
    int[] pos3 = new int[] { p[6] - 'a', (int)p[7] };
    int[] pos4 = new int[] { p[9] - 'a', (int)p[10] }
    
    return (
        (++pos1[0] + pos1[1] + ++pos2[0] + pos2[1]) % 2 ==
        (++pos3[0] + pos3[1] + ++pos4[0] + pos4[1]) % 2
    );
}

/*---------------------------------------------------------------------------*/
/*---------------------------------------------------------------------------*/

// Unclear but cool one-liner

bool solution(string p) => (p[0] + p[1] + p[3] + p[4] - p[6] - p[7] - p[9] - p[10]) % 2 == 0;
