using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    [SerializeField] private GameObject _gameoverCanvas;
    private void Awake()
    {
        if (instance == null) instance = this;
        Time.timeScale = 1.0f;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GameOver()
    {
        _gameoverCanvas.SetActive(true);
        Time.timeScale = 0f;
    }
}