using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderController : MonoBehaviour
{
    public GameObject boulder;
    public GameObject spawnedBoulder;

    // Update is called once per frame
    void Update()
    {   
        //controls spawner movement from left to right
        if (Input.GetKey("a") && transform.position.x<8)
        {
            transform.Translate(0.05f, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x < 8)
        {
            transform.Translate(0.05f, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x>-7)
        {
            transform.Translate(-0.05f, 0f, 0f);
        }

        if (Input.GetKey("d") && transform.position.x > -7)
        {
            transform.Translate(-0.05f, 0f, 0f);
        }

        //when spacebar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //destroy spawned boulder then create new in spawner location
            Destroy(spawnedBoulder);
            spawnedBoulder = Instantiate(boulder);
            spawnedBoulder.transform.position = transform.position;
        }


    }
}
