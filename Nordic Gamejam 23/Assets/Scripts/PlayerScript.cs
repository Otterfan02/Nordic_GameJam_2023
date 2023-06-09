using Coherence.Toolkit;
using Coherence.UI;
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
    public float rotationSpeed;
    public float currentRotation;
    
    [Header("Heat")]
    private float maxHeat = 69420;
    public float currentHeat;
    public float decayRate;
    public GameObject heatBar;
    
    [Header("Connection")]
    private bool isConnected;
    private CoherenceMonoBridge bridge;

    [Header("Score")]
    public TMP_Text scoreText;
    public float score;

    [Header("Div")]
    private Vector2 StartPos;
    public TMP_Text nameTag;
    public string currentName;
    private Animator animator;



    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        currentHeat = maxHeat;
        isConnected = false;
        StartPos = transform.position;
        animator= GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        ChangeSkin();

        rb.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * speed;
        if (Input.GetKeyDown(KeyCode.Escape)) Application.Quit();

        if (Input.GetKey(KeyCode.Q))
        {
            currentRotation -= rotationSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.E))
        {
            currentRotation += rotationSpeed * Time.deltaTime;
        }
        transform.localRotation = Quaternion.Euler(0, 0, currentRotation);


        if (currentHeat > 0 && CheckConnected())
        {
            currentHeat -= decayRate * Time.deltaTime;
        }

        if(currentHeat <= 0)
        {
            score = 0;
            transform.position = StartPos + new Vector2(Random.Range(-20, 20), Random.Range(-20, 20));
            currentHeat = maxHeat;
        }

 

        //Debug.Log(currentHeat);

        if (!CheckConnected())
        {
            currentHeat = maxHeat;
            score = 0;
        }

        currentName = NetworkDialog.PlayerName;
        nameTag.text = currentName;
        //Debug.Log(NetworkDialog.PlayerName);


        if (currentHeat > maxHeat) currentHeat = maxHeat;
        heatBar.gameObject.transform.localScale = new Vector3(currentHeat/maxHeat, heatBar.gameObject.transform.localScale.y, heatBar.gameObject.transform.localScale.z);

        rb.velocity = rb.velocity * dragConstant;

        scoreText.text = "Score: " + Mathf.Round(score);

        ScoreIncrease(Time.deltaTime);


    bool CheckConnected()
    {
        if (!MonoBridgeStore.TryGetBridge(gameObject.scene, out bridge))
        {
            return false;
        }
        return bridge.isConnected;
    }

        
}

    public void ScoreIncrease(float amount)
    {
        score += amount;
        CoherenceClientConnection clientCC = bridge.ClientConnections.GetMine();
        if(clientCC != null)
            clientCC.GameObject.GetComponent<Client>().changeScore(score);
    }

    public void kill()
    {
        Debug.Log("Kill1");
        currentHeat = -10000;
        Debug.Log("Kill2");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Food"))
        {
            currentHeat += 10000;
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("Projectile"))
        {
            currentHeat -= 10000;
            DestroyBullet(collision.gameObject);
        }
    }

    private void ChangeSkin()
    {
        switch (currentName) {

            case "Huferu":
                animator.SetInteger("Player", 1);
                break;
            case "Otter":
                animator.SetInteger("Player", 2);
                break;
            default:
                animator.SetInteger("Player", 0);
                break;
        }
    }

    private void DestroyBullet(GameObject bullet)
    {
        bullet.GetComponent<Animator>().SetInteger("Hit",1);
    }




}
