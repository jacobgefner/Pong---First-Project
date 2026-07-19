using UnityEngine;
using TMPro;

public class Manager : MonoBehaviour
{
    public TMP_Text AIScoreText;
    public TMP_Text PlayerScoreText;

    private int aiScore = 0;
    private int playerScore = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        updateScoreText();
    }

    public void AddAIScore()
    {
        aiScore++;
        updateScoreText();
    }

    public void AddPlayerScore()
    {
        playerScore++;
        updateScoreText();
    }

    private void updateScoreText()
    {
        AIScoreText.text = aiScore.ToString();
        PlayerScoreText.text = playerScore.ToString();
    }
}
