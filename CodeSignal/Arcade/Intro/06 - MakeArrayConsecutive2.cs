// Basic solution

int makeArrayConsecutive2(int[] statues) {
    int count = 0;
    
    int limit = statues.Max();
    int start = statues.Min();

    for(int i = start; i < limit; i++) { 
        if(Array.IndexOf(statues, i) == -1) { 
           count++;
        } 
    }
    
    return count;
}

/*--------------------------------------------*/
/*--------------------------------------------*/

// Same but with a while-loop instead

int makeArrayConsecutive2(int[] statues) {
    int count = 0;
    
    int limit = statues.Max();
    int start = statues.Min();

    while(start < limit) if(Array.IndexOf(statues, start++) == -1) count++;
    
    return count;
}
