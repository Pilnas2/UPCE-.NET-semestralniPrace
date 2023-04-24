using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;
using TMPro;

public class GetText : MonoBehaviour
{
    public Transform contentWindow;
    public GameObject recallTextObject;

    private void Start()
    {
        string readFromFilePath = Application.streamingAssetsPath + "/Recall_Chat/" + "A" + ".txt";

        List<string> fileLines = File.ReadAllLines(readFromFilePath).ToList();

        foreach (string line in fileLines)
        {
            Instantiate(recallTextObject, contentWindow);
            recallTextObject.GetComponent<TextMeshProUGUI>().text = line;
        }
    }
}
