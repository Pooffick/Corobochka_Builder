using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDeliter : MonoBehaviour
{
    [SerializeField] private GameObject Spawn;
    [SerializeField] private Timer timer;

    private void Start()
    {
        Spawn = GameObject.FindGameObjectWithTag("Spawn");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "block")
        {
            Destroy(collision.gameObject);
            Spawn.GetComponent<BlockSpawner>().spawnBlock();
            timer.time += 5;
        }
    }
}
