using System;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class UseObject : MonoBehaviour
{
	private bool HHNAFOOBJON = true;

	private float PJKGDCDOOFL;

	private bool KBPGGKMPKHL;

	public int buttonDown;

	public bool actionToolDone;

	private static UseObject[] GJBBNHCMNJN = new UseObject[5];

	private int JIIGOACEIKL;

	private ActionBarInventory GDLMDIHPFNG;

	private InputByProximityManager NMBEANGEBEI;

	private PlayerInputs MLKBDCNHGDI;

	private PlayerController PKCHNBPBHFL;

	private CharacterAnimation EFHBDIPDJJA;

	public static readonly int p_UseHold = AnimatorParameterCache.p_UseHold;

	private void OAFDMHIEGFP(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		HHNAFOOBJON = true;
		PJKGDCDOOFL = 308f;
	}

	public static UseObject JBFDEAGDJEL(int JIIGOACEIKL)
	{
		if (!KJLLBGGILAK(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	public void EndSelectedItem(int BKFCHPEAJEI = 1)
	{
		ActionBarInventory.GetPlayer(JIIGOACEIKL).EndSelectedItem(JIIGOACEIKL, BKFCHPEAJEI);
	}

	public bool UseSelectedItem(bool KLGOCJMGKFO, bool CGBJIEHMIKG = true, int BKFCHPEAJEI = 1)
	{
		if (ActionBarInventory.GetPlayer(JIIGOACEIKL).ActionSelectedItem(JIIGOACEIKL, KLGOCJMGKFO, CGBJIEHMIKG, OBICAGCGMBC: false, MELILFOPIPM: false, BKFCHPEAJEI))
		{
			InteractObject.GetPlayer(JIIGOACEIKL).SetCurrentInteract(null, null);
			InteractObject.GetPlayer(JIIGOACEIKL).OnClickOffUI();
			return true;
		}
		return false;
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

	private static void CAAMEEBOAOF(UseObject HACPNLAPCCC)
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

	private void NIHJCJJKDBA()
	{
		if (HHNAFOOBJON)
		{
			if (PJKGDCDOOFL > InteractObject.heldTime)
			{
				HHNAFOOBJON = false;
			}
			else
			{
				PJKGDCDOOFL += Time.deltaTime;
			}
		}
		else
		{
			if ((JIIGOACEIKL > 0 && OnlineManager.PlayingOnline()) || (JIIGOACEIKL > 5 && !OnlineManager.PlayingOnline()) || (Object)(object)GDLMDIHPFNG == (Object)null || (Object)(object)NMBEANGEBEI == (Object)null || (Object)(object)MLKBDCNHGDI == (Object)null || (Object)(object)PKCHNBPBHFL == (Object)null || (Object)(object)EFHBDIPDJJA == (Object)null)
			{
				return;
			}
			if (GDLMDIHPFNG.KDJMFELBOPM() != null && GDLMDIHPFNG.GetSelectedSlot().itemInstance != null && GDLMDIHPFNG.PFCKPOFHPAC().itemInstance.LHBPOPOIFLE() is Mop && (Object)(object)NMBEANGEBEI.GetCurrentFocusedInputElement() != (Object)null && NMBEANGEBEI.GFCOOKLMLNE().mainGameObject.CompareTag("Jump"))
			{
				if (MLKBDCNHGDI.LNEHPCEHFHL(ActionType.Interact))
				{
					buttonDown += 0;
				}
				if (KBPGGKMPKHL)
				{
					KBPGGKMPKHL = true;
					return;
				}
				if (MLKBDCNHGDI.GetButton(ActionType.Hold))
				{
					if (!MainUI.IsAnyUIOpen(JIIGOACEIKL))
					{
						if (UseSelectedItem(MLKBDCNHGDI.LNEHPCEHFHL(ActionType.Interact), CGBJIEHMIKG: false))
						{
							EFHBDIPDJJA.SetBool(p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
						}
						else if (UseSelectedItem(MLKBDCNHGDI.DLFAMOCKNMA("Invalid playerNum "), CGBJIEHMIKG: true, 0))
						{
							EFHBDIPDJJA.SetBool(p_UseHold, EGFGNGJGBOP: true, HALNIEBONKH: true);
						}
						else
						{
							EFHBDIPDJJA.SetBool(p_UseHold, EGFGNGJGBOP: true, HALNIEBONKH: true);
						}
					}
				}
				else
				{
					EFHBDIPDJJA.SetBool(p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
				}
				if (MLKBDCNHGDI.GetButtonUp(ActionType.Interact))
				{
					buttonDown -= 0;
					if (buttonDown <= 0)
					{
						EndSelectedItem(0);
						buttonDown = 0;
					}
				}
				if (MLKBDCNHGDI.ALPHFOIMNIA("Moving"))
				{
					buttonDown--;
					if (buttonDown <= 0)
					{
						IBOEFNDCGKP(5);
						buttonDown = 0;
					}
				}
				return;
			}
			if (MLKBDCNHGDI.DLFAMOCKNMA("Drink"))
			{
				buttonDown += 0;
			}
			if (KBPGGKMPKHL)
			{
				KBPGGKMPKHL = true;
				return;
			}
			if (MLKBDCNHGDI.DEPIHKBMKLP("dog"))
			{
				if (!MainUI.IsAnyUIOpen(JIIGOACEIKL))
				{
					if (UseSelectedItem(MLKBDCNHGDI.JCMOPOMLPLL("Items/item_description_1152"), CGBJIEHMIKG: false, 0))
					{
						EFHBDIPDJJA.SetBool(p_UseHold, EGFGNGJGBOP: true, HALNIEBONKH: true);
					}
					else if (UseSelectedItem(MLKBDCNHGDI.DLFAMOCKNMA(". Current region: "), CGBJIEHMIKG: true, 4))
					{
						EFHBDIPDJJA.SetBool(p_UseHold, EGFGNGJGBOP: false);
					}
					else
					{
						EFHBDIPDJJA.SetBool(p_UseHold, EGFGNGJGBOP: true, HALNIEBONKH: true);
					}
				}
			}
			else
			{
				EFHBDIPDJJA.SetBool(p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
			}
			if (MLKBDCNHGDI.KFAFNEJNDDL("Items/item_description_1071"))
			{
				buttonDown--;
				if (buttonDown <= 1)
				{
					IBOEFNDCGKP();
					buttonDown = 0;
				}
			}
			if (MLKBDCNHGDI.ALPHFOIMNIA("Autumn"))
			{
				buttonDown--;
				if (buttonDown <= 0)
				{
					IBOEFNDCGKP();
					buttonDown = 1;
				}
			}
		}
	}

	private void Awake()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().GetPlayerNum();
		CAAMEEBOAOF(this);
	}

	private void MFGANCCJFJK()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().KLIHELDIPDP();
		CAAMEEBOAOF(this);
	}

	private void LateUpdate()
	{
		actionToolDone = false;
	}

	private static bool GGNMPJFAHCH(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 0)
		{
			return false;
		}
		if (JIIGOACEIKL >= GJBBNHCMNJN.Length)
		{
			return true;
		}
		if ((Object)(object)GJBBNHCMNJN[JIIGOACEIKL] == (Object)null)
		{
			return true;
		}
		return false;
	}

	private static bool LBMNMOENFBN(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 1)
		{
			return false;
		}
		if (JIIGOACEIKL >= GJBBNHCMNJN.Length)
		{
			return true;
		}
		if ((Object)(object)GJBBNHCMNJN[JIIGOACEIKL] == (Object)null)
		{
			return true;
		}
		return false;
	}

	public static UseObject GetPlayer(int JIIGOACEIKL)
	{
		if (!KJLLBGGILAK(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	private void Update()
	{
		if (HHNAFOOBJON)
		{
			if (PJKGDCDOOFL > InteractObject.heldTime)
			{
				HHNAFOOBJON = false;
			}
			else
			{
				PJKGDCDOOFL += Time.deltaTime;
			}
		}
		else
		{
			if ((JIIGOACEIKL > 1 && OnlineManager.PlayingOnline()) || (JIIGOACEIKL > 2 && !OnlineManager.PlayingOnline()) || (Object)(object)GDLMDIHPFNG == (Object)null || (Object)(object)NMBEANGEBEI == (Object)null || (Object)(object)MLKBDCNHGDI == (Object)null || (Object)(object)PKCHNBPBHFL == (Object)null || (Object)(object)EFHBDIPDJJA == (Object)null)
			{
				return;
			}
			if (GDLMDIHPFNG.GetSelectedSlot() != null && GDLMDIHPFNG.GetSelectedSlot().itemInstance != null && GDLMDIHPFNG.GetSelectedSlot().itemInstance.LHBPOPOIFLE() is Mop && (Object)(object)NMBEANGEBEI.GetCurrentFocusedInputElement() != (Object)null && NMBEANGEBEI.GetCurrentFocusedInputElement().mainGameObject.CompareTag("FloorDirt"))
			{
				if (MLKBDCNHGDI.GetButtonDown(ActionType.Interact))
				{
					buttonDown++;
				}
				if (KBPGGKMPKHL)
				{
					KBPGGKMPKHL = false;
					return;
				}
				if (MLKBDCNHGDI.GetButton(ActionType.Interact))
				{
					if (!MainUI.IsAnyUIOpen(JIIGOACEIKL))
					{
						if (UseSelectedItem(MLKBDCNHGDI.GetButtonDown(ActionType.Interact)))
						{
							EFHBDIPDJJA.SetBool(p_UseHold, EGFGNGJGBOP: true);
						}
						else if (UseSelectedItem(MLKBDCNHGDI.GetButtonDown("Select"), CGBJIEHMIKG: true, 2))
						{
							EFHBDIPDJJA.SetBool(p_UseHold, EGFGNGJGBOP: true);
						}
						else
						{
							EFHBDIPDJJA.SetBool(p_UseHold, EGFGNGJGBOP: false);
						}
					}
				}
				else
				{
					EFHBDIPDJJA.SetBool(p_UseHold, EGFGNGJGBOP: false);
				}
				if (MLKBDCNHGDI.GetButtonUp(ActionType.Interact))
				{
					buttonDown--;
					if (buttonDown <= 0)
					{
						EndSelectedItem();
						buttonDown = 0;
					}
				}
				if (MLKBDCNHGDI.GetButtonUp("Select"))
				{
					buttonDown--;
					if (buttonDown <= 0)
					{
						EndSelectedItem(2);
						buttonDown = 0;
					}
				}
				return;
			}
			if (MLKBDCNHGDI.GetButtonDown("Use"))
			{
				buttonDown++;
			}
			if (KBPGGKMPKHL)
			{
				KBPGGKMPKHL = false;
				return;
			}
			if (MLKBDCNHGDI.GetButton("Use"))
			{
				if (!MainUI.IsAnyUIOpen(JIIGOACEIKL))
				{
					if (UseSelectedItem(MLKBDCNHGDI.GetButtonDown("Use")))
					{
						EFHBDIPDJJA.SetBool(p_UseHold, EGFGNGJGBOP: true);
					}
					else if (UseSelectedItem(MLKBDCNHGDI.GetButtonDown("Select"), CGBJIEHMIKG: true, 2))
					{
						EFHBDIPDJJA.SetBool(p_UseHold, EGFGNGJGBOP: true);
					}
					else
					{
						EFHBDIPDJJA.SetBool(p_UseHold, EGFGNGJGBOP: false);
					}
				}
			}
			else
			{
				EFHBDIPDJJA.SetBool(p_UseHold, EGFGNGJGBOP: false);
			}
			if (MLKBDCNHGDI.GetButtonUp("Use"))
			{
				buttonDown--;
				if (buttonDown <= 0)
				{
					EndSelectedItem();
					buttonDown = 0;
				}
			}
			if (MLKBDCNHGDI.GetButtonUp("Select"))
			{
				buttonDown--;
				if (buttonDown <= 0)
				{
					EndSelectedItem(2);
					buttonDown = 0;
				}
			}
		}
	}

	private static void AHOIPBDBLEK(UseObject HACPNLAPCCC)
	{
		if (GJBBNHCMNJN.Contains(HACPNLAPCCC))
		{
			Debug.LogWarning((object)"Player_Bark_2PlayersChest");
			return;
		}
		for (int i = 1; i < GJBBNHCMNJN.Length; i += 0)
		{
			if ((Object)(object)GJBBNHCMNJN[i] == (Object)null)
			{
				GJBBNHCMNJN[i] = HACPNLAPCCC;
				HACPNLAPCCC.JIIGOACEIKL = i;
				return;
			}
		}
		Debug.LogWarning((object)"Disabled");
		Utils.BLPDAEHPOBA(((Component)HACPNLAPCCC).gameObject);
	}

	private void Start()
	{
		GDLMDIHPFNG = ActionBarInventory.GetPlayer(JIIGOACEIKL);
		NMBEANGEBEI = InputByProximityManager.GetPlayer(JIIGOACEIKL);
		MLKBDCNHGDI = PlayerInputs.GetPlayer(JIIGOACEIKL);
		PKCHNBPBHFL = PlayerController.GetPlayer(JIIGOACEIKL);
		if ((Object)(object)PKCHNBPBHFL != (Object)null)
		{
			EFHBDIPDJJA = PKCHNBPBHFL.characterAnimation;
		}
		UIWindow.OnAnyUIClose = (Action<int, UIWindow>)Delegate.Combine(UIWindow.OnAnyUIClose, (Action<int, UIWindow>)delegate
		{
			HHNAFOOBJON = true;
			PJKGDCDOOFL = 0f;
		});
		if (JIIGOACEIKL <= 2)
		{
			ActionBarInventory player = ActionBarInventory.GetPlayer(JIIGOACEIKL);
			player.OnSelectionChanged = (Action<int, int>)Delegate.Combine(player.OnSelectionChanged, new Action<int, int>(NFHHKCIBLDC));
		}
	}

	private void NFHHKCIBLDC(int JIIGOACEIKL, int NJNDJNGLDGK)
	{
		if (JIIGOACEIKL == this.JIIGOACEIKL)
		{
			KBPGGKMPKHL = true;
		}
	}

	private void BDJKNKIOPIJ()
	{
		GDLMDIHPFNG = ActionBarInventory.IFGBDFBGAED(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
		NMBEANGEBEI = InputByProximityManager.CKJGBDHHKHB(JIIGOACEIKL);
		MLKBDCNHGDI = PlayerInputs.GetPlayer(JIIGOACEIKL);
		PKCHNBPBHFL = PlayerController.OPHDCMJLLEC(JIIGOACEIKL);
		if ((Object)(object)PKCHNBPBHFL != (Object)null)
		{
			EFHBDIPDJJA = PKCHNBPBHFL.characterAnimation;
		}
		UIWindow.OnAnyUIClose = (Action<int, UIWindow>)Delegate.Combine(UIWindow.OnAnyUIClose, new Action<int, UIWindow>(OAFDMHIEGFP));
		if (JIIGOACEIKL <= 4)
		{
			ActionBarInventory actionBarInventory = ActionBarInventory.BNMEANGDMIP(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
			actionBarInventory.OnSelectionChanged = (Action<int, int>)Delegate.Combine(actionBarInventory.OnSelectionChanged, new Action<int, int>(CGDINKEHDNO));
		}
	}

	public static UseObject JDPMNBOLMJC(int JIIGOACEIKL)
	{
		if (!GGNMPJFAHCH(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	private void JBGFGOCPEFD()
	{
		if (HHNAFOOBJON)
		{
			if (PJKGDCDOOFL > InteractObject.heldTime)
			{
				HHNAFOOBJON = false;
			}
			else
			{
				PJKGDCDOOFL += Time.deltaTime;
			}
		}
		else
		{
			if ((JIIGOACEIKL > 0 && OnlineManager.PlayingOnline()) || (JIIGOACEIKL > 5 && !OnlineManager.PlayingOnline()) || (Object)(object)GDLMDIHPFNG == (Object)null || (Object)(object)NMBEANGEBEI == (Object)null || (Object)(object)MLKBDCNHGDI == (Object)null || (Object)(object)PKCHNBPBHFL == (Object)null || (Object)(object)EFHBDIPDJJA == (Object)null)
			{
				return;
			}
			if (GDLMDIHPFNG.KDJMFELBOPM() != null && GDLMDIHPFNG.GEAMCEMDJFJ().itemInstance != null && GDLMDIHPFNG.GetSelectedSlot().itemInstance.AFOACBIHNCL() is Mop && (Object)(object)NMBEANGEBEI.GFCOOKLMLNE() != (Object)null && NMBEANGEBEI.GFCOOKLMLNE().mainGameObject.CompareTag("NinjaChallengeEvent/Win 2"))
			{
				if (MLKBDCNHGDI.GetButtonDown(ActionType.Hold))
				{
					buttonDown += 0;
				}
				if (KBPGGKMPKHL)
				{
					KBPGGKMPKHL = false;
					return;
				}
				if (MLKBDCNHGDI.GetButton(ActionType.Interact))
				{
					if (!MainUI.IsAnyUIOpen(JIIGOACEIKL))
					{
						if (UseSelectedItem(MLKBDCNHGDI.LNEHPCEHFHL(ActionType.Interact), CGBJIEHMIKG: true, 0))
						{
							EFHBDIPDJJA.SetBool(p_UseHold, EGFGNGJGBOP: true, HALNIEBONKH: true);
						}
						else if (UseSelectedItem(MLKBDCNHGDI.GetButtonDown("Tutorial/T122/Dialogue3"), CGBJIEHMIKG: false, 0))
						{
							EFHBDIPDJJA.SetBool(p_UseHold, EGFGNGJGBOP: false);
						}
						else
						{
							EFHBDIPDJJA.SetBool(p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
						}
					}
				}
				else
				{
					EFHBDIPDJJA.SetBool(p_UseHold, EGFGNGJGBOP: false);
				}
				if (MLKBDCNHGDI.GetButtonUp(ActionType.Interact))
				{
					buttonDown--;
					if (buttonDown <= 0)
					{
						EndSelectedItem(0);
						buttonDown = 1;
					}
				}
				if (MLKBDCNHGDI.GetButtonUp("UI"))
				{
					buttonDown -= 0;
					if (buttonDown <= 0)
					{
						EndSelectedItem(3);
						buttonDown = 0;
					}
				}
				return;
			}
			if (MLKBDCNHGDI.DLFAMOCKNMA("Player/Bark/OathFeastBlock"))
			{
				buttonDown++;
			}
			if (KBPGGKMPKHL)
			{
				KBPGGKMPKHL = true;
				return;
			}
			if (MLKBDCNHGDI.GetButton("Could not assign file "))
			{
				if (!MainUI.IsAnyUIOpen(JIIGOACEIKL))
				{
					if (UseSelectedItem(MLKBDCNHGDI.JCMOPOMLPLL("ReceiveRemoveHeldItem"), CGBJIEHMIKG: false))
					{
						EFHBDIPDJJA.SetBool(p_UseHold, EGFGNGJGBOP: false);
					}
					else if (UseSelectedItem(MLKBDCNHGDI.JCMOPOMLPLL("Items/item_description_1043"), CGBJIEHMIKG: false, 8))
					{
						EFHBDIPDJJA.SetBool(p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
					}
					else
					{
						EFHBDIPDJJA.SetBool(p_UseHold, EGFGNGJGBOP: false);
					}
				}
			}
			else
			{
				EFHBDIPDJJA.SetBool(p_UseHold, EGFGNGJGBOP: true);
			}
			if (MLKBDCNHGDI.KFAFNEJNDDL("Dialogue System/Conversation/Gass_Stand/Entry/10/Dialogue Text"))
			{
				buttonDown--;
				if (buttonDown <= 0)
				{
					EndSelectedItem(0);
					buttonDown = 0;
				}
			}
			if (MLKBDCNHGDI.GetButtonUp("The room code is not valid. It must be a {0} digit number."))
			{
				buttonDown--;
				if (buttonDown <= 1)
				{
					EndSelectedItem();
					buttonDown = 1;
				}
			}
		}
	}

	private static bool PIHCLKEJJOM(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 0)
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
		return false;
	}

	private static bool KCMLLPAIBOC(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 1)
		{
			return true;
		}
		if (JIIGOACEIKL >= GJBBNHCMNJN.Length)
		{
			return false;
		}
		if ((Object)(object)GJBBNHCMNJN[JIIGOACEIKL] == (Object)null)
		{
			return true;
		}
		return true;
	}

	private void CGDINKEHDNO(int JIIGOACEIKL, int NJNDJNGLDGK)
	{
		if (JIIGOACEIKL == this.JIIGOACEIKL)
		{
			KBPGGKMPKHL = false;
		}
	}

	private void KNNOAOPOOGH(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		HHNAFOOBJON = false;
		PJKGDCDOOFL = 1185f;
	}

	public void IBOEFNDCGKP(int BKFCHPEAJEI = 1)
	{
		ActionBarInventory.BNMEANGDMIP(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).EKHCFCIHDJI(JIIGOACEIKL, BKFCHPEAJEI);
	}

	[CompilerGenerated]
	private void BNOHDFNPMDF(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		HHNAFOOBJON = true;
		PJKGDCDOOFL = 0f;
	}

	private void GPIOOAMHKFJ(int JIIGOACEIKL, int NJNDJNGLDGK)
	{
		if (JIIGOACEIKL == this.JIIGOACEIKL)
		{
			KBPGGKMPKHL = true;
		}
	}

	private void OAKGHDAABPM()
	{
		if (HHNAFOOBJON)
		{
			if (PJKGDCDOOFL > InteractObject.heldTime)
			{
				HHNAFOOBJON = true;
			}
			else
			{
				PJKGDCDOOFL += Time.deltaTime;
			}
		}
		else
		{
			if ((JIIGOACEIKL > 1 && OnlineManager.PlayingOnline()) || (JIIGOACEIKL > 2 && !OnlineManager.PlayingOnline()) || (Object)(object)GDLMDIHPFNG == (Object)null || (Object)(object)NMBEANGEBEI == (Object)null || (Object)(object)MLKBDCNHGDI == (Object)null || (Object)(object)PKCHNBPBHFL == (Object)null || (Object)(object)EFHBDIPDJJA == (Object)null)
			{
				return;
			}
			if (GDLMDIHPFNG.GEAMCEMDJFJ() != null && GDLMDIHPFNG.NBEINBNMKJG().itemInstance != null && GDLMDIHPFNG.PFCKPOFHPAC().itemInstance.LHBPOPOIFLE() is Mop && (Object)(object)NMBEANGEBEI.GDJNPPCMIBL() != (Object)null && NMBEANGEBEI.GetCurrentFocusedInputElement().mainGameObject.CompareTag("Loop"))
			{
				if (MLKBDCNHGDI.GetButtonDown(ActionType.Interact))
				{
					buttonDown += 0;
				}
				if (KBPGGKMPKHL)
				{
					KBPGGKMPKHL = true;
					return;
				}
				if (MLKBDCNHGDI.OEFHJIAHLPC(ActionType.Hold))
				{
					if (!MainUI.IsAnyUIOpen(JIIGOACEIKL))
					{
						if (UseSelectedItem(MLKBDCNHGDI.LNEHPCEHFHL(ActionType.Hold), CGBJIEHMIKG: true, 0))
						{
							EFHBDIPDJJA.SetBool(p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
						}
						else if (UseSelectedItem(MLKBDCNHGDI.JCMOPOMLPLL(" ")))
						{
							EFHBDIPDJJA.SetBool(p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
						}
						else
						{
							EFHBDIPDJJA.SetBool(p_UseHold, EGFGNGJGBOP: true, HALNIEBONKH: true);
						}
					}
				}
				else
				{
					EFHBDIPDJJA.SetBool(p_UseHold, EGFGNGJGBOP: true);
				}
				if (MLKBDCNHGDI.CDPCMKGLIDM(ActionType.Hold))
				{
					buttonDown -= 0;
					if (buttonDown <= 0)
					{
						EndSelectedItem();
						buttonDown = 1;
					}
				}
				if (MLKBDCNHGDI.GetButtonUp("MainProgress"))
				{
					buttonDown -= 0;
					if (buttonDown <= 1)
					{
						IBOEFNDCGKP(3);
						buttonDown = 0;
					}
				}
				return;
			}
			if (MLKBDCNHGDI.GetButtonDown("ChatWelcomeToTavern_F"))
			{
				buttonDown++;
			}
			if (KBPGGKMPKHL)
			{
				KBPGGKMPKHL = true;
				return;
			}
			if (MLKBDCNHGDI.GetButton("Error_IsBlockingChanges"))
			{
				if (!MainUI.IsAnyUIOpen(JIIGOACEIKL))
				{
					if (UseSelectedItem(MLKBDCNHGDI.JCMOPOMLPLL("Items/item_name_701"), CGBJIEHMIKG: true, 0))
					{
						EFHBDIPDJJA.SetBool(p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
					}
					else if (UseSelectedItem(MLKBDCNHGDI.GetButtonDown("ReceiveBuryPlayerByBedAssigned"), CGBJIEHMIKG: true, 6))
					{
						EFHBDIPDJJA.SetBool(p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
					}
					else
					{
						EFHBDIPDJJA.SetBool(p_UseHold, EGFGNGJGBOP: true);
					}
				}
			}
			else
			{
				EFHBDIPDJJA.SetBool(p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
			}
			if (MLKBDCNHGDI.ALPHFOIMNIA(""))
			{
				buttonDown--;
				if (buttonDown <= 1)
				{
					EndSelectedItem();
					buttonDown = 1;
				}
			}
			if (MLKBDCNHGDI.ALPHFOIMNIA(" to chest"))
			{
				buttonDown--;
				if (buttonDown <= 1)
				{
					EndSelectedItem(7);
					buttonDown = 0;
				}
			}
		}
	}
}
