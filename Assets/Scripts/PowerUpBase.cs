using UnityEngine;

public abstract class PowerUpBase
{
    protected bool IsEffectActive = false;

    public abstract void ApplayEffect(Player player);
}
