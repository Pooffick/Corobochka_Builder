using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KranMover : MonoBehaviour
{
    [SerializeField] private Rigidbody2D KranController;
    [SerializeField] public float MoveSpeed = 10f;
    [SerializeField] private Transform Verevka;
    [SerializeField] private GameObject defit;
    private void Update()
    {
        KranController.velocity = new Vector2(Input.GetAxis("Horizontal") * MoveSpeed, 0f);
        if (Verevka.localScale.y > 0 && Verevka.localScale.y < 8)
        {
            Verevka.localScale += new Vector3(0f, -Input.GetAxis("Vertical") * Time.deltaTime);
            Verevka.position += new Vector3(0f, -Input.GetAxis("Vertical") * Time.deltaTime);
        }
        else
        {
            defit.GetComponent<Defit>().lose = true;
            defit.GetComponent<Defit>().image.SetActive(true);
        }
    }
}
