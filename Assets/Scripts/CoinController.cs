using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision) {
        //solo se desactiva
        //gameObject.SetActive(false);

        //GameObject scripter = GameObject.Find("Scripter");
        //scripter.GetComponent<ScoreManager>().RaiseScore(1);
        ScoreManager.scoreManager.RaiseScore(1);

        Destroy(transform.parent.gameObject);
    }
}
