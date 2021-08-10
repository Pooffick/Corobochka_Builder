using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDeliter : MonoBehaviour //вообще delEte, но лучше использовать Remover хотя бы
{
    private BlockSpawner _spawner;
    [SerializeField] 
    private Timer _timer;

    private void Start()
    {
        _spawner = GameObject.FindGameObjectWithTag("Spawn").GetComponent<BlockSpawner>();
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("block"))
        {
            Destroy(collision.gameObject);
            _spawner.spawnBlock();
            _timer.AddTime(5);
        }
    }
}
