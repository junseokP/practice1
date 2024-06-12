using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreMng : MonoBehaviour
{
    public static ScoreMng inst;
    public Text scoreText;
    public int score=0;

    private void Awake()
    {
        if (inst == null)
        {
            inst = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int num)
    {
        score += num;
        scoreText.text="Score " + score;

        print(score);
    }
}
