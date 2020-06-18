using UnityEngine;
using TMPro;

public class Display : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TypeResource _type;
    [SerializeField] private TMP_Text _text;
    
    private void OnChangeResource(IResourceble resource)
    {
        if (_type == resource.Type)
            _text.text = resource.Type.ToString() + ": " + resource.Amount.ToString();
    }

    private void OnEnable()
    {
        _player.ChangeResource += OnChangeResource;
    }

    private void OnDisable()
    {
        _player.ChangeResource += OnChangeResource;
    }
}
