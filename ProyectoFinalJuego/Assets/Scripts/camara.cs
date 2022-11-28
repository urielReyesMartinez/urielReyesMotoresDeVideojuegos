using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    public GameObject tarjet;
    private Vector3 tarjetpos;

    public float haciaAdelante;
    public float smothig;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tarjetpos = new Vector3(tarjet.transform.position.x, tarjet.transform.position.y);
        if (tarjet.transform.localScale.x==1)//derecha
        {
            tarjetpos = new Vector3(tarjetpos.x + haciaAdelante, tarjetpos.y, transform.position.z);
        }
        if (tarjet.transform.localScale.x == 1)//izquierda
        {
            tarjetpos = new Vector3(tarjetpos.x-haciaAdelante,tarjetpos.y,transform.position.z);
        }

        transform.position = Vector3.Lerp(transform.position,tarjetpos,smothig*Time.deltaTime);

    }
}
