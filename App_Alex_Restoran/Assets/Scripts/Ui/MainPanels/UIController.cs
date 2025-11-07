using System.Collections;
using UnityEngine;


class UIController : MonoBehaviour
{
    [SerializeField] private GameObject _root;

    [SerializeField] private GameObject _adminPanel;
    [SerializeField] private GameObject _staffPanel;
    [SerializeField] private GameObject _manegerPanel;
    
    [SerializeField] private GameObject _mainPanel;
    [SerializeField] private GameObject _infoTabPanel;
    [SerializeField] private GameObject _dishesPanel;
    [SerializeField] private GameObject _hookahPanel;
    [SerializeField] private GameObject _reservationPanel;
    [SerializeField] private GameObject _newsPanel;

    private GameObject _activePanel;

    private void Awake()
    {
        Instantiate(_mainPanel, _root.transform);
        _activePanel = _mainPanel;
        _activePanel.SetActive(true);
    }
    private void OpenPanel(GameObject nextPanel)
    {
        if (nextPanel!= null && nextPanel.scene.IsValid())
        {
            nextPanel.SetActive(true);
        }
        else
        {
            Instantiate(nextPanel, _root.transform);
        }
        _activePanel.SetActive(false);
        _activePanel = nextPanel;
        _activePanel.SetActive(true);
    }
    private void Update()
    {
        foreach (KeyCode key in System.Enum.GetValues(typeof(KeyCode)))
        {
            if (Input.GetKeyDown(key))
            {
                switch (key)
                {
                    case KeyCode.Alpha1:
                    case KeyCode.Keypad1:
                        Debug.Log("_adminPanel");
                        OpenPanel(_adminPanel);
                        break;

                    case KeyCode.Alpha2:
                    case KeyCode.Keypad2:
                        OpenPanel(_staffPanel);
                        Debug.Log("_staffPanel");
                        break;

                    case KeyCode.Alpha3:
                    case KeyCode.Keypad3:
                        OpenPanel(_manegerPanel);
                        Debug.Log("_manegerPanel");
                        break;

                    case KeyCode.Alpha4:
                    case KeyCode.Keypad4:
                        OpenPanel(_mainPanel);
                        Debug.Log("_mainPanel");
                        break;

                    case KeyCode.Alpha5:
                    case KeyCode.Keypad5:
                        OpenPanel(_infoTabPanel);
                        Debug.Log("_infoTabPanel");
                        break;

                    case KeyCode.Alpha6:
                    case KeyCode.Keypad6:
                        OpenPanel(_dishesPanel);
                        Debug.Log("_dishesPanel");
                        break;

                    case KeyCode.Alpha7:
                    case KeyCode.Keypad7:
                        OpenPanel(_hookahPanel);
                        Debug.Log("_hookahPanel");
                        break;

                    case KeyCode.Alpha8:
                    case KeyCode.Keypad8:
                        OpenPanel(_reservationPanel);
                        Debug.Log("_reservationPanel");
                        break;

                    case KeyCode.Alpha9:
                    case KeyCode.Keypad9:
                        OpenPanel(_newsPanel);
                        Debug.Log("_newsPanel");
                        break;

                    default:
                        break;
                }
            }
        }
    }

}
