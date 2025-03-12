using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject pauseMenuPanel;
    [SerializeField] GameObject pauseMenuContents;
    [SerializeField] GameObject score;
    [SerializeField] GameObject pauseButton;
    [SerializeField] GameObject countDown;
    [SerializeField] Text countDownText;

    
    public void PauseGame()
    {
        pauseMenuPanel.SetActive(true);
        pauseMenuContents.SetActive(true);
        score.SetActive(false);
        pauseButton.SetActive(false);
        Time.timeScale = 0;

    }

    public async void ResumeGame()
    {
        pauseMenuContents.SetActive(false);
        countDown.SetActive(true);
        
        for (int i = 3; i >= 0; i--)
        {
            countDownText.text = i.ToString();
            await Task.Delay(1000);
        }
        
        countDown.SetActive(false) ;
        pauseMenuPanel.SetActive(false);
        score.SetActive(true);
        pauseButton.SetActive(true);

        Time.timeScale = 1;
    }
}
