using System;
using System.Collections.Generic;

namespace Assignment3
{
    public static class TowerOfHanoi
    {

        public static int GetNumberOfSteps(int numDiscs)
        {
            if (numDiscs < 0)
            {
                return -1;
            }

            return (int)Math.Pow(2, numDiscs) - 1;
        }

        public static List<List<int>[]> SolveTowerOfHanoi(int numDiscs)
        {
            List<List<int>[]> snapshots = new List<List<int>[]>();

            if (numDiscs < 1)
            {
                return snapshots;
            }

            List<int>[] pegs = new List<int>[3]
            {
                new List<int>(numDiscs),
                new List<int>(),
                new List<int>()
            };

            for (int i = numDiscs; i >= 1; i--)
            {
                pegs[0].Add(i);
            }

            snapshots.Add(ClonePegs(pegs));
            MoveDiscs(numDiscs, pegs, 0, 2, 1, snapshots);

            return snapshots;
        }

        public static void MoveDiscs(int numDiscs, List<int>[] pegs, int fromPeg, int toPeg, int usingPeg, List<List<int>[]> snapshots)
        {
            if (numDiscs <= 0)
            {
                return;
            }

            MoveDiscs(numDiscs - 1, pegs, fromPeg, usingPeg, toPeg, snapshots);

            pegs[toPeg].Add(pegs[fromPeg][pegs[fromPeg].Count - 1]);
            pegs[fromPeg].RemoveAt(pegs[fromPeg].Count - 1);
            snapshots.Add(ClonePegs(pegs));

            MoveDiscs(numDiscs - 1, pegs, usingPeg, toPeg, fromPeg, snapshots);
        }

        public static List<int>[] ClonePegs(List<int>[] pegs)
        {
            List<int>[] clonedPegs = new List<int>[3]
            {
                new List<int>(pegs[0].Count),
                new List<int>(pegs[1].Count),
                new List<int>(pegs[2].Count)
            };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < pegs[i].Count; j++)
                {
                    clonedPegs[i].Add(pegs[i][j]);
                }
            }

            return clonedPegs;
        }
    }
}