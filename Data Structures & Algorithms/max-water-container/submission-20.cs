public class Solution {
    public int MaxArea(int[] heights) {
        int left = 0 , right = heights.Length-1 , size = 0;
        while ( left < right )
        {
            int width = right - left ;
            int height = Math.Min (heights[left] , heights[right]);
            size = Math.Max(size , height * width);
            if( heights[left] < heights[right]){
                left++;
            }
            else{
                right--;
            }
        }
        return size;
    }
}
