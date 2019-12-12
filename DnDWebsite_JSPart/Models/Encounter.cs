using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDWebsite_JSPart.Models
{
    public class Encounter
    {
        /// <summary>
        /// Programmer: Jonah Spear
        /// Email: jspear2@cnm.edu
        /// Enounter.cs - model class to represent a DnD enounter, takes in a list of players
        /// and generates an appropriate list of monsters(CR) to fight the players, can take in a list of monsters instead
        /// </summary>

        #region props
        //teams
        public List<Monster> NPCs { get; set; }
        public List<Character> Players { get; set; }

        //string to read in for difficulty dm wants
        public string Difficulty { get; set; }

        //exp amount
        public double adjustedExp{ get; set; }
        public double totalExp { get; set; }
        //solely for calculations
        private double easyExp { get; set; }
        private double medExp { get; set; }
        private double hardExp { get; set; }
        private double deadExp { get; set; }
        private int emptyCount { get; set; }

        // planning to add initative rolls to either the enounter model or the monster/character models
        //public List<int> iniRolls { get; set; }
        #endregion

        #region R/O vars
        //Lists for encounter difficulty
        //sorted by level-1
        //may be changed later
        private static List<double> Easy = new List<double> { 25, 50, 75, 125, 250, 300, 350, 450, 550, 600, 800, 1000, 1100, 1250, 1400, 1600, 2000, 2100, 2400, 2800 };
        private static List<double> Medium = new List<double> { 50, 100, 150, 250, 500, 600, 750, 900, 1100, 1200, 1600, 2000, 2200, 2500, 2800, 3200, 3900, 4200, 4900, 5700 };
        private static List<double> Hard = new List<double> {75, 150, 225, 375, 750, 900, 1100, 1400, 1600, 1900, 2400, 3000, 3400, 3800, 4300, 4800, 5900, 6300, 7300, 8500};
        private static List<double> Deadly = new List<double> { 100, 200, 400, 500, 1100, 1400, 1700, 2100, 2400, 2800, 3600, 4500, 5100, 5700, 6400, 7200, 8800, 9500, 10900, 12700 };
        private static List<double> CrToExp = new List<double> {10, 25, 50, 100, 200, 450, 700, 1100, 1800, 2300, 2900, 3900, 5000, 5900,7200,8400,10000,11500,13000,15000,18000,20000,22000,25000, 33000, 41000,50000,62000,155000};
        //TODO: add CR to Exp conversion
        #endregion

        #region constructor
        public Encounter() 
        {
            Players = new List<Character> 
            {
                new Character(),
                new Character(),
                new Character(),
                new Character(),
                new Character()
            };
            NPCs = new List<Monster>
            {
                new Monster(),
                new Monster(),
                new Monster(),
                new Monster(),
                new Monster()
            };
            emptyCount = 0;
        }
        #endregion

        #region methods
        //calc random enounter
        public void ReadEncounter() 
        {
            foreach (Monster m in NPCs)
            {
                #region Add monster exp
                switch (m.CR)
                {
                    case 0:
                        emptyCount++;
                        break;
                    case 0.125:
                        totalExp += CrToExp[1];
                        break;
                    case 0.25:
                        totalExp += CrToExp[2];
                        break;
                    case 0.5:
                        totalExp += CrToExp[3];
                        break;
                    case 1:
                        totalExp += CrToExp[4];
                        break;
                    case 2:
                        totalExp += CrToExp[5];
                        break;
                    case 3:
                        totalExp += CrToExp[6];
                        break;
                    case 4:
                        totalExp += CrToExp[7];
                        break;
                    case 5:
                        totalExp += CrToExp[8];
                        break;
                    case 6:
                        totalExp += CrToExp[9];
                        break;
                    case 7:
                        totalExp += CrToExp[10];
                        break;
                    case 8:
                        totalExp += CrToExp[11];
                        break;
                    case 9:
                        totalExp += CrToExp[12];
                        break;
                    case 10:
                        totalExp += CrToExp[13];
                        break;
                    case 11:
                        totalExp += CrToExp[14];
                        break;
                    case 12:
                        totalExp += CrToExp[15];
                        break;
                    case 13:
                        totalExp += CrToExp[16];
                        break;
                    case 14:
                        totalExp += CrToExp[17];
                        break;
                    case 15:
                        totalExp += CrToExp[18];
                        break;
                    case 16:
                        totalExp += CrToExp[19];
                        break;
                    case 17:
                        totalExp += CrToExp[20];
                        break;
                    case 18:
                        totalExp += CrToExp[21];
                        break;
                    case 19:
                        totalExp += CrToExp[22];
                        break;
                    case 20:
                        totalExp += CrToExp[23];
                        break;
                    case 21:
                        totalExp += CrToExp[24];
                        break;
                    case 22:
                        totalExp += CrToExp[25];
                        break;
                    case 23:
                        totalExp += CrToExp[26];
                        break;
                    case 24:
                        totalExp += CrToExp[27];
                        break;
                    case 25:
                        totalExp += CrToExp[28];
                        break;
                    case 26:
                        totalExp += CrToExp[29];
                        break;
                    case 27:
                        totalExp += CrToExp[30];
                        break;
                    case 28:
                        totalExp += CrToExp[31];
                        break;
                    case 29:
                        totalExp += CrToExp[32];
                        break;
                    case 30:
                        totalExp += CrToExp[33];
                        break;
                }//switch
                #endregion

                #region determine player difficult
                foreach (Character c in Players)
                {
                    if (c.Level != 0) 
                    {
                        easyExp += Easy[c.Level - 1];
                        medExp += Medium[c.Level - 1];
                        hardExp += Hard[c.Level - 1];
                        deadExp += Deadly[c.Level - 1];
                    }
                }
                #endregion

                if (emptyCount > 1)
                {
                    adjustedExp = totalExp + (totalExp * .5);
                }
                else 
                {
                    adjustedExp = totalExp;
                }

                if (adjustedExp <= easyExp)
                {
                    Difficulty = "easy";
                }
                else if (adjustedExp <= medExp) 
                {
                    Difficulty = "medium";
                }
                else if (adjustedExp <= hardExp)
                {
                    Difficulty = "hard";
                }
                else 
                {
                    Difficulty = "deadly";
                }

            }
        }
        #endregion

    }//class
}
