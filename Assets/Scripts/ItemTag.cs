using System;
using UnityEngine;

[Serializable]
public abstract class ItemTag
{
    [SerializeField] protected EItemTagType type = EItemTagType.None;
    [SerializeField] private ItemBase parent;

    protected ItemTag(ItemBase parent)
    {
        this.parent = parent;
    }

    public EItemTagType GetTagType()
    {
        return type;
    }

    public ItemBase GetParent()
    {
        return parent;
    }
}
