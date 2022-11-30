using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject player;

    private int playerLifes = 3;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddDamage()
    {
        playerLifes -= 1;
        Debug.Log("Actual lifes : " + playerLifes);

        if (playerLifes <= 0)
        {
            Destroy(player);
            Debug.Log("YOU DIE... GAME OVER");
        }
    }
}
