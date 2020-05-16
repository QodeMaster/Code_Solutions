// Basic Solution

int seatsInTheater(int nCols, int nRows, int col, int row) {
    int affect = (nCols - col + 1) * (nRows - row);
    return affect;
}

/*------------------------------------------------------------------*/
/*------------------------------------------------------------------*/

// One-liner

int seatsInTheater(int nCols, int nRows, int col, int row) => (nCols - col + 1) * (nRows - row);
