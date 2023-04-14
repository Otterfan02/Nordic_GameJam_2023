using Coherence.Toolkit;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [Header("Movement")]
    private Rigidbody2D rb;
    public float speed;
    public float dragConstant;
    
    [Header("Heat")]
    private float maxHeat = 69420;
    private float currentHeat;
    public float decayRate;
    public GameObject heatBar;
    
    [Header("Connection")]
    private bool isConnected;
    private CoherenceMonoBridge bridge;

    [Header("Score")]
    public TMP_Text scoreText;
    private float score;

    [Header("Div")]
    private Vector2 StartPos;



    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        currentHeat = maxHeat;
        isConnected = false;
        StartPos = transform.position;
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

        if(currentHeat <= 0)
        {
            score = 0;
            transform.position = StartPos + new Vector2(Random.RandomRange(-20, 20), Random.RandomRange(-20, 20));
            currentHeat = maxHeat;
        }

        Debug.Log(currentHeat);

        if (!CheckConnected())
        {
            currentHeat = maxHeat;
            score = 0;
        }
        

        heatBar.gameObject.transform.localScale = new Vector3(currentHeat/maxHeat, heatBar.gameObject.transform.localScale.y, heatBar.gameObject.transform.localScale.z);

        rb.velocity = rb.velocity * dragConstant;

        scoreText.text = "Score: " + Mathf.Round(score);

        score += Time.deltaTime;


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
