using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStarted : MonoBehaviour
{
    public GameObject secondPlayer;
    void Start()
    {
        Debug.Log("Scene Loaded!");
        Debug.Log(StaticClass.NumberOfPlayers);
        if (StaticClass.NumberOfPlayers == 2)
        {
            Instantiate(secondPlayer, new Vector3(-5, -5.6f, 0), new Quaternion());
            Debug.Log("Second player created!");
        }
    }
}
