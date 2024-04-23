using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance { get; private set; }

    public const string NEW_LINE = "\n";

    private List<string> logList;

    [SerializeField] private TextMeshProUGUI displayText;

    private void Awake()
    {
        if (Instance != null)
        {

            Debug.LogError("There is more than one instance");

        }

        Instance = this;

    }

    private void Start()
    {
        DisplayFullRoomText();
    }

    private void DisplayFullRoomText()
    {

        string fullText = RoomManager.Instance.currentRoom.description + NEW_LINE;
        UpdateLogList(fullText);

    }

    public void UpdateLogList(string stringToAdd)
    {
        //logList.Add(stringToAdd);
        DisplayLogText();
    }

    private void DisplayLogText(){

        displayText.text = string.Join(NEW_LINE, logList.ToArray());

    }

}
