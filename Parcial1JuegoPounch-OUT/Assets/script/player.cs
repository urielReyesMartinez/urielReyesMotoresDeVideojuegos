using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class player : MonoBehaviour
{
    public int vida=50;
    public int atackP=10;
    public int velocid = 4f;
    public int daño = 2;
    public Transform;
        private GameManager GameManager;
    public Text textoVida;
    Vector2 pocicionInicial;

    // Start is called before the first frame update
    void Start()
    {
        GameManager = FindObjectOfType<GameManager>();
        textoVida.text = "vida:" + GameManager.vida;
        pocicionInicial = transform.position;
        public ra
    }

    // Update is called once per frame
    void fixedUpdate()
    {
        if (transform.position.y < daño)quitarvida;
    }
    void quitarvida()
    {
        GameManager.vida--;
        textoVida.text = "vida:" + GameManager.vida;
        transform.position = pocicionInicial;
        Rigidbody2D.velocid:= Vector2.zero;
    }
    public void movimiento()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Transform(velocid * Time.deltaTime, 0, 0);
            Debug.Log("movimiento izquierdo");
        }
        if (Input.GetKey(KeyCode.D))
        {
            Transform(velocid * Time.deltaTime, 0, 0);
            Debug.Log("movimiento derecho");
        }
    }
    public void atackP()
    {
        if(Input.GetKey(KeyCode.W))
        {
            Debug.Log("golpe izquierdo");
        }
        if(Input.GetKey(KeyCode.E))
        {
            Debug.Log("golpe derecho");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("movimiento");
        movimiento();
    }
}

