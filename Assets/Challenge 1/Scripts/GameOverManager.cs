using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    
    [SerializeField] private Button _btnReturnToMenu;

    void Start()
    {
        _btnReturnToMenu.onClick.AddListener(ReturnToMenu);
        
        GameObject gameManager = GameObject.Find("Game Manager");
        if (gameManager != null)
        {
            Destroy(gameManager);
        }
    }

    private void ReturnToMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
