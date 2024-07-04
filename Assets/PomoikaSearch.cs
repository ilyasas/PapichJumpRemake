using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PomoikaSearch : MonoBehaviour
{
    public int minPomoikasPerIceFrog, maxPomoikasPerIceFrog, minPomoikasPerSol, maxPomoikasPerSol, minPomoikasPerClock, maxPomoikasPerClock, minPomoikasPerSabgi, maxPomoikasPerSabgi;
    int IceFrogSpawnTime=0, RandomTimeIce, SolyaraSpawnTime=0, RandomTimeSol, ClockSpawnTime = 0, RandomTimeClock, SabgiSpawnTime = 0, RandomTimeSabgi;
    float scale;
    float width;
    public GameObject Pomoika;
    public GameObject GayShit;
    public GameObject IceFrog;
    public GameObject Solyara;
    public GameObject Clock;
    public GameObject Sabgi;
    Camera cameramain;
    // Start is called before the first frame update
    void Start()
    {
        RandomTimeSabgi = Random.Range(minPomoikasPerSabgi, maxPomoikasPerSabgi);
        RandomTimeClock = Random.Range(minPomoikasPerClock, maxPomoikasPerClock);
        RandomTimeSol = Random.Range(minPomoikasPerSol, maxPomoikasPerSol);
        RandomTimeIce = Random.Range(minPomoikasPerIceFrog, maxPomoikasPerIceFrog);
        transform.position = new Vector3(Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.pixelWidth / 2, 0)).x, Camera.main.ScreenToWorldPoint(new Vector3(0, Camera.main.pixelHeight)).y+2f);
        Instantiate(GayShit, new Vector3(transform.position.x, transform.position.y), transform.rotation);
        cameramain = Camera.main.GetComponent<Camera>();
        width = (Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.pixelWidth,0)).x-Camera.main.ScreenToWorldPoint(new Vector3(0, 0)).x) / 2-0.5f;
        transform.localScale = new Vector3(1, 0.1f);
        for (float i = cameramain.transform.position.y - cameramain.orthographicSize; i <= transform.position.y; i += 0.6f)
        {
            Instantiate(Pomoika, new Vector3(Random.Range(-width, width), i), transform.rotation);
        }
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        scale = (AllScores.score/7000);
        scale = Mathf.Clamp(scale, 0f, 1f);
        transform.localScale = new Vector3(1f, 0.1f+(0.1f*scale));
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        
        if (collision.CompareTag("SpawnTime"))        
        {            
            Instantiate(GayShit, new Vector3(transform.position.x, transform.position.y), transform.rotation);

            SabgiSpawnTime += 1;
            if (SabgiSpawnTime == RandomTimeSabgi)
            {
                Instantiate(Sabgi, new Vector3(Random.Range(-width, width), Random.Range(0f, 2f) + transform.position.y), transform.rotation);
                SabgiSpawnTime = 0;
                RandomTimeSabgi = Random.Range(minPomoikasPerSabgi, maxPomoikasPerSabgi);
            }

            ClockSpawnTime += 1;
            if (ClockSpawnTime >= RandomTimeClock - Mathf.Round(Mathf.Clamp(RandomTimeClock * scale, 0, RandomTimeClock-8)))
            {
                Instantiate(Clock, new Vector3(Random.Range(-width, width), Random.Range(0f, 2f) + transform.position.y), transform.rotation);
                ClockSpawnTime = 0;
                RandomTimeClock = Random.Range(minPomoikasPerClock, maxPomoikasPerClock);
            }

            SolyaraSpawnTime += 1;
            if (SolyaraSpawnTime == RandomTimeSol)
            {
                Instantiate(Solyara, new Vector3(Random.Range(-width, width), Random.Range(0f, 2f) + transform.position.y), transform.rotation);
                SolyaraSpawnTime = 0;
                RandomTimeSol = Random.Range(minPomoikasPerSol, maxPomoikasPerSol);
            }

            IceFrogSpawnTime += 1;
            if (IceFrogSpawnTime >= RandomTimeIce - Mathf.Round(Mathf.Clamp(RandomTimeIce * scale, 0, RandomTimeIce-4)))
            {
                Instantiate(IceFrog, new Vector3(Random.Range(-width, width), Random.Range(0f, 2f) + transform.position.y), transform.rotation);
                IceFrogSpawnTime = 0;
                RandomTimeIce = Random.Range(minPomoikasPerIceFrog, maxPomoikasPerIceFrog);
            }
            //int Howmuch = Random.Range(1, 3);
            //for (int i = 1; i <= Howmuch; i++)
            //{
            Instantiate(Pomoika, new Vector3(Random.Range(-width, width), Random.Range(-0.5f, 0.5f) + transform.position.y), transform.rotation);
            //}
        }
    }
}
