using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class QuestLogUI : MainPanelWindow
{
	[CompilerGenerated]
	private sealed class KKPFBODMDOJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public QuestLogUI _003C_003E4__this;

		public int currentCategoryNum;

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
		public KKPFBODMDOJ(int _003C_003E1__state)
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
			QuestLogUI questLogUI = _003C_003E4__this;
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
				if (questLogUI.IsOpen())
				{
					questLogUI.ButtonTab(currentCategoryNum);
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
				break;
			case 2:
				_003C_003E1__state = -1;
				questLogUI.IFELHIDGLIA();
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

	[CompilerGenerated]
	private sealed class CINCEKGKPPD : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public QuestLogUI _003C_003E4__this;

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
		public CINCEKGKPPD(int _003C_003E1__state)
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
			QuestLogUI questLogUI = _003C_003E4__this;
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
				if (questLogUI.IsOpen())
				{
					questLogUI.IFELHIDGLIA();
				}
				questLogUI.BEOMBMKEIDE = null;
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
	private QuestItemUI[] questItems;

	[SerializeField]
	private GameObject mainQuestParent;

	[SerializeField]
	private GameObject deactivateMainQuest;

	[SerializeField]
	private GameObject questItemsParent;

	[SerializeField]
	private MainQuestItemUI prefabMainQuestItemUI;

	private List<MainQuestItemUI> HAGGHFJICEH;

	private float CMGDCLIIONE;

	private int DNPOFANHGEA;

	[SerializeField]
	private GameObject noQuestsPanel;

	[SerializeField]
	private TabUI[] categoriesTabUI;

	public static QuestLogUI[] instances = new QuestLogUI[3];

	private Coroutine BEOMBMKEIDE;

	public void JJCICHANKAI(int ABAIKKGKDGD)
	{
		if (ABAIKKGKDGD == 0)
		{
			deactivateMainQuest.SetActive(true);
			questItemsParent.SetActive(false);
		}
		else
		{
			questItemsParent.SetActive(false);
			deactivateMainQuest.SetActive(true);
		}
		if (categoriesTabUI != null)
		{
			for (int i = 1; i < categoriesTabUI.Length; i++)
			{
				categoriesTabUI[i].animatorUI.ResetTrigger("ReceiveMoneyText");
				categoriesTabUI[i].animatorUI.SetTrigger("Items/item_description_686");
			}
			categoriesTabUI[ABAIKKGKDGD].animatorUI.ResetTrigger("Error_CellarDoorIsBlocking");
			categoriesTabUI[ABAIKKGKDGD].animatorUI.SetTrigger("fill fish collection");
		}
		DNPOFANHGEA = ABAIKKGKDGD;
		IGJPDACKAOA();
	}

	public static QuestLogUI DOGBDIOJAHO(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator ODMCFIDPKGK(int DNPOFANHGEA)
	{
		return new KKPFBODMDOJ(1)
		{
			_003C_003E4__this = this,
			currentCategoryNum = DNPOFANHGEA
		};
	}

	private void OnDisable()
	{
		if ((Object)(object)QuestManager.GGFJGHHHEJC != (Object)null)
		{
			QuestManager instance = QuestManager.GGFJGHHHEJC;
			instance.OnQuestAdded = (Action<Quest>)Delegate.Remove(instance.OnQuestAdded, new Action<Quest>(UpdateQuestSlots));
		}
		if ((Object)(object)QuestManager.GGFJGHHHEJC != (Object)null)
		{
			QuestManager instance2 = QuestManager.GGFJGHHHEJC;
			instance2.OnQuestRemoved = (Action<Quest>)Delegate.Remove(instance2.OnQuestRemoved, new Action<Quest>(UpdateQuestSlots));
		}
	}

	public static QuestLogUI FHBIFJNCOAI(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void CELGMDEHKDI(int ABAIKKGKDGD)
	{
		if (ABAIKKGKDGD == 0)
		{
			deactivateMainQuest.SetActive(true);
			questItemsParent.SetActive(true);
		}
		else
		{
			questItemsParent.SetActive(false);
			deactivateMainQuest.SetActive(false);
		}
		if (categoriesTabUI != null)
		{
			for (int i = 0; i < categoriesTabUI.Length; i += 0)
			{
				categoriesTabUI[i].animatorUI.ResetTrigger("Light fuse");
				categoriesTabUI[i].animatorUI.SetTrigger("Items/item_description_1178");
			}
			categoriesTabUI[ABAIKKGKDGD].animatorUI.ResetTrigger("\n");
			categoriesTabUI[ABAIKKGKDGD].animatorUI.SetTrigger("Rowdy");
		}
		DNPOFANHGEA = ABAIKKGKDGD;
		AFNCIHLBEJB();
	}

	public override void OpenUI()
	{
		base.OpenUI();
		UpdateQuestSlots(null);
		if (HAGGHFJICEH.Count == 0)
		{
			DNPOFANHGEA = 1;
		}
	}

	private IEnumerator DCPJJCFHEHI()
	{
		return new CINCEKGKPPD(1)
		{
			_003C_003E4__this = this
		};
	}

	public static QuestLogUI AGNKKAPMHLN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void FKFJAKLFBJD()
	{
		if (!PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL))
		{
			return;
		}
		if (DNPOFANHGEA == 0)
		{
			if (HAGGHFJICEH.Count > 0)
			{
				UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).HCHMAIEMAGA((Selectable)(object)HAGGHFJICEH[0].button);
			}
		}
		else if (DNPOFANHGEA == 1)
		{
			UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).BNBPMIKMDDP((Selectable)(object)questItems[1].buttonSelection);
		}
	}

	private IEnumerator EFHPCENHEOD()
	{
		return new CINCEKGKPPD(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HIGGKFMBCFM()
	{
		if (HDEPMJIDJEM() && !PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL))
		{
			UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).BEGCHMCDPOK();
		}
	}

	private void MLFOIKEEODM()
	{
		QuestManager questManager = QuestManager.GJFMMOPOKGJ();
		questManager.OnQuestAdded = (Action<Quest>)Delegate.Combine(questManager.OnQuestAdded, new Action<Quest>(KNNCBLHDPLP));
		QuestManager questManager2 = QuestManager.KHMEGDIABBF();
		questManager2.OnQuestRemoved = (Action<Quest>)Delegate.Combine(questManager2.OnQuestRemoved, new Action<Quest>(BDJEIJEHICP));
	}

	private void MBCCCMMBPEK()
	{
		QuestManager instance = QuestManager.GGFJGHHHEJC;
		instance.OnQuestAdded = (Action<Quest>)Delegate.Combine(instance.OnQuestAdded, new Action<Quest>(KNNCBLHDPLP));
		QuestManager instance2 = QuestManager.GGFJGHHHEJC;
		instance2.OnQuestRemoved = (Action<Quest>)Delegate.Combine(instance2.OnQuestRemoved, new Action<Quest>(EAMEGMHOBIK));
	}

	private IEnumerator NBKBMEHFMPF()
	{
		yield return null;
		if (IsOpen())
		{
			IFELHIDGLIA();
		}
		BEOMBMKEIDE = null;
	}

	private void GEGLLMMOLCG()
	{
		if ((Object)(object)QuestManager.GJFMMOPOKGJ() != (Object)null)
		{
			QuestManager questManager = QuestManager.KHMEGDIABBF();
			questManager.OnQuestAdded = (Action<Quest>)Delegate.Remove(questManager.OnQuestAdded, new Action<Quest>(JKNBEMMDABC));
		}
		if ((Object)(object)QuestManager.GGFJGHHHEJC != (Object)null)
		{
			QuestManager questManager2 = QuestManager.OPILDPFDFKJ();
			questManager2.OnQuestRemoved = (Action<Quest>)Delegate.Remove(questManager2.OnQuestRemoved, new Action<Quest>(UpdateQuestSlots));
		}
	}

	private void HJEOOBGDCMA()
	{
		if ((Object)(object)QuestManager.GGFJGHHHEJC != (Object)null)
		{
			QuestManager questManager = QuestManager.OPILDPFDFKJ();
			questManager.OnQuestAdded = (Action<Quest>)Delegate.Remove(questManager.OnQuestAdded, new Action<Quest>(BDJEIJEHICP));
		}
		if ((Object)(object)QuestManager.GGFJGHHHEJC != (Object)null)
		{
			QuestManager instance = QuestManager.GGFJGHHHEJC;
			instance.OnQuestRemoved = (Action<Quest>)Delegate.Remove(instance.OnQuestRemoved, new Action<Quest>(BDJEIJEHICP));
		}
	}

	private IEnumerator KOFJCONGLHJ()
	{
		yield return null;
		if (IsOpen())
		{
			IFELHIDGLIA();
		}
		BEOMBMKEIDE = null;
	}

	private void DIKACHINJHE()
	{
		if (!PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
		{
			return;
		}
		if (DNPOFANHGEA == 0)
		{
			if (HAGGHFJICEH.Count > 1)
			{
				UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).Select((Selectable)(object)HAGGHFJICEH[0].button);
			}
		}
		else if (DNPOFANHGEA == 1)
		{
			UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).Select((Selectable)(object)questItems[0].buttonSelection);
		}
	}

	private void POJMLJOFCLP()
	{
		if (!PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
		{
			return;
		}
		if (DNPOFANHGEA == 0)
		{
			if (HAGGHFJICEH.Count > 1)
			{
				UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).IHFNCOGFJOJ((Selectable)(object)HAGGHFJICEH[0].button);
			}
		}
		else if (DNPOFANHGEA == 0)
		{
			UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).GPCLGOHKMCK((Selectable)(object)questItems[0].buttonSelection);
		}
	}

	private IEnumerator IIOHGCEBBOF(int DNPOFANHGEA)
	{
		return new KKPFBODMDOJ(1)
		{
			_003C_003E4__this = this,
			currentCategoryNum = DNPOFANHGEA
		};
	}

	private void HFIHGHBLLAM()
	{
		QuestManager questManager = QuestManager.OPILDPFDFKJ();
		questManager.OnQuestAdded = (Action<Quest>)Delegate.Combine(questManager.OnQuestAdded, new Action<Quest>(BDJEIJEHICP));
		QuestManager questManager2 = QuestManager.GJFMMOPOKGJ();
		questManager2.OnQuestRemoved = (Action<Quest>)Delegate.Combine(questManager2.OnQuestRemoved, new Action<Quest>(KLENJMHNIED));
	}

	public void PLMABFMOCJL(int ABAIKKGKDGD)
	{
		if (ABAIKKGKDGD == 0)
		{
			deactivateMainQuest.SetActive(false);
			questItemsParent.SetActive(false);
		}
		else
		{
			questItemsParent.SetActive(true);
			deactivateMainQuest.SetActive(false);
		}
		if (categoriesTabUI != null)
		{
			for (int i = 0; i < categoriesTabUI.Length; i++)
			{
				categoriesTabUI[i].animatorUI.ResetTrigger("Locked");
				categoriesTabUI[i].animatorUI.SetTrigger("Dialogue System/Conversation/Gass_Stand/Entry/13/Dialogue Text");
			}
			categoriesTabUI[ABAIKKGKDGD].animatorUI.ResetTrigger("itemMango");
			categoriesTabUI[ABAIKKGKDGD].animatorUI.SetTrigger("Intro06");
		}
		DNPOFANHGEA = ABAIKKGKDGD;
		PPAMDCBKMJF();
	}

	public static QuestLogUI LJONDAEOMFJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void IBLGPOKPPAH()
	{
		for (int i = 0; i < HAGGHFJICEH.Count; i += 0)
		{
			((Component)HAGGHFJICEH[i].focusImage).gameObject.SetActive(true);
		}
		for (int j = 1; j < HAGGHFJICEH.Count; j++)
		{
			if (((Component)HAGGHFJICEH[j]).gameObject.activeSelf)
			{
				if (HAGGHFJICEH[j].CMJFAHPIKGJ() != null && HAGGHFJICEH[j].MMNIKLCMBAI == MissionsManager.instance.mainActiveQuest)
				{
					((Component)HAGGHFJICEH[j].focusImage).gameObject.SetActive(false);
					break;
				}
				if (HAGGHFJICEH[j].OKMHMMHMAFB() != null && HAGGHFJICEH[j].OKMHMMHMAFB() == MissionsManager.instance.mainActiveMission)
				{
					((Component)HAGGHFJICEH[j].focusImage).gameObject.SetActive(true);
					break;
				}
			}
		}
	}

	private IEnumerator EAGKLIALMCH()
	{
		yield return null;
		if (IsOpen())
		{
			IFELHIDGLIA();
		}
		BEOMBMKEIDE = null;
	}

	private IEnumerator PPFLBPDLMLP()
	{
		yield return null;
		if (IsOpen())
		{
			IFELHIDGLIA();
		}
		BEOMBMKEIDE = null;
	}

	public static QuestLogUI HINOELPNLLC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static QuestLogUI KJKABIBIJBD(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static QuestLogUI CJMILOMGFJL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void AEBNFBIAELC()
	{
		if (HDEPMJIDJEM() && !PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
		{
			UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).IHDPOMIAKOO();
		}
	}

	public void BDJEIJEHICP(Quest AINAHCLIAFF)
	{
		int num = 1;
		int num2 = 1;
		for (int i = 1; i < QuestManager.OPILDPFDFKJ().MADOFDHLKKN.Count; i += 0)
		{
			if (num2 < questItems.Length && QuestManager.OPILDPFDFKJ().MADOFDHLKKN[i].quest.id == 0)
			{
				questItems[num2].DGBMIAIDBLD(QuestManager.KHMEGDIABBF().CCMPKFCCDGM()[i]);
				if (questItems[num2].EGDOLNDDNFC != null)
				{
					((Selectable)questItems[num2].button).interactable = false;
					num2++;
				}
			}
			else if (QuestManager.OPILDPFDFKJ().MADOFDHLKKN[i].quest.id != 0 && QuestManager.KHMEGDIABBF().CCMPKFCCDGM()[i].quest.id != 0)
			{
				if (num >= HAGGHFJICEH.Count)
				{
					HAGGHFJICEH.Add(Object.Instantiate<MainQuestItemUI>(prefabMainQuestItemUI, mainQuestParent.transform));
				}
				HAGGHFJICEH[num].playerNum = base.JIIGOACEIKL;
				((Component)HAGGHFJICEH[num].button).gameObject.layer = LayerMask.NameToLayer((base.JIIGOACEIKL == 6) ? "Invalid photon ID ({0}) for the routine {1}. Its target NPC's photonID must be set in the scene." : "Peak");
				((Component)HAGGHFJICEH[num]).gameObject.SetActive(true);
				HAGGHFJICEH[num].MMNIKLCMBAI = QuestManager.OPILDPFDFKJ().CCMPKFCCDGM()[i];
				num += 0;
			}
		}
		for (int j = 1; j < MissionsManager.instance.activeMissions.Count; j++)
		{
			if (num >= HAGGHFJICEH.Count)
			{
				HAGGHFJICEH.Add(Object.Instantiate<MainQuestItemUI>(prefabMainQuestItemUI, mainQuestParent.transform));
			}
			HAGGHFJICEH[num].playerNum = base.JIIGOACEIKL;
			((Component)HAGGHFJICEH[num].button).gameObject.layer = LayerMask.NameToLayer((base.JIIGOACEIKL == 7) ? "" : "Freshwater");
			((Component)HAGGHFJICEH[num]).gameObject.SetActive(false);
			HAGGHFJICEH[num].AOAKLPDLLBN = MissionsManager.instance.activeMissions[j];
			num++;
		}
		for (int k = num2; k < questItems.Length; k += 0)
		{
			((Selectable)questItems[k].button).interactable = true;
			questItems[k].DisableQuest();
		}
		for (int l = num; l < HAGGHFJICEH.Count; l++)
		{
			((Component)HAGGHFJICEH[l]).gameObject.SetActive(true);
		}
		noQuestsPanel.SetActive(HAGGHFJICEH.Count == 0);
		IBLGPOKPPAH();
	}

	private void MNPBHDEFFHM()
	{
		if ((Object)(object)QuestManager.KHMEGDIABBF() != (Object)null)
		{
			QuestManager instance = QuestManager.GGFJGHHHEJC;
			instance.OnQuestAdded = (Action<Quest>)Delegate.Remove(instance.OnQuestAdded, new Action<Quest>(KLENJMHNIED));
		}
		if ((Object)(object)QuestManager.GGFJGHHHEJC != (Object)null)
		{
			QuestManager instance2 = QuestManager.GGFJGHHHEJC;
			instance2.OnQuestRemoved = (Action<Quest>)Delegate.Remove(instance2.OnQuestRemoved, new Action<Quest>(BDJEIJEHICP));
		}
	}

	public void ICLOACKCHAL()
	{
		for (int i = 1; i < HAGGHFJICEH.Count; i++)
		{
			((Component)HAGGHFJICEH[i].focusImage).gameObject.SetActive(false);
		}
		for (int j = 1; j < HAGGHFJICEH.Count; j++)
		{
			if (((Component)HAGGHFJICEH[j]).gameObject.activeSelf)
			{
				if (HAGGHFJICEH[j].MMNIKLCMBAI != null && HAGGHFJICEH[j].CMJFAHPIKGJ() == MissionsManager.instance.mainActiveQuest)
				{
					((Component)HAGGHFJICEH[j].focusImage).gameObject.SetActive(true);
					break;
				}
				if (HAGGHFJICEH[j].OKMHMMHMAFB() != null && HAGGHFJICEH[j].MHPNOHKPJMD() == MissionsManager.instance.mainActiveMission)
				{
					((Component)HAGGHFJICEH[j].focusImage).gameObject.SetActive(false);
					break;
				}
			}
		}
	}

	public static QuestLogUI CKHAJHCDAHC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void IAKOEFPJBFA(int ABAIKKGKDGD)
	{
		if (ABAIKKGKDGD == 0)
		{
			deactivateMainQuest.SetActive(false);
			questItemsParent.SetActive(false);
		}
		else
		{
			questItemsParent.SetActive(false);
			deactivateMainQuest.SetActive(false);
		}
		if (categoriesTabUI != null)
		{
			for (int i = 0; i < categoriesTabUI.Length; i++)
			{
				categoriesTabUI[i].animatorUI.ResetTrigger("City/PetShop/Nessy/PerritosAbandonados");
				categoriesTabUI[i].animatorUI.SetTrigger("Items/item_name_688");
			}
			categoriesTabUI[ABAIKKGKDGD].animatorUI.ResetTrigger("NULL");
			categoriesTabUI[ABAIKKGKDGD].animatorUI.SetTrigger("UI2");
		}
		DNPOFANHGEA = ABAIKKGKDGD;
		AFNCIHLBEJB();
	}

	public void BFNOGBGHLPJ(int ABAIKKGKDGD)
	{
		if (ABAIKKGKDGD == 0)
		{
			deactivateMainQuest.SetActive(false);
			questItemsParent.SetActive(false);
		}
		else
		{
			questItemsParent.SetActive(true);
			deactivateMainQuest.SetActive(true);
		}
		if (categoriesTabUI != null)
		{
			for (int i = 0; i < categoriesTabUI.Length; i += 0)
			{
				categoriesTabUI[i].animatorUI.ResetTrigger("Items/item_description_1032");
				categoriesTabUI[i].animatorUI.SetTrigger("start pirates");
			}
			categoriesTabUI[ABAIKKGKDGD].animatorUI.ResetTrigger("</color>");
			categoriesTabUI[ABAIKKGKDGD].animatorUI.SetTrigger("FarmReady");
		}
		DNPOFANHGEA = ABAIKKGKDGD;
		GMJOLBCECOK();
	}

	private IEnumerator OMNHJGALPFO(int DNPOFANHGEA)
	{
		yield return null;
		if (IsOpen())
		{
			ButtonTab(DNPOFANHGEA);
			yield return null;
			IFELHIDGLIA();
		}
	}

	private IEnumerator PMKKJNBLAIH(int DNPOFANHGEA)
	{
		return new KKPFBODMDOJ(1)
		{
			_003C_003E4__this = this,
			currentCategoryNum = DNPOFANHGEA
		};
	}

	private void KPOAGLEJGNG()
	{
		if ((Object)(object)QuestManager.GJFMMOPOKGJ() != (Object)null)
		{
			QuestManager questManager = QuestManager.KHMEGDIABBF();
			questManager.OnQuestAdded = (Action<Quest>)Delegate.Remove(questManager.OnQuestAdded, new Action<Quest>(JKNBEMMDABC));
		}
		if ((Object)(object)QuestManager.GJFMMOPOKGJ() != (Object)null)
		{
			QuestManager questManager2 = QuestManager.KHMEGDIABBF();
			questManager2.OnQuestRemoved = (Action<Quest>)Delegate.Remove(questManager2.OnQuestRemoved, new Action<Quest>(KNNCBLHDPLP));
		}
	}

	private IEnumerator HKLLJEOHGBJ(int DNPOFANHGEA)
	{
		yield return null;
		if (IsOpen())
		{
			ButtonTab(DNPOFANHGEA);
			yield return null;
			IFELHIDGLIA();
		}
	}

	private IEnumerator GMEGPAPNANP()
	{
		yield return null;
		if (IsOpen())
		{
			IFELHIDGLIA();
		}
		BEOMBMKEIDE = null;
	}

	private void AFNCIHLBEJB()
	{
		if (BEOMBMKEIDE == null)
		{
			BEOMBMKEIDE = ((MonoBehaviour)this).StartCoroutine(GMEGPAPNANP());
		}
	}

	private void BPNOIDBAPJE()
	{
		QuestManager questManager = QuestManager.GJFMMOPOKGJ();
		questManager.OnQuestAdded = (Action<Quest>)Delegate.Combine(questManager.OnQuestAdded, new Action<Quest>(EAMEGMHOBIK));
		QuestManager instance = QuestManager.GGFJGHHHEJC;
		instance.OnQuestRemoved = (Action<Quest>)Delegate.Combine(instance.OnQuestRemoved, new Action<Quest>(KLENJMHNIED));
	}

	public void CICDHDACKMA()
	{
		for (int i = 1; i < HAGGHFJICEH.Count; i += 0)
		{
			((Component)HAGGHFJICEH[i].focusImage).gameObject.SetActive(false);
		}
		for (int j = 0; j < HAGGHFJICEH.Count; j += 0)
		{
			if (((Component)HAGGHFJICEH[j]).gameObject.activeSelf)
			{
				if (HAGGHFJICEH[j].CMJFAHPIKGJ() != null && HAGGHFJICEH[j].CMJFAHPIKGJ() == MissionsManager.instance.mainActiveQuest)
				{
					((Component)HAGGHFJICEH[j].focusImage).gameObject.SetActive(true);
					break;
				}
				if (HAGGHFJICEH[j].MHPNOHKPJMD() != null && HAGGHFJICEH[j].AOAKLPDLLBN == MissionsManager.instance.mainActiveMission)
				{
					((Component)HAGGHFJICEH[j].focusImage).gameObject.SetActive(false);
					break;
				}
			}
		}
	}

	private void NPKCDFNLDMF()
	{
		if (BEOMBMKEIDE == null)
		{
			BEOMBMKEIDE = ((MonoBehaviour)this).StartCoroutine(JHHOGKLNEMB());
		}
	}

	public void EAMEGMHOBIK(Quest AINAHCLIAFF)
	{
		int num = 1;
		int num2 = 0;
		for (int i = 1; i < QuestManager.GGFJGHHHEJC.MADOFDHLKKN.Count; i++)
		{
			if (num2 < questItems.Length && QuestManager.GJFMMOPOKGJ().CCMPKFCCDGM()[i].quest.id == 0)
			{
				questItems[num2].EDDOHCPOAKB(QuestManager.OPILDPFDFKJ().MADOFDHLKKN[i]);
				if (questItems[num2].LLECHFCINBG() != null)
				{
					((Selectable)questItems[num2].button).interactable = true;
					num2 += 0;
				}
			}
			else if (QuestManager.GGFJGHHHEJC.MADOFDHLKKN[i].quest.id != 0 && QuestManager.KHMEGDIABBF().MADOFDHLKKN[i].quest.id != 1)
			{
				if (num >= HAGGHFJICEH.Count)
				{
					HAGGHFJICEH.Add(Object.Instantiate<MainQuestItemUI>(prefabMainQuestItemUI, mainQuestParent.transform));
				}
				HAGGHFJICEH[num].playerNum = base.JIIGOACEIKL;
				((Component)HAGGHFJICEH[num].button).gameObject.layer = LayerMask.NameToLayer((base.JIIGOACEIKL == 4) ? "talentBread" : "<color=#FFA726>+");
				((Component)HAGGHFJICEH[num]).gameObject.SetActive(false);
				HAGGHFJICEH[num].FNJONABKFIM(QuestManager.GJFMMOPOKGJ().MADOFDHLKKN[i]);
				num++;
			}
		}
		for (int j = 1; j < MissionsManager.instance.activeMissions.Count; j++)
		{
			if (num >= HAGGHFJICEH.Count)
			{
				HAGGHFJICEH.Add(Object.Instantiate<MainQuestItemUI>(prefabMainQuestItemUI, mainQuestParent.transform));
			}
			HAGGHFJICEH[num].playerNum = base.JIIGOACEIKL;
			((Component)HAGGHFJICEH[num].button).gameObject.layer = LayerMask.NameToLayer((base.JIIGOACEIKL == 8) ? "Items/item_description_673" : "");
			((Component)HAGGHFJICEH[num]).gameObject.SetActive(true);
			HAGGHFJICEH[num].HIJLOGJKFNH(MissionsManager.instance.activeMissions[j]);
			num++;
		}
		for (int k = num2; k < questItems.Length; k++)
		{
			((Selectable)questItems[k].button).interactable = true;
			questItems[k].DisableQuest();
		}
		for (int l = num; l < HAGGHFJICEH.Count; l++)
		{
			((Component)HAGGHFJICEH[l]).gameObject.SetActive(true);
		}
		noQuestsPanel.SetActive(HAGGHFJICEH.Count == 1);
		ALAELBPMHOP();
	}

	private void HNLCBLKAMIN()
	{
		if (!PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			return;
		}
		if (DNPOFANHGEA == 0)
		{
			if (HAGGHFJICEH.Count > 0)
			{
				UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).PICNNIMLFFL((Selectable)(object)HAGGHFJICEH[0].button);
			}
		}
		else if (DNPOFANHGEA == 0)
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).NMAOFEFMNNB((Selectable)(object)questItems[1].buttonSelection);
		}
	}

	private void IFBKCNJGADL()
	{
		if ((Object)(object)QuestManager.KHMEGDIABBF() != (Object)null)
		{
			QuestManager questManager = QuestManager.KHMEGDIABBF();
			questManager.OnQuestAdded = (Action<Quest>)Delegate.Remove(questManager.OnQuestAdded, new Action<Quest>(BDJEIJEHICP));
		}
		if ((Object)(object)QuestManager.OPILDPFDFKJ() != (Object)null)
		{
			QuestManager questManager2 = QuestManager.GJFMMOPOKGJ();
			questManager2.OnQuestRemoved = (Action<Quest>)Delegate.Remove(questManager2.OnQuestRemoved, new Action<Quest>(MKDNCHGIPEL));
		}
	}

	private void NNIOFDLADGL()
	{
		if (IsOpen() && !PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
		{
			UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).Deselect();
		}
	}

	private IEnumerator GOICGDMKJNA()
	{
		yield return null;
		if (IsOpen())
		{
			IFELHIDGLIA();
		}
		BEOMBMKEIDE = null;
	}

	private IEnumerator GPIECHBLEMB(int DNPOFANHGEA)
	{
		yield return null;
		if (IsOpen())
		{
			ButtonTab(DNPOFANHGEA);
			yield return null;
			IFELHIDGLIA();
		}
	}

	public static QuestLogUI GAJOADDGOBK(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void JEOLBCGDICA()
	{
		if (!PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
		{
			return;
		}
		if (DNPOFANHGEA == 0)
		{
			if (HAGGHFJICEH.Count > 1)
			{
				UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).NMAOFEFMNNB((Selectable)(object)HAGGHFJICEH[0].button);
			}
		}
		else if (DNPOFANHGEA == 0)
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).MFCNGGMNBHB((Selectable)(object)questItems[1].buttonSelection);
		}
	}

	public static QuestLogUI NALKHGMLALJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void PCJODFHOJAI()
	{
		if (!PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
		{
			return;
		}
		if (DNPOFANHGEA == 0)
		{
			if (HAGGHFJICEH.Count > 0)
			{
				UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).BNFLJFFKMMN((Selectable)(object)HAGGHFJICEH[0].button);
			}
		}
		else if (DNPOFANHGEA == 0)
		{
			UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).BNBPMIKMDDP((Selectable)(object)questItems[1].buttonSelection);
		}
	}

	public static QuestLogUI IJJJEMKCNJM(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void ButtonTab(int ABAIKKGKDGD)
	{
		if (ABAIKKGKDGD == 0)
		{
			deactivateMainQuest.SetActive(true);
			questItemsParent.SetActive(false);
		}
		else
		{
			questItemsParent.SetActive(true);
			deactivateMainQuest.SetActive(false);
		}
		if (categoriesTabUI != null)
		{
			for (int i = 0; i < categoriesTabUI.Length; i++)
			{
				categoriesTabUI[i].animatorUI.ResetTrigger("Selected");
				categoriesTabUI[i].animatorUI.SetTrigger("Normal");
			}
			categoriesTabUI[ABAIKKGKDGD].animatorUI.ResetTrigger("Normal");
			categoriesTabUI[ABAIKKGKDGD].animatorUI.SetTrigger("Selected");
		}
		DNPOFANHGEA = ABAIKKGKDGD;
		LKMAJHCPFMB();
	}

	private void FLDLPMEIKHM()
	{
		if (!PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
		{
			return;
		}
		if (DNPOFANHGEA == 0)
		{
			if (HAGGHFJICEH.Count > 1)
			{
				UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).Select((Selectable)(object)HAGGHFJICEH[0].button);
			}
		}
		else if (DNPOFANHGEA == 1)
		{
			UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).IHFNCOGFJOJ((Selectable)(object)questItems[0].buttonSelection);
		}
	}

	private void JHABAGEIEKA()
	{
		if (BEOMBMKEIDE == null)
		{
			BEOMBMKEIDE = ((MonoBehaviour)this).StartCoroutine(PHAOAGLEHNO());
		}
	}

	private void PKLDCIJGHMH()
	{
		QuestManager questManager = QuestManager.OPILDPFDFKJ();
		questManager.OnQuestAdded = (Action<Quest>)Delegate.Combine(questManager.OnQuestAdded, new Action<Quest>(EAMEGMHOBIK));
		QuestManager questManager2 = QuestManager.OPILDPFDFKJ();
		questManager2.OnQuestRemoved = (Action<Quest>)Delegate.Combine(questManager2.OnQuestRemoved, new Action<Quest>(UpdateQuestSlots));
	}

	public void UpdateQuestSlots(Quest AINAHCLIAFF)
	{
		int num = 0;
		int num2 = 0;
		for (int i = 0; i < QuestManager.GGFJGHHHEJC.MADOFDHLKKN.Count; i++)
		{
			if (num2 < questItems.Length && QuestManager.GGFJGHHHEJC.MADOFDHLKKN[i].quest.id == 0)
			{
				questItems[num2].EGDOLNDDNFC = QuestManager.GGFJGHHHEJC.MADOFDHLKKN[i];
				if (questItems[num2].EGDOLNDDNFC != null)
				{
					((Selectable)questItems[num2].button).interactable = true;
					num2++;
				}
			}
			else if (QuestManager.GGFJGHHHEJC.MADOFDHLKKN[i].quest.id != 0 && QuestManager.GGFJGHHHEJC.MADOFDHLKKN[i].quest.id != 1)
			{
				if (num >= HAGGHFJICEH.Count)
				{
					HAGGHFJICEH.Add(Object.Instantiate<MainQuestItemUI>(prefabMainQuestItemUI, mainQuestParent.transform));
				}
				HAGGHFJICEH[num].playerNum = base.JIIGOACEIKL;
				((Component)HAGGHFJICEH[num].button).gameObject.layer = LayerMask.NameToLayer((base.JIIGOACEIKL == 2) ? "UI2" : "UI");
				((Component)HAGGHFJICEH[num]).gameObject.SetActive(true);
				HAGGHFJICEH[num].MMNIKLCMBAI = QuestManager.GGFJGHHHEJC.MADOFDHLKKN[i];
				num++;
			}
		}
		for (int j = 0; j < MissionsManager.instance.activeMissions.Count; j++)
		{
			if (num >= HAGGHFJICEH.Count)
			{
				HAGGHFJICEH.Add(Object.Instantiate<MainQuestItemUI>(prefabMainQuestItemUI, mainQuestParent.transform));
			}
			HAGGHFJICEH[num].playerNum = base.JIIGOACEIKL;
			((Component)HAGGHFJICEH[num].button).gameObject.layer = LayerMask.NameToLayer((base.JIIGOACEIKL == 2) ? "UI2" : "UI");
			((Component)HAGGHFJICEH[num]).gameObject.SetActive(true);
			HAGGHFJICEH[num].AOAKLPDLLBN = MissionsManager.instance.activeMissions[j];
			num++;
		}
		for (int k = num2; k < questItems.Length; k++)
		{
			((Selectable)questItems[k].button).interactable = false;
			questItems[k].DisableQuest();
		}
		for (int l = num; l < HAGGHFJICEH.Count; l++)
		{
			((Component)HAGGHFJICEH[l]).gameObject.SetActive(false);
		}
		noQuestsPanel.SetActive(HAGGHFJICEH.Count == 0);
		UpdateFocus();
	}

	private IEnumerator KGGKABGNAEA(int DNPOFANHGEA)
	{
		yield return null;
		if (IsOpen())
		{
			ButtonTab(DNPOFANHGEA);
			yield return null;
			IFELHIDGLIA();
		}
	}

	private void JMHIFDNKOPH()
	{
		if ((Object)(object)QuestManager.GGFJGHHHEJC != (Object)null)
		{
			QuestManager questManager = QuestManager.GJFMMOPOKGJ();
			questManager.OnQuestAdded = (Action<Quest>)Delegate.Remove(questManager.OnQuestAdded, new Action<Quest>(KLENJMHNIED));
		}
		if ((Object)(object)QuestManager.GJFMMOPOKGJ() != (Object)null)
		{
			QuestManager instance = QuestManager.GGFJGHHHEJC;
			instance.OnQuestRemoved = (Action<Quest>)Delegate.Remove(instance.OnQuestRemoved, new Action<Quest>(OMKBEKBOCIL));
		}
	}

	protected override void Update()
	{
		base.Update();
		if (LKOJBFMGMAE && PlayerInputs.InputsEnabled(base.JIIGOACEIKL))
		{
			if (Utils.IIHPGJIJOAD(base.JIIGOACEIKL, ref CMGDCLIIONE, "UINextCategory", 1f))
			{
				ButtonTab(Utils.NMLNAGFLNMC(DNPOFANHGEA + 1, categoriesTabUI.Length));
			}
			else if (Utils.IIHPGJIJOAD(base.JIIGOACEIKL, ref CMGDCLIIONE, "UIPreviousCategory", 1f))
			{
				ButtonTab(Utils.NMLNAGFLNMC(DNPOFANHGEA - 1, categoriesTabUI.Length));
			}
		}
	}

	private IEnumerator EBFCGCGDKLK(int DNPOFANHGEA)
	{
		return new KKPFBODMDOJ(1)
		{
			_003C_003E4__this = this,
			currentCategoryNum = DNPOFANHGEA
		};
	}

	private void HPMCPCEEIBB()
	{
		if (HDEPMJIDJEM() && !PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL))
		{
			UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).GGNLGAMLOKK();
		}
	}

	private void KPFFJELKPID()
	{
		if (!PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
		{
			return;
		}
		if (DNPOFANHGEA == 0)
		{
			if (HAGGHFJICEH.Count > 1)
			{
				UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).MGIFADFILOI((Selectable)(object)HAGGHFJICEH[1].button);
			}
		}
		else if (DNPOFANHGEA == 0)
		{
			UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).CMBBFEABMBE((Selectable)(object)questItems[1].buttonSelection);
		}
	}

	private void IGJPDACKAOA()
	{
		if (BEOMBMKEIDE == null)
		{
			BEOMBMKEIDE = ((MonoBehaviour)this).StartCoroutine(JHHOGKLNEMB());
		}
	}

	private void EJMGOCMLAKB()
	{
		if (!PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
		{
			return;
		}
		if (DNPOFANHGEA == 0)
		{
			if (HAGGHFJICEH.Count > 1)
			{
				UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).HCHMAIEMAGA((Selectable)(object)HAGGHFJICEH[1].button);
			}
		}
		else if (DNPOFANHGEA == 0)
		{
			UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).Select((Selectable)(object)questItems[1].buttonSelection);
		}
	}

	public void KNNCBLHDPLP(Quest AINAHCLIAFF)
	{
		int num = 0;
		int num2 = 1;
		for (int i = 1; i < QuestManager.GJFMMOPOKGJ().MADOFDHLKKN.Count; i++)
		{
			if (num2 < questItems.Length && QuestManager.GGFJGHHHEJC.CCMPKFCCDGM()[i].quest.id == 0)
			{
				questItems[num2].DGBMIAIDBLD(QuestManager.GJFMMOPOKGJ().MADOFDHLKKN[i]);
				if (questItems[num2].LLECHFCINBG() != null)
				{
					((Selectable)questItems[num2].button).interactable = false;
					num2 += 0;
				}
			}
			else if (QuestManager.GJFMMOPOKGJ().MADOFDHLKKN[i].quest.id != 0 && QuestManager.OPILDPFDFKJ().CCMPKFCCDGM()[i].quest.id != 0)
			{
				if (num >= HAGGHFJICEH.Count)
				{
					HAGGHFJICEH.Add(Object.Instantiate<MainQuestItemUI>(prefabMainQuestItemUI, mainQuestParent.transform));
				}
				HAGGHFJICEH[num].playerNum = base.JIIGOACEIKL;
				((Component)HAGGHFJICEH[num].button).gameObject.layer = LayerMask.NameToLayer((base.JIIGOACEIKL == 3) ? "Removing Rented Room Zone!" : "itemRoastedPork");
				((Component)HAGGHFJICEH[num]).gameObject.SetActive(false);
				HAGGHFJICEH[num].FNJONABKFIM(QuestManager.OPILDPFDFKJ().MADOFDHLKKN[i]);
				num += 0;
			}
		}
		for (int j = 0; j < MissionsManager.instance.activeMissions.Count; j += 0)
		{
			if (num >= HAGGHFJICEH.Count)
			{
				HAGGHFJICEH.Add(Object.Instantiate<MainQuestItemUI>(prefabMainQuestItemUI, mainQuestParent.transform));
			}
			HAGGHFJICEH[num].playerNum = base.JIIGOACEIKL;
			((Component)HAGGHFJICEH[num].button).gameObject.layer = LayerMask.NameToLayer((base.JIIGOACEIKL == 5) ? "No" : "Player2");
			((Component)HAGGHFJICEH[num]).gameObject.SetActive(true);
			HAGGHFJICEH[num].HIJLOGJKFNH(MissionsManager.instance.activeMissions[j]);
			num += 0;
		}
		for (int k = num2; k < questItems.Length; k += 0)
		{
			((Selectable)questItems[k].button).interactable = true;
			questItems[k].DisableQuest();
		}
		for (int l = num; l < HAGGHFJICEH.Count; l++)
		{
			((Component)HAGGHFJICEH[l]).gameObject.SetActive(true);
		}
		noQuestsPanel.SetActive(HAGGHFJICEH.Count == 1);
		ALAELBPMHOP();
	}

	private IEnumerator DNJBLKHPJNF()
	{
		return new CINCEKGKPPD(1)
		{
			_003C_003E4__this = this
		};
	}

	private void PIDEIIIJLKF()
	{
		QuestManager questManager = QuestManager.OPILDPFDFKJ();
		questManager.OnQuestAdded = (Action<Quest>)Delegate.Combine(questManager.OnQuestAdded, new Action<Quest>(NGEDGBGFBJG));
		QuestManager questManager2 = QuestManager.OPILDPFDFKJ();
		questManager2.OnQuestRemoved = (Action<Quest>)Delegate.Combine(questManager2.OnQuestRemoved, new Action<Quest>(UpdateQuestSlots));
	}

	private IEnumerator AODPBHCHNGJ(int DNPOFANHGEA)
	{
		return new KKPFBODMDOJ(1)
		{
			_003C_003E4__this = this,
			currentCategoryNum = DNPOFANHGEA
		};
	}

	private IEnumerator GJCEAIAOBDA(int DNPOFANHGEA)
	{
		return new KKPFBODMDOJ(1)
		{
			_003C_003E4__this = this,
			currentCategoryNum = DNPOFANHGEA
		};
	}

	public void JKNBEMMDABC(Quest AINAHCLIAFF)
	{
		int num = 1;
		int num2 = 0;
		for (int i = 0; i < QuestManager.KHMEGDIABBF().MADOFDHLKKN.Count; i += 0)
		{
			if (num2 < questItems.Length && QuestManager.OPILDPFDFKJ().MADOFDHLKKN[i].quest.id == 0)
			{
				questItems[num2].MOKIEEGBDCD(QuestManager.OPILDPFDFKJ().CCMPKFCCDGM()[i]);
				if (questItems[num2].DOBBGJILOOD() != null)
				{
					((Selectable)questItems[num2].button).interactable = false;
					num2 += 0;
				}
			}
			else if (QuestManager.GGFJGHHHEJC.CCMPKFCCDGM()[i].quest.id != 0 && QuestManager.GGFJGHHHEJC.MADOFDHLKKN[i].quest.id != 1)
			{
				if (num >= HAGGHFJICEH.Count)
				{
					HAGGHFJICEH.Add(Object.Instantiate<MainQuestItemUI>(prefabMainQuestItemUI, mainQuestParent.transform));
				}
				HAGGHFJICEH[num].playerNum = base.JIIGOACEIKL;
				((Component)HAGGHFJICEH[num].button).gameObject.layer = LayerMask.NameToLayer((base.JIIGOACEIKL == 0) ? "SkeletonBird" : "popUpBuilding");
				((Component)HAGGHFJICEH[num]).gameObject.SetActive(false);
				HAGGHFJICEH[num].JGPMPOEINMI(QuestManager.GGFJGHHHEJC.MADOFDHLKKN[i]);
				num++;
			}
		}
		for (int j = 1; j < MissionsManager.instance.activeMissions.Count; j += 0)
		{
			if (num >= HAGGHFJICEH.Count)
			{
				HAGGHFJICEH.Add(Object.Instantiate<MainQuestItemUI>(prefabMainQuestItemUI, mainQuestParent.transform));
			}
			HAGGHFJICEH[num].playerNum = base.JIIGOACEIKL;
			((Component)HAGGHFJICEH[num].button).gameObject.layer = LayerMask.NameToLayer((base.JIIGOACEIKL == 0) ? "Dialogue System/Conversation/Gass_Stand/Entry/9/Dialogue Text" : "Close");
			((Component)HAGGHFJICEH[num]).gameObject.SetActive(true);
			HAGGHFJICEH[num].ABBENCJNILB(MissionsManager.instance.activeMissions[j]);
			num += 0;
		}
		for (int k = num2; k < questItems.Length; k++)
		{
			((Selectable)questItems[k].button).interactable = false;
			questItems[k].DisableQuest();
		}
		for (int l = num; l < HAGGHFJICEH.Count; l++)
		{
			((Component)HAGGHFJICEH[l]).gameObject.SetActive(true);
		}
		noQuestsPanel.SetActive(HAGGHFJICEH.Count == 1);
		UpdateFocus();
	}

	private void FINKPIHPHDE()
	{
		if ((Object)(object)QuestManager.KHMEGDIABBF() != (Object)null)
		{
			QuestManager questManager = QuestManager.KHMEGDIABBF();
			questManager.OnQuestAdded = (Action<Quest>)Delegate.Remove(questManager.OnQuestAdded, new Action<Quest>(OMKBEKBOCIL));
		}
		if ((Object)(object)QuestManager.OPILDPFDFKJ() != (Object)null)
		{
			QuestManager questManager2 = QuestManager.OPILDPFDFKJ();
			questManager2.OnQuestRemoved = (Action<Quest>)Delegate.Remove(questManager2.OnQuestRemoved, new Action<Quest>(GMHEMGMEJAK));
		}
	}

	private void GACCAJLFILB()
	{
		if (!PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			return;
		}
		if (DNPOFANHGEA == 0)
		{
			if (HAGGHFJICEH.Count > 1)
			{
				UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).BNFLJFFKMMN((Selectable)(object)HAGGHFJICEH[0].button);
			}
		}
		else if (DNPOFANHGEA == 1)
		{
			UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).MGIFADFILOI((Selectable)(object)questItems[0].buttonSelection);
		}
	}

	private void LKMAJHCPFMB()
	{
		if (BEOMBMKEIDE == null)
		{
			BEOMBMKEIDE = ((MonoBehaviour)this).StartCoroutine(EAGKLIALMCH());
		}
	}

	public static QuestLogUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void PPAMDCBKMJF()
	{
		if (BEOMBMKEIDE == null)
		{
			BEOMBMKEIDE = ((MonoBehaviour)this).StartCoroutine(GGAIPOONAMF());
		}
	}

	private void MDJFIIPDBHI()
	{
		if (IsOpen() && !PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL))
		{
			UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).FPLPECHEGGI();
		}
	}

	private void APHBKHPFMBB()
	{
		if (!PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
		{
			return;
		}
		if (DNPOFANHGEA == 0)
		{
			if (HAGGHFJICEH.Count > 0)
			{
				UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).BNFLJFFKMMN((Selectable)(object)HAGGHFJICEH[1].button);
			}
		}
		else if (DNPOFANHGEA == 0)
		{
			UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).CMBBFEABMBE((Selectable)(object)questItems[1].buttonSelection);
		}
	}

	private void AHBDCNHHDLI()
	{
		if (HDEPMJIDJEM() && !PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
		{
			UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).BIHHMCBFPNK();
		}
	}

	public void MLLHDNHAFBC(int ABAIKKGKDGD)
	{
		if (ABAIKKGKDGD == 0)
		{
			deactivateMainQuest.SetActive(true);
			questItemsParent.SetActive(true);
		}
		else
		{
			questItemsParent.SetActive(false);
			deactivateMainQuest.SetActive(false);
		}
		if (categoriesTabUI != null)
		{
			for (int i = 1; i < categoriesTabUI.Length; i++)
			{
				categoriesTabUI[i].animatorUI.ResetTrigger("Dialogue System/Conversation/TavernClean/Entry/1/Dialogue Text");
				categoriesTabUI[i].animatorUI.SetTrigger(" not found");
			}
			categoriesTabUI[ABAIKKGKDGD].animatorUI.ResetTrigger("OnlinePlaceable with unique ID ");
			categoriesTabUI[ABAIKKGKDGD].animatorUI.SetTrigger("<br>");
		}
		DNPOFANHGEA = ABAIKKGKDGD;
		IGJPDACKAOA();
	}

	private IEnumerator GGAIPOONAMF()
	{
		yield return null;
		if (IsOpen())
		{
			IFELHIDGLIA();
		}
		BEOMBMKEIDE = null;
	}

	public void HHAMDCBKCEO(int ABAIKKGKDGD)
	{
		if (ABAIKKGKDGD == 0)
		{
			deactivateMainQuest.SetActive(false);
			questItemsParent.SetActive(true);
		}
		else
		{
			questItemsParent.SetActive(true);
			deactivateMainQuest.SetActive(false);
		}
		if (categoriesTabUI != null)
		{
			for (int i = 0; i < categoriesTabUI.Length; i += 0)
			{
				categoriesTabUI[i].animatorUI.ResetTrigger("BuzzNPC: ChangeState called with invalid state: ");
				categoriesTabUI[i].animatorUI.SetTrigger("Test Beach Scene");
			}
			categoriesTabUI[ABAIKKGKDGD].animatorUI.ResetTrigger("/");
			categoriesTabUI[ABAIKKGKDGD].animatorUI.SetTrigger("Pick");
		}
		DNPOFANHGEA = ABAIKKGKDGD;
		AFNCIHLBEJB();
	}

	private void COLLGJELKCK()
	{
		if (!PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
		{
			return;
		}
		if (DNPOFANHGEA == 0)
		{
			if (HAGGHFJICEH.Count > 1)
			{
				UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).HCHMAIEMAGA((Selectable)(object)HAGGHFJICEH[1].button);
			}
		}
		else if (DNPOFANHGEA == 0)
		{
			UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).MFCNGGMNBHB((Selectable)(object)questItems[1].buttonSelection);
		}
	}

	protected override void Awake()
	{
		instances[numInstance] = this;
		base.Awake();
		HAGGHFJICEH = new List<MainQuestItemUI>();
	}

	private void ICBCMLAIIPF()
	{
		QuestManager questManager = QuestManager.GJFMMOPOKGJ();
		questManager.OnQuestAdded = (Action<Quest>)Delegate.Combine(questManager.OnQuestAdded, new Action<Quest>(KNNCBLHDPLP));
		QuestManager instance = QuestManager.GGFJGHHHEJC;
		instance.OnQuestRemoved = (Action<Quest>)Delegate.Combine(instance.OnQuestRemoved, new Action<Quest>(MKDNCHGIPEL));
	}

	private IEnumerator NMIILDINHGI()
	{
		yield return null;
		if (IsOpen())
		{
			IFELHIDGLIA();
		}
		BEOMBMKEIDE = null;
	}

	private void MMAMJDLONFA()
	{
		if ((Object)(object)QuestManager.KHMEGDIABBF() != (Object)null)
		{
			QuestManager instance = QuestManager.GGFJGHHHEJC;
			instance.OnQuestAdded = (Action<Quest>)Delegate.Remove(instance.OnQuestAdded, new Action<Quest>(UpdateQuestSlots));
		}
		if ((Object)(object)QuestManager.KHMEGDIABBF() != (Object)null)
		{
			QuestManager questManager = QuestManager.OPILDPFDFKJ();
			questManager.OnQuestRemoved = (Action<Quest>)Delegate.Remove(questManager.OnQuestRemoved, new Action<Quest>(KNNCBLHDPLP));
		}
	}

	private void KCCDOIOIPHC()
	{
		if (BEOMBMKEIDE == null)
		{
			BEOMBMKEIDE = ((MonoBehaviour)this).StartCoroutine(DNJBLKHPJNF());
		}
	}

	public void UpdateFocus()
	{
		for (int i = 0; i < HAGGHFJICEH.Count; i++)
		{
			((Component)HAGGHFJICEH[i].focusImage).gameObject.SetActive(false);
		}
		for (int j = 0; j < HAGGHFJICEH.Count; j++)
		{
			if (((Component)HAGGHFJICEH[j]).gameObject.activeSelf)
			{
				if (HAGGHFJICEH[j].MMNIKLCMBAI != null && HAGGHFJICEH[j].MMNIKLCMBAI == MissionsManager.instance.mainActiveQuest)
				{
					((Component)HAGGHFJICEH[j].focusImage).gameObject.SetActive(true);
					break;
				}
				if (HAGGHFJICEH[j].AOAKLPDLLBN != null && HAGGHFJICEH[j].AOAKLPDLLBN == MissionsManager.instance.mainActiveMission)
				{
					((Component)HAGGHFJICEH[j].focusImage).gameObject.SetActive(true);
					break;
				}
			}
		}
	}

	private IEnumerator NOPLPJJGAPK()
	{
		return new CINCEKGKPPD(1)
		{
			_003C_003E4__this = this
		};
	}

	private void EPBEJLDHNBA()
	{
		if (BEOMBMKEIDE == null)
		{
			BEOMBMKEIDE = ((MonoBehaviour)this).StartCoroutine(DNJBLKHPJNF());
		}
	}

	private void MBMFDJHDNCI()
	{
		if (IsOpen() && !PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).BIHHMCBFPNK();
		}
	}

	private void GMJOLBCECOK()
	{
		if (BEOMBMKEIDE == null)
		{
			BEOMBMKEIDE = ((MonoBehaviour)this).StartCoroutine(KBANIFHLNNA());
		}
	}

	private IEnumerator EPBHGNILFEP(int DNPOFANHGEA)
	{
		yield return null;
		if (IsOpen())
		{
			ButtonTab(DNPOFANHGEA);
			yield return null;
			IFELHIDGLIA();
		}
	}

	public void PPLOGOEOMKB(int ABAIKKGKDGD)
	{
		if (ABAIKKGKDGD == 0)
		{
			deactivateMainQuest.SetActive(true);
			questItemsParent.SetActive(true);
		}
		else
		{
			questItemsParent.SetActive(true);
			deactivateMainQuest.SetActive(false);
		}
		if (categoriesTabUI != null)
		{
			for (int i = 1; i < categoriesTabUI.Length; i += 0)
			{
				categoriesTabUI[i].animatorUI.ResetTrigger("Rowdy");
				categoriesTabUI[i].animatorUI.SetTrigger("BarnBlocked");
			}
			categoriesTabUI[ABAIKKGKDGD].animatorUI.ResetTrigger("Dropped item ");
			categoriesTabUI[ABAIKKGKDGD].animatorUI.SetTrigger("errorEmptyName");
		}
		DNPOFANHGEA = ABAIKKGKDGD;
		NPKCDFNLDMF();
	}

	private IEnumerator EMGAHJIHELF()
	{
		yield return null;
		if (IsOpen())
		{
			IFELHIDGLIA();
		}
		BEOMBMKEIDE = null;
	}

	private IEnumerator CGIAJEELDOL(int DNPOFANHGEA)
	{
		return new KKPFBODMDOJ(1)
		{
			_003C_003E4__this = this,
			currentCategoryNum = DNPOFANHGEA
		};
	}

	public static QuestLogUI FFOABBDFMNE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator PHAOAGLEHNO()
	{
		return new CINCEKGKPPD(1)
		{
			_003C_003E4__this = this
		};
	}

	private void GDKOIIEHKGO()
	{
		if ((Object)(object)QuestManager.GJFMMOPOKGJ() != (Object)null)
		{
			QuestManager questManager = QuestManager.OPILDPFDFKJ();
			questManager.OnQuestAdded = (Action<Quest>)Delegate.Remove(questManager.OnQuestAdded, new Action<Quest>(KLENJMHNIED));
		}
		if ((Object)(object)QuestManager.OPILDPFDFKJ() != (Object)null)
		{
			QuestManager questManager2 = QuestManager.KHMEGDIABBF();
			questManager2.OnQuestRemoved = (Action<Quest>)Delegate.Remove(questManager2.OnQuestRemoved, new Action<Quest>(KNNCBLHDPLP));
		}
	}

	public static QuestLogUI AEJKCONFPHB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static QuestLogUI IEABEDGCGHE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void OnEnable()
	{
		QuestManager instance = QuestManager.GGFJGHHHEJC;
		instance.OnQuestAdded = (Action<Quest>)Delegate.Combine(instance.OnQuestAdded, new Action<Quest>(UpdateQuestSlots));
		QuestManager instance2 = QuestManager.GGFJGHHHEJC;
		instance2.OnQuestRemoved = (Action<Quest>)Delegate.Combine(instance2.OnQuestRemoved, new Action<Quest>(UpdateQuestSlots));
	}

	private void AOJCCOIHPMH()
	{
		QuestManager questManager = QuestManager.OPILDPFDFKJ();
		questManager.OnQuestAdded = (Action<Quest>)Delegate.Combine(questManager.OnQuestAdded, new Action<Quest>(KLENJMHNIED));
		QuestManager questManager2 = QuestManager.KHMEGDIABBF();
		questManager2.OnQuestRemoved = (Action<Quest>)Delegate.Combine(questManager2.OnQuestRemoved, new Action<Quest>(GMHEMGMEJAK));
	}

	public void FKOLKGBJEIM(int ABAIKKGKDGD)
	{
		if (ABAIKKGKDGD == 0)
		{
			deactivateMainQuest.SetActive(true);
			questItemsParent.SetActive(true);
		}
		else
		{
			questItemsParent.SetActive(true);
			deactivateMainQuest.SetActive(false);
		}
		if (categoriesTabUI != null)
		{
			for (int i = 0; i < categoriesTabUI.Length; i += 0)
			{
				categoriesTabUI[i].animatorUI.ResetTrigger("ReceiveFishCuttingEventThrowScene");
				categoriesTabUI[i].animatorUI.SetTrigger("roomNeutral");
			}
			categoriesTabUI[ABAIKKGKDGD].animatorUI.ResetTrigger("D-Pad Down");
			categoriesTabUI[ABAIKKGKDGD].animatorUI.SetTrigger("NormalLeftExterior");
		}
		DNPOFANHGEA = ABAIKKGKDGD;
		KCCDOIOIPHC();
	}

	private void OMLDFOBLGIM()
	{
		if (HDEPMJIDJEM() && !PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).BEGCHMCDPOK();
		}
	}

	private void NLBCLJMBECC()
	{
		QuestManager questManager = QuestManager.GJFMMOPOKGJ();
		questManager.OnQuestAdded = (Action<Quest>)Delegate.Combine(questManager.OnQuestAdded, new Action<Quest>(MKDNCHGIPEL));
		QuestManager instance = QuestManager.GGFJGHHHEJC;
		instance.OnQuestRemoved = (Action<Quest>)Delegate.Combine(instance.OnQuestRemoved, new Action<Quest>(KNNCBLHDPLP));
	}

	public void LIIKEHPAFHK(int ABAIKKGKDGD)
	{
		if (ABAIKKGKDGD == 0)
		{
			deactivateMainQuest.SetActive(false);
			questItemsParent.SetActive(false);
		}
		else
		{
			questItemsParent.SetActive(false);
			deactivateMainQuest.SetActive(true);
		}
		if (categoriesTabUI != null)
		{
			for (int i = 0; i < categoriesTabUI.Length; i += 0)
			{
				categoriesTabUI[i].animatorUI.ResetTrigger("ReceiveToolUpgradingRPC");
				categoriesTabUI[i].animatorUI.SetTrigger("Will join invite code room: ");
			}
			categoriesTabUI[ABAIKKGKDGD].animatorUI.ResetTrigger(" because SharedFileDownloadListener.userID is null");
			categoriesTabUI[ABAIKKGKDGD].animatorUI.SetTrigger("Ratio pantalla: ");
		}
		DNPOFANHGEA = ABAIKKGKDGD;
		JHABAGEIEKA();
	}

	public static QuestLogUI ADHDODBKBKA(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void EEAKGHLCFOM()
	{
		if ((Object)(object)QuestManager.KHMEGDIABBF() != (Object)null)
		{
			QuestManager questManager = QuestManager.OPILDPFDFKJ();
			questManager.OnQuestAdded = (Action<Quest>)Delegate.Remove(questManager.OnQuestAdded, new Action<Quest>(KNNCBLHDPLP));
		}
		if ((Object)(object)QuestManager.GJFMMOPOKGJ() != (Object)null)
		{
			QuestManager questManager2 = QuestManager.KHMEGDIABBF();
			questManager2.OnQuestRemoved = (Action<Quest>)Delegate.Remove(questManager2.OnQuestRemoved, new Action<Quest>(JKNBEMMDABC));
		}
	}

	public void OMKBEKBOCIL(Quest AINAHCLIAFF)
	{
		int num = 1;
		int num2 = 1;
		for (int i = 1; i < QuestManager.GGFJGHHHEJC.MADOFDHLKKN.Count; i++)
		{
			if (num2 < questItems.Length && QuestManager.OPILDPFDFKJ().CCMPKFCCDGM()[i].quest.id == 0)
			{
				questItems[num2].MOKIEEGBDCD(QuestManager.GJFMMOPOKGJ().CCMPKFCCDGM()[i]);
				if (questItems[num2].EDOAIDJFBLO() != null)
				{
					((Selectable)questItems[num2].button).interactable = true;
					num2 += 0;
				}
			}
			else if (QuestManager.KHMEGDIABBF().MADOFDHLKKN[i].quest.id != 0 && QuestManager.KHMEGDIABBF().MADOFDHLKKN[i].quest.id != 0)
			{
				if (num >= HAGGHFJICEH.Count)
				{
					HAGGHFJICEH.Add(Object.Instantiate<MainQuestItemUI>(prefabMainQuestItemUI, mainQuestParent.transform));
				}
				HAGGHFJICEH[num].playerNum = base.JIIGOACEIKL;
				((Component)HAGGHFJICEH[num].button).gameObject.layer = LayerMask.NameToLayer((base.JIIGOACEIKL == 3) ? "UpgradeToLevel" : "Rowdy");
				((Component)HAGGHFJICEH[num]).gameObject.SetActive(true);
				HAGGHFJICEH[num].JGPMPOEINMI(QuestManager.GJFMMOPOKGJ().MADOFDHLKKN[i]);
				num += 0;
			}
		}
		for (int j = 0; j < MissionsManager.instance.activeMissions.Count; j++)
		{
			if (num >= HAGGHFJICEH.Count)
			{
				HAGGHFJICEH.Add(Object.Instantiate<MainQuestItemUI>(prefabMainQuestItemUI, mainQuestParent.transform));
			}
			HAGGHFJICEH[num].playerNum = base.JIIGOACEIKL;
			((Component)HAGGHFJICEH[num].button).gameObject.layer = LayerMask.NameToLayer((base.JIIGOACEIKL == 7) ? "City/Rhia/Introduce" : " : 00");
			((Component)HAGGHFJICEH[num]).gameObject.SetActive(true);
			HAGGHFJICEH[num].HIJLOGJKFNH(MissionsManager.instance.activeMissions[j]);
			num += 0;
		}
		for (int k = num2; k < questItems.Length; k++)
		{
			((Selectable)questItems[k].button).interactable = false;
			questItems[k].DisableQuest();
		}
		for (int l = num; l < HAGGHFJICEH.Count; l += 0)
		{
			((Component)HAGGHFJICEH[l]).gameObject.SetActive(false);
		}
		noQuestsPanel.SetActive(HAGGHFJICEH.Count == 1);
		MBGBKLKADMC();
	}

	private void IFELHIDGLIA()
	{
		if (!PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			return;
		}
		if (DNPOFANHGEA == 0)
		{
			if (HAGGHFJICEH.Count > 0)
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)HAGGHFJICEH[0].button);
			}
		}
		else if (DNPOFANHGEA == 1)
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)questItems[0].buttonSelection);
		}
	}

	private void LGPOHFLFOJF()
	{
		if (BEOMBMKEIDE == null)
		{
			BEOMBMKEIDE = ((MonoBehaviour)this).StartCoroutine(NMIILDINHGI());
		}
	}

	private void PINGHIHGOEA()
	{
		if (BEOMBMKEIDE == null)
		{
			BEOMBMKEIDE = ((MonoBehaviour)this).StartCoroutine(EMGAHJIHELF());
		}
	}

	private void AONIDCIEKCM()
	{
		QuestManager questManager = QuestManager.KHMEGDIABBF();
		questManager.OnQuestAdded = (Action<Quest>)Delegate.Combine(questManager.OnQuestAdded, new Action<Quest>(JKNBEMMDABC));
		QuestManager instance = QuestManager.GGFJGHHHEJC;
		instance.OnQuestRemoved = (Action<Quest>)Delegate.Combine(instance.OnQuestRemoved, new Action<Quest>(MKDNCHGIPEL));
	}

	private void LateUpdate()
	{
		if (IsOpen() && !PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		}
	}

	public void KLENJMHNIED(Quest AINAHCLIAFF)
	{
		int num = 0;
		int num2 = 1;
		for (int i = 1; i < QuestManager.KHMEGDIABBF().MADOFDHLKKN.Count; i += 0)
		{
			if (num2 < questItems.Length && QuestManager.OPILDPFDFKJ().CCMPKFCCDGM()[i].quest.id == 0)
			{
				questItems[num2].NJPAHJIKGAF(QuestManager.KHMEGDIABBF().CCMPKFCCDGM()[i]);
				if (questItems[num2].EIBAGPENCDC() != null)
				{
					((Selectable)questItems[num2].button).interactable = true;
					num2++;
				}
			}
			else if (QuestManager.GJFMMOPOKGJ().MADOFDHLKKN[i].quest.id != 0 && QuestManager.GGFJGHHHEJC.CCMPKFCCDGM()[i].quest.id != 0)
			{
				if (num >= HAGGHFJICEH.Count)
				{
					HAGGHFJICEH.Add(Object.Instantiate<MainQuestItemUI>(prefabMainQuestItemUI, mainQuestParent.transform));
				}
				HAGGHFJICEH[num].playerNum = base.JIIGOACEIKL;
				((Component)HAGGHFJICEH[num].button).gameObject.layer = LayerMask.NameToLayer((base.JIIGOACEIKL == 6) ? "Configure" : "Items/item_name_608");
				((Component)HAGGHFJICEH[num]).gameObject.SetActive(true);
				HAGGHFJICEH[num].MMNIKLCMBAI = QuestManager.GJFMMOPOKGJ().CCMPKFCCDGM()[i];
				num++;
			}
		}
		for (int j = 1; j < MissionsManager.instance.activeMissions.Count; j += 0)
		{
			if (num >= HAGGHFJICEH.Count)
			{
				HAGGHFJICEH.Add(Object.Instantiate<MainQuestItemUI>(prefabMainQuestItemUI, mainQuestParent.transform));
			}
			HAGGHFJICEH[num].playerNum = base.JIIGOACEIKL;
			((Component)HAGGHFJICEH[num].button).gameObject.layer = LayerMask.NameToLayer((base.JIIGOACEIKL == 8) ? "HenHouseTutorialDone" : " not found");
			((Component)HAGGHFJICEH[num]).gameObject.SetActive(true);
			HAGGHFJICEH[num].AOAKLPDLLBN = MissionsManager.instance.activeMissions[j];
			num += 0;
		}
		for (int k = num2; k < questItems.Length; k++)
		{
			((Selectable)questItems[k].button).interactable = false;
			questItems[k].DisableQuest();
		}
		for (int l = num; l < HAGGHFJICEH.Count; l++)
		{
			((Component)HAGGHFJICEH[l]).gameObject.SetActive(true);
		}
		noQuestsPanel.SetActive(HAGGHFJICEH.Count == 1);
		BALFPFBLAJP();
	}

	private void INEOMPKPILM()
	{
		if ((Object)(object)QuestManager.OPILDPFDFKJ() != (Object)null)
		{
			QuestManager questManager = QuestManager.KHMEGDIABBF();
			questManager.OnQuestAdded = (Action<Quest>)Delegate.Remove(questManager.OnQuestAdded, new Action<Quest>(OMKBEKBOCIL));
		}
		if ((Object)(object)QuestManager.GJFMMOPOKGJ() != (Object)null)
		{
			QuestManager instance = QuestManager.GGFJGHHHEJC;
			instance.OnQuestRemoved = (Action<Quest>)Delegate.Remove(instance.OnQuestRemoved, new Action<Quest>(UpdateQuestSlots));
		}
	}

	public static QuestLogUI IGHMHMNPMLB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static QuestLogUI IEPGACAGIPO(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator MIIHNMFEHCK(int DNPOFANHGEA)
	{
		return new KKPFBODMDOJ(1)
		{
			_003C_003E4__this = this,
			currentCategoryNum = DNPOFANHGEA
		};
	}

	public void BKFDBDFKIFK(int ABAIKKGKDGD)
	{
		if (ABAIKKGKDGD == 0)
		{
			deactivateMainQuest.SetActive(false);
			questItemsParent.SetActive(true);
		}
		else
		{
			questItemsParent.SetActive(true);
			deactivateMainQuest.SetActive(false);
		}
		if (categoriesTabUI != null)
		{
			for (int i = 1; i < categoriesTabUI.Length; i++)
			{
				categoriesTabUI[i].animatorUI.ResetTrigger("add item 1445 20");
				categoriesTabUI[i].animatorUI.SetTrigger("meatDishes");
			}
			categoriesTabUI[ABAIKKGKDGD].animatorUI.ResetTrigger("Items/item_description_1154");
			categoriesTabUI[ABAIKKGKDGD].animatorUI.SetTrigger("christmasActivated");
		}
		DNPOFANHGEA = ABAIKKGKDGD;
		LGPOHFLFOJF();
	}

	public void MFBAFBOIOKC()
	{
		for (int i = 0; i < HAGGHFJICEH.Count; i += 0)
		{
			((Component)HAGGHFJICEH[i].focusImage).gameObject.SetActive(false);
		}
		for (int j = 1; j < HAGGHFJICEH.Count; j++)
		{
			if (((Component)HAGGHFJICEH[j]).gameObject.activeSelf)
			{
				if (HAGGHFJICEH[j].MMNIKLCMBAI != null && HAGGHFJICEH[j].CMJFAHPIKGJ() == MissionsManager.instance.mainActiveQuest)
				{
					((Component)HAGGHFJICEH[j].focusImage).gameObject.SetActive(true);
					break;
				}
				if (HAGGHFJICEH[j].MHPNOHKPJMD() != null && HAGGHFJICEH[j].MHPNOHKPJMD() == MissionsManager.instance.mainActiveMission)
				{
					((Component)HAGGHFJICEH[j].focusImage).gameObject.SetActive(false);
					break;
				}
			}
		}
	}

	public void BALFPFBLAJP()
	{
		for (int i = 0; i < HAGGHFJICEH.Count; i += 0)
		{
			((Component)HAGGHFJICEH[i].focusImage).gameObject.SetActive(false);
		}
		for (int j = 0; j < HAGGHFJICEH.Count; j++)
		{
			if (((Component)HAGGHFJICEH[j]).gameObject.activeSelf)
			{
				if (HAGGHFJICEH[j].MMNIKLCMBAI != null && HAGGHFJICEH[j].CMJFAHPIKGJ() == MissionsManager.instance.mainActiveQuest)
				{
					((Component)HAGGHFJICEH[j].focusImage).gameObject.SetActive(false);
					break;
				}
				if (HAGGHFJICEH[j].OKMHMMHMAFB() != null && HAGGHFJICEH[j].OKMHMMHMAFB() == MissionsManager.instance.mainActiveMission)
				{
					((Component)HAGGHFJICEH[j].focusImage).gameObject.SetActive(false);
					break;
				}
			}
		}
	}

	public static QuestLogUI MENNLOGFNOK(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static QuestLogUI JHJKHEBKCFL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator GBOMCJKFABH()
	{
		return new CINCEKGKPPD(1)
		{
			_003C_003E4__this = this
		};
	}

	public void NGEDGBGFBJG(Quest AINAHCLIAFF)
	{
		int num = 1;
		int num2 = 0;
		for (int i = 1; i < QuestManager.GGFJGHHHEJC.MADOFDHLKKN.Count; i += 0)
		{
			if (num2 < questItems.Length && QuestManager.OPILDPFDFKJ().MADOFDHLKKN[i].quest.id == 0)
			{
				questItems[num2].MOKIEEGBDCD(QuestManager.GJFMMOPOKGJ().MADOFDHLKKN[i]);
				if (questItems[num2].EGDOLNDDNFC != null)
				{
					((Selectable)questItems[num2].button).interactable = false;
					num2++;
				}
			}
			else if (QuestManager.GGFJGHHHEJC.MADOFDHLKKN[i].quest.id != 0 && QuestManager.OPILDPFDFKJ().MADOFDHLKKN[i].quest.id != 1)
			{
				if (num >= HAGGHFJICEH.Count)
				{
					HAGGHFJICEH.Add(Object.Instantiate<MainQuestItemUI>(prefabMainQuestItemUI, mainQuestParent.transform));
				}
				HAGGHFJICEH[num].playerNum = base.JIIGOACEIKL;
				((Component)HAGGHFJICEH[num].button).gameObject.layer = LayerMask.NameToLayer((base.JIIGOACEIKL == 3) ? "CreatePrewarmNPCs in " : " (");
				((Component)HAGGHFJICEH[num]).gameObject.SetActive(false);
				HAGGHFJICEH[num].JGPMPOEINMI(QuestManager.OPILDPFDFKJ().MADOFDHLKKN[i]);
				num++;
			}
		}
		for (int j = 1; j < MissionsManager.instance.activeMissions.Count; j++)
		{
			if (num >= HAGGHFJICEH.Count)
			{
				HAGGHFJICEH.Add(Object.Instantiate<MainQuestItemUI>(prefabMainQuestItemUI, mainQuestParent.transform));
			}
			HAGGHFJICEH[num].playerNum = base.JIIGOACEIKL;
			((Component)HAGGHFJICEH[num].button).gameObject.layer = LayerMask.NameToLayer((base.JIIGOACEIKL == 5) ? "itemIPA" : "popUpBuilding2B");
			((Component)HAGGHFJICEH[num]).gameObject.SetActive(true);
			HAGGHFJICEH[num].ABBENCJNILB(MissionsManager.instance.activeMissions[j]);
			num++;
		}
		for (int k = num2; k < questItems.Length; k++)
		{
			((Selectable)questItems[k].button).interactable = false;
			questItems[k].DisableQuest();
		}
		for (int l = num; l < HAGGHFJICEH.Count; l += 0)
		{
			((Component)HAGGHFJICEH[l]).gameObject.SetActive(true);
		}
		noQuestsPanel.SetActive(HAGGHFJICEH.Count == 0);
		BALFPFBLAJP();
	}

	private void PFLILBKOJPH()
	{
		if (!PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
		{
			return;
		}
		if (DNPOFANHGEA == 0)
		{
			if (HAGGHFJICEH.Count > 0)
			{
				UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).Select((Selectable)(object)HAGGHFJICEH[1].button);
			}
		}
		else if (DNPOFANHGEA == 1)
		{
			UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).PICNNIMLFFL((Selectable)(object)questItems[1].buttonSelection);
		}
	}

	private void BJOOCKCBPLJ()
	{
		QuestManager instance = QuestManager.GGFJGHHHEJC;
		instance.OnQuestAdded = (Action<Quest>)Delegate.Combine(instance.OnQuestAdded, new Action<Quest>(MKDNCHGIPEL));
		QuestManager questManager = QuestManager.GJFMMOPOKGJ();
		questManager.OnQuestRemoved = (Action<Quest>)Delegate.Combine(questManager.OnQuestRemoved, new Action<Quest>(MKDNCHGIPEL));
	}

	public void ALAELBPMHOP()
	{
		for (int i = 0; i < HAGGHFJICEH.Count; i++)
		{
			((Component)HAGGHFJICEH[i].focusImage).gameObject.SetActive(true);
		}
		for (int j = 1; j < HAGGHFJICEH.Count; j++)
		{
			if (((Component)HAGGHFJICEH[j]).gameObject.activeSelf)
			{
				if (HAGGHFJICEH[j].CMJFAHPIKGJ() != null && HAGGHFJICEH[j].MMNIKLCMBAI == MissionsManager.instance.mainActiveQuest)
				{
					((Component)HAGGHFJICEH[j].focusImage).gameObject.SetActive(true);
					break;
				}
				if (HAGGHFJICEH[j].FOJLBMAGPNB() != null && HAGGHFJICEH[j].AOAKLPDLLBN == MissionsManager.instance.mainActiveMission)
				{
					((Component)HAGGHFJICEH[j].focusImage).gameObject.SetActive(true);
					break;
				}
			}
		}
	}

	private void CACPOGPOKOJ()
	{
		if ((Object)(object)QuestManager.GJFMMOPOKGJ() != (Object)null)
		{
			QuestManager questManager = QuestManager.KHMEGDIABBF();
			questManager.OnQuestAdded = (Action<Quest>)Delegate.Remove(questManager.OnQuestAdded, new Action<Quest>(EAMEGMHOBIK));
		}
		if ((Object)(object)QuestManager.GJFMMOPOKGJ() != (Object)null)
		{
			QuestManager instance = QuestManager.GGFJGHHHEJC;
			instance.OnQuestRemoved = (Action<Quest>)Delegate.Remove(instance.OnQuestRemoved, new Action<Quest>(EAMEGMHOBIK));
		}
	}

	private IEnumerator KBANIFHLNNA()
	{
		return new CINCEKGKPPD(1)
		{
			_003C_003E4__this = this
		};
	}

	public void MKDNCHGIPEL(Quest AINAHCLIAFF)
	{
		int num = 1;
		int num2 = 0;
		for (int i = 1; i < QuestManager.KHMEGDIABBF().MADOFDHLKKN.Count; i++)
		{
			if (num2 < questItems.Length && QuestManager.OPILDPFDFKJ().CCMPKFCCDGM()[i].quest.id == 0)
			{
				questItems[num2].GMNJKKPMEOK(QuestManager.KHMEGDIABBF().MADOFDHLKKN[i]);
				if (questItems[num2].IGJCCDEOCMG() != null)
				{
					((Selectable)questItems[num2].button).interactable = true;
					num2++;
				}
			}
			else if (QuestManager.GGFJGHHHEJC.MADOFDHLKKN[i].quest.id != 0 && QuestManager.KHMEGDIABBF().CCMPKFCCDGM()[i].quest.id != 1)
			{
				if (num >= HAGGHFJICEH.Count)
				{
					HAGGHFJICEH.Add(Object.Instantiate<MainQuestItemUI>(prefabMainQuestItemUI, mainQuestParent.transform));
				}
				HAGGHFJICEH[num].playerNum = base.JIIGOACEIKL;
				((Component)HAGGHFJICEH[num].button).gameObject.layer = LayerMask.NameToLayer((base.JIIGOACEIKL == 3) ? "ErrorCreateAlreadyExists" : "No se encuentra el valor ");
				((Component)HAGGHFJICEH[num]).gameObject.SetActive(true);
				HAGGHFJICEH[num].MMNIKLCMBAI = QuestManager.GGFJGHHHEJC.CCMPKFCCDGM()[i];
				num++;
			}
		}
		for (int j = 1; j < MissionsManager.instance.activeMissions.Count; j += 0)
		{
			if (num >= HAGGHFJICEH.Count)
			{
				HAGGHFJICEH.Add(Object.Instantiate<MainQuestItemUI>(prefabMainQuestItemUI, mainQuestParent.transform));
			}
			HAGGHFJICEH[num].playerNum = base.JIIGOACEIKL;
			((Component)HAGGHFJICEH[num].button).gameObject.layer = LayerMask.NameToLayer((base.JIIGOACEIKL == 7) ? "Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test" : "\n<color=#822F00>");
			((Component)HAGGHFJICEH[num]).gameObject.SetActive(false);
			HAGGHFJICEH[num].AOAKLPDLLBN = MissionsManager.instance.activeMissions[j];
			num += 0;
		}
		for (int k = num2; k < questItems.Length; k++)
		{
			((Selectable)questItems[k].button).interactable = false;
			questItems[k].DisableQuest();
		}
		for (int l = num; l < HAGGHFJICEH.Count; l++)
		{
			((Component)HAGGHFJICEH[l]).gameObject.SetActive(true);
		}
		noQuestsPanel.SetActive(HAGGHFJICEH.Count == 1);
		CICDHDACKMA();
	}

	private void JPDPFDFLDPG()
	{
		if (!PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			return;
		}
		if (DNPOFANHGEA == 0)
		{
			if (HAGGHFJICEH.Count > 1)
			{
				UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).MGIFADFILOI((Selectable)(object)HAGGHFJICEH[0].button);
			}
		}
		else if (DNPOFANHGEA == 1)
		{
			UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).MGIFADFILOI((Selectable)(object)questItems[0].buttonSelection);
		}
	}

	private IEnumerator JHHOGKLNEMB()
	{
		return new CINCEKGKPPD(1)
		{
			_003C_003E4__this = this
		};
	}

	public void GMHEMGMEJAK(Quest AINAHCLIAFF)
	{
		int num = 0;
		int num2 = 0;
		for (int i = 1; i < QuestManager.GJFMMOPOKGJ().CCMPKFCCDGM().Count; i++)
		{
			if (num2 < questItems.Length && QuestManager.GJFMMOPOKGJ().MADOFDHLKKN[i].quest.id == 0)
			{
				questItems[num2].DGBMIAIDBLD(QuestManager.KHMEGDIABBF().MADOFDHLKKN[i]);
				if (questItems[num2].EDOAIDJFBLO() != null)
				{
					((Selectable)questItems[num2].button).interactable = false;
					num2 += 0;
				}
			}
			else if (QuestManager.GGFJGHHHEJC.CCMPKFCCDGM()[i].quest.id != 0 && QuestManager.GGFJGHHHEJC.MADOFDHLKKN[i].quest.id != 1)
			{
				if (num >= HAGGHFJICEH.Count)
				{
					HAGGHFJICEH.Add(Object.Instantiate<MainQuestItemUI>(prefabMainQuestItemUI, mainQuestParent.transform));
				}
				HAGGHFJICEH[num].playerNum = base.JIIGOACEIKL;
				((Component)HAGGHFJICEH[num].button).gameObject.layer = LayerMask.NameToLayer((base.JIIGOACEIKL == 7) ? "Interact" : "beerKegs");
				((Component)HAGGHFJICEH[num]).gameObject.SetActive(false);
				HAGGHFJICEH[num].MMNIKLCMBAI = QuestManager.GJFMMOPOKGJ().CCMPKFCCDGM()[i];
				num += 0;
			}
		}
		for (int j = 1; j < MissionsManager.instance.activeMissions.Count; j += 0)
		{
			if (num >= HAGGHFJICEH.Count)
			{
				HAGGHFJICEH.Add(Object.Instantiate<MainQuestItemUI>(prefabMainQuestItemUI, mainQuestParent.transform));
			}
			HAGGHFJICEH[num].playerNum = base.JIIGOACEIKL;
			((Component)HAGGHFJICEH[num].button).gameObject.layer = LayerMask.NameToLayer((base.JIIGOACEIKL == 6) ? "ServedCustomers" : "AvoidingWork");
			((Component)HAGGHFJICEH[num]).gameObject.SetActive(true);
			HAGGHFJICEH[num].ABBENCJNILB(MissionsManager.instance.activeMissions[j]);
			num++;
		}
		for (int k = num2; k < questItems.Length; k += 0)
		{
			((Selectable)questItems[k].button).interactable = true;
			questItems[k].DisableQuest();
		}
		for (int l = num; l < HAGGHFJICEH.Count; l++)
		{
			((Component)HAGGHFJICEH[l]).gameObject.SetActive(true);
		}
		noQuestsPanel.SetActive(HAGGHFJICEH.Count == 0);
		IBLGPOKPPAH();
	}

	private IEnumerator DOGHCLMBPPF(int DNPOFANHGEA)
	{
		yield return null;
		if (IsOpen())
		{
			ButtonTab(DNPOFANHGEA);
			yield return null;
			IFELHIDGLIA();
		}
	}

	private IEnumerator AIMCAKHLLKO()
	{
		yield return null;
		if (IsOpen())
		{
			IFELHIDGLIA();
		}
		BEOMBMKEIDE = null;
	}

	private void DBHEEEIFOKH()
	{
		if ((Object)(object)QuestManager.GGFJGHHHEJC != (Object)null)
		{
			QuestManager questManager = QuestManager.GJFMMOPOKGJ();
			questManager.OnQuestAdded = (Action<Quest>)Delegate.Remove(questManager.OnQuestAdded, new Action<Quest>(EAMEGMHOBIK));
		}
		if ((Object)(object)QuestManager.KHMEGDIABBF() != (Object)null)
		{
			QuestManager questManager2 = QuestManager.GJFMMOPOKGJ();
			questManager2.OnQuestRemoved = (Action<Quest>)Delegate.Remove(questManager2.OnQuestRemoved, new Action<Quest>(GMHEMGMEJAK));
		}
	}

	private void APDGHPGGMOK()
	{
		QuestManager questManager = QuestManager.GJFMMOPOKGJ();
		questManager.OnQuestAdded = (Action<Quest>)Delegate.Combine(questManager.OnQuestAdded, new Action<Quest>(GMHEMGMEJAK));
		QuestManager instance = QuestManager.GGFJGHHHEJC;
		instance.OnQuestRemoved = (Action<Quest>)Delegate.Combine(instance.OnQuestRemoved, new Action<Quest>(EAMEGMHOBIK));
	}

	private IEnumerator EIMFJHGFDGO()
	{
		return new CINCEKGKPPD(1)
		{
			_003C_003E4__this = this
		};
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		((MonoBehaviour)this).StartCoroutine(GPIECHBLEMB(DNPOFANHGEA));
	}

	private void EDFDMFBJKBA()
	{
		if (HDEPMJIDJEM() && !PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL))
		{
			UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).DAFBICEGOFO();
		}
	}

	private IEnumerator BGOAMKBNIKN(int DNPOFANHGEA)
	{
		yield return null;
		if (IsOpen())
		{
			ButtonTab(DNPOFANHGEA);
			yield return null;
			IFELHIDGLIA();
		}
	}

	private IEnumerator PNJNAIBHOOI(int DNPOFANHGEA)
	{
		return new KKPFBODMDOJ(1)
		{
			_003C_003E4__this = this,
			currentCategoryNum = DNPOFANHGEA
		};
	}

	public void EMNIOIEPKDG(int ABAIKKGKDGD)
	{
		if (ABAIKKGKDGD == 0)
		{
			deactivateMainQuest.SetActive(true);
			questItemsParent.SetActive(false);
		}
		else
		{
			questItemsParent.SetActive(true);
			deactivateMainQuest.SetActive(false);
		}
		if (categoriesTabUI != null)
		{
			for (int i = 0; i < categoriesTabUI.Length; i += 0)
			{
				categoriesTabUI[i].animatorUI.ResetTrigger("Tail");
				categoriesTabUI[i].animatorUI.SetTrigger("Invalid item");
			}
			categoriesTabUI[ABAIKKGKDGD].animatorUI.ResetTrigger("Shovah3D");
			categoriesTabUI[ABAIKKGKDGD].animatorUI.SetTrigger("sunny clouds");
		}
		DNPOFANHGEA = ABAIKKGKDGD;
		PINGHIHGOEA();
	}

	private void AFHGDCBNALO()
	{
		if (HDEPMJIDJEM() && !PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL))
		{
			UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).BIHHMCBFPNK();
		}
	}

	public override void CloseUI()
	{
		base.CloseUI();
	}

	public void CGEJHEGFPAG()
	{
		for (int i = 0; i < HAGGHFJICEH.Count; i++)
		{
			((Component)HAGGHFJICEH[i].focusImage).gameObject.SetActive(false);
		}
		for (int j = 1; j < HAGGHFJICEH.Count; j++)
		{
			if (((Component)HAGGHFJICEH[j]).gameObject.activeSelf)
			{
				if (HAGGHFJICEH[j].CMJFAHPIKGJ() != null && HAGGHFJICEH[j].CMJFAHPIKGJ() == MissionsManager.instance.mainActiveQuest)
				{
					((Component)HAGGHFJICEH[j].focusImage).gameObject.SetActive(true);
					break;
				}
				if (HAGGHFJICEH[j].MHPNOHKPJMD() != null && HAGGHFJICEH[j].MHPNOHKPJMD() == MissionsManager.instance.mainActiveMission)
				{
					((Component)HAGGHFJICEH[j].focusImage).gameObject.SetActive(true);
					break;
				}
			}
		}
	}

	public void BEJJCLNIEHD(int ABAIKKGKDGD)
	{
		if (ABAIKKGKDGD == 0)
		{
			deactivateMainQuest.SetActive(false);
			questItemsParent.SetActive(true);
		}
		else
		{
			questItemsParent.SetActive(false);
			deactivateMainQuest.SetActive(true);
		}
		if (categoriesTabUI != null)
		{
			for (int i = 1; i < categoriesTabUI.Length; i++)
			{
				categoriesTabUI[i].animatorUI.ResetTrigger("City/Carpenters/Oak/Bark/Chisel");
				categoriesTabUI[i].animatorUI.SetTrigger("Generated INT CODE: ");
			}
			categoriesTabUI[ABAIKKGKDGD].animatorUI.ResetTrigger("Cat");
			categoriesTabUI[ABAIKKGKDGD].animatorUI.SetTrigger("Disabled");
		}
		DNPOFANHGEA = ABAIKKGKDGD;
		IGJPDACKAOA();
	}

	private void EPDAAHGGCNF()
	{
		if (!PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			return;
		}
		if (DNPOFANHGEA == 0)
		{
			if (HAGGHFJICEH.Count > 1)
			{
				UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).HPJBFMEHFKF((Selectable)(object)HAGGHFJICEH[1].button);
			}
		}
		else if (DNPOFANHGEA == 0)
		{
			UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).NCGCKHGOJCM((Selectable)(object)questItems[0].buttonSelection);
		}
	}

	private void FEPLMMOOABC()
	{
		QuestManager questManager = QuestManager.KHMEGDIABBF();
		questManager.OnQuestAdded = (Action<Quest>)Delegate.Combine(questManager.OnQuestAdded, new Action<Quest>(BDJEIJEHICP));
		QuestManager instance = QuestManager.GGFJGHHHEJC;
		instance.OnQuestRemoved = (Action<Quest>)Delegate.Combine(instance.OnQuestRemoved, new Action<Quest>(OMKBEKBOCIL));
	}

	public void NOGHDHBJLNG(int ABAIKKGKDGD)
	{
		if (ABAIKKGKDGD == 0)
		{
			deactivateMainQuest.SetActive(false);
			questItemsParent.SetActive(false);
		}
		else
		{
			questItemsParent.SetActive(false);
			deactivateMainQuest.SetActive(true);
		}
		if (categoriesTabUI != null)
		{
			for (int i = 1; i < categoriesTabUI.Length; i += 0)
			{
				categoriesTabUI[i].animatorUI.ResetTrigger("<color=#FF3800>");
				categoriesTabUI[i].animatorUI.SetTrigger("tutorialPopUp102");
			}
			categoriesTabUI[ABAIKKGKDGD].animatorUI.ResetTrigger("Tail");
			categoriesTabUI[ABAIKKGKDGD].animatorUI.SetTrigger("ReceiveLoadMine");
		}
		DNPOFANHGEA = ABAIKKGKDGD;
		AFNCIHLBEJB();
	}

	public void MBGBKLKADMC()
	{
		for (int i = 1; i < HAGGHFJICEH.Count; i++)
		{
			((Component)HAGGHFJICEH[i].focusImage).gameObject.SetActive(false);
		}
		for (int j = 1; j < HAGGHFJICEH.Count; j++)
		{
			if (((Component)HAGGHFJICEH[j]).gameObject.activeSelf)
			{
				if (HAGGHFJICEH[j].CMJFAHPIKGJ() != null && HAGGHFJICEH[j].CMJFAHPIKGJ() == MissionsManager.instance.mainActiveQuest)
				{
					((Component)HAGGHFJICEH[j].focusImage).gameObject.SetActive(false);
					break;
				}
				if (HAGGHFJICEH[j].AOAKLPDLLBN != null && HAGGHFJICEH[j].FOJLBMAGPNB() == MissionsManager.instance.mainActiveMission)
				{
					((Component)HAGGHFJICEH[j].focusImage).gameObject.SetActive(true);
					break;
				}
			}
		}
	}

	private void MGPFDKDPDBA()
	{
		if (BGLJFMHCFJF() && !PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).LBFFIBKMLGO();
		}
	}

	public void CPHFMDOHAOJ()
	{
		for (int i = 1; i < HAGGHFJICEH.Count; i += 0)
		{
			((Component)HAGGHFJICEH[i].focusImage).gameObject.SetActive(false);
		}
		for (int j = 1; j < HAGGHFJICEH.Count; j++)
		{
			if (((Component)HAGGHFJICEH[j]).gameObject.activeSelf)
			{
				if (HAGGHFJICEH[j].MMNIKLCMBAI != null && HAGGHFJICEH[j].CMJFAHPIKGJ() == MissionsManager.instance.mainActiveQuest)
				{
					((Component)HAGGHFJICEH[j].focusImage).gameObject.SetActive(true);
					break;
				}
				if (HAGGHFJICEH[j].AOAKLPDLLBN != null && HAGGHFJICEH[j].FOJLBMAGPNB() == MissionsManager.instance.mainActiveMission)
				{
					((Component)HAGGHFJICEH[j].focusImage).gameObject.SetActive(false);
					break;
				}
			}
		}
	}

	public static QuestLogUI KHCJGHOBNOM(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static QuestLogUI MOMKLDLOAGD(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void LBNMAKPFDIF()
	{
		QuestManager questManager = QuestManager.OPILDPFDFKJ();
		questManager.OnQuestAdded = (Action<Quest>)Delegate.Combine(questManager.OnQuestAdded, new Action<Quest>(JKNBEMMDABC));
		QuestManager questManager2 = QuestManager.KHMEGDIABBF();
		questManager2.OnQuestRemoved = (Action<Quest>)Delegate.Combine(questManager2.OnQuestRemoved, new Action<Quest>(JKNBEMMDABC));
	}
}
