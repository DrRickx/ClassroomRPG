using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomRPG
{
    public abstract class StudentHero
    {
        public string Name { get; private set; }
        public int health { get; private set; }
        public int maxHealth { get; private set; }

        public string SpritePath { get; protected set; }

        public StudentHero(string name, int maxHealth)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("name");
            }
            if (maxHealth <= 0)
            {
                throw new ArgumentOutOfRangeException("maxHealth", "Max health must be greater than zero.");
            }

            Name = name;
            this.maxHealth = maxHealth;
            this.health = maxHealth;
            SpritePath = string.Empty;
        }

        public abstract int Attack();


        public virtual void TakeDamage(int damage)
        {
            if (damage < 0)
            {
                throw new ArgumentOutOfRangeException("damage", "Damage cannot be negative.");
            }
            health -= damage;
            if (health < 0)
            {
                health = 0;
            }
        }   
    }
}
 