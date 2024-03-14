using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerLives = 5;
    public Text livesText;
    public GameObject gameOverScreen;

    [ContextMenu("Decrease Lives")]
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
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
