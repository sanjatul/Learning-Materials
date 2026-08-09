public class Solution {
    public int[] TwoSum(int[] nums, int target) {
       Dictionary<int, int> lookup=new Dictionary<int,int>();
       for(int i=0;i<nums.Length;i++){
        int val=target-nums[i];
        if(lookup.ContainsKey(val)){
            return new[]{i,lookup[val]};
        }
         lookup[nums[i]]=i;
       }
       return new int[]{};
    }
}