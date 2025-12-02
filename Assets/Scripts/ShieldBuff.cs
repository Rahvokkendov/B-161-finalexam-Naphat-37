using UnityEngine;

public class ShieldBuff : PowerUpBase
{
    public override void ApplayEffect(Player player)
    {
        if (!IsEffectActive)
        {
            player.SetInvulnerability(true);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
