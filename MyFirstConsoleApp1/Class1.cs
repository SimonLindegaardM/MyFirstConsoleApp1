using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstConsoleApp1
{
    class Person
    {
        private string _name;
        private int _age;
        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }
        public string name
        {
            get { return _name; }
        }
        public int age
        {
            get { return _age; }
        }
    }
}
