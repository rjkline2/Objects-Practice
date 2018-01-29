using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Practice
{
    class Cat
    {
        //STATES
        
       //fields
        private string name;
        private int age;
        private string furColor;
        private bool isHungry = true;

       // Properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
       // BEHAVIORS
        // Contructors
       public Cat()
        {
            //default contructor
            //takes no parameters (nothing in the parentheses)
        }
        public Cat(string name, int age, string furColor)
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;
        }
        public void Eat()
        {
            if (isHungry)//this means if isHungry is set to true...NOTE!!!
            {
                isHungry = false;
            }
            Console.WriteLine("Is the cat hungry?" + isHungry );
        }

        public void Meow()
        {
            Console.WriteLine("\a");
        }
    }
}
