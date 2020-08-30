int combs(string comb1, string comb2) {
    int c1 = 0;
    int c2 = 0;
    int len = comb2.Length + comb1.Length;
    
    for(int i = 0; i < comb1.Length; i++) c1 = (c1 << 1) + (comb1[i] == '*' ? 1 : 0);
    c1 <<= comb2.Length;
    for(int i = 0; i < comb2.Length; i++) c2 = (c2 << 1) + (comb2[i] == '*' ? 1 : 0);
    c2 <<= len;
    
    int min = 100;
    
    for(int i = 0; i < len; i++) {
        if((c1 & c2) == 0) {
            if(GetLength(c1 | c2) < min) min = GetLength(c1 | c2);
        }
        c2 >>= 1;
    }
    
    
    return min;
}

static int GetLength(int bin) {
    bool on = false;
    
    while(0 < bin) {
        if(bin % 2 == 1 && !on) on = true;
        if(on) return (int)Math.Log(bin, 2) + 1; 
        bin >>= 1;
    }
    
    return 1;
}
