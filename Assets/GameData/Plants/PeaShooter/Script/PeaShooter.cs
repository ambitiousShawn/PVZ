using UnityEngine;

public class PeaShooter : BasePlant
{
    private const string ProducePath = "";

    private int ID;
    private PlantUnit Unit;

    private float timer;
    private int curHealth;
    protected override void Init()
    {
        ID = GetInstanceID(E_AllPlant.PeaShooter);
        Unit = Resources.Load<PlantShooterData>("SO/PlantsData").Plants[ID];
        timer = 0;
        curHealth = Unit.Health;
    }

    protected override void Tick()
    {
        timer += Time.deltaTime;
        if (timer >= Unit.Interval)
        {
            Attack();
            timer = 0;
        }
    }


    protected void Attack()
    {

    }
}
