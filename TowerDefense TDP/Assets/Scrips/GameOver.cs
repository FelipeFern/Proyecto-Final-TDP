using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Text roundsText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Al aparecer el menu de game over calcula los rounds que sobrevivio.
    private void OnEnable()
    {
        roundsText.text =  Player.GetRounds().ToString();
    }

    //Metodo para reiniciar la partida en el menu de game over.
    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }


    //Metodo para ir al menu en el menu de game over.
    public void Menu()
    {
        Debug.Log("Voy al menu");
    }
}
