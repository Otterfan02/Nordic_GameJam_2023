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
            Destroy(gameObject);
        }
        currentTime += Time.deltaTime;
    }
}