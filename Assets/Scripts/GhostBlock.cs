using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostBlock : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    private KorobochkaScript _korobochka;
    private BlockSpawner _spawner;
    private Timer _timer;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _timer = GameObject.Find("loseColider").GetComponent<Timer>();
        _spawner = GameObject.FindGameObjectWithTag("Spawn").GetComponent<BlockSpawner>();
        _korobochka = GameObject.FindGameObjectWithTag("korobochka").GetComponent<KorobochkaScript>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (!Input.GetKey(KeyCode.Space))
            return;
        if (collision.gameObject.GetComponent<SpriteRenderer>().sprite == _spriteRenderer.sprite)
        {
            collision.gameObject.GetComponent<WheelJoint2D>().breakForce = 1f;
            _korobochka.Gblocks.Remove(gameObject);
            _spawner.SpawnBlock();
            collision.gameObject.tag = "Untagged";
            collision.gameObject.GetComponent<Rigidbody2D>().mass = 20;
            _timer.AddTime(30);
            Destroy(gameObject);
        }
    }

}
