using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    // Todo fue sacado del canal Brackeys de Youtube
    //https://www.youtube.com/watch?v=_nRzoTzeyxU&feature=youtu.be
    public Dialogue dialogue;
    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

}
