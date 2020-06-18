
public interface IResourceble 
{
    TypeResource Type {get;}
    int Amount {get;}
    void Add(int amount);
}

public enum TypeResource 
{
    Gold,
    Oil,
    Coal
}

