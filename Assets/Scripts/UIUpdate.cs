using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIUpdate : MonoBehaviour
{
    [SerializeField] Text highScoreText;
    [SerializeField] IntSO highScore;
    [SerializeField] Text scoreText;
    [SerializeField] Text livesText;
    private void UpdateText(Text text, string Word, int value)
    {
        text.text = Word + value;
    }

    public void UpdateScore()
    {
        UpdateText(scoreText, "Score: ", GameManager.score);
    }

    public void UpdateLives()
    {
        UpdateText(livesText, "Lives: ", GameManager.lives);
    }

    public void UpdateHighScore()
    {
        UpdateText(highScoreText, "Highest ", highScore.value);
    }
}
