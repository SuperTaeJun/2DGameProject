using Unity.VisualScripting;
using UnityEngine;

public class PlayerState
{
    protected Player _player;
    protected string _animBoolName;
    protected PlayerStateMachine _playerStateMachine;
    public PlayerState(Player player, PlayerStateMachine playerStateMachine, string animBoolName)
    {
        _player = player;
        _playerStateMachine = playerStateMachine;
        _animBoolName = animBoolName;
    }

    protected virtual void Enter()
    {

    }
    protected virtual void Tick()
    {

    }
    protected virtual void Exit()
    {

    }
}
