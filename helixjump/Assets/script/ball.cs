using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpForce=5f;
    public GameObject splashImg;
    private gameManager gm;
    private ring ring;
    void Start()
    {
        gm = GameObject.FindObjectOfType<gameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        rb.AddForce(Vector3.up*jumpForce, ForceMode.Impulse);
        GameObject splash = Instantiate(splashImg, transform.position - new Vector3(0, 0.22f, 0f), transform.rotation); 
        splash.transform.SetParent(other.gameObject.transform);
        Destroy(splash, 1);
        string materialName = other.gameObject.GetComponent<MeshRenderer>().material.name;
        if (materialName== "unsafecolor (Instance)")
        {
            gm.restartGame();
        }
    }
}
