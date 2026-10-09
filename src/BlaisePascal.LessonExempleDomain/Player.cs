using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.LessonExempleDomain
{
    public class Player
    {
        public string Name;
        private int _level;
        public int Level
        {
            get { return _level; }

            private set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Level must be greater than or equal to 1.");
                }
                _level = value;
            }
        }
        public int Experience { get; private set; }
        public int Health { get; private set; }
        public int MaxHealth { get; private set; }
        public bool IsAlive { get; private set; }
        public int Gold { get; private set; }

        public Player(string name, int level, int experience, int health, int maxHealth, bool isAlive, int gold)
        {
            Name = name;
            Level = level;
            Experience = experience;
            Health = health;
            MaxHealth = maxHealth;
            IsAlive = isAlive;
            Gold = gold;
        }

        public void Addexperience(int amount)
        {
            while (amount > 100)
            {
                Level += 1;
                amount -= 100;
            }
            Experience += amount;
        }

        public void ResetExperience()
        {
            Experience = 0;
        }

        public void TakeDamage(int damage)
        {

            if (damage < 0)
            {
                throw new ArgumentOutOfRangeException("Damage must be greater than or equal to 0.");
            }

            Health -= damage;
            if (Health <= 0)
            {
                Health = 0;
                IsAlive = false;
            }
        }

        public void Heal(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Heal amount must be greater than or equal to 0.");
            }
            Health += amount;
            if (Health > MaxHealth)
            {
                Health = MaxHealth;
            }
        }

        public void AddGold(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Gold amount must be greater than or equal to 0.");
            }
            Gold += amount;
        }
        public void resetHealth()
        {
            Health = MaxHealth;
            IsAlive = true;
        }

    }
}
