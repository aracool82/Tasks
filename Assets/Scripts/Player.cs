using UnityEngine.Events;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Server _server;

    private IResourceble[] _resorces = { new Gold(), new Oil() ,new Coal()};

    public event UnityAction<IResourceble> ChangeResource;

    private void Start() => ConnectWhithServer();

    private void OnSendResource(IResourceble resource)
    {
        for (int i = 0; i < _resorces.Length; i++)
        {
            if (_resorces[i].Type == resource.Type)
            { 
                _resorces[i].Add(resource.Amount);
                ChangeResource?.Invoke(_resorces[i]);
            }
        }
    }

    public void ConnectWhithServer() => _server.Conected();

    private void OnEnable () => _server.SendResource += OnSendResource;

    private void OnDisable () => _server.SendResource -= OnSendResource;

}
