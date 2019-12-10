using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACarrion_JSpear_JWilson_JGuevara_GroupProject.Models
{
    public class Monster
    {
        /// <summary>
        /// Programmer: Jonah Spear
        /// Email: jspear2@cnm.edu
        /// Monster.cs - model class to represent a DnD Monster
        /// subject to change or deletion
        /// </summary>

        #region props
        public string Name { get; set; }
        public double CR { get; set; }
        public int HP { get; set; }

        //www.dnd5eapi/api/monsters/? - contains a list of all monsters and there associcated stats(.JSON)
        //in a later iteration i plan to pull that info and load it into the monster
        //public string JsonApiLink
        #endregion
    }
}