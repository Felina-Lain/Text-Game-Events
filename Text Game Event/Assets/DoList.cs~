using UnityEngine;
using System.Collections;
using UnityEngine.UI;

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
				print("I'm sorry, I do not understand this training...");
					break;
				}

			_activities += 1;
			
		}else{

			_text.text = "I cannot add anymore to do or I shall crumble of exhaustion. I shall either change my mind, or finish this day and do another!";

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
			print("I'm sorry, I do not understand this training...");
				break;
		}

		_activities -= 1;
	}
}
