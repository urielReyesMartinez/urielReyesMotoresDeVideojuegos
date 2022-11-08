using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Escena1: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void camara1()
    {
        SceneManager.LoadScene("Escena1");
    }
    public void camara2()
    {
        SceneManager.LoadScene("Escena2");
    }
    public void Menustart()
    {
        SceneManager.LoadScene("Menustart");
    }
}
