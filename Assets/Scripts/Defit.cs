using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Defit : MonoBehaviour
{
    public bool lose = false;
    public GameObject image;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        image.SetActive(true);
        lose = true;
    }
    private void Update()
    {
        if (Input.anyKey && lose)
        {
            SceneManager.LoadScene(0);
        }
    }
}
