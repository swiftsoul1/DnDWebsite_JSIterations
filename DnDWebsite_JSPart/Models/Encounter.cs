using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACarrion_JSpear_JWilson_JGuevara_GroupProject.Models
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
        public string DifficultySel { get; set; }

        //exp amount
        public int totalExp { get; set; }
        //solely for calculations
        private int currentExp { get; set; }
        private int overExp { get; set; }

        // planning to add initative rolls to either the enounter model or the monster/character models
        //public List<int> iniRolls { get; set; }
        #endregion

        #region R/O vars
        //Lists for encounter difficulty
        //sorted by level-1
        //may be changed later
        private static List<int> Easy = new List<int> { 25, 50, 75, 125, 250, 300, 350, 450, 550, 600, 800, 1000, 1100, 1250, 1400, 1600, 2000, 2100, 2400, 2800 };
        private static List<int> Medium = new List<int> { 50, 100, 150, 250, 500, 600, 750, 900, 1100, 1200, 1600, 2000, 2200, 2500, 2800, 3200, 3900, 4200, 4900, 5700 };
        private static List<int> Hard = new List<int> {75, 150, 225, 375, 750, 900, 1100, 1400, 1600, 1900, 2400, 3000, 3400, 3800, 4300, 4800, 5900, 6300, 7300, 8500};
        private static List<int> Deadly = new List<int>{ 100, 200, 400, 500, 1100, 1400, 1700, 2100, 2400, 2800, 3600, 4500, 5100, 5700, 6400, 7200, 8800, 9500, 10900, 12700 };
        //TODO: add CR to Exp conversion
        #endregion

        #region constructor
        public Encounter(List<Character> players, string dif) 
        {
            Players = players;
            DifficultySel = dif;
            CalcEncounter();

        }//randomly generate
        public Encounter(List<Character> players, List<Monster> adds)
            :this(players, "")
        {
            NPCs = adds;
        }//to set in own monsters
        #endregion

        #region methods
        //calc random enounter
        public void CalcEncounter() 
        {

            switch(DifficultySel)
            {
                case "easy":
                    //get total exp needed 
                    foreach (Character player in Players)
                    {
                        totalExp += Easy[player.Level - 1];
                        overExp += Medium[player.Level - 1];
                    }

                    //add random monsters until we reach the goal
                    //subject to change
                    while (totalExp > currentExp)
                    {
                        //TODO: rand gen number 
                        //use number to generate a monster(CR)
                        //use CR to get the ExpAmount
                        //add monster to the list of NPCs
                        //add multipliers for 2+ more of the same monster



                        //if to much exp remove a monster
                        if (currentExp > overExp)
                        {
                            NPCs.RemoveAt(-1);
                        }
                     
                    }
                    break;
                case "medium":
                   
                    break;

            }//switch
        }//calcEncounter
        #endregion

    }//class
}
