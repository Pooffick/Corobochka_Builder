using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostBlock : MonoBehaviour
{
    [SerializeField] private KorobochkaScript korobochka;
    [SerializeField] private GameObject korobka;
    [SerializeField] private GameObject Spawn;
    [SerializeField] private GameObject _Timer;

    

    private void Start()
    {
        _Timer = GameObject.Find("loseColider");
        Spawn = GameObject.FindGameObjectWithTag("Spawn");
        korobka = GameObject.FindGameObjectWithTag("korobochka");
        korobochka = korobka.GetComponent<KorobochkaScript>();
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<SpriteRenderer>().sprite == gameObject.GetComponent<SpriteRenderer>().sprite && Input.GetKey(KeyCode.Space))
        {
            collision.gameObject.GetComponent<WheelJoint2D>().breakForce = 1f;
            korobochka.Gblocks.Remove(gameObject);
            Spawn.GetComponent<BlockSpawner>().spawnBlock();
            collision.gameObject.tag = "Untagged";
            collision.gameObject.GetComponent<Rigidbody2D>().mass = 20;
            _Timer.GetComponent<Timer>().time += 30;
            Destroy(gameObject);
        }
    }

}
