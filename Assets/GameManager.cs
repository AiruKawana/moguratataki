using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI lasttimeText;
    [SerializeField] public float time;
    // Start is called before the first frame update
    void Start()
    {
        time = 60.0f;
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
