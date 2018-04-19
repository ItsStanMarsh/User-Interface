using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorecounter : MonoBehaviour {

    public int score = 0;
    public Text uiText;

	void Start () {
		
	}

    public void hi(int tempA)
    {
        score += tempA;

        UpdateText();
    }


    void UpdateText () {

       uiText.text = "Score: " + score.ToString();
    }
}
