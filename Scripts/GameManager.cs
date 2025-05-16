using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Transform rightPlayer;
    public Transform leftPlayer;
    public Transform finishLine;

    public GameObject resultPanel;
    public Text winnerText;
    public Text loserText;
    public Button playAgainButton;

    private bool gameEnded = false;

    void Update()
    {
        if (gameEnded) return;

        float finishZ = finishLine.position.z;
        float rightZ = rightPlayer.position.z;
        float leftZ = leftPlayer.position.z;

        if (rightZ >= finishZ && leftZ >= finishZ)
        {
            // In case both reach at same time — optional logic
            ShowResult("It's a Tie!", "Both players reached the finish line.");
        }
        else if (rightZ >= finishZ)
        {
            ShowResult("Right Player Wins!", "Left Player Loses!");
        }
        else if (leftZ >= finishZ)
        {
            ShowResult("Left Player Wins!", "Right Player Loses!");
        }
    }

    void ShowResult(string winner, string loser)
    {
        gameEnded = true;
        resultPanel.SetActive(true);

        winnerText.text = winner;
        loserText.text = loser;

        playAgainButton.onClick.RemoveAllListeners(); // clean existing listeners
        playAgainButton.onClick.AddListener(restartGame);
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
