using System.Collections;

namespace CompareArrays
{
    public class ArrayComparer
    {
        public bool EqualityOperator(int[] firstArray, int[] secondArray)
        {
            return firstArray == secondArray;
        }

        public bool StringJoin(int[] firstArray, int[] secondArray)
        {
            return string.Join("=>", firstArray) == string.Join("=>", secondArray);
        }

        public bool ForLoop(int[] firstArray, int[] secondArray)
        {
            if (firstArray.Length != secondArray.Length)
                return false;

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                    return false;
            }

            return true;
        }

        public bool ForeachLoop(int[] firstArray, int[] secondArray)
        {
            if (firstArray.Length != secondArray.Length)
                return false;

            var index = 0;
            foreach (var item in firstArray)
            {
                if (item != secondArray[index])
                    return false;

                index++;
            }

            return true;
        }

        public bool EnumerableSequenceEqual(int[] firstArray, int[] secondArray)
        {
            return Enumerable.SequenceEqual(firstArray, secondArray);
        }

        public bool EnumerableEquals(int[] firstArray, int[] secondArray)
        {
            return Enumerable.Equals(firstArray, secondArray);
        }

        public bool EnumerableReferenceEquals(int[] firstArray, int[] secondArray)
        {
            return Enumerable.ReferenceEquals(firstArray, secondArray);
        }

        public bool StructuralEquatable(int[] firstArray, int[] secondArray)
        {
            IStructuralEquatable structuralEquatable = firstArray;

            return structuralEquatable.Equals(secondArray, StructuralComparisons.StructuralEqualityComparer);
        }
    }
}
