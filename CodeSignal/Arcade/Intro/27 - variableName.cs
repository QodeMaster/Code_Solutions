// Basic solution

bool variableName(string name) {
    bool firstCharNum = true;
    
    try { Console.Write(int.Parse(name[0].ToString()));} 
    catch(Exception e) { firstCharNum = false; }
    if(firstCharNum) return false;
    
    Regex reg = new Regex(@"[\d\w]*");
    
    
    return reg.Matches(name)[0].ToString() == name;
}

/*---------------------------------------------------------*/
/*---------------------------------------------------------*/

// Shorter solution

bool variableName(string name) {
    bool firstCharNum = true;
    
    try { Console.Write(int.Parse(name[0].ToString()));} 
    catch(Exception e) { firstCharNum = false; }
    if(firstCharNum) return false;
    
    
    return new Regex(@"[\d\w]*").Matches(name)[0].ToString() == name;
}
