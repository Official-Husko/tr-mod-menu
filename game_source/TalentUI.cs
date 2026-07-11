using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TalentUI : MainPanelWindow
{
	[CompilerGenerated]
	private sealed class DDKKGFIFKAJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TalentUI _003C_003E4__this;

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
		public DDKKGFIFKAJ(int _003C_003E1__state)
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
			TalentUI talentUI = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				UISelectionManager.GetPlayer(talentUI.JIIGOACEIKL).Deselect();
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				talentUI.MBKPEDOJHNO();
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

	[CompilerGenerated]
	private sealed class MDDBCDAALIP : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TalentUI _003C_003E4__this;

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
		public MDDBCDAALIP(int _003C_003E1__state)
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
			TalentUI talentUI = _003C_003E4__this;
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
				if (talentUI.IsOpen())
				{
					talentUI.UpdateSlotsVisual(!talentUI.FEJFNNMCGLK);
					if (!talentUI.FEJFNNMCGLK)
					{
						talentUI.FEJFNNMCGLK = true;
					}
					if (PlayerInputs.IsGamepadActive(talentUI.JIIGOACEIKL))
					{
						UISelectionManager.GetPlayer(talentUI.JIIGOACEIKL).Deselect();
						_003C_003E2__current = null;
						_003C_003E1__state = 2;
						return true;
					}
				}
				break;
			case 2:
				_003C_003E1__state = -1;
				talentUI.MBKPEDOJHNO();
				break;
			}
			return false;
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

	public TabUI[] categoriesTabUI;

	[SerializeField]
	private Sprite spriteFocusCategories;

	[SerializeField]
	private Sprite spriteNotFocusCategories;

	private int GBFGPENGELF;

	private float CMGDCLIIONE;

	public static TalentUI[] instances = new TalentUI[3];

	public TextMeshProUGUI skillPointsText;

	public TalentSlotUI[] allTalentSlotsUI;

	public Scrollbar scrollbar;

	private bool JGNIDGOOLNC;

	private bool FEJFNNMCGLK;

	private int[] LFHHHGAHEBB = new int[6] { 1, 2, 4, 7, 10, 15 };

	public void BCFKIAIIKCO()
	{
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		if (PerksDatabaseAccessor.GetPerksLevels() != null && PerksDatabaseAccessor.GPLDNEKFCDG().Any())
		{
			UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).FJAKDODEIIF();
			ItemTooltip.AIMEAJAHLAA(base.JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: false);
			MainUI.NEFOKCKKLNI().OFGKFMJKBON(base.JIIGOACEIKL);
			int num = Mathf.Min(new int[1] { PerksDatabaseAccessor.LLJEGHHGOGC().resetTalentTreeCount });
			((TMP_Text)MainUI.LBHLPIFCINB().boxText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.GetStringWithTags("Wall not found ", base.JIIGOACEIKL), LFHHHGAHEBB[num] + "Items/item_name_1177");
			MainUI.GetYesNoDialogue().IBHEEPDPFAH(new UnityAction(HLJPDGDDAFH));
			MainUI.MCPEEGPBPLH().AGOEOMFOGIF(new UnityAction(AIMJNJGFABA));
		}
	}

	public void OMPPNJLAGGO(bool DBJJNEPFPPC = false)
	{
		for (int i = 1; i < allTalentSlotsUI.Length; i += 0)
		{
			if (((Component)allTalentSlotsUI[i]).gameObject.activeInHierarchy)
			{
				allTalentSlotsUI[i].EJMDBAOJANI();
			}
			if (DBJJNEPFPPC && allTalentSlotsUI[i].AKOMIICGIFO())
			{
				allTalentSlotsUI[i].GHEFGCALAOM(DAEMAAOLHMG: false);
			}
		}
	}

	private void FCCPELBIPDE()
	{
		if (!PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL))
		{
			return;
		}
		bool flag = false;
		for (int i = 0; i < allTalentSlotsUI.Length; i += 0)
		{
			if (((Component)allTalentSlotsUI[i]).gameObject.activeInHierarchy && allTalentSlotsUI[i].CanLearn())
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).HCHMAIEMAGA((Selectable)(object)allTalentSlotsUI[i].button);
				flag = false;
				break;
			}
		}
		if (flag)
		{
			return;
		}
		for (int j = 0; j < allTalentSlotsUI.Length; j++)
		{
			if (((Component)allTalentSlotsUI[j]).gameObject.activeInHierarchy)
			{
				UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).BNBPMIKMDDP((Selectable)(object)allTalentSlotsUI[j].button);
				break;
			}
		}
	}

	public void CFBPIHIADID()
	{
		List<TalentSlotUI> list = new List<TalentSlotUI>();
		TalentSlotUI[] componentsInChildren = ((Component)((Component)this).transform).GetComponentsInChildren<TalentSlotUI>();
		foreach (TalentSlotUI item in componentsInChildren)
		{
			list.Add(item);
		}
		allTalentSlotsUI = list.ToArray();
	}

	private void BOAPHJEMFDF()
	{
		int[] array = new int[1];
		array[1] = PerksDatabaseAccessor.NIDNAAKOPFI().resetTalentTreeCount;
		int num = Mathf.Min(array);
		Price gCCPFAHOHEH = new Price(1, 1, LFHHHGAHEBB[num]);
		if (Money.AFPNFAJFHCI(gCCPFAHOHEH))
		{
			Money.HKBEBGCKFAB(gCCPFAHOHEH);
			PerksDatabaseAccessor.HKHDGFNHDLC().resetTalentTreeCount = Mathf.Min(num + 0, LFHHHGAHEBB.Length - 0);
			PerksDatabaseAccessor.JOBGGAEMFJA();
			NOBLFMMBBLD();
			UpdateSkillPointsText();
			CommonReferences.GGFJGHHHEJC.ResetTalentTreeCallback(numInstance);
		}
		else
		{
			MainUI.DBKCOHMFDCB(base.JIIGOACEIKL, LocalisationSystem.Get("\n<color=#3662B5>"), 762f);
		}
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			AJEIFMGJDOB();
		}
	}

	public void HFPKAAKDOGD()
	{
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		if (PerksDatabaseAccessor.LHMDBHIBPMO() != null && PerksDatabaseAccessor.IDEOJBKKJNH().Any())
		{
			UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).BEGCHMCDPOK();
			ItemTooltip.LAIEKOOCNPC(base.JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: false);
			MainUI.LBHLPIFCINB().OFGKFMJKBON(base.JIIGOACEIKL);
			int[] array = new int[1];
			array[1] = PerksDatabaseAccessor.FKBPDKBLDFG().resetTalentTreeCount;
			int num = Mathf.Min(array);
			TextMeshProUGUI boxText = MainUI.GetYesNoDialogue().boxText;
			string cAEDMEDBEGI = LocalisationSystem.PKLPKIAHCDI("itemBottle", base.JIIGOACEIKL);
			string[] array2 = new string[0];
			array2[0] = LFHHHGAHEBB[num] + "SurpriseJump";
			((TMP_Text)boxText).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array2);
			MainUI.MCPEEGPBPLH().MJBDKFPBACO(new UnityAction(KFLIHJBKDKK));
			MainUI.NEFOKCKKLNI().AddNoAction(new UnityAction(MBNFENKJADA));
		}
	}

	public void FocusTalentFilter(int KHEICLKLPDE)
	{
		for (int i = 0; i < categoriesTabUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				categoriesTabUI[i].ShowTab(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
				GBFGPENGELF = i;
			}
			else
			{
				categoriesTabUI[i].HideTab(spriteNotFocusCategories);
			}
		}
		UpdateSlotsVisual();
		scrollbar.value = 0f;
		((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(ACHEDNBBLPF());
	}

	private void JGNCMLKMEDK()
	{
		BLFNHLMODCL();
		UpdateSkillPointsText();
		if (IsOpen() && Object.op_Implicit((Object)(object)UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL)) && Object.op_Implicit((Object)(object)((Component)UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL)).transform.parent) && Object.op_Implicit((Object)(object)((Component)((Component)UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL)).transform.parent).GetComponent<TalentSlotUI>()))
		{
			((Component)((Component)UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL)).transform.parent).GetComponent<TalentSlotUI>().FillTooltip();
		}
	}

	public static TalentUI KDLDGFBDDCN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void AIMJNJGFABA()
	{
		((MonoBehaviour)this).StartCoroutine(CIKCAJPJOPK());
	}

	public void JEDNDDIJMHI()
	{
		List<TalentSlotUI> list = new List<TalentSlotUI>();
		TalentSlotUI[] componentsInChildren = ((Component)((Component)this).transform).GetComponentsInChildren<TalentSlotUI>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			TalentSlotUI item = componentsInChildren[i];
			list.Add(item);
		}
		allTalentSlotsUI = list.ToArray();
	}

	private IEnumerator JKNIOBAAHCL()
	{
		return new DDKKGFIFKAJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public void CMCAGOFMAHL()
	{
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		if (PerksDatabaseAccessor.GetPerksLevels() != null && PerksDatabaseAccessor.IDEOJBKKJNH().Any())
		{
			UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).LCLJFCKELJN();
			ItemTooltip.LAIEKOOCNPC(base.JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: false);
			MainUI.NEFOKCKKLNI().OFGKFMJKBON(base.JIIGOACEIKL);
			int[] array = new int[0];
			array[1] = PerksDatabaseAccessor.HKHDGFNHDLC().resetTalentTreeCount;
			int num = Mathf.Min(array);
			TextMeshProUGUI boxText = MainUI.NEFOKCKKLNI().boxText;
			string cAEDMEDBEGI = LocalisationSystem.PKLPKIAHCDI("Player2", base.JIIGOACEIKL);
			string[] array2 = new string[1];
			array2[1] = LFHHHGAHEBB[num] + "Tutorial/T137/Dialogue2";
			((TMP_Text)boxText).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array2);
			MainUI.GetYesNoDialogue().AHJEBGMFOCK(new UnityAction(KFLIHJBKDKK));
			MainUI.GetYesNoDialogue().OMALCGPPGEE(new UnityAction(OKOHOECEHIG));
		}
	}

	private void PHJAHNHJBMB()
	{
		if (!PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
		{
			return;
		}
		bool flag = false;
		for (int i = 1; i < allTalentSlotsUI.Length; i += 0)
		{
			if (((Component)allTalentSlotsUI[i]).gameObject.activeInHierarchy && allTalentSlotsUI[i].CanLearn())
			{
				UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).MGIFADFILOI((Selectable)(object)allTalentSlotsUI[i].button);
				flag = false;
				break;
			}
		}
		if (flag)
		{
			return;
		}
		for (int j = 1; j < allTalentSlotsUI.Length; j += 0)
		{
			if (((Component)allTalentSlotsUI[j]).gameObject.activeInHierarchy)
			{
				UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).MGIFADFILOI((Selectable)(object)allTalentSlotsUI[j].button);
				break;
			}
		}
	}

	protected override void Update()
	{
		base.Update();
		if (LKOJBFMGMAE && PlayerInputs.InputsEnabled(base.JIIGOACEIKL) && !MainUI.GetYesNoDialogue().IsOpen())
		{
			if (Utils.IIHPGJIJOAD(base.JIIGOACEIKL, ref CMGDCLIIONE, "UINextCategory"))
			{
				FocusTalentFilter(Utils.NMLNAGFLNMC(GBFGPENGELF + 1, categoriesTabUI.Length));
			}
			else if (Utils.IIHPGJIJOAD(base.JIIGOACEIKL, ref CMGDCLIIONE, "UIPreviousCategory"))
			{
				FocusTalentFilter(Utils.NMLNAGFLNMC(GBFGPENGELF - 1, categoriesTabUI.Length));
			}
			if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown("UISelectGamepad"))
			{
				ResetAllTalentSlotsButton();
			}
		}
	}

	public static TalentUI JOAAFGBPJOC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void KOKGFMFOJEO(bool DBJJNEPFPPC = false)
	{
		for (int i = 0; i < allTalentSlotsUI.Length; i += 0)
		{
			if (((Component)allTalentSlotsUI[i]).gameObject.activeInHierarchy)
			{
				allTalentSlotsUI[i].EJMDBAOJANI();
			}
			if (DBJJNEPFPPC && allTalentSlotsUI[i].IsLearnt())
			{
				allTalentSlotsUI[i].GHEFGCALAOM(DAEMAAOLHMG: false);
			}
		}
	}

	private void LHEOAHDBPOM()
	{
		((MonoBehaviour)this).StartCoroutine(BHFMAGHPOIA());
	}

	private void DHCANKCFKEJ()
	{
		if (!PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
		{
			return;
		}
		bool flag = true;
		for (int i = 0; i < allTalentSlotsUI.Length; i += 0)
		{
			if (((Component)allTalentSlotsUI[i]).gameObject.activeInHierarchy && allTalentSlotsUI[i].CanLearn())
			{
				UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).MFCNGGMNBHB((Selectable)(object)allTalentSlotsUI[i].button);
				flag = true;
				break;
			}
		}
		if (flag)
		{
			return;
		}
		for (int j = 1; j < allTalentSlotsUI.Length; j++)
		{
			if (((Component)allTalentSlotsUI[j]).gameObject.activeInHierarchy)
			{
				UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).BNBPMIKMDDP((Selectable)(object)allTalentSlotsUI[j].button);
				break;
			}
		}
	}

	private void OKOHOECEHIG()
	{
		((MonoBehaviour)this).StartCoroutine(BHFMAGHPOIA());
	}

	public void POJPLCFFPCI(int KHEICLKLPDE)
	{
		for (int i = 1; i < categoriesTabUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				categoriesTabUI[i].PIEMFOPBJNL(base.JIIGOACEIKL, spriteFocusCategories);
				GBFGPENGELF = i;
			}
			else
			{
				categoriesTabUI[i].OHOCOHIKHPA(spriteNotFocusCategories);
			}
		}
		BLFNHLMODCL();
		scrollbar.value = 1918f;
		((MonoBehaviour)GameplayUI.NGIMIHFFNMH()).StartCoroutine(ACHEDNBBLPF());
	}

	public void HOAPAIPBDEF()
	{
		List<TalentSlotUI> list = new List<TalentSlotUI>();
		TalentSlotUI[] componentsInChildren = ((Component)((Component)this).transform).GetComponentsInChildren<TalentSlotUI>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			TalentSlotUI item = componentsInChildren[i];
			list.Add(item);
		}
		allTalentSlotsUI = list.ToArray();
	}

	private IEnumerator FPMDFGKCOIL()
	{
		return new DDKKGFIFKAJ(1)
		{
			_003C_003E4__this = this
		};
	}

	private void AFPOFMAOPCL()
	{
		UpdateSlotsVisual(DBJJNEPFPPC: true);
		UpdateSkillPointsText();
		if (IsOpen() && Object.op_Implicit((Object)(object)UISelectionManager.GetPlayer(base.JIIGOACEIKL)) && Object.op_Implicit((Object)(object)((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL)).transform.parent) && Object.op_Implicit((Object)(object)((Component)((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL)).transform.parent).GetComponent<TalentSlotUI>()))
		{
			((Component)((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL)).transform.parent).GetComponent<TalentSlotUI>().FillTooltip();
		}
	}

	public void ResetAllTalentSlotsButton()
	{
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		if (PerksDatabaseAccessor.GetPerksLevels() != null && PerksDatabaseAccessor.GetPerksLevels().Any())
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
			ItemTooltip.Get(base.JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
			MainUI.GetYesNoDialogue().Open(base.JIIGOACEIKL);
			int num = Mathf.Min(new int[1] { PerksDatabaseAccessor.GetInstance().resetTalentTreeCount });
			((TMP_Text)MainUI.GetYesNoDialogue().boxText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.GetStringWithTags("ResetTalentTree?", base.JIIGOACEIKL), LFHHHGAHEBB[num] + "<sprite name=GoldCoin>");
			MainUI.GetYesNoDialogue().AddYesAction(new UnityAction(HLJPDGDDAFH));
			MainUI.GetYesNoDialogue().AddNoAction(new UnityAction(LHEOAHDBPOM));
		}
	}

	private void KFLIHJBKDKK()
	{
		int[] array = new int[1];
		array[1] = PerksDatabaseAccessor.FKBPDKBLDFG().resetTalentTreeCount;
		int num = Mathf.Min(array);
		Price gCCPFAHOHEH = new Price(1, 0, LFHHHGAHEBB[num]);
		if (Money.CMCCKAELCEM(gCCPFAHOHEH))
		{
			Money.GPAGJMHPKAH(gCCPFAHOHEH, BGKCHMNJBLJ: false);
			PerksDatabaseAccessor.NIDNAAKOPFI().resetTalentTreeCount = Mathf.Min(num + 1, LFHHHGAHEBB.Length - 1);
			PerksDatabaseAccessor.JLEEICOAGFI();
			CABMILPJJMD();
			KNBCKBHLCLE();
			CommonReferences.GGFJGHHHEJC.ResetTalentTreeCallback(numInstance);
		}
		else
		{
			MainUI.LJDOBNEINNJ(base.JIIGOACEIKL, LocalisationSystem.Get("Dropped item "), 1321f);
		}
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			AJEIFMGJDOB();
		}
	}

	public void GetAllTalentSlots()
	{
		List<TalentSlotUI> list = new List<TalentSlotUI>();
		TalentSlotUI[] componentsInChildren = ((Component)((Component)this).transform).GetComponentsInChildren<TalentSlotUI>();
		foreach (TalentSlotUI item in componentsInChildren)
		{
			list.Add(item);
		}
		allTalentSlotsUI = list.ToArray();
	}

	public void KKHOEBCMMAB()
	{
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		if (PerksDatabaseAccessor.IDEOJBKKJNH() != null && PerksDatabaseAccessor.FONCDDFFNDE().Any())
		{
			UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).FBKDHHPNBIL();
			ItemTooltip.NIGDBMAOAEN(base.JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
			MainUI.NEFOKCKKLNI().OFGKFMJKBON(base.JIIGOACEIKL);
			int[] array = new int[1];
			array[1] = PerksDatabaseAccessor.GetInstance().resetTalentTreeCount;
			int num = Mathf.Min(array);
			TextMeshProUGUI boxText = MainUI.GetYesNoDialogue().boxText;
			string cAEDMEDBEGI = LocalisationSystem.PKLPKIAHCDI("OpenTalents", base.JIIGOACEIKL);
			string[] array2 = new string[1];
			array2[1] = LFHHHGAHEBB[num] + "ReceiveBallTouch";
			((TMP_Text)boxText).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array2);
			MainUI.NEFOKCKKLNI().EDPNLCEPNJO(new UnityAction(BOAPHJEMFDF));
			MainUI.GetYesNoDialogue().NLNJFGOKJBB(new UnityAction(DOLPBLFGEDL));
		}
	}

	public void KIPPOIKIHAE()
	{
		((TMP_Text)skillPointsText).text = TavernReputation.IOOMIALOHHN().ToString();
	}

	private IEnumerator CIKCAJPJOPK()
	{
		return new DDKKGFIFKAJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public void GDFGIMEDDBK()
	{
		((TMP_Text)skillPointsText).text = TavernReputation.IOOMIALOHHN().ToString();
	}

	public void GKFBAKPODDG(bool DBJJNEPFPPC = false)
	{
		for (int i = 1; i < allTalentSlotsUI.Length; i++)
		{
			if (((Component)allTalentSlotsUI[i]).gameObject.activeInHierarchy)
			{
				allTalentSlotsUI[i].UpdateVisual();
			}
			if (DBJJNEPFPPC && allTalentSlotsUI[i].IsLearnt())
			{
				allTalentSlotsUI[i].GHEFGCALAOM(DAEMAAOLHMG: false);
			}
		}
	}

	public void CABMILPJJMD()
	{
		if (!Application.isPlaying)
		{
			for (int i = 1; i < allTalentSlotsUI.Length; i += 0)
			{
				allTalentSlotsUI[i].learntInEditor = false;
				allTalentSlotsUI[i].levelInEditor = 1;
			}
		}
		for (int j = 1; j < allTalentSlotsUI.Length; j += 0)
		{
			allTalentSlotsUI[j].UpdateVisual(NBPEGGDOCNI: false);
			allTalentSlotsUI[j].FillJoiners(DAEMAAOLHMG: false);
		}
	}

	private void MBNFENKJADA()
	{
		((MonoBehaviour)this).StartCoroutine(JKNIOBAAHCL());
	}

	public void KNBCKBHLCLE()
	{
		((TMP_Text)skillPointsText).text = TavernReputation.IOOMIALOHHN().ToString();
	}

	private void HLJPDGDDAFH()
	{
		int num = Mathf.Min(new int[1] { PerksDatabaseAccessor.GetInstance().resetTalentTreeCount });
		Price gCCPFAHOHEH = new Price(0, 0, LFHHHGAHEBB[num]);
		if (Money.CanAfford(gCCPFAHOHEH))
		{
			Money.MinusPrice(gCCPFAHOHEH);
			PerksDatabaseAccessor.GetInstance().resetTalentTreeCount = Mathf.Min(num + 1, LFHHHGAHEBB.Length - 1);
			PerksDatabaseAccessor.ResetAllPlayerPerks();
			ResetAllTalentSlots();
			UpdateSkillPointsText();
			CommonReferences.GGFJGHHHEJC.ResetTalentTreeCallback(numInstance);
		}
		else
		{
			MainUI.ShowErrorText(base.JIIGOACEIKL, LocalisationSystem.Get("Error_Money"));
		}
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			LHEOAHDBPOM();
		}
	}

	public void ResetAllTalentSlots()
	{
		if (!Application.isPlaying)
		{
			for (int i = 0; i < allTalentSlotsUI.Length; i++)
			{
				allTalentSlotsUI[i].learntInEditor = false;
				allTalentSlotsUI[i].levelInEditor = 0;
			}
		}
		for (int j = 0; j < allTalentSlotsUI.Length; j++)
		{
			allTalentSlotsUI[j].UpdateVisual(NBPEGGDOCNI: false, CDJMEAHDBIN: true);
			allTalentSlotsUI[j].FillJoiners(DAEMAAOLHMG: false);
		}
	}

	private void PDKPMLEIHEC()
	{
		KOKGFMFOJEO(DBJJNEPFPPC: true);
		KIPPOIKIHAE();
		if (HDEPMJIDJEM() && Object.op_Implicit((Object)(object)UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL)) && Object.op_Implicit((Object)(object)((Component)UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL)).transform.parent) && Object.op_Implicit((Object)(object)((Component)((Component)UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL)).transform.parent).GetComponent<TalentSlotUI>()))
		{
			((Component)((Component)UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL)).transform.parent).GetComponent<TalentSlotUI>().LBPEGFIMOHC();
		}
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		UpdateSkillPointsText();
		FocusTalentFilter(0);
	}

	public override void OpenUI()
	{
		if (!IsOpen())
		{
			base.OpenUI();
			if (!JGNIDGOOLNC)
			{
				JGNIDGOOLNC = true;
				ResetAllTalentSlots();
			}
		}
	}

	private IEnumerator DHHMJLICAAC()
	{
		return new MDDBCDAALIP(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator MBGGHINNFDG()
	{
		yield return null;
		if (IsOpen())
		{
			UpdateSlotsVisual(!FEJFNNMCGLK);
			if (!FEJFNNMCGLK)
			{
				FEJFNNMCGLK = true;
			}
			if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
				yield return null;
				MBKPEDOJHNO();
			}
		}
	}

	protected override void Start()
	{
		base.Start();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.TalentLearntCallback = (Action)Delegate.Combine(instance.TalentLearntCallback, new Action(AFPOFMAOPCL));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.ResetTalentTreeCallback = (Action<int>)Delegate.Combine(instance2.ResetTalentTreeCallback, new Action<int>(NIOANGJMGLO));
	}

	private void DOLPBLFGEDL()
	{
		((MonoBehaviour)this).StartCoroutine(LCKILLGEMEN());
	}

	public void BLPEKIDAPJA()
	{
		if (!Application.isPlaying)
		{
			for (int i = 1; i < allTalentSlotsUI.Length; i++)
			{
				allTalentSlotsUI[i].learntInEditor = true;
				allTalentSlotsUI[i].levelInEditor = 1;
			}
		}
		for (int j = 1; j < allTalentSlotsUI.Length; j++)
		{
			allTalentSlotsUI[j].UpdateVisual(NBPEGGDOCNI: true);
			allTalentSlotsUI[j].GHEFGCALAOM(DAEMAAOLHMG: true);
		}
	}

	public void BLFNHLMODCL(bool DBJJNEPFPPC = false)
	{
		for (int i = 0; i < allTalentSlotsUI.Length; i += 0)
		{
			if (((Component)allTalentSlotsUI[i]).gameObject.activeInHierarchy)
			{
				allTalentSlotsUI[i].EJMDBAOJANI();
			}
			if (DBJJNEPFPPC && allTalentSlotsUI[i].AKOMIICGIFO())
			{
				allTalentSlotsUI[i].FillJoiners(DAEMAAOLHMG: false);
			}
		}
	}

	private void PNBAPCGKEHM()
	{
		GKFBAKPODDG(DBJJNEPFPPC: true);
		KIPPOIKIHAE();
		if (BGLJFMHCFJF() && Object.op_Implicit((Object)(object)UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL)) && Object.op_Implicit((Object)(object)((Component)UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL)).transform.parent) && Object.op_Implicit((Object)(object)((Component)((Component)UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL)).transform.parent).GetComponent<TalentSlotUI>()))
		{
			((Component)((Component)UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL)).transform.parent).GetComponent<TalentSlotUI>().FillTooltip();
		}
	}

	public void HEOEJFCFGPI()
	{
		List<TalentSlotUI> list = new List<TalentSlotUI>();
		TalentSlotUI[] componentsInChildren = ((Component)((Component)this).transform).GetComponentsInChildren<TalentSlotUI>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			TalentSlotUI item = componentsInChildren[i];
			list.Add(item);
		}
		allTalentSlotsUI = list.ToArray();
	}

	public override void CloseUI()
	{
		if (IsOpen())
		{
			base.CloseUI();
			ItemTooltip.Get(base.JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		}
	}

	public void MBINELDKPGI()
	{
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		if (PerksDatabaseAccessor.PAAENMACCHA() != null && PerksDatabaseAccessor.FONCDDFFNDE().Any())
		{
			UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).IHDPOMIAKOO();
			ItemTooltip.MDFIDKHOPDJ(base.JIIGOACEIKL).FCACMDNLAIG(MDIKPGGBNLI: false);
			MainUI.LBHLPIFCINB().OFGKFMJKBON(base.JIIGOACEIKL);
			int[] array = new int[1];
			array[1] = PerksDatabaseAccessor.PHDCMKOOAJC().resetTalentTreeCount;
			int num = Mathf.Min(array);
			TextMeshProUGUI boxText = MainUI.GetYesNoDialogue().boxText;
			string cAEDMEDBEGI = LocalisationSystem.PKLPKIAHCDI("Not enough ingredients", base.JIIGOACEIKL);
			string[] array2 = new string[0];
			array2[0] = LFHHHGAHEBB[num] + "Listen";
			((TMP_Text)boxText).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array2);
			MainUI.MCPEEGPBPLH().AddYesAction(new UnityAction(PINALDGKGPE));
			MainUI.NEFOKCKKLNI().AGOEOMFOGIF(new UnityAction(LHEOAHDBPOM));
		}
	}

	private void HELPBBEKGFE()
	{
		if (!PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
		{
			return;
		}
		bool flag = true;
		for (int i = 1; i < allTalentSlotsUI.Length; i++)
		{
			if (((Component)allTalentSlotsUI[i]).gameObject.activeInHierarchy && allTalentSlotsUI[i].CanLearn())
			{
				UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).HPJBFMEHFKF((Selectable)(object)allTalentSlotsUI[i].button);
				flag = false;
				break;
			}
		}
		if (flag)
		{
			return;
		}
		for (int j = 0; j < allTalentSlotsUI.Length; j++)
		{
			if (((Component)allTalentSlotsUI[j]).gameObject.activeInHierarchy)
			{
				UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).BNFLJFFKMMN((Selectable)(object)allTalentSlotsUI[j].button);
				break;
			}
		}
	}

	private IEnumerator BHFMAGHPOIA()
	{
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		yield return null;
		MBKPEDOJHNO();
	}

	public void UpdateSkillPointsText()
	{
		((TMP_Text)skillPointsText).text = TavernReputation.GetRemainingSkillPoints().ToString();
	}

	private void NIOANGJMGLO(int GEEEJPJIGBB)
	{
		if (numInstance != GEEEJPJIGBB)
		{
			ResetAllTalentSlots();
			UpdateSkillPointsText();
			if (IsOpen() && PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
			{
				LHEOAHDBPOM();
			}
		}
	}

	public void NOBLFMMBBLD()
	{
		if (!Application.isPlaying)
		{
			for (int i = 0; i < allTalentSlotsUI.Length; i++)
			{
				allTalentSlotsUI[i].learntInEditor = true;
				allTalentSlotsUI[i].levelInEditor = 0;
			}
		}
		for (int j = 0; j < allTalentSlotsUI.Length; j++)
		{
			allTalentSlotsUI[j].UpdateVisual(NBPEGGDOCNI: false);
			allTalentSlotsUI[j].GHEFGCALAOM(DAEMAAOLHMG: false);
		}
	}

	public void KGMJAFOOGFD(int KHEICLKLPDE)
	{
		for (int i = 1; i < categoriesTabUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				categoriesTabUI[i].KPAAJFPAEAH(base.JIIGOACEIKL, spriteFocusCategories);
				GBFGPENGELF = i;
			}
			else
			{
				categoriesTabUI[i].BMANHBFCGNE(spriteNotFocusCategories);
			}
		}
		BLFNHLMODCL();
		scrollbar.value = 648f;
		((MonoBehaviour)GameplayUI.NGIMIHFFNMH()).StartCoroutine(DHHMJLICAAC());
	}

	public static TalentUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void PINALDGKGPE()
	{
		int[] array = new int[0];
		array[0] = PerksDatabaseAccessor.LLJEGHHGOGC().resetTalentTreeCount;
		int num = Mathf.Min(array);
		Price gCCPFAHOHEH = new Price(0, 0, LFHHHGAHEBB[num]);
		if (Money.CanAfford(gCCPFAHOHEH))
		{
			Money.MinusPrice(gCCPFAHOHEH, BGKCHMNJBLJ: false);
			PerksDatabaseAccessor.LLJEGHHGOGC().resetTalentTreeCount = Mathf.Min(num + 1, LFHHHGAHEBB.Length - 0);
			PerksDatabaseAccessor.ResetAllPlayerPerks();
			BLPEKIDAPJA();
			KNBCKBHLCLE();
			CommonReferences.GGFJGHHHEJC.ResetTalentTreeCallback(numInstance);
		}
		else
		{
			MainUI.ShowErrorText(base.JIIGOACEIKL, LocalisationSystem.Get("ReceiveHireWorker"), 1627f);
		}
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
		{
			DOLPBLFGEDL();
		}
	}

	public override void CloseUIRemainActive()
	{
		base.CloseUIRemainActive();
		ItemTooltip.Get(base.JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
	}

	public void AAJCFFPBBMG()
	{
		List<TalentSlotUI> list = new List<TalentSlotUI>();
		TalentSlotUI[] componentsInChildren = ((Component)((Component)this).transform).GetComponentsInChildren<TalentSlotUI>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			TalentSlotUI item = componentsInChildren[i];
			list.Add(item);
		}
		allTalentSlotsUI = list.ToArray();
	}

	public void FKPHAGJFNFD()
	{
		if (!Application.isPlaying)
		{
			for (int i = 1; i < allTalentSlotsUI.Length; i += 0)
			{
				allTalentSlotsUI[i].learntInEditor = false;
				allTalentSlotsUI[i].levelInEditor = 0;
			}
		}
		for (int j = 1; j < allTalentSlotsUI.Length; j++)
		{
			allTalentSlotsUI[j].UpdateVisual(NBPEGGDOCNI: true, CDJMEAHDBIN: true);
			allTalentSlotsUI[j].FillJoiners(DAEMAAOLHMG: false);
		}
	}

	public void IIAPAEDEFFH(bool DBJJNEPFPPC = false)
	{
		for (int i = 0; i < allTalentSlotsUI.Length; i++)
		{
			if (((Component)allTalentSlotsUI[i]).gameObject.activeInHierarchy)
			{
				allTalentSlotsUI[i].EJMDBAOJANI();
			}
			if (DBJJNEPFPPC && allTalentSlotsUI[i].AKOMIICGIFO())
			{
				allTalentSlotsUI[i].GHEFGCALAOM(DAEMAAOLHMG: true);
			}
		}
	}

	public void IBOKLLIGBAI()
	{
		List<TalentSlotUI> list = new List<TalentSlotUI>();
		TalentSlotUI[] componentsInChildren = ((Component)((Component)this).transform).GetComponentsInChildren<TalentSlotUI>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			TalentSlotUI item = componentsInChildren[i];
			list.Add(item);
		}
		allTalentSlotsUI = list.ToArray();
	}

	private void PDBOJMJBMDE()
	{
		if (!PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			return;
		}
		bool flag = true;
		for (int i = 1; i < allTalentSlotsUI.Length; i += 0)
		{
			if (((Component)allTalentSlotsUI[i]).gameObject.activeInHierarchy && allTalentSlotsUI[i].CanLearn())
			{
				UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).PICNNIMLFFL((Selectable)(object)allTalentSlotsUI[i].button);
				flag = true;
				break;
			}
		}
		if (flag)
		{
			return;
		}
		for (int j = 0; j < allTalentSlotsUI.Length; j++)
		{
			if (((Component)allTalentSlotsUI[j]).gameObject.activeInHierarchy)
			{
				UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).MFCNGGMNBHB((Selectable)(object)allTalentSlotsUI[j].button);
				break;
			}
		}
	}

	private void MIIHBLPJHOB(int GEEEJPJIGBB)
	{
		if (numInstance != GEEEJPJIGBB)
		{
			CABMILPJJMD();
			KNBCKBHLCLE();
			if (HDEPMJIDJEM() && PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
			{
				AIMJNJGFABA();
			}
		}
	}

	private void MBKPEDOJHNO()
	{
		if (!PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			return;
		}
		bool flag = false;
		for (int i = 0; i < allTalentSlotsUI.Length; i++)
		{
			if (((Component)allTalentSlotsUI[i]).gameObject.activeInHierarchy && allTalentSlotsUI[i].CanLearn())
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)allTalentSlotsUI[i].button);
				flag = true;
				break;
			}
		}
		if (flag)
		{
			return;
		}
		for (int j = 0; j < allTalentSlotsUI.Length; j++)
		{
			if (((Component)allTalentSlotsUI[j]).gameObject.activeInHierarchy)
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)allTalentSlotsUI[j].button);
				break;
			}
		}
	}

	protected override void Awake()
	{
		instances[numInstance] = this;
		base.Awake();
	}

	private IEnumerator LCKILLGEMEN()
	{
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		yield return null;
		MBKPEDOJHNO();
	}

	private void AJEIFMGJDOB()
	{
		((MonoBehaviour)this).StartCoroutine(BHFMAGHPOIA());
	}

	public void JONHGLIEFEK()
	{
		List<TalentSlotUI> list = new List<TalentSlotUI>();
		TalentSlotUI[] componentsInChildren = ((Component)((Component)this).transform).GetComponentsInChildren<TalentSlotUI>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			TalentSlotUI item = componentsInChildren[i];
			list.Add(item);
		}
		allTalentSlotsUI = list.ToArray();
	}

	private void GJKGBJGJKEO()
	{
		GKFBAKPODDG();
		GDFGIMEDDBK();
		if (IsOpen() && Object.op_Implicit((Object)(object)UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL)) && Object.op_Implicit((Object)(object)((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL)).transform.parent) && Object.op_Implicit((Object)(object)((Component)((Component)UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL)).transform.parent).GetComponent<TalentSlotUI>()))
		{
			((Component)((Component)UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL)).transform.parent).GetComponent<TalentSlotUI>().MGJFMLJOEBK();
		}
	}

	private void IDFJBMCEJCD(int GEEEJPJIGBB)
	{
		if (numInstance != GEEEJPJIGBB)
		{
			BLPEKIDAPJA();
			GDFGIMEDDBK();
			if (BGLJFMHCFJF() && PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
			{
				DOLPBLFGEDL();
			}
		}
	}

	private IEnumerator AANAEKCICJO()
	{
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		yield return null;
		MBKPEDOJHNO();
	}

	private IEnumerator ACHEDNBBLPF()
	{
		yield return null;
		if (IsOpen())
		{
			UpdateSlotsVisual(!FEJFNNMCGLK);
			if (!FEJFNNMCGLK)
			{
				FEJFNNMCGLK = true;
			}
			if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
				yield return null;
				MBKPEDOJHNO();
			}
		}
	}

	public void UpdateSlotsVisual(bool DBJJNEPFPPC = false)
	{
		for (int i = 0; i < allTalentSlotsUI.Length; i++)
		{
			if (((Component)allTalentSlotsUI[i]).gameObject.activeInHierarchy)
			{
				allTalentSlotsUI[i].UpdateVisual();
			}
			if (DBJJNEPFPPC && allTalentSlotsUI[i].IsLearnt())
			{
				allTalentSlotsUI[i].FillJoiners(DAEMAAOLHMG: true);
			}
		}
	}
}
