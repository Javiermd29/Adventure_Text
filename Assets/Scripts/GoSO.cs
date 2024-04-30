using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GoSO : InputActionSO
{

    public override void RespondToInput(string[] separatedInput)
    {

        RoomManager.Instance.TryToChangeRoom(separatedInput[1]);

    }


}
