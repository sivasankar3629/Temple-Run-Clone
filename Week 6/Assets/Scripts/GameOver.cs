using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class GameOver : MonoBehaviour
{
    [SerializeField] Player player;
    [SerializeField] Animator animator;
    [SerializeField] GameObject panel;
    [SerializeField] GameObject scoreField;
    [SerializeField] Text score;
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            Debug.Log(collision.collider.name);
            player.canMove = false;
            animator.SetBool("GameOver",true);
            Invoke("GameOverScreen", 3f);
            score.text = player.score.ToString();

        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
        panel.SetActive(false);
        scoreField.SetActive(true);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    void GameOverScreen()
    {
        panel.SetActive(true);
        scoreField.SetActive(false);
    }
}
