using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class minigame2 : MonoBehaviour
{
    public void playAgain()
    {
        SceneManager.LoadScene("fishgame");
    }
}
