public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> map=new Dictionary<int,int>();
        foreach(int item in nums){
            if(map.ContainsKey(item)){
                map[item]++;
            }else{
                map[item]=1;
            }
        }
        return map.OrderByDescending(pair=>pair.Value).Take(k).Select(pair=>pair.Key).ToArray();
    }
}