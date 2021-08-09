using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class KorobochkaScript : MonoBehaviour
{
    [SerializeField] private int width, height, localHeight;
    [SerializeField] private GameObject Gblock;
    public List<GameObject> Gblocks;
    [SerializeField] private List<Sprite> sprites;
    [SerializeField] private GameObject TimerText;
    [SerializeField] private GameObject WinImage;
    private void Start()
    {
        Gblocks = new List<GameObject>();
        localHeight = 0;
        GenerateBlocks();
    }

    void GenerateBlocks()
    {
        if (localHeight > height)
        {
            TimerText.SetActive(false);
            WinImage.SetActive(true);
        }
        else
        {
            for (int x = 0; x < width; x++)
            {
                GameObject temp;
                Gblocks.Add(Instantiate(Gblock, new Vector2(x, localHeight), Quaternion.identity));
                temp = Gblocks[x];
                temp.GetComponent<SpriteRenderer>().sprite = sprites[Random.Range(0, sprites.Count)];
            }
            localHeight++;
        }
    }
    private void Update()
    {

        if(Gblocks.Count <= 0)
        {
            GenerateBlocks();
        }
    }
}
