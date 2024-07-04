using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Text>().text = $"{AllScores.score} pts.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
