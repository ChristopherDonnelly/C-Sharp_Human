using System;

namespace Human {
    public class Human {

        string name;
        int strength;
        int intelligence;
        int dexterity;
        int health;

        public Human(string name){
            this.name = name;
            this.strength = 3;
            this.intelligence = 3;
            this.dexterity = 3;
            this.health = 100;
        }

        public Human(string name, int strength = 3, int intelligence = 3, int dexterity = 3, int health = 100){
            this.name = name;
            this.strength = strength;
            this.intelligence = intelligence;
            this.dexterity = dexterity;
            this.health = health;
        }

        public Human Attack(object attacked){
            if(attacked is Human){
                Human opponent = attacked as Human;
                opponent.health -= (this.strength * 5);
            }else{
                Console.WriteLine("Sorry, you can only attack another Human!");
            }
            return this;
        }

        public Human DisplayHealth(){
            Console.WriteLine("{0}'s current Health is {1}", this.name, this.health);
            return this;
        }

        public Human DisplaySats(){
            Console.WriteLine("{0}'s Stats:", this.name);
            Console.WriteLine("Strength: {0}", this.strength);
            Console.WriteLine("Intelligence: {0}:", this.intelligence);
            Console.WriteLine("Dexterity: {0}:", this.dexterity);
            Console.WriteLine("Health: {0}:", this.health);
            Console.WriteLine(Environment.NewLine);
            return this;
        }
    }
}