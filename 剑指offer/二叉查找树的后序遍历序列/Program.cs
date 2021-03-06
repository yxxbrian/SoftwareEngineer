﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 二叉查找树的后序遍历序列
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] s = new int[] { 3, 7, 5, 13, 15, 10 };
            new Solution().VerifySquenceOfBST(s);
        }

        class Solution
        {
            public bool VerifySquenceOfBST(int[] sequence)
            {
                // write code here
                if (sequence.Length == 0)
                    return false;
                return Verify(sequence, 0, sequence.Length - 1);
            }

            public bool Verify(int[] sequence, int start, int end)
            {
                if (end <= start)
                    return true;
                else 
                {
                    int midIndex = end-1;
                    while (midIndex >= start)
                    {
                        if (sequence[midIndex] >= sequence[end])
                            midIndex--;
                        else
                            break;
                        
                    }
                    for (int i = start; i <= midIndex; i++)
                        if (sequence[i] > sequence[end])
                            return false;
                    bool nextLeftResult = Verify(sequence, start, midIndex);
                    bool nextRightResult = Verify(sequence, midIndex + 1, end-1);
                    return nextLeftResult && nextRightResult;
                }
            }

        }


    }
}
