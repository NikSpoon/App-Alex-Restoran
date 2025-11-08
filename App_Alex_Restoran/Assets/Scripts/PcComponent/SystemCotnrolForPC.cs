using UnityEngine;

public class SystemCotnrolForPC : MonoBehaviour
{
    [SerializeField] private InputSystem _inputSystem;
    private void Update()
    {
        if (_inputSystem.AdminPanel)
        {
            Context.Instance.AppUISystem.Trigger(Fsm.AppUI.AppTriger.ToAdminPanel);
        }
        if (_inputSystem.StaffPanel)
        {
            Context.Instance.AppUISystem.Trigger(Fsm.AppUI.AppTriger.ToStaffPanel);
        }
        if (_inputSystem.ManagerPanel)
        {
            Context.Instance.AppUISystem.Trigger(Fsm.AppUI.AppTriger.ToManagerPanel);
        }


        if (_inputSystem.MainPanel)
        {
            Context.Instance.AppUISystem.Trigger(Fsm.AppUI.AppTriger.ToMainPanel);
        }
        if (_inputSystem.DishesPanel)
        {
            Context.Instance.AppUISystem.Trigger(Fsm.AppUI.AppTriger.ToDishesPanel);
        }
        if (_inputSystem.HookahPanel)
        {
            Context.Instance.AppUISystem.Trigger(Fsm.AppUI.AppTriger.ToHookahPanel);
        }
        if (_inputSystem.InfoTabPanel)
        {
            Context.Instance.AppUISystem.Trigger(Fsm.AppUI.AppTriger.ToInfoTabPanel);
        }
        if (_inputSystem.NewsPanel)
        {
            Context.Instance.AppUISystem.Trigger(Fsm.AppUI.AppTriger.ToNewsPanel);
        }
        if (_inputSystem.ReservationPanel)
        {
            Context.Instance.AppUISystem.Trigger(Fsm.AppUI.AppTriger.ToReservationPanel);
        }
    }
}
