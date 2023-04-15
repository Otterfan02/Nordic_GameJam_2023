using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    public GameObject chilli;
    public GameObject doritio;
    public float maxFoodSpawn;
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
        if (currentDelay > spawnDelay && GameObject.FindGameObjectsWithTag("Food").Length < maxFoodSpawn)
        {
            if(Random.Range(0,1) > 0.5f)
            {
                Instantiate(chilli, new Vector3((Random.Range(-40, 40)), Random.Range(-23, 23), 0), Quaternion.identity);
                currentDelay = 0;
            }
            else
            {
                Instantiate(doritio, new Vector3((Random.Range(-40, 40)), Random.Range(-23, 23), 0), Quaternion.identity);
                currentDelay = 0;
            }


        }
        currentDelay += Time.deltaTime;

    }
}
