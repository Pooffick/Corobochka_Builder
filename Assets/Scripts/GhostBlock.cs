using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostBlock : MonoBehaviour
{
    private KorobochkaScript _korobochka;
    private GameObject _korobka;
    private GameObject _spawn;
    private GameObject _timer;

    private void Start()
    {
        _timer = GameObject.Find("loseColider");
        _spawn = GameObject.FindGameObjectWithTag("Spawn");
        _korobka = GameObject.FindGameObjectWithTag("korobochka");
        _korobochka = _korobka.GetComponent<KorobochkaScript>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<SpriteRenderer>().sprite == gameObject.GetComponent<SpriteRenderer>().sprite && Input.GetKey(KeyCode.Space))
        {
            collision.gameObject.GetComponent<WheelJoint2D>().breakForce = 1f;
            _korobochka.Gblocks.Remove(gameObject);
            _spawn.GetComponent<BlockSpawner>().SpawnBlock();
            collision.gameObject.tag = "Untagged";
            collision.gameObject.GetComponent<Rigidbody2D>().mass = 20;
            _timer.GetComponent<Timer>().time += 30;
            Destroy(gameObject);
        }
    }

}
