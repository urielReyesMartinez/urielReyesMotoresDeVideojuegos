using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NewBehaviourScript : MonoBehaviour
{
    public void loadsecen(string scena1)//CAMBIO DE ESCENA DONDE PUEDAS CAMBIAR DE DOS ESCENAS EN EL JUEGO
    {
        SceneManager.LoadScene(scena1);
    }
}
