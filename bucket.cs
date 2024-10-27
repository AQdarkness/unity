using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bucket : MonoBehaviour
{
    public Text myText;
    
    private int score = 0;


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "rain")
        {
            
            Debug.Log("your score");
            score++;
            myText.text = "your score is" + score;
            //Destroy(gameObject);
            Destroy(collision.gameObject);
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