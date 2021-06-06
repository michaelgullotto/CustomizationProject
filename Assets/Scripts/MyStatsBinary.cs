using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class MyStatsBinary
{
    public static void SavePlayerData(MystatsData mystatsData)
    {
        //converting our game classes into something we can write to a file
        MystatsData data = new MystatsData(mystatsData);


        //create a new binary formatter
        BinaryFormatter formatter = new BinaryFormatter();
        //location we are saving the file
        string path = Application.dataPath + "/MyStatsSave.this";
        //create a file at file path
        FileStream stream = new FileStream(path, FileMode.Create);

        //convert a class into a string that can be written to the file
        formatter.Serialize(stream, data);

        stream.Close();
    }

    public static MystatsData loadMyStatsData(MystatsData mystatsData)
    {
        //location to read from (save location)
        string path = Application.dataPath + "/MystatsSave.this";

        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            //this time we are deserializing the data
            MystatsData data = (MystatsData)formatter.Deserialize(stream);
            //PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();

            //load the data back into unity
            data.LoadMyStatsData(mystatsData);
            return data;
        }
        else
        {
            return null;
        }
    }
}