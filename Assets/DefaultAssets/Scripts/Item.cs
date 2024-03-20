using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Create New Item", order = 0)]
public class Item : ScriptableObject
{
    //Key variables for each item
    public string itemName;
    public Sprite itemImage;
    public float modifier;

    // Figuring out how to do the UI thing i want 
    //[SerializeField] Modifiables mods = new Modifiables();

    [SerializeField] public List<Modifiables> baens;
}

public enum Modifiables
{
    Beans,
    Carrots, 
    Potatoes
};
