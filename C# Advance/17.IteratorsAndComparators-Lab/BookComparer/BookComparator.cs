namespace IteratorsAndComparators
{
    using System.Collections.Generic;

    public class BookComparator : IComparer<Book>
    {
        public int Compare(Book first, Book second)
        {
            int titleCompare = first.Title.CompareTo(second.Title);

            if (titleCompare == 0)
            {
                titleCompare = second.Year.CompareTo(first.Year);
            }

            return titleCompare;
        }
    }
}
