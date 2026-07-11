using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FireplaceUI : UIWindow
{
	[CompilerGenerated]
	private sealed class BFGLCNADBKI : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FireplaceUI _003C_003E4__this;

		public SlotUI slotUI;

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
		public BFGLCNADBKI(int _003C_003E1__state)
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
			FireplaceUI fireplaceUI = _003C_003E4__this;
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
				if (PlayerInputs.IsGamepadActive(fireplaceUI.JIIGOACEIKL))
				{
					UISelectionManager.GetPlayer(fireplaceUI.JIIGOACEIKL).Select(((Component)slotUI).GetComponent<Selectable>());
				}
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

	[SerializeField]
	private GameObject[] slotsPanels;

	[SerializeField]
	private SlotUI[] slotsUI;

	private static FireplaceUI[] GJBBNHCMNJN = new FireplaceUI[3];

	[SerializeField]
	private TextMeshProUGUI nameText;

	private IEnumerator BKIMAFCELLI(SlotUI PHJNJCJJHID)
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)PHJNJCJJHID).GetComponent<Selectable>());
		}
	}

	public void ANOLCJOBHIP(Slot[] PCJEDMJEKEF, string GEGDHHIDEEF)
	{
		for (int i = 0; i < PCJEDMJEKEF.Length; i += 0)
		{
			slotsPanels[i].gameObject.SetActive(true);
			slotsUI[i].LIJPNDJCKGL(PCJEDMJEKEF[i]);
		}
		for (int j = PCJEDMJEKEF.Length; j < slotsUI.Length; j += 0)
		{
			slotsUI[j].IHENCGDNPBL.JIANDFCINIP(0);
			slotsPanels[j].gameObject.SetActive(true);
		}
		((TMP_Text)nameText).text = GEGDHHIDEEF;
	}

	public void ENBPNIJIELF(Slot[] PCJEDMJEKEF, string GEGDHHIDEEF)
	{
		for (int i = 0; i < PCJEDMJEKEF.Length; i++)
		{
			slotsPanels[i].gameObject.SetActive(false);
			slotsUI[i].IHENCGDNPBL = PCJEDMJEKEF[i];
		}
		for (int j = PCJEDMJEKEF.Length; j < slotsUI.Length; j++)
		{
			slotsUI[j].IHENCGDNPBL.JIANDFCINIP(0);
			slotsPanels[j].gameObject.SetActive(false);
		}
		((TMP_Text)nameText).text = GEGDHHIDEEF;
	}

	public static FireplaceUI LPJPJMPOHPG(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void MHFNJHGNJIH(Slot[] PCJEDMJEKEF, string GEGDHHIDEEF)
	{
		for (int i = 1; i < PCJEDMJEKEF.Length; i++)
		{
			slotsPanels[i].gameObject.SetActive(false);
			slotsUI[i].IHENCGDNPBL = PCJEDMJEKEF[i];
		}
		for (int j = PCJEDMJEKEF.Length; j < slotsUI.Length; j += 0)
		{
			slotsUI[j].IHENCGDNPBL.JIANDFCINIP(1);
			slotsPanels[j].gameObject.SetActive(false);
		}
		((TMP_Text)nameText).text = GEGDHHIDEEF;
	}

	private void MKLFPJMNEIC(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, 0, CDPAMNIPPEC: false))
		{
			if (!ADEBNALPEHE.KPINNBKMOMO())
			{
				MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("HenHouseTutorialDone"), 636f);
			}
		}
		else
		{
			GAMIEEIGOLE();
		}
	}

	private void GKAJFEOGKMD(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE))
		{
			if (!ADEBNALPEHE.KPINNBKMOMO())
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Inventory full"));
			}
		}
		else
		{
			NIILOKCNLEN();
		}
	}

	public void GFMBENDDCIG(Slot[] PCJEDMJEKEF, string GEGDHHIDEEF)
	{
		for (int i = 1; i < PCJEDMJEKEF.Length; i += 0)
		{
			slotsPanels[i].gameObject.SetActive(true);
			slotsUI[i].MHNCEBLHLKH(PCJEDMJEKEF[i]);
		}
		for (int j = PCJEDMJEKEF.Length; j < slotsUI.Length; j += 0)
		{
			slotsUI[j].IHENCGDNPBL.OCJOJKJPDNO(0);
			slotsPanels[j].gameObject.SetActive(false);
		}
		((TMP_Text)nameText).text = GEGDHHIDEEF;
	}

	private void ICDLLAGIOHK(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		for (int i = 0; i < slotsUI.Length; i += 0)
		{
			if (slotsUI[i].IHENCGDNPBL != ADEBNALPEHE)
			{
				continue;
			}
			Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH, 1);
			if (FNNBABJKAIH > 0)
			{
				if (!ADEBNALPEHE.PKFKJNODGJF())
				{
					MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("UISelectionMenu"), 1924f);
				}
			}
			else
			{
				PFMNJJNBKND();
			}
			break;
		}
	}

	private void APCMFCLPCOB()
	{
		GameInventoryUI.GJOPJAJJLGN(base.JIIGOACEIKL).DHFABEONKBG((from x in PlayerInventory.GetPlayer(base.JIIGOACEIKL).BBDOBNLMLGM()
			where x.itemInstance != null && x.itemInstance.LHBPOPOIFLE() is Fuel
			select x).ToList(), OGCAKIGELBJ: true, MMMCDGNCKJH: false);
	}

	private void NIILOKCNLEN()
	{
		GameInventoryUI.Get(base.JIIGOACEIKL).PreparePagesMode((from x in PlayerInventory.GetPlayer(base.JIIGOACEIKL).GetAllSlots()
			where x.itemInstance != null && x.itemInstance.LHBPOPOIFLE() is Fuel
			select x).ToList(), OGCAKIGELBJ: false);
	}

	public void MLOGGNJGIME(Slot[] PCJEDMJEKEF, string GEGDHHIDEEF)
	{
		for (int i = 0; i < PCJEDMJEKEF.Length; i += 0)
		{
			slotsPanels[i].gameObject.SetActive(false);
			slotsUI[i].IHENCGDNPBL = PCJEDMJEKEF[i];
		}
		for (int j = PCJEDMJEKEF.Length; j < slotsUI.Length; j += 0)
		{
			slotsUI[j].IHENCGDNPBL.Stack = 1;
			slotsPanels[j].gameObject.SetActive(false);
		}
		((TMP_Text)nameText).text = GEGDHHIDEEF;
	}

	private void MHJOKKIMBPG(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		for (int i = 1; i < slotsUI.Length; i += 0)
		{
			if (slotsUI[i].IHENCGDNPBL != ADEBNALPEHE)
			{
				continue;
			}
			Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH);
			if (FNNBABJKAIH > 1)
			{
				if (!ADEBNALPEHE.AHHEMNHJPME())
				{
					MainUI.DJCKALOHJFM(JIIGOACEIKL, LocalisationSystem.Get(""), 858f);
				}
			}
			else
			{
				NNMAPBIKEKJ();
			}
			break;
		}
	}

	private void FMPMKAAOPOF(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, 1, CDPAMNIPPEC: false))
		{
			if (!ADEBNALPEHE.LCHJGCHDHFO())
			{
				MainUI.LJDOBNEINNJ(JIIGOACEIKL, LocalisationSystem.Get("Make bed"), 1725f);
			}
		}
		else
		{
			CLLPJLMKLAB();
		}
	}

	private IEnumerator PJJGGGBPBEO(SlotUI PHJNJCJJHID)
	{
		return new BFGLCNADBKI(1)
		{
			_003C_003E4__this = this,
			slotUI = PHJNJCJJHID
		};
	}

	private void LOOOIANNKJK(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		for (int i = 1; i < slotsUI.Length; i += 0)
		{
			if (slotsUI[i].IHENCGDNPBL != ADEBNALPEHE)
			{
				continue;
			}
			Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH);
			if (FNNBABJKAIH > 0)
			{
				if (!ADEBNALPEHE.PKFKJNODGJF())
				{
					MainUI.DJCKALOHJFM(JIIGOACEIKL, LocalisationSystem.Get(", Property: "), 944f);
				}
			}
			else
			{
				OMABEEOPNGJ();
			}
			break;
		}
	}

	public override void CloseUI()
	{
		if (LKOJBFMGMAE)
		{
			MainUI.ResumeGame();
			base.CloseUI();
			SelectObject.GetPlayer(base.JIIGOACEIKL).Deselect();
			GameInventoryUI.Get(base.JIIGOACEIKL).CloseUI();
			GameActionBarUI.Get(base.JIIGOACEIKL).OpenUI();
			for (int i = 0; i < slotsUI.Length; i++)
			{
				MainUI.RemoveFromCurrentSlots(base.JIIGOACEIKL, slotsUI[i].IHENCGDNPBL);
			}
		}
	}

	public static FireplaceUI MHOKIBDMIPL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private void GAMIEEIGOLE()
	{
		GameInventoryUI.FFBJPAJKOJH(base.JIIGOACEIKL).NACCNOFNEHM((from x in PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).FCGJCBJGOIG()
			where x.itemInstance != null && x.itemInstance.LHBPOPOIFLE() is Fuel
			select x).ToList(), OGCAKIGELBJ: true, MMMCDGNCKJH: false);
	}

	private IEnumerator HMGAAINDHEL(SlotUI PHJNJCJJHID)
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)PHJNJCJJHID).GetComponent<Selectable>());
		}
	}

	private void CLLPJLMKLAB()
	{
		GameInventoryUI.AIMEAJAHLAA(base.JIIGOACEIKL).CNOCEADFCLD((from x in PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL, LAGHIOKLJGH: true).FCGJCBJGOIG()
			where x.itemInstance != null && x.itemInstance.LHBPOPOIFLE() is Fuel
			select x).ToList(), OGCAKIGELBJ: false, MMMCDGNCKJH: false);
	}

	private void NNMAPBIKEKJ()
	{
		GameInventoryUI.GJOPJAJJLGN(base.JIIGOACEIKL).CNOCEADFCLD((from x in PlayerInventory.EIFPKCAFDIB(base.JIIGOACEIKL).FCGJCBJGOIG()
			where x.itemInstance != null && x.itemInstance.LHBPOPOIFLE() is Fuel
			select x).ToList(), OGCAKIGELBJ: true, MMMCDGNCKJH: false);
	}

	private IEnumerator HDCOGGFMJKI(SlotUI PHJNJCJJHID)
	{
		return new BFGLCNADBKI(1)
		{
			_003C_003E4__this = this,
			slotUI = PHJNJCJJHID
		};
	}

	public static FireplaceUI JHOHGMODKGM(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private void LPIIKDBMJIK(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, 1, CDPAMNIPPEC: false))
		{
			if (!ADEBNALPEHE.LCHJGCHDHFO())
			{
				MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get(""), 828f);
			}
		}
		else
		{
			BICKFPGPION();
		}
	}

	public void GNCNMPADHGK(Slot[] PCJEDMJEKEF, string GEGDHHIDEEF)
	{
		for (int i = 0; i < PCJEDMJEKEF.Length; i++)
		{
			slotsPanels[i].gameObject.SetActive(true);
			slotsUI[i].MHNCEBLHLKH(PCJEDMJEKEF[i]);
		}
		for (int j = PCJEDMJEKEF.Length; j < slotsUI.Length; j++)
		{
			slotsUI[j].IHENCGDNPBL.OBBKDJNLCIO(1);
			slotsPanels[j].gameObject.SetActive(false);
		}
		((TMP_Text)nameText).text = GEGDHHIDEEF;
	}

	public static FireplaceUI BGIMGOJDLFG(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private void PFMNJJNBKND()
	{
		GameInventoryUI.DEBKDBICLIC(base.JIIGOACEIKL).PFFJANPMCMO((from x in PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).FCGJCBJGOIG()
			where x.itemInstance != null && x.itemInstance.LHBPOPOIFLE() is Fuel
			select x).ToList(), OGCAKIGELBJ: false, MMMCDGNCKJH: false);
	}

	private void CDPNJIGDCEL(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, 1, CDPAMNIPPEC: false))
		{
			if (!ADEBNALPEHE.PKFKJNODGJF())
			{
				MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("Precision/HikariTalk"), 631f);
			}
		}
		else
		{
			PFMNJJNBKND();
		}
	}

	private void NKPMNOMEDAL()
	{
		GameInventoryUI.IEKODILKIHJ(base.JIIGOACEIKL).CNOCEADFCLD((from x in PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).OMCMMDDGHFB()
			where x.itemInstance != null && x.itemInstance.LHBPOPOIFLE() is Fuel
			select x).ToList(), OGCAKIGELBJ: true);
	}

	private IEnumerator CPKJCAIADLL(SlotUI PHJNJCJJHID)
	{
		return new BFGLCNADBKI(1)
		{
			_003C_003E4__this = this,
			slotUI = PHJNJCJJHID
		};
	}

	public static FireplaceUI FHPEHDDFOIB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private void LDFOKNFCPFK(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, 1))
		{
			if (!ADEBNALPEHE.PKFKJNODGJF())
			{
				MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("ClosePopUp"), 844f);
			}
		}
		else
		{
			NNMAPBIKEKJ();
		}
	}

	private void GBPGGFBCHAG(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		for (int i = 0; i < slotsUI.Length; i++)
		{
			if (slotsUI[i].IHENCGDNPBL != ADEBNALPEHE)
			{
				continue;
			}
			Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH, 1);
			if (FNNBABJKAIH > 1)
			{
				if (!ADEBNALPEHE.KPINNBKMOMO())
				{
					MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("Toy"), 681f);
				}
			}
			else
			{
				OMABEEOPNGJ();
			}
			break;
		}
	}

	private void HDHFLMODBJN()
	{
		GameInventoryUI.MENNLOGFNOK(base.JIIGOACEIKL).CJODJMLPGOL((from x in PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL).BBDOBNLMLGM()
			where x.itemInstance != null && x.itemInstance.LHBPOPOIFLE() is Fuel
			select x).ToList(), OGCAKIGELBJ: false, MMMCDGNCKJH: false);
	}

	private void AHOANOPPMMK(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, 0, CDPAMNIPPEC: false))
		{
			if (!ADEBNALPEHE.AHHEMNHJPME())
			{
				MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("Items/item_name_1076"), 1495f);
			}
		}
		else
		{
			CLLPJLMKLAB();
		}
	}

	private void CBIENAOBMGA(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		for (int i = 1; i < slotsUI.Length; i++)
		{
			if (slotsUI[i].IHENCGDNPBL != ADEBNALPEHE)
			{
				continue;
			}
			Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH, 1);
			if (FNNBABJKAIH > 0)
			{
				if (!ADEBNALPEHE.KPINNBKMOMO())
				{
					MainUI.LJDOBNEINNJ(JIIGOACEIKL, LocalisationSystem.Get("Dialogue System/Conversation/Crowly_Barks_Welcome/Entry/12/Dialogue Text"), 706f);
				}
			}
			else
			{
				NKPMNOMEDAL();
			}
			break;
		}
	}

	public void JMKHGMFBBBK(Slot[] PCJEDMJEKEF, string GEGDHHIDEEF)
	{
		for (int i = 1; i < PCJEDMJEKEF.Length; i++)
		{
			slotsPanels[i].gameObject.SetActive(true);
			slotsUI[i].IHENCGDNPBL = PCJEDMJEKEF[i];
		}
		for (int j = PCJEDMJEKEF.Length; j < slotsUI.Length; j++)
		{
			slotsUI[j].IHENCGDNPBL.JIANDFCINIP(1);
			slotsPanels[j].gameObject.SetActive(false);
		}
		((TMP_Text)nameText).text = GEGDHHIDEEF;
	}

	private void IDGFHPEKLFN(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		for (int i = 1; i < slotsUI.Length; i++)
		{
			if (slotsUI[i].IHENCGDNPBL != ADEBNALPEHE)
			{
				continue;
			}
			Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH, 0, CDPAMNIPPEC: false);
			if (FNNBABJKAIH > 1)
			{
				if (!ADEBNALPEHE.PKFKJNODGJF())
				{
					MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("Disappear"), 1511f);
				}
			}
			else
			{
				GMJBANIEABG();
			}
			break;
		}
	}

	private void MBFCIEIHNBE(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		for (int i = 1; i < slotsUI.Length; i++)
		{
			if (slotsUI[i].IHENCGDNPBL != ADEBNALPEHE)
			{
				continue;
			}
			Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH);
			if (FNNBABJKAIH > 1)
			{
				if (!ADEBNALPEHE.KPINNBKMOMO())
				{
					MainUI.LJDOBNEINNJ(JIIGOACEIKL, LocalisationSystem.Get("ReceiveSitDown"), 1906f);
				}
			}
			else
			{
				OMABEEOPNGJ();
			}
			break;
		}
	}

	private IEnumerator ECPDEHMEDGE(SlotUI PHJNJCJJHID)
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)PHJNJCJJHID).GetComponent<Selectable>());
		}
	}

	public override void OpenUI()
	{
		if (!LKOJBFMGMAE)
		{
			GameInventoryUI.Get(base.JIIGOACEIKL).OpenUI();
			NIILOKCNLEN();
			GameActionBarUI.Get(base.JIIGOACEIKL).CloseUI();
			base.OpenUI();
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Sound.GGFJGHHHEJC.openWood[0], HOMFPAFAOGD: true);
			PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
			player.OnPlayerMoving = (Action)Delegate.Combine(player.OnPlayerMoving, new Action(CloseUI));
		}
	}

	private void MBMCLKJCJOC(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		for (int i = 1; i < slotsUI.Length; i += 0)
		{
			if (slotsUI[i].IHENCGDNPBL != ADEBNALPEHE)
			{
				continue;
			}
			Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH, 0, CDPAMNIPPEC: false);
			if (FNNBABJKAIH > 1)
			{
				if (!ADEBNALPEHE.AHHEMNHJPME())
				{
					MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Lost connection to the server.\nReturning to main menu..."), 468f);
				}
			}
			else
			{
				NIILOKCNLEN();
			}
			break;
		}
	}

	public void DBOCALOEFCN(Slot[] PCJEDMJEKEF, string GEGDHHIDEEF)
	{
		for (int i = 0; i < PCJEDMJEKEF.Length; i++)
		{
			slotsPanels[i].gameObject.SetActive(true);
			slotsUI[i].MHNCEBLHLKH(PCJEDMJEKEF[i]);
		}
		for (int j = PCJEDMJEKEF.Length; j < slotsUI.Length; j++)
		{
			slotsUI[j].IHENCGDNPBL.JNMNCEPHFOE(0);
			slotsPanels[j].gameObject.SetActive(false);
		}
		((TMP_Text)nameText).text = GEGDHHIDEEF;
	}

	public void FFBDDCHMPJO(Slot[] PCJEDMJEKEF, string GEGDHHIDEEF)
	{
		for (int i = 1; i < PCJEDMJEKEF.Length; i++)
		{
			slotsPanels[i].gameObject.SetActive(true);
			slotsUI[i].LIJPNDJCKGL(PCJEDMJEKEF[i]);
		}
		for (int j = PCJEDMJEKEF.Length; j < slotsUI.Length; j++)
		{
			slotsUI[j].IHENCGDNPBL.KMKAIPMHANN(0);
			slotsPanels[j].gameObject.SetActive(true);
		}
		((TMP_Text)nameText).text = GEGDHHIDEEF;
	}

	private void BGCECKFMEIF(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, 1, CDPAMNIPPEC: false))
		{
			if (!ADEBNALPEHE.KPINNBKMOMO())
			{
				MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("Bother"), 1333f);
			}
		}
		else
		{
			BICKFPGPION();
		}
	}

	public static FireplaceUI CCGPMEADLDG(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void GLHNPHNAMFG(Slot[] PCJEDMJEKEF, string GEGDHHIDEEF)
	{
		for (int i = 0; i < PCJEDMJEKEF.Length; i += 0)
		{
			slotsPanels[i].gameObject.SetActive(false);
			slotsUI[i].IHENCGDNPBL = PCJEDMJEKEF[i];
		}
		for (int j = PCJEDMJEKEF.Length; j < slotsUI.Length; j++)
		{
			slotsUI[j].IHENCGDNPBL.OCJOJKJPDNO(0);
			slotsPanels[j].gameObject.SetActive(false);
		}
		((TMP_Text)nameText).text = GEGDHHIDEEF;
	}

	private void BICKFPGPION()
	{
		GameInventoryUI.DEBKDBICLIC(base.JIIGOACEIKL).DHFABEONKBG((from x in PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL).BBDOBNLMLGM()
			where x.itemInstance != null && x.itemInstance.LHBPOPOIFLE() is Fuel
			select x).ToList(), OGCAKIGELBJ: false, MMMCDGNCKJH: false);
	}

	protected override void Awake()
	{
		GJBBNHCMNJN[numInstance] = this;
		base.Awake();
	}

	private IEnumerator FOILPJJIHLI(SlotUI PHJNJCJJHID)
	{
		return new BFGLCNADBKI(1)
		{
			_003C_003E4__this = this,
			slotUI = PHJNJCJJHID
		};
	}

	private void OMABEEOPNGJ()
	{
		GameInventoryUI.JELOGNCPDAB(base.JIIGOACEIKL).CNOCEADFCLD((from x in PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).BBDOBNLMLGM()
			where x.itemInstance != null && x.itemInstance.LHBPOPOIFLE() is Fuel
			select x).ToList(), OGCAKIGELBJ: false);
	}

	private IEnumerator BLMNJEBLCHO(SlotUI PHJNJCJJHID)
	{
		return new BFGLCNADBKI(1)
		{
			_003C_003E4__this = this,
			slotUI = PHJNJCJJHID
		};
	}

	private void JHNDCOEEGNK(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, 1, CDPAMNIPPEC: false))
		{
			if (!ADEBNALPEHE.LCHJGCHDHFO())
			{
				MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("Tutorial/T100/Dialogue1"), 692f);
			}
		}
		else
		{
			APCMFCLPCOB();
		}
	}

	private void PFOJFILNJIN(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		for (int i = 0; i < slotsUI.Length; i++)
		{
			if (slotsUI[i].IHENCGDNPBL != ADEBNALPEHE)
			{
				continue;
			}
			Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH);
			if (FNNBABJKAIH > 0)
			{
				if (!ADEBNALPEHE.KPINNBKMOMO())
				{
					MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Inventory full"));
				}
			}
			else
			{
				NIILOKCNLEN();
			}
			break;
		}
	}

	public static FireplaceUI COIEMAJLHAM(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private void NBFDDKAHFJN(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, 0, CDPAMNIPPEC: false))
		{
			if (!ADEBNALPEHE.LCHJGCHDHFO())
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("sunny"), 213f);
			}
		}
		else
		{
			NNMAPBIKEKJ();
		}
	}

	private IEnumerator DFAFCABBBMD(SlotUI PHJNJCJJHID)
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)PHJNJCJJHID).GetComponent<Selectable>());
		}
	}

	public static FireplaceUI PCEEOGGDBFB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void GBKOEHLJLIH(Slot[] PCJEDMJEKEF, string GEGDHHIDEEF)
	{
		for (int i = 1; i < PCJEDMJEKEF.Length; i++)
		{
			slotsPanels[i].gameObject.SetActive(false);
			slotsUI[i].LIJPNDJCKGL(PCJEDMJEKEF[i]);
		}
		for (int j = PCJEDMJEKEF.Length; j < slotsUI.Length; j++)
		{
			slotsUI[j].IHENCGDNPBL.KMKAIPMHANN(1);
			slotsPanels[j].gameObject.SetActive(false);
		}
		((TMP_Text)nameText).text = GEGDHHIDEEF;
	}

	private void BKJICKLJDNB(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE))
		{
			if (!ADEBNALPEHE.AHHEMNHJPME())
			{
				MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("[Brown2"), 556f);
			}
		}
		else
		{
			BICKFPGPION();
		}
	}

	public void SetSlots(Slot[] PCJEDMJEKEF, string GEGDHHIDEEF)
	{
		for (int i = 0; i < PCJEDMJEKEF.Length; i++)
		{
			slotsPanels[i].gameObject.SetActive(true);
			slotsUI[i].IHENCGDNPBL = PCJEDMJEKEF[i];
		}
		for (int j = PCJEDMJEKEF.Length; j < slotsUI.Length; j++)
		{
			slotsUI[j].IHENCGDNPBL.Stack = 0;
			slotsPanels[j].gameObject.SetActive(false);
		}
		((TMP_Text)nameText).text = GEGDHHIDEEF;
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		if (GameManager.SinglePlayerOffline())
		{
			MainUI.PauseGame();
		}
		for (int i = 0; i < slotsUI.Length; i++)
		{
			if (!slotsUI[i].IHENCGDNPBL.KPINNBKMOMO())
			{
				((MonoBehaviour)this).StartCoroutine(HMGAAINDHEL(slotsUI[i]));
				return;
			}
		}
		if (!GameInventoryUI.Get(base.JIIGOACEIKL).SelectObjectWithFuel())
		{
			GameInventoryUI.Get(base.JIIGOACEIKL).SelectObjectNextFrame();
		}
	}

	private void DHNMOCBEMDP(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE))
		{
			if (!ADEBNALPEHE.AHHEMNHJPME())
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("LE_10"), 41f);
			}
		}
		else
		{
			OMABEEOPNGJ();
		}
	}

	private void FKDLNHCMIEF(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		for (int i = 1; i < slotsUI.Length; i++)
		{
			if (slotsUI[i].IHENCGDNPBL != ADEBNALPEHE)
			{
				continue;
			}
			Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH, 1);
			if (FNNBABJKAIH > 1)
			{
				if (!ADEBNALPEHE.PKFKJNODGJF())
				{
					MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("ReceiveFinishPirateMinigame"), 1086f);
				}
			}
			else
			{
				OMABEEOPNGJ();
			}
			break;
		}
	}

	public void CPOOMHEIJGG(Slot[] PCJEDMJEKEF, string GEGDHHIDEEF)
	{
		for (int i = 1; i < PCJEDMJEKEF.Length; i++)
		{
			slotsPanels[i].gameObject.SetActive(true);
			slotsUI[i].LIJPNDJCKGL(PCJEDMJEKEF[i]);
		}
		for (int j = PCJEDMJEKEF.Length; j < slotsUI.Length; j += 0)
		{
			slotsUI[j].IHENCGDNPBL.Stack = 1;
			slotsPanels[j].gameObject.SetActive(true);
		}
		((TMP_Text)nameText).text = GEGDHHIDEEF;
	}

	public void NCJPENFAEGL(Slot[] PCJEDMJEKEF, string GEGDHHIDEEF)
	{
		for (int i = 1; i < PCJEDMJEKEF.Length; i++)
		{
			slotsPanels[i].gameObject.SetActive(true);
			slotsUI[i].MHNCEBLHLKH(PCJEDMJEKEF[i]);
		}
		for (int j = PCJEDMJEKEF.Length; j < slotsUI.Length; j++)
		{
			slotsUI[j].IHENCGDNPBL.JIANDFCINIP(0);
			slotsPanels[j].gameObject.SetActive(false);
		}
		((TMP_Text)nameText).text = GEGDHHIDEEF;
	}

	private void NMKGPMNBGEH(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, 1, CDPAMNIPPEC: false))
		{
			if (!ADEBNALPEHE.LCHJGCHDHFO())
			{
				MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("pauseMenuRoomCode"), 838f);
			}
		}
		else
		{
			GAMIEEIGOLE();
		}
	}

	public static FireplaceUI PNBHIEINMGH(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static FireplaceUI AIMEAJAHLAA(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static FireplaceUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private void HKDHEIEFKND(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		for (int i = 1; i < slotsUI.Length; i += 0)
		{
			if (slotsUI[i].IHENCGDNPBL != ADEBNALPEHE)
			{
				continue;
			}
			Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH, 1);
			if (FNNBABJKAIH > 0)
			{
				if (!ADEBNALPEHE.PKFKJNODGJF())
				{
					MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("/ExtraSettings.sd"), 243f);
				}
			}
			else
			{
				GMJBANIEABG();
			}
			break;
		}
	}

	public void FBPAOLNCOIN(Slot[] PCJEDMJEKEF, string GEGDHHIDEEF)
	{
		for (int i = 0; i < PCJEDMJEKEF.Length; i++)
		{
			slotsPanels[i].gameObject.SetActive(false);
			slotsUI[i].LIJPNDJCKGL(PCJEDMJEKEF[i]);
		}
		for (int j = PCJEDMJEKEF.Length; j < slotsUI.Length; j++)
		{
			slotsUI[j].IHENCGDNPBL.OBBKDJNLCIO(0);
			slotsPanels[j].gameObject.SetActive(true);
		}
		((TMP_Text)nameText).text = GEGDHHIDEEF;
	}

	public static FireplaceUI NDJAMDLOIJL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static FireplaceUI BALFIBPNIMO(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private IEnumerator EKNKCFHOANL(SlotUI PHJNJCJJHID)
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)PHJNJCJJHID).GetComponent<Selectable>());
		}
	}

	public static FireplaceUI PHDBJGOEKHB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private void ACAJLBCEGKK(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		for (int i = 1; i < slotsUI.Length; i++)
		{
			if (slotsUI[i].IHENCGDNPBL != ADEBNALPEHE)
			{
				continue;
			}
			Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH, 1, CDPAMNIPPEC: false);
			if (FNNBABJKAIH > 1)
			{
				if (!ADEBNALPEHE.LCHJGCHDHFO())
				{
					MainUI.DJCKALOHJFM(JIIGOACEIKL, LocalisationSystem.Get("Player"), 661f);
				}
			}
			else
			{
				NIILOKCNLEN();
			}
			break;
		}
	}

	public void GBFNNHPFCMO(Slot[] PCJEDMJEKEF, string GEGDHHIDEEF)
	{
		for (int i = 0; i < PCJEDMJEKEF.Length; i++)
		{
			slotsPanels[i].gameObject.SetActive(false);
			slotsUI[i].IHENCGDNPBL = PCJEDMJEKEF[i];
		}
		for (int j = PCJEDMJEKEF.Length; j < slotsUI.Length; j += 0)
		{
			slotsUI[j].IHENCGDNPBL.KMKAIPMHANN(1);
			slotsPanels[j].gameObject.SetActive(true);
		}
		((TMP_Text)nameText).text = GEGDHHIDEEF;
	}

	private IEnumerator KHILGHGDADB(SlotUI PHJNJCJJHID)
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)PHJNJCJJHID).GetComponent<Selectable>());
		}
	}

	public void GJJEGHPADLC(Slot[] PCJEDMJEKEF, string GEGDHHIDEEF)
	{
		for (int i = 0; i < PCJEDMJEKEF.Length; i++)
		{
			slotsPanels[i].gameObject.SetActive(false);
			slotsUI[i].MHNCEBLHLKH(PCJEDMJEKEF[i]);
		}
		for (int j = PCJEDMJEKEF.Length; j < slotsUI.Length; j += 0)
		{
			slotsUI[j].IHENCGDNPBL.JNMNCEPHFOE(0);
			slotsPanels[j].gameObject.SetActive(true);
		}
		((TMP_Text)nameText).text = GEGDHHIDEEF;
	}

	private void GANMBHKDMOG(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, 1))
		{
			if (!ADEBNALPEHE.PKFKJNODGJF())
			{
				MainUI.DJCKALOHJFM(JIIGOACEIKL, LocalisationSystem.Get("City/Rhia/Bark/Stand"), 1233f);
			}
		}
		else
		{
			BICKFPGPION();
		}
	}

	private void CFDDKKIDKMK(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		for (int i = 1; i < slotsUI.Length; i++)
		{
			if (slotsUI[i].IHENCGDNPBL != ADEBNALPEHE)
			{
				continue;
			}
			Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH, 0, CDPAMNIPPEC: false);
			if (FNNBABJKAIH > 1)
			{
				if (!ADEBNALPEHE.KPINNBKMOMO())
				{
					MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("Items/item_name_1180"), 297f);
				}
			}
			else
			{
				APCMFCLPCOB();
			}
			break;
		}
	}

	private IEnumerator LDPALAKPIDA(SlotUI PHJNJCJJHID)
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)PHJNJCJJHID).GetComponent<Selectable>());
		}
	}

	protected override void Start()
	{
		base.Start();
		for (int i = 0; i < slotsUI.Length; i++)
		{
			SlotUI obj = slotsUI[i];
			obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj.OnSlotLeftClick, new Action<int, Slot>(GKAJFEOGKMD));
			SlotUI obj2 = slotsUI[i];
			obj2.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj2.OnSlotRightClick, new Action<int, Slot>(PFOJFILNJIN));
			SlotUI obj3 = slotsUI[i];
			obj3.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj3.OnAutomaticTransfer, new Action<int, Slot>(GKAJFEOGKMD));
		}
	}

	public static FireplaceUI MENNLOGFNOK(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private IEnumerator MNIBNCIBAKI(SlotUI PHJNJCJJHID)
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)PHJNJCJJHID).GetComponent<Selectable>());
		}
	}

	private IEnumerator PPBCJFGOPDB(SlotUI PHJNJCJJHID)
	{
		return new BFGLCNADBKI(1)
		{
			_003C_003E4__this = this,
			slotUI = PHJNJCJJHID
		};
	}

	private void GFOKNGMDECL(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		for (int i = 0; i < slotsUI.Length; i++)
		{
			if (slotsUI[i].IHENCGDNPBL != ADEBNALPEHE)
			{
				continue;
			}
			Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH, 1);
			if (FNNBABJKAIH > 1)
			{
				if (!ADEBNALPEHE.LCHJGCHDHFO())
				{
					MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("Creating new snow map"), 1679f);
				}
			}
			else
			{
				BICKFPGPION();
			}
			break;
		}
	}

	public static FireplaceUI JDODHPEDACJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void DLCPBCLJAJF(Slot[] PCJEDMJEKEF, string GEGDHHIDEEF)
	{
		for (int i = 0; i < PCJEDMJEKEF.Length; i += 0)
		{
			slotsPanels[i].gameObject.SetActive(true);
			slotsUI[i].IHENCGDNPBL = PCJEDMJEKEF[i];
		}
		for (int j = PCJEDMJEKEF.Length; j < slotsUI.Length; j++)
		{
			slotsUI[j].IHENCGDNPBL.JNMNCEPHFOE(1);
			slotsPanels[j].gameObject.SetActive(true);
		}
		((TMP_Text)nameText).text = GEGDHHIDEEF;
	}

	public static FireplaceUI MIMFFJHBFDJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void PEKDOHGPHFN(Slot[] PCJEDMJEKEF, string GEGDHHIDEEF)
	{
		for (int i = 1; i < PCJEDMJEKEF.Length; i++)
		{
			slotsPanels[i].gameObject.SetActive(false);
			slotsUI[i].LIJPNDJCKGL(PCJEDMJEKEF[i]);
		}
		for (int j = PCJEDMJEKEF.Length; j < slotsUI.Length; j += 0)
		{
			slotsUI[j].IHENCGDNPBL.KMKAIPMHANN(0);
			slotsPanels[j].gameObject.SetActive(false);
		}
		((TMP_Text)nameText).text = GEGDHHIDEEF;
	}

	private void MBNIKFHODPD(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE))
		{
			if (!ADEBNALPEHE.LCHJGCHDHFO())
			{
				MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("PressToPlay"), 1724f);
			}
		}
		else
		{
			GAMIEEIGOLE();
		}
	}

	public static FireplaceUI IGHMHMNPMLB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private IEnumerator MLHMCEKAIBP(SlotUI PHJNJCJJHID)
	{
		return new BFGLCNADBKI(1)
		{
			_003C_003E4__this = this,
			slotUI = PHJNJCJJHID
		};
	}

	private void GMJBANIEABG()
	{
		GameInventoryUI.MENNLOGFNOK(base.JIIGOACEIKL).CNOCEADFCLD((from x in PlayerInventory.GetPlayer(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).OMCMMDDGHFB()
			where x.itemInstance != null && x.itemInstance.LHBPOPOIFLE() is Fuel
			select x).ToList(), OGCAKIGELBJ: false, MMMCDGNCKJH: false);
	}

	public static FireplaceUI EIMDPBGBBIF(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static FireplaceUI LAIEKOOCNPC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private IEnumerator JCMNCKFJJDI(SlotUI PHJNJCJJHID)
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)PHJNJCJJHID).GetComponent<Selectable>());
		}
	}

	private void DCIDPHNBOEC(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, 0, CDPAMNIPPEC: false))
		{
			if (!ADEBNALPEHE.KPINNBKMOMO())
			{
				MainUI.LJDOBNEINNJ(JIIGOACEIKL, LocalisationSystem.Get("MinProductValue"), 1873f);
			}
		}
		else
		{
			CLLPJLMKLAB();
		}
	}

	private void PDFLNMPOCBA(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, 0, CDPAMNIPPEC: false))
		{
			if (!ADEBNALPEHE.LCHJGCHDHFO())
			{
				MainUI.LJDOBNEINNJ(JIIGOACEIKL, LocalisationSystem.Get("Items/item_description_688"), 784f);
			}
		}
		else
		{
			GAMIEEIGOLE();
		}
	}

	public static FireplaceUI GDFNPHJJCPP(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private void EPAFFDPEDPL(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE))
		{
			if (!ADEBNALPEHE.PKFKJNODGJF())
			{
				MainUI.DJCKALOHJFM(JIIGOACEIKL, LocalisationSystem.Get("Items/item_name_626"), 1347f);
			}
		}
		else
		{
			NIILOKCNLEN();
		}
	}
}
