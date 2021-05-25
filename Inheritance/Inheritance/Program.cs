using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //Single level inheritance
    /*
    public class Vehicle //base class
    {
        string number;
        string owner;
    }

    //Derived class of vehicle
    public class Car : Vehicle
    {
        int numberOfDoors;
    }
    */

    //Multilevel level inheritance
    /*
    public class Vehicle //base class
    {
        string number;
        string owner;
    }

    public class FourWheeler : Vehicle //derived class
    {
        string type;
    }

    public class Car : FourWheeler // derived class 
    {
        int numberOfDoors;
    }
    */

    //Hierarchical inheritance
    /*
    public class Vehicle //base class
    {
        string number;
        string owner;
    }

    public class FourWheeler : Vehicle //derived class
    {
        string type;
    }

    public class Tractor : FourWheeler // derived class 
    {
        int numberOfAxels;
    }

    public class Car : FourWheeler // derived class 
    {
        int numberOfDoors;
    }
    */

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
