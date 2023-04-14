using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonSpawnScript : MonoBehaviour
{
    public GameObject Skeleton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(Skeleton, new Vector3((Random.RandomRange(-20, 20)), Random.RandomRange(-20, 20), 0), Quaternion.identity);
        
    }
}
