using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class EquipmentData
    {
        public string name;
        public string depiction;
        public float defense;

        public EquipmentData(string name, string depiction, float defense)
        {
            this.name = name;
            this.depiction = depiction;
            this.defense = defense;
        }
    }
}
