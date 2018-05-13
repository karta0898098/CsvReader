using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class WeaponData
    {
        public string name;
        public string depiction;
        public float atk;

        public WeaponData(string name, string depiction, float atk)
        {
            this.name = name;
            this.depiction = depiction;
            this.atk = atk;
        }
    }
}
