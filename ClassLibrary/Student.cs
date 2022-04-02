using System;
using System.Collections.Generic;
using System.Text;
using Extentions;

namespace ClassLibrary
{
    public  class Student
    {
        public Student(string fullname, string groupNo, int age)
        {
            _fullname=fullname;
            _groupNo=groupNo;
            Age=age;
        }
        string _groupNo;
        string _fullname;
        public string Fullname
        {
            get => _fullname; set
            {
                if (value.IsFullname())
                {
                    _fullname = value;
                }
                else
                {
                    _fullname = "No Data";
                }
            }
        }
        public string GroupNo
        {
            get => _groupNo; set
            {
                if(value.IsGroupNo()) _groupNo = value;
            }
        }
        public int Age { get; set; }



    }
}
