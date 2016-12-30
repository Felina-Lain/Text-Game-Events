using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Manager : MonoBehaviour {

	public delegate void YellingEventType(); 

	public event YellingEventType m_MyEvent;

	public int dayNb;

	public Text _acts;
	public Text _text;
	public Text _stat_strength;
	public Text _stat_speed;
	public Text _stat_intel;
	public Text _dayNb;
	public Button _execute;
	public Dropdown _weapon;
	public Dropdown _armor;

	public Button Conf;
	public Button Def;
	public Button endD;

	public Button newJ;

	public bool dragface;


	//button for this, to validate end of the day
	public void EndDay () {

		if (m_MyEvent != null) {

			m_MyEvent ();

		}

		_text.text = "Twas a good day of training! Soon I shall defeat the dragon!";
		dayNb +=1;
		GetComponent<DoList>()._activities = 0;
		m_MyEvent = null;
	}



	//end game
	public void Execution () {

		dragface = true;

		switch (_weapon.value)
		{
		case 0: //If dropdown value = Read
			GetComponent<Manager>().m_MyEvent += Mage;
			break;
		case 1: //Value = Work Out
			GetComponent<Manager>().m_MyEvent += War;;
			break;
		case 2: //Value = Run
			GetComponent<Manager>().m_MyEvent += Rogue;

			break;
		default:
			print("This item does not exist");
			break;
		}

		switch (_armor.value)
		{
		case 0: //If dropdown value = Read
			GetComponent<Manager>().m_MyEvent += Mage;
			break;
		case 1: //Value = Work Out
			GetComponent<Manager>().m_MyEvent += War;
			break;
		case 2: //Value = Run
			GetComponent<Manager>().m_MyEvent += Rogue;

			break;
		default:
			print("This item does not exist");
			break;
		}

		if (m_MyEvent != null) {

			m_MyEvent ();

		}
			
	}


	void Update(){

		_dayNb.text = "Days left to train " + (7 - dayNb).ToString();
		_acts.text = GetComponent<DoList>()._activities.ToString();
		_stat_strength.text = GetComponent<DoList>()._myHero.strength.ToString();
		_stat_speed.text = GetComponent<DoList>()._myHero.speed.ToString();
		_stat_intel.text = GetComponent<DoList>()._myHero.intelligence.ToString();


		if(dayNb == 7 ){

			_text.text = "Tis now time to face the beast! I shall pick a weapon and an armor before I go!";

			_execute.interactable = true;
			_weapon.interactable = true;
			_armor.interactable = true;

			Def.interactable = false;
			Conf.interactable = false;
			endD.interactable = false;
			GetComponent<DoList>()._dropdowns.interactable = false;

		}

		if(dragface){

			_execute.interactable = false;
			_weapon.interactable = false;
			_armor.interactable = false;

		     if(GetComponent<DoList>()._myHero.strength < 0 ||GetComponent<DoList>()._myHero.intelligence  < 0 || GetComponent<DoList>()._myHero.speed < 0){
		     
		     		_text.text = "You neglected to train in a balanced manner. The Dragon easily spotted your weakness, used it against you and ate you.";
		     
		     }else if(GetComponent<DoList>()._myHero.strength > 35 ){
		     
		     	_text.text = "You used your superior strenght and warrior skills to cut the head of dragon! You now have a new pair of scaly boots!";
		     
		     }else if (GetComponent<DoList>()._myHero.intelligence  > 35){
		     
		     	_text.text = "You used your magic and intellect to defeat the dragon and made it your pet. It's a very good watchdog.";
		     
		     }else if (GetComponent<DoList>()._myHero.speed  > 35 ){
		     
		     	_text.text = "You used your speed and agility to trick the dragon into killing itself. Even I don't know how you did that one.";			
			}else{

				_text.text = "Your training was not enough to defeat the dragon, but at least you managed to escape alive. There shall be another occasion.";	
				
			}

			newJ.interactable = true;
		}
	}

	public void Mage(){

		GetComponent<DoList>()._myHero.intelligence +=5;
		
	}
	public void War(){

		GetComponent<DoList>()._myHero.strength +=5;

	}
	public void Rogue(){

		GetComponent<DoList>()._myHero.speed +=5;
		
	}



	public void Restart(){

		Application.LoadLevel("Main");
	}
	
}
