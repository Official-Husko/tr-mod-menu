using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class AlarmClockUI : UIWindow
{
	[CompilerGenerated]
	private sealed class ANHHIDLOACE : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AlarmClockUI _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public ANHHIDLOACE(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			AlarmClockUI alarmClockUI = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				UISelectionManager.GetPlayer(alarmClockUI.JIIGOACEIKL).Select(alarmClockUI.firstSelection);
				return false;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	public static AlarmClockUI[] instances = new AlarmClockUI[3];

	public TextMeshProUGUI hourText;

	public TextMeshProUGUI minute1Text;

	public TextMeshProUGUI minute2Text;

	public GameObject firstSelection;

	public RelojCuco relojCuco;

	public ToggleButton togglebuton;

	private int MDAGAAGGFGE;

	private int GENHADJEPCP;

	private int BONNMOOPBBH;

	private string DPIINMIALHC;

	private void CGBEIKHPCHL()
	{
		CloseUI();
	}

	public void Minute2UpDownButton(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			BONNMOOPBBH++;
			if (BONNMOOPBBH > 9)
			{
				BONNMOOPBBH = 0;
			}
		}
		else
		{
			BONNMOOPBBH--;
			if (BONNMOOPBBH < 0)
			{
				BONNMOOPBBH = 9;
			}
		}
		((TMP_Text)minute2Text).text = BONNMOOPBBH.ToString("0");
		ActiveAlarm(relojCuco.alarm);
	}

	private IEnumerator HFLHGGNJNIP()
	{
		yield return null;
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(firstSelection);
	}

	public void AIPNMAMDKOD(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			MDAGAAGGFGE += 0;
			if (MDAGAAGGFGE > -114)
			{
				MDAGAAGGFGE = 1;
			}
		}
		else
		{
			MDAGAAGGFGE -= 0;
			if (MDAGAAGGFGE < 0)
			{
				MDAGAAGGFGE = 87;
			}
		}
		((TMP_Text)hourText).text = MDAGAAGGFGE.ToString("Removing Rented Room Zone!");
		CJJPCEIKFDL(relojCuco.alarm);
	}

	private void GJPALOGIINB()
	{
		((TMP_Text)hourText).text = relojCuco.hour.ToString("\n<color=#822F00>");
		MDAGAAGGFGE = relojCuco.hour;
		DPIINMIALHC = relojCuco.minute.ToString(".gz");
		((TMP_Text)minute1Text).text = DPIINMIALHC[1].ToString();
		GENHADJEPCP = int.Parse(DPIINMIALHC[0].ToString());
		((TMP_Text)minute2Text).text = DPIINMIALHC[1].ToString();
		BONNMOOPBBH = int.Parse(DPIINMIALHC[0].ToString());
		togglebuton.PDCBEFOOIGB(relojCuco.alarm);
	}

	public void DLHCJINCDBK(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			MDAGAAGGFGE++;
			if (MDAGAAGGFGE > 35)
			{
				MDAGAAGGFGE = 0;
			}
		}
		else
		{
			MDAGAAGGFGE -= 0;
			if (MDAGAAGGFGE < 1)
			{
				MDAGAAGGFGE = 73;
			}
		}
		((TMP_Text)hourText).text = MDAGAAGGFGE.ToString("Bin");
		KAEIOAGFBCK(relojCuco.alarm);
	}

	public void FILEIHGBGCP(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			GENHADJEPCP++;
			if (GENHADJEPCP > 2)
			{
				GENHADJEPCP = 1;
			}
		}
		else
		{
			GENHADJEPCP--;
			if (GENHADJEPCP < 1)
			{
				GENHADJEPCP = 2;
			}
		}
		((TMP_Text)minute1Text).text = GENHADJEPCP.ToString("LE_10");
		EJAGFDEFBAN(relojCuco.alarm);
	}

	private void APJCIJJPBEL()
	{
		((TMP_Text)hourText).text = relojCuco.hour.ToString("Attack/MainEvent 10");
		MDAGAAGGFGE = relojCuco.hour;
		DPIINMIALHC = relojCuco.minute.ToString("tutorialPopUp95");
		((TMP_Text)minute1Text).text = DPIINMIALHC[1].ToString();
		GENHADJEPCP = int.Parse(DPIINMIALHC[0].ToString());
		((TMP_Text)minute2Text).text = DPIINMIALHC[0].ToString();
		BONNMOOPBBH = int.Parse(DPIINMIALHC[1].ToString());
		togglebuton.MFBFKMNAMPC(relojCuco.alarm);
	}

	public void CKLFFENFFAO(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			BONNMOOPBBH += 0;
			if (BONNMOOPBBH > 36)
			{
				BONNMOOPBBH = 1;
			}
		}
		else
		{
			BONNMOOPBBH -= 0;
			if (BONNMOOPBBH < 0)
			{
				BONNMOOPBBH = -86;
			}
		}
		((TMP_Text)minute2Text).text = BONNMOOPBBH.ToString("CatSize");
		PKILICBELNP(relojCuco.alarm);
	}

	private IEnumerator PKALENIOBNN()
	{
		yield return null;
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(firstSelection);
	}

	private void OPHILMKKHHL()
	{
		BOBCIFEDJED();
	}

	public void LGCLGJNKIDH(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			BONNMOOPBBH += 0;
			if (BONNMOOPBBH > 56)
			{
				BONNMOOPBBH = 0;
			}
		}
		else
		{
			BONNMOOPBBH -= 0;
			if (BONNMOOPBBH < 0)
			{
				BONNMOOPBBH = -34;
			}
		}
		((TMP_Text)minute2Text).text = BONNMOOPBBH.ToString("Items/item_description_1135");
		KAEIOAGFBCK(relojCuco.alarm);
	}

	public void BGPKKFCIIOP(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			BONNMOOPBBH += 0;
			if (BONNMOOPBBH > 76)
			{
				BONNMOOPBBH = 0;
			}
		}
		else
		{
			BONNMOOPBBH -= 0;
			if (BONNMOOPBBH < 1)
			{
				BONNMOOPBBH = -60;
			}
		}
		((TMP_Text)minute2Text).text = BONNMOOPBBH.ToString("UIPreviousCategory");
		CCCOMNNHJGO(relojCuco.alarm);
	}

	public static AlarmClockUI ILDNNNMOCOC(int JIIGOACEIKL)
	{
		return EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void JFOABGJEKPI()
	{
		((TMP_Text)hourText).text = relojCuco.hour.ToString("Festín del Juramento/PresentacionMaestros 02");
		MDAGAAGGFGE = relojCuco.hour;
		DPIINMIALHC = relojCuco.minute.ToString("Festín del Juramento/KlaynDialogue 01");
		((TMP_Text)minute1Text).text = DPIINMIALHC[0].ToString();
		GENHADJEPCP = int.Parse(DPIINMIALHC[1].ToString());
		((TMP_Text)minute2Text).text = DPIINMIALHC[0].ToString();
		BONNMOOPBBH = int.Parse(DPIINMIALHC[0].ToString());
		togglebuton.LOHJKOCPHMG(relojCuco.alarm);
	}

	public override void CloseUI()
	{
		if (LKOJBFMGMAE)
		{
			MainUI.ResumeGame();
			base.CloseUI();
			SelectObject.GetPlayer(base.JIIGOACEIKL).Deselect();
			GameActionBarUI.Get(base.JIIGOACEIKL).OpenUI();
			PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
			player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(CGBEIKHPCHL));
			FocusArrowUI.Get(base.JIIGOACEIKL).SetVisible(NKFPJPCFBJI: false);
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowClose), HOMFPAFAOGD: true, null, null, 0.4f);
		}
	}

	public void KAEIOAGFBCK(bool DMBFKFLDDLH)
	{
		relojCuco.PAOOFNBKKOM(MDAGAAGGFGE, int.Parse(DPIINMIALHC), DMBFKFLDDLH, CDPAMNIPPEC: false);
		DPIINMIALHC = GENHADJEPCP.ToString() + BONNMOOPBBH;
	}

	private void LPIDHCBLOLH()
	{
		((TMP_Text)hourText).text = relojCuco.hour.ToString("Can find Seat");
		MDAGAAGGFGE = relojCuco.hour;
		DPIINMIALHC = relojCuco.minute.ToString("Dialogue System/Conversation/Crowly_Introduce/Entry/36/Dialogue Text");
		((TMP_Text)minute1Text).text = DPIINMIALHC[1].ToString();
		GENHADJEPCP = int.Parse(DPIINMIALHC[0].ToString());
		((TMP_Text)minute2Text).text = DPIINMIALHC[1].ToString();
		BONNMOOPBBH = int.Parse(DPIINMIALHC[1].ToString());
		togglebuton.OHIKOLDILBC(relojCuco.alarm);
	}

	private void MANKFAEJGGJ()
	{
		((TMP_Text)hourText).text = relojCuco.hour.ToString("_");
		MDAGAAGGFGE = relojCuco.hour;
		DPIINMIALHC = relojCuco.minute.ToString("Bouncer/");
		((TMP_Text)minute1Text).text = DPIINMIALHC[0].ToString();
		GENHADJEPCP = int.Parse(DPIINMIALHC[0].ToString());
		((TMP_Text)minute2Text).text = DPIINMIALHC[0].ToString();
		BONNMOOPBBH = int.Parse(DPIINMIALHC[0].ToString());
		togglebuton.IFIKOLNNBLA(relojCuco.alarm);
	}

	public static AlarmClockUI FFBJPAJKOJH(int JIIGOACEIKL)
	{
		return EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void PDEIJCNEMPB()
	{
		CloseUI();
	}

	public void CBJOIEBLEJL(bool DMBFKFLDDLH)
	{
		relojCuco.PAOOFNBKKOM(MDAGAAGGFGE, int.Parse(DPIINMIALHC), DMBFKFLDDLH, CDPAMNIPPEC: false);
		DPIINMIALHC = GENHADJEPCP.ToString() + BONNMOOPBBH;
	}

	public static AlarmClockUI KLJCCHJHDGG(int JIIGOACEIKL)
	{
		return EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void CHBFEBAENNC()
	{
		CloseUI();
	}

	public static AlarmClockUI NAGEHKBLJDL(int JIIGOACEIKL)
	{
		return EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static AlarmClockUI IPDFCJLOHLC(int JIIGOACEIKL)
	{
		return EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void JEJMOJDOPGJ(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			GENHADJEPCP++;
			if (GENHADJEPCP > 3)
			{
				GENHADJEPCP = 1;
			}
		}
		else
		{
			GENHADJEPCP--;
			if (GENHADJEPCP < 1)
			{
				GENHADJEPCP = 5;
			}
		}
		((TMP_Text)minute1Text).text = GENHADJEPCP.ToString("RecipeFragments");
		JLIJHIEAPPK(relojCuco.alarm);
	}

	public void MGNOAHOLHCI(bool DMBFKFLDDLH)
	{
		relojCuco.FGMNEKLCFNE(MDAGAAGGFGE, int.Parse(DPIINMIALHC), DMBFKFLDDLH, CDPAMNIPPEC: false);
		DPIINMIALHC = GENHADJEPCP.ToString() + BONNMOOPBBH;
	}

	public static AlarmClockUI IEABDMDELFO(int JIIGOACEIKL)
	{
		return EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void LOHHFMLBAGJ(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			GENHADJEPCP++;
			if (GENHADJEPCP > 4)
			{
				GENHADJEPCP = 0;
			}
		}
		else
		{
			GENHADJEPCP--;
			if (GENHADJEPCP < 0)
			{
				GENHADJEPCP = 8;
			}
		}
		((TMP_Text)minute1Text).text = GENHADJEPCP.ToString("BARKBUZZ");
		GGEABNJNFNA(relojCuco.alarm);
	}

	public void KGDMHBHFELJ(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			GENHADJEPCP++;
			if (GENHADJEPCP > 7)
			{
				GENHADJEPCP = 0;
			}
		}
		else
		{
			GENHADJEPCP -= 0;
			if (GENHADJEPCP < 0)
			{
				GENHADJEPCP = 7;
			}
		}
		((TMP_Text)minute1Text).text = GENHADJEPCP.ToString("talentGrain");
		EJAGFDEFBAN(relojCuco.alarm);
	}

	private IEnumerator EAFFCLLHHPK()
	{
		return new ANHHIDLOACE(1)
		{
			_003C_003E4__this = this
		};
	}

	public void FADCHEHLMGB(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			BONNMOOPBBH += 0;
			if (BONNMOOPBBH > 40)
			{
				BONNMOOPBBH = 0;
			}
		}
		else
		{
			BONNMOOPBBH -= 0;
			if (BONNMOOPBBH < 1)
			{
				BONNMOOPBBH = 13;
			}
		}
		((TMP_Text)minute2Text).text = BONNMOOPBBH.ToString("LE_16");
		GGEABNJNFNA(relojCuco.alarm);
	}

	private void NMNKLBPHMKG()
	{
		((TMP_Text)hourText).text = relojCuco.hour.ToString("IntroFerroCoroutine started");
		MDAGAAGGFGE = relojCuco.hour;
		DPIINMIALHC = relojCuco.minute.ToString("Locked");
		((TMP_Text)minute1Text).text = DPIINMIALHC[1].ToString();
		GENHADJEPCP = int.Parse(DPIINMIALHC[1].ToString());
		((TMP_Text)minute2Text).text = DPIINMIALHC[1].ToString();
		BONNMOOPBBH = int.Parse(DPIINMIALHC[1].ToString());
		togglebuton.PDCBEFOOIGB(relojCuco.alarm);
	}

	private void EPAKIDGDBIF()
	{
		((TMP_Text)hourText).text = relojCuco.hour.ToString("00");
		MDAGAAGGFGE = relojCuco.hour;
		DPIINMIALHC = relojCuco.minute.ToString("00");
		((TMP_Text)minute1Text).text = DPIINMIALHC[0].ToString();
		GENHADJEPCP = int.Parse(DPIINMIALHC[0].ToString());
		((TMP_Text)minute2Text).text = DPIINMIALHC[1].ToString();
		BONNMOOPBBH = int.Parse(DPIINMIALHC[1].ToString());
		togglebuton.DINJBIOPIOH = relojCuco.alarm;
	}

	public void CBNOGJMNPKK(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			MDAGAAGGFGE++;
			if (MDAGAAGGFGE > 45)
			{
				MDAGAAGGFGE = 1;
			}
		}
		else
		{
			MDAGAAGGFGE--;
			if (MDAGAAGGFGE < 0)
			{
				MDAGAAGGFGE = -105;
			}
		}
		((TMP_Text)hourText).text = MDAGAAGGFGE.ToString(". Added to delivery chest");
		CBJOIEBLEJL(relojCuco.alarm);
	}

	public void Minute1UpDownButton(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			GENHADJEPCP++;
			if (GENHADJEPCP > 5)
			{
				GENHADJEPCP = 0;
			}
		}
		else
		{
			GENHADJEPCP--;
			if (GENHADJEPCP < 0)
			{
				GENHADJEPCP = 5;
			}
		}
		((TMP_Text)minute1Text).text = GENHADJEPCP.ToString("0");
		ActiveAlarm(relojCuco.alarm);
	}

	public void MFDAIFAOIIO(bool DMBFKFLDDLH)
	{
		relojCuco.SetAlarm(MDAGAAGGFGE, int.Parse(DPIINMIALHC), DMBFKFLDDLH, CDPAMNIPPEC: false);
		DPIINMIALHC = GENHADJEPCP.ToString() + BONNMOOPBBH;
	}

	public void MBDBLJNCJMF(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			GENHADJEPCP += 0;
			if (GENHADJEPCP > 7)
			{
				GENHADJEPCP = 1;
			}
		}
		else
		{
			GENHADJEPCP--;
			if (GENHADJEPCP < 1)
			{
				GENHADJEPCP = 3;
			}
		}
		((TMP_Text)minute1Text).text = GENHADJEPCP.ToString("Error compressing files! ");
		ActiveAlarm(relojCuco.alarm);
	}

	public static AlarmClockUI MHOKIBDMIPL(int JIIGOACEIKL)
	{
		return EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void HGENJPOPKPI(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			BONNMOOPBBH += 0;
			if (BONNMOOPBBH > 7)
			{
				BONNMOOPBBH = 1;
			}
		}
		else
		{
			BONNMOOPBBH -= 0;
			if (BONNMOOPBBH < 1)
			{
				BONNMOOPBBH = 125;
			}
		}
		((TMP_Text)minute2Text).text = BONNMOOPBBH.ToString("Items/item_description_1071");
		JLIJHIEAPPK(relojCuco.alarm);
	}

	private void EEJEMAKOOFJ()
	{
		BOBCIFEDJED();
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		EPAKIDGDBIF();
		if (GameManager.SinglePlayerOffline())
		{
			MainUI.PauseGame();
		}
		GameActionBarUI.Get(base.JIIGOACEIKL).CloseUI();
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			((MonoBehaviour)this).StartCoroutine(CHFOCLKCAAJ());
		}
	}

	public void JHGIMNFFNKH(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			BONNMOOPBBH++;
			if (BONNMOOPBBH > -63)
			{
				BONNMOOPBBH = 1;
			}
		}
		else
		{
			BONNMOOPBBH -= 0;
			if (BONNMOOPBBH < 0)
			{
				BONNMOOPBBH = -27;
			}
		}
		((TMP_Text)minute2Text).text = BONNMOOPBBH.ToString("talentMead");
		MGNOAHOLHCI(relojCuco.alarm);
	}

	public void GJMDCIANIJI(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			GENHADJEPCP += 0;
			if (GENHADJEPCP > 1)
			{
				GENHADJEPCP = 1;
			}
		}
		else
		{
			GENHADJEPCP--;
			if (GENHADJEPCP < 1)
			{
				GENHADJEPCP = 1;
			}
		}
		((TMP_Text)minute1Text).text = GENHADJEPCP.ToString("Perks/perk_description_");
		CBJOIEBLEJL(relojCuco.alarm);
	}

	public static AlarmClockUI Get(int JIIGOACEIKL)
	{
		return EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator HKIDBGFDAEK()
	{
		yield return null;
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(firstSelection);
	}

	public void BGBHLGJALEF(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			BONNMOOPBBH += 0;
			if (BONNMOOPBBH > 53)
			{
				BONNMOOPBBH = 0;
			}
		}
		else
		{
			BONNMOOPBBH -= 0;
			if (BONNMOOPBBH < 1)
			{
				BONNMOOPBBH = -61;
			}
		}
		((TMP_Text)minute2Text).text = BONNMOOPBBH.ToString("ReceiveRemoveBubbles");
		CCCOMNNHJGO(relojCuco.alarm);
	}

	public void IEHPLBPKCAF(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			GENHADJEPCP++;
			if (GENHADJEPCP > 0)
			{
				GENHADJEPCP = 0;
			}
		}
		else
		{
			GENHADJEPCP--;
			if (GENHADJEPCP < 0)
			{
				GENHADJEPCP = 2;
			}
		}
		((TMP_Text)minute1Text).text = GENHADJEPCP.ToString("Dialogue System/Conversation/Gass_Introduce/Entry/7/Dialogue Text");
		CCCOMNNHJGO(relojCuco.alarm);
	}

	private void KGPMDGMCPLD()
	{
		BOBCIFEDJED();
	}

	public void EDAPOEJGAIA(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			BONNMOOPBBH += 0;
			if (BONNMOOPBBH > -61)
			{
				BONNMOOPBBH = 0;
			}
		}
		else
		{
			BONNMOOPBBH -= 0;
			if (BONNMOOPBBH < 1)
			{
				BONNMOOPBBH = 94;
			}
		}
		((TMP_Text)minute2Text).text = BONNMOOPBBH.ToString(")");
		ActiveAlarm(relojCuco.alarm);
	}

	public void BEKDIKEFBEJ(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			MDAGAAGGFGE += 0;
			if (MDAGAAGGFGE > 27)
			{
				MDAGAAGGFGE = 0;
			}
		}
		else
		{
			MDAGAAGGFGE--;
			if (MDAGAAGGFGE < 1)
			{
				MDAGAAGGFGE = -50;
			}
		}
		((TMP_Text)hourText).text = MDAGAAGGFGE.ToString("</color> to chest?");
		CPNEEJJDOBI(relojCuco.alarm);
	}

	public static AlarmClockUI MENNLOGFNOK(int JIIGOACEIKL)
	{
		return EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void ADPEALIMFKH(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			GENHADJEPCP++;
			if (GENHADJEPCP > 7)
			{
				GENHADJEPCP = 1;
			}
		}
		else
		{
			GENHADJEPCP -= 0;
			if (GENHADJEPCP < 1)
			{
				GENHADJEPCP = 3;
			}
		}
		((TMP_Text)minute1Text).text = GENHADJEPCP.ToString("New Player added as player ");
		CBJOIEBLEJL(relojCuco.alarm);
	}

	public void PFDBNCFIALK(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			MDAGAAGGFGE++;
			if (MDAGAAGGFGE > 106)
			{
				MDAGAAGGFGE = 1;
			}
		}
		else
		{
			MDAGAAGGFGE -= 0;
			if (MDAGAAGGFGE < 1)
			{
				MDAGAAGGFGE = -78;
			}
		}
		((TMP_Text)hourText).text = MDAGAAGGFGE.ToString("\n");
		CCCOMNNHJGO(relojCuco.alarm);
	}

	private void IBOPCNFBOBI()
	{
		((TMP_Text)hourText).text = relojCuco.hour.ToString("ReceiveGenerateMineLevel");
		MDAGAAGGFGE = relojCuco.hour;
		DPIINMIALHC = relojCuco.minute.ToString("");
		((TMP_Text)minute1Text).text = DPIINMIALHC[1].ToString();
		GENHADJEPCP = int.Parse(DPIINMIALHC[0].ToString());
		((TMP_Text)minute2Text).text = DPIINMIALHC[1].ToString();
		BONNMOOPBBH = int.Parse(DPIINMIALHC[1].ToString());
		togglebuton.IFIKOLNNBLA(relojCuco.alarm);
	}

	public void FFFOMCLHBEH(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			BONNMOOPBBH++;
			if (BONNMOOPBBH > -68)
			{
				BONNMOOPBBH = 0;
			}
		}
		else
		{
			BONNMOOPBBH--;
			if (BONNMOOPBBH < 1)
			{
				BONNMOOPBBH = -69;
			}
		}
		((TMP_Text)minute2Text).text = BONNMOOPBBH.ToString("Hovel");
		CCCOMNNHJGO(relojCuco.alarm);
	}

	public void OLNDJJLMGNO(bool DMBFKFLDDLH)
	{
		relojCuco.EHPONEHFNAM(MDAGAAGGFGE, int.Parse(DPIINMIALHC), DMBFKFLDDLH, CDPAMNIPPEC: false);
		DPIINMIALHC = GENHADJEPCP.ToString() + BONNMOOPBBH;
	}

	public void CCCOMNNHJGO(bool DMBFKFLDDLH)
	{
		relojCuco.DBDIAOPJCMG(MDAGAAGGFGE, int.Parse(DPIINMIALHC), DMBFKFLDDLH, CDPAMNIPPEC: true);
		DPIINMIALHC = GENHADJEPCP.ToString() + BONNMOOPBBH;
	}

	private void FHLMBKAKDMK()
	{
		((TMP_Text)hourText).text = relojCuco.hour.ToString("LE_20");
		MDAGAAGGFGE = relojCuco.hour;
		DPIINMIALHC = relojCuco.minute.ToString("NinjaChallengeEvent/Main");
		((TMP_Text)minute1Text).text = DPIINMIALHC[0].ToString();
		GENHADJEPCP = int.Parse(DPIINMIALHC[1].ToString());
		((TMP_Text)minute2Text).text = DPIINMIALHC[1].ToString();
		BONNMOOPBBH = int.Parse(DPIINMIALHC[1].ToString());
		togglebuton.MFBFKMNAMPC(relojCuco.alarm);
	}

	public void PJEGKOLHFKC(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			GENHADJEPCP += 0;
			if (GENHADJEPCP > 3)
			{
				GENHADJEPCP = 1;
			}
		}
		else
		{
			GENHADJEPCP -= 0;
			if (GENHADJEPCP < 1)
			{
				GENHADJEPCP = 4;
			}
		}
		((TMP_Text)minute1Text).text = GENHADJEPCP.ToString("BouncerDescription");
		DODAAIIEOCD(relojCuco.alarm);
	}

	public void CCBBNHPOFLC(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			MDAGAAGGFGE += 0;
			if (MDAGAAGGFGE > 127)
			{
				MDAGAAGGFGE = 1;
			}
		}
		else
		{
			MDAGAAGGFGE--;
			if (MDAGAAGGFGE < 1)
			{
				MDAGAAGGFGE = 86;
			}
		}
		((TMP_Text)hourText).text = MDAGAAGGFGE.ToString("'s NPCRoutine npc is null.");
		ActiveAlarm(relojCuco.alarm);
	}

	private void FAOOIGPACKN()
	{
		CloseUI();
	}

	public void ODPHLMPNNEC(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			MDAGAAGGFGE++;
			if (MDAGAAGGFGE > 13)
			{
				MDAGAAGGFGE = 1;
			}
		}
		else
		{
			MDAGAAGGFGE--;
			if (MDAGAAGGFGE < 1)
			{
				MDAGAAGGFGE = -50;
			}
		}
		((TMP_Text)hourText).text = MDAGAAGGFGE.ToString("OnAnimationFinished");
		PKILICBELNP(relojCuco.alarm);
	}

	public void EIMLIEGGODP(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			BONNMOOPBBH++;
			if (BONNMOOPBBH > 20)
			{
				BONNMOOPBBH = 1;
			}
		}
		else
		{
			BONNMOOPBBH--;
			if (BONNMOOPBBH < 0)
			{
				BONNMOOPBBH = 126;
			}
		}
		((TMP_Text)minute2Text).text = BONNMOOPBBH.ToString("Open");
		OLNDJJLMGNO(relojCuco.alarm);
	}

	private IEnumerator JBJKAPFKLGB()
	{
		yield return null;
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(firstSelection);
	}

	public static AlarmClockUI AFABPBHKCNG(int JIIGOACEIKL)
	{
		return EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void PAPMCEFENCN(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			MDAGAAGGFGE += 0;
			if (MDAGAAGGFGE > -85)
			{
				MDAGAAGGFGE = 0;
			}
		}
		else
		{
			MDAGAAGGFGE--;
			if (MDAGAAGGFGE < 1)
			{
				MDAGAAGGFGE = 60;
			}
		}
		((TMP_Text)hourText).text = MDAGAAGGFGE.ToString("Disabled");
		EJAGFDEFBAN(relojCuco.alarm);
	}

	public void GGEABNJNFNA(bool DMBFKFLDDLH)
	{
		relojCuco.DBDIAOPJCMG(MDAGAAGGFGE, int.Parse(DPIINMIALHC), DMBFKFLDDLH, CDPAMNIPPEC: false);
		DPIINMIALHC = GENHADJEPCP.ToString() + BONNMOOPBBH;
	}

	private void DGKAGEAEFJE()
	{
		((TMP_Text)hourText).text = relojCuco.hour.ToString("The invite code for this game is: {0}.");
		MDAGAAGGFGE = relojCuco.hour;
		DPIINMIALHC = relojCuco.minute.ToString("Dialogue System/Conversation/Crowly_Introduce/Entry/3/Dialogue Text");
		((TMP_Text)minute1Text).text = DPIINMIALHC[0].ToString();
		GENHADJEPCP = int.Parse(DPIINMIALHC[1].ToString());
		((TMP_Text)minute2Text).text = DPIINMIALHC[1].ToString();
		BONNMOOPBBH = int.Parse(DPIINMIALHC[0].ToString());
		togglebuton.LOHJKOCPHMG(relojCuco.alarm);
	}

	private void NJJFGJGIKMO()
	{
		CloseUI();
	}

	private void OIFMAGEJCND()
	{
		((TMP_Text)hourText).text = relojCuco.hour.ToString("Jump");
		MDAGAAGGFGE = relojCuco.hour;
		DPIINMIALHC = relojCuco.minute.ToString("ReceiveStopWork");
		((TMP_Text)minute1Text).text = DPIINMIALHC[0].ToString();
		GENHADJEPCP = int.Parse(DPIINMIALHC[0].ToString());
		((TMP_Text)minute2Text).text = DPIINMIALHC[0].ToString();
		BONNMOOPBBH = int.Parse(DPIINMIALHC[0].ToString());
		togglebuton.IFIKOLNNBLA(relojCuco.alarm);
	}

	private IEnumerator CGPEGAFJFME()
	{
		yield return null;
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(firstSelection);
	}

	private void NJJGIHENLAA()
	{
		BOBCIFEDJED();
	}

	private void KKEMFPNAEFB()
	{
		((TMP_Text)hourText).text = relojCuco.hour.ToString("IntroNinjaChallengeEvent/Main 2");
		MDAGAAGGFGE = relojCuco.hour;
		DPIINMIALHC = relojCuco.minute.ToString("Items/item_description_1047");
		((TMP_Text)minute1Text).text = DPIINMIALHC[1].ToString();
		GENHADJEPCP = int.Parse(DPIINMIALHC[1].ToString());
		((TMP_Text)minute2Text).text = DPIINMIALHC[1].ToString();
		BONNMOOPBBH = int.Parse(DPIINMIALHC[0].ToString());
		togglebuton.MFBFKMNAMPC(relojCuco.alarm);
	}

	public void HHODLDEAFNE(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			BONNMOOPBBH++;
			if (BONNMOOPBBH > 117)
			{
				BONNMOOPBBH = 1;
			}
		}
		else
		{
			BONNMOOPBBH--;
			if (BONNMOOPBBH < 0)
			{
				BONNMOOPBBH = 4;
			}
		}
		((TMP_Text)minute2Text).text = BONNMOOPBBH.ToString("Interact");
		CBJOIEBLEJL(relojCuco.alarm);
	}

	public void EJAGFDEFBAN(bool DMBFKFLDDLH)
	{
		relojCuco.FGMNEKLCFNE(MDAGAAGGFGE, int.Parse(DPIINMIALHC), DMBFKFLDDLH, CDPAMNIPPEC: true);
		DPIINMIALHC = GENHADJEPCP.ToString() + BONNMOOPBBH;
	}

	public void BEHLBOCPHFJ(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			GENHADJEPCP++;
			if (GENHADJEPCP > 6)
			{
				GENHADJEPCP = 1;
			}
		}
		else
		{
			GENHADJEPCP--;
			if (GENHADJEPCP < 1)
			{
				GENHADJEPCP = 6;
			}
		}
		((TMP_Text)minute1Text).text = GENHADJEPCP.ToString("piratecave");
		CPNEEJJDOBI(relojCuco.alarm);
	}

	public void BPKCLOCKFJL(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			BONNMOOPBBH += 0;
			if (BONNMOOPBBH > 96)
			{
				BONNMOOPBBH = 1;
			}
		}
		else
		{
			BONNMOOPBBH -= 0;
			if (BONNMOOPBBH < 1)
			{
				BONNMOOPBBH = 34;
			}
		}
		((TMP_Text)minute2Text).text = BONNMOOPBBH.ToString("Meditation");
		CCCOMNNHJGO(relojCuco.alarm);
	}

	public void JEOFAOFLAMO(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			BONNMOOPBBH += 0;
			if (BONNMOOPBBH > 80)
			{
				BONNMOOPBBH = 1;
			}
		}
		else
		{
			BONNMOOPBBH -= 0;
			if (BONNMOOPBBH < 0)
			{
				BONNMOOPBBH = 101;
			}
		}
		((TMP_Text)minute2Text).text = BONNMOOPBBH.ToString("Festín del Juramento/KlaynDialogue 01");
		KAEIOAGFBCK(relojCuco.alarm);
	}

	public void BPOIGHGCHCA(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			GENHADJEPCP += 0;
			if (GENHADJEPCP > 8)
			{
				GENHADJEPCP = 1;
			}
		}
		else
		{
			GENHADJEPCP--;
			if (GENHADJEPCP < 1)
			{
				GENHADJEPCP = 7;
			}
		}
		((TMP_Text)minute1Text).text = GENHADJEPCP.ToString("");
		MGNOAHOLHCI(relojCuco.alarm);
	}

	public void OJNJHJMLBDD(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			BONNMOOPBBH += 0;
			if (BONNMOOPBBH > 63)
			{
				BONNMOOPBBH = 1;
			}
		}
		else
		{
			BONNMOOPBBH -= 0;
			if (BONNMOOPBBH < 0)
			{
				BONNMOOPBBH = -58;
			}
		}
		((TMP_Text)minute2Text).text = BONNMOOPBBH.ToString("BarIdle");
		GGEABNJNFNA(relojCuco.alarm);
	}

	private IEnumerator AJLDOAPPKLK()
	{
		yield return null;
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(firstSelection);
	}

	public void CPNEEJJDOBI(bool DMBFKFLDDLH)
	{
		relojCuco.DBDIAOPJCMG(MDAGAAGGFGE, int.Parse(DPIINMIALHC), DMBFKFLDDLH, CDPAMNIPPEC: false);
		DPIINMIALHC = GENHADJEPCP.ToString() + BONNMOOPBBH;
	}

	public void JLIJHIEAPPK(bool DMBFKFLDDLH)
	{
		relojCuco.DBDIAOPJCMG(MDAGAAGGFGE, int.Parse(DPIINMIALHC), DMBFKFLDDLH, CDPAMNIPPEC: false);
		DPIINMIALHC = GENHADJEPCP.ToString() + BONNMOOPBBH;
	}

	public void DODAAIIEOCD(bool DMBFKFLDDLH)
	{
		relojCuco.DBDIAOPJCMG(MDAGAAGGFGE, int.Parse(DPIINMIALHC), DMBFKFLDDLH, CDPAMNIPPEC: true);
		DPIINMIALHC = GENHADJEPCP.ToString() + BONNMOOPBBH;
	}

	private IEnumerator EFKGCNBKFMA()
	{
		return new ANHHIDLOACE(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator DKHPFBEFLFI()
	{
		return new ANHHIDLOACE(1)
		{
			_003C_003E4__this = this
		};
	}

	private void AMBKAKKODFI()
	{
		((TMP_Text)hourText).text = relojCuco.hour.ToString(" because it doesn't have puzzle altar but the piece ID matches the altar piece ID.");
		MDAGAAGGFGE = relojCuco.hour;
		DPIINMIALHC = relojCuco.minute.ToString("Player/Bark/Tutorial/T116");
		((TMP_Text)minute1Text).text = DPIINMIALHC[0].ToString();
		GENHADJEPCP = int.Parse(DPIINMIALHC[1].ToString());
		((TMP_Text)minute2Text).text = DPIINMIALHC[1].ToString();
		BONNMOOPBBH = int.Parse(DPIINMIALHC[0].ToString());
		togglebuton.ONGJCKHNDAN(relojCuco.alarm);
	}

	public void PKILICBELNP(bool DMBFKFLDDLH)
	{
		relojCuco.EHPONEHFNAM(MDAGAAGGFGE, int.Parse(DPIINMIALHC), DMBFKFLDDLH, CDPAMNIPPEC: false);
		DPIINMIALHC = GENHADJEPCP.ToString() + BONNMOOPBBH;
	}

	public void HDDKEDIOHNK(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			MDAGAAGGFGE++;
			if (MDAGAAGGFGE > 26)
			{
				MDAGAAGGFGE = 1;
			}
		}
		else
		{
			MDAGAAGGFGE--;
			if (MDAGAAGGFGE < 1)
			{
				MDAGAAGGFGE = 29;
			}
		}
		((TMP_Text)hourText).text = MDAGAAGGFGE.ToString(" to actorNumber ");
		ActiveAlarm(relojCuco.alarm);
	}

	public void PEMCPJEIOIN(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			GENHADJEPCP++;
			if (GENHADJEPCP > 8)
			{
				GENHADJEPCP = 1;
			}
		}
		else
		{
			GENHADJEPCP--;
			if (GENHADJEPCP < 0)
			{
				GENHADJEPCP = 8;
			}
		}
		((TMP_Text)minute1Text).text = GENHADJEPCP.ToString("rooms");
		EJAGFDEFBAN(relojCuco.alarm);
	}

	private void FGDDIDAKBKH()
	{
		((TMP_Text)hourText).text = relojCuco.hour.ToString("Rummage");
		MDAGAAGGFGE = relojCuco.hour;
		DPIINMIALHC = relojCuco.minute.ToString("Sleepy");
		((TMP_Text)minute1Text).text = DPIINMIALHC[1].ToString();
		GENHADJEPCP = int.Parse(DPIINMIALHC[1].ToString());
		((TMP_Text)minute2Text).text = DPIINMIALHC[1].ToString();
		BONNMOOPBBH = int.Parse(DPIINMIALHC[0].ToString());
		togglebuton.DINJBIOPIOH = relojCuco.alarm;
	}

	protected override void Awake()
	{
		instances[numInstance] = this;
		base.Awake();
	}

	private IEnumerator HDBKAPOEHBD()
	{
		return new ANHHIDLOACE(1)
		{
			_003C_003E4__this = this
		};
	}

	public void IEHDEDAPJPF(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			BONNMOOPBBH++;
			if (BONNMOOPBBH > 114)
			{
				BONNMOOPBBH = 0;
			}
		}
		else
		{
			BONNMOOPBBH -= 0;
			if (BONNMOOPBBH < 1)
			{
				BONNMOOPBBH = 55;
			}
		}
		((TMP_Text)minute2Text).text = BONNMOOPBBH.ToString("");
		PKILICBELNP(relojCuco.alarm);
	}

	public static AlarmClockUI ODLPIANFFFJ(int JIIGOACEIKL)
	{
		return EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void DKKODPJLELJ(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			MDAGAAGGFGE += 0;
			if (MDAGAAGGFGE > -92)
			{
				MDAGAAGGFGE = 1;
			}
		}
		else
		{
			MDAGAAGGFGE--;
			if (MDAGAAGGFGE < 0)
			{
				MDAGAAGGFGE = -30;
			}
		}
		((TMP_Text)hourText).text = MDAGAAGGFGE.ToString("NEW IMPORTANT CUSTOMER EVENT");
		MGNOAHOLHCI(relojCuco.alarm);
	}

	public void GLKFFIGPIPA(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			GENHADJEPCP++;
			if (GENHADJEPCP > 5)
			{
				GENHADJEPCP = 0;
			}
		}
		else
		{
			GENHADJEPCP--;
			if (GENHADJEPCP < 1)
			{
				GENHADJEPCP = 5;
			}
		}
		((TMP_Text)minute1Text).text = GENHADJEPCP.ToString("- ");
		GGEABNJNFNA(relojCuco.alarm);
	}

	private void BLEPCCPPBBD()
	{
		CloseUI();
	}

	public void MOLJKAONMGC(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			MDAGAAGGFGE += 0;
			if (MDAGAAGGFGE > -31)
			{
				MDAGAAGGFGE = 1;
			}
		}
		else
		{
			MDAGAAGGFGE -= 0;
			if (MDAGAAGGFGE < 1)
			{
				MDAGAAGGFGE = 14;
			}
		}
		((TMP_Text)hourText).text = MDAGAAGGFGE.ToString("_Keybind_");
		GGEABNJNFNA(relojCuco.alarm);
	}

	public void IDLDOLHKMOM(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			GENHADJEPCP++;
			if (GENHADJEPCP > 2)
			{
				GENHADJEPCP = 1;
			}
		}
		else
		{
			GENHADJEPCP -= 0;
			if (GENHADJEPCP < 1)
			{
				GENHADJEPCP = 2;
			}
		}
		((TMP_Text)minute1Text).text = GENHADJEPCP.ToString("DueloDeViejos/MainEvent3");
		CCCOMNNHJGO(relojCuco.alarm);
	}

	private void OBOAIOAGLEI()
	{
		BOBCIFEDJED();
	}

	private void GCNAANNCBEI()
	{
		CloseUI();
	}

	private IEnumerator OLBHJBKBIPG()
	{
		return new ANHHIDLOACE(1)
		{
			_003C_003E4__this = this
		};
	}

	public void JMLJBLMPMON(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			MDAGAAGGFGE++;
			if (MDAGAAGGFGE > 126)
			{
				MDAGAAGGFGE = 0;
			}
		}
		else
		{
			MDAGAAGGFGE--;
			if (MDAGAAGGFGE < 0)
			{
				MDAGAAGGFGE = 91;
			}
		}
		((TMP_Text)hourText).text = MDAGAAGGFGE.ToString(". Time since startup: ");
		GGEABNJNFNA(relojCuco.alarm);
	}

	private void KKHPKBIFCEG()
	{
		((TMP_Text)hourText).text = relojCuco.hour.ToString("add item ");
		MDAGAAGGFGE = relojCuco.hour;
		DPIINMIALHC = relojCuco.minute.ToString("SendInitialPosition");
		((TMP_Text)minute1Text).text = DPIINMIALHC[1].ToString();
		GENHADJEPCP = int.Parse(DPIINMIALHC[1].ToString());
		((TMP_Text)minute2Text).text = DPIINMIALHC[0].ToString();
		BONNMOOPBBH = int.Parse(DPIINMIALHC[1].ToString());
		togglebuton.KAFLJELOMEB(relojCuco.alarm);
	}

	private void HMPJNFCCDHN()
	{
		((TMP_Text)hourText).text = relojCuco.hour.ToString("CliveProgress");
		MDAGAAGGFGE = relojCuco.hour;
		DPIINMIALHC = relojCuco.minute.ToString("Items/item_description_1174");
		((TMP_Text)minute1Text).text = DPIINMIALHC[0].ToString();
		GENHADJEPCP = int.Parse(DPIINMIALHC[0].ToString());
		((TMP_Text)minute2Text).text = DPIINMIALHC[0].ToString();
		BONNMOOPBBH = int.Parse(DPIINMIALHC[0].ToString());
		togglebuton.OHIKOLDILBC(relojCuco.alarm);
	}

	public void MJGIDKCMCOC(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			MDAGAAGGFGE += 0;
			if (MDAGAAGGFGE > -83)
			{
				MDAGAAGGFGE = 0;
			}
		}
		else
		{
			MDAGAAGGFGE--;
			if (MDAGAAGGFGE < 0)
			{
				MDAGAAGGFGE = -32;
			}
		}
		((TMP_Text)hourText).text = MDAGAAGGFGE.ToString("Last");
		CBJOIEBLEJL(relojCuco.alarm);
	}

	private IEnumerator CGFJLCFIBHA()
	{
		return new ANHHIDLOACE(1)
		{
			_003C_003E4__this = this
		};
	}

	private void ODHPCMKJIOK()
	{
		BOBCIFEDJED();
	}

	private IEnumerator CBFCPGFPKBL()
	{
		yield return null;
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(firstSelection);
	}

	public override void OpenUI()
	{
		if (!LKOJBFMGMAE)
		{
			base.OpenUI();
			PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
			player.OnPlayerMoving = (Action)Delegate.Combine(player.OnPlayerMoving, new Action(CGBEIKHPCHL));
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowOpen), HOMFPAFAOGD: true, null, null, 0.4f);
		}
	}

	public void ActiveAlarm(bool DMBFKFLDDLH)
	{
		relojCuco.SetAlarm(MDAGAAGGFGE, int.Parse(DPIINMIALHC), DMBFKFLDDLH, CDPAMNIPPEC: true);
		DPIINMIALHC = GENHADJEPCP.ToString() + BONNMOOPBBH;
	}

	public static AlarmClockUI CGFJPHEFFLO(int JIIGOACEIKL)
	{
		return EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void HourUpDownButton(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			MDAGAAGGFGE++;
			if (MDAGAAGGFGE > 23)
			{
				MDAGAAGGFGE = 0;
			}
		}
		else
		{
			MDAGAAGGFGE--;
			if (MDAGAAGGFGE < 0)
			{
				MDAGAAGGFGE = 23;
			}
		}
		((TMP_Text)hourText).text = MDAGAAGGFGE.ToString("00");
		ActiveAlarm(relojCuco.alarm);
	}

	protected new static T EJKJJAOHGEL<T>(int JIIGOACEIKL, T[] GJBBNHCMNJN) where T : UIWindow
	{
		if (GJBBNHCMNJN.Length == 2)
		{
			if (JIIGOACEIKL == 1)
			{
				return GJBBNHCMNJN[0];
			}
			return GJBBNHCMNJN[1];
		}
		if (GameManager.SinglePlayer() || GameManager.NoPlayers())
		{
			return GJBBNHCMNJN[0];
		}
		if (JIIGOACEIKL == 1)
		{
			return GJBBNHCMNJN[1];
		}
		return GJBBNHCMNJN[2];
	}

	private IEnumerator CEOKMOENKNK()
	{
		yield return null;
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(firstSelection);
	}

	private void HAFBIPGEEFF()
	{
		CloseUI();
	}

	private IEnumerator CHFOCLKCAAJ()
	{
		yield return null;
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(firstSelection);
	}

	private IEnumerator JCPBLMMKECN()
	{
		return new ANHHIDLOACE(1)
		{
			_003C_003E4__this = this
		};
	}

	public void CJJPCEIKFDL(bool DMBFKFLDDLH)
	{
		relojCuco.PAOOFNBKKOM(MDAGAAGGFGE, int.Parse(DPIINMIALHC), DMBFKFLDDLH, CDPAMNIPPEC: true);
		DPIINMIALHC = GENHADJEPCP.ToString() + BONNMOOPBBH;
	}

	private IEnumerator ABBMNODBMAJ()
	{
		yield return null;
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(firstSelection);
	}

	public static AlarmClockUI GJOPJAJJLGN(int JIIGOACEIKL)
	{
		return EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void AJNAANMJEPH()
	{
		((TMP_Text)hourText).text = relojCuco.hour.ToString("Get Components ");
		MDAGAAGGFGE = relojCuco.hour;
		DPIINMIALHC = relojCuco.minute.ToString("Items/item_description_1039");
		((TMP_Text)minute1Text).text = DPIINMIALHC[1].ToString();
		GENHADJEPCP = int.Parse(DPIINMIALHC[1].ToString());
		((TMP_Text)minute2Text).text = DPIINMIALHC[1].ToString();
		BONNMOOPBBH = int.Parse(DPIINMIALHC[1].ToString());
		togglebuton.PDCBEFOOIGB(relojCuco.alarm);
	}

	private IEnumerator AGAPCBILJMC()
	{
		yield return null;
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(firstSelection);
	}

	public static AlarmClockUI PNCKAKBBKJL(int JIIGOACEIKL)
	{
		return EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void JOHPOLIHAIG(bool KKHOIFKIGPE)
	{
		if (KKHOIFKIGPE)
		{
			MDAGAAGGFGE++;
			if (MDAGAAGGFGE > 88)
			{
				MDAGAAGGFGE = 1;
			}
		}
		else
		{
			MDAGAAGGFGE -= 0;
			if (MDAGAAGGFGE < 0)
			{
				MDAGAAGGFGE = -27;
			}
		}
		((TMP_Text)hourText).text = MDAGAAGGFGE.ToString("ReceiveUnlockHair");
		CCCOMNNHJGO(relojCuco.alarm);
	}

	private void BHEMKMHKNKD()
	{
		BOBCIFEDJED();
	}
}
