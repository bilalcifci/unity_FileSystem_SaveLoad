using System.Collections;
using System.Collections.Generic;
using OpenCover.Framework.Model;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Player_V2 : MonoBehaviour
{
    public int Puan;
    public string Ad;

    public TextMeshProUGUI puan_text;
    public TextMeshProUGUI ad_text;

    private void Start()
    {
        Load();
    }
    public void Save()
    {
        SaveSystem_V2.SavePlayer(this);
        Load();
    }
    public void Load()
    {
        PlayerData data = SaveSystem_V2.LoadPlayer(this);

        puan_text.text = data.Puan.ToString();
        ad_text.text = data.Ad;

        Puan = data.Puan;
        Ad = data.Ad;
    }
}
