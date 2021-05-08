using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Databases/ItemsDatabase", fileName = "ItemsDatabase")]
public class DataBase : ScriptableObject
{
    [SerializeReference] public List<ItemTag> tags = new List<ItemTag>
    {
        new ItemTagNoiseLevel(new ItemBase("Item 1"), 12f),
        new ItemTagDifficultyClass(new ItemBase("Item 2"), 03f)
    };

    public string dbName = "Test Database";
}