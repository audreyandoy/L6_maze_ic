using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Collectables
{

    //private Vector3 normalizeDirection;

    float speed = 1f;
    float delta = 1f;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {

        float y = transform.position.y + Mathf.PingPong(speed * Time.time, delta);
        Vector3 pos = new Vector3(transform.position.x, y, transform.position.z);
        transform.position = pos;

    }
}
