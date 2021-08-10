using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDeliter : MonoBehaviour //вообще delEte, но лучше использовать Remover хотя бы
{
    [SerializeField] 
    private GameObject _spawn;
    [SerializeField] 
    private Timer _timer;

    private void Start()
    {
        _spawn = GameObject.FindGameObjectWithTag("Spawn");
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "block")
        {
            Destroy(collision.gameObject);
            _spawn.GetComponent<BlockSpawner>().spawnBlock();
            _timer.time += 5;
        }
    }
}
