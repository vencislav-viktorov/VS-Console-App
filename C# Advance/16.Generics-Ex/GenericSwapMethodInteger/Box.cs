using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodInteger
{
    public class Box<T>
    {
        private List<T> data;

        public Box()
        {
            this.data = new List<T>();
        }

        public List<T> Data => this.data;

        public void Add(T item)
        {
            this.data.Add(item);
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            var temp = this.data[firstIndex];
            this.data[firstIndex] = this.data[secondIndex];
            this.data[secondIndex] = temp;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            foreach (var item in this.data)
            {
                stringBuilder.AppendLine($"{typeof(T)}: {item}");
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
