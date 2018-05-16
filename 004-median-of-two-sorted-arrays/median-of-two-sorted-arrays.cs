// There are two sorted arrays nums1 and nums2 of size m and n respectively.
//
// Find the median of the two sorted arrays. The overall run time complexity should be O(log (m+n)).
//
// Example 1:
//
// nums1 = [1, 3]
// nums2 = [2]
//
// The median is 2.0
//
//
//
// Example 2:
//
// nums1 = [1, 2]
// nums2 = [3, 4]
//
// The median is (2 + 3)/2 = 2.5
//
//


public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        
        int tatalNum = nums1.Length + nums2.Length;
        int midNum = (tatalNum+ 1)/2;
        int i = 0;
        int j = 0;
        List<int> numList = new List<int>();

        if(tatalNum == 1)
        {
            return nums1.Length>nums2.Length ? nums1[0]:nums2[0];
        }
        while(i +j <= midNum)
        {
            if(i<nums1.Length && j<nums2.Length)
            {
                if(nums1[i]<nums2[j])
                {
                    numList.Add(nums1[i]);
                    i++;
                }
                else
                {
                    numList.Add(nums2[j]);
                    j++;
                }
            }
            else if(i < nums1.Length)
            {
                numList.Add(nums1[i]);
                i++;      
            }
            else if(j < nums2.Length)
            {
                numList.Add(nums2[j]);
                j++;
            }     
        }
        
        if(tatalNum %2 == 0)//偶数个
        {
            return (numList[numList.Count-1] + numList[numList.Count-2])/2.0;
        }
        else//奇数个
        {
             return (numList[numList.Count-2]);
        }
        
        
    }
}
