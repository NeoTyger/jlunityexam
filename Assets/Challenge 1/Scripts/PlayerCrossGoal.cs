using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCrossGoal : MonoBehaviour
{
    
    private GameManager _gameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Goal"))
        {
            _gameManager.NextLevel();
        }
    }
}
