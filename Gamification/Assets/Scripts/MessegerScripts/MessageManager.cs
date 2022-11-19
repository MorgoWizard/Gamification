using System.Collections.Generic;
using UnityEngine;
using TMPro;
namespace Messanger 
{
public class MessageManager : MonoBehaviour
{
    [SerializeField] private GameObject _messagesCustomer1;
    [SerializeField] private GameObject _playerMessagePrefab;
    [SerializeField] private GameObject _CustomerMessagePrefab;
    [SerializeField] private TMP_InputField _inputField;
    [SerializeField] private int _height = 300;
    [SerializeField] private Vector3 _customerMessagePosition = Vector3.zero;
    [SerializeField] private Vector3 _messagePosition = new Vector3(930, -250, 0);

    private List<GameObject> _messages = new List<GameObject>();
    private Vector3 _currentPosition;
    private GameObject _playerTemporaryMessage;
    private GameObject _customerTemporaryMessage;
    private void Start()
    {
        int childCount = _messagesCustomer1.transform.GetChild(0).GetChild(0).childCount;
        for (int i = 0; i < childCount; i++)
            _messages.Add( _messagesCustomer1.transform.GetChild(0).GetChild(0).GetChild(i).gameObject );

        _currentPosition = _messages[0].transform.position;
    }
    public void EnterMessage()
    {
        for (int i = 0; i < _messages.Count; i++)
        {
            _messages[i].transform.position = new Vector3(_messages[i].transform.position.x,
                _messages[i].transform.position.y + _height,
                _messages[i].transform.position.z);
        }
        _playerTemporaryMessage = Instantiate(_playerMessagePrefab);
        _playerTemporaryMessage.transform.position = _currentPosition;
        _playerTemporaryMessage.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = _inputField.text;
        _playerTemporaryMessage.transform.SetParent(_messagesCustomer1.transform.GetChild(0).GetChild(0).transform);
        _messages.Add(_playerTemporaryMessage);


            _customerTemporaryMessage = Instantiate(_CustomerMessagePrefab);
            _customerTemporaryMessage.transform.position = _currentPosition - _customerMessagePosition;
            _customerTemporaryMessage.transform.SetParent(_messagesCustomer1.transform.GetChild(0).GetChild(0).transform);
            switch (_inputField.text)
            {
                case "Сколько стоит":
                    _customerTemporaryMessage.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "500";
                    break;
                case "1":
                    _customerTemporaryMessage.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "...";
                    break;
                default:
                    _customerTemporaryMessage.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Я не понимаю";
                    break;
            }

            _messages.Add(_customerTemporaryMessage);

            _currentPosition = _playerTemporaryMessage.transform.position;
    }
}
}

/*
//_customerTemporaryMessage = Instantiate(_CustomerMessagePrefab);
//_customerTemporaryMessage.transform.position = _currentPosition - _customerMessagePosition;
//_customerTemporaryMessage.transform.SetParent(_messagesCustomer1.transform.GetChild(0).GetChild(0).transform);
_customerTemporaryMessage.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "I do not understand!";
//_messages.Add(_customerTemporaryMessage);
*/

/*
if (_inputField.text == "1")
{
    _customerTemporaryMessage.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Yes";
}
else
{
    _customerTemporaryMessage.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "I do not understand!";
}
*/