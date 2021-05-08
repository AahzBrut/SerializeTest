using System;

[Serializable]
public class ItemTagNoiseLevel: ItemTagFloatValue
{
    public float Value => value;

    public ItemTagNoiseLevel(ItemBase parent, float noiseLevel) : base(parent, noiseLevel)
    {
        type = EItemTagType.NoiseLevel;
    }
}