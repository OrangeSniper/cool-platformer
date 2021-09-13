using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public int curTrack;
    public GameObject[] enemies;
    public Track[] tracks;

    private int curBPM;

    private AudioSource source;

    private float curSecBtwnBeat;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    private void Start()
    {
        curBPM = tracks[0].bpm;
        StartCoroutine(MusicPlay());
    }

    IEnumerator MusicPlay()
    {
        curTrack = Random.Range(0, tracks.Length);
        source.clip = tracks[curTrack].audio;
        source.Play();
        yield return new WaitForSeconds(getSecBtwnBeat(curBPM) * 4 * tracks[curTrack].lengthInBars);
        StartCoroutine(MusicPlay());
    }

    public float getSecBtwnBeat(float bpm)
    {
        return 60000f / bpm / 1000f;
    }
}
