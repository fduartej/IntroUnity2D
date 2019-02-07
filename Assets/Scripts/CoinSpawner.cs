using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    float timer;
    public GameObject coinPrefab;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 2f) { //timer igual a 2s
            timer = 0;
            float x = Random.Range(-9f, 9f);
            Vector3 position = new Vector3(x, 0, 0);
            Instantiate(coinPrefab, position,new Quaternion());
        }
    }
}
