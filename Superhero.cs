using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Practice
{
    class Superhero
    {
        //STATES

        //fields
        private string name;
        private string intel;
        private int str;
        private int speed;
        private string durability;
        private string energyProjection;
        private string fightAbility;
        private bool kryptonite = false;
        private bool yellowSun = true;


        // Properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Intel
        {
            get { return this.intel; }
            set { this.intel = value; }
        }
        public int Str
        {
            get { return this.str; }
            set { this.str = value; }
        }
        public string EnergyProjection
        {
            get { return this.energyProjection; }
            set { this.energyProjection = value; }
        }
        public string Durability
        {
            get { return this.durability; }
            set { this.durability = value; }
        }
        // BEHAVIORS
        // Contructors
        public Superhero()
        {
            //default contructor
            //takes no parameters (nothing in the parentheses)
        }
        public Superhero(string name, int str, string durability, string energyProjection )
        {
            this.name = name;
            this.str = str;
            this.durability = durability;
            this.energyProjection = energyProjection;
        }
        public Superhero(int str, string durability, string energyProjection )
        {

            this.str = str;
            this.durability = durability;
            this.energyProjection = energyProjection;
        }
        public void Weakness()
        {
            if (kryptonite)
            {
                kryptonite = true;
            }
            durability = "Weak";
            str = 1;
            energyProjection = "None";   
        }
        public void AbsorbYellowSun()
        {
            if (yellowSun)
            {
                yellowSun = false;
            }
            durability = "Normal";
            str = 2;
            energyProjection = "None";
        }
            



    }
}
