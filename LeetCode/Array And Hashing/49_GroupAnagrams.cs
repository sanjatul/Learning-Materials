public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {

        Dictionary<string , IList<string>> map=new Dictionary<string,IList<string>>();
        foreach(var item in strs){
            char[] hash=new char[26];
            for(int i=0; i<item.Length;i++){
                hash[item[i]-'a']++;
            }
            string key=new string(hash);
            if(map.ContainsKey(key)){
                map[key].Add(item);
            }
            else{
                map[key]=new List<string>(){item};
            }
        }
        return map.Values.ToList();
    }
}