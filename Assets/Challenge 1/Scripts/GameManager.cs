using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    public GameObject player;

    public int playerLifes = 3;
    private bool playerWins;

    private Vector3 spawnOfTheLevel = Vector3.zero;
    
    [SerializeField] private TextMeshProUGUI _txtWinMSG;
    [SerializeField] private Button _btnNextLevel;
    [SerializeField] private Image life1;
    [SerializeField] private Image life2;
    [SerializeField] private Image life3;


    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        _txtWinMSG.gameObject.SetActive(false);
        _btnNextLevel.onClick.AddListener(GameOver);
        _btnNextLevel.gameObject.SetActive(false);
        
        Time.timeScale = 1.0f;
    }

    public void AddDamage()
    {
        playerLifes -= 1;
        //Debug.Log("Actual lifes : " + playerLifes);

        if (playerLifes == 2)
        {
            Destroy(life1);
        }
        
        if (playerLifes == 1)
        {
            Destroy(life2);
        }
        
        if (playerLifes <= 0)
        {
            Destroy(life3);
        }
        
        RestartLevel();

        if (playerLifes <= 0)
        {
            Destroy(player);
            //Debug.Log("YOU DIE... GAME OVER");
            FinishLevel("YOU DIE... GAME OVER");
            
            playerWins = false;
            GameOver();
        }
    }

    private void FinishLevel(string msg)
    {
        _txtWinMSG.gameObject.SetActive(true);
        _txtWinMSG.text = msg;

        _btnNextLevel.gameObject.SetActive(true);
    }

    private void RestartLevel()
    {
        player.transform.position = spawnOfTheLevel;
        player.transform.rotation = new Quaternion(0f,0f,0f,0f);
    }

    public void GameOver()
    {
        if (playerWins == false)
        {
            Time.timeScale = 0;
            SceneManager.LoadScene("Game Over");
        }

        if (playerWins)
        {
            Time.timeScale = 0;
            FinishLevel("YOU END THE GAME!!!");
            SceneManager.LoadScene("Game Over");
        }
    }

    public void NextLevel()
    {
        Time.timeScale = 0;
        _txtWinMSG.gameObject.SetActive(false);
        _btnNextLevel.onClick.AddListener(GameOver);
        _btnNextLevel.gameObject.SetActive(false);
        FinishLevel("YOU WIN!!!");
        SceneManager.LoadScene("Level 2");
    }

    public void AddLife()
    {
        if (playerLifes != 3)
        { 
            playerLifes += 1;
            //Falta poner que vuelva a crearse una imagen de la vida
        }
        
    }
}
