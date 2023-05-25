using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlockManager : MonoBehaviour
{
    public GameObject[] currentBlockPosition;

    private void Start()
    {
        currentBlockPosition[0] = GameObject.FindWithTag("Bishop");
        currentBlockPosition[1] = GameObject.FindWithTag("Dragon");
        currentBlockPosition[2] = GameObject.FindWithTag("Knight");
        currentBlockPosition[3] = GameObject.FindWithTag("Rock");
    }

    public void onClickBlock()
    {
        BlockSprite.Instance.blockType = Random.Range(0, 3);

        if (BlockSprite.Instance.blockType == 0)
        {
            BlockSprite.Instance.score += 2;
            currentBlockPosition[0].GetComponent<RectTransform>().anchoredPosition = this.gameObject.GetComponent<RectTransform>().anchoredPosition;

            currentBlockPosition[0].SetActive(true);
            currentBlockPosition[1].SetActive(false);
            currentBlockPosition[2].SetActive(false);
            currentBlockPosition[3].SetActive(false);
        }
        else if (BlockSprite.Instance.blockType == 1)
        {
            BlockSprite.Instance.score += 1;
            currentBlockPosition[1].GetComponent<RectTransform>().anchoredPosition = this.gameObject.GetComponent<RectTransform>().anchoredPosition;

            currentBlockPosition[0].SetActive(false);
            currentBlockPosition[1].SetActive(true);
            currentBlockPosition[2].SetActive(false);
            currentBlockPosition[3].SetActive(false);
        }
        else if (BlockSprite.Instance.blockType == 2)
        {
            BlockSprite.Instance.score += 1;
            currentBlockPosition[2].GetComponent<RectTransform>().anchoredPosition = this.gameObject.GetComponent<RectTransform>().anchoredPosition;

            currentBlockPosition[0].SetActive(false);
            currentBlockPosition[1].SetActive(false);
            currentBlockPosition[2].SetActive(true);
            currentBlockPosition[3].SetActive(false);
        }
        else if (BlockSprite.Instance.blockType == 3)
        {
            BlockSprite.Instance.score += 2;
            currentBlockPosition[3].GetComponent<RectTransform>().anchoredPosition = this.gameObject.GetComponent<RectTransform>().anchoredPosition;

            currentBlockPosition[0].SetActive(false);
            currentBlockPosition[1].SetActive(false);
            currentBlockPosition[2].SetActive(false);
            currentBlockPosition[3].SetActive(true);
        }

        this.gameObject.GetComponent<Image>().sprite = BlockSprite.Instance.currentBlockSprite;
        this.gameObject.GetComponent<Button>().enabled = false;
    }
}
