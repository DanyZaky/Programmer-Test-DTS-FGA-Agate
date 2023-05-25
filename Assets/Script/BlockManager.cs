using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlockManager : MonoBehaviour
{
    
    public void onClickBlock()
    {
        BlockSprite.Instance.blockType = Random.Range(0, 3);

        if (BlockSprite.Instance.blockType == 0)
        {
            BlockSprite.Instance.score += 2;
        }
        else if (BlockSprite.Instance.blockType == 1)
        {
            BlockSprite.Instance.score += 1;
        }
        else if (BlockSprite.Instance.blockType == 2)
        {
            BlockSprite.Instance.score += 1;
        }
        else if (BlockSprite.Instance.blockType == 3)
        {
            BlockSprite.Instance.score += 2;
        }

        this.gameObject.GetComponent<Image>().sprite = BlockSprite.Instance.currentBlockSprite;
        this.gameObject.GetComponent<Button>().enabled = false;
    }
}
