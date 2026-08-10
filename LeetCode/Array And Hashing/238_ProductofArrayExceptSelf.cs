public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] leftToRight=new int[nums.Length];
        int[] rightToLeft=new int[nums.Length];
        int[] result=new int[nums.Length];

        leftToRight[0]=1;
        for(int i=1;i<nums.Length;i++){
            leftToRight[i]=leftToRight[i-1]*nums[i-1];
        }

        rightToLeft[nums.Length-1]=1;
        for(int i=nums.Length-2;i>=0;i--){
            rightToLeft[i]=rightToLeft[i+1]*nums[i+1];
        }
         for(int i=0;i<nums.Length;i++){
            result[i]=leftToRight[i]*rightToLeft[i];
        }
        return result;
    }
}