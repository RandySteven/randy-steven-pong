using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField]
    private Vector2 speed;

    private Rigidbody2D rig;
    // Start is called before the first frame update
    void Start()
    {
        speed = Vector3.zero;

        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
        float rand = Random.Range(0, 2);

        if(rand < 1){
            rig.AddForce(new Vector2(20, -15));
        } else {
            rig.AddForce(new Vector2(-20, -15));
        }
    }

    void LateUpdate()
    {
        transform.Translate(speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        
    }
}
