using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverController : MonoBehaviour
{
    CanvasGroup _canvasGroup;

    private void Awake()
    {
        _canvasGroup = GetComponent<CanvasGroup>();
    }

    private void Start()
    {
        _canvasGroup.alpha = 0f;
        _canvasGroup.interactable = false;
        _canvasGroup.blocksRaycasts = false;
    }
    private void OnEnable()
    {
        GameManager.Instance.OnGameOvered += HandleOnGameOvered;
    }

    private void OnDisable()
    {
        GameManager.Instance.OnGameOvered -= HandleOnGameOvered;
    }

    private void HandleOnGameOvered(int score, int bestScore)
    {
        _canvasGroup.alpha = 1f;
        _canvasGroup.interactable = true;
        _canvasGroup.blocksRaycasts = true;
    }
}
