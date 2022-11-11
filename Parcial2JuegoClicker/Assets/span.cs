using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class span : MonoBehaviour
{
    public GameObject prefab;
    private int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject cube = Instantiate(prefab, transform.position,transform.rotation) as GameObject;
            cube.name = "food" + count++;
            Destroy(cube, 3f);
        }
    }
}
