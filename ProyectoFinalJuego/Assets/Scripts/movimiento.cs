using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    public float velocidad = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) //movimiento horizontal
        {
            transform.position += Vector3.left * velocidad * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * velocidad * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))//movimiento vertical
        {
            transform.position += Vector3.up * velocidad * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * velocidad * Time.deltaTime;
        }
    }
}
