using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFactory : MonoBehaviour
{
    public GameObject bullet;
    public GameObject fatBullet;
    public GameObject pulsingBullet;

    public GameObject createBullet(BulletType type = BulletType.RANDOM)
    {
        if (type == BulletType.RANDOM)
        {
            var randomBullet = Random.Range(0, 3);
            type = (BulletType) randomBullet;
        }

        GameObject tempBullet = null;

        switch (type)
        {
            //case "Bullet":
            //    tempBullet = Instantiate(this.bullet);
            //    break;
            //case "Fat Bullet":

            //    break;
            //case "Pulsing Bullet":

            //    break;

            case BulletType.REGULAR:
                tempBullet = Instantiate(bullet);
                break;
            case BulletType.FAT:
                tempBullet = Instantiate(fatBullet);
                break;
            case BulletType.PULSING:
                tempBullet = Instantiate(pulsingBullet);
                break;
        }

        tempBullet.transform.parent = transform;
        tempBullet.SetActive(false);

        return tempBullet;
    }
}
