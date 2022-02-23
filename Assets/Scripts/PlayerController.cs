using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;
    public int collectibleDegeri;
    public bool xVarMi = true;
    public bool collectibleVarMi = true;

    [SerializeField] private Text _yearText;

    [SerializeField] private List<GameObject> _anaTanklar = new List<GameObject>();
    [SerializeField] private List<GameObject> _birinciEvreDuzen = new List<GameObject>();
    [SerializeField] private List<GameObject> _ikinciEvreDuzen = new List<GameObject>();
    [SerializeField] private List<GameObject> _ucuncuEvreDuzen = new List<GameObject>();
    [SerializeField] private List<GameObject> _dorduncuEvreDuzen = new List<GameObject>();
    [SerializeField] private List<GameObject> _besinciEvreDuzen = new List<GameObject>();
    [SerializeField] private List<GameObject> _altinciEvreDuzen = new List<GameObject>();

    public int _year;

    public int _tankSayisi;

    private float _yearFinish;

    private int _deger;


    private void Awake()
    {
        if (instance == null) instance = this;
        //else Destroy(this);
    }

    void Start()
    {
        StartingEvents();
    }


    private void Update()
    {


        if (_year < 500)
        {
            _anaTanklar[1].SetActive(false);
            _anaTanklar[2].SetActive(false);
            _anaTanklar[3].SetActive(false);
            _anaTanklar[4].SetActive(false);
            _anaTanklar[5].SetActive(false);
            _anaTanklar[0].SetActive(true);

            if (_tankSayisi >= 2 && _tankSayisi < 4)
            {
                _birinciEvreDuzen[0].SetActive(true);
                _birinciEvreDuzen[1].SetActive(true);
            }
            else if (_tankSayisi >= 4)
            {
                _birinciEvreDuzen[0].SetActive(true);
                _birinciEvreDuzen[1].SetActive(true);
                _birinciEvreDuzen[2].SetActive(true);
                _birinciEvreDuzen[3].SetActive(true);
            }
            else
            {
                _birinciEvreDuzen[0].SetActive(false);
                _birinciEvreDuzen[1].SetActive(false);
                _birinciEvreDuzen[2].SetActive(false);
                _birinciEvreDuzen[3].SetActive(false);
            }
        }
        else
        {
            _birinciEvreDuzen[0].SetActive(false);
            _birinciEvreDuzen[1].SetActive(false);
            _birinciEvreDuzen[2].SetActive(false);
            _birinciEvreDuzen[3].SetActive(false);
        }


        if (_year >= 500 && _year < 1000)
        {
            _anaTanklar[0].SetActive(false);
            _anaTanklar[2].SetActive(false);
            _anaTanklar[3].SetActive(false);
            _anaTanklar[4].SetActive(false);
            _anaTanklar[5].SetActive(false);
            _anaTanklar[1].SetActive(true);

            if (_tankSayisi >= 2 && _tankSayisi < 4)
            {
                _ikinciEvreDuzen[0].SetActive(true);
                _ikinciEvreDuzen[1].SetActive(true);
            }
            else if (_tankSayisi >= 4)
            {
                _ikinciEvreDuzen[0].SetActive(true);
                _ikinciEvreDuzen[1].SetActive(true);
                _ikinciEvreDuzen[2].SetActive(true);
                _ikinciEvreDuzen[3].SetActive(true);
            }
            else
            {
                _ikinciEvreDuzen[0].SetActive(false);
                _ikinciEvreDuzen[1].SetActive(false);
                _ikinciEvreDuzen[2].SetActive(false);
                _ikinciEvreDuzen[3].SetActive(false);
            }
        }
        else
        {
            _ikinciEvreDuzen[0].SetActive(false);
            _ikinciEvreDuzen[1].SetActive(false);
            _ikinciEvreDuzen[2].SetActive(false);
            _ikinciEvreDuzen[3].SetActive(false);
        }


        if (_year >= 1000 && _year < 1500)
        {
            _anaTanklar[1].SetActive(false);
            _anaTanklar[0].SetActive(false);
            _anaTanklar[3].SetActive(false);
            _anaTanklar[4].SetActive(false);
            _anaTanklar[5].SetActive(false);
            _anaTanklar[2].SetActive(true);

            if (_tankSayisi >= 2 && _tankSayisi < 4)
            {
                _ucuncuEvreDuzen[0].SetActive(true);
                _ucuncuEvreDuzen[1].SetActive(true);
            }
            else if (_tankSayisi >= 4)
            {
                _ucuncuEvreDuzen[0].SetActive(true);
                _ucuncuEvreDuzen[1].SetActive(true);
                _ucuncuEvreDuzen[2].SetActive(true);
                _ucuncuEvreDuzen[3].SetActive(true);
            }
            else
            {
                _ucuncuEvreDuzen[0].SetActive(false);
                _ucuncuEvreDuzen[1].SetActive(false);
                _ucuncuEvreDuzen[2].SetActive(false);
                _ucuncuEvreDuzen[3].SetActive(false);
            }
        }
        else
        {
            _ucuncuEvreDuzen[0].SetActive(false);
            _ucuncuEvreDuzen[1].SetActive(false);
            _ucuncuEvreDuzen[2].SetActive(false);
            _ucuncuEvreDuzen[3].SetActive(false);
        }


        if (_year >= 1500 && _year < 2000)
        {
            _anaTanklar[1].SetActive(false);
            _anaTanklar[2].SetActive(false);
            _anaTanklar[0].SetActive(false);
            _anaTanklar[4].SetActive(false);
            _anaTanklar[5].SetActive(false);
            _anaTanklar[3].SetActive(true);

            if (_tankSayisi >= 2 && _tankSayisi < 4)
            {
                _dorduncuEvreDuzen[0].SetActive(true);
                _dorduncuEvreDuzen[1].SetActive(true);
            }
            else if (_tankSayisi >= 4)
            {
                _dorduncuEvreDuzen[0].SetActive(true);
                _dorduncuEvreDuzen[1].SetActive(true);
                _dorduncuEvreDuzen[2].SetActive(true);
                _dorduncuEvreDuzen[3].SetActive(true);
            }
            else
            {
                _dorduncuEvreDuzen[0].SetActive(false);
                _dorduncuEvreDuzen[1].SetActive(false);
                _dorduncuEvreDuzen[2].SetActive(false);
                _dorduncuEvreDuzen[3].SetActive(false);
            }
        }
        else
        {
            _dorduncuEvreDuzen[0].SetActive(false);
            _dorduncuEvreDuzen[1].SetActive(false);
            _dorduncuEvreDuzen[2].SetActive(false);
            _dorduncuEvreDuzen[3].SetActive(false);
        }


        if (_year >= 2000 && _year < 2500)
        {
            _anaTanklar[1].SetActive(false);
            _anaTanklar[2].SetActive(false);
            _anaTanklar[3].SetActive(false);
            _anaTanklar[0].SetActive(false);
            _anaTanklar[5].SetActive(false);
            _anaTanklar[4].SetActive(true);

            if (_tankSayisi >= 2 && _tankSayisi < 4)
            {
                _besinciEvreDuzen[0].SetActive(true);
                _besinciEvreDuzen[1].SetActive(true);
            }
            else if (_tankSayisi >= 4)
            {
                _besinciEvreDuzen[0].SetActive(true);
                _besinciEvreDuzen[1].SetActive(true);
                _besinciEvreDuzen[2].SetActive(true);
                _besinciEvreDuzen[3].SetActive(true);
            }
            else
            {
                _besinciEvreDuzen[0].SetActive(false);
                _besinciEvreDuzen[1].SetActive(false);
                _besinciEvreDuzen[2].SetActive(false);
                _besinciEvreDuzen[3].SetActive(false);
            }
        }
        else
        {
            _besinciEvreDuzen[0].SetActive(false);
            _besinciEvreDuzen[1].SetActive(false);
            _besinciEvreDuzen[2].SetActive(false);
            _besinciEvreDuzen[3].SetActive(false);
        }


        if (_year >= 2500)
        {
            _anaTanklar[1].SetActive(false);
            _anaTanklar[2].SetActive(false);
            _anaTanklar[3].SetActive(false);
            _anaTanklar[4].SetActive(false);
            _anaTanklar[0].SetActive(false);
            _anaTanklar[5].SetActive(true);

            if (_tankSayisi >= 2 && _tankSayisi < 4)
            {
                _altinciEvreDuzen[0].SetActive(true);
                _altinciEvreDuzen[1].SetActive(true);
            }
            else if (_tankSayisi >= 4)
            {
                _altinciEvreDuzen[0].SetActive(true);
                _altinciEvreDuzen[1].SetActive(true);
                _altinciEvreDuzen[2].SetActive(true);
                _altinciEvreDuzen[3].SetActive(true);
            }
            else
            {
                _altinciEvreDuzen[0].SetActive(false);
                _altinciEvreDuzen[1].SetActive(false);
                _altinciEvreDuzen[2].SetActive(false);
                _altinciEvreDuzen[3].SetActive(false);
            }
        }
        else
        {
            _altinciEvreDuzen[0].SetActive(false);
            _altinciEvreDuzen[1].SetActive(false);
            _altinciEvreDuzen[2].SetActive(false);
            _altinciEvreDuzen[3].SetActive(false);
        }

        /*

        if (GameController.instance.isFinish == true && _year != 0)
        {

            _yearFinish -= Time.deltaTime;
            _year = (int)_yearFinish;
            _yearText.text = _year.ToString();
        }
        else
        {

        }
        */

    }

    /// <summary>
    /// Playerin collider olaylari.. collectible, engel veya finish noktasi icin. Burasi artirilabilir.
    /// elmas icin veya baska herhangi etkilesimler icin tag ekleyerek kontrol dongusune eklenir.
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("collectible"))
        {
            // COLLECTIBLE CARPINCA YAPILACAKLAR...
            GameController.instance.SetScore(collectibleDegeri); // ORNEK KULLANIM detaylar icin ctrl+click yapip fonksiyon aciklamasini oku

        }
        else if (other.CompareTag("engel"))
        {
            // ENGELELRE CARPINCA YAPILACAKLAR....
            GameController.instance.SetScore(-collectibleDegeri); // ORNEK KULLANIM detaylar icin ctrl+click yapip fonksiyon aciklamasini oku
            if (GameController.instance.score < 0) // SKOR SIFIRIN ALTINA DUSTUYSE
            {
                // FAİL EVENTLERİ BURAYA YAZILACAK..
                GameController.instance.isContinue = false; // çarptığı anda oyuncunun yerinde durması ilerlememesi için
                Invoke("LoseBaslat", 1f); // Bu fonksiyon direk çağrılada bilir veya herhangi bir effect veya animasyon bitiminde de çağrılabilir..
                                          // oyuncu fail durumunda bu fonksiyon çağrılacak.. 
            }


        }
        else if (other.CompareTag("PozitifKapi"))
        {

            //_year += other.gameObject.GetComponent<KapiScript>()._kapiDegeri;
            //_yearText.text = _year.ToString();

            MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);

            _deger = 0;
            _deger = _year + other.gameObject.GetComponent<KapiScript>()._kapiDegeri;

            GameController.instance.SetScore(collectibleDegeri);

            StartCoroutine(YearArtmaSayac());


        }
        else if (other.CompareTag("NegatifKapi"))
        {

            //_year -= other.gameObject.GetComponent<KapiScript>()._kapiDegeri;
            //_yearText.text = _year.ToString();

            MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);


            _deger = 0;
            _deger = _year - other.gameObject.GetComponent<KapiScript>()._kapiDegeri;

            if (_deger > 0)
            {
                StartCoroutine(YearAzalmaSayac());
            }
            else
            {
                GameController.instance.isContinue = false;
                Invoke("LoseBaslat", 1f);
            }




        }
        else if (other.CompareTag("TankKapisi"))
        {

            MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);

            _tankSayisi += 2;


        }
        else if (other.CompareTag("finish"))
        {
            // finishe collider eklenecek levellerde...
            // FINISH NOKTASINA GELINCE YAPILACAKLAR... Totalscore artırma, x işlemleri, efektler v.s. v.s.

            GameController.instance.isFinish = true;
            transform.localPosition = new Vector3(0, 0, 0);
            StartCoroutine(FinishYearSayac());

            Time.timeScale = 1.5f;
            //_yearFinish = _year;
            //GameController.instance.ScoreCarp(3);  // Bu fonksiyon normalde x ler hesaplandıktan sonra çağrılacak. Parametre olarak x i alıyor. 
            // x değerine göre oyuncunun total scoreunu hesaplıyor.. x li olmayan oyunlarda parametre olarak 1 gönderilecek.
            //UIController.instance.ActivateWinScreen(); // finish noktasına gelebildiyse her türlü win screen aktif edilecek.. ama burada değil..
            // normal de bu kodu x ler hesaplandıktan sonra çağıracağız. Ve bu kod çağrıldığında da kazanılan puanlar animasyonlu şekilde artacak..


        }
        else if (other.CompareTag("X1"))
        {
            if (_year == 0)
            {
                GameController.instance.isContinue = false;
                GameController.instance.ScoreCarp(1);
                Time.timeScale = 1;
                Invoke("WinBaslat", 2f);
            }
            else
            {

            }


        }
        else if (other.CompareTag("X2"))
        {
            if (_year == 0)
            {
                GameController.instance.isContinue = false;
                GameController.instance.ScoreCarp(2);
                Time.timeScale = 1;
                Invoke("WinBaslat", 2f);
            }
            else
            {

            }


        }
        else if (other.CompareTag("X3"))
        {
            if (_year == 0)
            {
                GameController.instance.isContinue = false;
                GameController.instance.ScoreCarp(3);
                Time.timeScale = 1;
                Invoke("WinBaslat", 2f);
            }
            else
            {

            }


        }
        else if (other.CompareTag("X4"))
        {
            if (_year == 0)
            {
                GameController.instance.isContinue = false;
                GameController.instance.ScoreCarp(4);
                Time.timeScale = 1;
                Invoke("WinBaslat", 2f);
            }
            else
            {

            }


        }
        else if (other.CompareTag("X5"))
        {
            if (_year == 0)
            {
                GameController.instance.isContinue = false;
                GameController.instance.ScoreCarp(5);
                Time.timeScale = 1;
                Invoke("WinBaslat", 2f);
            }
            else
            {

            }


        }
        else if (other.CompareTag("X6"))
        {
            if (_year == 0)
            {
                GameController.instance.isContinue = false;
                GameController.instance.ScoreCarp(6);
                Time.timeScale = 1;
                Invoke("WinBaslat", 2f);
            }
            else
            {

            }


        }
        else if (other.CompareTag("X7"))
        {
            if (_year == 0)
            {
                GameController.instance.isContinue = false;
                GameController.instance.ScoreCarp(7);
                Time.timeScale = 1;
                Invoke("WinBaslat", 2f);
            }
            else
            {

            }


        }
        else if (other.CompareTag("X8"))
        {
            if (_year == 0)
            {
                GameController.instance.isContinue = false;
                GameController.instance.ScoreCarp(8);
                Time.timeScale = 1;
                Invoke("WinBaslat", 2f);
            }
            else
            {

            }


        }
        else if (other.CompareTag("X9"))
        {
            if (_year == 0)
            {
                GameController.instance.isContinue = false;
                GameController.instance.ScoreCarp(9);
                Time.timeScale = 1;
                Invoke("WinBaslat", 2f);
            }
            else
            {

            }


        }
        else if (other.CompareTag("X10"))
        {
            _year = 0;
            _yearText.text = _year.ToString();
            GameController.instance.isContinue = false;
            GameController.instance.ScoreCarp(10);
            Time.timeScale = 1;
            Invoke("WinBaslat", 2f);


        }

    }

    private void WinBaslat()
    {
        UIController.instance.ActivateWinScreen();
    }

    private void LoseBaslat()
    {
        UIController.instance.ActivateLooseScreen();
    }

    IEnumerator FinishYearSayac()
    {

        while (_year != 0)
        {
            _year -= 10;
            _yearText.text = _year.ToString();
            yield return new WaitForSeconds(.01f);
        }
    }


    IEnumerator YearArtmaSayac()
    {

        while (_year != _deger)
        {
            _year += 10;
            _yearText.text = _year.ToString();
            yield return new WaitForSeconds(.01f);
        }
    }

    IEnumerator YearAzalmaSayac()
    {

        while (_year != _deger)
        {
            _year -= 10;
            _yearText.text = _year.ToString();
            yield return new WaitForSeconds(.01f);
        }
    }


    /// <summary>
    /// Bu fonksiyon her level baslarken cagrilir. 
    /// </summary>
    public void StartingEvents()
    {

        transform.parent.transform.rotation = Quaternion.Euler(0, 0, 0);
        transform.parent.transform.position = Vector3.zero;
        GameController.instance.isContinue = false;
        GameController.instance.isFinish = false;
        GameController.instance.score = 0;
        transform.position = new Vector3(0, transform.position.y, 0);
        GetComponent<Collider>().enabled = true;

        _tankSayisi = 1;
        _year = 0;
        _yearText.text = _year.ToString();
        StartTankAyarla();

    }

    private void StartTankAyarla()
    {
        _anaTanklar[1].SetActive(false);
        _anaTanklar[2].SetActive(false);
        _anaTanklar[3].SetActive(false);
        _anaTanklar[4].SetActive(false);
        _anaTanklar[5].SetActive(false);
        _anaTanklar[0].SetActive(true);
    }

}
