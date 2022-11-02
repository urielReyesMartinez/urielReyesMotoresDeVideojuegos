using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MOVEMENT
{
    NULL,
    LEFT,
    RIGTH,
}
public class NewBehaviourScript : MonoBehaviour
{
    private Rigidbody2D RB;
    public float speed = 3f;
    public bool Movement = false;
    public MOVEMENT MoveState;
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Movement = true;
            MoveState = MOVEMENT.LEFT;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            MoveState = MOVEMENT.RIGTH;
            Movement = true;
        }
        else 
        {
            MoveState = MOVEMENT.NULL;
            Movement = false;
        }
    }
    public void FixedUpdate()
    {
        if (MoveState==MOVEMENT.LEFT)
        {
            RB.AddForce(= new Vector2(-speed, 0));
            //*RB.velocity = new Vector2(-speed, 0);
        }
        else if (MoveState==MOVEMENT.RIGTH)
        {
            RB.AddForce(= new Vector2(-speed, 0));
           // RB.velocity = new Vector2(speed, 0);

        }
        else if (MoveState==MOVEMENT.NULL)
        {
            //RB.AddForce(= new Vector2(-speed, 0));
            //RB.velocity = new Vector2(0, 0);

        }
    }
}
