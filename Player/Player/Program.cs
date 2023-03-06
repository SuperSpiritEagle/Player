using System;

namespace Player
{
    class Program
    {
        static void Main(string[] args)
        {
            Palyers palyer = new Palyers(10,20,30);
            palyer.Print();
        }

        class Palyers
        {
            private int _health = 100;
            public int _speed;
            public int _damage;

            public Palyers(int health, int speed, int damage)
            {
                _health = health;
                _speed = speed;
                _damage = damage;
            }

            public Palyers()
            {

            }

            public void Print()
            {
                Console.WriteLine($"Жизнь = {_health} Speed = {_speed} Damage = {_damage}");
            }
        }
    }
}
