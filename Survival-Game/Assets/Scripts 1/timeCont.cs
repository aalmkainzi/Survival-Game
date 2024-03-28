using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class timeCont : MonoBehaviour
{
    [SerializeField] private float timeMulti;

    [SerializeField] private float startHour;

    [SerializeField] private float sunRiseHour;

    [SerializeField] private float sunSetHour;

    [SerializeField] private Light sunLight;

    private TimeSpan sunSet;

    private TimeSpan sunRise;

    private DateTime currTime;

    // Start is called before the first frame update
    void Start()
    {
        currTime = DateTime.Now.Date + TimeSpan.FromHours(startHour);

        sunRise = TimeSpan.FromHours(sunRiseHour);
        sunSet = TimeSpan.FromHours(sunSetHour);
    }

    // Update is called once per frame
    void Update()
    {
        updateTime();
        rotateSun();
    }

    private void updateTime()
    {
        currTime = currTime.AddSeconds(Time.deltaTime * timeMulti);
    }

    private void rotateSun()
    {
        float sunRotate;

        if(currTime.TimeOfDay > sunRise && currTime.TimeOfDay < sunSet)
        {
            TimeSpan riseToSet = theTimeDiff(sunRise, sunSet);
            TimeSpan timeSinceRise = theTimeDiff(sunRise, currTime.TimeOfDay);

            double perc = timeSinceRise.TotalMinutes / riseToSet.TotalMinutes;
            sunRotate = Mathf.Lerp(0, 180, (float)perc);
        }
        else
        {
            TimeSpan setToRise = theTimeDiff(sunSet, sunRise);
            TimeSpan timeSinceSet = theTimeDiff(sunSet, currTime.TimeOfDay);

            double perc = timeSinceSet.TotalMinutes / setToRise.TotalMinutes;
            sunRotate = Mathf.Lerp(180, 360, (float)perc);
        }

        sunLight.transform.rotation = Quaternion.AxisAngle(Vector3.right,sunRotate);
    }

    private TimeSpan theTimeDiff(TimeSpan fromTime,TimeSpan toTime)

    {
        TimeSpan diff = toTime - fromTime;

        if(diff.TotalSeconds < 0)
        {
            diff += TimeSpan.FromHours(24);
        }
        return diff;
    }
}
