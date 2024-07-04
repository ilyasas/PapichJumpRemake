using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SabgiEndScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Text>().text = $"{AllScores.sabgi} руб.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
