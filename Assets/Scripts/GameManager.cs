using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] IntSO maximumLives;
    public IntSO HighestScore;
    [SerializeField] EventSystem_SO stopGameEvent;
    [SerializeField] EventSystem_SO startGameEvent;
    [SerializeField] EventSystem_SO UIUpdateEvent;
    public static int lives;
    public static int score;

    private void OnEnable()
    {
        lives = maximumLives.value;
        score = 0;
        UIUpdateEvent.Fire();
        startGameEvent.Fire();
        Debug.Log("GameStarted");
    }
    public void ResetScore()
    {
        lives = maximumLives.value;
        score = 0;
    }

    public void IncrementScore(IntSO HitScoreValue)
    {
        score += HitScoreValue.value;
        HighestScore.value = Mathf.Max(score, HighestScore.value);
        UIUpdateEvent.Fire();
    }

    public void DecreaseLife()
    {
        lives--;
        UIUpdateEvent.Fire();
        if (lives > 0)
        {
            Invoke("StartNewGame", 2);
        }
        else
        {
            stopGameEvent.Fire();
            enabled = false;
        }
    }

    public void StartNewGame()
    {
        startGameEvent.Fire();
    }
}
