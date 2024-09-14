using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem_V2
{
    /// <summary>
    /// 
    /// </summary>
    public static void SavePlayer(Player_V2 player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream("player_v2.bin", FileMode.Create);

        PlayerData data = new PlayerData(player, false);

        formatter.Serialize(stream, data);

        stream.Close();
    }
    /// <summary>
    /// 
    /// </summary>
    public static PlayerData LoadPlayer(Player_V2 player)
    {
        string dosya_ad = "player_v2.bin";

        if (!File.Exists(dosya_ad))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream("player_v2.bin", FileMode.Create);

            PlayerData data = new PlayerData(player, true);

            formatter.Serialize(stream, data);

            stream.Close();
        }

        if (File.Exists(dosya_ad))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(dosya_ad, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData; 

            stream.Close();
            return data;
        }
        else
        {
            Debug.LogError("Dosya bulunamadi !");
            return null;
        }

    }

}
