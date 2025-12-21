public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
     int firstSize = nums1.Length;
     int seccondSize = nums2.Length;

     int[] merged = new int[firstSize + seccondSize];

     int k = 0;
     for(int i = 0; i< firstSize; i++){
        merged[k++] = nums1[i];
     }

    for(int i = 0; i< seccondSize; i++){
        merged[k++] = nums2[i];
    }

    Array.Sort(merged);

    int total = merged.Length;

    if(total %2 == 1){
        return (double)merged[total/2];
    }

    int middle1 = merged[total/2 - 1];
    int middle2 = merged[total/2];

    return ((double)middle1 + (double)middle2)/2;

    }
}