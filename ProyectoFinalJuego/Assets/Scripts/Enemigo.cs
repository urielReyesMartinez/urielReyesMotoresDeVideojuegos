using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public float rangoalerta;
    public LayerMask capaJugador;
    private bool estarAlerta;
    public Transform jugador;
    public float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        estarAlerta = Physics.CheckSphere(transform.position, rangoalerta, capaJugador);

        if (estarAlerta == true)
        {
            Vector3 posijugador = new Vector3(jugador.position.x, jugador.position.y,jugador.position.z);
            transform.LookAt(jugador);
            transform.LookAt(posijugador);
            transform.position = Vector3.MoveTowards(transform.position, posijugador, velocidad * Time.deltaTime);
           
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, rangoalerta);
    }

}
