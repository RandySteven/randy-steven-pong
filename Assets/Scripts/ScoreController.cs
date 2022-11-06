using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{

    public ScoreManager scoreManager;

    public Text leftScoreText;
    public Text rightScoreText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        leftScoreText.text = scoreManager.leftScore.ToString();
        rightScoreText.text = scoreManager.rightScore.ToString();
    }

    
}
