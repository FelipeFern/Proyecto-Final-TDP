using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject GUI;
    
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {
           Pause();
        }
        
    }
    //Metodo para pausar o reunadar la partida desde el PauseMenu
    public void Pause()
    {
        GUI.SetActive(!GUI.activeSelf);

        if (GUI.activeSelf)
        {
            Time.timeScale = 0f;
            
        }
        else
        {
            Time.timeScale = 1f;
        }

    }
    

    //Metodo para reiniciar la partida desde el PauseMenu.
    public void Retry()
    {
        Pause();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    //Metodo para ir al menu desde el PauseMenu.
    public void Menu()
    {
        Debug.Log("Voy al menu");
    }
}
