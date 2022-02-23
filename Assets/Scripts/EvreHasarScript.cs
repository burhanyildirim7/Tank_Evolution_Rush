using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EvreHasarScript : MonoBehaviour
{

    [SerializeField] private ParticleSystem _hitParticle;
    [SerializeField] private ParticleSystem _destroyParticle;

    [SerializeField] private Slider _slider;

    private int _hitSayisi;


    void Start()
    {
        _hitSayisi = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {

            if (_hitSayisi > 3)
            {
                gameObject.GetComponent<BoxCollider>().enabled = false;

                _destroyParticle.Play();

                MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);

                Invoke("ObjeKapat", 0.5f);
            }
            else
            {
                _hitParticle.Play();

                _hitSayisi++;

                _slider.value = 3 - _hitSayisi;

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
