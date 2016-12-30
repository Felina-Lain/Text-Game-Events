using UnityEngine;
using System.Collections;

public enum WeaponsGroup{Sword, Axe, Stick, Staff}
public enum ArmorGroup{Cloth, Leather, Mail}

public class Character{

	public float intelligence;
	public float strength;
	public float speed;

	public WeaponsGroup myweapon;
	public ArmorGroup myarmor;

	public void ToRead(){

	strength -= 1;
	speed -= 1;
	intelligence += 3;

	}
	public void ToFight(){

		strength += 2;
		speed += 1;
		intelligence -= 1;
	}
	public void ToRun(){

		strength += 1;
		speed += 2;
		intelligence -= 1;
	}

}
