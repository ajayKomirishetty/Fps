using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   float timeAlive = 0f;

    // Update is called once per frame
    void Update()
    {
        timeAlive += Time.deltaTime;
        if (timeAlive > 3)
        {
            gameObject.SetActive(false);
            timeAlive = 0f;
        }
    }
}
