﻿namespace Tree
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Program
    {
        public static void Main(string[] args)
        {
            var tree = new Tree<int>(34, 
                        new Tree<int>(43), 
                        new Tree<int>(4), 
                        new Tree<int>(143));
            
        }
    }
}
