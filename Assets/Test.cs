using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public int fuel = 100;
    public float lapprogress;
    public float lapprogressreq = 200f;
    public int Laps;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //how much fuel does the car have
        //if I have fuel, Car progresses and fuel decreasing
        if(fuel > 0)
        {
            //increase progression
            lapprogress += 5;
            //decrease fuel
            fuel--;

        }
        else
        {
            //out of fuel
            Debug.Log("Bad Luck, We're out of fuel");

        }
        //if lapprogress = 200f, increase laps count
        if( lapprogress >= lapprogressreq)
        {
            //reset progress
            lapprogress = 0;
            //increase laps
            Laps++;
        }
        Debug.Log("Current Fuel: " + fuel);
        Debug.Log("Current Laps: " + Laps);
    }
}
