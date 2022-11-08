using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void reanudar()
    {
        SceneManager.LoadScene("escena1");
    }
    public void MenuPrinci()
    {
        SceneManager.LoadScene("MenuPrinci");
    }
    public void salir()
    {
        Application.Quit();
    }
}
