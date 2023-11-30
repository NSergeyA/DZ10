using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ10
{
    internal class Student
    {
        public string Name { get; set; }
        public string Group { get; set; }


        public Student(string name, string group)
        {
            Name = name;
            Group = group;
            
        }

       