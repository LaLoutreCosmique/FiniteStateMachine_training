using System.Collections;
using UnityEngine;

public class FSM
{
    IFSMState _currentState;
    readonly MonoBehaviour _monoBehaviour;

    public FSM(MonoBehaviour monoBehaviour)
    {
        _monoBehaviour = monoBehaviour;
    }

    public void SetState(IFSMState state)
    {
        _monoBehaviour.StartCoroutine(ChangeState(state));
    }

    IEnumerator ChangeState(IFSMState state)
    {
        if (_currentState != state)
        {
            _currentState?.OnExit();
            _currentState = state;
            _currentState.OnEnter();

            yield return null;
        }
    }
}
