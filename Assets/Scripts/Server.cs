using UnityEngine;
using UnityEngine.Events;

public class Server : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private bool _isWork;
 
    [SerializeField] private ResourceGenerator _generator;
    
    [Range(1f, 5f)]
    [SerializeField] private float _timeSend = 1f;
    private float _time = 0;

    public event UnityAction<IResourceble> SendResource;

    public void Conected() => _isWork = true;

    private void Update()
    {
        if (_isWork == false)
            return;
        else
        {
            _time += Time.deltaTime;
            if (_time >= _timeSend)
            {
                _time = 0;
                var gold =_generator.GetResources(new Gold());
                SendResources(gold);
                var oil = _generator.GetResources(new Oil());
                SendResources(oil);
                var coal = _generator.GetResources(new Coal());
                SendResources(coal);
            }
        }
    }

    private void SendResources(IResourceble resource) => SendResource?.Invoke(resource);
}
