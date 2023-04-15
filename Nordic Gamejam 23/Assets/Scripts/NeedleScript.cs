using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedleScript : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.transform.tag);
        if(collision.transform.tag == "Enemy")
        {
            //Debug.Log("Kill");
            transform.parent.GetComponent<PlayerScript>().score += 69;
            transform.parent.GetComponent<PlayerScript>().currentHeat += 6900;
            Destroy(collision.gameObject);
        } else if(collision.transform.tag == "Player")
        {
            transform.parent.GetComponent<PlayerScript>().score += collision.gameObject.GetComponent<PlayerScript>().score;
            transform.parent.GetComponent<PlayerScript>().currentHeat += collision.gameObject.GetComponent<PlayerScript>().currentHeat;
            collision.gameObject.GetComponent<PlayerScript>().currentHeat = -1;

        }
    }
}
