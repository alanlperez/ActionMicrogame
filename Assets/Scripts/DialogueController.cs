using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueController : MonoBehaviour
{
    Dialogue currentDialogue;
    public GameObject UIParent;
    public Text nameUI;
    public Text dialogueUI;
    int currentIndex;

    public void StartDialogue(Dialogue d)
    {
        currentDialogue = d;
        UIParent.SetActive(true);
        currentIndex = 0;
        nameUI.text = currentDialogue.npcName;
        dialogueUI.text = currentDialogue.dialogue[currentIndex];
    }

    public void NextLine()
    {
        currentIndex++;
        if (currentIndex < currentDialogue.dialogue.Length)
        {
            nameUI.text = currentDialogue.npcName;
            dialogueUI.text = currentDialogue.dialogue[currentIndex];
        }
        else
            ExitDialogue();
    }

    public void ExitDialogue()
    {
        nameUI.text = "";
        dialogueUI.text = "";
        UIParent.SetActive(false);
        currentIndex = 0;
    }
}
