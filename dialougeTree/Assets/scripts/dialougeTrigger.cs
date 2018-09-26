using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialougeTrigger : MonoBehaviour {

    [SerializeField]
    dialougeManager _Manager;

    public Dialouge dialouge;
    public bool inCoversation = false;
    public bool NpcTalking = false;

    public void TriggerDialouge()
    {
        FindObjectOfType<dialougeManager>().startDialouge(dialouge);
    }

    void OnMouseOver()
    {
        if (inCoversation == false)
        {
            TriggerDialouge();
            print("test");
            inCoversation = true;
        }
    }
     void Update()
    {
        if (_Manager.endCoversation == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {

                FindObjectOfType<dialougeManager>().DisplayNextSentence();

                NpcTalking = !NpcTalking;
            }
        }
        }
}
