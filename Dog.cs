using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Practice
{
    class Dog
    {
        
        private string hairLength;
        private double height;
        private string runningSpd;
        private double weight;

        public string HairLength
        { 
            get { return this.hairLength; }
            set { this.hairLength = value; }

        }
        public Dog()
        {

        }
        public Dog(string hairLength, double height, string runningSpd, double weight )
        {
            this.hairLength = hairLength;
            this.height = height;
            this.runningSpd = runningSpd;
            this.weight = weight;

        }
        public void Bark()
        {
            Console.WriteLine("\a");
        }
        public void Run()
        {
            switch (runningSpd)
                case 
        }
    }
       
   
    
}
