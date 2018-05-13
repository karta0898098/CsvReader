using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataCenter : MonoBehaviour
{
    private void Awake()
    {
        CsvReader csvReader = new CsvReader();
        csvReader.Read("EquipmentData",DataBase.Instance.equipmentData,DataType.Equipment);
        csvReader.Read("WeaponData", DataBase.Instance.weaponData, DataType.Weapon);
        csvReader.Read("ConsumablesData", DataBase.Instance.consumablesData, DataType.Consumables);
    }

}

public interface ICsvReader
{
    void HandleData(string readData, Dictionary<string, object> data);
}

public enum DataType
{
    Equipment,
    Weapon,
    Consumables
}

public class CsvReader
{
    public void Read(string name,Dictionary<string,object> data ,DataType type)
    {
        TextAsset csvFile = Resources.Load(name, typeof(TextAsset)) as TextAsset;

        if (csvFile == null)
        {
            Debug.Log("Please Check Is file exist?");
            return;
        }

        ICsvReader csv = null;

        switch (type)
        {
            case DataType.Equipment:
                csv = new HandleData.EquipmentText();
                break;
            case DataType.Weapon:
                csv = new HandleData.WeaponText();
                break;
            case DataType.Consumables:
                csv = new HandleData.ConsumablesText();
                break;
        }

        if (csv != null)
        {
            csv.HandleData(csvFile.text,data);
        }
        Resources.UnloadAsset(csvFile);
    }
}
