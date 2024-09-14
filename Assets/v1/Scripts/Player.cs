using System.Collections;
using System.Collections.Generic;
using OpenCover.Framework.Model;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public InputField gelen_puan_deger;
    public InputField gelen_ad_deger;

    public TextMeshProUGUI puan_text;
    public TextMeshProUGUI ad_text;

    private void Start()
    {
        Load();
    }
    public void Save()
    {
        Verilerimiz.Puan = int.Parse(gelen_puan_deger.text);
        Verilerimiz.Ad = gelen_ad_deger.text;

        SaveSystem.SavePlayer();
    }
    public void Load()
    {
        SaveSystem.LoadPlayer();
        puan_text.text = Verilerimiz.Puan.ToString();
        ad_text.text = Verilerimiz.Ad;
    }
}
