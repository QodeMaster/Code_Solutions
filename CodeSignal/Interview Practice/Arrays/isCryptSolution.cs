bool solution(string[] crypt, char[][] solution) {
    int[] termsAndSum = new int[3];
    
    for(int i = 0; i < crypt.Length; i++) {
        int pow10 = 1;
        if(1 < crypt[i].Length && giveNum(crypt[i][0], solution) == 0) return false;
        for(int j = crypt[i].Length - 1; j >= 0; j--) {
            termsAndSum[i] += giveNum(crypt[i][j], solution) * pow10;
            pow10 *= 10;
        } 
    }
    
    return termsAndSum[0] + termsAndSum[1] == termsAndSum[2];
}

int giveNum(char c, char[][] solution) {
    foreach(char[] translation in solution) {
        if(translation[0] == c) return translation[1] - '0';
    }
    
    return 0;
}
