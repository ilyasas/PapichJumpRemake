using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static float pts;
    RectTransform rect;
    Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        //cam = Camera.main;
        //rect = GetComponent<RectTransform>();
        //rect.anchoredPosition=new Vector3(-(cam.GetComponent<Camera>().pixelWidth/2), cam.GetComponent<Camera>().pixelHeight/2);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //pts = Mathf.FloorToInt(100 * transform.parent.transform.parent.position.y);
        gameObject.GetComponent<Text>().text = $"{AllScores.score}";

    }
}
