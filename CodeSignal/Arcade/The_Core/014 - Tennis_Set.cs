// Solution

bool tennisSet(int score1, int score2) {
    if(score1 == score2) return false;
    if(score1 > 7 || score2 > 7) return false;
    if((score1 == 7 && score2 < 5) || (score2 == 7 && score1 < 5) || score1 + score2 == 11) return false;
    if(score1 < 6 && score2 < 6) return false;


    return true;
}
