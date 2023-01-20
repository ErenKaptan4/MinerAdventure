using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class SaveLoadManager
{

    public void SaveData()
    {
        SerializedData mySerializedData = new SerializedData();
        mySerializedData.ser_score = GameData.Score;

        BinaryFormatter bf = new BinaryFormatter();

        FileStream myfile = File.Create(Application.persistentDataPath + "/MinerAdvantureData.save");
        bf.Serialize(myfile, mySerializedData);  //Serialize and save
        myfile.Close();
        Debug.Log("FILE SAVED");

    }

    public void LoadData()
    {
        SerializedData mySerializedData = new SerializedData();

        if (File.Exists(Application.persistentDataPath + "/MinerAdvantureData.save"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream myfile = File.Open(Application.persistentDataPath + "/MinerAdvantureData.save", FileMode.Open);
            mySerializedData = (SerializedData)bf.Deserialize(myfile);
            myfile.Close();

            GameData.Score = mySerializedData.ser_score;

        }
    }

    public void DeleteFile()
    {
        if (File.Exists(Application.persistentDataPath + "/MinerAdvantureData.save"))
        {
            File.Delete(Application.persistentDataPath + "/MinerAdvantureData.save");
        }


        if (File.Exists(Application.persistentDataPath + "/MinerAdvantureData.save"))
        {
            File.Delete(Application.persistentDataPath + "/MinerAdvantureData.save");
        }

    }
}
