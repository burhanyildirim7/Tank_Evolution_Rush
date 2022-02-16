using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvreDuzenleme : MonoBehaviour
{


    [SerializeField] private GameObject _birinciEvre;
    [SerializeField] private GameObject _ikinciEvre;
    [SerializeField] private GameObject _ucuncuEvre;
    [SerializeField] private GameObject _dorduncuEvre;
    [SerializeField] private GameObject _besinciEvre;
    [SerializeField] private GameObject _altinciEvre;


    void Start()
    {
        _ikinciEvre.SetActive(false);
        _ucuncuEvre.SetActive(false);
        _dorduncuEvre.SetActive(false);
        _besinciEvre.SetActive(false);
        _altinciEvre.SetActive(false);
        _birinciEvre.SetActive(true);
    }


    void Update()
    {
        if (PlayerController.instance._year < 500)
        {
            _ikinciEvre.SetActive(false);
            _ucuncuEvre.SetActive(false);
            _dorduncuEvre.SetActive(false);
            _besinciEvre.SetActive(false);
            _altinciEvre.SetActive(false);
            _birinciEvre.SetActive(true);
        }
        else if (PlayerController.instance._year >= 500 && PlayerController.instance._year < 1000)
        {
            _birinciEvre.SetActive(false);
            _ucuncuEvre.SetActive(false);
            _dorduncuEvre.SetActive(false);
            _besinciEvre.SetActive(false);
            _altinciEvre.SetActive(false);
            _ikinciEvre.SetActive(true);
        }
        else if (PlayerController.instance._year >= 1000 && PlayerController.instance._year < 1500)
        {
            _ikinciEvre.SetActive(false);
            _birinciEvre.SetActive(false);
            _dorduncuEvre.SetActive(false);
            _besinciEvre.SetActive(false);
            _altinciEvre.SetActive(false);
            _ucuncuEvre.SetActive(true);
        }
        else if (PlayerController.instance._year >= 1500 && PlayerController.instance._year < 2000)
        {
            _ikinciEvre.SetActive(false);
            _ucuncuEvre.SetActive(false);
            _birinciEvre.SetActive(false);
            _besinciEvre.SetActive(false);
            _altinciEvre.SetActive(false);
            _dorduncuEvre.SetActive(true);
        }
        else if (PlayerController.instance._year >= 2000 && PlayerController.instance._year < 2500)
        {
            _ikinciEvre.SetActive(false);
            _ucuncuEvre.SetActive(false);
            _dorduncuEvre.SetActive(false);
            _birinciEvre.SetActive(false);
            _altinciEvre.SetActive(false);
            _besinciEvre.SetActive(true);
        }
        else if (PlayerController.instance._year >= 2500)
        {
            _ikinciEvre.SetActive(false);
            _ucuncuEvre.SetActive(false);
            _dorduncuEvre.SetActive(false);
            _besinciEvre.SetActive(false);
            _birinciEvre.SetActive(false);
            _altinciEvre.SetActive(true);
        }
        else
        {

        }
    }
}
