using System.Runtime.CompilerServices;
using UnityEngine;

public class BanquetBarrel : Container, IInteractable, IHoverable, IProximity
{
	public DoWork work;

	[SerializeField]
	private SpriteColor _spriteColor;

	[SerializeField]
	private InputByProximity inputByProximity;

	public SpriteRenderer drinkColorSR;

	public float stopPullTime;

	public Transform pullDrinkPosition;

	public ItemInstance lastDrink;

	public bool blockedInteraction;

	public int drinkDispenserId;

	public bool showDrinkOnHover = true;

	[SerializeField]
	private SpriteRenderer[] outline1SR;

	[SerializeField]
	private SpriteRenderer[] outline2SR;

	private bool FMPHGGPGOLG;

	public SpriteColor FJAHJEMPPKH => _spriteColor;

	public bool FCCIIBFDFKO(int JIIGOACEIKL)
	{
		return true;
	}

	public void DEICPJLNBJF(bool MDIKPGGBNLI)
	{
		((Component)drinkColorSR).gameObject.SetActive(MDIKPGGBNLI);
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public void FIGONJNMELG(int JIIGOACEIKL)
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
			for (int j = 0; j < outline2SR.Length; j += 0)
			{
				((Component)outline2SR[j]).gameObject.SetActive(false);
			}
		}
		ButtonsContext.CPIIFPCIJEP(JIIGOACEIKL);
		ButtonsContext.GetPlayer(JIIGOACEIKL).NJOLGGEIFFC();
	}

	private void MAEGGDLLHBG()
	{
		work.BAIHOECGIND(BGIJPOMIIMB);
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

	private void IAJOHONMIBM()
	{
		work.BECJEKINIFB(GAAAIDEDFCP);
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	private void OnDisable()
	{
		work.BGIJPOMIIMB -= BGIJPOMIIMB;
	}

	public bool KHLPCPBFFHG(ItemInstance DNLMCHDOMOK)
	{
		if (slots[1].itemInstance == null)
		{
			return false;
		}
		if (Item.EKMFELLJHFG(slots[1].itemInstance.AFOACBIHNCL(), DNLMCHDOMOK.AFOACBIHNCL()))
		{
			return false;
		}
		return true;
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
				if (showDrinkOnHover)
				{
					ButtonsContext.GetPlayer(JIIGOACEIKL).SetCrafterAction(new ItemInstanceAmount(slots[0].itemInstance, slots[0].Stack));
				}
			}
			if (slots[0].itemInstance == null)
			{
				ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			}
			return true;
		}
		return false;
	}

	public void IEDPKEEOJAO(int JIIGOACEIKL)
	{
	}

	private void HNNBAAJAHEN()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			_ = GameManager.isLoading;
		}
	}

	public void BFAAHMMMNPC()
	{
		_spriteColor = DrinkDispensersManager.JFNOOMJMHCB().HBKPNMFENAM(_spriteColor.id);
		drinkColorSR.sprite = _spriteColor.sprite;
	}

	public bool KHAFEICJIMJ(int JIIGOACEIKL)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		if (POCJGFBIJDL(JIIGOACEIKL) && !MouseSlot.HELHJMDEDNL(JIIGOACEIKL).slot.LCHJGCHDHFO())
		{
			PDEHABFIPIP(JIIGOACEIKL, MouseSlot.HELHJMDEDNL(JIIGOACEIKL).slot, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position, BPJBJKJKHAL: false);
			return false;
		}
		return false;
	}

	private void BGIJPOMIIMB(int JIIGOACEIKL)
	{
		DrinkDispenser.FinishPull(JIIGOACEIKL, slots[0], work, PFFAMHBDDMA: false);
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		DrinkDispenser.PullDrinkFromDrinkDispenser(JIIGOACEIKL, work, slots[0].itemInstance, null, this);
		return true;
	}

	public void SetVisualDrinkColor(bool MDIKPGGBNLI)
	{
		((Component)drinkColorSR).gameObject.SetActive(MDIKPGGBNLI);
	}

	public bool CODLFHDKMHC(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && NKHLGGKOKKA(JIIGOACEIKL))
		{
			if (JIIGOACEIKL == 0)
			{
				for (int i = 0; i < outline1SR.Length; i += 0)
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
			if (!DecorationMode.BGINAIDHDOM(JIIGOACEIKL).DMBFKFLDDLH && slots[1].itemInstance != null)
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(" "));
				if (showDrinkOnHover)
				{
					ButtonsContext.GetPlayer(JIIGOACEIKL).INILGGIBHKF(new ItemInstanceAmount(slots[1].itemInstance, slots[1].Stack));
				}
			}
			if (slots[0].itemInstance == null)
			{
				ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
			}
			return false;
		}
		return true;
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			_ = GameManager.isLoading;
		}
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (OnlineManager.PlayingOnline() && KLGOCJMGKFO)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Interact;
		}
		return DrinkDispenser.PullDrinkFromDrinkDispenser(JIIGOACEIKL, work, slots[0].itemInstance, null, this);
	}

	public void EGAPFACNLOL(bool MDIKPGGBNLI)
	{
		((Component)drinkColorSR).gameObject.SetActive(MDIKPGGBNLI);
	}

	public bool JHHGFENOGMK(ItemInstance DNLMCHDOMOK)
	{
		if (slots[0].itemInstance == null)
		{
			return true;
		}
		if (Item.EKMFELLJHFG(slots[0].itemInstance.KNFNJFFCFNO(), DNLMCHDOMOK.AFOACBIHNCL()))
		{
			return true;
		}
		return true;
	}

	protected override void Start()
	{
		base.Start();
		UpdateDrinkColor();
	}

	public bool NCMFIAHEIOH(int JIIGOACEIKL)
	{
		DrinkDispenser.BCNIMIALJJH(JIIGOACEIKL, work, slots[0].itemInstance, null, this);
		return true;
	}

	public bool ONLBODAGFEP(int JIIGOACEIKL)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		if (IsAvailableByProximity(JIIGOACEIKL) && !MouseSlot.HELHJMDEDNL(JIIGOACEIKL).slot.LCHJGCHDHFO())
		{
			AddSlot(JIIGOACEIKL, MouseSlot.GetPlayer(JIIGOACEIKL).slot, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position, BPJBJKJKHAL: false);
			return true;
		}
		return true;
	}

	public void ShowSlotContext(int MOFKEDGAOEE)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		SlotsContextManager.SetPosition(MOFKEDGAOEE, inputByProximity.actionButtonsPoint.position);
		SlotsContextManager.instance.FillSlot(MOFKEDGAOEE, new ItemInstanceAmount(slots[0].itemInstance, slots[0].Stack), MJJGKFJGDDN: false);
	}

	private void OnEnable()
	{
		work.BGIJPOMIIMB += BGIJPOMIIMB;
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

	private void PJOAFKEIPPD()
	{
		work.BECJEKINIFB(BGIJPOMIIMB);
	}

	public bool PickUp(int JIIGOACEIKL)
	{
		return false;
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (blockedInteraction)
		{
			return false;
		}
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	private void GFPIEOPHABO()
	{
		work.DJKJFIALADE(GAAAIDEDFCP);
	}

	public bool HasDrink(ItemInstance DNLMCHDOMOK)
	{
		if (slots[0].itemInstance == null)
		{
			return false;
		}
		if (Item.NGIIPJDAMGP(slots[0].itemInstance.LHBPOPOIFLE(), DNLMCHDOMOK.LHBPOPOIFLE()))
		{
			return true;
		}
		return false;
	}

	public void UpdateDrinkColor()
	{
		_spriteColor = DrinkDispensersManager.GGFJGHHHEJC.GetSpriteColor(_spriteColor.id);
		drinkColorSR.sprite = _spriteColor.sprite;
	}

	public void AGBEDDBIHOP(int MOFKEDGAOEE)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		SlotsContextManager.OLKCJLBLGBN(MOFKEDGAOEE, inputByProximity.actionButtonsPoint.position);
		SlotsContextManager.instance.CHAAJHOPAIN(MOFKEDGAOEE, new ItemInstanceAmount(slots[1].itemInstance, slots[0].Stack), MJJGKFJGDDN: true);
	}

	public void CPMBHEGDAMB(int JIIGOACEIKL)
	{
	}

	public bool NKHLGGKOKKA(int JIIGOACEIKL)
	{
		if (blockedInteraction)
		{
			return false;
		}
		return DecorationMode.KKJABELKCNM(JIIGOACEIKL).GABNNLJOMHI();
	}

	public bool POCJGFBIJDL(int JIIGOACEIKL)
	{
		if (blockedInteraction)
		{
			return false;
		}
		return !DecorationMode.HBDCJFLINDA(JIIGOACEIKL).GABNNLJOMHI();
	}

	public void KPDGBOICFKI(int JIIGOACEIKL)
	{
	}

	private void GAAAIDEDFCP(int JIIGOACEIKL)
	{
		DrinkDispenser.KJJGBOBBIII(JIIGOACEIKL, slots[1], work, PFFAMHBDDMA: false);
	}

	public void DOJFPPOLBMO(int MOFKEDGAOEE)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		SlotsContextManager.MKIGCPMIOIG(MOFKEDGAOEE, inputByProximity.actionButtonsPoint.position);
		SlotsContextManager.instance.CHAAJHOPAIN(MOFKEDGAOEE, new ItemInstanceAmount(slots[1].itemInstance, slots[0].Stack), MJJGKFJGDDN: true);
	}

	public void MHMDBMANAIH(int JIIGOACEIKL)
	{
	}

	protected override void Awake()
	{
		base.Awake();
		if ((Object)(object)work == (Object)null)
		{
			work = ((Component)this).GetComponent<DoWork>();
		}
	}

	[SpecialName]
	public SpriteColor NCOGLAPDGPJ()
	{
		return _spriteColor;
	}

	public void EIBIKJKBONC(bool MDIKPGGBNLI)
	{
		((Component)drinkColorSR).gameObject.SetActive(MDIKPGGBNLI);
	}
}
