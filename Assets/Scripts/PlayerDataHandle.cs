using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataHandle : MonoBehaviour
{
    // Static class for save the current player data
    // Singleton pattern
    public static PlayerDataHandle instance;

    public string playerName;
    public int score;

    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);

            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
