using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Messanger 
{
    public class MessageManager : MonoBehaviour
    {
        [SerializeField] private GameObject _scrollRectGameObject;
        [SerializeField] private GameObject _playerMessagePrefab;
        [SerializeField] private GameObject _CustomerMessagePrefab;
        [SerializeField] private TMP_InputField _inputField;
        [SerializeField] private int _heightBetweenMessages = 300;

        private List<GameObject> _messages = new List<GameObject>();
        private Vector3 _currentPosition;
        private GameObject _playerTemporaryMessage;
        private GameObject _customerTemporaryMessage;
        private Vector3 _customerMessagePosition = new Vector3(500, 100, 0); // Позиция ответа на сообщения пользователя.
        private void Awake()
        {
            int childCount = _scrollRectGameObject.transform.GetChild(0).GetChild(0).childCount;
            for (int i = 0; i < childCount; i++)
                _messages.Add( _scrollRectGameObject.transform.GetChild(0).GetChild(0).GetChild(i).gameObject );

            _currentPosition = _messages[0].transform.localPosition;

            if ( gameObject.name[0] != '1')
                gameObject.SetActive(false);
        }
        public void EnterMessage()
        {
            if (!gameObject.active)
                return; 
            // Перемещаем все наши сообщения по Y на определённую высоту.
            for (int i = 0; i < _messages.Count; i++)
            {
                _messages[i].transform.localPosition = new Vector3(
                    _messages[i].transform.localPosition.x,
                    _messages[i].transform.localPosition.y + _heightBetweenMessages,
                    _messages[i].transform.localPosition.z);
            }
            // Создаём сообщение пользователя, делаем его ребёнком ScrollRect, перемещаем в нужную нам позицию и добавляем в наши сообщения.
            _playerTemporaryMessage = Instantiate(_playerMessagePrefab);
            _playerTemporaryMessage.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = _inputField.text;
            _playerTemporaryMessage.transform.SetParent(_scrollRectGameObject.transform.GetChild(0).GetChild(0).transform);
            _playerTemporaryMessage.transform.localPosition = _currentPosition;
            _messages.Add(_playerTemporaryMessage);

            // Отвечаем на сообщение пользователя в зависимости от его сообщения. 
            _customerTemporaryMessage = Instantiate(_CustomerMessagePrefab);
            _customerTemporaryMessage.transform.SetParent(_scrollRectGameObject.transform.GetChild(0).GetChild(0).transform);
            _customerTemporaryMessage.transform.localPosition = _currentPosition - _customerMessagePosition;
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

            //Меняем текущую позицию на позицию текущего сообщения пользвателя.
            _currentPosition = _playerTemporaryMessage.transform.localPosition;
        }
    }
}

/*
//_customerTemporaryMessage = Instantiate(_CustomerMessagePrefab);
//_customerTemporaryMessage.transform.position = _currentPosition - _customerMessagePosition;
//_customerTemporaryMessage.transform.SetParent(_scrollRectGameObject.transform.GetChild(0).GetChild(0).transform);
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


//[SerializeField] private Vector3 _messagePosition = new Vector3(930, -250, 0);

//_currentPosition = _messages[0].transform.position;
/*
for (int i = 0; i < _messages.Count; i++)
{
    _messages[i].transform.position = new Vector3(_messages[i].transform.position.x,
        _messages[i].transform.position.y + _heightBetweenMessages,
        _messages[i].transform.position.z);
}
*/
/*
_playerTemporaryMessage = Instantiate(_playerMessagePrefab);
//_playerTemporaryMessage.transform.position = _currentPosition;
_playerTemporaryMessage.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = _inputField.text;
_playerTemporaryMessage.transform.SetParent(_scrollRectGameObject.transform.GetChild(0).GetChild(0).transform);
_playerTemporaryMessage.transform.localPosition = _currentPosition;
_messages.Add(_playerTemporaryMessage);
*/
/*
//_customerTemporaryMessage.transform.position = _currentPosition - _customerMessagePosition;
_customerTemporaryMessage.transform.SetParent(_scrollRectGameObject.transform.GetChild(0).GetChild(0).transform);
_customerTemporaryMessage.transform.localPosition = _currentPosition - _customerMessagePosition;
*/

//_currentPosition = _playerTemporaryMessage.transform.position;