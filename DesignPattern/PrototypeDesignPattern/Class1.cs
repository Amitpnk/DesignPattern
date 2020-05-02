﻿using System;

namespace PrototypeDesignPattern
{
    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public Employee GetClone()
        {
            // Memberwise clone creates a fresh object rather than point BYREF
            return (Employee)this.MemberwiseClone();
        }
    }
}
