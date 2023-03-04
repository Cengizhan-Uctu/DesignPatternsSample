

public class Idle : BaseState
{
    public Idle(CustomerAISM stateMachine) : base("Idle", stateMachine) { }
    public override void Enter()
    {
        base.Enter();
       
        if (((CustomerAISM)stateMachine).target)
        {
            stateMachine.ChangeState(((CustomerAISM)stateMachine).moving);
        }
       
       
    }

}
