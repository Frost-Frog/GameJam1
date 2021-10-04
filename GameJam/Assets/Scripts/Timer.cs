using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Timer : MonoBehaviour
{
    public string scoretime;

    public GameObject home;
    public TextMeshProUGUI timer;
    public float currentTime;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(home);
    }

    // Update is called once per frame
    void Update()
    {
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        currentTime = currentTime + Time.deltaTime;
        //currentTime += System.Math.Round(Time.deltaTime*10, 2);
        //currentTime = Time.timeAsDouble;
        timer.text = time.ToString(@"mm\:ss\:ff");
        scoretime = time.ToString(@"mm\:ss\:ff");
    }
}
