using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SavePlayer()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream("player.bin", FileMode.Create);

        formatter.Serialize(stream, Verilerimiz.Puan);
        formatter.Serialize(stream, Verilerimiz.Ad);

        stream.Close();
    }
    public static void LoadPlayer()
    {
        string dosya_ad = "player.bin";

        if (File.Exists(dosya_ad))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(dosya_ad, FileMode.Open);

            Verilerimiz.Puan = (int)formatter.Deserialize(stream);
            Verilerimiz.Ad = (string)formatter.Deserialize(stream);

            stream.Close();

        }
        else
        {
            Debug.LogError("Dosya bulunamadi !");
        }

    }

}
