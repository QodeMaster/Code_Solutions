// Solution

string[] christmasTree(int levelNum, int levelHeight) {
    string[] tree = new string[3 + levelNum * levelHeight + levelNum];
    
    // The crown, the initial value
    tree[0] = "*";
    tree[1] = "*";
    tree[2] = "***";
    
    // Defining the foot
    string foot = "" + (levelHeight % 2 == 0 ? "*" : "");
    for(int i = 0; i < levelHeight; i++) {
        foot += "*";
    }
    
    // First top of the tree
    for(int i = 3; i < levelHeight + 3; i++) {
        tree[i] = tree[i - 1] + "**";
    }
    
    // The rest of the tops of the tree
    for(int i = 3 + levelHeight; i < levelNum * levelHeight + 3; i++) {
        if((i - 3 + levelHeight) % levelHeight == 0) {
            tree[i] = tree[i - levelHeight] + "**";
        } else {
            tree[i] = tree[i] = tree[i - 1] + "**";
        }
    }
    
    // Assigning the foot to the tree
    for(int i = 0; i < levelNum; i++) {
        tree[tree.Length - 1 - i] = foot;
    }
    
    // Adding whitespaces to the beginning of the tree
    for(int i = 0; i < tree.Length; i++) {
        tree[i] = addWhiteSpace(tree[i].Length, levelNum + levelHeight) + tree[i];
    }
    
    return tree;
}

public static string addWhiteSpace(int segmentLength, int midwayPoint) {
    int marginLeft = midwayPoint - (segmentLength - 1) / 2;
    string newSegment = "";
    
    while(0 < marginLeft) {
        newSegment += " ";
        marginLeft--;
    }
    
    return newSegment;
}
