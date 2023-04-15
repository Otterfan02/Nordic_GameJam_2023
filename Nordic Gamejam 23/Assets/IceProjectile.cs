using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class IceProjectile : MonoBehaviour
{
    private Vector2 dir;
    private float speed = 2f;

    public void GetDir(Vector2 skeletonDir)
    {
        dir = skeletonDir;
    }
    private void FixedUpdate()
    {
        transform.position = new Vector2(transform.position.x + dir.x, transform.position.y + dir.y);
    }
}
