using UnityEngine;

public class JumpBoost : PowerUpBase
{
    public override void ApplayEffect(Player player)
    {
        if (!IsEffectActive)
        {
            player.SetJumpForce(20);
        }
    }

    
}
