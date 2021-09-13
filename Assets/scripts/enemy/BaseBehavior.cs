using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBehavior : MonoBehaviour
{
    public int track;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(track == 0)
        {
            Track0Behave();
        }else if(track == 1)
        {
            Track1Behave();
        }
    }

    private void Track0Behave()
    {
        Debug.Log("track 1");
    }
    private void Track1Behave()
    {
        Debug.Log("track 2");
    }
    private void TrackFallback()
    {
        Debug.LogWarning("gameobject's track is out of bounds");
    }
}
