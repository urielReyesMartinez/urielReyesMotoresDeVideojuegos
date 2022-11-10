using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MOVEMEN
{
    NULL,
    LEFT,
    RIGTH,
    JUMP,
}
public class movimiento : MonoBehaviour
{
    private Rigidbody2D RB;
    public float speed = 2f;
    public bool Movement = false;
    public MOVEMEN MoveState;
    // Start is called before the first frame update
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
            MoveState = MOVEMEN.LEFT;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            MoveState = MOVEMEN.RIGTH;
            Movement = true;
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            Movement = true;
            MoveState = MOVEMEN.JUMP;
        }
        else
        {
            MoveState = MOVEMEN.NULL;
            Movement = false;
        }
    }
    public void FixedUpdate()
    {
        if (MoveState == MOVEMEN.LEFT)
        {
            RB.AddForce(new Vector2(-speed, 0), ForceMode2D.Impulse);
            //*RB.velocity = new Vector2(-speed, 0);
        }
        else if (MoveState == MOVEMEN.RIGTH)
        {
            RB.AddForce(new Vector2(-speed, 0), ForceMode2D.Impulse);
            // RB.velocity = new Vector2(speed, 0);

        }
        else if (MoveState == MOVEMEN.JUMP)
        {
            // RB.AddForce(Vector2.up * JumpHeight);
        }
        else if (MoveState == MOVEMEN.NULL)
        {
            //RB.AddForce(= new Vector2(-speed, 0));
            //RB.velocity = new Vector2(0, 0);

        }
    }
}

