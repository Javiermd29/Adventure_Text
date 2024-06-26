using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    public static RoomManager Instance { get; private set; }

    public RoomSO currentRoom;

    private Dictionary<string, RoomSO> exitsDictionary = new Dictionary<string, RoomSO>();

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("There is more than one instance");
        }

        Instance = this;

    }

    public List<string> GetExitDescriptionsListInRoom()
    {
        List<string> exitDescriptionList = new List<string>();

        foreach (Exit exit in currentRoom.exits)
        {

            exitsDescriptionList.Add(exit.description);
            exitsDictionary.Add(exit.direction, exit.room);

        }

        return exitDescriptionList;

    }

    public void TryToChangeRoom(string direction)
    {
        if (exitsDictionary.ContainsKey(direction))
        {

            currentRoom = exitsDictionary[direction];
            GameManager.Instance.UpdateLogList("$You head to the {direction}");
            GameManager.Instance.IsDisconnectedPrefabInstance();

        }
        else
        {
            GameManager.Instance.UpdateLogList("$There's no path to the {direction}");
        }
    }

    public void ClearExits()
    {

        exitsDictionary.Clear();

    }

}
