using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialog
{
    [SerializeField] string title;
    [SerializeField] List<float> times;
    [TextArea]
    [SerializeField] List<string> lines;


    public List<float> Times
    {
        get { return times; }
    }

    public List<string> Lines
    {
        get { return lines; }
    }
}