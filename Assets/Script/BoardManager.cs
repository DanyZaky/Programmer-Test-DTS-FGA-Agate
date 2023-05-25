using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoardManager : MonoBehaviour
{
    [SerializeField] private Image blockTypeImage;
    
    [SerializeField] private GameObject blockPrefabs;
    [SerializeField] private Transform boardParent;

    void Start()
    {
        for (int i = 0; i < 54; i++)
        {
            Instantiate(blockPrefabs, boardParent);
        }
    }

    void Update()
    {
        if (BlockSprite.Instance.blockType == 0)
        {
            blockTypeImage.sprite = BlockSprite.Instance.bishop;
        }
        else if (BlockSprite.Instance.blockType == 1)
        {
            blockTypeImage.sprite = BlockSprite.Instance.dragon;
        }
        else if (BlockSprite.Instance.blockType == 2)
        {
            blockTypeImage.sprite = BlockSprite.Instance.knight;
        }
        else if (BlockSprite.Instance.blockType == 3)
        {
            blockTypeImage.sprite = BlockSprite.Instance.rock;
        }

        BlockSprite.Instance.currentBlockSprite = blockTypeImage.sprite;
    }
}
