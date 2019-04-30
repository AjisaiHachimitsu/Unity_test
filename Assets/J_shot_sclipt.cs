using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class J_shot_sclipt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //transform.position = GameObject.Find("Jiki").transform.position;
    }
    const float SPEED = 0.4f;
    // Update is called once per frame
     void Update()
    {
        transform.Translate(0, SPEED, 0);
        if (transform.position.y>10)
        {
            Destroy(gameObject);
        }
    }
}
