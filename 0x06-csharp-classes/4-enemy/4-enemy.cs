using System;

namespace Enemies
{
    /// <summary>Class with member health.</summary>
    public class Zombie
    {
        int health;
        string name = "(No name)";
        ///<summary>(String)Name of Zombie object.</summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        /// <summary>Creates a Zombie with health set to 0.</summary>
        public Zombie()
        {
            this.health = 0;
        }
        /// <summary>Creates a Zombie and sets health.</summary>
        /// <param name="value">The Zombie health.</param>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            this.health = value;
        }
        /// <summary>Returns Zombie health(int) value.</summary>
        public int GetHealth()
        {
            return this.health;
        }
    }
}
