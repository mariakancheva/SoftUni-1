﻿using System;

class Human
{
    private string firstName;
    private string lastName;

    public Human(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public string FirstName
    {
        get
        {
            return this.firstName;
        }
        set
        {
            if(value.Length <= 3)
            {
                throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
            }
            if (Char.IsLower(value[0]))
            {
                throw new ArgumentException("Expected upper case letter! Argument: firstName");
            }

            this.firstName = value;
        }
    }

    public string LastName
    {
        get
        {
            return this.lastName;
        }
        set
        {
            if (value.Length <= 2)
            {
                throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
            }
            if (Char.IsLower(value[0]))
            {
                throw new ArgumentException("Expected upper case letter! Argument: lastName");
            }

            this.lastName = value;
        }
    }
}