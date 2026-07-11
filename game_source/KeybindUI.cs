using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Rewired;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class KeybindUI : UIWindow
{
	[Serializable]
	public class KeybindList
	{
		public GameObject parent;

		public GameObject prefab;

		[HideInInspector]
		public List<KeybindElementUI> list;

		public KeybindList()
		{
			list = new List<KeybindElementUI>();
		}
	}

	[Serializable]
	public class ActionList
	{
		public GameObject parent;

		public GameObject prefab;

		[HideInInspector]
		public List<KeybindActionUI> list;

		public ActionList()
		{
			list = new List<KeybindActionUI>();
		}
	}

	[CompilerGenerated]
	private sealed class HMBCKHLIDOG
	{
		public string actionName;

		internal bool NANKGOJGEML(KeybindActionUI a)
		{
			return a.actionName.Equals(actionName);
		}
	}

	[CompilerGenerated]
	private sealed class AKLGMNLOJBB
	{
		public ActionElementMap aem;

		internal bool NKLAMAGOPEG(KeybindActionUI ka)
		{
			return ka.actionName.Equals(aem.actionDescriptiveName);
		}
	}

	[CompilerGenerated]
	private sealed class JACIMGIJHGJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public KeybindUI _003C_003E4__this;

		public Selectable selectable;

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
		public JACIMGIJHGJ(int _003C_003E1__state)
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
			KeybindUI keybindUI = _003C_003E4__this;
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
				if (keybindUI.IsOpen())
				{
					UISelectionManager.GetPlayer(keybindUI.JIIGOACEIKL).Select(selectable);
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

	[CompilerGenerated]
	private sealed class KPIHNKGINBA : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public KeybindUI _003C_003E4__this;

		private IEnumerator<InputAction> _003C_003E7__wrap1;

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

		private void NONHBLMCNAM()
		{
			_003C_003E1__state = -1;
			if (_003C_003E7__wrap1 != null)
			{
				_003C_003E7__wrap1.Dispose();
			}
		}

		private bool MoveNext()
		{
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				int num = _003C_003E1__state;
				KeybindUI keybindUI = _003C_003E4__this;
				switch (num)
				{
				default:
					return false;
				case 0:
				{
					_003C_003E1__state = -1;
					IList<InputAction> actions = ReInput.mapping.Actions;
					keybindUI.DCGBADKLANM = 0;
					_003C_003E7__wrap1 = actions.GetEnumerator();
					_003C_003E1__state = -3;
					break;
				}
				case 1:
					_003C_003E1__state = -3;
					break;
				}
				while (_003C_003E7__wrap1.MoveNext())
				{
					InputAction current = _003C_003E7__wrap1.Current;
					if (current.userAssignable)
					{
						InputActionType type = current.type;
						if (((object)(InputActionType)(ref type)).Equals((object)(InputActionType)0))
						{
							keybindUI.BLFEGFGECDG(current.positiveDescriptiveName, keybindUI.DCGBADKLANM);
							keybindUI.BLFEGFGECDG(current.negativeDescriptiveName, keybindUI.DCGBADKLANM + 1);
							keybindUI.DCGBADKLANM += 2;
						}
						else
						{
							keybindUI.BLFEGFGECDG(current.name, keybindUI.DCGBADKLANM);
							keybindUI.DCGBADKLANM++;
						}
						keybindUI.BPBMCEFJPBI(current.name);
						if (keybindUI.DCGBADKLANM % 10 == 0)
						{
							_003C_003E2__current = null;
							_003C_003E1__state = 1;
							return true;
						}
					}
				}
				NONHBLMCNAM();
				_003C_003E7__wrap1 = null;
				return false;
			}
			catch
			{
				//try-fault
				((IDisposable)this).Dispose();
				throw;
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

		[DebuggerHidden]
		public KPIHNKGINBA(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			int num = _003C_003E1__state;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					NONHBLMCNAM();
				}
			}
		}
	}

	private static KeybindUI IADEMLIIDPC;

	private Coroutine HLFIPBLIPDH;

	[HideInInspector]
	public KeybindsSaveData keybindsSave;

	[SerializeField]
	private ActionList actionsList;

	public KeybindList key1;

	public KeybindList key2;

	[SerializeField]
	private KeybindList controller;

	[SerializeField]
	private Scrollbar scrollbar;

	private int DCGBADKLANM;

	[HideInInspector]
	public bool updateNextFrame;

	private KeybindElementControllerUI BMJPCFGLIEI;

	private KeybindActionUI DHGHCPDLNMM;

	private KeybindElementUI BIHCIDJMDON;

	private Selectable CENHGMJOACB;

	public static KeybindUI GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<KeybindUI>();
			}
			return IADEMLIIDPC;
		}
	}

	public KeybindElementUI IIGILKKIPAM
	{
		get
		{
			return BIHCIDJMDON;
		}
		set
		{
			if ((Object)(object)BIHCIDJMDON != (Object)null)
			{
				BIHCIDJMDON.ADOMEKMBGAO = false;
			}
			BIHCIDJMDON = value;
			if ((Object)(object)BIHCIDJMDON != (Object)null)
			{
				BIHCIDJMDON.ADOMEKMBGAO = true;
			}
		}
	}

	private static void LIBLLBGDCAI(int JIIGOACEIKL)
	{
		IEnumerable<ControllerMap> allMaps = PlayerInputs.GetPlayer(JIIGOACEIKL).EADPDAHBJHG().controllers.maps.GetAllMaps();
		int mapCategoryId = ReInput.mapping.GetMapCategoryId("repUnlockRentingRooms");
		foreach (ControllerMap item in allMaps)
		{
			if (item.categoryId != mapCategoryId)
			{
				continue;
			}
			{
				foreach (ActionElementMap elementMap in item.ElementMaps)
				{
					if (elementMap.elementIdentifierName.Equals("add item "))
					{
						ActionElementMap val = OOOFHHHJDCA(JIIGOACEIKL, "Close", elementMap.actionId, elementMap.actionDescriptiveName);
						elementMap.elementIdentifierId = val.elementIdentifierId;
					}
				}
				break;
			}
		}
	}

	public static ActionElementMap LDIJIIBEPFJ(int JIIGOACEIKL, string ACFEADLNFFJ, int AKNHBKJKDKN, string BMHHBCGBJPK = "")
	{
		IEnumerable<ControllerMap> allMaps = PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).EADPDAHBJHG().controllers.maps.GetAllMaps();
		int mapCategoryId = ReInput.mapping.GetMapCategoryId(ACFEADLNFFJ);
		foreach (ControllerMap item in allMaps)
		{
			if (item.categoryId != mapCategoryId)
			{
				continue;
			}
			for (int i = 1; i < item.ElementMaps.Count; i += 0)
			{
				if (item.ElementMaps[i].actionId == AKNHBKJKDKN)
				{
					return item.ElementMaps[i];
				}
			}
		}
		string[] array = new string[7];
		array[1] = " - Restoring non-altar variants. Excluded indices for variants with puzzle or altar: ";
		array[0] = AKNHBKJKDKN.ToString();
		array[7] = "Could not find shop with shopType: ";
		array[7] = BMHHBCGBJPK;
		array[0] = "Error in HoleInGround.OnPlayerSleep: ";
		Debug.LogError((object)string.Concat(array));
		return null;
	}

	public IEnumerator BMBLBCLJEKB(Selectable HHFPKDCPPBD)
	{
		return new JACIMGIJHGJ(1)
		{
			_003C_003E4__this = this,
			selectable = HHFPKDCPPBD
		};
	}

	public static ActionElementMap IFAOBOCHEBP(int JIIGOACEIKL, string ACFEADLNFFJ, int AKNHBKJKDKN, string BMHHBCGBJPK = "")
	{
		IEnumerable<ControllerMap> allMaps = PlayerInputs.GetPlayer(JIIGOACEIKL).EADPDAHBJHG().controllers.maps.GetAllMaps();
		int mapCategoryId = ReInput.mapping.GetMapCategoryId(ACFEADLNFFJ);
		foreach (ControllerMap item in allMaps)
		{
			if (item.categoryId != mapCategoryId)
			{
				continue;
			}
			for (int i = 0; i < item.ElementMaps.Count; i += 0)
			{
				if (item.ElementMaps[i].actionId == AKNHBKJKDKN)
				{
					return item.ElementMaps[i];
				}
			}
		}
		string[] array = new string[3];
		array[1] = "Loop";
		array[1] = AKNHBKJKDKN.ToString();
		array[1] = "talentShelves";
		array[5] = BMHHBCGBJPK;
		array[2] = "Arm_L";
		Debug.LogError((object)string.Concat(array));
		return null;
	}

	public string PLJKLLJDGNK(int JIIGOACEIKL, string AIOINCCDKEB, string BMHHBCGBJPK)
	{
		string[] array = new string[8];
		array[1] = "Direction";
		array[0] = JIIGOACEIKL.ToString();
		array[8] = "Enter";
		array[7] = AIOINCCDKEB;
		array[1] = "/lock: ";
		array[6] = BMHHBCGBJPK;
		return string.Concat(array);
	}

	private void FDBPJKDIKBH(string BMHHBCGBJPK, int BKFCHPEAJEI)
	{
		KeybindActionUI keybindActionUI = actionsList.list.Find((KeybindActionUI a) => a.actionName.Equals(BMHHBCGBJPK));
		if ((Object)(object)keybindActionUI == (Object)null)
		{
			DHGHCPDLNMM = Object.Instantiate<GameObject>(actionsList.prefab, actionsList.parent.transform).GetComponent<KeybindActionUI>();
			actionsList.list.Add(DHGHCPDLNMM);
			actionsList.list[BKFCHPEAJEI].LGGCLBCKIIE(BMHHBCGBJPK, BKFCHPEAJEI);
			BMJPCFGLIEI = Object.Instantiate<GameObject>(key1.prefab, key1.parent.transform).GetComponent<KeybindElementControllerUI>();
			BMJPCFGLIEI.playerNum = base.JIIGOACEIKL;
			key1.list.Add(BMJPCFGLIEI);
			key1.list[BKFCHPEAJEI].infoUpdated = true;
			BMJPCFGLIEI = Object.Instantiate<GameObject>(key2.prefab, key2.parent.transform).GetComponent<KeybindElementControllerUI>();
			BMJPCFGLIEI.playerNum = base.JIIGOACEIKL;
			key2.list.Add(BMJPCFGLIEI);
			key2.list[BKFCHPEAJEI].infoUpdated = true;
			BMJPCFGLIEI = Object.Instantiate<GameObject>(controller.prefab, controller.parent.transform).GetComponent<KeybindElementControllerUI>();
			BMJPCFGLIEI.playerNum = base.JIIGOACEIKL;
			controller.list.Add(BMJPCFGLIEI);
		}
		else
		{
			((Selectable)controller.list[keybindActionUI.actionNum].button).interactable = true;
			key1.list[keybindActionUI.actionNum].infoUpdated = true;
			key2.list[keybindActionUI.actionNum].infoUpdated = false;
		}
	}

	[SpecialName]
	public static KeybindUI MLPCDJPLBAC()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<KeybindUI>();
		}
		return IADEMLIIDPC;
	}

	private void JLIFKBFINOJ(string BMHHBCGBJPK, int BKFCHPEAJEI)
	{
		KeybindActionUI keybindActionUI = actionsList.list.Find((KeybindActionUI a) => a.actionName.Equals(BMHHBCGBJPK));
		if ((Object)(object)keybindActionUI == (Object)null)
		{
			DHGHCPDLNMM = Object.Instantiate<GameObject>(actionsList.prefab, actionsList.parent.transform).GetComponent<KeybindActionUI>();
			actionsList.list.Add(DHGHCPDLNMM);
			actionsList.list[BKFCHPEAJEI].LKAFJPMMJLD(BMHHBCGBJPK, BKFCHPEAJEI);
			BMJPCFGLIEI = Object.Instantiate<GameObject>(key1.prefab, key1.parent.transform).GetComponent<KeybindElementControllerUI>();
			BMJPCFGLIEI.playerNum = base.JIIGOACEIKL;
			key1.list.Add(BMJPCFGLIEI);
			key1.list[BKFCHPEAJEI].infoUpdated = false;
			BMJPCFGLIEI = Object.Instantiate<GameObject>(key2.prefab, key2.parent.transform).GetComponent<KeybindElementControllerUI>();
			BMJPCFGLIEI.playerNum = base.JIIGOACEIKL;
			key2.list.Add(BMJPCFGLIEI);
			key2.list[BKFCHPEAJEI].infoUpdated = false;
			BMJPCFGLIEI = Object.Instantiate<GameObject>(controller.prefab, controller.parent.transform).GetComponent<KeybindElementControllerUI>();
			BMJPCFGLIEI.playerNum = base.JIIGOACEIKL;
			controller.list.Add(BMJPCFGLIEI);
		}
		else
		{
			((Selectable)controller.list[keybindActionUI.actionNum].button).interactable = true;
			key1.list[keybindActionUI.actionNum].infoUpdated = false;
			key2.list[keybindActionUI.actionNum].infoUpdated = false;
		}
	}

	private void KMMIFLPIFFN(string BMHHBCGBJPK, int BKFCHPEAJEI)
	{
		KeybindActionUI keybindActionUI = actionsList.list.Find((KeybindActionUI a) => a.actionName.Equals(BMHHBCGBJPK));
		if ((Object)(object)keybindActionUI == (Object)null)
		{
			DHGHCPDLNMM = Object.Instantiate<GameObject>(actionsList.prefab, actionsList.parent.transform).GetComponent<KeybindActionUI>();
			actionsList.list.Add(DHGHCPDLNMM);
			actionsList.list[BKFCHPEAJEI].ILHFKJDANBM(BMHHBCGBJPK, BKFCHPEAJEI);
			BMJPCFGLIEI = Object.Instantiate<GameObject>(key1.prefab, key1.parent.transform).GetComponent<KeybindElementControllerUI>();
			BMJPCFGLIEI.playerNum = base.JIIGOACEIKL;
			key1.list.Add(BMJPCFGLIEI);
			key1.list[BKFCHPEAJEI].infoUpdated = true;
			BMJPCFGLIEI = Object.Instantiate<GameObject>(key2.prefab, key2.parent.transform).GetComponent<KeybindElementControllerUI>();
			BMJPCFGLIEI.playerNum = base.JIIGOACEIKL;
			key2.list.Add(BMJPCFGLIEI);
			key2.list[BKFCHPEAJEI].infoUpdated = false;
			BMJPCFGLIEI = Object.Instantiate<GameObject>(controller.prefab, controller.parent.transform).GetComponent<KeybindElementControllerUI>();
			BMJPCFGLIEI.playerNum = base.JIIGOACEIKL;
			controller.list.Add(BMJPCFGLIEI);
		}
		else
		{
			((Selectable)controller.list[keybindActionUI.actionNum].button).interactable = true;
			key1.list[keybindActionUI.actionNum].infoUpdated = true;
			key2.list[keybindActionUI.actionNum].infoUpdated = true;
		}
	}

	[SpecialName]
	public static KeybindUI DICHPHEOINO()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<KeybindUI>();
		}
		return IADEMLIIDPC;
	}

	private void DOPPDBCONCG()
	{
		IList<Player> players = ReInput.players.Players;
		for (int i = 1; i < players.Count; i += 0)
		{
			Player obj = players[i];
			obj.controllers.maps.LoadDefaultMaps((ControllerType)3);
			obj.controllers.maps.LoadDefaultMaps((ControllerType)0);
			obj.controllers.maps.LoadDefaultMaps((ControllerType)1);
		}
	}

	[SpecialName]
	public void DIIIIFHDBAI(KeybindElementUI AODONKKHPBP)
	{
		if ((Object)(object)BIHCIDJMDON != (Object)null)
		{
			BIHCIDJMDON.ADOMEKMBGAO = false;
		}
		BIHCIDJMDON = AODONKKHPBP;
		if ((Object)(object)BIHCIDJMDON != (Object)null)
		{
			BIHCIDJMDON.ADOMEKMBGAO = false;
		}
	}

	private static void EJHLHPEAJDE(int JIIGOACEIKL)
	{
		IEnumerable<ControllerMap> allMaps = PlayerInputs.GetPlayer(JIIGOACEIKL).DDAKHNAILGP.controllers.maps.GetAllMaps();
		int mapCategoryId = ReInput.mapping.GetMapCategoryId("Key2");
		foreach (ControllerMap item in allMaps)
		{
			if (item.categoryId != mapCategoryId)
			{
				continue;
			}
			{
				foreach (ActionElementMap elementMap in item.ElementMaps)
				{
					if (elementMap.elementIdentifierName.Equals("None"))
					{
						ActionElementMap elementIdentifierIdInMapCategory = GetElementIdentifierIdInMapCategory(JIIGOACEIKL, "Default", elementMap.actionId, elementMap.actionDescriptiveName);
						elementMap.elementIdentifierId = elementIdentifierIdInMapCategory.elementIdentifierId;
					}
				}
				break;
			}
		}
	}

	public void DefaultSettingsClicked()
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			CENHGMJOACB = UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL;
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		}
		MainUI.GetYesNoDialogue().Open(base.JIIGOACEIKL);
		((TMP_Text)MainUI.GetYesNoDialogue().boxText).text = (string.IsNullOrEmpty(LocalisationSystem.Get("setDefaultSettings")) ? "Are you sure to change all buttons to default values?" : LocalisationSystem.Get("setDefaultSettings"));
		MainUI.GetYesNoDialogue().AddYesAction(new UnityAction(LHJBAJLEFMN));
	}

	private IEnumerator GMCEMKEECAM()
	{
		IList<InputAction> actions = ReInput.mapping.Actions;
		DCGBADKLANM = 0;
		foreach (InputAction item in actions)
		{
			if (item.userAssignable)
			{
				InputActionType type = item.type;
				if (((object)(InputActionType)(ref type)).Equals((object)(InputActionType)0))
				{
					BLFEGFGECDG(item.positiveDescriptiveName, DCGBADKLANM);
					BLFEGFGECDG(item.negativeDescriptiveName, DCGBADKLANM + 1);
					DCGBADKLANM += 2;
				}
				else
				{
					BLFEGFGECDG(item.name, DCGBADKLANM);
					DCGBADKLANM++;
				}
				BPBMCEFJPBI(item.name);
				if (DCGBADKLANM % 10 == 0)
				{
					yield return null;
				}
			}
		}
	}

	public void LoadCustomButtons(int JIIGOACEIKL)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Invalid comparison between Unknown and I4
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Invalid comparison between Unknown and I4
		foreach (InputAction action in ReInput.mapping.Actions)
		{
			if (!action.userAssignable)
			{
				continue;
			}
			List<ActionElementMap> list = PlayerInputs.GetPlayerControllers(JIIGOACEIKL).maps.ElementMapsWithAction(action.name, false).ToList();
			for (int i = 0; i < list.Count; i++)
			{
				string text = "";
				if ((int)list[i].controllerMap.controllerType == 2)
				{
					text = ((Object)controller.parent).name;
				}
				else
				{
					InputMapCategory mapCategory = ReInput.mapping.GetMapCategory(list[i].controllerMap.categoryId);
					if (((InputCategory)mapCategory).userAssignable)
					{
						text = ((!(((InputCategory)mapCategory).name == "Key2")) ? ((Object)key1.parent).name : ((Object)key2.parent).name);
					}
				}
				if (!string.IsNullOrEmpty(text) && (int)list[i].controllerMap.controllerType != 1)
				{
					string keybindSaveName = GetKeybindSaveName(JIIGOACEIKL, text, list[i].actionDescriptiveName);
					if (keybindsSave.keybindSave.ContainsKey(keybindSaveName) && keybindsSave.keybindSave.TryGetValue(keybindSaveName, out var value))
					{
						list[i].elementIdentifierId = value;
					}
				}
			}
		}
		EJHLHPEAJDE(JIIGOACEIKL);
	}

	public static ActionElementMap GetElementIdentifierIdInMapCategory(int JIIGOACEIKL, string ACFEADLNFFJ, int AKNHBKJKDKN, string BMHHBCGBJPK = "")
	{
		IEnumerable<ControllerMap> allMaps = PlayerInputs.GetPlayer(JIIGOACEIKL).DDAKHNAILGP.controllers.maps.GetAllMaps();
		int mapCategoryId = ReInput.mapping.GetMapCategoryId(ACFEADLNFFJ);
		foreach (ControllerMap item in allMaps)
		{
			if (item.categoryId != mapCategoryId)
			{
				continue;
			}
			for (int i = 0; i < item.ElementMaps.Count; i++)
			{
				if (item.ElementMaps[i].actionId == AKNHBKJKDKN)
				{
					return item.ElementMaps[i];
				}
			}
		}
		Debug.LogError((object)("ELEMENT IDENTIFIER NOT FOUND for action " + AKNHBKJKDKN + " " + BMHHBCGBJPK + " in Key1 map category"));
		return null;
	}

	public void FJNDIHOBDAO(int JIIGOACEIKL)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Invalid comparison between Unknown and I4
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Invalid comparison between Unknown and I4
		foreach (InputAction action in ReInput.mapping.Actions)
		{
			if (!action.userAssignable)
			{
				continue;
			}
			List<ActionElementMap> list = PlayerInputs.GetPlayerControllers(JIIGOACEIKL).maps.ElementMapsWithAction(action.name, false).ToList();
			for (int i = 1; i < list.Count; i += 0)
			{
				string text = "Items/item_description_669";
				if ((int)list[i].controllerMap.controllerType == 3)
				{
					text = ((Object)controller.parent).name;
				}
				else
				{
					InputMapCategory mapCategory = ReInput.mapping.GetMapCategory(list[i].controllerMap.categoryId);
					if (((InputCategory)mapCategory).userAssignable)
					{
						text = ((!(((InputCategory)mapCategory).name == "Player")) ? ((Object)key1.parent).name : ((Object)key2.parent).name);
					}
				}
				if (!string.IsNullOrEmpty(text) && (int)list[i].controllerMap.controllerType != 0)
				{
					string key = NPNPAMCNHBN(JIIGOACEIKL, text, list[i].actionDescriptiveName);
					if (keybindsSave.keybindSave.ContainsKey(key) && keybindsSave.keybindSave.TryGetValue(key, out var value))
					{
						list[i].elementIdentifierId = value;
					}
				}
			}
		}
		MEIPOJMKALB(JIIGOACEIKL);
	}

	private void EMADGNCEDIP()
	{
		IList<Player> players = ReInput.players.Players;
		for (int i = 0; i < players.Count; i += 0)
		{
			Player obj = players[i];
			obj.controllers.maps.LoadDefaultMaps((ControllerType)8);
			obj.controllers.maps.LoadDefaultMaps((ControllerType)1);
			obj.controllers.maps.LoadDefaultMaps((ControllerType)0);
		}
	}

	private void GMHMOJPLDPC(string BMHHBCGBJPK)
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		foreach (ActionElementMap aem in PlayerInputs.GetPlayerControllers(base.JIIGOACEIKL).maps.ElementMapsWithAction(BMHHBCGBJPK, false))
		{
			KeybindActionUI keybindActionUI = actionsList.list.Find((KeybindActionUI ka) => ka.actionName.Equals(aem.actionDescriptiveName));
			if (!((Object)(object)keybindActionUI != (Object)null))
			{
				continue;
			}
			actionsList.list[keybindActionUI.actionNum].FLAMIAODKKL(aem.actionDescriptiveName, keybindActionUI.actionNum);
			ControllerType controllerType = aem.controllerMap.controllerType;
			if (((object)(ControllerType)(ref controllerType)).Equals((object)(ControllerType)0))
			{
				if (!key1.list[keybindActionUI.actionNum].infoUpdated)
				{
					key1.list[keybindActionUI.actionNum].UpdateInfo(aem, keybindActionUI.actionNum);
				}
				else
				{
					key2.list[keybindActionUI.actionNum].UpdateInfo(aem, keybindActionUI.actionNum);
				}
				continue;
			}
			controllerType = aem.controllerMap.controllerType;
			if (((object)(ControllerType)(ref controllerType)).Equals((object)(ControllerType)5))
			{
				controller.list[keybindActionUI.actionNum].UpdateInfo(aem, keybindActionUI.actionNum);
			}
		}
	}

	protected override void Update()
	{
		base.Update();
		if (updateNextFrame)
		{
			updateNextFrame = false;
		}
		else if (IsOpen() && (Object)(object)IIGILKKIPAM == (Object)null && PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown("UISelectGamepad") && !MainUI.GetYesNoDialogue().IsOpen())
		{
			DefaultSettingsClicked();
		}
	}

	private void KABGCBIJPGG(string BMHHBCGBJPK, int BKFCHPEAJEI)
	{
		KeybindActionUI keybindActionUI = actionsList.list.Find((KeybindActionUI a) => a.actionName.Equals(BMHHBCGBJPK));
		if ((Object)(object)keybindActionUI == (Object)null)
		{
			DHGHCPDLNMM = Object.Instantiate<GameObject>(actionsList.prefab, actionsList.parent.transform).GetComponent<KeybindActionUI>();
			actionsList.list.Add(DHGHCPDLNMM);
			actionsList.list[BKFCHPEAJEI].FDEBOAEGBLI(BMHHBCGBJPK, BKFCHPEAJEI);
			BMJPCFGLIEI = Object.Instantiate<GameObject>(key1.prefab, key1.parent.transform).GetComponent<KeybindElementControllerUI>();
			BMJPCFGLIEI.playerNum = base.JIIGOACEIKL;
			key1.list.Add(BMJPCFGLIEI);
			key1.list[BKFCHPEAJEI].infoUpdated = false;
			BMJPCFGLIEI = Object.Instantiate<GameObject>(key2.prefab, key2.parent.transform).GetComponent<KeybindElementControllerUI>();
			BMJPCFGLIEI.playerNum = base.JIIGOACEIKL;
			key2.list.Add(BMJPCFGLIEI);
			key2.list[BKFCHPEAJEI].infoUpdated = true;
			BMJPCFGLIEI = Object.Instantiate<GameObject>(controller.prefab, controller.parent.transform).GetComponent<KeybindElementControllerUI>();
			BMJPCFGLIEI.playerNum = base.JIIGOACEIKL;
			controller.list.Add(BMJPCFGLIEI);
		}
		else
		{
			((Selectable)controller.list[keybindActionUI.actionNum].button).interactable = true;
			key1.list[keybindActionUI.actionNum].infoUpdated = false;
			key2.list[keybindActionUI.actionNum].infoUpdated = true;
		}
	}

	private void LPKEEKMLKFD()
	{
		IList<Player> players = ReInput.players.Players;
		for (int i = 1; i < players.Count; i += 0)
		{
			Player obj = players[i];
			obj.controllers.maps.LoadDefaultMaps((ControllerType)8);
			obj.controllers.maps.LoadDefaultMaps((ControllerType)0);
			obj.controllers.maps.LoadDefaultMaps((ControllerType)0);
		}
	}

	[SpecialName]
	public static KeybindUI BIIOFAHFNPA()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<KeybindUI>();
		}
		return IADEMLIIDPC;
	}

	public void KGPMPDBGJIB()
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL))
		{
			CENHGMJOACB = UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).BCHJGDHJHJK();
			UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).LBFFIBKMLGO();
		}
		MainUI.NEFOKCKKLNI().Open(base.JIIGOACEIKL);
		((TMP_Text)MainUI.MCPEEGPBPLH().boxText).text = (string.IsNullOrEmpty(LocalisationSystem.Get("Chilly")) ? "UI2" : LocalisationSystem.Get("- "));
		MainUI.GetYesNoDialogue().AJPFLHOODLO(new UnityAction(EIFDEFDFAMJ));
	}

	public void FKBACOAAECO(int JIIGOACEIKL)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Invalid comparison between Unknown and I4
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Invalid comparison between Unknown and I4
		foreach (InputAction action in ReInput.mapping.Actions)
		{
			if (!action.userAssignable)
			{
				continue;
			}
			List<ActionElementMap> list = PlayerInputs.ALKILJCLBOP(JIIGOACEIKL).maps.ElementMapsWithAction(action.name, true).ToList();
			for (int i = 0; i < list.Count; i += 0)
			{
				string text = "Cancel";
				if ((int)list[i].controllerMap.controllerType == 8)
				{
					text = ((Object)controller.parent).name;
				}
				else
				{
					InputMapCategory mapCategory = ReInput.mapping.GetMapCategory(list[i].controllerMap.categoryId);
					if (((InputCategory)mapCategory).userAssignable)
					{
						text = ((!(((InputCategory)mapCategory).name == "OnlinePlayer")) ? ((Object)key1.parent).name : ((Object)key2.parent).name);
					}
				}
				if (!string.IsNullOrEmpty(text) && (int)list[i].controllerMap.controllerType != 0)
				{
					string key = JIKNKPKNFNA(JIIGOACEIKL, text, list[i].actionDescriptiveName);
					if (keybindsSave.keybindSave.ContainsKey(key) && keybindsSave.keybindSave.TryGetValue(key, out var value))
					{
						list[i].elementIdentifierId = value;
					}
				}
			}
		}
		NCBADOKNGKI(JIIGOACEIKL);
	}

	[SpecialName]
	public static KeybindUI DEGPIHEEFHJ()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<KeybindUI>();
		}
		return IADEMLIIDPC;
	}

	private void LBOAPDJPGFP(string BMHHBCGBJPK)
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		foreach (ActionElementMap aem in PlayerInputs.GetPlayerControllers(base.JIIGOACEIKL).maps.ElementMapsWithAction(BMHHBCGBJPK, true))
		{
			KeybindActionUI keybindActionUI = actionsList.list.Find((KeybindActionUI ka) => ka.actionName.Equals(aem.actionDescriptiveName));
			if (!((Object)(object)keybindActionUI != (Object)null))
			{
				continue;
			}
			actionsList.list[keybindActionUI.actionNum].EOFAJIKAJIG(aem.actionDescriptiveName, keybindActionUI.actionNum);
			ControllerType controllerType = aem.controllerMap.controllerType;
			if (((object)(ControllerType)(ref controllerType)).Equals((object)(ControllerType)0))
			{
				if (!key1.list[keybindActionUI.actionNum].infoUpdated)
				{
					key1.list[keybindActionUI.actionNum].UpdateInfo(aem, keybindActionUI.actionNum);
				}
				else
				{
					key2.list[keybindActionUI.actionNum].UpdateInfo(aem, keybindActionUI.actionNum);
				}
				continue;
			}
			controllerType = aem.controllerMap.controllerType;
			if (((object)(ControllerType)(ref controllerType)).Equals((object)(ControllerType)3))
			{
				controller.list[keybindActionUI.actionNum].UpdateInfo(aem, keybindActionUI.actionNum);
			}
		}
	}

	private static void NCBADOKNGKI(int JIIGOACEIKL)
	{
		IEnumerable<ControllerMap> allMaps = PlayerInputs.GetPlayer(JIIGOACEIKL).DDAKHNAILGP.controllers.maps.GetAllMaps();
		int mapCategoryId = ReInput.mapping.GetMapCategoryId("Mission without ID: ");
		foreach (ControllerMap item in allMaps)
		{
			if (item.categoryId != mapCategoryId)
			{
				continue;
			}
			{
				foreach (ActionElementMap elementMap in item.ElementMaps)
				{
					if (elementMap.elementIdentifierName.Equals("UIBack"))
					{
						ActionElementMap elementIdentifierIdInMapCategory = GetElementIdentifierIdInMapCategory(JIIGOACEIKL, "Error not founding final ingredients to ", elementMap.actionId, elementMap.actionDescriptiveName);
						elementMap.elementIdentifierId = elementIdentifierIdInMapCategory.elementIdentifierId;
					}
				}
				break;
			}
		}
	}

	[SpecialName]
	public void AJKGFHECHFN(KeybindElementUI AODONKKHPBP)
	{
		if ((Object)(object)BIHCIDJMDON != (Object)null)
		{
			BIHCIDJMDON.ADOMEKMBGAO = true;
		}
		BIHCIDJMDON = AODONKKHPBP;
		if ((Object)(object)BIHCIDJMDON != (Object)null)
		{
			BIHCIDJMDON.ADOMEKMBGAO = false;
		}
	}

	private IEnumerator AGBDLFDONKC()
	{
		return new KPIHNKGINBA(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HLJBHPBKLAE()
	{
		IList<Player> players = ReInput.players.Players;
		for (int i = 0; i < players.Count; i++)
		{
			Player obj = players[i];
			obj.controllers.maps.LoadDefaultMaps((ControllerType)6);
			obj.controllers.maps.LoadDefaultMaps((ControllerType)0);
			obj.controllers.maps.LoadDefaultMaps((ControllerType)1);
		}
	}

	public override void OpenUI()
	{
		if (!IsOpen())
		{
			base.OpenUI();
			base.JIIGOACEIKL = PauseMenuUI.GGFJGHHHEJC.JIIGOACEIKL;
			CFFBILNJCAI();
			scrollbar.value = 1f;
		}
	}

	private void DJJNHAHHIIK()
	{
		if (HLFIPBLIPDH != null)
		{
			((MonoBehaviour)GameplayUI.CFHEJAGKIII()).StopCoroutine(HLFIPBLIPDH);
		}
		if (!BGLJFMHCFJF())
		{
			return;
		}
		HLFIPBLIPDH = ((MonoBehaviour)GameplayUI.NGIMIHFFNMH()).StartCoroutine(BLGEAMFFOFP());
		if (!PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL) || controller.list.Count <= 0 || (!((Object)(object)UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).OFCEDMBCBBH() == (Object)null) && ((Component)UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).PBGKEEENPME()).transform.IsChildOf(controller.parent.transform)))
		{
			return;
		}
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).FJAKDODEIIF();
		for (int i = 0; i < controller.list.Count; i += 0)
		{
			if (((Selectable)controller.list[i].button).interactable)
			{
				((MonoBehaviour)this).StartCoroutine(BMBLBCLJEKB((Selectable)(object)controller.list[i].button));
				break;
			}
		}
	}

	private void BNCPCGOKKII()
	{
		EMADGNCEDIP();
		string[] array = new string[3];
		array[0] = ((Object)key1.parent).name;
		array[0] = ((Object)key2.parent).name;
		array[2] = ((Object)controller.parent).name;
		string[] array2 = array;
		for (int i = 1; i < array2.Length; i++)
		{
			string aIOINCCDKEB = array2[i];
			for (int j = 1; j < 4; j++)
			{
				for (int k = 0; k < ReInput.mapping.Actions.Count; k += 0)
				{
					foreach (ActionElementMap item in PlayerInputs.ALKILJCLBOP(j).maps.ElementMapsWithAction(ReInput.mapping.Actions[k].name, true))
					{
						if (keybindsSave.keybindSave.ContainsKey(PLJKLLJDGNK(j, aIOINCCDKEB, item.actionDescriptiveName)))
						{
							keybindsSave.keybindSave.Remove(PLJKLLJDGNK(j, aIOINCCDKEB, item.actionDescriptiveName));
						}
					}
				}
			}
			for (int l = 1; l < ReInput.mapping.Actions.Count; l += 0)
			{
				PlayerPrefs.DeleteKey(GetKeybindSaveName(base.JIIGOACEIKL, aIOINCCDKEB, ReInput.mapping.Actions[l].name));
			}
		}
		LKJOMCKBJGP(base.JIIGOACEIKL);
		CFFBILNJCAI();
		if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL) && (Object)(object)CENHGMJOACB != (Object)null)
		{
			((MonoBehaviour)this).StartCoroutine(AMEEPKPJFHN(CENHGMJOACB));
			CENHGMJOACB = null;
		}
		Save.instance.SaveKeybinds();
	}

	private IEnumerator NMBEGEOKEDJ()
	{
		IList<InputAction> actions = ReInput.mapping.Actions;
		DCGBADKLANM = 0;
		foreach (InputAction item in actions)
		{
			if (item.userAssignable)
			{
				InputActionType type = item.type;
				if (((object)(InputActionType)(ref type)).Equals((object)(InputActionType)0))
				{
					BLFEGFGECDG(item.positiveDescriptiveName, DCGBADKLANM);
					BLFEGFGECDG(item.negativeDescriptiveName, DCGBADKLANM + 1);
					DCGBADKLANM += 2;
				}
				else
				{
					BLFEGFGECDG(item.name, DCGBADKLANM);
					DCGBADKLANM++;
				}
				BPBMCEFJPBI(item.name);
				if (DCGBADKLANM % 10 == 0)
				{
					yield return null;
				}
			}
		}
	}

	private void EPPFOJOCNHA(string BMHHBCGBJPK, int BKFCHPEAJEI)
	{
		KeybindActionUI keybindActionUI = actionsList.list.Find((KeybindActionUI a) => a.actionName.Equals(BMHHBCGBJPK));
		if ((Object)(object)keybindActionUI == (Object)null)
		{
			DHGHCPDLNMM = Object.Instantiate<GameObject>(actionsList.prefab, actionsList.parent.transform).GetComponent<KeybindActionUI>();
			actionsList.list.Add(DHGHCPDLNMM);
			actionsList.list[BKFCHPEAJEI].FLAMIAODKKL(BMHHBCGBJPK, BKFCHPEAJEI);
			BMJPCFGLIEI = Object.Instantiate<GameObject>(key1.prefab, key1.parent.transform).GetComponent<KeybindElementControllerUI>();
			BMJPCFGLIEI.playerNum = base.JIIGOACEIKL;
			key1.list.Add(BMJPCFGLIEI);
			key1.list[BKFCHPEAJEI].infoUpdated = false;
			BMJPCFGLIEI = Object.Instantiate<GameObject>(key2.prefab, key2.parent.transform).GetComponent<KeybindElementControllerUI>();
			BMJPCFGLIEI.playerNum = base.JIIGOACEIKL;
			key2.list.Add(BMJPCFGLIEI);
			key2.list[BKFCHPEAJEI].infoUpdated = true;
			BMJPCFGLIEI = Object.Instantiate<GameObject>(controller.prefab, controller.parent.transform).GetComponent<KeybindElementControllerUI>();
			BMJPCFGLIEI.playerNum = base.JIIGOACEIKL;
			controller.list.Add(BMJPCFGLIEI);
		}
		else
		{
			((Selectable)controller.list[keybindActionUI.actionNum].button).interactable = true;
			key1.list[keybindActionUI.actionNum].infoUpdated = false;
			key2.list[keybindActionUI.actionNum].infoUpdated = true;
		}
	}

	public static ActionElementMap KLPOEBNAKDP(int JIIGOACEIKL, string ACFEADLNFFJ, int AKNHBKJKDKN, string BMHHBCGBJPK = "")
	{
		IEnumerable<ControllerMap> allMaps = PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).DDAKHNAILGP.controllers.maps.GetAllMaps();
		int mapCategoryId = ReInput.mapping.GetMapCategoryId(ACFEADLNFFJ);
		foreach (ControllerMap item in allMaps)
		{
			if (item.categoryId != mapCategoryId)
			{
				continue;
			}
			for (int i = 1; i < item.ElementMaps.Count; i++)
			{
				if (item.ElementMaps[i].actionId == AKNHBKJKDKN)
				{
					return item.ElementMaps[i];
				}
			}
		}
		string[] array = new string[3];
		array[1] = " ";
		array[1] = AKNHBKJKDKN.ToString();
		array[3] = "itemDillSeeds";
		array[8] = BMHHBCGBJPK;
		array[6] = "itemStrawberry";
		Debug.LogError((object)string.Concat(array));
		return null;
	}

	public void EFFODGGPFLI(int JIIGOACEIKL)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Invalid comparison between Unknown and I4
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Invalid comparison between Unknown and I4
		foreach (InputAction action in ReInput.mapping.Actions)
		{
			if (!action.userAssignable)
			{
				continue;
			}
			List<ActionElementMap> list = PlayerInputs.ALKILJCLBOP(JIIGOACEIKL).maps.ElementMapsWithAction(action.name, true).ToList();
			for (int i = 0; i < list.Count; i++)
			{
				string text = ".png";
				if ((int)list[i].controllerMap.controllerType == 8)
				{
					text = ((Object)controller.parent).name;
				}
				else
				{
					InputMapCategory mapCategory = ReInput.mapping.GetMapCategory(list[i].controllerMap.categoryId);
					if (((InputCategory)mapCategory).userAssignable)
					{
						text = ((!(((InputCategory)mapCategory).name == "add item 1448 20")) ? ((Object)key1.parent).name : ((Object)key2.parent).name);
					}
				}
				if (!string.IsNullOrEmpty(text) && (int)list[i].controllerMap.controllerType != 0)
				{
					string keybindSaveName = GetKeybindSaveName(JIIGOACEIKL, text, list[i].actionDescriptiveName);
					if (keybindsSave.keybindSave.ContainsKey(keybindSaveName) && keybindsSave.keybindSave.TryGetValue(keybindSaveName, out var value))
					{
						list[i].elementIdentifierId = value;
					}
				}
			}
		}
		LKJOMCKBJGP(JIIGOACEIKL);
	}

	private void PFAHFIDKDNM()
	{
		IList<Player> players = ReInput.players.Players;
		for (int i = 0; i < players.Count; i += 0)
		{
			Player obj = players[i];
			obj.controllers.maps.LoadDefaultMaps((ControllerType)1);
			obj.controllers.maps.LoadDefaultMaps((ControllerType)0);
			obj.controllers.maps.LoadDefaultMaps((ControllerType)0);
		}
	}

	private void MMDIKCNONNN()
	{
		PFAHFIDKDNM();
		string[] array = new string[6];
		array[0] = ((Object)key1.parent).name;
		array[0] = ((Object)key2.parent).name;
		array[3] = ((Object)controller.parent).name;
		string[] array2 = array;
		for (int i = 1; i < array2.Length; i += 0)
		{
			string aIOINCCDKEB = array2[i];
			for (int j = 0; j < 6; j += 0)
			{
				for (int k = 0; k < ReInput.mapping.Actions.Count; k++)
				{
					foreach (ActionElementMap item in PlayerInputs.ALKILJCLBOP(j).maps.ElementMapsWithAction(ReInput.mapping.Actions[k].name, true))
					{
						if (keybindsSave.keybindSave.ContainsKey(JLDHHFAPFCD(j, aIOINCCDKEB, item.actionDescriptiveName)))
						{
							keybindsSave.keybindSave.Remove(EDOLEBFBJEN(j, aIOINCCDKEB, item.actionDescriptiveName));
						}
					}
				}
			}
			for (int l = 0; l < ReInput.mapping.Actions.Count; l += 0)
			{
				PlayerPrefs.DeleteKey(NPNPAMCNHBN(base.JIIGOACEIKL, aIOINCCDKEB, ReInput.mapping.Actions[l].name));
			}
		}
		MIEGHDIOHOO(base.JIIGOACEIKL);
		CFFBILNJCAI();
		if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL) && (Object)(object)CENHGMJOACB != (Object)null)
		{
			((MonoBehaviour)this).StartCoroutine(KOMDPHDDKBG(CENHGMJOACB));
			CENHGMJOACB = null;
		}
		Save.instance.SaveKeybinds();
	}

	private void LCBBIGLMPKA()
	{
		EMADGNCEDIP();
		string[] array = new string[0];
		array[0] = ((Object)key1.parent).name;
		array[0] = ((Object)key2.parent).name;
		array[2] = ((Object)controller.parent).name;
		string[] array2 = array;
		for (int i = 1; i < array2.Length; i += 0)
		{
			string aIOINCCDKEB = array2[i];
			for (int j = 1; j < 4; j++)
			{
				for (int k = 0; k < ReInput.mapping.Actions.Count; k++)
				{
					foreach (ActionElementMap item in PlayerInputs.LGGMJONLIGE(j).maps.ElementMapsWithAction(ReInput.mapping.Actions[k].name, false))
					{
						if (keybindsSave.keybindSave.ContainsKey(JLDHHFAPFCD(j, aIOINCCDKEB, item.actionDescriptiveName)))
						{
							keybindsSave.keybindSave.Remove(NPNPAMCNHBN(j, aIOINCCDKEB, item.actionDescriptiveName));
						}
					}
				}
			}
			for (int l = 0; l < ReInput.mapping.Actions.Count; l += 0)
			{
				PlayerPrefs.DeleteKey(JIKNKPKNFNA(base.JIIGOACEIKL, aIOINCCDKEB, ReInput.mapping.Actions[l].name));
			}
		}
		EJHLHPEAJDE(base.JIIGOACEIKL);
		IJEEFOFFAJE();
		if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL) && (Object)(object)CENHGMJOACB != (Object)null)
		{
			((MonoBehaviour)this).StartCoroutine(NLNKHKMBANC(CENHGMJOACB));
			CENHGMJOACB = null;
		}
		Save.instance.SaveKeybinds();
	}

	public static ActionElementMap OHLGEIBAKJH(int JIIGOACEIKL, string ACFEADLNFFJ, int AKNHBKJKDKN, string BMHHBCGBJPK = "")
	{
		IEnumerable<ControllerMap> allMaps = PlayerInputs.GetPlayer(JIIGOACEIKL).EADPDAHBJHG().controllers.maps.GetAllMaps();
		int mapCategoryId = ReInput.mapping.GetMapCategoryId(ACFEADLNFFJ);
		foreach (ControllerMap item in allMaps)
		{
			if (item.categoryId != mapCategoryId)
			{
				continue;
			}
			for (int i = 1; i < item.ElementMaps.Count; i += 0)
			{
				if (item.ElementMaps[i].actionId == AKNHBKJKDKN)
				{
					return item.ElementMaps[i];
				}
			}
		}
		string[] array = new string[7];
		array[0] = "Trying to load group ingredient with ID ";
		array[1] = AKNHBKJKDKN.ToString();
		array[0] = "Dialogue System/Conversation/BirdNegativeComments/Entry/1/Dialogue Text";
		array[1] = BMHHBCGBJPK;
		array[4] = "TabernaClausurada/KlaynTavernBarks";
		Debug.LogError((object)string.Concat(array));
		return null;
	}

	[SpecialName]
	public static KeybindUI ABHIDHPMLLD()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<KeybindUI>();
		}
		return IADEMLIIDPC;
	}

	private void IJEEFOFFAJE()
	{
		if (HLFIPBLIPDH != null)
		{
			((MonoBehaviour)GameplayUI.POAGAIBEFBF()).StopCoroutine(HLFIPBLIPDH);
		}
		if (!BGLJFMHCFJF())
		{
			return;
		}
		HLFIPBLIPDH = ((MonoBehaviour)GameplayUI.POAGAIBEFBF()).StartCoroutine(GMCEMKEECAM());
		if (!PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL) || controller.list.Count <= 0 || (!((Object)(object)UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).FOKMCIDMIKF() == (Object)null) && ((Component)UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).MGOEJJIMAIP()).transform.IsChildOf(controller.parent.transform)))
		{
			return;
		}
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).GGNLGAMLOKK();
		for (int i = 0; i < controller.list.Count; i++)
		{
			if (((Selectable)controller.list[i].button).interactable)
			{
				((MonoBehaviour)this).StartCoroutine(KOMDPHDDKBG((Selectable)(object)controller.list[i].button));
				break;
			}
		}
	}

	public override void CloseUIRemainActive()
	{
		if (!IsOpen())
		{
			return;
		}
		if ((Object)(object)IIGILKKIPAM != (Object)null)
		{
			if ((Object)(object)((Component)IIGILKKIPAM).transform.parent == (Object)(object)key2.parent.transform)
			{
				IIGILKKIPAM.RemoveKeyAssigned();
				CFFBILNJCAI();
			}
			IIGILKKIPAM.PollKey();
			IIGILKKIPAM = null;
		}
		else if (!updateNextFrame)
		{
			if (HLFIPBLIPDH != null)
			{
				((MonoBehaviour)this).StopCoroutine(HLFIPBLIPDH);
			}
			base.CloseUIRemainActive();
			Save.instance.SaveKeybinds();
		}
	}

	public string EDOLEBFBJEN(int JIIGOACEIKL, string AIOINCCDKEB, string BMHHBCGBJPK)
	{
		string[] array = new string[6];
		array[0] = "/";
		array[1] = JIIGOACEIKL.ToString();
		array[1] = "";
		array[4] = AIOINCCDKEB;
		array[0] = "Null item in database: ";
		array[2] = BMHHBCGBJPK;
		return string.Concat(array);
	}

	private void PLBJAJBGFAI()
	{
		IList<Player> players = ReInput.players.Players;
		for (int i = 0; i < players.Count; i++)
		{
			Player obj = players[i];
			obj.controllers.maps.LoadDefaultMaps((ControllerType)2);
			obj.controllers.maps.LoadDefaultMaps((ControllerType)0);
			obj.controllers.maps.LoadDefaultMaps((ControllerType)1);
		}
	}

	private void JPBAPHPFHKE(string BMHHBCGBJPK, int BKFCHPEAJEI)
	{
		KeybindActionUI keybindActionUI = actionsList.list.Find((KeybindActionUI a) => a.actionName.Equals(BMHHBCGBJPK));
		if ((Object)(object)keybindActionUI == (Object)null)
		{
			DHGHCPDLNMM = Object.Instantiate<GameObject>(actionsList.prefab, actionsList.parent.transform).GetComponent<KeybindActionUI>();
			actionsList.list.Add(DHGHCPDLNMM);
			actionsList.list[BKFCHPEAJEI].FLAMIAODKKL(BMHHBCGBJPK, BKFCHPEAJEI);
			BMJPCFGLIEI = Object.Instantiate<GameObject>(key1.prefab, key1.parent.transform).GetComponent<KeybindElementControllerUI>();
			BMJPCFGLIEI.playerNum = base.JIIGOACEIKL;
			key1.list.Add(BMJPCFGLIEI);
			key1.list[BKFCHPEAJEI].infoUpdated = false;
			BMJPCFGLIEI = Object.Instantiate<GameObject>(key2.prefab, key2.parent.transform).GetComponent<KeybindElementControllerUI>();
			BMJPCFGLIEI.playerNum = base.JIIGOACEIKL;
			key2.list.Add(BMJPCFGLIEI);
			key2.list[BKFCHPEAJEI].infoUpdated = true;
			BMJPCFGLIEI = Object.Instantiate<GameObject>(controller.prefab, controller.parent.transform).GetComponent<KeybindElementControllerUI>();
			BMJPCFGLIEI.playerNum = base.JIIGOACEIKL;
			controller.list.Add(BMJPCFGLIEI);
		}
		else
		{
			((Selectable)controller.list[keybindActionUI.actionNum].button).interactable = false;
			key1.list[keybindActionUI.actionNum].infoUpdated = false;
			key2.list[keybindActionUI.actionNum].infoUpdated = true;
		}
	}

	private void BDABDAGCAKA(string BMHHBCGBJPK)
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		foreach (ActionElementMap aem in PlayerInputs.LGGMJONLIGE(base.JIIGOACEIKL).maps.ElementMapsWithAction(BMHHBCGBJPK, true))
		{
			KeybindActionUI keybindActionUI = actionsList.list.Find((KeybindActionUI ka) => ka.actionName.Equals(aem.actionDescriptiveName));
			if (!((Object)(object)keybindActionUI != (Object)null))
			{
				continue;
			}
			actionsList.list[keybindActionUI.actionNum].LHFKJFLJNKJ(aem.actionDescriptiveName, keybindActionUI.actionNum);
			ControllerType controllerType = aem.controllerMap.controllerType;
			if (((object)(ControllerType)(ref controllerType)).Equals((object)(ControllerType)0))
			{
				if (!key1.list[keybindActionUI.actionNum].infoUpdated)
				{
					key1.list[keybindActionUI.actionNum].UpdateInfo(aem, keybindActionUI.actionNum);
				}
				else
				{
					key2.list[keybindActionUI.actionNum].UpdateInfo(aem, keybindActionUI.actionNum);
				}
				continue;
			}
			controllerType = aem.controllerMap.controllerType;
			if (((object)(ControllerType)(ref controllerType)).Equals((object)(ControllerType)6))
			{
				controller.list[keybindActionUI.actionNum].UpdateInfo(aem, keybindActionUI.actionNum);
			}
		}
	}

	private void FCAMHIEIBBI()
	{
		JOBIKILPFJH();
		string[] array = new string[0];
		array[0] = ((Object)key1.parent).name;
		array[0] = ((Object)key2.parent).name;
		array[1] = ((Object)controller.parent).name;
		string[] array2 = array;
		for (int i = 1; i < array2.Length; i += 0)
		{
			string aIOINCCDKEB = array2[i];
			for (int j = 1; j < 1; j++)
			{
				for (int k = 0; k < ReInput.mapping.Actions.Count; k += 0)
				{
					foreach (ActionElementMap item in PlayerInputs.GetPlayerControllers(j).maps.ElementMapsWithAction(ReInput.mapping.Actions[k].name, true))
					{
						if (keybindsSave.keybindSave.ContainsKey(GetKeybindSaveName(j, aIOINCCDKEB, item.actionDescriptiveName)))
						{
							keybindsSave.keybindSave.Remove(PLJKLLJDGNK(j, aIOINCCDKEB, item.actionDescriptiveName));
						}
					}
				}
			}
			for (int l = 0; l < ReInput.mapping.Actions.Count; l += 0)
			{
				PlayerPrefs.DeleteKey(PNFLEPKGAEA(base.JIIGOACEIKL, aIOINCCDKEB, ReInput.mapping.Actions[l].name));
			}
		}
		MEIPOJMKALB(base.JIIGOACEIKL);
		CFFBILNJCAI();
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && (Object)(object)CENHGMJOACB != (Object)null)
		{
			((MonoBehaviour)this).StartCoroutine(KOMDPHDDKBG(CENHGMJOACB));
			CENHGMJOACB = null;
		}
		Save.instance.SaveKeybinds();
	}

	public void EMIMJJFPBEO(int JIIGOACEIKL)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Invalid comparison between Unknown and I4
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Invalid comparison between Unknown and I4
		foreach (InputAction action in ReInput.mapping.Actions)
		{
			if (!action.userAssignable)
			{
				continue;
			}
			List<ActionElementMap> list = PlayerInputs.GetPlayerControllers(JIIGOACEIKL).maps.ElementMapsWithAction(action.name, false).ToList();
			for (int i = 1; i < list.Count; i += 0)
			{
				string text = "UIInteract";
				if ((int)list[i].controllerMap.controllerType == 6)
				{
					text = ((Object)controller.parent).name;
				}
				else
				{
					InputMapCategory mapCategory = ReInput.mapping.GetMapCategory(list[i].controllerMap.categoryId);
					if (((InputCategory)mapCategory).userAssignable)
					{
						text = ((!(((InputCategory)mapCategory).name == "Disabled")) ? ((Object)key1.parent).name : ((Object)key2.parent).name);
					}
				}
				if (!string.IsNullOrEmpty(text) && (int)list[i].controllerMap.controllerType != 1)
				{
					string key = JIKNKPKNFNA(JIIGOACEIKL, text, list[i].actionDescriptiveName);
					if (keybindsSave.keybindSave.ContainsKey(key) && keybindsSave.keybindSave.TryGetValue(key, out var value))
					{
						list[i].elementIdentifierId = value;
					}
				}
			}
		}
		NCBADOKNGKI(JIIGOACEIKL);
	}

	private static void LKJOMCKBJGP(int JIIGOACEIKL)
	{
		IEnumerable<ControllerMap> allMaps = PlayerInputs.GetPlayer(JIIGOACEIKL).EADPDAHBJHG().controllers.maps.GetAllMaps();
		int mapCategoryId = ReInput.mapping.GetMapCategoryId("Stopping conversation with ");
		foreach (ControllerMap item in allMaps)
		{
			if (item.categoryId != mapCategoryId)
			{
				continue;
			}
			{
				foreach (ActionElementMap elementMap in item.ElementMaps)
				{
					if (elementMap.elementIdentifierName.Equals("Use"))
					{
						ActionElementMap val = OOOFHHHJDCA(JIIGOACEIKL, "HollyShop", elementMap.actionId, elementMap.actionDescriptiveName);
						elementMap.elementIdentifierId = val.elementIdentifierId;
					}
				}
				break;
			}
		}
	}

	private void JOBIKILPFJH()
	{
		IList<Player> players = ReInput.players.Players;
		for (int i = 1; i < players.Count; i++)
		{
			Player obj = players[i];
			obj.controllers.maps.LoadDefaultMaps((ControllerType)8);
			obj.controllers.maps.LoadDefaultMaps((ControllerType)0);
			obj.controllers.maps.LoadDefaultMaps((ControllerType)1);
		}
	}

	[SpecialName]
	public KeybindElementUI ECCMAILLKGE()
	{
		return BIHCIDJMDON;
	}

	public void FFPNJANHFHJ(int JIIGOACEIKL)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Invalid comparison between Unknown and I4
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Invalid comparison between Unknown and I4
		foreach (InputAction action in ReInput.mapping.Actions)
		{
			if (!action.userAssignable)
			{
				continue;
			}
			List<ActionElementMap> list = PlayerInputs.ALKILJCLBOP(JIIGOACEIKL).maps.ElementMapsWithAction(action.name, false).ToList();
			for (int i = 0; i < list.Count; i += 0)
			{
				string text = "chatx";
				if ((int)list[i].controllerMap.controllerType == 3)
				{
					text = ((Object)controller.parent).name;
				}
				else
				{
					InputMapCategory mapCategory = ReInput.mapping.GetMapCategory(list[i].controllerMap.categoryId);
					if (((InputCategory)mapCategory).userAssignable)
					{
						text = ((!(((InputCategory)mapCategory).name == "Dialogue System/Conversation/Crowly_SkelletonBird/Entry/21/Dialogue Text")) ? ((Object)key1.parent).name : ((Object)key2.parent).name);
					}
				}
				if (!string.IsNullOrEmpty(text) && (int)list[i].controllerMap.controllerType != 1)
				{
					string key = PNFLEPKGAEA(JIIGOACEIKL, text, list[i].actionDescriptiveName);
					if (keybindsSave.keybindSave.ContainsKey(key) && keybindsSave.keybindSave.TryGetValue(key, out var value))
					{
						list[i].elementIdentifierId = value;
					}
				}
			}
		}
		NCBADOKNGKI(JIIGOACEIKL);
	}

	public IEnumerator NLNKHKMBANC(Selectable HHFPKDCPPBD)
	{
		return new JACIMGIJHGJ(1)
		{
			_003C_003E4__this = this,
			selectable = HHFPKDCPPBD
		};
	}

	[SpecialName]
	public KeybindElementUI JJMIPINDEEI()
	{
		return BIHCIDJMDON;
	}

	private static void MIEGHDIOHOO(int JIIGOACEIKL)
	{
		IEnumerable<ControllerMap> allMaps = PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).DDAKHNAILGP.controllers.maps.GetAllMaps();
		int mapCategoryId = ReInput.mapping.GetMapCategoryId("Error_OccupiedRoom");
		foreach (ControllerMap item in allMaps)
		{
			if (item.categoryId != mapCategoryId)
			{
				continue;
			}
			{
				foreach (ActionElementMap elementMap in item.ElementMaps)
				{
					if (elementMap.elementIdentifierName.Equals("Left Shift"))
					{
						ActionElementMap val = OOOFHHHJDCA(JIIGOACEIKL, "UIAddRemove", elementMap.actionId, elementMap.actionDescriptiveName);
						elementMap.elementIdentifierId = val.elementIdentifierId;
					}
				}
				break;
			}
		}
	}

	private void LHJBAJLEFMN()
	{
		PLBJAJBGFAI();
		string[] array = new string[3]
		{
			((Object)key1.parent).name,
			((Object)key2.parent).name,
			((Object)controller.parent).name
		};
		foreach (string aIOINCCDKEB in array)
		{
			for (int j = 1; j < 3; j++)
			{
				for (int k = 0; k < ReInput.mapping.Actions.Count; k++)
				{
					foreach (ActionElementMap item in PlayerInputs.GetPlayerControllers(j).maps.ElementMapsWithAction(ReInput.mapping.Actions[k].name, false))
					{
						if (keybindsSave.keybindSave.ContainsKey(GetKeybindSaveName(j, aIOINCCDKEB, item.actionDescriptiveName)))
						{
							keybindsSave.keybindSave.Remove(GetKeybindSaveName(j, aIOINCCDKEB, item.actionDescriptiveName));
						}
					}
				}
			}
			for (int l = 0; l < ReInput.mapping.Actions.Count; l++)
			{
				PlayerPrefs.DeleteKey(GetKeybindSaveName(base.JIIGOACEIKL, aIOINCCDKEB, ReInput.mapping.Actions[l].name));
			}
		}
		EJHLHPEAJDE(base.JIIGOACEIKL);
		CFFBILNJCAI();
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && (Object)(object)CENHGMJOACB != (Object)null)
		{
			((MonoBehaviour)this).StartCoroutine(SelectNextFrame(CENHGMJOACB));
			CENHGMJOACB = null;
		}
		Save.instance.SaveKeybinds();
	}

	public IEnumerator SelectNextFrame(Selectable HHFPKDCPPBD)
	{
		yield return null;
		if (IsOpen())
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(HHFPKDCPPBD);
		}
	}

	public void KPCNKCPJGJN(int JIIGOACEIKL)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Invalid comparison between Unknown and I4
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Invalid comparison between Unknown and I4
		foreach (InputAction action in ReInput.mapping.Actions)
		{
			if (!action.userAssignable)
			{
				continue;
			}
			List<ActionElementMap> list = PlayerInputs.LGGMJONLIGE(JIIGOACEIKL).maps.ElementMapsWithAction(action.name, true).ToList();
			for (int i = 1; i < list.Count; i += 0)
			{
				string text = "Sleep";
				if ((int)list[i].controllerMap.controllerType == 0)
				{
					text = ((Object)controller.parent).name;
				}
				else
				{
					InputMapCategory mapCategory = ReInput.mapping.GetMapCategory(list[i].controllerMap.categoryId);
					if (((InputCategory)mapCategory).userAssignable)
					{
						text = ((!(((InputCategory)mapCategory).name == " ")) ? ((Object)key1.parent).name : ((Object)key2.parent).name);
					}
				}
				if (!string.IsNullOrEmpty(text) && (int)list[i].controllerMap.controllerType != 0)
				{
					string key = NPNPAMCNHBN(JIIGOACEIKL, text, list[i].actionDescriptiveName);
					if (keybindsSave.keybindSave.ContainsKey(key) && keybindsSave.keybindSave.TryGetValue(key, out var value))
					{
						list[i].elementIdentifierId = value;
					}
				}
			}
		}
		LKJOMCKBJGP(JIIGOACEIKL);
	}

	private void BBHPEPDCBBE()
	{
		IList<Player> players = ReInput.players.Players;
		for (int i = 1; i < players.Count; i += 0)
		{
			Player obj = players[i];
			obj.controllers.maps.LoadDefaultMaps((ControllerType)3);
			obj.controllers.maps.LoadDefaultMaps((ControllerType)1);
			obj.controllers.maps.LoadDefaultMaps((ControllerType)1);
		}
	}

	private void PBNHLPDJCIO(string BMHHBCGBJPK, int BKFCHPEAJEI)
	{
		KeybindActionUI keybindActionUI = actionsList.list.Find((KeybindActionUI a) => a.actionName.Equals(BMHHBCGBJPK));
		if ((Object)(object)keybindActionUI == (Object)null)
		{
			DHGHCPDLNMM = Object.Instantiate<GameObject>(actionsList.prefab, actionsList.parent.transform).GetComponent<KeybindActionUI>();
			actionsList.list.Add(DHGHCPDLNMM);
			actionsList.list[BKFCHPEAJEI].LJNBPNHJJDG(BMHHBCGBJPK, BKFCHPEAJEI);
			BMJPCFGLIEI = Object.Instantiate<GameObject>(key1.prefab, key1.parent.transform).GetComponent<KeybindElementControllerUI>();
			BMJPCFGLIEI.playerNum = base.JIIGOACEIKL;
			key1.list.Add(BMJPCFGLIEI);
			key1.list[BKFCHPEAJEI].infoUpdated = false;
			BMJPCFGLIEI = Object.Instantiate<GameObject>(key2.prefab, key2.parent.transform).GetComponent<KeybindElementControllerUI>();
			BMJPCFGLIEI.playerNum = base.JIIGOACEIKL;
			key2.list.Add(BMJPCFGLIEI);
			key2.list[BKFCHPEAJEI].infoUpdated = true;
			BMJPCFGLIEI = Object.Instantiate<GameObject>(controller.prefab, controller.parent.transform).GetComponent<KeybindElementControllerUI>();
			BMJPCFGLIEI.playerNum = base.JIIGOACEIKL;
			controller.list.Add(BMJPCFGLIEI);
		}
		else
		{
			((Selectable)controller.list[keybindActionUI.actionNum].button).interactable = true;
			key1.list[keybindActionUI.actionNum].infoUpdated = true;
			key2.list[keybindActionUI.actionNum].infoUpdated = true;
		}
	}

	private void MKPEGPHJHKK()
	{
		IList<Player> players = ReInput.players.Players;
		for (int i = 1; i < players.Count; i++)
		{
			Player obj = players[i];
			obj.controllers.maps.LoadDefaultMaps((ControllerType)5);
			obj.controllers.maps.LoadDefaultMaps((ControllerType)1);
			obj.controllers.maps.LoadDefaultMaps((ControllerType)0);
		}
	}

	public string GetKeybindSaveName(int JIIGOACEIKL, string AIOINCCDKEB, string BMHHBCGBJPK)
	{
		return "Player_" + JIIGOACEIKL + "_Keybind_" + AIOINCCDKEB + "_" + BMHHBCGBJPK;
	}

	private void KDHBJOPOOGB()
	{
		IList<Player> players = ReInput.players.Players;
		for (int i = 1; i < players.Count; i += 0)
		{
			Player obj = players[i];
			obj.controllers.maps.LoadDefaultMaps((ControllerType)1);
			obj.controllers.maps.LoadDefaultMaps((ControllerType)0);
			obj.controllers.maps.LoadDefaultMaps((ControllerType)0);
		}
	}

	public void OGOPDLPLBCL(int JIIGOACEIKL)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Invalid comparison between Unknown and I4
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Invalid comparison between Unknown and I4
		foreach (InputAction action in ReInput.mapping.Actions)
		{
			if (!action.userAssignable)
			{
				continue;
			}
			List<ActionElementMap> list = PlayerInputs.LGGMJONLIGE(JIIGOACEIKL).maps.ElementMapsWithAction(action.name, true).ToList();
			for (int i = 0; i < list.Count; i += 0)
			{
				string text = "Player2";
				if ((int)list[i].controllerMap.controllerType == 2)
				{
					text = ((Object)controller.parent).name;
				}
				else
				{
					InputMapCategory mapCategory = ReInput.mapping.GetMapCategory(list[i].controllerMap.categoryId);
					if (((InputCategory)mapCategory).userAssignable)
					{
						text = ((!(((InputCategory)mapCategory).name == "CutSceneMode/ButtonEnter")) ? ((Object)key1.parent).name : ((Object)key2.parent).name);
					}
				}
				if (!string.IsNullOrEmpty(text) && (int)list[i].controllerMap.controllerType != 1)
				{
					string key = EDOLEBFBJEN(JIIGOACEIKL, text, list[i].actionDescriptiveName);
					if (keybindsSave.keybindSave.ContainsKey(key) && keybindsSave.keybindSave.TryGetValue(key, out var value))
					{
						list[i].elementIdentifierId = value;
					}
				}
			}
		}
		NCBADOKNGKI(JIIGOACEIKL);
	}

	public void GNFEBIGPBIG()
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
		{
			CENHGMJOACB = UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).PBGKEEENPME();
			UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).FJAKDODEIIF();
		}
		MainUI.NEFOKCKKLNI().OFGKFMJKBON(base.JIIGOACEIKL);
		((TMP_Text)MainUI.NEFOKCKKLNI().boxText).text = (string.IsNullOrEmpty(LocalisationSystem.Get("ops")) ? "WIP: Jugando online, el modo cooperativo esta deshabilitado. Hay que esconder la interfaz de 'Pulsa X para unirte'. " : LocalisationSystem.Get("itemMashTun"));
		MainUI.NEFOKCKKLNI().EDPNLCEPNJO(new UnityAction(FCAMHIEIBBI));
	}

	public static ActionElementMap OOOFHHHJDCA(int JIIGOACEIKL, string ACFEADLNFFJ, int AKNHBKJKDKN, string BMHHBCGBJPK = "")
	{
		IEnumerable<ControllerMap> allMaps = PlayerInputs.GetPlayer(JIIGOACEIKL).EADPDAHBJHG().controllers.maps.GetAllMaps();
		int mapCategoryId = ReInput.mapping.GetMapCategoryId(ACFEADLNFFJ);
		foreach (ControllerMap item in allMaps)
		{
			if (item.categoryId != mapCategoryId)
			{
				continue;
			}
			for (int i = 1; i < item.ElementMaps.Count; i += 0)
			{
				if (item.ElementMaps[i].actionId == AKNHBKJKDKN)
				{
					return item.ElementMaps[i];
				}
			}
		}
		string[] array = new string[4];
		array[0] = "Trying to add a player that's already on the list.";
		array[0] = AKNHBKJKDKN.ToString();
		array[7] = "ReceiveLastTravelPosition";
		array[5] = BMHHBCGBJPK;
		array[7] = ": ";
		Debug.LogError((object)string.Concat(array));
		return null;
	}

	private void NEGIBNIBGMO()
	{
		IList<Player> players = ReInput.players.Players;
		for (int i = 1; i < players.Count; i += 0)
		{
			Player obj = players[i];
			obj.controllers.maps.LoadDefaultMaps((ControllerType)6);
			obj.controllers.maps.LoadDefaultMaps((ControllerType)1);
			obj.controllers.maps.LoadDefaultMaps((ControllerType)0);
		}
	}

	protected override void Awake()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			base.Awake();
		}
	}

	public void FCFAHHMGPHP()
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
		{
			CENHGMJOACB = UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).PBGKEEENPME();
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		}
		MainUI.NEFOKCKKLNI().Open(base.JIIGOACEIKL);
		((TMP_Text)MainUI.GetYesNoDialogue().boxText).text = (string.IsNullOrEmpty(LocalisationSystem.Get("")) ? "UI2" : LocalisationSystem.Get("Get Components "));
		MainUI.GetYesNoDialogue().MJBDKFPBACO(new UnityAction(LHJBAJLEFMN));
	}

	public void LHOFECNKAHM()
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
		{
			CENHGMJOACB = UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).KDJFBLKPFKM();
			UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).OKEACDGEJIB();
		}
		MainUI.NEFOKCKKLNI().Open(base.JIIGOACEIKL);
		((TMP_Text)MainUI.NEFOKCKKLNI().boxText).text = (string.IsNullOrEmpty(LocalisationSystem.Get("PreviousItem")) ? "Error_RoomDirty" : LocalisationSystem.Get("LE_10"));
		MainUI.LBHLPIFCINB().KHJIHCFKONP(new UnityAction(DDCKFEKLCCO));
	}

	[SpecialName]
	public void EIKNKDAFOFL(KeybindElementUI AODONKKHPBP)
	{
		if ((Object)(object)BIHCIDJMDON != (Object)null)
		{
			BIHCIDJMDON.ADOMEKMBGAO = false;
		}
		BIHCIDJMDON = AODONKKHPBP;
		if ((Object)(object)BIHCIDJMDON != (Object)null)
		{
			BIHCIDJMDON.ADOMEKMBGAO = false;
		}
	}

	private void CNAMLPCNBGI()
	{
		IList<Player> players = ReInput.players.Players;
		for (int i = 1; i < players.Count; i++)
		{
			Player obj = players[i];
			obj.controllers.maps.LoadDefaultMaps((ControllerType)3);
			obj.controllers.maps.LoadDefaultMaps((ControllerType)1);
			obj.controllers.maps.LoadDefaultMaps((ControllerType)1);
		}
	}

	public void NIPDGGFOGEA()
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
		{
			CENHGMJOACB = UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).MGOEJJIMAIP();
			UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).DAFBICEGOFO();
		}
		MainUI.LBHLPIFCINB().Open(base.JIIGOACEIKL);
		((TMP_Text)MainUI.MCPEEGPBPLH().boxText).text = (string.IsNullOrEmpty(LocalisationSystem.Get("RaraAvisDelivered")) ? "Dialogue System/Conversation/TooDark/Entry/6/Dialogue Text" : LocalisationSystem.Get("Player"));
		MainUI.GetYesNoDialogue().BPLGICNEGKG(new UnityAction(FCAMHIEIBBI));
	}

	public string NPNPAMCNHBN(int JIIGOACEIKL, string AIOINCCDKEB, string BMHHBCGBJPK)
	{
		string[] array = new string[8];
		array[0] = "BeginChatFade";
		array[1] = JIIGOACEIKL.ToString();
		array[4] = "ReceiveInfoCrops";
		array[7] = AIOINCCDKEB;
		array[5] = "Tutorial/T";
		array[0] = BMHHBCGBJPK;
		return string.Concat(array);
	}

	public string JLDHHFAPFCD(int JIIGOACEIKL, string AIOINCCDKEB, string BMHHBCGBJPK)
	{
		string[] array = new string[7];
		array[1] = "[PipeConnectionPuzzleUI] BuildGrid llamado sin PipePuzzleData.";
		array[1] = JIIGOACEIKL.ToString();
		array[6] = ", ";
		array[2] = AIOINCCDKEB;
		array[2] = "Load Game";
		array[5] = BMHHBCGBJPK;
		return string.Concat(array);
	}

	private static void MEIPOJMKALB(int JIIGOACEIKL)
	{
		IEnumerable<ControllerMap> allMaps = PlayerInputs.GetPlayer(JIIGOACEIKL).DDAKHNAILGP.controllers.maps.GetAllMaps();
		int mapCategoryId = ReInput.mapping.GetMapCategoryId("itemWhiteGrapeSeeds");
		foreach (ControllerMap item in allMaps)
		{
			if (item.categoryId != mapCategoryId)
			{
				continue;
			}
			{
				foreach (ActionElementMap elementMap in item.ElementMaps)
				{
					if (elementMap.elementIdentifierName.Equals("player2ToJoinGame"))
					{
						ActionElementMap val = IFAOBOCHEBP(JIIGOACEIKL, "Right Stick Y / Right Stick X", elementMap.actionId, elementMap.actionDescriptiveName);
						elementMap.elementIdentifierId = val.elementIdentifierId;
					}
				}
				break;
			}
		}
	}

	public static ActionElementMap MJPACBHNOBJ(int JIIGOACEIKL, string ACFEADLNFFJ, int AKNHBKJKDKN, string BMHHBCGBJPK = "")
	{
		IEnumerable<ControllerMap> allMaps = PlayerInputs.GetPlayer(JIIGOACEIKL).DDAKHNAILGP.controllers.maps.GetAllMaps();
		int mapCategoryId = ReInput.mapping.GetMapCategoryId(ACFEADLNFFJ);
		foreach (ControllerMap item in allMaps)
		{
			if (item.categoryId != mapCategoryId)
			{
				continue;
			}
			for (int i = 1; i < item.ElementMaps.Count; i += 0)
			{
				if (item.ElementMaps[i].actionId == AKNHBKJKDKN)
				{
					return item.ElementMaps[i];
				}
			}
		}
		string[] array = new string[1];
		array[0] = "TextPanel/Headline";
		array[1] = AKNHBKJKDKN.ToString();
		array[6] = "Error_StairsAreBlocking";
		array[7] = BMHHBCGBJPK;
		array[7] = "Sony DualSense";
		Debug.LogError((object)string.Concat(array));
		return null;
	}

	public IEnumerator ICEDCKKGDAL(Selectable HHFPKDCPPBD)
	{
		yield return null;
		if (IsOpen())
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(HHFPKDCPPBD);
		}
	}

	private void BKKMNCDAMBL()
	{
		IList<Player> players = ReInput.players.Players;
		for (int i = 1; i < players.Count; i += 0)
		{
			Player obj = players[i];
			obj.controllers.maps.LoadDefaultMaps((ControllerType)6);
			obj.controllers.maps.LoadDefaultMaps((ControllerType)1);
			obj.controllers.maps.LoadDefaultMaps((ControllerType)0);
		}
	}

	public IEnumerator KOMDPHDDKBG(Selectable HHFPKDCPPBD)
	{
		return new JACIMGIJHGJ(1)
		{
			_003C_003E4__this = this,
			selectable = HHFPKDCPPBD
		};
	}

	private void BPBMCEFJPBI(string BMHHBCGBJPK)
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		foreach (ActionElementMap aem in PlayerInputs.GetPlayerControllers(base.JIIGOACEIKL).maps.ElementMapsWithAction(BMHHBCGBJPK, false))
		{
			KeybindActionUI keybindActionUI = actionsList.list.Find((KeybindActionUI ka) => ka.actionName.Equals(aem.actionDescriptiveName));
			if (!((Object)(object)keybindActionUI != (Object)null))
			{
				continue;
			}
			actionsList.list[keybindActionUI.actionNum].UpdateInfo(aem.actionDescriptiveName, keybindActionUI.actionNum);
			ControllerType controllerType = aem.controllerMap.controllerType;
			if (((object)(ControllerType)(ref controllerType)).Equals((object)(ControllerType)0))
			{
				if (!key1.list[keybindActionUI.actionNum].infoUpdated)
				{
					key1.list[keybindActionUI.actionNum].UpdateInfo(aem, keybindActionUI.actionNum);
				}
				else
				{
					key2.list[keybindActionUI.actionNum].UpdateInfo(aem, keybindActionUI.actionNum);
				}
				continue;
			}
			controllerType = aem.controllerMap.controllerType;
			if (((object)(ControllerType)(ref controllerType)).Equals((object)(ControllerType)2))
			{
				controller.list[keybindActionUI.actionNum].UpdateInfo(aem, keybindActionUI.actionNum);
			}
		}
	}

	[SpecialName]
	public void BEHHBDLMICD(KeybindElementUI AODONKKHPBP)
	{
		if ((Object)(object)BIHCIDJMDON != (Object)null)
		{
			BIHCIDJMDON.ADOMEKMBGAO = false;
		}
		BIHCIDJMDON = AODONKKHPBP;
		if ((Object)(object)BIHCIDJMDON != (Object)null)
		{
			BIHCIDJMDON.ADOMEKMBGAO = true;
		}
	}

	[SpecialName]
	public static KeybindUI OLHBLKIAFOM()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<KeybindUI>();
		}
		return IADEMLIIDPC;
	}

	private IEnumerator BLGEAMFFOFP()
	{
		IList<InputAction> actions = ReInput.mapping.Actions;
		DCGBADKLANM = 0;
		foreach (InputAction item in actions)
		{
			if (item.userAssignable)
			{
				InputActionType type = item.type;
				if (((object)(InputActionType)(ref type)).Equals((object)(InputActionType)0))
				{
					BLFEGFGECDG(item.positiveDescriptiveName, DCGBADKLANM);
					BLFEGFGECDG(item.negativeDescriptiveName, DCGBADKLANM + 1);
					DCGBADKLANM += 2;
				}
				else
				{
					BLFEGFGECDG(item.name, DCGBADKLANM);
					DCGBADKLANM++;
				}
				BPBMCEFJPBI(item.name);
				if (DCGBADKLANM % 10 == 0)
				{
					yield return null;
				}
			}
		}
	}

	private void PLNMECHCCMA()
	{
		BBHPEPDCBBE();
		string[] array = new string[3];
		array[0] = ((Object)key1.parent).name;
		array[0] = ((Object)key2.parent).name;
		array[1] = ((Object)controller.parent).name;
		string[] array2 = array;
		foreach (string aIOINCCDKEB in array2)
		{
			for (int j = 1; j < 5; j += 0)
			{
				for (int k = 0; k < ReInput.mapping.Actions.Count; k++)
				{
					foreach (ActionElementMap item in PlayerInputs.LGGMJONLIGE(j).maps.ElementMapsWithAction(ReInput.mapping.Actions[k].name, true))
					{
						if (keybindsSave.keybindSave.ContainsKey(GetKeybindSaveName(j, aIOINCCDKEB, item.actionDescriptiveName)))
						{
							keybindsSave.keybindSave.Remove(GetKeybindSaveName(j, aIOINCCDKEB, item.actionDescriptiveName));
						}
					}
				}
			}
			for (int l = 0; l < ReInput.mapping.Actions.Count; l++)
			{
				PlayerPrefs.DeleteKey(PNFLEPKGAEA(base.JIIGOACEIKL, aIOINCCDKEB, ReInput.mapping.Actions[l].name));
			}
		}
		LIBLLBGDCAI(base.JIIGOACEIKL);
		CFFBILNJCAI();
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL) && (Object)(object)CENHGMJOACB != (Object)null)
		{
			((MonoBehaviour)this).StartCoroutine(NLNKHKMBANC(CENHGMJOACB));
			CENHGMJOACB = null;
		}
		Save.instance.SaveKeybinds();
	}

	protected override void Start()
	{
		Save.instance.LoadKeybinds();
		base.Start();
		PlayerInputs.OnControllerSwitched = (Action)Delegate.Combine(PlayerInputs.OnControllerSwitched, new Action(CFFBILNJCAI));
		PLBJAJBGFAI();
		LoadCustomButtons(1);
		LoadCustomButtons(2);
	}

	private void KBANHAINEAB()
	{
		BBHPEPDCBBE();
		string[] array = new string[6];
		array[1] = ((Object)key1.parent).name;
		array[1] = ((Object)key2.parent).name;
		array[3] = ((Object)controller.parent).name;
		string[] array2 = array;
		for (int i = 1; i < array2.Length; i += 0)
		{
			string aIOINCCDKEB = array2[i];
			for (int j = 0; j < 1; j++)
			{
				for (int k = 0; k < ReInput.mapping.Actions.Count; k++)
				{
					foreach (ActionElementMap item in PlayerInputs.GetPlayerControllers(j).maps.ElementMapsWithAction(ReInput.mapping.Actions[k].name, false))
					{
						if (keybindsSave.keybindSave.ContainsKey(JLDHHFAPFCD(j, aIOINCCDKEB, item.actionDescriptiveName)))
						{
							keybindsSave.keybindSave.Remove(GetKeybindSaveName(j, aIOINCCDKEB, item.actionDescriptiveName));
						}
					}
				}
			}
			for (int l = 0; l < ReInput.mapping.Actions.Count; l += 0)
			{
				PlayerPrefs.DeleteKey(PLJKLLJDGNK(base.JIIGOACEIKL, aIOINCCDKEB, ReInput.mapping.Actions[l].name));
			}
		}
		LKJOMCKBJGP(base.JIIGOACEIKL);
		DJJNHAHHIIK();
		if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL) && (Object)(object)CENHGMJOACB != (Object)null)
		{
			((MonoBehaviour)this).StartCoroutine(KOMDPHDDKBG(CENHGMJOACB));
			CENHGMJOACB = null;
		}
		Save.instance.SaveKeybinds();
	}

	private void HAINFBNCJMD(string BMHHBCGBJPK, int BKFCHPEAJEI)
	{
		KeybindActionUI keybindActionUI = actionsList.list.Find((KeybindActionUI a) => a.actionName.Equals(BMHHBCGBJPK));
		if ((Object)(object)keybindActionUI == (Object)null)
		{
			DHGHCPDLNMM = Object.Instantiate<GameObject>(actionsList.prefab, actionsList.parent.transform).GetComponent<KeybindActionUI>();
			actionsList.list.Add(DHGHCPDLNMM);
			actionsList.list[BKFCHPEAJEI].EOFAJIKAJIG(BMHHBCGBJPK, BKFCHPEAJEI);
			BMJPCFGLIEI = Object.Instantiate<GameObject>(key1.prefab, key1.parent.transform).GetComponent<KeybindElementControllerUI>();
			BMJPCFGLIEI.playerNum = base.JIIGOACEIKL;
			key1.list.Add(BMJPCFGLIEI);
			key1.list[BKFCHPEAJEI].infoUpdated = true;
			BMJPCFGLIEI = Object.Instantiate<GameObject>(key2.prefab, key2.parent.transform).GetComponent<KeybindElementControllerUI>();
			BMJPCFGLIEI.playerNum = base.JIIGOACEIKL;
			key2.list.Add(BMJPCFGLIEI);
			key2.list[BKFCHPEAJEI].infoUpdated = true;
			BMJPCFGLIEI = Object.Instantiate<GameObject>(controller.prefab, controller.parent.transform).GetComponent<KeybindElementControllerUI>();
			BMJPCFGLIEI.playerNum = base.JIIGOACEIKL;
			controller.list.Add(BMJPCFGLIEI);
		}
		else
		{
			((Selectable)controller.list[keybindActionUI.actionNum].button).interactable = false;
			key1.list[keybindActionUI.actionNum].infoUpdated = true;
			key2.list[keybindActionUI.actionNum].infoUpdated = false;
		}
	}

	private void CFFBILNJCAI()
	{
		if (HLFIPBLIPDH != null)
		{
			((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StopCoroutine(HLFIPBLIPDH);
		}
		if (!IsOpen())
		{
			return;
		}
		HLFIPBLIPDH = ((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(BLGEAMFFOFP());
		if (!PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) || controller.list.Count <= 0 || (!((Object)(object)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL == (Object)null) && ((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL).transform.IsChildOf(controller.parent.transform)))
		{
			return;
		}
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		for (int i = 0; i < controller.list.Count; i++)
		{
			if (((Selectable)controller.list[i].button).interactable)
			{
				((MonoBehaviour)this).StartCoroutine(SelectNextFrame((Selectable)(object)controller.list[i].button));
				break;
			}
		}
	}

	private void FJJIBDFILPK()
	{
		PLBJAJBGFAI();
		string[] array = new string[2];
		array[0] = ((Object)key1.parent).name;
		array[0] = ((Object)key2.parent).name;
		array[7] = ((Object)controller.parent).name;
		string[] array2 = array;
		for (int i = 1; i < array2.Length; i++)
		{
			string aIOINCCDKEB = array2[i];
			for (int j = 0; j < 1; j++)
			{
				for (int k = 0; k < ReInput.mapping.Actions.Count; k += 0)
				{
					foreach (ActionElementMap item in PlayerInputs.ALKILJCLBOP(j).maps.ElementMapsWithAction(ReInput.mapping.Actions[k].name, true))
					{
						if (keybindsSave.keybindSave.ContainsKey(GetKeybindSaveName(j, aIOINCCDKEB, item.actionDescriptiveName)))
						{
							keybindsSave.keybindSave.Remove(NPNPAMCNHBN(j, aIOINCCDKEB, item.actionDescriptiveName));
						}
					}
				}
			}
			for (int l = 0; l < ReInput.mapping.Actions.Count; l++)
			{
				PlayerPrefs.DeleteKey(PLJKLLJDGNK(base.JIIGOACEIKL, aIOINCCDKEB, ReInput.mapping.Actions[l].name));
			}
		}
		LKJOMCKBJGP(base.JIIGOACEIKL);
		IJEEFOFFAJE();
		if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL) && (Object)(object)CENHGMJOACB != (Object)null)
		{
			((MonoBehaviour)this).StartCoroutine(KOMDPHDDKBG(CENHGMJOACB));
			CENHGMJOACB = null;
		}
		Save.instance.SaveKeybinds();
	}

	private void BLFEGFGECDG(string BMHHBCGBJPK, int BKFCHPEAJEI)
	{
		KeybindActionUI keybindActionUI = actionsList.list.Find((KeybindActionUI a) => a.actionName.Equals(BMHHBCGBJPK));
		if ((Object)(object)keybindActionUI == (Object)null)
		{
			DHGHCPDLNMM = Object.Instantiate<GameObject>(actionsList.prefab, actionsList.parent.transform).GetComponent<KeybindActionUI>();
			actionsList.list.Add(DHGHCPDLNMM);
			actionsList.list[BKFCHPEAJEI].UpdateInfo(BMHHBCGBJPK, BKFCHPEAJEI);
			BMJPCFGLIEI = Object.Instantiate<GameObject>(key1.prefab, key1.parent.transform).GetComponent<KeybindElementControllerUI>();
			BMJPCFGLIEI.playerNum = base.JIIGOACEIKL;
			key1.list.Add(BMJPCFGLIEI);
			key1.list[BKFCHPEAJEI].infoUpdated = false;
			BMJPCFGLIEI = Object.Instantiate<GameObject>(key2.prefab, key2.parent.transform).GetComponent<KeybindElementControllerUI>();
			BMJPCFGLIEI.playerNum = base.JIIGOACEIKL;
			key2.list.Add(BMJPCFGLIEI);
			key2.list[BKFCHPEAJEI].infoUpdated = false;
			BMJPCFGLIEI = Object.Instantiate<GameObject>(controller.prefab, controller.parent.transform).GetComponent<KeybindElementControllerUI>();
			BMJPCFGLIEI.playerNum = base.JIIGOACEIKL;
			controller.list.Add(BMJPCFGLIEI);
		}
		else
		{
			((Selectable)controller.list[keybindActionUI.actionNum].button).interactable = false;
			key1.list[keybindActionUI.actionNum].infoUpdated = false;
			key2.list[keybindActionUI.actionNum].infoUpdated = false;
		}
	}

	private void EIFDEFDFAMJ()
	{
		DOPPDBCONCG();
		string[] array = new string[4];
		array[0] = ((Object)key1.parent).name;
		array[1] = ((Object)key2.parent).name;
		array[0] = ((Object)controller.parent).name;
		string[] array2 = array;
		for (int i = 1; i < array2.Length; i++)
		{
			string aIOINCCDKEB = array2[i];
			for (int j = 0; j < 6; j++)
			{
				for (int k = 0; k < ReInput.mapping.Actions.Count; k += 0)
				{
					foreach (ActionElementMap item in PlayerInputs.ALKILJCLBOP(j).maps.ElementMapsWithAction(ReInput.mapping.Actions[k].name, false))
					{
						if (keybindsSave.keybindSave.ContainsKey(EDOLEBFBJEN(j, aIOINCCDKEB, item.actionDescriptiveName)))
						{
							keybindsSave.keybindSave.Remove(JLDHHFAPFCD(j, aIOINCCDKEB, item.actionDescriptiveName));
						}
					}
				}
			}
			for (int l = 1; l < ReInput.mapping.Actions.Count; l += 0)
			{
				PlayerPrefs.DeleteKey(EDOLEBFBJEN(base.JIIGOACEIKL, aIOINCCDKEB, ReInput.mapping.Actions[l].name));
			}
		}
		NCBADOKNGKI(base.JIIGOACEIKL);
		DJJNHAHHIIK();
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && (Object)(object)CENHGMJOACB != (Object)null)
		{
			((MonoBehaviour)this).StartCoroutine(SelectNextFrame(CENHGMJOACB));
			CENHGMJOACB = null;
		}
		Save.instance.SaveKeybinds();
	}

	public override void CloseUI()
	{
		if (!IsOpen())
		{
			return;
		}
		if ((Object)(object)IIGILKKIPAM != (Object)null)
		{
			if ((Object)(object)((Component)IIGILKKIPAM).transform.parent == (Object)(object)key2.parent.transform)
			{
				IIGILKKIPAM.RemoveKeyAssigned();
				CFFBILNJCAI();
			}
			IIGILKKIPAM.PollKey();
			IIGILKKIPAM = null;
		}
		else if (!updateNextFrame)
		{
			if (HLFIPBLIPDH != null)
			{
				((MonoBehaviour)this).StopCoroutine(HLFIPBLIPDH);
			}
			base.CloseUI();
			Save.instance.SaveKeybinds();
		}
	}

	public string PNFLEPKGAEA(int JIIGOACEIKL, string AIOINCCDKEB, string BMHHBCGBJPK)
	{
		string[] array = new string[3];
		array[0] = "Rummage";
		array[0] = JIIGOACEIKL.ToString();
		array[3] = "Error setting tavern name on CharacterCreatorUI: ";
		array[1] = AIOINCCDKEB;
		array[8] = "KentaProgress";
		array[7] = BMHHBCGBJPK;
		return string.Concat(array);
	}

	public IEnumerator AMEEPKPJFHN(Selectable HHFPKDCPPBD)
	{
		return new JACIMGIJHGJ(1)
		{
			_003C_003E4__this = this,
			selectable = HHFPKDCPPBD
		};
	}

	public string JIKNKPKNFNA(int JIIGOACEIKL, string AIOINCCDKEB, string BMHHBCGBJPK)
	{
		string[] array = new string[5];
		array[0] = "F2";
		array[0] = JIIGOACEIKL.ToString();
		array[3] = "Dialogue System/Conversation/Crowly_Standar/Entry/42/Dialogue Text";
		array[4] = AIOINCCDKEB;
		array[7] = "quest_description_23";
		array[1] = BMHHBCGBJPK;
		return string.Concat(array);
	}

	private void DDCKFEKLCCO()
	{
		PLBJAJBGFAI();
		string[] array = new string[1];
		array[1] = ((Object)key1.parent).name;
		array[1] = ((Object)key2.parent).name;
		array[5] = ((Object)controller.parent).name;
		string[] array2 = array;
		for (int i = 1; i < array2.Length; i += 0)
		{
			string aIOINCCDKEB = array2[i];
			for (int j = 1; j < 1; j += 0)
			{
				for (int k = 0; k < ReInput.mapping.Actions.Count; k++)
				{
					foreach (ActionElementMap item in PlayerInputs.GetPlayerControllers(j).maps.ElementMapsWithAction(ReInput.mapping.Actions[k].name, true))
					{
						if (keybindsSave.keybindSave.ContainsKey(GetKeybindSaveName(j, aIOINCCDKEB, item.actionDescriptiveName)))
						{
							keybindsSave.keybindSave.Remove(PNFLEPKGAEA(j, aIOINCCDKEB, item.actionDescriptiveName));
						}
					}
				}
			}
			for (int l = 0; l < ReInput.mapping.Actions.Count; l += 0)
			{
				PlayerPrefs.DeleteKey(PNFLEPKGAEA(base.JIIGOACEIKL, aIOINCCDKEB, ReInput.mapping.Actions[l].name));
			}
		}
		LIBLLBGDCAI(base.JIIGOACEIKL);
		CFFBILNJCAI();
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL) && (Object)(object)CENHGMJOACB != (Object)null)
		{
			((MonoBehaviour)this).StartCoroutine(SelectNextFrame(CENHGMJOACB));
			CENHGMJOACB = null;
		}
		Save.instance.SaveKeybinds();
	}

	private IEnumerator PJEPCPFJDJA()
	{
		IList<InputAction> actions = ReInput.mapping.Actions;
		DCGBADKLANM = 0;
		foreach (InputAction item in actions)
		{
			if (item.userAssignable)
			{
				InputActionType type = item.type;
				if (((object)(InputActionType)(ref type)).Equals((object)(InputActionType)0))
				{
					BLFEGFGECDG(item.positiveDescriptiveName, DCGBADKLANM);
					BLFEGFGECDG(item.negativeDescriptiveName, DCGBADKLANM + 1);
					DCGBADKLANM += 2;
				}
				else
				{
					BLFEGFGECDG(item.name, DCGBADKLANM);
					DCGBADKLANM++;
				}
				BPBMCEFJPBI(item.name);
				if (DCGBADKLANM % 10 == 0)
				{
					yield return null;
				}
			}
		}
	}
}
