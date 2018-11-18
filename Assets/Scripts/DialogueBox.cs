using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueBox : MonoBehaviour {

    public bool inDialogue = false;
    Text Text;
    public Queue<string> currentDialogue = new Queue<string>();

	// Use this for initialization
	void Start () {
		Text = this.GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyUp(KeyCode.Space) && currentDialogue.Count <= 0)
        {
            Text.text = "";
            inDialogue = false;
        }
        if ((!inDialogue || Input.GetKeyUp(KeyCode.Space)) && currentDialogue.Count > 0)
        {
            inDialogue = true;
            Text.text = currentDialogue.Dequeue();
        }
    }
}
