using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ground : MonoBehaviour
{
    public Text scoreText;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "rain")
        {
            Debug.Log("game over");
            scoreText.text = "Game Over";
           // Destroy(gameObject);
            Destroy(collision.gameObject);

            Time.timeScale = 0;
        }
    }
        // Start is called before the first frame update
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}