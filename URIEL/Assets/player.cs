using LanguageExt.UnitsOfMeasure;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Time = UnityEngine.Time;
using System;

public class player : MonoBehaviour
{
    public int vida = 50;
    public int atakP = 10;
    private int velocidad=4;
    public Transform;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void movimiento()
    {
        if (Input.GetKey(KeyCode.A))
        {
            player.Transform(velocidad * Time.deltaTime,0,0);
            Debug.Log("movimiento izquierdo");
        }
        if (Input.GetKey(KeyCode.D))
        {
            player.Transform(velocidad * Time.deltaTime,0,0);
            Debug.Log("movimiento derecho");
        }
    }
    public void atackP()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("golpe izquierdo");
        }
        if (Input.GetKey(KeyCode.E))
        {
            Debug.Log("golpe derecho");
        }
    }
    private void ontrigerenter2d(Collision2D collicion)
    {
        Debug.Log("movimiento");
        movimiento();
        randomAtack();
    }

}