// Solution

bool isInformationConsistent(int[][] evidences) {
    int response = 2;
    
    for(int i = 0; i < evidences[0].Length; i++) {
        response = 2;
        for(int j = 0; j < evidences.Length; j++) {
            if(evidences[j][i] == 0) continue;
            response = (response == 2 ? evidences[j][i] : response);
            if(response != evidences[j][i]) return false;
        }
    }
    
    return true;
}
