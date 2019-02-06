using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    bool canJump;

    // Start is called before the first frame update
    void Start()
    {
        //gameObject.GetComponent<Transform>().position = new Vector3(5, 0, 0);
        /*gameObject.transform.position = new Vector3(gameObject.transform.position.x + 5, 
            gameObject.transform.position.y, gameObject.transform.position.z);*/
    }

    // Update is called once per frame
    void Update()
    {
        /*gameObject.transform.position = new Vector3(gameObject.transform.position.x + 0.1f * Time.deltaTime,
            gameObject.transform.position.y, gameObject.transform.position.z);*/
        /*gameObject.transform.position = new Vector3(gameObject.transform.position.x + 50f * Time.deltaTime,
            gameObject.transform.position.y, gameObject.transform.position.z);*/
        //gameObject.transform.Translate(50f * Time.deltaTime, 0, 0);

        if (Input.GetKey("left")) {
            gameObject.transform.Translate(-50f * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("right"))
        {
            gameObject.transform.Translate(50f * Time.deltaTime, 0, 0);
        }
        ManageJump();
    }

    void ManageJump() {
        if (gameObject.transform.position.y <= 0) { //esta en el suelo
            canJump = true;
        }

        if (Input.GetKey("up") && canJump && gameObject.transform.position.y < 10) //puede saltar
        {
            //mover hacia arriba
            gameObject.transform.Translate(0, 50f * Time.deltaTime, 0);
        }
        else {
            canJump = false;
            if (gameObject.transform.position.y > 0) { //Player en el aire
                gameObject.transform.Translate(0, -50f * Time.deltaTime, 0);
            }
        }
    }
}
