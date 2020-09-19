using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyObject : MonoBehaviour
{
    public static EnemyObject sharedInstance;
    public List<GameObject> pooledObjects;
    public GameObject enemy;
    public int amountToPool;


    private void awake()
    {
        sharedInstance = this;
    }



    void Start()
    {
        pooledObjects = new List<GameObject>();
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject obj = (GameObject)Instantiate(enemy);
            obj.SetActive(true);
            pooledObjects.Add(obj);
        }
    }

    public GameObject getPooledObjects()
    {
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
                return pooledObjects[i];
        }
        return null;
    }

}
