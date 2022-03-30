using System;
using System.Collections.Generic;
using System.Text;

namespace oop_game
{
    public class Character
    {
        private int shield;
        private int health;
        private int damage;
        private int highkick;

        public string Name { get; }
        public int Health { get => health; }
        public int Shield { get => shield; }
        public int Damage { get => damage; }
        public int Highkick { get => highkick; }

        public Character(string name)
        {
            Name = name;
            health = 100;
            shield = 50;
            damage = 20;
            highkick = 50;

        }
        public void GetHit(int damage)
        {
            {
                shield -= damage;
                if (shield < 0)
                {
                    health += shield;
                    shield = 0;
                }

            }

        }
        public void Heal()
        {
            health += 15;
        }
        public override string ToString()
        {
            string text = "Name: " + Name + "\n";
            text += "Health: " + health + "\n";
            text += "Shield: " + shield + "\n";
            text += "Damage: " + damage + "\n";
            text += "Highkick: " + highkick + "\n";
            return text;
        }
        public void PlusShield()
        {
            shield += 10;
        }
        public void EmotionalDamage(int damage)
        {
            health = 0;
            shield = 0;
        }
        public void GetHighkick (int highkick)
        {
            {
                shield -= highkick;
                if (shield < 0)
                {
                    health += shield;
                    shield = 0;
                }

            }
        }
    }

}
