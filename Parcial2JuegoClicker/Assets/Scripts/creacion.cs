using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creacion : MonoBehaviour
{
    public GameObject enemyPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector2 randomSpawnPosition = new Vector2(Random.Range(-2, 5), Random.Range(-2, 5));
            Instantiate(enemyPrefab, randomSpawnPosition, Quaternion.identity);
        }
    }
}
