using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScreenAudio : MonoBehaviour
{
    public AudioClip[] zvuki;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource.PlayClipAtPoint(zvuki[Random.Range(0, zvuki.Length)], transform.position,0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
