public class Enemy
{
    public string type;
    public int hp;

    public Enemy()
    {
        type = "Normal";
        hp = 10;
    }

    public void wait()
    {

    }
}

public class EnemyWalking : Enemy
{
    public EnemyWalking()
    {
        type = "Walking";
        hp = 50;
    }

    void Walk()
    {
        wait();
    }
}