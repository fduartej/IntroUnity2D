using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    bool canJump;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left")) {
            //unity asume que cada pixel equivale un metro
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-1000f * Time.deltaTime, 0));
        }
        if (Input.GetKey("right"))
        {
            //unity asume que cada pixel equivale un metro
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(1000f * Time.deltaTime, 0));
        }

        if (Input.GetKeyDown("up") && canJump)
        {
            canJump = false;
            //unity asume que cada pixel equivale un metro
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0 , 300f));
        }

    }

    private void OnCollisionEnter2D(Collision2D collision) {

        if (collision.transform.tag == "ground") {
            canJump = true;
        }

    }
}
