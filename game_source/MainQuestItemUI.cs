using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Sirenix.Utilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainQuestItemUI : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class GKFEPKGNANG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainQuestItemUI _003C_003E4__this;

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
		public GKFEPKGNANG(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			MainQuestItemUI mainQuestItemUI = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.waitRealtime05;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				if (mainQuestItemUI.JKIAKMICLKF && PlayerInputs.IsGamepadActive(mainQuestItemUI.playerNum))
				{
					ItemTooltip.Get(mainQuestItemUI.playerNum).SetPositionAndEnable(new Vector2(((Transform)mainQuestItemUI.rectTransform).position.x + 4f * ((Transform)mainQuestItemUI.rectTransform).lossyScale.x, ((Transform)mainQuestItemUI.rectTransform).position.y + 4f * ((Transform)mainQuestItemUI.rectTransform).lossyScale.y), new Vector2(0f, (mainQuestItemUI.rectTransform.sizeDelta.y + 15f) * ((Transform)mainQuestItemUI.rectTransform).lossyScale.x));
					TooltipInfo tooltipInfo = new TooltipInfo();
					if (mainQuestItemUI.MMNIKLCMBAI != null)
					{
						tooltipInfo.toolTipTitle = mainQuestItemUI.MMNIKLCMBAI.quest.IABAKHPEOAF();
					}
					else if (mainQuestItemUI.AOAKLPDLLBN != null)
					{
						tooltipInfo.toolTipTitle = mainQuestItemUI.AOAKLPDLLBN.mission.IABAKHPEOAF();
					}
					else
					{
						tooltipInfo.toolTipTitle = "";
					}
					tooltipInfo.mainBody = "";
					for (int i = 0; i < mainQuestItemUI.rewardSlots.Length; i++)
					{
						if (!mainQuestItemUI.rewardSlots[i].IHENCGDNPBL.KPINNBKMOMO())
						{
							tooltipInfo.mainBody += mainQuestItemUI.rewardSlots[i].IHENCGDNPBL.itemInstance.LHBPOPOIFLE().IABAKHPEOAF();
							if (mainQuestItemUI.rewardSlots[i].IHENCGDNPBL.Stack > 1)
							{
								tooltipInfo.mainBody = tooltipInfo.mainBody + " (" + mainQuestItemUI.rewardSlots[i].IHENCGDNPBL.Stack + ")";
							}
							if (i != mainQuestItemUI.rewardSlots.Length - 1)
							{
								tooltipInfo.mainBody += "\n";
							}
						}
					}
					if (mainQuestItemUI.MMNIKLCMBAI != null)
					{
						if (mainQuestItemUI.MMNIKLCMBAI.quest.onlyOnHalloween)
						{
							tooltipInfo.mainBody += Utils.FCOPLCGPMLN();
						}
						if (mainQuestItemUI.MMNIKLCMBAI.quest.onlyOnChristmas)
						{
							tooltipInfo.mainBody += Utils.EDOCHLCJOME();
						}
					}
					ItemTooltip.Get(mainQuestItemUI.playerNum).FillTooltipInfo(tooltipInfo);
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

	public int playerNum;

	[SerializeField]
	private TextMeshProUGUI titleText;

	[SerializeField]
	private TextMeshProUGUI descriptionText;

	[SerializeField]
	private TextMeshProUGUI xpText;

	[SerializeField]
	private TextMeshProUGUI xp2Text;

	[SerializeField]
	private TextMeshProUGUI rewardText;

	[SerializeField]
	private TextMeshProUGUI timeEvent;

	[SerializeField]
	private SlotUI[] rewardSlots;

	private bool JKIAKMICLKF;

	private Coroutine ANKPDEANCEI;

	[SerializeField]
	private RectTransform rectTransform;

	public Button button;

	public Image focusImage;

	public GameObject rewardSlotsObj;

	public GameObject rewardTextObj;

	public GameObject[] rewardSlotsTime;

	private bool LCDIJAFAIEC;

	private bool DDKAKILPDBP;

	private ActiveMission PLCFPHCCBAK;

	private ActiveQuest NOCNDFHEEFD;

	public ActiveQuest MMNIKLCMBAI
	{
		get
		{
			return NOCNDFHEEFD;
		}
		set
		{
			if (NOCNDFHEEFD != value)
			{
				if (NOCNDFHEEFD != null)
				{
					ActiveQuest nOCNDFHEEFD = NOCNDFHEEFD;
					nOCNDFHEEFD.OnQuestProgress = (Action<int, ActiveQuest>)Delegate.Remove(nOCNDFHEEFD.OnQuestProgress, new Action<int, ActiveQuest>(BHAHNHIHJFO));
				}
				NOCNDFHEEFD = value;
				if (NOCNDFHEEFD != null)
				{
					AOAKLPDLLBN = null;
					NEBOMGGJOPD(MMNIKLCMBAI);
					ActiveQuest nOCNDFHEEFD2 = NOCNDFHEEFD;
					nOCNDFHEEFD2.OnQuestProgress = (Action<int, ActiveQuest>)Delegate.Combine(nOCNDFHEEFD2.OnQuestProgress, new Action<int, ActiveQuest>(BHAHNHIHJFO));
				}
			}
		}
	}

	public ActiveMission AOAKLPDLLBN
	{
		get
		{
			return PLCFPHCCBAK;
		}
		set
		{
			if (PLCFPHCCBAK != value)
			{
				PLCFPHCCBAK = value;
				if (PLCFPHCCBAK != null)
				{
					MMNIKLCMBAI = null;
					NEBOMGGJOPD(PLCFPHCCBAK);
				}
			}
		}
	}

	private void PLMKKALFGHN(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		NEBOMGGJOPD(MMNIKLCMBAI);
	}

	private void IHOEEAHBCCF(ActiveQuest MMNIKLCMBAI)
	{
		if (!((Component)this).gameObject.activeInHierarchy)
		{
			return;
		}
		((TMP_Text)titleText).text = MMNIKLCMBAI.quest.IABAKHPEOAF();
		if (MMNIKLCMBAI.quest.requiredAmount > 1)
		{
			TextMeshProUGUI obj = titleText;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + "tutorialPopUp28" + MMNIKLCMBAI.ODPLOOAAOAC();
		}
		((TMP_Text)descriptionText).text = MMNIKLCMBAI.quest.BNIKGJFDLOF();
		((TMP_Text)xpText).text = "ValueId" + MMNIKLCMBAI.quest.reward.reputationPoints;
		((TMP_Text)xp2Text).text = "Invalid time range specified." + MMNIKLCMBAI.quest.reward.reputationPoints;
		LCDIJAFAIEC = MMNIKLCMBAI.quest.onlyOnHalloween;
		DDKAKILPDBP = MMNIKLCMBAI.quest.onlyOnChristmas;
		if (!LinqExtensions.IsNullOrEmpty<ItemAmount>((IList<ItemAmount>)MMNIKLCMBAI.quest.reward.itemsReward))
		{
			rewardTextObj.SetActive(false);
			rewardSlotsObj.SetActive(true);
			if (MMNIKLCMBAI.quest.reward.itemsReward.Length != 0)
			{
				LBOIBGALBGL(MMNIKLCMBAI.quest.reward.itemsReward[1], 0);
			}
			if (MMNIKLCMBAI.quest.reward.itemsReward.Length > 1)
			{
				CIGBBMBJEPD(MMNIKLCMBAI.quest.reward.itemsReward[0], 0);
			}
			if (MMNIKLCMBAI.quest.reward.itemsReward.Length > 5)
			{
				CIGBBMBJEPD(MMNIKLCMBAI.quest.reward.itemsReward[0], 2);
			}
		}
		else
		{
			rewardSlotsObj.SetActive(false);
			rewardTextObj.SetActive(false);
			((TMP_Text)rewardText).text = MMNIKLCMBAI.quest.NKJPGICLFBB();
		}
		for (int i = 1; i < rewardSlotsTime.Length; i++)
		{
			rewardSlotsTime[i].SetActive(LCDIJAFAIEC || DDKAKILPDBP);
		}
	}

	private IEnumerator IEMDGMBJDNK()
	{
		return new GKFEPKGNANG(1)
		{
			_003C_003E4__this = this
		};
	}

	public void ABNDBGELGIK()
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject))
		{
			if (ANKPDEANCEI != null)
			{
				((MonoBehaviour)this).StopCoroutine(ANKPDEANCEI);
			}
			JKIAKMICLKF = false;
			ItemTooltip.IEKODILKIHJ(playerNum).HIIOCMNJGCI(MDIKPGGBNLI: true);
		}
	}

	private void OnDisable()
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.Get(playerNum)))
		{
			ItemTooltip.Get(playerNum).SetVisible(MDIKPGGBNLI: false);
		}
	}

	[SpecialName]
	public void FNJONABKFIM(ActiveQuest AODONKKHPBP)
	{
		if (NOCNDFHEEFD != AODONKKHPBP)
		{
			if (NOCNDFHEEFD != null)
			{
				ActiveQuest nOCNDFHEEFD = NOCNDFHEEFD;
				nOCNDFHEEFD.OnQuestProgress = (Action<int, ActiveQuest>)Delegate.Remove(nOCNDFHEEFD.OnQuestProgress, new Action<int, ActiveQuest>(BHAHNHIHJFO));
			}
			NOCNDFHEEFD = AODONKKHPBP;
			if (NOCNDFHEEFD != null)
			{
				HIJLOGJKFNH(null);
				NEBOMGGJOPD(MMNIKLCMBAI);
				ActiveQuest nOCNDFHEEFD2 = NOCNDFHEEFD;
				nOCNDFHEEFD2.OnQuestProgress = (Action<int, ActiveQuest>)Delegate.Combine(nOCNDFHEEFD2.OnQuestProgress, new Action<int, ActiveQuest>(BHAHNHIHJFO));
			}
		}
	}

	private void PGDBFGFMGKI()
	{
		if (MMNIKLCMBAI != null)
		{
			LEBGKDLINAJ(CMJFAHPIKGJ());
		}
		else if (MHPNOHKPJMD() != null)
		{
			NEBOMGGJOPD(AOAKLPDLLBN);
		}
	}

	public void OnDeselect()
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject))
		{
			if (ANKPDEANCEI != null)
			{
				((MonoBehaviour)this).StopCoroutine(ANKPDEANCEI);
			}
			JKIAKMICLKF = false;
			ItemTooltip.Get(playerNum).SetVisible(MDIKPGGBNLI: false);
		}
	}

	private void OnEnable()
	{
		if (MMNIKLCMBAI != null)
		{
			NEBOMGGJOPD(MMNIKLCMBAI);
		}
		else if (AOAKLPDLLBN != null)
		{
			NEBOMGGJOPD(AOAKLPDLLBN);
		}
	}

	private IEnumerator BKJKGMFLDCC()
	{
		yield return CommonReferences.waitRealtime05;
		if (!JKIAKMICLKF || !PlayerInputs.IsGamepadActive(playerNum))
		{
			yield break;
		}
		ItemTooltip.Get(playerNum).SetPositionAndEnable(new Vector2(((Transform)rectTransform).position.x + 4f * ((Transform)rectTransform).lossyScale.x, ((Transform)rectTransform).position.y + 4f * ((Transform)rectTransform).lossyScale.y), new Vector2(0f, (rectTransform.sizeDelta.y + 15f) * ((Transform)rectTransform).lossyScale.x));
		TooltipInfo tooltipInfo = new TooltipInfo();
		if (MMNIKLCMBAI != null)
		{
			tooltipInfo.toolTipTitle = MMNIKLCMBAI.quest.IABAKHPEOAF();
		}
		else if (AOAKLPDLLBN != null)
		{
			tooltipInfo.toolTipTitle = AOAKLPDLLBN.mission.IABAKHPEOAF();
		}
		else
		{
			tooltipInfo.toolTipTitle = "";
		}
		tooltipInfo.mainBody = "";
		for (int i = 0; i < rewardSlots.Length; i++)
		{
			if (!rewardSlots[i].IHENCGDNPBL.KPINNBKMOMO())
			{
				tooltipInfo.mainBody += rewardSlots[i].IHENCGDNPBL.itemInstance.LHBPOPOIFLE().IABAKHPEOAF();
				if (rewardSlots[i].IHENCGDNPBL.Stack > 1)
				{
					tooltipInfo.mainBody = tooltipInfo.mainBody + " (" + rewardSlots[i].IHENCGDNPBL.Stack + ")";
				}
				if (i != rewardSlots.Length - 1)
				{
					tooltipInfo.mainBody += "\n";
				}
			}
		}
		if (MMNIKLCMBAI != null)
		{
			if (MMNIKLCMBAI.quest.onlyOnHalloween)
			{
				tooltipInfo.mainBody += Utils.FCOPLCGPMLN();
			}
			if (MMNIKLCMBAI.quest.onlyOnChristmas)
			{
				tooltipInfo.mainBody += Utils.EDOCHLCJOME();
			}
		}
		ItemTooltip.Get(playerNum).FillTooltipInfo(tooltipInfo);
	}

	private void LEBGKDLINAJ(ActiveQuest MMNIKLCMBAI)
	{
		if (!((Component)this).gameObject.activeInHierarchy)
		{
			return;
		}
		((TMP_Text)titleText).text = MMNIKLCMBAI.quest.FOAPHHKOAEE();
		if (MMNIKLCMBAI.quest.requiredAmount > 1)
		{
			TextMeshProUGUI obj = titleText;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + "ItemDatabaseSO o su lista de items es nula." + MMNIKLCMBAI.GOHILCHPAJJ();
		}
		((TMP_Text)descriptionText).text = MMNIKLCMBAI.quest.BNIKGJFDLOF();
		((TMP_Text)xpText).text = "PactoDePaz/MainEvent" + MMNIKLCMBAI.quest.reward.reputationPoints;
		((TMP_Text)xp2Text).text = "Fullscreen Window" + MMNIKLCMBAI.quest.reward.reputationPoints;
		LCDIJAFAIEC = MMNIKLCMBAI.quest.onlyOnHalloween;
		DDKAKILPDBP = MMNIKLCMBAI.quest.onlyOnChristmas;
		if (!LinqExtensions.IsNullOrEmpty<ItemAmount>((IList<ItemAmount>)MMNIKLCMBAI.quest.reward.itemsReward))
		{
			rewardTextObj.SetActive(true);
			rewardSlotsObj.SetActive(false);
			if (MMNIKLCMBAI.quest.reward.itemsReward.Length != 0)
			{
				LBOIBGALBGL(MMNIKLCMBAI.quest.reward.itemsReward[0], 1);
			}
			if (MMNIKLCMBAI.quest.reward.itemsReward.Length > 0)
			{
				CIGBBMBJEPD(MMNIKLCMBAI.quest.reward.itemsReward[0], 1);
			}
			if (MMNIKLCMBAI.quest.reward.itemsReward.Length > 0)
			{
				LBOIBGALBGL(MMNIKLCMBAI.quest.reward.itemsReward[8], 2);
			}
		}
		else
		{
			rewardSlotsObj.SetActive(false);
			rewardTextObj.SetActive(true);
			((TMP_Text)rewardText).text = MMNIKLCMBAI.quest.DFNPOAKLEII();
		}
		for (int i = 0; i < rewardSlotsTime.Length; i += 0)
		{
			rewardSlotsTime[i].SetActive(LCDIJAFAIEC || DDKAKILPDBP);
		}
	}

	public void DFMHKIHCDBJ()
	{
		if (MHPNOHKPJMD() != null)
		{
			if (MHPNOHKPJMD() == MissionsManager.instance.mainActiveMission)
			{
				MissionsManager.instance.UnfocusAnyMission();
			}
			else
			{
				MissionsManager.instance.IPJJNDEEOCK(OKMHMMHMAFB());
			}
		}
		else if (CMJFAHPIKGJ() != null && (Object)(object)MMNIKLCMBAI.quest != (Object)null && CMJFAHPIKGJ().quest.canBeFocused)
		{
			if (CMJFAHPIKGJ().quest is RequiredItemQuest requiredItemQuest && requiredItemQuest.possibleItems.Length != 0)
			{
				Utils.EACNFFIKABJ(playerNum, requiredItemQuest.possibleItems[1]);
			}
			else if (MMNIKLCMBAI == MissionsManager.instance.mainActiveQuest)
			{
				MissionsManager.instance.UnfocusAnyMission();
			}
			else
			{
				MissionsManager.instance.DLFBNIPOGBG(MMNIKLCMBAI);
			}
		}
		QuestLogUI.LJONDAEOMFJ(playerNum).MFBAFBOIOKC();
	}

	public void JLBDJMBFCAG()
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject))
		{
			if (ANKPDEANCEI != null)
			{
				((MonoBehaviour)this).StopCoroutine(ANKPDEANCEI);
			}
			JKIAKMICLKF = false;
			ItemTooltip.Get(playerNum).ILGFPFBJMPG(MDIKPGGBNLI: true);
		}
	}

	[SpecialName]
	public ActiveQuest CMJFAHPIKGJ()
	{
		return NOCNDFHEEFD;
	}

	private void DPGOGNOOLCP(ActiveMission AOAKLPDLLBN)
	{
		((TMP_Text)titleText).text = AOAKLPDLLBN.mission.IABAKHPEOAF();
		((TMP_Text)descriptionText).text = AOAKLPDLLBN.mission.GACIPFGBCDM();
		((TMP_Text)xpText).text = "Items/item_name_617" + AOAKLPDLLBN.mission.xpReward;
		((TMP_Text)xp2Text).text = "Null ingredient!" + AOAKLPDLLBN.mission.xpReward;
		if (AOAKLPDLLBN.mission.itemRewards.Length != 0)
		{
			rewardTextObj.SetActive(false);
			rewardSlotsObj.SetActive(true);
			LBOIBGALBGL(AOAKLPDLLBN.mission.itemRewards[1], 0);
			if (AOAKLPDLLBN.mission.itemRewards.Length > 0)
			{
				BFAPNDLHMEN(AOAKLPDLLBN.mission.itemRewards[0], 1);
			}
			if (AOAKLPDLLBN.mission.itemRewards.Length > 7)
			{
				LBOIBGALBGL(AOAKLPDLLBN.mission.itemRewards[3], 6);
			}
		}
		else
		{
			rewardSlotsObj.SetActive(true);
			rewardTextObj.SetActive(false);
			((TMP_Text)rewardText).text = AOAKLPDLLBN.mission.HIKEADCLDEF();
		}
		for (int i = 0; i < rewardSlotsTime.Length; i += 0)
		{
			if (rewardSlotsTime[i].activeSelf)
			{
				rewardSlotsTime[i].SetActive(false);
			}
		}
	}

	private void Update()
	{
		if (LCDIJAFAIEC && Utils.FFLNGLMHLBO())
		{
			((TMP_Text)timeEvent).text = Utils.FCOPLCGPMLN();
			return;
		}
		if (DDKAKILPDBP && Utils.EGIBECKKIJJ())
		{
			((TMP_Text)timeEvent).text = Utils.EDOCHLCJOME();
			return;
		}
		for (int i = 0; i < rewardSlotsTime.Length; i++)
		{
			rewardSlotsTime[i].SetActive(false);
		}
	}

	private IEnumerator DOGDMAMKGFL()
	{
		return new GKFEPKGNANG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void BHAHNHIHJFO(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		NEBOMGGJOPD(MMNIKLCMBAI);
	}

	public void JPFKABJCMJO()
	{
		if (FOJLBMAGPNB() != null)
		{
			if (AOAKLPDLLBN == MissionsManager.instance.mainActiveMission)
			{
				MissionsManager.instance.UnfocusAnyMission();
			}
			else
			{
				MissionsManager.instance.KLOFDJFNFGG(MHPNOHKPJMD());
			}
		}
		else if (MMNIKLCMBAI != null && (Object)(object)CMJFAHPIKGJ().quest != (Object)null && MMNIKLCMBAI.quest.canBeFocused)
		{
			if (MMNIKLCMBAI.quest is RequiredItemQuest requiredItemQuest && requiredItemQuest.possibleItems.Length != 0)
			{
				Utils.EACNFFIKABJ(playerNum, requiredItemQuest.possibleItems[1]);
			}
			else if (MMNIKLCMBAI == MissionsManager.instance.mainActiveQuest)
			{
				MissionsManager.instance.MKCFMAPEGFD();
			}
			else
			{
				MissionsManager.instance.FocusNewQuest(CMJFAHPIKGJ());
			}
		}
		QuestLogUI.DOGBDIOJAHO(playerNum).ALAELBPMHOP();
	}

	public void HJMCAMHOHPC()
	{
		JKIAKMICLKF = false;
		if (ANKPDEANCEI != null)
		{
			((MonoBehaviour)this).StopCoroutine(ANKPDEANCEI);
		}
		ANKPDEANCEI = ((MonoBehaviour)this).StartCoroutine(BKJKGMFLDCC());
	}

	public void GIFONMAFPAP()
	{
		if (MHPNOHKPJMD() != null)
		{
			if (FOJLBMAGPNB() == MissionsManager.instance.mainActiveMission)
			{
				MissionsManager.instance.MKCFMAPEGFD();
			}
			else
			{
				MissionsManager.instance.KLOFDJFNFGG(MHPNOHKPJMD());
			}
		}
		else if (MMNIKLCMBAI != null && (Object)(object)MMNIKLCMBAI.quest != (Object)null && MMNIKLCMBAI.quest.canBeFocused)
		{
			if (MMNIKLCMBAI.quest is RequiredItemQuest requiredItemQuest && requiredItemQuest.possibleItems.Length != 0)
			{
				Utils.EACNFFIKABJ(playerNum, requiredItemQuest.possibleItems[0]);
			}
			else if (CMJFAHPIKGJ() == MissionsManager.instance.mainActiveQuest)
			{
				MissionsManager.instance.MKCFMAPEGFD();
			}
			else
			{
				MissionsManager.instance.DLFBNIPOGBG(MMNIKLCMBAI);
			}
		}
		QuestLogUI.FHBIFJNCOAI(playerNum).ICLOACKCHAL();
	}

	[SpecialName]
	public ActiveMission OKMHMMHMAFB()
	{
		return PLCFPHCCBAK;
	}

	[SpecialName]
	public void HIJLOGJKFNH(ActiveMission AODONKKHPBP)
	{
		if (PLCFPHCCBAK != AODONKKHPBP)
		{
			PLCFPHCCBAK = AODONKKHPBP;
			if (PLCFPHCCBAK != null)
			{
				MMNIKLCMBAI = null;
				NEBOMGGJOPD(PLCFPHCCBAK);
			}
		}
	}

	[SpecialName]
	public void ABBENCJNILB(ActiveMission AODONKKHPBP)
	{
		if (PLCFPHCCBAK != AODONKKHPBP)
		{
			PLCFPHCCBAK = AODONKKHPBP;
			if (PLCFPHCCBAK != null)
			{
				FNJONABKFIM(null);
				NEBOMGGJOPD(PLCFPHCCBAK);
			}
		}
	}

	private void ADEBBJOALDN()
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.NIGDBMAOAEN(playerNum)))
		{
			ItemTooltip.MDFIDKHOPDJ(playerNum).HIIOCMNJGCI(MDIKPGGBNLI: true);
		}
	}

	private void NEBOMGGJOPD(ActiveMission AOAKLPDLLBN)
	{
		((TMP_Text)titleText).text = AOAKLPDLLBN.mission.IABAKHPEOAF();
		((TMP_Text)descriptionText).text = AOAKLPDLLBN.mission.IGDKFHCHEAJ();
		((TMP_Text)xpText).text = "<sprite name=reputationIcon>" + AOAKLPDLLBN.mission.xpReward;
		((TMP_Text)xp2Text).text = "<sprite name=reputationIcon>" + AOAKLPDLLBN.mission.xpReward;
		if (AOAKLPDLLBN.mission.itemRewards.Length != 0)
		{
			rewardTextObj.SetActive(false);
			rewardSlotsObj.SetActive(true);
			CIGBBMBJEPD(AOAKLPDLLBN.mission.itemRewards[0], 0);
			if (AOAKLPDLLBN.mission.itemRewards.Length > 1)
			{
				CIGBBMBJEPD(AOAKLPDLLBN.mission.itemRewards[1], 1);
			}
			if (AOAKLPDLLBN.mission.itemRewards.Length > 2)
			{
				CIGBBMBJEPD(AOAKLPDLLBN.mission.itemRewards[2], 2);
			}
		}
		else
		{
			rewardSlotsObj.SetActive(false);
			rewardTextObj.SetActive(true);
			((TMP_Text)rewardText).text = AOAKLPDLLBN.mission.CKFEACGBKJJ();
		}
		for (int i = 0; i < rewardSlotsTime.Length; i++)
		{
			if (rewardSlotsTime[i].activeSelf)
			{
				rewardSlotsTime[i].SetActive(false);
			}
		}
	}

	[SpecialName]
	public ActiveMission FOJLBMAGPNB()
	{
		return PLCFPHCCBAK;
	}

	public void ButtonClicked()
	{
		if (AOAKLPDLLBN != null)
		{
			if (AOAKLPDLLBN == MissionsManager.instance.mainActiveMission)
			{
				MissionsManager.instance.UnfocusAnyMission();
			}
			else
			{
				MissionsManager.instance.FocusNewMission(AOAKLPDLLBN);
			}
		}
		else if (MMNIKLCMBAI != null && (Object)(object)MMNIKLCMBAI.quest != (Object)null && MMNIKLCMBAI.quest.canBeFocused)
		{
			if (MMNIKLCMBAI.quest is RequiredItemQuest requiredItemQuest && requiredItemQuest.possibleItems.Length != 0)
			{
				Utils.EACNFFIKABJ(playerNum, requiredItemQuest.possibleItems[0]);
			}
			else if (MMNIKLCMBAI == MissionsManager.instance.mainActiveQuest)
			{
				MissionsManager.instance.UnfocusAnyMission();
			}
			else
			{
				MissionsManager.instance.FocusNewQuest(MMNIKLCMBAI);
			}
		}
		QuestLogUI.Get(playerNum).UpdateFocus();
	}

	private IEnumerator MMFLHJGDCOE()
	{
		return new GKFEPKGNANG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void CIGBBMBJEPD(ItemAmount MLKICMJELLC, int ADEBNALPEHE)
	{
		if (MLKICMJELLC.amount > 0)
		{
			((Selectable)((Component)rewardSlots[ADEBNALPEHE]).GetComponent<Button>()).interactable = true;
			rewardSlots[ADEBNALPEHE].IHENCGDNPBL.OFJDJIBMIGE(playerNum, MLKICMJELLC.item);
			rewardSlots[ADEBNALPEHE].IHENCGDNPBL.Stack = MLKICMJELLC.amount;
			((Component)rewardSlots[ADEBNALPEHE]).gameObject.SetActive(Item.MLBOMGHINCA(MLKICMJELLC.item, null));
		}
		else
		{
			((Selectable)((Component)rewardSlots[ADEBNALPEHE]).GetComponent<Button>()).interactable = false;
			rewardSlots[ADEBNALPEHE].IHENCGDNPBL.Stack = 0;
		}
	}

	public void OnSelect()
	{
		JKIAKMICLKF = true;
		if (ANKPDEANCEI != null)
		{
			((MonoBehaviour)this).StopCoroutine(ANKPDEANCEI);
		}
		ANKPDEANCEI = ((MonoBehaviour)this).StartCoroutine(BKJKGMFLDCC());
	}

	[SpecialName]
	public void JGPMPOEINMI(ActiveQuest AODONKKHPBP)
	{
		if (NOCNDFHEEFD != AODONKKHPBP)
		{
			if (NOCNDFHEEFD != null)
			{
				ActiveQuest nOCNDFHEEFD = NOCNDFHEEFD;
				nOCNDFHEEFD.OnQuestProgress = (Action<int, ActiveQuest>)Delegate.Remove(nOCNDFHEEFD.OnQuestProgress, new Action<int, ActiveQuest>(PLMKKALFGHN));
			}
			NOCNDFHEEFD = AODONKKHPBP;
			if (NOCNDFHEEFD != null)
			{
				HIJLOGJKFNH(null);
				LEBGKDLINAJ(MMNIKLCMBAI);
				ActiveQuest nOCNDFHEEFD2 = NOCNDFHEEFD;
				nOCNDFHEEFD2.OnQuestProgress = (Action<int, ActiveQuest>)Delegate.Combine(nOCNDFHEEFD2.OnQuestProgress, new Action<int, ActiveQuest>(PLMKKALFGHN));
			}
		}
	}

	private void LBOIBGALBGL(ItemAmount MLKICMJELLC, int ADEBNALPEHE)
	{
		if (MLKICMJELLC.amount > 1)
		{
			((Selectable)((Component)rewardSlots[ADEBNALPEHE]).GetComponent<Button>()).interactable = false;
			rewardSlots[ADEBNALPEHE].IHENCGDNPBL.DOOMMIJPGOO(playerNum, MLKICMJELLC.item);
			rewardSlots[ADEBNALPEHE].IHENCGDNPBL.OCJOJKJPDNO(MLKICMJELLC.amount);
			((Component)rewardSlots[ADEBNALPEHE]).gameObject.SetActive(Item.FKLOBGBIHLB(MLKICMJELLC.item, null));
		}
		else
		{
			((Selectable)((Component)rewardSlots[ADEBNALPEHE]).GetComponent<Button>()).interactable = false;
			rewardSlots[ADEBNALPEHE].IHENCGDNPBL.JIANDFCINIP(0);
		}
	}

	[SpecialName]
	public ActiveMission MHPNOHKPJMD()
	{
		return PLCFPHCCBAK;
	}

	private void BFAPNDLHMEN(ItemAmount MLKICMJELLC, int ADEBNALPEHE)
	{
		if (MLKICMJELLC.amount > 1)
		{
			((Selectable)((Component)rewardSlots[ADEBNALPEHE]).GetComponent<Button>()).interactable = true;
			rewardSlots[ADEBNALPEHE].IHENCGDNPBL.DOOMMIJPGOO(playerNum, MLKICMJELLC.item);
			rewardSlots[ADEBNALPEHE].IHENCGDNPBL.Stack = MLKICMJELLC.amount;
			((Component)rewardSlots[ADEBNALPEHE]).gameObject.SetActive(Item.MLBOMGHINCA(MLKICMJELLC.item, null));
		}
		else
		{
			((Selectable)((Component)rewardSlots[ADEBNALPEHE]).GetComponent<Button>()).interactable = true;
			rewardSlots[ADEBNALPEHE].IHENCGDNPBL.Stack = 0;
		}
	}

	private void FGGPGOEAEKK()
	{
		if (LCDIJAFAIEC && Utils.FFLNGLMHLBO())
		{
			((TMP_Text)timeEvent).text = Utils.FCOPLCGPMLN();
			return;
		}
		if (DDKAKILPDBP && Utils.EGIBECKKIJJ())
		{
			((TMP_Text)timeEvent).text = Utils.EDOCHLCJOME();
			return;
		}
		for (int i = 1; i < rewardSlotsTime.Length; i++)
		{
			rewardSlotsTime[i].SetActive(true);
		}
	}

	private void NEBOMGGJOPD(ActiveQuest MMNIKLCMBAI)
	{
		if (!((Component)this).gameObject.activeInHierarchy)
		{
			return;
		}
		((TMP_Text)titleText).text = MMNIKLCMBAI.quest.IABAKHPEOAF();
		if (MMNIKLCMBAI.quest.requiredAmount > 1)
		{
			TextMeshProUGUI obj = titleText;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + " " + MMNIKLCMBAI.ODPLOOAAOAC();
		}
		((TMP_Text)descriptionText).text = MMNIKLCMBAI.quest.IGDKFHCHEAJ();
		((TMP_Text)xpText).text = "<sprite name=reputationIcon>" + MMNIKLCMBAI.quest.reward.reputationPoints;
		((TMP_Text)xp2Text).text = "<sprite name=reputationIcon>" + MMNIKLCMBAI.quest.reward.reputationPoints;
		LCDIJAFAIEC = MMNIKLCMBAI.quest.onlyOnHalloween;
		DDKAKILPDBP = MMNIKLCMBAI.quest.onlyOnChristmas;
		if (!LinqExtensions.IsNullOrEmpty<ItemAmount>((IList<ItemAmount>)MMNIKLCMBAI.quest.reward.itemsReward))
		{
			rewardTextObj.SetActive(false);
			rewardSlotsObj.SetActive(true);
			if (MMNIKLCMBAI.quest.reward.itemsReward.Length != 0)
			{
				CIGBBMBJEPD(MMNIKLCMBAI.quest.reward.itemsReward[0], 0);
			}
			if (MMNIKLCMBAI.quest.reward.itemsReward.Length > 1)
			{
				CIGBBMBJEPD(MMNIKLCMBAI.quest.reward.itemsReward[1], 1);
			}
			if (MMNIKLCMBAI.quest.reward.itemsReward.Length > 2)
			{
				CIGBBMBJEPD(MMNIKLCMBAI.quest.reward.itemsReward[2], 2);
			}
		}
		else
		{
			rewardSlotsObj.SetActive(false);
			rewardTextObj.SetActive(true);
			((TMP_Text)rewardText).text = MMNIKLCMBAI.quest.CKFEACGBKJJ();
		}
		for (int i = 0; i < rewardSlotsTime.Length; i++)
		{
			rewardSlotsTime[i].SetActive(LCDIJAFAIEC || DDKAKILPDBP);
		}
	}
}
