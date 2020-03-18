// Basic solution
int centuryFromYear(int year) {
    double centuryRoundUp = Math.Ceiling(year / 100.0);

    return Convert.ToInt32(centuryRoundUp);
}

/*------------------------------------------------*/
/*------------------------------------------------*/


// Same solution as the one above except it's all in one return statement
int centuryFromYear(int year) { 
    return Convert.ToInt32(Math.Ceiling(year / 100.0));
}

/*------------------------------------------------*/
/*------------------------------------------------*/


// Less readable one-liner but it works just as well
int centuryFromYear(int year) => (int)Math.Ceiling(year++ / 100.0);
