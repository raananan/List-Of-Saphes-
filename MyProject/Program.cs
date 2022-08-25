using System;
using System.Collections.Generic;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Shape> ShapeList = new List<Shape>();
            ShapeList.Add(new Shape("Square", "a2", "4a"));
            ShapeList.Add(new Shape("Rhombus", "pa/2", "4a"));
            ShapeList.Add(new Shape("Rectangle", "wl", "2(w+i)"));
     

            foreach (var item in ShapeList)
             Console.WriteLine("Name: {0}, Area: {1}, Perimeter: {2}", item.getName, item.getArea, item.Getperimeter);


        }

    }
    }

public class Shape
{
    private string name;
    private string area;
    private string perimeter;

    // constructor
    public Shape(string name, string area, string perimeter)
    {
        this.name = name;
        this.area = area;
        this.perimeter = perimeter;
    }

    public string getName
    {
        get { return name; }
    }
    public string getArea
    {
        get { return area; }
    }
    public string Getperimeter
    {
        get { return perimeter; }
    }
}

