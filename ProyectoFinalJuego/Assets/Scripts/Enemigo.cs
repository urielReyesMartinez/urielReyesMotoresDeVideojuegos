using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public float rangoalerta;
    public LayerMask capaJugador;
    public bool estaralerta;
    public Transform jugador;
    public float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        estaralerta= Physics.CheckSphere(transform.position, rangoalerta, capaJugador);

        if (estaralerta==true)
        {
            Vector3 posijugador = new Vector3(jugador.position.x, jugador.position.y, 0);
            //transform.LookAt(jugador);
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
public class muerte : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)//matar al jugador con este script al jugador
    {
        if (other.CompareTag("enemy"))
        {
            Debug.Log("muerte jugador");

        }
    }
}