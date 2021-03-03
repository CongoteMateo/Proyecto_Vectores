using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TMP_Text scoreTxt = null;
    private int score = 20;
    [SerializeField] UiManager uimanager = null;
    private void Awake()
    {
        score = int.Parse(scoreTxt.text);
    }
    public void CalculateScore()
    {
        score -= 1;
        scoreTxt.text = string.Format("{0} Gallinitas" ,score.ToString()) ;
        if (score == 0)
        {
        uimanager.Finish();
        }
    }
}
