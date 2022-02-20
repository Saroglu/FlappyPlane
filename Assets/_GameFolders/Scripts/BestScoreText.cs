using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BestScoreText : MonoBehaviour
{
    //Text _text;
    TMP_Text _text;

    void Awake()
    {
        _text = GetComponent<TMP_Text>();
    }

    void OnEnable()
    {
        GameManager.Instance.OnGameOvered += HandleOnGameOvered;
    }

    void OnDisable()
    {
        GameManager.Instance.OnGameOvered -= HandleOnGameOvered;
    }

    void HandleOnGameOvered(int score, int bestScore)
    {
        _text.text = bestScore.ToString("00");
    }
}
