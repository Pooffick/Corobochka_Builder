using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    [SerializeField] private Transform SpawnPoint;
    [SerializeField] private GameObject BlockPrefab;
    [SerializeField] private List<Sprite> sprites;

    private void Start()
    {
        SpawnPoint = GetComponent<Transform>();
        spawnBlock();
    }
   public void spawnBlock()
    {
        GameObject temp;
        temp = Instantiate(BlockPrefab, SpawnPoint, false);
        temp.GetComponent<SpriteRenderer>().sprite = sprites[Random.Range(0, sprites.Count)];
    }
}
