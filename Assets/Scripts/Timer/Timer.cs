using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Kulicka;

namespace Timer
{
    public class Timer : MonoBehaviour
    {
        PlayerEntity player;
        [Header("Component")]
        public TextMeshProUGUI timerText;

        [Header("Timer Settings")]
        public float currentTime;
        public bool countDown;

        public void Start()
        {

        }
        private void Update()
        {
            currentTime = countDown ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;
            timerText.text = "Your current Time: " + currentTime.ToString("0.000");
            //StopTimer();
        }
        float StopTimer()
        {
            countDown = false;
            return currentTime;
        }
        string TimeToString(float t)
        {
            string minutes = ((int)t / 60).ToString();
            string seconds = (t % 60).ToString("f2");
            return minutes + ":" + seconds;
        }
        //float StopTimer()
        //{
        //    if (player.Kill())
        //    {
        //        Debug.Log("nevim");
        //        countDown = false;
        //        return currentTime;
        //    }
        //    return 0;
        //}
    }
}
