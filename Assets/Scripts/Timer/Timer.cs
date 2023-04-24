using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Kulicka;
using System.IO;
using System;

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
        private bool _isPaused = true;

        public void Pause() => _isPaused = false;


        public void Start()
        {

        }
        private void Update()
        {
            if (_isPaused)
            {
                currentTime = countDown ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;
                timerText.text = "Your current Time: " + currentTime.ToString("0.000");
            }
            else
            {
                ukladani();
                enabled = false;
            }
        }

        void ukladani()
        {
            string cas = currentTime.ToString();
            string level = "Level 1";
            DateTime now = DateTime.Now;
            string timeString = now.ToString("yyyy-MM-dd HH:mm:ss");
            string folderPath = @"C:\Users\marti\Semestralka_KulickaGame\Assets\StreamingAssets\Recall_Chat";
            string fileName = Path.Combine(folderPath, "gameTimes.txt");

            using (StreamWriter sw = new StreamWriter(fileName, true))
            {
                sw.WriteLine("èas v cíli: " + cas + " / " + "Level: " + level + " / " + "aktuální datum a èas: " + timeString);
            }
        }
    }
}
