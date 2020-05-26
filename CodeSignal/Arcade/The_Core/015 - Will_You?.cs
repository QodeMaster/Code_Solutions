// Basic Solution

bool willYou(bool young, bool beautiful, bool loved) {
    if(!loved && beautiful && young) return true;
    if(loved && (!beautiful || !young)) return true;

    return false;
}


/*------------------------------------------------------*/
/*------------------------------------------------------*/

// One-liner

bool willYou(bool young, bool beautiful, bool loved) => ((!loved && beautiful && young) || (loved && (!beautiful || !young)));
