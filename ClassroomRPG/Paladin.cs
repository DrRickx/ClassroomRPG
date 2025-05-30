﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomRPG
{
    class Paladin: StudentHero
    {
        Random random = new Random();

        public Paladin(string name) : base(name, 150)
        {
            Random random = new Random();
            SpritePath = "Resources/cleric.png";
        }

        public override int Attack()
        {
            // 70% chance of normal damage (10–20), 30% chance of a critical debug hit (25–35)
            int roll = random.Next(1, 101);
            if (roll <= 70)
            {
                return random.Next(10, 21); // normal attack
            }
            else
            {
                return random.Next(25, 36); // critical debug hit
            }
        }
    }
}
