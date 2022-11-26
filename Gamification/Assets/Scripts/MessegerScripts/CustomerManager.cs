using UnityEngine;

public class CustomerManager : MonoBehaviour
{
    [SerializeField] private GameObject _messenger;

    private const int _numberOfCustomers = 3;
    private GameObject[] _contactTextWindows = new GameObject[_numberOfCustomers];
    private GameObject[] _contacts = new GameObject[_numberOfCustomers];
    private GameObject[] _contactsActive = new GameObject[_numberOfCustomers];
    private GameObject[] _contactsUnActive = new GameObject[_numberOfCustomers];
    private GameObject[] _scrollRects = new GameObject[_numberOfCustomers];
    private void Awake()
    {
        // Получаем все контакты.
        for (int i = 0; i < _numberOfCustomers; i++)
        {
            _contacts[i] = transform.GetChild(0).GetChild(0).GetChild(i).gameObject;
            _contactsActive[i] = _contacts[i].transform.GetChild(0).gameObject;
            _contactsUnActive[i] = _contacts[i].transform.GetChild(1).gameObject;
        }

        // Получаем все текстовые окна.
        int z = 0;
        for (int i = 7; i < _numberOfCustomers + 7; i++)
        {
            _contactTextWindows[z] = _messenger.transform.GetChild(i).gameObject;
            z++;
        }
        // Получаем все ScrollRect.
        z = 0;
        for (int i = 10; i < _numberOfCustomers + 10; i++)
        {
            _scrollRects[z] = _messenger.transform.GetChild(i).gameObject;
            z++;
        }
    }
    public void SetActiveCustomer1()
    {
        for (int i = 1; i < _numberOfCustomers; i++)
        {
            _contactsActive[i].gameObject.SetActive(false);
            _contactsUnActive[i].gameObject.SetActive(true);
            _contactTextWindows[i].gameObject.SetActive(false);
            _scrollRects[i].gameObject.SetActive(false);
        }
        _contactsActive[0].SetActive(true);
        _contactsUnActive[0].SetActive(false);
        _contactTextWindows[0].SetActive(true);
        _scrollRects[0].gameObject.SetActive(true);
    }
    public void SetActiveCustomer2()
    {
        for (int i = 0; i < _numberOfCustomers; i++)
        {
            _contactsActive[i].gameObject.SetActive(false);
            _contactsUnActive[i].gameObject.SetActive(true);
            _contactTextWindows[i].gameObject.SetActive(false);
            _scrollRects[i].gameObject.SetActive(false);
        }
        _contactsActive[1].SetActive(true);
        _contactsUnActive[1].SetActive(false);
        _contactTextWindows[1].SetActive(true);
        _scrollRects[1].gameObject.SetActive(true);
    }
    public void SetActiveCustomer3()
    {
        for (int i = 0; i < _numberOfCustomers; i++)
        {
            _contactsActive[i].gameObject.SetActive(false);
            _contactsUnActive[i].gameObject.SetActive(true);
            _contactTextWindows[i].gameObject.SetActive(false);
            _scrollRects[i].gameObject.SetActive(false);
        }
        _contactsActive[2].SetActive(true);
        _contactsUnActive[2].SetActive(false);
        _contactTextWindows[2].SetActive(true);
        _scrollRects[2].gameObject.SetActive(true);
    }
}
