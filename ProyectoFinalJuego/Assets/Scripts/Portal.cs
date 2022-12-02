using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Portal : MonoBehaviour
{
    public int numeroEscena;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "player")
        {
            SceneManager.LoadScene(numeroEscena);
        }
    }
}
