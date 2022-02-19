using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    [SerializeField] private float _speed;

    void Start()
    {
        Destroy(gameObject, 2f);
    }


    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * _speed);
    }
}
