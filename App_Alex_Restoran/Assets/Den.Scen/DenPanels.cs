using UnityEngine;

public class DenPanels : MonoBehaviour
{
    [SerializeField] private GameObject _settingPanel;
    public void OpenSetting()
    {
       _settingPanel.SetActive(true);
    }
}
