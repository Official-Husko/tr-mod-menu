using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DrinkDispenser : Container, IInteractable, ISelectable, IHoverable, IProximity
{
	[CompilerGenerated]
	private sealed class ELJHCFGNJJI : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DrinkDispenser _003C_003E4__this;

		public bool loading;

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
		public ELJHCFGNJJI(int _003C_003E1__state)
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
			DrinkDispenser drinkDispenser = _003C_003E4__this;
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
				drinkDispenser.drinkDispenserId = DrinkDispensersManager.GGFJGHHHEJC.AddDrinkDispenser(drinkDispenser, loading);
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
	private sealed class LLICIGCLEOD : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DrinkDispenser _003C_003E4__this;

		public short id;

		public bool _sendOnline;

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
		public LLICIGCLEOD(int _003C_003E1__state)
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
			DrinkDispenser drinkDispenser = _003C_003E4__this;
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
				drinkDispenser.SetDrinkColor(DrinkDispensersManager.GGFJGHHHEJC.GetSpriteColor(id), _sendOnline);
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

	public static Action<DrinkDispenser> DrinkDispenserColorUpdated = delegate
	{
	};

	public static Action<DrinkDispenser> DrinkDispenserContainerUpdated = delegate
	{
	};

	public DoWork work;

	[SerializeField]
	private SpriteColor _spriteColor;

	public Placeable placeable;

	public SpriteRenderer drinkColorSR;

	public Transform barworkerRoot;

	public bool isBeerTap;

	public ItemInstance lastDrink;

	private int LBPALMBBIKM = 1;

	public int drinkDispenserId;

	[SerializeField]
	private SpriteRenderer[] outline1SR;

	[SerializeField]
	private SpriteRenderer[] outline2SR;

	private bool HHALKJCPLGL;

	private float HOAANMDGJEP;

	public SpriteColor FJAHJEMPPKH => _spriteColor;

	public static bool CPBMKHEEFOL(int JIIGOACEIKL, Tray DOGOFILIHPJ, Slot ADEBNALPEHE, DoWork LEBMEKLLJFK, bool PFFAMHBDDMA, Employee NAKCFGEAGHH = null)
	{
		if (ADEBNALPEHE.itemInstance != null && ADEBNALPEHE.Stack > 1)
		{
			if (DOGOFILIHPJ.LALIFJEMJFJ(ADEBNALPEHE.itemInstance.PHGLMBIEOMK().JEDPCLGBLBA(ADEBNALPEHE.itemInstance), NAKCFGEAGHH))
			{
				if (PFFAMHBDDMA && ((Object)(object)NAKCFGEAGHH == (Object)null || Random.Range(1, 127) >= NAKCFGEAGHH.GetPerkValue(5)))
				{
					ADEBNALPEHE.AJOGNKDJNAD(AODONKKHPBP: true);
					ADEBNALPEHE.MEODNPFJDMH();
				}
				if ((Object)(object)NAKCFGEAGHH == (Object)null && JIIGOACEIKL != 0)
				{
					LEBMEKLLJFK.Stop();
				}
				return true;
			}
			CommonReferences.GGFJGHHHEJC.PlayerBark("Leave smoothly", JIIGOACEIKL, ECPEFDHOFHN: false);
			return true;
		}
		CommonReferences.MNFMOEKMJKN().PlayerBark("Invalid playerNum ", JIIGOACEIKL, ECPEFDHOFHN: false);
		return false;
	}

	private void EFEPLFGDFMP()
	{
		if (!slots[1].KPINNBKMOMO() && slots[0].itemInstance.KNFNJFFCFNO().JDJGFAACPFC(DAINLFIMLIH: false) == 44)
		{
			slots[1].HBMBGCHGEGN(slots[1].Stack, CDPAMNIPPEC: true, 1);
			slots[1].MHIIKMOOMFH(0, ItemDatabaseAccessor.KMBGJEKCJFJ(68).JMDALJBNFML(), GetMaxStack(slots[0].itemInstance), HAGPBCJEGKM: true, BDGJBPCEFPN: true, CDPAMNIPPEC: true);
			PlayerInventory.EIFPKCAFDIB(LBPALMBBIKM, LAGHIOKLJGH: true).AddItem(ItemDatabaseAccessor.EABMGELAAPG(-158, GGBBJNBBLMF: true).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
		}
	}

	public bool OFODDFNCPJN(int JIIGOACEIKL)
	{
		HHALKJCPLGL = false;
		LBPALMBBIKM = JIIGOACEIKL;
		ACFHHFNBGFJ(JIIGOACEIKL, work, slots[0].itemInstance, this);
		return true;
	}

	public void JCDOBMNHOMI(SpriteColor FJAHJEMPPKH)
	{
		DrinkDispensersManager.JFNOOMJMHCB().NMEMIJAMAKN(this, FJAHJEMPPKH);
	}

	private void FAKNILODPNH()
	{
		work.DJKJFIALADE(JCENACCAGHJ);
		Slot obj = slots[0];
		obj.OnItemAdded = (Action)Delegate.Remove(obj.OnItemAdded, new Action(ELLKHPHHKPO));
	}

	private void HFKOBCFMNJJ()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)DrinkDispensersManager.OPILDPFDFKJ()))
		{
			DrinkDispensersManager.GGFJGHHHEJC.IOKEKCBOEIG(this);
		}
	}

	public bool PFDCMDDOFNN(int JIIGOACEIKL)
	{
		HHALKJCPLGL = false;
		LBPALMBBIKM = JIIGOACEIKL;
		BCNIMIALJJH(JIIGOACEIKL, work, slots[0].itemInstance, this);
		return false;
	}

	private void NPDFCPEOFPD()
	{
		work.BECJEKINIFB(LBPOCBOFDGO);
		Slot obj = slots[0];
		obj.OnItemAdded = (Action)Delegate.Combine(obj.OnItemAdded, new Action(EEKCGPHLAJD));
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public bool MABBMICEHDC(int JIIGOACEIKL)
	{
		return false;
	}

	private void EBBJNLPIEPF()
	{
		ODIAJJAFGBL();
		if (!slots[0].KPINNBKMOMO())
		{
			lastDrink = slots[1].itemInstance;
		}
		DrinkDispenserContainerUpdated(this);
	}

	public static void FinishPull(int JIIGOACEIKL, Slot ADEBNALPEHE, DoWork LEBMEKLLJFK, bool PFFAMHBDDMA, DrinkDispenser MJMNGLHDJFH = null)
	{
		if (!ADEBNALPEHE.KPINNBKMOMO() && !TakeDrink(JIIGOACEIKL, PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray, ADEBNALPEHE, LEBMEKLLJFK, PFFAMHBDDMA))
		{
			ADEBNALPEHE.isDirty = true;
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		ButtonsContext.ResetCrafterAction(JIIGOACEIKL);
		if (Object.op_Implicit((Object)(object)MJMNGLHDJFH))
		{
			MJMNGLHDJFH.HHALKJCPLGL = false;
			if (Object.op_Implicit((Object)(object)MJMNGLHDJFH.placeable) && OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendRemoveFromInteracting(MJMNGLHDJFH.placeable.onlinePlaceable);
			}
		}
	}

	public void OffHover(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			for (int i = 0; i < outline1SR.Length; i++)
			{
				((Component)outline1SR[i]).gameObject.SetActive(false);
			}
		}
		else
		{
			for (int j = 0; j < outline2SR.Length; j++)
			{
				((Component)outline2SR[j]).gameObject.SetActive(false);
			}
		}
		ButtonsContext.ResetCrafterAction(JIIGOACEIKL);
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetBeerTapBar();
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		HHALKJCPLGL = true;
		LBPALMBBIKM = JIIGOACEIKL;
		PullDrinkFromDrinkDispenser(JIIGOACEIKL, work, slots[0].itemInstance, this);
		return true;
	}

	public static bool DJBACNJDBEO(int JIIGOACEIKL, DoWork LEBMEKLLJFK, ItemInstance DNLMCHDOMOK, DrinkDispenser MJMNGLHDJFH = null, BanquetBarrel JAPHAKHOHCI = null)
	{
		if (DNLMCHDOMOK != null && !LEBMEKLLJFK.KGOEFMFHCOG())
		{
			LEBMEKLLJFK.EBAGOIDGCLE(1682f);
			((MonoBehaviour)GameManager.NJNFHEPLEHL()).StartCoroutine(MPLLAIDMHBI(LEBMEKLLJFK, MJMNGLHDJFH, JAPHAKHOHCI));
		}
		else if (LEBMEKLLJFK.OENMBFGINAL())
		{
			if (LEBMEKLLJFK.PFLPFNICHJA(JIIGOACEIKL, 120f * Time.deltaTime * (1991f + (float)PerksDatabaseAccessor.NGMJIGOPGDK(-8) / 546f), CDPAMNIPPEC: false))
			{
				return true;
			}
			if (Object.op_Implicit((Object)(object)MJMNGLHDJFH))
			{
				MJMNGLHDJFH.HOAANMDGJEP = Time.time + 614f;
			}
			else if (Object.op_Implicit((Object)(object)JAPHAKHOHCI))
			{
				JAPHAKHOHCI.stopPullTime = Time.time + 985f;
			}
		}
		if (DNLMCHDOMOK == null)
		{
			CommonReferences.MNFMOEKMJKN().PlayerBark("", JIIGOACEIKL);
			if ((Object)(object)MJMNGLHDJFH != (Object)null && Object.op_Implicit((Object)(object)MJMNGLHDJFH.placeable) && OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendRemoveFromInteracting(MJMNGLHDJFH.placeable.onlinePlaceable);
			}
			return false;
		}
		return true;
	}

	private void JCENACCAGHJ(int JIIGOACEIKL)
	{
		HKJBNPCOOIH(JIIGOACEIKL, slots[0], work, PFFAMHBDDMA: false, this);
	}

	public void ChangeDrinkColor(SpriteColor FJAHJEMPPKH)
	{
		DrinkDispensersManager.GGFJGHHHEJC.ChangeDrinkColor(this, FJAHJEMPPKH);
	}

	public static void KJJGBOBBIII(int JIIGOACEIKL, Slot ADEBNALPEHE, DoWork LEBMEKLLJFK, bool PFFAMHBDDMA, DrinkDispenser MJMNGLHDJFH = null)
	{
		if (!ADEBNALPEHE.AHHEMNHJPME() && !GAPMIEHBPHI(JIIGOACEIKL, PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray, ADEBNALPEHE, LEBMEKLLJFK, PFFAMHBDDMA))
		{
			ADEBNALPEHE.AJOGNKDJNAD(AODONKKHPBP: true);
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		ButtonsContext.CPIIFPCIJEP(JIIGOACEIKL);
		if (Object.op_Implicit((Object)(object)MJMNGLHDJFH))
		{
			MJMNGLHDJFH.HHALKJCPLGL = false;
			if (Object.op_Implicit((Object)(object)MJMNGLHDJFH.placeable) && OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendRemoveFromInteracting(MJMNGLHDJFH.placeable.onlinePlaceable);
			}
		}
	}

	public bool DLBFJFOGOJF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (KLGOCJMGKFO)
			{
				if (slots[1].itemInstance == null)
				{
					CommonReferences.MNFMOEKMJKN().APKKEGHGFHG("City/Woody/Bark/Stand", JIIGOACEIKL, ECPEFDHOFHN: false);
					return true;
				}
				HHALKJCPLGL = true;
				PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Select;
				OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(placeable.onlinePlaceable.uniqueId);
			}
			if (!HHALKJCPLGL)
			{
				return true;
			}
		}
		LBPALMBBIKM = JIIGOACEIKL;
		return HAHKDPOPPBB(JIIGOACEIKL, work, slots[1].itemInstance, this);
	}

	public static bool JAOFAKKOHGJ(int JIIGOACEIKL, DoWork LEBMEKLLJFK, ItemInstance DNLMCHDOMOK, DrinkDispenser MJMNGLHDJFH = null, BanquetBarrel JAPHAKHOHCI = null)
	{
		if (DNLMCHDOMOK != null && !LEBMEKLLJFK.JCMBHAEKLKK)
		{
			LEBMEKLLJFK.OKINPIOJMNA(191f);
			((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(PAEACDAAKCK(LEBMEKLLJFK, MJMNGLHDJFH, JAPHAKHOHCI));
		}
		else if (LEBMEKLLJFK.JCMBHAEKLKK)
		{
			if (LEBMEKLLJFK.AddWorkDone(JIIGOACEIKL, 1415f * Time.deltaTime * (898f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(60) / 239f)))
			{
				return false;
			}
			if (Object.op_Implicit((Object)(object)MJMNGLHDJFH))
			{
				MJMNGLHDJFH.HOAANMDGJEP = Time.time + 804f;
			}
			else if (Object.op_Implicit((Object)(object)JAPHAKHOHCI))
			{
				JAPHAKHOHCI.stopPullTime = Time.time + 836f;
			}
		}
		if (DNLMCHDOMOK == null)
		{
			CommonReferences.GGFJGHHHEJC.PlayerBark("Items/item_description_726", JIIGOACEIKL);
			if ((Object)(object)MJMNGLHDJFH != (Object)null && Object.op_Implicit((Object)(object)MJMNGLHDJFH.placeable) && OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendRemoveFromInteracting(MJMNGLHDJFH.placeable.onlinePlaceable);
			}
			return true;
		}
		return true;
	}

	public void ADDLJEJIAFP(short JFNMCNCHMEO, bool BGKCHMNJBLJ = true)
	{
		((MonoBehaviour)this).StartCoroutine(DMMBNMOEDED(JFNMCNCHMEO, BGKCHMNJBLJ));
	}

	public void JANKIIPLLFL(SpriteColor FJAHJEMPPKH)
	{
		DrinkDispensersManager.OLHBLKIAFOM().JGILLMHFEBF(this, FJAHJEMPPKH);
	}

	private IEnumerator OHJIDBKNCAG(bool KBNNPAKJDJM)
	{
		return new ELJHCFGNJJI(1)
		{
			_003C_003E4__this = this,
			loading = KBNNPAKJDJM
		};
	}

	public bool SelectOnline(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			PJLEIDLNHPB(JIIGOACEIKL);
			return true;
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return false;
	}

	public bool LBNJPLCFLEE(int JIIGOACEIKL)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		if (IGHNIAICNEC(JIIGOACEIKL) && !MouseSlot.GetPlayer(JIIGOACEIKL).slot.AHHEMNHJPME())
		{
			AddSlot(JIIGOACEIKL, MouseSlot.GetPlayer(JIIGOACEIKL).slot, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position, BPJBJKJKHAL: false);
			return true;
		}
		return true;
	}

	private void CAAGFCIMKLM()
	{
		LBFBAHNJFFB();
		if (!slots[0].KPINNBKMOMO())
		{
			lastDrink = slots[0].itemInstance;
		}
		DrinkDispenserContainerUpdated(this);
	}

	public static bool HAHKDPOPPBB(int JIIGOACEIKL, DoWork LEBMEKLLJFK, ItemInstance DNLMCHDOMOK, DrinkDispenser MJMNGLHDJFH = null, BanquetBarrel JAPHAKHOHCI = null)
	{
		if (DNLMCHDOMOK != null && !LEBMEKLLJFK.OENMBFGINAL())
		{
			LEBMEKLLJFK.EBAGOIDGCLE(197f);
			((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(MPLLAIDMHBI(LEBMEKLLJFK, MJMNGLHDJFH, JAPHAKHOHCI));
		}
		else if (LEBMEKLLJFK.OENMBFGINAL())
		{
			if (LEBMEKLLJFK.BNMJANINOIG(JIIGOACEIKL, 996f * Time.deltaTime * (798f + (float)PerksDatabaseAccessor.NGMJIGOPGDK(32, 0, LDNMDAHFBGG: true) / 1739f), CDPAMNIPPEC: false))
			{
				return false;
			}
			if (Object.op_Implicit((Object)(object)MJMNGLHDJFH))
			{
				MJMNGLHDJFH.HOAANMDGJEP = Time.time + 1348f;
			}
			else if (Object.op_Implicit((Object)(object)JAPHAKHOHCI))
			{
				JAPHAKHOHCI.stopPullTime = Time.time + 1508f;
			}
		}
		if (DNLMCHDOMOK == null)
		{
			CommonReferences.GGFJGHHHEJC.PlayerBark("ReceiveGroundTypeList", JIIGOACEIKL);
			if ((Object)(object)MJMNGLHDJFH != (Object)null && Object.op_Implicit((Object)(object)MJMNGLHDJFH.placeable) && OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendRemoveFromInteracting(MJMNGLHDJFH.placeable.onlinePlaceable);
			}
			return false;
		}
		return false;
	}

	private static IEnumerator PAEACDAAKCK(DoWork LEBMEKLLJFK, DrinkDispenser MJMNGLHDJFH, BanquetBarrel JAPHAKHOHCI)
	{
		bool removeFromInteractingDone = false;
		if (Object.op_Implicit((Object)(object)MJMNGLHDJFH))
		{
			MJMNGLHDJFH.HOAANMDGJEP = Time.time + 0.1f;
		}
		else if (Object.op_Implicit((Object)(object)JAPHAKHOHCI))
		{
			JAPHAKHOHCI.stopPullTime = Time.time + 0.1f;
		}
		while (LEBMEKLLJFK.JCMBHAEKLKK)
		{
			yield return null;
			if (Time.time > (((Object)(object)MJMNGLHDJFH != (Object)null) ? MJMNGLHDJFH.HOAANMDGJEP : JAPHAKHOHCI.stopPullTime))
			{
				LEBMEKLLJFK.Stop();
				if (!removeFromInteractingDone && OnlineManager.PlayingOnline())
				{
					removeFromInteractingDone = true;
					if (Object.op_Implicit((Object)(object)MJMNGLHDJFH))
					{
						MJMNGLHDJFH.HHALKJCPLGL = false;
						OnlineObjectsManager.instance.SendRemoveFromInteracting(MJMNGLHDJFH.placeable.onlinePlaceable);
					}
				}
			}
			yield return null;
		}
	}

	private void CLJPBIOLJLG()
	{
		MEFFOEOGAMO();
	}

	private void DBHEEEIFOKH()
	{
		work.DJKJFIALADE(JCENACCAGHJ);
		Slot obj = slots[1];
		obj.OnItemAdded = (Action)Delegate.Remove(obj.OnItemAdded, new Action(FGMOPANGOAJ));
	}

	private static IEnumerator MPLLAIDMHBI(DoWork LEBMEKLLJFK, DrinkDispenser MJMNGLHDJFH, BanquetBarrel JAPHAKHOHCI)
	{
		bool removeFromInteractingDone = false;
		if (Object.op_Implicit((Object)(object)MJMNGLHDJFH))
		{
			MJMNGLHDJFH.HOAANMDGJEP = Time.time + 0.1f;
		}
		else if (Object.op_Implicit((Object)(object)JAPHAKHOHCI))
		{
			JAPHAKHOHCI.stopPullTime = Time.time + 0.1f;
		}
		while (LEBMEKLLJFK.JCMBHAEKLKK)
		{
			yield return null;
			if (Time.time > (((Object)(object)MJMNGLHDJFH != (Object)null) ? MJMNGLHDJFH.HOAANMDGJEP : JAPHAKHOHCI.stopPullTime))
			{
				LEBMEKLLJFK.Stop();
				if (!removeFromInteractingDone && OnlineManager.PlayingOnline())
				{
					removeFromInteractingDone = true;
					if (Object.op_Implicit((Object)(object)MJMNGLHDJFH))
					{
						MJMNGLHDJFH.HHALKJCPLGL = false;
						OnlineObjectsManager.instance.SendRemoveFromInteracting(MJMNGLHDJFH.placeable.onlinePlaceable);
					}
				}
			}
			yield return null;
		}
	}

	public bool Select(int JIIGOACEIKL)
	{
		if (!isBeerTap && NewTutorialManager.ServiceBarrelBlocked(JIIGOACEIKL))
		{
			return false;
		}
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Select;
				OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(placeable.onlinePlaceable.uniqueId);
				return false;
			}
			PJLEIDLNHPB(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	private void MMAGCMLMMAH()
	{
		if (!slots[1].AHHEMNHJPME() && slots[0].itemInstance.PHGLMBIEOMK().JGHNDJBCFAJ() == -184)
		{
			slots[0].JPACDDCJGPD(slots[0].Stack, CDPAMNIPPEC: true);
			slots[1].BEEDBHJANGN(1, ItemDatabaseAccessor.AFOACBIHNCL(36, GGBBJNBBLMF: true).JMDALJBNFML(), GetMaxStack(slots[1].itemInstance));
			PlayerInventory.EIFPKCAFDIB(LBPALMBBIKM, LAGHIOKLJGH: true).AddItem(ItemDatabaseAccessor.INJBNHPGCIJ(127).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: false);
		}
	}

	private void JNEEMGFBLHL()
	{
		ODIAJJAFGBL();
		if (!slots[0].AHHEMNHJPME())
		{
			lastDrink = slots[1].itemInstance;
		}
		DrinkDispenserContainerUpdated(this);
	}

	public static bool JJBOLLNMFII(int JIIGOACEIKL, Tray DOGOFILIHPJ, Slot ADEBNALPEHE, DoWork LEBMEKLLJFK, bool PFFAMHBDDMA, Employee NAKCFGEAGHH = null)
	{
		if (ADEBNALPEHE.itemInstance != null && ADEBNALPEHE.Stack > 1)
		{
			if (DOGOFILIHPJ.GJGHFNGGGNM(ADEBNALPEHE.itemInstance.AFOACBIHNCL().LJBOJBAPDAD(ADEBNALPEHE.itemInstance), NAKCFGEAGHH))
			{
				if (PFFAMHBDDMA && ((Object)(object)NAKCFGEAGHH == (Object)null || Random.Range(1, 97) >= NAKCFGEAGHH.GetPerkValue(4)))
				{
					ADEBNALPEHE.isDirty = false;
					ADEBNALPEHE.FMEPMEKLHIJ(CDPAMNIPPEC: false);
				}
				if ((Object)(object)NAKCFGEAGHH == (Object)null && JIIGOACEIKL != 0)
				{
					LEBMEKLLJFK.IEMMMGCJOME();
				}
				return false;
			}
			CommonReferences.MNFMOEKMJKN().APKKEGHGFHG("ReceiveUpdateMoodState", JIIGOACEIKL, ECPEFDHOFHN: false);
			return false;
		}
		CommonReferences.GGFJGHHHEJC.PlayerBark("LE_13", JIIGOACEIKL, ECPEFDHOFHN: false);
		return true;
	}

	public void SetDrinkColor(SpriteColor AODONKKHPBP, bool CDPAMNIPPEC = true)
	{
		_spriteColor = AODONKKHPBP;
		drinkColorSR.sprite = _spriteColor.sprite;
		if (OnlineManager.IsMasterClient() && CDPAMNIPPEC)
		{
			OnlineDrinkDispensersManager.instance.SendSetDrinkColor(placeable.BEIPALOAAJJ, _spriteColor.id);
		}
		DrinkDispenserColorUpdated(this);
	}

	public bool KDKCLGIABEO(int JIIGOACEIKL)
	{
		return false;
	}

	public bool IGHNIAICNEC(int JIIGOACEIKL)
	{
		if (Bar.instance.placeable.FHEMHCEAICB)
		{
			return true;
		}
		if (OnlineManager.PlayingOnline() && Bar.instance.placeable.PHOCAFJDCDK)
		{
			return true;
		}
		return DecorationMode.HBDCJFLINDA(JIIGOACEIKL).DFNMDDHOIJI();
	}

	public bool JEDGABGEHJE(int JIIGOACEIKL)
	{
		if (KBDEDNHDNOK(JIIGOACEIKL))
		{
			JAABKCMFNAJ(JIIGOACEIKL);
			return false;
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return false;
	}

	private IEnumerator DMMBNMOEDED(short JFNMCNCHMEO, bool BGKCHMNJBLJ = true)
	{
		return new LLICIGCLEOD(1)
		{
			_003C_003E4__this = this,
			id = JFNMCNCHMEO,
			_sendOnline = BGKCHMNJBLJ
		};
	}

	public static bool GAPMIEHBPHI(int JIIGOACEIKL, Tray DOGOFILIHPJ, Slot ADEBNALPEHE, DoWork LEBMEKLLJFK, bool PFFAMHBDDMA, Employee NAKCFGEAGHH = null)
	{
		if (ADEBNALPEHE.itemInstance != null && ADEBNALPEHE.Stack > 0)
		{
			if (DOGOFILIHPJ.CBPCDEKHELA(ADEBNALPEHE.itemInstance.KNFNJFFCFNO().LJBOJBAPDAD(ADEBNALPEHE.itemInstance), NAKCFGEAGHH))
			{
				if (PFFAMHBDDMA && ((Object)(object)NAKCFGEAGHH == (Object)null || Random.Range(0, 64) >= NAKCFGEAGHH.GetPerkValue(6)))
				{
					ADEBNALPEHE.AJOGNKDJNAD(AODONKKHPBP: false);
					ADEBNALPEHE.DJFOMFDOOKM(CDPAMNIPPEC: false);
				}
				if ((Object)(object)NAKCFGEAGHH == (Object)null && JIIGOACEIKL != 0)
				{
					LEBMEKLLJFK.Stop(CDPAMNIPPEC: false);
				}
				return true;
			}
			CommonReferences.MNFMOEKMJKN().PlayerBark("Items/item_description_1048", JIIGOACEIKL, ECPEFDHOFHN: false);
			return true;
		}
		CommonReferences.GGFJGHHHEJC.APKKEGHGFHG("Error_MaxZones", JIIGOACEIKL, ECPEFDHOFHN: false);
		return false;
	}

	public bool IOANEJAHOMG(int JIIGOACEIKL)
	{
		DrinkDispenserUI.OFEFGPCGJDF(JIIGOACEIKL).BOBCIFEDJED();
		CommonReferences.GGFJGHHHEJC.OnAnyTapClosed(JIIGOACEIKL);
		InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return true;
	}

	public bool DOFKECGCCAJ(int JIIGOACEIKL)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		if (IGHNIAICNEC(JIIGOACEIKL) && !MouseSlot.GetPlayer(JIIGOACEIKL).slot.AHHEMNHJPME())
		{
			CPJOOCKFAJC(JIIGOACEIKL, MouseSlot.HELHJMDEDNL(JIIGOACEIKL).slot, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position);
			return false;
		}
		return true;
	}

	private static IEnumerator ENCFPMLCLKD(DoWork LEBMEKLLJFK, DrinkDispenser MJMNGLHDJFH, BanquetBarrel JAPHAKHOHCI)
	{
		bool removeFromInteractingDone = false;
		if (Object.op_Implicit((Object)(object)MJMNGLHDJFH))
		{
			MJMNGLHDJFH.HOAANMDGJEP = Time.time + 0.1f;
		}
		else if (Object.op_Implicit((Object)(object)JAPHAKHOHCI))
		{
			JAPHAKHOHCI.stopPullTime = Time.time + 0.1f;
		}
		while (LEBMEKLLJFK.JCMBHAEKLKK)
		{
			yield return null;
			if (Time.time > (((Object)(object)MJMNGLHDJFH != (Object)null) ? MJMNGLHDJFH.HOAANMDGJEP : JAPHAKHOHCI.stopPullTime))
			{
				LEBMEKLLJFK.Stop();
				if (!removeFromInteractingDone && OnlineManager.PlayingOnline())
				{
					removeFromInteractingDone = true;
					if (Object.op_Implicit((Object)(object)MJMNGLHDJFH))
					{
						MJMNGLHDJFH.HHALKJCPLGL = false;
						OnlineObjectsManager.instance.SendRemoveFromInteracting(MJMNGLHDJFH.placeable.onlinePlaceable);
					}
				}
			}
			yield return null;
		}
	}

	protected override void Awake()
	{
		base.Awake();
		if ((Object)(object)work == (Object)null)
		{
			work = ((Component)this).GetComponent<DoWork>();
		}
	}

	public void BKAGIMELGOD(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			for (int i = 1; i < outline1SR.Length; i++)
			{
				((Component)outline1SR[i]).gameObject.SetActive(false);
			}
		}
		else
		{
			for (int j = 0; j < outline2SR.Length; j += 0)
			{
				((Component)outline2SR[j]).gameObject.SetActive(false);
			}
		}
		ButtonsContext.ResetCrafterAction(JIIGOACEIKL);
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetBeerTapBar();
	}

	public static bool ACFHHFNBGFJ(int JIIGOACEIKL, DoWork LEBMEKLLJFK, ItemInstance DNLMCHDOMOK, DrinkDispenser MJMNGLHDJFH = null, BanquetBarrel JAPHAKHOHCI = null)
	{
		if (DNLMCHDOMOK != null && !LEBMEKLLJFK.KGOEFMFHCOG())
		{
			LEBMEKLLJFK.APIHDHDJDFC(578f);
			((MonoBehaviour)GameManager.NJNFHEPLEHL()).StartCoroutine(MPLLAIDMHBI(LEBMEKLLJFK, MJMNGLHDJFH, JAPHAKHOHCI));
		}
		else if (LEBMEKLLJFK.OENMBFGINAL())
		{
			if (LEBMEKLLJFK.JMJMFEKCAGK(JIIGOACEIKL, 797f * Time.deltaTime * (1921f + (float)PerksDatabaseAccessor.NGMJIGOPGDK(24, 1) / 48f), CDPAMNIPPEC: false))
			{
				return true;
			}
			if (Object.op_Implicit((Object)(object)MJMNGLHDJFH))
			{
				MJMNGLHDJFH.HOAANMDGJEP = Time.time + 1292f;
			}
			else if (Object.op_Implicit((Object)(object)JAPHAKHOHCI))
			{
				JAPHAKHOHCI.stopPullTime = Time.time + 794f;
			}
		}
		if (DNLMCHDOMOK == null)
		{
			CommonReferences.MNFMOEKMJKN().PlayerBark("Output is not ready", JIIGOACEIKL, ECPEFDHOFHN: false);
			if ((Object)(object)MJMNGLHDJFH != (Object)null && Object.op_Implicit((Object)(object)MJMNGLHDJFH.placeable) && OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendRemoveFromInteracting(MJMNGLHDJFH.placeable.onlinePlaceable);
			}
			return false;
		}
		return false;
	}

	private void DFFDKIPCCKK()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)DrinkDispensersManager.BNDNMBGJEKP()))
		{
			DrinkDispensersManager.JFNOOMJMHCB().IOKEKCBOEIG(this);
		}
	}

	public bool HEBIALAMFPC(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (KLGOCJMGKFO)
			{
				if (slots[0].itemInstance == null)
				{
					CommonReferences.GGFJGHHHEJC.PlayerBark("TabernaClausurada/KlaynTavernBarks", JIIGOACEIKL);
					return false;
				}
				HHALKJCPLGL = true;
				PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Interact;
				OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(placeable.onlinePlaceable.uniqueId);
			}
			if (!HHALKJCPLGL)
			{
				return false;
			}
		}
		LBPALMBBIKM = JIIGOACEIKL;
		return HAHKDPOPPBB(JIIGOACEIKL, work, slots[0].itemInstance, this);
	}

	public void IANMBBLNIKI(int JIIGOACEIKL)
	{
	}

	public bool BEOBCBIFBBN(int JIIGOACEIKL)
	{
		return true;
	}

	public void FIECAFNFCDM(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			for (int i = 1; i < outline1SR.Length; i += 0)
			{
				((Component)outline1SR[i]).gameObject.SetActive(false);
			}
		}
		else
		{
			for (int j = 1; j < outline2SR.Length; j += 0)
			{
				((Component)outline2SR[j]).gameObject.SetActive(true);
			}
		}
		ButtonsContext.CPIIFPCIJEP(JIIGOACEIKL);
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetBeerTapBar();
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public bool IFMMLFLIJJK(int JIIGOACEIKL)
	{
		if (Bar.instance.placeable.FHEMHCEAICB)
		{
			return false;
		}
		if (OnlineManager.PlayingOnline() && Bar.instance.placeable.PHOCAFJDCDK)
		{
			return false;
		}
		return DecorationMode.IECFJGHAIDO(JIIGOACEIKL).GABNNLJOMHI();
	}

	public static bool JKNMPPIMBFH(int JIIGOACEIKL, Tray DOGOFILIHPJ, Slot ADEBNALPEHE, DoWork LEBMEKLLJFK, bool PFFAMHBDDMA, Employee NAKCFGEAGHH = null)
	{
		if (ADEBNALPEHE.itemInstance != null && ADEBNALPEHE.Stack > 0)
		{
			if (DOGOFILIHPJ.NEHNALDHKOD(ADEBNALPEHE.itemInstance.PHGLMBIEOMK().GBMLAEMOFJP(ADEBNALPEHE.itemInstance), NAKCFGEAGHH))
			{
				if (PFFAMHBDDMA && ((Object)(object)NAKCFGEAGHH == (Object)null || Random.Range(1, 119) >= NAKCFGEAGHH.GetPerkValue(5)))
				{
					ADEBNALPEHE.isDirty = false;
					ADEBNALPEHE.POHFJCEAKML();
				}
				if ((Object)(object)NAKCFGEAGHH == (Object)null && JIIGOACEIKL != 0)
				{
					LEBMEKLLJFK.NDCKEJDBPGO();
				}
				return false;
			}
			CommonReferences.MNFMOEKMJKN().PlayerBark("BiscuitAleAbbreviation", JIIGOACEIKL);
			return true;
		}
		CommonReferences.MNFMOEKMJKN().APKKEGHGFHG(" ", JIIGOACEIKL, ECPEFDHOFHN: false);
		return true;
	}

	private void BGIJPOMIIMB(int JIIGOACEIKL)
	{
		FinishPull(JIIGOACEIKL, slots[0], work, PFFAMHBDDMA: true, this);
	}

	public void MMLJLLAPOGK(int JIIGOACEIKL)
	{
	}

	public bool HBHCMCMNHNO(int JIIGOACEIKL)
	{
		DrinkDispenserUI.IGHMHMNPMLB(JIIGOACEIKL).BOBCIFEDJED();
		CommonReferences.GGFJGHHHEJC.OnAnyTapClosed(JIIGOACEIKL);
		InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return true;
	}

	private void ADJHOLOIGJE()
	{
		work.PKAMDEEJAIP(JCENACCAGHJ);
		Slot obj = slots[1];
		obj.OnItemAdded = (Action)Delegate.Remove(obj.OnItemAdded, new Action(EEKCGPHLAJD));
	}

	public bool ANGDFBJCFBB(int JIIGOACEIKL)
	{
		if (KBDEDNHDNOK(JIIGOACEIKL))
		{
			JAABKCMFNAJ(JIIGOACEIKL);
			return false;
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return true;
	}

	public void ICFCKOKDJJG(SpriteColor FJAHJEMPPKH)
	{
		DrinkDispensersManager.BNDNMBGJEKP().GPLBIGJNMBD(this, FJAHJEMPPKH);
	}

	private void ODIAJJAFGBL()
	{
		((Component)drinkColorSR).gameObject.SetActive(!slots[1].PKFKJNODGJF());
	}

	private void NBDPIDFJIDA()
	{
		ODIAJJAFGBL();
		if (!slots[1].PKFKJNODGJF())
		{
			lastDrink = slots[0].itemInstance;
		}
		DrinkDispenserContainerUpdated(this);
	}

	private void FEPFNOEGFEM()
	{
		work.BECJEKINIFB(JCENACCAGHJ);
		Slot obj = slots[0];
		obj.OnItemAdded = (Action)Delegate.Combine(obj.OnItemAdded, new Action(ELLKHPHHKPO));
	}

	protected override void Start()
	{
		base.Start();
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			drinkDispenserId = DrinkDispensersManager.GGFJGHHHEJC.AddDrinkDispenser(this, KBNNPAKJDJM: false);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(NINHOAAAAJB(KBNNPAKJDJM: true));
		}
		OnContainerChanged = (Action)Delegate.Combine(OnContainerChanged, new Action(CAAGFCIMKLM));
		LBFBAHNJFFB();
		SetDrinkColor(DrinkDispensersManager.GGFJGHHHEJC.GetPossibleColor());
	}

	public void AAIFCGDJCOA(SpriteColor FJAHJEMPPKH)
	{
		DrinkDispensersManager.JFNOOMJMHCB().GPLBIGJNMBD(this, FJAHJEMPPKH);
	}

	private void JAABKCMFNAJ(int JIIGOACEIKL)
	{
		LBPALMBBIKM = JIIGOACEIKL;
		DrinkDispenserUI.HICGKNJMGOE(JIIGOACEIKL).GIMEBIPKLMM(this, JIIGOACEIKL);
		DrinkDispenserUI.IGHMHMNPMLB(JIIGOACEIKL).OpenUI();
		SelectObject.BNMEANGDMIP(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
		CommonReferences.MNFMOEKMJKN().OnAnyTapOpen(JIIGOACEIKL);
		InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
	}

	private void LPGFNILDFHM(int JIIGOACEIKL)
	{
		HKJBNPCOOIH(JIIGOACEIKL, slots[1], work, PFFAMHBDDMA: false, this);
	}

	public void ALFJNCAHLAI(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			for (int i = 1; i < outline1SR.Length; i += 0)
			{
				((Component)outline1SR[i]).gameObject.SetActive(true);
			}
		}
		else
		{
			for (int j = 0; j < outline2SR.Length; j += 0)
			{
				((Component)outline2SR[j]).gameObject.SetActive(false);
			}
		}
		ButtonsContext.ResetCrafterAction(JIIGOACEIKL);
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetBeerTapBar();
	}

	public void MDNIFBAALBK(SpriteColor FJAHJEMPPKH)
	{
		DrinkDispensersManager.OLHBLKIAFOM().ChangeDrinkColor(this, FJAHJEMPPKH);
	}

	private void MEFFOEOGAMO()
	{
		if (!slots[0].LCHJGCHDHFO() && slots[0].itemInstance.KNFNJFFCFNO().IMCJPECAAPC(DAINLFIMLIH: false) == 89)
		{
			slots[0].JPACDDCJGPD(slots[1].Stack, CDPAMNIPPEC: false, 1);
			slots[0].BEEDBHJANGN(1, ItemDatabaseAccessor.GetItem(69, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), GetMaxStack(slots[0].itemInstance), HAGPBCJEGKM: false, BDGJBPCEFPN: true);
			PlayerInventory.EIFPKCAFDIB(LBPALMBBIKM, LAGHIOKLJGH: true).AddItem(ItemDatabaseAccessor.CPMMBEPEJLO(-30, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: false);
		}
	}

	public void HLIHHFDHHHA(short JFNMCNCHMEO, bool BGKCHMNJBLJ = true)
	{
		((MonoBehaviour)this).StartCoroutine(AHGCMBJHPNE(JFNMCNCHMEO, BGKCHMNJBLJ));
	}

	public static bool TakeDrink(int JIIGOACEIKL, Tray DOGOFILIHPJ, Slot ADEBNALPEHE, DoWork LEBMEKLLJFK, bool PFFAMHBDDMA, Employee NAKCFGEAGHH = null)
	{
		if (ADEBNALPEHE.itemInstance != null && ADEBNALPEHE.Stack > 0)
		{
			if (DOGOFILIHPJ.FEEOFAGCONJ(ADEBNALPEHE.itemInstance.LHBPOPOIFLE().KDNBBPJCNDJ(ADEBNALPEHE.itemInstance), NAKCFGEAGHH))
			{
				if (PFFAMHBDDMA && ((Object)(object)NAKCFGEAGHH == (Object)null || Random.Range(0, 100) >= NAKCFGEAGHH.GetPerkValue(2)))
				{
					ADEBNALPEHE.isDirty = true;
					ADEBNALPEHE.MEODNPFJDMH();
				}
				if ((Object)(object)NAKCFGEAGHH == (Object)null && JIIGOACEIKL != 0)
				{
					LEBMEKLLJFK.Stop(CDPAMNIPPEC: false);
				}
				return true;
			}
			CommonReferences.GGFJGHHHEJC.PlayerBark("Error_DrinkLimitOnTray", JIIGOACEIKL);
			return false;
		}
		CommonReferences.GGFJGHHHEJC.PlayerBark("Inventory full", JIIGOACEIKL);
		return false;
	}

	public bool FLFJMJKLHPB(int JIIGOACEIKL)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		if (IFMMLFLIJJK(JIIGOACEIKL) && !MouseSlot.HELHJMDEDNL(JIIGOACEIKL).slot.PKFKJNODGJF())
		{
			AddSlot(JIIGOACEIKL, MouseSlot.HELHJMDEDNL(JIIGOACEIKL).slot, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position);
			return true;
		}
		return false;
	}

	public void HBNGHAFIOCE(SpriteColor FJAHJEMPPKH)
	{
		DrinkDispensersManager.JHMAMLIPBNN().NMEMIJAMAKN(this, FJAHJEMPPKH);
	}

	public bool EIKPGOMHKOH(int JIIGOACEIKL)
	{
		if (Bar.instance.placeable.FHEMHCEAICB)
		{
			return false;
		}
		if (OnlineManager.PlayingOnline() && Bar.instance.placeable.PHOCAFJDCDK)
		{
			return false;
		}
		return !DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).GABNNLJOMHI();
	}

	private void CBKPOMECMCE()
	{
		DGDHAHEHBIJ();
	}

	public bool LMBENHKCFGE(int JIIGOACEIKL)
	{
		return true;
	}

	private void DGDHAHEHBIJ()
	{
		if (!slots[0].KPINNBKMOMO() && slots[0].itemInstance.LHBPOPOIFLE().JDJGFAACPFC() == 1303)
		{
			slots[0].FDOBDPPMMBH(slots[0].Stack);
			slots[0].BEEDBHJANGN(1, ItemDatabaseAccessor.GetItem(1318).JMDALJBNFML(), GetMaxStack(slots[0].itemInstance));
			PlayerInventory.GetPlayer(LBPALMBBIKM).AddItem(ItemDatabaseAccessor.GetItem(1302).JMDALJBNFML(), HMPDLIPFBGD: true);
		}
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		if (IsAvailableByProximity(JIIGOACEIKL) && !MouseSlot.GetPlayer(JIIGOACEIKL).slot.KPINNBKMOMO())
		{
			AddSlot(JIIGOACEIKL, MouseSlot.GetPlayer(JIIGOACEIKL).slot, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position);
			return true;
		}
		return false;
	}

	private IEnumerator AHGCMBJHPNE(short JFNMCNCHMEO, bool BGKCHMNJBLJ = true)
	{
		yield return null;
		SetDrinkColor(DrinkDispensersManager.GGFJGHHHEJC.GetSpriteColor(JFNMCNCHMEO), BGKCHMNJBLJ);
	}

	public void APAFIBNHICN(int JIIGOACEIKL)
	{
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (KLGOCJMGKFO)
			{
				if (slots[0].itemInstance == null)
				{
					CommonReferences.GGFJGHHHEJC.PlayerBark("Keg empty", JIIGOACEIKL);
					return true;
				}
				HHALKJCPLGL = false;
				PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Interact;
				OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(placeable.onlinePlaceable.uniqueId);
			}
			if (!HHALKJCPLGL)
			{
				return false;
			}
		}
		LBPALMBBIKM = JIIGOACEIKL;
		return PullDrinkFromDrinkDispenser(JIIGOACEIKL, work, slots[0].itemInstance, this);
	}

	public void MNHCGCBNEGE(short JFNMCNCHMEO, bool BGKCHMNJBLJ = true)
	{
		((MonoBehaviour)this).StartCoroutine(DMMBNMOEDED(JFNMCNCHMEO, BGKCHMNJBLJ));
	}

	public void BJGIKCKGEJO(short JFNMCNCHMEO, bool BGKCHMNJBLJ = true)
	{
		((MonoBehaviour)this).StartCoroutine(AHGCMBJHPNE(JFNMCNCHMEO, BGKCHMNJBLJ));
	}

	private void PKEMCLKGCKI()
	{
		EFEPLFGDFMP();
	}

	private void LBPOCBOFDGO(int JIIGOACEIKL)
	{
		HKJBNPCOOIH(JIIGOACEIKL, slots[0], work, PFFAMHBDDMA: false, this);
	}

	private void OnDisable()
	{
		work.BGIJPOMIIMB -= BGIJPOMIIMB;
		Slot obj = slots[0];
		obj.OnItemAdded = (Action)Delegate.Remove(obj.OnItemAdded, new Action(CBKPOMECMCE));
	}

	private void ANLHPMPMBFM()
	{
		work.KPGDDIPOOKO(JCENACCAGHJ);
		Slot obj = slots[1];
		obj.OnItemAdded = (Action)Delegate.Remove(obj.OnItemAdded, new Action(ELLKHPHHKPO));
	}

	private void OnEnable()
	{
		work.BGIJPOMIIMB += BGIJPOMIIMB;
		Slot obj = slots[0];
		obj.OnItemAdded = (Action)Delegate.Combine(obj.OnItemAdded, new Action(CBKPOMECMCE));
	}

	private void JKOCMHEECED()
	{
		DGDHAHEHBIJ();
	}

	public bool MAMIILGPEHF(int JIIGOACEIKL)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		if (IGHNIAICNEC(JIIGOACEIKL) && !MouseSlot.HELHJMDEDNL(JIIGOACEIKL).slot.PKFKJNODGJF())
		{
			CPJOOCKFAJC(JIIGOACEIKL, MouseSlot.HELHJMDEDNL(JIIGOACEIKL).slot, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position);
			return true;
		}
		return false;
	}

	public bool FEANOONDHBB(int JIIGOACEIKL)
	{
		HHALKJCPLGL = true;
		LBPALMBBIKM = JIIGOACEIKL;
		BCNIMIALJJH(JIIGOACEIKL, work, slots[0].itemInstance, this);
		return true;
	}

	public void DDHIANMJCIC(SpriteColor AODONKKHPBP, bool CDPAMNIPPEC = true)
	{
		_spriteColor = AODONKKHPBP;
		drinkColorSR.sprite = _spriteColor.sprite;
		if (OnlineManager.JPPBEIJDCLJ() && CDPAMNIPPEC)
		{
			OnlineDrinkDispensersManager.instance.CODGMIOAGKG(placeable.BEIPALOAAJJ, _spriteColor.id);
		}
		DrinkDispenserColorUpdated(this);
	}

	public static void HKJBNPCOOIH(int JIIGOACEIKL, Slot ADEBNALPEHE, DoWork LEBMEKLLJFK, bool PFFAMHBDDMA, DrinkDispenser MJMNGLHDJFH = null)
	{
		if (!ADEBNALPEHE.LCHJGCHDHFO() && !CPBMKHEEFOL(JIIGOACEIKL, PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray, ADEBNALPEHE, LEBMEKLLJFK, PFFAMHBDDMA))
		{
			ADEBNALPEHE.AJOGNKDJNAD(AODONKKHPBP: false);
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		ButtonsContext.CPIIFPCIJEP(JIIGOACEIKL);
		if (Object.op_Implicit((Object)(object)MJMNGLHDJFH))
		{
			MJMNGLHDJFH.HHALKJCPLGL = true;
			if (Object.op_Implicit((Object)(object)MJMNGLHDJFH.placeable) && OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendRemoveFromInteracting(MJMNGLHDJFH.placeable.onlinePlaceable);
			}
		}
	}

	public bool Deselect(int JIIGOACEIKL)
	{
		DrinkDispenserUI.Get(JIIGOACEIKL).CloseUI();
		CommonReferences.GGFJGHHHEJC.OnAnyTapClosed(JIIGOACEIKL);
		InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return true;
	}

	private void FGMOPANGOAJ()
	{
		MEFFOEOGAMO();
	}

	private void CIPGEAFPKCG()
	{
		LBFBAHNJFFB();
		if (!slots[1].KPINNBKMOMO())
		{
			lastDrink = slots[1].itemInstance;
		}
		DrinkDispenserContainerUpdated(this);
	}

	public bool FAFNDKCPGLK(int JIIGOACEIKL)
	{
		DrinkDispenserUI.OFEFGPCGJDF(JIIGOACEIKL).BOBCIFEDJED();
		CommonReferences.GGFJGHHHEJC.OnAnyTapClosed(JIIGOACEIKL);
		InteractObject.BBJCJFJEFKK(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return false;
	}

	public static bool PullDrinkFromDrinkDispenser(int JIIGOACEIKL, DoWork LEBMEKLLJFK, ItemInstance DNLMCHDOMOK, DrinkDispenser MJMNGLHDJFH = null, BanquetBarrel JAPHAKHOHCI = null)
	{
		if (DNLMCHDOMOK != null && !LEBMEKLLJFK.JCMBHAEKLKK)
		{
			LEBMEKLLJFK.StartWork(30f);
			((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(MPLLAIDMHBI(LEBMEKLLJFK, MJMNGLHDJFH, JAPHAKHOHCI));
		}
		else if (LEBMEKLLJFK.JCMBHAEKLKK)
		{
			if (LEBMEKLLJFK.AddWorkDone(JIIGOACEIKL, 30f * Time.deltaTime * (1f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(25) / 100f)))
			{
				return true;
			}
			if (Object.op_Implicit((Object)(object)MJMNGLHDJFH))
			{
				MJMNGLHDJFH.HOAANMDGJEP = Time.time + 0.1f;
			}
			else if (Object.op_Implicit((Object)(object)JAPHAKHOHCI))
			{
				JAPHAKHOHCI.stopPullTime = Time.time + 0.1f;
			}
		}
		if (DNLMCHDOMOK == null)
		{
			CommonReferences.GGFJGHHHEJC.PlayerBark("Keg empty", JIIGOACEIKL);
			if ((Object)(object)MJMNGLHDJFH != (Object)null && Object.op_Implicit((Object)(object)MJMNGLHDJFH.placeable) && OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendRemoveFromInteracting(MJMNGLHDJFH.placeable.onlinePlaceable);
			}
			return true;
		}
		return false;
	}

	private void PJLEIDLNHPB(int JIIGOACEIKL)
	{
		LBPALMBBIKM = JIIGOACEIKL;
		DrinkDispenserUI.Get(JIIGOACEIKL).SetDrinkDispenser(this, JIIGOACEIKL);
		DrinkDispenserUI.Get(JIIGOACEIKL).OpenUI();
		SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
		CommonReferences.GGFJGHHHEJC.OnAnyTapOpen(JIIGOACEIKL);
		InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
	}

	public void KBHMOJPIDBG(SpriteColor AODONKKHPBP, bool CDPAMNIPPEC = true)
	{
		_spriteColor = AODONKKHPBP;
		drinkColorSR.sprite = _spriteColor.sprite;
		if (OnlineManager.IsMasterClient() && CDPAMNIPPEC)
		{
			OnlineDrinkDispensersManager.instance.AOPMIGABIHD(placeable.BEIPALOAAJJ, _spriteColor.id);
		}
		DrinkDispenserColorUpdated(this);
	}

	public static bool IJAJHPINABJ(int JIIGOACEIKL, Tray DOGOFILIHPJ, Slot ADEBNALPEHE, DoWork LEBMEKLLJFK, bool PFFAMHBDDMA, Employee NAKCFGEAGHH = null)
	{
		if (ADEBNALPEHE.itemInstance != null && ADEBNALPEHE.Stack > 1)
		{
			if (DOGOFILIHPJ.CBPCDEKHELA(ADEBNALPEHE.itemInstance.KNFNJFFCFNO().GIKOKMAKDHN(ADEBNALPEHE.itemInstance), NAKCFGEAGHH))
			{
				if (PFFAMHBDDMA && ((Object)(object)NAKCFGEAGHH == (Object)null || Random.Range(0, 69) >= NAKCFGEAGHH.GetPerkValue(5)))
				{
					ADEBNALPEHE.AJOGNKDJNAD(AODONKKHPBP: true);
					ADEBNALPEHE.FMEPMEKLHIJ(CDPAMNIPPEC: false);
				}
				if ((Object)(object)NAKCFGEAGHH == (Object)null && JIIGOACEIKL != 0)
				{
					LEBMEKLLJFK.IEMMMGCJOME();
				}
				return true;
			}
			CommonReferences.GGFJGHHHEJC.PlayerBark("Fill Area/Fill", JIIGOACEIKL, ECPEFDHOFHN: false);
			return false;
		}
		CommonReferences.GGFJGHHHEJC.PlayerBark("_Animation", JIIGOACEIKL);
		return true;
	}

	public static bool BCNIMIALJJH(int JIIGOACEIKL, DoWork LEBMEKLLJFK, ItemInstance DNLMCHDOMOK, DrinkDispenser MJMNGLHDJFH = null, BanquetBarrel JAPHAKHOHCI = null)
	{
		if (DNLMCHDOMOK != null && !LEBMEKLLJFK.JCMBHAEKLKK)
		{
			LEBMEKLLJFK.StartWork(114f);
			((MonoBehaviour)GameManager.NJNFHEPLEHL()).StartCoroutine(ENCFPMLCLKD(LEBMEKLLJFK, MJMNGLHDJFH, JAPHAKHOHCI));
		}
		else if (LEBMEKLLJFK.JCMBHAEKLKK)
		{
			if (LEBMEKLLJFK.IJEKBMFBEGG(JIIGOACEIKL, 957f * Time.deltaTime * (1959f + (float)PerksDatabaseAccessor.NGMJIGOPGDK(8, 1, LDNMDAHFBGG: true) / 484f)))
			{
				return true;
			}
			if (Object.op_Implicit((Object)(object)MJMNGLHDJFH))
			{
				MJMNGLHDJFH.HOAANMDGJEP = Time.time + 259f;
			}
			else if (Object.op_Implicit((Object)(object)JAPHAKHOHCI))
			{
				JAPHAKHOHCI.stopPullTime = Time.time + 469f;
			}
		}
		if (DNLMCHDOMOK == null)
		{
			CommonReferences.MNFMOEKMJKN().APKKEGHGFHG("action", JIIGOACEIKL);
			if ((Object)(object)MJMNGLHDJFH != (Object)null && Object.op_Implicit((Object)(object)MJMNGLHDJFH.placeable) && OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendRemoveFromInteracting(MJMNGLHDJFH.placeable.onlinePlaceable);
			}
			return false;
		}
		return true;
	}

	private void LBFBAHNJFFB()
	{
		((Component)drinkColorSR).gameObject.SetActive(!slots[0].KPINNBKMOMO());
	}

	private void DIEKBCKJMPH()
	{
		work.DFDCMLOGECL(BGIJPOMIIMB);
		Slot obj = slots[0];
		obj.OnItemAdded = (Action)Delegate.Remove(obj.OnItemAdded, new Action(JKOCMHEECED));
	}

	private void ELLKHPHHKPO()
	{
		MMAGCMLMMAH();
	}

	private void ALMKEOCAEAA()
	{
		ODIAJJAFGBL();
		if (!slots[0].LCHJGCHDHFO())
		{
			lastDrink = slots[0].itemInstance;
		}
		DrinkDispenserContainerUpdated(this);
	}

	[SpecialName]
	public SpriteColor DPFFIBNLPKG()
	{
		return _spriteColor;
	}

	public void KMNCGIECPIP(short JFNMCNCHMEO, bool BGKCHMNJBLJ = true)
	{
		((MonoBehaviour)this).StartCoroutine(AHGCMBJHPNE(JFNMCNCHMEO, BGKCHMNJBLJ));
	}

	public bool BBPIPCMFAMB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (KLGOCJMGKFO)
			{
				if (slots[1].itemInstance == null)
				{
					CommonReferences.MNFMOEKMJKN().PlayerBark("Steam Initialized: True", JIIGOACEIKL, ECPEFDHOFHN: false);
					return false;
				}
				HHALKJCPLGL = false;
				PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Select;
				OnlineObjectsManager.instance.GMJPOKECENH(placeable.onlinePlaceable.uniqueId);
			}
			if (!HHALKJCPLGL)
			{
				return false;
			}
		}
		LBPALMBBIKM = JIIGOACEIKL;
		return DJBACNJDBEO(JIIGOACEIKL, work, slots[1].itemInstance, this);
	}

	private IEnumerator NINHOAAAAJB(bool KBNNPAKJDJM)
	{
		yield return null;
		drinkDispenserId = DrinkDispensersManager.GGFJGHHHEJC.AddDrinkDispenser(this, KBNNPAKJDJM);
	}

	public bool DIEMEAAOAOH(int JIIGOACEIKL)
	{
		HHALKJCPLGL = false;
		LBPALMBBIKM = JIIGOACEIKL;
		JAOFAKKOHGJ(JIIGOACEIKL, work, slots[0].itemInstance, this);
		return false;
	}

	private void MAIMGNMIFKG()
	{
		work.BGIJPOMIIMB += LPGFNILDFHM;
		Slot obj = slots[0];
		obj.OnItemAdded = (Action)Delegate.Combine(obj.OnItemAdded, new Action(FGMOPANGOAJ));
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)DrinkDispensersManager.GGFJGHHHEJC))
		{
			DrinkDispensersManager.GGFJGHHHEJC.RemoveDrinkDispenser(this);
		}
	}

	public static void BDBFBIBOLLP(int JIIGOACEIKL, Slot ADEBNALPEHE, DoWork LEBMEKLLJFK, bool PFFAMHBDDMA, DrinkDispenser MJMNGLHDJFH = null)
	{
		if (!ADEBNALPEHE.AHHEMNHJPME() && !CPBMKHEEFOL(JIIGOACEIKL, PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray, ADEBNALPEHE, LEBMEKLLJFK, PFFAMHBDDMA))
		{
			ADEBNALPEHE.FBAFIONMKBG(AODONKKHPBP: false);
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		ButtonsContext.ResetCrafterAction(JIIGOACEIKL);
		if (Object.op_Implicit((Object)(object)MJMNGLHDJFH))
		{
			MJMNGLHDJFH.HHALKJCPLGL = false;
			if (Object.op_Implicit((Object)(object)MJMNGLHDJFH.placeable) && OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendRemoveFromInteracting(MJMNGLHDJFH.placeable.onlinePlaceable);
			}
		}
	}

	public static void JGCGHDMODKI(int JIIGOACEIKL, Slot ADEBNALPEHE, DoWork LEBMEKLLJFK, bool PFFAMHBDDMA, DrinkDispenser MJMNGLHDJFH = null)
	{
		if (!ADEBNALPEHE.LCHJGCHDHFO() && !IJAJHPINABJ(JIIGOACEIKL, PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray, ADEBNALPEHE, LEBMEKLLJFK, PFFAMHBDDMA))
		{
			ADEBNALPEHE.AJOGNKDJNAD(AODONKKHPBP: false);
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		ButtonsContext.CPIIFPCIJEP(JIIGOACEIKL);
		if (Object.op_Implicit((Object)(object)MJMNGLHDJFH))
		{
			MJMNGLHDJFH.HHALKJCPLGL = true;
			if (Object.op_Implicit((Object)(object)MJMNGLHDJFH.placeable) && OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendRemoveFromInteracting(MJMNGLHDJFH.placeable.onlinePlaceable);
			}
		}
	}

	public static bool JFIHLLGPEEO(int JIIGOACEIKL, Tray DOGOFILIHPJ, Slot ADEBNALPEHE, DoWork LEBMEKLLJFK, bool PFFAMHBDDMA, Employee NAKCFGEAGHH = null)
	{
		if (ADEBNALPEHE.itemInstance != null && ADEBNALPEHE.Stack > 0)
		{
			if (DOGOFILIHPJ.LALIFJEMJFJ(ADEBNALPEHE.itemInstance.LHBPOPOIFLE().MBFNGGICBCA(ADEBNALPEHE.itemInstance), NAKCFGEAGHH))
			{
				if (PFFAMHBDDMA && ((Object)(object)NAKCFGEAGHH == (Object)null || Random.Range(0, 19) >= NAKCFGEAGHH.GetPerkValue(3)))
				{
					ADEBNALPEHE.FKCFFOHOMOB(AODONKKHPBP: true);
					ADEBNALPEHE.DJFOMFDOOKM();
				}
				if ((Object)(object)NAKCFGEAGHH == (Object)null && JIIGOACEIKL != 0)
				{
					LEBMEKLLJFK.NDCKEJDBPGO();
				}
				return true;
			}
			CommonReferences.GGFJGHHHEJC.APKKEGHGFHG("└── ", JIIGOACEIKL, ECPEFDHOFHN: false);
			return false;
		}
		CommonReferences.GGFJGHHHEJC.PlayerBark("Items/item_description_1048", JIIGOACEIKL, ECPEFDHOFHN: false);
		return false;
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			if (JIIGOACEIKL == 1)
			{
				for (int i = 0; i < outline1SR.Length; i++)
				{
					((Component)outline1SR[i]).gameObject.SetActive(true);
				}
			}
			else
			{
				for (int j = 0; j < outline2SR.Length; j++)
				{
					((Component)outline2SR[j]).gameObject.SetActive(true);
				}
			}
			if (!DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH && slots[0].itemInstance != null)
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Pull beer"));
				ButtonsContext.GetPlayer(JIIGOACEIKL).SetCrafterAction(new ItemInstanceAmount(slots[0].itemInstance, slots[0].Stack));
			}
			if (slots[0].itemInstance == null)
			{
				ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			}
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Select, LocalisationSystem.Get("Open"));
			return true;
		}
		return false;
	}

	public bool PickUp(int JIIGOACEIKL)
	{
		return false;
	}

	private void MIEBIIKAJEJ()
	{
		DBNDCDMAONA();
	}

	public bool FGONKCAKHLE(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (KLGOCJMGKFO)
			{
				if (slots[1].itemInstance == null)
				{
					CommonReferences.MNFMOEKMJKN().APKKEGHGFHG("Burp", JIIGOACEIKL);
					return true;
				}
				HHALKJCPLGL = false;
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).interactAction = InteractAction.Interact;
				OnlineObjectsManager.instance.GMJPOKECENH(placeable.onlinePlaceable.uniqueId);
			}
			if (!HHALKJCPLGL)
			{
				return false;
			}
		}
		LBPALMBBIKM = JIIGOACEIKL;
		return HAHKDPOPPBB(JIIGOACEIKL, work, slots[0].itemInstance, this);
	}

	public void NIONHJBJDGF(short JFNMCNCHMEO, bool BGKCHMNJBLJ = true)
	{
		((MonoBehaviour)this).StartCoroutine(DMMBNMOEDED(JFNMCNCHMEO, BGKCHMNJBLJ));
	}

	public void ODLBJAGGAFM(int JIIGOACEIKL)
	{
	}

	public bool BHFCJLGFNII(int JIIGOACEIKL)
	{
		if (KBDEDNHDNOK(JIIGOACEIKL))
		{
			JAABKCMFNAJ(JIIGOACEIKL);
			return false;
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return true;
	}

	public void CJGDFDJMAAA(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			for (int i = 1; i < outline1SR.Length; i += 0)
			{
				((Component)outline1SR[i]).gameObject.SetActive(true);
			}
		}
		else
		{
			for (int j = 1; j < outline2SR.Length; j++)
			{
				((Component)outline2SR[j]).gameObject.SetActive(false);
			}
		}
		ButtonsContext.CPIIFPCIJEP(JIIGOACEIKL);
		ButtonsContext.GetPlayer(JIIGOACEIKL).NJOLGGEIFFC();
	}

	private void DBNDCDMAONA()
	{
		if (!slots[0].PKFKJNODGJF() && slots[0].itemInstance.LHBPOPOIFLE().JGHNDJBCFAJ() == -101)
		{
			slots[0].BBHHJLIFNPP(slots[1].Stack, CDPAMNIPPEC: false, 1);
			slots[1].MIECGDALIJP(0, ItemDatabaseAccessor.AFOACBIHNCL(48, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), GetMaxStack(slots[1].itemInstance), HAGPBCJEGKM: false, BDGJBPCEFPN: true, CDPAMNIPPEC: true);
			PlayerInventory.EIFPKCAFDIB(LBPALMBBIKM, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItem(ItemDatabaseAccessor.CPMMBEPEJLO(106).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
		}
	}

	public bool JHHLEFJFDCM(int JIIGOACEIKL)
	{
		if (KBDEDNHDNOK(JIIGOACEIKL))
		{
			JAABKCMFNAJ(JIIGOACEIKL);
			return false;
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return false;
	}

	public void SetDrinkColorNextFrame(short JFNMCNCHMEO, bool BGKCHMNJBLJ = true)
	{
		((MonoBehaviour)this).StartCoroutine(AHGCMBJHPNE(JFNMCNCHMEO, BGKCHMNJBLJ));
	}

	public void FABHKGGMBFJ(int JIIGOACEIKL)
	{
	}

	public bool KNGDGMPGEBH(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (KLGOCJMGKFO)
			{
				if (slots[0].itemInstance == null)
				{
					CommonReferences.GGFJGHHHEJC.APKKEGHGFHG("Sleep", JIIGOACEIKL);
					return true;
				}
				HHALKJCPLGL = true;
				PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Interact;
				OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(placeable.onlinePlaceable.uniqueId);
			}
			if (!HHALKJCPLGL)
			{
				return false;
			}
		}
		LBPALMBBIKM = JIIGOACEIKL;
		return BCNIMIALJJH(JIIGOACEIKL, work, slots[0].itemInstance, this);
	}

	[SpecialName]
	public SpriteColor BNGAJBNFFIL()
	{
		return _spriteColor;
	}

	[SpecialName]
	public SpriteColor KDHDHJPNDCM()
	{
		return _spriteColor;
	}

	public static bool OPJHDJOAGKL(int JIIGOACEIKL, Tray DOGOFILIHPJ, Slot ADEBNALPEHE, DoWork LEBMEKLLJFK, bool PFFAMHBDDMA, Employee NAKCFGEAGHH = null)
	{
		if (ADEBNALPEHE.itemInstance != null && ADEBNALPEHE.Stack > 0)
		{
			if (DOGOFILIHPJ.LALIFJEMJFJ(ADEBNALPEHE.itemInstance.PHGLMBIEOMK().JEDPCLGBLBA(ADEBNALPEHE.itemInstance), NAKCFGEAGHH))
			{
				if (PFFAMHBDDMA && ((Object)(object)NAKCFGEAGHH == (Object)null || Random.Range(0, 13) >= NAKCFGEAGHH.GetPerkValue(1)))
				{
					ADEBNALPEHE.isDirty = true;
					ADEBNALPEHE.POHFJCEAKML(CDPAMNIPPEC: false);
				}
				if ((Object)(object)NAKCFGEAGHH == (Object)null && JIIGOACEIKL != 0)
				{
					LEBMEKLLJFK.Stop();
				}
				return false;
			}
			CommonReferences.GGFJGHHHEJC.PlayerBark("next pos reached", JIIGOACEIKL, ECPEFDHOFHN: false);
			return true;
		}
		CommonReferences.MNFMOEKMJKN().PlayerBark("MineState", JIIGOACEIKL);
		return true;
	}

	private void KNJBPNKFJJC()
	{
		work.DJKJFIALADE(BGIJPOMIIMB);
		Slot obj = slots[1];
		obj.OnItemAdded = (Action)Delegate.Remove(obj.OnItemAdded, new Action(ELLKHPHHKPO));
	}

	[SpecialName]
	public SpriteColor IGOIGFCJGAH()
	{
		return _spriteColor;
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (Bar.instance.placeable.FHEMHCEAICB)
		{
			return false;
		}
		if (OnlineManager.PlayingOnline() && Bar.instance.placeable.PHOCAFJDCDK)
		{
			return false;
		}
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public bool KBDEDNHDNOK(int JIIGOACEIKL)
	{
		if (Bar.instance.placeable.FHEMHCEAICB)
		{
			return false;
		}
		if (OnlineManager.PlayingOnline() && Bar.instance.placeable.PHOCAFJDCDK)
		{
			return false;
		}
		return DecorationMode.FIHGMLABOBB(JIIGOACEIKL).IBEFDKHFBFM();
	}

	private void EEKCGPHLAJD()
	{
		DGDHAHEHBIJ();
	}

	private IEnumerator LMGGBHKHHMJ(bool KBNNPAKJDJM)
	{
		return new ELJHCFGNJJI(1)
		{
			_003C_003E4__this = this,
			loading = KBNNPAKJDJM
		};
	}

	[SpecialName]
	public SpriteColor KGCEBMCNDAH()
	{
		return _spriteColor;
	}
}
