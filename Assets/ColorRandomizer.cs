using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorRandomizer : MonoBehaviour
{
    public Text Text;
    public float _duration = 1;
    private float _delta = 0;
    private Color _color1;
    private Color _color2;


    private void Start()
    {
        _color1 = Random.ColorHSV();
        _color2 = Random.ColorHSV();
    }

    private void Update()
    {
        _delta += Time.deltaTime;

        if(_delta > _duration)
        {
            _color1 = Random.ColorHSV();
            _color2 = Random.ColorHSV();
            _delta = 0;
        }

        Text.color = Color.Lerp(_color1, _color2, Mathf.PingPong(Time.unscaledTime, _duration));
    }
}
