using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemy : MonoBehaviour
{
    public int vida = 50;
    public int atackE = 10;
    public int velocid = 4f;
    public int daño = 2;
    public Transform;
        private GameManager GameManager;
    public Text textoVida;
    Vector2 pocicionInicial;
    private RandomAtack=2;

    // Start is called before the first frame update
    void Start()
    {
        GameManager = FindObjectOfType<GameManager>();
        textoVida.text = "vida:" + GameManager.vida;
        pocicionInicial = transform.position;
        Random Atack = Random.Range(0,4);
        switch (RandomAtack)
        {case 0;
                transform(velocid * Time.deltaTime, 0, 0);
                break;
         case 1;
                transform(velocid * Time.deltaTime, 0, 0);
                break;
            case 2;(atackE);
                transform(velocid * Time.deltaTime, 0, 0);
                Debug.Log("golpe izquierdo");
                break;
            case 3; (atackE);
                transform(velocid * Time.deltaTime, 0, 0);
                Debug.Log("golpe derecho");
                break;
            default:
                break;
        }
    }
    void fixedUpdate()
    {
        if (transform.position.y < daño) quitarvida;
    }
    void quitarvida()
    {
        GameManager.vida--;
        textoVida.text = "vida:" + GameManager.vida;
        transform.position = pocicionInicial;
        Rigidbody2D.velocid:= Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("movimiento");
        RandomAtack();
        atackE();
    }
}
