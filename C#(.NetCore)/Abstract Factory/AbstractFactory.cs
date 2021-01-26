using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Abstract_Factory
{
    class AbstractFactory
    {

        public static void Start()
        {
            Developer dev = new PanelDeveloper("ООО КирпичСтрой");
            House house2 = dev.Create();

            dev = new WoodDeveloper("Частный застройщик");
            House house = dev.Create();

            dev = new BrickDeveloper("Кирпичный зайстройщик");
            House house3 = dev.Create();
            Console.ReadLine();
        }

    }




    class PanelDeveloper : Developer
    {
        public PanelDeveloper(string n) : base(n)
        { }

        public override House Create()
        {
            return new PanelHouse();
        }
    }
    // строит деревянные дома
    class WoodDeveloper : Developer
    {
        public WoodDeveloper(string n) : base(n)
        { }

        public override House Create()
        {
            return new WoodHouse();
        }
    }
    class BrickDeveloper : Developer
    {
        public BrickDeveloper(string n) : base(n)
        { }
        public override House Create()
        {
            return new BrickHouse();
        }
    }

    abstract class Developer
    {
        public string Name { get; set; }

        public Developer(string n)
        {
            Name = n;
        }
        // фабричный метод
        abstract public House Create();
    }





    abstract class House
    { }

    class PanelHouse : House
    {
        public PanelHouse()
        {
            Console.WriteLine("Панельный дом построен");
        }
    }
    class WoodHouse : House
    {
        public WoodHouse()
        {
            Console.WriteLine("Деревянный дом построен");
        }
    }
    class BrickHouse : House
    {
        public BrickHouse()
        { Console.WriteLine("Кирпичный дом построен"); }
    }


}
