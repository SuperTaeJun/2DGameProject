using UnityEngine;

public class PlayerIdleState : PlayerState
{
    public PlayerIdleState(Player player, PlayerStateMachine playerStateMachine, string animBoolName) : base(player, playerStateMachine, animBoolName)
    {
    }

    protected override void Enter()
    {
        base.Enter();
    }

    protected override void Exit()
    {
        base.Exit();
    }

    protected override void Tick()
    {
        base.Tick();
    }
}
