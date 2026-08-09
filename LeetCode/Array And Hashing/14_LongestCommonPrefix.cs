public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if(strs == null || strs.Length ==0) return null;
        Array.Sort(strs);
        int index=0;
        string first=strs[0];
        string last=strs[strs.Length-1];

        for(int i=0;i<first.Length && i<last.Length;i++){
            if(first[i] != last[i]) break;
            index++;
        }
        return first.Substring(0,index);
    }
}