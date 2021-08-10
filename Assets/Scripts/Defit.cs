using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//если речь про поражение, то defeat
//с неймингом переменных тоже все не очень хорошо, но хер с ним
public class Defit : MonoBehaviour
{
    public bool Lose = false;
    public GameObject Image;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Image.SetActive(true);
        Lose = true;
    }

    private void Update()
    {
        if (Input.anyKey && Lose)
        {
            SceneManager.LoadScene(0);
        }
    }
}
