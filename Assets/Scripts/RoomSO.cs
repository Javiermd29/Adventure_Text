using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Object/Room")]

public class RoomSO : ScriptableObject
{

    public string name;
    [TextArea] public string description;

}
