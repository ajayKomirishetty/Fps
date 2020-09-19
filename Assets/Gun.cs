using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public GameObject bullet;
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            GameObject newbullet = Instantiate(bullet);
            //GameObject newbullet = ObjectPool.sharedInstance.getPooledObjects();
            newbullet.transform.position = transform.position + transform.up;
            newbullet.GetComponent<Rigidbody>().velocity = transform.up*10f;
            audio.Play();
            //newbullet.SetActive(true);
        }
        
    }
}
