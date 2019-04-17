using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartKeyPressed : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            StaticClass.NumberOfPlayers = 1;

//            PlayerScore.playerScore = 0;
  //          GameOver.isPlayerDead = false;
    //        Time.timeScale = 1;

            SceneManager.LoadScene("Scene_001");
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            StaticClass.NumberOfPlayers = 2;
            SceneManager.LoadScene("Scene_001");
        }

    }
}
