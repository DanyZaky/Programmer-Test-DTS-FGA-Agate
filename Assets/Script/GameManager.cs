using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; internal set; }

    public Sprite currentBlockSprite;
    public Sprite bishop, dragon, knight, rock;
    public int blockType;

    [SerializeField] private GameObject losePanel;
    public bool loseCondition;

    public TextMeshProUGUI scoreText;
    public int score;

    public float timePlacing;
    public Image timeFilled;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(this);
    }

    private void Start()
    {
        blockType = Random.Range(0, 4);
        loseCondition = false;
        timePlacing = 10;
    }

    private void Update()
    {
        Score();
        TimePlace();
        LoseCondition();
    }

    private void Score()
    {
        scoreText.text = "SCORE = " + score.ToString();
    }

    private void TimePlace()
    {
        timePlacing -= Time.deltaTime * 1;
        timeFilled.fillAmount = timePlacing / 10;

        if (timePlacing <= 0)
        {
            loseCondition = true;
        }
    }

    private void LoseCondition()
    {
        if (loseCondition == true)
        {
            losePanel.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            losePanel.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void OnClickRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
