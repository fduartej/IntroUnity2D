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
            gameObject.GetComponent<Animator>().SetBool("mooving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.GetKey("right"))
        {
            //unity asume que cada pixel equivale un metro
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(1000f * Time.deltaTime, 0));
            gameObject.GetComponent<Animator>().SetBool("mooving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }

        if (!Input.GetKey("left") && !Input.GetKey("right")) {
            gameObject.GetComponent<Animator>().SetBool("mooving", false);
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
