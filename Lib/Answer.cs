namespace Lib
{
    public static class Answer
    {
        public static bool ExistsListAny(int[] ints, int k)
        {
            if (ints is null)
            {
                return false;
            }

           return ints.ToList().Any(x => x == k);
        }

        public static bool ExistsBuiltInBinarySearch(int[] ints, int k)
        {
            if (ints is null)
            {
                return false;
            }

            return Array.BinarySearch(ints, k) >= 0;
        }

        public static bool ExistsBubble(int[] ints, int k)
        {
            if (ints is null)
            {
                return false;
            }

            foreach (int x in ints)
            {
                if (x == k) return true;
            }

            return false;
        }

        public static bool ExistsBinarySearchChatGpt(int[] ints, int k)
        {
            int left = 0, right = ints.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (ints[mid] == k)
                    return true;
                else if (ints[mid] < k)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return false;
        }

        public static bool Exists(int[] ints, int k)
        {
            if (ints is null)
            {
                return false;
            }

            if (ints.Length == 0)
            {
                return false;
            }

            if (ints.Length == 1)
            {
                return ints[0] == k;
            }

            return ExistsInHalf(ints, k, 0, ints.Length - 1);
        }

        private static bool ExistsInHalf(int[] ints, int k, int startIndex, int endIndex)
        {
            //Console.WriteLine($"StartIndex : {startIndex} EndIndex: {endIndex}");
            if (startIndex == endIndex)
            {
                return ints[startIndex] == k;
            }

            if ((startIndex + 1) == endIndex)
            {
                return ints[endIndex] == k;
            }

            var half = (startIndex + endIndex) / 2;
            //Console.WriteLine($"Half: {half}");

            if (k > ints[half])
            {
                return ExistsInHalf(ints, k, half, endIndex);
            }
            else
            {
                return ExistsInHalf(ints, k, startIndex, half);
            }
        }
    }
}
