public class Solution {
    public void SortColors(int[] nums) {
        int color0=0,color1=0,color2=0;
        foreach(int item in nums){
            if(item==0) color0++;
            else if(item==1) color1++;
            else if(item==2) color2++;
        }
        int index=0;
        while(color0-- >0) nums[index++]=0;
        while(color1-- >0) nums[index++]=1;
        while(color2-- >0) nums[index++]=2;
    }
}