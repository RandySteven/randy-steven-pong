using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField]
    private int speed;

    private Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = GetInput();

        MoveObject(movement);
    }

    private Vector2 GetInput(){
        Vector2 movement = Vector2.zero;

        if(Input.GetKey(KeyCode.W)){
            movement = Vector2.up * speed;
        }else if(Input.GetKey(KeyCode.S)){
            movement = Vector2.down * speed;
        }

        return movement;
    }

    private void MoveObject(Vector2 movement){
        rig.velocity = movement;
        // transform.Translate(movement * Time.deltaTime);
    }
}
