using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{

    [SerializeField]
    private int speed;

    [SerializeField]
    private Transform camera;

    private Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveObject(GetInput());
        // PaddlePosition();
    }

    private Vector2 GetInput(){
        Vector3 movement = Vector3.zero;

        KeyInput(movement);

        return movement;
    }

    private void PaddlePosition(){
        float maxX = camera.localScale.x;
        float maxY = camera.localScale.y;

        if(this.transform.position.x > maxX){
            transform.position = new Vector3(maxX, transform.position.y, transform.position.z);
        }
        if(this.transform.position.y > maxY){
            transform.position = new Vector3(transform.position.x, maxY, transform.position.z);
        }
    }

    private void KeyInput(Vector3 movement){
        if(Input.GetKey(KeyCode.W)){
            movement = Vector3.up * speed;
        }
        if(Input.GetKey(KeyCode.S)){
            movement = Vector3.down * speed;
        }
        if(Input.GetKey(KeyCode.A)){
            movement = Vector3.left * speed;
        }
        if(Input.GetKey(KeyCode.D)){
            movement = Vector3.right * speed;
        }
    }

    private void MoveObject(Vector2 movement){
        transform.Translate(movement * Time.deltaTime);
    }
}
