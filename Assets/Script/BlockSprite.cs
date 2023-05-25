using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BlockSprite : MonoBehaviour
{
    public static BlockSprite Instance { get; internal set; }

    public Sprite currentBlockSprite;
    public Sprite bishop, dragon, knight, rock;
    public int blockType;

    public TextMeshProUGUI scoreText;
    public int score;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(this);
    }

    private void Start()
    {
        blockType = Random.Range(0, 3);
    }

    private void Update()
    {
        scoreText.text = "SCORE = " + score.ToString();
    }
}
