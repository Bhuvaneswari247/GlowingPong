using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int scoreToReach;


    private int Player1Score = 0;
    private int Player2Score = 0;

    public TMP_Text Player1ScoreText;
    public TMP_Text Player2ScoreText;

    public void Player1Goal()
    {
        Player1Score++;
        Player1ScoreText.text = Player1Score.ToString();
        CheckScore();
    }

    public void Player2Goal()
    {
        Player2Score++;
        Player2ScoreText.text = Player2Score.ToString();
        CheckScore();
    }
    private void CheckScore()
    {
        if(Player1Score == scoreToReach ||  Player2Score == scoreToReach)
        {
            SceneManager.LoadScene(2);
        }
    }

}
