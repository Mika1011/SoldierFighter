using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI livesText;
    [SerializeField] TextMeshProUGUI timerText;

    [SerializeField] AudioSource selectSource;

    public void updateLivesText(int lives)
    {
        livesText.text = "Lives: " + lives;
    }

    public void restart()
    {
        selectSource.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void backToMenu()
    {
        selectSource.Play();
        SceneManager.LoadScene(0);
    }
}
