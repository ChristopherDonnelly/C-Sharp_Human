using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human mark = new Human("Mark", 5, 5, 5, 1000);
            Human ashley = new Human("Ashley", 10, 10, 10, 500);

            mark.DisplaySats();
            ashley.DisplaySats();

            ashley.Attack(mark).Attack(mark);
            mark.DisplayHealth();
        }
    }
}
