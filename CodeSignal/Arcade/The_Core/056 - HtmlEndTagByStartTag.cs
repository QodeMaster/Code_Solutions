// Solution

string htmlEndTagByStartTag(string startTag) {
    string tag = startTag.Split(" ")[0].Substring(1);
    
    return "</" + tag + (tag.Last() == '>' ? "" : ">");
}
