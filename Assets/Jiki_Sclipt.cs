using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jiki_Sclipt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector3(0,-5.0f, 0);
    }

    const float SPEED = 0.3f;
    const float SCREEN_SIZE_X = 16.0f;
    // Update is called once per frame
    public GameObject Jiki_shot_prefab;
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)&&transform.position.x>-SCREEN_SIZE_X)
        {
            transform.Translate(-SPEED, 0, 0);
        }
        if(Input.GetKey(KeyCode.RightArrow)&&transform.position.x<SCREEN_SIZE_X)
        {
            transform.Translate(SPEED, 0, 0);
        }
        if(Input.GetKeyDown(KeyCode.Z))
        {
            Instantiate(Jiki_shot_prefab, transform.position, Quaternion.identity);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Enemy_Shot")
        {
            Debug.Log("GAME OVER!!");
            Destroy(gameObject);
        }
    }
}
