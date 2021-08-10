using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//если речь про поражение, то defeat
//с неймингом переменных тоже все не очень хорошо, но хер с ним
public class Defit : MonoBehaviour
{
    private bool _lose = false;
    [SerializeField]
    private GameObject _image;

    public void Lose()
    {
        _image.SetActive(true);
        _lose = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Lose();
    }

    private void Update()
    {
        if (Input.anyKey && _lose)
        {
            SceneManager.LoadScene(0);
        }
    }
}
