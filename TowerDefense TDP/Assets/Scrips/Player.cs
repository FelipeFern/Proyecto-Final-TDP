using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public static int money;
    public int inicialMoney = 300;

    public static int lives;
    public int inicialLives = 10;

    public static int rounds;
    public int inicialRounds = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        money = inicialMoney;
        lives = inicialLives;
        rounds = inicialRounds;
    }

    public static void ReduceLives()
    {
        if (lives > 0)
        {
            lives--;
        }
        else
        {

        }
    }

    public static void IncreaseMoney(int mon)
    {
        money += mon;
    } 

    public static void SetRounds(int number)
    {
        rounds = number;
    }

    public static int GetRounds()
    {
        return rounds;
    }

}
