using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;

public class CellarDoor : Door
{
	public enum Room
	{
		Cellar,
		Hallway
	}

	[CompilerGenerated]
	private sealed class FFHJANMDEPB : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool canOpenDoor;

		public CellarDoor _003C_003E4__this;

		public int playerNum;

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
		public FFHJANMDEPB(int _003C_003E1__state)
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
			CellarDoor cellarDoor = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				if (canOpenDoor)
				{
					_003C_003E2__current = CommonReferences.wait1;
					_003C_003E1__state = 1;
					return true;
				}
				break;
			case 1:
				_003C_003E1__state = -1;
				break;
			}
			cellarDoor.travelZone.StartTravelZone(playerNum);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnTravel = (Action<int>)Delegate.Combine(instance.OnTravel, new Action<int>(cellarDoor.BOMOLAANGHO));
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

	public Room roomTo;

	private Coroutine HCELENMMJDG;

	private int LBPALMBBIKM;

	private void GKLHDCCMDPN(int JIIGOACEIKL)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == LBPALMBBIKM)
		{
			HCELENMMJDG = null;
			PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
			if (base.ECMGCJGPKNO)
			{
				BCEFIALOMMJ();
				MultiAudioManager.PlayAudioObject(closeDoor, travelZone.NOJLAHMDNLB().GetRandomPosition());
			}
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnTravel = (Action<int>)Delegate.Remove(commonReferences.OnTravel, new Action<int>(KJDHIBCOJMI));
		}
	}

	private void GHDBHNMOBMN()
	{
		if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(ADGKMLOOMBG));
		}
		if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
		{
			OnlineLoadManager instance = OnlineLoadManager.instance;
			instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(FEMEFCNMOOL));
		}
	}

	private bool KHCIAMDHIAK()
	{
		if (!NIAJOGCHBKN())
		{
			return EPGBPGKLOHN();
		}
		return false;
	}

	private bool KGNDDFBMFJL()
	{
		if (!base.ECMGCJGPKNO)
		{
			return IsClosingOrOpening();
		}
		return true;
	}

	private IEnumerator BGFNJLBMFMO(int JIIGOACEIKL, bool HMECKFFFLGC)
	{
		if (HMECKFFFLGC)
		{
			yield return CommonReferences.wait1;
		}
		travelZone.StartTravelZone(JIIGOACEIKL);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnTravel = (Action<int>)Delegate.Combine(instance.OnTravel, new Action<int>(BOMOLAANGHO));
	}

	private void DMGOPJMKAIL(int JIIGOACEIKL)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == LBPALMBBIKM)
		{
			HCELENMMJDG = null;
			PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
			if (NIAJOGCHBKN())
			{
				OpenCloseTheDoor();
				MultiAudioManager.PlayAudioObject(closeDoor, travelZone.GetTravelZoneTo().GetRandomPosition());
			}
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnTravel = (Action<int>)Delegate.Remove(commonReferences.OnTravel, new Action<int>(DMGOPJMKAIL));
		}
	}

	private string JKDJHCHKBFJ(int JIIGOACEIKL)
	{
		return LocalisationSystem.Get("NewGameSetup");
	}

	private void OCPLOMJAFPC()
	{
		if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(MFBPGPKONNO));
		}
		if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
		{
			OnlineLoadManager instance = OnlineLoadManager.instance;
			instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(MFBPGPKONNO));
		}
	}

	private IEnumerator MEKMNMMBBCP(int JIIGOACEIKL, bool HMECKFFFLGC)
	{
		return new FFHJANMDEPB(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL,
			canOpenDoor = HMECKFFFLGC
		};
	}

	private void KJDHIBCOJMI(int JIIGOACEIKL)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == LBPALMBBIKM)
		{
			HCELENMMJDG = null;
			PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
			if (EHCJDLADLDI())
			{
				OpenCloseTheDoor();
				MultiAudioManager.PlayAudioObject(closeDoor, travelZone.GetTravelZoneTo().GetRandomPosition());
			}
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnTravel = (Action<int>)Delegate.Remove(commonReferences.OnTravel, new Action<int>(KGOLNEOEEPA));
		}
	}

	private string OHICLNMDGNN(int JIIGOACEIKL)
	{
		return LocalisationSystem.Get("Error in CatNPC.TeleToBed: ");
	}

	private string FHPKCOFINCL(int JIIGOACEIKL)
	{
		return LocalisationSystem.Get(" without doWork attached to OnlineObject");
	}

	private bool CONEJOJOPNJ()
	{
		if (!FEIJOJGEBHE())
		{
			return !EPGBPGKLOHN();
		}
		return false;
	}

	private bool NPFJHMLFNIB()
	{
		if (!NIAJOGCHBKN())
		{
			return MPHGAAMHLGM();
		}
		return true;
	}

	private string JAEMABIKNCF(int JIIGOACEIKL)
	{
		return LocalisationSystem.Get("LE_10");
	}

	private string EJIOCNHEIGP(int JIIGOACEIKL)
	{
		return LocalisationSystem.Get("ops");
	}

	private string GGDJLIEENOE(int JIIGOACEIKL)
	{
		return LocalisationSystem.Get("ReceiveObjectInteract");
	}

	private void NFDKGKCANIG()
	{
		try
		{
			placeable.itemSpace.Place(NMLKLAGDNPF: true, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private string KEDBFCFNBCA(int JIIGOACEIKL)
	{
		return LocalisationSystem.Get("Disappear");
	}

	private string MDCMHLJLCCP(int JIIGOACEIKL)
	{
		return LocalisationSystem.Get("Partida comprimida. Tiempo: ");
	}

	private void CGMFALLCMDF()
	{
		if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(NFDKGKCANIG));
		}
		if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
		{
			OnlineLoadManager instance = OnlineLoadManager.instance;
			instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(DFPDNPABDBG));
		}
	}

	private bool LLADMOBOPNK()
	{
		if (!base.ECMGCJGPKNO)
		{
			return !IPAHLGNLLIC();
		}
		return false;
	}

	private IEnumerator FKPAAOBFIAE(int JIIGOACEIKL, bool HMECKFFFLGC)
	{
		if (HMECKFFFLGC)
		{
			yield return CommonReferences.wait1;
		}
		travelZone.StartTravelZone(JIIGOACEIKL);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnTravel = (Action<int>)Delegate.Combine(instance.OnTravel, new Action<int>(BOMOLAANGHO));
	}

	private void NEJABGEEFJF()
	{
		try
		{
			placeable.itemSpace.OAIBPEEFIJB(NMLKLAGDNPF: false, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void GMLFGAKIEAD()
	{
		try
		{
			placeable.itemSpace.Place(NMLKLAGDNPF: true);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void KOGELMJFPCH()
	{
		try
		{
			placeable.itemSpace.Place(NMLKLAGDNPF: true, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private bool CBKELJKFBNA()
	{
		if (!base.ECMGCJGPKNO)
		{
			return IPAHLGNLLIC();
		}
		return true;
	}

	private void BFKAMFHNCFF(int JIIGOACEIKL)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == LBPALMBBIKM)
		{
			HCELENMMJDG = null;
			PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
			if (GIGOAOEHKBA())
			{
				BCEFIALOMMJ();
				MultiAudioManager.PlayAudioObject(closeDoor, travelZone.NOJLAHMDNLB().GetRandomPosition());
			}
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnTravel = (Action<int>)Delegate.Remove(commonReferences.OnTravel, new Action<int>(AGNPGAHOFOE));
		}
	}

	public override bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	private IEnumerator MKIDJHGOFKO(int JIIGOACEIKL, bool HMECKFFFLGC)
	{
		if (HMECKFFFLGC)
		{
			yield return CommonReferences.wait1;
		}
		travelZone.StartTravelZone(JIIGOACEIKL);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnTravel = (Action<int>)Delegate.Combine(instance.OnTravel, new Action<int>(BOMOLAANGHO));
	}

	private void AKPLLNELLJK()
	{
		if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(MFBPGPKONNO));
		}
		if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
		{
			OnlineLoadManager instance = OnlineLoadManager.instance;
			instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(GDBOOAEIMFP));
		}
	}

	private void AEDIIIAECIC()
	{
		if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
		{
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(ADGKMLOOMBG));
		}
		if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
		{
			OnlineLoadManager instance2 = OnlineLoadManager.instance;
			instance2.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance2.OnFinishedOnlineLoad, new Action(OCKPENPJODH));
		}
	}

	private void DIMNNFHAKIB(int JIIGOACEIKL)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == LBPALMBBIKM)
		{
			HCELENMMJDG = null;
			PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
			if (base.ECMGCJGPKNO)
			{
				HKNDBJPCFBF();
				MultiAudioManager.PlayAudioObject(closeDoor, travelZone.NOJLAHMDNLB().GetRandomPosition());
			}
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnTravel = (Action<int>)Delegate.Remove(instance.OnTravel, new Action<int>(DIMNNFHAKIB));
		}
	}

	private bool GEFBHIAPFFP()
	{
		if (!FEIJOJGEBHE())
		{
			return !DODAIOFHIEC();
		}
		return false;
	}

	private string CKMMDCBAAKC(int JIIGOACEIKL)
	{
		return LocalisationSystem.Get("Normal");
	}

	private void OJAJLIAMGEJ()
	{
		if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(JCFPPJDJOOJ));
		}
		if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
		{
			OnlineLoadManager instance = OnlineLoadManager.instance;
			instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(NEJABGEEFJF));
		}
	}

	private bool FGLHHOKDJIO()
	{
		if (!NIAJOGCHBKN())
		{
			return IsClosingOrOpening();
		}
		return true;
	}

	public override bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			if (roomTo == Room.Cellar)
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Cellar"));
			}
			else if (roomTo == Room.Hallway)
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("hallway"));
			}
			return true;
		}
		return false;
	}

	private void FIBOIODLMAG()
	{
		try
		{
			placeable.itemSpace.OAIBPEEFIJB(NMLKLAGDNPF: true, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void DKHCOKMIJME()
	{
		if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
		{
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(PHAGPPHHOKC));
		}
		if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
		{
			OnlineLoadManager instance2 = OnlineLoadManager.instance;
			instance2.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance2.OnFinishedOnlineLoad, new Action(PHAGPPHHOKC));
		}
	}

	private bool POOJMPKOLOL()
	{
		if (!GIGOAOEHKBA())
		{
			return EPGBPGKLOHN();
		}
		return false;
	}

	private void ANMIPNLGIHM()
	{
		if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
		{
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(PHAGPPHHOKC));
		}
		if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
		{
			OnlineLoadManager instance2 = OnlineLoadManager.instance;
			instance2.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance2.OnFinishedOnlineLoad, new Action(BGPGIOMKKAO));
		}
	}

	private void MNGDCOFANPC(int JIIGOACEIKL)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == LBPALMBBIKM)
		{
			HCELENMMJDG = null;
			PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
			if (base.ECMGCJGPKNO)
			{
				OpenCloseTheDoor();
				MultiAudioManager.PlayAudioObject(closeDoor, travelZone.KLEIGOKONOM().GetRandomPosition());
			}
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnTravel = (Action<int>)Delegate.Remove(commonReferences.OnTravel, new Action<int>(AAGBNGPCPGP));
		}
	}

	public override bool MouseUp(int JIIGOACEIKL)
	{
		if (PlayerInputs.GetPlayer(JIIGOACEIKL).mouseUpBlockers.Count > 0)
		{
			return false;
		}
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (roomTo == Room.Cellar && NewTutorialManager.CCCLOBIOMCL && (NewTutorialManager.GetCurrentPhaseID() < 106 || (NewTutorialManager.GetCurrentPhaseID() == 106 && !NewTutorialManager.instance.canEnterCellar)))
			{
				PlayerController.GetPlayer(1).PlayerBark("Player/Bark/Tutorial/CellarBlock");
				return true;
			}
			if (HCELENMMJDG == null)
			{
				bool flag = AHDNFCBBGFC();
				if (flag)
				{
					OpenCloseTheDoor();
				}
				HCELENMMJDG = ((MonoBehaviour)this).StartCoroutine(BGFNJLBMFMO(JIIGOACEIKL, flag));
				PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this);
				LBPALMBBIKM = JIIGOACEIKL;
				return true;
			}
		}
		return false;
	}

	private void INJNMCCGFIF()
	{
		try
		{
			placeable.itemSpace.OAIBPEEFIJB(NMLKLAGDNPF: false, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private IEnumerator BMMJPEBGEEG(int JIIGOACEIKL, bool HMECKFFFLGC)
	{
		return new FFHJANMDEPB(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL,
			canOpenDoor = HMECKFFFLGC
		};
	}

	private string NCLCBNBBIGE(int JIIGOACEIKL)
	{
		return LocalisationSystem.Get("KlaynTakingDrink: No barrel found for drink request: ");
	}

	private void BDMEBEOBEHC()
	{
		try
		{
			placeable.itemSpace.Place(NMLKLAGDNPF: true, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private bool EBDOIIPLHCE()
	{
		if (!base.ECMGCJGPKNO)
		{
			return MPHGAAMHLGM();
		}
		return true;
	}

	private void MBBEAMDHFFP(int JIIGOACEIKL)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == LBPALMBBIKM)
		{
			HCELENMMJDG = null;
			PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
			if (GIGOAOEHKBA())
			{
				HKNDBJPCFBF();
				MultiAudioManager.PlayAudioObject(closeDoor, travelZone.KLEIGOKONOM().GetRandomPosition());
			}
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnTravel = (Action<int>)Delegate.Remove(instance.OnTravel, new Action<int>(KJDHIBCOJMI));
		}
	}

	private string CHBLKGCIJNC(int JIIGOACEIKL)
	{
		return LocalisationSystem.Get("Items/item_description_1062");
	}

	private IEnumerator EOHKMOMBCCJ(int JIIGOACEIKL, bool HMECKFFFLGC)
	{
		if (HMECKFFFLGC)
		{
			yield return CommonReferences.wait1;
		}
		travelZone.StartTravelZone(JIIGOACEIKL);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnTravel = (Action<int>)Delegate.Combine(instance.OnTravel, new Action<int>(BOMOLAANGHO));
	}

	private IEnumerator ALBOPHKKLAJ(int JIIGOACEIKL, bool HMECKFFFLGC)
	{
		return new FFHJANMDEPB(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL,
			canOpenDoor = HMECKFFFLGC
		};
	}

	private string FHJGGAOEFLP(int JIIGOACEIKL)
	{
		return LocalisationSystem.Get("ReceiveConstructionModeOpened");
	}

	private void LALJNGFGKPA()
	{
		if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(ACNPANNGIFH));
		}
		if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
		{
			OnlineLoadManager instance = OnlineLoadManager.instance;
			instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(INJNMCCGFIF));
		}
	}

	private IEnumerator KGLIHFPKEMF(int JIIGOACEIKL, bool HMECKFFFLGC)
	{
		return new FFHJANMDEPB(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL,
			canOpenDoor = HMECKFFFLGC
		};
	}

	private bool FFHNGJLBDDO()
	{
		if (!NIAJOGCHBKN())
		{
			return MPHGAAMHLGM();
		}
		return false;
	}

	private bool GFMLAPNBJNL()
	{
		if (!AGJJEBPPPAC())
		{
			return !EPGBPGKLOHN();
		}
		return false;
	}

	private void GBKHKKJEGHP(int JIIGOACEIKL)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == LBPALMBBIKM)
		{
			HCELENMMJDG = null;
			PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
			if (FEIJOJGEBHE())
			{
				BCEFIALOMMJ();
				MultiAudioManager.PlayAudioObject(closeDoor, travelZone.GetTravelZoneTo().GetRandomPosition());
			}
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnTravel = (Action<int>)Delegate.Remove(instance.OnTravel, new Action<int>(OKMCNBBNGDF));
		}
	}

	private void OCKPENPJODH()
	{
		try
		{
			placeable.itemSpace.Place(NMLKLAGDNPF: true, KBNNPAKJDJM: true);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private string JKJONFKIKIP(int JIIGOACEIKL)
	{
		return LocalisationSystem.Get("CellarUnlockMessage");
	}

	private void DDJGHPFELOF(int JIIGOACEIKL)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == LBPALMBBIKM)
		{
			HCELENMMJDG = null;
			PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
			if (EHCJDLADLDI())
			{
				PPIMCKBHPAG();
				MultiAudioManager.PlayAudioObject(closeDoor, travelZone.ANOLFMAPJJH().GetRandomPosition());
			}
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnTravel = (Action<int>)Delegate.Remove(instance.OnTravel, new Action<int>(DIMNNFHAKIB));
		}
	}

	private void JCNGGPIICIN()
	{
		if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(DFPDNPABDBG));
		}
		if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
		{
			OnlineLoadManager instance = OnlineLoadManager.instance;
			instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(EFBEKNLOILH));
		}
	}

	private void LADLGPKMPBP()
	{
		if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
		{
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(GMLFGAKIEAD));
		}
		if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
		{
			OnlineLoadManager instance2 = OnlineLoadManager.instance;
			instance2.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance2.OnFinishedOnlineLoad, new Action(BEANNEHDDJB));
		}
	}

	private bool MOAEJNJGHFE()
	{
		if (!NIAJOGCHBKN())
		{
			return MPHGAAMHLGM();
		}
		return false;
	}

	private void IJHMHHHLPKO()
	{
		try
		{
			placeable.itemSpace.Place(NMLKLAGDNPF: true, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private bool NKPLJPCOAAD()
	{
		if (!FEIJOJGEBHE())
		{
			return !IsClosingOrOpening();
		}
		return false;
	}

	private void JNKKJELMCNN()
	{
		if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(BDMEBEOBEHC));
		}
		if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
		{
			OnlineLoadManager instance = OnlineLoadManager.instance;
			instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(OPIHPIJFDOP));
		}
	}

	private void DFPDNPABDBG()
	{
		try
		{
			placeable.itemSpace.Place(NMLKLAGDNPF: false, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void ACNPANNGIFH()
	{
		try
		{
			placeable.itemSpace.OAIBPEEFIJB(NMLKLAGDNPF: false, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private IEnumerator GIOJKNPENNE(int JIIGOACEIKL, bool HMECKFFFLGC)
	{
		if (HMECKFFFLGC)
		{
			yield return CommonReferences.wait1;
		}
		travelZone.StartTravelZone(JIIGOACEIKL);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnTravel = (Action<int>)Delegate.Combine(instance.OnTravel, new Action<int>(BOMOLAANGHO));
	}

	public override bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (!OnlineManager.PlayingOnline() && !AHDNFCBBGFC())
		{
			return false;
		}
		return base.IsAvailableByProximity(JIIGOACEIKL);
	}

	private void OnDestroy()
	{
		if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
		{
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(BGPGIOMKKAO));
		}
		if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
		{
			OnlineLoadManager instance2 = OnlineLoadManager.instance;
			instance2.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance2.OnFinishedOnlineLoad, new Action(BGPGIOMKKAO));
		}
	}

	private void FCLMPKFKMEF()
	{
		try
		{
			placeable.itemSpace.Place(NMLKLAGDNPF: false);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void HFKOBCFMNJJ()
	{
		if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(INJNMCCGFIF));
		}
		if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
		{
			OnlineLoadManager instance = OnlineLoadManager.instance;
			instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(ADGKMLOOMBG));
		}
	}

	private void NOILIOLOOBJ()
	{
		if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
		{
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(ADGKMLOOMBG));
		}
		if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
		{
			OnlineLoadManager instance2 = OnlineLoadManager.instance;
			instance2.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance2.OnFinishedOnlineLoad, new Action(BGPGIOMKKAO));
		}
	}

	private IEnumerator PKIENLEKDDC(int JIIGOACEIKL, bool HMECKFFFLGC)
	{
		if (HMECKFFFLGC)
		{
			yield return CommonReferences.wait1;
		}
		travelZone.StartTravelZone(JIIGOACEIKL);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnTravel = (Action<int>)Delegate.Combine(instance.OnTravel, new Action<int>(BOMOLAANGHO));
	}

	private void MFBPGPKONNO()
	{
		try
		{
			placeable.itemSpace.Place(NMLKLAGDNPF: false, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void GCCEONGMOIE(int JIIGOACEIKL)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == LBPALMBBIKM)
		{
			HCELENMMJDG = null;
			PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
			if (FEIJOJGEBHE())
			{
				JDHOOAABPMJ();
				MultiAudioManager.PlayAudioObject(closeDoor, travelZone.GetTravelZoneTo().GetRandomPosition());
			}
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnTravel = (Action<int>)Delegate.Remove(instance.OnTravel, new Action<int>(MBBEAMDHFFP));
		}
	}

	private string NOJHJIFCNCH(int JIIGOACEIKL)
	{
		return LocalisationSystem.Get("GOG ");
	}

	private string PPHCPGDBJHI(int JIIGOACEIKL)
	{
		return LocalisationSystem.Get("NoEresDigno/MainEvent");
	}

	private void JCFPPJDJOOJ()
	{
		try
		{
			placeable.itemSpace.OAIBPEEFIJB(NMLKLAGDNPF: false, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void HKJDCBMGCMK(int JIIGOACEIKL)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == LBPALMBBIKM)
		{
			HCELENMMJDG = null;
			PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
			if (NIAJOGCHBKN())
			{
				PPIMCKBHPAG();
				MultiAudioManager.PlayAudioObject(closeDoor, travelZone.NOJLAHMDNLB().GetRandomPosition());
			}
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnTravel = (Action<int>)Delegate.Remove(instance.OnTravel, new Action<int>(KOKJHBFFLCJ));
		}
	}

	private void HHMBCKCNPPN()
	{
		if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
		{
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(OCKPENPJODH));
		}
		if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
		{
			OnlineLoadManager instance2 = OnlineLoadManager.instance;
			instance2.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance2.OnFinishedOnlineLoad, new Action(EFBEKNLOILH));
		}
	}

	private IEnumerator LDFJNKICGKM(int JIIGOACEIKL, bool HMECKFFFLGC)
	{
		if (HMECKFFFLGC)
		{
			yield return CommonReferences.wait1;
		}
		travelZone.StartTravelZone(JIIGOACEIKL);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnTravel = (Action<int>)Delegate.Combine(instance.OnTravel, new Action<int>(BOMOLAANGHO));
	}

	private IEnumerator IJBLLNILBGN(int JIIGOACEIKL, bool HMECKFFFLGC)
	{
		return new FFHJANMDEPB(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL,
			canOpenDoor = HMECKFFFLGC
		};
	}

	private void BGPGIOMKKAO()
	{
		try
		{
			placeable.itemSpace.Place(NMLKLAGDNPF: true, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private string MJDEEGJJBKI(int JIIGOACEIKL)
	{
		return LocalisationSystem.Get("ChristmasPresent");
	}

	private string JFCIKEEAFGN(int JIIGOACEIKL)
	{
		return LocalisationSystem.Get("");
	}

	private void ADGKMLOOMBG()
	{
		try
		{
			placeable.itemSpace.Place(NMLKLAGDNPF: false, KBNNPAKJDJM: true);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void KOKJHBFFLCJ(int JIIGOACEIKL)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == LBPALMBBIKM)
		{
			HCELENMMJDG = null;
			PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
			if (EHCJDLADLDI())
			{
				OpenCloseTheDoor();
				MultiAudioManager.PlayAudioObject(closeDoor, travelZone.ANOLFMAPJJH().GetRandomPosition());
			}
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnTravel = (Action<int>)Delegate.Remove(commonReferences.OnTravel, new Action<int>(PHHGFKFOMPC));
		}
	}

	private void OKMCNBBNGDF(int JIIGOACEIKL)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == LBPALMBBIKM)
		{
			HCELENMMJDG = null;
			PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
			if (NIAJOGCHBKN())
			{
				HKNDBJPCFBF();
				MultiAudioManager.PlayAudioObject(closeDoor, travelZone.ANOLFMAPJJH().GetRandomPosition());
			}
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnTravel = (Action<int>)Delegate.Remove(instance.OnTravel, new Action<int>(DMGOPJMKAIL));
		}
	}

	private void JNJCCIFIKOC()
	{
		if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
		{
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(IJHMHHHLPKO));
		}
		if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
		{
			OnlineLoadManager instance2 = OnlineLoadManager.instance;
			instance2.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance2.OnFinishedOnlineLoad, new Action(KOGELMJFPCH));
		}
	}

	private void GDBOOAEIMFP()
	{
		try
		{
			placeable.itemSpace.Place(NMLKLAGDNPF: false, KBNNPAKJDJM: true);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void CEIEOCICPMB(int JIIGOACEIKL)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == LBPALMBBIKM)
		{
			HCELENMMJDG = null;
			PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
			if (GIGOAOEHKBA())
			{
				PPIMCKBHPAG();
				MultiAudioManager.PlayAudioObject(closeDoor, travelZone.NOJLAHMDNLB().GetRandomPosition());
			}
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnTravel = (Action<int>)Delegate.Remove(instance.OnTravel, new Action<int>(KJDHIBCOJMI));
		}
	}

	private void NJFDKCMBMDH()
	{
		if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(OPIHPIJFDOP));
		}
		if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
		{
			OnlineLoadManager instance = OnlineLoadManager.instance;
			instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(ACNPANNGIFH));
		}
	}

	private bool NAFMADLLCFO()
	{
		if (!base.ECMGCJGPKNO)
		{
			return EPGBPGKLOHN();
		}
		return false;
	}

	private void OPIHPIJFDOP()
	{
		try
		{
			placeable.itemSpace.OAIBPEEFIJB(NMLKLAGDNPF: false, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void KPILPDFCHBG()
	{
		if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(GDBOOAEIMFP));
		}
		if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
		{
			OnlineLoadManager instance = OnlineLoadManager.instance;
			instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(DFPDNPABDBG));
		}
	}

	private void CDFMNDEKBJE()
	{
		if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(GMLFGAKIEAD));
		}
		if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
		{
			OnlineLoadManager instance = OnlineLoadManager.instance;
			instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(NNODOACIKOO));
		}
	}

	private void BOMOLAANGHO(int JIIGOACEIKL)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == LBPALMBBIKM)
		{
			HCELENMMJDG = null;
			PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
			if (base.ECMGCJGPKNO)
			{
				OpenCloseTheDoor();
				MultiAudioManager.PlayAudioObject(closeDoor, travelZone.GetTravelZoneTo().GetRandomPosition());
			}
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnTravel = (Action<int>)Delegate.Remove(instance.OnTravel, new Action<int>(BOMOLAANGHO));
		}
	}

	private void BEANNEHDDJB()
	{
		try
		{
			placeable.itemSpace.OAIBPEEFIJB(NMLKLAGDNPF: false, KBNNPAKJDJM: true);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private string IDCNLGPNOJE(int JIIGOACEIKL)
	{
		return LocalisationSystem.Get(" ");
	}

	private void PHAGPPHHOKC()
	{
		try
		{
			placeable.itemSpace.OAIBPEEFIJB(NMLKLAGDNPF: false, KBNNPAKJDJM: true);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private bool BNPDPEAHDFH()
	{
		if (!EHCJDLADLDI())
		{
			return !IsClosingOrOpening();
		}
		return true;
	}

	private void AGNPGAHOFOE(int JIIGOACEIKL)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == LBPALMBBIKM)
		{
			HCELENMMJDG = null;
			PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
			if (AGJJEBPPPAC())
			{
				BCEFIALOMMJ();
				MultiAudioManager.PlayAudioObject(closeDoor, travelZone.ANOLFMAPJJH().GetRandomPosition());
			}
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnTravel = (Action<int>)Delegate.Remove(commonReferences.OnTravel, new Action<int>(KOKJHBFFLCJ));
		}
	}

	private void AAGBNGPCPGP(int JIIGOACEIKL)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == LBPALMBBIKM)
		{
			HCELENMMJDG = null;
			PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
			if (GIGOAOEHKBA())
			{
				HKNDBJPCFBF();
				MultiAudioManager.PlayAudioObject(closeDoor, travelZone.NOJLAHMDNLB().GetRandomPosition());
			}
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnTravel = (Action<int>)Delegate.Remove(instance.OnTravel, new Action<int>(KOKJHBFFLCJ));
		}
	}

	private void ANHOOODHPKD()
	{
		if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(GMLFGAKIEAD));
		}
		if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
		{
			OnlineLoadManager instance = OnlineLoadManager.instance;
			instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(BGPGIOMKKAO));
		}
	}

	private IEnumerator IGDEFEEPHEK(int JIIGOACEIKL, bool HMECKFFFLGC)
	{
		if (HMECKFFFLGC)
		{
			yield return CommonReferences.wait1;
		}
		travelZone.StartTravelZone(JIIGOACEIKL);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnTravel = (Action<int>)Delegate.Combine(instance.OnTravel, new Action<int>(BOMOLAANGHO));
	}

	private void KGOLNEOEEPA(int JIIGOACEIKL)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == LBPALMBBIKM)
		{
			HCELENMMJDG = null;
			PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
			if (base.ECMGCJGPKNO)
			{
				OpenCloseTheDoor();
				MultiAudioManager.PlayAudioObject(closeDoor, travelZone.KLEIGOKONOM().GetRandomPosition());
			}
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnTravel = (Action<int>)Delegate.Remove(instance.OnTravel, new Action<int>(DENJHPKNFMO));
		}
	}

	private void CHPLGADBAGD()
	{
		if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(ACNPANNGIFH));
		}
		if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
		{
			OnlineLoadManager instance = OnlineLoadManager.instance;
			instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(NFDKGKCANIG));
		}
	}

	private void AANKFMNMCJN()
	{
		try
		{
			placeable.itemSpace.OAIBPEEFIJB(NMLKLAGDNPF: false, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private bool AHDNFCBBGFC()
	{
		if (!base.ECMGCJGPKNO)
		{
			return !IsClosingOrOpening();
		}
		return false;
	}

	private void DENJHPKNFMO(int JIIGOACEIKL)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == LBPALMBBIKM)
		{
			HCELENMMJDG = null;
			PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
			if (EHCJDLADLDI())
			{
				BCEFIALOMMJ();
				MultiAudioManager.PlayAudioObject(closeDoor, travelZone.KLEIGOKONOM().GetRandomPosition());
			}
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnTravel = (Action<int>)Delegate.Remove(commonReferences.OnTravel, new Action<int>(OKMCNBBNGDF));
		}
	}

	private string LJEOEKLJINL(int JIIGOACEIKL)
	{
		return LocalisationSystem.Get("DecorationTile_16");
	}

	private IEnumerator KKIEAKFIDAP(int JIIGOACEIKL, bool HMECKFFFLGC)
	{
		if (HMECKFFFLGC)
		{
			yield return CommonReferences.wait1;
		}
		travelZone.StartTravelZone(JIIGOACEIKL);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnTravel = (Action<int>)Delegate.Combine(instance.OnTravel, new Action<int>(BOMOLAANGHO));
	}

	private IEnumerator EIGPFEIJAMI(int JIIGOACEIKL, bool HMECKFFFLGC)
	{
		if (HMECKFFFLGC)
		{
			yield return CommonReferences.wait1;
		}
		travelZone.StartTravelZone(JIIGOACEIKL);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnTravel = (Action<int>)Delegate.Combine(instance.OnTravel, new Action<int>(BOMOLAANGHO));
	}

	private string CLPJBFKLALL(int JIIGOACEIKL)
	{
		return LocalisationSystem.Get(" / ");
	}

	private void HEGNINLLINP()
	{
		if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
		{
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(INJNMCCGFIF));
		}
		if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
		{
			OnlineLoadManager instance2 = OnlineLoadManager.instance;
			instance2.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance2.OnFinishedOnlineLoad, new Action(FEMEFCNMOOL));
		}
	}

	private IEnumerator PIFLGKIPNDD(int JIIGOACEIKL, bool HMECKFFFLGC)
	{
		return new FFHJANMDEPB(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL,
			canOpenDoor = HMECKFFFLGC
		};
	}

	private string LBIIIEDONJA(int JIIGOACEIKL)
	{
		return LocalisationSystem.Get("");
	}

	private bool GAGIFCOAGFE()
	{
		if (!FEIJOJGEBHE())
		{
			return !IPAHLGNLLIC();
		}
		return true;
	}

	private bool JMKPOCNLKGA()
	{
		if (!base.ECMGCJGPKNO)
		{
			return EPGBPGKLOHN();
		}
		return false;
	}

	private bool GFMAOGCFOEB()
	{
		if (!EHCJDLADLDI())
		{
			return !EPGBPGKLOHN();
		}
		return false;
	}

	protected override void Start()
	{
		base.Start();
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(BGPGIOMKKAO));
		OnlineLoadManager instance2 = OnlineLoadManager.instance;
		instance2.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance2.OnFinishedOnlineLoad, new Action(BGPGIOMKKAO));
	}

	private string GJCFCOICAKO(int JIIGOACEIKL)
	{
		return LocalisationSystem.Get("/BarkMai");
	}

	private void PCEFNHADDIG()
	{
		if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(MFBPGPKONNO));
		}
		if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
		{
			OnlineLoadManager instance = OnlineLoadManager.instance;
			instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(INJNMCCGFIF));
		}
	}

	private void FEMEFCNMOOL()
	{
		try
		{
			placeable.itemSpace.OAIBPEEFIJB(NMLKLAGDNPF: false, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void HPMFOHOMLDO()
	{
		if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
		{
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(FIBOIODLMAG));
		}
		if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
		{
			OnlineLoadManager instance2 = OnlineLoadManager.instance;
			instance2.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance2.OnFinishedOnlineLoad, new Action(PHAGPPHHOKC));
		}
	}

	private void EFBEKNLOILH()
	{
		try
		{
			placeable.itemSpace.OAIBPEEFIJB(NMLKLAGDNPF: false, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private string AMGMMJEMIHA(int JIIGOACEIKL)
	{
		return LocalisationSystem.Get(" ");
	}

	private void DGOGKLMHJEG()
	{
		if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(KOGELMJFPCH));
		}
		if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
		{
			OnlineLoadManager instance = OnlineLoadManager.instance;
			instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(OPIHPIJFDOP));
		}
	}

	private void JOGBCDIAGEK()
	{
		if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
		{
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(GLCOOIIJCMH));
		}
		if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
		{
			OnlineLoadManager instance2 = OnlineLoadManager.instance;
			instance2.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance2.OnFinishedOnlineLoad, new Action(FEMEFCNMOOL));
		}
	}

	private string NNCGJHCHHOP(int JIIGOACEIKL)
	{
		return LocalisationSystem.Get("CurrentZoomIndex: ");
	}

	private string GHAIPIDPLLL(int JIIGOACEIKL)
	{
		return LocalisationSystem.Get("UIBack");
	}

	private string DHLEFAAEJDH(int JIIGOACEIKL)
	{
		return LocalisationSystem.Get("A network prefab has not been set up properly");
	}

	private void GLCOOIIJCMH()
	{
		try
		{
			placeable.itemSpace.Place(NMLKLAGDNPF: true);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private string LLABCGOEPJB(int JIIGOACEIKL)
	{
		return LocalisationSystem.Get("Happy");
	}

	private void NNODOACIKOO()
	{
		try
		{
			placeable.itemSpace.Place(NMLKLAGDNPF: true);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void DFFDKIPCCKK()
	{
		if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
		{
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(JCFPPJDJOOJ));
		}
		if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
		{
			OnlineLoadManager instance2 = OnlineLoadManager.instance;
			instance2.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance2.OnFinishedOnlineLoad, new Action(GLCOOIIJCMH));
		}
	}

	private string DOLNBOJCLGF(int JIIGOACEIKL)
	{
		return LocalisationSystem.Get("player");
	}

	private void HLHHDNGOGNI()
	{
		if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(NNODOACIKOO));
		}
		if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
		{
			OnlineLoadManager instance = OnlineLoadManager.instance;
			instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(FCLMPKFKMEF));
		}
	}

	private void PHHGFKFOMPC(int JIIGOACEIKL)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == LBPALMBBIKM)
		{
			HCELENMMJDG = null;
			PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
			if (GIGOAOEHKBA())
			{
				BCEFIALOMMJ();
				MultiAudioManager.PlayAudioObject(closeDoor, travelZone.ANOLFMAPJJH().GetRandomPosition());
			}
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnTravel = (Action<int>)Delegate.Remove(commonReferences.OnTravel, new Action<int>(GBKHKKJEGHP));
		}
	}

	private void NCNGPFDFPKA()
	{
		if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(MFBPGPKONNO));
		}
		if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
		{
			OnlineLoadManager instance = OnlineLoadManager.instance;
			instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(MFBPGPKONNO));
		}
	}

	private void KCJKDPNIEIP(int JIIGOACEIKL)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == LBPALMBBIKM)
		{
			HCELENMMJDG = null;
			PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
			if (NIAJOGCHBKN())
			{
				HKNDBJPCFBF();
				MultiAudioManager.PlayAudioObject(closeDoor, travelZone.NOJLAHMDNLB().GetRandomPosition());
			}
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnTravel = (Action<int>)Delegate.Remove(instance.OnTravel, new Action<int>(KOKJHBFFLCJ));
		}
	}

	private void GDPPGLPHJHK(int JIIGOACEIKL)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == LBPALMBBIKM)
		{
			HCELENMMJDG = null;
			PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
			if (EHCJDLADLDI())
			{
				BCEFIALOMMJ();
				MultiAudioManager.PlayAudioObject(closeDoor, travelZone.GetTravelZoneTo().GetRandomPosition());
			}
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnTravel = (Action<int>)Delegate.Remove(instance.OnTravel, new Action<int>(CEIEOCICPMB));
		}
	}

	private IEnumerator AAGJMBCOHLM(int JIIGOACEIKL, bool HMECKFFFLGC)
	{
		if (HMECKFFFLGC)
		{
			yield return CommonReferences.wait1;
		}
		travelZone.StartTravelZone(JIIGOACEIKL);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnTravel = (Action<int>)Delegate.Combine(instance.OnTravel, new Action<int>(BOMOLAANGHO));
	}

	private bool HGFBALKLFPB()
	{
		if (!AGJJEBPPPAC())
		{
			return !EPGBPGKLOHN();
		}
		return false;
	}
}
