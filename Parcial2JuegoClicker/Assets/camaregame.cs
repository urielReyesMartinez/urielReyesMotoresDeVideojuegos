using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camaregame : MonoBehaviour
{
    public Camera office;
    public Camera cam1;
    public Camera cam2;
    // Start is called before the first frame update
    void Start()
    {
        office.gameObject.SetActive(true);
        cam1.gameObject.SetActive(false);
        cam2.gameObject.SetActive(false);

    }


    // Update is called once per frame
    void Update()
    {
        
    }
    public void Cam1()
    {
        office.gameObject.SetActive(false);
        cam1.gameObject.SetActive(true);
        cam2.gameObject.SetActive(false);
    }
    public void Cam2()
    {
        office.gameObject.SetActive(false);
        cam1.gameObject.SetActive(false);
        cam2.gameObject.SetActive(true);
    }
}
