using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] answers) {
        int[] std1 = new int[] { 1, 2, 3, 4, 5 };
        int[] std2 = new int[] { 2, 1, 2, 3, 2, 4, 2, 5 };
        int[] std3 = new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };
        int[] hit = new int[3];
        int test = 0;
        for (int i = 0; i < answers.Length; i++)
        {
            if (answers[i] == std1[i % std1.Length]) ++hit[0];
            if (answers[i] == std2[i % std2.Length]) ++hit[1];
            if (answers[i] == std3[i % std3.Length]) ++hit[2];
        }
        List<int> max = new List<int>();
        if (hit[0] == hit.Max()) max.Add(1);
        if (hit[1] == hit.Max()) max.Add(2);
        if (hit[2] == hit.Max()) max.Add(3);
        return max.ToArray();
    }
}