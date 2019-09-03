using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Para poder guardarlo en un archivo
[System.Serializable]
public class Highscore
{

    public int highscore;

    public Highscore(Player player)
    {
        highscore = Player.GetHighscore();
    }

    public int GetHighscore()
    {
        return highscore;
    }

}