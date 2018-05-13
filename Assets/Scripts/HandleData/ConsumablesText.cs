using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HandleData
{
    public class ConsumablesText:ICsvReader
    {
        private char[] lineSeperater = { '\n', '\r' };
        private char fieldSeperator = ',';

        public void HandleData(string readData, Dictionary<string, object> data)
        {
            string[] records = readData.Split(lineSeperater);
            for (int i = 1; i < records.Length; i++)
            {
                if (records[i] != "")
                {
                    string[] fields = records[i].Split(fieldSeperator);
                    object wantAddData = new Data.ConsumablesData(fields[1], fields[2], float.Parse(fields[3]));
                    data.Add(fields[0], wantAddData);
                }
            }
        }
    }
}
