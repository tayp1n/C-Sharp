﻿using System;

namespace Test.ClassesForVM.Departamens
{
    public class MainDeportament : BaseDepartament
    {
        public MainDeportament(string title, int parentId = 0) : base(title, parentId)
        {
        }

        public MainDeportament() : base()
        {
        }

        protected string address;
        public string Address
        {
            get { return address; }
            set
            {
                address = value;
                OnPropertyChanged("");
            }
        }

        protected DateTime birthDay;
        public DateTime BirthDay
        {
            get { return birthDay; }
            set
            {
                birthDay = value;
                OnPropertyChanged("");
            }
        }

    }
}
