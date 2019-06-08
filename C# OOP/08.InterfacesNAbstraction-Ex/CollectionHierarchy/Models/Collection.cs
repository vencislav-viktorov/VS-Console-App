namespace CollectionHierarchy
{
    using System.Collections.Generic;

    public abstract class Collection : IAdd
    {
        private readonly List<string> list;

        public Collection()
        {
            this.list = new List<string>();
        }

        protected IList<string> List
        {
            get
            {
                return this.list;
            }
        }

        public abstract int Add(string element);
    }
}