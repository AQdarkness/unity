using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menustartbutton : MonoBehaviour
{
    public void playgame(){
        SceneManager.LoadSceneAsync("waterdrop");
    }
    public void quitgame() {
        Application.Quit();
    }
}
