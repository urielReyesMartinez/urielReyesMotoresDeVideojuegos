using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaens : MonoBehaviour
{
    public GameObject enem1;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector2 randomSpawnPosition = new Vector2(Random.Range(-2, 5), Random.Range(-2, 5));
            Instantiate(enem1, randomSpawnPosition, Quaternion.identity);
        }
    }
}
