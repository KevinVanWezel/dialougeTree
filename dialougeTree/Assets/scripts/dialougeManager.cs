using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialougeManager : MonoBehaviour {

    [SerializeField]
    dialougeTrigger _Trigger;

    public bool endCoversation = false;

    public TextAsset dialouge1;
  
    private string[] Text;

    public Text nameText;
    public Text dialougeText;

    private Queue<string> sentences;

	void Start () {
        if (dialouge1)
        {
            Text = (dialouge1.text.Split("\n"[0]));
        }
        

        sentences = new Queue<string>();
		
	}
    
    public void startDialouge (Dialouge dialouge)
    {
       
        nameText.text = dialouge.name;

        sentences.Clear();

        foreach(string sentence in Text)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();

    }
    public void DisplayNextSentence()
    {
       
            
        if (sentences.Count == 0)
        {
            EndDialouge();
            return;
        }

        string sentence = sentences.Dequeue();
        dialougeText.text = sentence;
    }

    public void EndDialouge()
    {
        endCoversation = true;
        print("end of the conversation");
    }

    private void Update()
    {
        if (_Trigger.NpcTalking == true)
        {
            Text DialougeText = GameObject.Find("Dialouge").GetComponent<Text>();
            DialougeText.transform.position = new Vector3(550, 240, 0);
        }
        else
        {
            Text DialougeText = GameObject.Find("Dialouge").GetComponent<Text>();
            DialougeText.transform.position = new Vector3(379, 240, 0);
        }
       
    }


}
