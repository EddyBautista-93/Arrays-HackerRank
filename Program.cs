using System;
using System.Collections.Generic;

namespace arrays
{
    internal class Program
    {
        // 1.2D Array
        // Given a  2D Array, :

        // 1 1 1 0 0 0
        // 0 1 0 0 0 0
        // 1 1 1 0 0 0
        // 0 0 0 0 0 0
        // 0 0 0 0 0 0
        // 0 0 0 0 0 0
        // An hourglass in  is a subset of values with indices falling in this pattern in 's graphical representation:

        // a b c
        //   d
        // e f g
        // There are  hourglasses in . An hourglass sum is the sum of an hourglass' values. Calculate the hourglass sum for every hourglass in , then print the maximum hourglass sum. The array will always be .

        // Example

        // -9 -9 -9  1 1 1
        //  0 -9  0  4 3 2
        // -9 -9 -9  1 2 3
        //  0  0  8  6 6 0
        //  0  0  0 -2 0 0
        //  0  0  1  2 4 0
        // The  hourglass sums are:

        // -63, -34, -9, 12,
        // -10,   0, 28, 23,
        // -27, -11, -2, 10,
        //   9,  17, 25, 18
        // The highest hourglass sum is  from the hourglass beginning at row , column :

        // 0 4 3
        //   1
        // 8 6 6
        // Note: If you have already solved the Java domain's Java 2D Array challenge, you may wish to skip this challenge.

        // Function Description

        // Complete the function hourglassSum in the editor below.

        // hourglassSum has the following parameter(s):

        // int arr[6][6]: an array of integers
        // Returns

        // int: the maximum hourglass sum
        // Input Format

        // Each of the  lines of inputs  contains  space-separated integers .

        public static int hourglassSum(List<List<int>> arr)
        {
            int retVal = int.MinValue;
            int highest = 0;
            for (int i = 0; i < arr.Count - 2; i++)
            {
                for (int j = 0; j < arr.Count - 2; j++)
                {
                    highest = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                    if (highest > retVal)
                    {
                        retVal = highest;
                    }
                }
            }

            return retVal;
        }

        // Arrays: Left Rotation
        // A left rotation operation on an array shifts each of the array's elements  unit to the left. For example, if  left rotations are performed on array , then the array would become . Note that the lowest index item moves to the highest index in a rotation. This is called a circular array.

        // Given an array  of  integers and a number, , perform  left rotations on the array. Return the updated array to be printed as a single line of space-separated integers.

        // Function Description

        // Complete the function rotLeft in the editor below.

        // rotLeft has the following parameter(s):

        // int a[n]: the array to rotate
        // int d: the number of rotations
        // Returns

        // int a'[n]: the rotated array
        // Input Format

        // The first line contains two space-separated integers  and , the size of  and the number of left rotations.
        // The second line contains  space-separated integers, each an .

        // Constraints

        // Sample Input

        // 5 4
        // 1 2 3 4 5
        // Sample Output

        // 5 1 2 3 4

        public static List<int> rotLeft(List<int> a, int d)
        {
            List<int> retList = new List<int>();
            int index = d;
            int len = a.Count;
            int place = 0;

            for (var i = 0; i < len; i++)
            {
                if (index >= d && index >= len)
                {
                    retList.Add(a[place]);
                    ++place;
                }
                else if (index >= d)
                {
                    retList.Add(a[index]);
                    ++index;
                }
            }
            return retList;
        }

        //New Years Chaos
        //It is New Year's Day and people are in line for the Wonderland rollercoaster ride. Each person wears a sticker indicating their initial position in the queue from  to . Any person can bribe the person directly in front of them to swap positions, but they still wear their original sticker. One person can bribe at most two others.

        // Determine the minimum number of bribes that took place to get to a given queue order. Print the number of bribes, or, if anyone has bribed more than two people, print Too chaotic.

        // Example

        // If person  bribes person , the queue will look like this: . Only  bribe is required. Print 1.

        // Person  had to bribe  people to get to the current position. Print Too chaotic.

        // Function Description

        // Complete the function minimumBribes in the editor below.

        // minimumBribes has the following parameter(s):

        // int q[n]: the positions of the people after all bribes
        // Returns

        // No value is returned. Print the minimum number of bribes necessary or Too chaotic if someone has bribed more than  people.
        // Input Format

        // The first line contains an integer , the number of test cases.

        // Each of the next  pairs of lines are as follows:
        // - The first line contains an integer , the number of people in the queue
        // - The second line has  space-separated integers describing the final state of the queue.

        // Constraints

        // Subtasks

        // For  score
        // For  score

        // Sample Input

        // STDIN       Function
        // -----       --------
        // 2           t = 2
        // 5           n = 5
        // 2 1 5 3 4   q = [2, 1, 5, 3, 4]
        // 5           n = 5
        // 2 5 1 3 4   q = [2, 5, 1, 3, 4]
        // Sample Output

        // 3
        // Too chaotic

        public static void minimumBribes(List<int> q)
        {
            bool chaotic = false;
            int length = q.Count;
            int bribe = 0;

            for (var i = 0; i < length; i++)
            {
                if (q[i] - (i + 1) > 2)
                {
                    chaotic = true;
                    break;
                }
                for (int j = Math.Max(0, q[i] - 2); j < i; j++)
                    if (q[j] > q[i])
                        bribe++;
            }
            if (chaotic)
                Console.WriteLine("Too Chaotic");
            else
                Console.WriteLine(bribe);
        }

        // Minimum Swaps 2
        // You are given an unordered array consisting of consecutive integers 
        // [1, 2, 3, ..., n] without any duplicates. You are allowed to swap any 
        // two elements. Find the minimum number of swaps required to sort the array 
        // in ascending order.

        static int minimumSwaps(int[] arr)
        {
            int count = 0;
            int i = 0;
            while (i < arr.Length)
            {

                // If current element is
                // not at the right position
                if (arr[i] != i + 1)
                {

                    while (arr[i] != i + 1)
                    {
                        int temp = 0;

                        // Swap current element
                        // with correct position
                        // of that element
                        temp = arr[arr[i] - 1];
                        arr[arr[i] - 1] = arr[i];
                        arr[i] = temp;
                        count++;
                    }
                }

                // Increment for next index
                // when current element is at
                // correct position
                i++;
            }
            return count;
        }


        // Array Manipulation 
        //Starting with a 1-indexed array of zeros and a list of operations, for each operation add a value to each the array element between two given indices, inclusive. Once all operations have been performed, return the maximum value in the array.

        // Example


        // Queries are interpreted as follows:

        //     a b k
        //     1 5 3
        //     4 8 7
        //     6 9 1
        // Add the values of  between the indices  and  inclusive:

        // index->	 1 2 3  4  5 6 7 8 9 10
        // 	[0,0,0, 0, 0,0,0,0,0, 0]
        // 	[3,3,3, 3, 3,0,0,0,0, 0]
        // 	[3,3,3,10,10,7,7,7,0, 0]
        // 	[3,3,3,10,10,8,8,8,1, 0]
        // The largest value is  after all operations are performed.

        // Function Description

        // Complete the function arrayManipulation in the editor below.

        // arrayManipulation has the following parameters:

        // int n - the number of elements in the array
        // int queries[q][3] - a two dimensional array of queries where each queries[i] contains three integers, a, b, and k.
        // Returns

        // int - the maximum value in the resultant array

        public static long arrayManipulation(int n, List<List<int>> queries)
        {

            
        }

        private static void Main(string[] args)
        {

            int[] arr = { 2, 3, 4, 1, 5 };

            // Function to find minimum swaps
            Console.WriteLine(minimumSwaps(arr));
        }
    }
}