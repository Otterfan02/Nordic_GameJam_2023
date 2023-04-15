using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonSpawnScript : MonoBehaviour
{
    public GameObject Skeleton;
    public float maxSkeletonSpawn;
    public float spawnDelay;
    private float currentDelay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(GameObject.FindGameObjectsWithTag("Enemy").Length);
        if (currentDelay > spawnDelay && GameObject.FindGameObjectsWithTag("Enemy").Length < maxSkeletonSpawn)
        {
            Instantiate(Skeleton, new Vector3((Random.RandomRange(-20, 20)), Random.RandomRange(-20, 20), 0), Quaternion.identity);
            currentDelay = 0;
        }
        currentDelay += Time.deltaTime;

    }
}
