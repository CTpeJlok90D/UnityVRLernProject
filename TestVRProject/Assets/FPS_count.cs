using UnityEngine;
using TMPro;

public class FPS_count : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private float _updateFrame;

    private float _currentUpdateTime = 0;
    private void Update()
    {
        _currentUpdateTime+= Time.deltaTime;
        if (_currentUpdateTime >= _updateFrame)
        {
            _text.text = ((int)(1 / Time.deltaTime)).ToString();
            _currentUpdateTime = 0;
        }
    }
}
