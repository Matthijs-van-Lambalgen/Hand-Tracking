using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DialogDatabase", menuName = "ScriptableObjects/DialogDatabase", order = 1)]
public class DialogDatabase : ScriptableObject
{
    public List<Dialog> dialogs;
}