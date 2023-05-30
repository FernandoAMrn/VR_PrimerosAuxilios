using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public static Score instance;
    
    public TMP_Text scoreText;
    public GameObject panel;

    public int score = 0;
    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
        scoreText.text = score.ToString("0");
    }

    private void Update()
    {
        if (score == 30)
        {
            panel.SetActive(true);
        }
    }

    public void AddPoint()
    {
        score += 1;
        scoreText.text = score.ToString("0");
    }

}
