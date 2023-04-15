using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class SkeletonMovement : MonoBehaviour
{
    private Animator m_Animator;
    float timer;
    float currentTime;
    public int randomDirection;
    private float raycastDistance = 2;
    private Rigidbody2D rb;
    [SerializeField] private LayerMask mask;
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
        if (LookingAtAPlayer())
        {
            AnimatorController(randomDirection+8);
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
                AnimatorController(0);
                break;
            case 1:
                dir = new Vector2(1, 0);
                AnimatorController(1);
                break;
            case 2:
                dir = new Vector2(1, 1);
                AnimatorController(2);
                break;
            case 3:
                dir = new Vector2(-1, 0);
                AnimatorController(3);
                break;
            case 4:
                dir = new Vector2(0, -1);
                AnimatorController(4);
                break;
            case 5:
                dir = new Vector2(-1, 1);
                AnimatorController(5);
                break;
            case 6:
                dir = new Vector2(1, -1);
                AnimatorController(6);
                break;
            case 7:
                dir = new Vector2(-1, -1);
                AnimatorController(7);
                break;
        }
    }

    private bool LookingAtAPlayer()
    {
        Debug.DrawRay(transform.position, dir * raycastDistance);
        int currentDir = randomDirection;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, dir, raycastDistance, mask);
        if (hit.collider == null)
            return false;

        Debug.Log(hit.collider.tag);
        return true;
    }

    private void FixedUpdate()
    {
        if (LookingAtAPlayer())
            return;

        transform.position += new Vector3(dir.x * Time.deltaTime,dir.y * Time.deltaTime, transform.position.z);
    }


    private void AnimatorController(int currentAnimation)
    {
        m_Animator.SetInteger("Direction", currentAnimation);
    }
}
