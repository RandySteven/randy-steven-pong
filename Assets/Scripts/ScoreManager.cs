using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int rightScore;
    public int leftScore;

    public int maxScore;
    public BallController ballController;

    public Text playerWinText;

    // Start is called before the first frame update
    void Start()
    {
        playerWinText.text = null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddLeftScore(int increment){        
        ballController.ResetBall();

        leftScore += increment;
        
        if(leftScore == maxScore){
            GameOver();
            playerWinText.text = "PLAYER 1 WIN";
        }
    }

    public void AddRightScore(int increment){
        ballController.ResetBall();
        
        rightScore += increment;

        if(rightScore == maxScore){
            GameOver();
            playerWinText.text = "PLAYER 2 WIN";
        }
    }

    public void GameOver(){
        Time.timeScale = 0f;
    }
}
