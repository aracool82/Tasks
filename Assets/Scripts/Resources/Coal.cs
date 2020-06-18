using System;

[Serializable]
public class Coal : IResourceble
{
    private int _amount;
    private TypeResource _type = TypeResource.Coal;

    public int Amount => _amount;
    public TypeResource Type => _type;

    public void Add(int amount) => _amount += amount;
}
