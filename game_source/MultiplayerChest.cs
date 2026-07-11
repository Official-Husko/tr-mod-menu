using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using Photon.Pun;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class MultiplayerChest : MonoBehaviour, IInteractable, ISelectable, IProximity, IHoverable
{
	[CompilerGenerated]
	private sealed class DHKONHGEOBB : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MultiplayerChest _003C_003E4__this;

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
		public DHKONHGEOBB(int _003C_003E1__state)
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
			MultiplayerChest multiplayerChest = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				if (multiplayerChest.hasAnimation)
				{
					multiplayerChest.NKEMALMMOBL = true;
					MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.closeDoor, ((Component)multiplayerChest).transform);
					_003C_003E2__current = ((MonoBehaviour)multiplayerChest).StartCoroutine(Utils.OBCEOGNEFPD(multiplayerChest.animationSprites, multiplayerChest.doorSpriteRenderer, multiplayerChest.frameRate));
					_003C_003E1__state = 1;
					return true;
				}
				break;
			case 1:
				_003C_003E1__state = -1;
				multiplayerChest.NKEMALMMOBL = false;
				break;
			}
			multiplayerChest.KCLDPDNCNOA = false;
			if (Object.op_Implicit((Object)(object)multiplayerChest.placeable))
			{
				multiplayerChest.placeable.selectBlockers.Remove(multiplayerChest.MFHACMAHGHC);
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

	[CompilerGenerated]
	private sealed class ECBCMLOHKJD : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MultiplayerChest _003C_003E4__this;

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
		public ECBCMLOHKJD(int _003C_003E1__state)
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
			MultiplayerChest multiplayerChest = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				Sound.GGFJGHHHEJC.PlayOpenSound(OpenSound.Wood, ((Component)multiplayerChest).transform);
				if (multiplayerChest.hasAnimation)
				{
					_003C_003E2__current = ((MonoBehaviour)multiplayerChest).StartCoroutine(Utils.KAHHFCFDJIK(playerNum, multiplayerChest.frameRate, multiplayerChest.animationSprites, multiplayerChest.doorSpriteRenderer, (MonoBehaviour)(object)multiplayerChest));
					_003C_003E1__state = 1;
					return true;
				}
				break;
			case 1:
				_003C_003E1__state = -1;
				break;
			}
			if (!multiplayerChest.NKEMALMMOBL)
			{
				if (Object.op_Implicit((Object)(object)multiplayerChest.placeable) && !multiplayerChest.placeable.selectBlockers.Contains(multiplayerChest.MFHACMAHGHC))
				{
					multiplayerChest.placeable.selectBlockers.Add(multiplayerChest.MFHACMAHGHC);
				}
				if (!SmallContainerUI.Get(playerNum).IsOpen())
				{
					InteractObject.GetPlayer(playerNum).interactingObject = ((Component)multiplayerChest).gameObject;
					if (OnlineManager.MasterOrOffline())
					{
						BigContainerUI.Get(playerNum).SetContainer(Inventory.GetPlayer(multiplayerChest.id, LAGHIOKLJGH: false, ADPNMHGBFKG: true));
						BigContainerUI.Get(playerNum).FillSlots(PlayerInventory.GetPlayer(multiplayerChest.id, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetAllSlots(), null, IFMNAFDGKKK: true, OGCAKIGELBJ: false, 5);
						multiplayerChest.MCMCNOOHKPE(playerNum);
					}
					else
					{
						OnlineSlotsManager.instance.RequestPlayerInventory(PhotonNetwork.LocalPlayer.ActorNumber, multiplayerChest.id);
						OnlineSlotsManager instance = OnlineSlotsManager.instance;
						instance.OnRecivePlayerInventory = (Action)Delegate.Combine(instance.OnRecivePlayerInventory, new Action(multiplayerChest.HHLPFDOMAIC));
					}
				}
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

	private static MultiplayerChest[] MLECCLAILFE = new MultiplayerChest[5];

	public int id;

	[SerializeField]
	private Placeable placeable;

	private float PPMHCOBKMCN;

	private float LINBLNKCFBB;

	[SerializeField]
	private OpenSound openSound;

	public bool hasAnimation;

	public float frameRate = 0.125f;

	public SpriteRenderer doorSpriteRenderer;

	public Sprite[] animationSprites;

	private bool KCLDPDNCNOA;

	private bool NKEMALMMOBL;

	private string MFHACMAHGHC = "Output is not ready";

	public bool HPPHMKMDKEG(int JIIGOACEIKL)
	{
		if (Object.op_Implicit((Object)(object)placeable) && placeable.FHEMHCEAICB)
		{
			return true;
		}
		return !DecorationMode.NPANPNIDKDG(JIIGOACEIKL).GABNNLJOMHI();
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public void MLOBKOONNMH(int JIIGOACEIKL)
	{
	}

	public IEnumerator HMBEOELLFPF(int JIIGOACEIKL)
	{
		Sound.GGFJGHHHEJC.PlayOpenSound(OpenSound.Wood, ((Component)this).transform);
		if (hasAnimation)
		{
			yield return ((MonoBehaviour)this).StartCoroutine(Utils.KAHHFCFDJIK(JIIGOACEIKL, frameRate, animationSprites, doorSpriteRenderer, (MonoBehaviour)(object)this));
		}
		if (NKEMALMMOBL)
		{
			yield break;
		}
		if (Object.op_Implicit((Object)(object)placeable) && !placeable.selectBlockers.Contains(MFHACMAHGHC))
		{
			placeable.selectBlockers.Add(MFHACMAHGHC);
		}
		if (!SmallContainerUI.Get(JIIGOACEIKL).IsOpen())
		{
			InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
			if (OnlineManager.MasterOrOffline())
			{
				BigContainerUI.Get(JIIGOACEIKL).SetContainer(Inventory.GetPlayer(id, LAGHIOKLJGH: false, ADPNMHGBFKG: true));
				BigContainerUI.Get(JIIGOACEIKL).FillSlots(PlayerInventory.GetPlayer(id, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetAllSlots(), null, IFMNAFDGKKK: true, OGCAKIGELBJ: false, 5);
				MCMCNOOHKPE(JIIGOACEIKL);
			}
			else
			{
				OnlineSlotsManager.instance.RequestPlayerInventory(PhotonNetwork.LocalPlayer.ActorNumber, id);
				OnlineSlotsManager instance = OnlineSlotsManager.instance;
				instance.OnRecivePlayerInventory = (Action)Delegate.Combine(instance.OnRecivePlayerInventory, new Action(HHLPFDOMAIC));
			}
		}
	}

	public bool BJFECJMIPMB(int JIIGOACEIKL)
	{
		return false;
	}

	public void GIIDCCEDHOF(int JIIGOACEIKL)
	{
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public IEnumerator OpenContainer(int JIIGOACEIKL)
	{
		Sound.GGFJGHHHEJC.PlayOpenSound(OpenSound.Wood, ((Component)this).transform);
		if (hasAnimation)
		{
			yield return ((MonoBehaviour)this).StartCoroutine(Utils.KAHHFCFDJIK(JIIGOACEIKL, frameRate, animationSprites, doorSpriteRenderer, (MonoBehaviour)(object)this));
		}
		if (NKEMALMMOBL)
		{
			yield break;
		}
		if (Object.op_Implicit((Object)(object)placeable) && !placeable.selectBlockers.Contains(MFHACMAHGHC))
		{
			placeable.selectBlockers.Add(MFHACMAHGHC);
		}
		if (!SmallContainerUI.Get(JIIGOACEIKL).IsOpen())
		{
			InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
			if (OnlineManager.MasterOrOffline())
			{
				BigContainerUI.Get(JIIGOACEIKL).SetContainer(Inventory.GetPlayer(id, LAGHIOKLJGH: false, ADPNMHGBFKG: true));
				BigContainerUI.Get(JIIGOACEIKL).FillSlots(PlayerInventory.GetPlayer(id, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetAllSlots(), null, IFMNAFDGKKK: true, OGCAKIGELBJ: false, 5);
				MCMCNOOHKPE(JIIGOACEIKL);
			}
			else
			{
				OnlineSlotsManager.instance.RequestPlayerInventory(PhotonNetwork.LocalPlayer.ActorNumber, id);
				OnlineSlotsManager instance = OnlineSlotsManager.instance;
				instance.OnRecivePlayerInventory = (Action)Delegate.Combine(instance.OnRecivePlayerInventory, new Action(HHLPFDOMAIC));
			}
		}
	}

	public bool NLJKBACPIFA(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool GBELEBJJDIN(int JIIGOACEIKL)
	{
		return true;
	}

	public void HPLHMNAIEMF(int JIIGOACEIKL)
	{
	}

	public static MultiplayerChest GetPlayer(int JIIGOACEIKL)
	{
		return MLECCLAILFE[JIIGOACEIKL];
	}

	public void FJBPHNEBDEP(int JIIGOACEIKL)
	{
	}

	public IEnumerator LJCHCABCCHP()
	{
		if (hasAnimation)
		{
			NKEMALMMOBL = true;
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.closeDoor, ((Component)this).transform);
			yield return ((MonoBehaviour)this).StartCoroutine(Utils.OBCEOGNEFPD(animationSprites, doorSpriteRenderer, frameRate));
			NKEMALMMOBL = false;
		}
		KCLDPDNCNOA = false;
		if (Object.op_Implicit((Object)(object)placeable))
		{
			placeable.selectBlockers.Remove(MFHACMAHGHC);
		}
	}

	public bool PBEPBBPAFOH(int JIIGOACEIKL)
	{
		return false;
	}

	public IEnumerator DNOPBECHHLL(int JIIGOACEIKL)
	{
		Sound.GGFJGHHHEJC.PlayOpenSound(OpenSound.Wood, ((Component)this).transform);
		if (hasAnimation)
		{
			yield return ((MonoBehaviour)this).StartCoroutine(Utils.KAHHFCFDJIK(JIIGOACEIKL, frameRate, animationSprites, doorSpriteRenderer, (MonoBehaviour)(object)this));
		}
		if (NKEMALMMOBL)
		{
			yield break;
		}
		if (Object.op_Implicit((Object)(object)placeable) && !placeable.selectBlockers.Contains(MFHACMAHGHC))
		{
			placeable.selectBlockers.Add(MFHACMAHGHC);
		}
		if (!SmallContainerUI.Get(JIIGOACEIKL).IsOpen())
		{
			InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
			if (OnlineManager.MasterOrOffline())
			{
				BigContainerUI.Get(JIIGOACEIKL).SetContainer(Inventory.GetPlayer(id, LAGHIOKLJGH: false, ADPNMHGBFKG: true));
				BigContainerUI.Get(JIIGOACEIKL).FillSlots(PlayerInventory.GetPlayer(id, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetAllSlots(), null, IFMNAFDGKKK: true, OGCAKIGELBJ: false, 5);
				MCMCNOOHKPE(JIIGOACEIKL);
			}
			else
			{
				OnlineSlotsManager.instance.RequestPlayerInventory(PhotonNetwork.LocalPlayer.ActorNumber, id);
				OnlineSlotsManager instance = OnlineSlotsManager.instance;
				instance.OnRecivePlayerInventory = (Action)Delegate.Combine(instance.OnRecivePlayerInventory, new Action(HHLPFDOMAIC));
			}
		}
	}

	public void BEBLOHAFHNO(int JIIGOACEIKL)
	{
	}

	public void CDNPCGKAGLI(int JIIGOACEIKL)
	{
	}

	public bool KDGAIGKBPAC(int JIIGOACEIKL)
	{
		if (Object.op_Implicit((Object)(object)placeable) && placeable.FHEMHCEAICB)
		{
			return false;
		}
		return !DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).DFNMDDHOIJI();
	}

	public IEnumerator JNNENMMHODO()
	{
		return new DHKONHGEOBB(1)
		{
			_003C_003E4__this = this
		};
	}

	public void OHONHNNDOKC(int JIIGOACEIKL)
	{
	}

	public bool PPJFDGOOIDK(int JIIGOACEIKL)
	{
		if (Object.op_Implicit((Object)(object)placeable) && placeable.FHEMHCEAICB)
		{
			return false;
		}
		return DecorationMode.FIHGMLABOBB(JIIGOACEIKL).DFNMDDHOIJI();
	}

	private void DPDBMJCOLJC()
	{
		BigContainerUI.PHDBJGOEKHB(0).MINCILKHEIB(Inventory.GetPlayer(id, LAGHIOKLJGH: true));
		BigContainerUI.FHBIFJNCOAI(0).BCPBALLMBJD(PlayerInventory.GetPlayer(id, LAGHIOKLJGH: true, ADPNMHGBFKG: true).OMCMMDDGHFB(), null, IFMNAFDGKKK: true, OGCAKIGELBJ: true, 6);
		OEMBPNAEGBA(1);
		OnlineSlotsManager instance = OnlineSlotsManager.instance;
		instance.OnRecivePlayerInventory = (Action)Delegate.Remove(instance.OnRecivePlayerInventory, new Action(JMHCCBGKKOD));
	}

	public bool FNFLFAIMACE(int JIIGOACEIKL)
	{
		return true;
	}

	protected void JIAJFDKNJME()
	{
		MLECCLAILFE[id] = this;
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
	}

	public void GGCCMCLILLH(int JIIGOACEIKL)
	{
	}

	public static MultiplayerChest MPDMDABCCCA(int JIIGOACEIKL)
	{
		return MLECCLAILFE[JIIGOACEIKL];
	}

	public bool EFNIMEIJFGA(int JIIGOACEIKL)
	{
		return false;
	}

	public bool SelectOnline(int JIIGOACEIKL)
	{
		return true;
	}

	public bool OPAGNKBJKHO(int JIIGOACEIKL)
	{
		return false;
	}

	public void HPJLNHGMIGD(int JIIGOACEIKL)
	{
	}

	public bool EKKKHOHJONB(int JIIGOACEIKL)
	{
		return false;
	}

	public IEnumerator MNFNBMLEPCM()
	{
		return new DHKONHGEOBB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void CAOAGNDCCJH()
	{
		BigContainerUI.JGNOJMLHPOK(1).SetContainer(Inventory.KEHIBCAHKPJ(id, LAGHIOKLJGH: true));
		BigContainerUI.PHDBJGOEKHB(0).BCPBALLMBJD(PlayerInventory.OGKNJNINGMH(id, LAGHIOKLJGH: false, ADPNMHGBFKG: true).BBDOBNLMLGM(), null, IFMNAFDGKKK: true, OGCAKIGELBJ: true, 7);
		MCMCNOOHKPE(0);
		OnlineSlotsManager instance = OnlineSlotsManager.instance;
		instance.OnRecivePlayerInventory = (Action)Delegate.Remove(instance.OnRecivePlayerInventory, new Action(HHLPFDOMAIC));
	}

	private void MDFFFMHALON()
	{
		BigContainerUI.JDODHPEDACJ(0).EDKDKKGBIPG(Inventory.HHONLOCNFNC(id));
		BigContainerUI.JGNOJMLHPOK(0).PJDPPGMDBMC(PlayerInventory.NEKDDPIAOBE(id).GetAllSlots(), null, IFMNAFDGKKK: false, OGCAKIGELBJ: true, 5);
		FDNLHEPFHJE(0);
		OnlineSlotsManager instance = OnlineSlotsManager.instance;
		instance.OnRecivePlayerInventory = (Action)Delegate.Remove(instance.OnRecivePlayerInventory, new Action(OJEEGNINILI));
	}

	public bool BKGFMLPODHD(int JIIGOACEIKL)
	{
		if (IALLCPMIGDP(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				if (OnlineManager.BPLHEADPHAJ())
				{
					if (Time.time > PPMHCOBKMCN + 1520f)
					{
						PPMHCOBKMCN = Time.time;
						if (Bed.CJMABIHEPBF() == id)
						{
							DialogueManager.Bark("Items/item_description_615", ((Component)PlayerController.OPHDCMJLLEC(0)).transform);
						}
						else
						{
							CommonReferences.MNFMOEKMJKN().PlayerBark(".gz", JIIGOACEIKL);
						}
					}
					return true;
				}
				if (OnlineBedroomsManager.instance.bedOccupants[id - 1].bedAssigned != 0)
				{
					if (Time.time > PPMHCOBKMCN + 406f)
					{
						PPMHCOBKMCN = Time.time;
						CommonReferences.GGFJGHHHEJC.PlayerBark("", JIIGOACEIKL, ECPEFDHOFHN: false);
					}
					return false;
				}
			}
			if (GameManager.LocalCoop() && JIIGOACEIKL == 8)
			{
				if (Time.time > LINBLNKCFBB + 468f)
				{
					LINBLNKCFBB = Time.time;
					CommonReferences.GGFJGHHHEJC.PlayerBark("Items/item_description_1038", JIIGOACEIKL, ECPEFDHOFHN: false);
				}
				return false;
			}
			if (!KCLDPDNCNOA)
			{
				KCLDPDNCNOA = false;
				((MonoBehaviour)this).StartCoroutine(HMBEOELLFPF(JIIGOACEIKL));
			}
			return false;
		}
		return false;
	}

	public bool HEAPEALHADP(int JIIGOACEIKL)
	{
		return true;
	}

	public static MultiplayerChest IMJOOACMADK(int JIIGOACEIKL)
	{
		return MLECCLAILFE[JIIGOACEIKL];
	}

	protected void FBHHPNJGNJG()
	{
		MLECCLAILFE[id] = this;
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
	}

	public IEnumerator BFJHBOGICLF(int JIIGOACEIKL)
	{
		Sound.GGFJGHHHEJC.PlayOpenSound(OpenSound.Wood, ((Component)this).transform);
		if (hasAnimation)
		{
			yield return ((MonoBehaviour)this).StartCoroutine(Utils.KAHHFCFDJIK(JIIGOACEIKL, frameRate, animationSprites, doorSpriteRenderer, (MonoBehaviour)(object)this));
		}
		if (NKEMALMMOBL)
		{
			yield break;
		}
		if (Object.op_Implicit((Object)(object)placeable) && !placeable.selectBlockers.Contains(MFHACMAHGHC))
		{
			placeable.selectBlockers.Add(MFHACMAHGHC);
		}
		if (!SmallContainerUI.Get(JIIGOACEIKL).IsOpen())
		{
			InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
			if (OnlineManager.MasterOrOffline())
			{
				BigContainerUI.Get(JIIGOACEIKL).SetContainer(Inventory.GetPlayer(id, LAGHIOKLJGH: false, ADPNMHGBFKG: true));
				BigContainerUI.Get(JIIGOACEIKL).FillSlots(PlayerInventory.GetPlayer(id, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetAllSlots(), null, IFMNAFDGKKK: true, OGCAKIGELBJ: false, 5);
				MCMCNOOHKPE(JIIGOACEIKL);
			}
			else
			{
				OnlineSlotsManager.instance.RequestPlayerInventory(PhotonNetwork.LocalPlayer.ActorNumber, id);
				OnlineSlotsManager instance = OnlineSlotsManager.instance;
				instance.OnRecivePlayerInventory = (Action)Delegate.Combine(instance.OnRecivePlayerInventory, new Action(HHLPFDOMAIC));
			}
		}
	}

	public bool GABJJKAPBMJ(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public IEnumerator EPBEJDCABDJ(int JIIGOACEIKL)
	{
		Sound.GGFJGHHHEJC.PlayOpenSound(OpenSound.Wood, ((Component)this).transform);
		if (hasAnimation)
		{
			yield return ((MonoBehaviour)this).StartCoroutine(Utils.KAHHFCFDJIK(JIIGOACEIKL, frameRate, animationSprites, doorSpriteRenderer, (MonoBehaviour)(object)this));
		}
		if (NKEMALMMOBL)
		{
			yield break;
		}
		if (Object.op_Implicit((Object)(object)placeable) && !placeable.selectBlockers.Contains(MFHACMAHGHC))
		{
			placeable.selectBlockers.Add(MFHACMAHGHC);
		}
		if (!SmallContainerUI.Get(JIIGOACEIKL).IsOpen())
		{
			InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
			if (OnlineManager.MasterOrOffline())
			{
				BigContainerUI.Get(JIIGOACEIKL).SetContainer(Inventory.GetPlayer(id, LAGHIOKLJGH: false, ADPNMHGBFKG: true));
				BigContainerUI.Get(JIIGOACEIKL).FillSlots(PlayerInventory.GetPlayer(id, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetAllSlots(), null, IFMNAFDGKKK: true, OGCAKIGELBJ: false, 5);
				MCMCNOOHKPE(JIIGOACEIKL);
			}
			else
			{
				OnlineSlotsManager.instance.RequestPlayerInventory(PhotonNetwork.LocalPlayer.ActorNumber, id);
				OnlineSlotsManager instance = OnlineSlotsManager.instance;
				instance.OnRecivePlayerInventory = (Action)Delegate.Combine(instance.OnRecivePlayerInventory, new Action(HHLPFDOMAIC));
			}
		}
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public void FHEGMGFAIPM(int JIIGOACEIKL)
	{
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Open"));
			return true;
		}
		return false;
	}

	public bool IALLCPMIGDP(int JIIGOACEIKL)
	{
		if (Object.op_Implicit((Object)(object)placeable) && placeable.FHEMHCEAICB)
		{
			return true;
		}
		return DecorationMode.KKJABELKCNM(JIIGOACEIKL).DBAEGBDEPFK();
	}

	public bool BAGPKDFCDPN(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void JJELBOKLMLB(int JIIGOACEIKL)
	{
	}

	public void KMBCKODACPJ(int JIIGOACEIKL)
	{
	}

	public bool LGMPIBOODMG(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool PickUp(int JIIGOACEIKL)
	{
		return false;
	}

	private void JMHCCBGKKOD()
	{
		BigContainerUI.JDODHPEDACJ(0).NIJNBDEMAEB(Inventory.GFHCACLMFDK(id));
		BigContainerUI.OHPNDOJNCBK(1).BCPBALLMBJD(PlayerInventory.GetPlayer(id, LAGHIOKLJGH: false, ADPNMHGBFKG: true).OMCMMDDGHFB(), null, IFMNAFDGKKK: false, OGCAKIGELBJ: false, 5);
		DMNFDLPFEAL(0);
		OnlineSlotsManager instance = OnlineSlotsManager.instance;
		instance.OnRecivePlayerInventory = (Action)Delegate.Remove(instance.OnRecivePlayerInventory, new Action(MDFFFMHALON));
	}

	public bool EGLBFPEHNHH(int JIIGOACEIKL)
	{
		return true;
	}

	public void GGAOCGGKIEJ(int JIIGOACEIKL)
	{
	}

	private void OCKDGAMNFDJ()
	{
		BigContainerUI.Get(1).PJLJDDKELHA(Inventory.NPANPNIDKDG(id));
		BigContainerUI.FHBIFJNCOAI(1).FillSlots(PlayerInventory.OGKNJNINGMH(id, LAGHIOKLJGH: true).FCGJCBJGOIG(), null, IFMNAFDGKKK: true, OGCAKIGELBJ: true, 0);
		JBLDNPIMMOG(0);
		OnlineSlotsManager instance = OnlineSlotsManager.instance;
		instance.OnRecivePlayerInventory = (Action)Delegate.Remove(instance.OnRecivePlayerInventory, new Action(CAOAGNDCCJH));
	}

	public void DACLICLAKIM(int JIIGOACEIKL)
	{
	}

	public IEnumerator OAEMCDLBENN()
	{
		if (hasAnimation)
		{
			NKEMALMMOBL = true;
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.closeDoor, ((Component)this).transform);
			yield return ((MonoBehaviour)this).StartCoroutine(Utils.OBCEOGNEFPD(animationSprites, doorSpriteRenderer, frameRate));
			NKEMALMMOBL = false;
		}
		KCLDPDNCNOA = false;
		if (Object.op_Implicit((Object)(object)placeable))
		{
			placeable.selectBlockers.Remove(MFHACMAHGHC);
		}
	}

	private void JBLDNPIMMOG(int JIIGOACEIKL)
	{
		BigContainerUI.NDJAMDLOIJL(JIIGOACEIKL).NBKOCCODEKN = (MonoBehaviour)(object)this;
		BigContainerUI.IGHMHMNPMLB(JIIGOACEIKL).NNIIGOFFBMM(IFMNAFDGKKK: true);
		SelectObject.BNMEANGDMIP(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
		InteractObject.BBJCJFJEFKK(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
		BigContainerUI.ILDNNNMOCOC(JIIGOACEIKL).EDHEIFHAAKO();
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		return true;
	}

	public IEnumerator NILPHMOMOAF()
	{
		if (hasAnimation)
		{
			NKEMALMMOBL = true;
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.closeDoor, ((Component)this).transform);
			yield return ((MonoBehaviour)this).StartCoroutine(Utils.OBCEOGNEFPD(animationSprites, doorSpriteRenderer, frameRate));
			NKEMALMMOBL = false;
		}
		KCLDPDNCNOA = false;
		if (Object.op_Implicit((Object)(object)placeable))
		{
			placeable.selectBlockers.Remove(MFHACMAHGHC);
		}
	}

	public bool NFIAILONCHG(int JIIGOACEIKL)
	{
		return true;
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (Object.op_Implicit((Object)(object)placeable) && placeable.FHEMHCEAICB)
		{
			return false;
		}
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public static MultiplayerChest JHEHMLIPPAA(int JIIGOACEIKL)
	{
		return MLECCLAILFE[JIIGOACEIKL];
	}

	public bool HAOPENBNBFF(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && HPPHMKMDKEG(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("sForSeconds"));
			return false;
		}
		return true;
	}

	protected void GFLFDLIMOLI()
	{
		MLECCLAILFE[id] = this;
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
	}

	private void DMNFDLPFEAL(int JIIGOACEIKL)
	{
		BigContainerUI.EIMDPBGBBIF(JIIGOACEIKL).GLBNOLCHOHO((MonoBehaviour)(object)this);
		BigContainerUI.IGHMHMNPMLB(JIIGOACEIKL).JGMNPLDFOPP(IFMNAFDGKKK: true);
		SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
		InteractObject.BBJCJFJEFKK(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
		BigContainerUI.Get(JIIGOACEIKL).IDLAGJNLPJL();
	}

	public bool JNCIONKLFBF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool HOGBEKJNJBM(int JIIGOACEIKL)
	{
		return true;
	}

	public bool NCGCKHGOJCM(int JIIGOACEIKL)
	{
		return false;
	}

	private void OJEEGNINILI()
	{
		BigContainerUI.EIMDPBGBBIF(0).HGKCOKBAFAJ(Inventory.JFIPFFDLDKB(id, LAGHIOKLJGH: false, ADPNMHGBFKG: true));
		BigContainerUI.ILDNNNMOCOC(0).PJDPPGMDBMC(PlayerInventory.OGKNJNINGMH(id, LAGHIOKLJGH: false, ADPNMHGBFKG: true).FCGJCBJGOIG(), null, IFMNAFDGKKK: true, OGCAKIGELBJ: false, 4);
		DMNFDLPFEAL(0);
		OnlineSlotsManager instance = OnlineSlotsManager.instance;
		instance.OnRecivePlayerInventory = (Action)Delegate.Remove(instance.OnRecivePlayerInventory, new Action(CAOAGNDCCJH));
	}

	public bool DIHBFCGKMKH(int JIIGOACEIKL)
	{
		return true;
	}

	public IEnumerator DBBCJEINGCO()
	{
		return new DHKONHGEOBB(1)
		{
			_003C_003E4__this = this
		};
	}

	public IEnumerator CloseContainer()
	{
		if (hasAnimation)
		{
			NKEMALMMOBL = true;
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.closeDoor, ((Component)this).transform);
			yield return ((MonoBehaviour)this).StartCoroutine(Utils.OBCEOGNEFPD(animationSprites, doorSpriteRenderer, frameRate));
			NKEMALMMOBL = false;
		}
		KCLDPDNCNOA = false;
		if (Object.op_Implicit((Object)(object)placeable))
		{
			placeable.selectBlockers.Remove(MFHACMAHGHC);
		}
	}

	public bool NHGNIPINAOF(int JIIGOACEIKL)
	{
		BigContainerUI.FHBIFJNCOAI(JIIGOACEIKL).CloseUI();
		InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
		if (!NKEMALMMOBL)
		{
			((MonoBehaviour)this).StartCoroutine(NILPHMOMOAF());
		}
		return true;
	}

	public bool Deselect(int JIIGOACEIKL)
	{
		BigContainerUI.Get(JIIGOACEIKL).CloseUI();
		InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
		if (!NKEMALMMOBL)
		{
			((MonoBehaviour)this).StartCoroutine(CloseContainer());
		}
		return true;
	}

	public bool CAIOMAEKPFK(int JIIGOACEIKL)
	{
		return true;
	}

	public bool JEJAGPHMLLF(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("talent_name_112"));
			return true;
		}
		return true;
	}

	public bool CAJMKLBCBEK(int JIIGOACEIKL)
	{
		if (HPPHMKMDKEG(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				if (OnlineManager.IsClient())
				{
					if (Time.time > PPMHCOBKMCN + 560f)
					{
						PPMHCOBKMCN = Time.time;
						if (Bed.CJMABIHEPBF() == id)
						{
							DialogueManager.Bark("Travellers Rest", ((Component)PlayerController.OPHDCMJLLEC(1)).transform);
						}
						else
						{
							CommonReferences.MNFMOEKMJKN().APKKEGHGFHG("RPC Receive Talent From Other ", JIIGOACEIKL, ECPEFDHOFHN: false);
						}
					}
					return true;
				}
				if (OnlineBedroomsManager.instance.bedOccupants[id - 7].bedAssigned != 0)
				{
					if (Time.time > PPMHCOBKMCN + 531f)
					{
						PPMHCOBKMCN = Time.time;
						CommonReferences.GGFJGHHHEJC.PlayerBark(" ExitState().", JIIGOACEIKL);
					}
					return false;
				}
			}
			if (GameManager.LocalCoop() && JIIGOACEIKL == 4)
			{
				if (Time.time > LINBLNKCFBB + 1383f)
				{
					LINBLNKCFBB = Time.time;
					CommonReferences.GGFJGHHHEJC.PlayerBark("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/24/Dialogue Text", JIIGOACEIKL);
				}
				return false;
			}
			if (!KCLDPDNCNOA)
			{
				KCLDPDNCNOA = true;
				((MonoBehaviour)this).StartCoroutine(OpenContainer(JIIGOACEIKL));
			}
			return false;
		}
		return true;
	}

	public void PJNPPBCLBCO(int JIIGOACEIKL)
	{
	}

	private void FDNLHEPFHJE(int JIIGOACEIKL)
	{
		BigContainerUI.ILDNNNMOCOC(JIIGOACEIKL).PPJGIEOIJCF((MonoBehaviour)(object)this);
		BigContainerUI.PHDBJGOEKHB(JIIGOACEIKL).SetDeliveryOnly(IFMNAFDGKKK: false);
		SelectObject.BNMEANGDMIP(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
		InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
		BigContainerUI.JGNOJMLHPOK(JIIGOACEIKL).OpenUI();
	}

	public bool MCGLIBHNMNH(int JIIGOACEIKL)
	{
		return true;
	}

	public bool HFKHIIFGAKP(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && PPJFDGOOIDK(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("AreaSpace not attached on OnlineAreaSpace of placeable "));
			return false;
		}
		return true;
	}

	public bool AGJPABDBHCJ(int JIIGOACEIKL)
	{
		if (Object.op_Implicit((Object)(object)placeable) && placeable.FHEMHCEAICB)
		{
			return true;
		}
		return !DecorationMode.BGINAIDHDOM(JIIGOACEIKL).KNFEPKBIHND();
	}

	public bool AKBPOPKJFHG(int JIIGOACEIKL)
	{
		BigContainerUI.PHDBJGOEKHB(JIIGOACEIKL).BOBCIFEDJED();
		InteractObject.BBJCJFJEFKK(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
		if (!NKEMALMMOBL)
		{
			((MonoBehaviour)this).StartCoroutine(FAJIKPLCAJM());
		}
		return true;
	}

	public bool KAPFKOCOOCO(int JIIGOACEIKL)
	{
		if (IALLCPMIGDP(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				if (OnlineManager.IsClient())
				{
					if (Time.time > PPMHCOBKMCN + 561f)
					{
						PPMHCOBKMCN = Time.time;
						if (Bed.GetNumInstance() == id)
						{
							DialogueManager.Bark("Items/item_name_664", ((Component)PlayerController.GetPlayer(1)).transform);
						}
						else
						{
							CommonReferences.GGFJGHHHEJC.PlayerBark(" because it doesn't have puzzle altar but the piece ID matches the altar piece ID.", JIIGOACEIKL, ECPEFDHOFHN: false);
						}
					}
					return false;
				}
				if (OnlineBedroomsManager.instance.bedOccupants[id - 3].bedAssigned != 0)
				{
					if (Time.time > PPMHCOBKMCN + 1699f)
					{
						PPMHCOBKMCN = Time.time;
						CommonReferences.GGFJGHHHEJC.PlayerBark("Items/item_name_1058", JIIGOACEIKL);
					}
					return true;
				}
			}
			if (GameManager.LocalCoop() && JIIGOACEIKL == 2)
			{
				if (Time.time > LINBLNKCFBB + 462f)
				{
					LINBLNKCFBB = Time.time;
					CommonReferences.MNFMOEKMJKN().PlayerBark("IdleCamp", JIIGOACEIKL, ECPEFDHOFHN: false);
				}
				return false;
			}
			if (!KCLDPDNCNOA)
			{
				KCLDPDNCNOA = true;
				((MonoBehaviour)this).StartCoroutine(BFJHBOGICLF(JIIGOACEIKL));
			}
			return true;
		}
		return true;
	}

	public IEnumerator AFKGPNEMFCN()
	{
		return new DHKONHGEOBB(1)
		{
			_003C_003E4__this = this
		};
	}

	public static MultiplayerChest IKAEFEPNADI(int JIIGOACEIKL)
	{
		return MLECCLAILFE[JIIGOACEIKL];
	}

	public bool KILODECAMAI(int JIIGOACEIKL)
	{
		return true;
	}

	private void OEMBPNAEGBA(int JIIGOACEIKL)
	{
		BigContainerUI.JGNOJMLHPOK(JIIGOACEIKL).JLGKPCGNMLL((MonoBehaviour)(object)this);
		BigContainerUI.FHBIFJNCOAI(JIIGOACEIKL).NNIIGOFFBMM(IFMNAFDGKKK: true);
		SelectObject.BNMEANGDMIP(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
		InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
		BigContainerUI.AANKLOIDPOA(JIIGOACEIKL).OpenUI();
	}

	public bool DAFBICEGOFO(int JIIGOACEIKL)
	{
		BigContainerUI.FHBIFJNCOAI(JIIGOACEIKL).BOBCIFEDJED();
		InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
		if (!NKEMALMMOBL)
		{
			((MonoBehaviour)this).StartCoroutine(FAJIKPLCAJM());
		}
		return true;
	}

	public void ALBEDNOIEJF(int JIIGOACEIKL)
	{
	}

	public IEnumerator FAJIKPLCAJM()
	{
		if (hasAnimation)
		{
			NKEMALMMOBL = true;
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.closeDoor, ((Component)this).transform);
			yield return ((MonoBehaviour)this).StartCoroutine(Utils.OBCEOGNEFPD(animationSprites, doorSpriteRenderer, frameRate));
			NKEMALMMOBL = false;
		}
		KCLDPDNCNOA = false;
		if (Object.op_Implicit((Object)(object)placeable))
		{
			placeable.selectBlockers.Remove(MFHACMAHGHC);
		}
	}

	public bool LDFBAJAHNLA(int JIIGOACEIKL)
	{
		return true;
	}

	private void HHLPFDOMAIC()
	{
		BigContainerUI.Get(1).SetContainer(Inventory.GetPlayer(id, LAGHIOKLJGH: false, ADPNMHGBFKG: true));
		BigContainerUI.Get(1).FillSlots(PlayerInventory.GetPlayer(id, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetAllSlots(), null, IFMNAFDGKKK: true, OGCAKIGELBJ: false, 5);
		MCMCNOOHKPE(1);
		OnlineSlotsManager instance = OnlineSlotsManager.instance;
		instance.OnRecivePlayerInventory = (Action)Delegate.Remove(instance.OnRecivePlayerInventory, new Action(HHLPFDOMAIC));
	}

	public void EPADOBKDNKG(int JIIGOACEIKL)
	{
	}

	public void BFKDGNPAJDE(int JIIGOACEIKL)
	{
	}

	protected void Awake()
	{
		MLECCLAILFE[id] = this;
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
	}

	private void MCMCNOOHKPE(int JIIGOACEIKL)
	{
		BigContainerUI.Get(JIIGOACEIKL).NBKOCCODEKN = (MonoBehaviour)(object)this;
		BigContainerUI.Get(JIIGOACEIKL).SetDeliveryOnly(IFMNAFDGKKK: true);
		SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
		InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
		BigContainerUI.Get(JIIGOACEIKL).OpenUI();
	}

	public IEnumerator PANJPFBLMIK(int JIIGOACEIKL)
	{
		return new ECBCMLOHKJD(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				if (OnlineManager.IsClient())
				{
					if (Time.time > PPMHCOBKMCN + 8f)
					{
						PPMHCOBKMCN = Time.time;
						if (Bed.GetNumInstance() == id)
						{
							DialogueManager.Bark("Player2_Bark_2PlayersChest", ((Component)PlayerController.GetPlayer(1)).transform);
						}
						else
						{
							CommonReferences.GGFJGHHHEJC.PlayerBark("NotMyChest", JIIGOACEIKL);
						}
					}
					return false;
				}
				if (OnlineBedroomsManager.instance.bedOccupants[id - 2].bedAssigned != 0)
				{
					if (Time.time > PPMHCOBKMCN + 8f)
					{
						PPMHCOBKMCN = Time.time;
						CommonReferences.GGFJGHHHEJC.PlayerBark("NotMyChest", JIIGOACEIKL);
					}
					return false;
				}
			}
			if (GameManager.LocalCoop() && JIIGOACEIKL == 2)
			{
				if (Time.time > LINBLNKCFBB + 8f)
				{
					LINBLNKCFBB = Time.time;
					CommonReferences.GGFJGHHHEJC.PlayerBark("NotMyChest", JIIGOACEIKL);
				}
				return false;
			}
			if (!KCLDPDNCNOA)
			{
				KCLDPDNCNOA = true;
				((MonoBehaviour)this).StartCoroutine(OpenContainer(JIIGOACEIKL));
			}
			return true;
		}
		return false;
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public bool Select(int JIIGOACEIKL)
	{
		return false;
	}

	public bool MEEJECDJJNK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && KDGAIGKBPAC(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("NormalRightExterior"));
			return true;
		}
		return false;
	}

	public bool DPMOJBCABKA(int JIIGOACEIKL)
	{
		BigContainerUI.EPLOMIBMKFC(JIIGOACEIKL).CloseUI();
		InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
		if (!NKEMALMMOBL)
		{
			((MonoBehaviour)this).StartCoroutine(JNNENMMHODO());
		}
		return false;
	}

	public void OBBHKOLLLJH(int JIIGOACEIKL)
	{
	}

	protected void KHONOODGLBI()
	{
		MLECCLAILFE[id] = this;
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
	}

	public bool FMDIGCNHBAP(int JIIGOACEIKL)
	{
		return false;
	}

	public static MultiplayerChest BGINAIDHDOM(int JIIGOACEIKL)
	{
		return MLECCLAILFE[JIIGOACEIKL];
	}
}
