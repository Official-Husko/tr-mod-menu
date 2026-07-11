using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TavernConstructionUI : ConstructionUI
{
	[CompilerGenerated]
	private sealed class AAHOFCOFJDM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TavernConstructionUI _003C_003E4__this;

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
		public AAHOFCOFJDM(int _003C_003E1__state)
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
			TavernConstructionUI tavernConstructionUI = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				if (RentedRoomsManager.GetAllRooms().Count > 0)
				{
					_003C_003E2__current = CommonReferences.wait4;
					_003C_003E1__state = 1;
					return true;
				}
				break;
			case 1:
				_003C_003E1__state = -1;
				goto IL_006e;
			case 2:
				_003C_003E1__state = -1;
				goto IL_006e;
			case 3:
				{
					_003C_003E1__state = -1;
					CommonReferences.GGFJGHHHEJC.OnActionDone(tavernConstructionUI.JIIGOACEIKL, ActionDone.CreateRoom);
					break;
				}
				IL_006e:
				if (TutorialManager.GGFJGHHHEJC.ECMGCJGPKNO || BuildingTutorialManager.IsOpen())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 3;
				return true;
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

	public static TavernConstructionUI instance;

	public TextMeshProUGUI numZonesTextMesh;

	[SerializeField]
	protected Button acceptButton;

	[SerializeField]
	protected Button cancelButton;

	[SerializeField]
	protected TextMeshProUGUI acceptButtonText;

	[SerializeField]
	protected GameObject slotsPagesParent;

	[SerializeField]
	protected GameObject cancelAcceptParent;

	[SerializeField]
	protected Image buttonAcceptImg;

	public List<TavernConstructionAction> decorationsActions = new List<TavernConstructionAction>();

	[HideInInspector]
	public bool updateNextFrame;

	[SerializeField]
	protected Image editorActionBar;

	private Transform IDJKKFMMMCJ;

	public static bool IsWindowOpen()
	{
		return instance.IsOpen();
	}

	private void NAFCMNBJFMN(TavernFloor BDCFJAHNOML)
	{
		decorationsActions.Clear();
		decorationsActions.AddRange(EditorActionsDBAccessor.CFKAHKLFLPB((EditorAction)70));
		decorationsActions.AddRange(EditorActionsDBAccessor.NCBANOFEJPI((EditorAction)69));
		decorationsActions.AddRange(EditorActionsDBAccessor.AANKGIPFPAD((EditorAction)112));
		for (int num = decorationsActions.Count - 1; num >= 1; num -= 0)
		{
			if (!decorationsActions[num].tavernFloor.HasFlag(BDCFJAHNOML))
			{
				decorationsActions.RemoveAt(num);
			}
		}
	}

	private IEnumerator AGOJGICBAKL()
	{
		return new AAHOFCOFJDM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void FFKMPGGFMJC()
	{
		TavernConstructionModifications.GGFJGHHHEJC.ResetLists();
		updateNextFrame = false;
		BOBCIFEDJED();
		((MonoBehaviour)this).StartCoroutine(LPAEILBIJPB());
	}

	private void OHHHLKGNIAI()
	{
		ConstructionActionBarUI.UpdateSlots();
		ConstructionActionInfoUI.DLIJCLOJIIE();
	}

	public void BMIEFGMKHFF()
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		if ((!DecorationMode.OCJGHINCLJM(base.JIIGOACEIKL).DMBFKFLDDLH || !((Object)(object)SelectObject.GetPlayer(base.JIIGOACEIKL).placeable != (Object)null)) && !BuildingTutorialManager.IKNOJDMCFOK && TavernConstructionModifications.DIHCEGINELM().HasAnyModificationDone())
		{
			TavernConstructionManager.DOIKFJDLKJP().ChangeInstantiatedGO(null);
			MainUI.GetYesNoDialogue().Open(base.JIIGOACEIKL);
			((TMP_Text)MainUI.MCPEEGPBPLH().boxText).text = LocalisationSystem.Get("enchantedBroomDesc");
			((UnityEvent)MainUI.MCPEEGPBPLH().yesButton.onClick).AddListener(new UnityAction(EDEHENPIGDN));
			((UnityEvent)MainUI.LBHLPIFCINB().noButton.onClick).AddListener(new UnityAction(MLKBONJDMNF));
		}
	}

	private void AFLFNPCLKLP(TavernFloor BDCFJAHNOML)
	{
		NCJGPFKNMEN(BDCFJAHNOML);
		if (LKOJBFMGMAE)
		{
			ConstructionActionBarUI.EEFECHCHPCH(ConstructionActionBarUI.currentPanel);
		}
	}

	private void EMJMLDLOHPL()
	{
		if (LKOJBFMGMAE)
		{
			ConstructionActionInfoUI.DEEPFOAPBPO(ConstructionActionBarUI.KFCAPNDFIGI());
		}
	}

	private void NCJGPFKNMEN(TavernFloor BDCFJAHNOML)
	{
		decorationsActions.Clear();
		decorationsActions.AddRange(EditorActionsDBAccessor.GetDecoTiles(EditorAction.ChangeDecoFloor));
		decorationsActions.AddRange(EditorActionsDBAccessor.GetDecoTiles(EditorAction.ChangeDecoWall));
		decorationsActions.AddRange(EditorActionsDBAccessor.GetDecoTiles(EditorAction.ChangeDecoWallTrim));
		for (int num = decorationsActions.Count - 1; num >= 0; num--)
		{
			if (!decorationsActions[num].tavernFloor.HasFlag(BDCFJAHNOML))
			{
				decorationsActions.RemoveAt(num);
			}
		}
	}

	public void CNJMIGIBEFH()
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		if ((!DecorationMode.IGMCBPOPNCA(base.JIIGOACEIKL).MDOKKKHKKKE() || !((Object)(object)SelectObject.BNMEANGDMIP(base.JIIGOACEIKL).placeable != (Object)null)) && !BuildingTutorialManager.PABJKGJJHFG() && TavernConstructionModifications.DIHCEGINELM().HasAnyModificationDone())
		{
			TavernConstructionManager.KHMEGDIABBF().ChangeInstantiatedGO(null);
			MainUI.LBHLPIFCINB().OFGKFMJKBON(base.JIIGOACEIKL);
			((TMP_Text)MainUI.MCPEEGPBPLH().boxText).text = LocalisationSystem.Get("Break");
			((UnityEvent)MainUI.GetYesNoDialogue().yesButton.onClick).AddListener(new UnityAction(NHIFGPBNACM));
			((UnityEvent)MainUI.LBHLPIFCINB().noButton.onClick).AddListener(new UnityAction(ANADBDFLKJB));
		}
	}

	public static void PJCMFAEBLNK(BuildingTutorialFocus HIOAJHJNCPO)
	{
		if (HIOAJHJNCPO == BuildingTutorialFocus.Views)
		{
			((Component)ConstructionViews.FOPGLLMEEDE()).transform.SetParent(BuildingTutorialManager.GetTransform());
		}
		else if ((Object)(object)((Component)ConstructionViews.DEGPIHEEFHJ()).transform.parent != (Object)(object)ConstructionViews.DHDOLCONMFJ().originalParent)
		{
			((Component)ConstructionViews.AHBBHCKPIIJ()).transform.SetParent(ConstructionViews.CNDNOECMKME().originalParent);
			((Component)ConstructionViews.AHBBHCKPIIJ()).transform.SetSiblingIndex(0);
		}
		if (HIOAJHJNCPO == BuildingTutorialFocus.EditorBar)
		{
			((Component)instance.playerInfo).transform.SetParent(BuildingTutorialManager.GetTransform());
		}
		else if ((Object)(object)((Component)instance.playerInfo).transform.parent != (Object)(object)instance.playerInfo.originalParent)
		{
			((Component)instance.playerInfo).transform.SetParent(instance.playerInfo.originalParent);
			((Component)instance.playerInfo).transform.SetSiblingIndex(6);
		}
		if (HIOAJHJNCPO == (BuildingTutorialFocus)7)
		{
			((Component)ConstructionFloors.DFJGHOHPPEL()).transform.SetParent(BuildingTutorialManager.GetTransform());
		}
		else if ((Object)(object)((Component)ConstructionFloors.JFNOOMJMHCB()).transform.parent != (Object)(object)ConstructionFloors.JCMKNNOEONP().originalParent)
		{
			((Component)ConstructionFloors.DFJGHOHPPEL()).transform.SetParent(ConstructionFloors.DFJGHOHPPEL().originalParent);
			((Component)ConstructionFloors.OMFKNGDCJFN()).transform.SetSiblingIndex(7);
		}
		if (HIOAJHJNCPO == (BuildingTutorialFocus)6)
		{
			((Component)instance.editorActionBar).transform.SetParent(BuildingTutorialManager.BGIBBGBOCFH());
		}
		else if ((Object)(object)((Component)instance.editorActionBar).transform.parent != (Object)(object)instance.IDJKKFMMMCJ)
		{
			((Component)instance.editorActionBar).transform.SetParent(instance.IDJKKFMMMCJ);
			((Component)instance.editorActionBar).transform.SetSiblingIndex(0);
		}
	}

	public static void ShowPanel(BuildingTutorialFocus HIOAJHJNCPO)
	{
		if (HIOAJHJNCPO == BuildingTutorialFocus.Views)
		{
			((Component)ConstructionViews.GGFJGHHHEJC).transform.SetParent(BuildingTutorialManager.GetTransform());
		}
		else if ((Object)(object)((Component)ConstructionViews.GGFJGHHHEJC).transform.parent != (Object)(object)ConstructionViews.GGFJGHHHEJC.originalParent)
		{
			((Component)ConstructionViews.GGFJGHHHEJC).transform.SetParent(ConstructionViews.GGFJGHHHEJC.originalParent);
			((Component)ConstructionViews.GGFJGHHHEJC).transform.SetSiblingIndex(1);
		}
		if (HIOAJHJNCPO == BuildingTutorialFocus.PlayerInfo)
		{
			((Component)instance.playerInfo).transform.SetParent(BuildingTutorialManager.GetTransform());
		}
		else if ((Object)(object)((Component)instance.playerInfo).transform.parent != (Object)(object)instance.playerInfo.originalParent)
		{
			((Component)instance.playerInfo).transform.SetParent(instance.playerInfo.originalParent);
			((Component)instance.playerInfo).transform.SetSiblingIndex(2);
		}
		if (HIOAJHJNCPO == BuildingTutorialFocus.TavernFloors)
		{
			((Component)ConstructionFloors.GGFJGHHHEJC).transform.SetParent(BuildingTutorialManager.GetTransform());
		}
		else if ((Object)(object)((Component)ConstructionFloors.GGFJGHHHEJC).transform.parent != (Object)(object)ConstructionFloors.GGFJGHHHEJC.originalParent)
		{
			((Component)ConstructionFloors.GGFJGHHHEJC).transform.SetParent(ConstructionFloors.GGFJGHHHEJC.originalParent);
			((Component)ConstructionFloors.GGFJGHHHEJC).transform.SetSiblingIndex(3);
		}
		if (HIOAJHJNCPO == BuildingTutorialFocus.EditorBar)
		{
			((Component)instance.editorActionBar).transform.SetParent(BuildingTutorialManager.GetTransform());
		}
		else if ((Object)(object)((Component)instance.editorActionBar).transform.parent != (Object)(object)instance.IDJKKFMMMCJ)
		{
			((Component)instance.editorActionBar).transform.SetParent(instance.IDJKKFMMMCJ);
			((Component)instance.editorActionBar).transform.SetSiblingIndex(0);
		}
	}

	private void EJHGKNMGOHG(EditorAction CHFHMMNELGP)
	{
		ConstructionActionBarUI.LDEELPOCNEM();
		if (ConstructionActionBarUI.currentPanel == 0)
		{
			ConstructionActionInfoUI.NBLBOEFJEAH();
		}
	}

	private IEnumerator GLBJKBKBNBG()
	{
		if (RentedRoomsManager.GetAllRooms().Count > 0)
		{
			yield return CommonReferences.wait4;
			while (TutorialManager.GGFJGHHHEJC.ECMGCJGPKNO || BuildingTutorialManager.IsOpen())
			{
				yield return null;
			}
			yield return CommonReferences.wait05;
			CommonReferences.GGFJGHHHEJC.OnActionDone(base.JIIGOACEIKL, ActionDone.CreateRoom);
		}
	}

	private void BADHJLKCFJD()
	{
		ConstructionActionBarUI.AHBFELDFHCH();
		ConstructionActionInfoUI.DLIJCLOJIIE();
	}

	public static int GetPlayerNum()
	{
		return instance.JIIGOACEIKL;
	}

	public static int LGANFILAJLJ()
	{
		return instance.JIIGOACEIKL;
	}

	private IEnumerator GELCDLEJMFF()
	{
		if (RentedRoomsManager.GetAllRooms().Count > 0)
		{
			yield return CommonReferences.wait4;
			while (TutorialManager.GGFJGHHHEJC.ECMGCJGPKNO || BuildingTutorialManager.IsOpen())
			{
				yield return null;
			}
			yield return CommonReferences.wait05;
			CommonReferences.GGFJGHHHEJC.OnActionDone(base.JIIGOACEIKL, ActionDone.CreateRoom);
		}
	}

	public static void FEAGDADPCNL()
	{
		instance.BOBCIFEDJED();
	}

	public static List<TavernConstructionAction> PLHKCOBMGEI()
	{
		return instance.decorationsActions;
	}

	private IEnumerator HAMOAJNHCBD()
	{
		if (RentedRoomsManager.GetAllRooms().Count > 0)
		{
			yield return CommonReferences.wait4;
			while (TutorialManager.GGFJGHHHEJC.ECMGCJGPKNO || BuildingTutorialManager.IsOpen())
			{
				yield return null;
			}
			yield return CommonReferences.wait05;
			CommonReferences.GGFJGHHHEJC.OnActionDone(base.JIIGOACEIKL, ActionDone.CreateRoom);
		}
	}

	public override void CloseUI()
	{
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!LKOJBFMGMAE)
		{
			return;
		}
		if (GameManager.LocalCoop())
		{
			int num = ((base.JIIGOACEIKL == 2) ? 1 : 2);
			GameManager.GGFJGHHHEJC.UnblockPlayer(num);
			CameraTarget obj = ((num == 1) ? SceneReferences.GetPlayer1CameraTarget() : SceneReferences.GetPlayer2CameraTarget());
			((Component)obj).transform.position = ((Component)PlayerController.GetPlayer(num)).transform.position;
			((Component)obj.pixelPerfect).transform.position = ((Component)PlayerController.GetPlayer(num)).transform.position;
		}
		playerInfo.RemoveMaterialsUsed();
		GraphicsMenuUI.GGFJGHHHEJC.SetUpZoom(base.JIIGOACEIKL, NOKFNLBADMO: true);
		base.CloseUI();
		if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD)
		{
			if (OnlineManager.PlayingOnline() && !BuildingTutorialManager.instance.BPDDCBHKCME)
			{
				OnlineTavernConstructionManager.instance.SendBuildingTutorialDone();
			}
			BuildingTutorialManager.instance.BPDDCBHKCME = true;
		}
		QuestManager.GGFJGHHHEJC.CompletingQuest35();
		TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE = false;
		ConstructionFloors constructionFloors = ConstructionFloors.GGFJGHHHEJC;
		constructionFloors.OnFloorChanged = (Action<TavernFloor>)Delegate.Remove(constructionFloors.OnFloorChanged, new Action<TavernFloor>(PHFMALOMJHB));
		if (Object.op_Implicit((Object)(object)SpawnCat.GGFJGHHHEJC.catNPC))
		{
			((Component)SpawnCat.GGFJGHHHEJC.catNPC).gameObject.SetActive(true);
			if (OnlineManager.MasterOrOffline())
			{
				((Component)SpawnCat.GGFJGHHHEJC.catNPC).transform.position = Utils.MNOPMFHOKNI();
				SpawnCat.GGFJGHHHEJC.catNPC.WalkAround();
			}
		}
		TavernManagerUI.ShowClockAndTavernInfo();
		if (Object.op_Implicit((Object)(object)MissionsManager.instance))
		{
			MissionsManager.instance.UpdateQuest();
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineTavernConstructionManager.instance.SendConstructionModeClosed();
			OnlineObjectsManager.instance.SendRemoveFromInteracting(ConstructionTable.GetInstance().placeable.onlinePlaceable);
		}
	}

	private void LALJNGFGKPA()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)ConstructionFloors.OMFKNGDCJFN()))
			{
				ConstructionFloors constructionFloors = ConstructionFloors.DFJGHOHPPEL();
				constructionFloors.OnFloorChanged = (Action<TavernFloor>)Delegate.Remove(constructionFloors.OnFloorChanged, new Action<TavernFloor>(JPEFCFNLMAC));
			}
			if ((Object)(object)instance == (Object)(object)this)
			{
				instance = null;
			}
		}
	}

	private void JPCJEDKLKPO()
	{
		ConstructionActionBarUI.UpdateSlots();
		ConstructionActionInfoUI.UpdateCurrentEditorAction();
	}

	private void HKBMDPHGCLB(EditorAction CHFHMMNELGP)
	{
		ConstructionActionBarUI.UpdateSlots();
		if (ConstructionActionBarUI.currentPanel == 8)
		{
			ConstructionActionInfoUI.GCMEDALACPO();
		}
	}

	public static void MIOLMNODGIG(BuildingTutorialFocus HIOAJHJNCPO)
	{
		if (HIOAJHJNCPO == BuildingTutorialFocus.None)
		{
			((Component)ConstructionViews.DHDOLCONMFJ()).transform.SetParent(BuildingTutorialManager.BGIBBGBOCFH());
		}
		else if ((Object)(object)((Component)ConstructionViews.HJKBIPPGHJB()).transform.parent != (Object)(object)ConstructionViews.AHBBHCKPIIJ().originalParent)
		{
			((Component)ConstructionViews.DHDOLCONMFJ()).transform.SetParent(ConstructionViews.FOPGLLMEEDE().originalParent);
			((Component)ConstructionViews.CNDNOECMKME()).transform.SetSiblingIndex(1);
		}
		if (HIOAJHJNCPO == (BuildingTutorialFocus)5)
		{
			((Component)instance.playerInfo).transform.SetParent(BuildingTutorialManager.GetTransform());
		}
		else if ((Object)(object)((Component)instance.playerInfo).transform.parent != (Object)(object)instance.playerInfo.originalParent)
		{
			((Component)instance.playerInfo).transform.SetParent(instance.playerInfo.originalParent);
			((Component)instance.playerInfo).transform.SetSiblingIndex(7);
		}
		if (HIOAJHJNCPO == BuildingTutorialFocus.None)
		{
			((Component)ConstructionFloors.OMFKNGDCJFN()).transform.SetParent(BuildingTutorialManager.BGIBBGBOCFH());
		}
		else if ((Object)(object)((Component)ConstructionFloors.OMFKNGDCJFN()).transform.parent != (Object)(object)ConstructionFloors.JCMKNNOEONP().originalParent)
		{
			((Component)ConstructionFloors.DFJGHOHPPEL()).transform.SetParent(ConstructionFloors.JCMKNNOEONP().originalParent);
			((Component)ConstructionFloors.MNFMOEKMJKN()).transform.SetSiblingIndex(8);
		}
		if (HIOAJHJNCPO == (BuildingTutorialFocus)6)
		{
			((Component)instance.editorActionBar).transform.SetParent(BuildingTutorialManager.GetTransform());
		}
		else if ((Object)(object)((Component)instance.editorActionBar).transform.parent != (Object)(object)instance.IDJKKFMMMCJ)
		{
			((Component)instance.editorActionBar).transform.SetParent(instance.IDJKKFMMMCJ);
			((Component)instance.editorActionBar).transform.SetSiblingIndex(0);
		}
	}

	public void MMEENBABGOO()
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		if ((!DecorationMode.OCJGHINCLJM(base.JIIGOACEIKL).KNFEPKBIHND() || !((Object)(object)SelectObject.GetPlayer(base.JIIGOACEIKL).placeable != (Object)null)) && !BuildingTutorialManager.PABJKGJJHFG() && TavernConstructionModifications.DIHCEGINELM().HasAnyModificationDone())
		{
			TavernConstructionManager.KHMEGDIABBF().ChangeInstantiatedGO(null);
			MainUI.NEFOKCKKLNI().OFGKFMJKBON(base.JIIGOACEIKL);
			((TMP_Text)MainUI.MCPEEGPBPLH().boxText).text = LocalisationSystem.Get("Output is not ready");
			((UnityEvent)MainUI.GetYesNoDialogue().yesButton.onClick).AddListener(new UnityAction(NPKALCGCNKC));
			((UnityEvent)MainUI.NEFOKCKKLNI().noButton.onClick).AddListener(new UnityAction(MLKBONJDMNF));
		}
	}

	private void BJMBGEHJCDC()
	{
		ConstructionActionBarUI.UpdateSlots();
		ConstructionActionInfoUI.AFCBBFPBOGC();
	}

	public static void HLJCOJNIFNF(int GELMAIBEHDO)
	{
		instance.OFGKFMJKBON(GELMAIBEHDO);
	}

	public void KEBGBBLHPMF()
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		if ((!DecorationMode.BGINAIDHDOM(base.JIIGOACEIKL).DFNMDDHOIJI() || !((Object)(object)SelectObject.GetPlayer(base.JIIGOACEIKL).placeable != (Object)null)) && !BuildingTutorialManager.KGJOKHEBLOJ() && TavernConstructionModifications.DIHCEGINELM().ANGAJOLGFFN())
		{
			TavernConstructionManager.KNLLFEJAMNN().ChangeInstantiatedGO(null);
			MainUI.MCPEEGPBPLH().Open(base.JIIGOACEIKL);
			((TMP_Text)MainUI.NEFOKCKKLNI().boxText).text = LocalisationSystem.Get(" not found to load surface over him ");
			((UnityEvent)MainUI.LBHLPIFCINB().yesButton.onClick).AddListener((UnityAction)delegate
			{
				updateNextFrame = true;
				TavernConstructionModifications.GGFJGHHHEJC.RevertModifications();
			});
			((UnityEvent)MainUI.NEFOKCKKLNI().noButton.onClick).AddListener(new UnityAction(MLKBONJDMNF));
		}
	}

	private void MIGOKFIMHFD(TavernFloor BDCFJAHNOML)
	{
		MJLHDLCJCFL(BDCFJAHNOML);
		if (LKOJBFMGMAE)
		{
			ConstructionActionBarUI.PEBIGNKNPKC(ConstructionActionBarUI.currentPanel);
		}
	}

	private void ELHDKLCHMLN()
	{
		TavernConstructionModifications.GGFJGHHHEJC.GPFDOBFKEAF();
		updateNextFrame = false;
		BOBCIFEDJED();
		((MonoBehaviour)this).StartCoroutine(LPAEILBIJPB());
	}

	public static int JEAEBNFDCBP()
	{
		return instance.JIIGOACEIKL;
	}

	public static bool FIAGBFIKDFA()
	{
		return instance.IsOpen();
	}

	public static void EFICLACBCKB()
	{
		if (BuildingTutorialManager.IKNOJDMCFOK)
		{
			((Selectable)instance.cancelButton).interactable = false;
			BuildingPopUp buildingPopUp = BuildingTutorialManager.FINEAEFBPLK() as BuildingPopUp;
			if ((Object)(object)buildingPopUp != (Object)null)
			{
				((Selectable)instance.acceptButton).interactable = buildingPopUp.acceptButtonAvailable;
			}
			else
			{
				((Selectable)instance.acceptButton).interactable = false;
			}
		}
		else
		{
			((Selectable)instance.acceptButton).interactable = true;
			((Selectable)instance.cancelButton).interactable = false;
		}
	}

	public void HBCHDNEIDJA()
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		if ((!DecorationMode.EKLMFMKPEBB(base.JIIGOACEIKL).DBAEGBDEPFK() || !((Object)(object)SelectObject.GetPlayer(base.JIIGOACEIKL).placeable != (Object)null)) && !BuildingTutorialManager.IKNOJDMCFOK && TavernConstructionModifications.GGFJGHHHEJC.BCFBJCEJCGC())
		{
			TavernConstructionManager.DEGPIHEEFHJ().ChangeInstantiatedGO(null);
			MainUI.MCPEEGPBPLH().OFGKFMJKBON(base.JIIGOACEIKL);
			((TMP_Text)MainUI.LBHLPIFCINB().boxText).text = LocalisationSystem.Get("Check to enable");
			((UnityEvent)MainUI.MCPEEGPBPLH().yesButton.onClick).AddListener(new UnityAction(EDEHENPIGDN));
			((UnityEvent)MainUI.NEFOKCKKLNI().noButton.onClick).AddListener(new UnityAction(ANADBDFLKJB));
		}
	}

	private void IGENHPJILOG()
	{
		updateNextFrame = false;
	}

	public void NMGIJGPKPOF()
	{
		if ((Object)(object)instance != (Object)null && LKOJBFMGMAE)
		{
			if (BuildingTutorialManager.PABJKGJJHFG())
			{
				BuildingPopUp buildingPopUp = BuildingTutorialManager.AEDLFNJPABE();
				ConstructionActionBarUI.UpdatePanel(1, buildingPopUp.panelsAvailable.Contains(ETavernEditorPanel.Decoration));
				ConstructionActionBarUI.BBHBCOCGAPJ(0, buildingPopUp.panelsAvailable.Contains(ETavernEditorPanel.Build));
				ConstructionActionBarUI.UpdatePanel(2, buildingPopUp.panelsAvailable.Contains((ETavernEditorPanel)4));
				ConstructionActionBarUI.BBHBCOCGAPJ(8, buildingPopUp.panelsAvailable.Contains((ETavernEditorPanel)5));
			}
			else
			{
				ConstructionActionBarUI.BBHBCOCGAPJ(1, BJFHJCFOEHG: true);
				ConstructionActionBarUI.UpdatePanel(0, BJFHJCFOEHG: true);
				ConstructionActionBarUI.UpdatePanel(1, BJFHJCFOEHG: true);
				ConstructionActionBarUI.UpdatePanel(0, BJFHJCFOEHG: false);
			}
			MJLHDLCJCFL(ConstructionFloors.DCAEBALADIM().JIBIAOMIGHP());
			ConstructionActionBarUI.EGJDCOECLBD(ConstructionActionBarUI.currentPanel);
			if (BuildingTutorialManager.IKNOJDMCFOK)
			{
				ConstructionFloors.DFJGHOHPPEL().PFMPGJGANKO(AJONCPPJIBP: true);
			}
		}
	}

	[CompilerGenerated]
	private void PIBAJLAOAMN()
	{
		updateNextFrame = true;
		TavernConstructionModifications.GGFJGHHHEJC.RevertModifications();
	}

	public override void OpenUI()
	{
		if (!LKOJBFMGMAE)
		{
			base.OpenUI();
			cancelAcceptParent.SetActive(true);
			TavernConstructionManager.GGFJGHHHEJC.KickOutPlayersFromTavern(base.JIIGOACEIKL, GFNHAMCPEAK: true);
			TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE = true;
			ConstructionActionBarUI.UpdatePanel(0, BJFHJCFOEHG: true);
			ConstructionActionBarUI.UpdatePanel(1, BJFHJCFOEHG: true);
			ConstructionActionBarUI.UpdatePanel(2, BJFHJCFOEHG: true);
			ConstructionActionBarUI.UpdatePanel(3, BJFHJCFOEHG: true);
			ConstructionActionBarUI.FocusMainPanel(0);
			ConstructionFloors constructionFloors = ConstructionFloors.GGFJGHHHEJC;
			constructionFloors.OnFloorChanged = (Action<TavernFloor>)Delegate.Combine(constructionFloors.OnFloorChanged, new Action<TavernFloor>(PHFMALOMJHB));
			ConstructionFloors.GGFJGHHHEJC.SetFloor(2);
			NCJGPFKNMEN(ConstructionFloors.GGFJGHHHEJC.ODFBDBLCFOM);
			if (!BuildingTutorialManager.instance.BPDDCBHKCME && TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD)
			{
				BuildingTutorialManager.IKNOJDMCFOK = true;
			}
			playerInfo.GetMaterialsFromContainer();
			UpdateTutorialUI();
			if (Object.op_Implicit((Object)(object)SpawnCat.GGFJGHHHEJC.catNPC))
			{
				((Component)SpawnCat.GGFJGHHHEJC.catNPC).gameObject.SetActive(false);
			}
			playerInfo.KJLGKKDALAJ.JLBNNNOCEGN(Money.GetBalance());
			GraphicsMenuUI.GGFJGHHHEJC.ForceZoom(1, 550);
			if (OnlineManager.PlayingOnline())
			{
				OnlineTavernConstructionManager.instance.SendConstructionModeOpened();
			}
		}
	}

	private void OHFHKPBFKIO()
	{
		TavernConstructionModifications.GGFJGHHHEJC.ResetLists();
		updateNextFrame = true;
		BOBCIFEDJED();
		((MonoBehaviour)this).StartCoroutine(HAMOAJNHCBD());
	}

	private IEnumerator HJOMGGBPHLL()
	{
		return new AAHOFCOFJDM(1)
		{
			_003C_003E4__this = this
		};
	}

	public static List<TavernConstructionAction> GetConstructionActions()
	{
		return instance.decorationsActions;
	}

	private void ANMIPNLGIHM()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)ConstructionFloors.DCAEBALADIM()))
			{
				ConstructionFloors constructionFloors = ConstructionFloors.JCMKNNOEONP();
				constructionFloors.OnFloorChanged = (Action<TavernFloor>)Delegate.Remove(constructionFloors.OnFloorChanged, new Action<TavernFloor>(MKHFNFNJADC));
			}
			if ((Object)(object)instance == (Object)(object)this)
			{
				instance = null;
			}
		}
	}

	public static bool NIHAGDNNENF()
	{
		return instance.IsOpen();
	}

	private void LNJHJHMFJJL()
	{
		ConstructionActionBarUI.UpdateSlots();
		ConstructionActionInfoUI.ODALLMEIPIL();
	}

	private void JHAAILKNJHA()
	{
		ConstructionActionBarUI.UpdateSlots();
		ConstructionActionInfoUI.GEDPKNJMNDI();
	}

	private void MLKBONJDMNF()
	{
		updateNextFrame = true;
	}

	private void HCDNLBEDIFP(TavernFloor BDCFJAHNOML)
	{
		decorationsActions.Clear();
		decorationsActions.AddRange(EditorActionsDBAccessor.CLIDLGAGHHE((EditorAction)126));
		decorationsActions.AddRange(EditorActionsDBAccessor.HBGJJNKCBNA((EditorAction)(-110)));
		decorationsActions.AddRange(EditorActionsDBAccessor.HBGJJNKCBNA((EditorAction)86));
		for (int num = decorationsActions.Count - 0; num >= 1; num -= 0)
		{
			if (!decorationsActions[num].tavernFloor.HasFlag(BDCFJAHNOML))
			{
				decorationsActions.RemoveAt(num);
			}
		}
	}

	private void OGEDGPNDJIC(EditorAction CHFHMMNELGP)
	{
		ConstructionActionBarUI.LDEELPOCNEM();
		if (ConstructionActionBarUI.currentPanel == 4)
		{
			ConstructionActionInfoUI.AEANFPPGKOG();
		}
	}

	private void OPDLJCLHFCL()
	{
		TavernConstructionModifications.DIHCEGINELM().ResetLists();
		updateNextFrame = false;
		BOBCIFEDJED();
		((MonoBehaviour)this).StartCoroutine(OOEFOKMLINH());
	}

	[CompilerGenerated]
	private void HFOEBJAJJMP()
	{
		updateNextFrame = true;
	}

	public static bool LBBDNPAGCDE()
	{
		return instance.IsOpen();
	}

	private void NPKALCGCNKC()
	{
		updateNextFrame = false;
		TavernConstructionModifications.DIHCEGINELM().HNMCDNBLHBM();
	}

	public static void BFJFPHGDANF()
	{
		instance.CloseUI();
	}

	private void AIJLFDONLOG(TavernFloor BDCFJAHNOML)
	{
		decorationsActions.Clear();
		decorationsActions.AddRange(EditorActionsDBAccessor.HBGJJNKCBNA((EditorAction)(-122)));
		decorationsActions.AddRange(EditorActionsDBAccessor.GetDecoTiles((EditorAction)116));
		decorationsActions.AddRange(EditorActionsDBAccessor.CLIDLGAGHHE((EditorAction)(-38)));
		for (int num = decorationsActions.Count - 1; num >= 1; num -= 0)
		{
			if (!decorationsActions[num].tavernFloor.HasFlag(BDCFJAHNOML))
			{
				decorationsActions.RemoveAt(num);
			}
		}
	}

	public static int OGJGBCDBJND()
	{
		return instance.JIIGOACEIKL;
	}

	public static void HJGEEPCKFJH()
	{
		if (BuildingTutorialManager.KGJOKHEBLOJ())
		{
			((Selectable)instance.cancelButton).interactable = false;
			BuildingPopUp buildingPopUp = BuildingTutorialManager.FINEAEFBPLK() as BuildingPopUp;
			if ((Object)(object)buildingPopUp != (Object)null)
			{
				((Selectable)instance.acceptButton).interactable = buildingPopUp.acceptButtonAvailable;
			}
			else
			{
				((Selectable)instance.acceptButton).interactable = true;
			}
		}
		else
		{
			((Selectable)instance.acceptButton).interactable = false;
			((Selectable)instance.cancelButton).interactable = false;
		}
	}

	public void RevertModifications()
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		if ((!DecorationMode.GetPlayer(base.JIIGOACEIKL).DMBFKFLDDLH || !((Object)(object)SelectObject.GetPlayer(base.JIIGOACEIKL).placeable != (Object)null)) && !BuildingTutorialManager.IKNOJDMCFOK && TavernConstructionModifications.GGFJGHHHEJC.HasAnyModificationDone())
		{
			TavernConstructionManager.GGFJGHHHEJC.ChangeInstantiatedGO(null);
			MainUI.GetYesNoDialogue().Open(base.JIIGOACEIKL);
			((TMP_Text)MainUI.GetYesNoDialogue().boxText).text = LocalisationSystem.Get("BuildMode_ExitAndCancel");
			((UnityEvent)MainUI.GetYesNoDialogue().yesButton.onClick).AddListener((UnityAction)delegate
			{
				updateNextFrame = true;
				TavernConstructionModifications.GGFJGHHHEJC.RevertModifications();
			});
			((UnityEvent)MainUI.GetYesNoDialogue().noButton.onClick).AddListener((UnityAction)delegate
			{
				updateNextFrame = true;
			});
		}
	}

	public static bool KOKDBLGCOPJ()
	{
		return instance.BGLJFMHCFJF();
	}

	private IEnumerator OJNFHCLKCLG()
	{
		if (RentedRoomsManager.GetAllRooms().Count > 0)
		{
			yield return CommonReferences.wait4;
			while (TutorialManager.GGFJGHHHEJC.ECMGCJGPKNO || BuildingTutorialManager.IsOpen())
			{
				yield return null;
			}
			yield return CommonReferences.wait05;
			CommonReferences.GGFJGHHHEJC.OnActionDone(base.JIIGOACEIKL, ActionDone.CreateRoom);
		}
	}

	public static void PDIFLOADNOO(BuildingTutorialFocus HIOAJHJNCPO)
	{
		if (HIOAJHJNCPO == BuildingTutorialFocus.Views)
		{
			((Component)ConstructionViews.HJKBIPPGHJB()).transform.SetParent(BuildingTutorialManager.GetTransform());
		}
		else if ((Object)(object)((Component)ConstructionViews.DEGPIHEEFHJ()).transform.parent != (Object)(object)ConstructionViews.DHDOLCONMFJ().originalParent)
		{
			((Component)ConstructionViews.GGFJGHHHEJC).transform.SetParent(ConstructionViews.AHBBHCKPIIJ().originalParent);
			((Component)ConstructionViews.DHDOLCONMFJ()).transform.SetSiblingIndex(1);
		}
		if (HIOAJHJNCPO == BuildingTutorialFocus.PlayerInfo)
		{
			((Component)instance.playerInfo).transform.SetParent(BuildingTutorialManager.BGIBBGBOCFH());
		}
		else if ((Object)(object)((Component)instance.playerInfo).transform.parent != (Object)(object)instance.playerInfo.originalParent)
		{
			((Component)instance.playerInfo).transform.SetParent(instance.playerInfo.originalParent);
			((Component)instance.playerInfo).transform.SetSiblingIndex(5);
		}
		if (HIOAJHJNCPO == BuildingTutorialFocus.Views)
		{
			((Component)ConstructionFloors.DOIKFJDLKJP()).transform.SetParent(BuildingTutorialManager.BGIBBGBOCFH());
		}
		else if ((Object)(object)((Component)ConstructionFloors.JCMKNNOEONP()).transform.parent != (Object)(object)ConstructionFloors.OMFKNGDCJFN().originalParent)
		{
			((Component)ConstructionFloors.OMFKNGDCJFN()).transform.SetParent(ConstructionFloors.JCMKNNOEONP().originalParent);
			((Component)ConstructionFloors.DCAEBALADIM()).transform.SetSiblingIndex(5);
		}
		if (HIOAJHJNCPO == (BuildingTutorialFocus)6)
		{
			((Component)instance.editorActionBar).transform.SetParent(BuildingTutorialManager.GetTransform());
		}
		else if ((Object)(object)((Component)instance.editorActionBar).transform.parent != (Object)(object)instance.IDJKKFMMMCJ)
		{
			((Component)instance.editorActionBar).transform.SetParent(instance.IDJKKFMMMCJ);
			((Component)instance.editorActionBar).transform.SetSiblingIndex(0);
		}
	}

	private void ENNMJBBHJHK()
	{
		TavernConstructionModifications.GGFJGHHHEJC.GPFDOBFKEAF();
		updateNextFrame = true;
		BOBCIFEDJED();
		((MonoBehaviour)this).StartCoroutine(GLBJKBKBNBG());
	}

	public static bool EICFLKPBJIP()
	{
		return instance.IsOpen();
	}

	private void PHFMALOMJHB(TavernFloor BDCFJAHNOML)
	{
		NCJGPFKNMEN(BDCFJAHNOML);
		if (LKOJBFMGMAE)
		{
			ConstructionActionBarUI.FocusMainPanel(ConstructionActionBarUI.currentPanel);
		}
	}

	public void MIJKCIHJBID()
	{
		if ((Object)(object)instance != (Object)null && LKOJBFMGMAE)
		{
			if (BuildingTutorialManager.KGJOKHEBLOJ())
			{
				BuildingPopUp buildingPopUp = BuildingTutorialManager.GMANLOEOFDB();
				ConstructionActionBarUI.UpdatePanel(1, buildingPopUp.panelsAvailable.Contains(ETavernEditorPanel.Decoration));
				ConstructionActionBarUI.BBHBCOCGAPJ(1, buildingPopUp.panelsAvailable.Contains(ETavernEditorPanel.Build));
				ConstructionActionBarUI.BBHBCOCGAPJ(0, buildingPopUp.panelsAvailable.Contains((ETavernEditorPanel)5));
				ConstructionActionBarUI.UpdatePanel(0, buildingPopUp.panelsAvailable.Contains(ETavernEditorPanel.Access));
			}
			else
			{
				ConstructionActionBarUI.BBHBCOCGAPJ(0, BJFHJCFOEHG: false);
				ConstructionActionBarUI.BBHBCOCGAPJ(0, BJFHJCFOEHG: true);
				ConstructionActionBarUI.BBHBCOCGAPJ(0, BJFHJCFOEHG: false);
				ConstructionActionBarUI.UpdatePanel(2, BJFHJCFOEHG: true);
			}
			NAFCMNBJFMN(ConstructionFloors.OMFKNGDCJFN().CPNOFHJLENN());
			ConstructionActionBarUI.EGJDCOECLBD(ConstructionActionBarUI.currentPanel);
			if (BuildingTutorialManager.KGJOKHEBLOJ())
			{
				ConstructionFloors.DOIKFJDLKJP().UpdateFloor(AJONCPPJIBP: false);
			}
		}
	}

	public static List<TavernConstructionAction> CKOFPLEONDG()
	{
		return instance.decorationsActions;
	}

	public static bool BHKOPGENIFB()
	{
		return instance.HDEPMJIDJEM();
	}

	private IEnumerator KDPNDGEGAFJ()
	{
		return new AAHOFCOFJDM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void ANADBDFLKJB()
	{
		updateNextFrame = false;
	}

	public void MGDLFCAMPIG()
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		if ((!DecorationMode.HBDCJFLINDA(base.JIIGOACEIKL).DFNMDDHOIJI() || !((Object)(object)SelectObject.GetPlayer(base.JIIGOACEIKL).placeable != (Object)null)) && !BuildingTutorialManager.KGJOKHEBLOJ() && TavernConstructionModifications.DIHCEGINELM().ANGAJOLGFFN())
		{
			TavernConstructionManager.GGFJGHHHEJC.ChangeInstantiatedGO(null);
			MainUI.LBHLPIFCINB().Open(base.JIIGOACEIKL);
			((TMP_Text)MainUI.LBHLPIFCINB().boxText).text = LocalisationSystem.Get("[Action");
			((UnityEvent)MainUI.MCPEEGPBPLH().yesButton.onClick).AddListener(new UnityAction(JDLBONJEKDL));
			((UnityEvent)MainUI.LBHLPIFCINB().noButton.onClick).AddListener(new UnityAction(MLKBONJDMNF));
		}
	}

	private void MJLHDLCJCFL(TavernFloor BDCFJAHNOML)
	{
		decorationsActions.Clear();
		decorationsActions.AddRange(EditorActionsDBAccessor.OADBFHBNJEN((EditorAction)106));
		decorationsActions.AddRange(EditorActionsDBAccessor.NCBANOFEJPI((EditorAction)101));
		decorationsActions.AddRange(EditorActionsDBAccessor.AANKGIPFPAD(EditorAction.RemoveFloorDisponible));
		for (int num = decorationsActions.Count - 0; num >= 0; num -= 0)
		{
			if (!decorationsActions[num].tavernFloor.HasFlag(BDCFJAHNOML))
			{
				decorationsActions.RemoveAt(num);
			}
		}
	}

	public void UpdateTutorialUI()
	{
		if ((Object)(object)instance != (Object)null && LKOJBFMGMAE)
		{
			if (BuildingTutorialManager.IKNOJDMCFOK)
			{
				BuildingPopUp buildingPopUp = BuildingTutorialManager.CPJBNDOMLGL;
				ConstructionActionBarUI.UpdatePanel(0, buildingPopUp.panelsAvailable.Contains(ETavernEditorPanel.Build));
				ConstructionActionBarUI.UpdatePanel(1, buildingPopUp.panelsAvailable.Contains(ETavernEditorPanel.Decoration));
				ConstructionActionBarUI.UpdatePanel(2, buildingPopUp.panelsAvailable.Contains(ETavernEditorPanel.Zones));
				ConstructionActionBarUI.UpdatePanel(3, buildingPopUp.panelsAvailable.Contains(ETavernEditorPanel.Access));
			}
			else
			{
				ConstructionActionBarUI.UpdatePanel(0, BJFHJCFOEHG: true);
				ConstructionActionBarUI.UpdatePanel(1, BJFHJCFOEHG: true);
				ConstructionActionBarUI.UpdatePanel(2, BJFHJCFOEHG: true);
				ConstructionActionBarUI.UpdatePanel(3, BJFHJCFOEHG: true);
			}
			NCJGPFKNMEN(ConstructionFloors.GGFJGHHHEJC.ODFBDBLCFOM);
			ConstructionActionBarUI.FocusMainPanel(ConstructionActionBarUI.currentPanel);
			if (BuildingTutorialManager.IKNOJDMCFOK)
			{
				ConstructionFloors.GGFJGHHHEJC.UpdateFloor(AJONCPPJIBP: false);
			}
		}
	}

	private void AGPONCCIFHC()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)ConstructionFloors.OMFKNGDCJFN()))
			{
				ConstructionFloors constructionFloors = ConstructionFloors.OMFKNGDCJFN();
				constructionFloors.OnFloorChanged = (Action<TavernFloor>)Delegate.Remove(constructionFloors.OnFloorChanged, new Action<TavernFloor>(PHFMALOMJHB));
			}
			if ((Object)(object)instance == (Object)(object)this)
			{
				instance = null;
			}
		}
	}

	public void COODMBACCAI()
	{
		if ((Object)(object)instance != (Object)null && LKOJBFMGMAE)
		{
			if (BuildingTutorialManager.KGJOKHEBLOJ())
			{
				BuildingPopUp buildingPopUp = BuildingTutorialManager.MAPABOKDNEC();
				ConstructionActionBarUI.UpdatePanel(1, buildingPopUp.panelsAvailable.Contains(ETavernEditorPanel.Build));
				ConstructionActionBarUI.UpdatePanel(1, buildingPopUp.panelsAvailable.Contains(ETavernEditorPanel.Build));
				ConstructionActionBarUI.BBHBCOCGAPJ(7, buildingPopUp.panelsAvailable.Contains(ETavernEditorPanel.Zones));
				ConstructionActionBarUI.BBHBCOCGAPJ(2, buildingPopUp.panelsAvailable.Contains((ETavernEditorPanel)6));
			}
			else
			{
				ConstructionActionBarUI.BBHBCOCGAPJ(0, BJFHJCFOEHG: false);
				ConstructionActionBarUI.BBHBCOCGAPJ(0, BJFHJCFOEHG: false);
				ConstructionActionBarUI.UpdatePanel(0, BJFHJCFOEHG: true);
				ConstructionActionBarUI.UpdatePanel(2, BJFHJCFOEHG: true);
			}
			HCDNLBEDIFP(ConstructionFloors.MNFMOEKMJKN().LKIILEMCPHH());
			ConstructionActionBarUI.BPEACMMHGCP(ConstructionActionBarUI.currentPanel);
			if (BuildingTutorialManager.IKNOJDMCFOK)
			{
				ConstructionFloors.JFNOOMJMHCB().AGBMOOCJFNE(AJONCPPJIBP: false);
			}
		}
	}

	public void ACGKOBBLAIF()
	{
		if ((Object)(object)instance != (Object)null && LKOJBFMGMAE)
		{
			if (BuildingTutorialManager.PABJKGJJHFG())
			{
				BuildingPopUp buildingPopUp = BuildingTutorialManager.GMANLOEOFDB();
				ConstructionActionBarUI.BBHBCOCGAPJ(0, buildingPopUp.panelsAvailable.Contains(ETavernEditorPanel.Build));
				ConstructionActionBarUI.UpdatePanel(0, buildingPopUp.panelsAvailable.Contains(ETavernEditorPanel.Build));
				ConstructionActionBarUI.BBHBCOCGAPJ(0, buildingPopUp.panelsAvailable.Contains(ETavernEditorPanel.Zones));
				ConstructionActionBarUI.UpdatePanel(0, buildingPopUp.panelsAvailable.Contains(ETavernEditorPanel.Zones));
			}
			else
			{
				ConstructionActionBarUI.UpdatePanel(0, BJFHJCFOEHG: false);
				ConstructionActionBarUI.UpdatePanel(1, BJFHJCFOEHG: true);
				ConstructionActionBarUI.UpdatePanel(3, BJFHJCFOEHG: true);
				ConstructionActionBarUI.UpdatePanel(5, BJFHJCFOEHG: true);
			}
			NAFCMNBJFMN(ConstructionFloors.MNFMOEKMJKN().CPOCGMOJCEL());
			ConstructionActionBarUI.FocusMainPanel(ConstructionActionBarUI.currentPanel);
			if (BuildingTutorialManager.KGJOKHEBLOJ())
			{
				ConstructionFloors.JCMKNNOEONP().NIJBDBOAMEL(AJONCPPJIBP: false);
			}
		}
	}

	private void DENIHGLKNDO()
	{
		ConstructionActionBarUI.UpdateSlots();
		ConstructionActionInfoUI.ODALLMEIPIL();
	}

	public static void CloseWindow()
	{
		instance.CloseUI();
	}

	private void GHDBHNMOBMN()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)ConstructionFloors.DOIKFJDLKJP()))
			{
				ConstructionFloors constructionFloors = ConstructionFloors.DCAEBALADIM();
				constructionFloors.OnFloorChanged = (Action<TavernFloor>)Delegate.Remove(constructionFloors.OnFloorChanged, new Action<TavernFloor>(AFLFNPCLKLP));
			}
			if ((Object)(object)instance == (Object)(object)this)
			{
				instance = null;
			}
		}
	}

	public static void JJEHPMLFIBP()
	{
		if (BuildingTutorialManager.IKNOJDMCFOK)
		{
			((Selectable)instance.cancelButton).interactable = false;
			BuildingPopUp buildingPopUp = BuildingTutorialManager.FINEAEFBPLK() as BuildingPopUp;
			if ((Object)(object)buildingPopUp != (Object)null)
			{
				((Selectable)instance.acceptButton).interactable = buildingPopUp.acceptButtonAvailable;
			}
			else
			{
				((Selectable)instance.acceptButton).interactable = false;
			}
		}
		else
		{
			((Selectable)instance.acceptButton).interactable = true;
			((Selectable)instance.cancelButton).interactable = false;
		}
	}

	public static void DLKBHNGIPDI()
	{
		instance.BOBCIFEDJED();
	}

	public static void NCFGEMEBFNA(BuildingTutorialFocus HIOAJHJNCPO)
	{
		if (HIOAJHJNCPO == BuildingTutorialFocus.None)
		{
			((Component)ConstructionViews.AHBBHCKPIIJ()).transform.SetParent(BuildingTutorialManager.GetTransform());
		}
		else if ((Object)(object)((Component)ConstructionViews.HJKBIPPGHJB()).transform.parent != (Object)(object)ConstructionViews.AHBBHCKPIIJ().originalParent)
		{
			((Component)ConstructionViews.CNDNOECMKME()).transform.SetParent(ConstructionViews.HJKBIPPGHJB().originalParent);
			((Component)ConstructionViews.HJKBIPPGHJB()).transform.SetSiblingIndex(1);
		}
		if (HIOAJHJNCPO == BuildingTutorialFocus.TavernFloors)
		{
			((Component)instance.playerInfo).transform.SetParent(BuildingTutorialManager.BGIBBGBOCFH());
		}
		else if ((Object)(object)((Component)instance.playerInfo).transform.parent != (Object)(object)instance.playerInfo.originalParent)
		{
			((Component)instance.playerInfo).transform.SetParent(instance.playerInfo.originalParent);
			((Component)instance.playerInfo).transform.SetSiblingIndex(0);
		}
		if (HIOAJHJNCPO == BuildingTutorialFocus.None)
		{
			((Component)ConstructionFloors.GGFJGHHHEJC).transform.SetParent(BuildingTutorialManager.BGIBBGBOCFH());
		}
		else if ((Object)(object)((Component)ConstructionFloors.GGFJGHHHEJC).transform.parent != (Object)(object)ConstructionFloors.DCAEBALADIM().originalParent)
		{
			((Component)ConstructionFloors.OMFKNGDCJFN()).transform.SetParent(ConstructionFloors.JFNOOMJMHCB().originalParent);
			((Component)ConstructionFloors.GGFJGHHHEJC).transform.SetSiblingIndex(6);
		}
		if (HIOAJHJNCPO == (BuildingTutorialFocus)7)
		{
			((Component)instance.editorActionBar).transform.SetParent(BuildingTutorialManager.GetTransform());
		}
		else if ((Object)(object)((Component)instance.editorActionBar).transform.parent != (Object)(object)instance.IDJKKFMMMCJ)
		{
			((Component)instance.editorActionBar).transform.SetParent(instance.IDJKKFMMMCJ);
			((Component)instance.editorActionBar).transform.SetSiblingIndex(1);
		}
	}

	public static void OpenWindow(int GELMAIBEHDO)
	{
		instance.Open(GELMAIBEHDO);
	}

	public static void BBHJJDPJKFH()
	{
		if (BuildingTutorialManager.PABJKGJJHFG())
		{
			((Selectable)instance.cancelButton).interactable = true;
			BuildingPopUp buildingPopUp = BuildingTutorialManager.FINEAEFBPLK() as BuildingPopUp;
			if ((Object)(object)buildingPopUp != (Object)null)
			{
				((Selectable)instance.acceptButton).interactable = buildingPopUp.acceptButtonAvailable;
			}
			else
			{
				((Selectable)instance.acceptButton).interactable = true;
			}
		}
		else
		{
			((Selectable)instance.acceptButton).interactable = true;
			((Selectable)instance.cancelButton).interactable = true;
		}
	}

	private void IGDMFJBGJKK(EditorAction CHFHMMNELGP)
	{
		ConstructionActionBarUI.UpdateSlots();
		if (ConstructionActionBarUI.currentPanel == 8)
		{
			ConstructionActionInfoUI.MOCOJNMKEKI();
		}
	}

	public static List<TavernConstructionAction> AJNDFOKAJBG()
	{
		return instance.decorationsActions;
	}

	private void MPECHEJAEFN()
	{
		updateNextFrame = true;
	}

	private void MLKOPLHGOMF()
	{
		if (LKOJBFMGMAE)
		{
			ConstructionActionInfoUI.MCDBDGOONJF(ConstructionActionBarUI.OPPJACDGOAF());
		}
	}

	private void HNJCEICDICG()
	{
		TavernConstructionModifications.DIHCEGINELM().ResetLists();
		updateNextFrame = true;
		CloseUI();
		((MonoBehaviour)this).StartCoroutine(OJNFHCLKCLG());
	}

	public static List<TavernConstructionAction> PCFNIELMCLN()
	{
		return instance.decorationsActions;
	}

	public static int APENPNKFADP()
	{
		return instance.JIIGOACEIKL;
	}

	private void HJJEODADCOD()
	{
		updateNextFrame = false;
	}

	public void FCLJCHEENAP()
	{
		if ((Object)(object)instance != (Object)null && LKOJBFMGMAE)
		{
			if (BuildingTutorialManager.IKNOJDMCFOK)
			{
				BuildingPopUp buildingPopUp = BuildingTutorialManager.AEDLFNJPABE();
				ConstructionActionBarUI.BBHBCOCGAPJ(0, buildingPopUp.panelsAvailable.Contains(ETavernEditorPanel.Decoration));
				ConstructionActionBarUI.UpdatePanel(0, buildingPopUp.panelsAvailable.Contains(ETavernEditorPanel.Decoration));
				ConstructionActionBarUI.UpdatePanel(1, buildingPopUp.panelsAvailable.Contains(ETavernEditorPanel.Decoration));
				ConstructionActionBarUI.UpdatePanel(0, buildingPopUp.panelsAvailable.Contains((ETavernEditorPanel)8));
			}
			else
			{
				ConstructionActionBarUI.UpdatePanel(1, BJFHJCFOEHG: true);
				ConstructionActionBarUI.UpdatePanel(0, BJFHJCFOEHG: true);
				ConstructionActionBarUI.UpdatePanel(3, BJFHJCFOEHG: false);
				ConstructionActionBarUI.BBHBCOCGAPJ(0, BJFHJCFOEHG: true);
			}
			MJLHDLCJCFL(ConstructionFloors.MNFMOEKMJKN().CPOCGMOJCEL());
			ConstructionActionBarUI.BPEACMMHGCP(ConstructionActionBarUI.currentPanel);
			if (BuildingTutorialManager.KGJOKHEBLOJ())
			{
				ConstructionFloors.JCMKNNOEONP().IIJGGHLKCNC(AJONCPPJIBP: false);
			}
		}
	}

	private void LKOMPLCEJNB()
	{
		updateNextFrame = true;
	}

	private void MOKMLJHHEDE()
	{
		updateNextFrame = false;
	}

	public static void UpdateAcceptCancelButton()
	{
		if (BuildingTutorialManager.IKNOJDMCFOK)
		{
			((Selectable)instance.cancelButton).interactable = false;
			BuildingPopUp buildingPopUp = BuildingTutorialManager.GetCurrentPopUp() as BuildingPopUp;
			if ((Object)(object)buildingPopUp != (Object)null)
			{
				((Selectable)instance.acceptButton).interactable = buildingPopUp.acceptButtonAvailable;
			}
			else
			{
				((Selectable)instance.acceptButton).interactable = false;
			}
		}
		else
		{
			((Selectable)instance.acceptButton).interactable = true;
			((Selectable)instance.cancelButton).interactable = true;
		}
	}

	private void OLDKLMKPIMN()
	{
		updateNextFrame = true;
		TavernConstructionModifications.GGFJGHHHEJC.HNMCDNBLHBM();
	}

	public static void MLPLPLEOFEJ()
	{
		if (BuildingTutorialManager.PABJKGJJHFG())
		{
			((Selectable)instance.cancelButton).interactable = false;
			BuildingPopUp buildingPopUp = BuildingTutorialManager.GetCurrentPopUp() as BuildingPopUp;
			if ((Object)(object)buildingPopUp != (Object)null)
			{
				((Selectable)instance.acceptButton).interactable = buildingPopUp.acceptButtonAvailable;
			}
			else
			{
				((Selectable)instance.acceptButton).interactable = true;
			}
		}
		else
		{
			((Selectable)instance.acceptButton).interactable = false;
			((Selectable)instance.cancelButton).interactable = true;
		}
	}

	public static void OACIOEBMMIF()
	{
		instance.BOBCIFEDJED();
	}

	private void EOFHJAFGOLG()
	{
		updateNextFrame = true;
	}

	private void MKHFNFNJADC(TavernFloor BDCFJAHNOML)
	{
		MJLHDLCJCFL(BDCFJAHNOML);
		if (LKOJBFMGMAE)
		{
			ConstructionActionBarUI.EEFECHCHPCH(ConstructionActionBarUI.currentPanel);
		}
	}

	private void ANFENPMNGHI(EditorAction CHFHMMNELGP)
	{
		ConstructionActionBarUI.UpdateSlots();
		if (ConstructionActionBarUI.currentPanel == 8)
		{
			ConstructionActionInfoUI.AFCBBFPBOGC();
		}
	}

	private void HLKCGJOPIPA()
	{
		if (LKOJBFMGMAE)
		{
			ConstructionActionInfoUI.JHFKIIKIICO(ConstructionActionBarUI.GDFHCDKEAMF());
		}
	}

	private void EGHOIJHBDBP()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)ConstructionFloors.MNFMOEKMJKN()))
			{
				ConstructionFloors constructionFloors = ConstructionFloors.JCMKNNOEONP();
				constructionFloors.OnFloorChanged = (Action<TavernFloor>)Delegate.Remove(constructionFloors.OnFloorChanged, new Action<TavernFloor>(MKHFNFNJADC));
			}
			if ((Object)(object)instance == (Object)(object)this)
			{
				instance = null;
			}
		}
	}

	private void NHIFGPBNACM()
	{
		updateNextFrame = true;
		TavernConstructionModifications.GGFJGHHHEJC.RevertModifications();
	}

	protected override void Update()
	{
		if (!LKOJBFMGMAE)
		{
			return;
		}
		if (updateNextFrame)
		{
			updateNextFrame = false;
			return;
		}
		if (TavernConstructionModifications.GGFJGHHHEJC.HasAnyModificationDone())
		{
			if (!((Component)cancelButton).gameObject.activeSelf)
			{
				((Component)cancelButton).gameObject.SetActive(true);
			}
			((TMP_Text)acceptButtonText).text = LocalisationSystem.Get("Accept");
			buttonAcceptImg.sprite = buttonAcceptSprites[0];
		}
		else
		{
			if (((Component)cancelButton).gameObject.activeSelf)
			{
				((Component)cancelButton).gameObject.SetActive(false);
			}
			((TMP_Text)acceptButtonText).text = LocalisationSystem.Get("Exit");
			buttonAcceptImg.sprite = buttonAcceptSprites[1];
		}
		if (DevConsole.instance.cheatsEnabled && PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown("ActionBar9") && !TavernConstructionManager.GGFJGHHHEJC.selectingArea)
		{
			BuildingTutorialManager.IKNOJDMCFOK = false;
			CloseUI();
		}
		if (!PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonUp("Pause") && !TavernConstructionManager.GGFJGHHHEJC.selectingArea)
		{
			AcceptChanges();
		}
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && !BuildingTutorialManager.IsOpen() && (!DecorationMode.GetPlayer(base.JIIGOACEIKL).DMBFKFLDDLH || (Object)(object)SelectObject.GetPlayer(base.JIIGOACEIKL).placeable == (Object)null))
		{
			if (MainUI.GetYesNoDialogue().IsOpen() && PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown("UIBack"))
			{
				MainUI.GetYesNoDialogue().CloseUI();
				updateNextFrame = true;
			}
			else if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown("Use"))
			{
				AcceptChanges();
			}
			else if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown("Cancel") && !TavernConstructionManager.GGFJGHHHEJC.cancelChangesPressed)
			{
				RevertModifications();
			}
		}
	}

	public static List<TavernConstructionAction> IOIHCFPGEFC()
	{
		return instance.decorationsActions;
	}

	public static int PCBJLEPFICI()
	{
		return instance.JIIGOACEIKL;
	}

	public static void HFBDGMPHFKG(BuildingTutorialFocus HIOAJHJNCPO)
	{
		if (HIOAJHJNCPO == BuildingTutorialFocus.Views)
		{
			((Component)ConstructionViews.DHDOLCONMFJ()).transform.SetParent(BuildingTutorialManager.BGIBBGBOCFH());
		}
		else if ((Object)(object)((Component)ConstructionViews.AHBBHCKPIIJ()).transform.parent != (Object)(object)ConstructionViews.CNDNOECMKME().originalParent)
		{
			((Component)ConstructionViews.AHBBHCKPIIJ()).transform.SetParent(ConstructionViews.GGFJGHHHEJC.originalParent);
			((Component)ConstructionViews.FOPGLLMEEDE()).transform.SetSiblingIndex(0);
		}
		if (HIOAJHJNCPO == (BuildingTutorialFocus)5)
		{
			((Component)instance.playerInfo).transform.SetParent(BuildingTutorialManager.BGIBBGBOCFH());
		}
		else if ((Object)(object)((Component)instance.playerInfo).transform.parent != (Object)(object)instance.playerInfo.originalParent)
		{
			((Component)instance.playerInfo).transform.SetParent(instance.playerInfo.originalParent);
			((Component)instance.playerInfo).transform.SetSiblingIndex(3);
		}
		if (HIOAJHJNCPO == BuildingTutorialFocus.None)
		{
			((Component)ConstructionFloors.JCMKNNOEONP()).transform.SetParent(BuildingTutorialManager.GetTransform());
		}
		else if ((Object)(object)((Component)ConstructionFloors.DFJGHOHPPEL()).transform.parent != (Object)(object)ConstructionFloors.DCAEBALADIM().originalParent)
		{
			((Component)ConstructionFloors.DCAEBALADIM()).transform.SetParent(ConstructionFloors.MNFMOEKMJKN().originalParent);
			((Component)ConstructionFloors.JCMKNNOEONP()).transform.SetSiblingIndex(6);
		}
		if (HIOAJHJNCPO == BuildingTutorialFocus.Views)
		{
			((Component)instance.editorActionBar).transform.SetParent(BuildingTutorialManager.GetTransform());
		}
		else if ((Object)(object)((Component)instance.editorActionBar).transform.parent != (Object)(object)instance.IDJKKFMMMCJ)
		{
			((Component)instance.editorActionBar).transform.SetParent(instance.IDJKKFMMMCJ);
			((Component)instance.editorActionBar).transform.SetSiblingIndex(0);
		}
	}

	private void IKMPNICLPBM()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)ConstructionFloors.JCMKNNOEONP()))
			{
				ConstructionFloors constructionFloors = ConstructionFloors.MNFMOEKMJKN();
				constructionFloors.OnFloorChanged = (Action<TavernFloor>)Delegate.Remove(constructionFloors.OnFloorChanged, new Action<TavernFloor>(PHFMALOMJHB));
			}
			if ((Object)(object)instance == (Object)(object)this)
			{
				instance = null;
			}
		}
	}

	public static void JDPLELLEFJC()
	{
		instance.BOBCIFEDJED();
	}

	public static void OFDPKPEDIOB()
	{
		instance.BOBCIFEDJED();
	}

	private void JKLAKIFMFHH()
	{
		if (LKOJBFMGMAE)
		{
			ConstructionActionInfoUI.BANJNMFEODG(ConstructionActionBarUI.OPPJACDGOAF());
		}
	}

	private void JPEFCFNLMAC(TavernFloor BDCFJAHNOML)
	{
		KNMDPKFJGFM(BDCFJAHNOML);
		if (LKOJBFMGMAE)
		{
			ConstructionActionBarUI.BPEACMMHGCP(ConstructionActionBarUI.currentPanel);
		}
	}

	public static TavernConstructionUI GetInstance()
	{
		return instance;
	}

	public override void AcceptChanges()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		if ((DecorationMode.GetPlayer(base.JIIGOACEIKL).DMBFKFLDDLH && (Object)(object)SelectObject.GetPlayer(base.JIIGOACEIKL).placeable != (Object)null) || (BuildingTutorialManager.IKNOJDMCFOK && !BuildingTutorialManager.CPJBNDOMLGL.acceptButtonAvailable))
		{
			return;
		}
		if (TavernConstructionModifications.GGFJGHHHEJC.HasAnyModificationDone())
		{
			TavernConstructionManager.GGFJGHHHEJC.ChangeInstantiatedGO(null);
			MainUI.GetYesNoDialogue().Open(base.JIIGOACEIKL);
			((TMP_Text)MainUI.GetYesNoDialogue().boxText).text = LocalisationSystem.Get("BuildMode_ExitAndSave");
			MainUI.GetYesNoDialogue().AddYesAction((UnityAction)delegate
			{
				TavernConstructionModifications.GGFJGHHHEJC.ResetLists();
				updateNextFrame = true;
				CloseUI();
				((MonoBehaviour)this).StartCoroutine(GLBJKBKBNBG());
			});
			MainUI.GetYesNoDialogue().AddNoAction((UnityAction)delegate
			{
				updateNextFrame = true;
			});
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(GLBJKBKBNBG());
			CloseUI();
		}
	}

	private void GBJGJOOMCLA()
	{
		if (LKOJBFMGMAE)
		{
			ConstructionActionInfoUI.ABHABINJPCE(ConstructionActionBarUI.GetEditorActionInfo());
		}
	}

	protected override void Start()
	{
		base.Start();
		content.SetActive(false);
		IDJKKFMMMCJ = ((Component)editorActionBar).transform.parent;
		TavernConstructionManager tavernConstructionManager = TavernConstructionManager.GGFJGHHHEJC;
		tavernConstructionManager.OnCancelChanges = (Action<EditorAction>)Delegate.Combine(tavernConstructionManager.OnCancelChanges, new Action<EditorAction>(OABINNENNIP));
		TavernConstructionModifications tavernConstructionModifications = TavernConstructionModifications.GGFJGHHHEJC;
		tavernConstructionModifications.OnRevertModifications = (Action)Delegate.Combine(tavernConstructionModifications.OnRevertModifications, new Action(JPCJEDKLKPO));
		TavernZonesManager tavernZonesManager = TavernZonesManager.GGFJGHHHEJC;
		tavernZonesManager.OnZoneCreated = (Action)Delegate.Combine(tavernZonesManager.OnZoneCreated, new Action(PAAOEEFAOIF));
	}

	private void OLDADKOJGEM(EditorAction CHFHMMNELGP)
	{
		ConstructionActionBarUI.AHBFELDFHCH();
		if (ConstructionActionBarUI.currentPanel == 0)
		{
			ConstructionActionInfoUI.DLIJCLOJIIE();
		}
	}

	public static void PNKFDBCAIOB(BuildingTutorialFocus HIOAJHJNCPO)
	{
		if (HIOAJHJNCPO == BuildingTutorialFocus.None)
		{
			((Component)ConstructionViews.HJKBIPPGHJB()).transform.SetParent(BuildingTutorialManager.BGIBBGBOCFH());
		}
		else if ((Object)(object)((Component)ConstructionViews.DEGPIHEEFHJ()).transform.parent != (Object)(object)ConstructionViews.CNDNOECMKME().originalParent)
		{
			((Component)ConstructionViews.CNDNOECMKME()).transform.SetParent(ConstructionViews.HJKBIPPGHJB().originalParent);
			((Component)ConstructionViews.AHBBHCKPIIJ()).transform.SetSiblingIndex(0);
		}
		if (HIOAJHJNCPO == (BuildingTutorialFocus)6)
		{
			((Component)instance.playerInfo).transform.SetParent(BuildingTutorialManager.GetTransform());
		}
		else if ((Object)(object)((Component)instance.playerInfo).transform.parent != (Object)(object)instance.playerInfo.originalParent)
		{
			((Component)instance.playerInfo).transform.SetParent(instance.playerInfo.originalParent);
			((Component)instance.playerInfo).transform.SetSiblingIndex(6);
		}
		if (HIOAJHJNCPO == BuildingTutorialFocus.TavernFloors)
		{
			((Component)ConstructionFloors.GGFJGHHHEJC).transform.SetParent(BuildingTutorialManager.BGIBBGBOCFH());
		}
		else if ((Object)(object)((Component)ConstructionFloors.DFJGHOHPPEL()).transform.parent != (Object)(object)ConstructionFloors.MNFMOEKMJKN().originalParent)
		{
			((Component)ConstructionFloors.JCMKNNOEONP()).transform.SetParent(ConstructionFloors.DOIKFJDLKJP().originalParent);
			((Component)ConstructionFloors.DCAEBALADIM()).transform.SetSiblingIndex(5);
		}
		if (HIOAJHJNCPO == (BuildingTutorialFocus)5)
		{
			((Component)instance.editorActionBar).transform.SetParent(BuildingTutorialManager.BGIBBGBOCFH());
		}
		else if ((Object)(object)((Component)instance.editorActionBar).transform.parent != (Object)(object)instance.IDJKKFMMMCJ)
		{
			((Component)instance.editorActionBar).transform.SetParent(instance.IDJKKFMMMCJ);
			((Component)instance.editorActionBar).transform.SetSiblingIndex(0);
		}
	}

	private void AFPOOOCMEDE(EditorAction CHFHMMNELGP)
	{
		ConstructionActionBarUI.AHBFELDFHCH();
		if (ConstructionActionBarUI.currentPanel == 1)
		{
			ConstructionActionInfoUI.POHLAEJCAFG();
		}
	}

	public static TavernConstructionUI KIKCLAICGBH()
	{
		return instance;
	}

	private void HNNBAAJAHEN()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)ConstructionFloors.MNFMOEKMJKN()))
			{
				ConstructionFloors constructionFloors = ConstructionFloors.JCMKNNOEONP();
				constructionFloors.OnFloorChanged = (Action<TavernFloor>)Delegate.Remove(constructionFloors.OnFloorChanged, new Action<TavernFloor>(MIGOKFIMHFD));
			}
			if ((Object)(object)instance == (Object)(object)this)
			{
				instance = null;
			}
		}
	}

	private void JDLBONJEKDL()
	{
		updateNextFrame = true;
		TavernConstructionModifications.DIHCEGINELM().HNMCDNBLHBM();
	}

	private IEnumerator EOJJMOJDEDP()
	{
		return new AAHOFCOFJDM(1)
		{
			_003C_003E4__this = this
		};
	}

	[CompilerGenerated]
	private void CIHBDAKIIJA()
	{
		updateNextFrame = true;
	}

	private void GBFPOGBCMME()
	{
		updateNextFrame = false;
	}

	private void EDEHENPIGDN()
	{
		updateNextFrame = false;
		TavernConstructionModifications.GGFJGHHHEJC.RevertModifications();
	}

	public void OEOACOKAFDL()
	{
		if ((Object)(object)instance != (Object)null && LKOJBFMGMAE)
		{
			if (BuildingTutorialManager.PABJKGJJHFG())
			{
				BuildingPopUp buildingPopUp = BuildingTutorialManager.MAPABOKDNEC();
				ConstructionActionBarUI.BBHBCOCGAPJ(0, buildingPopUp.panelsAvailable.Contains(ETavernEditorPanel.Decoration));
				ConstructionActionBarUI.UpdatePanel(0, buildingPopUp.panelsAvailable.Contains(ETavernEditorPanel.Decoration));
				ConstructionActionBarUI.UpdatePanel(1, buildingPopUp.panelsAvailable.Contains((ETavernEditorPanel)5));
				ConstructionActionBarUI.BBHBCOCGAPJ(1, buildingPopUp.panelsAvailable.Contains((ETavernEditorPanel)5));
			}
			else
			{
				ConstructionActionBarUI.BBHBCOCGAPJ(0, BJFHJCFOEHG: false);
				ConstructionActionBarUI.UpdatePanel(1, BJFHJCFOEHG: false);
				ConstructionActionBarUI.UpdatePanel(5, BJFHJCFOEHG: false);
				ConstructionActionBarUI.BBHBCOCGAPJ(7, BJFHJCFOEHG: false);
			}
			NCJGPFKNMEN(ConstructionFloors.JCMKNNOEONP().LKIILEMCPHH());
			ConstructionActionBarUI.EGJDCOECLBD(ConstructionActionBarUI.currentPanel);
			if (BuildingTutorialManager.KGJOKHEBLOJ())
			{
				ConstructionFloors.MNFMOEKMJKN().AGBMOOCJFNE(AJONCPPJIBP: false);
			}
		}
	}

	public void DBPFLNCPBFK()
	{
		if ((Object)(object)instance != (Object)null && LKOJBFMGMAE)
		{
			if (BuildingTutorialManager.KGJOKHEBLOJ())
			{
				BuildingPopUp buildingPopUp = BuildingTutorialManager.AEDLFNJPABE();
				ConstructionActionBarUI.UpdatePanel(1, buildingPopUp.panelsAvailable.Contains(ETavernEditorPanel.Decoration));
				ConstructionActionBarUI.BBHBCOCGAPJ(0, buildingPopUp.panelsAvailable.Contains(ETavernEditorPanel.Decoration));
				ConstructionActionBarUI.BBHBCOCGAPJ(6, buildingPopUp.panelsAvailable.Contains(ETavernEditorPanel.Access));
				ConstructionActionBarUI.BBHBCOCGAPJ(7, buildingPopUp.panelsAvailable.Contains((ETavernEditorPanel)6));
			}
			else
			{
				ConstructionActionBarUI.UpdatePanel(0, BJFHJCFOEHG: true);
				ConstructionActionBarUI.BBHBCOCGAPJ(0, BJFHJCFOEHG: false);
				ConstructionActionBarUI.UpdatePanel(5, BJFHJCFOEHG: true);
				ConstructionActionBarUI.BBHBCOCGAPJ(8, BJFHJCFOEHG: true);
			}
			KNMDPKFJGFM(ConstructionFloors.JCMKNNOEONP().CPOCGMOJCEL());
			ConstructionActionBarUI.EGJDCOECLBD(ConstructionActionBarUI.currentPanel);
			if (BuildingTutorialManager.IKNOJDMCFOK)
			{
				ConstructionFloors.GGFJGHHHEJC.IIJGGHLKCNC(AJONCPPJIBP: false);
			}
		}
	}

	private void HGDIIKHJBIB()
	{
		if (LKOJBFMGMAE)
		{
			ConstructionActionInfoUI.DEEPFOAPBPO(ConstructionActionBarUI.KFCAPNDFIGI());
		}
	}

	public static bool OJBKLPONLAH()
	{
		return instance.HDEPMJIDJEM();
	}

	public static void GMIKMFDNAJA()
	{
		instance.BOBCIFEDJED();
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)ConstructionFloors.GGFJGHHHEJC))
			{
				ConstructionFloors constructionFloors = ConstructionFloors.GGFJGHHHEJC;
				constructionFloors.OnFloorChanged = (Action<TavernFloor>)Delegate.Remove(constructionFloors.OnFloorChanged, new Action<TavernFloor>(PHFMALOMJHB));
			}
			if ((Object)(object)instance == (Object)(object)this)
			{
				instance = null;
			}
		}
	}

	public static void PDCJNHDNAPA(BuildingTutorialFocus HIOAJHJNCPO)
	{
		if (HIOAJHJNCPO == BuildingTutorialFocus.None)
		{
			((Component)ConstructionViews.HJKBIPPGHJB()).transform.SetParent(BuildingTutorialManager.GetTransform());
		}
		else if ((Object)(object)((Component)ConstructionViews.DHDOLCONMFJ()).transform.parent != (Object)(object)ConstructionViews.CNDNOECMKME().originalParent)
		{
			((Component)ConstructionViews.FOPGLLMEEDE()).transform.SetParent(ConstructionViews.DHDOLCONMFJ().originalParent);
			((Component)ConstructionViews.DHDOLCONMFJ()).transform.SetSiblingIndex(1);
		}
		if (HIOAJHJNCPO == (BuildingTutorialFocus)8)
		{
			((Component)instance.playerInfo).transform.SetParent(BuildingTutorialManager.BGIBBGBOCFH());
		}
		else if ((Object)(object)((Component)instance.playerInfo).transform.parent != (Object)(object)instance.playerInfo.originalParent)
		{
			((Component)instance.playerInfo).transform.SetParent(instance.playerInfo.originalParent);
			((Component)instance.playerInfo).transform.SetSiblingIndex(8);
		}
		if (HIOAJHJNCPO == BuildingTutorialFocus.None)
		{
			((Component)ConstructionFloors.DFJGHOHPPEL()).transform.SetParent(BuildingTutorialManager.BGIBBGBOCFH());
		}
		else if ((Object)(object)((Component)ConstructionFloors.DOIKFJDLKJP()).transform.parent != (Object)(object)ConstructionFloors.GGFJGHHHEJC.originalParent)
		{
			((Component)ConstructionFloors.MNFMOEKMJKN()).transform.SetParent(ConstructionFloors.DCAEBALADIM().originalParent);
			((Component)ConstructionFloors.DOIKFJDLKJP()).transform.SetSiblingIndex(7);
		}
		if (HIOAJHJNCPO == (BuildingTutorialFocus)5)
		{
			((Component)instance.editorActionBar).transform.SetParent(BuildingTutorialManager.BGIBBGBOCFH());
		}
		else if ((Object)(object)((Component)instance.editorActionBar).transform.parent != (Object)(object)instance.IDJKKFMMMCJ)
		{
			((Component)instance.editorActionBar).transform.SetParent(instance.IDJKKFMMMCJ);
			((Component)instance.editorActionBar).transform.SetSiblingIndex(1);
		}
	}

	public static void BMHKHFMHAGF(int GELMAIBEHDO)
	{
		instance.OFGKFMJKBON(GELMAIBEHDO);
	}

	public static bool PGKBDDJMEEK()
	{
		return instance.HDEPMJIDJEM();
	}

	public static TavernConstructionUI LLJEGHHGOGC()
	{
		return instance;
	}

	private void EKDIEDHFBEF()
	{
		updateNextFrame = false;
	}

	public static bool OBBOCMPOJFH()
	{
		return instance.HDEPMJIDJEM();
	}

	public static int MOCMMGCAOPH()
	{
		return instance.JIIGOACEIKL;
	}

	private IEnumerator GBFDAILHEFE()
	{
		if (RentedRoomsManager.GetAllRooms().Count > 0)
		{
			yield return CommonReferences.wait4;
			while (TutorialManager.GGFJGHHHEJC.ECMGCJGPKNO || BuildingTutorialManager.IsOpen())
			{
				yield return null;
			}
			yield return CommonReferences.wait05;
			CommonReferences.GGFJGHHHEJC.OnActionDone(base.JIIGOACEIKL, ActionDone.CreateRoom);
		}
	}

	public void NNKDINEIOGL()
	{
		if ((Object)(object)instance != (Object)null && LKOJBFMGMAE)
		{
			if (BuildingTutorialManager.PABJKGJJHFG())
			{
				BuildingPopUp buildingPopUp = BuildingTutorialManager.AEDLFNJPABE();
				ConstructionActionBarUI.UpdatePanel(0, buildingPopUp.panelsAvailable.Contains(ETavernEditorPanel.Decoration));
				ConstructionActionBarUI.UpdatePanel(1, buildingPopUp.panelsAvailable.Contains(ETavernEditorPanel.Build));
				ConstructionActionBarUI.BBHBCOCGAPJ(8, buildingPopUp.panelsAvailable.Contains((ETavernEditorPanel)4));
				ConstructionActionBarUI.BBHBCOCGAPJ(2, buildingPopUp.panelsAvailable.Contains((ETavernEditorPanel)4));
			}
			else
			{
				ConstructionActionBarUI.BBHBCOCGAPJ(1, BJFHJCFOEHG: true);
				ConstructionActionBarUI.BBHBCOCGAPJ(1, BJFHJCFOEHG: true);
				ConstructionActionBarUI.BBHBCOCGAPJ(6, BJFHJCFOEHG: true);
				ConstructionActionBarUI.UpdatePanel(2, BJFHJCFOEHG: false);
			}
			HCDNLBEDIFP(ConstructionFloors.DFJGHOHPPEL().EJKJLPAFFOI());
			ConstructionActionBarUI.PEBIGNKNPKC(ConstructionActionBarUI.currentPanel);
			if (BuildingTutorialManager.KGJOKHEBLOJ())
			{
				ConstructionFloors.DOIKFJDLKJP().UpdateFloor(AJONCPPJIBP: true);
			}
		}
	}

	[CompilerGenerated]
	private void ABFPNEOJPCO()
	{
		TavernConstructionModifications.GGFJGHHHEJC.ResetLists();
		updateNextFrame = true;
		CloseUI();
		((MonoBehaviour)this).StartCoroutine(GLBJKBKBNBG());
	}

	private void KNMDPKFJGFM(TavernFloor BDCFJAHNOML)
	{
		decorationsActions.Clear();
		decorationsActions.AddRange(EditorActionsDBAccessor.AANKGIPFPAD((EditorAction)32));
		decorationsActions.AddRange(EditorActionsDBAccessor.NCBANOFEJPI((EditorAction)100));
		decorationsActions.AddRange(EditorActionsDBAccessor.CFKAHKLFLPB((EditorAction)(-102)));
		for (int num = decorationsActions.Count - 0; num >= 0; num--)
		{
			if (!decorationsActions[num].tavernFloor.HasFlag(BDCFJAHNOML))
			{
				decorationsActions.RemoveAt(num);
			}
		}
	}

	public static int JCAIGIPKLHI()
	{
		return instance.JIIGOACEIKL;
	}

	public static void OHCNNCOIAIO()
	{
		instance.BOBCIFEDJED();
	}

	private void CCJFPKNLBFB()
	{
		ConstructionActionBarUI.LDEELPOCNEM();
		ConstructionActionInfoUI.LEFLEPJENNG();
	}

	private IEnumerator ICNPFDCOPCO()
	{
		return new AAHOFCOFJDM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LPAEILBIJPB()
	{
		if (RentedRoomsManager.GetAllRooms().Count > 0)
		{
			yield return CommonReferences.wait4;
			while (TutorialManager.GGFJGHHHEJC.ECMGCJGPKNO || BuildingTutorialManager.IsOpen())
			{
				yield return null;
			}
			yield return CommonReferences.wait05;
			CommonReferences.GGFJGHHHEJC.OnActionDone(base.JIIGOACEIKL, ActionDone.CreateRoom);
		}
	}

	private void PAAOEEFAOIF()
	{
		if (LKOJBFMGMAE)
		{
			ConstructionActionInfoUI.UpdateCurrentSlotInfo(ConstructionActionBarUI.GetEditorActionInfo());
		}
	}

	private void PBHICMLCNGL(TavernFloor BDCFJAHNOML)
	{
		decorationsActions.Clear();
		decorationsActions.AddRange(EditorActionsDBAccessor.CFKAHKLFLPB((EditorAction)121));
		decorationsActions.AddRange(EditorActionsDBAccessor.CFKAHKLFLPB((EditorAction)107));
		decorationsActions.AddRange(EditorActionsDBAccessor.NCBANOFEJPI(EditorAction.ChangeRoof));
		for (int num = decorationsActions.Count - 0; num >= 0; num--)
		{
			if (!decorationsActions[num].tavernFloor.HasFlag(BDCFJAHNOML))
			{
				decorationsActions.RemoveAt(num);
			}
		}
	}

	protected override void Awake()
	{
		instance = this;
		base.Awake();
	}

	private IEnumerator OOEFOKMLINH()
	{
		if (RentedRoomsManager.GetAllRooms().Count > 0)
		{
			yield return CommonReferences.wait4;
			while (TutorialManager.GGFJGHHHEJC.ECMGCJGPKNO || BuildingTutorialManager.IsOpen())
			{
				yield return null;
			}
			yield return CommonReferences.wait05;
			CommonReferences.GGFJGHHHEJC.OnActionDone(base.JIIGOACEIKL, ActionDone.CreateRoom);
		}
	}

	public void KHIGHLDPDMN()
	{
		if ((Object)(object)instance != (Object)null && LKOJBFMGMAE)
		{
			if (BuildingTutorialManager.KGJOKHEBLOJ())
			{
				BuildingPopUp buildingPopUp = BuildingTutorialManager.AEDLFNJPABE();
				ConstructionActionBarUI.BBHBCOCGAPJ(1, buildingPopUp.panelsAvailable.Contains(ETavernEditorPanel.Build));
				ConstructionActionBarUI.UpdatePanel(1, buildingPopUp.panelsAvailable.Contains(ETavernEditorPanel.Decoration));
				ConstructionActionBarUI.BBHBCOCGAPJ(4, buildingPopUp.panelsAvailable.Contains((ETavernEditorPanel)7));
				ConstructionActionBarUI.BBHBCOCGAPJ(3, buildingPopUp.panelsAvailable.Contains(ETavernEditorPanel.Decoration));
			}
			else
			{
				ConstructionActionBarUI.BBHBCOCGAPJ(1, BJFHJCFOEHG: false);
				ConstructionActionBarUI.BBHBCOCGAPJ(0, BJFHJCFOEHG: false);
				ConstructionActionBarUI.UpdatePanel(5, BJFHJCFOEHG: true);
				ConstructionActionBarUI.UpdatePanel(6, BJFHJCFOEHG: false);
			}
			HCDNLBEDIFP(ConstructionFloors.JFNOOMJMHCB().EJKJLPAFFOI());
			ConstructionActionBarUI.PEBIGNKNPKC(ConstructionActionBarUI.currentPanel);
			if (BuildingTutorialManager.PABJKGJJHFG())
			{
				ConstructionFloors.JFNOOMJMHCB().UpdateFloor(AJONCPPJIBP: false);
			}
		}
	}

	private void AEDIIIAECIC()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)ConstructionFloors.GGFJGHHHEJC))
			{
				ConstructionFloors constructionFloors = ConstructionFloors.DOIKFJDLKJP();
				constructionFloors.OnFloorChanged = (Action<TavernFloor>)Delegate.Remove(constructionFloors.OnFloorChanged, new Action<TavernFloor>(PHFMALOMJHB));
			}
			if ((Object)(object)instance == (Object)(object)this)
			{
				instance = null;
			}
		}
	}

	public static int ABDMPLACJHI()
	{
		return instance.JIIGOACEIKL;
	}

	public static void NODJEDECCMC()
	{
		instance.BOBCIFEDJED();
	}

	private void OABINNENNIP(EditorAction CHFHMMNELGP)
	{
		ConstructionActionBarUI.UpdateSlots();
		if (ConstructionActionBarUI.currentPanel == 2)
		{
			ConstructionActionInfoUI.UpdateCurrentEditorAction();
		}
	}

	public static void NBANOINMAJO()
	{
		instance.BOBCIFEDJED();
	}

	private void DLJKJGIMAPB()
	{
		if (LKOJBFMGMAE)
		{
			ConstructionActionInfoUI.IJAOECOMHHP(ConstructionActionBarUI.OPPJACDGOAF());
		}
	}
}
