using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(DoWork))]
public class Table : MonoBehaviour, IInteractable, IHoverable, IProximity
{
	[CompilerGenerated]
	private sealed class MJAPDELAMOM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Table _003C_003E4__this;

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
		public MJAPDELAMOM(int _003C_003E1__state)
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
			Table table = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				break;
			case 1:
				_003C_003E1__state = -1;
				if (Time.time > table.AJPMIJBCADE)
				{
					if ((Object)(object)table.CBLBJCEOBEG != (Object)null)
					{
						table.CBLBJCEOBEG.Stop();
						Utils.BLPDAEHPOBA(((Component)table.CBLBJCEOBEG).gameObject);
						table.CBLBJCEOBEG = null;
					}
					table.doWork.Stop();
				}
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				break;
			}
			if (table.doWork.JCMBHAEKLKK)
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
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

	public Action OnBecomeClean = delegate
	{
	};

	[SerializeField]
	private float dirtiness;

	[HideInInspector]
	public TableCloth tableCloth;

	public OnlineTable onlineTable;

	private bool FECCKLBPNEA;

	private float GCCDADAPKPF;

	private TableDirtLevel DCDLGMBCPCE;

	[SerializeField]
	private Sprite tableSprite;

	[SerializeField]
	private Sprite tableDirty;

	[SerializeField]
	private Sprite tableVeryDirty;

	[SerializeField]
	private Sprite tableTutorial;

	[SerializeField]
	private Sprite tableDirtyTutorial;

	[SerializeField]
	private Sprite tableVeryDirtyTutorial;

	[SerializeField]
	private DoWork doWork;

	private float AJPMIJBCADE;

	[SerializeField]
	private SpriteRenderer spriteRenderer;

	public float leftRightTuck;

	public float upDownTuck;

	public float tableDirtyMultiplier = 1f;

	public Placeable placeable;

	private AudioSource CBLBJCEOBEG;

	private string FBKKOFBMMIN = "Table is dirty";

	public float loadedDirtiness;

	private int OJJCMMBGGEC;

	[SerializeField]
	private bool useBlockSpaces = true;

	public Transform[] freeSpaces1;

	public Transform[] freeSpaces2;

	[SerializeField]
	private Transform cleanPosition1;

	[SerializeField]
	private Transform cleanPosition2;

	[SerializeField]
	private Transform tableMask;

	[SerializeField]
	private SeatingGroup[] seatingGroups;

	[SerializeField]
	private List<int> canSeatPositions;

	public List<Seat> seat;

	public ServeOrderInTable serveOrderInTable;

	public DirtyDish[] dish;

	private bool OGICABGJDLL;

	private static Coaster CLOICPLGHLI;

	private Vector3 FIAMALDJHFL;

	private bool LJAMOPAKFPL;

	private int ABAIKKGKDGD;

	public float PDPKEPEBPIK
	{
		get
		{
			return dirtiness;
		}
		set
		{
			dirtiness = Mathf.Min(value, (float)(2000 * OJJCMMBGGEC));
			if (dirtiness > (float)DirtinessThreshold(TableDirtLevel.VeryDirty))
			{
				JNHCCCBICDM = TableDirtLevel.VeryDirty;
				if (OGICABGJDLL)
				{
					IEKDBGNGKOC(5);
				}
			}
			else if (dirtiness > (float)DirtinessThreshold(TableDirtLevel.Dirty))
			{
				JNHCCCBICDM = TableDirtLevel.Dirty;
				if (OGICABGJDLL)
				{
					IEKDBGNGKOC(3);
				}
			}
			else if (dirtiness > (float)DirtinessThreshold(TableDirtLevel.Messy))
			{
				JNHCCCBICDM = TableDirtLevel.Messy;
				if (OGICABGJDLL)
				{
					IEKDBGNGKOC(2);
				}
			}
			else if (dirtiness < (float)DirtinessThreshold(TableDirtLevel.Clean))
			{
				JNHCCCBICDM = TableDirtLevel.Perfect;
				if (OGICABGJDLL)
				{
					IEKDBGNGKOC(0);
				}
			}
			else
			{
				JNHCCCBICDM = TableDirtLevel.Clean;
				if (OGICABGJDLL)
				{
					IEKDBGNGKOC(0);
				}
			}
		}
	}

	public TableDirtLevel JNHCCCBICDM
	{
		get
		{
			return DCDLGMBCPCE;
		}
		set
		{
			if (value == DCDLGMBCPCE)
			{
				return;
			}
			if (placeable.currentZoneType == ZoneType.DiningRoom)
			{
				TavernManager.GGFJGHHHEJC.PDPKEPEBPIK -= GCCDADAPKPF;
			}
			DCDLGMBCPCE = value;
			CheckTableSprites();
			if (placeable.currentZoneType == ZoneType.DiningRoom)
			{
				GCCDADAPKPF = (float)DirtinessThreshold(DCDLGMBCPCE) / Mathf.Max(1f, TavernManager.GGFJGHHHEJC.tableDirtinessScale);
				if (NewTutorialManager.CCCLOBIOMCL)
				{
					GCCDADAPKPF *= 0.5f;
				}
				TavernManager.GGFJGHHHEJC.PDPKEPEBPIK += GCCDADAPKPF;
			}
			CommonReferences.GGFJGHHHEJC.OnAnyTableDirtLevelChanged(DCDLGMBCPCE);
		}
	}

	public void BFAAFIPPFKM(float FHHCDEOMPDH, bool KGCEBPFKPOG = true, bool CDPAMNIPPEC = true)
	{
		OGICABGJDLL = true;
		if (KGCEBPFKPOG)
		{
			PDPKEPEBPIK = FAJDGMBMHMJ() + FHHCDEOMPDH * tableDirtyMultiplier;
		}
		else
		{
			JJAGPCKINJH(FAJDGMBMHMJ() + FHHCDEOMPDH);
		}
		if (OnlineManager.JPPBEIJDCLJ() && CDPAMNIPPEC)
		{
			if (KGCEBPFKPOG)
			{
				onlineTable.JDJGELNCKPP(FHHCDEOMPDH * tableDirtyMultiplier);
			}
			else
			{
				onlineTable.HADFIKLLKMK(FHHCDEOMPDH);
			}
		}
	}

	private void GJFHCMHELPO(int JIIGOACEIKL)
	{
		HGCDPGJHMNP();
	}

	public bool GPHHMPEOCEJ(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI)
		{
			if (!DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).DFNMDDHOIJI() && CDLMMHAHDON() != 0 && IPEPPDAICDD() != TableDirtLevel.Clean)
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("ERROR: The object "));
				return false;
			}
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		}
		return false;
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnTavernRepaired = (Action<int>)Delegate.Remove(instance.OnTavernRepaired, new Action<int>(AKHEBCIABFH));
			if (Object.op_Implicit((Object)(object)tableMask))
			{
				Utils.BLPDAEHPOBA(((Component)tableMask).gameObject);
			}
		}
	}

	private void GKAJDICMAPM()
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		if (!useBlockSpaces || freeSpaces1 == null || freeSpaces1.Length == 0 || freeSpaces2 == null || freeSpaces2.Length == 0)
		{
			return;
		}
		bool flag = LMOELDGFPHK(freeSpaces1);
		bool flag2 = LMOELDGFPHK(freeSpaces2);
		if (placeable.FHEMHCEAICB || placeable.PHOCAFJDCDK)
		{
			if (flag)
			{
				for (int i = 0; i < freeSpaces1.Length; i++)
				{
					WorldGrid.NBMCMFAGPNE(freeSpaces1[i].position, ((Component)this).gameObject);
				}
			}
			if (flag2)
			{
				for (int j = 0; j < freeSpaces2.Length; j++)
				{
					WorldGrid.NBMCMFAGPNE(freeSpaces2[j].position, ((Component)this).gameObject);
				}
			}
			return;
		}
		if (!flag && flag2)
		{
			for (int k = 0; k < freeSpaces1.Length; k++)
			{
				WorldGrid.NBMCMFAGPNE(freeSpaces1[k].position, ((Component)this).gameObject);
			}
			for (int l = 0; l < freeSpaces2.Length; l++)
			{
				WorldGrid.JJEOOJEIIFM(freeSpaces2[l].position, ((Component)this).gameObject);
			}
			return;
		}
		if (flag && !flag2)
		{
			for (int m = 0; m < freeSpaces1.Length; m++)
			{
				WorldGrid.JJEOOJEIIFM(freeSpaces1[m].position, ((Component)this).gameObject);
			}
			for (int n = 0; n < freeSpaces2.Length; n++)
			{
				WorldGrid.NBMCMFAGPNE(freeSpaces2[n].position, ((Component)this).gameObject);
			}
			return;
		}
		if (flag)
		{
			for (int num = 0; num < freeSpaces1.Length; num++)
			{
				WorldGrid.NBMCMFAGPNE(freeSpaces1[num].position, ((Component)this).gameObject);
			}
		}
		if (flag2)
		{
			for (int num2 = 0; num2 < freeSpaces2.Length; num2++)
			{
				WorldGrid.NBMCMFAGPNE(freeSpaces2[num2].position, ((Component)this).gameObject);
			}
		}
	}

	private void HPNHFFODJIC(int JIIGOACEIKL)
	{
		APMMMPNALBN(JIIGOACEIKL, ENCANKDGBOH: false);
	}

	public bool IBMMEBJBHOE(int JIIGOACEIKL)
	{
		PlayerController playerController = PlayerController.OPHDCMJLLEC(JIIGOACEIKL);
		playerController.characterAnimation.SetCleaning(NJHMBMGKCPL: true, placeable.placeableSurface);
		playerController.rb.interpolation = (RigidbodyInterpolation2D)0;
		if (OnlineManager.PlayingOnline())
		{
			playerController.characterAnimation.characterAnimator.ActivatedCleanSprites?.Invoke(arg1: true, arg2: false, placeable.placeableSurface, (byte)playerController.characterAnimation.FCGBJEIIMBC);
		}
		return true;
	}

	private void DJBKHJFHAHL()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			SetDirtiness(loadedDirtiness);
		}
	}

	private bool CBPPJLOGKFL(int JIIGOACEIKL, float LLIKFNFINLB)
	{
		if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).EECADEPLELA() != "LE_8" && !NewTutorialManager.CleanTableBlocked(JIIGOACEIKL))
		{
			if (doWork.OENMBFGINAL())
			{
				if (!PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator.IHLIHEEAIMD())
				{
					PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.MNPJICEALPE(NJHMBMGKCPL: false, placeable.placeableSurface);
				}
				if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator.MLBGEKOIALK)
				{
					if ((Object)(object)CBLBJCEOBEG == (Object)null)
					{
						CBLBJCEOBEG = Sound.ABDJJBFNLBJ().NADFIJPBNCH(Utils.CPDCJAHJOPE(Sound.BNBMNOMFFBE().cleanTable), null, null, 1508f);
					}
					if (doWork.PFLPFNICHJA(JIIGOACEIKL, LLIKFNFINLB, CDPAMNIPPEC: false))
					{
						SetDirtiness(1066f, CDPAMNIPPEC: false);
						if ((Object)(object)CBLBJCEOBEG != (Object)null)
						{
							CBLBJCEOBEG.Stop();
							Utils.BLPDAEHPOBA(((Component)CBLBJCEOBEG).gameObject);
							CBLBJCEOBEG = null;
						}
						PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.SetCleaning(NJHMBMGKCPL: false, placeable.placeableSurface);
						PlayerController.GetPlayer(JIIGOACEIKL).rb.interpolation = (RigidbodyInterpolation2D)0;
						if (FECCKLBPNEA)
						{
							Utils.FKKHJPEMNBG("Fishing Update: Recipe fragments updated from ", 1);
						}
						FECCKLBPNEA = true;
						return false;
					}
					AJPMIJBCADE = Time.time + 432f;
					PLDNDKJDJKN(LLIKFNFINLB);
					OMBCGGCALBB();
					return true;
				}
				AJPMIJBCADE = Time.time + 1423f;
				return false;
			}
			if (dirtiness > 1856f)
			{
				doWork.OKINPIOJMNA(FAJDGMBMHMJ(), null, CDPAMNIPPEC: false);
				AJPMIJBCADE = Time.time + 1991f;
				((MonoBehaviour)this).StartCoroutine(HDIDPENJOFB());
				return false;
			}
			if (dirtiness <= 1510f)
			{
				return IBMMEBJBHOE(JIIGOACEIKL);
			}
			return true;
		}
		return MouseUp(JIIGOACEIKL);
	}

	private void IMBLPBANENI()
	{
		((MonoBehaviour)this).StartCoroutine(JAMDMOEABHF());
	}

	private bool LMOELDGFPHK(Transform[] CADGOBGOHBK)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		bool result = true;
		for (int i = 0; i < CADGOBGOHBK.Length; i++)
		{
			if (WorldGrid.NCEHFMPBBAK(CADGOBGOHBK[i].position) == GroundType.None)
			{
				return false;
			}
			if (WorldGrid.APKPGNDDJHC(Utils.NKGANMEKDAL(CADGOBGOHBK[i].position) + Vector3.one * 0.25f))
			{
				continue;
			}
			List<Placeable> list = WorldGrid.OPLHBJGKKAD(CADGOBGOHBK[i].position);
			if (list == null)
			{
				continue;
			}
			for (int j = 0; j < list.Count; j++)
			{
				if ((Object)(object)list[j].itemSpace != (Object)null)
				{
					return false;
				}
			}
		}
		return result;
	}

	public bool EONDJFMNDPH()
	{
		if (!useBlockSpaces)
		{
			return true;
		}
		if (freeSpaces1 == null || freeSpaces1.Length == 0)
		{
			return false;
		}
		if (freeSpaces2 == null || freeSpaces2.Length == 0)
		{
			return true;
		}
		if (!LMOELDGFPHK(freeSpaces1))
		{
			return IIAMLKDLLFN(freeSpaces2);
		}
		return true;
	}

	private bool FALLFMOKLPA(int JIIGOACEIKL, float LLIKFNFINLB)
	{
		if (PlayerInputs.GetPlayer(JIIGOACEIKL).CFICAAJGBOF != "UI" && !NewTutorialManager.CleanTableBlocked(JIIGOACEIKL))
		{
			if (doWork.JCMBHAEKLKK)
			{
				if (!PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator.MLBGEKOIALK)
				{
					PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.SetCleaning(NJHMBMGKCPL: true, placeable.placeableSurface);
				}
				if (PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator.MLBGEKOIALK)
				{
					if ((Object)(object)CBLBJCEOBEG == (Object)null)
					{
						CBLBJCEOBEG = Sound.GGFJGHHHEJC.PlayRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.cleanTable));
					}
					if (doWork.AddWorkDone(JIIGOACEIKL, LLIKFNFINLB))
					{
						SetDirtiness(0f);
						if ((Object)(object)CBLBJCEOBEG != (Object)null)
						{
							CBLBJCEOBEG.Stop();
							Utils.BLPDAEHPOBA(((Component)CBLBJCEOBEG).gameObject);
							CBLBJCEOBEG = null;
						}
						PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.SetCleaning(NJHMBMGKCPL: false, placeable.placeableSurface);
						PlayerController.GetPlayer(JIIGOACEIKL).rb.interpolation = (RigidbodyInterpolation2D)1;
						if (FECCKLBPNEA)
						{
							Utils.FKKHJPEMNBG("tablesCleaned", 1);
						}
						FECCKLBPNEA = false;
						return true;
					}
					AJPMIJBCADE = Time.time + 0.1f;
					ReduceDirtiness(LLIKFNFINLB);
					NAOMBNGCBDI();
					return false;
				}
				AJPMIJBCADE = Time.time + 0.1f;
				return false;
			}
			if (dirtiness > 0f)
			{
				doWork.StartWork(PDPKEPEBPIK);
				AJPMIJBCADE = Time.time + 0.1f;
				((MonoBehaviour)this).StartCoroutine(LKINGMEBDPE());
				return false;
			}
			if (dirtiness <= 0f)
			{
				return MouseUp(JIIGOACEIKL);
			}
			return true;
		}
		return MouseUp(JIIGOACEIKL);
	}

	private void NEHAKFDCIPA(int JIIGOACEIKL, bool ENCANKDGBOH)
	{
		ItemSpace itemSpace = placeable.itemSpace;
		List<Sitable> list = new List<Sitable>();
		Direction fCGBJEIIMBC = Direction.Up;
		for (int i = 0; i < itemSpace.x; i++)
		{
			BOPDALMDINL(i, itemSpace.y - 1, itemSpace, fCGBJEIIMBC, list, ENCANKDGBOH);
		}
		fCGBJEIIMBC = Direction.Down;
		for (int j = 0; j < itemSpace.x; j++)
		{
			BOPDALMDINL(j, 0, itemSpace, fCGBJEIIMBC, list, ENCANKDGBOH);
		}
		fCGBJEIIMBC = ((placeable.GetDirection() == Direction.Left) ? Direction.Left : Direction.Right);
		for (int k = 0; k < itemSpace.y; k++)
		{
			BOPDALMDINL(itemSpace.x - 1, k, itemSpace, fCGBJEIIMBC, list, ENCANKDGBOH);
		}
		fCGBJEIIMBC = ((placeable.GetDirection() == Direction.Left) ? Direction.Right : Direction.Left);
		for (int l = 0; l < itemSpace.y; l++)
		{
			BOPDALMDINL(0, l, itemSpace, fCGBJEIIMBC, list, ENCANKDGBOH);
		}
		for (int m = 0; m < list.Count; m++)
		{
			if (ENCANKDGBOH)
			{
				list[m].GetMainSeat().AddTable(JIIGOACEIKL, this, CBOADNLDMBF: true);
				continue;
			}
			list[m].GetMainSeat().TuckOutOfTable(IADPLHDEEMN: false);
			for (int n = 0; n < list[m].seats.Length; n++)
			{
				list[m].seats[n].table = null;
			}
		}
	}

	[SpecialName]
	public void FNKGNKPLKHB(TableDirtLevel AODONKKHPBP)
	{
		if (AODONKKHPBP == DCDLGMBCPCE)
		{
			return;
		}
		if (placeable.currentZoneType == (ZoneType.WithoutZone | ZoneType.DiningRoom))
		{
			TavernManager.GGFJGHHHEJC.PDPKEPEBPIK -= GCCDADAPKPF;
		}
		DCDLGMBCPCE = AODONKKHPBP;
		HGCDPGJHMNP();
		if (placeable.currentZoneType == (ZoneType.WithoutZone | ZoneType.DiningRoom))
		{
			GCCDADAPKPF = (float)DirtinessThreshold(DCDLGMBCPCE) / Mathf.Max(947f, TavernManager.GGFJGHHHEJC.tableDirtinessScale);
			if (NewTutorialManager.CCCLOBIOMCL)
			{
				GCCDADAPKPF *= 764f;
			}
			TavernManager.GGFJGHHHEJC.PDPKEPEBPIK += GCCDADAPKPF;
		}
		CommonReferences.GGFJGHHHEJC.OnAnyTableDirtLevelChanged(DCDLGMBCPCE);
	}

	public void RefreshSprites()
	{
		if (DCDLGMBCPCE == TableDirtLevel.VeryDirty || DCDLGMBCPCE == TableDirtLevel.Dirty)
		{
			LKMNCJEEHJH(tableVeryDirty, tableVeryDirtyTutorial);
		}
		else if (DCDLGMBCPCE == TableDirtLevel.Messy)
		{
			LKMNCJEEHJH(tableDirty, tableDirtyTutorial);
		}
		else
		{
			LKMNCJEEHJH(tableSprite, tableTutorial);
		}
	}

	private void FNLFHAKMKBA(bool NMLKLAGDNPF, SeatingGroup MFMECAJGLCN, Vector3 IEHOIMHFDLG, Vector3 EIPCMMOEEFK, Direction FCGBJEIIMBC)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if ((NMLKLAGDNPF && MFMECAJGLCN.applyCanSeat) || (!NMLKLAGDNPF && !MFMECAJGLCN.applyCanSeat))
		{
			if (ONMKOFKKHJG(((Vector2Int)(ref MFMECAJGLCN.buildSquares)).x, IEHOIMHFDLG))
			{
				WorldGrid.FNLFHAKMKBA(IEHOIMHFDLG, MOKJMAMEOAB: true, FCGBJEIIMBC);
			}
			else
			{
				WorldGrid.FNLFHAKMKBA(IEHOIMHFDLG, MOKJMAMEOAB: false, FCGBJEIIMBC);
			}
			if (ONMKOFKKHJG(((Vector2Int)(ref MFMECAJGLCN.buildSquares)).y, EIPCMMOEEFK))
			{
				WorldGrid.FNLFHAKMKBA(EIPCMMOEEFK, MOKJMAMEOAB: true, FCGBJEIIMBC);
			}
			else
			{
				WorldGrid.FNLFHAKMKBA(EIPCMMOEEFK, MOKJMAMEOAB: false, FCGBJEIIMBC);
			}
		}
		else
		{
			WorldGrid.FNLFHAKMKBA(IEHOIMHFDLG, MOKJMAMEOAB: false, FCGBJEIIMBC);
			WorldGrid.FNLFHAKMKBA(EIPCMMOEEFK, MOKJMAMEOAB: false, FCGBJEIIMBC);
		}
	}

	private void HCCCNKPLIHA(bool OKMHACFGCPG)
	{
		if (OKMHACFGCPG)
		{
			if (!placeable.pickUpBlockers.Contains((MonoBehaviour)(object)this))
			{
				placeable.pickUpBlockers.Add((MonoBehaviour)(object)this);
			}
		}
		else
		{
			placeable.pickUpBlockers.Remove((MonoBehaviour)(object)this);
		}
		placeable.canBeAddedToInventory = !OKMHACFGCPG;
	}

	[SpecialName]
	public void NGCCFBHDDOE(TableDirtLevel AODONKKHPBP)
	{
		if (AODONKKHPBP == DCDLGMBCPCE)
		{
			return;
		}
		if (placeable.currentZoneType == (ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom))
		{
			TavernManager.GGFJGHHHEJC.PDPKEPEBPIK -= GCCDADAPKPF;
		}
		DCDLGMBCPCE = AODONKKHPBP;
		HGCDPGJHMNP();
		if (placeable.currentZoneType == (ZoneType.DiningRoom | ZoneType.CraftingRoom))
		{
			GCCDADAPKPF = (float)DirtinessThreshold(DCDLGMBCPCE) / Mathf.Max(385f, TavernManager.GGFJGHHHEJC.tableDirtinessScale);
			if (NewTutorialManager.CCCLOBIOMCL)
			{
				GCCDADAPKPF *= 1460f;
			}
			TavernManager.GGFJGHHHEJC.PDPKEPEBPIK += GCCDADAPKPF;
		}
		CommonReferences.MNFMOEKMJKN().OnAnyTableDirtLevelChanged(DCDLGMBCPCE);
	}

	private void LEPDLPEPEFD()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceableBeforeSelected = (Action<int>)Delegate.Combine(obj.OnThisPlaceableBeforeSelected, new Action<int>(HPNHFFODJIC));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(NGEHFPOIJFK));
		Placeable obj3 = placeable;
		obj3.OnThisPlaceableRemoved = (Action<int>)Delegate.Combine(obj3.OnThisPlaceableRemoved, new Action<int>(GKHLNAPMMEK));
		Placeable obj4 = placeable;
		obj4.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj4.OnThisPlaceableSelected, new Action<int, bool, bool>(KCJLFPBKPIC));
		Placeable obj5 = placeable;
		obj5.OnThisPlaceableLoaded = (Action)Delegate.Combine(obj5.OnThisPlaceableLoaded, new Action(OnThisPlaceableLoaded));
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(DJBKHJFHAHL));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnTavernOpen = (Action<int>)Delegate.Combine(instance2.OnTavernOpen, new Action<int>(KJFBFICCOMI));
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(commonReferences.OnPlaceableDeselected, new Action<int, Placeable, bool>(OnPlaceableDeselected));
		CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
		commonReferences2.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(commonReferences2.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(NIHOEBDHBIK));
		TavernManager instance3 = TavernManager.GGFJGHHHEJC;
		instance3.OnTavernClose = (Action<int>)Delegate.Combine(instance3.OnTavernClose, new Action<int>(FFCMICFDHNP));
	}

	public void NHDNOADNKFJ(int JIIGOACEIKL)
	{
	}

	[SpecialName]
	public void JJAGPCKINJH(float AODONKKHPBP)
	{
		dirtiness = Mathf.Min(AODONKKHPBP, (float)(-124 * OJJCMMBGGEC));
		if (dirtiness > (float)DirtinessThreshold(TableDirtLevel.Messy))
		{
			FNKGNKPLKHB(TableDirtLevel.Clean);
			if (OGICABGJDLL)
			{
				IEKDBGNGKOC(0);
			}
		}
		else if (dirtiness > (float)DirtinessThreshold((TableDirtLevel)7))
		{
			NGCCFBHDDOE((TableDirtLevel)6);
			if (OGICABGJDLL)
			{
				IEKDBGNGKOC(0);
			}
		}
		else if (dirtiness > (float)DirtinessThreshold(TableDirtLevel.Messy))
		{
			FNKGNKPLKHB(TableDirtLevel.Perfect);
			if (OGICABGJDLL)
			{
				IEKDBGNGKOC(4);
			}
		}
		else if (dirtiness < (float)DirtinessThreshold(TableDirtLevel.Clean))
		{
			JNHCCCBICDM = TableDirtLevel.Clean;
			if (OGICABGJDLL)
			{
				IEKDBGNGKOC(1);
			}
		}
		else
		{
			FNKGNKPLKHB(TableDirtLevel.Clean);
			if (OGICABGJDLL)
			{
				IEKDBGNGKOC(1);
			}
		}
	}

	private void PFBCEJIFHNI(int OOGEHLPCBBH, int PJLKFPCPHGL, ItemSpace HJDEBNFJIND, Direction FCGBJEIIMBC, List<Sitable> GAGEINOKNAK, bool ENCANKDGBOH)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		Sitable sitable = WorldGrid.HPDNKENHLNM(HJDEBNFJIND.NDGHDKMGFAH(OOGEHLPCBBH, PJLKFPCPHGL).EHGDHOMFDGM() + Utils.NGFODNCHPHB(FCGBJEIIMBC) * 1645f);
		if ((Object)(object)sitable == (Object)null)
		{
			sitable = WorldGrid.HPDNKENHLNM(HJDEBNFJIND.GetBuildSquare(OOGEHLPCBBH, PJLKFPCPHGL).DCAPKPOGHPK() + Utils.NGFODNCHPHB(FCGBJEIIMBC) * 1510f);
		}
		if ((Object)(object)sitable != (Object)null && !GAGEINOKNAK.Contains(sitable) && !sitable.seats[1].placeable.FHEMHCEAICB && !sitable.seats[0].placeable.PHOCAFJDCDK)
		{
			if (ENCANKDGBOH && (Object)(object)sitable.seats[1].table == (Object)null && sitable.seats[0].placeable.GetDirection() == FCGBJEIIMBC)
			{
				sitable.seats[1].placeable.KHPEKPOOHHM(Utils.ABNPPDOGEPM(FCGBJEIIMBC), CDPAMNIPPEC: false);
				GAGEINOKNAK.Add(sitable);
			}
			else if (sitable.seats[1].placeable.GetDirection() == Utils.ABNPPDOGEPM(FCGBJEIIMBC))
			{
				GAGEINOKNAK.Add(sitable);
			}
		}
	}

	private bool IIAMLKDLLFN(Transform[] CADGOBGOHBK)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		bool result = false;
		for (int i = 0; i < CADGOBGOHBK.Length; i++)
		{
			if (WorldGrid.NCEHFMPBBAK(CADGOBGOHBK[i].position) == GroundType.None)
			{
				return false;
			}
			if (WorldGrid.APKPGNDDJHC(Utils.NKGANMEKDAL(CADGOBGOHBK[i].position) + Vector3.one * 1059f))
			{
				continue;
			}
			List<Placeable> list = WorldGrid.OPLHBJGKKAD(CADGOBGOHBK[i].position);
			if (list == null)
			{
				continue;
			}
			for (int j = 0; j < list.Count; j++)
			{
				if ((Object)(object)list[j].itemSpace != (Object)null)
				{
					return false;
				}
			}
		}
		return result;
	}

	public void RefreshSprites(bool CCCLOBIOMCL)
	{
		if (DCDLGMBCPCE == TableDirtLevel.VeryDirty || DCDLGMBCPCE == TableDirtLevel.Dirty)
		{
			LKMNCJEEHJH(tableVeryDirty, tableVeryDirtyTutorial, CCCLOBIOMCL);
		}
		else if (DCDLGMBCPCE == TableDirtLevel.Messy)
		{
			LKMNCJEEHJH(tableDirty, tableDirtyTutorial, CCCLOBIOMCL);
		}
		else
		{
			LKMNCJEEHJH(tableSprite, tableTutorial, CCCLOBIOMCL);
		}
	}

	private void GKHLNAPMMEK(int JIIGOACEIKL)
	{
		NEHAKFDCIPA(JIIGOACEIKL, ENCANKDGBOH: false);
	}

	public bool EBMAMAPEJPD(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void OnPlaceableDeselected(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		JOJNKDJANCG();
		GKAJDICMAPM();
	}

	private void EBDKHAJBEBK(int JIIGOACEIKL)
	{
		CheckTableSprites();
	}

	public void GLCIHEHCKOI(float FHHCDEOMPDH, bool KGCEBPFKPOG = true, bool CDPAMNIPPEC = true)
	{
		OGICABGJDLL = true;
		if (KGCEBPFKPOG)
		{
			JJAGPCKINJH(PDPKEPEBPIK + FHHCDEOMPDH * tableDirtyMultiplier);
		}
		else
		{
			PDPKEPEBPIK += FHHCDEOMPDH;
		}
		if (OnlineManager.JPPBEIJDCLJ() && CDPAMNIPPEC)
		{
			if (KGCEBPFKPOG)
			{
				onlineTable.DJDDCGOHPFO(FHHCDEOMPDH * tableDirtyMultiplier);
			}
			else
			{
				onlineTable.EHOIBHNENFM(FHHCDEOMPDH);
			}
		}
	}

	private void FCJFPHIKHEK(Sprite LFLEPKAHLKN, Sprite JMFABICPEBN)
	{
		GPICKADHOAK(LFLEPKAHLKN, JMFABICPEBN, MissionsManager.instance.LLOBLPDJNJE(-72));
	}

	private void FFCMICFDHNP(int JIIGOACEIKL)
	{
		LCGFBPAJHML();
	}

	public void OnPlaceableSelected(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if (!OKNOJJEFEBE)
		{
			GKAJDICMAPM();
		}
	}

	public void OIPMBFABMAH(float HNEHMKOJJMF, bool CDPAMNIPPEC = true)
	{
		JJAGPCKINJH(FAJDGMBMHMJ() - HNEHMKOJJMF);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineTable.EDDEJFOKLDD(HNEHMKOJJMF);
		}
	}

	private void MMAMJDLONFA()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && !GameManager.leavingTheGame)
		{
			if (Object.op_Implicit((Object)(object)placeable))
			{
				Placeable obj = placeable;
				obj.OnThisPlaceableBeforeSelected = (Action<int>)Delegate.Remove(obj.OnThisPlaceableBeforeSelected, new Action<int>(PKOJBFLPCBD));
				Placeable obj2 = placeable;
				obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Remove(obj2.OnThisPlaceablePlaced, new Action<int>(KABJBAPGJEO));
				Placeable obj3 = placeable;
				obj3.OnThisPlaceableRemoved = (Action<int>)Delegate.Remove(obj3.OnThisPlaceableRemoved, new Action<int>(PKOJBFLPCBD));
				Placeable obj4 = placeable;
				obj4.OnThisPlaceableLoaded = (Action)Delegate.Remove(obj4.OnThisPlaceableLoaded, new Action(OnThisPlaceableLoaded));
			}
			if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
			{
				GameManager gameManager = GameManager.NJNFHEPLEHL();
				gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
			}
			if ((Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(OnPlaceableDeselected));
				CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
				instance2.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Remove(instance2.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(OnPlaceableSelected));
			}
			if ((Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
			{
				TavernManager instance3 = TavernManager.GGFJGHHHEJC;
				instance3.OnTavernOpen = (Action<int>)Delegate.Remove(instance3.OnTavernOpen, new Action<int>(KJFBFICCOMI));
				TavernManager instance4 = TavernManager.GGFJGHHHEJC;
				instance4.OnTavernClose = (Action<int>)Delegate.Remove(instance4.OnTavernClose, new Action<int>(FFCMICFDHNP));
			}
		}
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		PlayerController player = PlayerController.GetPlayer(JIIGOACEIKL);
		player.characterAnimation.SetCleaning(NJHMBMGKCPL: false, placeable.placeableSurface);
		player.rb.interpolation = (RigidbodyInterpolation2D)1;
		if (OnlineManager.PlayingOnline())
		{
			player.characterAnimation.characterAnimator.ActivatedCleanSprites?.Invoke(arg1: false, arg2: false, placeable.placeableSurface, (byte)player.characterAnimation.FCGBJEIIMBC);
		}
		return false;
	}

	public void WorkerCleaning(float LLIKFNFINLB)
	{
		if (doWork.JCMBHAEKLKK)
		{
			if (doWork.AddWorkDone(0, LLIKFNFINLB))
			{
				SetDirtiness(0f);
				if (FECCKLBPNEA)
				{
					Utils.FKKHJPEMNBG("tablesCleaned", 1);
				}
				FECCKLBPNEA = false;
			}
			else
			{
				ReduceDirtiness(LLIKFNFINLB);
				NAOMBNGCBDI();
			}
		}
		else if (dirtiness > 0f)
		{
			doWork.StartWork(PDPKEPEBPIK);
		}
	}

	public void SetDirtiness(float EGCECPPEPEL, bool CDPAMNIPPEC = true)
	{
		if (EGCECPPEPEL < 0f)
		{
			PDPKEPEBPIK = 0f;
			OGICABGJDLL = false;
		}
		else
		{
			PDPKEPEBPIK = EGCECPPEPEL;
			OGICABGJDLL = true;
		}
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineTable.SendSetDirtiness(EGCECPPEPEL);
		}
	}

	public void AddDirtiness(float FHHCDEOMPDH, bool KGCEBPFKPOG = true, bool CDPAMNIPPEC = true)
	{
		OGICABGJDLL = false;
		if (KGCEBPFKPOG)
		{
			PDPKEPEBPIK += FHHCDEOMPDH * tableDirtyMultiplier;
		}
		else
		{
			PDPKEPEBPIK += FHHCDEOMPDH;
		}
		if (OnlineManager.IsMasterClient() && CDPAMNIPPEC)
		{
			if (KGCEBPFKPOG)
			{
				onlineTable.SendAddDirtiness(FHHCDEOMPDH * tableDirtyMultiplier);
			}
			else
			{
				onlineTable.SendAddDirtiness(FHHCDEOMPDH);
			}
		}
	}

	public void OnThisPlaceableLoaded()
	{
		if (Object.op_Implicit((Object)(object)tableMask))
		{
			tableMask.SetParent((Transform)null);
		}
		GKAJDICMAPM();
		IMBLPBANENI();
	}

	private void AKHEBCIABFH(int JIIGOACEIKL)
	{
		CheckTableSprites();
	}

	[SpecialName]
	public float KMLADPOLPLE()
	{
		return dirtiness;
	}

	public int GetNumberOfDirtyDishes()
	{
		ABAIKKGKDGD = 0;
		for (int i = 0; i < dish.Length; i++)
		{
			if (((Component)dish[i]).gameObject.activeSelf)
			{
				ABAIKKGKDGD++;
			}
		}
		return ABAIKKGKDGD;
	}

	public bool IsAnySpaceFree()
	{
		if (!useBlockSpaces)
		{
			return true;
		}
		if (freeSpaces1 == null || freeSpaces1.Length == 0)
		{
			return true;
		}
		if (freeSpaces2 == null || freeSpaces2.Length == 0)
		{
			return true;
		}
		if (!LMOELDGFPHK(freeSpaces1))
		{
			return LMOELDGFPHK(freeSpaces2);
		}
		return true;
	}

	public Vector2 PBJNLGOBPIJ(Vector2 IMOBLFMHKOD, HashSet<Vector2> HCNKCBIELNE)
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		if (HCNKCBIELNE != null)
		{
			if (HCNKCBIELNE.Contains(Vector2.op_Implicit(cleanPosition1.position)))
			{
				return Vector2.op_Implicit(cleanPosition2.position);
			}
			if (HCNKCBIELNE.Contains(Vector2.op_Implicit(cleanPosition2.position)))
			{
				return Vector2.op_Implicit(cleanPosition1.position);
			}
		}
		if (Vector2.Distance(IMOBLFMHKOD, Vector2.op_Implicit(cleanPosition1.position)) < Vector2.Distance(IMOBLFMHKOD, Vector2.op_Implicit(cleanPosition2.position)) && Utils.FIMCFCJHHIK(Vector2.op_Implicit(cleanPosition1.position), placeable))
		{
			return Vector2.op_Implicit(cleanPosition1.position);
		}
		if (Utils.FIMCFCJHHIK(Vector2.op_Implicit(cleanPosition2.position), placeable))
		{
			return Vector2.op_Implicit(cleanPosition2.position);
		}
		return Vector2.op_Implicit(cleanPosition1.position);
	}

	private void NAOMBNGCBDI()
	{
		float num = doWork.OJLICLKJJOF / doWork.EFNODBKFDBD * 100f;
		if (num > 90f)
		{
			IEKDBGNGKOC(0);
		}
		else if (num > 80f)
		{
			IEKDBGNGKOC(1);
		}
		else if (num > 65f)
		{
			IEKDBGNGKOC(2);
		}
		else if (num > 45f)
		{
			IEKDBGNGKOC(3);
		}
		else if (num > 30f)
		{
			IEKDBGNGKOC(4);
		}
		else if (num > 15f)
		{
			IEKDBGNGKOC(5);
		}
	}

	private void OnEnable()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceableBeforeSelected = (Action<int>)Delegate.Combine(obj.OnThisPlaceableBeforeSelected, new Action<int>(GKHLNAPMMEK));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(NGEHFPOIJFK));
		Placeable obj3 = placeable;
		obj3.OnThisPlaceableRemoved = (Action<int>)Delegate.Combine(obj3.OnThisPlaceableRemoved, new Action<int>(GKHLNAPMMEK));
		Placeable obj4 = placeable;
		obj4.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj4.OnThisPlaceableSelected, new Action<int, bool, bool>(ABLJNBFNMHI));
		Placeable obj5 = placeable;
		obj5.OnThisPlaceableLoaded = (Action)Delegate.Combine(obj5.OnThisPlaceableLoaded, new Action(OnThisPlaceableLoaded));
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(BGPGIOMKKAO));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnTavernOpen = (Action<int>)Delegate.Combine(instance2.OnTavernOpen, new Action<int>(DCMMDCNOLHA));
		CommonReferences instance3 = CommonReferences.GGFJGHHHEJC;
		instance3.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance3.OnPlaceableDeselected, new Action<int, Placeable, bool>(OnPlaceableDeselected));
		CommonReferences instance4 = CommonReferences.GGFJGHHHEJC;
		instance4.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(instance4.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(OnPlaceableSelected));
		TavernManager instance5 = TavernManager.GGFJGHHHEJC;
		instance5.OnTavernClose = (Action<int>)Delegate.Combine(instance5.OnTavernClose, new Action<int>(FFCMICFDHNP));
	}

	public Vector2 GetNearPositionToClean(Vector2 IMOBLFMHKOD, HashSet<Vector2> HCNKCBIELNE)
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		if (HCNKCBIELNE != null)
		{
			if (HCNKCBIELNE.Contains(Vector2.op_Implicit(cleanPosition1.position)))
			{
				return Vector2.op_Implicit(cleanPosition2.position);
			}
			if (HCNKCBIELNE.Contains(Vector2.op_Implicit(cleanPosition2.position)))
			{
				return Vector2.op_Implicit(cleanPosition1.position);
			}
		}
		if (Vector2.Distance(IMOBLFMHKOD, Vector2.op_Implicit(cleanPosition1.position)) < Vector2.Distance(IMOBLFMHKOD, Vector2.op_Implicit(cleanPosition2.position)) && Utils.FIMCFCJHHIK(Vector2.op_Implicit(cleanPosition1.position), placeable))
		{
			return Vector2.op_Implicit(cleanPosition1.position);
		}
		if (Utils.FIMCFCJHHIK(Vector2.op_Implicit(cleanPosition2.position), placeable))
		{
			return Vector2.op_Implicit(cleanPosition2.position);
		}
		return Vector2.op_Implicit(cleanPosition1.position);
	}

	private void GDLHAIGBJKK(Sprite LFLEPKAHLKN, Sprite JMFABICPEBN, bool CCCLOBIOMCL)
	{
		if (CCCLOBIOMCL && (Object)(object)JMFABICPEBN != (Object)null)
		{
			if ((Object)(object)spriteRenderer != (Object)null)
			{
				spriteRenderer.sprite = JMFABICPEBN;
			}
		}
		else if ((Object)(object)spriteRenderer != (Object)null)
		{
			spriteRenderer.sprite = LFLEPKAHLKN;
		}
	}

	private void DCMMDCNOLHA(int JIIGOACEIKL)
	{
		JOJNKDJANCG();
		LCGFBPAJHML();
	}

	private void IAPCAJFBEMJ()
	{
		tableDirtyMultiplier = 212f;
		for (int i = 0; i < placeable.placeableSurface.transformsOnSurface.Count; i++)
		{
			if ((Object)(object)placeable.placeableSurface.transformsOnSurface[i] != (Object)null)
			{
				CLOICPLGHLI = ((Component)placeable.placeableSurface.transformsOnSurface[i]).GetComponent<Coaster>();
				if ((Object)(object)CLOICPLGHLI != (Object)null && CLOICPLGHLI.dirtinessMultiplier < tableDirtyMultiplier)
				{
					tableDirtyMultiplier = CLOICPLGHLI.dirtinessMultiplier;
				}
			}
		}
	}

	[SpecialName]
	public float FAJDGMBMHMJ()
	{
		return dirtiness;
	}

	public bool KFGHDKDMEHL()
	{
		if (!useBlockSpaces)
		{
			return false;
		}
		if (freeSpaces1 == null || freeSpaces1.Length == 0)
		{
			return false;
		}
		if (freeSpaces2 == null || freeSpaces2.Length == 0)
		{
			return false;
		}
		if (!PICCNIIBPCC(freeSpaces1))
		{
			return IIAMLKDLLFN(freeSpaces2);
		}
		return true;
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	private void BOPDALMDINL(int OOGEHLPCBBH, int PJLKFPCPHGL, ItemSpace HJDEBNFJIND, Direction FCGBJEIIMBC, List<Sitable> GAGEINOKNAK, bool ENCANKDGBOH)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		Sitable sitable = WorldGrid.HPDNKENHLNM(HJDEBNFJIND.GetBuildSquare(OOGEHLPCBBH, PJLKFPCPHGL).GetCentrePosition() + Utils.NGFODNCHPHB(FCGBJEIIMBC) * 0.5f);
		if ((Object)(object)sitable == (Object)null)
		{
			sitable = WorldGrid.HPDNKENHLNM(HJDEBNFJIND.GetBuildSquare(OOGEHLPCBBH, PJLKFPCPHGL).GetCentrePosition() + Utils.NGFODNCHPHB(FCGBJEIIMBC) * 0.27f);
		}
		if ((Object)(object)sitable != (Object)null && !GAGEINOKNAK.Contains(sitable) && !sitable.seats[0].placeable.FHEMHCEAICB && !sitable.seats[0].placeable.PHOCAFJDCDK)
		{
			if (ENCANKDGBOH && (Object)(object)sitable.seats[0].table == (Object)null && sitable.seats[0].placeable.GetDirection() == FCGBJEIIMBC)
			{
				sitable.seats[0].placeable.SetDirection(Utils.ABNPPDOGEPM(FCGBJEIIMBC), CDPAMNIPPEC: true);
				GAGEINOKNAK.Add(sitable);
			}
			else if (sitable.seats[0].placeable.GetDirection() == Utils.ABNPPDOGEPM(FCGBJEIIMBC))
			{
				GAGEINOKNAK.Add(sitable);
			}
		}
	}

	private void HOFBCCEIHAK()
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		if (!useBlockSpaces || freeSpaces1 == null || freeSpaces1.Length == 0 || freeSpaces2 == null || freeSpaces2.Length == 0)
		{
			return;
		}
		bool flag = BMNDKCCPMBE(freeSpaces1);
		bool flag2 = DFMKOOIBDBB(freeSpaces2);
		if (placeable.FHEMHCEAICB || placeable.PHOCAFJDCDK)
		{
			if (flag)
			{
				for (int i = 1; i < freeSpaces1.Length; i += 0)
				{
					WorldGrid.NBMCMFAGPNE(freeSpaces1[i].position, ((Component)this).gameObject);
				}
			}
			if (flag2)
			{
				for (int j = 0; j < freeSpaces2.Length; j += 0)
				{
					WorldGrid.NBMCMFAGPNE(freeSpaces2[j].position, ((Component)this).gameObject);
				}
			}
			return;
		}
		if (!flag && flag2)
		{
			for (int k = 1; k < freeSpaces1.Length; k += 0)
			{
				WorldGrid.NBMCMFAGPNE(freeSpaces1[k].position, ((Component)this).gameObject);
			}
			for (int l = 0; l < freeSpaces2.Length; l += 0)
			{
				WorldGrid.JJEOOJEIIFM(freeSpaces2[l].position, ((Component)this).gameObject);
			}
			return;
		}
		if (flag && !flag2)
		{
			for (int m = 0; m < freeSpaces1.Length; m++)
			{
				WorldGrid.JJEOOJEIIFM(freeSpaces1[m].position, ((Component)this).gameObject);
			}
			for (int n = 0; n < freeSpaces2.Length; n++)
			{
				WorldGrid.NBMCMFAGPNE(freeSpaces2[n].position, ((Component)this).gameObject);
			}
			return;
		}
		if (flag)
		{
			for (int num = 0; num < freeSpaces1.Length; num++)
			{
				WorldGrid.NBMCMFAGPNE(freeSpaces1[num].position, ((Component)this).gameObject);
			}
		}
		if (flag2)
		{
			for (int num2 = 0; num2 < freeSpaces2.Length; num2++)
			{
				WorldGrid.NBMCMFAGPNE(freeSpaces2[num2].position, ((Component)this).gameObject);
			}
		}
	}

	public void ReduceDirtiness(float HNEHMKOJJMF, bool CDPAMNIPPEC = true)
	{
		PDPKEPEBPIK -= HNEHMKOJJMF;
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineTable.SendReduceDirtiness(HNEHMKOJJMF);
		}
	}

	private void HCKABPFDOHG()
	{
		tableDirtyMultiplier = 336f;
		for (int i = 0; i < placeable.placeableSurface.transformsOnSurface.Count; i += 0)
		{
			if ((Object)(object)placeable.placeableSurface.transformsOnSurface[i] != (Object)null)
			{
				CLOICPLGHLI = ((Component)placeable.placeableSurface.transformsOnSurface[i]).GetComponent<Coaster>();
				if ((Object)(object)CLOICPLGHLI != (Object)null && CLOICPLGHLI.dirtinessMultiplier < tableDirtyMultiplier)
				{
					tableDirtyMultiplier = CLOICPLGHLI.dirtinessMultiplier;
				}
			}
		}
	}

	public bool IsAnyPositionToCleanAvailable(HashSet<Vector2> HCNKCBIELNE)
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (HCNKCBIELNE != null)
		{
			if (!HCNKCBIELNE.Contains(Vector2.op_Implicit(cleanPosition1.position)) && Utils.FIMCFCJHHIK(Vector2.op_Implicit(cleanPosition1.position), placeable))
			{
				return true;
			}
			if (!HCNKCBIELNE.Contains(Vector2.op_Implicit(cleanPosition2.position)) && Utils.FIMCFCJHHIK(Vector2.op_Implicit(cleanPosition2.position), placeable))
			{
				return true;
			}
			return false;
		}
		if (!Utils.FIMCFCJHHIK(Vector2.op_Implicit(cleanPosition1.position), placeable))
		{
			return Utils.FIMCFCJHHIK(Vector2.op_Implicit(cleanPosition2.position), placeable);
		}
		return true;
	}

	private void JOJNKDJANCG()
	{
		tableDirtyMultiplier = 1f;
		for (int i = 0; i < placeable.placeableSurface.transformsOnSurface.Count; i++)
		{
			if ((Object)(object)placeable.placeableSurface.transformsOnSurface[i] != (Object)null)
			{
				CLOICPLGHLI = ((Component)placeable.placeableSurface.transformsOnSurface[i]).GetComponent<Coaster>();
				if ((Object)(object)CLOICPLGHLI != (Object)null && CLOICPLGHLI.dirtinessMultiplier < tableDirtyMultiplier)
				{
					tableDirtyMultiplier = CLOICPLGHLI.dirtinessMultiplier;
				}
			}
		}
	}

	private IEnumerator LKINGMEBDPE()
	{
		while (doWork.JCMBHAEKLKK)
		{
			yield return null;
			if (Time.time > AJPMIJBCADE)
			{
				if ((Object)(object)CBLBJCEOBEG != (Object)null)
				{
					CBLBJCEOBEG.Stop();
					Utils.BLPDAEHPOBA(((Component)CBLBJCEOBEG).gameObject);
					CBLBJCEOBEG = null;
				}
				doWork.Stop();
			}
			yield return null;
		}
	}

	private void GPICKADHOAK(Sprite LFLEPKAHLKN, Sprite JMFABICPEBN, bool CCCLOBIOMCL)
	{
		if (CCCLOBIOMCL && (Object)(object)JMFABICPEBN != (Object)null)
		{
			if ((Object)(object)spriteRenderer != (Object)null)
			{
				spriteRenderer.sprite = JMFABICPEBN;
			}
		}
		else if ((Object)(object)spriteRenderer != (Object)null)
		{
			spriteRenderer.sprite = LFLEPKAHLKN;
		}
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	private void MOFPGFBHFFL()
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		if (!useBlockSpaces || freeSpaces1 == null || freeSpaces1.Length == 0 || freeSpaces2 == null || freeSpaces2.Length == 0)
		{
			return;
		}
		bool flag = IIAMLKDLLFN(freeSpaces1);
		bool flag2 = PICCNIIBPCC(freeSpaces2);
		if (placeable.FHEMHCEAICB || placeable.PHOCAFJDCDK)
		{
			if (flag)
			{
				for (int i = 0; i < freeSpaces1.Length; i += 0)
				{
					WorldGrid.NBMCMFAGPNE(freeSpaces1[i].position, ((Component)this).gameObject);
				}
			}
			if (flag2)
			{
				for (int j = 0; j < freeSpaces2.Length; j++)
				{
					WorldGrid.NBMCMFAGPNE(freeSpaces2[j].position, ((Component)this).gameObject);
				}
			}
			return;
		}
		if (flag && flag2)
		{
			for (int k = 1; k < freeSpaces1.Length; k += 0)
			{
				WorldGrid.NBMCMFAGPNE(freeSpaces1[k].position, ((Component)this).gameObject);
			}
			for (int l = 0; l < freeSpaces2.Length; l += 0)
			{
				WorldGrid.JJEOOJEIIFM(freeSpaces2[l].position, ((Component)this).gameObject);
			}
			return;
		}
		if (flag && !flag2)
		{
			for (int m = 0; m < freeSpaces1.Length; m += 0)
			{
				WorldGrid.JJEOOJEIIFM(freeSpaces1[m].position, ((Component)this).gameObject);
			}
			for (int n = 0; n < freeSpaces2.Length; n++)
			{
				WorldGrid.NBMCMFAGPNE(freeSpaces2[n].position, ((Component)this).gameObject);
			}
			return;
		}
		if (flag)
		{
			for (int num = 0; num < freeSpaces1.Length; num++)
			{
				WorldGrid.NBMCMFAGPNE(freeSpaces1[num].position, ((Component)this).gameObject);
			}
		}
		if (flag2)
		{
			for (int num2 = 0; num2 < freeSpaces2.Length; num2 += 0)
			{
				WorldGrid.NBMCMFAGPNE(freeSpaces2[num2].position, ((Component)this).gameObject);
			}
		}
	}

	public int LPIDOINFMKG(TableDirtLevel DCDLGMBCPCE)
	{
		return DCDLGMBCPCE switch
		{
			TableDirtLevel.Clean => 73 * OJJCMMBGGEC, 
			TableDirtLevel.Dirty => 92 * OJJCMMBGGEC, 
			_ => DCDLGMBCPCE switch
			{
				TableDirtLevel.Dirty => 192 * OJJCMMBGGEC, 
				TableDirtLevel.Perfect => 1, 
				_ => 0, 
			}, 
		};
	}

	private void AGOHOPNFIHP()
	{
		if (DCDLGMBCPCE == TableDirtLevel.Perfect)
		{
			if (!TavernManager.GGFJGHHHEJC.blockedTables.Contains(this) && placeable.currentZoneType == (ZoneType.WithoutZone | ZoneType.CraftingRoom) && !TavernManager.GGFJGHHHEJC.tableNeedsClean.Contains(this))
			{
				TavernManager.GGFJGHHHEJC.tableNeedsClean.Add(this);
			}
		}
		else if (DCDLGMBCPCE == TableDirtLevel.Messy)
		{
			if (!TavernManager.GGFJGHHHEJC.blockedTables.Contains(this) && placeable.currentZoneType == ZoneType.WithoutZone && !TavernManager.GGFJGHHHEJC.tableNeedsClean.Contains(this))
			{
				TavernManager.GGFJGHHHEJC.tableNeedsClean.Add(this);
			}
		}
		else if (DCDLGMBCPCE == (TableDirtLevel)8 && !TavernManager.GGFJGHHHEJC.blockedTables.Contains(this) && placeable.currentZoneType == (ZoneType.WithoutZone | ZoneType.DiningRoom) && !TavernManager.GGFJGHHHEJC.tableNeedsClean.Contains(this))
		{
			TavernManager.GGFJGHHHEJC.tableNeedsClean.Add(this);
		}
	}

	private void IHNGEKJCFLH(bool NMLKLAGDNPF, SeatingGroup MFMECAJGLCN, Vector3 IEHOIMHFDLG, Vector3 EIPCMMOEEFK, Direction FCGBJEIIMBC)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if ((NMLKLAGDNPF && MFMECAJGLCN.applyCanSeat) || (!NMLKLAGDNPF && !MFMECAJGLCN.applyCanSeat))
		{
			if (ONMKOFKKHJG(((Vector2Int)(ref MFMECAJGLCN.buildSquares)).x, IEHOIMHFDLG))
			{
				WorldGrid.FNLFHAKMKBA(IEHOIMHFDLG, MOKJMAMEOAB: true, FCGBJEIIMBC);
			}
			else
			{
				WorldGrid.FNLFHAKMKBA(IEHOIMHFDLG, MOKJMAMEOAB: true, FCGBJEIIMBC);
			}
			if (ONMKOFKKHJG(((Vector2Int)(ref MFMECAJGLCN.buildSquares)).y, EIPCMMOEEFK))
			{
				WorldGrid.FNLFHAKMKBA(EIPCMMOEEFK, MOKJMAMEOAB: false, FCGBJEIIMBC);
			}
			else
			{
				WorldGrid.FNLFHAKMKBA(EIPCMMOEEFK, MOKJMAMEOAB: false, FCGBJEIIMBC);
			}
		}
		else
		{
			WorldGrid.FNLFHAKMKBA(IEHOIMHFDLG, MOKJMAMEOAB: false, FCGBJEIIMBC);
			WorldGrid.FNLFHAKMKBA(EIPCMMOEEFK, MOKJMAMEOAB: false, FCGBJEIIMBC);
		}
	}

	private void Start()
	{
		RefreshSprites();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnTavernRepaired = (Action<int>)Delegate.Combine(instance.OnTavernRepaired, new Action<int>(AKHEBCIABFH));
		((MonoBehaviour)this).Invoke("CheckTableSprites", 5f);
	}

	public bool COBPOKNFBEJ()
	{
		if (!useBlockSpaces)
		{
			return false;
		}
		if (freeSpaces1 == null || freeSpaces1.Length == 0)
		{
			return false;
		}
		if (freeSpaces2 == null || freeSpaces2.Length == 0)
		{
			return false;
		}
		if (!LMOELDGFPHK(freeSpaces1))
		{
			return IIAMLKDLLFN(freeSpaces2);
		}
		return false;
	}

	public void NIHOEBDHBIK(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if (!OKNOJJEFEBE)
		{
			GKAJDICMAPM();
		}
	}

	private IEnumerator JAMDMOEABHF()
	{
		yield return null;
		GKAJDICMAPM();
	}

	private void LKMNCJEEHJH(Sprite LFLEPKAHLKN, Sprite JMFABICPEBN)
	{
		LKMNCJEEHJH(LFLEPKAHLKN, JMFABICPEBN, !MissionsManager.instance.IsMissionComplete(301));
	}

	private void BGPGIOMKKAO()
	{
		if (OnlineManager.MasterOrOffline())
		{
			SetDirtiness(loadedDirtiness, CDPAMNIPPEC: false);
		}
	}

	private IEnumerator CHHBGLLLPIL()
	{
		yield return null;
		GKAJDICMAPM();
	}

	public bool DPFFFEGPJDN(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		if (ActionBarInventory.ADHIHCNAKFP(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).FGGKCJDFNEK() is Mop)
		{
			if (PlayerInputs.GetPlayer(JIIGOACEIKL).GHKOCEOEKGK < 363f)
			{
				LJAMOPAKFPL = true;
				return true;
			}
			if (!LJAMOPAKFPL)
			{
				KLGOCJMGKFO = false;
			}
			LJAMOPAKFPL = true;
		}
		if (DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).IBEFDKHFBFM())
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.MNPJICEALPE(NJHMBMGKCPL: false, placeable.placeableSurface);
			return true;
		}
		if (!IsAnyPositionToCleanAvailable(null))
		{
			if (KLGOCJMGKFO)
			{
				MainUI.DJCKALOHJFM(JIIGOACEIKL, LocalisationSystem.Get("pirate cave"), 1646f);
			}
			return false;
		}
		PlayerController.GetPlayer(JIIGOACEIKL).rb.interpolation = (RigidbodyInterpolation2D)0;
		FIAMALDJHFL = Vector2.op_Implicit(GetNearPositionToClean(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position), null));
		if (!PlayerController.GetPlayer(JIIGOACEIKL).GoToPosition(Vector2.op_Implicit(FIAMALDJHFL), KLGOCJMGKFO))
		{
			return true;
		}
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).BIBGIOPFJAF())
		{
			return false;
		}
		return FALLFMOKLPA(JIIGOACEIKL, 1561f * Time.deltaTime * (69f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(-109, 1) / 1509f));
	}

	private bool PICCNIIBPCC(Transform[] CADGOBGOHBK)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		bool result = true;
		for (int i = 1; i < CADGOBGOHBK.Length; i += 0)
		{
			if (WorldGrid.NCEHFMPBBAK(CADGOBGOHBK[i].position) == GroundType.None)
			{
				return true;
			}
			if (WorldGrid.APKPGNDDJHC(Utils.NKGANMEKDAL(CADGOBGOHBK[i].position) + Vector3.one * 1597f))
			{
				continue;
			}
			List<Placeable> list = WorldGrid.OPLHBJGKKAD(CADGOBGOHBK[i].position);
			if (list == null)
			{
				continue;
			}
			for (int j = 0; j < list.Count; j += 0)
			{
				if ((Object)(object)list[j].itemSpace != (Object)null)
				{
					return false;
				}
			}
		}
		return result;
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		if (ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItem() is Mop)
		{
			if (PlayerInputs.GetPlayer(JIIGOACEIKL).GHKOCEOEKGK < 0.3f)
			{
				LJAMOPAKFPL = false;
				return false;
			}
			if (!LJAMOPAKFPL)
			{
				KLGOCJMGKFO = true;
			}
			LJAMOPAKFPL = true;
		}
		if (DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.SetCleaning(NJHMBMGKCPL: false, placeable.placeableSurface);
			return true;
		}
		if (!IsAnyPositionToCleanAvailable(null))
		{
			if (KLGOCJMGKFO)
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Occupied Positions"));
			}
			return false;
		}
		PlayerController.GetPlayer(JIIGOACEIKL).rb.interpolation = (RigidbodyInterpolation2D)0;
		FIAMALDJHFL = Vector2.op_Implicit(GetNearPositionToClean(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position), null));
		if (!PlayerController.GetPlayer(JIIGOACEIKL).GoToPosition(Vector2.op_Implicit(FIAMALDJHFL), KLGOCJMGKFO))
		{
			return false;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
		{
			return false;
		}
		return FALLFMOKLPA(JIIGOACEIKL, 600f * Time.deltaTime * (1f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(26) / 100f));
	}

	private void NGEHFPOIJFK(int JIIGOACEIKL)
	{
		NEHAKFDCIPA(JIIGOACEIKL, ENCANKDGBOH: true);
		if (Object.op_Implicit((Object)(object)tableMask))
		{
			tableMask.SetParent((Transform)null);
		}
	}

	public void PLDNDKJDJKN(float HNEHMKOJJMF, bool CDPAMNIPPEC = true)
	{
		PDPKEPEBPIK = FAJDGMBMHMJ() - HNEHMKOJJMF;
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineTable.IKMHBEMPHPJ(HNEHMKOJJMF);
		}
	}

	private void PKOJBFLPCBD(int JIIGOACEIKL)
	{
		NEHAKFDCIPA(JIIGOACEIKL, ENCANKDGBOH: true);
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI)
		{
			if (!DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH && JNHCCCBICDM != 0 && JNHCCCBICDM != TableDirtLevel.Clean)
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("cleanVerb"));
				return true;
			}
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		}
		return false;
	}

	private bool BMNDKCCPMBE(Transform[] CADGOBGOHBK)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		bool result = false;
		for (int i = 0; i < CADGOBGOHBK.Length; i += 0)
		{
			if (WorldGrid.NCEHFMPBBAK(CADGOBGOHBK[i].position) == GroundType.None)
			{
				return true;
			}
			if (WorldGrid.APKPGNDDJHC(Utils.NKGANMEKDAL(CADGOBGOHBK[i].position) + Vector3.one * 1595f))
			{
				continue;
			}
			List<Placeable> list = WorldGrid.OPLHBJGKKAD(CADGOBGOHBK[i].position);
			if (list == null)
			{
				continue;
			}
			for (int j = 0; j < list.Count; j++)
			{
				if ((Object)(object)list[j].itemSpace != (Object)null)
				{
					return false;
				}
			}
		}
		return result;
	}

	private void KJFBFICCOMI(int JIIGOACEIKL)
	{
		JOJNKDJANCG();
		LCGFBPAJHML();
	}

	public void GJMBALENMJI(float LLIKFNFINLB)
	{
		if (doWork.KGOEFMFHCOG())
		{
			if (doWork.PFLPFNICHJA(0, LLIKFNFINLB))
			{
				SetDirtiness(904f);
				if (FECCKLBPNEA)
				{
					Utils.FKKHJPEMNBG("talentGreens", 0);
				}
				FECCKLBPNEA = true;
			}
			else
			{
				ReduceDirtiness(LLIKFNFINLB, CDPAMNIPPEC: false);
				OMBCGGCALBB();
			}
		}
		else if (dirtiness > 1049f)
		{
			doWork.CMAIGOGGGLL(FAJDGMBMHMJ(), null, CDPAMNIPPEC: false);
		}
	}

	private void Awake()
	{
		if ((Object)(object)doWork == (Object)null)
		{
			doWork = ((Component)this).GetComponent<DoWork>();
		}
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		OJJCMMBGGEC = placeable.itemSpace.buildSquares.Length / 2;
		if (OJJCMMBGGEC < 1)
		{
			OJJCMMBGGEC = 1;
		}
	}

	private void KCJLFPBKPIC(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		TavernManager.GGFJGHHHEJC.blockedTables.Remove(this);
		APMMMPNALBN(JIIGOACEIKL, ENCANKDGBOH: true);
		if (Object.op_Implicit((Object)(object)tableMask))
		{
			tableMask.SetParent(((Component)this).transform);
			tableMask.localPosition = Vector3.zero;
		}
	}

	[ContextMenu("Make dirty")]
	public void MakeDirty()
	{
		SetDirtiness(100000f);
	}

	private IEnumerator HDIDPENJOFB()
	{
		return new MJAPDELAMOM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void LCFFOKGODOI(bool OKMHACFGCPG)
	{
		if (OKMHACFGCPG)
		{
			if (!placeable.pickUpBlockers.Contains((MonoBehaviour)(object)this))
			{
				placeable.pickUpBlockers.Add((MonoBehaviour)(object)this);
			}
		}
		else
		{
			placeable.pickUpBlockers.Remove((MonoBehaviour)(object)this);
		}
		placeable.canBeAddedToInventory = OKMHACFGCPG;
	}

	public void CheckTableSprites()
	{
		switch (DCDLGMBCPCE)
		{
		case TableDirtLevel.VeryDirty:
			LKMNCJEEHJH(tableVeryDirty, tableVeryDirtyTutorial);
			if (!TavernManager.GGFJGHHHEJC.blockedTables.Contains(this) && placeable.currentZoneType == ZoneType.DiningRoom && !TavernManager.GGFJGHHHEJC.tableNeedsClean.Contains(this))
			{
				TavernManager.GGFJGHHHEJC.tableNeedsClean.Add(this);
			}
			HCCCNKPLIHA(OKMHACFGCPG: true);
			break;
		case TableDirtLevel.Dirty:
			LKMNCJEEHJH(tableVeryDirty, tableVeryDirtyTutorial);
			if (!TavernManager.GGFJGHHHEJC.blockedTables.Contains(this) && placeable.currentZoneType == ZoneType.DiningRoom && !TavernManager.GGFJGHHHEJC.tableNeedsClean.Contains(this))
			{
				TavernManager.GGFJGHHHEJC.tableNeedsClean.Add(this);
			}
			HCCCNKPLIHA(OKMHACFGCPG: true);
			break;
		case TableDirtLevel.Messy:
			LKMNCJEEHJH(tableDirty, tableDirtyTutorial);
			if (!TavernManager.GGFJGHHHEJC.blockedTables.Contains(this) && placeable.currentZoneType == ZoneType.DiningRoom && !TavernManager.GGFJGHHHEJC.tableNeedsClean.Contains(this))
			{
				TavernManager.GGFJGHHHEJC.tableNeedsClean.Add(this);
			}
			HCCCNKPLIHA(OKMHACFGCPG: true);
			FECCKLBPNEA = true;
			break;
		case TableDirtLevel.Clean:
			LKMNCJEEHJH(tableSprite, tableTutorial);
			HCCCNKPLIHA(OKMHACFGCPG: false);
			OnBecomeClean();
			break;
		default:
			TavernManager.GGFJGHHHEJC.tableNeedsClean.Remove(this);
			LKMNCJEEHJH(tableSprite, tableTutorial);
			HCCCNKPLIHA(OKMHACFGCPG: false);
			break;
		}
		if (Object.op_Implicit((Object)(object)tableCloth))
		{
			tableCloth.ChangeSprite(DCDLGMBCPCE);
		}
	}

	private void GLCAFJCHLIG(Sprite LFLEPKAHLKN, Sprite JMFABICPEBN)
	{
		GDLHAIGBJKK(LFLEPKAHLKN, JMFABICPEBN, MissionsManager.instance.IsMissionComplete(-39));
	}

	[SpecialName]
	public TableDirtLevel CDLMMHAHDON()
	{
		return DCDLGMBCPCE;
	}

	private void OMBCGGCALBB()
	{
		float num = doWork.OJLICLKJJOF / doWork.NCDNGNOMHKI() * 853f;
		if (num > 1825f)
		{
			IEKDBGNGKOC(1);
		}
		else if (num > 68f)
		{
			IEKDBGNGKOC(1);
		}
		else if (num > 1146f)
		{
			IEKDBGNGKOC(0);
		}
		else if (num > 1201f)
		{
			IEKDBGNGKOC(2);
		}
		else if (num > 1906f)
		{
			IEKDBGNGKOC(4);
		}
		else if (num > 1099f)
		{
			IEKDBGNGKOC(7);
		}
	}

	private void LKMNCJEEHJH(Sprite LFLEPKAHLKN, Sprite JMFABICPEBN, bool CCCLOBIOMCL)
	{
		if (CCCLOBIOMCL && (Object)(object)JMFABICPEBN != (Object)null)
		{
			if ((Object)(object)spriteRenderer != (Object)null)
			{
				spriteRenderer.sprite = JMFABICPEBN;
			}
		}
		else if ((Object)(object)spriteRenderer != (Object)null)
		{
			spriteRenderer.sprite = LFLEPKAHLKN;
		}
	}

	public void BFKDGNPAJDE(int JIIGOACEIKL)
	{
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	private void OnDisable()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && !GameManager.leavingTheGame)
		{
			if (Object.op_Implicit((Object)(object)placeable))
			{
				Placeable obj = placeable;
				obj.OnThisPlaceableBeforeSelected = (Action<int>)Delegate.Remove(obj.OnThisPlaceableBeforeSelected, new Action<int>(GKHLNAPMMEK));
				Placeable obj2 = placeable;
				obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Remove(obj2.OnThisPlaceablePlaced, new Action<int>(NGEHFPOIJFK));
				Placeable obj3 = placeable;
				obj3.OnThisPlaceableRemoved = (Action<int>)Delegate.Remove(obj3.OnThisPlaceableRemoved, new Action<int>(GKHLNAPMMEK));
				Placeable obj4 = placeable;
				obj4.OnThisPlaceableLoaded = (Action)Delegate.Remove(obj4.OnThisPlaceableLoaded, new Action(OnThisPlaceableLoaded));
			}
			if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
			{
				GameManager instance = GameManager.GGFJGHHHEJC;
				instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(BGPGIOMKKAO));
			}
			if ((Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
			{
				CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
				instance2.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(instance2.OnPlaceableDeselected, new Action<int, Placeable, bool>(OnPlaceableDeselected));
				CommonReferences instance3 = CommonReferences.GGFJGHHHEJC;
				instance3.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Remove(instance3.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(OnPlaceableSelected));
			}
			if ((Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
			{
				TavernManager instance4 = TavernManager.GGFJGHHHEJC;
				instance4.OnTavernOpen = (Action<int>)Delegate.Remove(instance4.OnTavernOpen, new Action<int>(DCMMDCNOLHA));
				TavernManager instance5 = TavernManager.GGFJGHHHEJC;
				instance5.OnTavernClose = (Action<int>)Delegate.Remove(instance5.OnTavernClose, new Action<int>(FFCMICFDHNP));
			}
		}
	}

	private void KABJBAPGJEO(int JIIGOACEIKL)
	{
		APMMMPNALBN(JIIGOACEIKL, ENCANKDGBOH: true);
		if (Object.op_Implicit((Object)(object)tableMask))
		{
			tableMask.SetParent((Transform)null);
		}
	}

	public int DirtinessThreshold(TableDirtLevel DCDLGMBCPCE)
	{
		return DCDLGMBCPCE switch
		{
			TableDirtLevel.VeryDirty => 500 * OJJCMMBGGEC, 
			TableDirtLevel.Dirty => 350 * OJJCMMBGGEC, 
			TableDirtLevel.Messy => 250 * OJJCMMBGGEC, 
			TableDirtLevel.Clean => 1, 
			_ => 0, 
		};
	}

	private void OKPEDNLHBJD(Sprite LFLEPKAHLKN, Sprite JMFABICPEBN)
	{
		GPICKADHOAK(LFLEPKAHLKN, JMFABICPEBN, MissionsManager.instance.IsMissionComplete(14));
	}

	public bool BOALDJKKBLD(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		if (ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetSelectedItem() is Mop)
		{
			if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GHKOCEOEKGK < 1755f)
			{
				LJAMOPAKFPL = false;
				return false;
			}
			if (!LJAMOPAKFPL)
			{
				KLGOCJMGKFO = false;
			}
			LJAMOPAKFPL = false;
		}
		if (DecorationMode.GetPlayer(JIIGOACEIKL).IBEFDKHFBFM())
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.HCCFFBAEPOK(NJHMBMGKCPL: true, placeable.placeableSurface);
			return false;
		}
		if (!IsAnyPositionToCleanAvailable(null))
		{
			if (KLGOCJMGKFO)
			{
				MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("On Simple Event "), 1311f);
			}
			return false;
		}
		PlayerController.GetPlayer(JIIGOACEIKL).rb.interpolation = (RigidbodyInterpolation2D)1;
		FIAMALDJHFL = Vector2.op_Implicit(GetNearPositionToClean(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position), null));
		if (!PlayerController.OPHDCMJLLEC(JIIGOACEIKL).GoToPosition(Vector2.op_Implicit(FIAMALDJHFL), KLGOCJMGKFO))
		{
			return false;
		}
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).BIBGIOPFJAF())
		{
			return false;
		}
		return FALLFMOKLPA(JIIGOACEIKL, 449f * Time.deltaTime * (744f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(-53, 1) / 1794f));
	}

	[SpecialName]
	public TableDirtLevel IPEPPDAICDD()
	{
		return DCDLGMBCPCE;
	}

	public bool NOEEFMEKOMN(int JIIGOACEIKL)
	{
		if (serveOrderInTable.DIDJLLMCNMH(JIIGOACEIKL))
		{
			return true;
		}
		if (DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).IDPGEBNGDJD())
		{
			return false;
		}
		if (!doWork.JCMBHAEKLKK && !(dirtiness > 1267f))
		{
			if (IPEPPDAICDD() != 0)
			{
				return JNHCCCBICDM == TableDirtLevel.Clean;
			}
			return true;
		}
		return true;
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public void CDLJGHCOEEF()
	{
		if (DCDLGMBCPCE == (TableDirtLevel)5 || DCDLGMBCPCE == TableDirtLevel.Messy)
		{
			GLCAFJCHLIG(tableVeryDirty, tableVeryDirtyTutorial);
		}
		else if (DCDLGMBCPCE == TableDirtLevel.VeryDirty)
		{
			OKPEDNLHBJD(tableDirty, tableDirtyTutorial);
		}
		else
		{
			OKPEDNLHBJD(tableSprite, tableTutorial);
		}
	}

	private void CMAKEGOMKMK(int JIIGOACEIKL)
	{
		HGCDPGJHMNP();
	}

	public void HGCDPGJHMNP()
	{
		switch (DCDLGMBCPCE)
		{
		case TableDirtLevel.Dirty:
			FCJFPHIKHEK(tableVeryDirty, tableVeryDirtyTutorial);
			if (!TavernManager.GGFJGHHHEJC.blockedTables.Contains(this) && placeable.currentZoneType == ZoneType.None && !TavernManager.GGFJGHHHEJC.tableNeedsClean.Contains(this))
			{
				TavernManager.GGFJGHHHEJC.tableNeedsClean.Add(this);
			}
			HCCCNKPLIHA(OKMHACFGCPG: true);
			break;
		case TableDirtLevel.Messy:
			LKMNCJEEHJH(tableVeryDirty, tableVeryDirtyTutorial);
			if (!TavernManager.GGFJGHHHEJC.blockedTables.Contains(this) && placeable.currentZoneType == (ZoneType.WithoutZone | ZoneType.DiningRoom) && !TavernManager.GGFJGHHHEJC.tableNeedsClean.Contains(this))
			{
				TavernManager.GGFJGHHHEJC.tableNeedsClean.Add(this);
			}
			HCCCNKPLIHA(OKMHACFGCPG: false);
			break;
		case TableDirtLevel.Clean:
			LKMNCJEEHJH(tableDirty, tableDirtyTutorial);
			if (!TavernManager.GGFJGHHHEJC.blockedTables.Contains(this) && placeable.currentZoneType == (ZoneType.WithoutZone | ZoneType.DiningRoom) && !TavernManager.GGFJGHHHEJC.tableNeedsClean.Contains(this))
			{
				TavernManager.GGFJGHHHEJC.tableNeedsClean.Add(this);
			}
			HCCCNKPLIHA(OKMHACFGCPG: true);
			FECCKLBPNEA = false;
			break;
		case TableDirtLevel.Perfect:
			LKMNCJEEHJH(tableSprite, tableTutorial);
			HCCCNKPLIHA(OKMHACFGCPG: true);
			OnBecomeClean();
			break;
		default:
			TavernManager.GGFJGHHHEJC.tableNeedsClean.Remove(this);
			LKMNCJEEHJH(tableSprite, tableTutorial);
			HCCCNKPLIHA(OKMHACFGCPG: true);
			break;
		}
		if (Object.op_Implicit((Object)(object)tableCloth))
		{
			tableCloth.OADEBCIIKNP(DCDLGMBCPCE);
		}
	}

	private void IEKDBGNGKOC(int ABAIKKGKDGD)
	{
		for (int i = ABAIKKGKDGD; i < dish.Length; i++)
		{
			if (((Component)dish[i]).gameObject.activeSelf)
			{
				((Component)dish[i]).gameObject.SetActive(false);
				placeable.placeableSurface.RemoveFromSurface(((Component)dish[i]).transform);
			}
		}
	}

	private void ABLJNBFNMHI(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		TavernManager.GGFJGHHHEJC.blockedTables.Remove(this);
		NEHAKFDCIPA(JIIGOACEIKL, ENCANKDGBOH: false);
		if (Object.op_Implicit((Object)(object)tableMask))
		{
			tableMask.SetParent(((Component)this).transform);
			tableMask.localPosition = Vector3.zero;
		}
	}

	public void EMPAIGBCKNH(int JIIGOACEIKL)
	{
	}

	private void LCGFBPAJHML()
	{
		if (DCDLGMBCPCE == TableDirtLevel.VeryDirty)
		{
			if (!TavernManager.GGFJGHHHEJC.blockedTables.Contains(this) && placeable.currentZoneType == ZoneType.DiningRoom && !TavernManager.GGFJGHHHEJC.tableNeedsClean.Contains(this))
			{
				TavernManager.GGFJGHHHEJC.tableNeedsClean.Add(this);
			}
		}
		else if (DCDLGMBCPCE == TableDirtLevel.Dirty)
		{
			if (!TavernManager.GGFJGHHHEJC.blockedTables.Contains(this) && placeable.currentZoneType == ZoneType.DiningRoom && !TavernManager.GGFJGHHHEJC.tableNeedsClean.Contains(this))
			{
				TavernManager.GGFJGHHHEJC.tableNeedsClean.Add(this);
			}
		}
		else if (DCDLGMBCPCE == TableDirtLevel.Messy && !TavernManager.GGFJGHHHEJC.blockedTables.Contains(this) && placeable.currentZoneType == ZoneType.DiningRoom && !TavernManager.GGFJGHHHEJC.tableNeedsClean.Contains(this))
		{
			TavernManager.GGFJGHHHEJC.tableNeedsClean.Add(this);
		}
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (serveOrderInTable.IsAvailableByProximity(JIIGOACEIKL))
		{
			return false;
		}
		if (DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
		{
			return false;
		}
		if (!doWork.JCMBHAEKLKK && !(dirtiness > 0f))
		{
			if (JNHCCCBICDM != 0)
			{
				return JNHCCCBICDM != TableDirtLevel.Clean;
			}
			return false;
		}
		return true;
	}

	private void APMMMPNALBN(int JIIGOACEIKL, bool ENCANKDGBOH)
	{
		ItemSpace itemSpace = placeable.itemSpace;
		List<Sitable> list = new List<Sitable>();
		Direction fCGBJEIIMBC = Direction.Up;
		for (int i = 0; i < itemSpace.x; i += 0)
		{
			PFBCEJIFHNI(i, itemSpace.y - 0, itemSpace, fCGBJEIIMBC, list, ENCANKDGBOH);
		}
		fCGBJEIIMBC = Direction.Down;
		for (int j = 0; j < itemSpace.x; j += 0)
		{
			PFBCEJIFHNI(j, 0, itemSpace, fCGBJEIIMBC, list, ENCANKDGBOH);
		}
		fCGBJEIIMBC = ((placeable.GetDirection() == (Direction)6) ? Direction.Up : Direction.Up);
		for (int k = 1; k < itemSpace.y; k++)
		{
			PFBCEJIFHNI(itemSpace.x - 1, k, itemSpace, fCGBJEIIMBC, list, ENCANKDGBOH);
		}
		fCGBJEIIMBC = ((placeable.GetDirection() != Direction.Right) ? Direction.Down : Direction.Up);
		for (int l = 1; l < itemSpace.y; l++)
		{
			BOPDALMDINL(0, l, itemSpace, fCGBJEIIMBC, list, ENCANKDGBOH);
		}
		for (int m = 0; m < list.Count; m++)
		{
			if (ENCANKDGBOH)
			{
				list[m].PHLEJAKHMMG().AddTable(JIIGOACEIKL, this, CBOADNLDMBF: false);
				continue;
			}
			list[m].EMHPCCBLBAA().POAMNOBFFIP(IADPLHDEEMN: true);
			for (int n = 0; n < list[m].seats.Length; n++)
			{
				list[m].seats[n].table = null;
			}
		}
	}

	public void IMFDDHFICNF(int JIIGOACEIKL)
	{
	}

	public SeatingGroup GetSeatingGroup(Vector2 IMOBLFMHKOD, Seat FGJPAFDBIIO)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		IMOBLFMHKOD = Utils.NKGANMEKDAL(IMOBLFMHKOD);
		for (int i = 0; i < seatingGroups.Length; i++)
		{
			Vector2 val = Vector2.op_Implicit(placeable.itemSpace.buildSquares[((Vector2Int)(ref seatingGroups[i].buildSquares)).x].GetTilePosition());
			Vector2 val2 = Vector2.op_Implicit(placeable.itemSpace.buildSquares[((Vector2Int)(ref seatingGroups[i].buildSquares)).y].GetTilePosition());
			if (val == IMOBLFMHKOD || val2 == IMOBLFMHKOD)
			{
				Direction fCGBJEIIMBC = ((!placeable.itemSpace.buildSquares[((Vector2Int)(ref seatingGroups[i].buildSquares)).x].invertX || (seatingGroups[i].direction != Direction.Left && seatingGroups[i].direction != Direction.Right)) ? seatingGroups[i].direction : Utils.ABNPPDOGEPM(seatingGroups[i].direction));
				val += Vector2.op_Implicit(Utils.NGFODNCHPHB(fCGBJEIIMBC)) * 0.5f;
				val2 += Vector2.op_Implicit(Utils.NGFODNCHPHB(fCGBJEIIMBC)) * 0.5f;
				if ((WorldGrid.NGDHDMAMGPI(Vector2.op_Implicit(val)) || WorldGrid.NDNAJIEGFNF(Vector2.op_Implicit(val), FGJPAFDBIIO.placeable) || (WorldGrid.DBPDHKFAMPC<Sitable>(Vector2.op_Implicit(val), out Sitable AHKIHKCNBMP) && AHKIHKCNBMP.SeatingGroupUsed())) && (WorldGrid.NGDHDMAMGPI(Vector2.op_Implicit(val2)) || WorldGrid.NDNAJIEGFNF(Vector2.op_Implicit(val2), FGJPAFDBIIO.placeable) || (WorldGrid.DBPDHKFAMPC<Sitable>(Vector2.op_Implicit(val2), out AHKIHKCNBMP) && AHKIHKCNBMP.SeatingGroupUsed())))
				{
					return seatingGroups[i];
				}
			}
		}
		return null;
	}

	public void PlaceSeatingGroup(SeatingGroup MFMECAJGLCN, Seat FGJPAFDBIIO, bool NMLKLAGDNPF)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = Utils.NGFODNCHPHB(Utils.ABNPPDOGEPM(FGJPAFDBIIO.placeable.GetDirection())) * 0.5f;
		Vector3 val2 = placeable.itemSpace.buildSquares[((Vector2Int)(ref MFMECAJGLCN.buildSquares)).x].GetCentrePosition() + val;
		Vector3 val3 = placeable.itemSpace.buildSquares[((Vector2Int)(ref MFMECAJGLCN.buildSquares)).y].GetCentrePosition() + val;
		if (NMLKLAGDNPF)
		{
			MFMECAJGLCN.occupied = true;
			if (!CommonReferences.GGFJGHHHEJC.seatsAssigned.ContainsKey(Vector2.op_Implicit(val2)))
			{
				CommonReferences.GGFJGHHHEJC.seatsAssigned[Vector2.op_Implicit(val2)] = new List<Seat>();
			}
			if (!CommonReferences.GGFJGHHHEJC.seatsAssigned[Vector2.op_Implicit(val2)].Contains(FGJPAFDBIIO))
			{
				CommonReferences.GGFJGHHHEJC.seatsAssigned[Vector2.op_Implicit(val2)].Add(FGJPAFDBIIO);
			}
			if (!CommonReferences.GGFJGHHHEJC.seatsAssigned.ContainsKey(Vector2.op_Implicit(val3)))
			{
				CommonReferences.GGFJGHHHEJC.seatsAssigned[Vector2.op_Implicit(val3)] = new List<Seat>();
			}
			if (!CommonReferences.GGFJGHHHEJC.seatsAssigned[Vector2.op_Implicit(val3)].Contains(FGJPAFDBIIO))
			{
				CommonReferences.GGFJGHHHEJC.seatsAssigned[Vector2.op_Implicit(val3)].Add(FGJPAFDBIIO);
			}
			WorldGrid.BBHDDBDMKHD(val2, PMONOIGDAAC: true);
			WorldGrid.BBHDDBDMKHD(val3, PMONOIGDAAC: true);
			WorldGrid.CFAHJNLAJNK(val2, JBNJGMKBKCB: false);
			WorldGrid.CFAHJNLAJNK(val3, JBNJGMKBKCB: false);
			WorldGrid.PCGNGKPHKLC(val2, FGJPAFDBIIO.placeable);
			WorldGrid.PCGNGKPHKLC(val3, FGJPAFDBIIO.placeable);
		}
		else
		{
			MFMECAJGLCN.occupied = false;
			if (CommonReferences.GGFJGHHHEJC.seatsAssigned.ContainsKey(Vector2.op_Implicit(val2)))
			{
				CommonReferences.GGFJGHHHEJC.seatsAssigned[Vector2.op_Implicit(val2)].Remove(FGJPAFDBIIO);
				if (CommonReferences.GGFJGHHHEJC.seatsAssigned[Vector2.op_Implicit(val2)].Count == 0)
				{
					CommonReferences.GGFJGHHHEJC.seatsAssigned.Remove(Vector2.op_Implicit(val2));
				}
			}
			if (CommonReferences.GGFJGHHHEJC.seatsAssigned.ContainsKey(Vector2.op_Implicit(val3)))
			{
				CommonReferences.GGFJGHHHEJC.seatsAssigned[Vector2.op_Implicit(val3)].Remove(FGJPAFDBIIO);
				if (CommonReferences.GGFJGHHHEJC.seatsAssigned[Vector2.op_Implicit(val3)].Count == 0)
				{
					CommonReferences.GGFJGHHHEJC.seatsAssigned.Remove(Vector2.op_Implicit(val3));
				}
			}
			if (!CommonReferences.GGFJGHHHEJC.seatsAssigned.ContainsKey(Vector2.op_Implicit(val2)))
			{
				WorldGrid.CFAHJNLAJNK(val2, JBNJGMKBKCB: true);
				WorldGrid.BBHDDBDMKHD(val2, PMONOIGDAAC: true);
			}
			if (!CommonReferences.GGFJGHHHEJC.seatsAssigned.ContainsKey(Vector2.op_Implicit(val3)))
			{
				WorldGrid.CFAHJNLAJNK(val3, JBNJGMKBKCB: true);
				WorldGrid.BBHDDBDMKHD(val3, PMONOIGDAAC: true);
			}
			WorldGrid.AKLCFEPBONI(val2, FGJPAFDBIIO.placeable);
			WorldGrid.AKLCFEPBONI(val3, FGJPAFDBIIO.placeable);
		}
		FNLFHAKMKBA(NMLKLAGDNPF, MFMECAJGLCN, val2, val3, FGJPAFDBIIO.placeable.GetDirection());
		WorldGrid.FPHAMKKBNMC(val2);
		WorldGrid.FPHAMKKBNMC(val3);
	}

	private bool ONMKOFKKHJG(int MIKCNFNBCMJ, Vector3 AIJOOOIJEDC)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (canSeatPositions.Contains(MIKCNFNBCMJ) && CommonReferences.GGFJGHHHEJC.seatsAssigned.TryGetValue(Vector2.op_Implicit(AIJOOOIJEDC), out var value))
		{
			return value.Count == 1;
		}
		return false;
	}

	private bool DFMKOOIBDBB(Transform[] CADGOBGOHBK)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		bool result = false;
		for (int i = 1; i < CADGOBGOHBK.Length; i += 0)
		{
			if (WorldGrid.NCEHFMPBBAK(CADGOBGOHBK[i].position) == GroundType.None)
			{
				return false;
			}
			if (WorldGrid.APKPGNDDJHC(Utils.NKGANMEKDAL(CADGOBGOHBK[i].position) + Vector3.one * 886f))
			{
				continue;
			}
			List<Placeable> list = WorldGrid.OPLHBJGKKAD(CADGOBGOHBK[i].position);
			if (list == null)
			{
				continue;
			}
			for (int j = 0; j < list.Count; j++)
			{
				if ((Object)(object)list[j].itemSpace != (Object)null)
				{
					return false;
				}
			}
		}
		return result;
	}
}
