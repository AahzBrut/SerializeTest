using System;
using UnityEngine;

[Serializable]
public class ItemTagDifficultyClass : ItemTagFloatValue
{
    [SerializeField] private string diffClass = "Very hard";
    
    public ItemTagDifficultyClass(ItemBase parent, float value) : base(parent, value)
    {
        type = EItemTagType.DifficultyClass;
    }
}