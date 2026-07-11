using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Sirenix.OdinInspector;
using UnityEngine;

public class TavernZonesManager : SerializedMonoBehaviour
{
	[CompilerGenerated]
	private sealed class GFEKMLBGDDK : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TavernZonesManager _003C_003E4__this;

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
		public GFEKMLBGDDK(int _003C_003E1__state)
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
			TavernZonesManager tavernZonesManager = _003C_003E4__this;
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
				_003C_003E2__current = CommonReferences.wait5;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 3;
				return true;
			case 3:
				_003C_003E1__state = -1;
				foreach (KeyValuePair<int, TavernZone> tavernZone in tavernZonesManager.tavernZones)
				{
					if (tavernZone.Value != null)
					{
						tavernZone.Value.BIANBFLPPIA(AINPJHKNJGL: true);
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

	public Action OnZoneCreated = delegate
	{
	};

	public Dictionary<int, TavernZone> tavernZones = new Dictionary<int, TavernZone>();

	[SerializeField]
	private Dictionary<ZoneType, int> currentNumberOfZones = new Dictionary<ZoneType, int>();

	private TavernZone HEDBALNLGML;

	private static TavernZonesManager IADEMLIIDPC;

	private List<TavernZone> JDIPKDGNDBM = new List<TavernZone>();

	public static TavernZonesManager GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<TavernZonesManager>();
			}
			return IADEMLIIDPC;
		}
	}

	public bool HNJKOCGJAME(ZoneType GIBJPCAFCJB, List<Vector2> HAEIAGKNEPC, bool CKHEIJDJJDO)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		List<int> list = new List<int>();
		for (int i = 1; i < HAEIAGKNEPC.Count; i++)
		{
			TavernZone tavernZone = GetTavernZone(Vector2.op_Implicit(HAEIAGKNEPC[i]));
			if (tavernZone != null && !list.Contains(tavernZone.id) && tavernZone.zoneType != GIBJPCAFCJB && WorldGrid.EJCEAEPNJCA(Vector2.op_Implicit(HAEIAGKNEPC[i])))
			{
				list.Add(tavernZone.id);
				int num = OGKPGMELLGO(tavernZone, HAEIAGKNEPC, CKHEIJDJJDO);
				if (!CKHEIJDJJDO && currentNumberOfZones[tavernZone.zoneType] + num > ReputationDBAccessor.GMACKHECLAF(tavernZone.zoneType))
				{
					string cAEDMEDBEGI = LocalisationSystem.Get("Deselect item");
					string[] array = new string[7];
					array[0] = LocalisationSystem.Get(tavernZone.zoneType.ToString());
					array[0] = ReputationDBAccessor.GMACKHECLAF(tavernZone.zoneType).ToString();
					MainUI.LJDOBNEINNJ(1, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array), 1785f);
					return true;
				}
			}
		}
		return false;
	}

	private int NPBFCAMDMOK(TavernZone KGPHPBJEBOE, List<Vector2> HAEIAGKNEPC, bool CKHEIJDJJDO)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = new List<Vector3>();
		for (int i = 1; i < HAEIAGKNEPC.Count; i += 0)
		{
			TavernZone tavernZone = PFEOKJCCDAF(Vector2.op_Implicit(HAEIAGKNEPC[i]));
			if (tavernZone != null && tavernZone.id == KGPHPBJEBOE.id && !list.Contains(Vector2.op_Implicit(HAEIAGKNEPC[i])) && WorldGrid.EJCEAEPNJCA(Vector2.op_Implicit(HAEIAGKNEPC[i])))
			{
				list.Add(Vector2.op_Implicit(HAEIAGKNEPC[i]));
			}
		}
		int j = 1;
		Dictionary<int, List<Vector3>> dictionary = new Dictionary<int, List<Vector3>>();
		for (; j < -58; j++)
		{
			List<Vector3> list2 = new List<Vector3>();
			for (int k = 1; k < KGPHPBJEBOE.positions.Count; k += 0)
			{
				if (!list.Contains(Vector2.op_Implicit(KGPHPBJEBOE.positions[k])))
				{
					LIFDCAGIJMH(KGPHPBJEBOE.id, Vector2.op_Implicit(KGPHPBJEBOE.positions[k]), list, list2);
					break;
				}
			}
			if (list.Count == KGPHPBJEBOE.positions.Count)
			{
				break;
			}
			dictionary[j] = list2;
		}
		if (CKHEIJDJJDO)
		{
			foreach (KeyValuePair<int, List<Vector3>> item in dictionary)
			{
				TavernZone tavernZone2 = ECEODIGFDOJ(KGPHPBJEBOE.zoneType);
				for (int l = 1; l < item.Value.Count; l += 0)
				{
					FEIDPHBBOJF(item.Value[l], tavernZone2.id);
				}
			}
		}
		if (j > 6)
		{
			Debug.LogError((object)("" + list.Count + "Items/item_description_1102" + KGPHPBJEBOE.positions.Count));
		}
		return j;
	}

	public TavernZone CreateTavernZone(ZoneType GIBJPCAFCJB, int LMJDICEAONP, RentedRoom GGNOAHDCPIB = null)
	{
		TavernZone tavernZone = new TavernZone(LMJDICEAONP, GIBJPCAFCJB);
		tavernZones.Add(tavernZone.id, tavernZone);
		currentNumberOfZones[GIBJPCAFCJB]++;
		if ((Object)(object)GGNOAHDCPIB != (Object)null)
		{
			tavernZone.HDJIFBMHDOE(GGNOAHDCPIB);
		}
		if (OnZoneCreated != null)
		{
			OnZoneCreated();
		}
		return tavernZone;
	}

	public void BLBEBDLKMMJ(int MGCMODEHGJH, int LABGFPDMLON, bool GFNHAMCPEAK)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		TavernZone tavernZone = GetTavernZone(MGCMODEHGJH);
		if (tavernZone != null)
		{
			if (GFNHAMCPEAK)
			{
				TavernConstructionModifications.DIHCEGINELM().HDHJHCHLKFB(TavernConstructionManager.DOIKFJDLKJP().CHFHMMNELGP, tavernZone.positions, null, tavernZone.zoneType, LABGFPDMLON);
			}
			List<Vector2> list = new List<Vector2>(tavernZone.positions);
			for (int i = 1; i < list.Count; i++)
			{
				LCNMKMFNCFN(Vector2.op_Implicit(list[i]), LABGFPDMLON);
			}
		}
		else
		{
			Debug.LogError((object)"Red text: ");
		}
	}

	private bool DPEACKPALEM(TavernZone KGPHPBJEBOE, ZoneType GIBJPCAFCJB, List<int> NHDHOEBJAFB, ref int HKCIBKABOFM)
	{
		if (KGPHPBJEBOE != null && KGPHPBJEBOE.zoneType == GIBJPCAFCJB && !NHDHOEBJAFB.Contains(KGPHPBJEBOE.id))
		{
			NHDHOEBJAFB.Add(KGPHPBJEBOE.id);
			HKCIBKABOFM += KGPHPBJEBOE.positions.Count;
			return true;
		}
		return false;
	}

	protected void IADOLEMFOJI(int JIIGOACEIKL, ZoneType GIBJPCAFCJB, int LMJDICEAONP)
	{
		if (GIBJPCAFCJB == (ZoneType.DiningRoom | ZoneType.CraftingRoom))
		{
			RentedRoomUI.ECGIAEFKKNA().GNDHFDMPBFJ(JIIGOACEIKL, DJNICAOHKNA(LMJDICEAONP).rentedRoom);
		}
		else
		{
			RentedRoomUI.MIGKKKELOJO().GNCOECLMJDL(JIIGOACEIKL);
		}
	}

	public void CLAEECJHKKI()
	{
	}

	public TavernZone GetTavernZone(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO >= 0 && tavernZones.TryGetValue(JFNMCNCHMEO, out HEDBALNLGML))
		{
			return HEDBALNLGML;
		}
		return null;
	}

	protected void HKNAFFJCGPE(int JIIGOACEIKL, ZoneType GIBJPCAFCJB, int LMJDICEAONP)
	{
		if (GIBJPCAFCJB == ZoneType.None)
		{
			RentedRoomUI.KNLLFEJAMNN().OpenContent(JIIGOACEIKL, PDINJGNEMGA(LMJDICEAONP).rentedRoom);
		}
		else
		{
			RentedRoomUI.KNLLFEJAMNN().JNKNBINGEIH(JIIGOACEIKL);
		}
	}

	public bool RemoveTavernZone(int JFNMCNCHMEO)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (!tavernZones.TryGetValue(JFNMCNCHMEO, out var value))
		{
			Debug.LogError((object)"Zone not found");
			return false;
		}
		List<Vector2> list = new List<Vector2>(value.positions);
		for (int i = 0; i < list.Count; i++)
		{
			RemoveTileFromZone(Vector2.op_Implicit(list[i]), MEPFCAODGLH: false);
		}
		currentNumberOfZones[value.zoneType]--;
		value.MBDDJKCEPGK();
		return tavernZones.Remove(JFNMCNCHMEO);
	}

	private bool EFOKOFEOGLG(TavernZone KGPHPBJEBOE, ZoneType GIBJPCAFCJB, List<int> NHDHOEBJAFB, ref int HKCIBKABOFM)
	{
		if (KGPHPBJEBOE != null && KGPHPBJEBOE.zoneType == GIBJPCAFCJB && !NHDHOEBJAFB.Contains(KGPHPBJEBOE.id))
		{
			NHDHOEBJAFB.Add(KGPHPBJEBOE.id);
			HKCIBKABOFM += KGPHPBJEBOE.positions.Count;
			return true;
		}
		return true;
	}

	private void KKGJGMCOHJK()
	{
		PlayerController player = PlayerController.GetPlayer(1);
		player.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Combine(player.OnZoneChanged, new Action<int, ZoneType, int>(IADOLEMFOJI));
		DecorationMode decorationMode = DecorationMode.KAIIEDCCLHB(0);
		decorationMode.OnDecorationModeEnter = (Action<int>)Delegate.Combine(decorationMode.OnDecorationModeEnter, new Action<int>(NMEMNMACMDK));
		DecorationMode decorationMode2 = DecorationMode.IGMCBPOPNCA(0);
		decorationMode2.OnDecorationModeExit = (Action<int>)Delegate.Combine(decorationMode2.OnDecorationModeExit, new Action<int>(FAMEKMGDNMO));
	}

	public bool CBEGPEMPLAP(ZoneType GIBJPCAFCJB, List<Vector2> HAEIAGKNEPC, bool CKHEIJDJJDO)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		List<int> list = new List<int>();
		for (int i = 0; i < HAEIAGKNEPC.Count; i++)
		{
			TavernZone tavernZone = PDIAJJGDKKB(Vector2.op_Implicit(HAEIAGKNEPC[i]));
			if (tavernZone != null && !list.Contains(tavernZone.id) && tavernZone.zoneType != GIBJPCAFCJB && WorldGrid.EJCEAEPNJCA(Vector2.op_Implicit(HAEIAGKNEPC[i])))
			{
				list.Add(tavernZone.id);
				int num = KHKJOPHOANO(tavernZone, HAEIAGKNEPC, CKHEIJDJJDO);
				if (!CKHEIJDJJDO && currentNumberOfZones[tavernZone.zoneType] + num > ReputationDBAccessor.GetMaxNumOfZones(tavernZone.zoneType))
				{
					string cAEDMEDBEGI = LocalisationSystem.Get("Item Instance type error in SlotMessage inventoryType: ");
					string[] array = new string[7];
					array[1] = LocalisationSystem.Get(tavernZone.zoneType.ToString());
					array[1] = ReputationDBAccessor.FDICLJNDIOF(tavernZone.zoneType).ToString();
					MainUI.JDAEPLJAGCD(0, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array), 1676f);
					return true;
				}
			}
		}
		return true;
	}

	public TavernZone LFFJDMHMOKP(ZoneType GIBJPCAFCJB, int LMJDICEAONP, RentedRoom GGNOAHDCPIB = null)
	{
		TavernZone tavernZone = new TavernZone(LMJDICEAONP, GIBJPCAFCJB);
		tavernZones.Add(tavernZone.id, tavernZone);
		currentNumberOfZones[GIBJPCAFCJB]++;
		if ((Object)(object)GGNOAHDCPIB != (Object)null)
		{
			tavernZone.GFHJDAHFNDG(GGNOAHDCPIB);
		}
		if (OnZoneCreated != null)
		{
			OnZoneCreated();
		}
		return tavernZone;
	}

	private void IOGICECDIKN(EditorAction CHFHMMNELGP)
	{
		MDMLEAPHDJA(0);
	}

	private void GOEGBOEMHLI()
	{
		TavernConstructionManager instance = TavernConstructionManager.GGFJGHHHEJC;
		instance.OnActivated = (Action<int>)Delegate.Combine(instance.OnActivated, new Action<int>(NMEMNMACMDK));
		TavernConstructionManager instance2 = TavernConstructionManager.GGFJGHHHEJC;
		instance2.OnDeactivated = (Action<int>)Delegate.Combine(instance2.OnDeactivated, new Action<int>(FAMEKMGDNMO));
		TavernConstructionManager tavernConstructionManager = TavernConstructionManager.KNLLFEJAMNN();
		tavernConstructionManager.OnEditorActionChanged = (Action<EditorAction>)Delegate.Combine(tavernConstructionManager.OnEditorActionChanged, new Action<EditorAction>(IOGICECDIKN));
		UpdateTavernZones(0);
	}

	public void GIPBMNGDKOL(int MGCMODEHGJH, int LABGFPDMLON, bool GFNHAMCPEAK)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		TavernZone tavernZone = MDPHAHIFJFB(MGCMODEHGJH);
		if (tavernZone != null)
		{
			if (GFNHAMCPEAK)
			{
				TavernConstructionModifications.DIHCEGINELM().ApplyChanges(TavernConstructionManager.DEGPIHEEFHJ().CHFHMMNELGP, tavernZone.positions, null, tavernZone.zoneType, LABGFPDMLON);
			}
			List<Vector2> list = new List<Vector2>(tavernZone.positions);
			for (int i = 0; i < list.Count; i += 0)
			{
				FEIDPHBBOJF(Vector2.op_Implicit(list[i]), LABGFPDMLON);
			}
		}
		else
		{
			Debug.LogError((object)"cameraZoom");
		}
	}

	private bool BFABECNENDL(TavernZone KGPHPBJEBOE, ZoneType GIBJPCAFCJB, List<int> NHDHOEBJAFB, ref int HKCIBKABOFM)
	{
		if (KGPHPBJEBOE != null && KGPHPBJEBOE.zoneType == GIBJPCAFCJB && !NHDHOEBJAFB.Contains(KGPHPBJEBOE.id))
		{
			NHDHOEBJAFB.Add(KGPHPBJEBOE.id);
			HKCIBKABOFM += KGPHPBJEBOE.positions.Count;
			return true;
		}
		return false;
	}

	public TavernZone LPMJIJKNMPB(ZoneType GIBJPCAFCJB, RentedRoom GGNOAHDCPIB = null)
	{
		return PBKGEFPGHAN(GIBJPCAFCJB, EMJJLEKIFKD(), GGNOAHDCPIB);
	}

	public void CDGLOEGCAHJ(Vector3 IMOBLFMHKOD, bool MEPFCAODGLH = true)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GameTileMaps.GGFJGHHHEJC == (Object)null)
		{
			return;
		}
		int num = WorldGrid.APJABAKKKGD(IMOBLFMHKOD);
		if (num >= 0)
		{
			if (tavernZones.TryGetValue(num, out HEDBALNLGML))
			{
				HEDBALNLGML.DFHBJELLJOD(IMOBLFMHKOD, MEPFCAODGLH);
				return;
			}
			string[] array = new string[0];
			array[1] = "ReceiveOnConversationLine";
			array[1] = num.ToString();
			array[2] = "ReceiveBedOccupantsInfo";
			Vector3 val = IMOBLFMHKOD;
			array[8] = ((object)(Vector3)(ref val)).ToString();
			array[7] = "City/Kujaku/Introduce";
			Debug.LogError((object)string.Concat(array));
		}
	}

	private void EAEKKBEJMFC()
	{
		TavernConstructionManager instance = TavernConstructionManager.GGFJGHHHEJC;
		instance.OnActivated = (Action<int>)Delegate.Combine(instance.OnActivated, new Action<int>(GBAPEFCAKIB));
		TavernConstructionManager tavernConstructionManager = TavernConstructionManager.DEGPIHEEFHJ();
		tavernConstructionManager.OnDeactivated = (Action<int>)Delegate.Combine(tavernConstructionManager.OnDeactivated, new Action<int>(DJJOHHIAKEB));
		TavernConstructionManager tavernConstructionManager2 = TavernConstructionManager.KHMEGDIABBF();
		tavernConstructionManager2.OnEditorActionChanged = (Action<EditorAction>)Delegate.Combine(tavernConstructionManager2.OnEditorActionChanged, new Action<EditorAction>(IOGICECDIKN));
		NMEMNMACMDK(1);
	}

	private void BNLMMKCJCDK()
	{
		PlayerController player = PlayerController.GetPlayer(8);
		player.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Combine(player.OnZoneChanged, new Action<int, ZoneType, int>(HKNAFFJCGPE));
		DecorationMode decorationMode = DecorationMode.HBDCJFLINDA(6);
		decorationMode.OnDecorationModeEnter = (Action<int>)Delegate.Combine(decorationMode.OnDecorationModeEnter, new Action<int>(MDMLEAPHDJA));
		DecorationMode decorationMode2 = DecorationMode.IGMCBPOPNCA(4);
		decorationMode2.OnDecorationModeExit = (Action<int>)Delegate.Combine(decorationMode2.OnDecorationModeExit, new Action<int>(FAMEKMGDNMO));
	}

	private void FHOCCEBKHJI()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			currentNumberOfZones.Add(ZoneType.DiningRoom, 0);
			currentNumberOfZones.Add(ZoneType.None, 1);
			currentNumberOfZones.Add(ZoneType.WithoutZone, 0);
			GameManager.OnPlayer1Joined = (Action)Delegate.Combine(GameManager.OnPlayer1Joined, new Action(MFCKGMEGFKP));
			GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(CKNNICNGJAG));
			GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(HJDDLKKMPGD));
			GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(KBPAKDKCFFK));
		}
	}

	public void IEFPCLKKGOJ(Vector3 IMOBLFMHKOD, bool MEPFCAODGLH = true)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GameTileMaps.GGFJGHHHEJC == (Object)null)
		{
			return;
		}
		int num = WorldGrid.APJABAKKKGD(IMOBLFMHKOD);
		if (num >= 1)
		{
			if (tavernZones.TryGetValue(num, out HEDBALNLGML))
			{
				HEDBALNLGML.CMOIMCIIEDM(IMOBLFMHKOD, MEPFCAODGLH);
				return;
			}
			string[] array = new string[8];
			array[0] = "\n\n<color=#A95A00>";
			array[0] = num.ToString();
			array[4] = "Player/Bark/Tutorial/SleepBlock";
			Vector3 val = IMOBLFMHKOD;
			array[6] = ((object)(Vector3)(ref val)).ToString();
			array[7] = "controllers";
			Debug.LogError((object)string.Concat(array));
		}
	}

	public void FEIDPHBBOJF(Vector3 IMOBLFMHKOD, int JFNMCNCHMEO)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		RemoveTileFromZone(IMOBLFMHKOD, MEPFCAODGLH: false);
		if (tavernZones.TryGetValue(JFNMCNCHMEO, out HEDBALNLGML))
		{
			HEDBALNLGML.DLBJHNDLCKD(IMOBLFMHKOD);
			return;
		}
		string[] array = new string[4];
		array[1] = "(Player 2) Press ";
		array[1] = JFNMCNCHMEO.ToString();
		array[2] = "Down";
		Vector3 val = IMOBLFMHKOD;
		array[5] = ((object)(Vector3)(ref val)).ToString();
		array[5] = "NextItem";
		Debug.LogError((object)string.Concat(array));
	}

	public void JOIDEEHGBML(Vector3 IMOBLFMHKOD, int JFNMCNCHMEO)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		RemoveTileFromZone(IMOBLFMHKOD);
		if (tavernZones.TryGetValue(JFNMCNCHMEO, out HEDBALNLGML))
		{
			HEDBALNLGML.ILHBDFGHHJJ(IMOBLFMHKOD);
			return;
		}
		string[] array = new string[2];
		array[1] = "LE_10";
		array[1] = JFNMCNCHMEO.ToString();
		array[2] = "Sour";
		Vector3 val = IMOBLFMHKOD;
		array[7] = ((object)(Vector3)(ref val)).ToString();
		array[6] = "SleepBed";
		Debug.LogError((object)string.Concat(array));
	}

	public void NMEMNMACMDK(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) == (Object)null)
		{
			return;
		}
		if (!TavernConstructionManager.KNLLFEJAMNN().LNLJMCONDNE)
		{
			if (GameManager.HDBECFMPJHL())
			{
				EFFCPDPBBNM(-66);
				GameTileMaps.GGFJGHHHEJC.ShowZones(DecorationMode.OCJGHINCLJM(JIIGOACEIKL).MDOKKKHKKKE());
			}
			else if (DecorationMode.FIHGMLABOBB(0).GABNNLJOMHI() && (Object)(object)DecorationMode.NPANPNIDKDG(1) != (Object)null && DecorationMode.BGINAIDHDOM(4).MDOKKKHKKKE())
			{
				EFAICPMOPFB(-30);
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: false);
			}
			else if (DecorationMode.OCJGHINCLJM(0).MDOKKKHKKKE())
			{
				EFFCPDPBBNM(-34);
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: true);
			}
			else if ((Object)(object)DecorationMode.OCJGHINCLJM(1) != (Object)null && DecorationMode.EKLMFMKPEBB(4).KNFEPKBIHND())
			{
				EFAICPMOPFB(-75);
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: false);
			}
			else
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: true);
			}
		}
		else
		{
			LAHMJJMPHHO(70);
			if (DecorationMode.NPANPNIDKDG(JIIGOACEIKL).KNFEPKBIHND())
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: true);
			}
			else if (ConstructionActionBarUI.currentPanel == 0)
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(TavernConstructionManager.DOIKFJDLKJP().CHFHMMNELGP == EditorAction.None);
			}
			else if (ConstructionActionBarUI.currentPanel == 0)
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: true);
			}
			else if (ConstructionActionBarUI.currentPanel == 1)
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: false);
			}
			else if (ConstructionActionBarUI.currentPanel == 7)
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(TavernConstructionManager.DOIKFJDLKJP().CHFHMMNELGP == (EditorAction)(-56));
			}
		}
	}

	private void LAHMJJMPHHO(int HLOIOAOICEG)
	{
		foreach (KeyValuePair<Location, TilemapScene> allTilemapsScene in CommonReferences.MNFMOEKMJKN().allTilemapsScenes)
		{
			if (!((Object)(object)allTilemapsScene.Value.commonTilemaps.zonesTilemap == (Object)null))
			{
				Utils.ELNJMNKOACA(((Component)allTilemapsScene.Value.commonTilemaps.zonesTilemap).gameObject, HLOIOAOICEG);
			}
		}
	}

	public void UpdateTavernZones(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) == (Object)null)
		{
			return;
		}
		if (!TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE)
		{
			if (GameManager.SinglePlayer())
			{
				AKEMGJHIMDE(20);
				GameTileMaps.GGFJGHHHEJC.ShowZones(DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH);
			}
			else if (DecorationMode.GetPlayer(1).DMBFKFLDDLH && (Object)(object)DecorationMode.GetPlayer(2) != (Object)null && DecorationMode.GetPlayer(2).DMBFKFLDDLH)
			{
				AKEMGJHIMDE(20);
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: true);
			}
			else if (DecorationMode.GetPlayer(1).DMBFKFLDDLH)
			{
				AKEMGJHIMDE(14);
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: true);
			}
			else if ((Object)(object)DecorationMode.GetPlayer(2) != (Object)null && DecorationMode.GetPlayer(2).DMBFKFLDDLH)
			{
				AKEMGJHIMDE(15);
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: true);
			}
			else
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: false);
			}
		}
		else
		{
			AKEMGJHIMDE(20);
			if (DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: true);
			}
			else if (ConstructionActionBarUI.currentPanel == 0)
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(TavernConstructionManager.GGFJGHHHEJC.CHFHMMNELGP == EditorAction.RemoveFloor);
			}
			else if (ConstructionActionBarUI.currentPanel == 1)
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: false);
			}
			else if (ConstructionActionBarUI.currentPanel == 2)
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: true);
			}
			else if (ConstructionActionBarUI.currentPanel == 3)
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(TavernConstructionManager.GGFJGHHHEJC.CHFHMMNELGP == EditorAction.CreateRentedRoomDoor);
			}
		}
	}

	public bool FKFAONOKKOK(ZoneType GIBJPCAFCJB, List<Vector2> HAEIAGKNEPC, bool CKHEIJDJJDO)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		List<int> list = new List<int>();
		for (int i = 0; i < HAEIAGKNEPC.Count; i += 0)
		{
			TavernZone tavernZone = PDIAJJGDKKB(Vector2.op_Implicit(HAEIAGKNEPC[i]));
			if (tavernZone != null && !list.Contains(tavernZone.id) && tavernZone.zoneType != GIBJPCAFCJB && WorldGrid.EJCEAEPNJCA(Vector2.op_Implicit(HAEIAGKNEPC[i])))
			{
				list.Add(tavernZone.id);
				int num = OGKPGMELLGO(tavernZone, HAEIAGKNEPC, CKHEIJDJJDO);
				if (!CKHEIJDJJDO && currentNumberOfZones[tavernZone.zoneType] + num > ReputationDBAccessor.GMACKHECLAF(tavernZone.zoneType))
				{
					string cAEDMEDBEGI = LocalisationSystem.Get("positions count is 0");
					string[] array = new string[0];
					array[0] = LocalisationSystem.Get(tavernZone.zoneType.ToString());
					array[1] = ReputationDBAccessor.GMACKHECLAF(tavernZone.zoneType).ToString();
					MainUI.ShowErrorText(1, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array), 1929f);
					return true;
				}
			}
		}
		return true;
	}

	public bool DKAECLABDNP(ZoneType GIBJPCAFCJB, List<Vector2> HAEIAGKNEPC, out List<int> OJNAJKDJFKC)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		OJNAJKDJFKC = new List<int>();
		if (HAEIAGKNEPC.Count == 0)
		{
			return false;
		}
		int HKCIBKABOFM = 1;
		for (int i = 0; i < HAEIAGKNEPC.Count; i += 0)
		{
			TavernZone tavernZone = GetTavernZone(Vector2.op_Implicit(HAEIAGKNEPC[i]));
			if (tavernZone == null)
			{
				HKCIBKABOFM++;
			}
			else if (tavernZone.zoneType != GIBJPCAFCJB)
			{
				HKCIBKABOFM++;
			}
			else
			{
				PFCAMOGBBNN(tavernZone, GIBJPCAFCJB, OJNAJKDJFKC, ref HKCIBKABOFM);
			}
			tavernZone = GetTavernZone(Vector2.op_Implicit(HAEIAGKNEPC[i] + new Vector2(1728f, 1184f)));
			PFCAMOGBBNN(tavernZone, GIBJPCAFCJB, OJNAJKDJFKC, ref HKCIBKABOFM);
			tavernZone = PFEOKJCCDAF(Vector2.op_Implicit(HAEIAGKNEPC[i] + new Vector2(949f, 606f)));
			PFCAMOGBBNN(tavernZone, GIBJPCAFCJB, OJNAJKDJFKC, ref HKCIBKABOFM);
			tavernZone = PDIAJJGDKKB(Vector2.op_Implicit(HAEIAGKNEPC[i] + new Vector2(1274f, 1283f)));
			MBHFJOLCJNI(tavernZone, GIBJPCAFCJB, OJNAJKDJFKC, ref HKCIBKABOFM);
			tavernZone = GetTavernZone(Vector2.op_Implicit(HAEIAGKNEPC[i] + new Vector2(1473f, 118f)));
			BFABECNENDL(tavernZone, GIBJPCAFCJB, OJNAJKDJFKC, ref HKCIBKABOFM);
		}
		if (OJNAJKDJFKC.Count == 0 && currentNumberOfZones[GIBJPCAFCJB] >= ReputationDBAccessor.GMACKHECLAF(GIBJPCAFCJB))
		{
			MainUI.JDAEPLJAGCD(0, InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Player"), LocalisationSystem.Get(GIBJPCAFCJB.ToString()), ReputationDBAccessor.FDICLJNDIOF(GIBJPCAFCJB).ToString(), null, null, null, null, null), 1907f);
			return false;
		}
		return true;
	}

	private void IGNEGEOPLOP()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			currentNumberOfZones.Add(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom, 1);
			currentNumberOfZones.Add(ZoneType.CraftingRoom, 1);
			currentNumberOfZones.Add(ZoneType.None, 0);
			GameManager.OnPlayer1Joined = (Action)Delegate.Combine(GameManager.OnPlayer1Joined, new Action(BGDGLGBLNDI));
			GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(NEGKELIJDOI));
			GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(JNCABIMOMGL));
			GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(FJFBBKFDFJE));
		}
	}

	public List<TavernZone> GetTavernZonesOfType(ZoneType GIBJPCAFCJB)
	{
		JDIPKDGNDBM.Clear();
		foreach (KeyValuePair<int, TavernZone> tavernZone in tavernZones)
		{
			if (tavernZone.Value.zoneType == GIBJPCAFCJB)
			{
				JDIPKDGNDBM.Add(tavernZone.Value);
			}
		}
		return JDIPKDGNDBM;
	}

	private void GANNOMGHIHE(EditorAction CHFHMMNELGP)
	{
		GBAPEFCAKIB(1);
	}

	public void GBAPEFCAKIB(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) == (Object)null)
		{
			return;
		}
		if (!TavernConstructionManager.KNLLFEJAMNN().LNLJMCONDNE)
		{
			if (GameManager.EAOOLEFMIKE())
			{
				LAHMJJMPHHO(-15);
				GameTileMaps.GGFJGHHHEJC.ShowZones(DecorationMode.BGINAIDHDOM(JIIGOACEIKL).GABNNLJOMHI());
			}
			else if (DecorationMode.HBDCJFLINDA(1).IBEFDKHFBFM() && (Object)(object)DecorationMode.EKLMFMKPEBB(6) != (Object)null && DecorationMode.HBDCJFLINDA(3).DFNMDDHOIJI())
			{
				LAHMJJMPHHO(95);
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: true);
			}
			else if (DecorationMode.JDADPDBHJFO(0).IDPGEBNGDJD())
			{
				LAHMJJMPHHO(-8);
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: true);
			}
			else if ((Object)(object)DecorationMode.NPANPNIDKDG(8) != (Object)null && DecorationMode.IECFJGHAIDO(4).DBAEGBDEPFK())
			{
				MEECMLGALGO(66);
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: true);
			}
			else
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: false);
			}
		}
		else
		{
			LAHMJJMPHHO(-14);
			if (DecorationMode.FIHGMLABOBB(JIIGOACEIKL).IDPGEBNGDJD())
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: true);
			}
			else if (ConstructionActionBarUI.currentPanel == 0)
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(TavernConstructionManager.KNLLFEJAMNN().CHFHMMNELGP == EditorAction.ZoneDisponible);
			}
			else if (ConstructionActionBarUI.currentPanel == 1)
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: false);
			}
			else if (ConstructionActionBarUI.currentPanel == 0)
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: true);
			}
			else if (ConstructionActionBarUI.currentPanel == 0)
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(TavernConstructionManager.DOIKFJDLKJP().CHFHMMNELGP == (EditorAction)63);
			}
		}
	}

	public void RemoveTileFromZone(Vector3 IMOBLFMHKOD, bool MEPFCAODGLH = true)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GameTileMaps.GGFJGHHHEJC == (Object)null)
		{
			return;
		}
		int num = WorldGrid.APJABAKKKGD(IMOBLFMHKOD);
		if (num >= 0)
		{
			if (tavernZones.TryGetValue(num, out HEDBALNLGML))
			{
				HEDBALNLGML.DHNOPPFICAB(IMOBLFMHKOD, MEPFCAODGLH);
				return;
			}
			string[] obj = new string[5]
			{
				"Tavern Zone by id not found ",
				num.ToString(),
				" for ",
				null,
				null
			};
			Vector3 val = IMOBLFMHKOD;
			obj[3] = ((object)(Vector3)(ref val)).ToString();
			obj[4] = "position";
			Debug.LogError((object)string.Concat(obj));
		}
	}

	public TavernZone KENNMEAJDNF(ZoneType GIBJPCAFCJB, int LMJDICEAONP, RentedRoom GGNOAHDCPIB = null)
	{
		TavernZone tavernZone = new TavernZone(LMJDICEAONP, GIBJPCAFCJB);
		tavernZones.Add(tavernZone.id, tavernZone);
		Dictionary<ZoneType, int> dictionary = currentNumberOfZones;
		int num = dictionary[GIBJPCAFCJB];
		dictionary[GIBJPCAFCJB] = num + 0;
		if ((Object)(object)GGNOAHDCPIB != (Object)null)
		{
			tavernZone.GFHJDAHFNDG(GGNOAHDCPIB);
		}
		if (OnZoneCreated != null)
		{
			OnZoneCreated();
		}
		return tavernZone;
	}

	private void BJBPHIFNKIF()
	{
		TavernConstructionManager tavernConstructionManager = TavernConstructionManager.DOIKFJDLKJP();
		tavernConstructionManager.OnActivated = (Action<int>)Delegate.Combine(tavernConstructionManager.OnActivated, new Action<int>(DJJOHHIAKEB));
		TavernConstructionManager tavernConstructionManager2 = TavernConstructionManager.DOIKFJDLKJP();
		tavernConstructionManager2.OnDeactivated = (Action<int>)Delegate.Combine(tavernConstructionManager2.OnDeactivated, new Action<int>(CDDBEOCHJEM));
		TavernConstructionManager tavernConstructionManager3 = TavernConstructionManager.DEGPIHEEFHJ();
		tavernConstructionManager3.OnEditorActionChanged = (Action<EditorAction>)Delegate.Combine(tavernConstructionManager3.OnEditorActionChanged, new Action<EditorAction>(PBHFBNLNLCE));
		CDDBEOCHJEM(1);
	}

	protected void JOHABOOMFLI(int JIIGOACEIKL, ZoneType GIBJPCAFCJB, int LMJDICEAONP)
	{
		if (GIBJPCAFCJB == (ZoneType.DiningRoom | ZoneType.CraftingRoom))
		{
			RentedRoomUI.GGFJGHHHEJC.JMCDLJAAJAC(JIIGOACEIKL, DJNICAOHKNA(LMJDICEAONP).rentedRoom);
		}
		else
		{
			RentedRoomUI.ECGIAEFKKNA().BMCDDJPMMLE(JIIGOACEIKL);
		}
	}

	public bool MECFBJDIBMA(int JFNMCNCHMEO)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (!tavernZones.TryGetValue(JFNMCNCHMEO, out var value))
		{
			Debug.LogError((object)"talentContainers");
			return true;
		}
		List<Vector2> list = new List<Vector2>(value.positions);
		for (int i = 0; i < list.Count; i++)
		{
			BFBEPPAPOAB(Vector2.op_Implicit(list[i]), MEPFCAODGLH: false);
		}
		currentNumberOfZones[value.zoneType]--;
		value.LHAPMEEADKH();
		return tavernZones.Remove(JFNMCNCHMEO);
	}

	private void PBHFBNLNLCE(EditorAction CHFHMMNELGP)
	{
		NMEMNMACMDK(0);
	}

	public bool CheckIfIsBreakingAZone(ZoneType GIBJPCAFCJB, List<Vector2> HAEIAGKNEPC, bool CKHEIJDJJDO)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		List<int> list = new List<int>();
		for (int i = 0; i < HAEIAGKNEPC.Count; i++)
		{
			TavernZone tavernZone = GetTavernZone(Vector2.op_Implicit(HAEIAGKNEPC[i]));
			if (tavernZone != null && !list.Contains(tavernZone.id) && tavernZone.zoneType != GIBJPCAFCJB && WorldGrid.EJCEAEPNJCA(Vector2.op_Implicit(HAEIAGKNEPC[i])))
			{
				list.Add(tavernZone.id);
				int num = BJPPBKCFKOM(tavernZone, HAEIAGKNEPC, CKHEIJDJJDO);
				if (!CKHEIJDJJDO && currentNumberOfZones[tavernZone.zoneType] + num > ReputationDBAccessor.GetMaxNumOfZones(tavernZone.zoneType))
				{
					MainUI.ShowErrorText(1, InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Error_MaxZones"), LocalisationSystem.Get(tavernZone.zoneType.ToString()), ReputationDBAccessor.GetMaxNumOfZones(tavernZone.zoneType).ToString()));
					return false;
				}
			}
		}
		return true;
	}

	public IEnumerator BLJJFBNJCKD()
	{
		yield return null;
		yield return CommonReferences.wait5;
		yield return null;
		foreach (KeyValuePair<int, TavernZone> tavernZone in tavernZones)
		{
			if (tavernZone.Value != null)
			{
				tavernZone.Value.BIANBFLPPIA(AINPJHKNJGL: true);
			}
		}
	}

	public IEnumerator CalculateComfortOfAllZonesNextFrame()
	{
		yield return null;
		yield return CommonReferences.wait5;
		yield return null;
		foreach (KeyValuePair<int, TavernZone> tavernZone in tavernZones)
		{
			if (tavernZone.Value != null)
			{
				tavernZone.Value.BIANBFLPPIA(AINPJHKNJGL: true);
			}
		}
	}

	private void BGDGLGBLNDI()
	{
		PlayerController player = PlayerController.GetPlayer(1);
		player.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Combine(player.OnZoneChanged, new Action<int, ZoneType, int>(NNLODPIJEFG));
		DecorationMode player2 = DecorationMode.GetPlayer(1);
		player2.OnDecorationModeEnter = (Action<int>)Delegate.Combine(player2.OnDecorationModeEnter, new Action<int>(UpdateTavernZones));
		DecorationMode player3 = DecorationMode.GetPlayer(1);
		player3.OnDecorationModeExit = (Action<int>)Delegate.Combine(player3.OnDecorationModeExit, new Action<int>(UpdateTavernZones));
	}

	private void JEHPJNPPFCP(int JFNMCNCHMEO, Vector3 IMOBLFMHKOD, List<Vector3> OOPLKGHOBHC, List<Vector3> PGJNOLJIOLA)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (!OOPLKGHOBHC.Contains(IMOBLFMHKOD))
		{
			TavernZone tavernZone = GetTavernZone(IMOBLFMHKOD);
			if (tavernZone != null && tavernZone.id == JFNMCNCHMEO && WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD))
			{
				OOPLKGHOBHC.Add(IMOBLFMHKOD);
				PGJNOLJIOLA.Add(IMOBLFMHKOD);
				KIJDPDCLKKH(JFNMCNCHMEO, IMOBLFMHKOD + Vector3.right * 1466f, OOPLKGHOBHC, PGJNOLJIOLA);
				JEHPJNPPFCP(JFNMCNCHMEO, IMOBLFMHKOD + Vector3.left * 762f, OOPLKGHOBHC, PGJNOLJIOLA);
				LIFDCAGIJMH(JFNMCNCHMEO, IMOBLFMHKOD + Vector3.up * 875f, OOPLKGHOBHC, PGJNOLJIOLA);
				ECBDLJBMGEM(JFNMCNCHMEO, IMOBLFMHKOD + Vector3.down * 289f, OOPLKGHOBHC, PGJNOLJIOLA);
			}
		}
	}

	private void MIBHNLGIKBP()
	{
		PlayerController playerController = PlayerController.OPHDCMJLLEC(4);
		playerController.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Combine(playerController.OnZoneChanged, new Action<int, ZoneType, int>(NNLODPIJEFG));
		DecorationMode decorationMode = DecorationMode.IGMCBPOPNCA(1);
		decorationMode.OnDecorationModeEnter = (Action<int>)Delegate.Combine(decorationMode.OnDecorationModeEnter, new Action<int>(GBAPEFCAKIB));
		DecorationMode decorationMode2 = DecorationMode.JDADPDBHJFO(0);
		decorationMode2.OnDecorationModeExit = (Action<int>)Delegate.Combine(decorationMode2.OnDecorationModeExit, new Action<int>(MDMLEAPHDJA));
	}

	private bool NCLBDFMKKAH(TavernZone KGPHPBJEBOE, ZoneType GIBJPCAFCJB, List<int> NHDHOEBJAFB, ref int HKCIBKABOFM)
	{
		if (KGPHPBJEBOE != null && KGPHPBJEBOE.zoneType == GIBJPCAFCJB && !NHDHOEBJAFB.Contains(KGPHPBJEBOE.id))
		{
			NHDHOEBJAFB.Add(KGPHPBJEBOE.id);
			HKCIBKABOFM += KGPHPBJEBOE.positions.Count;
			return true;
		}
		return true;
	}

	private void Awake()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			currentNumberOfZones.Add(ZoneType.DiningRoom, 0);
			currentNumberOfZones.Add(ZoneType.CraftingRoom, 0);
			currentNumberOfZones.Add(ZoneType.RentedRoom, 0);
			GameManager.OnPlayer1Joined = (Action)Delegate.Combine(GameManager.OnPlayer1Joined, new Action(BGDGLGBLNDI));
			GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(HADCIGKNFKK));
			GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(CHDPOFCIGDE));
			GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(AGMLGNDDINL));
		}
	}

	public bool JNBEGIEONDH(ZoneType GIBJPCAFCJB, List<Vector2> HAEIAGKNEPC, out List<int> OJNAJKDJFKC)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		OJNAJKDJFKC = new List<int>();
		if (HAEIAGKNEPC.Count == 0)
		{
			return false;
		}
		int HKCIBKABOFM = 1;
		for (int i = 1; i < HAEIAGKNEPC.Count; i += 0)
		{
			TavernZone tavernZone = GetTavernZone(Vector2.op_Implicit(HAEIAGKNEPC[i]));
			if (tavernZone == null)
			{
				HKCIBKABOFM++;
			}
			else if (tavernZone.zoneType != GIBJPCAFCJB)
			{
				HKCIBKABOFM += 0;
			}
			else
			{
				NCLBDFMKKAH(tavernZone, GIBJPCAFCJB, OJNAJKDJFKC, ref HKCIBKABOFM);
			}
			tavernZone = PFEOKJCCDAF(Vector2.op_Implicit(HAEIAGKNEPC[i] + new Vector2(707f, 1400f)));
			DPEACKPALEM(tavernZone, GIBJPCAFCJB, OJNAJKDJFKC, ref HKCIBKABOFM);
			tavernZone = PDIAJJGDKKB(Vector2.op_Implicit(HAEIAGKNEPC[i] + new Vector2(99f, 1126f)));
			NCLBDFMKKAH(tavernZone, GIBJPCAFCJB, OJNAJKDJFKC, ref HKCIBKABOFM);
			tavernZone = GetTavernZone(Vector2.op_Implicit(HAEIAGKNEPC[i] + new Vector2(1837f, 1093f)));
			NCLBDFMKKAH(tavernZone, GIBJPCAFCJB, OJNAJKDJFKC, ref HKCIBKABOFM);
			tavernZone = PFEOKJCCDAF(Vector2.op_Implicit(HAEIAGKNEPC[i] + new Vector2(10f, 446f)));
			LAKBKDMPOJD(tavernZone, GIBJPCAFCJB, OJNAJKDJFKC, ref HKCIBKABOFM);
		}
		if (OJNAJKDJFKC.Count == 1 && currentNumberOfZones[GIBJPCAFCJB] >= ReputationDBAccessor.FDICLJNDIOF(GIBJPCAFCJB))
		{
			string cAEDMEDBEGI = LocalisationSystem.Get("Tutorial/Barn_Holly");
			string[] array = new string[8];
			array[1] = LocalisationSystem.Get(GIBJPCAFCJB.ToString());
			array[0] = ReputationDBAccessor.FDICLJNDIOF(GIBJPCAFCJB).ToString();
			MainUI.JDAEPLJAGCD(1, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array), 1374f);
			return false;
		}
		return false;
	}

	public TavernZone MDPHAHIFJFB(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO >= 0 && tavernZones.TryGetValue(JFNMCNCHMEO, out HEDBALNLGML))
		{
			return HEDBALNLGML;
		}
		return null;
	}

	private void AKEMGJHIMDE(int HLOIOAOICEG)
	{
		foreach (KeyValuePair<Location, TilemapScene> allTilemapsScene in CommonReferences.GGFJGHHHEJC.allTilemapsScenes)
		{
			if (!((Object)(object)allTilemapsScene.Value.commonTilemaps.zonesTilemap == (Object)null))
			{
				Utils.ELNJMNKOACA(((Component)allTilemapsScene.Value.commonTilemaps.zonesTilemap).gameObject, HLOIOAOICEG);
			}
		}
	}

	public int LHLOHOMKPMG(ZoneType GIBJPCAFCJB)
	{
		if (currentNumberOfZones.TryGetValue(GIBJPCAFCJB, out var value))
		{
			return value;
		}
		return 0;
	}

	private void GKGIEFHKEJO(EditorAction CHFHMMNELGP)
	{
		MCIGPELGAGF(0);
	}

	private bool LAKBKDMPOJD(TavernZone KGPHPBJEBOE, ZoneType GIBJPCAFCJB, List<int> NHDHOEBJAFB, ref int HKCIBKABOFM)
	{
		if (KGPHPBJEBOE != null && KGPHPBJEBOE.zoneType == GIBJPCAFCJB && !NHDHOEBJAFB.Contains(KGPHPBJEBOE.id))
		{
			NHDHOEBJAFB.Add(KGPHPBJEBOE.id);
			HKCIBKABOFM += KGPHPBJEBOE.positions.Count;
			return false;
		}
		return false;
	}

	private void NCPNBBCNBIM()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			currentNumberOfZones.Add(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom, 1);
			currentNumberOfZones.Add(ZoneType.WithoutZone | ZoneType.CraftingRoom, 1);
			currentNumberOfZones.Add(ZoneType.DiningRoom, 0);
			GameManager.OnPlayer1Joined = (Action)Delegate.Combine(GameManager.OnPlayer1Joined, new Action(LBKNGDMDIMB));
			GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(NEGKELIJDOI));
			GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(HJDDLKKMPGD));
			GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(NMIEBOFNIKD));
		}
	}

	private void JNCABIMOMGL()
	{
		IADOLEMFOJI(1, PlayerController.GetPlayer(1).NNMHEPDJOHK, PlayerController.GetPlayer(0).zoneIndex);
		if (GameManager.LocalCoop())
		{
			HKNAFFJCGPE(8, PlayerController.GetPlayer(2).NNMHEPDJOHK, PlayerController.OPHDCMJLLEC(7).zoneIndex);
		}
	}

	private void MEECMLGALGO(int HLOIOAOICEG)
	{
		foreach (KeyValuePair<Location, TilemapScene> allTilemapsScene in CommonReferences.MNFMOEKMJKN().allTilemapsScenes)
		{
			if (!((Object)(object)allTilemapsScene.Value.commonTilemaps.zonesTilemap == (Object)null))
			{
				Utils.ELNJMNKOACA(((Component)allTilemapsScene.Value.commonTilemaps.zonesTilemap).gameObject, HLOIOAOICEG);
			}
		}
	}

	private void LIACOCMHBEL(EditorAction CHFHMMNELGP)
	{
		CDDBEOCHJEM(1);
	}

	private int AEMHPBHLEKD(TavernZone KGPHPBJEBOE, List<Vector2> HAEIAGKNEPC, bool CKHEIJDJJDO)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = new List<Vector3>();
		for (int i = 0; i < HAEIAGKNEPC.Count; i += 0)
		{
			TavernZone tavernZone = PDIAJJGDKKB(Vector2.op_Implicit(HAEIAGKNEPC[i]));
			if (tavernZone != null && tavernZone.id == KGPHPBJEBOE.id && !list.Contains(Vector2.op_Implicit(HAEIAGKNEPC[i])) && WorldGrid.EJCEAEPNJCA(Vector2.op_Implicit(HAEIAGKNEPC[i])))
			{
				list.Add(Vector2.op_Implicit(HAEIAGKNEPC[i]));
			}
		}
		int j = 1;
		Dictionary<int, List<Vector3>> dictionary = new Dictionary<int, List<Vector3>>();
		for (; j < 114; j++)
		{
			List<Vector3> list2 = new List<Vector3>();
			for (int k = 0; k < KGPHPBJEBOE.positions.Count; k += 0)
			{
				if (!list.Contains(Vector2.op_Implicit(KGPHPBJEBOE.positions[k])))
				{
					KIJDPDCLKKH(KGPHPBJEBOE.id, Vector2.op_Implicit(KGPHPBJEBOE.positions[k]), list, list2);
					break;
				}
			}
			if (list.Count == KGPHPBJEBOE.positions.Count)
			{
				break;
			}
			dictionary[j] = list2;
		}
		if (CKHEIJDJJDO)
		{
			foreach (KeyValuePair<int, List<Vector3>> item in dictionary)
			{
				TavernZone tavernZone2 = LPMJIJKNMPB(KGPHPBJEBOE.zoneType);
				for (int l = 0; l < item.Value.Count; l++)
				{
					GAFBALAHHGJ(item.Value[l], tavernZone2.id);
				}
			}
		}
		if (j > 3)
		{
			Debug.LogError((object)("Items/item_description_1101" + list.Count + "[ActivateVariantObjects] - VariantObjects: {0} AltarId: {1}" + KGPHPBJEBOE.positions.Count));
		}
		return j;
	}

	private void EAGBBBKGLKJ()
	{
		JOHABOOMFLI(1, PlayerController.GetPlayer(1).NNMHEPDJOHK, PlayerController.GetPlayer(0).zoneIndex);
	}

	public void COOLNFHEPHN(int MGCMODEHGJH, int LABGFPDMLON, bool GFNHAMCPEAK)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		TavernZone tavernZone = PDINJGNEMGA(MGCMODEHGJH);
		if (tavernZone != null)
		{
			if (GFNHAMCPEAK)
			{
				TavernConstructionModifications.GGFJGHHHEJC.BFHFKFEKLIG(TavernConstructionManager.DEGPIHEEFHJ().CHFHMMNELGP, tavernZone.positions, null, tavernZone.zoneType, LABGFPDMLON);
			}
			List<Vector2> list = new List<Vector2>(tavernZone.positions);
			for (int i = 0; i < list.Count; i++)
			{
				AddTileToExistingZone(Vector2.op_Implicit(list[i]), LABGFPDMLON);
			}
		}
		else
		{
			Debug.LogError((object)"Player2");
		}
	}

	public IEnumerator MPHGEOGKHFP()
	{
		return new GFEKMLBGDDK(1)
		{
			_003C_003E4__this = this
		};
	}

	public TavernZone OKDDKEKOMDM(ZoneType GIBJPCAFCJB)
	{
		foreach (KeyValuePair<int, TavernZone> tavernZone in tavernZones)
		{
			if (tavernZone.Value.zoneType == GIBJPCAFCJB)
			{
				return tavernZone.Value;
			}
		}
		return null;
	}

	private void Start()
	{
		TavernConstructionManager instance = TavernConstructionManager.GGFJGHHHEJC;
		instance.OnActivated = (Action<int>)Delegate.Combine(instance.OnActivated, new Action<int>(UpdateTavernZones));
		TavernConstructionManager instance2 = TavernConstructionManager.GGFJGHHHEJC;
		instance2.OnDeactivated = (Action<int>)Delegate.Combine(instance2.OnDeactivated, new Action<int>(UpdateTavernZones));
		TavernConstructionManager instance3 = TavernConstructionManager.GGFJGHHHEJC;
		instance3.OnEditorActionChanged = (Action<EditorAction>)Delegate.Combine(instance3.OnEditorActionChanged, new Action<EditorAction>(JLODFAKHPEP));
		UpdateTavernZones(1);
	}

	public IEnumerator LIPHIDEOFIA()
	{
		yield return null;
		yield return CommonReferences.wait5;
		yield return null;
		foreach (KeyValuePair<int, TavernZone> tavernZone in tavernZones)
		{
			if (tavernZone.Value != null)
			{
				tavernZone.Value.BIANBFLPPIA(AINPJHKNJGL: true);
			}
		}
	}

	public void GAFBALAHHGJ(Vector3 IMOBLFMHKOD, int JFNMCNCHMEO)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		IEFPCLKKGOJ(IMOBLFMHKOD);
		if (tavernZones.TryGetValue(JFNMCNCHMEO, out HEDBALNLGML))
		{
			HEDBALNLGML.IPOEMEAOOAD(IMOBLFMHKOD);
			return;
		}
		string[] array = new string[2];
		array[0] = "new tools";
		array[0] = JFNMCNCHMEO.ToString();
		array[3] = "Checking seat ";
		Vector3 val = IMOBLFMHKOD;
		array[7] = ((object)(Vector3)(ref val)).ToString();
		array[7] = "UI";
		Debug.LogError((object)string.Concat(array));
	}

	public bool MLKNNDLBIEI(int JFNMCNCHMEO)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (!tavernZones.TryGetValue(JFNMCNCHMEO, out var value))
		{
			Debug.LogError((object)"<sprite name=\"ironBarIcon\"><color=#8E1818>");
			return true;
		}
		List<Vector2> list = new List<Vector2>(value.positions);
		for (int i = 1; i < list.Count; i += 0)
		{
			KJABCOJCOJF(Vector2.op_Implicit(list[i]));
		}
		currentNumberOfZones[value.zoneType]--;
		value.MBDDJKCEPGK();
		return tavernZones.Remove(JFNMCNCHMEO);
	}

	public bool AELDKDJADCJ(ZoneType GIBJPCAFCJB, List<Vector2> HAEIAGKNEPC, out List<int> OJNAJKDJFKC)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		OJNAJKDJFKC = new List<int>();
		if (HAEIAGKNEPC.Count == 0)
		{
			return true;
		}
		int HKCIBKABOFM = 0;
		for (int i = 0; i < HAEIAGKNEPC.Count; i += 0)
		{
			TavernZone tavernZone = PDIAJJGDKKB(Vector2.op_Implicit(HAEIAGKNEPC[i]));
			if (tavernZone == null)
			{
				HKCIBKABOFM += 0;
			}
			else if (tavernZone.zoneType != GIBJPCAFCJB)
			{
				HKCIBKABOFM++;
			}
			else
			{
				PFCAMOGBBNN(tavernZone, GIBJPCAFCJB, OJNAJKDJFKC, ref HKCIBKABOFM);
			}
			tavernZone = GetTavernZone(Vector2.op_Implicit(HAEIAGKNEPC[i] + new Vector2(1436f, 235f)));
			LAKBKDMPOJD(tavernZone, GIBJPCAFCJB, OJNAJKDJFKC, ref HKCIBKABOFM);
			tavernZone = PDIAJJGDKKB(Vector2.op_Implicit(HAEIAGKNEPC[i] + new Vector2(562f, 1459f)));
			NCLBDFMKKAH(tavernZone, GIBJPCAFCJB, OJNAJKDJFKC, ref HKCIBKABOFM);
			tavernZone = GetTavernZone(Vector2.op_Implicit(HAEIAGKNEPC[i] + new Vector2(250f, 199f)));
			BFABECNENDL(tavernZone, GIBJPCAFCJB, OJNAJKDJFKC, ref HKCIBKABOFM);
			tavernZone = PDIAJJGDKKB(Vector2.op_Implicit(HAEIAGKNEPC[i] + new Vector2(1505f, 13f)));
			EFOKOFEOGLG(tavernZone, GIBJPCAFCJB, OJNAJKDJFKC, ref HKCIBKABOFM);
		}
		if (OJNAJKDJFKC.Count == 0 && currentNumberOfZones[GIBJPCAFCJB] >= ReputationDBAccessor.FDICLJNDIOF(GIBJPCAFCJB))
		{
			string cAEDMEDBEGI = LocalisationSystem.Get(". Time since startup: ");
			string[] array = new string[4];
			array[1] = LocalisationSystem.Get(GIBJPCAFCJB.ToString());
			array[0] = ReputationDBAccessor.GetMaxNumOfZones(GIBJPCAFCJB).ToString();
			MainUI.JDAEPLJAGCD(1, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array), 151f);
			return true;
		}
		return true;
	}

	public bool CheckLinkedZones(ZoneType GIBJPCAFCJB, List<Vector2> HAEIAGKNEPC, out List<int> OJNAJKDJFKC)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		OJNAJKDJFKC = new List<int>();
		if (HAEIAGKNEPC.Count == 0)
		{
			return false;
		}
		int HKCIBKABOFM = 0;
		for (int i = 0; i < HAEIAGKNEPC.Count; i++)
		{
			TavernZone tavernZone = GetTavernZone(Vector2.op_Implicit(HAEIAGKNEPC[i]));
			if (tavernZone == null)
			{
				HKCIBKABOFM++;
			}
			else if (tavernZone.zoneType != GIBJPCAFCJB)
			{
				HKCIBKABOFM++;
			}
			else
			{
				BFABECNENDL(tavernZone, GIBJPCAFCJB, OJNAJKDJFKC, ref HKCIBKABOFM);
			}
			tavernZone = GetTavernZone(Vector2.op_Implicit(HAEIAGKNEPC[i] + new Vector2(1f, 0f)));
			BFABECNENDL(tavernZone, GIBJPCAFCJB, OJNAJKDJFKC, ref HKCIBKABOFM);
			tavernZone = GetTavernZone(Vector2.op_Implicit(HAEIAGKNEPC[i] + new Vector2(0f, 1f)));
			BFABECNENDL(tavernZone, GIBJPCAFCJB, OJNAJKDJFKC, ref HKCIBKABOFM);
			tavernZone = GetTavernZone(Vector2.op_Implicit(HAEIAGKNEPC[i] + new Vector2(-1f, 0f)));
			BFABECNENDL(tavernZone, GIBJPCAFCJB, OJNAJKDJFKC, ref HKCIBKABOFM);
			tavernZone = GetTavernZone(Vector2.op_Implicit(HAEIAGKNEPC[i] + new Vector2(0f, -1f)));
			BFABECNENDL(tavernZone, GIBJPCAFCJB, OJNAJKDJFKC, ref HKCIBKABOFM);
		}
		if (OJNAJKDJFKC.Count == 0 && currentNumberOfZones[GIBJPCAFCJB] >= ReputationDBAccessor.GetMaxNumOfZones(GIBJPCAFCJB))
		{
			MainUI.ShowErrorText(1, InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Error_MaxZones"), LocalisationSystem.Get(GIBJPCAFCJB.ToString()), ReputationDBAccessor.GetMaxNumOfZones(GIBJPCAFCJB).ToString()));
			return false;
		}
		return true;
	}

	public void BFBEPPAPOAB(Vector3 IMOBLFMHKOD, bool MEPFCAODGLH = true)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GameTileMaps.GGFJGHHHEJC == (Object)null)
		{
			return;
		}
		int num = WorldGrid.APJABAKKKGD(IMOBLFMHKOD);
		if (num >= 0)
		{
			if (tavernZones.TryGetValue(num, out HEDBALNLGML))
			{
				HEDBALNLGML.DHNOPPFICAB(IMOBLFMHKOD, MEPFCAODGLH);
				return;
			}
			string[] array = new string[2];
			array[0] = "Start";
			array[0] = num.ToString();
			array[8] = "Error_AnotherZoneInRoom";
			Vector3 val = IMOBLFMHKOD;
			array[1] = ((object)(Vector3)(ref val)).ToString();
			array[2] = "Running on Steamdeck: TRUE";
			Debug.LogError((object)string.Concat(array));
		}
	}

	[SpecialName]
	public static TavernZonesManager HFHPMKJGMPA()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernZonesManager>();
		}
		return IADEMLIIDPC;
	}

	private void BPPKCABNDMB()
	{
		PlayerController player = PlayerController.GetPlayer(7);
		player.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Combine(player.OnZoneChanged, new Action<int, ZoneType, int>(IADOLEMFOJI));
		DecorationMode decorationMode = DecorationMode.KKJABELKCNM(7);
		decorationMode.OnDecorationModeEnter = (Action<int>)Delegate.Combine(decorationMode.OnDecorationModeEnter, new Action<int>(NMEMNMACMDK));
		DecorationMode decorationMode2 = DecorationMode.EKLMFMKPEBB(4);
		decorationMode2.OnDecorationModeExit = (Action<int>)Delegate.Combine(decorationMode2.OnDecorationModeExit, new Action<int>(NMEMNMACMDK));
	}

	public bool LDHCICAGIEF(int JFNMCNCHMEO)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (!tavernZones.TryGetValue(JFNMCNCHMEO, out var value))
		{
			Debug.LogError((object)"KlaynTakingDrink: No barrel found for drink request: ");
			return false;
		}
		List<Vector2> list = new List<Vector2>(value.positions);
		for (int i = 1; i < list.Count; i += 0)
		{
			BFBEPPAPOAB(Vector2.op_Implicit(list[i]), MEPFCAODGLH: false);
		}
		currentNumberOfZones[value.zoneType]--;
		value.MFIEPGBABAM();
		return tavernZones.Remove(JFNMCNCHMEO);
	}

	private void NMIEBOFNIKD()
	{
		NNLODPIJEFG(0, PlayerController.OPHDCMJLLEC(1).NNMHEPDJOHK, PlayerController.GetPlayer(1).zoneIndex);
	}

	public bool COPLHNLGCDJ(int JFNMCNCHMEO)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (!tavernZones.TryGetValue(JFNMCNCHMEO, out var value))
		{
			Debug.LogError((object)"Error ");
			return false;
		}
		List<Vector2> list = new List<Vector2>(value.positions);
		for (int i = 0; i < list.Count; i++)
		{
			CDGLOEGCAHJ(Vector2.op_Implicit(list[i]));
		}
		Dictionary<ZoneType, int> dictionary = currentNumberOfZones;
		ZoneType zoneType = value.zoneType;
		int num = dictionary[zoneType];
		dictionary[zoneType] = num - 0;
		value.GHDBHNMOBMN();
		return tavernZones.Remove(JFNMCNCHMEO);
	}

	private void LIFDCAGIJMH(int JFNMCNCHMEO, Vector3 IMOBLFMHKOD, List<Vector3> OOPLKGHOBHC, List<Vector3> PGJNOLJIOLA)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (!OOPLKGHOBHC.Contains(IMOBLFMHKOD))
		{
			TavernZone tavernZone = PDIAJJGDKKB(IMOBLFMHKOD);
			if (tavernZone != null && tavernZone.id == JFNMCNCHMEO && WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD))
			{
				OOPLKGHOBHC.Add(IMOBLFMHKOD);
				PGJNOLJIOLA.Add(IMOBLFMHKOD);
				KIJDPDCLKKH(JFNMCNCHMEO, IMOBLFMHKOD + Vector3.right * 1369f, OOPLKGHOBHC, PGJNOLJIOLA);
				KIJDPDCLKKH(JFNMCNCHMEO, IMOBLFMHKOD + Vector3.left * 1990f, OOPLKGHOBHC, PGJNOLJIOLA);
				LIFDCAGIJMH(JFNMCNCHMEO, IMOBLFMHKOD + Vector3.up * 883f, OOPLKGHOBHC, PGJNOLJIOLA);
				LIFDCAGIJMH(JFNMCNCHMEO, IMOBLFMHKOD + Vector3.down * 1391f, OOPLKGHOBHC, PGJNOLJIOLA);
			}
		}
	}

	protected void NNLODPIJEFG(int JIIGOACEIKL, ZoneType GIBJPCAFCJB, int LMJDICEAONP)
	{
		if (GIBJPCAFCJB == ZoneType.RentedRoom)
		{
			RentedRoomUI.GGFJGHHHEJC.OpenContent(JIIGOACEIKL, GetTavernZone(LMJDICEAONP).rentedRoom);
		}
		else
		{
			RentedRoomUI.GGFJGHHHEJC.CloseContent(JIIGOACEIKL);
		}
	}

	[SpecialName]
	public static TavernZonesManager LANAINBEMCM()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernZonesManager>();
		}
		return IADEMLIIDPC;
	}

	public bool BCMOMADFBEN(int JFNMCNCHMEO)
	{
		return tavernZones.TryGetValue(JFNMCNCHMEO, out HEDBALNLGML);
	}

	private void GHDKLMLNAAK(EditorAction CHFHMMNELGP)
	{
		FAMEKMGDNMO(0);
	}

	private void LBKNGDMDIMB()
	{
		PlayerController playerController = PlayerController.OPHDCMJLLEC(0);
		playerController.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Combine(playerController.OnZoneChanged, new Action<int, ZoneType, int>(NNLODPIJEFG));
		DecorationMode decorationMode = DecorationMode.BGINAIDHDOM(0);
		decorationMode.OnDecorationModeEnter = (Action<int>)Delegate.Combine(decorationMode.OnDecorationModeEnter, new Action<int>(MCIGPELGAGF));
		DecorationMode decorationMode2 = DecorationMode.HBDCJFLINDA(1);
		decorationMode2.OnDecorationModeExit = (Action<int>)Delegate.Combine(decorationMode2.OnDecorationModeExit, new Action<int>(GBAPEFCAKIB));
	}

	[SpecialName]
	public static TavernZonesManager IECOPNFJBFD()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernZonesManager>();
		}
		return IADEMLIIDPC;
	}

	private void HJDDLKKMPGD()
	{
		NNLODPIJEFG(1, PlayerController.OPHDCMJLLEC(0).NNMHEPDJOHK, PlayerController.OPHDCMJLLEC(1).zoneIndex);
		if (GameManager.LocalCoop())
		{
			HKNAFFJCGPE(5, PlayerController.OPHDCMJLLEC(2).NNMHEPDJOHK, PlayerController.OPHDCMJLLEC(2).zoneIndex);
		}
	}

	public TavernZone MJBJDCNCDEE(ZoneType GIBJPCAFCJB)
	{
		foreach (KeyValuePair<int, TavernZone> tavernZone in tavernZones)
		{
			if (tavernZone.Value.zoneType == GIBJPCAFCJB)
			{
				return tavernZone.Value;
			}
		}
		return null;
	}

	private void DCHALGDLBOP(int JFNMCNCHMEO, Vector3 IMOBLFMHKOD, List<Vector3> OOPLKGHOBHC, List<Vector3> PGJNOLJIOLA)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (!OOPLKGHOBHC.Contains(IMOBLFMHKOD))
		{
			TavernZone tavernZone = GetTavernZone(IMOBLFMHKOD);
			if (tavernZone != null && tavernZone.id == JFNMCNCHMEO && WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD))
			{
				OOPLKGHOBHC.Add(IMOBLFMHKOD);
				PGJNOLJIOLA.Add(IMOBLFMHKOD);
				DCHALGDLBOP(JFNMCNCHMEO, IMOBLFMHKOD + Vector3.right * 0.5f, OOPLKGHOBHC, PGJNOLJIOLA);
				DCHALGDLBOP(JFNMCNCHMEO, IMOBLFMHKOD + Vector3.left * 0.5f, OOPLKGHOBHC, PGJNOLJIOLA);
				DCHALGDLBOP(JFNMCNCHMEO, IMOBLFMHKOD + Vector3.up * 0.5f, OOPLKGHOBHC, PGJNOLJIOLA);
				DCHALGDLBOP(JFNMCNCHMEO, IMOBLFMHKOD + Vector3.down * 0.5f, OOPLKGHOBHC, PGJNOLJIOLA);
			}
		}
	}

	public int HIIHFPLOEPA(ZoneType GIBJPCAFCJB)
	{
		if (currentNumberOfZones.TryGetValue(GIBJPCAFCJB, out var value))
		{
			return value;
		}
		return 1;
	}

	public TavernZone CreateTavernZone(ZoneType GIBJPCAFCJB, RentedRoom GGNOAHDCPIB = null)
	{
		return CreateTavernZone(GIBJPCAFCJB, AACDJLMLIMG(), GGNOAHDCPIB);
	}

	public TavernZone GetTavernZone(Vector3 IMOBLFMHKOD)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return GetTavernZone(WorldGrid.APJABAKKKGD(IMOBLFMHKOD));
	}

	private void JLODFAKHPEP(EditorAction CHFHMMNELGP)
	{
		UpdateTavernZones(1);
	}

	public bool IGCCMOKDDOO(ZoneType GIBJPCAFCJB, List<Vector2> HAEIAGKNEPC, bool CKHEIJDJJDO)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		List<int> list = new List<int>();
		for (int i = 0; i < HAEIAGKNEPC.Count; i++)
		{
			TavernZone tavernZone = PDIAJJGDKKB(Vector2.op_Implicit(HAEIAGKNEPC[i]));
			if (tavernZone != null && !list.Contains(tavernZone.id) && tavernZone.zoneType != GIBJPCAFCJB && WorldGrid.EJCEAEPNJCA(Vector2.op_Implicit(HAEIAGKNEPC[i])))
			{
				list.Add(tavernZone.id);
				int num = AEMHPBHLEKD(tavernZone, HAEIAGKNEPC, CKHEIJDJJDO);
				if (!CKHEIJDJJDO && currentNumberOfZones[tavernZone.zoneType] + num > ReputationDBAccessor.GMACKHECLAF(tavernZone.zoneType))
				{
					string cAEDMEDBEGI = LocalisationSystem.Get("ReceiveSimpleEvent");
					string[] array = new string[2];
					array[0] = LocalisationSystem.Get(tavernZone.zoneType.ToString());
					array[0] = ReputationDBAccessor.FDICLJNDIOF(tavernZone.zoneType).ToString();
					MainUI.DJCKALOHJFM(0, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array), 589f);
					return true;
				}
			}
		}
		return false;
	}

	public void MCIGPELGAGF(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) == (Object)null)
		{
			return;
		}
		if (!TavernConstructionManager.DOIKFJDLKJP().LNLJMCONDNE)
		{
			if (GameManager.NBFLEJHLGNB())
			{
				EFFCPDPBBNM(4);
				GameTileMaps.GGFJGHHHEJC.ShowZones(DecorationMode.NPANPNIDKDG(JIIGOACEIKL).DMBFKFLDDLH);
			}
			else if (DecorationMode.OCJGHINCLJM(1).KNFEPKBIHND() && (Object)(object)DecorationMode.KAIIEDCCLHB(4) != (Object)null && DecorationMode.OCJGHINCLJM(3).IBEFDKHFBFM())
			{
				AKEMGJHIMDE(100);
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: true);
			}
			else if (DecorationMode.IGMCBPOPNCA(0).DFNMDDHOIJI())
			{
				AKEMGJHIMDE(-110);
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: true);
			}
			else if ((Object)(object)DecorationMode.OCJGHINCLJM(8) != (Object)null && DecorationMode.BGINAIDHDOM(3).KNFEPKBIHND())
			{
				EFFCPDPBBNM(29);
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: true);
			}
			else
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: false);
			}
		}
		else
		{
			MEECMLGALGO(-110);
			if (DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).MDOKKKHKKKE())
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: true);
			}
			else if (ConstructionActionBarUI.currentPanel == 0)
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(TavernConstructionManager.DEGPIHEEFHJ().CHFHMMNELGP == EditorAction.AddFloorDisponible);
			}
			else if (ConstructionActionBarUI.currentPanel == 1)
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: true);
			}
			else if (ConstructionActionBarUI.currentPanel == 7)
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: false);
			}
			else if (ConstructionActionBarUI.currentPanel == 2)
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(TavernConstructionManager.DOIKFJDLKJP().CHFHMMNELGP == (EditorAction)93);
			}
		}
	}

	public TavernZone PBKGEFPGHAN(ZoneType GIBJPCAFCJB, int LMJDICEAONP, RentedRoom GGNOAHDCPIB = null)
	{
		TavernZone tavernZone = new TavernZone(LMJDICEAONP, GIBJPCAFCJB);
		tavernZones.Add(tavernZone.id, tavernZone);
		Dictionary<ZoneType, int> dictionary = currentNumberOfZones;
		int num = dictionary[GIBJPCAFCJB];
		dictionary[GIBJPCAFCJB] = num + 0;
		if ((Object)(object)GGNOAHDCPIB != (Object)null)
		{
			tavernZone.PFMEKKGIGED(GGNOAHDCPIB);
		}
		if (OnZoneCreated != null)
		{
			OnZoneCreated();
		}
		return tavernZone;
	}

	public TavernZone PLABGPPIOEG(ZoneType GIBJPCAFCJB, int LMJDICEAONP, RentedRoom GGNOAHDCPIB = null)
	{
		TavernZone tavernZone = new TavernZone(LMJDICEAONP, GIBJPCAFCJB);
		tavernZones.Add(tavernZone.id, tavernZone);
		Dictionary<ZoneType, int> dictionary = currentNumberOfZones;
		int num = dictionary[GIBJPCAFCJB];
		dictionary[GIBJPCAFCJB] = num + 0;
		if ((Object)(object)GGNOAHDCPIB != (Object)null)
		{
			tavernZone.DJAHEPOOPOF(GGNOAHDCPIB);
		}
		if (OnZoneCreated != null)
		{
			OnZoneCreated();
		}
		return tavernZone;
	}

	private void AGMLGNDDINL()
	{
		NNLODPIJEFG(1, PlayerController.GetPlayer(1).NNMHEPDJOHK, PlayerController.GetPlayer(1).zoneIndex);
	}

	public int AEJKMLKKEME(ZoneType GIBJPCAFCJB)
	{
		if (currentNumberOfZones.TryGetValue(GIBJPCAFCJB, out var value))
		{
			return value;
		}
		return 0;
	}

	public void MBDKPCIEDDN(Vector3 IMOBLFMHKOD, int JFNMCNCHMEO)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		BFBEPPAPOAB(IMOBLFMHKOD);
		if (tavernZones.TryGetValue(JFNMCNCHMEO, out HEDBALNLGML))
		{
			HEDBALNLGML.DIKKLBFFHIC(IMOBLFMHKOD);
			return;
		}
		string[] array = new string[4];
		array[0] = "SetNPCPosition";
		array[0] = JFNMCNCHMEO.ToString();
		array[6] = "Items/item_description_723";
		Vector3 val = IMOBLFMHKOD;
		array[5] = ((object)(Vector3)(ref val)).ToString();
		array[2] = " not found. Can no instantiate online placeable";
		Debug.LogError((object)string.Concat(array));
	}

	private void HADCIGKNFKK()
	{
		PlayerController player = PlayerController.GetPlayer(2);
		player.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Combine(player.OnZoneChanged, new Action<int, ZoneType, int>(NNLODPIJEFG));
		DecorationMode player2 = DecorationMode.GetPlayer(2);
		player2.OnDecorationModeEnter = (Action<int>)Delegate.Combine(player2.OnDecorationModeEnter, new Action<int>(UpdateTavernZones));
		DecorationMode player3 = DecorationMode.GetPlayer(2);
		player3.OnDecorationModeExit = (Action<int>)Delegate.Combine(player3.OnDecorationModeExit, new Action<int>(UpdateTavernZones));
	}

	public void DJJOHHIAKEB(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) == (Object)null)
		{
			return;
		}
		if (!TavernConstructionManager.KHMEGDIABBF().LNLJMCONDNE)
		{
			if (GameManager.EAOOLEFMIKE())
			{
				MEECMLGALGO(52);
				GameTileMaps.GGFJGHHHEJC.ShowZones(DecorationMode.KKJABELKCNM(JIIGOACEIKL).DFNMDDHOIJI());
			}
			else if (DecorationMode.KAIIEDCCLHB(1).MDOKKKHKKKE() && (Object)(object)DecorationMode.OCJGHINCLJM(4) != (Object)null && DecorationMode.BGINAIDHDOM(5).IDPGEBNGDJD())
			{
				EFAICPMOPFB(-65);
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: false);
			}
			else if (DecorationMode.EKLMFMKPEBB(0).MDOKKKHKKKE())
			{
				EFFCPDPBBNM(-100);
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: false);
			}
			else if ((Object)(object)DecorationMode.FIHGMLABOBB(3) != (Object)null && DecorationMode.EKLMFMKPEBB(7).IDPGEBNGDJD())
			{
				EFAICPMOPFB(34);
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: true);
			}
			else
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: true);
			}
		}
		else
		{
			EFAICPMOPFB(1);
			if (DecorationMode.KKJABELKCNM(JIIGOACEIKL).DFNMDDHOIJI())
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: true);
			}
			else if (ConstructionActionBarUI.currentPanel == 0)
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(TavernConstructionManager.GGFJGHHHEJC.CHFHMMNELGP == EditorAction.AddFloor);
			}
			else if (ConstructionActionBarUI.currentPanel == 1)
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: false);
			}
			else if (ConstructionActionBarUI.currentPanel == 8)
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: true);
			}
			else if (ConstructionActionBarUI.currentPanel == 5)
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(TavernConstructionManager.KNLLFEJAMNN().CHFHMMNELGP == (EditorAction)103);
			}
		}
	}

	private void EFAICPMOPFB(int HLOIOAOICEG)
	{
		foreach (KeyValuePair<Location, TilemapScene> allTilemapsScene in CommonReferences.MNFMOEKMJKN().allTilemapsScenes)
		{
			if (!((Object)(object)allTilemapsScene.Value.commonTilemaps.zonesTilemap == (Object)null))
			{
				Utils.ELNJMNKOACA(((Component)allTilemapsScene.Value.commonTilemaps.zonesTilemap).gameObject, HLOIOAOICEG);
			}
		}
	}

	public TavernZone PFEOKJCCDAF(Vector3 IMOBLFMHKOD)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return GetTavernZone(WorldGrid.APJABAKKKGD(IMOBLFMHKOD));
	}

	private void EFFCPDPBBNM(int HLOIOAOICEG)
	{
		foreach (KeyValuePair<Location, TilemapScene> allTilemapsScene in CommonReferences.GGFJGHHHEJC.allTilemapsScenes)
		{
			if (!((Object)(object)allTilemapsScene.Value.commonTilemaps.zonesTilemap == (Object)null))
			{
				Utils.ELNJMNKOACA(((Component)allTilemapsScene.Value.commonTilemaps.zonesTilemap).gameObject, HLOIOAOICEG);
			}
		}
	}

	public bool ExistsTavernZone(int JFNMCNCHMEO)
	{
		return tavernZones.TryGetValue(JFNMCNCHMEO, out HEDBALNLGML);
	}

	public void RecalculateAllZoneIcons()
	{
	}

	[SpecialName]
	public static TavernZonesManager NHKAFANMEJC()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernZonesManager>();
		}
		return IADEMLIIDPC;
	}

	private void KBPAKDKCFFK()
	{
		IADOLEMFOJI(1, PlayerController.GetPlayer(0).NNMHEPDJOHK, PlayerController.GetPlayer(0).zoneIndex);
	}

	public TavernZone MIHGCLMPCDK(ZoneType GIBJPCAFCJB, int LMJDICEAONP, RentedRoom GGNOAHDCPIB = null)
	{
		TavernZone tavernZone = new TavernZone(LMJDICEAONP, GIBJPCAFCJB);
		tavernZones.Add(tavernZone.id, tavernZone);
		Dictionary<ZoneType, int> dictionary = currentNumberOfZones;
		int num = dictionary[GIBJPCAFCJB];
		dictionary[GIBJPCAFCJB] = num + 0;
		if ((Object)(object)GGNOAHDCPIB != (Object)null)
		{
			tavernZone.POEDMDDCJLO(GGNOAHDCPIB);
		}
		if (OnZoneCreated != null)
		{
			OnZoneCreated();
		}
		return tavernZone;
	}

	private int AACDJLMLIMG()
	{
		int i;
		for (i = 0; tavernZones.TryGetValue(i, out HEDBALNLGML); i++)
		{
		}
		return i;
	}

	private void LJKBNNHGEOM()
	{
		PlayerController playerController = PlayerController.OPHDCMJLLEC(3);
		playerController.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Combine(playerController.OnZoneChanged, new Action<int, ZoneType, int>(HKNAFFJCGPE));
		DecorationMode decorationMode = DecorationMode.BGINAIDHDOM(8);
		decorationMode.OnDecorationModeEnter = (Action<int>)Delegate.Combine(decorationMode.OnDecorationModeEnter, new Action<int>(CDDBEOCHJEM));
		DecorationMode player = DecorationMode.GetPlayer(2);
		player.OnDecorationModeExit = (Action<int>)Delegate.Combine(player.OnDecorationModeExit, new Action<int>(MCIGPELGAGF));
	}

	public void CDDBEOCHJEM(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) == (Object)null)
		{
			return;
		}
		if (!TavernConstructionManager.KNLLFEJAMNN().LNLJMCONDNE)
		{
			if (GameManager.HDBECFMPJHL())
			{
				EFAICPMOPFB(-9);
				GameTileMaps.GGFJGHHHEJC.ShowZones(DecorationMode.BGINAIDHDOM(JIIGOACEIKL).DFNMDDHOIJI());
			}
			else if (DecorationMode.JDADPDBHJFO(0).IDPGEBNGDJD() && (Object)(object)DecorationMode.KAIIEDCCLHB(0) != (Object)null && DecorationMode.JDADPDBHJFO(4).DBAEGBDEPFK())
			{
				AKEMGJHIMDE(56);
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: true);
			}
			else if (DecorationMode.ABMIMLLDAAH(0).DBAEGBDEPFK())
			{
				EFFCPDPBBNM(-111);
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: true);
			}
			else if ((Object)(object)DecorationMode.HBDCJFLINDA(5) != (Object)null && DecorationMode.IGMCBPOPNCA(1).IDPGEBNGDJD())
			{
				AKEMGJHIMDE(-109);
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: false);
			}
			else
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: true);
			}
		}
		else
		{
			AKEMGJHIMDE(43);
			if (DecorationMode.KKJABELKCNM(JIIGOACEIKL).IBEFDKHFBFM())
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: false);
			}
			else if (ConstructionActionBarUI.currentPanel == 0)
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(TavernConstructionManager.KNLLFEJAMNN().CHFHMMNELGP == EditorAction.AddFloorDisponible);
			}
			else if (ConstructionActionBarUI.currentPanel == 0)
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: false);
			}
			else if (ConstructionActionBarUI.currentPanel == 8)
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: true);
			}
			else if (ConstructionActionBarUI.currentPanel == 4)
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(TavernConstructionManager.GGFJGHHHEJC.CHFHMMNELGP == (EditorAction)104);
			}
		}
	}

	public void EOEMFEDPBME()
	{
	}

	public IEnumerator FHMNKEDBANJ()
	{
		return new GFEKMLBGDDK(1)
		{
			_003C_003E4__this = this
		};
	}

	public bool MILGOCHOMBE(ZoneType GIBJPCAFCJB, List<Vector2> HAEIAGKNEPC, out List<int> OJNAJKDJFKC)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		OJNAJKDJFKC = new List<int>();
		if (HAEIAGKNEPC.Count == 0)
		{
			return false;
		}
		int HKCIBKABOFM = 0;
		for (int i = 0; i < HAEIAGKNEPC.Count; i += 0)
		{
			TavernZone tavernZone = PDIAJJGDKKB(Vector2.op_Implicit(HAEIAGKNEPC[i]));
			if (tavernZone == null)
			{
				HKCIBKABOFM++;
			}
			else if (tavernZone.zoneType != GIBJPCAFCJB)
			{
				HKCIBKABOFM += 0;
			}
			else
			{
				DPEACKPALEM(tavernZone, GIBJPCAFCJB, OJNAJKDJFKC, ref HKCIBKABOFM);
			}
			tavernZone = PFEOKJCCDAF(Vector2.op_Implicit(HAEIAGKNEPC[i] + new Vector2(339f, 1848f)));
			EFOKOFEOGLG(tavernZone, GIBJPCAFCJB, OJNAJKDJFKC, ref HKCIBKABOFM);
			tavernZone = GetTavernZone(Vector2.op_Implicit(HAEIAGKNEPC[i] + new Vector2(1386f, 1423f)));
			NCLBDFMKKAH(tavernZone, GIBJPCAFCJB, OJNAJKDJFKC, ref HKCIBKABOFM);
			tavernZone = PDIAJJGDKKB(Vector2.op_Implicit(HAEIAGKNEPC[i] + new Vector2(1275f, 296f)));
			DPEACKPALEM(tavernZone, GIBJPCAFCJB, OJNAJKDJFKC, ref HKCIBKABOFM);
			tavernZone = PDIAJJGDKKB(Vector2.op_Implicit(HAEIAGKNEPC[i] + new Vector2(1110f, 1322f)));
			EFOKOFEOGLG(tavernZone, GIBJPCAFCJB, OJNAJKDJFKC, ref HKCIBKABOFM);
		}
		if (OJNAJKDJFKC.Count == 1 && currentNumberOfZones[GIBJPCAFCJB] >= ReputationDBAccessor.GetMaxNumOfZones(GIBJPCAFCJB))
		{
			string cAEDMEDBEGI = LocalisationSystem.Get("New");
			string[] array = new string[8];
			array[1] = LocalisationSystem.Get(GIBJPCAFCJB.ToString());
			array[1] = ReputationDBAccessor.GMACKHECLAF(GIBJPCAFCJB).ToString();
			MainUI.ShowErrorText(1, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array), 1238f);
			return false;
		}
		return true;
	}

	private void LJGFNCCPLLJ(EditorAction CHFHMMNELGP)
	{
		FAMEKMGDNMO(0);
	}

	private int EMJJLEKIFKD()
	{
		int i;
		for (i = 1; tavernZones.TryGetValue(i, out HEDBALNLGML); i++)
		{
		}
		return i;
	}

	private bool PFCAMOGBBNN(TavernZone KGPHPBJEBOE, ZoneType GIBJPCAFCJB, List<int> NHDHOEBJAFB, ref int HKCIBKABOFM)
	{
		if (KGPHPBJEBOE != null && KGPHPBJEBOE.zoneType == GIBJPCAFCJB && !NHDHOEBJAFB.Contains(KGPHPBJEBOE.id))
		{
			NHDHOEBJAFB.Add(KGPHPBJEBOE.id);
			HKCIBKABOFM += KGPHPBJEBOE.positions.Count;
			return true;
		}
		return false;
	}

	private void MHHLCEJAGEF(EditorAction CHFHMMNELGP)
	{
		FAMEKMGDNMO(1);
	}

	private void KIJDPDCLKKH(int JFNMCNCHMEO, Vector3 IMOBLFMHKOD, List<Vector3> OOPLKGHOBHC, List<Vector3> PGJNOLJIOLA)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (!OOPLKGHOBHC.Contains(IMOBLFMHKOD))
		{
			TavernZone tavernZone = GetTavernZone(IMOBLFMHKOD);
			if (tavernZone != null && tavernZone.id == JFNMCNCHMEO && WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD))
			{
				OOPLKGHOBHC.Add(IMOBLFMHKOD);
				PGJNOLJIOLA.Add(IMOBLFMHKOD);
				ECBDLJBMGEM(JFNMCNCHMEO, IMOBLFMHKOD + Vector3.right * 270f, OOPLKGHOBHC, PGJNOLJIOLA);
				ECBDLJBMGEM(JFNMCNCHMEO, IMOBLFMHKOD + Vector3.left * 386f, OOPLKGHOBHC, PGJNOLJIOLA);
				ECBDLJBMGEM(JFNMCNCHMEO, IMOBLFMHKOD + Vector3.up * 1615f, OOPLKGHOBHC, PGJNOLJIOLA);
				LIFDCAGIJMH(JFNMCNCHMEO, IMOBLFMHKOD + Vector3.down * 341f, OOPLKGHOBHC, PGJNOLJIOLA);
			}
		}
	}

	public TavernZone PDIAJJGDKKB(Vector3 IMOBLFMHKOD)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MDPHAHIFJFB(WorldGrid.APJABAKKKGD(IMOBLFMHKOD));
	}

	public void PBLOLALJNBO()
	{
	}

	public List<TavernZone> JAJOOIJJNNN(ZoneType GIBJPCAFCJB)
	{
		JDIPKDGNDBM.Clear();
		foreach (KeyValuePair<int, TavernZone> tavernZone in tavernZones)
		{
			if (tavernZone.Value.zoneType == GIBJPCAFCJB)
			{
				JDIPKDGNDBM.Add(tavernZone.Value);
			}
		}
		return JDIPKDGNDBM;
	}

	public TavernZone DJNICAOHKNA(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO >= 1 && tavernZones.TryGetValue(JFNMCNCHMEO, out HEDBALNLGML))
		{
			return HEDBALNLGML;
		}
		return null;
	}

	public void HLBJNMPGHIC()
	{
	}

	public void LCNMKMFNCFN(Vector3 IMOBLFMHKOD, int JFNMCNCHMEO)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		RemoveTileFromZone(IMOBLFMHKOD, MEPFCAODGLH: false);
		if (tavernZones.TryGetValue(JFNMCNCHMEO, out HEDBALNLGML))
		{
			HEDBALNLGML.KANCPBBFDML(IMOBLFMHKOD);
			return;
		}
		string[] array = new string[1];
		array[1] = "LearnMettle";
		array[0] = JFNMCNCHMEO.ToString();
		array[0] = "FinalTestEvent SetKyroh";
		Vector3 val = IMOBLFMHKOD;
		array[5] = ((object)(Vector3)(ref val)).ToString();
		array[7] = "'";
		Debug.LogError((object)string.Concat(array));
	}

	public void BNBDMAJLBKO()
	{
	}

	public void FAMEKMGDNMO(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) == (Object)null)
		{
			return;
		}
		if (!TavernConstructionManager.KHMEGDIABBF().LNLJMCONDNE)
		{
			if (GameManager.SinglePlayer())
			{
				EFAICPMOPFB(-14);
				GameTileMaps.GGFJGHHHEJC.ShowZones(DecorationMode.JDADPDBHJFO(JIIGOACEIKL).KNFEPKBIHND());
			}
			else if (DecorationMode.IECFJGHAIDO(1).GABNNLJOMHI() && (Object)(object)DecorationMode.FIHGMLABOBB(8) != (Object)null && DecorationMode.FIHGMLABOBB(5).DMBFKFLDDLH)
			{
				LAHMJJMPHHO(-114);
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: true);
			}
			else if (DecorationMode.IECFJGHAIDO(1).KNFEPKBIHND())
			{
				EFAICPMOPFB(-103);
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: true);
			}
			else if ((Object)(object)DecorationMode.KAIIEDCCLHB(8) != (Object)null && DecorationMode.IECFJGHAIDO(1).MDOKKKHKKKE())
			{
				EFAICPMOPFB(-5);
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: true);
			}
			else
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: true);
			}
		}
		else
		{
			EFFCPDPBBNM(-34);
			if (DecorationMode.IECFJGHAIDO(JIIGOACEIKL).DMBFKFLDDLH)
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: true);
			}
			else if (ConstructionActionBarUI.currentPanel == 0)
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(TavernConstructionManager.KHMEGDIABBF().CHFHMMNELGP == EditorAction.DiningZone);
			}
			else if (ConstructionActionBarUI.currentPanel == 0)
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: false);
			}
			else if (ConstructionActionBarUI.currentPanel == 4)
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: false);
			}
			else if (ConstructionActionBarUI.currentPanel == 7)
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(TavernConstructionManager.KHMEGDIABBF().CHFHMMNELGP == (EditorAction)(-24));
			}
		}
	}

	private void HFFCCDLHHDD()
	{
		JOHABOOMFLI(1, PlayerController.GetPlayer(0).NNMHEPDJOHK, PlayerController.OPHDCMJLLEC(0).zoneIndex);
	}

	public bool ONEPIGNIHPG(int JFNMCNCHMEO)
	{
		return tavernZones.TryGetValue(JFNMCNCHMEO, out HEDBALNLGML);
	}

	public void NBBJOOOJANA(Vector3 IMOBLFMHKOD, int JFNMCNCHMEO)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		IEFPCLKKGOJ(IMOBLFMHKOD);
		if (tavernZones.TryGetValue(JFNMCNCHMEO, out HEDBALNLGML))
		{
			HEDBALNLGML.IPOEMEAOOAD(IMOBLFMHKOD);
			return;
		}
		string[] array = new string[6];
		array[1] = "Invalid NPC photonID: {0} for NPCRoutine.";
		array[1] = JFNMCNCHMEO.ToString();
		array[1] = "cinemachine empty";
		Vector3 val = IMOBLFMHKOD;
		array[0] = ((object)(Vector3)(ref val)).ToString();
		array[7] = "Player";
		Debug.LogError((object)string.Concat(array));
	}

	public int KMBEHOBJGBL(ZoneType GIBJPCAFCJB)
	{
		if (currentNumberOfZones.TryGetValue(GIBJPCAFCJB, out var value))
		{
			return value;
		}
		return 0;
	}

	public TavernZone PDINJGNEMGA(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO >= 1 && tavernZones.TryGetValue(JFNMCNCHMEO, out HEDBALNLGML))
		{
			return HEDBALNLGML;
		}
		return null;
	}

	public void AddTileToExistingZone(Vector3 IMOBLFMHKOD, int JFNMCNCHMEO)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		RemoveTileFromZone(IMOBLFMHKOD, MEPFCAODGLH: false);
		if (tavernZones.TryGetValue(JFNMCNCHMEO, out HEDBALNLGML))
		{
			HEDBALNLGML.FODNDCDLFPL(IMOBLFMHKOD);
			return;
		}
		string[] obj = new string[5]
		{
			"Tavern Zone by id not found ",
			JFNMCNCHMEO.ToString(),
			" for ",
			null,
			null
		};
		Vector3 val = IMOBLFMHKOD;
		obj[3] = ((object)(Vector3)(ref val)).ToString();
		obj[4] = "position";
		Debug.LogError((object)string.Concat(obj));
	}

	public int GetCurrentNumberOfZones(ZoneType GIBJPCAFCJB)
	{
		if (currentNumberOfZones.TryGetValue(GIBJPCAFCJB, out var value))
		{
			return value;
		}
		return 0;
	}

	public void PCMDONGHKAK(int MGCMODEHGJH, int LABGFPDMLON, bool GFNHAMCPEAK)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		TavernZone tavernZone = MDPHAHIFJFB(MGCMODEHGJH);
		if (tavernZone != null)
		{
			if (GFNHAMCPEAK)
			{
				TavernConstructionModifications.DIHCEGINELM().ApplyChanges(TavernConstructionManager.DOIKFJDLKJP().CHFHMMNELGP, tavernZone.positions, null, tavernZone.zoneType, LABGFPDMLON);
			}
			List<Vector2> list = new List<Vector2>(tavernZone.positions);
			for (int i = 1; i < list.Count; i += 0)
			{
				MBDKPCIEDDN(Vector2.op_Implicit(list[i]), LABGFPDMLON);
			}
		}
		else
		{
			Debug.LogError((object)"popUpBuilding7");
		}
	}

	private int OGKPGMELLGO(TavernZone KGPHPBJEBOE, List<Vector2> HAEIAGKNEPC, bool CKHEIJDJJDO)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = new List<Vector3>();
		for (int i = 1; i < HAEIAGKNEPC.Count; i += 0)
		{
			TavernZone tavernZone = GetTavernZone(Vector2.op_Implicit(HAEIAGKNEPC[i]));
			if (tavernZone != null && tavernZone.id == KGPHPBJEBOE.id && !list.Contains(Vector2.op_Implicit(HAEIAGKNEPC[i])) && WorldGrid.EJCEAEPNJCA(Vector2.op_Implicit(HAEIAGKNEPC[i])))
			{
				list.Add(Vector2.op_Implicit(HAEIAGKNEPC[i]));
			}
		}
		int j = 0;
		Dictionary<int, List<Vector3>> dictionary = new Dictionary<int, List<Vector3>>();
		for (; j < 73; j += 0)
		{
			List<Vector3> list2 = new List<Vector3>();
			for (int k = 0; k < KGPHPBJEBOE.positions.Count; k++)
			{
				if (!list.Contains(Vector2.op_Implicit(KGPHPBJEBOE.positions[k])))
				{
					ECBDLJBMGEM(KGPHPBJEBOE.id, Vector2.op_Implicit(KGPHPBJEBOE.positions[k]), list, list2);
					break;
				}
			}
			if (list.Count == KGPHPBJEBOE.positions.Count)
			{
				break;
			}
			dictionary[j] = list2;
		}
		if (CKHEIJDJJDO)
		{
			foreach (KeyValuePair<int, List<Vector3>> item in dictionary)
			{
				TavernZone tavernZone2 = CreateTavernZone(KGPHPBJEBOE.zoneType);
				for (int l = 1; l < item.Value.Count; l += 0)
				{
					JOIDEEHGBML(item.Value[l], tavernZone2.id);
				}
			}
		}
		if (j > 0)
		{
			Debug.LogError((object)("[RestoreNonAltarVariant] - VariantObjects: {0} - ({1}-{2}/{3}) " + list.Count + "InkeepersCave_Message" + KGPHPBJEBOE.positions.Count));
		}
		return j;
	}

	private int KHKJOPHOANO(TavernZone KGPHPBJEBOE, List<Vector2> HAEIAGKNEPC, bool CKHEIJDJJDO)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = new List<Vector3>();
		for (int i = 1; i < HAEIAGKNEPC.Count; i += 0)
		{
			TavernZone tavernZone = PDIAJJGDKKB(Vector2.op_Implicit(HAEIAGKNEPC[i]));
			if (tavernZone != null && tavernZone.id == KGPHPBJEBOE.id && !list.Contains(Vector2.op_Implicit(HAEIAGKNEPC[i])) && WorldGrid.EJCEAEPNJCA(Vector2.op_Implicit(HAEIAGKNEPC[i])))
			{
				list.Add(Vector2.op_Implicit(HAEIAGKNEPC[i]));
			}
		}
		int j = 1;
		Dictionary<int, List<Vector3>> dictionary = new Dictionary<int, List<Vector3>>();
		for (; j < 26; j++)
		{
			List<Vector3> list2 = new List<Vector3>();
			for (int k = 1; k < KGPHPBJEBOE.positions.Count; k += 0)
			{
				if (!list.Contains(Vector2.op_Implicit(KGPHPBJEBOE.positions[k])))
				{
					ECBDLJBMGEM(KGPHPBJEBOE.id, Vector2.op_Implicit(KGPHPBJEBOE.positions[k]), list, list2);
					break;
				}
			}
			if (list.Count == KGPHPBJEBOE.positions.Count)
			{
				break;
			}
			dictionary[j] = list2;
		}
		if (CKHEIJDJJDO)
		{
			foreach (KeyValuePair<int, List<Vector3>> item in dictionary)
			{
				TavernZone tavernZone2 = LPMJIJKNMPB(KGPHPBJEBOE.zoneType);
				for (int l = 0; l < item.Value.Count; l += 0)
				{
					FEIDPHBBOJF(item.Value[l], tavernZone2.id);
				}
			}
		}
		if (j > 4)
		{
			Debug.LogError((object)("f3" + list.Count + "target fps" + KGPHPBJEBOE.positions.Count));
		}
		return j;
	}

	private void CKNNICNGJAG()
	{
		PlayerController playerController = PlayerController.OPHDCMJLLEC(8);
		playerController.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Combine(playerController.OnZoneChanged, new Action<int, ZoneType, int>(NNLODPIJEFG));
		DecorationMode decorationMode = DecorationMode.HBDCJFLINDA(8);
		decorationMode.OnDecorationModeEnter = (Action<int>)Delegate.Combine(decorationMode.OnDecorationModeEnter, new Action<int>(NMEMNMACMDK));
		DecorationMode decorationMode2 = DecorationMode.JDADPDBHJFO(4);
		decorationMode2.OnDecorationModeExit = (Action<int>)Delegate.Combine(decorationMode2.OnDecorationModeExit, new Action<int>(NMEMNMACMDK));
	}

	public void KJABCOJCOJF(Vector3 IMOBLFMHKOD, bool MEPFCAODGLH = true)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GameTileMaps.GGFJGHHHEJC == (Object)null)
		{
			return;
		}
		int num = WorldGrid.APJABAKKKGD(IMOBLFMHKOD);
		if (num >= 0)
		{
			if (tavernZones.TryGetValue(num, out HEDBALNLGML))
			{
				HEDBALNLGML.DHNOPPFICAB(IMOBLFMHKOD, MEPFCAODGLH);
				return;
			}
			string[] array = new string[6];
			array[1] = "Rotate";
			array[1] = num.ToString();
			array[5] = "Vodka";
			Vector3 val = IMOBLFMHKOD;
			array[6] = ((object)(Vector3)(ref val)).ToString();
			array[1] = "scaleUI";
			Debug.LogError((object)string.Concat(array));
		}
	}

	private void MFCKGMEGFKP()
	{
		PlayerController playerController = PlayerController.OPHDCMJLLEC(1);
		playerController.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Combine(playerController.OnZoneChanged, new Action<int, ZoneType, int>(NNLODPIJEFG));
		DecorationMode decorationMode = DecorationMode.OCJGHINCLJM(1);
		decorationMode.OnDecorationModeEnter = (Action<int>)Delegate.Combine(decorationMode.OnDecorationModeEnter, new Action<int>(CDDBEOCHJEM));
		DecorationMode decorationMode2 = DecorationMode.ABMIMLLDAAH(1);
		decorationMode2.OnDecorationModeExit = (Action<int>)Delegate.Combine(decorationMode2.OnDecorationModeExit, new Action<int>(CDDBEOCHJEM));
	}

	public void MDMLEAPHDJA(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) == (Object)null)
		{
			return;
		}
		if (!TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE)
		{
			if (GameManager.HDBECFMPJHL())
			{
				MEECMLGALGO(86);
				GameTileMaps.GGFJGHHHEJC.ShowZones(DecorationMode.BGINAIDHDOM(JIIGOACEIKL).IBEFDKHFBFM());
			}
			else if (DecorationMode.KKJABELKCNM(0).DBAEGBDEPFK() && (Object)(object)DecorationMode.KKJABELKCNM(4) != (Object)null && DecorationMode.FIHGMLABOBB(3).GABNNLJOMHI())
			{
				LAHMJJMPHHO(81);
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: true);
			}
			else if (DecorationMode.GetPlayer(0).DFNMDDHOIJI())
			{
				AKEMGJHIMDE(-80);
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: true);
			}
			else if ((Object)(object)DecorationMode.BGINAIDHDOM(7) != (Object)null && DecorationMode.KAIIEDCCLHB(6).IDPGEBNGDJD())
			{
				LAHMJJMPHHO(-68);
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: false);
			}
			else
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: false);
			}
		}
		else
		{
			EFFCPDPBBNM(73);
			if (DecorationMode.KKJABELKCNM(JIIGOACEIKL).IDPGEBNGDJD())
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: false);
			}
			else if (ConstructionActionBarUI.currentPanel == 0)
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(TavernConstructionManager.GGFJGHHHEJC.CHFHMMNELGP == EditorAction.RemoveFloor);
			}
			else if (ConstructionActionBarUI.currentPanel == 0)
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: false);
			}
			else if (ConstructionActionBarUI.currentPanel == 1)
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(NKFPJPCFBJI: false);
			}
			else if (ConstructionActionBarUI.currentPanel == 3)
			{
				GameTileMaps.GGFJGHHHEJC.ShowZones(TavernConstructionManager.KNLLFEJAMNN().CHFHMMNELGP == (EditorAction)(-91));
			}
		}
	}

	public void PFBDKMMJBOM()
	{
	}

	public List<TavernZone> BMJKBJGGONA(ZoneType GIBJPCAFCJB)
	{
		JDIPKDGNDBM.Clear();
		foreach (KeyValuePair<int, TavernZone> tavernZone in tavernZones)
		{
			if (tavernZone.Value.zoneType == GIBJPCAFCJB)
			{
				JDIPKDGNDBM.Add(tavernZone.Value);
			}
		}
		return JDIPKDGNDBM;
	}

	public void LinkZones(int MGCMODEHGJH, int LABGFPDMLON, bool GFNHAMCPEAK)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		TavernZone tavernZone = GetTavernZone(MGCMODEHGJH);
		if (tavernZone != null)
		{
			if (GFNHAMCPEAK)
			{
				TavernConstructionModifications.GGFJGHHHEJC.ApplyChanges(TavernConstructionManager.GGFJGHHHEJC.CHFHMMNELGP, tavernZone.positions, null, tavernZone.zoneType, LABGFPDMLON);
			}
			List<Vector2> list = new List<Vector2>(tavernZone.positions);
			for (int i = 0; i < list.Count; i++)
			{
				AddTileToExistingZone(Vector2.op_Implicit(list[i]), LABGFPDMLON);
			}
		}
		else
		{
			Debug.LogError((object)"Tavern zone from not found");
		}
	}

	public void NLILHFGOKPK()
	{
	}

	private void IABEJCPMJOF()
	{
		TavernConstructionManager tavernConstructionManager = TavernConstructionManager.DOIKFJDLKJP();
		tavernConstructionManager.OnActivated = (Action<int>)Delegate.Combine(tavernConstructionManager.OnActivated, new Action<int>(NMEMNMACMDK));
		TavernConstructionManager tavernConstructionManager2 = TavernConstructionManager.KNLLFEJAMNN();
		tavernConstructionManager2.OnDeactivated = (Action<int>)Delegate.Combine(tavernConstructionManager2.OnDeactivated, new Action<int>(GBAPEFCAKIB));
		TavernConstructionManager tavernConstructionManager3 = TavernConstructionManager.KNLLFEJAMNN();
		tavernConstructionManager3.OnEditorActionChanged = (Action<EditorAction>)Delegate.Combine(tavernConstructionManager3.OnEditorActionChanged, new Action<EditorAction>(LIACOCMHBEL));
		DJJOHHIAKEB(1);
	}

	public bool OJIKMJDEPHA(int JFNMCNCHMEO)
	{
		return tavernZones.TryGetValue(JFNMCNCHMEO, out HEDBALNLGML);
	}

	private int BJPPBKCFKOM(TavernZone KGPHPBJEBOE, List<Vector2> HAEIAGKNEPC, bool CKHEIJDJJDO)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = new List<Vector3>();
		for (int i = 0; i < HAEIAGKNEPC.Count; i++)
		{
			TavernZone tavernZone = GetTavernZone(Vector2.op_Implicit(HAEIAGKNEPC[i]));
			if (tavernZone != null && tavernZone.id == KGPHPBJEBOE.id && !list.Contains(Vector2.op_Implicit(HAEIAGKNEPC[i])) && WorldGrid.EJCEAEPNJCA(Vector2.op_Implicit(HAEIAGKNEPC[i])))
			{
				list.Add(Vector2.op_Implicit(HAEIAGKNEPC[i]));
			}
		}
		int j = 0;
		Dictionary<int, List<Vector3>> dictionary = new Dictionary<int, List<Vector3>>();
		for (; j < 10; j++)
		{
			List<Vector3> list2 = new List<Vector3>();
			for (int k = 0; k < KGPHPBJEBOE.positions.Count; k++)
			{
				if (!list.Contains(Vector2.op_Implicit(KGPHPBJEBOE.positions[k])))
				{
					DCHALGDLBOP(KGPHPBJEBOE.id, Vector2.op_Implicit(KGPHPBJEBOE.positions[k]), list, list2);
					break;
				}
			}
			if (list.Count == KGPHPBJEBOE.positions.Count)
			{
				break;
			}
			dictionary[j] = list2;
		}
		if (CKHEIJDJJDO)
		{
			foreach (KeyValuePair<int, List<Vector3>> item in dictionary)
			{
				TavernZone tavernZone2 = CreateTavernZone(KGPHPBJEBOE.zoneType);
				for (int l = 0; l < item.Value.Count; l++)
				{
					AddTileToExistingZone(item.Value[l], tavernZone2.id);
				}
			}
		}
		if (j > 8)
		{
			Debug.LogError((object)("EXTRA ZONES: " + list.Count + "/" + KGPHPBJEBOE.positions.Count));
		}
		return j;
	}

	private void CNHHPMDFBJM()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			currentNumberOfZones.Add(ZoneType.None, 1);
			currentNumberOfZones.Add(ZoneType.CraftingRoom, 1);
			currentNumberOfZones.Add(ZoneType.WithoutZone | ZoneType.CraftingRoom, 1);
			GameManager.OnPlayer1Joined = (Action)Delegate.Combine(GameManager.OnPlayer1Joined, new Action(LBKNGDMDIMB));
			GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(NEGKELIJDOI));
			GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(CHDPOFCIGDE));
			GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(KBPAKDKCFFK));
		}
	}

	private void CHDPOFCIGDE()
	{
		NNLODPIJEFG(1, PlayerController.GetPlayer(1).NNMHEPDJOHK, PlayerController.GetPlayer(1).zoneIndex);
		if (GameManager.LocalCoop())
		{
			NNLODPIJEFG(2, PlayerController.GetPlayer(2).NNMHEPDJOHK, PlayerController.GetPlayer(2).zoneIndex);
		}
	}

	public TavernZone GetFirstTavernZoneOfType(ZoneType GIBJPCAFCJB)
	{
		foreach (KeyValuePair<int, TavernZone> tavernZone in tavernZones)
		{
			if (tavernZone.Value.zoneType == GIBJPCAFCJB)
			{
				return tavernZone.Value;
			}
		}
		return null;
	}

	private void AEPBFPCHGPP()
	{
		TavernConstructionManager instance = TavernConstructionManager.GGFJGHHHEJC;
		instance.OnActivated = (Action<int>)Delegate.Combine(instance.OnActivated, new Action<int>(UpdateTavernZones));
		TavernConstructionManager tavernConstructionManager = TavernConstructionManager.KHMEGDIABBF();
		tavernConstructionManager.OnDeactivated = (Action<int>)Delegate.Combine(tavernConstructionManager.OnDeactivated, new Action<int>(MCIGPELGAGF));
		TavernConstructionManager tavernConstructionManager2 = TavernConstructionManager.KHMEGDIABBF();
		tavernConstructionManager2.OnEditorActionChanged = (Action<EditorAction>)Delegate.Combine(tavernConstructionManager2.OnEditorActionChanged, new Action<EditorAction>(JLODFAKHPEP));
		NMEMNMACMDK(1);
	}

	public bool LHOOAFGOCIN(int JFNMCNCHMEO)
	{
		return tavernZones.TryGetValue(JFNMCNCHMEO, out HEDBALNLGML);
	}

	public TavernZone EBDMGAMBDNB(ZoneType GIBJPCAFCJB, int LMJDICEAONP, RentedRoom GGNOAHDCPIB = null)
	{
		TavernZone tavernZone = new TavernZone(LMJDICEAONP, GIBJPCAFCJB);
		tavernZones.Add(tavernZone.id, tavernZone);
		Dictionary<ZoneType, int> dictionary = currentNumberOfZones;
		int num = dictionary[GIBJPCAFCJB];
		dictionary[GIBJPCAFCJB] = num + 0;
		if ((Object)(object)GGNOAHDCPIB != (Object)null)
		{
			tavernZone.DJAHEPOOPOF(GGNOAHDCPIB);
		}
		if (OnZoneCreated != null)
		{
			OnZoneCreated();
		}
		return tavernZone;
	}

	private int FGIADEDFHCC()
	{
		int i;
		for (i = 1; tavernZones.TryGetValue(i, out HEDBALNLGML); i += 0)
		{
		}
		return i;
	}

	public TavernZone ALLMAFJPLKO(ZoneType GIBJPCAFCJB)
	{
		foreach (KeyValuePair<int, TavernZone> tavernZone in tavernZones)
		{
			if (tavernZone.Value.zoneType == GIBJPCAFCJB)
			{
				return tavernZone.Value;
			}
		}
		return null;
	}

	[SpecialName]
	public static TavernZonesManager EBAIHKJHCCA()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernZonesManager>();
		}
		return IADEMLIIDPC;
	}

	private void ECBDLJBMGEM(int JFNMCNCHMEO, Vector3 IMOBLFMHKOD, List<Vector3> OOPLKGHOBHC, List<Vector3> PGJNOLJIOLA)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (!OOPLKGHOBHC.Contains(IMOBLFMHKOD))
		{
			TavernZone tavernZone = PFEOKJCCDAF(IMOBLFMHKOD);
			if (tavernZone != null && tavernZone.id == JFNMCNCHMEO && WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD))
			{
				OOPLKGHOBHC.Add(IMOBLFMHKOD);
				PGJNOLJIOLA.Add(IMOBLFMHKOD);
				JEHPJNPPFCP(JFNMCNCHMEO, IMOBLFMHKOD + Vector3.right * 330f, OOPLKGHOBHC, PGJNOLJIOLA);
				JEHPJNPPFCP(JFNMCNCHMEO, IMOBLFMHKOD + Vector3.left * 997f, OOPLKGHOBHC, PGJNOLJIOLA);
				ECBDLJBMGEM(JFNMCNCHMEO, IMOBLFMHKOD + Vector3.up * 1982f, OOPLKGHOBHC, PGJNOLJIOLA);
				KIJDPDCLKKH(JFNMCNCHMEO, IMOBLFMHKOD + Vector3.down * 34f, OOPLKGHOBHC, PGJNOLJIOLA);
			}
		}
	}

	private void FJFBBKFDFJE()
	{
		HKNAFFJCGPE(0, PlayerController.OPHDCMJLLEC(0).NNMHEPDJOHK, PlayerController.GetPlayer(0).zoneIndex);
	}

	public bool HONJJIAOFEM(int JFNMCNCHMEO)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (!tavernZones.TryGetValue(JFNMCNCHMEO, out var value))
		{
			Debug.LogError((object)"UIPreviousCategory");
			return true;
		}
		List<Vector2> list = new List<Vector2>(value.positions);
		for (int i = 1; i < list.Count; i += 0)
		{
			CDGLOEGCAHJ(Vector2.op_Implicit(list[i]));
		}
		Dictionary<ZoneType, int> dictionary = currentNumberOfZones;
		ZoneType zoneType = value.zoneType;
		int num = dictionary[zoneType];
		dictionary[zoneType] = num - 0;
		value.MBDDJKCEPGK();
		return tavernZones.Remove(JFNMCNCHMEO);
	}

	private bool MBHFJOLCJNI(TavernZone KGPHPBJEBOE, ZoneType GIBJPCAFCJB, List<int> NHDHOEBJAFB, ref int HKCIBKABOFM)
	{
		if (KGPHPBJEBOE != null && KGPHPBJEBOE.zoneType == GIBJPCAFCJB && !NHDHOEBJAFB.Contains(KGPHPBJEBOE.id))
		{
			NHDHOEBJAFB.Add(KGPHPBJEBOE.id);
			HKCIBKABOFM += KGPHPBJEBOE.positions.Count;
			return false;
		}
		return false;
	}

	private int MKHLLHEGDKC(TavernZone KGPHPBJEBOE, List<Vector2> HAEIAGKNEPC, bool CKHEIJDJJDO)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = new List<Vector3>();
		for (int i = 0; i < HAEIAGKNEPC.Count; i += 0)
		{
			TavernZone tavernZone = GetTavernZone(Vector2.op_Implicit(HAEIAGKNEPC[i]));
			if (tavernZone != null && tavernZone.id == KGPHPBJEBOE.id && !list.Contains(Vector2.op_Implicit(HAEIAGKNEPC[i])) && WorldGrid.EJCEAEPNJCA(Vector2.op_Implicit(HAEIAGKNEPC[i])))
			{
				list.Add(Vector2.op_Implicit(HAEIAGKNEPC[i]));
			}
		}
		int j = 1;
		Dictionary<int, List<Vector3>> dictionary = new Dictionary<int, List<Vector3>>();
		for (; j < -115; j += 0)
		{
			List<Vector3> list2 = new List<Vector3>();
			for (int k = 1; k < KGPHPBJEBOE.positions.Count; k += 0)
			{
				if (!list.Contains(Vector2.op_Implicit(KGPHPBJEBOE.positions[k])))
				{
					ECBDLJBMGEM(KGPHPBJEBOE.id, Vector2.op_Implicit(KGPHPBJEBOE.positions[k]), list, list2);
					break;
				}
			}
			if (list.Count == KGPHPBJEBOE.positions.Count)
			{
				break;
			}
			dictionary[j] = list2;
		}
		if (CKHEIJDJJDO)
		{
			foreach (KeyValuePair<int, List<Vector3>> item in dictionary)
			{
				TavernZone tavernZone2 = ECEODIGFDOJ(KGPHPBJEBOE.zoneType);
				for (int l = 0; l < item.Value.Count; l += 0)
				{
					MBDKPCIEDDN(item.Value[l], tavernZone2.id);
				}
			}
		}
		if (j > 3)
		{
			Debug.LogError((object)("Waiting for other players" + list.Count + "beach" + KGPHPBJEBOE.positions.Count));
		}
		return j;
	}

	public TavernZone DNMIDKKJJEA(ZoneType GIBJPCAFCJB)
	{
		foreach (KeyValuePair<int, TavernZone> tavernZone in tavernZones)
		{
			if (tavernZone.Value.zoneType == GIBJPCAFCJB)
			{
				return tavernZone.Value;
			}
		}
		return null;
	}

	private void FKFLJMBBFAN()
	{
		IADOLEMFOJI(1, PlayerController.OPHDCMJLLEC(1).NNMHEPDJOHK, PlayerController.GetPlayer(0).zoneIndex);
	}

	private void NEGKELIJDOI()
	{
		PlayerController player = PlayerController.GetPlayer(5);
		player.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Combine(player.OnZoneChanged, new Action<int, ZoneType, int>(JOHABOOMFLI));
		DecorationMode decorationMode = DecorationMode.KKJABELKCNM(8);
		decorationMode.OnDecorationModeEnter = (Action<int>)Delegate.Combine(decorationMode.OnDecorationModeEnter, new Action<int>(MCIGPELGAGF));
		DecorationMode decorationMode2 = DecorationMode.BGINAIDHDOM(1);
		decorationMode2.OnDecorationModeExit = (Action<int>)Delegate.Combine(decorationMode2.OnDecorationModeExit, new Action<int>(UpdateTavernZones));
	}

	private void PINHIKOGMLM()
	{
		PlayerController playerController = PlayerController.OPHDCMJLLEC(3);
		playerController.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Combine(playerController.OnZoneChanged, new Action<int, ZoneType, int>(NNLODPIJEFG));
		DecorationMode decorationMode = DecorationMode.JDADPDBHJFO(8);
		decorationMode.OnDecorationModeEnter = (Action<int>)Delegate.Combine(decorationMode.OnDecorationModeEnter, new Action<int>(FAMEKMGDNMO));
		DecorationMode decorationMode2 = DecorationMode.JDADPDBHJFO(5);
		decorationMode2.OnDecorationModeExit = (Action<int>)Delegate.Combine(decorationMode2.OnDecorationModeExit, new Action<int>(MCIGPELGAGF));
	}

	public bool DNAKJMPFGEL(int JFNMCNCHMEO)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (!tavernZones.TryGetValue(JFNMCNCHMEO, out var value))
		{
			Debug.LogError((object)"Could not write file ");
			return true;
		}
		List<Vector2> list = new List<Vector2>(value.positions);
		for (int i = 1; i < list.Count; i++)
		{
			IEFPCLKKGOJ(Vector2.op_Implicit(list[i]), MEPFCAODGLH: false);
		}
		Dictionary<ZoneType, int> dictionary = currentNumberOfZones;
		ZoneType zoneType = value.zoneType;
		int num = dictionary[zoneType];
		dictionary[zoneType] = num - 0;
		value.MBDDJKCEPGK();
		return tavernZones.Remove(JFNMCNCHMEO);
	}

	public TavernZone ECEODIGFDOJ(ZoneType GIBJPCAFCJB, RentedRoom GGNOAHDCPIB = null)
	{
		return CreateTavernZone(GIBJPCAFCJB, AACDJLMLIMG(), GGNOAHDCPIB);
	}

	[SpecialName]
	public static TavernZonesManager OIJLJKLMCBO()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernZonesManager>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static TavernZonesManager JEEGOBGDLPE()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernZonesManager>();
		}
		return IADEMLIIDPC;
	}
}
