using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
   public int score;
   public Text scoreText;

    public void gameScore(int scoreS)
    {
        score += scoreS;
        scoreText.text = "SCORE:" + score.ToString();
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
