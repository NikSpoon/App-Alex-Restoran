using Fsm.AppUI;
using UnityEngine;
class UIController : MonoBehaviour
{
    [SerializeField] private Transform _root;

    [SerializeField] private GameObject _loaderPanel;
    [SerializeField] private GameObject _adminPanel;
    [SerializeField] private GameObject _staffPanel;
    [SerializeField] private GameObject _manegerPanel;

    [SerializeField] private GameObject _mainPanel;
    [SerializeField] private GameObject _infoTabPanel;
    [SerializeField] private GameObject _dishesPanel;
    [SerializeField] private GameObject _hookahPanel;
    [SerializeField] private GameObject _reservationPanel;
    [SerializeField] private GameObject _newsPanel;

    private GameObject _currentScren;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

        if (FindObjectsByType<UIController>(FindObjectsSortMode.None).Length > 1)
        {
            Destroy(gameObject);
            return;
        }
       
    }
    private void Start()
    {
        var appSystem = Context.Instance.AppUISystem;
        Context.Instance.AppUISystem.OnStateChange += OnStateChange;

        _currentScren = Instantiate(_loaderPanel,_root);
    }
    private void OnStateChange(StateChangeData<AppState, AppTriger> data)
    {
        if (_currentScren != null)
        {
            Destroy(_currentScren);
        }
        switch (data.NewState)
        {
            case AppState.MainPanel:        _currentScren = Instantiate(_mainPanel, _root);        break;
            case AppState.DishesPanel:      _currentScren = Instantiate(_dishesPanel, _root);      break;
            case AppState.HookahPanel:      _currentScren = Instantiate(_hookahPanel, _root);      break;
            case AppState.NewsPanel:        _currentScren = Instantiate(_newsPanel, _root);        break;
            case AppState.ReservationPanel: _currentScren = Instantiate(_reservationPanel, _root); break;
            case AppState.InfoTabPanel:     _currentScren = Instantiate(_infoTabPanel, _root);     break;
            case AppState.StaffPanel:       _currentScren = Instantiate(_staffPanel, _root);       break;
            case AppState.ManagerPanel:     _currentScren = Instantiate(_manegerPanel, _root);     break;
            case AppState.AdminPanel:       _currentScren = Instantiate(_adminPanel, _root);       break;
        }
    }
}