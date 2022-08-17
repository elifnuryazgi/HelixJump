using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ring : MonoBehaviour
{

    public Transform ball;
    private gameManager gm;

    void Start()
    {
        gm = GameObject.FindObjectOfType<gameManager>();
    }


    void Update()
    {
        if (ball.position.y <= transform.position.y-5f )
        {   
            Destroy(gameObject);
            gm.gameScore(25);
        }
    }
}
