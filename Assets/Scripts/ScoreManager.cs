using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    private int player1Score = 0 ;
    private int player2Score = 0 ;

    public TMP_Text player1ScoreText;
    public TMP_Text player2ScoreText;

    public void Player1Goal() {
        player1Score++ ;
        player1ScoreText.text = player1Score.ToString() ;
    }

    public void Player2Goal() {
        player2Score++ ;
        player2ScoreText.text = player2Score.ToString() ;
    }
}
