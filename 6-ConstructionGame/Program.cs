using System;
using System.Collections.Generic;
using System.Text;

namespace _6_ConstructionGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var myHouse = new Building()
                .AddKitchen()
                .AddBedroom("master")
                .AddBedroom("guest")
                .AddBalcony();

            var normalHouse = myHouse.Build();

            //kitchen, master room, guest room, balcony
            Console.WriteLine(normalHouse.Describe());

            myHouse.AddKitchen().AddBedroom("another");

            var luxuryHouse = myHouse.Build();

            //it only shows the kitchen after build
            //kitchen, master room, guest room, balcony, kitchen, another room
            Console.WriteLine(luxuryHouse.Describe());

            Console.ReadKey();

        }
    }

    #region Building Class
    public class Building
    {
        readonly IList<IComponent> _buildingComponents = new List<IComponent>();
        readonly StringBuilder _description = new StringBuilder();

        public Building AddKitchen()
        {
            _buildingComponents.Add(new Kitchen());

            return this;
        }

        public Building AddBedroom(string name)
        {
            _buildingComponents.Add(new Bedroom(name));

            return this;
        }

        public Building AddBalcony()
        {
            _buildingComponents.Add(new Balcony());

            return this;
        }

        public Building Build()
        {
            _description.Clear();

            foreach (var item in _buildingComponents)
            {
                _description.Append($"{item.Name}, ");
            }

            return this;
        }

        public string Describe()
        {
            _description.Remove(_description.Length - 1, 1);

            return _description.ToString();
        }
    }
    #endregion

    #region Building Components
    public interface IComponent
    {
        string Name { get; set; }
    }

    public class Kitchen : IComponent
    {
        public string Name { get; set; }
        public Kitchen()
        {
            Name = "kitchen";
        }
    }

    public class Bedroom : IComponent
    {
        public string Name { get; set; }
        public Bedroom(string name)
        {
            Name = $"{name} room";
        }
    }

    public class Balcony : IComponent
    {
        public string Name { get; set; }
        public Balcony()
        {
            Name = "balcony";
        }
    }
    #endregion
}