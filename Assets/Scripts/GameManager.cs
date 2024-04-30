using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance { get; private set; }

    public const string NEW_LINE = "\n";

    private List<string> logList = new List<string>();

    [SerializeField] private TextMeshProUGUI displayText;

    [SerializeField] private InputActionSO[] inputActionsArray;

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

    public InputActionSO[] GetInputActions()
    {



    }

    public void DisplayFullRoomText()
    {
        ClearAllColectionsForNewRoom();

        string roomDescription = RoomManager.Instance.currentRoom.description + NEW_LINE;
        string roomExitDescription = string.Join(NEW_LINE, RoomManager.Instance.GetExitDescriptionsListInRoom());
        string fullText = roomDescription + roomExitDescription;

        UpdateLogList(fullText);

    }

    public void UpdateLogList(string stringToAdd)
    {
        logList.Add(stringToAdd);
        DisplayLoggedText();
    }

    private void DisplayLoggedText(){

        displayText.text = string.Join(NEW_LINE, logList);

    }

    private void ClearAllColectionsForNewRoom()
    {

        RoomManager.Instance.ClearExits();

    }

}
