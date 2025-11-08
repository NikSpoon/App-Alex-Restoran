
using System;

namespace Fsm.AppUI
{
    public interface IAppSystem
    {
        AppState CurrentState { get; }
        void Trigger(AppTriger trigger);
        event Action<StateChangeData<AppState, AppTriger>> OnStateChange;
    }

    class AppUISystem : IAppSystem
    {
        private FSM<AppState, AppTriger> _stateMashine;
        public AppState CurrentState => _stateMashine.CurrentState;

        event Action<StateChangeData<AppState, AppTriger>> IAppSystem.OnStateChange
        {
            add => _stateMashine.OnStateChange += value;
            remove => _stateMashine.OnStateChange -= value;
        }
    

        public AppUISystem()
        {
            _stateMashine = new FSM<AppState, AppTriger>(AppState.Loading);

            _stateMashine.AddTransition(AppState.Loading, AppTriger.ToMainPanel, AppState.MainPanel);

            _stateMashine.AddTransition(AppState.MainPanel, AppTriger.ToAdminPanel , AppState.AdminPanel);
            _stateMashine.AddTransition(AppState.MainPanel, AppTriger.ToManagerPanel , AppState.ManagerPanel);
            _stateMashine.AddTransition(AppState.MainPanel, AppTriger.ToStaffPanel , AppState.StaffPanel);
        
            _stateMashine.AddTransition(AppState.MainPanel, AppTriger.ToInfoTabPanel , AppState.InfoTabPanel);
            _stateMashine.AddTransition(AppState.MainPanel, AppTriger.ToDishesPanel, AppState.DishesPanel);
            _stateMashine.AddTransition(AppState.MainPanel, AppTriger.ToHookahPanel, AppState.HookahPanel);
            _stateMashine.AddTransition(AppState.MainPanel, AppTriger.ToNewsPanel, AppState.NewsPanel);
            _stateMashine.AddTransition(AppState.MainPanel, AppTriger.ToReservationPanel, AppState.ReservationPanel);

            _stateMashine.AddTransition(AppState.AdminPanel, AppTriger.ToMainPanel, AppState.MainPanel);

            _stateMashine.AddTransition(AppState.ManagerPanel, AppTriger.ToMainPanel, AppState.MainPanel);
           
            _stateMashine.AddTransition(AppState.StaffPanel, AppTriger.ToMainPanel, AppState.MainPanel);


            _stateMashine.AddTransition(AppState.InfoTabPanel, AppTriger.ToMainPanel, AppState.MainPanel);
            _stateMashine.AddTransition(AppState.InfoTabPanel, AppTriger.ToDishesPanel, AppState.DishesPanel);
            _stateMashine.AddTransition(AppState.InfoTabPanel, AppTriger.ToHookahPanel, AppState.HookahPanel);
            _stateMashine.AddTransition(AppState.InfoTabPanel, AppTriger.ToNewsPanel, AppState.NewsPanel);
            _stateMashine.AddTransition(AppState.InfoTabPanel, AppTriger.ToReservationPanel, AppState.ReservationPanel);

            _stateMashine.AddTransition(AppState.DishesPanel, AppTriger.ToMainPanel, AppState.MainPanel);
            _stateMashine.AddTransition(AppState.DishesPanel, AppTriger.ToInfoTabPanel, AppState.InfoTabPanel);
            _stateMashine.AddTransition(AppState.DishesPanel, AppTriger.ToHookahPanel, AppState.HookahPanel);
            _stateMashine.AddTransition(AppState.DishesPanel, AppTriger.ToNewsPanel, AppState.NewsPanel);
            _stateMashine.AddTransition(AppState.DishesPanel, AppTriger.ToReservationPanel, AppState.ReservationPanel);

            _stateMashine.AddTransition(AppState.HookahPanel, AppTriger.ToMainPanel, AppState.MainPanel);
            _stateMashine.AddTransition(AppState.HookahPanel, AppTriger.ToDishesPanel, AppState.DishesPanel);
            _stateMashine.AddTransition(AppState.HookahPanel, AppTriger.ToInfoTabPanel, AppState.InfoTabPanel);
            _stateMashine.AddTransition(AppState.HookahPanel, AppTriger.ToNewsPanel, AppState.NewsPanel);
            _stateMashine.AddTransition(AppState.HookahPanel, AppTriger.ToReservationPanel, AppState.ReservationPanel);

            _stateMashine.AddTransition(AppState.NewsPanel, AppTriger.ToMainPanel, AppState.MainPanel);
            _stateMashine.AddTransition(AppState.NewsPanel, AppTriger.ToDishesPanel, AppState.DishesPanel);
            _stateMashine.AddTransition(AppState.NewsPanel, AppTriger.ToHookahPanel, AppState.HookahPanel);
            _stateMashine.AddTransition(AppState.NewsPanel, AppTriger.ToInfoTabPanel, AppState.InfoTabPanel);
            _stateMashine.AddTransition(AppState.NewsPanel, AppTriger.ToReservationPanel, AppState.ReservationPanel);

            _stateMashine.AddTransition(AppState.ReservationPanel, AppTriger.ToMainPanel, AppState.MainPanel);
            _stateMashine.AddTransition(AppState.ReservationPanel, AppTriger.ToDishesPanel, AppState.DishesPanel);
            _stateMashine.AddTransition(AppState.ReservationPanel, AppTriger.ToHookahPanel, AppState.HookahPanel);
            _stateMashine.AddTransition(AppState.ReservationPanel, AppTriger.ToNewsPanel, AppState.NewsPanel);
            _stateMashine.AddTransition(AppState.ReservationPanel, AppTriger.ToInfoTabPanel, AppState.InfoTabPanel);
        }
        
        public void Trigger(AppTriger trigger)
        {
            _stateMashine.SetTrigger(trigger);
        }

    }

    public enum AppState
    {
        Loading,
        AdminPanel,
        DishesPanel,
        HookahPanel,
        InfoTabPanel,
        MainPanel,
        ManagerPanel,
        NewsPanel,
        ReservationPanel,
        StaffPanel
    }

    public enum AppTriger
    {
        ToAdminPanel,
        ToDishesPanel,
        ToHookahPanel,
        ToInfoTabPanel,
        ToMainPanel,
        ToManagerPanel,
        ToNewsPanel,
        ToReservationPanel,
        ToStaffPanel
    }
}

