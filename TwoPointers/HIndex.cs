//Given an array of integers citations where citations[i] is the number of citations a researcher received for their ith paper, return the researcher's h-index.
//According to the definition of h-index on Wikipedia: The h-index is defined as the maximum value of h such that the given researcher has published at least h papers that have each been cited at least h times.



//Example 1:

//Input: citations = [3, 0, 6, 1, 5]
//Output: 3
//Explanation: [3,0,6,1,5] means the researcher has 5 papers in total and each of them had received 3, 0, 6, 1, 5 citations respectively.
//Since the researcher has 3 papers with at least 3 citations each and the remaining two with no more than 3 citations each, their h-index is 3.
//Example 2:

//Input: citations = [1, 3, 1]
//Output: 1



//Constraints:

//n == citations.length
//1 <= n <= 5000
//0 <= citations[i] <= 1000

//Solution:-

public class Solution
{
    public int HIndex(int[] citations)
    {
        // first sort the array to ascending order [0,1,3,5,6]
        // Think from right to left for the solution
        Array.Sort(citations);
        int possibleCitation = citations.Length;
        int pointer1 = citations.Length - 1;
        int numberGreaterThanPC = 0;

        if (citations.Length == 0)
            return 0;
        if (citations.Length == 1 && citations[0] > 0)
            return 1;

        // Logic: only if numberGreaterThanPC >= possibleCitation value that means
        // we have the possible citation value in our hand
        while (pointer1 >= 0)
        {
            // if this condition satisfies means we have received the citation value
            if (numberGreaterThanPC >= possibleCitation)
            {
                return possibleCitation;
            }
            // if citations[pointer1] >= possibleCitation, we need to move left by one to
            // next highest(one lower) citation value, and increment the numberGreaterThanPC by 1
            // since we have 1 more number greater than possible citation now
            if (citations[pointer1] >= possibleCitation)
            {
                numberGreaterThanPC += 1;
                pointer1--;
                continue;
            }
            // if numbersGreaterThanPC is less than the PossibleCitation, since we
            // need both be same, so we must decreate the possibleCitation value by 1
            if (numberGreaterThanPC < possibleCitation)
            {
                possibleCitation--;
                continue;
            }
        }
        return possibleCitation;
    }
}