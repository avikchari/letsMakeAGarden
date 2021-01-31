using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedSlots : MonoBehaviour
{
    public GameObject newSeed;

    public bool seedSlotEmpty;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void SpawnNewSeed() 
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (seedSlotEmpty = true) 
        {
            SpawnNewSeed();
        }
    }
}
