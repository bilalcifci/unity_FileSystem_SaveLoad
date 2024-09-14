using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int Puan;
    public string Ad;

    public PlayerData(Player_V2 player, bool ilk_mi)
    {
        if (!ilk_mi)
        {
            Puan = player.Puan;
            Ad = player.Ad;

        }
        else
        {
            Puan = 0;
            Ad = "--";
        }

    }
}
