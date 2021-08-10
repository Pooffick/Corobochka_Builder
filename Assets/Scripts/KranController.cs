using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KranController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("block"))
        {
            collision.GetComponent<Transform>().SetParent(null);
            collision.GetComponent<WheelJoint2D>().connectedBody = gameObject.GetComponent<Rigidbody2D>();
            collision.GetComponent<Rigidbody2D>().gravityScale = 1f;
        }
    }

}
