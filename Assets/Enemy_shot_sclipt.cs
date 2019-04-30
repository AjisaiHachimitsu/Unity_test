using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Assets;
//using System;
public class Enemy_shot_sclipt : MonoBehaviour
{
    Vector3 vec=new Vector3(0,-0.1f,0);
    public void Create(Vector3 shot_vec)
    {
        vec = shot_vec;
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(vec);
        if (transform.position.y < -10 || transform.position.x > 18 || transform.position.x < -18)
        {
            Destroy(gameObject);
        }
    }
}
