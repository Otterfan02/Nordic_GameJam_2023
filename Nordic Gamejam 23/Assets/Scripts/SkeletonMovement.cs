using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonMovement : MonoBehaviour
{
    private Animator m_Animator;
    float timer;
    float currentTime;
    int randomDirection;
    private Rigidbody2D rb;
    Vector2 dir;
    RaycastHit2D hit;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        m_Animator= GetComponent<Animator>();
        timer = Random.Range(1, 5);
        randomDirection = Random.Range(0, 8);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(transform.position, new Vector2(transform.position.x + dir.x * 5, transform.position.y + dir.y * 5));
        if (LookingAtAPlayer()){
            m_Animator.SetInteger("Direction", (0 + 8));
            return;
        }

        if (currentTime >= timer) {
            randomDirection = Random.Range(0, 8);
            timer = Random.Range(1, 5);
            currentTime = 0;
        }
        currentTime += Time.deltaTime;




        switch (randomDirection)
        {
            case 0:
               dir = new Vector2(0, 1);
                m_Animator.SetInteger("Direction", 0);
                break;
            case 1:
                dir = new Vector2(1, 0);
                m_Animator.SetInteger("Direction", 1);
                break;
            case 2:
                dir = new Vector2(1, 1);
                m_Animator.SetInteger("Direction", 2);
                break;
            case 3:
                dir = new Vector2(-1, 0);
                m_Animator.SetInteger("Direction", 3);
                break;
            case 4:
                dir = new Vector2(0, -1);
                m_Animator.SetInteger("Direction", 4);
                break;
            case 5:
                dir = new Vector2(-1, 1);
                m_Animator.SetInteger("Direction", 5);
                break;
            case 6:
                dir = new Vector2(1, -1);
                m_Animator.SetInteger("Direction", 6);
                break;
            case 7:
                dir = new Vector2(-1, -1);
                m_Animator.SetInteger("Direction", 7);
                break;
        }
    }

    private bool LookingAtAPlayer()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(transform.position.x + dir.x * 5, transform.position.y + dir.y * 5));
        if (hit.collider.CompareTag("Player"))
        {
            m_Animator.SetInteger("Direction", randomDirection + 8);
            return true;
        }
        return false;
    }

    private void FixedUpdate()
    {
        if (LookingAtAPlayer())
            return;

        transform.position += new Vector3(dir.x * Time.deltaTime,dir.y * Time.deltaTime, transform.position.z);
    }

}
