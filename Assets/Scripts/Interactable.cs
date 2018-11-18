using System.Collections.Generic;
using System.Reflection;
using Esckie;
using UnityEngine;

namespace Assets.Scripts
{
    public class Interactable : MonoBehaviour
    {
        protected EscActionsHandler handler = new EscActionsHandler(Assembly.GetExecutingAssembly());
        GameObject player;
        DialogueBox dialogueBox;

        // Use this for initialization
        protected void Start()
        {
            player = GameObject.Find("Player");
            dialogueBox = GameObject.Find("DialogueBox").GetComponent<DialogueBox>();
        }

        protected bool IsTalkActivated()
        {
            return !dialogueBox.inDialogue && Vector3.Distance(player.transform.position, this.transform.position) < 3.0f && Input.GetKeyUp(KeyCode.E);
        }
    }
}
