using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NewBehaviourScript : MonoBehaviour
{
    public void loadsecen(string scena1)
    {
        SceneManager.LoadScene(scena1);
    }
}
