using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dicto1 : MonoBehaviour
{
	Dictionary<string, int> weaponsList = new Dictionary<string, int>();
	string currentWeapon = "PlasmaGun";
	
    // Start is called before the first frame update
    void Start()
    {
		weaponsList.Add("PlasmaGun", 16);
		weaponsList.Add("musket", 2);
		weaponsList.Add("GUNBLADE", 6);
		Debug.Log("i am working as intended");
    }

    // Update is called once per frame
    void Update()
    {

		if (Input.GetKeyDown(KeyCode.Space))
		{
			if (weaponsList[currentWeapon] >= 1)
			{
				Debug.Log("YOU SHOT SOMETHING");
				weaponsList[currentWeapon] -= 1;
				Debug.Log("your weapon has: " + weaponsList[currentWeapon]+ " ammo left");
			}
			else
			{
				Debug.Log("you don't have any ammo left to shoot");
			}
		}
    }
}
