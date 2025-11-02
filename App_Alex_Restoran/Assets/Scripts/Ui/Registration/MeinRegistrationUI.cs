using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MeinRegistrationUI : MonoBehaviour
{
    [SerializeField] private GameObject _registrationPanel;

    [SerializeField] private TMP_InputField _loginText;
    [SerializeField] private TMP_InputField _passwordText;

    private string _login;
    private string _password;

    private void Awake()
    {
        _registrationPanel.SetActive(false);
    }
    private void Start()
    {
        
    }
    public void OnEnter()
    {
        if (CheckLoginInfo()== true)
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            OnRegistration();
        }
        
    }

    public void OnRegistration()
    {
        _registrationPanel.SetActive(true);
    }
    public void OnExit()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    private bool CheckLoginInfo()
    {
        _login = _loginText.text;
        _password = _passwordText.text;

        return true;
    }
}
