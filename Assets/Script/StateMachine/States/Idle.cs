

public class Idle : BaseState
{
    public Idle(CustomerAISM stateMachine) : base("Idle", stateMachine) { }
    public override void Enter()// salona girince yani spwan olunca karakterimiz target olarak tombala masasını seçecek
    {
        base.Enter();
        // burada animasyon oynatabiliriz
        if (((CustomerAISM)stateMachine).target)
        {
            stateMachine.ChangeState(((CustomerAISM)stateMachine).moving);// bu statedeki işimiz bittiği zaman buradan geçmek istediğimiz state ye geçiyoruz
        }
       
       
    }

}
