// Implement atoi which&nbsp;converts a string to an integer.
//
// The function first discards as many whitespace characters as necessary until the first non-whitespace character is found. Then, starting from this character, takes an optional initial plus or minus sign followed by as many numerical digits as possible, and interprets them as a numerical value.
//
// The string can contain additional characters after those that form the integral number, which are ignored and have no effect on the behavior of this function.
//
// If the first sequence of non-whitespace characters in str is not a valid integral number, or if no such sequence exists because either str is empty or it contains only whitespace characters, no conversion is performed.
//
// If no valid conversion could be performed, a zero value is returned.
//
// Note:
//
//
// 	Only the space character &#39; &#39; is considered as whitespace character.
// 	Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [&minus;231,&nbsp; 231&nbsp;&minus; 1]. If the numerical value is out of the range of representable values, INT_MAX (231&nbsp;&minus; 1) or INT_MIN (&minus;231) is returned.
//
//
// Example 1:
//
//
// Input: &quot;42&quot;
// Output: 42
//
//
// Example 2:
//
//
// Input: &quot;   -42&quot;
// Output: -42
// Explanation: The first non-whitespace character is &#39;-&#39;, which is the minus sign.
// &nbsp;            Then take as many numerical digits as possible, which gets 42.
//
//
// Example 3:
//
//
// Input: &quot;4193 with words&quot;
// Output: 4193
// Explanation: Conversion stops at digit &#39;3&#39; as the next character is not a numerical digit.
//
//
// Example 4:
//
//
// Input: &quot;words and 987&quot;
// Output: 0
// Explanation: The first non-whitespace character is &#39;w&#39;, which is not a numerical 
// &nbsp;            digit or a +/- sign. Therefore no valid conversion could be performed.
//
// Example 5:
//
//
// Input: &quot;-91283472332&quot;
// Output: -2147483648
// Explanation: The number &quot;-91283472332&quot; is out of the range of a 32-bit signed integer.
// &nbsp;            Thefore INT_MIN (&minus;231) is returned.
//




public class Solution {
    public int MyAtoi(string str) {
        int INT_MAX = 2147483647;
        int INT_MIN = -2147483648;
        
        int final = 0;
        int temp = 0;
        int fuhao = 1;
        bool ismustbenum = false;
        bool iscankongge = true;
        
        checked
        {
            try
            {
                for(int i = 0;i<str.Length;i++)
                {
                    var asc = (int)str[i];
                    if(asc == 43 && !ismustbenum )//加号
                    {
                        final += temp*fuhao;
                        temp = 0;
                        fuhao = 1;
                        ismustbenum = true;
                        iscankongge = false;
                    }
                    else if(asc == 45 && !ismustbenum)//减号
                    {
                        final += temp*fuhao;
                        temp = 0;
                        fuhao = -1;
                        ismustbenum = true;
                        iscankongge = false;
                    }
                    else 
                    {
                        var num = asc - 48;
                        if(num>= 0 && num <= 9)
                        {
                            ismustbenum = false;
                            temp = temp * 10 +num;
                            iscankongge = false;
                        }
                        else if(asc == 32 && iscankongge)//空格
                        {
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }       
                }
                final += temp*fuhao;
            }
            catch(OverflowException oEx) //溢出
            { 
                final += temp*fuhao;
                final = final>0? INT_MAX:INT_MIN;
            }
        }
        return final;
    }
}
