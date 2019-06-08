namespace StrategyPattern
{
    using System.Collections.Generic;

    public class PersonNameLengthComparer : IComparer<Person>
    {
        public int Compare(Person first, Person second)
        {
            var nameLengthResult = first.Name.Length.CompareTo(second.Name.Length);

            if (nameLengthResult == 0)
            {
                return first.Name.ToLower()[0].CompareTo(second.Name.ToLower()[0]);
            }

            return nameLengthResult;
        }
    }
}