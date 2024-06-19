using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI lasttimeText;
    [SerializeField] public float time;
    [SerializeField] private TextMeshProUGUI ScoreText;
    [SerializeField] public int score;

    //[SerializeField] private MoleAction moleAction;
    // Start is called before the first frame update
    void Start()
    {
        time = 60.0f;
        score = 0;
    }

    public void PulasScore()
    {
        score += 1;
        ScoreText.text = "Score:" + score.ToString("D2");
    }

    // Update is called once per frame
    void Update()
    {
        if(0 <= time)
        {
            time -= Time.deltaTime;
            lasttimeText.text = "Last Time:" + time.ToString("F1");
        } 
        else if(0 >= time)
        {
            lasttimeText.text = "TimeUp";
        }
    }
}
