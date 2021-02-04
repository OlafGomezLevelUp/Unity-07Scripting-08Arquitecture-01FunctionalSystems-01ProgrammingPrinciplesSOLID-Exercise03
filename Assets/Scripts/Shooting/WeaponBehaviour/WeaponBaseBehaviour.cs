using UnityEngine;

public abstract class WeaponBaseBehaviour : MonoBehaviour
{
    [SerializeField]
    protected BulletBase bulletPrefab;

    [SerializeField]
    float fireRate;
    
    float nextTimeFire;

    public abstract void Fire(Vector3 firePoint);

    protected virtual bool CanFire() 
    {
        return Time.time >= nextTimeFire;
    }
}
