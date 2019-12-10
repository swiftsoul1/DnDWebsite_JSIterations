using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACarrion_JSpear_JWilson_JGuevara_GroupProject.Models
{
    public class Character
    {
        public int ID { get; set; }
        //public IdentityUser User { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public int Level { get; set; }
        // No skill points in 5E! :-p
        //public int SkillPoints { get; set; }
        public string Race { get; set; }
        public string Alignment { get; set; }
        public int XP { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Wisdom { get; set; }
        public int Intelligence { get; set; }
        public int Charisma { get; set; }
        public int StrMod { get; set; }
        public int DexMod { get; set; }
        public int ConMod { get; set; }
        public int WisMod { get; set; }
        public int IntMod { get; set; }
        public int ChaMod { get; set; }
        public int ProficiencyBonus { get; set; }
        public int ArmorClass { get; set; }
        public int Initiative { get; set; }
        public int Speed { get; set; }
        public int HitPoints { get; set; }
        public string Personality { get; set; }
        public string Ideals { get; set; }
        public string Bonds { get; set; }
        public string Flaws { get; set; }
        public string HitDice { get; set; }
        public int Acrobatics { get; set; }
        public int AnimalHandling { get; set; }
        public int Arcana { get; set; }
        public int Athletics { get; set; }
        public int Deception { get; set; }
        public int History { get; set; }
        public int Insight { get; set; }
        public int Intimidation { get; set; }
        public int Investigation { get; set; }
        public int Medicine { get; set; }
        public int Nature { get; set; }
        public int Perception { get; set; }
        public int Performance { get; set; }
        public int Persuasion { get; set; }
        public int Religion { get; set; }
        public int SleightofHand { get; set; }
        public int Stealth { get; set; }
        public int Survival { get; set; }

        //public Character (IdentityUser user)
        //{
        //    User = user;
        //}

        //public List<string> SkillsList { get; set; }

        //public Character (List<string> skillsList)
        //{
        //    SkillsList = skillsList;
        //    skillsList.add("Athletics", "Acrobatics", "Sleight of Hand", "Stealth", "Arcana", "History", "Investigation", "Nature", "Religion", "Animal Handling", "Insight", "Medicine", "Perception", "Survival", "Deception", "Intimidation", "Performance", "Persuasion");
        //}

    }
}
