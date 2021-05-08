using System;
using UnityEngine;

[Serializable]
public abstract class ItemTagFloatValue : ItemTag
{
    [SerializeField] protected float value; 

    protected ItemTagFloatValue(ItemBase parent, float value) : base(parent)
    {
        this.value = value;
    }
}