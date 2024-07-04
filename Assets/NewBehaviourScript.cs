using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public AudioClip[] zdarova;
    private void Start()
    {
        Screen.SetResolution(740, 1080, true);
        AudioSource.PlayClipAtPoint(zdarova[Random.Range(0, zdarova.Length)], Camera.main.transform.position);
    }
    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }

    public void guideMenu()
    {
        SceneManager.LoadScene(3);
    }
}
