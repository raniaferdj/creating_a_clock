using System;
using UnityEngine;
public class Clock : MonoBehaviour
{
    [SerializeField]
    Transform hoursPivot, minutesPivot, secondsPivot;
    const float hoursToDegrees = -30f, minutesToDegrees = -6f, secondsToDegrees = -6f;

    //void Awake() {
    void Update()
    {
        //Debug.Log(DateTime.Now.Hour);
        //var time = DateTime.Now;

        TimeSpan time = DateTime.Now.TimeOfDay;

        //hoursPivot.localRotation = Quaternion.Euler(0f, 0f, hoursToDegrees * time.Hour);
        //minutesPivot.localRotation = Quaternion.Euler(0f, 0f, minutesToDegrees * time.Minute);
        //secondsPivot.localRotation = Quaternion.Euler(0f, 0f, secondsToDegrees * time.Second);

        hoursPivot.localRotation =
            Quaternion.Euler(0f, 0f, hoursToDegrees * (float)time.TotalHours);
        minutesPivot.localRotation =
            Quaternion.Euler(0f, 0f, minutesToDegrees * (float)time.TotalMinutes);
        secondsPivot.localRotation =
            Quaternion.Euler(0f, 0f, secondsToDegrees * (float)time.TotalSeconds);
    }

}