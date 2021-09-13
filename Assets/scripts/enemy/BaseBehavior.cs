using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBehavior : MonoBehaviour
{
    public int track;
    public BehaviorAddBase behavior;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(track == 0)
        {
            behavior.Track0();
        }else if(track == 1)
        {
            behavior.Track1();
        }
        else
        {
            TrackFallback();
        }
    }
    private void TrackFallback()
    {
        Debug.LogWarning("gameobject's track is out of bounds");
    }
}
