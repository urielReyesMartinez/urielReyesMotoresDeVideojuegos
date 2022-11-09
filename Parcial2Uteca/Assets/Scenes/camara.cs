using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    public Transform Target;
    public float speed = 2f;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPOs = new Vector3(Target.position.x, Target.position.y, -10f) + offset;
        transform.position = Vector3.Slerp(Target.position, newPOs, speed * Time.deltaTime);
    }
}
