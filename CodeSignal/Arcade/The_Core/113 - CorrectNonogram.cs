// Solution

bool correctNonogram(int size, string[][] nonogramField) {
    int startInd = (size + 1) / 2;
    int totSize = nonogramField.Length;
    
    for(int i = startInd; i < totSize; i++) {
        Queue queRow = new Queue();
        Queue queCol = new Queue();
        
        for(int j = 0; j < startInd; j++) {
            if(nonogramField[i][j] != "-") queRow.Enqueue(Int32.Parse(nonogramField[i][j]));
            if(nonogramField[j][i] != "-") queCol.Enqueue(Int32.Parse(nonogramField[j][i]));
        }
        if(!IsRowValid(startInd, queRow, totSize, nonogramField[i])) return false;
        if(!IsColValid(startInd, queCol, totSize, i, nonogramField)) return false;
    }
    
    bool IsColValid(int startInd, Queue q, int totSize, int j, string[][] arr) {
        int countPix = 0;
        for(int i = startInd; i < totSize; i++) {
            countPix += (arr[i][j] == "#" ? 1 : 0);
            if((arr[i][j] == "." || i == totSize - 1) && countPix != 0) {
                if(Convert.ToInt32(q.Peek()) == countPix) {
                    q.Dequeue();
                    countPix = 0;
                } else {
                    return false;
                }
            }
        }
        return q.Count == 0;
    }
    
    bool IsRowValid(int startInd, Queue q, int totSize, string[] arr) {
        int countPix = 0;
        for(int i = startInd; i < totSize; i++) {
            countPix += (arr[i] == "#" ? 1 : 0);
            
            if((arr[i] == "." || i == totSize - 1) && countPix != 0) {
                if(q.Count != 0 && Convert.ToInt32(q.Peek()) == countPix) {
                    q.Dequeue();
                    countPix = 0;
                } else {
                    return false;
                }
            }
        }
        return q.Count == 0;
    }
    
    return true;
}
