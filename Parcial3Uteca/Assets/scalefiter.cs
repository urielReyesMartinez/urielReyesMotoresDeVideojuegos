using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scalefiter : MonoBehaviour
{
    private Camera maincamara;
    
    private void Start()
    {
        //inicializar cmara

        maincamara = GameObject.FindGameObjectWithTag("maincamra").GetComponent<Camera>();
        transform.position = new Vector3(maincamara.transform.position.x, maincamara.transform.position.y, 0);
        Vector3 Bottomlef = maincamara.ViewportToWorldPoint(Vector3.zero) * 100;
        Vector3 topriht = maincamara.ViewportToWorldPoint(new Vector3(maincamara.rect.width, maincamara.rect.height));
        Vector3 scrensire = topriht - Bottomlef;
        //escalar la pantalla en inicializando

        float screenratio = scrensire.x / scrensire.y;
        float desireradio = transform.localScale.x / transform.localScale.y;

        if (screenratio>desireradio)//agustar pantalla en anchos y radio Y y X
        {
            float heigt = scrensire.y;
            transform.localScale = new Vector3(heigt * desireradio, heigt);
        }
        else
        {
            float whidth = scrensire.x;
            transform.localScale = new Vector3(whidth, whidth / desireradio);
        }
    }



}
