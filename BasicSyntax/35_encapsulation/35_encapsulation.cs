using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Encapsulation is implemented by using access specifiers.
An access specifier defines the scope and visibility of a class member. C# supports the following access specifiers:

Public - can be accessed from outside the class
Private - hide its member variables and member functions from other functions and objects; only functions of the same class can access its private members; even an instance of a class cannot access its private members
Protected - allows a child class to access the member variables and member functions of its base class
Internal -  any member with internal access specifier can be accessed from any class or method defined within the application in which the member is defined
Protected internal - allows a class to hide its member variables and member functions from other class objects and functions, except a child class within the same application

what would be the default access specifier of a class member if we don't mention any? It is private.
*/


namespace _35_encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
