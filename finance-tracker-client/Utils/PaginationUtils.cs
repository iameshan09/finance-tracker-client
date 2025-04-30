namespace finance_tracker_client.Utils
{
    public static class PaginationUtils
{
        public static bool HasDataForPage<T>(int newPage, int rowsPerPage, int totalRecords, List<T> rows)
        {
            int startIndex = newPage * rowsPerPage;
            int endIndex = Math.Min(startIndex + rowsPerPage, totalRecords);
            int expectedCount = endIndex - startIndex;

            return rows.GetRangeSafe(startIndex, expectedCount).Count == expectedCount;
        }

        private static List<T> GetRangeSafe<T>(this List<T> list, int index, int count)
        {
            if (index >= list.Count) return new List<T>();
            if (index + count > list.Count)
            {
                count = list.Count - index;
            }
            return list.GetRange(index, count);
        }
    }
}
