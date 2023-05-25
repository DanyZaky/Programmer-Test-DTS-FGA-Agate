using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlockManager : MonoBehaviour
{
    public GameObject[] currentBlockPosition;

    private void Start()
    {
        currentBlockPosition[0] = GameObject.FindWithTag("Knight");
        currentBlockPosition[1] = GameObject.FindWithTag("Dragon");
        currentBlockPosition[2] = GameObject.FindWithTag("Bishop");
        currentBlockPosition[3] = GameObject.FindWithTag("Rock");

        this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
    }

    public void onClickBlock()
    {
        this.gameObject.GetComponent<BoxCollider2D>().enabled = true;
        this.gameObject.GetComponent<Image>().sprite = GameManager.Instance.currentBlockSprite;
        this.gameObject.GetComponent<Button>().enabled = false;

        if (GameManager.Instance.blockType == 0)
        {
            BlockAttackZoneType(0, 2);
        }
        else if (GameManager.Instance.blockType == 1)
        {
            BlockAttackZoneType(1, 1);
        }
        else if (GameManager.Instance.blockType == 2)
        {
            BlockAttackZoneType(2, 1);
        }
        else if (GameManager.Instance.blockType == 3)
        {
            BlockAttackZoneType(3, 2);
        }

        GameManager.Instance.timePlacing = 10;
        GameManager.Instance.blockType = Random.Range(0, 4);
    }

    private void BlockAttackZoneType(int index, int score)
    {
        GameManager.Instance.score += score;
        currentBlockPosition[index].GetComponent<RectTransform>().anchoredPosition = this.gameObject.GetComponent<RectTransform>().anchoredPosition;

        for (int i = 0; i < 4; i++)
        {
            currentBlockPosition[i].SetActive(false);
        }

        currentBlockPosition[index].SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "AttackZone")
        {
            Debug.Log("Lose");
            GameManager.Instance.loseCondition = true;
        }
    }
}
