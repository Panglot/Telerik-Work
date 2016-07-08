namespace Homework02_Library.List
{
    using System;

    public class GenericList<T> where T : IComparable<T>
    {
        public T[] Content { get; private set; } = new T[8];
        public int Count { get; set; } = 0;

        public void Add(T item)
        {
            //Auto grow functionality if we exceed the current limit
            if (Count == Content.Length)
            {
                T[] temp = Content;
                Content = new T[Count + 8];
                for (int i = 0; i < temp.Length; i++)
                {
                    Content[i] = temp[i];
                }
            }
            Content[Count++] = item;
        }
        public T ElementAt(int position)
        {
            if (position > Count)
            {
                throw new ArgumentOutOfRangeException("The index is out of the list range.");
            }
            return Content[position];
        }
        public void InsertAt(int index, T item)
        {
            if (index > Count)
            {
                throw new ArgumentOutOfRangeException("The index is out of the list range.");
            }
            Count++;
            int displacement = 0;

            T[] temp = Content;

            if (Count >= Content.Length)
            {
                Content = new T[Count + 8];
            }
            else
            {
                Content = new T[Count];
            }

            Content[index] = item;
            for (int i = 0; i < Count; i++, displacement++)
            {
                if (i == index)
                {
                    displacement--;
                    continue;
                }
                Content[i] = temp[displacement];
            }
        }
        public void RemoveAt(int index)
        {
            if (index > Count)
            {
                throw new ArgumentOutOfRangeException("The index is out of the list range.");
            }
            Count--;
            int displacement = 0;

            T[] temp = Content;
            Content = new T[Count * 2];


            for (int i = 0; i < Count + 1; i++, displacement++)
            {
                if (i == index)
                {
                    displacement--;
                    continue;
                }
                Content[displacement] = temp[i];
            }
        }
        public void Clear()
        {
            Content = new T[8];
            Count = 0;
        }
        /// <summary>
        /// Searches for element by value. Returns the index number of the first element found or null if nothing is found.
        /// </summary>
        /// <param name="element">Element for search</param>
        /// <returns></returns>
        public int? Find(T element)
        {
            for (int? i = 0; i < Count; i++)
            {
                if (element.CompareTo(Content[(int)i]) == 0)
                {
                    return i;
                }
            }
            return null;
        }

        public override string ToString()
        {
            if (Count == 0)
            {
                return "The list is empty";
            }
            string forReturn = "{ ";
            for (int i = 0; i < Count - 1; i++)
            {
                forReturn += Content[i] + ", ";
            }
            forReturn += Content[Count - 1] + " }";
            return forReturn;
        }

        public T Min()
        {
            T min = this.Content[0];

            foreach (T item in this.Content)
            {
                if (min.CompareTo(item) > 0)
                {
                    min = item;
                }
            }
            return min;
        }
        public T Max()
        {
            T max = this.Content[0];

            foreach (T item in this.Content)
            {
                if (max.CompareTo(item) < 0)
                {
                    max = item;
                }
            }
            return max;
        }
    }
}
