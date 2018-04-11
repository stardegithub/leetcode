// Given a string, find the length of the longest substring without repeating characters.
//
// Examples:
//
// Given "abcabcbb", the answer is "abc", which the length is 3.
//
// Given "bbbbb", the answer is "b", with the length of 1.
//
// Given "pwwkew", the answer is "wke", with the length of 3. Note that the answer must be a substring, "pwke" is a subsequence and not a substring.


public class Solution {
    public int LengthOfLongestSubstring(string s) {
        
        int a = 0;
        int j = 0;
        int maxLenth = 0;
        int maxi = 0;
        int maxj = 0;
        List<char> ishave = new List<char>();
        for(int i = 0;i<s.Length;i++)
        {
            if(!ishave.Contains(s[i]))
            {
                ishave.Add(s[i]);
                j++;
            }
            else
            {
                if(maxLenth < j)
                {
                    maxLenth = j;
                    maxi = a;
                    maxj = j;
                 
                }
                j =0;
                ishave.Clear();
                i =a;
                a++;
            }
         
        }
        return maxj > j ? maxj:j;
    }
}
