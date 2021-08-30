﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace arrays
{
    class Program
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
        List<int> sums = new List<int>();
        for(int i = 1; i < 5; i++)
        {
            for(int j = 1; j < 5; j++)
            {
                int leftTopCorner = arr[i-1][j-1];
                int topMiddle = arr[i-1][j];
                int rightTopCorner = arr[i-1][j+1];
                int middle = arr[i][j];
                int leftBottomCorner = arr[i+1][j-1];
                int bottomMiddle = arr[i+1][j];
                int rightBottomCorner = arr[i+1][j+1];
                int sum = leftTopCorner + topMiddle + rightBottomCorner
                                     + middle +
                       leftBottomCorner + bottomMiddle + rightBottomCorner;
                sums.Add(sum);
            }
        }
        foreach (var c in sums)
        {
            Console.WriteLine(c);
            
        }
        
        return sums.Max();
        }



        static void Main(string[] args)
        {
            // test case 1 passed
            // List<List<int>> testLest = new List<List<int>>();
            // testLest.Add(new List<int>{1, 1, 1, 0, 0, 0});
            // testLest.Add(new List<int>{0, 1, 0, 0, 0, 0});
            // testLest.Add(new List<int>{1, 1, 1, 0, 0, 0});
            // testLest.Add(new List<int>{0, 0, 2, 4, 4, 0});
            // testLest.Add(new List<int>{0, 0, 0, 2, 0, 0});
            // testLest.Add(new List<int>{0, 0, 1, 2, 4, 0});

            // test case 2
            List<List<int>> testLest = new List<List<int>>();
            testLest.Add(new List<int>{-9, -9, -9, 1, 1, 1});
            testLest.Add(new List<int>{0, -9, 0, 4, 3, 2});
            testLest.Add(new List<int>{-9, -9, -9, 1, 2, 3});
            testLest.Add(new List<int>{0, 0, 8, 6, 6, 0});
            testLest.Add(new List<int>{0, 0, 0, -2, 0, 0});
            testLest.Add(new List<int>{0, 0, 1, 2, 4, 0});
            
            hourglassSum(testLest);

        }
    }
}