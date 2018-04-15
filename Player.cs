using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatedFootballTeam
{
    class Player
    {
        //издържливост, Спринт, дрибъл, подавания и стрелба
        private string name;
        private int endurance;
        private int sprint;
        private int drible;
        private int pass;
        private int shooting;

        public Player(string name, int endurance, int sprint, int drible, int pass, int shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Drible = drible;
            this.Pass = pass;
            this.Shooting = shooting;
        }



        public Player()
        {
        }

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrEmpty(value) || value.Trim().Length == 0)
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                this.name = value;
            }
        }
        private int Endurance
        {
            get => endurance;
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Endurance should be between 0 and 100.");
                }
                endurance = value;
            }
               
        }
        private int Sprint
        {
            get => sprint;
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Sprint should be between 0 and 100.");
                }
                sprint = value;
            }
        }
        private int Drible
        {
            get => drible;
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Drible should be between 0 and 100.");
                }
                drible = value;
            }
        }
        private int Pass
        {
            get => pass;
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Pass should be between 0 and 100.");
                }
                pass = value;
            }
        }
        private int Shooting
        {
            get => shooting;
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Shooring should be between 0 and 100.");
                }
                shooting = value;
            }
        }

        public int GetStatistic()
        {
            return (int)Math.Ceiling((Endurance + Sprint + Drible + Pass + Shooting) / 5.0);
        }
    }
}
