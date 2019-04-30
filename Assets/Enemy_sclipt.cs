using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets;
using System;

public class Enemy_sclipt : MonoBehaviour
{
    const float SPEED = 0.2f;
    const float SCREEN_SIZE_X = 18.0f;
    public const int LEFT = -1;
    public const int RIGHT = 1;
    int dir=1;
    public void Create(int direction)
    {
        dir = direction;
    }
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    public GameObject Enemy_shot_prefab;
    void Update()
    {
        transform.Translate(new Vector3(SPEED*dir,0,0));
        if(UnityEngine.Random.Range(0,100)==0)
        {
            Shot1();
            //shot_flag = true;
        }
        if (transform.position.x>SCREEN_SIZE_X||transform.position.x<-SCREEN_SIZE_X)
        {
            Destroy(gameObject);
        }
        
    }
    public void Shot1()
    {
        const int WAY_NUM = 3;
        const int SHOT_NUM = 5;
        const float SPEED_DAMPING_RATE = 0.8f;
        const float ANGLE_INTERVAL = 20.0f;
        float speed = 0.3f;
        ComplexNumbers_f down = new ComplexNumbers_f(0.0f, -1.0f);
        ComplexNumbers_f shot_vec = new ComplexNumbers_f();
        float angle;
        if (WAY_NUM % 2 == 1)
        {
            for (int i=0;i<SHOT_NUM;i++)
            {
                for (int j = -(WAY_NUM - 1) / 2; j <= (WAY_NUM - 1) / 2; j++)
                {
                    GameObject shot;
                    shot = Instantiate(Enemy_shot_prefab, transform.position, Quaternion.identity);
                    Enemy_shot_sclipt s = shot.GetComponent<Enemy_shot_sclipt>();
                    angle = j * ANGLE_INTERVAL * (float)(Math.PI) / 180.0f;
                    shot_vec = ComplexNumbers_f.Product(new ComplexNumbers_f(speed), ComplexNumbers_f
                        .Product(down, new ComplexNumbers_f((float)Math.Cos(angle), (float)Math.Sin(angle))));
                    s.Create(new Vector3(shot_vec.real, shot_vec.image, 0));
                }
                speed *= SPEED_DAMPING_RATE;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Jiki_Shot")
        {
            Destroy(gameObject);
        }
    }
}
