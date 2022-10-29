using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField]
    private Vector2 speed;

    [SerializeField]
    private Transform paddleLeft, paddleRight;   

    private Rigidbody2D rig;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        gameObject.AddComponent<CircleCollider2D>();
    }

    void FixedUpdate()
    {
        transform.Translate(speed * Time.deltaTime);        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        float posY = 0f; 
        if(other.gameObject.tag == "PaddleLeft"){
            posY = (speed.y - paddleLeft.position.y) / paddleLeft.transform.lossyScale.y;
            speed.x = 10;
            speed.y = posY;
            Debug.Log("X : " + speed.x +" | Y :" + speed.y);
            gameObject.transform.Translate(speed * Time.deltaTime);
        }
        if(other.gameObject.tag == "PaddleRight"){
            posY = (speed.y - paddleRight.position.y) / paddleRight.transform.lossyScale.y;
            speed.x = -10;
            speed.y =posY;
            Debug.Log("X : " + speed.x +" | Y :" + speed.y);
            gameObject.transform.Translate(speed * Time.deltaTime);
            // dir = new Vector2(-1, posY).normalized;
            // rig.velocity = speed * dir * Time.deltaTime;
        }
        if(other.gameObject.tag == "WallUp"){
            speed.y = -5;
        }
        if(other.gameObject.tag == "WallDown"){
            speed.y = 5;
        }
    }
}
