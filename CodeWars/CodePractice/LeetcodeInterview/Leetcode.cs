namespace LeetcodeInterview
{
	public class Leetcode
	{
		//Leetcode 88. Merge Sorted Array- could not solve it yet
		public void Merge(int[] nums1, int m, int[] nums2, int n)
		{
			m=nums1.Length;
			n=nums2.Length;
			for (int i = 0; i < m; i++)
			{
				for (int j = 0; j < n; j++)
				{
					m= nums1[i] + nums2[j];
				}
			}
			n=nums2.Length;
			

			for(int i = 0;	i < m+n; i++) 
			{
				//int result=
			}
		}
		//Leetcode 58. Length of Last Word
		public int LengthOfLastWord(string s)
		{
			int result = s.Trim().Split(' ').Last().Length;
			return result;
		}

	}
}
