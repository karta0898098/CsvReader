using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBase : MonoBehaviour
{
    //Singleton-------------------------------------
    private static DataBase m_Instance;

    public static DataBase Instance
    {
        get
        {
            if (m_Instance == null)
            {
                m_Instance = FindObjectOfType(typeof(DataBase)) as DataBase;

                if (m_Instance == null)
                {
                    GameObject go = new GameObject("DataBase");
                    m_Instance = go.AddComponent<DataBase>();
                }
            }
            return m_Instance;
        }
    }
    //Singleton-------------------------------------

    public Dictionary<string, object> equipmentData = new Dictionary<string, object>();
    public Dictionary<string, object> weaponData = new Dictionary<string, object>();
    public Dictionary<string, object> consumablesData = new Dictionary<string, object>();
    //Conect Unity Loop-------------------------
    private void Awake()
    {
        if (m_Instance == null)
        {
            m_Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(this);
        }
    }

    private void Start()
    {
        for (int i = 1; i < (equipmentData.Count + 1); i++)
        {
            Debug.Log
                (
                "Name:"+((Data.EquipmentData)equipmentData["test" + i]).name + 
                " Depiction:"+ ((Data.EquipmentData)equipmentData["test" + i]).depiction+
                " Defense:"+((Data.EquipmentData)equipmentData["test" + i]).defense
                );
        }

        for (int i = 1; i < (equipmentData.Count + 1); i++)
        {
            Debug.Log
                (
                "Name:" + ((Data.WeaponData)weaponData["test" + i]).name +
                " Depiction:" + ((Data.WeaponData)weaponData["test" + i]).depiction +
                " Atk:" + ((Data.WeaponData)weaponData["test" + i]).atk
                );
        }

        for (int i = 1; i < (equipmentData.Count + 1); i++)
        {
            Debug.Log
                (
                "Name:" + ((Data.ConsumablesData)consumablesData["test" + i]).name +
                " Depiction:" + ((Data.ConsumablesData)consumablesData["test" + i]).depiction +
                " EffectValue:" + ((Data.ConsumablesData)consumablesData["test" + i]).effectValue
                );
        }
    }
    //Conect Unity Loop-------------------------
}
