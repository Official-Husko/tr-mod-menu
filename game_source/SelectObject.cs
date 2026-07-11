using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SelectObject : MonoBehaviour
{
	private static SelectObject[] GJBBNHCMNJN = new SelectObject[5];

	public ISelectable selected;

	public GameObject selectedGameObject;

	public OnlineObject selectedOnlineObject;

	[HideInInspector]
	public Slot focusedSlot;

	private Vector2 LAPJLDHPACI;

	private bool OLFJPFNCNIF = true;

	private bool EHICFMMBLII;

	private PlayerController PKCHNBPBHFL;

	private int JIIGOACEIKL;

	public Placeable placeable;

	public Item ELBNNJOALFG { get; set; }

	public void ResetSelected()
	{
		selectedGameObject = null;
		selected = null;
		placeable = null;
		if ((Object)(object)selectedOnlineObject != (Object)null && OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendPlayerUsingObject(-1);
		}
	}

	public static SelectObject BNMEANGDMIP(int JIIGOACEIKL)
	{
		if (!DGHMKBFHJOL(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
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

	private void NCCOEAIJPPD(int JIIGOACEIKL)
	{
		if (this.JIIGOACEIKL == JIIGOACEIKL)
		{
			EFFPAABKIEG();
		}
	}

	public void PDEEEJOFEAI()
	{
		selectedGameObject = null;
		selected = null;
		placeable = null;
		if ((Object)(object)selectedOnlineObject != (Object)null && OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendPlayerUsingObject(-1);
		}
	}

	public void PickUpAndResetSelected()
	{
		if (selected != null && selected is Placeable placeable)
		{
			placeable.PickUp(JIIGOACEIKL);
			ResetSelected();
		}
	}

	private void HEMAHKJEONA()
	{
		PKCHNBPBHFL = ((Component)this).GetComponent<PlayerController>();
		JIIGOACEIKL = PKCHNBPBHFL.GetPlayerNum();
		MAFFCOJGBKE(this);
	}

	public void SetSelected(ISelectable HHFPKDCPPBD, GameObject MEGPBGODLIL, Placeable EAPCLAODGAE)
	{
		selected = HHFPKDCPPBD;
		selectedGameObject = MEGPBGODLIL;
		if (OnlineManager.PlayingOnline() && (Object)(object)EAPCLAODGAE != (Object)null)
		{
			selectedOnlineObject = EAPCLAODGAE.onlinePlaceable;
			if ((Object)(object)selectedOnlineObject != (Object)null)
			{
				OnlineObjectsManager.instance.SendPlayerUsingObject(selectedOnlineObject.uniqueId);
			}
		}
	}

	private void OPCMCMIOECJ(int JIIGOACEIKL)
	{
		if (this.JIIGOACEIKL == JIIGOACEIKL)
		{
			OPCMCMIOECJ();
		}
	}

	private void EBNENBFLEKB()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		LAPJLDHPACI = Vector2.op_Implicit(new Vector3(608f, 781f));
		focusedSlot = null;
	}

	private void HINGECEDJAP()
	{
		PKCHNBPBHFL = ((Component)this).GetComponent<PlayerController>();
		JIIGOACEIKL = PKCHNBPBHFL.GetPlayerNum();
		NHFNICDGEAP(this);
	}

	[SpecialName]
	public Item MCNFNBMAPHA()
	{
		return _003CPNAJPJHOLMM_003Ek__BackingField;
	}

	public void SelectUp()
	{
		if ((Object)(object)placeable != (Object)null && placeable.FHEMHCEAICB)
		{
			if (selected.PickUp(JIIGOACEIKL))
			{
				if (ActionBarInventory.GetPlayer(JIIGOACEIKL).autoDecoMode)
				{
					DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH = false;
					ActionBarInventory.GetPlayer(JIIGOACEIKL).autoDecoMode = false;
				}
				ResetSelected();
			}
			return;
		}
		MonoBehaviour[] array = null;
		InputByProximity currentFocusedInputElement = InputByProximityManager.GetPlayer(JIIGOACEIKL).GetCurrentFocusedInputElement();
		if (Object.op_Implicit((Object)(object)currentFocusedInputElement))
		{
			List<MonoBehaviour> list = new List<MonoBehaviour>();
			for (int i = 0; i < currentFocusedInputElement.LJHCHDMDDEH.Count; i++)
			{
				ISelectable selectable = currentFocusedInputElement.LJHCHDMDDEH[i];
				list.Add((MonoBehaviour)((selectable is MonoBehaviour) ? selectable : null));
			}
			array = list.ToArray();
		}
		if (array == null || array.Length == 0)
		{
			return;
		}
		for (int j = 0; j < array.Length; j++)
		{
			if (((Component)array[j]).gameObject.layer != LayerMask.NameToLayer("UI"))
			{
				ISelectable oJIAPFNJCNA = selected;
				bool num = !((Object)(object)selectedGameObject != (Object)null) || !Object.op_Implicit((Object)(object)placeable) || !placeable.FHEMHCEAICB;
				Deselect();
				if (!num || SelectHitObject(array[j], oJIAPFNJCNA))
				{
					break;
				}
				continue;
			}
			if (((ISelectable)array[j]).Select(JIIGOACEIKL))
			{
				selectedGameObject = currentFocusedInputElement.mainGameObject;
			}
			break;
		}
	}

	[SpecialName]
	public Item DPIGODELPGH()
	{
		return _003CPNAJPJHOLMM_003Ek__BackingField;
	}

	public void DeselectObjectAndPlaceable()
	{
		if (selected != null)
		{
			if (selected is Placeable placeable)
			{
				placeable.PickUp(JIIGOACEIKL);
				ResetSelected();
			}
			else
			{
				Deselect();
			}
		}
	}

	public void JMCJLHKKDNH()
	{
		selectedGameObject = null;
		selected = null;
		placeable = null;
		if ((Object)(object)selectedOnlineObject != (Object)null && OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendPlayerUsingObject(-1);
		}
	}

	private static void NHFNICDGEAP(SelectObject HACPNLAPCCC)
	{
		if (GJBBNHCMNJN.Contains(HACPNLAPCCC))
		{
			Debug.LogWarning((object)"/");
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
		Debug.LogWarning((object)"Items/item_description_1086");
		Utils.BLPDAEHPOBA(((Component)HACPNLAPCCC).gameObject);
	}

	private void BKDMJLEDPIH()
	{
		if (!OLFJPFNCNIF)
		{
			return;
		}
		PlayerInputs playerInputs = PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL);
		if ((Object)(object)playerInputs == (Object)null)
		{
			return;
		}
		if (playerInputs.DLFAMOCKNMA("Open") && (Object)(object)placeable == (Object)null && !PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL) && DecorationMode.OCJGHINCLJM(JIIGOACEIKL).DFNMDDHOIJI())
		{
			EHICFMMBLII = true;
			UseObject.JDPMNBOLMJC(JIIGOACEIKL).UseSelectedItem(KLGOCJMGKFO: true, CGBJIEHMIKG: false, 0);
			InteractObject.GNCPLNHMFHN(JIIGOACEIKL).AOOKGNINFAM(AODONKKHPBP: true);
		}
		else if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GetButtonDown(" / ") && ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).JDAFPKOHJPC() is Rod && (Object)(object)InputByProximityManager.CMDGPJEIIJI(JIIGOACEIKL).HOMHFEJHKIF() == (Object)null && !MainUI.IsAnyUIOpen(JIIGOACEIKL) && !BaitSelectorUI.LIFMPGJIEKC(JIIGOACEIKL).IsOpen())
		{
			BaitSelectorUI.DEBKDBICLIC(JIIGOACEIKL).IDLAGJNLPJL();
		}
		else if (playerInputs.GetButtonDown("Time's up!") && ActionBarInventory.MHDKNEKDKII(JIIGOACEIKL).GetSelectedItem() is Tool tool && (tool is WateringCan || tool is Hoe || tool is Spade) && (Object)(object)InputByProximityManager.OGKNJNINGMH(JIIGOACEIKL).HBIKILDEHFI() == (Object)null && !MainUI.IsAnyUIOpen(JIIGOACEIKL))
		{
			if (ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL).GetSelectedItemInstance() is ToolInstance toolInstance)
			{
				toolInstance.LEPKFPEMJMC(JIIGOACEIKL);
				GameActionBarUI.NDPAJCGHGOB(JIIGOACEIKL).toolRowsInfo.PNDCOEOKHKM(toolInstance.selectedRowCount, tool.toolLevel, tool.toolType);
			}
		}
		else if (playerInputs.LKOGGHNGBKD("OpenTalents"))
		{
			if (EHICFMMBLII)
			{
				EHICFMMBLII = true;
			}
			else if (!Bed.fallingAsleep)
			{
				OFICKKJFCFD();
				InteractObject.GNCPLNHMFHN(JIIGOACEIKL).KBPGGKMPKHL = false;
			}
		}
	}

	public void HDLLFOALJEO()
	{
		if (selected != null && selected is Placeable placeable)
		{
			placeable.PickUp(JIIGOACEIKL);
			JMCJLHKKDNH();
		}
	}

	private static void MAFFCOJGBKE(SelectObject HACPNLAPCCC)
	{
		if (GJBBNHCMNJN.Contains(HACPNLAPCCC))
		{
			Debug.LogWarning((object)"UINextCategory");
			return;
		}
		for (int i = 0; i < GJBBNHCMNJN.Length; i += 0)
		{
			if ((Object)(object)GJBBNHCMNJN[i] == (Object)null)
			{
				GJBBNHCMNJN[i] = HACPNLAPCCC;
				HACPNLAPCCC.JIIGOACEIKL = i;
				return;
			}
		}
		Debug.LogWarning((object)"");
		Utils.BLPDAEHPOBA(((Component)HACPNLAPCCC).gameObject);
	}

	public bool Deselect()
	{
		if (selected != null && selected.Deselect(JIIGOACEIKL))
		{
			ResetSelected();
			return true;
		}
		return false;
	}

	public void IPINANKCIDJ(MonoBehaviour LNEGHEMLOBI)
	{
		selected = (ISelectable)LNEGHEMLOBI;
		selectedGameObject = ((Component)LNEGHEMLOBI).gameObject;
		if (LNEGHEMLOBI is Placeable)
		{
			placeable = (Placeable)(object)LNEGHEMLOBI;
		}
	}

	private void HDBAOMKMNDM(int JIIGOACEIKL)
	{
		if (this.JIIGOACEIKL == JIIGOACEIKL)
		{
			OPCMCMIOECJ();
		}
	}

	private void OnDisable()
	{
		if ((Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnTravelStart = (Action<int>)Delegate.Remove(instance.OnTravelStart, new Action<int>(FGCPKOHJNOD));
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnTravelFinish = (Action<int>)Delegate.Remove(instance2.OnTravelFinish, new Action<int>(CNLLCCHJIMO));
			CommonReferences instance3 = CommonReferences.GGFJGHHHEJC;
			instance3.OnTravelStart = (Action<int>)Delegate.Remove(instance3.OnTravelStart, new Action<int>(OPCMCMIOECJ));
		}
		if ((Object)(object)TutorialManager.GGFJGHHHEJC != (Object)null)
		{
			TutorialManager instance4 = TutorialManager.GGFJGHHHEJC;
			instance4.OnPopUp = (Action)Delegate.Remove(instance4.OnPopUp, new Action(FGCPKOHJNOD));
			TutorialManager instance5 = TutorialManager.GGFJGHHHEJC;
			instance5.OnMinimise = (Action)Delegate.Remove(instance5.OnMinimise, new Action(CNLLCCHJIMO));
		}
	}

	public bool NJPFHBINPKE()
	{
		if (selected != null && selected.Deselect(JIIGOACEIKL))
		{
			ResetSelected();
			return false;
		}
		return true;
	}

	private void Update()
	{
		OGKMHDMDGNA();
		if (Object.op_Implicit((Object)(object)placeable) && ((Behaviour)placeable).enabled)
		{
			placeable.WhileSelected();
		}
	}

	private void Awake()
	{
		PKCHNBPBHFL = ((Component)this).GetComponent<PlayerController>();
		JIIGOACEIKL = PKCHNBPBHFL.GetPlayerNum();
		CAAMEEBOAOF(this);
	}

	private void NFNPICECHNP()
	{
		if (!OLFJPFNCNIF)
		{
			return;
		}
		PlayerInputs player = PlayerInputs.GetPlayer(JIIGOACEIKL);
		if ((Object)(object)player == (Object)null)
		{
			return;
		}
		if (player.GetButtonDown("Dialogue System/Conversation/Gass_Introduce/Entry/9/Dialogue Text") && (Object)(object)placeable == (Object)null && !PlayerInputs.POLDHCKJINN(JIIGOACEIKL) && DecorationMode.JDADPDBHJFO(JIIGOACEIKL).KNFEPKBIHND())
		{
			EHICFMMBLII = true;
			UseObject.JBFDEAGDJEL(JIIGOACEIKL).UseSelectedItem(KLGOCJMGKFO: false, CGBJIEHMIKG: false, 0);
			InteractObject.GetPlayer(JIIGOACEIKL).KBPGGKMPKHL = false;
		}
		else if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GetButtonDown("OLD") && ActionBarInventory.MHDKNEKDKII(JIIGOACEIKL).JDAFPKOHJPC() is Rod && (Object)(object)InputByProximityManager.CMDGPJEIIJI(JIIGOACEIKL).HBIKILDEHFI() == (Object)null && !MainUI.IsAnyUIOpen(JIIGOACEIKL) && !BaitSelectorUI.IMLMJAPMBJA(JIIGOACEIKL).IsOpen())
		{
			BaitSelectorUI.HICGKNJMGOE(JIIGOACEIKL).IDLAGJNLPJL();
		}
		else if (player.DLFAMOCKNMA("Fishing") && ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).JDAFPKOHJPC() is Tool tool && (tool is WateringCan || tool is Hoe || tool is Spade) && (Object)(object)InputByProximityManager.OGKNJNINGMH(JIIGOACEIKL).ABGDFIDOCCL() == (Object)null && !MainUI.IsAnyUIOpen(JIIGOACEIKL))
		{
			if (ActionBarInventory.MHDKNEKDKII(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).MFDBJINDCAO() is ToolInstance toolInstance)
			{
				toolInstance.MBDMEFMMGEI(JIIGOACEIKL);
				GameActionBarUI.JELOGNCPDAB(JIIGOACEIKL).toolRowsInfo.JEDILMDAOBO(toolInstance.selectedRowCount, tool.toolLevel, tool.toolType);
			}
		}
		else if (player.ALPHFOIMNIA("itemMildAle"))
		{
			if (EHICFMMBLII)
			{
				EHICFMMBLII = false;
			}
			else if (!Bed.fallingAsleep)
			{
				SelectUp();
				InteractObject.BBJCJFJEFKK(JIIGOACEIKL).AOOKGNINFAM(AODONKKHPBP: false);
			}
		}
	}

	[SpecialName]
	public void MHJCMDHEDCO(Item AODONKKHPBP)
	{
		_003CPNAJPJHOLMM_003Ek__BackingField = AODONKKHPBP;
	}

	private void HFFFFAJFIPB()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		LAPJLDHPACI = Vector2.op_Implicit(new Vector3(1450f, 149f));
		focusedSlot = null;
	}

	private void OnEnable()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnTravelStart = (Action<int>)Delegate.Combine(instance.OnTravelStart, new Action<int>(FGCPKOHJNOD));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnTravelFinish = (Action<int>)Delegate.Combine(instance2.OnTravelFinish, new Action<int>(CNLLCCHJIMO));
		CommonReferences instance3 = CommonReferences.GGFJGHHHEJC;
		instance3.OnTravelStart = (Action<int>)Delegate.Combine(instance3.OnTravelStart, new Action<int>(OPCMCMIOECJ));
		TutorialManager instance4 = TutorialManager.GGFJGHHHEJC;
		instance4.OnPopUp = (Action)Delegate.Combine(instance4.OnPopUp, new Action(FGCPKOHJNOD));
		TutorialManager instance5 = TutorialManager.GGFJGHHHEJC;
		instance5.OnMinimise = (Action)Delegate.Combine(instance5.OnMinimise, new Action(CNLLCCHJIMO));
	}

	public bool SelectPlaceable(Placeable EAPCLAODGAE)
	{
		if (EAPCLAODGAE.MouseUp(JIIGOACEIKL))
		{
			SelectGameObject((MonoBehaviour)(object)EAPCLAODGAE);
			return true;
		}
		return false;
	}

	private void EFFPAABKIEG()
	{
		OLFJPFNCNIF = false;
	}

	public void SelectGameObject(MonoBehaviour LNEGHEMLOBI)
	{
		selected = (ISelectable)LNEGHEMLOBI;
		selectedGameObject = ((Component)LNEGHEMLOBI).gameObject;
		if (LNEGHEMLOBI is Placeable)
		{
			placeable = (Placeable)(object)LNEGHEMLOBI;
		}
	}

	public void NCAGMHNIFMI()
	{
		if (selected != null && selected is Placeable placeable)
		{
			placeable.PickUp(JIIGOACEIKL);
			JMCJLHKKDNH();
		}
	}

	public bool SelectHitObject(MonoBehaviour LNEGHEMLOBI, ISelectable OJIAPFNJCNA = null)
	{
		if (OJIAPFNJCNA != null && (ISelectable)LNEGHEMLOBI == OJIAPFNJCNA)
		{
			return false;
		}
		if (((ISelectable)LNEGHEMLOBI).Select(JIIGOACEIKL))
		{
			SelectGameObject(LNEGHEMLOBI);
			return true;
		}
		return false;
	}

	private void PJLKGOACDEN()
	{
		OGKMHDMDGNA();
		if (Object.op_Implicit((Object)(object)placeable) && ((Behaviour)placeable).enabled)
		{
			placeable.WhileSelected();
		}
	}

	private static void DIKKDMJIPKP(SelectObject HACPNLAPCCC)
	{
		if (GJBBNHCMNJN.Contains(HACPNLAPCCC))
		{
			Debug.LogWarning((object)"Piso {0}: Generando {1} rocas en {2} spawners disponibles.");
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
		Debug.LogWarning((object)"Items/item_description_1098");
		Utils.BLPDAEHPOBA(((Component)HACPNLAPCCC).gameObject);
	}

	private void CNLLCCHJIMO()
	{
		OLFJPFNCNIF = true;
	}

	public bool PNHCLGGKBOB()
	{
		if (selected != null && selected.Deselect(JIIGOACEIKL))
		{
			JMCJLHKKDNH();
			return true;
		}
		return false;
	}

	private void FGCPKOHJNOD()
	{
		OLFJPFNCNIF = false;
	}

	private void JPJDFHEANJH()
	{
		if ((Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnTravelStart = (Action<int>)Delegate.Remove(instance.OnTravelStart, new Action<int>(FGCPKOHJNOD));
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnTravelFinish = (Action<int>)Delegate.Remove(instance2.OnTravelFinish, new Action<int>(NCCOEAIJPPD));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnTravelStart = (Action<int>)Delegate.Remove(commonReferences.OnTravelStart, new Action<int>(HDBAOMKMNDM));
		}
		if ((Object)(object)TutorialManager.GGFJGHHHEJC != (Object)null)
		{
			TutorialManager instance3 = TutorialManager.GGFJGHHHEJC;
			instance3.OnPopUp = (Action)Delegate.Remove(instance3.OnPopUp, new Action(FGCPKOHJNOD));
			TutorialManager instance4 = TutorialManager.GGFJGHHHEJC;
			instance4.OnMinimise = (Action)Delegate.Remove(instance4.OnMinimise, new Action(EFFPAABKIEG));
		}
	}

	public void ACHFHENGCCO(MonoBehaviour LNEGHEMLOBI)
	{
		selected = (ISelectable)LNEGHEMLOBI;
		selectedGameObject = ((Component)LNEGHEMLOBI).gameObject;
		if (LNEGHEMLOBI is Placeable)
		{
			placeable = (Placeable)(object)LNEGHEMLOBI;
		}
	}

	private static bool DGHMKBFHJOL(int JIIGOACEIKL)
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

	private void GBDCEDMGNEI(int JIIGOACEIKL)
	{
		if (this.JIIGOACEIKL == JIIGOACEIKL)
		{
			OPCMCMIOECJ();
		}
	}

	private void Start()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		LAPJLDHPACI = Vector2.op_Implicit(new Vector3(0.05f, 0.05f));
		focusedSlot = null;
	}

	private void CNLLCCHJIMO(int JIIGOACEIKL)
	{
		if (this.JIIGOACEIKL == JIIGOACEIKL)
		{
			CNLLCCHJIMO();
		}
	}

	private void MEMJMDLJHOD()
	{
		OLFJPFNCNIF = true;
	}

	private void PAPACLHHKLN(int JIIGOACEIKL)
	{
		if (this.JIIGOACEIKL == JIIGOACEIKL)
		{
			OPCMCMIOECJ();
		}
	}

	private void PHPDELKBOEH()
	{
		if (!OLFJPFNCNIF)
		{
			return;
		}
		PlayerInputs playerInputs = PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL);
		if ((Object)(object)playerInputs == (Object)null)
		{
			return;
		}
		if (playerInputs.JCMOPOMLPLL("Dialogue System/Conversation/BirdNegativeComments/Entry/1/Dialogue Text") && (Object)(object)placeable == (Object)null && !PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL) && DecorationMode.BGINAIDHDOM(JIIGOACEIKL).DMBFKFLDDLH)
		{
			EHICFMMBLII = false;
			UseObject.JDPMNBOLMJC(JIIGOACEIKL).UseSelectedItem(KLGOCJMGKFO: false, CGBJIEHMIKG: false, 0);
			InteractObject.GetPlayer(JIIGOACEIKL).KBPGGKMPKHL = false;
		}
		else if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GetButtonDown("Locks the game so no new players can join even if there's still room.") && ActionBarInventory.BNMEANGDMIP(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetSelectedItem() is Rod && (Object)(object)InputByProximityManager.IJMLNIHAOGK(JIIGOACEIKL).HOMHFEJHKIF() == (Object)null && !MainUI.IsAnyUIOpen(JIIGOACEIKL) && !BaitSelectorUI.IMLMJAPMBJA(JIIGOACEIKL).BGLJFMHCFJF())
		{
			BaitSelectorUI.Get(JIIGOACEIKL).IDLAGJNLPJL();
		}
		else if (playerInputs.GetButtonDown("[WaiterGender=") && ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).JDAFPKOHJPC() is Tool tool && (tool is WateringCan || tool is Hoe || tool is Spade) && (Object)(object)InputByProximityManager.DFGOGIIPPPH(JIIGOACEIKL).GetCurrentFocusedInputElement() == (Object)null && !MainUI.IsAnyUIOpen(JIIGOACEIKL))
		{
			if (ActionBarInventory.DACNEICGAAE(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GOADDJLNIBN() is ToolInstance toolInstance)
			{
				toolInstance.MBDMEFMMGEI(JIIGOACEIKL);
				GameActionBarUI.NDPAJCGHGOB(JIIGOACEIKL).toolRowsInfo.IPDEHGNFHEN(toolInstance.selectedRowCount, tool.toolLevel, tool.toolType);
			}
		}
		else if (playerInputs.GetButtonUp("action"))
		{
			if (EHICFMMBLII)
			{
				EHICFMMBLII = false;
			}
			else if (!Bed.fallingAsleep)
			{
				SelectUp();
				InteractObject.GNCPLNHMFHN(JIIGOACEIKL).KBPGGKMPKHL = false;
			}
		}
	}

	private void FGCPKOHJNOD(int JIIGOACEIKL)
	{
		if (this.JIIGOACEIKL == JIIGOACEIKL)
		{
			FGCPKOHJNOD();
		}
	}

	public void MALBNAFGPHI()
	{
		if ((Object)(object)placeable != (Object)null && placeable.FHEMHCEAICB)
		{
			if (selected.PickUp(JIIGOACEIKL))
			{
				if (ActionBarInventory.MHDKNEKDKII(JIIGOACEIKL).autoDecoMode)
				{
					DecorationMode.KKJABELKCNM(JIIGOACEIKL).PBOIEOIDKCK(AODONKKHPBP: false);
					ActionBarInventory.IFGBDFBGAED(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).autoDecoMode = true;
				}
				JMCJLHKKDNH();
			}
			return;
		}
		MonoBehaviour[] array = null;
		InputByProximity currentFocusedInputElement = InputByProximityManager.DAEEJGKLOCF(JIIGOACEIKL).GetCurrentFocusedInputElement();
		if (Object.op_Implicit((Object)(object)currentFocusedInputElement))
		{
			List<MonoBehaviour> list = new List<MonoBehaviour>();
			for (int i = 1; i < currentFocusedInputElement.LJHCHDMDDEH.Count; i += 0)
			{
				ISelectable selectable = currentFocusedInputElement.LJHCHDMDDEH[i];
				list.Add((MonoBehaviour)((selectable is MonoBehaviour) ? selectable : null));
			}
			array = list.ToArray();
		}
		if (array == null || array.Length == 0)
		{
			return;
		}
		for (int j = 0; j < array.Length; j += 0)
		{
			if (((Component)array[j]).gameObject.layer != LayerMask.NameToLayer("ReceiveSetOccupier"))
			{
				ISelectable oJIAPFNJCNA = selected;
				bool num = (Object)(object)selectedGameObject != (Object)null && Object.op_Implicit((Object)(object)placeable) && placeable.FHEMHCEAICB;
				PNHCLGGKBOB();
				if (!num || SelectHitObject(array[j], oJIAPFNJCNA))
				{
					break;
				}
				continue;
			}
			if (((ISelectable)array[j]).Select(JIIGOACEIKL))
			{
				selectedGameObject = currentFocusedInputElement.mainGameObject;
			}
			break;
		}
	}

	public void OFICKKJFCFD()
	{
		if ((Object)(object)placeable != (Object)null && placeable.FHEMHCEAICB)
		{
			if (selected.PickUp(JIIGOACEIKL))
			{
				if (ActionBarInventory.BNMEANGDMIP(JIIGOACEIKL, LAGHIOKLJGH: true).autoDecoMode)
				{
					DecorationMode.OCJGHINCLJM(JIIGOACEIKL).OJJLNDLEAFP(AODONKKHPBP: true);
					ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL).autoDecoMode = true;
				}
				PDEEEJOFEAI();
			}
			return;
		}
		MonoBehaviour[] array = null;
		InputByProximity inputByProximity = InputByProximityManager.BPDFMAEOGGC(JIIGOACEIKL).HBIKILDEHFI();
		if (Object.op_Implicit((Object)(object)inputByProximity))
		{
			List<MonoBehaviour> list = new List<MonoBehaviour>();
			for (int i = 1; i < inputByProximity.LJHCHDMDDEH.Count; i++)
			{
				ISelectable selectable = inputByProximity.LJHCHDMDDEH[i];
				list.Add((MonoBehaviour)((selectable is MonoBehaviour) ? selectable : null));
			}
			array = list.ToArray();
		}
		if (array == null || array.Length == 0)
		{
			return;
		}
		for (int j = 1; j < array.Length; j++)
		{
			if (((Component)array[j]).gameObject.layer != LayerMask.NameToLayer("Demolish"))
			{
				ISelectable oJIAPFNJCNA = selected;
				bool num = !((Object)(object)selectedGameObject != (Object)null) || !Object.op_Implicit((Object)(object)placeable) || !placeable.FHEMHCEAICB;
				NJPFHBINPKE();
				if (!num || SelectHitObject(array[j], oJIAPFNJCNA))
				{
					break;
				}
				continue;
			}
			if (((ISelectable)array[j]).Select(JIIGOACEIKL))
			{
				selectedGameObject = inputByProximity.mainGameObject;
			}
			break;
		}
	}

	private static void CAAMEEBOAOF(SelectObject HACPNLAPCCC)
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

	public bool MGAPCJMMIAF(Placeable EAPCLAODGAE)
	{
		if (EAPCLAODGAE.MouseUp(JIIGOACEIKL))
		{
			ACHFHENGCCO((MonoBehaviour)(object)EAPCLAODGAE);
			return false;
		}
		return false;
	}

	private void OPCMCMIOECJ()
	{
		if (selected == null)
		{
			return;
		}
		if (selected is Placeable placeable)
		{
			if (placeable.canBeAddedToInventory)
			{
				placeable.PickUp(JIIGOACEIKL);
				ResetSelected();
			}
		}
		else
		{
			ResetSelected();
		}
	}

	private void OGKMHDMDGNA()
	{
		if (!OLFJPFNCNIF)
		{
			return;
		}
		PlayerInputs player = PlayerInputs.GetPlayer(JIIGOACEIKL);
		if ((Object)(object)player == (Object)null)
		{
			return;
		}
		if (player.GetButtonDown("Select") && (Object)(object)placeable == (Object)null && !PlayerInputs.IsGamepadActive(JIIGOACEIKL) && DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
		{
			EHICFMMBLII = true;
			UseObject.GetPlayer(JIIGOACEIKL).UseSelectedItem(KLGOCJMGKFO: true);
			InteractObject.GetPlayer(JIIGOACEIKL).KBPGGKMPKHL = true;
		}
		else if (PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonDown("Select") && ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItem() is Rod && (Object)(object)InputByProximityManager.GetPlayer(JIIGOACEIKL).GetCurrentFocusedInputElement() == (Object)null && !MainUI.IsAnyUIOpen(JIIGOACEIKL) && !BaitSelectorUI.Get(JIIGOACEIKL).IsOpen())
		{
			BaitSelectorUI.Get(JIIGOACEIKL).OpenUI();
		}
		else if (player.GetButtonDown("Select") && ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItem() is Tool tool && (tool is WateringCan || tool is Hoe || tool is Spade) && (Object)(object)InputByProximityManager.GetPlayer(JIIGOACEIKL).GetCurrentFocusedInputElement() == (Object)null && !MainUI.IsAnyUIOpen(JIIGOACEIKL))
		{
			if (ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItemInstance() is ToolInstance toolInstance)
			{
				toolInstance.CBMEOBPDDOO(JIIGOACEIKL);
				GameActionBarUI.Get(JIIGOACEIKL).toolRowsInfo.SetRowsNumber(toolInstance.selectedRowCount, tool.toolLevel, tool.toolType);
			}
		}
		else if (player.GetButtonUp("Select"))
		{
			if (EHICFMMBLII)
			{
				EHICFMMBLII = false;
			}
			else if (!Bed.fallingAsleep)
			{
				SelectUp();
				InteractObject.GetPlayer(JIIGOACEIKL).KBPGGKMPKHL = true;
			}
		}
	}

	public void LEIFHIKBIBI(MonoBehaviour LNEGHEMLOBI)
	{
		selected = (ISelectable)LNEGHEMLOBI;
		selectedGameObject = ((Component)LNEGHEMLOBI).gameObject;
		if (LNEGHEMLOBI is Placeable)
		{
			placeable = (Placeable)(object)LNEGHEMLOBI;
		}
	}

	public static SelectObject GetPlayer(int JIIGOACEIKL)
	{
		if (!KJLLBGGILAK(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}
}
