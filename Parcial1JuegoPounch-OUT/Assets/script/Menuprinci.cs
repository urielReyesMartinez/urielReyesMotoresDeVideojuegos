using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menuprinci : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void escenajuego()
    {
        SceneManager.LoadScene("Ponch-simi");
    }
    public void salir()
    {
        Application.Quit();
    }
}
