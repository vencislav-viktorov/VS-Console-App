namespace ListyIterator
{
    using System.Collections.Generic;

    public class ListyIterator<T>
    {
        private List<T> data;
        private int index;

        public ListyIterator(List<T> data)
        {
            this.data = data;
        }

        public bool Move()
        {
            if (HasNext())
            {
                this.index++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            if (index + 1 < this.data.Count)
            {
                return true;
            }

            return false;
        }

        public string Print()
        {
            if (this.data.Count == 0)
            {
                return "Invalid Operation!";
            }

            return this.data[index].ToString();
        }
    }
}
