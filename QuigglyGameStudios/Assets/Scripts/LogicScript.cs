using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public GameObject Player;
    public int playerLives;
    public Text livesText;
    public GameObject gameOverScreen;


    void Update()
    {

        if (Player != null)
        {
            playerLives = Player.GetComponent<PlayerHealth>().health;
            if (playerLives == 0 || playerLives < 0)
            {
                playerLives = 0;
                livesText.text = playerLives.ToString();
                gameOver();
            }
            livesText.text = playerLives.ToString();
        }
        else
        {
            playerLives = 0;
            livesText.text = playerLives.ToString();
        }
    }


    /*[ContextMenu("Decrease Lives")]
    public void plusMinusLives()
    {
        playerLives = playerLives - 1;
        if (playerLives == 0 || playerLives < 0)
        {
            playerLives = 0;
            livesText.text = playerLives.ToString();
            gameOver();
        }
        livesText.text = playerLives.ToString();
    }*/

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
