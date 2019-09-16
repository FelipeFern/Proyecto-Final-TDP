using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Text roundsText;
    public Text Highscore;

    public Button buttonHighscore;

    
    //Al aparecer el menu de game over calcula los rounds que sobrevivio.
    private void OnEnable()
    {
        int rounds = Player.GetRounds();
        roundsText.text =  rounds.ToString() + " Rounds";
        if(rounds > Player.GetHighscore())
        {
            Player.SetHighscore(rounds);
            buttonHighscore.gameObject.SetActive(true);
        }
        
        Highscore.text = "Highscore: " + Player.GetHighscore().ToString() + " Rounds";

    }
    
    
    //Reiniciar la partida en el menu de game over.
    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        buttonHighscore.gameObject.SetActive(false);

    }

}
