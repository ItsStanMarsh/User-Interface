using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lifecounter : MonoBehaviour
{

    public int lives = 20;
    public Text uiText;

    public Slider sl;

    void Start()
    {
        sl = sl.GetComponent<Slider>();
    }
   
    public void edditpoints(int hi)
    {
        if ((lives >= 20 && hi == 1) || (lives <= 0 && hi == -1))
        {

        }
        else { lives += hi;}

        sl.value = lives;
    }


     void Update()
    {
        uiText.text = "lives: " + lives.ToString();
    }

    
}