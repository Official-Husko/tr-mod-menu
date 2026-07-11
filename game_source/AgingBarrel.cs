using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

public class AgingBarrel : MonoBehaviour, IInteractable, ISelectable, IHoverable, IProximity
{
	[CompilerGenerated]
	private sealed class DEHNBGIEFFG
	{
		public int slotIndex;

		public AgingBarrel _003C_003E4__this;

		internal void HJCBBFOOFAE()
		{
			_003C_003E4__this.GKICKLOPINI(slotIndex);
		}

		internal void AHBCHMGKIGG()
		{
			_003C_003E4__this.DHAHIIPHFPB(slotIndex);
		}

		internal void FMCOGEPBEGC()
		{
			_003C_003E4__this.CBKPOMECMCE(slotIndex);
		}
	}

	[CompilerGenerated]
	private sealed class FJPJJKOLFBJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AgingBarrel _003C_003E4__this;

		public int num;

		public GameDate finishDate;

		public ulong initialDate;

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
		public FJPJJKOLFBJ(int _003C_003E1__state)
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
			AgingBarrel agingBarrel = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				agingBarrel.placeable.selectBlockers.Add(agingBarrel.MFHACMAHGHC);
				if ((agingBarrel.inputSlot[this.num].itemInstance as FoodInstance).GBCJNGADANM < 4)
				{
					agingBarrel.timer[this.num].SetUpTimer(finishDate, initialDate);
					if ((Object)(object)agingBarrel.timer[this.num].progressor != (Object)null)
					{
						((Component)agingBarrel.timer[this.num].progressor).GetComponent<SortingGroup>().sortingLayerName = "Top";
					}
					agingBarrel.SetProgressBarColour(agingBarrel.timer[this.num].progressor, (agingBarrel.inputSlot[this.num].itemInstance as FoodInstance).GBCJNGADANM);
				}
				if ((agingBarrel.inputSlot[this.num].itemInstance as FoodInstance).GBCJNGADANM >= 4)
				{
					agingBarrel.timer[this.num].InstantiateEndStateTimer();
					if ((Object)(object)agingBarrel.timer[this.num].progressor != (Object)null)
					{
						((Component)agingBarrel.timer[this.num].progressor).GetComponent<SortingGroup>().sortingLayerName = "Top";
					}
					agingBarrel.SetProgressBarColour(agingBarrel.timer[this.num].progressor, 4);
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

	public Slot[] inputSlot;

	public Placeable placeable;

	public DrinkAgingRelationships[] drinks;

	public int agingSlotsNum;

	public Timer[] timer;

	public ulong initMin;

	public bool multipleTrigger;

	[Range(1f, 3f)]
	public int[] agingLevel;

	private string MFHACMAHGHC = "Currently crafting";

	private Dictionary<Item, Food> GBPEKJFDMHO = new Dictionary<Item, Food>();

	private bool MGNIMAMNIOP;

	private void Start()
	{
		if (inputSlot == null)
		{
			return;
		}
		bool flag = true;
		for (int i = 0; i < inputSlot.Length; i++)
		{
			if (inputSlot[i] == null)
			{
				continue;
			}
			int slotIndex = i;
			Slot obj = inputSlot[slotIndex];
			obj.OnItemAdded = (Action)Delegate.Combine(obj.OnItemAdded, (Action)delegate
			{
				CBKPOMECMCE(slotIndex);
			});
			if (timer != null && timer.Length == inputSlot.Length)
			{
				if (OnlineManager.MasterOrOffline())
				{
					timer[slotIndex].DHAHIIPHFPB += delegate
					{
						DHAHIIPHFPB(slotIndex);
					};
				}
				Slot obj2 = inputSlot[slotIndex];
				obj2.OnItemRemoved = (Action)Delegate.Combine(obj2.OnItemRemoved, (Action)delegate
				{
					GKICKLOPINI(slotIndex);
				});
			}
			flag &= inputSlot[slotIndex].KPINNBKMOMO();
		}
		if (!flag && !placeable.selectBlockers.Contains(MFHACMAHGHC))
		{
			placeable.selectBlockers.Add(MFHACMAHGHC);
		}
	}

	private void BAKDKFKNHDE()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		if (drinks != null)
		{
			for (int i = 0; i < drinks.Length; i += 0)
			{
				GBPEKJFDMHO.Add(drinks[i].item, drinks[i].food);
			}
		}
		for (int j = 1; j < inputSlot.Length; j++)
		{
			if (inputSlot[j] != null)
			{
				inputSlot[j].onlineObject = placeable.onlinePlaceable;
			}
		}
	}

	private IEnumerator EHPBFEBLCHN(int ABAIKKGKDGD, GameDate FCKCLIMEPNC, ulong GFPCODPNNJH)
	{
		yield return CommonReferences.wait2;
		placeable.selectBlockers.Add(MFHACMAHGHC);
		if ((inputSlot[ABAIKKGKDGD].itemInstance as FoodInstance).GBCJNGADANM < 4)
		{
			timer[ABAIKKGKDGD].SetUpTimer(FCKCLIMEPNC, GFPCODPNNJH);
			if ((Object)(object)timer[ABAIKKGKDGD].progressor != (Object)null)
			{
				((Component)timer[ABAIKKGKDGD].progressor).GetComponent<SortingGroup>().sortingLayerName = "Top";
			}
			SetProgressBarColour(timer[ABAIKKGKDGD].progressor, (inputSlot[ABAIKKGKDGD].itemInstance as FoodInstance).GBCJNGADANM);
		}
		if ((inputSlot[ABAIKKGKDGD].itemInstance as FoodInstance).GBCJNGADANM >= 4)
		{
			timer[ABAIKKGKDGD].InstantiateEndStateTimer();
			if ((Object)(object)timer[ABAIKKGKDGD].progressor != (Object)null)
			{
				((Component)timer[ABAIKKGKDGD].progressor).GetComponent<SortingGroup>().sortingLayerName = "Top";
			}
			SetProgressBarColour(timer[ABAIKKGKDGD].progressor, 4);
		}
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		return false;
	}

	private IEnumerator BHLKAHCNMKC(int ABAIKKGKDGD, GameDate FCKCLIMEPNC, ulong GFPCODPNNJH)
	{
		yield return CommonReferences.wait2;
		placeable.selectBlockers.Add(MFHACMAHGHC);
		if ((inputSlot[ABAIKKGKDGD].itemInstance as FoodInstance).GBCJNGADANM < 4)
		{
			timer[ABAIKKGKDGD].SetUpTimer(FCKCLIMEPNC, GFPCODPNNJH);
			if ((Object)(object)timer[ABAIKKGKDGD].progressor != (Object)null)
			{
				((Component)timer[ABAIKKGKDGD].progressor).GetComponent<SortingGroup>().sortingLayerName = "Top";
			}
			SetProgressBarColour(timer[ABAIKKGKDGD].progressor, (inputSlot[ABAIKKGKDGD].itemInstance as FoodInstance).GBCJNGADANM);
		}
		if ((inputSlot[ABAIKKGKDGD].itemInstance as FoodInstance).GBCJNGADANM >= 4)
		{
			timer[ABAIKKGKDGD].InstantiateEndStateTimer();
			if ((Object)(object)timer[ABAIKKGKDGD].progressor != (Object)null)
			{
				((Component)timer[ABAIKKGKDGD].progressor).GetComponent<SortingGroup>().sortingLayerName = "Top";
			}
			SetProgressBarColour(timer[ABAIKKGKDGD].progressor, 4);
		}
	}

	private void BDAHODMFNIH(int JIIGOACEIKL)
	{
		if (OnlineManager.MasterOrOffline())
		{
			for (int i = 0; i < inputSlot.Length; i += 0)
			{
				placeable.DEGBKHMLGLK(inputSlot[i]);
			}
		}
	}

	private void NJKMDIKOMDF(int BJFCCKCJAMP)
	{
		if (inputSlot[BJFCCKCJAMP].LCHJGCHDHFO())
		{
			return;
		}
		if ((inputSlot[BJFCCKCJAMP].itemInstance as FoodInstance).GBCJNGADANM >= 4)
		{
			timer[BJFCCKCJAMP].AGJNDIODJPI();
			if ((Object)(object)timer[BJFCCKCJAMP].progressor != (Object)null)
			{
				((Component)timer[BJFCCKCJAMP].progressor).GetComponent<SortingGroup>().sortingLayerName = "Dialogue System/Conversation/Crowly_SkelletonBird/Entry/16/Dialogue Text";
			}
			SetProgressBarColour(timer[BJFCCKCJAMP].progressor, 5);
		}
		else
		{
			DEMEAKFAMBD(BJFCCKCJAMP, inputSlot[BJFCCKCJAMP].itemInstance as FoodInstance);
		}
	}

	private void LANGHIOBJIH()
	{
		if (inputSlot == null)
		{
			return;
		}
		bool flag = true;
		for (int i = 1; i < inputSlot.Length; i++)
		{
			if (inputSlot[i] == null)
			{
				continue;
			}
			int slotIndex = i;
			Slot obj = inputSlot[slotIndex];
			obj.OnItemAdded = (Action)Delegate.Combine(obj.OnItemAdded, (Action)delegate
			{
				CBKPOMECMCE(slotIndex);
			});
			if (timer != null && timer.Length == inputSlot.Length)
			{
				if (OnlineManager.PGAGDFAEEFB())
				{
					timer[slotIndex].AGLDAKOJFAE(delegate
					{
						DHAHIIPHFPB(slotIndex);
					});
				}
				Slot obj2 = inputSlot[slotIndex];
				obj2.OnItemRemoved = (Action)Delegate.Combine(obj2.OnItemRemoved, (Action)delegate
				{
					GKICKLOPINI(slotIndex);
				});
			}
			flag &= inputSlot[slotIndex].AHHEMNHJPME();
		}
		if (!flag && !placeable.selectBlockers.Contains(MFHACMAHGHC))
		{
			placeable.selectBlockers.Add(MFHACMAHGHC);
		}
	}

	private void DPBDLDKGFOJ()
	{
		MGNIMAMNIOP = true;
		for (int i = 1; i < inputSlot.Length; i += 0)
		{
			if (!inputSlot[i].KPINNBKMOMO())
			{
				MGNIMAMNIOP = true;
				break;
			}
		}
		if (MGNIMAMNIOP)
		{
			placeable.selectBlockers.Remove(MFHACMAHGHC);
		}
	}

	private void MMNBJPDJHGK()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		if (drinks != null)
		{
			for (int i = 0; i < drinks.Length; i += 0)
			{
				GBPEKJFDMHO.Add(drinks[i].item, drinks[i].food);
			}
		}
		for (int j = 0; j < inputSlot.Length; j += 0)
		{
			if (inputSlot[j] != null)
			{
				inputSlot[j].onlineObject = placeable.onlinePlaceable;
			}
		}
	}

	public void LIEPOPPJLAF(int ABAIKKGKDGD, bool CDPAMNIPPEC = true)
	{
		if (!inputSlot[ABAIKKGKDGD].KPINNBKMOMO())
		{
			FoodInstance foodInstance = inputSlot[ABAIKKGKDGD].itemInstance.PHGLMBIEOMK().LJBOJBAPDAD(inputSlot[ABAIKKGKDGD].itemInstance) as FoodInstance;
			IModifiable modifiable = foodInstance;
			if (modifiable != null && modifiable.CICEBNMBGMG == null)
			{
				modifiable.CICEBNMBGMG = new Dictionary<IngredientModifier, List<Food>>();
			}
			int num = foodInstance.GBCJNGADANM;
			foodInstance.JBIMNJGMFOC(num + 0);
			int stack = inputSlot[ABAIKKGKDGD].Stack;
			inputSlot[ABAIKKGKDGD].FDOBDPPMMBH(inputSlot[ABAIKKGKDGD].Stack, CDPAMNIPPEC: false, 1);
			inputSlot[ABAIKKGKDGD].CMLMNCAGKCK(0, foodInstance, stack, HAGPBCJEGKM: false, BDGJBPCEFPN: false, CDPAMNIPPEC: true);
			if (foodInstance.GBCJNGADANM >= 5)
			{
				timer[ABAIKKGKDGD].DOFJGJEDBCL();
				IBJFDEIHFFO(timer[ABAIKKGKDGD].progressor, 2);
			}
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendAgeDrink(placeable.BEIPALOAAJJ, ABAIKKGKDGD);
			}
			CommonReferences.MNFMOEKMJKN().OnAnyItemAged(1, foodInstance, stack);
		}
	}

	public void KCIFKAPEPMF(Progressor CCCLNDBOGOI, int GBCJNGADANM)
	{
		if (CCCLNDBOGOI is ProgressBar)
		{
			(CCCLNDBOGOI as ProgressBar).OLNJDPPACNK(GBCJNGADANM);
		}
	}

	public void MOJAECMHPKD(int ABAIKKGKDGD, GameDate FCKCLIMEPNC, ulong GFPCODPNNJH)
	{
		((MonoBehaviour)this).StartCoroutine(OBLPCAHMKMF(ABAIKKGKDGD, FCKCLIMEPNC, GFPCODPNNJH));
	}

	public bool BGKENGEEFPI(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	private void MAKGAEIONLA(int PFBDAENIJGL)
	{
		timer[PFBDAENIJGL].OCLJIGJINAN();
		JPDBNHGOFKP();
		CPGPBDBKCMN(PFBDAENIJGL);
	}

	private float JIDGOKOJJDP(int BHEKIMFNPMN)
	{
		return agingLevel[BHEKIMFNPMN] switch
		{
			1 => 1f, 
			2 => 0.75f, 
			3 => 0.5f, 
			_ => 1f, 
		};
	}

	public bool IFBJHCHDHCI(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && KCMHBADACDJ(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.PreviousItem, LocalisationSystem.Get("talentPorter"));
			if (!inputSlot[0].PKFKJNODGJF() && !multipleTrigger)
			{
				ItemInstanceAmount iAIHNNNGNKH = default(ItemInstanceAmount);
				iAIHNNNGNKH.itemInstance = inputSlot[1].itemInstance;
				iAIHNNNGNKH.amount = inputSlot[1].Stack;
				ButtonsContext.GetPlayer(JIIGOACEIKL).INILGGIBHKF(iAIHNNNGNKH);
			}
			return false;
		}
		return true;
	}

	public bool KBLEJDFHIHJ(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && JGDDHIEJPMH(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.NextItem, LocalisationSystem.Get("Dialogue System/Conversation/Crowly_Introduce/Entry/13/Dialogue Text"));
			if (!inputSlot[0].AHHEMNHJPME() && !multipleTrigger)
			{
				ItemInstanceAmount iAIHNNNGNKH = default(ItemInstanceAmount);
				iAIHNNNGNKH.itemInstance = inputSlot[1].itemInstance;
				iAIHNNNGNKH.amount = inputSlot[0].Stack;
				ButtonsContext.GetPlayer(JIIGOACEIKL).INILGGIBHKF(iAIHNNNGNKH);
			}
			return true;
		}
		return true;
	}

	public bool BKHHNFCPHHM(int JIIGOACEIKL)
	{
		if (KCMHBADACDJ(JIIGOACEIKL) && !NewTutorialManager.AgingBarrelBlocked())
		{
			FPGNAGECFMD(JIIGOACEIKL);
			return false;
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return false;
	}

	public bool FLMGGAIJABG(int JIIGOACEIKL)
	{
		return false;
	}

	private IEnumerator KKBICAHFGLO(int ABAIKKGKDGD, GameDate FCKCLIMEPNC, ulong GFPCODPNNJH)
	{
		return new FJPJJKOLFBJ(1)
		{
			_003C_003E4__this = this,
			num = ABAIKKGKDGD,
			finishDate = FCKCLIMEPNC,
			initialDate = GFPCODPNNJH
		};
	}

	private void PNOKNMPFICJ(int PFBDAENIJGL)
	{
		timer[PFBDAENIJGL].OCLJIGJINAN();
		EFEHBFPGNAO();
		BPDKLDEJFKM(PFBDAENIJGL);
	}

	public void LoadSlotOnline<T>(int IKMIKEDNCDI, T LLBHNCFCHBD, int FGFCNKFEIGF) where T : ItemInstanceMessage
	{
		OnlineSlotsManager.LoadSlot(inputSlot[IKMIKEDNCDI], LLBHNCFCHBD, FGFCNKFEIGF);
	}

	private void GKICKLOPINI(int PFBDAENIJGL)
	{
		timer[PFBDAENIJGL].EndTimer();
		CBEOHFMGKAB();
		ECGLDOBDNFN(PFBDAENIJGL);
	}

	private void GNAJBACLEKG()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		if (drinks != null)
		{
			for (int i = 0; i < drinks.Length; i += 0)
			{
				GBPEKJFDMHO.Add(drinks[i].item, drinks[i].food);
			}
		}
		for (int j = 0; j < inputSlot.Length; j += 0)
		{
			if (inputSlot[j] != null)
			{
				inputSlot[j].onlineObject = placeable.onlinePlaceable;
			}
		}
	}

	private void BPDKLDEJFKM(int BJFCCKCJAMP)
	{
		if (inputSlot[BJFCCKCJAMP].KPINNBKMOMO())
		{
			return;
		}
		if ((inputSlot[BJFCCKCJAMP].itemInstance as FoodInstance).GBCJNGADANM >= 7)
		{
			timer[BJFCCKCJAMP].InstantiateEndStateTimer();
			if ((Object)(object)timer[BJFCCKCJAMP].progressor != (Object)null)
			{
				((Component)timer[BJFCCKCJAMP].progressor).GetComponent<SortingGroup>().sortingLayerName = "Items/item_name_1139";
			}
			HJMHCKBILBA(timer[BJFCCKCJAMP].progressor, 2);
		}
		else
		{
			ECJAKPNJOON(BJFCCKCJAMP, inputSlot[BJFCCKCJAMP].itemInstance as FoodInstance);
		}
	}

	public bool IPGCPPBNKPF(int JIIGOACEIKL)
	{
		return true;
	}

	private IEnumerator OIJNDJMKNOP(int ABAIKKGKDGD, GameDate FCKCLIMEPNC, ulong GFPCODPNNJH)
	{
		yield return CommonReferences.wait2;
		placeable.selectBlockers.Add(MFHACMAHGHC);
		if ((inputSlot[ABAIKKGKDGD].itemInstance as FoodInstance).GBCJNGADANM < 4)
		{
			timer[ABAIKKGKDGD].SetUpTimer(FCKCLIMEPNC, GFPCODPNNJH);
			if ((Object)(object)timer[ABAIKKGKDGD].progressor != (Object)null)
			{
				((Component)timer[ABAIKKGKDGD].progressor).GetComponent<SortingGroup>().sortingLayerName = "Top";
			}
			SetProgressBarColour(timer[ABAIKKGKDGD].progressor, (inputSlot[ABAIKKGKDGD].itemInstance as FoodInstance).GBCJNGADANM);
		}
		if ((inputSlot[ABAIKKGKDGD].itemInstance as FoodInstance).GBCJNGADANM >= 4)
		{
			timer[ABAIKKGKDGD].InstantiateEndStateTimer();
			if ((Object)(object)timer[ABAIKKGKDGD].progressor != (Object)null)
			{
				((Component)timer[ABAIKKGKDGD].progressor).GetComponent<SortingGroup>().sortingLayerName = "Top";
			}
			SetProgressBarColour(timer[ABAIKKGKDGD].progressor, 4);
		}
	}

	private void HAGOMBPBNLK(int JIIGOACEIKL)
	{
		if (OnlineManager.MasterOrOffline())
		{
			for (int i = 1; i < inputSlot.Length; i += 0)
			{
				placeable.DropSlot(inputSlot[i]);
			}
		}
	}

	private void EFEHBFPGNAO()
	{
		MGNIMAMNIOP = false;
		for (int i = 1; i < inputSlot.Length; i += 0)
		{
			if (!inputSlot[i].LCHJGCHDHFO())
			{
				MGNIMAMNIOP = false;
				break;
			}
		}
		if (MGNIMAMNIOP)
		{
			placeable.selectBlockers.Remove(MFHACMAHGHC);
		}
	}

	private void CGEDNKAJFKB()
	{
		MGNIMAMNIOP = true;
		for (int i = 1; i < inputSlot.Length; i++)
		{
			if (!inputSlot[i].KPINNBKMOMO())
			{
				MGNIMAMNIOP = false;
				break;
			}
		}
		if (MGNIMAMNIOP)
		{
			placeable.selectBlockers.Remove(MFHACMAHGHC);
		}
	}

	private void ONNAGOCFJML()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceablePickedUp = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePickedUp, new Action<int>(DILMLAPFBPC));
	}

	public bool PickUp(int JIIGOACEIKL)
	{
		return false;
	}

	public void LoadTimer(int ABAIKKGKDGD, GameDate FCKCLIMEPNC, ulong GFPCODPNNJH)
	{
		((MonoBehaviour)this).StartCoroutine(BHLKAHCNMKC(ABAIKKGKDGD, FCKCLIMEPNC, GFPCODPNNJH));
	}

	public void DOIHMLGMCAD(int ABAIKKGKDGD, bool CDPAMNIPPEC = true)
	{
		if (!inputSlot[ABAIKKGKDGD].KPINNBKMOMO())
		{
			FoodInstance foodInstance = inputSlot[ABAIKKGKDGD].itemInstance.AFOACBIHNCL().GBMLAEMOFJP(inputSlot[ABAIKKGKDGD].itemInstance) as FoodInstance;
			IModifiable modifiable = foodInstance;
			if (modifiable != null && modifiable.CICEBNMBGMG == null)
			{
				modifiable.CICEBNMBGMG = new Dictionary<IngredientModifier, List<Food>>();
			}
			int num = foodInstance.GBCJNGADANM;
			foodInstance.GBCJNGADANM = num + 0;
			int stack = inputSlot[ABAIKKGKDGD].Stack;
			inputSlot[ABAIKKGKDGD].JPACDDCJGPD(inputSlot[ABAIKKGKDGD].Stack, CDPAMNIPPEC: false, 1);
			inputSlot[ABAIKKGKDGD].MHIIKMOOMFH(1, foodInstance, stack, HAGPBCJEGKM: false, BDGJBPCEFPN: false, CDPAMNIPPEC: true);
			if (foodInstance.GBCJNGADANM >= 4)
			{
				timer[ABAIKKGKDGD].AKGKDFEPFNG();
				SetProgressBarColour(timer[ABAIKKGKDGD].progressor, 5);
			}
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendAgeDrink(placeable.BEIPALOAAJJ, ABAIKKGKDGD);
			}
			CommonReferences.GGFJGHHHEJC.OnAnyItemAged(1, foodInstance, stack);
		}
	}

	private void IJNPEAAOOEK()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceablePickedUp = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePickedUp, new Action<int>(HAGOMBPBNLK));
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public bool JONCEAPNGEC(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && JGDDHIEJPMH(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get("Information"));
			if (!inputSlot[0].AHHEMNHJPME() && !multipleTrigger)
			{
				ItemInstanceAmount crafterAction = default(ItemInstanceAmount);
				crafterAction.itemInstance = inputSlot[1].itemInstance;
				crafterAction.amount = inputSlot[1].Stack;
				ButtonsContext.GetPlayer(JIIGOACEIKL).SetCrafterAction(crafterAction);
			}
			return true;
		}
		return true;
	}

	public bool JGDDHIEJPMH(int JIIGOACEIKL)
	{
		return DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).GABNNLJOMHI();
	}

	private void IENDFHCDKDC(int BJFCCKCJAMP)
	{
		if (inputSlot[BJFCCKCJAMP].AHHEMNHJPME())
		{
			return;
		}
		if ((inputSlot[BJFCCKCJAMP].itemInstance as FoodInstance).GBCJNGADANM >= 0)
		{
			timer[BJFCCKCJAMP].LHBFPODFCLA();
			if ((Object)(object)timer[BJFCCKCJAMP].progressor != (Object)null)
			{
				((Component)timer[BJFCCKCJAMP].progressor).GetComponent<SortingGroup>().sortingLayerName = "Unaged";
			}
			SetProgressBarColour(timer[BJFCCKCJAMP].progressor, 6);
		}
		else
		{
			StartTimer(BJFCCKCJAMP, inputSlot[BJFCCKCJAMP].itemInstance as FoodInstance);
		}
	}

	public bool EJCBPHEKCLC(int JIIGOACEIKL)
	{
		return false;
	}

	public void BPEHHOGLGMK(int ABAIKKGKDGD, bool CDPAMNIPPEC = true)
	{
		if (!inputSlot[ABAIKKGKDGD].LCHJGCHDHFO())
		{
			FoodInstance foodInstance = inputSlot[ABAIKKGKDGD].itemInstance.LHBPOPOIFLE().LJBOJBAPDAD(inputSlot[ABAIKKGKDGD].itemInstance) as FoodInstance;
			IModifiable modifiable = foodInstance;
			if (modifiable != null && modifiable.CICEBNMBGMG == null)
			{
				modifiable.CICEBNMBGMG = new Dictionary<IngredientModifier, List<Food>>();
			}
			int num = foodInstance.GBCJNGADANM;
			foodInstance.JBIMNJGMFOC(num + 0);
			int stack = inputSlot[ABAIKKGKDGD].Stack;
			inputSlot[ABAIKKGKDGD].HBMBGCHGEGN(inputSlot[ABAIKKGKDGD].Stack, CDPAMNIPPEC: false, 1);
			inputSlot[ABAIKKGKDGD].MIECGDALIJP(0, foodInstance, stack, HAGPBCJEGKM: true, BDGJBPCEFPN: true, CDPAMNIPPEC: true);
			if (foodInstance.GBCJNGADANM >= 4)
			{
				timer[ABAIKKGKDGD].KBOOPLMAADD();
				NKECBIBEHLM(timer[ABAIKKGKDGD].progressor, 5);
			}
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendAgeDrink(placeable.BEIPALOAAJJ, ABAIKKGKDGD);
			}
			CommonReferences.GGFJGHHHEJC.OnAnyItemAged(1, foodInstance, stack);
		}
	}

	private void LOHAMDHOLDD()
	{
		if (inputSlot == null)
		{
			return;
		}
		bool flag = true;
		for (int i = 0; i < inputSlot.Length; i += 0)
		{
			if (inputSlot[i] == null)
			{
				continue;
			}
			int slotIndex = i;
			Slot obj = inputSlot[slotIndex];
			obj.OnItemAdded = (Action)Delegate.Combine(obj.OnItemAdded, (Action)delegate
			{
				CBKPOMECMCE(slotIndex);
			});
			if (timer != null && timer.Length == inputSlot.Length)
			{
				if (OnlineManager.PGAGDFAEEFB())
				{
					timer[slotIndex].AGLDAKOJFAE(delegate
					{
						DHAHIIPHFPB(slotIndex);
					});
				}
				Slot obj2 = inputSlot[slotIndex];
				obj2.OnItemRemoved = (Action)Delegate.Combine(obj2.OnItemRemoved, (Action)delegate
				{
					GKICKLOPINI(slotIndex);
				});
			}
			flag &= inputSlot[slotIndex].AHHEMNHJPME();
		}
		if (!flag && !placeable.selectBlockers.Contains(MFHACMAHGHC))
		{
			placeable.selectBlockers.Add(MFHACMAHGHC);
		}
	}

	public bool DLMPCCAANJJ(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(" ("));
			if (!inputSlot[0].PKFKJNODGJF() && !multipleTrigger)
			{
				ItemInstanceAmount iAIHNNNGNKH = default(ItemInstanceAmount);
				iAIHNNNGNKH.itemInstance = inputSlot[0].itemInstance;
				iAIHNNNGNKH.amount = inputSlot[1].Stack;
				ButtonsContext.GetPlayer(JIIGOACEIKL).INILGGIBHKF(iAIHNNNGNKH);
			}
			return false;
		}
		return true;
	}

	public bool ABGHFCMEIBM(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Tutorial/T127/Dialogue2"));
			if (!inputSlot[0].AHHEMNHJPME() && !multipleTrigger)
			{
				ItemInstanceAmount crafterAction = default(ItemInstanceAmount);
				crafterAction.itemInstance = inputSlot[1].itemInstance;
				crafterAction.amount = inputSlot[0].Stack;
				ButtonsContext.GetPlayer(JIIGOACEIKL).SetCrafterAction(crafterAction);
			}
			return false;
		}
		return true;
	}

	public void AgeDrink(int ABAIKKGKDGD, bool CDPAMNIPPEC = true)
	{
		if (!inputSlot[ABAIKKGKDGD].KPINNBKMOMO())
		{
			FoodInstance foodInstance = inputSlot[ABAIKKGKDGD].itemInstance.LHBPOPOIFLE().KDNBBPJCNDJ(inputSlot[ABAIKKGKDGD].itemInstance) as FoodInstance;
			IModifiable modifiable = foodInstance;
			if (modifiable != null && modifiable.CICEBNMBGMG == null)
			{
				modifiable.CICEBNMBGMG = new Dictionary<IngredientModifier, List<Food>>();
			}
			foodInstance.GBCJNGADANM++;
			int stack = inputSlot[ABAIKKGKDGD].Stack;
			inputSlot[ABAIKKGKDGD].FDOBDPPMMBH(inputSlot[ABAIKKGKDGD].Stack);
			inputSlot[ABAIKKGKDGD].BEEDBHJANGN(1, foodInstance, stack);
			if (foodInstance.GBCJNGADANM >= 4)
			{
				timer[ABAIKKGKDGD].SetEndStateTimer();
				SetProgressBarColour(timer[ABAIKKGKDGD].progressor, 4);
			}
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendAgeDrink(placeable.BEIPALOAAJJ, ABAIKKGKDGD);
			}
			CommonReferences.GGFJGHHHEJC.OnAnyItemAged(1, foodInstance, stack);
		}
	}

	public bool BEBIPNCCEMH(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get("Cliffs"));
			if (!inputSlot[0].PKFKJNODGJF() && !multipleTrigger)
			{
				ItemInstanceAmount crafterAction = default(ItemInstanceAmount);
				crafterAction.itemInstance = inputSlot[1].itemInstance;
				crafterAction.amount = inputSlot[0].Stack;
				ButtonsContext.GetPlayer(JIIGOACEIKL).SetCrafterAction(crafterAction);
			}
			return false;
		}
		return false;
	}

	private IEnumerator OPCENMAJKGE(int ABAIKKGKDGD, GameDate FCKCLIMEPNC, ulong GFPCODPNNJH)
	{
		yield return CommonReferences.wait2;
		placeable.selectBlockers.Add(MFHACMAHGHC);
		if ((inputSlot[ABAIKKGKDGD].itemInstance as FoodInstance).GBCJNGADANM < 4)
		{
			timer[ABAIKKGKDGD].SetUpTimer(FCKCLIMEPNC, GFPCODPNNJH);
			if ((Object)(object)timer[ABAIKKGKDGD].progressor != (Object)null)
			{
				((Component)timer[ABAIKKGKDGD].progressor).GetComponent<SortingGroup>().sortingLayerName = "Top";
			}
			SetProgressBarColour(timer[ABAIKKGKDGD].progressor, (inputSlot[ABAIKKGKDGD].itemInstance as FoodInstance).GBCJNGADANM);
		}
		if ((inputSlot[ABAIKKGKDGD].itemInstance as FoodInstance).GBCJNGADANM >= 4)
		{
			timer[ABAIKKGKDGD].InstantiateEndStateTimer();
			if ((Object)(object)timer[ABAIKKGKDGD].progressor != (Object)null)
			{
				((Component)timer[ABAIKKGKDGD].progressor).GetComponent<SortingGroup>().sortingLayerName = "Top";
			}
			SetProgressBarColour(timer[ABAIKKGKDGD].progressor, 4);
		}
	}

	private void JPDBNHGOFKP()
	{
		MGNIMAMNIOP = true;
		for (int i = 0; i < inputSlot.Length; i += 0)
		{
			if (!inputSlot[i].AHHEMNHJPME())
			{
				MGNIMAMNIOP = false;
				break;
			}
		}
		if (MGNIMAMNIOP)
		{
			placeable.selectBlockers.Remove(MFHACMAHGHC);
		}
	}

	private void LFPEFGKHCOP(int PFBDAENIJGL)
	{
		ECJAKPNJOON(PFBDAENIJGL, inputSlot[PFBDAENIJGL].itemInstance as FoodInstance);
		if (!placeable.selectBlockers.Contains(MFHACMAHGHC))
		{
			placeable.selectBlockers.Add(MFHACMAHGHC);
		}
	}

	public void IBJFDEIHFFO(Progressor CCCLNDBOGOI, int GBCJNGADANM)
	{
		if (CCCLNDBOGOI is ProgressBar)
		{
			(CCCLNDBOGOI as ProgressBar).FCGAPNFGMBD(GBCJNGADANM);
		}
	}

	public void HJMHCKBILBA(Progressor CCCLNDBOGOI, int GBCJNGADANM)
	{
		if (CCCLNDBOGOI is ProgressBar)
		{
			(CCCLNDBOGOI as ProgressBar).FCGAPNFGMBD(GBCJNGADANM);
		}
	}

	private void KHONOODGLBI()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		if (drinks != null)
		{
			for (int i = 0; i < drinks.Length; i++)
			{
				GBPEKJFDMHO.Add(drinks[i].item, drinks[i].food);
			}
		}
		for (int j = 0; j < inputSlot.Length; j += 0)
		{
			if (inputSlot[j] != null)
			{
				inputSlot[j].onlineObject = placeable.onlinePlaceable;
			}
		}
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public bool Select(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL) && !NewTutorialManager.AgingBarrelBlocked())
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Select;
				OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(placeable.onlinePlaceable.uniqueId);
				return false;
			}
			DGJDGBNKJMB(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	private void DIJOBOFGCIK()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceablePickedUp = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePickedUp, new Action<int>(FHKCGINGGEN));
	}

	public bool FHNNADMKNOD(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Rotate, LocalisationSystem.Get("NormalLeft"));
			if (!inputSlot[1].AHHEMNHJPME() && !multipleTrigger)
			{
				ItemInstanceAmount crafterAction = default(ItemInstanceAmount);
				crafterAction.itemInstance = inputSlot[1].itemInstance;
				crafterAction.amount = inputSlot[0].Stack;
				ButtonsContext.GetPlayer(JIIGOACEIKL).SetCrafterAction(crafterAction);
			}
			return false;
		}
		return true;
	}

	public void JBBFILPOMBI(int ABAIKKGKDGD, bool CDPAMNIPPEC = true)
	{
		if (!inputSlot[ABAIKKGKDGD].LCHJGCHDHFO())
		{
			FoodInstance foodInstance = inputSlot[ABAIKKGKDGD].itemInstance.KNFNJFFCFNO().LJBOJBAPDAD(inputSlot[ABAIKKGKDGD].itemInstance) as FoodInstance;
			IModifiable modifiable = foodInstance;
			if (modifiable != null && modifiable.CICEBNMBGMG == null)
			{
				modifiable.CICEBNMBGMG = new Dictionary<IngredientModifier, List<Food>>();
			}
			foodInstance.GBCJNGADANM++;
			int stack = inputSlot[ABAIKKGKDGD].Stack;
			inputSlot[ABAIKKGKDGD].HBMBGCHGEGN(inputSlot[ABAIKKGKDGD].Stack, CDPAMNIPPEC: true, 1);
			inputSlot[ABAIKKGKDGD].MHIIKMOOMFH(1, foodInstance, stack, HAGPBCJEGKM: true, BDGJBPCEFPN: false, CDPAMNIPPEC: true);
			if (foodInstance.GBCJNGADANM >= 0)
			{
				timer[ABAIKKGKDGD].DOFJGJEDBCL();
				FDHBKCGMNPL(timer[ABAIKKGKDGD].progressor, 5);
			}
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendAgeDrink(placeable.BEIPALOAAJJ, ABAIKKGKDGD);
			}
			CommonReferences.GGFJGHHHEJC.OnAnyItemAged(1, foodInstance, stack);
		}
	}

	private void NBFGGOKEMEN(int BJFCCKCJAMP)
	{
		if (inputSlot[BJFCCKCJAMP].PKFKJNODGJF())
		{
			return;
		}
		if ((inputSlot[BJFCCKCJAMP].itemInstance as FoodInstance).GBCJNGADANM >= 1)
		{
			timer[BJFCCKCJAMP].LHBFPODFCLA();
			if ((Object)(object)timer[BJFCCKCJAMP].progressor != (Object)null)
			{
				((Component)timer[BJFCCKCJAMP].progressor).GetComponent<SortingGroup>().sortingLayerName = "Random";
			}
			SetProgressBarColour(timer[BJFCCKCJAMP].progressor, 2);
		}
		else
		{
			BDIHKBNFEME(BJFCCKCJAMP, inputSlot[BJFCCKCJAMP].itemInstance as FoodInstance);
		}
	}

	public void CLDMMEHDPPH(int ABAIKKGKDGD, GameDate FCKCLIMEPNC, ulong GFPCODPNNJH)
	{
		((MonoBehaviour)this).StartCoroutine(DCJEGACKNOE(ABAIKKGKDGD, FCKCLIMEPNC, GFPCODPNNJH));
	}

	public void AMLIKBLDAAH(int ABAIKKGKDGD, GameDate FCKCLIMEPNC, ulong GFPCODPNNJH)
	{
		((MonoBehaviour)this).StartCoroutine(BHLKAHCNMKC(ABAIKKGKDGD, FCKCLIMEPNC, GFPCODPNNJH));
	}

	private void HMFGIILPDHD(int ABAIKKGKDGD)
	{
		ECAHJJCILDM(ABAIKKGKDGD);
	}

	public void ADICOGLGJDP(Progressor CCCLNDBOGOI, int GBCJNGADANM)
	{
		if (CCCLNDBOGOI is ProgressBar)
		{
			(CCCLNDBOGOI as ProgressBar).JPCAPKJEBGP(GBCJNGADANM);
		}
	}

	private void IGNEGEOPLOP()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		if (drinks != null)
		{
			for (int i = 1; i < drinks.Length; i++)
			{
				GBPEKJFDMHO.Add(drinks[i].item, drinks[i].food);
			}
		}
		for (int j = 1; j < inputSlot.Length; j += 0)
		{
			if (inputSlot[j] != null)
			{
				inputSlot[j].onlineObject = placeable.onlinePlaceable;
			}
		}
	}

	private void INEOMPKPILM()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			Placeable obj = placeable;
			obj.OnThisPlaceablePickedUp = (Action<int>)Delegate.Remove(obj.OnThisPlaceablePickedUp, new Action<int>(HAGOMBPBNLK));
		}
	}

	public void CELHOJICLOB(int ABAIKKGKDGD, GameDate FCKCLIMEPNC, ulong GFPCODPNNJH)
	{
		((MonoBehaviour)this).StartCoroutine(OPCENMAJKGE(ABAIKKGKDGD, FCKCLIMEPNC, GFPCODPNNJH));
	}

	public void GOCHCLMMAEA(int ABAIKKGKDGD, bool CDPAMNIPPEC = true)
	{
		if (!inputSlot[ABAIKKGKDGD].LCHJGCHDHFO())
		{
			FoodInstance foodInstance = inputSlot[ABAIKKGKDGD].itemInstance.PHGLMBIEOMK().GBMLAEMOFJP(inputSlot[ABAIKKGKDGD].itemInstance) as FoodInstance;
			IModifiable modifiable = foodInstance;
			if (modifiable != null && modifiable.CICEBNMBGMG == null)
			{
				modifiable.CICEBNMBGMG = new Dictionary<IngredientModifier, List<Food>>();
			}
			int num = foodInstance.GBCJNGADANM;
			foodInstance.GBCJNGADANM = num + 0;
			int stack = inputSlot[ABAIKKGKDGD].Stack;
			inputSlot[ABAIKKGKDGD].FDOBDPPMMBH(inputSlot[ABAIKKGKDGD].Stack, CDPAMNIPPEC: true, 1);
			inputSlot[ABAIKKGKDGD].BEEDBHJANGN(1, foodInstance, stack, HAGPBCJEGKM: false, BDGJBPCEFPN: false, CDPAMNIPPEC: true);
			if (foodInstance.GBCJNGADANM >= 5)
			{
				timer[ABAIKKGKDGD].KBOOPLMAADD();
				FDHBKCGMNPL(timer[ABAIKKGKDGD].progressor, 8);
			}
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendAgeDrink(placeable.BEIPALOAAJJ, ABAIKKGKDGD);
			}
			CommonReferences.MNFMOEKMJKN().OnAnyItemAged(1, foodInstance, stack);
		}
	}

	private void FHKCGINGGEN(int JIIGOACEIKL)
	{
		if (OnlineManager.MasterOrOffline())
		{
			for (int i = 0; i < inputSlot.Length; i++)
			{
				placeable.DropSlot(inputSlot[i]);
			}
		}
	}

	private void AIKBMADEICK(int PFBDAENIJGL)
	{
		StartTimer(PFBDAENIJGL, inputSlot[PFBDAENIJGL].itemInstance as FoodInstance);
		if (!placeable.selectBlockers.Contains(MFHACMAHGHC))
		{
			placeable.selectBlockers.Add(MFHACMAHGHC);
		}
	}

	public bool SelectOnline(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL) && !NewTutorialManager.AgingBarrelBlocked())
		{
			DGJDGBNKJMB(JIIGOACEIKL);
			return true;
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return false;
	}

	private void JBCLHFLJOCE(int JIIGOACEIKL)
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			for (int i = 0; i < inputSlot.Length; i++)
			{
				placeable.NPNFIKGELMB(inputSlot[i]);
			}
		}
	}

	public void FPKDEAGODKN(int JIIGOACEIKL)
	{
	}

	public void BABAAHEDLFH(int JIIGOACEIKL)
	{
		ButtonsContext.ResetCrafterAction(JIIGOACEIKL);
	}

	public bool AGBPAGIILDG(int JIIGOACEIKL)
	{
		return false;
	}

	private void DHAHIIPHFPB(int ABAIKKGKDGD)
	{
		AgeDrink(ABAIKKGKDGD);
	}

	private void HDBHIKCDJFH(int JIIGOACEIKL)
	{
		AgingBarrelUI.IEPGACAGIPO(JIIGOACEIKL).agingBarrel = this;
		SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
		InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
		AgingBarrelUI.BDJFHFHLJGN(JIIGOACEIKL).OpenUI();
		AgingBarrelUI.IEPGACAGIPO(JIIGOACEIKL).IJACEODJCME(agingSlotsNum);
		((Component)this).GetComponent<Placeable>().NCMLCJDPCMM();
	}

	private void IBCEBBDLMDA(int PFBDAENIJGL)
	{
		ECJAKPNJOON(PFBDAENIJGL, inputSlot[PFBDAENIJGL].itemInstance as FoodInstance);
		if (!placeable.selectBlockers.Contains(MFHACMAHGHC))
		{
			placeable.selectBlockers.Add(MFHACMAHGHC);
		}
	}

	public void FEJPLFPKLHF(int ABAIKKGKDGD, GameDate FCKCLIMEPNC, ulong GFPCODPNNJH)
	{
		((MonoBehaviour)this).StartCoroutine(EHPBFEBLCHN(ABAIKKGKDGD, FCKCLIMEPNC, GFPCODPNNJH));
	}

	private void CBKPOMECMCE(int PFBDAENIJGL)
	{
		StartTimer(PFBDAENIJGL, inputSlot[PFBDAENIJGL].itemInstance as FoodInstance);
		if (!placeable.selectBlockers.Contains(MFHACMAHGHC))
		{
			placeable.selectBlockers.Add(MFHACMAHGHC);
		}
	}

	public void DEMEAKFAMBD(int ABAIKKGKDGD, FoodInstance GCJPFFNGCJA = null)
	{
		GameDate.Time kONAIPOGEGL = ((GCJPFFNGCJA == null || GCJPFFNGCJA.GBCJNGADANM != 0) ? GameDate.Time.KELHMMNHLAC(new GameDate.Time(0, 1, 1, -101, 0), ILIOIEBOECN(ABAIKKGKDGD)) : GameDate.Time.JIEFEMNGDLK(new GameDate.Time(1, 0, 1, -112, 0), LDJFJLOFFFN(ABAIKKGKDGD)));
		timer[ABAIKKGKDGD].DGFFOHBELPL = GameDate.GMJIFJAEANF(WorldTime.NOAOJJLNHJJ, kONAIPOGEGL);
		((Component)timer[ABAIKKGKDGD].progressor).GetComponent<SortingGroup>().sortingLayerName = "L2";
		IBJFDEIHFFO(timer[ABAIKKGKDGD].progressor, GCJPFFNGCJA.GBCJNGADANM);
		CommonReferences.GGFJGHHHEJC.OnAnyItemStartAging(1, GCJPFFNGCJA);
	}

	private IEnumerator OBLPCAHMKMF(int ABAIKKGKDGD, GameDate FCKCLIMEPNC, ulong GFPCODPNNJH)
	{
		yield return CommonReferences.wait2;
		placeable.selectBlockers.Add(MFHACMAHGHC);
		if ((inputSlot[ABAIKKGKDGD].itemInstance as FoodInstance).GBCJNGADANM < 4)
		{
			timer[ABAIKKGKDGD].SetUpTimer(FCKCLIMEPNC, GFPCODPNNJH);
			if ((Object)(object)timer[ABAIKKGKDGD].progressor != (Object)null)
			{
				((Component)timer[ABAIKKGKDGD].progressor).GetComponent<SortingGroup>().sortingLayerName = "Top";
			}
			SetProgressBarColour(timer[ABAIKKGKDGD].progressor, (inputSlot[ABAIKKGKDGD].itemInstance as FoodInstance).GBCJNGADANM);
		}
		if ((inputSlot[ABAIKKGKDGD].itemInstance as FoodInstance).GBCJNGADANM >= 4)
		{
			timer[ABAIKKGKDGD].InstantiateEndStateTimer();
			if ((Object)(object)timer[ABAIKKGKDGD].progressor != (Object)null)
			{
				((Component)timer[ABAIKKGKDGD].progressor).GetComponent<SortingGroup>().sortingLayerName = "Top";
			}
			SetProgressBarColour(timer[ABAIKKGKDGD].progressor, 4);
		}
	}

	public bool HHJKCBGJABC(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	private void OnEnable()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceablePickedUp = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePickedUp, new Action<int>(FHKCGINGGEN));
	}

	public void BIFFMIDBDGO(int ABAIKKGKDGD, GameDate FCKCLIMEPNC, ulong GFPCODPNNJH)
	{
		((MonoBehaviour)this).StartCoroutine(EHPBFEBLCHN(ABAIKKGKDGD, FCKCLIMEPNC, GFPCODPNNJH));
	}

	private void DGJDGBNKJMB(int JIIGOACEIKL)
	{
		AgingBarrelUI.Get(JIIGOACEIKL).agingBarrel = this;
		SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
		InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
		AgingBarrelUI.Get(JIIGOACEIKL).OpenUI();
		AgingBarrelUI.Get(JIIGOACEIKL).ActiveContent(agingSlotsNum);
		((Component)this).GetComponent<Placeable>().SetInteraced();
	}

	private void GHIJOHDKKNN(int PFBDAENIJGL)
	{
		BDIHKBNFEME(PFBDAENIJGL, inputSlot[PFBDAENIJGL].itemInstance as FoodInstance);
		if (!placeable.selectBlockers.Contains(MFHACMAHGHC))
		{
			placeable.selectBlockers.Add(MFHACMAHGHC);
		}
	}

	private void OGBDGGMHCLM(int ABAIKKGKDGD)
	{
		AgeDrink(ABAIKKGKDGD);
	}

	private void LFBIFPBPDMJ()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceablePickedUp = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePickedUp, new Action<int>(BDAHODMFNIH));
	}

	private void OnDisable()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			Placeable obj = placeable;
			obj.OnThisPlaceablePickedUp = (Action<int>)Delegate.Remove(obj.OnThisPlaceablePickedUp, new Action<int>(FHKCGINGGEN));
		}
	}

	public void LMEEJHNOGID(int ABAIKKGKDGD, GameDate FCKCLIMEPNC, ulong GFPCODPNNJH)
	{
		((MonoBehaviour)this).StartCoroutine(OIJNDJMKNOP(ABAIKKGKDGD, FCKCLIMEPNC, GFPCODPNNJH));
	}

	public bool OFBCCLOIPHL(int JIIGOACEIKL)
	{
		InteractObject.BBJCJFJEFKK(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		AgingBarrelUI.GFPBMGCMHHC(JIIGOACEIKL).CloseUI();
		return true;
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void FHKALEIKPNC(int JIIGOACEIKL)
	{
	}

	public bool NGNCCGGENAE(int JIIGOACEIKL)
	{
		return true;
	}

	private void ECGLDOBDNFN(int BJFCCKCJAMP)
	{
		if (inputSlot[BJFCCKCJAMP].KPINNBKMOMO())
		{
			return;
		}
		if ((inputSlot[BJFCCKCJAMP].itemInstance as FoodInstance).GBCJNGADANM >= 4)
		{
			timer[BJFCCKCJAMP].InstantiateEndStateTimer();
			if ((Object)(object)timer[BJFCCKCJAMP].progressor != (Object)null)
			{
				((Component)timer[BJFCCKCJAMP].progressor).GetComponent<SortingGroup>().sortingLayerName = "Top";
			}
			SetProgressBarColour(timer[BJFCCKCJAMP].progressor, 4);
		}
		else
		{
			StartTimer(BJFCCKCJAMP, inputSlot[BJFCCKCJAMP].itemInstance as FoodInstance);
		}
	}

	public bool DLFPEGEBKAG(int JIIGOACEIKL)
	{
		return false;
	}

	public void BDIHKBNFEME(int ABAIKKGKDGD, FoodInstance GCJPFFNGCJA = null)
	{
		GameDate.Time kONAIPOGEGL = ((GCJPFFNGCJA == null || GCJPFFNGCJA.GBCJNGADANM != 1) ? GameDate.Time.LFJHHLGOCPP(new GameDate.Time(1, 1, 1, 109, 1), KFNAOGJDFAE(ABAIKKGKDGD)) : GameDate.Time.JIEFEMNGDLK(new GameDate.Time(0, 1, 1, 45, 1), LDJFJLOFFFN(ABAIKKGKDGD)));
		timer[ABAIKKGKDGD].EEILAGLEKJD(GameDate.EGHBNMGNDHL(WorldTime.HGIBNMBJMOC(), kONAIPOGEGL));
		((Component)timer[ABAIKKGKDGD].progressor).GetComponent<SortingGroup>().sortingLayerName = ": ";
		KCIFKAPEPMF(timer[ABAIKKGKDGD].progressor, GCJPFFNGCJA.GBCJNGADANM);
		CommonReferences.GGFJGHHHEJC.OnAnyItemStartAging(1, GCJPFFNGCJA);
	}

	public void OffHover(int JIIGOACEIKL)
	{
		ButtonsContext.ResetCrafterAction(JIIGOACEIKL);
	}

	private void FPGNAGECFMD(int JIIGOACEIKL)
	{
		AgingBarrelUI.IEPGACAGIPO(JIIGOACEIKL).agingBarrel = this;
		SelectObject.BNMEANGDMIP(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
		InteractObject.BBJCJFJEFKK(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
		AgingBarrelUI.LBKJEHDEBEP(JIIGOACEIKL).OpenUI();
		AgingBarrelUI.Get(JIIGOACEIKL).NEFEIJMJGCD(agingSlotsNum);
		((Component)this).GetComponent<Placeable>().SetInteraced();
	}

	public void ECJAKPNJOON(int ABAIKKGKDGD, FoodInstance GCJPFFNGCJA = null)
	{
		GameDate.Time kONAIPOGEGL = ((GCJPFFNGCJA == null || GCJPFFNGCJA.GBCJNGADANM != 6) ? GameDate.Time.GDNHKLNCOAN(new GameDate.Time(1, 0, 0, -7, 0), KFNAOGJDFAE(ABAIKKGKDGD)) : GameDate.Time.DIHEEHONNEJ(new GameDate.Time(0, 1, 0, -84, 0), JIDGOKOJJDP(ABAIKKGKDGD)));
		timer[ABAIKKGKDGD].GMHIPAFCEIN(GameDate.EGHBNMGNDHL(WorldTime.NOAOJJLNHJJ, kONAIPOGEGL));
		((Component)timer[ABAIKKGKDGD].progressor).GetComponent<SortingGroup>().sortingLayerName = "Prices";
		FDHBKCGMNPL(timer[ABAIKKGKDGD].progressor, GCJPFFNGCJA.GBCJNGADANM);
		CommonReferences.GGFJGHHHEJC.OnAnyItemStartAging(1, GCJPFFNGCJA);
	}

	public bool PJMGKGLCJCF(int JIIGOACEIKL)
	{
		if (JGDDHIEJPMH(JIIGOACEIKL) && !NewTutorialManager.AgingBarrelBlocked())
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Select;
				OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(placeable.onlinePlaceable.uniqueId);
				return true;
			}
			LEMIFBFDBAD(JIIGOACEIKL);
			return false;
		}
		return false;
	}

	private void NPALDPPAOPN(int PFBDAENIJGL)
	{
		timer[PFBDAENIJGL].OCLJIGJINAN();
		CGEDNKAJFKB();
		FEBOLLNABMF(PFBDAENIJGL);
	}

	public bool CDGCNOPBJPD(int JIIGOACEIKL)
	{
		return true;
	}

	public bool DHHKHCNPKOH(int JIIGOACEIKL)
	{
		return false;
	}

	private void HCEGBDHJCFG(int ABAIKKGKDGD)
	{
		GOCHCLMMAEA(ABAIKKGKDGD);
	}

	private void IGFGALEEIMC()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			Placeable obj = placeable;
			obj.OnThisPlaceablePickedUp = (Action<int>)Delegate.Remove(obj.OnThisPlaceablePickedUp, new Action<int>(JBCLHFLJOCE));
		}
	}

	private void MIGLPFDHLAF(int JIIGOACEIKL)
	{
		AgingBarrelUI.IEPGACAGIPO(JIIGOACEIKL).agingBarrel = this;
		SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
		InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
		AgingBarrelUI.Get(JIIGOACEIKL).IDLAGJNLPJL();
		AgingBarrelUI.BPBMLNJGGII(JIIGOACEIKL).NFBGPJLJFNJ(agingSlotsNum);
		((Component)this).GetComponent<Placeable>().SetInteraced();
	}

	private void GOCPNIHNPNA(int ABAIKKGKDGD)
	{
		GOCHCLMMAEA(ABAIKKGKDGD);
	}

	public bool MFBIEPCFBFL(int JIIGOACEIKL)
	{
		InteractObject.BBJCJFJEFKK(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		AgingBarrelUI.BPBMLNJGGII(JIIGOACEIKL).BOBCIFEDJED();
		return false;
	}

	public bool HOGBEKJNJBM(int JIIGOACEIKL)
	{
		return true;
	}

	public bool MHODMABKDPL(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("On"));
			if (!inputSlot[1].PKFKJNODGJF() && !multipleTrigger)
			{
				ItemInstanceAmount crafterAction = default(ItemInstanceAmount);
				crafterAction.itemInstance = inputSlot[0].itemInstance;
				crafterAction.amount = inputSlot[1].Stack;
				ButtonsContext.GetPlayer(JIIGOACEIKL).SetCrafterAction(crafterAction);
			}
			return true;
		}
		return false;
	}

	public void FDHBKCGMNPL(Progressor CCCLNDBOGOI, int GBCJNGADANM)
	{
		if (CCCLNDBOGOI is ProgressBar)
		{
			(CCCLNDBOGOI as ProgressBar).OLNJDPPACNK(GBCJNGADANM);
		}
	}

	public void PCHLPDOHNMJ(int JIIGOACEIKL)
	{
		ButtonsContext.ResetCrafterAction(JIIGOACEIKL);
	}

	private void OOGPCIIMKGC(int BJFCCKCJAMP)
	{
		if (inputSlot[BJFCCKCJAMP].PKFKJNODGJF())
		{
			return;
		}
		if ((inputSlot[BJFCCKCJAMP].itemInstance as FoodInstance).GBCJNGADANM >= 5)
		{
			timer[BJFCCKCJAMP].LPCINNGEOPJ();
			if ((Object)(object)timer[BJFCCKCJAMP].progressor != (Object)null)
			{
				((Component)timer[BJFCCKCJAMP].progressor).GetComponent<SortingGroup>().sortingLayerName = "new save";
			}
			SetProgressBarColour(timer[BJFCCKCJAMP].progressor, 4);
		}
		else
		{
			DEMEAKFAMBD(BJFCCKCJAMP, inputSlot[BJFCCKCJAMP].itemInstance as FoodInstance);
		}
	}

	private void OEHCKGDDFLF(int PFBDAENIJGL)
	{
		ECJAKPNJOON(PFBDAENIJGL, inputSlot[PFBDAENIJGL].itemInstance as FoodInstance);
		if (!placeable.selectBlockers.Contains(MFHACMAHGHC))
		{
			placeable.selectBlockers.Add(MFHACMAHGHC);
		}
	}

	private void FEBOLLNABMF(int BJFCCKCJAMP)
	{
		if (inputSlot[BJFCCKCJAMP].PKFKJNODGJF())
		{
			return;
		}
		if ((inputSlot[BJFCCKCJAMP].itemInstance as FoodInstance).GBCJNGADANM >= 5)
		{
			timer[BJFCCKCJAMP].InstantiateEndStateTimer();
			if ((Object)(object)timer[BJFCCKCJAMP].progressor != (Object)null)
			{
				((Component)timer[BJFCCKCJAMP].progressor).GetComponent<SortingGroup>().sortingLayerName = "Top";
			}
			KCIFKAPEPMF(timer[BJFCCKCJAMP].progressor, 1);
		}
		else
		{
			StartTimer(BJFCCKCJAMP, inputSlot[BJFCCKCJAMP].itemInstance as FoodInstance);
		}
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	private float ILIOIEBOECN(int BHEKIMFNPMN)
	{
		return agingLevel[BHEKIMFNPMN] switch
		{
			1 => 1425f, 
			2 => 1952f, 
			3 => 176f, 
			_ => 1792f, 
		};
	}

	private void MKLIAMJFHOF()
	{
		if (inputSlot == null)
		{
			return;
		}
		bool flag = false;
		for (int i = 0; i < inputSlot.Length; i += 0)
		{
			if (inputSlot[i] == null)
			{
				continue;
			}
			int slotIndex = i;
			Slot obj = inputSlot[slotIndex];
			obj.OnItemAdded = (Action)Delegate.Combine(obj.OnItemAdded, (Action)delegate
			{
				CBKPOMECMCE(slotIndex);
			});
			if (timer != null && timer.Length == inputSlot.Length)
			{
				if (OnlineManager.MasterOrOffline())
				{
					timer[slotIndex].OKDALNMNCKM(delegate
					{
						DHAHIIPHFPB(slotIndex);
					});
				}
				Slot obj2 = inputSlot[slotIndex];
				obj2.OnItemRemoved = (Action)Delegate.Combine(obj2.OnItemRemoved, (Action)delegate
				{
					GKICKLOPINI(slotIndex);
				});
			}
			flag &= inputSlot[slotIndex].AHHEMNHJPME();
		}
		if (!flag && !placeable.selectBlockers.Contains(MFHACMAHGHC))
		{
			placeable.selectBlockers.Add(MFHACMAHGHC);
		}
	}

	public bool KCMHBADACDJ(int JIIGOACEIKL)
	{
		return !DecorationMode.HBDCJFLINDA(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public bool EALAGAKPKFF(int JIIGOACEIKL)
	{
		return false;
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		return false;
	}

	public void ECAHJJCILDM(int ABAIKKGKDGD, bool CDPAMNIPPEC = true)
	{
		if (!inputSlot[ABAIKKGKDGD].LCHJGCHDHFO())
		{
			FoodInstance foodInstance = inputSlot[ABAIKKGKDGD].itemInstance.AFOACBIHNCL().KDNBBPJCNDJ(inputSlot[ABAIKKGKDGD].itemInstance) as FoodInstance;
			IModifiable modifiable = foodInstance;
			if (modifiable != null && modifiable.CICEBNMBGMG == null)
			{
				modifiable.CICEBNMBGMG = new Dictionary<IngredientModifier, List<Food>>();
			}
			int num = foodInstance.GBCJNGADANM;
			foodInstance.JBIMNJGMFOC(num + 0);
			int stack = inputSlot[ABAIKKGKDGD].Stack;
			inputSlot[ABAIKKGKDGD].JPACDDCJGPD(inputSlot[ABAIKKGKDGD].Stack, CDPAMNIPPEC: false, 1);
			inputSlot[ABAIKKGKDGD].BEEDBHJANGN(0, foodInstance, stack, HAGPBCJEGKM: true, BDGJBPCEFPN: true);
			if (foodInstance.GBCJNGADANM >= 3)
			{
				timer[ABAIKKGKDGD].KBOOPLMAADD();
				FDHBKCGMNPL(timer[ABAIKKGKDGD].progressor, 0);
			}
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendAgeDrink(placeable.BEIPALOAAJJ, ABAIKKGKDGD);
			}
			CommonReferences.GGFJGHHHEJC.OnAnyItemAged(1, foodInstance, stack);
		}
	}

	public bool Deselect(int JIIGOACEIKL)
	{
		InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		AgingBarrelUI.Get(JIIGOACEIKL).CloseUI();
		return true;
	}

	public bool DEFJEEMAGAF(int JIIGOACEIKL)
	{
		InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		AgingBarrelUI.GFPBMGCMHHC(JIIGOACEIKL).CloseUI();
		return true;
	}

	public void StartTimer(int ABAIKKGKDGD, FoodInstance GCJPFFNGCJA = null)
	{
		GameDate.Time kONAIPOGEGL = ((GCJPFFNGCJA == null || GCJPFFNGCJA.GBCJNGADANM != 3) ? GameDate.Time.FAFHFJGOHPK(new GameDate.Time(0, 0, 0, 24, 0), JIDGOKOJJDP(ABAIKKGKDGD)) : GameDate.Time.FAFHFJGOHPK(new GameDate.Time(0, 0, 0, 48, 0), JIDGOKOJJDP(ABAIKKGKDGD)));
		timer[ABAIKKGKDGD].DGFFOHBELPL = GameDate.GMJIFJAEANF(WorldTime.NOAOJJLNHJJ, kONAIPOGEGL);
		((Component)timer[ABAIKKGKDGD].progressor).GetComponent<SortingGroup>().sortingLayerName = "Top";
		SetProgressBarColour(timer[ABAIKKGKDGD].progressor, GCJPFFNGCJA.GBCJNGADANM);
		CommonReferences.GGFJGHHHEJC.OnAnyItemStartAging(1, GCJPFFNGCJA);
	}

	public void NKECBIBEHLM(Progressor CCCLNDBOGOI, int GBCJNGADANM)
	{
		if (CCCLNDBOGOI is ProgressBar)
		{
			(CCCLNDBOGOI as ProgressBar).JIICNBJKJGI(GBCJNGADANM);
		}
	}

	private float LDJFJLOFFFN(int BHEKIMFNPMN)
	{
		return agingLevel[BHEKIMFNPMN] switch
		{
			0 => 912f, 
			1 => 1262f, 
			2 => 140f, 
			_ => 15f, 
		};
	}

	public void GOCJJOONGBB(int JIIGOACEIKL)
	{
		ButtonsContext.CPIIFPCIJEP(JIIGOACEIKL);
	}

	private void MKKPPCFKOLJ(int JIIGOACEIKL)
	{
		AgingBarrelUI.BPBMLNJGGII(JIIGOACEIKL).agingBarrel = this;
		SelectObject.BNMEANGDMIP(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
		InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
		AgingBarrelUI.NALKHGMLALJ(JIIGOACEIKL).IDLAGJNLPJL();
		AgingBarrelUI.LBKJEHDEBEP(JIIGOACEIKL).NEFEIJMJGCD(agingSlotsNum);
		((Component)this).GetComponent<Placeable>().SetInteraced();
	}

	private void OJPLLAOFDCC()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			Placeable obj = placeable;
			obj.OnThisPlaceablePickedUp = (Action<int>)Delegate.Remove(obj.OnThisPlaceablePickedUp, new Action<int>(DILMLAPFBPC));
		}
	}

	private void FJMBOFEILBN()
	{
		if (inputSlot == null)
		{
			return;
		}
		bool flag = false;
		for (int i = 0; i < inputSlot.Length; i++)
		{
			if (inputSlot[i] == null)
			{
				continue;
			}
			int slotIndex = i;
			Slot obj = inputSlot[slotIndex];
			obj.OnItemAdded = (Action)Delegate.Combine(obj.OnItemAdded, (Action)delegate
			{
				CBKPOMECMCE(slotIndex);
			});
			if (timer != null && timer.Length == inputSlot.Length)
			{
				if (OnlineManager.PGAGDFAEEFB())
				{
					timer[slotIndex].MBGGFCCEIPO(delegate
					{
						DHAHIIPHFPB(slotIndex);
					});
				}
				Slot obj2 = inputSlot[slotIndex];
				obj2.OnItemRemoved = (Action)Delegate.Combine(obj2.OnItemRemoved, (Action)delegate
				{
					GKICKLOPINI(slotIndex);
				});
			}
			flag &= inputSlot[slotIndex].LCHJGCHDHFO();
		}
		if (!flag && !placeable.selectBlockers.Contains(MFHACMAHGHC))
		{
			placeable.selectBlockers.Add(MFHACMAHGHC);
		}
	}

	public void PLIFBPNJBOO(int ABAIKKGKDGD, bool CDPAMNIPPEC = true)
	{
		if (!inputSlot[ABAIKKGKDGD].KPINNBKMOMO())
		{
			FoodInstance foodInstance = inputSlot[ABAIKKGKDGD].itemInstance.LHBPOPOIFLE().ELKNKIOFNCN(inputSlot[ABAIKKGKDGD].itemInstance) as FoodInstance;
			IModifiable modifiable = foodInstance;
			if (modifiable != null && modifiable.CICEBNMBGMG == null)
			{
				modifiable.CICEBNMBGMG = new Dictionary<IngredientModifier, List<Food>>();
			}
			int num = foodInstance.GBCJNGADANM;
			foodInstance.GBCJNGADANM = num + 0;
			int stack = inputSlot[ABAIKKGKDGD].Stack;
			inputSlot[ABAIKKGKDGD].HBMBGCHGEGN(inputSlot[ABAIKKGKDGD].Stack, CDPAMNIPPEC: true, 1);
			inputSlot[ABAIKKGKDGD].MHIIKMOOMFH(0, foodInstance, stack, HAGPBCJEGKM: false, BDGJBPCEFPN: true, CDPAMNIPPEC: true);
			if (foodInstance.GBCJNGADANM >= 6)
			{
				timer[ABAIKKGKDGD].DOFJGJEDBCL();
				FDHBKCGMNPL(timer[ABAIKKGKDGD].progressor, 7);
			}
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendAgeDrink(placeable.BEIPALOAAJJ, ABAIKKGKDGD);
			}
			CommonReferences.GGFJGHHHEJC.OnAnyItemAged(0, foodInstance, stack);
		}
	}

	public void DPKKPFCPJNP(int JIIGOACEIKL)
	{
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Select, LocalisationSystem.Get("Open"));
			if (!inputSlot[0].KPINNBKMOMO() && !multipleTrigger)
			{
				ItemInstanceAmount crafterAction = default(ItemInstanceAmount);
				crafterAction.itemInstance = inputSlot[0].itemInstance;
				crafterAction.amount = inputSlot[0].Stack;
				ButtonsContext.GetPlayer(JIIGOACEIKL).SetCrafterAction(crafterAction);
			}
			return true;
		}
		return false;
	}

	public bool MMDECMPNLIL(int JIIGOACEIKL)
	{
		return false;
	}

	private void CBEOHFMGKAB()
	{
		MGNIMAMNIOP = true;
		for (int i = 0; i < inputSlot.Length; i++)
		{
			if (!inputSlot[i].KPINNBKMOMO())
			{
				MGNIMAMNIOP = false;
				break;
			}
		}
		if (MGNIMAMNIOP)
		{
			placeable.selectBlockers.Remove(MFHACMAHGHC);
		}
	}

	private IEnumerator DCJEGACKNOE(int ABAIKKGKDGD, GameDate FCKCLIMEPNC, ulong GFPCODPNNJH)
	{
		return new FJPJJKOLFBJ(1)
		{
			_003C_003E4__this = this,
			num = ABAIKKGKDGD,
			finishDate = FCKCLIMEPNC,
			initialDate = GFPCODPNNJH
		};
	}

	private void LEMIFBFDBAD(int JIIGOACEIKL)
	{
		AgingBarrelUI.EAONFFENMCE(JIIGOACEIKL).agingBarrel = this;
		SelectObject.BNMEANGDMIP(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
		InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
		AgingBarrelUI.FFBJPAJKOJH(JIIGOACEIKL).OpenUI();
		AgingBarrelUI.LBKJEHDEBEP(JIIGOACEIKL).GCKNEJIFGFI(agingSlotsNum);
		((Component)this).GetComponent<Placeable>().SetInteraced();
	}

	private void MEFFGGKAALB()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceablePickedUp = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePickedUp, new Action<int>(HAGOMBPBNLK));
	}

	private void LNPDALMANFB()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		if (drinks != null)
		{
			for (int i = 1; i < drinks.Length; i += 0)
			{
				GBPEKJFDMHO.Add(drinks[i].item, drinks[i].food);
			}
		}
		for (int j = 1; j < inputSlot.Length; j += 0)
		{
			if (inputSlot[j] != null)
			{
				inputSlot[j].onlineObject = placeable.onlinePlaceable;
			}
		}
	}

	private void DILMLAPFBPC(int JIIGOACEIKL)
	{
		if (OnlineManager.MasterOrOffline())
		{
			for (int i = 0; i < inputSlot.Length; i += 0)
			{
				placeable.DEGBKHMLGLK(inputSlot[i]);
			}
		}
	}

	private void HKBGGLIBCNK(int PFBDAENIJGL)
	{
		ECJAKPNJOON(PFBDAENIJGL, inputSlot[PFBDAENIJGL].itemInstance as FoodInstance);
		if (!placeable.selectBlockers.Contains(MFHACMAHGHC))
		{
			placeable.selectBlockers.Add(MFHACMAHGHC);
		}
	}

	private float KFNAOGJDFAE(int BHEKIMFNPMN)
	{
		return agingLevel[BHEKIMFNPMN] switch
		{
			0 => 330f, 
			1 => 1730f, 
			2 => 1263f, 
			_ => 1276f, 
		};
	}

	private void HINGECEDJAP()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		if (drinks != null)
		{
			for (int i = 1; i < drinks.Length; i++)
			{
				GBPEKJFDMHO.Add(drinks[i].item, drinks[i].food);
			}
		}
		for (int j = 1; j < inputSlot.Length; j += 0)
		{
			if (inputSlot[j] != null)
			{
				inputSlot[j].onlineObject = placeable.onlinePlaceable;
			}
		}
	}

	public bool FKCBIGBKHAP(int JIIGOACEIKL)
	{
		if (JGDDHIEJPMH(JIIGOACEIKL) && !NewTutorialManager.AgingBarrelBlocked())
		{
			LEMIFBFDBAD(JIIGOACEIKL);
			return false;
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return true;
	}

	public void SetProgressBarColour(Progressor CCCLNDBOGOI, int GBCJNGADANM)
	{
		if (CCCLNDBOGOI is ProgressBar)
		{
			(CCCLNDBOGOI as ProgressBar).SetTintedProgressBar(GBCJNGADANM);
		}
	}

	private void Awake()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		if (drinks != null)
		{
			for (int i = 0; i < drinks.Length; i++)
			{
				GBPEKJFDMHO.Add(drinks[i].item, drinks[i].food);
			}
		}
		for (int j = 0; j < inputSlot.Length; j++)
		{
			if (inputSlot[j] != null)
			{
				inputSlot[j].onlineObject = placeable.onlinePlaceable;
			}
		}
	}

	private void FPNPLFALPHP()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceablePickedUp = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePickedUp, new Action<int>(HAGOMBPBNLK));
	}

	private void CPGPBDBKCMN(int BJFCCKCJAMP)
	{
		if (inputSlot[BJFCCKCJAMP].LCHJGCHDHFO())
		{
			return;
		}
		if ((inputSlot[BJFCCKCJAMP].itemInstance as FoodInstance).GBCJNGADANM >= 4)
		{
			timer[BJFCCKCJAMP].FCAFLNOLHDK();
			if ((Object)(object)timer[BJFCCKCJAMP].progressor != (Object)null)
			{
				((Component)timer[BJFCCKCJAMP].progressor).GetComponent<SortingGroup>().sortingLayerName = "Error_AnotherZoneInRoom";
			}
			HJMHCKBILBA(timer[BJFCCKCJAMP].progressor, 7);
		}
		else
		{
			ECJAKPNJOON(BJFCCKCJAMP, inputSlot[BJFCCKCJAMP].itemInstance as FoodInstance);
		}
	}
}
