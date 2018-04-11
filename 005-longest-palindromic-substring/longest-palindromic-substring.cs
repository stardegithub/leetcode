// Given a string s, find the longest palindromic substring in s. You may assume that the maximum length of s is 1000.
//
// Example:
//
//
// Input: &quot;babad&quot;
//
// Output: &quot;bab&quot;
//
// Note: &quot;aba&quot; is also a valid answer.
//
//
// &nbsp;
//
// Example:
//
//
// Input: &quot;cbbd&quot;
//
// Output: &quot;bb&quot;
//
//
// &nbsp;
//


public class Solution {
    public string LongestPalindrome(string s) {
        
        int maxlength = 0;
        int maxl = 0;
        int maxr = 0;
        int ori = 0;
        
        for(int i = 0 ;i < s.Length;i++)
        {
            int L = 0;
            int R = 0;
            while(i+L-1 > -1 && s[i] == s[i+L - 1]) L--;
            while(i+R+1 < s.Length -1 && s[i] == s[i+R + 1]) R++;
            
            while(i+L - 1 > -1 && i+R +1<s.Length && s[i+L - 1] == s[i+R+1])
            {
                L--;
                R++;
            }
            if(R-L+1 > maxlength)
            {
                ori = i;
                maxl = L;
                maxr = R;
                maxlength = R-L +1;
            }          
        }
        return s.Substring(ori+maxl,maxlength);
    }
}
