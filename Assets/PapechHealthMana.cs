using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PapechHealthMana : MonoBehaviour
{
    public AudioClip[] zvukdomaga;
    float maxMana;
    public bool inv=false;
    public float health=100;
    public float mana=100;
    public float maxExp = 100, lvl = 1,exp=0;
    // Start is called before the first frame update
    void Start()
    {
        maxMana = mana;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (lvl < 3)
        {
            if (exp >= maxExp * lvl)
            {
                exp -= maxExp * lvl;
                lvl += 1;
            }
        }
        else
        {
            exp = maxExp*lvl;
        }
    }
    public void ManaChange(float i)
    {
        mana += i;
        if (mana >=maxMana)
        {
            mana = maxMana;

        }
    }
    public float Mana()
    {
        return mana;
    }
    public void Damage(float i)
    {
        if (!inv)
        {
            health -= i;
            inv = true;
            StartCoroutine("Invincible");
            AudioSource.PlayClipAtPoint(zvukdomaga[Random.Range(0, zvukdomaga.Length)], GameObject.FindGameObjectWithTag("Listener").transform.position);
        }
        if (health<=0)
        {
            SceneManager.LoadScene(2);
            
        }
        

    }
    IEnumerator Invincible()
    {
        yield return new WaitForSeconds(3f);
        inv = false;
        FindObjectOfType<Flashing>().GetComponent<SpriteRenderer>().enabled = true;
    }

}

