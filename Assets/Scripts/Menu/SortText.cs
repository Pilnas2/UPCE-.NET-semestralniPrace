using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System.IO;

public class SortText : MonoBehaviour
{
    private TextMeshProUGUI _textComponent;

    private void Start()
    {
        _textComponent = GetComponent<TextMeshProUGUI>();
        string filePath = @"C:\Users\marti\Semestralka_KulickaGame\Assets\StreamingAssets\Recall_Chat\gameTimes.txt";
        string[] lines = File.ReadAllLines(filePath);
        _textComponent.text = string.Join("\n", lines);
    }
}
