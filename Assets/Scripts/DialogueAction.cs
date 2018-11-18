using System;
using Esckie;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class DialogueAction : EscAction
    {
        public static DialogueBox DialogueBox = GameObject.Find("DialogueBox").GetComponent<DialogueBox>();

        public static void Say(string actor, string content)
        {
            DialogueBox.currentDialogue.Enqueue(actor + ": " + content);
        }
    }
}
