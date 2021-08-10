using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    [SerializeField] 
    private GameObject _blockPrefab;
    [SerializeField] 
    private List<Sprite> _sprites;
    
    public void SpawnBlock()
    {
        GameObject temp = Instantiate(_blockPrefab, transform, false);
        temp.GetComponent<SpriteRenderer>().sprite = _sprites[Random.Range(0, _sprites.Count)];
    }

    private void Start()
    {
        SpawnBlock();
    }
}
