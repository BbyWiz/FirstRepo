﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    public class Node<T>
    {
        //Data
        public T Data { get; set; }

        //Link
        public Node<T> Next { get; internal set; }

        //constructor
        public Node(T data)
        {
            this.Data = data;
        }



    }
}
