using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zero_AnimateEyes : MonoBehaviour
{
    public MeshRenderer meshRenderer;

    private Renderer _renderer;
    private Material _eyeMaterial;

    private float _Xoffset;
    private float _Yoffset;

    private Vector2 _blinkVector = new Vector2(0.21f, -0.145f);
    private Vector2 _angryVector = new Vector2(-0.226f, -0.17f);
    private Vector2 _excitedVector = new Vector2(-0.47f, -0.17f);
    private Vector2 _confusedVector = new Vector2(0,0);

    private float _counter = 0f;

    private float _randomBlinkCounterStart;
    private float _randomBlinkCounterEnd;


    private void Start()
    {
        _renderer = GetComponent<Renderer>();
        _eyeMaterial = _renderer.material;

        //_Xoffset = _eyeMaterial.mainTextureOffset.x;
        //_Yoffset = _eyeMaterial.mainTextureOffset.y;

        ChangeOffset();
    }

    private void Update()
    {
        _counter += Time.deltaTime;

        if(_counter > _randomBlinkCounterStart && _counter < _randomBlinkCounterEnd)
        {
            _eyeMaterial.mainTextureOffset = _blinkVector;
        }
        else
        {
            _eyeMaterial.mainTextureOffset = _confusedVector;
        }

        if(_counter > _randomBlinkCounterEnd)
        {
            _counter = 0;
            ChangeOffset();
        }


    }

    private void ChangeOffset()
    {
        // _eyeMaterial.SetTextureOffset("", new Vector2(0,0));
        //_eyeMaterial.mainTextureOffset = new Vector2(0.21f, -0.145f);

        _randomBlinkCounterStart = Random.Range(1f, 3f);
        _randomBlinkCounterEnd = _randomBlinkCounterStart + 0.4f;


    }
}
