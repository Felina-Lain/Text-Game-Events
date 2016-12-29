using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;

public class DoList : MonoBehaviour {

	public Character _myHero;
	public Dropdown _dropdowns;
	public int _activities;

	public Text _text;

	void Start(){

		_myHero = new Character();
		_activities = 0;
	}


	public void Addstuff () {

		if(_activities < 5){

				switch (_dropdowns.value)
				{
				case 0: //If dropdown value = Read
				GetComponent<Manager>().m_MyEvent += _myHero.ToRead;
					break;
				case 1: //Value = Work Out
				GetComponent<Manager>().m_MyEvent += _myHero.ToFight;
					break;
				case 2: //Value = Run
				GetComponent<Manager>().m_MyEvent +=  _myHero.ToRun;
						
					break;
				default:
					break;
				}

			_activities += 1;
			
		}else{

			_text.text = GetComponent<Manager>()._lines[9];

		}
	
	}

	public void Removestuff (){

			switch (_dropdowns.value)
			{
			case 0: //If dropdown value = Read
				GetComponent<Manager>().m_MyEvent -= _myHero.ToRead;
				break;
			case 1: //Value = Work Out
			GetComponent<Manager>().m_MyEvent -= _myHero.ToFight;
				break;
			case 2: //Value = Run
			GetComponent<Manager>().m_MyEvent -=  _myHero.ToRun;

				break;
			default:
			
				break;
		}

		_activities -= 1;
	}

	//end game
	public void Execution () {

		GetComponent<Manager>().dragface = true;

		switch (GetComponent<Manager>()._weapon.value)
		{
		case 0: //If dropdown value = Read
			GetComponent<Manager>().m_MyEvent += _myHero.Mage;
			break;
		case 1: //Value = Work Out
			GetComponent<Manager>().m_MyEvent += _myHero.War;;
			break;
		case 2: //Value = Run
			GetComponent<Manager>().m_MyEvent += _myHero.Rogue;

			break;
		default:

			break;
		}

		switch (GetComponent<Manager>()._armor.value)
		{
		case 0: //If dropdown value = Read
			GetComponent<Manager>().m_MyEvent += _myHero.Mage;
			break;
		case 1: //Value = Work Out
			GetComponent<Manager>().m_MyEvent += _myHero.War;
			break;
		case 2: //Value = Run
			GetComponent<Manager>().m_MyEvent += _myHero.Rogue;

			break;
		default:

			break;
		}

	}
}
