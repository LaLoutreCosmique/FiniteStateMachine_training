using UnityEngine;

namespace States
{
    public sealed class TurnBegin : FSMState<TurnBeginContext>
    {
        public TurnBegin(FSMStateContext ctx, FSM fsm) : base(ctx, fsm)
        {
        }

        public override void OnEnter()
        {
            Debug.Log("ENTERED");
        }
    }
}
