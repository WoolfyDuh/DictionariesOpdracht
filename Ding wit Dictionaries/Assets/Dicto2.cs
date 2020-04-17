using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum WeaponTypes
{
	GUNBLADE,
	PLASMAGUN,
	MUSKET
}
public class Dicto2 : MonoBehaviour
{
	Dictionary<WeaponTypes, int> weaponsList = new Dictionary<WeaponTypes, int>();
	int selector = 0;
	WeaponTypes currentWeapon;
    // Start is called before the first frame update
    void Start()
    {
		weaponsList.Add(WeaponTypes.GUNBLADE, 6);
		weaponsList.Add(WeaponTypes.MUSKET, 4);
		weaponsList.Add(WeaponTypes.PLASMAGUN, 16);
		Debug.Log("my contents were properly filled");
    }

    // Update is called once per frame
    void Update()
    {
		switch (selector)
		{
			case 0:
				currentWeapon = WeaponTypes.GUNBLADE;
				break;
			case 1:
				currentWeapon = WeaponTypes.MUSKET;
				break;
			case 2:
				currentWeapon = WeaponTypes.PLASMAGUN;
				break;
			default:
				break;
		}
		if (weaponsList != null)
			if (Input.GetKeyDown(KeyCode.Space))
			{
				if (weaponsList[currentWeapon] >= 1){
					Debug.Log("I am firing my " + currentWeapon + "!!!");
					weaponsList[currentWeapon] -= 1;
					Debug.Log("my current weapon has: " + weaponsList[currentWeapon] + " bullets left.");
				}
				else
				{
					Debug.Log("I am out of ammo");
				}
			}
		if (Input.GetKeyDown(KeyCode.LeftArrow))
			selector -= 1;
		if (Input.GetKeyDown(KeyCode.RightArrow))
			selector += 1;
		if (selector == -1)
			selector = 2;
		if (selector == 3)
			selector = 0;
    }
}
