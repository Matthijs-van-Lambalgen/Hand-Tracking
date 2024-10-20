using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public static DialogManager Instance { get; set; }

    public int subId;

    public TextMeshProUGUI lineText;
    public RectTransform dialogBox;

    public DialogDatabase dialogDatabase;

    private List<float> currentTimes;
    private List<string> currentLines;
    private int currentDialogIndex = -1;
    private int currentDialogID;
    private float timer = 0;
    private float passedTime = 0;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);

        StartDialog(subId);
    }

    public void StartDialog(int id)
    {
        if (id >= 0 && id < dialogDatabase.dialogs.Count)
        {
            currentDialogID = id;
            currentTimes = dialogDatabase.dialogs[currentDialogID].Times;
            currentLines = dialogDatabase.dialogs[currentDialogID].Lines;
            currentDialogIndex = 0;
            DisplayNextDialog();
        }
    }

    void Update()
    {
        if (passedTime >= timer)
            DisplayNextDialog();
        else 
            passedTime += Time.deltaTime;
    }

    void DisplayNextDialog()
    {
        if (currentDialogIndex < currentTimes.Count)
        {
            lineText.text = currentLines[currentDialogIndex];
            if(lineText.text == "[Skip]")
            {
                lineText.text = "";
                dialogBox.GetComponent<Image>().color = new Color(1, 1, 1, 0);
            }
            else
                dialogBox.GetComponent<Image>().color = Color.white;
            timer = currentTimes[currentDialogIndex];
            passedTime = 0;
            currentDialogIndex++;

        }
        else
            dialogBox.gameObject.SetActive(false);
    }
}
