
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool gameEnded;

    public GameObject gameOverGUI;


    // Start is called before the first frame update
    void Start()
    {
        gameEnded = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameEnded == true)
            return;

        if(Player.lives <= 0)
        {
            EndGame();
        }

        if (Input.GetKeyDown("e"))
        {
            EndGame();
        }
    }

    void EndGame()
    {
        gameEnded = true;

        gameOverGUI.SetActive(true);
    }
}
