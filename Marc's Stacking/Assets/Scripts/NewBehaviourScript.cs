using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Spawner spawner;
    public CameraFollow vieww;
    public UIManager uiManager;

    private bool _gameOver;
    // Start is called before the first frame update
    void Start()
        private void Start()
    {
        spawner.Spawn();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1") && !_gameOver)
        {
            BlockMovement.CurrentBlock.Stop();
            if (BlockMovement.GameOver)

                _gameOver = true;
        }
        else
        {
            spawner.Spawn();
            vieww.Height = spawner.GetNewHeight();
            uiManager.Score++;
        }
    }
}
