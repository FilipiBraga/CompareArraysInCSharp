using BenchmarkDotNet.Attributes;

namespace CompareArrays
{
    public class ArrayComparer
    {
        [Benchmark]
        public bool EqualOperator(int[] firstArray, int[] secondArray)
        {
            return firstArray == secondArray;
        }

        [Benchmark]
        public bool StringJoin(int[] firstArray, int[] secondArray)
        {
            return string.Join("=>", firstArray) == string.Join("=>", secondArray);
        }
    }
}
