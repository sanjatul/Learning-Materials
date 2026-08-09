public class Solution {
    public int MajorityElement(int[] nums) {
     Dictionary<int, int> map=new Dictionary<int,int>();
     int majority=nums.Length/2;
     for(int i =0;i<nums.Length;i++){
        if(map.ContainsKey(nums[i])) map[nums[i]]++;
        else map[nums[i]]=1;

        if(map[nums[i]]>majority)
        return nums[i];
     }
     return -1;
    }
}