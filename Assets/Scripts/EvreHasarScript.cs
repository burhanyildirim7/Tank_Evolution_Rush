using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvreHasarScript : MonoBehaviour
{

    [SerializeField] private ParticleSystem _hitParticle;
    [SerializeField] private ParticleSystem _destroyParticle;

    private int _hitSayisi;


    void Start()
    {
        _hitSayisi = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {

            if (_hitSayisi > 5)
            {
                _destroyParticle.Play();

                Invoke("ObjeKapat", 0.5f);
            }
            else
            {
                _hitParticle.Play();

                _hitSayisi++;

                Destroy(other.gameObject);
            }

        }
        else
        {

        }
    }

    private void ObjeKapat()
    {
        //gameObject.SetActive(false);

        transform.parent.transform.position = new Vector3(0, 2500, 0);
    }
}
