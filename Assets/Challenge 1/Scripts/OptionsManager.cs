using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsManager : MonoBehaviour
{
    
    [SerializeField] private Button _btnReturnMenu;
    
    // Start is called before the first frame update
    void Start()
    {
        _btnReturnMenu.onClick.AddListener(ReturnMenu);
        
        GameObject gameManager = GameObject.Find("Game Manager");
        if (gameManager != null)
        {
            Destroy(gameManager);
        }
    }

    private void ReturnMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
