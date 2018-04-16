// Given a 32-bit signed integer, reverse digits of an integer.
//
// Example 1:
//
//
// Input: 123
// Output: 321
//
//
// Example 2:
//
//
// Input: -123
// Output: -321
//
//
// Example 3:
//
//
// Input: 120
// Output: 21
//
//
// Note:
// Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [&minus;231,&nbsp; 231&nbsp;&minus; 1]. For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.
//


public class Solution {
    public int Reverse(int x) {
        int final = 0;
        while(x != 0)
        {   
              checked    // 打开整数溢出检查  
            {  
                try  
                {  
                    final = (final * 10 + x%10) ;
                }  
  
                catch (OverflowException oEx)  
                {  
                    final = 0;
                    break;
                }  
            }  
          
            x = x/10;
        }
        
        
        return final;
        
    }
}
