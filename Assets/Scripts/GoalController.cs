using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public Collider2D ballCollider; 
    public ScoreManager scoreManager;

    public bool isRight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other == ballCollider){
            if(isRight){
                scoreManager.AddLeftScore(1);
            }else{
                scoreManager.AddRightScore(1);
            }
        }
    }
}
