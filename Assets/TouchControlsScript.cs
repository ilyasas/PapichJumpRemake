using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControlsScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void q()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<PapichSkill>().qskill();
    }
    public void w()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<PapichSkill>().wskill();
    }
    public void e()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<PapichSkill>().eskill();
    }
}
