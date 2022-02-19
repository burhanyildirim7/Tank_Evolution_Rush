using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankScript : MonoBehaviour
{

    [SerializeField] private GameObject _spawnPoint;

    [SerializeField] private GameObject _bullet;

    [SerializeField] private float _atisHizi;

    [SerializeField] private ParticleSystem _atesEtmeEfekt;

    private float _time;

    void Start()
    {

    }


    void Update()
    {
        if (GameController.instance.isContinue == true)
        {
            _time += Time.deltaTime;

            if (_time > _atisHizi)
            {
                _atesEtmeEfekt.Play();
                Instantiate(_bullet, _spawnPoint.transform.position, Quaternion.identity);
                _time = 0;
            }
            else
            {

            }

        }
        else
        {

        }
    }
}
