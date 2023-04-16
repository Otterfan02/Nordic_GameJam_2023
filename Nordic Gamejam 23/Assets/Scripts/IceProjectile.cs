using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class IceProjectile : MonoBehaviour
{
    private Vector2 dir;
    private float speed = 0.02f;
    [SerializeField] private float timer;
    private float currentTime;
    private BoxCollider2D col;
    private Animator animator;

    private void Start()
    {
        col= GetComponent<BoxCollider2D>();
        animator= GetComponent<Animator>();
    }

    public void GetDir(Vector2 skeletonDir)
    {
        dir = skeletonDir;
    }
    private void FixedUpdate()
    {
        transform.position = new Vector2(transform.position.x + dir.x * speed, transform.position.y + dir.y * speed);
    }

    private void Update()
    {
        if (currentTime >= timer)
        {
            animator.SetInteger("Hit",1);
        }
        currentTime += Time.deltaTime;
    }

    public void DisableBoxCollider()
    {
        col.enabled = false;
    }

    public void DestroyBullet()
    {
        Destroy(gameObject);
    }
}