using Coherence.Toolkit;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    public float dragConstant;
    private float maxHeat = 69420;
    private float currentHeat;
    public float decayRate;
    public GameObject heatBar;
    private bool isConnected;
    private CoherenceMonoBridge bridge;



    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        currentHeat = maxHeat;
        isConnected = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Time.deltaTime * speed * Vector2.up);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Time.deltaTime * -speed * Vector2.up);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Time.deltaTime * speed * Vector2.left);

        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Time.deltaTime * speed * -Vector2.left);

        }

        
        if(currentHeat > 0 && CheckConnected())
        {
            currentHeat -= decayRate * Time.deltaTime;
        }
        Debug.Log(currentHeat);

        if (!CheckConnected())
        {
            currentHeat = maxHeat;
        }
        

        heatBar.gameObject.transform.localScale = new Vector3(currentHeat/maxHeat, heatBar.gameObject.transform.localScale.y, heatBar.gameObject.transform.localScale.z);

        rb.velocity = rb.velocity * dragConstant;


    bool CheckConnected()
    {
        if (!MonoBridgeStore.TryGetBridge(gameObject.scene, out bridge))
        {
            return false;
        }
        return bridge.isConnected;
    }
}



}
