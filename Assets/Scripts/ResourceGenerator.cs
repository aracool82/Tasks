using UnityEngine;

public class ResourceGenerator : MonoBehaviour
{
    [Range (1,5)]
    [SerializeField] private int _minValue = 1;

    [Range(6, 20)]
    [SerializeField] private int _maxValue = 10;

    public IResourceble GetResources(IResourceble resource)
    {
        resource.Add(Random.Range(_minValue, _maxValue));
        return resource;
    }
}
