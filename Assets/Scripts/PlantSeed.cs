using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlantSeed : MonoBehaviour
{
    public UnityEvent seed1MusicPlay;
    public UnityEvent seed1MusicStop;
    public bool seed1In = false;

    public UnityEvent seed2MusicPlay;
    public UnityEvent seed2MusicStop;
    public bool seed2In = false;

    public UnityEvent seed3MusicPlay;
    public UnityEvent seed3MusicStop;
    public bool seed3In = false;

    public UnityEvent seed4MusicPlay;
    public UnityEvent seed4MusicStop;
    public bool seed4In = false;

    public UnityEvent seed5MusicPlay;
    public UnityEvent seed5MusicStop;
    public bool seed5In = false;

    public UnityEvent seed6MusicPlay;
    public UnityEvent seed6MusicStop;
    public bool seed6In = false;

    public UnityEvent seed7MusicPlay;
    public UnityEvent seed7MusicStop;
    public bool seed7In = false;

    public UnityEvent seed8MusicPlay;
    public UnityEvent seed8MusicStop;
    public bool seed8In = false;


    void OnTriggerEnter(Collider seed)
    {
        if(seed.tag == "Seed1")
        {
            Debug.Log("Seed1Play!");
            seed1MusicPlay.Invoke();
            seed1In = true;
            
        }

        else if(seed.tag == "Seed2")
        {
            Debug.Log("Seed2Play!");
            seed2MusicPlay.Invoke();
            seed2In = true;
        }

        else if(seed.tag == "Seed3")
        {
            Debug.Log("Seed3Play!");
            seed3MusicPlay.Invoke();
            seed3In = true;
        }

        else if(seed.tag == "Seed4")
        {
            Debug.Log("Seed4Play!");
            seed4MusicPlay.Invoke();
            seed4In = true;
        }

        else if(seed.tag == "Seed5")
        {
            Debug.Log("Seed5Play!");
            seed5MusicPlay.Invoke();
            seed5In = true;
        }

        else if(seed.tag == "Seed6")
        {
            Debug.Log("Seed6Play!");
            seed6MusicPlay.Invoke();
            seed6In = true;
        }

        else if(seed.tag == "Seed7")
        {
            Debug.Log("Seed7Play!");
            seed7MusicPlay.Invoke();
            seed7In = true;
        }

        else if(seed.tag == "Seed8")
        {
            Debug.Log("Seed8Play!");
            seed8MusicPlay.Invoke();
            seed8In = true;
        }  
    }

    void OnTriggerExit(Collider seed)
    {
        if(seed.tag == "Seed1")
        {
            Debug.Log("Seed1Stop!");
            seed1MusicStop.Invoke();
            seed1In = false;
            
        }

        else if(seed.tag == "Seed2")
        {
            Debug.Log("Seed2Stop!");
            seed2MusicStop.Invoke();
            seed2In = false;
        }

        else if(seed.tag == "Seed3")
        {
            Debug.Log("Seed3Play!");
            seed3MusicStop.Invoke();
            seed3In = false;
        }

        else if(seed.tag == "Seed4")
        {
            Debug.Log("Seed4Play!");
            seed4MusicStop.Invoke();
            seed4In = false;
        }

        else if(seed.tag == "Seed5")
        {
            Debug.Log("Seed5Play!");
            seed5MusicStop.Invoke();
            seed5In = false;
        }

        else if(seed.tag == "Seed6")
        {
            Debug.Log("Seed6Play!");
            seed6MusicStop.Invoke();
            seed6In = false;
        }

        else if(seed.tag == "Seed7")
        {
            Debug.Log("Seed7Play!");
            seed7MusicStop.Invoke();
            seed7In = false;
        }

        else if(seed.tag == "Seed8")
        {
            Debug.Log("Seed8Play!");
            seed8MusicStop.Invoke();
            seed8In = false;
        }  
    } 

   /*  public void Combo()
    {
        if (seed1In = true | seed2In = true | seed3In = true | seed 4In = true
    }  */

}
