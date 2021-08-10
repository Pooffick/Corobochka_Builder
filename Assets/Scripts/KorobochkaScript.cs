using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KorobochkaScript : MonoBehaviour
{
    private int _localHeight;
    [SerializeField] 
    private int _width;
    [SerializeField] 
    private int _height;
    [SerializeField]
    private GameObject _gBlock;
    [SerializeField] 
    private List<Sprite> sprites;
    [SerializeField] 
    private GameObject TimerText;
    [SerializeField] 
    private GameObject WinImage;

    public List<GameObject> GBlocks = new List<GameObject>();

    private void Start()
    {
        _localHeight = 0;
        GenerateBlocks();
    }

    private void GenerateBlocks()
    {
        if (_localHeight > _height)
        {
            TimerText.SetActive(false);
            WinImage.SetActive(true);
        }
        else
        {
            for (int x = 0; x < _width; x++)
            {
                GameObject temp = Instantiate(_gBlock, new Vector2(x, _localHeight), Quaternion.identity);
                GBlocks.Add(temp);
                temp.GetComponent<SpriteRenderer>().sprite = sprites[Random.Range(0, sprites.Count)];
            }
            _localHeight++;
        }
    }

    private void Update()
    {
        if (Gblocks.Count <= 0)
        {
            GenerateBlocks();
        }
    }
}
