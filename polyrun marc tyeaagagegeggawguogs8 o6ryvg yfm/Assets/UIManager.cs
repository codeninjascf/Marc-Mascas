using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagment;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public GameObject mainMenu;

    public GameObject gameOverMenu;
    public TextMeshProUGUI gameOverScoreText;
    public TextMeshProUGUI gameOverHighScoreText;

    private bool _gameOver;
    private int _highScore;

    void Start()
    {
        scoreText.gameObject.SetActive(false);
        mainMenu.SetActive(false);
        gameOverMenu.SetActive(false);

        _gameOver = false;
    }

    
    void Update()
    {
        
    }
}
