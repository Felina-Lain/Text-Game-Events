using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;

public class Manager : MonoBehaviour {

	public TextAsset _dialoguefile;
	public string[] _lines;

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

	void Start(){

		_lines = _dialoguefile.text.Split('\n');

	}

	//button for this, to validate end of the day
	public void EndDay () {

		if (m_MyEvent != null) {

			m_MyEvent ();

		}
			
		_text.text = _lines[1];
		dayNb +=1;
		GetComponent<DoList>()._activities = 0;
		m_MyEvent = null;
	}


	void Update(){

		_dayNb.text = _lines[2] + (7 - dayNb).ToString();
		_acts.text = GetComponent<DoList>()._activities.ToString();
		_stat_strength.text = GetComponent<DoList>()._myHero.strength.ToString();
		_stat_speed.text = GetComponent<DoList>()._myHero.speed.ToString();
		_stat_intel.text = GetComponent<DoList>()._myHero.intelligence.ToString();


		if(dayNb == 7 ){

			_text.text = _lines[3];

			_execute.gameObject.SetActive(true);
			_weapon.gameObject.SetActive(true);
			_armor.gameObject.SetActive(true);

			Def.gameObject.SetActive(false);
			Conf.gameObject.SetActive(false);
			endD.gameObject.SetActive(false);
			GetComponent<DoList>()._dropdowns.gameObject.SetActive(false);

		}

		if(dragface){

			_execute.gameObject.SetActive(false);
			_weapon.gameObject.SetActive(false);
			_armor.gameObject.SetActive(false);

		     if(GetComponent<DoList>()._myHero.strength < 0 ||GetComponent<DoList>()._myHero.intelligence  < 0 || GetComponent<DoList>()._myHero.speed < 0){
		     
				_text.text = _lines[4];
		     
		     }else if(GetComponent<DoList>()._myHero.strength > 35 ){
		     
				_text.text = _lines[5];
		     
		     }else if (GetComponent<DoList>()._myHero.intelligence  > 35){
		     
				_text.text = _lines[6];
		     
		     }else if (GetComponent<DoList>()._myHero.speed  > 35 ){
		     
				_text.text = _lines[7];			
			}else{

				_text.text = _lines[8];	
				
			}

			newJ.gameObject.SetActive(true);
		}
	}

	public void FinalFight(){

		if (m_MyEvent != null) {

			m_MyEvent ();

		}

	}

	public void Restart(){

		Application.LoadLevel("Main");
	}
	
}
