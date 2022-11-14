using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSprite : MonoBehaviour
{
    #region Variables
    [SerializeField]
    Transform _objectToCircle;

    [SerializeField]
    float _speed;
    #endregion

    #region Mono
    void Start()
    {
        
    }

    void Update()
    {
        transform.RotateAround(_objectToCircle.position, Vector3.back, 1 * _speed);
    }
    #endregion
    
}
