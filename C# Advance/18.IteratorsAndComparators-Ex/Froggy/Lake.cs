namespace Froggy
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class Lake : IEnumerable<int>
    {
        private List<int> stoneValues;

        public Lake(params int[] stoneValues)
        {
            this.stoneValues = stoneValues.ToList();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.stoneValues.Count; i+=2)
            {
                yield return this.stoneValues[i];
            }

            var startReverseIndex =
                this.stoneValues.Count % 2 == 0
                ? this.stoneValues.Count - 1
                : this.stoneValues.Count - 2;

            for (int i = startReverseIndex; i >= 0; i-=2)
            {
                yield return this.stoneValues[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
            => this.GetEnumerator();
    }
}
