// Solution

int differentSquares(int[][] matrix) {
    List<string> stringContainer = new List<string>();

    string contain = "";
    for(int i = 0; i < matrix.Length - 1; i++) {

        for(int j = 0; j < matrix[0].Length - 1; j++) {
            contain = $"{matrix[i][j]}{matrix[i][j + 1]}{matrix[i + 1][j]}{matrix[i + 1][j + 1]}";
            if(!stringContainer.Contains(contain)) stringContainer.Add(contain);
            contain = "";
        }
    }


    return stringContainer.Count();
}
