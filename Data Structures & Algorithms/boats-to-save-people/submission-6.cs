public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        Array.Sort(people);
        int l = 0 , r = people.Length - 1 , res =0;
        while ( l <= r ){
            int remaining = limit - people[r];
            r--;
            if ( l <= r && people[l] <= remaining){
                l++;
            }
            res++;
        }
        return res;
    }
}