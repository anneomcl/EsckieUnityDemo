using System.Collections.Generic;
using Assets.Scripts;
using Esckie;

public class BigRed : Interactable {

    Dictionary<string, EscEvent> actions;

    private void Start()
    {
        base.Start();
        actions = EscCompiler.Instance.Compile("Assets/Scripts/BigRed.esc", handler.ScriptActions);
        EscVirtualMachine.Instance.RunEvents(actions, handler, "on-start");
    }

    // Update is called once per frame
    void Update ()
    {
        if (this.IsTalkActivated())
        {
            EscVirtualMachine.Instance.RunEvents(this.actions, this.handler, "on-talk");
        }
    }
}
