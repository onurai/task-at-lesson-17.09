using System;
using System.Collections.Generic;
using System.Text;

namespace task_at_lesson_17._09
{
    public class Student
    {
        #region task 1
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Faculty { get; set; }
        public int Age { get; set; }

        public Student(string name, string surname, string faculty, int age)
        {
            num++;
            this.Id = num;
            this.Name = name;
            this.Name = surname;
            this.Faculty = faculty;
            this.Age = age;
        }
        public override string ToString()
        {
            return Id + " " + Name + " " + Surname + " " + Faculty + " " + Age;
        }

        public static int num = 100;
        #endregion







    }
}
