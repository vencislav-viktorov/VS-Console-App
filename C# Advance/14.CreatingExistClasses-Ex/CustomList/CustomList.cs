namespace CustomListDemo
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class CustomList
    {
        private int capacity;
        private object[] arr;

        public CustomList()
        {
            this.arr = new object[0];
            this.Count = 0;
        }

        public object[] Arr
        {
            get { return this.GetOnlyRealElements(); }
            //private set { this.arr = value; }
        }

        public object this[int index]
        {
            get
            {
                if (index >= this.Count || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }

                return this.arr[index];
            }
        }

        public int Count { get; private set; }

        public int Capacity
        {
            get { return capacity; }
            set { this.capacity = value; }
        }

        public void Add(object element)
        {
            if (this.Count == this.arr.Length)
            {
                this.Resize();
            }

            this.arr[Count] = element;
            this.Count++;
        }

        public object RemoveAt(int index)
        {
            if (index < 0 || index >= capacity)
            {
                throw new InvalidOperationException("Index out of range");
            }

            object obj = this.arr[index];
            this.arr[index] = null;

            for (int i = index; i < this.Count - 1; i++)
            {
                this.arr[i] = this.arr[i + 1];
            }

            this.Count--;
            this.arr[Count
] = null;

            return obj;
        }

        public bool Contains(object obj)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (obj.Equals(this.arr[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            if (firstIndex < 0 ||
                secondIndex < 0 ||
                firstIndex >= capacity ||
                secondIndex >= capacity)
            {
                throw new IndexOutOfRangeException("Invalid Index");
            }
                object temp = this.arr[firstIndex];
                this.arr[firstIndex] = this.arr[secondIndex];
                this.arr[secondIndex] = temp;
        }

        private void Resize()
        {
            this.Capacity = this.arr.Length * 2 == 0
                ? 4
                : this.arr.Length * 2;

            object[] temp = new object[this.Capacity];

            for (int i = 0; i < this.Count; i++)
            {
                temp[i] = arr[i];
            }

            this.arr = temp;
        }

        private object[] GetOnlyRealElements()
        {
            object[] temp = new object[this.Count];

            for (int i = 0; i < this.Count; i++)
            {
                temp[i] = arr[i];
            }

            return temp;
        }
    }
}