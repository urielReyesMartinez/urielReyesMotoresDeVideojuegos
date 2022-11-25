using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creacion : MonoBehaviour
{
    public GameObject enemyPrefab;
    private int count = 0;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector2 randomSpawnPosition = new Vector2(Random.Range(-2, 5), Random.Range(-2, 5));
            Instantiate(enemyPrefab, randomSpawnPosition, Quaternion.identity);
            Destroy(enemyPrefab, 2f);
        }
        
        
    }
    //private void OnMouseDown()
    //{
    // Destroy(gameObject);
    // Instantiate(gameObject.transform.position,Vector2);
    // }
    public GameObject prefab;
    private int cout = 0;

    //curso unity destruyendo prefabs
}
