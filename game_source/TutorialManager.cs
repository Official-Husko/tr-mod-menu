using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class TutorialManager : TutorialManagerBase
{
	[CompilerGenerated]
	private sealed class BGMKIKECBPO : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TutorialManager _003C_003E4__this;

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
		public BGMKIKECBPO(int _003C_003E1__state)
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
			TutorialManager tutorialManager = _003C_003E4__this;
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
				if (!tutorialManager.NAFMLLMLHPD)
				{
					SceneReferences.GetSceneReferences().tutorialCollider.SetActive(false);
					ActiveQuest activeQuest = QuestManager.GGFJGHHHEJC.AddQuest(QuestDatabaseAccessor.GetQuest(3));
					if (activeQuest != null)
					{
						QuestHighlightUI.ShowNewQuestAvailable(activeQuest.quest);
					}
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

	private static TutorialManager IADEMLIIDPC;

	public List<int> importantIDs;

	public Queue<TutorialPopUp> popUpQueue = new Queue<TutorialPopUp>();

	public GameObject tutorialCollider;

	private List<GameObject> FLHJHKMKNMB;

	private bool CMLOLBOIPJE;

	public bool right;

	public bool left;

	public GameObject[] masks;

	public GameObject[] masksPlayer1;

	public GameObject[] masksPlayer2;

	public GameObject buttonPopUp;

	[SerializeField]
	protected bool _tutorialEnabled;

	public bool NAFMLLMLHPD
	{
		get
		{
			return _tutorialEnabled;
		}
		set
		{
			_tutorialEnabled = value;
			if (!_tutorialEnabled)
			{
				DisableTutorial();
			}
			OnTutorialEnabledChanged(_tutorialEnabled);
		}
	}

	public static TutorialManager GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<TutorialManager>();
			}
			return IADEMLIIDPC;
		}
	}

	private void PCMJOOALNFC()
	{
		JDKOBFEPNJG();
	}

	public void ShowLastPopUp()
	{
		if (FNCLBNHNOKF.Count > 0 && NAFMLLMLHPD)
		{
			ShowPopUp(FNCLBNHNOKF[FNCLBNHNOKF.Count - 1], MDNOOMBIFNN: true, BLKLCBCGHCN: true);
			ENNFNPONCMB();
			if (FNCLBNHNOKF.Count - 1 == 0)
			{
				((Component)((Component)leftArrow).transform.parent).gameObject.SetActive(false);
			}
			else
			{
				((Component)((Component)leftArrow).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	private void Update()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		if (KBPGGKMPKHL)
		{
			KBPGGKMPKHL = false;
			return;
		}
		if (base.GCEHLDLKOIC && ((Component)contentRectTransform).gameObject.activeSelf)
		{
			Rect rect;
			if (left)
			{
				RectTransform obj = contentRectTransform;
				rect = contentRectTransform.rect;
				((Transform)obj).position = Vector2.op_Implicit(new Vector2(((Rect)(ref rect)).width, (float)(Screen.height / 2)) + panelRectTransform.sizeDelta);
			}
			else if (right)
			{
				RectTransform obj2 = contentRectTransform;
				float num = Screen.width;
				rect = contentRectTransform.rect;
				((Transform)obj2).position = Vector2.op_Implicit(new Vector2(num - ((Rect)(ref rect)).width, (float)(Screen.height / 2)) + panelRectTransform.sizeDelta);
			}
			else
			{
				((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2((float)(Screen.width / 2), (float)(Screen.height / 2)) + panelRectTransform.sizeDelta);
			}
		}
		if (!NAFMLLMLHPD || OnlineManager.ClientOnline())
		{
			return;
		}
		if (!base.GCEHLDLKOIC && popUpQueue.Count > 0 && !BuildingTutorialManager.IKNOJDMCFOK && GameManager.GGFJGHHHEJC.NAPGPOJEEOJ && (!popUpQueue.First().AIOOLCMJBKE || !MainUI.IsAnyUIOpen(popUpQueue.First().KKNDBMCIEBL)))
		{
			TutorialPopUp fKHFBMFJKDM = popUpQueue.Dequeue();
			ShowPopUp(fKHFBMFJKDM, MDNOOMBIFNN: true, BLKLCBCGHCN: true);
		}
		else
		{
			if (base.GCEHLDLKOIC)
			{
				return;
			}
			right = false;
			left = false;
			if (FNCLBNHNOKF.Count() > 0 && !BuildingTutorialManager.IKNOJDMCFOK && !FarmConstructionManager.IsActived())
			{
				if ((!PauseMenuUI.GGFJGHHHEJC.IsOpen() && MainUI.IsAnyUIOpen()) || KeybindUI.GGFJGHHHEJC.IsOpen() || OptionsMenuUI.GGFJGHHHEJC.IsOpen() || TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE)
				{
					((Component)tutorialPanelRectTransform).gameObject.SetActive(false);
				}
				else if (!minimisePopUpsClosed && !((Component)tutorialPanelRectTransform).gameObject.activeSelf)
				{
					((Component)tutorialPanelRectTransform).gameObject.SetActive(true);
				}
			}
			if (!BuildingTutorialManager.IKNOJDMCFOK && !FarmConstructionManager.IsActived())
			{
				if (TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE && ((Component)goalsPanelRectTransform).gameObject.activeSelf)
				{
					((Component)goalsPanelRectTransform).gameObject.SetActive(false);
				}
				if (!((Component)tutorialPanelRectTransform).gameObject.activeSelf)
				{
					return;
				}
				if (PlayerInputs.IsGamepadActive(1))
				{
					if (PauseMenuUI.GGFJGHHHEJC.IsOpen() && !minimisePopUpsClosed)
					{
						minimisedObject.SetActive(true);
						buttonObject.SetActive(true);
						closeGamepadSprite.SetImageVisible(NKFPJPCFBJI: true);
						if (PlayerInputs.GetPlayer(PauseMenuUI.GGFJGHHHEJC.JIIGOACEIKL).GetButtonUp(closeGamepadSprite.GetActionType()))
						{
							ClosePopUp();
						}
						else if (Utils.IIHPGJIJOAD(PauseMenuUI.GGFJGHHHEJC.JIIGOACEIKL, ref CMGDCLIIONE, "UIPreviousPage"))
						{
							ScrollLeft();
						}
						else if (Utils.IIHPGJIJOAD(PauseMenuUI.GGFJGHHHEJC.JIIGOACEIKL, ref CMGDCLIIONE, "UINextPage"))
						{
							ScrollRight();
						}
					}
					else
					{
						minimisedObject.SetActive(false);
						buttonObject.SetActive(false);
						closeGamepadSprite.SetImageVisible(NKFPJPCFBJI: false);
					}
				}
				else
				{
					minimisedObject.SetActive(true);
					buttonObject.SetActive(true);
					closeGamepadSprite.SetImageVisible(NKFPJPCFBJI: false);
				}
			}
			else if (minimisedObject.activeSelf)
			{
				minimisedObject.SetActive(false);
				buttonObject.SetActive(false);
			}
		}
	}

	private void BNIGAHFDNFO(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
	}

	private void JNNGCFEBNCO()
	{
		ENNFNPONCMB();
		if (NNHALHFFIEB != null)
		{
			ShowPopUp(NNHALHFFIEB, MDNOOMBIFNN: true, BLKLCBCGHCN: true);
			ENNFNPONCMB();
		}
	}

	[CompilerGenerated]
	private void OIMJFCEPHMB()
	{
		NAFMLLMLHPD = false;
		((MonoBehaviour)this).StartCoroutine(LKOKJPBFKFD());
	}

	private IEnumerator APBJFIHBJCO()
	{
		return new BGMKIKECBPO(1)
		{
			_003C_003E4__this = this
		};
	}

	private void FCJGNOLIGJF(PopUp FKHFBMFJKDM)
	{
		TutorialPopUp tutorialPopUp = (TutorialPopUp)FKHFBMFJKDM;
		((TMP_Text)tutorialBoxText).text = tutorialPopUp.LGMHKCMKMDK(tutorialPopUp.KKNDBMCIEBL);
		((TMP_Text)tutorialBoxText).ForceMeshUpdate(false, false);
	}

	public void KLHMILBINFL()
	{
		MissionsManager.instance.CILMLNGCFHG();
	}

	private void DHNENCKICBL()
	{
		if (EHAEJKGLAHE != null)
		{
			FCJGNOLIGJF(EHAEJKGLAHE);
		}
	}

	public void KCAAJEMLCJA()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		MainUI.NEFOKCKKLNI().Open(0);
		((TMP_Text)MainUI.LBHLPIFCINB().boxText).text = LocalisationSystem.Get(")");
		((UnityEvent)MainUI.NEFOKCKKLNI().yesButton.onClick).AddListener((UnityAction)delegate
		{
			NAFMLLMLHPD = true;
		});
		((UnityEvent)MainUI.GetYesNoDialogue().noButton.onClick).AddListener((UnityAction)delegate
		{
			NAFMLLMLHPD = false;
			((MonoBehaviour)this).StartCoroutine(LKOKJPBFKFD());
		});
	}

	private void DCJJKIMJMLP(int JIIGOACEIKL)
	{
		((Component)tutorialPanelRectTransform).gameObject.SetActive(FNCLBNHNOKF.Any());
	}

	private void FIKFHBLCNGH()
	{
		KIEBNMIAEPF(AODONKKHPBP: true);
	}

	protected override void Awake()
	{
		base.Awake();
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	public void UpdateGoals()
	{
		MissionsManager.instance.UpdateQuest();
	}

	private void KNKIKKFKLGI(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
	}

	public void DeactiveMask(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1 && !GameManager.LocalCoop())
		{
			for (int i = 0; i < masks.Length; i++)
			{
				masks[i].SetActive(false);
			}
		}
		if (!GameManager.LocalCoop())
		{
			return;
		}
		if (JIIGOACEIKL == 2)
		{
			for (int j = 0; j < masks.Length; j++)
			{
				masksPlayer2[j].SetActive(false);
			}
		}
		else
		{
			for (int k = 0; k < masks.Length; k++)
			{
				masksPlayer1[k].SetActive(false);
			}
		}
	}

	public void JDKOBFEPNJG()
	{
		MissionsManager.instance.KCNPLIHEOAB();
	}

	public override void ShowPopUp(PopUp FKHFBMFJKDM, bool MDNOOMBIFNN = true, bool BLKLCBCGHCN = true)
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		base.ShowPopUp(FKHFBMFJKDM, MDNOOMBIFNN);
		HMCIAKJCHLF();
		TutorialPopUp tutorialPopUp = (TutorialPopUp)FKHFBMFJKDM;
		CMLOLBOIPJE = ((Component)tutorialPanelRectTransform).gameObject.activeSelf;
		CJODOOFLLLB = tutorialPopUp.KKNDBMCIEBL;
		((TMP_Text)closePopUpText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Press {0} to continue"), InputUtils.CMOBIDABHKM(tutorialPopUp.KKNDBMCIEBL, "ClosePopUp"));
		((TMP_Text)closePopUpText).ForceMeshUpdate(false, false);
		((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2(-1000f, -1000f));
		UpdateGoals();
		((TMP_Text)tutorialBoxText).text = tutorialPopUp.LGMHKCMKMDK(tutorialPopUp.KKNDBMCIEBL);
		((TMP_Text)tutorialBoxText).ForceMeshUpdate(false, false);
		panelRectTransform.ForceUpdateRectTransforms();
		Utils.JEAHJILAIAP(0f);
		if (tutorialPopUp.NABJHKEFCEN != null)
		{
			FLHJHKMKNMB = tutorialPopUp.NABJHKEFCEN();
		}
		if (MDNOOMBIFNN && importantIDs.Contains(tutorialPopUp.DCFNIMCMFEM))
		{
			NNHALHFFIEB = FKHFBMFJKDM;
			if (!FNCLBNHNOKF.Contains(FKHFBMFJKDM))
			{
				FNCLBNHNOKF.Add(FKHFBMFJKDM);
			}
			NJHCNNPDANG = null;
		}
		else
		{
			buttonPopUp.SetActive(true);
			NJHCNNPDANG = tutorialPopUp;
		}
	}

	[SpecialName]
	public bool DHGMGFNNHCO()
	{
		return _tutorialEnabled;
	}

	private void BGPGIOMKKAO()
	{
		UpdateGoals();
	}

	protected override void ENNFNPONCMB()
	{
		Debug.Log((object)"MinimisePopUp");
		base.ENNFNPONCMB();
		UpdateGoals();
		minimisedObject.SetActive(true);
		buttonObject.SetActive(true);
		TutorialPopUp tutorialPopUp = (TutorialPopUp)NJHCNNPDANG;
		if (NJHCNNPDANG != null && tutorialPopUp.DCFNIMCMFEM == -1)
		{
			((Component)tutorialPanelRectTransform).gameObject.SetActive(CMLOLBOIPJE);
		}
		else
		{
			((Component)tutorialPanelRectTransform).gameObject.SetActive(true);
		}
		if (NNHALHFFIEB != null && ((TutorialPopUp)NNHALHFFIEB).DCFNIMCMFEM == 52 && QuestManager.GGFJGHHHEJC.GetActiveQuest(QuestDatabaseAccessor.GetQuest(3)) == null)
		{
			ActiveQuest activeQuest = QuestManager.GGFJGHHHEJC.AddQuest(QuestDatabaseAccessor.GetQuest(3));
			if (activeQuest != null)
			{
				QuestHighlightUI.ShowNewQuestAvailable(activeQuest.quest);
			}
		}
		Time.timeScale = 1f;
		if (MainUI.IsAnyUIOpen(1))
		{
			MainUI.GetCurrentOpenWindows(1).Last().OnContentActivated();
		}
		if (MainUI.IsAnyUIOpen(2))
		{
			MainUI.GetCurrentOpenWindows(2).Last().OnContentActivated();
		}
		if (FLHJHKMKNMB != null && FLHJHKMKNMB.Any())
		{
			foreach (GameObject item in FLHJHKMKNMB)
			{
				if ((Object)(object)item != (Object)null)
				{
					Utils.BLPDAEHPOBA(item);
				}
			}
		}
		DeactiveMask(1);
		DeactiveMask(2);
		buttonPopUp.SetActive(false);
	}

	private void HMCIAKJCHLF()
	{
		PlayerController.GetPlayer(1).characterAnimation.SetCleaning(NJHMBMGKCPL: false, null);
		PlayerController.GetPlayer(1).characterAnimation.SetInteracting(KOIDJKBBINH: false);
		InteractObject.GetPlayer(1).SetCurrentInteract(null, null);
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).characterAnimation.SetCleaning(NJHMBMGKCPL: false, null);
			PlayerController.GetPlayer(2).characterAnimation.SetInteracting(KOIDJKBBINH: false);
			InteractObject.GetPlayer(2).SetCurrentInteract(null, null);
		}
	}

	private void MACMLILLKDD()
	{
		KIEBNMIAEPF(AODONKKHPBP: true);
	}

	private void CLKMOMODGKF(int JIIGOACEIKL)
	{
		((Component)tutorialPanelRectTransform).gameObject.SetActive(!minimisePopUpsClosed && FNCLBNHNOKF.Any());
	}

	public void SortImportantIDs()
	{
		importantIDs.Sort();
	}

	public void ActiveMask(int JIIGOACEIKL, int ABAIKKGKDGD)
	{
		DeactiveMask(JIIGOACEIKL);
		if (GameManager.LocalCoop())
		{
			if (JIIGOACEIKL == 2)
			{
				masksPlayer2[ABAIKKGKDGD].SetActive(true);
			}
			else
			{
				masksPlayer1[ABAIKKGKDGD].SetActive(true);
			}
		}
		else
		{
			masks[ABAIKKGKDGD].SetActive(true);
		}
	}

	private IEnumerator LKOKJPBFKFD()
	{
		yield return null;
		if (!NAFMLLMLHPD)
		{
			SceneReferences.GetSceneReferences().tutorialCollider.SetActive(false);
			ActiveQuest activeQuest = QuestManager.GGFJGHHHEJC.AddQuest(QuestDatabaseAccessor.GetQuest(3));
			if (activeQuest != null)
			{
				QuestHighlightUI.ShowNewQuestAvailable(activeQuest.quest);
			}
		}
	}

	[SpecialName]
	public void KIEBNMIAEPF(bool AODONKKHPBP)
	{
		_tutorialEnabled = AODONKKHPBP;
		if (!_tutorialEnabled)
		{
			ICGIHNALIIL();
		}
		OnTutorialEnabledChanged(_tutorialEnabled);
	}

	private void FPOIFOGELHC()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		if (KBPGGKMPKHL)
		{
			KBPGGKMPKHL = false;
			return;
		}
		if (LLBPLOCOJAG() && ((Component)contentRectTransform).gameObject.activeSelf)
		{
			Rect rect;
			if (left)
			{
				RectTransform obj = contentRectTransform;
				rect = contentRectTransform.rect;
				((Transform)obj).position = Vector2.op_Implicit(new Vector2(((Rect)(ref rect)).width, (float)(Screen.height / 1)) + panelRectTransform.sizeDelta);
			}
			else if (right)
			{
				RectTransform obj2 = contentRectTransform;
				float num = Screen.width;
				rect = contentRectTransform.rect;
				((Transform)obj2).position = Vector2.op_Implicit(new Vector2(num - ((Rect)(ref rect)).width, (float)(Screen.height / 2)) + panelRectTransform.sizeDelta);
			}
			else
			{
				((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2((float)(Screen.width / 7), (float)(Screen.height / 4)) + panelRectTransform.sizeDelta);
			}
		}
		if (!DHGMGFNNHCO() || OnlineManager.ClientOnline())
		{
			return;
		}
		if (!JCGLIEOIHCP() && popUpQueue.Count > 0 && !BuildingTutorialManager.PABJKGJJHFG() && GameManager.NJNFHEPLEHL().NAPGPOJEEOJ && (!popUpQueue.First().KCFMCFKPDAM() || !MainUI.IsAnyUIOpen(popUpQueue.First().KKNDBMCIEBL)))
		{
			TutorialPopUp fKHFBMFJKDM = popUpQueue.Dequeue();
			MKMBMGCKLCL(fKHFBMFJKDM, MDNOOMBIFNN: true, BLKLCBCGHCN: true);
		}
		else
		{
			if (LLBPLOCOJAG())
			{
				return;
			}
			right = true;
			left = true;
			if (FNCLBNHNOKF.Count() > 0 && !BuildingTutorialManager.PABJKGJJHFG() && !FarmConstructionManager.IsActived())
			{
				if ((!PauseMenuUI.KGPJPILAHDE().BGLJFMHCFJF() && MainUI.AMOAACGGPJO()) || KeybindUI.BIIOFAHFNPA().IsOpen() || OptionsMenuUI.EFPJLFMBPLL().HDEPMJIDJEM() || TavernConstructionManager.KNLLFEJAMNN().LNLJMCONDNE)
				{
					((Component)tutorialPanelRectTransform).gameObject.SetActive(false);
				}
				else if (!minimisePopUpsClosed && !((Component)tutorialPanelRectTransform).gameObject.activeSelf)
				{
					((Component)tutorialPanelRectTransform).gameObject.SetActive(true);
				}
			}
			if (!BuildingTutorialManager.KGJOKHEBLOJ() && !FarmConstructionManager.IsActived())
			{
				if (TavernConstructionManager.DOIKFJDLKJP().LNLJMCONDNE && ((Component)goalsPanelRectTransform).gameObject.activeSelf)
				{
					((Component)goalsPanelRectTransform).gameObject.SetActive(true);
				}
				if (!((Component)tutorialPanelRectTransform).gameObject.activeSelf)
				{
					return;
				}
				if (PlayerInputs.ODGALPDEIFG(1))
				{
					if (PauseMenuUI.BDAGIEIJOOG().BGLJFMHCFJF() && !minimisePopUpsClosed)
					{
						minimisedObject.SetActive(false);
						buttonObject.SetActive(true);
						closeGamepadSprite.SetImageVisible(NKFPJPCFBJI: false);
						if (PlayerInputs.DEGBDMMDIIL(PauseMenuUI.GGFJGHHHEJC.JIIGOACEIKL).CDPCMKGLIDM(closeGamepadSprite.GetActionType()))
						{
							IILLPMNEFNI();
						}
						else if (Utils.IIHPGJIJOAD(PauseMenuUI.GGFJGHHHEJC.JIIGOACEIKL, ref CMGDCLIIONE, "NewQuestAvailable", 1160f))
						{
							ScrollLeft();
						}
						else if (Utils.IIHPGJIJOAD(PauseMenuUI.BDAGIEIJOOG().JIIGOACEIKL, ref CMGDCLIIONE, "itemBrownAle", 832f))
						{
							ScrollRight();
						}
					}
					else
					{
						minimisedObject.SetActive(false);
						buttonObject.SetActive(false);
						closeGamepadSprite.SetImageVisible(NKFPJPCFBJI: true);
					}
				}
				else
				{
					minimisedObject.SetActive(false);
					buttonObject.SetActive(false);
					closeGamepadSprite.SetImageVisible(NKFPJPCFBJI: true);
				}
			}
			else if (minimisedObject.activeSelf)
			{
				minimisedObject.SetActive(true);
				buttonObject.SetActive(true);
			}
		}
	}

	private void GGKFCNCDFMC(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		UpdateGoals();
	}

	public void ShowDialogueTutorialEnabled()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		MainUI.GetYesNoDialogue().Open(1);
		((TMP_Text)MainUI.GetYesNoDialogue().boxText).text = LocalisationSystem.Get("TutorialQuestion");
		((UnityEvent)MainUI.GetYesNoDialogue().yesButton.onClick).AddListener((UnityAction)delegate
		{
			NAFMLLMLHPD = true;
		});
		((UnityEvent)MainUI.GetYesNoDialogue().noButton.onClick).AddListener((UnityAction)delegate
		{
			NAFMLLMLHPD = false;
			((MonoBehaviour)this).StartCoroutine(LKOKJPBFKFD());
		});
	}

	public void ClearSidePopUps()
	{
		FNCLBNHNOKF.Clear();
	}

	[CompilerGenerated]
	private void JEOKAJAKMHL()
	{
		NAFMLLMLHPD = true;
	}

	private void JMFKCNDGPBA(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		UpdateGoals();
	}

	private void Start()
	{
		SaveUI instance = SaveUI.instance;
		instance.OnLoadFadeOutStart = (Action)Delegate.Combine(instance.OnLoadFadeOutStart, new Action(TutorialPopUps.HBOMKPFIFJM));
		GameManager instance2 = GameManager.GGFJGHHHEJC;
		instance2.OnWorldLoaded = (Action)Delegate.Combine(instance2.OnWorldLoaded, new Action(BGPGIOMKKAO));
		OthersMenuUI.OnLanguageDetermined = (Action)Delegate.Combine(OthersMenuUI.OnLanguageDetermined, new Action(DHNENCKICBL));
		CommonReferences instance3 = CommonReferences.GGFJGHHHEJC;
		instance3.OnAnyQuestProgress = (Action<int, ActiveQuest>)Delegate.Combine(instance3.OnAnyQuestProgress, new Action<int, ActiveQuest>(GGKFCNCDFMC));
		PauseMenuUI instance4 = PauseMenuUI.GGFJGHHHEJC;
		instance4.OnUIOpen = (Action<int>)Delegate.Combine(instance4.OnUIOpen, new Action<int>(DCJJKIMJMLP));
		PauseMenuUI instance5 = PauseMenuUI.GGFJGHHHEJC;
		instance5.OnUIClose = (Action<int>)Delegate.Combine(instance5.OnUIClose, new Action<int>(CLKMOMODGKF));
		UIWindow.OnAnyUIOpen = (Action<int, UIWindow>)Delegate.Combine(UIWindow.OnAnyUIOpen, new Action<int, UIWindow>(KNKIKKFKLGI));
		UIWindow.OnAnyUIClose = (Action<int, UIWindow>)Delegate.Combine(UIWindow.OnAnyUIClose, new Action<int, UIWindow>(KNKIKKFKLGI));
		((Component)goalsPanelRectTransform).gameObject.SetActive(false);
	}
}
