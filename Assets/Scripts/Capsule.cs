using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Collectables
{
    // Start is called before the first frame update
    void Start()
    {
        name = "hi";
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, Time.deltaTime * 25f);

    }
}
