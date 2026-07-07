namespace LeetCodeSolutions.Solutions;

public class TwoSum
{
    public int[] Solution(int[] nums, int target) 
    {    
        int first = 0;
        int second = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    first = j;
                    second = i;
                }
            }
        }
        
        return [first, second]; 
    }
}