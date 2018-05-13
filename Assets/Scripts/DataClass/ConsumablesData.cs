using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class ConsumablesData
    {
        public string name;
        public string depiction;
        public float effectValue;

        public ConsumablesData(string name, string depiction, float effectValue)
        {
            this.name = name;
            this.depiction = depiction;
            this.effectValue = effectValue;
        }
    }
}
