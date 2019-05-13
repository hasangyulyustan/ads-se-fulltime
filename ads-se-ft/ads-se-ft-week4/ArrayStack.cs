﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASD_PartTime_2
{
    using System.Linq;

    public class ArrayStack<T>
    {
        private const int InitialCapacity = 16;

        private T[] elements;

        public ArrayStack(int capacity = InitialCapacity)
        {
            this.elements = new T[capacity];
        }

        public int Count { get; private set; }

        public void Push(T element)
        {
            if (this.Count == this.elements.Length)
            {
                this.Grow();
            }

            this.elements[this.Count] = element;
            this.Count++;
        }

        public T Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException();
            }

            this.Count--;
            return this.elements[this.Count];
        }

        public T[] ToArray()
        {
            return this.elements.Take(this.Count).Reverse().ToArray();
        }

        private void Grow()
        {
            Array.Resize(ref this.elements, this.Count * 2);
        }
    }
}
