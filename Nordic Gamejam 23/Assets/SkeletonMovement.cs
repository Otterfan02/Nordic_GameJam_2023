using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonMovement : MonoBehaviour
{
    private Animator m_Animator;
    float timer;
    float currentTime;
    int randomDirection;
    Vector2 dir;
    // Start is called before the first frame update
    void Start()
    {
        m_Animator= GetComponent<Animator>();
        timer = Random.Range(1, 5);
        randomDirection = Random.Range(0, 8);
    }

    // Update is called once per frame
    void Update()
    {
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

    private void FixedUpdate()
    {
        transform.position += new Vector3(dir.x * Time.deltaTime,dir.y * Time.deltaTime, transform.position.z);
    }
}
