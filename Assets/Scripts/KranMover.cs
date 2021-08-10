using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KranMover : MonoBehaviour
{
    [SerializeField]
    private float _moveSpeed = 10f;
    [SerializeField] 
    private Rigidbody2D _kranController;
    [SerializeField] 
    private Transform _verevka;
    [SerializeField] 
    private GameObject _defit;

    private void Update()
    {
        _kranController.velocity = new Vector2(Input.GetAxis("Horizontal") * _moveSpeed, 0f);
        if (_verevka.localScale.y > 0 && _verevka.localScale.y < 8)
        {
            var newDirection = new Vector3(0f, -Input.GetAxis("Vertical") * Time.deltaTime);
            _verevka.localScale += newDirection;
            _verevka.position += newDirection;
        }
        else
        {
            _defit.GetComponent<Defit>().Lose();
        }
    }
}
