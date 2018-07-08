﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inherit
{
    class student:person
    {
        public int Id { get; set; }
        public student()
        {
        }

        internal void ShowStudent()
        {
            throw new NotImplementedException();
        }



        /// <summary>
        ///  آیدی و سن و نام و وضعیت تعهل
        /// </summary>
        /// <param name="id"></param>
        /// <param name="age"></param>
        /// <param name="fullName"></param>
        /// <param name="ezdevaj"></param>
        public student(int id,int age,string fullName,enamezdevaj ezdevaj) :base(age,fullName,ezdevaj)
        {
            Id = id;
        }
        public void Display()
        {
            Console.WriteLine($"\n  FullName: {FullName} \n Age: {Age} \n Id:{Id}\n ezdevaj:{Ezdevaj} ");
        }
        public override string ToString()
        {
            return string.Format($"\n  FullName: {FullName} \n Age: {Age} \n Id:{Id}\n ezdevaj:{Ezdevaj} ");
        }
    }
}
