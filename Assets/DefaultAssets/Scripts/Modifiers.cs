using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Modifier", menuName = "Create New Modifier", order = 1)]
public class Modifiers : ScriptableObject
{
    public string statChanged;
    public int amountChanged;
}
