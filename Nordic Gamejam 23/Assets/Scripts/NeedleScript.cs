using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedleScript : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.collider.transform.tag);
        if (collision.transform.tag == "Enemy")
        {
            //Debug.Log("Kill");
            transform.parent.GetComponent<PlayerScript>().ScoreIncrease(69);
            transform.parent.GetComponent<PlayerScript>().currentHeat += 6900;
            Destroy(collision.gameObject);
        } else if (collision.collider.gameObject.CompareTag("Player"))
        {
            transform.parent.GetComponent<PlayerScript>().ScoreIncrease(collision.gameObject.GetComponent<PlayerScript>().score);
            Debug.Log("Added Score");
            transform.parent.GetComponent<PlayerScript>().currentHeat += collision.gameObject.GetComponent<PlayerScript>().currentHeat;
            Debug.Log("Added Heat");
            collision.gameObject.GetComponent<PlayerScript>().kill();
            Debug.Log("Did kill");
        }
    }
}
