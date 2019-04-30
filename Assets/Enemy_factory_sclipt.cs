using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_factory_sclipt : MonoBehaviour
{
    public float timeOut;
    public float timeElapsed;
    // Start is called before the first frame update
    void Start()
    {
        timeOut = 0.5f;
    }
    public GameObject Enemy_prefab;
    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed >= timeOut)
        {
            GameObject enemy;
            float position_y = Random.Range(5.0f, 7.5f);
            int a = Random.Range(0, 2);
            if (a==0)
            {
                enemy = Instantiate(Enemy_prefab, new Vector3(-17.0f, position_y, 0), Quaternion.identity);
                Enemy_sclipt enemy_Sclipt = enemy.GetComponent<Enemy_sclipt>();
                enemy_Sclipt.Create(Enemy_sclipt.RIGHT);
            }else
            {
                enemy = Instantiate(Enemy_prefab, new Vector3(17.0f, position_y, 0), Quaternion.identity);
                Enemy_sclipt enemy_Sclipt = enemy.GetComponent<Enemy_sclipt>();
                enemy_Sclipt.Create(Enemy_sclipt.LEFT);
            }
            timeElapsed = 0.0f;
        }
    }
}
