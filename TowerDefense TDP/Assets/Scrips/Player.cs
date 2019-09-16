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

    public static int highscore;

    public GameObject Panel;
    

    // Start is called before the first frame update
    void Start()
    {
        money = inicialMoney;
        lives = inicialLives;
        rounds = inicialRounds;
        LoadHighscore();
    }
    
    public static void ReduceLives()
    {
        if (lives > 0)
        {
            lives--;
        }
        //Chequeamos desde el game manager si finaliza el juego o no.
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

    public static int GetHighscore()
    {
        return highscore;
    }

    public static void SetHighscore(int i)
    {
        highscore = i;

    }

    public void SaveHighscore()
    {
        Persistencia.SaveHighscore(this);
        
    }

    public void LoadHighscore()
    {
        Highscore puntaje = Persistencia.LoadHighscore();
        highscore = puntaje.GetHighscore();
    }

    public void EnableSavePanel()
    {
        Panel.SetActive(true);
    }

}
