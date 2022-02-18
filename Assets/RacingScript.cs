using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacingScript : MonoBehaviour
{
    int Lap = 0;
    float CurLapProgress = 0.0f;
    float ReqLapProgress = 100.0f;

    float Speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GainProgress(Speed);
        }
    }
    public void GainProgress(float progress)
    {
        CurLapProgress += progress;
        Debug.Log("Progress Gained: " + progress);
        Debug.Log("Current Lap Progress: " + CurLapProgress);
        CheckProgress(CurLapProgress);
    }
    public void CheckProgress(float Progress)
    {
        if(Progress>=ReqLapProgress)
        {
            //Completed a Lap
            LapCompleted();
            Debug.Log("We reached the required progress!");
        }
    }
    public void LapCompleted()
    {
            Lap += 1;
            CurLapProgress = 0;
            ReqLapProgress *=1.15f;
        Debug.Log("Completed a Lap");
        Debug.Log("Camps Completed: " + Lap);
    }
}
