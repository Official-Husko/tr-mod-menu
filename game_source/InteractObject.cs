using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class InteractObject : MonoBehaviour
{
	private static InteractObject[] GJBBNHCMNJN = new InteractObject[5];

	public Action OnClickOffUI = delegate
	{
	};

	public Action<List<IInteractable>> OnClick = delegate
	{
	};

	public Action<int> Interacted = delegate
	{
	};

	private List<IInteractable> FEOLIFGHOJE = new List<IInteractable>();

	private GameObject EOGLOFLIMNA;

	private bool HCDAAJKPGBM = true;

	public static float heldTime = 0.25f;

	private float DDMEOCCJBGG;

	[SerializeField]
	private bool _holding;

	[SerializeField]
	private bool actionDone;

	public GameObject interactingObject;

	private PlayerController PKCHNBPBHFL;

	private int JIIGOACEIKL;

	private bool NKMCOOCDNCG;

	private GameObject PCCHCFJCFOD;

	public Table table;

	private Table OEMEKMEAHLJ;

	private Placeable HMBOBOMFBBC;

	private bool OHCDBMNHBCG;

	private InputByProximity LFBNPHHABDK;

	private MonoBehaviour[] CENALNOKJCE;

	private List<IInteractable> COOCCFAOKOC;

	private OnlineObject NKJHFIDLEMN;

	public bool FGNLIEANHLB { get; private set; }

	public bool MBNAPBJGBHD { get; set; }

	public bool KBPGGKMPKHL { get; set; }

	public bool KOHOJLBBENG
	{
		get
		{
			return _holding;
		}
		set
		{
			if (_holding != value)
			{
				_holding = value;
			}
		}
	}

	private void OnDisable()
	{
		if ((Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnTravelStart = (Action<int>)Delegate.Remove(instance.OnTravelStart, new Action<int>(ILMBKIBPDAP));
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnTravelFinish = (Action<int>)Delegate.Remove(instance2.OnTravelFinish, new Action<int>(EMBJOGHMJAJ));
			CommonReferences instance3 = CommonReferences.GGFJGHHHEJC;
			instance3.OnPlayerSleep = (Action)Delegate.Remove(instance3.OnPlayerSleep, new Action(DisableInteract));
			CommonReferences instance4 = CommonReferences.GGFJGHHHEJC;
			instance4.OnPlayerPassout = (Action)Delegate.Remove(instance4.OnPlayerPassout, new Action(DisableInteract));
			CommonReferences instance5 = CommonReferences.GGFJGHHHEJC;
			instance5.OnPlayerAwake = (Action)Delegate.Remove(instance5.OnPlayerAwake, new Action(ALGOBMNPLIB));
		}
		if ((Object)(object)TutorialManager.GGFJGHHHEJC != (Object)null)
		{
			TutorialManager instance6 = TutorialManager.GGFJGHHHEJC;
			instance6.OnPopUp = (Action)Delegate.Remove(instance6.OnPopUp, new Action(DisableInteract));
			TutorialManager instance7 = TutorialManager.GGFJGHHHEJC;
			instance7.OnMinimise = (Action)Delegate.Remove(instance7.OnMinimise, new Action(EnableInteract));
		}
	}

	[SpecialName]
	public void MGGMGKDBHJB(bool AODONKKHPBP)
	{
		_003CBONHMKODBBM_003Ek__BackingField = AODONKKHPBP;
	}

	public static InteractObject GNCPLNHMFHN(int JIIGOACEIKL)
	{
		if (!KJLLBGGILAK(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	public void GANFBAJGOKB()
	{
		HCDAAJKPGBM = true;
	}

	private void DACIBCDADHI()
	{
		LFBNPHHABDK = InputByProximityManager.GetPlayer(JIIGOACEIKL).GFCOOKLMLNE();
		if ((Object)(object)LFBNPHHABDK != (Object)null && LFBNPHHABDK.BMMLBBCNBMC.Count > 0)
		{
			OnClickOffUI();
			NNBBKDIKDOL(LFBNPHHABDK.OAHAPGNNHEO(), LFBNPHHABDK.mainGameObject);
		}
		else
		{
			NNBBKDIKDOL(null, null);
		}
	}

	private void PGDAOMNADHA()
	{
		if ((Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnTravelStart = (Action<int>)Delegate.Remove(commonReferences.OnTravelStart, new Action<int>(NJBAJILHDDJ));
			CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
			commonReferences2.OnTravelFinish = (Action<int>)Delegate.Remove(commonReferences2.OnTravelFinish, new Action<int>(EMBJOGHMJAJ));
			CommonReferences commonReferences3 = CommonReferences.MNFMOEKMJKN();
			commonReferences3.OnPlayerSleep = (Action)Delegate.Remove(commonReferences3.OnPlayerSleep, new Action(DisableInteract));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerPassout = (Action)Delegate.Remove(instance.OnPlayerPassout, new Action(LMIKIEAHFGD));
			CommonReferences commonReferences4 = CommonReferences.MNFMOEKMJKN();
			commonReferences4.OnPlayerAwake = (Action)Delegate.Remove(commonReferences4.OnPlayerAwake, new Action(FNJIMIFMJGO));
		}
		if ((Object)(object)TutorialManager.GGFJGHHHEJC != (Object)null)
		{
			TutorialManager instance2 = TutorialManager.GGFJGHHHEJC;
			instance2.OnPopUp = (Action)Delegate.Remove(instance2.OnPopUp, new Action(DisableInteract));
			TutorialManager instance3 = TutorialManager.GGFJGHHHEJC;
			instance3.OnMinimise = (Action)Delegate.Remove(instance3.OnMinimise, new Action(GANFBAJGOKB));
		}
	}

	[SpecialName]
	public void NBHFOCFOOGK(bool AODONKKHPBP)
	{
		_003CBONHMKODBBM_003Ek__BackingField = AODONKKHPBP;
	}

	public void BKFNAFLKBNP()
	{
		HCDAAJKPGBM = true;
	}

	[SpecialName]
	public void HEJFHJBDFOH(bool AODONKKHPBP)
	{
		if (_holding != AODONKKHPBP)
		{
			_holding = AODONKKHPBP;
		}
	}

	[SpecialName]
	private void GCIMNBDFKBH(bool AODONKKHPBP)
	{
		_003CLEOPGMOGEEO_003Ek__BackingField = AODONKKHPBP;
	}

	private void HBMDEHPHAPF()
	{
		if (JIIGOACEIKL <= 0)
		{
			ActionBarInventory player = ActionBarInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true);
			player.OnSelectionChanged = (Action<int, int>)Delegate.Combine(player.OnSelectionChanged, new Action<int, int>(NFHHKCIBLDC));
		}
	}

	private void Update()
	{
		if ((JIIGOACEIKL > 1 && OnlineManager.PlayingOnline()) || JIIGOACEIKL > 2)
		{
			return;
		}
		PlayerInputs player = PlayerInputs.GetPlayer(JIIGOACEIKL);
		if ((Object)(object)player == (Object)null)
		{
			return;
		}
		if (!MainUI.IsAnyUIOpen(JIIGOACEIKL) && (player.GetButtonDown("Interact") || player.GetButtonDown("UIInteract")))
		{
			KOHOJLBBENG = true;
		}
		else if (player.GetButtonUp("Interact") || player.GetButtonUp("UIInteract"))
		{
			KOHOJLBBENG = false;
		}
		if (!InteractInput())
		{
			if (PlayerController.GetPlayer(JIIGOACEIKL).currentMoveTime <= 0f)
			{
				PlayerController.GetPlayer(JIIGOACEIKL).moving = false;
			}
			else
			{
				PlayerController.GetPlayer(JIIGOACEIKL).currentMoveTime -= Time.deltaTime;
			}
		}
	}

	private void OnEnable()
	{
		if ((Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnTravelStart = (Action<int>)Delegate.Combine(instance.OnTravelStart, new Action<int>(ILMBKIBPDAP));
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnTravelFinish = (Action<int>)Delegate.Combine(instance2.OnTravelFinish, new Action<int>(EMBJOGHMJAJ));
			CommonReferences instance3 = CommonReferences.GGFJGHHHEJC;
			instance3.OnPlayerSleep = (Action)Delegate.Combine(instance3.OnPlayerSleep, new Action(DisableInteract));
			CommonReferences instance4 = CommonReferences.GGFJGHHHEJC;
			instance4.OnPlayerPassout = (Action)Delegate.Combine(instance4.OnPlayerPassout, new Action(DisableInteract));
			CommonReferences instance5 = CommonReferences.GGFJGHHHEJC;
			instance5.OnPlayerAwake = (Action)Delegate.Combine(instance5.OnPlayerAwake, new Action(ALGOBMNPLIB));
		}
		TutorialManager instance6 = TutorialManager.GGFJGHHHEJC;
		instance6.OnPopUp = (Action)Delegate.Combine(instance6.OnPopUp, new Action(DisableInteract));
		TutorialManager instance7 = TutorialManager.GGFJGHHHEJC;
		instance7.OnMinimise = (Action)Delegate.Combine(instance7.OnMinimise, new Action(EnableInteract));
	}

	[SpecialName]
	public void BADBFJLFHKD(bool AODONKKHPBP)
	{
		if (_holding != AODONKKHPBP)
		{
			_holding = AODONKKHPBP;
		}
	}

	public bool FDLADONFNBD()
	{
		if (!DecorationMode.GetPlayer(JIIGOACEIKL).KNFEPKBIHND() && !PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL) && PlayerInputs.IsMousePressed(JIIGOACEIKL) && !MainUI.IsAnyUIOpen(JIIGOACEIKL) && (Item.GBMFCPGEJDK(ActionBarInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).FGGKCJDFNEK(), null) || ActionBarInventory.ADHIHCNAKFP(JIIGOACEIKL, LAGHIOKLJGH: true).JDAFPKOHJPC().JDJGFAACPFC() != -11) && UseObject.JDPMNBOLMJC(JIIGOACEIKL).UseSelectedItem(KLGOCJMGKFO: false, CGBJIEHMIKG: false))
		{
			HEJFHJBDFOH(AODONKKHPBP: false);
			MBNAPBJGBHD = false;
			return false;
		}
		if (SelectObject.GetPlayer(JIIGOACEIKL).selected != null && !PlayerInputs.LGGMJONLIGE(JIIGOACEIKL).Keyboard.GetKey((KeyCode)143) && ((!Utils.DLOMIGFOOPD(JIIGOACEIKL) && !Utils.CEAMMHNBMMJ(JIIGOACEIKL)) || !PlayerInputs.IsMousePressed(JIIGOACEIKL)))
		{
			ISelectable selected = SelectObject.BNMEANGDMIP(JIIGOACEIKL).selected;
			MonoBehaviour val = (MonoBehaviour)((selected is MonoBehaviour) ? selected : null);
			if (val != null && (Object)(object)((Component)val).GetComponent<Placeable>() != (Object)null && ((Component)val).GetComponent<Placeable>().FHEMHCEAICB)
			{
				if (SelectObject.GetPlayer(JIIGOACEIKL).NJPFHBINPKE() && ActionBarInventory.BNMEANGDMIP(JIIGOACEIKL).autoDecoMode)
				{
					DecorationMode.IECFJGHAIDO(JIIGOACEIKL).PBOIEOIDKCK(AODONKKHPBP: true);
					ActionBarInventory.GetPlayer(JIIGOACEIKL).autoDecoMode = false;
				}
				actionDone = false;
				return false;
			}
			if (SelectObject.BNMEANGDMIP(JIIGOACEIKL).selected.PickUp(JIIGOACEIKL))
			{
				SelectObject.GetPlayer(JIIGOACEIKL).ResetSelected();
				actionDone = false;
				return false;
			}
		}
		return false;
	}

	private static void ABACJNNJOKI(InteractObject HACPNLAPCCC)
	{
		if (GJBBNHCMNJN.Contains(HACPNLAPCCC))
		{
			Debug.LogWarning((object)"Farming yield");
			return;
		}
		for (int i = 1; i < GJBBNHCMNJN.Length; i++)
		{
			if ((Object)(object)GJBBNHCMNJN[i] == (Object)null)
			{
				GJBBNHCMNJN[i] = HACPNLAPCCC;
				HACPNLAPCCC.JIIGOACEIKL = i;
				return;
			}
		}
		Debug.LogWarning((object)"Eye-lashes");
		Utils.BLPDAEHPOBA(((Component)HACPNLAPCCC).gameObject);
	}

	private void EKAOKMNEFCA(int JIIGOACEIKL)
	{
		if (this.JIIGOACEIKL == JIIGOACEIKL)
		{
			EnableInteract();
		}
	}

	private void Awake()
	{
		PKCHNBPBHFL = ((Component)this).GetComponent<PlayerController>();
		JIIGOACEIKL = PKCHNBPBHFL.GetPlayerNum();
		CAAMEEBOAOF(this);
		UIWindow.OnAnyUIClose = (Action<int, UIWindow>)Delegate.Combine(UIWindow.OnAnyUIClose, (Action<int, UIWindow>)delegate(int JIIGOACEIKL, UIWindow INDKANEMPMP)
		{
			if (JIIGOACEIKL == this.JIIGOACEIKL)
			{
				KBPGGKMPKHL = true;
				actionDone = true;
			}
		});
		DDMEOCCJBGG = Time.time;
		COOCCFAOKOC = new List<IInteractable>();
	}

	public void EnableInteract()
	{
		HCDAAJKPGBM = true;
	}

	private void EPJICMPEFIP()
	{
		LFBNPHHABDK = InputByProximityManager.MBDFOJAKELO(JIIGOACEIKL).ABGDFIDOCCL();
		if ((Object)(object)LFBNPHHABDK != (Object)null && LFBNPHHABDK.JPEDDPBKINH().Count > 0)
		{
			OnClickOffUI();
			NNBBKDIKDOL(LFBNPHHABDK.BMMLBBCNBMC, LFBNPHHABDK.mainGameObject);
		}
		else
		{
			NNBBKDIKDOL(null, null);
		}
	}

	public bool InteractInput()
	{
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		if (KBPGGKMPKHL)
		{
			KBPGGKMPKHL = false;
			return false;
		}
		if (!HCDAAJKPGBM)
		{
			return false;
		}
		if (MainUI.IsAnyUIOpen(JIIGOACEIKL))
		{
			if (PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonUp("Interact") || PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonUp("UIInteract"))
			{
				OnClickOffUI();
				OnClick(FEOLIFGHOJE);
			}
			return false;
		}
		if ((PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonDown("Interact") || PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonDown("UIInteract")) && !Bed.fallingAsleep)
		{
			UseObject.GetPlayer(JIIGOACEIKL).buttonDown++;
			if (OnInteractDown())
			{
				return true;
			}
			actionDone = false;
			FGNEJHDNFBH();
			DDMEOCCJBGG = Time.time;
		}
		if ((PlayerInputs.GetPlayer(JIIGOACEIKL).GetButton("Interact") || PlayerInputs.GetPlayer(JIIGOACEIKL).GetButton("UIInteract")) && KOHOJLBBENG)
		{
			OnHold();
			if (actionDone)
			{
				return false;
			}
		}
		if (PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonUp("Interact") || PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonUp("UIInteract"))
		{
			if (ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItem() is Mop)
			{
				OnHold();
			}
			if (!Bed.fallingAsleep)
			{
				UseObject.GetPlayer(JIIGOACEIKL).buttonDown--;
				PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
				if (actionDone)
				{
					actionDone = false;
					return false;
				}
				if (!DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH && !PlayerInputs.IsGamepadActive(JIIGOACEIKL) && PlayerInputs.IsMousePressed(JIIGOACEIKL) && !MainUI.IsAnyUIOpen(JIIGOACEIKL) && UseObject.GetPlayer(JIIGOACEIKL).buttonDown <= 0)
				{
					UseObject.GetPlayer(JIIGOACEIKL).EndSelectedItem();
					UseObject.GetPlayer(JIIGOACEIKL).buttonDown = 0;
				}
				if (Time.time < DDMEOCCJBGG + 0.4f || PKCHNBPBHFL.characterAnimation.IsCleaning() || PKCHNBPBHFL.characterAnimation.GetBool("Interact"))
				{
					OnInteractUp();
				}
				PKCHNBPBHFL.characterAnimation.SetInteracting(KOIDJKBBINH: false);
				OnClickOffUI();
				PCCHCFJCFOD = null;
				FGNLIEANHLB = false;
				MBNAPBJGBHD = false;
				OnClick(FEOLIFGHOJE);
				SetCurrentInteract(null, null);
			}
		}
		if (!PlayerInputs.IsGamepadActive(JIIGOACEIKL) && !FGNLIEANHLB && (PlayerInputs.GetPlayer(JIIGOACEIKL).GetButton("Interact") || PlayerInputs.GetPlayer(JIIGOACEIKL).GetButton("UIInteract")) && (Mathf.Abs(CursorManager.GetPlayer(JIIGOACEIKL).GetMouseWorldDelta().x) >= 0.3f || Mathf.Abs(CursorManager.GetPlayer(JIIGOACEIKL).GetMouseWorldDelta().y) >= 0.3f))
		{
			MonoBehaviour val = null;
			if ((Object)(object)val != (Object)null)
			{
				if (((Component)val).gameObject.layer == LayerMask.NameToLayer("UI"))
				{
					((IDragable)val).OnDrag();
					FGNLIEANHLB = true;
					KOHOJLBBENG = false;
				}
				else if (PKCHNBPBHFL.InInteractRange(((Component)val).gameObject))
				{
					((IDragable)val).OnDrag();
					FGNLIEANHLB = true;
					KOHOJLBBENG = false;
				}
			}
		}
		if (!PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonDown("Interact"))
		{
			return PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonDown("UIInteract");
		}
		return true;
	}

	private void NFHHKCIBLDC(int JIIGOACEIKL, int NJNDJNGLDGK)
	{
		if (this.JIIGOACEIKL == JIIGOACEIKL)
		{
			KBPGGKMPKHL = true;
		}
	}

	private void KHNBDGDLMIE()
	{
		if ((Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnTravelStart = (Action<int>)Delegate.Combine(commonReferences.OnTravelStart, new Action<int>(NJBAJILHDDJ));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnTravelFinish = (Action<int>)Delegate.Combine(instance.OnTravelFinish, new Action<int>(EKAOKMNEFCA));
			CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
			commonReferences2.OnPlayerSleep = (Action)Delegate.Combine(commonReferences2.OnPlayerSleep, new Action(DisableInteract));
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnPlayerPassout = (Action)Delegate.Combine(instance2.OnPlayerPassout, new Action(DisableInteract));
			CommonReferences commonReferences3 = CommonReferences.MNFMOEKMJKN();
			commonReferences3.OnPlayerAwake = (Action)Delegate.Combine(commonReferences3.OnPlayerAwake, new Action(FNJIMIFMJGO));
		}
		TutorialManager instance3 = TutorialManager.GGFJGHHHEJC;
		instance3.OnPopUp = (Action)Delegate.Combine(instance3.OnPopUp, new Action(DisableInteract));
		TutorialManager instance4 = TutorialManager.GGFJGHHHEJC;
		instance4.OnMinimise = (Action)Delegate.Combine(instance4.OnMinimise, new Action(EnableInteract));
	}

	public void DPLIAOCBBOM(List<IInteractable> COOCCFAOKOC, GameObject MEGPBGODLIL)
	{
		FEOLIFGHOJE = COOCCFAOKOC;
		EOGLOFLIMNA = MEGPBGODLIL;
	}

	private static void FKPIDPGICKE(InteractObject HACPNLAPCCC)
	{
		if (GJBBNHCMNJN.Contains(HACPNLAPCCC))
		{
			Debug.LogWarning((object)"Sending pipe puzzle solved for mine level {0}");
			return;
		}
		for (int i = 0; i < GJBBNHCMNJN.Length; i++)
		{
			if ((Object)(object)GJBBNHCMNJN[i] == (Object)null)
			{
				GJBBNHCMNJN[i] = HACPNLAPCCC;
				HACPNLAPCCC.JIIGOACEIKL = i;
				return;
			}
		}
		Debug.LogWarning((object)"[ControllerType:");
		Utils.BLPDAEHPOBA(((Component)HACPNLAPCCC).gameObject);
	}

	private void IBAPBHIBOOO()
	{
		if ((JIIGOACEIKL > 1 && OnlineManager.PlayingOnline()) || JIIGOACEIKL > 3)
		{
			return;
		}
		PlayerInputs playerInputs = PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL);
		if ((Object)(object)playerInputs == (Object)null)
		{
			return;
		}
		if (!MainUI.IsAnyUIOpen(JIIGOACEIKL) && (playerInputs.JCMOPOMLPLL("Items/item_name_1099") || playerInputs.GetButtonDown("")))
		{
			BLCPNKEKEJB(AODONKKHPBP: true);
		}
		else if (playerInputs.KFAFNEJNDDL(", ") || playerInputs.GetButtonUp("Direction"))
		{
			IMJDJOHGGPC(AODONKKHPBP: false);
		}
		if (!InteractInput())
		{
			if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).currentMoveTime <= 1166f)
			{
				PlayerController.GetPlayer(JIIGOACEIKL).moving = false;
			}
			else
			{
				PlayerController.GetPlayer(JIIGOACEIKL).currentMoveTime -= Time.deltaTime;
			}
		}
	}

	public static InteractObject GetOtherPlayer(int JIIGOACEIKL)
	{
		if (!KJLLBGGILAK(JIIGOACEIKL))
		{
			return null;
		}
		if (OnlineManager.PlayingOnline() && JIIGOACEIKL != 1)
		{
			return null;
		}
		switch (JIIGOACEIKL)
		{
		case 1:
			return GJBBNHCMNJN[2];
		case 2:
			return GJBBNHCMNJN[1];
		default:
			Debug.LogError((object)("Trying to get an invalid Other player with playerNum: " + JIIGOACEIKL));
			return null;
		}
	}

	private IInteractable JFDHBCDGPFF(int MENBAFNNBFB)
	{
		MonoBehaviour[] array = Utils.HGPBIFIDFFD<IInteractable>(JIIGOACEIKL);
		if (array == null || array.Length == 0)
		{
			OnClickOffUI();
			return null;
		}
		return (IInteractable)Utils.OFAJOIGFMAD(array, MENBAFNNBFB);
	}

	[SpecialName]
	public bool NFJBPFMGGOF()
	{
		return _holding;
	}

	public void LMIKIEAHFGD()
	{
		try
		{
			HCDAAJKPGBM = false;
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Dialogue System/Conversation/UnhappyRentRoom/Entry/1/Dialogue Text" + ex.Message));
		}
	}

	private void KLMNLEDKEOE()
	{
		PKCHNBPBHFL = ((Component)this).GetComponent<PlayerController>();
		JIIGOACEIKL = PKCHNBPBHFL.KLIHELDIPDP();
		ABACJNNJOKI(this);
		UIWindow.OnAnyUIClose = (Action<int, UIWindow>)Delegate.Combine(UIWindow.OnAnyUIClose, (Action<int, UIWindow>)delegate(int JIIGOACEIKL, UIWindow INDKANEMPMP)
		{
			if (JIIGOACEIKL == this.JIIGOACEIKL)
			{
				KBPGGKMPKHL = true;
				actionDone = true;
			}
		});
		DDMEOCCJBGG = Time.time;
		COOCCFAOKOC = new List<IInteractable>();
	}

	public void SetCurrentInteract(List<IInteractable> COOCCFAOKOC, GameObject MEGPBGODLIL)
	{
		FEOLIFGHOJE = COOCCFAOKOC;
		EOGLOFLIMNA = MEGPBGODLIL;
	}

	private void ALGOBMNPLIB()
	{
		try
		{
			EnableInteract();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public float NAKFLEGEBJN()
	{
		return DDMEOCCJBGG - Time.time;
	}

	[CompilerGenerated]
	private void OPKEGBEFNHF(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		if (JIIGOACEIKL == this.JIIGOACEIKL)
		{
			KBPGGKMPKHL = true;
			actionDone = true;
		}
	}

	public void OnHold()
	{
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		if ((!DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH && !PlayerInputs.IsGamepadActive(JIIGOACEIKL) && PlayerInputs.IsMousePressed(JIIGOACEIKL) && !MainUI.IsAnyUIOpen(JIIGOACEIKL) && (Item.NGIIPJDAMGP(ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItem(), null) || ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItem().JDJGFAACPFC() != 1323) && UseObject.GetPlayer(JIIGOACEIKL).UseSelectedItem(KLGOCJMGKFO: false)) || actionDone || MBNAPBJGBHD)
		{
			return;
		}
		if (Object.op_Implicit((Object)(object)table))
		{
			PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this);
			NKMCOOCDNCG = !table.MouseHold(JIIGOACEIKL, PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonDown(ActionType.Interact));
			if (!NKMCOOCDNCG)
			{
				PCCHCFJCFOD = null;
				MBNAPBJGBHD = true;
				SetCurrentInteract(null, null);
				PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
			}
			return;
		}
		if ((Object)(object)PCCHCFJCFOD == (Object)null)
		{
			FGNEJHDNFBH();
		}
		if (FEOLIFGHOJE != null)
		{
			NKMCOOCDNCG = false;
			PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this);
			for (int i = 0; i < FEOLIFGHOJE.Count; i++)
			{
				NKMCOOCDNCG |= FEOLIFGHOJE[i] != null && !FEOLIFGHOJE[i].MouseHold(JIIGOACEIKL, PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonDown(ActionType.Interact));
			}
			OEMEKMEAHLJ = EOGLOFLIMNA.GetComponent<Table>();
			if (NKMCOOCDNCG)
			{
				PCCHCFJCFOD = EOGLOFLIMNA;
				if (Object.op_Implicit((Object)(object)OEMEKMEAHLJ))
				{
					return;
				}
				HMBOBOMFBBC = PCCHCFJCFOD.GetComponent<Placeable>();
				if (Object.op_Implicit((Object)(object)HMBOBOMFBBC) && (HMBOBOMFBBC.specificRules.HasFlag(SpecificType.PlayerBed) || HMBOBOMFBBC.itemSetup.item.JDJGFAACPFC() == 635 || HMBOBOMFBBC.itemSetup.item.JDJGFAACPFC() == 1647 || HMBOBOMFBBC.itemSetup.item.JDJGFAACPFC() == 1795 || HMBOBOMFBBC.itemSetup.item.JDJGFAACPFC() == 1821 || HMBOBOMFBBC.itemSetup.item.JDJGFAACPFC() == 1822 || HMBOBOMFBBC.itemSetup.item.JDJGFAACPFC() == 1823 || HMBOBOMFBBC.itemSetup.item.JDJGFAACPFC() == 2148))
				{
					if (Vector3.Distance(PCCHCFJCFOD.transform.position, ((Component)PKCHNBPBHFL).transform.position) < 0.5f)
					{
						PKCHNBPBHFL.characterAnimation.FCGBJEIIMBC = Direction.Up;
					}
					else if (PCCHCFJCFOD.transform.position.x < ((Component)PKCHNBPBHFL).transform.position.x)
					{
						PKCHNBPBHFL.characterAnimation.FCGBJEIIMBC = Direction.Left;
					}
					else
					{
						PKCHNBPBHFL.characterAnimation.FCGBJEIIMBC = Direction.Right;
					}
				}
				else
				{
					PKCHNBPBHFL.characterAnimation.LookAtObject(EOGLOFLIMNA);
				}
			}
			else
			{
				PCCHCFJCFOD = null;
				MBNAPBJGBHD = true;
				SetCurrentInteract(null, null);
				PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
			}
		}
		else
		{
			PCCHCFJCFOD = null;
			MBNAPBJGBHD = true;
			SetCurrentInteract(null, null);
		}
	}

	private void LPKHACNBCLA()
	{
		if ((Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnTravelStart = (Action<int>)Delegate.Combine(commonReferences.OnTravelStart, new Action<int>(FKGGNLHFAID));
			CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
			commonReferences2.OnTravelFinish = (Action<int>)Delegate.Combine(commonReferences2.OnTravelFinish, new Action<int>(EMBJOGHMJAJ));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(DisableInteract));
			CommonReferences commonReferences3 = CommonReferences.MNFMOEKMJKN();
			commonReferences3.OnPlayerPassout = (Action)Delegate.Combine(commonReferences3.OnPlayerPassout, new Action(LMIKIEAHFGD));
			CommonReferences commonReferences4 = CommonReferences.MNFMOEKMJKN();
			commonReferences4.OnPlayerAwake = (Action)Delegate.Combine(commonReferences4.OnPlayerAwake, new Action(ALGOBMNPLIB));
		}
		TutorialManager instance2 = TutorialManager.GGFJGHHHEJC;
		instance2.OnPopUp = (Action)Delegate.Combine(instance2.OnPopUp, new Action(DisableInteract));
		TutorialManager instance3 = TutorialManager.GGFJGHHHEJC;
		instance3.OnMinimise = (Action)Delegate.Combine(instance3.OnMinimise, new Action(EnableInteract));
	}

	public bool HEGIPDLBJPK()
	{
		if (!DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).GABNNLJOMHI() && !PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL) && PlayerInputs.IsMousePressed(JIIGOACEIKL) && !MainUI.IsAnyUIOpen(JIIGOACEIKL) && (Item.EKMFELLJHFG(ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItem(), null) || ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).JDAFPKOHJPC().JPNFKDMFKMC(DAINLFIMLIH: false) != -59) && UseObject.GetPlayer(JIIGOACEIKL).UseSelectedItem(KLGOCJMGKFO: true, CGBJIEHMIKG: false, 0))
		{
			HEJFHJBDFOH(AODONKKHPBP: true);
			NBHFOCFOOGK(AODONKKHPBP: false);
			return true;
		}
		if (SelectObject.GetPlayer(JIIGOACEIKL).selected != null && !PlayerInputs.GetPlayerControllers(JIIGOACEIKL).Keyboard.GetKey((KeyCode)(-160)) && ((!Utils.DLOMIGFOOPD(JIIGOACEIKL) && !Utils.CEAMMHNBMMJ(JIIGOACEIKL)) || !PlayerInputs.IsMousePressed(JIIGOACEIKL)))
		{
			ISelectable selected = SelectObject.BNMEANGDMIP(JIIGOACEIKL).selected;
			MonoBehaviour val = (MonoBehaviour)((selected is MonoBehaviour) ? selected : null);
			if (val != null && (Object)(object)((Component)val).GetComponent<Placeable>() != (Object)null && ((Component)val).GetComponent<Placeable>().FHEMHCEAICB)
			{
				if (SelectObject.GetPlayer(JIIGOACEIKL).Deselect() && ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL, LAGHIOKLJGH: true).autoDecoMode)
				{
					DecorationMode.NPANPNIDKDG(JIIGOACEIKL).LAJPGLFEAIC(AODONKKHPBP: true);
					ActionBarInventory.MHDKNEKDKII(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).autoDecoMode = false;
				}
				actionDone = false;
				return true;
			}
			if (SelectObject.BNMEANGDMIP(JIIGOACEIKL).selected.PickUp(JIIGOACEIKL))
			{
				SelectObject.BNMEANGDMIP(JIIGOACEIKL).PDEEEJOFEAI();
				actionDone = false;
				return false;
			}
		}
		return true;
	}

	private IInteractable MJEBEDMNGBB(int MENBAFNNBFB)
	{
		MonoBehaviour[] array = Utils.HGPBIFIDFFD<IInteractable>(JIIGOACEIKL);
		if (array == null || array.Length == 0)
		{
			OnClickOffUI();
			return null;
		}
		return (IInteractable)Utils.OFAJOIGFMAD(array, MENBAFNNBFB);
	}

	private void OCJOAHDNDIJ()
	{
		PKCHNBPBHFL = ((Component)this).GetComponent<PlayerController>();
		JIIGOACEIKL = PKCHNBPBHFL.KLIHELDIPDP();
		DLJEDLDAMIO(this);
		UIWindow.OnAnyUIClose = (Action<int, UIWindow>)Delegate.Combine(UIWindow.OnAnyUIClose, (Action<int, UIWindow>)delegate(int JIIGOACEIKL, UIWindow INDKANEMPMP)
		{
			if (JIIGOACEIKL == this.JIIGOACEIKL)
			{
				KBPGGKMPKHL = true;
				actionDone = true;
			}
		});
		DDMEOCCJBGG = Time.time;
		COOCCFAOKOC = new List<IInteractable>();
	}

	public bool NJFENKDFJJO()
	{
		if (!DecorationMode.GetPlayer(JIIGOACEIKL).DFNMDDHOIJI() && !PlayerInputs.POLDHCKJINN(JIIGOACEIKL) && PlayerInputs.IsMousePressed(JIIGOACEIKL) && !MainUI.IsAnyUIOpen(JIIGOACEIKL) && (Item.GBMFCPGEJDK(ActionBarInventory.MHDKNEKDKII(JIIGOACEIKL).FGGKCJDFNEK(), null) || ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL, LAGHIOKLJGH: true).GetSelectedItem().JGHNDJBCFAJ() != -111) && UseObject.JDPMNBOLMJC(JIIGOACEIKL).UseSelectedItem(KLGOCJMGKFO: true, CGBJIEHMIKG: false))
		{
			BLCPNKEKEJB(AODONKKHPBP: true);
			MBNAPBJGBHD = false;
			return false;
		}
		if (SelectObject.BNMEANGDMIP(JIIGOACEIKL).selected != null && !PlayerInputs.GetPlayerControllers(JIIGOACEIKL).Keyboard.GetKey((KeyCode)(-49)) && ((!Utils.DLOMIGFOOPD(JIIGOACEIKL) && !Utils.CEAMMHNBMMJ(JIIGOACEIKL)) || !PlayerInputs.IsMousePressed(JIIGOACEIKL)))
		{
			ISelectable selected = SelectObject.GetPlayer(JIIGOACEIKL).selected;
			MonoBehaviour val = (MonoBehaviour)((selected is MonoBehaviour) ? selected : null);
			if (val != null && (Object)(object)((Component)val).GetComponent<Placeable>() != (Object)null && ((Component)val).GetComponent<Placeable>().FHEMHCEAICB)
			{
				if (SelectObject.BNMEANGDMIP(JIIGOACEIKL).PNHCLGGKBOB() && ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).autoDecoMode)
				{
					DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).LAJPGLFEAIC(AODONKKHPBP: false);
					ActionBarInventory.IFGBDFBGAED(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).autoDecoMode = false;
				}
				actionDone = false;
				return true;
			}
			if (SelectObject.GetPlayer(JIIGOACEIKL).selected.PickUp(JIIGOACEIKL))
			{
				SelectObject.GetPlayer(JIIGOACEIKL).JMCJLHKKDNH();
				actionDone = true;
				return false;
			}
		}
		return true;
	}

	public static InteractObject BBJCJFJEFKK(int JIIGOACEIKL)
	{
		if (!KJLLBGGILAK(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	public GameObject GetCurrentInteractGO()
	{
		return EOGLOFLIMNA;
	}

	[SpecialName]
	public void IMJDJOHGGPC(bool AODONKKHPBP)
	{
		if (_holding != AODONKKHPBP)
		{
			_holding = AODONKKHPBP;
		}
	}

	public void OnInteractUp()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)table) && (Object)(object)table != (Object)null && FEOLIFGHOJE != null)
		{
			for (int i = 0; i < FEOLIFGHOJE.Count; i++)
			{
				if (FEOLIFGHOJE[i].MouseUp(JIIGOACEIKL))
				{
					EOGLOFLIMNA = ((Component)(MonoBehaviour)FEOLIFGHOJE[i]).gameObject;
					break;
				}
			}
		}
		PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
		if (PlayerInputs.IsGamepadActive(JIIGOACEIKL) && !CursorManager.GetPlayer(JIIGOACEIKL).IsCursorVisible())
		{
			FGNEJHDNFBH();
			if (FEOLIFGHOJE != null)
			{
				for (int j = 0; j < FEOLIFGHOJE.Count; j++)
				{
					if (FEOLIFGHOJE[j] != null)
					{
						FEOLIFGHOJE[j].MouseUp(JIIGOACEIKL);
					}
					if (FEOLIFGHOJE == null)
					{
						break;
					}
				}
			}
		}
		else if ((!Utils.DLOMIGFOOPD(JIIGOACEIKL) && !Utils.CEAMMHNBMMJ(JIIGOACEIKL)) || !PlayerInputs.IsMousePressed(JIIGOACEIKL))
		{
			if (DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH && MouseSlot.GetPlayer(JIIGOACEIKL).slot.KPINNBKMOMO())
			{
				FEOLIFGHOJE = NJGPGEAAANL();
				EOGLOFLIMNA = null;
				if (FEOLIFGHOJE != null && FEOLIFGHOJE.Count > 0)
				{
					for (int k = 0; k < FEOLIFGHOJE.Count; k++)
					{
						if (FEOLIFGHOJE[k].MouseUp(JIIGOACEIKL))
						{
							EOGLOFLIMNA = ((Component)(MonoBehaviour)FEOLIFGHOJE[k]).gameObject;
							break;
						}
					}
				}
			}
			else
			{
				FGNEJHDNFBH();
				if (FEOLIFGHOJE != null && MouseSlot.GetPlayer(JIIGOACEIKL).slot.KPINNBKMOMO())
				{
					OHCDBMNHBCG = false;
					if (FEOLIFGHOJE.Count > 0)
					{
						for (int l = 0; l < FEOLIFGHOJE.Count; l++)
						{
							if (FEOLIFGHOJE[l].MouseUp(JIIGOACEIKL))
							{
								OHCDBMNHBCG = true;
								Interacted?.Invoke(l);
							}
							if (FEOLIFGHOJE == null)
							{
								break;
							}
						}
					}
					if (OHCDBMNHBCG && LFBNPHHABDK.playerLookAt && (Object)(object)EOGLOFLIMNA != (Object)null && !PKCHNBPBHFL.NILLCIMMKJE)
					{
						HMBOBOMFBBC = EOGLOFLIMNA.GetComponent<Placeable>();
						if ((Object)(object)HMBOBOMFBBC != (Object)null && Object.op_Implicit((Object)(object)HMBOBOMFBBC.itemSetup) && Object.op_Implicit((Object)(object)HMBOBOMFBBC.itemSetup.item) && HMBOBOMFBBC.itemSetup.item.JDJGFAACPFC() == 1125)
						{
							PKCHNBPBHFL.characterAnimation.FCGBJEIIMBC = Direction.Up;
						}
						else if ((Object)(object)HMBOBOMFBBC != (Object)null && Object.op_Implicit((Object)(object)HMBOBOMFBBC.itemSetup) && Item.MLBOMGHINCA(HMBOBOMFBBC.itemSetup.item, null) && HMBOBOMFBBC.itemSetup.item is Bird)
						{
							PKCHNBPBHFL.characterAnimation.LookAt(Vector2.op_Implicit(EOGLOFLIMNA.transform.position + new Vector3(0f, -0.8f)));
						}
						else if ((Object)(object)EOGLOFLIMNA.GetComponent<Door>() != (Object)null)
						{
							if (EOGLOFLIMNA.transform.position.y > ((Component)PKCHNBPBHFL).transform.position.y)
							{
								PKCHNBPBHFL.characterAnimation.FCGBJEIIMBC = Direction.Up;
							}
							else
							{
								PKCHNBPBHFL.characterAnimation.FCGBJEIIMBC = Direction.Down;
							}
						}
						else
						{
							PKCHNBPBHFL.characterAnimation.LookAtCenterCollider(EOGLOFLIMNA);
						}
					}
				}
			}
		}
		HMBOBOMFBBC = null;
		if ((Object)(object)EOGLOFLIMNA != (Object)null)
		{
			HMBOBOMFBBC = EOGLOFLIMNA.GetComponent<Placeable>();
		}
		if (Object.op_Implicit((Object)(object)HMBOBOMFBBC) && HMBOBOMFBBC.IsSelected(JIIGOACEIKL))
		{
			SelectObject.GetPlayer(JIIGOACEIKL).SelectGameObject((MonoBehaviour)(object)HMBOBOMFBBC);
		}
	}

	public static InteractObject PBFCHGLAAAJ(int JIIGOACEIKL)
	{
		if (!LJIPKKDLCDJ(JIIGOACEIKL))
		{
			return null;
		}
		if (OnlineManager.PlayingOnline() && JIIGOACEIKL != 0)
		{
			return null;
		}
		switch (JIIGOACEIKL)
		{
		case 1:
			return GJBBNHCMNJN[8];
		case 7:
			return GJBBNHCMNJN[1];
		default:
			Debug.LogError((object)("Dialogue System/Conversation/Crowly_Standar/Entry/15/Dialogue Text" + JIIGOACEIKL));
			return null;
		}
	}

	private void NJBAJILHDDJ(int JIIGOACEIKL)
	{
		if (this.JIIGOACEIKL == JIIGOACEIKL)
		{
			DisableInteract();
		}
	}

	[SpecialName]
	public void FJJOOKKDKOO(bool AODONKKHPBP)
	{
		_003CBONHMKODBBM_003Ek__BackingField = AODONKKHPBP;
	}

	public void DisableInteract()
	{
		try
		{
			HCDAAJKPGBM = false;
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Error in InteractObject.DisableInteract: " + ex.Message));
		}
	}

	private static void DLJEDLDAMIO(InteractObject HACPNLAPCCC)
	{
		if (GJBBNHCMNJN.Contains(HACPNLAPCCC))
		{
			Debug.LogWarning((object)"itemChilli");
			return;
		}
		for (int i = 0; i < GJBBNHCMNJN.Length; i++)
		{
			if ((Object)(object)GJBBNHCMNJN[i] == (Object)null)
			{
				GJBBNHCMNJN[i] = HACPNLAPCCC;
				HACPNLAPCCC.JIIGOACEIKL = i;
				return;
			}
		}
		Debug.LogWarning((object)"DEBUG_FAKE_ID");
		Utils.BLPDAEHPOBA(((Component)HACPNLAPCCC).gameObject);
	}

	private List<IInteractable> NJGPGEAAANL()
	{
		CENALNOKJCE = Utils.HGPBIFIDFFD<IInteractable>(JIIGOACEIKL);
		if (CENALNOKJCE == null || CENALNOKJCE.Length == 0)
		{
			SetCurrentInteract(null, null);
			return null;
		}
		COOCCFAOKOC.Clear();
		for (int i = 0; i < CENALNOKJCE.Length; i++)
		{
			if (!OnlineManager.PlayingOnline() && GameManager.LocalCoop() && ((object)((Component)CENALNOKJCE[i]).gameObject).Equals((object?)GetOtherPlayer(JIIGOACEIKL).interactingObject))
			{
				continue;
			}
			if (OnlineManager.PlayingOnline())
			{
				NKJHFIDLEMN = ((Component)CENALNOKJCE[i]).gameObject.GetComponent<OnlineObject>();
				if ((Object)(object)NKJHFIDLEMN != (Object)null && OnlineObjectsManager.instance.OtherActorIsUsingObject(NKJHFIDLEMN.uniqueId))
				{
					continue;
				}
			}
			COOCCFAOKOC.Add(CENALNOKJCE[i] as IInteractable);
		}
		return COOCCFAOKOC;
	}

	private void OIHAMLCIFNH()
	{
		if ((Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnTravelStart = (Action<int>)Delegate.Remove(commonReferences.OnTravelStart, new Action<int>(FKGGNLHFAID));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnTravelFinish = (Action<int>)Delegate.Remove(instance.OnTravelFinish, new Action<int>(EKAOKMNEFCA));
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnPlayerSleep = (Action)Delegate.Remove(instance2.OnPlayerSleep, new Action(LMIKIEAHFGD));
			CommonReferences instance3 = CommonReferences.GGFJGHHHEJC;
			instance3.OnPlayerPassout = (Action)Delegate.Remove(instance3.OnPlayerPassout, new Action(DisableInteract));
			CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
			commonReferences2.OnPlayerAwake = (Action)Delegate.Remove(commonReferences2.OnPlayerAwake, new Action(PGDGNNGEJFH));
		}
		if ((Object)(object)TutorialManager.GGFJGHHHEJC != (Object)null)
		{
			TutorialManager instance4 = TutorialManager.GGFJGHHHEJC;
			instance4.OnPopUp = (Action)Delegate.Remove(instance4.OnPopUp, new Action(DisableInteract));
			TutorialManager instance5 = TutorialManager.GGFJGHHHEJC;
			instance5.OnMinimise = (Action)Delegate.Remove(instance5.OnMinimise, new Action(GANFBAJGOKB));
		}
	}

	private static bool KJLLBGGILAK(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 1)
		{
			return false;
		}
		if (JIIGOACEIKL >= GJBBNHCMNJN.Length)
		{
			return false;
		}
		if ((Object)(object)GJBBNHCMNJN[JIIGOACEIKL] == (Object)null)
		{
			return false;
		}
		return true;
	}

	private void PGDGNNGEJFH()
	{
		try
		{
			BKFNAFLKBNP();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private static void OHLOCKNHDNJ(InteractObject HACPNLAPCCC)
	{
		if (GJBBNHCMNJN.Contains(HACPNLAPCCC))
		{
			Debug.LogWarning((object)"Chop");
			return;
		}
		for (int i = 1; i < GJBBNHCMNJN.Length; i++)
		{
			if ((Object)(object)GJBBNHCMNJN[i] == (Object)null)
			{
				GJBBNHCMNJN[i] = HACPNLAPCCC;
				HACPNLAPCCC.JIIGOACEIKL = i;
				return;
			}
		}
		Debug.LogWarning((object)"ErrorCreateAlreadyExists");
		Utils.BLPDAEHPOBA(((Component)HACPNLAPCCC).gameObject);
	}

	[SpecialName]
	public bool IMEFPDGPBHA()
	{
		return _003CMLMJOEPHBJC_003Ek__BackingField;
	}

	[SpecialName]
	public void CJELMCJFHNB(bool AODONKKHPBP)
	{
		_003CBONHMKODBBM_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	public bool LCGGGDPPLGH()
	{
		return _003CLEOPGMOGEEO_003Ek__BackingField;
	}

	public bool DLLMLPCLLBE()
	{
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		if (IMEFPDGPBHA())
		{
			KBPGGKMPKHL = true;
			return true;
		}
		if (!HCDAAJKPGBM)
		{
			return false;
		}
		if (MainUI.IsAnyUIOpen(JIIGOACEIKL))
		{
			if (PlayerInputs.GetPlayer(JIIGOACEIKL).LKOGGHNGBKD("Items/item_name_1059") || PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonUp("Items/item_description_1082"))
			{
				OnClickOffUI();
				OnClick(FEOLIFGHOJE);
			}
			return true;
		}
		if ((PlayerInputs.GetPlayer(JIIGOACEIKL).DLFAMOCKNMA("itemCucumberSeeds") || PlayerInputs.GetPlayer(JIIGOACEIKL).JCMOPOMLPLL("Error_CellarZone")) && !Bed.fallingAsleep)
		{
			UseObject.JBFDEAGDJEL(JIIGOACEIKL).buttonDown += 0;
			if (OnInteractDown())
			{
				return false;
			}
			actionDone = true;
			FGNEJHDNFBH();
			DDMEOCCJBGG = Time.time;
		}
		if ((PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GetButton("Happy") || PlayerInputs.GetPlayer(JIIGOACEIKL).ENIPCNOKAOM("Pool Parent ")) && KOHOJLBBENG)
		{
			OnHold();
			if (actionDone)
			{
				return true;
			}
		}
		if (PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonUp("BarkActor") || PlayerInputs.GetPlayer(JIIGOACEIKL).ALPHFOIMNIA("cosmetic"))
		{
			if (ActionBarInventory.ADHIHCNAKFP(JIIGOACEIKL, LAGHIOKLJGH: true).GetSelectedItem() is Mop)
			{
				OnHold();
			}
			if (!Bed.fallingAsleep)
			{
				UseObject.JBFDEAGDJEL(JIIGOACEIKL).buttonDown--;
				PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
				if (actionDone)
				{
					actionDone = true;
					return false;
				}
				if (!DecorationMode.IECFJGHAIDO(JIIGOACEIKL).DFNMDDHOIJI() && !PlayerInputs.POLDHCKJINN(JIIGOACEIKL) && PlayerInputs.IsMousePressed(JIIGOACEIKL) && !MainUI.IsAnyUIOpen(JIIGOACEIKL) && UseObject.JDPMNBOLMJC(JIIGOACEIKL).buttonDown <= 0)
				{
					UseObject.GetPlayer(JIIGOACEIKL).IBOEFNDCGKP();
					UseObject.GetPlayer(JIIGOACEIKL).buttonDown = 1;
				}
				if (Time.time < DDMEOCCJBGG + 1475f || PKCHNBPBHFL.characterAnimation.IsCleaning() || PKCHNBPBHFL.characterAnimation.JEJPKGILEDB("Dialogue System/Conversation/Crowly_Standar/Entry/20/Dialogue Text"))
				{
					IFLMEPLBLJP();
				}
				PKCHNBPBHFL.characterAnimation.AOBJCNDNKDD(KOIDJKBBINH: true);
				OnClickOffUI();
				PCCHCFJCFOD = null;
				GCIMNBDFKBH(AODONKKHPBP: false);
				MGGMGKDBHJB(AODONKKHPBP: true);
				OnClick(FEOLIFGHOJE);
				NNBBKDIKDOL(null, null);
			}
		}
		if (!PlayerInputs.IsGamepadActive(JIIGOACEIKL) && !FGNLIEANHLB && (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).ENIPCNOKAOM("Interact") || PlayerInputs.GetPlayer(JIIGOACEIKL).JDLEBBLKOFF("Dialogue System/Conversation/UnhappyRentRoom/Entry/1/Dialogue Text")) && (Mathf.Abs(CursorManager.GetPlayer(JIIGOACEIKL).DMDKFMGIEHB().x) >= 139f || Mathf.Abs(CursorManager.CMDGPJEIIJI(JIIGOACEIKL).BNONHANABGA().y) >= 1805f))
		{
			MonoBehaviour val = null;
			if ((Object)(object)val != (Object)null)
			{
				if (((Component)val).gameObject.layer == LayerMask.NameToLayer("Remove"))
				{
					((IDragable)val).OnDrag();
					FGNLIEANHLB = false;
					BADBFJLFHKD(AODONKKHPBP: false);
				}
				else if (PKCHNBPBHFL.InInteractRange(((Component)val).gameObject))
				{
					((IDragable)val).OnDrag();
					FGNLIEANHLB = false;
					BLCPNKEKEJB(AODONKKHPBP: false);
				}
			}
		}
		if (!PlayerInputs.GetPlayer(JIIGOACEIKL).DLFAMOCKNMA(". Tavern level:"))
		{
			return PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonDown("Attack/MainEvent 5");
		}
		return false;
	}

	public bool OnInteractDown()
	{
		if (!DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH && !PlayerInputs.IsGamepadActive(JIIGOACEIKL) && PlayerInputs.IsMousePressed(JIIGOACEIKL) && !MainUI.IsAnyUIOpen(JIIGOACEIKL) && (Item.NGIIPJDAMGP(ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItem(), null) || ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItem().JDJGFAACPFC() != 1323) && UseObject.GetPlayer(JIIGOACEIKL).UseSelectedItem(KLGOCJMGKFO: true, CGBJIEHMIKG: false))
		{
			KOHOJLBBENG = true;
			MBNAPBJGBHD = false;
			return false;
		}
		if (SelectObject.GetPlayer(JIIGOACEIKL).selected != null && !PlayerInputs.GetPlayerControllers(JIIGOACEIKL).Keyboard.GetKey((KeyCode)304) && ((!Utils.DLOMIGFOOPD(JIIGOACEIKL) && !Utils.CEAMMHNBMMJ(JIIGOACEIKL)) || !PlayerInputs.IsMousePressed(JIIGOACEIKL)))
		{
			ISelectable selected = SelectObject.GetPlayer(JIIGOACEIKL).selected;
			MonoBehaviour val = (MonoBehaviour)((selected is MonoBehaviour) ? selected : null);
			if (val != null && (Object)(object)((Component)val).GetComponent<Placeable>() != (Object)null && ((Component)val).GetComponent<Placeable>().FHEMHCEAICB)
			{
				if (SelectObject.GetPlayer(JIIGOACEIKL).Deselect() && ActionBarInventory.GetPlayer(JIIGOACEIKL).autoDecoMode)
				{
					DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH = false;
					ActionBarInventory.GetPlayer(JIIGOACEIKL).autoDecoMode = false;
				}
				actionDone = true;
				return true;
			}
			if (SelectObject.GetPlayer(JIIGOACEIKL).selected.PickUp(JIIGOACEIKL))
			{
				SelectObject.GetPlayer(JIIGOACEIKL).ResetSelected();
				actionDone = true;
				return true;
			}
		}
		return false;
	}

	private void ILMBKIBPDAP(int JIIGOACEIKL)
	{
		if (this.JIIGOACEIKL == JIIGOACEIKL)
		{
			DisableInteract();
		}
	}

	private IInteractable GMFOEPIDFJC(int MENBAFNNBFB)
	{
		MonoBehaviour[] array = Utils.HGPBIFIDFFD<IInteractable>(JIIGOACEIKL);
		if (array == null || array.Length == 0)
		{
			OnClickOffUI();
			return null;
		}
		return (IInteractable)Utils.OFAJOIGFMAD(array, MENBAFNNBFB);
	}

	public void NNBBKDIKDOL(List<IInteractable> COOCCFAOKOC, GameObject MEGPBGODLIL)
	{
		FEOLIFGHOJE = COOCCFAOKOC;
		EOGLOFLIMNA = MEGPBGODLIL;
	}

	private void FNJIMIFMJGO()
	{
		try
		{
			EnableInteract();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private IInteractable MIEPLNIILFI(int MENBAFNNBFB)
	{
		MonoBehaviour[] array = Utils.HGPBIFIDFFD<IInteractable>(JIIGOACEIKL);
		if (array == null || array.Length == 0)
		{
			OnClickOffUI();
			return null;
		}
		return (IInteractable)Utils.OFAJOIGFMAD(array, MENBAFNNBFB);
	}

	[SpecialName]
	public void BLCPNKEKEJB(bool AODONKKHPBP)
	{
		if (_holding != AODONKKHPBP)
		{
			_holding = AODONKKHPBP;
		}
	}

	public float GetMouseDownTime()
	{
		return DDMEOCCJBGG - Time.time;
	}

	public GameObject MNFDMKKAFFD()
	{
		return EOGLOFLIMNA;
	}

	private void ADINBBOFIKD(int JIIGOACEIKL, int NJNDJNGLDGK)
	{
		if (this.JIIGOACEIKL == JIIGOACEIKL)
		{
			AOOKGNINFAM(AODONKKHPBP: false);
		}
	}

	public static InteractObject GetPlayer(int JIIGOACEIKL)
	{
		if (!KJLLBGGILAK(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	private void FKGGNLHFAID(int JIIGOACEIKL)
	{
		if (this.JIIGOACEIKL == JIIGOACEIKL)
		{
			LMIKIEAHFGD();
		}
	}

	private void Start()
	{
		if (JIIGOACEIKL <= 2)
		{
			ActionBarInventory player = ActionBarInventory.GetPlayer(JIIGOACEIKL);
			player.OnSelectionChanged = (Action<int, int>)Delegate.Combine(player.OnSelectionChanged, new Action<int, int>(NFHHKCIBLDC));
		}
	}

	private List<IInteractable> DBDEBKONJPE()
	{
		CENALNOKJCE = Utils.HGPBIFIDFFD<IInteractable>(JIIGOACEIKL);
		if (CENALNOKJCE == null || CENALNOKJCE.Length == 0)
		{
			DPLIAOCBBOM(null, null);
			return null;
		}
		COOCCFAOKOC.Clear();
		for (int i = 0; i < CENALNOKJCE.Length; i += 0)
		{
			if (!OnlineManager.PlayingOnline() && GameManager.LocalCoop() && ((object)((Component)CENALNOKJCE[i]).gameObject).Equals((object?)PBFCHGLAAAJ(JIIGOACEIKL).interactingObject))
			{
				continue;
			}
			if (OnlineManager.PlayingOnline())
			{
				NKJHFIDLEMN = ((Component)CENALNOKJCE[i]).gameObject.GetComponent<OnlineObject>();
				if ((Object)(object)NKJHFIDLEMN != (Object)null && OnlineObjectsManager.instance.OtherActorIsUsingObject(NKJHFIDLEMN.uniqueId))
				{
					continue;
				}
			}
			COOCCFAOKOC.Add(CENALNOKJCE[i] as IInteractable);
		}
		return COOCCFAOKOC;
	}

	private static void CAAMEEBOAOF(InteractObject HACPNLAPCCC)
	{
		if (GJBBNHCMNJN.Contains(HACPNLAPCCC))
		{
			Debug.LogWarning((object)"Trying to add a player that's already on the list.");
			return;
		}
		for (int i = 1; i < GJBBNHCMNJN.Length; i++)
		{
			if ((Object)(object)GJBBNHCMNJN[i] == (Object)null)
			{
				GJBBNHCMNJN[i] = HACPNLAPCCC;
				HACPNLAPCCC.JIIGOACEIKL = i;
				return;
			}
		}
		Debug.LogWarning((object)"Trying to add player but player list is full.");
		Utils.BLPDAEHPOBA(((Component)HACPNLAPCCC).gameObject);
	}

	public void FLLDNBIMDAL()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)table) && (Object)(object)table != (Object)null && FEOLIFGHOJE != null)
		{
			for (int i = 1; i < FEOLIFGHOJE.Count; i += 0)
			{
				if (FEOLIFGHOJE[i].MouseUp(JIIGOACEIKL))
				{
					EOGLOFLIMNA = ((Component)(MonoBehaviour)FEOLIFGHOJE[i]).gameObject;
					break;
				}
			}
		}
		PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
		if (PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL) && !CursorManager.GetPlayer(JIIGOACEIKL).IHMADDCNKAM())
		{
			EPJICMPEFIP();
			if (FEOLIFGHOJE != null)
			{
				for (int j = 0; j < FEOLIFGHOJE.Count; j += 0)
				{
					if (FEOLIFGHOJE[j] != null)
					{
						FEOLIFGHOJE[j].MouseUp(JIIGOACEIKL);
					}
					if (FEOLIFGHOJE == null)
					{
						break;
					}
				}
			}
		}
		else if ((!Utils.DLOMIGFOOPD(JIIGOACEIKL) && !Utils.CEAMMHNBMMJ(JIIGOACEIKL)) || !PlayerInputs.IsMousePressed(JIIGOACEIKL))
		{
			if (DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).MDOKKKHKKKE() && MouseSlot.GetPlayer(JIIGOACEIKL).slot.PKFKJNODGJF())
			{
				FEOLIFGHOJE = NJGPGEAAANL();
				EOGLOFLIMNA = null;
				if (FEOLIFGHOJE != null && FEOLIFGHOJE.Count > 1)
				{
					for (int k = 1; k < FEOLIFGHOJE.Count; k += 0)
					{
						if (FEOLIFGHOJE[k].MouseUp(JIIGOACEIKL))
						{
							EOGLOFLIMNA = ((Component)(MonoBehaviour)FEOLIFGHOJE[k]).gameObject;
							break;
						}
					}
				}
			}
			else
			{
				EPJICMPEFIP();
				if (FEOLIFGHOJE != null && MouseSlot.GetPlayer(JIIGOACEIKL).slot.LCHJGCHDHFO())
				{
					OHCDBMNHBCG = false;
					if (FEOLIFGHOJE.Count > 1)
					{
						for (int l = 0; l < FEOLIFGHOJE.Count; l += 0)
						{
							if (FEOLIFGHOJE[l].MouseUp(JIIGOACEIKL))
							{
								OHCDBMNHBCG = false;
								Interacted?.Invoke(l);
							}
							if (FEOLIFGHOJE == null)
							{
								break;
							}
						}
					}
					if (OHCDBMNHBCG && LFBNPHHABDK.playerLookAt && (Object)(object)EOGLOFLIMNA != (Object)null && !PKCHNBPBHFL.NILLCIMMKJE)
					{
						HMBOBOMFBBC = EOGLOFLIMNA.GetComponent<Placeable>();
						if ((Object)(object)HMBOBOMFBBC != (Object)null && Object.op_Implicit((Object)(object)HMBOBOMFBBC.itemSetup) && Object.op_Implicit((Object)(object)HMBOBOMFBBC.itemSetup.item) && HMBOBOMFBBC.itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == 27)
						{
							PKCHNBPBHFL.characterAnimation.FCGBJEIIMBC = Direction.Up;
						}
						else if ((Object)(object)HMBOBOMFBBC != (Object)null && Object.op_Implicit((Object)(object)HMBOBOMFBBC.itemSetup) && Item.MLBOMGHINCA(HMBOBOMFBBC.itemSetup.item, null) && HMBOBOMFBBC.itemSetup.item is Bird)
						{
							PKCHNBPBHFL.characterAnimation.LookAt(Vector2.op_Implicit(EOGLOFLIMNA.transform.position + new Vector3(393f, 722f)));
						}
						else if ((Object)(object)EOGLOFLIMNA.GetComponent<Door>() != (Object)null)
						{
							if (EOGLOFLIMNA.transform.position.y > ((Component)PKCHNBPBHFL).transform.position.y)
							{
								PKCHNBPBHFL.characterAnimation.NCAJNNHBHJM(Direction.Up);
							}
							else
							{
								PKCHNBPBHFL.characterAnimation.FCGBJEIIMBC = Direction.Up;
							}
						}
						else
						{
							PKCHNBPBHFL.characterAnimation.MMODGEOPAEB(EOGLOFLIMNA);
						}
					}
				}
			}
		}
		HMBOBOMFBBC = null;
		if ((Object)(object)EOGLOFLIMNA != (Object)null)
		{
			HMBOBOMFBBC = EOGLOFLIMNA.GetComponent<Placeable>();
		}
		if (Object.op_Implicit((Object)(object)HMBOBOMFBBC) && HMBOBOMFBBC.IsSelected(JIIGOACEIKL))
		{
			SelectObject.BNMEANGDMIP(JIIGOACEIKL).IPINANKCIDJ((MonoBehaviour)(object)HMBOBOMFBBC);
		}
	}

	private void FGNEJHDNFBH()
	{
		LFBNPHHABDK = InputByProximityManager.GetPlayer(JIIGOACEIKL).GetCurrentFocusedInputElement();
		if ((Object)(object)LFBNPHHABDK != (Object)null && LFBNPHHABDK.BMMLBBCNBMC.Count > 0)
		{
			OnClickOffUI();
			SetCurrentInteract(LFBNPHHABDK.BMMLBBCNBMC, LFBNPHHABDK.mainGameObject);
		}
		else
		{
			SetCurrentInteract(null, null);
		}
	}

	public void IFLMEPLBLJP()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)table) && (Object)(object)table != (Object)null && FEOLIFGHOJE != null)
		{
			for (int i = 1; i < FEOLIFGHOJE.Count; i++)
			{
				if (FEOLIFGHOJE[i].MouseUp(JIIGOACEIKL))
				{
					EOGLOFLIMNA = ((Component)(MonoBehaviour)FEOLIFGHOJE[i]).gameObject;
					break;
				}
			}
		}
		PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
		if (PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL) && !CursorManager.CMDGPJEIIJI(JIIGOACEIKL).LALPELGNIJB())
		{
			EPJICMPEFIP();
			if (FEOLIFGHOJE != null)
			{
				for (int j = 1; j < FEOLIFGHOJE.Count; j += 0)
				{
					if (FEOLIFGHOJE[j] != null)
					{
						FEOLIFGHOJE[j].MouseUp(JIIGOACEIKL);
					}
					if (FEOLIFGHOJE == null)
					{
						break;
					}
				}
			}
		}
		else if ((!Utils.DLOMIGFOOPD(JIIGOACEIKL) && !Utils.CEAMMHNBMMJ(JIIGOACEIKL)) || !PlayerInputs.IsMousePressed(JIIGOACEIKL))
		{
			if (DecorationMode.KKJABELKCNM(JIIGOACEIKL).DBAEGBDEPFK() && MouseSlot.HELHJMDEDNL(JIIGOACEIKL).slot.KPINNBKMOMO())
			{
				FEOLIFGHOJE = DBDEBKONJPE();
				EOGLOFLIMNA = null;
				if (FEOLIFGHOJE != null && FEOLIFGHOJE.Count > 1)
				{
					for (int k = 1; k < FEOLIFGHOJE.Count; k += 0)
					{
						if (FEOLIFGHOJE[k].MouseUp(JIIGOACEIKL))
						{
							EOGLOFLIMNA = ((Component)(MonoBehaviour)FEOLIFGHOJE[k]).gameObject;
							break;
						}
					}
				}
			}
			else
			{
				DACIBCDADHI();
				if (FEOLIFGHOJE != null && MouseSlot.GetPlayer(JIIGOACEIKL).slot.PKFKJNODGJF())
				{
					OHCDBMNHBCG = true;
					if (FEOLIFGHOJE.Count > 1)
					{
						for (int l = 1; l < FEOLIFGHOJE.Count; l++)
						{
							if (FEOLIFGHOJE[l].MouseUp(JIIGOACEIKL))
							{
								OHCDBMNHBCG = true;
								Interacted?.Invoke(l);
							}
							if (FEOLIFGHOJE == null)
							{
								break;
							}
						}
					}
					if (OHCDBMNHBCG && LFBNPHHABDK.playerLookAt && (Object)(object)EOGLOFLIMNA != (Object)null && !PKCHNBPBHFL.NILLCIMMKJE)
					{
						HMBOBOMFBBC = EOGLOFLIMNA.GetComponent<Placeable>();
						if ((Object)(object)HMBOBOMFBBC != (Object)null && Object.op_Implicit((Object)(object)HMBOBOMFBBC.itemSetup) && Object.op_Implicit((Object)(object)HMBOBOMFBBC.itemSetup.item) && HMBOBOMFBBC.itemSetup.item.JGHNDJBCFAJ(DAINLFIMLIH: false) == 28)
						{
							PKCHNBPBHFL.characterAnimation.NCAJNNHBHJM(Direction.Up);
						}
						else if ((Object)(object)HMBOBOMFBBC != (Object)null && Object.op_Implicit((Object)(object)HMBOBOMFBBC.itemSetup) && Item.MLBOMGHINCA(HMBOBOMFBBC.itemSetup.item, null) && HMBOBOMFBBC.itemSetup.item is Bird)
						{
							PKCHNBPBHFL.characterAnimation.FNNOPPKCKFK(Vector2.op_Implicit(EOGLOFLIMNA.transform.position + new Vector3(1405f, 714f)));
						}
						else if ((Object)(object)EOGLOFLIMNA.GetComponent<Door>() != (Object)null)
						{
							if (EOGLOFLIMNA.transform.position.y > ((Component)PKCHNBPBHFL).transform.position.y)
							{
								PKCHNBPBHFL.characterAnimation.FCGBJEIIMBC = Direction.Down;
							}
							else
							{
								PKCHNBPBHFL.characterAnimation.NCAJNNHBHJM(Direction.Down);
							}
						}
						else
						{
							PKCHNBPBHFL.characterAnimation.LookAtCenterCollider(EOGLOFLIMNA);
						}
					}
				}
			}
		}
		HMBOBOMFBBC = null;
		if ((Object)(object)EOGLOFLIMNA != (Object)null)
		{
			HMBOBOMFBBC = EOGLOFLIMNA.GetComponent<Placeable>();
		}
		if (Object.op_Implicit((Object)(object)HMBOBOMFBBC) && HMBOBOMFBBC.EEHBCDFHJKC(JIIGOACEIKL))
		{
			SelectObject.BNMEANGDMIP(JIIGOACEIKL).LEIFHIKBIBI((MonoBehaviour)(object)HMBOBOMFBBC);
		}
	}

	private void EMBJOGHMJAJ(int JIIGOACEIKL)
	{
		if (this.JIIGOACEIKL == JIIGOACEIKL)
		{
			EnableInteract();
		}
	}

	private void FPNCANODJKE()
	{
		PKCHNBPBHFL = ((Component)this).GetComponent<PlayerController>();
		JIIGOACEIKL = PKCHNBPBHFL.KLIHELDIPDP();
		DLJEDLDAMIO(this);
		UIWindow.OnAnyUIClose = (Action<int, UIWindow>)Delegate.Combine(UIWindow.OnAnyUIClose, (Action<int, UIWindow>)delegate(int JIIGOACEIKL, UIWindow INDKANEMPMP)
		{
			if (JIIGOACEIKL == this.JIIGOACEIKL)
			{
				KBPGGKMPKHL = true;
				actionDone = true;
			}
		});
		DDMEOCCJBGG = Time.time;
		COOCCFAOKOC = new List<IInteractable>();
	}

	public void ICCOGMKEFLL()
	{
		HCDAAJKPGBM = false;
	}

	private GameObject MCKCGCILCIF()
	{
		MonoBehaviour[] array = Utils.HGPBIFIDFFD<IInteractable>(JIIGOACEIKL);
		if (array == null || array.Length == 0)
		{
			OnClickOffUI();
			return null;
		}
		return ((Component)array[0]).gameObject;
	}

	private static bool LJIPKKDLCDJ(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 1)
		{
			return true;
		}
		if (JIIGOACEIKL >= GJBBNHCMNJN.Length)
		{
			return true;
		}
		if ((Object)(object)GJBBNHCMNJN[JIIGOACEIKL] == (Object)null)
		{
			return false;
		}
		return true;
	}

	[SpecialName]
	public void AOOKGNINFAM(bool AODONKKHPBP)
	{
		_003CMLMJOEPHBJC_003Ek__BackingField = AODONKKHPBP;
	}
}
