using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class FloorDirt : MonoBehaviour, IHoverable, IProximity
{
	[CompilerGenerated]
	private sealed class BGCMHPAOHDM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FloorDirt _003C_003E4__this;

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
		public BGCMHPAOHDM(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			FloorDirt floorDirt = _003C_003E4__this;
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
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				floorDirt.zoneType = WorldGrid.AGKGGAFFFGM(((Component)floorDirt).transform.position);
				floorDirt.zoneIndex = WorldGrid.APJABAKKKGD(((Component)floorDirt).transform.position);
				if (floorDirt.tutorialDirt && NewTutorialManager.DestroyFloorDirtOnLoad())
				{
					floorDirt.DestroyFloorDirt();
				}
				else if (floorDirt.zoneType == ZoneType.RentedRoom)
				{
					RentedRoomsManager.AddFloorDirt(floorDirt, floorDirt.zoneIndex);
				}
				else if (WorldGrid.EJCEAEPNJCA(((Component)floorDirt).transform.position) && !Utils.BLIAFMGPONN(((Component)floorDirt).transform.position))
				{
					TavernManager.GGFJGHHHEJC.PDPKEPEBPIK += 20f;
					CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Add(floorDirt);
				}
				else
				{
					floorDirt.DestroyFloorDirt();
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

	public int spriteIndex;

	public bool randomise = true;

	public bool tutorialDirt;

	[SerializeField]
	private Sprite[] sprites;

	public SpriteRenderer spriteRenderer;

	[SerializeField]
	private DoWork doWork;

	[SerializeField]
	private float workNeeded;

	public ZoneType zoneType;

	public int zoneIndex;

	private bool JKIAKMICLKF;

	private bool EHLJOBLJMOM;

	private Customer PJNGMCJIHME;

	public NPC cleanerAssigned;

	public void BKFHIADKPHK(int JIIGOACEIKL)
	{
	}

	private void Awake()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		zoneType = WorldGrid.AGKGGAFFFGM(((Component)this).transform.position);
		zoneIndex = WorldGrid.APJABAKKKGD(((Component)this).transform.position);
		if (Application.isEditor)
		{
			((Object)((Component)this).gameObject).name = Time.realtimeSinceStartup + " - " + ((Object)((Component)this).gameObject).name;
		}
	}

	public void KNAECECJECL(int JIIGOACEIKL)
	{
	}

	public bool ABMFEAKMFII(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			if (JIIGOACEIKL == 1)
			{
				JKIAKMICLKF = false;
			}
			else
			{
				EHLJOBLJMOM = false;
			}
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(""));
			return false;
		}
		return true;
	}

	public void MANFKPEAMLJ(int JIIGOACEIKL)
	{
		if (JKIAKMICLKF)
		{
			ButtonsContext.GetPlayer(0).ResetButtons();
		}
		if (EHLJOBLJMOM)
		{
			ButtonsContext.GetPlayer(3).DKCMJENPPFA();
		}
		JKIAKMICLKF = true;
		EHLJOBLJMOM = false;
	}

	public bool CEBLDOMPJNI(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && LDFDEJNMBLP(JIIGOACEIKL))
		{
			if (JIIGOACEIKL == 0)
			{
				JKIAKMICLKF = true;
			}
			else
			{
				EHLJOBLJMOM = true;
			}
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("itemCaramelAle"));
			return false;
		}
		return false;
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public void EGDDLLIJFMB(int JIIGOACEIKL)
	{
	}

	public bool MLDKIKOHBBG(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && DOGECDPIPBA(JIIGOACEIKL))
		{
			if (JIIGOACEIKL == 0)
			{
				JKIAKMICLKF = true;
			}
			else
			{
				EHLJOBLJMOM = false;
			}
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("No seat or table!"));
			return false;
		}
		return false;
	}

	private void MLPAOEEILAL()
	{
		if (GameManager.CIOEICMHCCK || GameManager.leavingTheGame)
		{
			return;
		}
		if (zoneType == (ZoneType.WithoutZone | ZoneType.DiningRoom))
		{
			RentedRoomsManager.BNDHCPBCKLC(this, zoneIndex);
		}
		else
		{
			if ((Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
			{
				TavernManager.GGFJGHHHEJC.PDPKEPEBPIK -= 1181f;
			}
			if ((Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
			{
				CommonReferences.MNFMOEKMJKN().tavernFloorDirt.Remove(this);
			}
		}
		if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences.MNFMOEKMJKN().OnFloorDirtDestroyed();
		}
		PCHLPDOHNMJ(0);
	}

	public bool AGJPABDBHCJ(int JIIGOACEIKL)
	{
		return ActionBarInventory.BNMEANGDMIP(JIIGOACEIKL).GetSelectedItem() is Mop;
	}

	public void OffHover(int JIIGOACEIKL)
	{
		if (JKIAKMICLKF)
		{
			ButtonsContext.GetPlayer(1).ResetButtons();
		}
		if (EHLJOBLJMOM)
		{
			ButtonsContext.GetPlayer(2).ResetButtons();
		}
		JKIAKMICLKF = false;
		EHLJOBLJMOM = false;
	}

	public void LAEDMIPNGPJ(int JIIGOACEIKL)
	{
		if (JKIAKMICLKF)
		{
			ButtonsContext.GetPlayer(0).ResetButtons();
		}
		if (EHLJOBLJMOM)
		{
			ButtonsContext.GetPlayer(2).ResetButtons();
		}
		JKIAKMICLKF = true;
		EHLJOBLJMOM = true;
	}

	public bool PEJPCEMKCJM(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && DJNPAPBNPNL(JIIGOACEIKL))
		{
			if (JIIGOACEIKL == 0)
			{
				JKIAKMICLKF = false;
			}
			else
			{
				EHLJOBLJMOM = true;
			}
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Player num by bed assigned failed. Finding by name..."));
			return true;
		}
		return false;
	}

	public bool BMMLEBLPANH(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && DJNPAPBNPNL(JIIGOACEIKL))
		{
			if (JIIGOACEIKL == 1)
			{
				JKIAKMICLKF = true;
			}
			else
			{
				EHLJOBLJMOM = false;
			}
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Warm"));
			return true;
		}
		return false;
	}

	public void DAFFDEDGGCL(int JIIGOACEIKL)
	{
		if (JKIAKMICLKF)
		{
			ButtonsContext.GetPlayer(0).DKCMJENPPFA();
		}
		if (EHLJOBLJMOM)
		{
			ButtonsContext.GetPlayer(4).DKCMJENPPFA();
		}
		JKIAKMICLKF = false;
		EHLJOBLJMOM = false;
	}

	public void CDOOEGGKFBB(int JIIGOACEIKL)
	{
	}

	public void KODCGEJPFPN(int JIIGOACEIKL)
	{
		if (JKIAKMICLKF)
		{
			ButtonsContext.GetPlayer(0).ResetButtons();
		}
		if (EHLJOBLJMOM)
		{
			ButtonsContext.GetPlayer(2).DKCMJENPPFA();
		}
		JKIAKMICLKF = false;
		EHLJOBLJMOM = false;
	}

	public bool DJNPAPBNPNL(int JIIGOACEIKL)
	{
		return ActionBarInventory.BNMEANGDMIP(JIIGOACEIKL, LAGHIOKLJGH: true).FGGKCJDFNEK() is Mop;
	}

	public void AJHBNGHFNNJ()
	{
		doWork.NDCKEJDBPGO();
	}

	public bool LDFDEJNMBLP(int JIIGOACEIKL)
	{
		return ActionBarInventory.MHDKNEKDKII(JIIGOACEIKL).GetSelectedItem() is Mop;
	}

	public void FGJPGIICPNF(int JIIGOACEIKL)
	{
	}

	public void OHHBNJBFDII()
	{
		doWork.KEDEHPOFEPA();
	}

	public void EAPDHKDAHLC(int JIIGOACEIKL)
	{
	}

	public bool BEDJMEFHKCK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && DJNPAPBNPNL(JIIGOACEIKL))
		{
			if (JIIGOACEIKL == 0)
			{
				JKIAKMICLKF = true;
			}
			else
			{
				EHLJOBLJMOM = true;
			}
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("upgradeRoomNotification"));
			return false;
		}
		return false;
	}

	public void OIMEKODEFAA(int JIIGOACEIKL)
	{
		if (JKIAKMICLKF)
		{
			ButtonsContext.GetPlayer(1).ResetButtons();
		}
		if (EHLJOBLJMOM)
		{
			ButtonsContext.GetPlayer(3).ResetButtons();
		}
		JKIAKMICLKF = false;
		EHLJOBLJMOM = false;
	}

	private void IGBEKHCLKFD()
	{
		if (GameManager.CIOEICMHCCK || GameManager.leavingTheGame)
		{
			return;
		}
		if (zoneType == (ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom))
		{
			RentedRoomsManager.BNDHCPBCKLC(this, zoneIndex);
		}
		else
		{
			if ((Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
			{
				TavernManager.GGFJGHHHEJC.PDPKEPEBPIK -= 1730f;
			}
			if ((Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
			{
				CommonReferences.MNFMOEKMJKN().tavernFloorDirt.Remove(this);
			}
		}
		if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences.GGFJGHHHEJC.OnFloorDirtDestroyed();
		}
		MANFKPEAMLJ(0);
	}

	public bool Clean(int JIIGOACEIKL, float HGMFJBLNCJJ)
	{
		if (doWork.JCMBHAEKLKK && Object.op_Implicit((Object)(object)doWork.CCCLNDBOGOI))
		{
			if (doWork.AddWorkDone(JIIGOACEIKL, HGMFJBLNCJJ * Time.deltaTime))
			{
				DestroyFloorDirt();
				return true;
			}
			return false;
		}
		doWork.StartWork(workNeeded);
		return false;
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			if (JIIGOACEIKL == 1)
			{
				JKIAKMICLKF = true;
			}
			else
			{
				EHLJOBLJMOM = true;
			}
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("cleanVerb"));
			return true;
		}
		return false;
	}

	public void KLPKJGPBNPA()
	{
		doWork.AddWorkDone(1, 1842f);
	}

	public void MJOMNDHGIBO()
	{
		doWork.AddWorkDone(0, 1529f, CDPAMNIPPEC: false);
	}

	public void BEBLOHAFHNO(int JIIGOACEIKL)
	{
		if (JKIAKMICLKF)
		{
			ButtonsContext.GetPlayer(0).DKCMJENPPFA();
		}
		if (EHLJOBLJMOM)
		{
			ButtonsContext.GetPlayer(0).DKCMJENPPFA();
		}
		JKIAKMICLKF = false;
		EHLJOBLJMOM = false;
	}

	private void CLGBFOIBANN()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		zoneType = WorldGrid.AGKGGAFFFGM(((Component)this).transform.position);
		zoneIndex = WorldGrid.APJABAKKKGD(((Component)this).transform.position);
		if (Application.isEditor)
		{
			((Object)((Component)this).gameObject).name = Time.realtimeSinceStartup + "change season" + ((Object)((Component)this).gameObject).name;
		}
	}

	public bool AEBLENEONED(int JIIGOACEIKL, float HGMFJBLNCJJ)
	{
		if (doWork.JCMBHAEKLKK && Object.op_Implicit((Object)(object)doWork.CCCLNDBOGOI))
		{
			if (doWork.AddWorkDone(JIIGOACEIKL, HGMFJBLNCJJ * Time.deltaTime))
			{
				ACEHJIMAFBH();
				return false;
			}
			return false;
		}
		doWork.OKINPIOJMNA(workNeeded);
		return false;
	}

	public void MOBFEFJFGBE(int JIIGOACEIKL)
	{
	}

	private void NFKHMBDBPLL(Collider2D HANHCHBHHEH)
	{
		PJNGMCJIHME = ((Component)HANHCHBHHEH).GetComponent<Customer>();
		if ((Object)(object)PJNGMCJIHME != (Object)null)
		{
			Customer pJNGMCJIHME = PJNGMCJIHME;
			pJNGMCJIHME.HGKKCKHDPJJ(pJNGMCJIHME.NGDAJGCPJEC - PJNGMCJIHME.customerInfo.floorDirtPenalty);
		}
	}

	public void HDBKHJKPJCD(int JIIGOACEIKL)
	{
	}

	private void NNMFLMJDKNH()
	{
		if (GameManager.ILMDHNFFIKH() || GameManager.leavingTheGame)
		{
			return;
		}
		if (zoneType == ZoneType.RentedRoom)
		{
			RentedRoomsManager.HKDLFHDOFGL(this, zoneIndex);
		}
		else
		{
			if ((Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
			{
				TavernManager.GGFJGHHHEJC.PDPKEPEBPIK -= 741f;
			}
			if ((Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
			{
				CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Remove(this);
			}
		}
		if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences.MNFMOEKMJKN().OnFloorDirtDestroyed();
		}
		FBNFCONOMDB(1);
	}

	private void AMBKBOBDAIF()
	{
		if (GameManager.CIOEICMHCCK || GameManager.leavingTheGame)
		{
			return;
		}
		if (zoneType == ZoneType.RentedRoom)
		{
			RentedRoomsManager.BNDHCPBCKLC(this, zoneIndex);
		}
		else
		{
			if ((Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
			{
				TavernManager.GGFJGHHHEJC.PDPKEPEBPIK -= 526f;
			}
			if ((Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
			{
				CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Remove(this);
			}
		}
		if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences.MNFMOEKMJKN().OnFloorDirtDestroyed();
		}
		KODCGEJPFPN(0);
	}

	public bool OCOFAKALNBL(int JIIGOACEIKL)
	{
		return ActionBarInventory.BNMEANGDMIP(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetSelectedItem() is Mop;
	}

	public bool HBLLEFBCDAP(int JIIGOACEIKL, float HGMFJBLNCJJ)
	{
		if (doWork.JCMBHAEKLKK && Object.op_Implicit((Object)(object)doWork.FOHJBMDNBEG()))
		{
			if (doWork.PFLPFNICHJA(JIIGOACEIKL, HGMFJBLNCJJ * Time.deltaTime))
			{
				PGEMJFFLJCP();
				return true;
			}
			return false;
		}
		doWork.StartWork(workNeeded);
		return false;
	}

	private IEnumerator OIFGHBMIGCD()
	{
		return new BGCMHPAOHDM(1)
		{
			_003C_003E4__this = this
		};
	}

	public bool MLILNBGDOAO(float HGMFJBLNCJJ)
	{
		if (doWork.OENMBFGINAL())
		{
			if (doWork.BNMJANINOIG(1, HGMFJBLNCJJ * Time.fixedDeltaTime))
			{
				PGEMJFFLJCP();
				return false;
			}
			return true;
		}
		doWork.OKINPIOJMNA(workNeeded, null, CDPAMNIPPEC: false);
		return true;
	}

	private void PMLPGABFLGE(Collider2D HANHCHBHHEH)
	{
		PJNGMCJIHME = ((Component)HANHCHBHHEH).GetComponent<Customer>();
		if ((Object)(object)PJNGMCJIHME != (Object)null)
		{
			PJNGMCJIHME.NGDAJGCPJEC -= PJNGMCJIHME.customerInfo.floorDirtPenalty;
		}
	}

	private void NJAFKFAPDIE()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		zoneType = WorldGrid.AGKGGAFFFGM(((Component)this).transform.position);
		zoneIndex = WorldGrid.APJABAKKKGD(((Component)this).transform.position);
		if (Application.isEditor)
		{
			((Object)((Component)this).gameObject).name = Time.realtimeSinceStartup + "Looking up current user name..." + ((Object)((Component)this).gameObject).name;
		}
	}

	public void MJNNGIAAGFH(int JIIGOACEIKL)
	{
	}

	public void KLHGNBGGHBE()
	{
		doWork.IEMMMGCJOME(CDPAMNIPPEC: false);
	}

	private void KJOJLHCDFPP()
	{
		if (randomise)
		{
			spriteIndex = Random.Range(1, sprites.Length);
			if (Random.Range(1452f, 342f) > 392f)
			{
				spriteRenderer.flipX = false;
			}
		}
		else if (tutorialDirt)
		{
			for (int i = 1; i < sprites.Length; i++)
			{
				if ((Object)(object)sprites[i] == (Object)(object)spriteRenderer.sprite)
				{
					spriteIndex = i;
				}
			}
		}
		spriteRenderer.sprite = sprites[spriteIndex];
		CommonReferences.GGFJGHHHEJC.OnFloorDirtCreated();
		((MonoBehaviour)this).StartCoroutine(OIFGHBMIGCD());
	}

	public void FHPIBJNKBEN(int JIIGOACEIKL)
	{
	}

	public void JAOLLBEMIDO()
	{
		doWork.PFLPFNICHJA(0, 456f);
	}

	public void GCBLINFFFKC(int JIIGOACEIKL)
	{
	}

	public void NJADCLAICMA()
	{
		doWork.IEMMMGCJOME(CDPAMNIPPEC: false);
	}

	public void NFKEBBHNBFC(int JIIGOACEIKL)
	{
	}

	public bool LKECKENGGHM(int JIIGOACEIKL, float HGMFJBLNCJJ)
	{
		if (doWork.OENMBFGINAL() && Object.op_Implicit((Object)(object)doWork.JJAJCGKOKMN()))
		{
			if (doWork.IJEKBMFBEGG(JIIGOACEIKL, HGMFJBLNCJJ * Time.deltaTime))
			{
				HCLIKAJIPLK();
				return true;
			}
			return false;
		}
		doWork.EBAGOIDGCLE(workNeeded, null, CDPAMNIPPEC: false);
		return false;
	}

	private IEnumerator JBHHMHEKCJD()
	{
		yield return null;
		yield return null;
		zoneType = WorldGrid.AGKGGAFFFGM(((Component)this).transform.position);
		zoneIndex = WorldGrid.APJABAKKKGD(((Component)this).transform.position);
		if (tutorialDirt && NewTutorialManager.DestroyFloorDirtOnLoad())
		{
			DestroyFloorDirt();
		}
		else if (zoneType == ZoneType.RentedRoom)
		{
			RentedRoomsManager.AddFloorDirt(this, zoneIndex);
		}
		else if (WorldGrid.EJCEAEPNJCA(((Component)this).transform.position) && !Utils.BLIAFMGPONN(((Component)this).transform.position))
		{
			TavernManager.GGFJGHHHEJC.PDPKEPEBPIK += 20f;
			CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Add(this);
		}
		else
		{
			DestroyFloorDirt();
		}
	}

	public bool EELFIIHLDCB(int JIIGOACEIKL, float HGMFJBLNCJJ)
	{
		if (doWork.JCMBHAEKLKK && Object.op_Implicit((Object)(object)doWork.ICDOMKLNMOB()))
		{
			if (doWork.AddWorkDone(JIIGOACEIKL, HGMFJBLNCJJ * Time.deltaTime))
			{
				DestroyFloorDirt();
				return false;
			}
			return true;
		}
		doWork.GEJFAPKOLJH(workNeeded);
		return true;
	}

	private void OMBHDODDHNO()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		zoneType = WorldGrid.AGKGGAFFFGM(((Component)this).transform.position);
		zoneIndex = WorldGrid.APJABAKKKGD(((Component)this).transform.position);
		if (Application.isEditor)
		{
			((Object)((Component)this).gameObject).name = Time.realtimeSinceStartup + "Tail" + ((Object)((Component)this).gameObject).name;
		}
	}

	public void NDCKEJDBPGO()
	{
		doWork.NDCKEJDBPGO(CDPAMNIPPEC: false);
	}

	private void EIMIDCDEIDD()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		zoneType = WorldGrid.AGKGGAFFFGM(((Component)this).transform.position);
		zoneIndex = WorldGrid.APJABAKKKGD(((Component)this).transform.position);
		if (Application.isEditor)
		{
			((Object)((Component)this).gameObject).name = Time.realtimeSinceStartup + "\n" + ((Object)((Component)this).gameObject).name;
		}
	}

	public void DBNHAAAKGAE()
	{
		doWork.Stop();
	}

	public bool DLMPCCAANJJ(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && LDFDEJNMBLP(JIIGOACEIKL))
		{
			if (JIIGOACEIKL == 0)
			{
				JKIAKMICLKF = true;
			}
			else
			{
				EHLJOBLJMOM = true;
			}
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Dog"));
			return false;
		}
		return false;
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		return ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItem() is Mop;
	}

	public bool BPIMPFDOLKL(int JIIGOACEIKL, float HGMFJBLNCJJ)
	{
		if (doWork.OENMBFGINAL() && Object.op_Implicit((Object)(object)doWork.CCCLNDBOGOI))
		{
			if (doWork.AddWorkDone(JIIGOACEIKL, HGMFJBLNCJJ * Time.deltaTime))
			{
				ACEHJIMAFBH();
				return true;
			}
			return true;
		}
		doWork.StartWork(workNeeded, null, CDPAMNIPPEC: false);
		return true;
	}

	public void GHNIOKFDOMC(int JIIGOACEIKL)
	{
	}

	public bool BHMMBNIFKHD(int JIIGOACEIKL)
	{
		return ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL).FGGKCJDFNEK() is Mop;
	}

	private void BDJKNKIOPIJ()
	{
		if (randomise)
		{
			spriteIndex = Random.Range(1, sprites.Length);
			if (Random.Range(1431f, 1233f) > 685f)
			{
				spriteRenderer.flipX = false;
			}
		}
		else if (tutorialDirt)
		{
			for (int i = 0; i < sprites.Length; i++)
			{
				if ((Object)(object)sprites[i] == (Object)(object)spriteRenderer.sprite)
				{
					spriteIndex = i;
				}
			}
		}
		spriteRenderer.sprite = sprites[spriteIndex];
		CommonReferences.GGFJGHHHEJC.OnFloorDirtCreated();
		((MonoBehaviour)this).StartCoroutine(OIFGHBMIGCD());
	}

	public bool GBJGKICAKKK(int JIIGOACEIKL, float HGMFJBLNCJJ)
	{
		if (doWork.KGOEFMFHCOG() && Object.op_Implicit((Object)(object)doWork.CCCLNDBOGOI))
		{
			if (doWork.JMJMFEKCAGK(JIIGOACEIKL, HGMFJBLNCJJ * Time.deltaTime, CDPAMNIPPEC: false))
			{
				PGEMJFFLJCP();
				return false;
			}
			return true;
		}
		doWork.GEJFAPKOLJH(workNeeded);
		return true;
	}

	private void IMIONHLAKIH()
	{
		if (randomise)
		{
			spriteIndex = Random.Range(0, sprites.Length);
			if (Random.Range(1935f, 353f) > 299f)
			{
				spriteRenderer.flipX = false;
			}
		}
		else if (tutorialDirt)
		{
			for (int i = 0; i < sprites.Length; i += 0)
			{
				if ((Object)(object)sprites[i] == (Object)(object)spriteRenderer.sprite)
				{
					spriteIndex = i;
				}
			}
		}
		spriteRenderer.sprite = sprites[spriteIndex];
		CommonReferences.MNFMOEKMJKN().OnFloorDirtCreated();
		((MonoBehaviour)this).StartCoroutine(JBHHMHEKCJD());
	}

	public void IILCHLHOPBF(int JIIGOACEIKL)
	{
		if (JKIAKMICLKF)
		{
			ButtonsContext.GetPlayer(1).ResetButtons();
		}
		if (EHLJOBLJMOM)
		{
			ButtonsContext.GetPlayer(8).DKCMJENPPFA();
		}
		JKIAKMICLKF = false;
		EHLJOBLJMOM = false;
	}

	public void FMOLFKKGDDM(int JIIGOACEIKL)
	{
	}

	private void EMCFHILONOH(Collider2D HANHCHBHHEH)
	{
		PJNGMCJIHME = ((Component)HANHCHBHHEH).GetComponent<Customer>();
		if ((Object)(object)PJNGMCJIHME != (Object)null)
		{
			PJNGMCJIHME.NGDAJGCPJEC -= PJNGMCJIHME.customerInfo.floorDirtPenalty;
		}
	}

	public bool GFKDNEJHNNI(int JIIGOACEIKL)
	{
		return ActionBarInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true).GetSelectedItem() is Mop;
	}

	public void BJEHMFGABIK(int JIIGOACEIKL)
	{
		if (JKIAKMICLKF)
		{
			ButtonsContext.GetPlayer(1).ResetButtons();
		}
		if (EHLJOBLJMOM)
		{
			ButtonsContext.GetPlayer(7).DKCMJENPPFA();
		}
		JKIAKMICLKF = false;
		EHLJOBLJMOM = true;
	}

	public void POHNLHHIKJL(int JIIGOACEIKL)
	{
	}

	private void OnTriggerEnter2D(Collider2D HANHCHBHHEH)
	{
		PJNGMCJIHME = ((Component)HANHCHBHHEH).GetComponent<Customer>();
		if ((Object)(object)PJNGMCJIHME != (Object)null)
		{
			PJNGMCJIHME.NGDAJGCPJEC -= PJNGMCJIHME.customerInfo.floorDirtPenalty;
		}
	}

	public void MIKGOJOHHJE()
	{
		if (Object.op_Implicit((Object)(object)((Component)this).gameObject))
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	public void LGFDLJLHEOJ(int JIIGOACEIKL)
	{
	}

	public void DNJDLFACCHF(int JIIGOACEIKL)
	{
	}

	private void Start()
	{
		if (randomise)
		{
			spriteIndex = Random.Range(0, sprites.Length);
			if (Random.Range(0f, 1f) > 0.5f)
			{
				spriteRenderer.flipX = true;
			}
		}
		else if (tutorialDirt)
		{
			for (int i = 0; i < sprites.Length; i++)
			{
				if ((Object)(object)sprites[i] == (Object)(object)spriteRenderer.sprite)
				{
					spriteIndex = i;
				}
			}
		}
		spriteRenderer.sprite = sprites[spriteIndex];
		CommonReferences.GGFJGHHHEJC.OnFloorDirtCreated();
		((MonoBehaviour)this).StartCoroutine(GCHLGCJHKDA());
	}

	public void HPJLNHGMIGD(int JIIGOACEIKL)
	{
	}

	public void JDFNIFFJEBJ(int JIIGOACEIKL)
	{
	}

	public void GOJPIEKMLIP()
	{
		doWork.Stop();
	}

	public bool FPMFDKMLCML(int JIIGOACEIKL)
	{
		return ActionBarInventory.DACNEICGAAE(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).FGGKCJDFNEK() is Mop;
	}

	private void MBEFBNJNMFF(Collider2D HANHCHBHHEH)
	{
		PJNGMCJIHME = ((Component)HANHCHBHHEH).GetComponent<Customer>();
		if ((Object)(object)PJNGMCJIHME != (Object)null)
		{
			PJNGMCJIHME.NGDAJGCPJEC -= PJNGMCJIHME.customerInfo.floorDirtPenalty;
		}
	}

	private void KOBNHPKEJJD()
	{
		if (GameManager.ILMDHNFFIKH() || GameManager.leavingTheGame)
		{
			return;
		}
		if (zoneType == (ZoneType.DiningRoom | ZoneType.CraftingRoom))
		{
			RentedRoomsManager.BNDHCPBCKLC(this, zoneIndex);
		}
		else
		{
			if ((Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
			{
				TavernManager.GGFJGHHHEJC.PDPKEPEBPIK -= 1650f;
			}
			if ((Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
			{
				CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Remove(this);
			}
		}
		if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences.MNFMOEKMJKN().OnFloorDirtDestroyed();
		}
		NIPHFNAJKBN(1);
	}

	private IEnumerator GCHLGCJHKDA()
	{
		yield return null;
		yield return null;
		zoneType = WorldGrid.AGKGGAFFFGM(((Component)this).transform.position);
		zoneIndex = WorldGrid.APJABAKKKGD(((Component)this).transform.position);
		if (tutorialDirt && NewTutorialManager.DestroyFloorDirtOnLoad())
		{
			DestroyFloorDirt();
		}
		else if (zoneType == ZoneType.RentedRoom)
		{
			RentedRoomsManager.AddFloorDirt(this, zoneIndex);
		}
		else if (WorldGrid.EJCEAEPNJCA(((Component)this).transform.position) && !Utils.BLIAFMGPONN(((Component)this).transform.position))
		{
			TavernManager.GGFJGHHHEJC.PDPKEPEBPIK += 20f;
			CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Add(this);
		}
		else
		{
			DestroyFloorDirt();
		}
	}

	public void CleanDirtImmediately()
	{
		doWork.AddWorkDone(1, float.MaxValue);
	}

	public void IEJHKJNOMPM()
	{
		doWork.Stop();
	}

	public bool NMKPOMCPJPB(int JIIGOACEIKL)
	{
		return ActionBarInventory.ADHIHCNAKFP(JIIGOACEIKL, LAGHIOKLJGH: true).FGGKCJDFNEK() is Mop;
	}

	private void ACLLIGOCDNN(Collider2D HANHCHBHHEH)
	{
		PJNGMCJIHME = ((Component)HANHCHBHHEH).GetComponent<Customer>();
		if ((Object)(object)PJNGMCJIHME != (Object)null)
		{
			Customer pJNGMCJIHME = PJNGMCJIHME;
			pJNGMCJIHME.HGKKCKHDPJJ(pJNGMCJIHME.NGDAJGCPJEC - PJNGMCJIHME.customerInfo.floorDirtPenalty);
		}
	}

	public bool FFFCFIOKCCB(int JIIGOACEIKL, float HGMFJBLNCJJ)
	{
		if (doWork.KGOEFMFHCOG() && Object.op_Implicit((Object)(object)doWork.JJAJCGKOKMN()))
		{
			if (doWork.JMJMFEKCAGK(JIIGOACEIKL, HGMFJBLNCJJ * Time.deltaTime))
			{
				DestroyFloorDirt();
				return false;
			}
			return false;
		}
		doWork.APIHDHDJDFC(workNeeded, null, CDPAMNIPPEC: false);
		return true;
	}

	private void CLLAKJADGIH()
	{
		if (GameManager.ILMDHNFFIKH() || GameManager.leavingTheGame)
		{
			return;
		}
		if (zoneType == (ZoneType.WithoutZone | ZoneType.DiningRoom))
		{
			RentedRoomsManager.HKDLFHDOFGL(this, zoneIndex);
		}
		else
		{
			if ((Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
			{
				TavernManager.GGFJGHHHEJC.PDPKEPEBPIK -= 1862f;
			}
			if ((Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
			{
				CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Remove(this);
			}
		}
		if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences.GGFJGHHHEJC.OnFloorDirtDestroyed();
		}
		BJEHMFGABIK(0);
	}

	public void PGEMJFFLJCP()
	{
		if (Object.op_Implicit((Object)(object)((Component)this).gameObject))
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	public bool CleanMagicBroom(float HGMFJBLNCJJ)
	{
		if (doWork.JCMBHAEKLKK)
		{
			if (doWork.AddWorkDone(1, HGMFJBLNCJJ * Time.fixedDeltaTime))
			{
				DestroyFloorDirt();
				return true;
			}
			return false;
		}
		doWork.StartWork(workNeeded);
		return false;
	}

	private IEnumerator FBFEGMIKJPF()
	{
		return new BGCMHPAOHDM(1)
		{
			_003C_003E4__this = this
		};
	}

	public bool CFGOGPBMEKL(int JIIGOACEIKL)
	{
		return ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL, LAGHIOKLJGH: true).FGGKCJDFNEK() is Mop;
	}

	public void FBNFCONOMDB(int JIIGOACEIKL)
	{
		if (JKIAKMICLKF)
		{
			ButtonsContext.GetPlayer(0).DKCMJENPPFA();
		}
		if (EHLJOBLJMOM)
		{
			ButtonsContext.GetPlayer(0).ResetButtons();
		}
		JKIAKMICLKF = true;
		EHLJOBLJMOM = true;
	}

	private void EKPNPAHGAIP(Collider2D HANHCHBHHEH)
	{
		PJNGMCJIHME = ((Component)HANHCHBHHEH).GetComponent<Customer>();
		if ((Object)(object)PJNGMCJIHME != (Object)null)
		{
			PJNGMCJIHME.NGDAJGCPJEC -= PJNGMCJIHME.customerInfo.floorDirtPenalty;
		}
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	private void OnDestroy()
	{
		if (GameManager.CIOEICMHCCK || GameManager.leavingTheGame)
		{
			return;
		}
		if (zoneType == ZoneType.RentedRoom)
		{
			RentedRoomsManager.RemoveFloorDirt(this, zoneIndex);
		}
		else
		{
			if ((Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
			{
				TavernManager.GGFJGHHHEJC.PDPKEPEBPIK -= 20f;
			}
			if ((Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
			{
				CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Remove(this);
			}
		}
		if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences.GGFJGHHHEJC.OnFloorDirtDestroyed();
		}
		OffHover(0);
	}

	private void GNOBDKFFPOL()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		zoneType = WorldGrid.AGKGGAFFFGM(((Component)this).transform.position);
		zoneIndex = WorldGrid.APJABAKKKGD(((Component)this).transform.position);
		if (Application.isEditor)
		{
			((Object)((Component)this).gameObject).name = Time.realtimeSinceStartup + "ReceiveHit" + ((Object)((Component)this).gameObject).name;
		}
	}

	public void KFKBGHHAIKM()
	{
		doWork.JMJMFEKCAGK(1, 611f, CDPAMNIPPEC: false);
	}

	private void OCPLOMJAFPC()
	{
		if (GameManager.ILMDHNFFIKH() || GameManager.leavingTheGame)
		{
			return;
		}
		if (zoneType == ZoneType.CraftingRoom)
		{
			RentedRoomsManager.HKDLFHDOFGL(this, zoneIndex);
		}
		else
		{
			if ((Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
			{
				TavernManager.GGFJGHHHEJC.PDPKEPEBPIK -= 1217f;
			}
			if ((Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
			{
				CommonReferences.MNFMOEKMJKN().tavernFloorDirt.Remove(this);
			}
		}
		if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences.GGFJGHHHEJC.OnFloorDirtDestroyed();
		}
		BEBLOHAFHNO(1);
	}

	public bool DOGECDPIPBA(int JIIGOACEIKL)
	{
		return ActionBarInventory.GetPlayer(JIIGOACEIKL).JDAFPKOHJPC() is Mop;
	}

	public void NIPHFNAJKBN(int JIIGOACEIKL)
	{
		if (JKIAKMICLKF)
		{
			ButtonsContext.GetPlayer(1).DKCMJENPPFA();
		}
		if (EHLJOBLJMOM)
		{
			ButtonsContext.GetPlayer(0).DKCMJENPPFA();
		}
		JKIAKMICLKF = true;
		EHLJOBLJMOM = true;
	}

	public void Stop()
	{
		doWork.Stop();
	}

	public bool AJMIALOCAJM(float HGMFJBLNCJJ)
	{
		if (doWork.JCMBHAEKLKK)
		{
			if (doWork.JMJMFEKCAGK(1, HGMFJBLNCJJ * Time.fixedDeltaTime, CDPAMNIPPEC: false))
			{
				ACEHJIMAFBH();
				return true;
			}
			return false;
		}
		doWork.GEJFAPKOLJH(workNeeded);
		return true;
	}

	public void NMPNLEAAJNM(int JIIGOACEIKL)
	{
	}

	public void HCLIKAJIPLK()
	{
		if (Object.op_Implicit((Object)(object)((Component)this).gameObject))
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	private void IGIKNCOLCKL()
	{
		if (randomise)
		{
			spriteIndex = Random.Range(1, sprites.Length);
			if (Random.Range(650f, 38f) > 1709f)
			{
				spriteRenderer.flipX = false;
			}
		}
		else if (tutorialDirt)
		{
			for (int i = 0; i < sprites.Length; i += 0)
			{
				if ((Object)(object)sprites[i] == (Object)(object)spriteRenderer.sprite)
				{
					spriteIndex = i;
				}
			}
		}
		spriteRenderer.sprite = sprites[spriteIndex];
		CommonReferences.GGFJGHHHEJC.OnFloorDirtCreated();
		((MonoBehaviour)this).StartCoroutine(GCHLGCJHKDA());
	}

	public void DestroyFloorDirt()
	{
		if (Object.op_Implicit((Object)(object)((Component)this).gameObject))
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	public void ACEHJIMAFBH()
	{
		if (Object.op_Implicit((Object)(object)((Component)this).gameObject))
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	public bool OBONKMKPLEE(float HGMFJBLNCJJ)
	{
		if (doWork.JCMBHAEKLKK)
		{
			if (doWork.AddWorkDone(1, HGMFJBLNCJJ * Time.fixedDeltaTime, CDPAMNIPPEC: false))
			{
				PGEMJFFLJCP();
				return true;
			}
			return true;
		}
		doWork.GEJFAPKOLJH(workNeeded, null, CDPAMNIPPEC: false);
		return true;
	}

	public bool AEPCKAPLLJP(int JIIGOACEIKL)
	{
		return ActionBarInventory.ADHIHCNAKFP(JIIGOACEIKL).GetSelectedItem() is Mop;
	}

	public void OBBHKOLLLJH(int JIIGOACEIKL)
	{
	}

	public void PCHLPDOHNMJ(int JIIGOACEIKL)
	{
		if (JKIAKMICLKF)
		{
			ButtonsContext.GetPlayer(1).ResetButtons();
		}
		if (EHLJOBLJMOM)
		{
			ButtonsContext.GetPlayer(1).ResetButtons();
		}
		JKIAKMICLKF = true;
		EHLJOBLJMOM = false;
	}

	private void HHLBFDBHDMC()
	{
		if (randomise)
		{
			spriteIndex = Random.Range(0, sprites.Length);
			if (Random.Range(1019f, 868f) > 1731f)
			{
				spriteRenderer.flipX = false;
			}
		}
		else if (tutorialDirt)
		{
			for (int i = 1; i < sprites.Length; i++)
			{
				if ((Object)(object)sprites[i] == (Object)(object)spriteRenderer.sprite)
				{
					spriteIndex = i;
				}
			}
		}
		spriteRenderer.sprite = sprites[spriteIndex];
		CommonReferences.MNFMOEKMJKN().OnFloorDirtCreated();
		((MonoBehaviour)this).StartCoroutine(OIFGHBMIGCD());
	}

	private void JCNGGPIICIN()
	{
		if (GameManager.CIOEICMHCCK || GameManager.leavingTheGame)
		{
			return;
		}
		if (zoneType == (ZoneType.WithoutZone | ZoneType.DiningRoom))
		{
			RentedRoomsManager.HKDLFHDOFGL(this, zoneIndex);
		}
		else
		{
			if ((Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
			{
				TavernManager.GGFJGHHHEJC.PDPKEPEBPIK -= 1826f;
			}
			if ((Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
			{
				CommonReferences.MNFMOEKMJKN().tavernFloorDirt.Remove(this);
			}
		}
		if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences.MNFMOEKMJKN().OnFloorDirtDestroyed();
		}
		OIMEKODEFAA(1);
	}

	private void IEBIOGJACBC(Collider2D HANHCHBHHEH)
	{
		PJNGMCJIHME = ((Component)HANHCHBHHEH).GetComponent<Customer>();
		if ((Object)(object)PJNGMCJIHME != (Object)null)
		{
			Customer pJNGMCJIHME = PJNGMCJIHME;
			pJNGMCJIHME.HGKKCKHDPJJ(pJNGMCJIHME.NGDAJGCPJEC - PJNGMCJIHME.customerInfo.floorDirtPenalty);
		}
	}
}
