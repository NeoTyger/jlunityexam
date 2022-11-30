using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{

    [SerializeField] private Button _btnPlay;
    [SerializeField] private Button _btnOptions;
    
    // Start is called before the first frame update
    void Start()
    {
        _btnPlay.onClick.AddListener(LoadLevel1);
        _btnOptions.onClick.AddListener(LoadOptions);
        
        GameObject gameManager = GameObject.Find("Game Manager");
        if (gameManager != null)
        {
            Destroy(gameManager);
        }
        
        
    }

    private void LoadLevel1()
    {
        SceneManager.LoadScene("Level 1");
    }

    private void LoadOptions()
    {
        SceneManager.LoadScene("Options");
    }
}
