﻿using System;
using System.Linq;

class Student : Human
{
    private string facultyNumber;

    public Student(string firstName, string lastName, string facultyNumber)
        : base(firstName, lastName)
    {
        this.FacultyNumber = facultyNumber;
    }

    public string FacultyNumber
    {
        get
        {
            return this.facultyNumber;
        }
        set
        {
            if (value.Length < 5 || value.Length > 10 ||
                value.Any(c => !Char.IsLetterOrDigit(c)))
            {
                throw new ArgumentException("Invalid faculty number!");
            }
            this.facultyNumber = value;
        }
    }

    public override string ToString()
    {
        return $@"First Name: {this.FirstName}
Last Name: {this.LastName}
Faculty number: {this.facultyNumber}";
    }
}