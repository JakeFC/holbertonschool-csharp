using System;

namespace Enemies
{
    /// <summary>Class with members health and name.</summary>
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
        /// <summary>Returns the formatted string "Zombie Name: name / Total Health: health".</summary>
        public override string ToString()
        {
            return String.Format("Zombie Name: {0} / Total Health: {1}", this.name, this.health);
        }
    }
}
