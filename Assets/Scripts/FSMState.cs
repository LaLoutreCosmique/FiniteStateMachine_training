public abstract class FSMState<T> : IFSMState where T : FSMStateContext
{
    FSMStateContext _ctx;
    FSM _fsm;
    
    public virtual void OnEnter()
    {
    }

    public virtual void OnExit()
    {
        
    }

    public FSMState(FSMStateContext ctx, FSM fsm)
    {
        _ctx = ctx;
        _fsm = fsm;
    }
}
