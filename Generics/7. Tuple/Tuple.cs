﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TupleType
{
    public class Tuple<T,V>
    {
        public Tuple(T item1, V item2)
        {
            this.Item1 = item1;
            this.Item2 = item2;
        }
        public T Item1 { get; set; }
        public V Item2 { get; set; }

        public override string ToString()
        {
            return $"{this.Item1} -> {this.Item2}";
        }
    }
}
