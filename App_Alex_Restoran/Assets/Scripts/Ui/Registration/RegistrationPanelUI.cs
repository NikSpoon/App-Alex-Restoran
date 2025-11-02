using UnityEngine;

public class RegistrationPanelUI : MonoBehaviour
{
    public void OnExit()
    {
        if (gameObject.activeSelf)
        {
            gameObject.SetActive(false);
        }
    }
}
