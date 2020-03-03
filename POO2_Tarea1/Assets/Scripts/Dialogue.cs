using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Dialogue
{
    // Todo fue sacado del canal Brackeys de Youtube
    //https://www.youtube.com/watch?v=_nRzoTzeyxU&feature=youtu.be
    public string name;

    [TextArea(3,10)]
    public string[] sentences;
}
