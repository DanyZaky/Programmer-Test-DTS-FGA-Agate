using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoardManager : MonoBehaviour
{
    [SerializeField] private Sprite bishop, dragon, knight, rock;
    [SerializeField] private int blockType;
    [SerializeField] private Image blockTypeImage;
    
    [SerializeField] private GameObject blockPrefabs;
    [SerializeField] private Transform boardParent;

    void Start()
    {
        for (int i = 0; i < 54; i++)
        {
            Instantiate(blockPrefabs, boardParent);
        }

        blockType = Random.Range(0, 3);
    }

    void Update()
    {
        if (blockType == 0)
        {
            blockTypeImage.sprite = bishop;
        }
        else if (blockType == 1)
        {
            blockTypeImage.sprite = dragon;
        }
        else if (blockType == 2)
        {
            blockTypeImage.sprite = knight;
        }
        else if (blockType == 3)
        {
            blockTypeImage.sprite = rock;
        }
    }
}
