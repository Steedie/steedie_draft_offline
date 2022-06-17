using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class GetPlayers : MonoBehaviour
{
    protected FileInfo theSourceFile = null;
    protected StreamReader reader = null;
    protected string text = " "; // assigned to allow first line to be read below

    void Start()
    {
        theSourceFile = new FileInfo("Test2.txt");
        reader = theSourceFile.OpenText();
    }

    void Update()
    {
        if (text != null)
        {
            text = reader.ReadLine();
            print(text);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            reader.Close();
        }
    }
}
