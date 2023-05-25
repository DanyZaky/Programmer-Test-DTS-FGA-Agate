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
        SpawnBoard();
    }

    void Update()
    {
        BoardNextInfo();
    }

    private void SpawnBoard()
    {
        for (int i = 0; i < 54; i++)
        {
            Instantiate(blockPrefabs, boardParent);
        }
    }

    private void BoardNextInfo()
    {
        if (GameManager.Instance.blockType == 0)
        {
            blockTypeImage.sprite = GameManager.Instance.bishop;
        }
        else if (GameManager.Instance.blockType == 1)
        {
            blockTypeImage.sprite = GameManager.Instance.dragon;
        }
        else if (GameManager.Instance.blockType == 2)
        {
            blockTypeImage.sprite = GameManager.Instance.knight;
        }
        else if (GameManager.Instance.blockType == 3)
        {
            blockTypeImage.sprite = GameManager.Instance.rock;
        }

        GameManager.Instance.currentBlockSprite = blockTypeImage.sprite;
    }
}
