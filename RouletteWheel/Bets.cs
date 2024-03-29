﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RouletteWheel
{
    public enum TypesOfBets { Numbers = 1, Evens, Odds, Reds, Blacks, Lows, Highs, Dozens, Columns, Street, SixNumbers, Splits, Corners }
    public class Bets
    {
        
        //DOUBLE ZERO = 37
        public static int[] numbers = new int[]
        {
           0,1,2,3,4,5,6,7,8,9,10,11,12,
           13,14,15,16,17,18,19,20,21,22,23,24,
           25,26,27,28,29,30,31,32,33,34,35,36,37
        };
        public static int[] evens = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36 };
        public static int[] odds = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35 };
        public static int[] zeros = { 0, 37 };
        public static int[] reds = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
        public static int[] blacks = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35};
        public static int[] greens = { 0, 37 };
        public static int[] lows = Enumerable.Range(1, 17).ToArray();
        public static int[] highs = Enumerable.Range(19, 17).ToArray();
        public static int[,] dozens = new int[,]
        {
           {1,2,3,4,5,6,7,8,9,10,11,12},
           {13,14,15,16,17,18,19,20,21,22,23,24},
           {25,26,27,28,29,30,31,32,33,34,35,36}
        };
        public static int[,] streets = new int[,]
        {
            {1,2,3},{4,5,6},{7,8,9},
            {10,11,12},{13,14,15},{16,17,18},
            {19,20,21},{22,23,24},{25,26,27},
            {28,29,30},{31,32,33},{34,35,36}
        };
        public static int[,] columns = new int[,]
        {
            {1,4,7,10,13,16,19,22,25,28,31,34},
            {2,5,8,11,14,17,20,23,26,29,32,35},
            {3,6,9,12,15,18,21,24,27,30,33,36}
        };
        public static int[,] sixNums = new int[,]
        {
            {1,2,3,4,5,6},
            {7,8,9,10,11,12},
            {13,14,15,16,17,18},
            {19,20,21,22,23,24},
            {25,26,27,28,29,30},
            {31,32,33,34,35,36}
        };
        public static int[,] splits;


        public static void SplitPossibilities(out int[,] splits)
        {
            splits = new int[57, 2];
            int startpoint = 1;
            for (int i = 0; i < 24; i++)//each street of splits.
            {
                splits[i, 0] = startpoint;
                splits[i, 1] = ++startpoint;
                i++;
                splits[i, 0] = startpoint;
                splits[i, 1] = ++startpoint;
                ++startpoint;
            }
            startpoint = 1;
            for (int i = 24; i < splits.GetLength(0); i++)//each column of splits. 
            {
                splits[i, 0] = startpoint;
                splits[i, 1] = 3 + startpoint;
                startpoint++;
            }
        }


        public static int[,] corners = new int[,]
        {
            {1,2,4,5},{2,3,5,6},{4,5,7,8},{5,6,8,9},{7,8,10,11},{8,9,11,12},
            {13,14,16,17},{14,15,17,18},{16,17,19,20},{17,18,20,21},{19,20,22,23},
            {20,21,23,24},{22,23,25,26},{23,24,26,27},{25,26,28,29},{26,27,29,30},
            {28,29,31,32},{29,30,32,33},{31,32,34,35},{32,33,35,36}
        };


    }
}
