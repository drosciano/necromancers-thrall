using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManagerMaze : MonoBehaviour
{
    public NPC npc;

    bool isTalking = false;
    bool dialogueComplete = false;

    float curResponseTrackerPlayer = 0;
    float curResponseNPC = 0;

    public GameObject player;
    public GameObject dialogueUI;

    public TextMeshProUGUI npcName;
    public TextMeshProUGUI npcDialogueBox;
    public TextMeshProUGUI playerResponse;

    private bool triggerEnter = false;



    // Start is called before the first frame update
    void Start()
    {
        dialogueUI.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        triggerEnter = true;
    }

    void OnTriggerExit(Collider other)
    {
        triggerEnter = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && triggerEnter == true && isTalking == false && dialogueComplete == false)
        {
            StartConversation();
        }
        else if (Input.GetKeyDown(KeyCode.E) && isTalking == true && triggerEnter == true)
        {
            EndDialogue();
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            curResponseTrackerPlayer++;
            if (curResponseTrackerPlayer >= npc.playerDialogue.Length - 1)
            {
                curResponseTrackerPlayer = npc.playerDialogue.Length - 1;
            }
        }
        else if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            curResponseTrackerPlayer--;
            if (curResponseTrackerPlayer < 0)
            {
                curResponseTrackerPlayer = 0;
            }
        }

        if (curResponseTrackerPlayer == 0 && npc.playerDialogue.Length >= 0 && curResponseNPC == 1)
        {
            playerResponse.text = npc.playerDialogue[0];
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Triggers.moralityCheck += 1;
                npcDialogueBox.text = npc.dialogue[1];
                curResponseNPC++;
            }

        }
        if (curResponseTrackerPlayer == 1 && npc.playerDialogue.Length >= 1 && curResponseNPC == 1)
        {
            playerResponse.text = npc.playerDialogue[1];
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Triggers.moralityCheck = Triggers.moralityCheck - 1;
                npcDialogueBox.text = npc.dialogue[1];
                curResponseNPC++;
            }

        }
        if (curResponseTrackerPlayer == 2 && npc.playerDialogue.Length >= 2 && curResponseNPC == 2)
        {
            playerResponse.text = npc.playerDialogue[2];
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Triggers.moralityCheck += 1;
                npcDialogueBox.text = npc.dialogue[2];
                curResponseNPC++;
            }

        }
        if (curResponseTrackerPlayer == 3 && npc.playerDialogue.Length >= 3 && curResponseNPC == 2)
        {
            playerResponse.text = npc.playerDialogue[3];
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Triggers.moralityCheck = Triggers.moralityCheck - 1;
                npcDialogueBox.text = npc.dialogue[2];
                curResponseNPC++;
            }

        }
        if (curResponseTrackerPlayer == 4 && npc.playerDialogue.Length >= 4 && curResponseNPC == 3)
        {
            playerResponse.text = npc.playerDialogue[4];
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Triggers.moralityCheck += 1;
                npcDialogueBox.text = npc.dialogue[3];
                curResponseNPC++;
            }

        }
        if (curResponseTrackerPlayer == 5 && npc.playerDialogue.Length >= 5 && curResponseNPC == 3)
        {
            playerResponse.text = npc.playerDialogue[5];
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Triggers.moralityCheck = Triggers.moralityCheck - 1;
                npcDialogueBox.text = npc.dialogue[3];
                curResponseNPC++;
            }

        }
        if (curResponseTrackerPlayer == 6 && npc.playerDialogue.Length >= 6 && curResponseNPC == 4)
        {
            playerResponse.text = npc.playerDialogue[6];
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Triggers.moralityCheck += 1;
                dialogueComplete = true;
                npcDialogueBox.text = npc.dialogue[4];
                curResponseNPC++;
                
            }

        }
        if (curResponseTrackerPlayer == 7 && npc.playerDialogue.Length >= 7 && curResponseNPC == 4)
        {
            playerResponse.text = npc.playerDialogue[7];
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Triggers.moralityCheck = Triggers.moralityCheck - 1;
                dialogueComplete = true;
                npcDialogueBox.text = npc.dialogue[4];
                curResponseNPC++;
                
            }

        }
        
    }

    void StartConversation()
    {
        isTalking = true;
        curResponseTrackerPlayer = 0;
        curResponseNPC = 1;
        dialogueUI.SetActive(true);
        npcName.text = npc.name;
        npcDialogueBox.text = npc.dialogue[0];
    }

    void EndDialogue()
    {
        isTalking = false;
        dialogueUI.SetActive(false);
        npcName.text = "";
        npcDialogueBox.text = "";
        playerResponse.text = "";
    }
}

