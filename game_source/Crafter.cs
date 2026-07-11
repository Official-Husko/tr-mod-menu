using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Timer))]
[RequireComponent(typeof(DoWork))]
public class Crafter : MonoBehaviour, ISelectable, IInteractable, IHoverable, IProximity
{
	[CompilerGenerated]
	private sealed class EIOGDECCOHM
	{
		public Crafter _003C_003E4__this;

		public int playerNum;

		public int woodCost;

		public int woodPlanksCost;

		public int stoneCost;

		public int ironNailsCost;

		public int ironBarCost;

		public YesNoDialogueUI window;

		internal void CFDCMFLHDMJ()
		{
			window.CloseUI();
		}

		internal void KIOBAFEKMHI()
		{
			_003C_003E4__this.Repair(playerNum, woodCost, woodPlanksCost, stoneCost, ironNailsCost, ironBarCost);
			window.CloseUI();
		}
	}

	[CompilerGenerated]
	private sealed class NMHFKJALPHL : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public List<RecipeQueueElement> craftingList;

		public Crafter _003C_003E4__this;

		public GameDate dateFinished;

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
		public NMHFKJALPHL(int _003C_003E1__state)
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
			Crafter crafter = _003C_003E4__this;
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
			{
				_003C_003E1__state = -1;
				for (int i = 0; i < craftingList.Count; i++)
				{
					Dictionary<IngredientModifier, List<Food>> cICEBNMBGMG = null;
					if (craftingList[i].ingredientsUsed != null && craftingList[i].ingredientsUsed.Count > 0)
					{
						List<Food> list = new List<Food>();
						for (int j = 0; j < craftingList[i].ingredientsUsed.Count; j++)
						{
							if (craftingList[i].ingredientsUsed[j].isModifierIngredient)
							{
								list.AddRange(ModifierUI.GetFinalIngredients(craftingList[i].ingredientsUsed[j].itemInstanceAmount.itemInstance, craftingList[i].recipe, craftingList[i].recipe.usingNewRecipesSystem));
							}
						}
						cICEBNMBGMG = ModifierUI.CreateModifiers(list);
					}
					ItemInstanceAmount[] iDBOIIOBIHN = (from x in craftingList[i].ingredientsUsed
						where x.isModifierIngredient
						select x.itemInstanceAmount).ToArray();
					crafter.SetUpCrafting(1, craftingList[i].recipe, dateFinished.LNPODHBKGCH() ? crafter.GetNextDateFinished(craftingList[i].recipe) : dateFinished, iDBOIIOBIHN, null, craftingList[i].customName, cICEBNMBGMG, null, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
				}
				return false;
			}
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

	public Action<int> OnFuelChange = delegate
	{
	};

	public Placeable placeable;

	public bool multipleCrafting;

	[Range(1f, 3f)]
	public int qualityLevel = 1;

	[SerializeField]
	private int fuel;

	public RecipeList recipeList;

	public Sprite crafterSprite;

	public Timer timer;

	public bool dropFuel = true;

	public List<RecipeQueueElement> craftingList = new List<RecipeQueueElement>();

	public List<RecipeQueueElement> readyItemsList = new List<RecipeQueueElement>();

	[HideInInspector]
	public ItemAmount chosenOption;

	public bool needsHolding;

	public DoWork doWork;

	[SerializeField]
	private OpenSound openSound;

	public AudioObject[] loopSound;

	private MultiAudioSource[] OPHNIFKJILF;

	public Animator anim;

	public Animator[] workAnim;

	[SerializeField]
	private GameObject gameObjectToActivate;

	[SerializeField]
	public GameObject[] activateUntilDrop;

	[SerializeField]
	public GameObject[] activateOnReset;

	private string MFHACMAHGHC = "Currently crafting";

	private bool HHNAFOOBJON = true;

	private float PJKGDCDOOFL;

	public bool timerFinished = true;

	[SerializeField]
	private int playerNum;

	[SerializeField]
	private GameObject[] destroyedGameobjects;

	[SerializeField]
	private GameObject[] normalGameObjects;

	public static bool sawmillRepaired;

	public static bool stumpRepaired;

	public static bool smelterRepaired;

	public static bool stoneWorkstationRepaired;

	public static bool blacksmithsTableRepaired;

	private static Slot KCJBFOAAFLK;

	public bool BNPHKHHEKJM { get; private set; }

	public OnlineCrafter BMLMEGDDIKE => placeable.onlinePlaceable as OnlineCrafter;

	public int LCCABPFHCOL => fuel;

	private GameDate.Time OGNFGHBNGKG(Recipe JNLKEMLDFIM)
	{
		GameDate.Time time = JNLKEMLDFIM.KOAEOANDGAP();
		return GameDate.Time.IPPDEBHKDBK(time, GameDate.Time.LLKHKNIBOPI(time, Mathf.Min(1130f, GetAreaBonifications((AreaBonificationType)8))));
	}

	private void HIEAIMBBKFL()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.GGFJGHHHEJC.NAPGPOJEEOJ || !BNPHKHHEKJM || fuel <= 1)
		{
			return;
		}
		(int, int, int) tuple = FuelCalculator.ACINIFLKNDA(fuel);
		Item item = ItemDatabaseAccessor.AFOACBIHNCL(-103, GGBBJNBBLMF: false, DAINLFIMLIH: false);
		Item item2 = ItemDatabaseAccessor.EABMGELAAPG(31, GGBBJNBBLMF: true);
		Item item3 = ItemDatabaseAccessor.AFOACBIHNCL(16);
		if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position) != 0)
		{
			if (tuple.Item1 > 0)
			{
				DroppedItem.SpawnDroppedItem(((Component)this).transform.position, item, tuple.Item1, LHLJILLAHFO: true, HFAKAMFMOGM: false, 1);
			}
			if (tuple.Item2 > 1)
			{
				DroppedItem.SpawnDroppedItem(((Component)this).transform.position, item2, tuple.Item2, LHLJILLAHFO: false, HFAKAMFMOGM: true);
			}
			if (tuple.Item3 > 1)
			{
				DroppedItem.OFMLIIIMDBE(((Component)this).transform.position, item3, tuple.Item3, LHLJILLAHFO: true, HFAKAMFMOGM: true);
			}
		}
		else
		{
			PlayerInventory.OGKNJNINGMH(placeable.GetPlayerNum(), LAGHIOKLJGH: false, ADPNMHGBFKG: true).AINJENENGFG(item.JMDALJBNFML(), tuple.Item1, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
			PlayerInventory.EIFPKCAFDIB(placeable.GetPlayerNum(), LAGHIOKLJGH: false, ADPNMHGBFKG: true).AddItems(item2.JMDALJBNFML(), tuple.Item2, HMPDLIPFBGD: false, EHGHJNOFMKF: false, APBCMCOAFDM: false, AOPGMJEMEFK: true);
			PlayerInventory.NEKDDPIAOBE(placeable.PHPMAEFGBBD(), LAGHIOKLJGH: true).AINJENENGFG(item3.JMDALJBNFML(), tuple.Item3, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
		}
	}

	[SpecialName]
	private void CLNNFPPHMKM(bool AODONKKHPBP)
	{
		_003CLHDILGGBMBC_003Ek__BackingField = AODONKKHPBP;
	}

	private bool BIAGABEAOHN(int JIIGOACEIKL, int PHHOFANMIFD, int IJEHECNHNDJ, int DOOALBAKMEE, int NKDJJAOFEBE, int CFJHCBJLNDE)
	{
		if (PHHOFANMIFD > 0 && !PlayerInventory.GetPlayer(JIIGOACEIKL).HaveEnoughItems(1031, PHHOFANMIFD))
		{
			return false;
		}
		if (IJEHECNHNDJ > 0 && !PlayerInventory.GetPlayer(JIIGOACEIKL).HaveEnoughItems(1036, IJEHECNHNDJ))
		{
			return false;
		}
		if (DOOALBAKMEE > 0 && !PlayerInventory.GetPlayer(JIIGOACEIKL).HaveEnoughItems(1049, DOOALBAKMEE))
		{
			return false;
		}
		if (NKDJJAOFEBE > 0 && !PlayerInventory.GetPlayer(JIIGOACEIKL).HaveEnoughItems(1045, NKDJJAOFEBE))
		{
			return false;
		}
		if (CFJHCBJLNDE > 0 && !PlayerInventory.GetPlayer(JIIGOACEIKL).HaveEnoughItems(1043, CFJHCBJLNDE))
		{
			return false;
		}
		return true;
	}

	public int HNHLLHFMMPJ(Item DGDDAMCDIKC, Item NHACCPPICKI, int MGNOBNCMDJG, ref ItemInstance OEDAIFKHGEO, bool DDAPJEAJGGA = false, int GBCJNGADANM = -1)
	{
		while (true)
		{
			KCJBFOAAFLK = CraftingInventory.EKBDKPCHPKN(playerNum, DGDDAMCDIKC, NHACCPPICKI, AKNBKINJGCF: true, placeable, DDAPJEAJGGA, GBCJNGADANM);
			if (KCJBFOAAFLK == null)
			{
				break;
			}
			OEDAIFKHGEO = KCJBFOAAFLK.itemInstance.LHBPOPOIFLE().MBFNGGICBCA(KCJBFOAAFLK.itemInstance);
			if (KCJBFOAAFLK.Stack < MGNOBNCMDJG)
			{
				MGNOBNCMDJG -= KCJBFOAAFLK.Stack;
				KCJBFOAAFLK.JPACDDCJGPD(KCJBFOAAFLK.Stack, CDPAMNIPPEC: false, 1);
				continue;
			}
			KCJBFOAAFLK.BBHHJLIFNPP(MGNOBNCMDJG, CDPAMNIPPEC: false, 1);
			MGNOBNCMDJG = 0;
			break;
		}
		return MGNOBNCMDJG;
	}

	public void FICJDKBPOOE(GameDate CINMCCAJNAK)
	{
		timer.EEILAGLEKJD(CINMCCAJNAK);
		timerFinished = false;
	}

	private int CFFAOCJPPCK(RecipeQueueElement FFNGGJENDKI)
	{
		return FFNGGJENDKI.output.amount;
	}

	private void OnEnable()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(IFHFNDELKOP));
	}

	private void JFHCAADJOEM(int JIIGOACEIKL, ItemAmount CKKNBMBLGPO)
	{
		if (PlayerInventory.GetPlayer(JIIGOACEIKL).AddItems(CKKNBMBLGPO.item.JMDALJBNFML(), CKKNBMBLGPO.amount, HMPDLIPFBGD: true) < CKKNBMBLGPO.amount)
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		}
	}

	public int LDPCPGOFKIE(Item DGDDAMCDIKC, Item NHACCPPICKI, int MGNOBNCMDJG, ref ItemInstance OEDAIFKHGEO, bool DDAPJEAJGGA = false, int GBCJNGADANM = -1)
	{
		while (true)
		{
			KCJBFOAAFLK = CraftingInventory.GetSlotWithItem(playerNum, DGDDAMCDIKC, NHACCPPICKI, AKNBKINJGCF: false, placeable, DDAPJEAJGGA, GBCJNGADANM);
			if (KCJBFOAAFLK == null)
			{
				break;
			}
			OEDAIFKHGEO = KCJBFOAAFLK.itemInstance.LHBPOPOIFLE().GBMLAEMOFJP(KCJBFOAAFLK.itemInstance);
			if (KCJBFOAAFLK.Stack < MGNOBNCMDJG)
			{
				MGNOBNCMDJG -= KCJBFOAAFLK.Stack;
				KCJBFOAAFLK.HBMBGCHGEGN(KCJBFOAAFLK.Stack);
				continue;
			}
			KCJBFOAAFLK.FDOBDPPMMBH(MGNOBNCMDJG, CDPAMNIPPEC: true, 1);
			MGNOBNCMDJG = 1;
			break;
		}
		return MGNOBNCMDJG;
	}

	public void PDACOPGDDKH(int AODONKKHPBP, bool CDPAMNIPPEC = false)
	{
		fuel = Mathf.Max(1, AODONKKHPBP);
		OnFuelChange(fuel);
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			PPGGGANFLLF().LBHLIPFKOLI(fuel);
		}
	}

	private void OKDGLJHOMDN(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		if (!MainUI.IsAnyUIOpen())
		{
			return;
		}
		HHNAFOOBJON = true;
		PJKGDCDOOFL = 0f;
		if (OPHNIFKJILF != null)
		{
			for (int i = 0; i < OPHNIFKJILF.Length; i++)
			{
				OPHNIFKJILF[i].LocalPause = false;
			}
		}
	}

	protected virtual void GMMNIIKNGNH(int JIIGOACEIKL, RecipeQueueElement FFNGGJENDKI, GameDate OOMMCABDBGO, bool CDPAMNIPPEC)
	{
		if (FFNGGJENDKI.recipe.time.LNPODHBKGCH())
		{
			LADOIOGPHKL();
			NPPJKDDNBJB(JIIGOACEIKL, FFNGGJENDKI.output);
			ResetCrafter();
			if (craftingList.Count == 0)
			{
				doWork.Stop(CDPAMNIPPEC);
				timer.EndTimer();
			}
		}
		else
		{
			if (needsHolding)
			{
				float num = Mathf.Max(0f, (float)GameDate.BJENFLGPHHN(FFNGGJENDKI.recipe.EOLGJFPONID()));
				num -= num * Mathf.Min(0.5f, GetAreaBonifications(AreaBonificationType.TimeReduction));
				doWork.StartWork(num, null, CDPAMNIPPEC);
			}
			else
			{
				StartTimer(OOMMCABDBGO);
			}
			for (int i = 0; i < activateUntilDrop.Length; i++)
			{
				activateUntilDrop[i].SetActive(true);
			}
			for (int j = 0; j < workAnim.Length; j++)
			{
				workAnim[j].ResetTrigger("End");
				workAnim[j].ResetTrigger("ChangeAnim");
				workAnim[j].ResetTrigger("Collect");
				workAnim[j].SetTrigger("Start");
			}
			IMEMCJJDDIG(NJHMBMGKCPL: true);
			DDHHBJDJPBK(MFFKPAELNBO: true);
		}
		CommonReferences.GGFJGHHHEJC.OnCraftingStarted(JIIGOACEIKL, FFNGGJENDKI.recipe);
	}

	public List<Recipe> JEGLMLGBIAJ()
	{
		return recipeList.FGCFDIMNAPF(MJHDMIGEJAK: false);
	}

	public void StartTimer(GameDate CINMCCAJNAK)
	{
		timer.DGFFOHBELPL = CINMCCAJNAK;
		timerFinished = false;
	}

	private void APGCPAMAMLO(int JIIGOACEIKL, RecipeQueueElement FFNGGJENDKI, bool GFNHAMCPEAK)
	{
		Recipe recipe = FFNGGJENDKI.recipe;
		if (GFNHAMCPEAK)
		{
			if (recipe.multiOptions)
			{
				CraftingInventory.PFOLOLPOKEM(JIIGOACEIKL, chosenOption.item.JMDALJBNFML(), placeable, chosenOption.amount);
			}
			else
			{
				ItemAmount cKKNBMBLGPO = default(ItemAmount);
				for (int i = 0; i < recipe.ingredientsNeeded.Length; i++)
				{
					int num = Math.Max(0, recipe.ingredientsNeeded[i].amount - (int)GetAreaBonifications((AreaBonificationType)8, recipe));
					Item item;
					if (recipe.usingNewRecipesSystem)
					{
						if (recipe.ingredientsNeeded[i].item is IngredientGroup || (recipe.ingredientsNeeded[i].item.JGJLNHAKJIJ() && (Item.EKMFELLJHFG(recipe.ingredientsNeeded[i].mod, null) || recipe.ingredientsNeeded[i].item.JFHFEMDAHCD(recipe) > 1)))
						{
							continue;
						}
						item = recipe.ingredientsNeeded[i].item;
					}
					else
					{
						item = recipe.ingredientsNeeded[i].item;
					}
					Slot dGFPLODEDAA = null;
					ItemInstance OEDAIFKHGEO = null;
					if (Item.EKGNIODFJCO(recipe.ingredientsNeeded[i].item, CommonReferences.MNFMOEKMJKN().bucketOfWaterItem))
					{
						cKKNBMBLGPO.item = CommonReferences.GGFJGHHHEJC.bucketItem;
						cKKNBMBLGPO.amount = Math.Max(1, recipe.ingredientsNeeded[i].amount);
						JFHCAADJOEM(JIIGOACEIKL, cKKNBMBLGPO);
					}
					if (item is Food food && food.GLMLNMKDOLD())
					{
						int num2 = num;
						for (int j = 1; j <= 2; j += 0)
						{
							num2 = GLDJHJDJBFP(item, recipe.ingredientsNeeded[i].mod, num2, ref OEDAIFKHGEO, DDAPJEAJGGA: false, j);
							if (num2 == 0)
							{
								break;
							}
						}
					}
					else
					{
						RemoveIngredientFromSlots(item, recipe.ingredientsNeeded[i].mod, num, ref OEDAIFKHGEO);
					}
					if (recipe.ingredientsNeeded[i].mod is Food item2 && OEDAIFKHGEO is IModifiable modifiable)
					{
						modifiable.KEKBKGGFOLK = new List<Food> { item2 };
						modifiable.CICEBNMBGMG = ModifierUI.NPFLKJHDBNO(modifiable.KEKBKGGFOLK);
					}
					IngredientUsedInfo item3 = new IngredientUsedInfo(new ItemInstanceAmount(OEDAIFKHGEO, num), DAJBIIKMEOD: false, dGFPLODEDAA);
					FFNGGJENDKI.ingredientsUsed.Add(item3);
				}
			}
		}
		if (recipe.fuel > 0)
		{
			int num3 = Mathf.RoundToInt((float)(recipe.fuel * PerksDatabaseAccessor.GetPlayerPerkValue(-29)) / 1230f);
			FFNGGJENDKI.fuelUsed = Mathf.Max(1, recipe.fuel - num3 - (int)KEKPCMBDFHM(AreaBonificationType.RecipeProduction, recipe));
			GMGBDCIFKKD(fuel - FFNGGJENDKI.fuelUsed, CDPAMNIPPEC: true);
		}
	}

	private int ICKMHLMEKKJ(RecipeQueueElement FFNGGJENDKI)
	{
		return FFNGGJENDKI.output.amount;
	}

	private void JBDCFJPGKEO()
	{
		for (int i = 1; i < destroyedGameobjects.Length; i += 0)
		{
			destroyedGameobjects[i].SetActive(JLBKAMHNOMP());
		}
		for (int j = 1; j < normalGameObjects.Length; j += 0)
		{
			normalGameObjects[j].SetActive(!AIIELPDNAPP());
		}
	}

	public virtual void CancelAllCrafting(int JIIGOACEIKL, bool GFNHAMCPEAK)
	{
		if (craftingList.Count > 0 && craftingList[0].recipe.multiOptions && Item.MLBOMGHINCA(chosenOption.item, null))
		{
			if (GFNHAMCPEAK && chosenOption.item.JDJGFAACPFC() != CommonReferences.GGFJGHHHEJC.bucketOfWaterItem.JDJGFAACPFC())
			{
				JFHCAADJOEM(JIIGOACEIKL, chosenOption);
			}
		}
		else
		{
			for (int i = 0; i < craftingList.Count; i++)
			{
				PAENAKNNBNF(JIIGOACEIKL, craftingList[i], GFNHAMCPEAK);
			}
		}
		if (GFNHAMCPEAK)
		{
			SelectObject.GetPlayer(JIIGOACEIKL).Deselect();
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		craftingList.Clear();
		ResetCrafter();
		doWork.Stop(GFNHAMCPEAK);
		timerFinished = true;
		timer.EndTimer();
		IMEMCJJDDIG(NJHMBMGKCPL: false);
		DDHHBJDJPBK(MFFKPAELNBO: false);
		for (int j = 0; j < workAnim.Length; j++)
		{
			workAnim[j].SetTrigger("ChangeAnim");
			workAnim[j].SetTrigger("End");
			workAnim[j].SetTrigger("Collect");
		}
	}

	public void AAEBCHOHPAL(int JIIGOACEIKL, RecipeQueueElement FFNGGJENDKI, GameDate OOMMCABDBGO, bool LHAMOFLLKOF, bool GFNHAMCPEAK)
	{
		if (!placeable.selectBlockers.Contains(MFHACMAHGHC) && !FFNGGJENDKI.recipe.time.DELEBKPCOEK())
		{
			placeable.selectBlockers.Add(MFHACMAHGHC);
		}
		if (LHAMOFLLKOF)
		{
			MNGJJMHCPMA(JIIGOACEIKL, FFNGGJENDKI, GFNHAMCPEAK);
		}
		if (FFNGGJENDKI.output.itemInstance is FoodInstance foodInstance)
		{
			foodInstance.JBIMNJGMFOC(Utils.MHOPHHOJLOK(foodInstance, FFNGGJENDKI.ingredientsUsed.Select((IngredientUsedInfo x) => x.itemInstanceAmount.itemInstance).ToList()));
			if (foodInstance.PJNBDKNJLJD().canBeSold)
			{
				if (qualityLevel < 0)
				{
					foodInstance.GHFDCAOBJMK = 0;
				}
				else
				{
					foodInstance.PDFNNFOCNJG(qualityLevel - 1);
				}
			}
			else
			{
				foodInstance.GHFDCAOBJMK = 0;
			}
		}
		if (timerFinished)
		{
			KFPFMPNFPEI(JIIGOACEIKL, FFNGGJENDKI, OOMMCABDBGO, GFNHAMCPEAK);
		}
		if (!FFNGGJENDKI.recipe.time.DGAOMOGBBPA())
		{
			craftingList.Add(FFNGGJENDKI);
		}
	}

	public static void InitializeRepairs()
	{
		Debug.Log((object)"Tutorial repairs to false");
		stumpRepaired = false;
		stoneWorkstationRepaired = false;
		smelterRepaired = false;
		sawmillRepaired = false;
		blacksmithsTableRepaired = false;
	}

	[SpecialName]
	public int FIIHBFCDFJH()
	{
		return fuel;
	}

	public float KEKPCMBDFHM(AreaBonificationType NBJMANNLDDH, Recipe JNLKEMLDFIM = null)
	{
		AreaSpace areaSpace = null;
		if (Object.op_Implicit((Object)(object)placeable.areaSpace))
		{
			areaSpace = placeable.areaSpace;
		}
		else if (Object.op_Implicit((Object)(object)placeable.attachedToPlaceable))
		{
			areaSpace = placeable.attachedToPlaceable.areaSpace;
		}
		if ((Object)(object)areaSpace != (Object)null && areaSpace.BCLLKIEHGPL() != null)
		{
			return areaSpace.BCLLKIEHGPL().HDGOBDMLKOE(NBJMANNLDDH, JNLKEMLDFIM);
		}
		return 673f;
	}

	public List<Recipe> GetKnownRecipes()
	{
		return recipeList.NEBIMEHBKMO();
	}

	public bool FPMFDKMLCML(int JIIGOACEIKL)
	{
		if (!placeable.FHEMHCEAICB && !placeable.PHOCAFJDCDK)
		{
			return !DecorationMode.JDADPDBHJFO(JIIGOACEIKL).DBAEGBDEPFK();
		}
		return true;
	}

	private bool JLBKAMHNOMP()
	{
		return placeable.itemSetup.item.ODENMDOJPLC(DAINLFIMLIH: false) switch
		{
			-130 => !smelterRepaired, 
			-128 => stoneWorkstationRepaired, 
			-131 => !sawmillRepaired, 
			-106 => !stumpRepaired, 
			-43 => blacksmithsTableRepaired, 
			_ => true, 
		};
	}

	public void SetUpCrafting(int JIIGOACEIKL, Recipe JNLKEMLDFIM, GameDate OOMMCABDBGO, ItemInstanceAmount[] IDBOIIOBIHN = null, Item[] CHLKJOHJHBJ = null, string GEDNLBAKONN = null, Dictionary<IngredientModifier, List<Food>> CICEBNMBGMG = null, Slot[] HEEBAPFJKBO = null, bool KBNNPAKJDJM = false, bool CDPAMNIPPEC = true)
	{
		ItemInstanceAmount dDFBCNLOCCN = default(ItemInstanceAmount);
		dDFBCNLOCCN.itemInstance = JNLKEMLDFIM.output.item.JMDALJBNFML();
		dDFBCNLOCCN.amount = (int)Math.Max(1f, (float)JNLKEMLDFIM.EOHCFADEMLI() + GetAreaBonifications(AreaBonificationType.RecipeProduction, JNLKEMLDFIM));
		if (dDFBCNLOCCN.itemInstance is IModifiable modifiable)
		{
			modifiable.AKFIOJCGMDH = GEDNLBAKONN;
			if (JNLKEMLDFIM.saveIngredientsAdded)
			{
				modifiable.CICEBNMBGMG = CICEBNMBGMG;
				modifiable.KEKBKGGFOLK = new List<Food>();
				if (IDBOIIOBIHN != null && IDBOIIOBIHN.Length != 0)
				{
					List<Food> list = new List<Food>();
					for (int i = 0; i < IDBOIIOBIHN.Length; i++)
					{
						list.AddRange(ModifierUI.GetFinalIngredients(IDBOIIOBIHN[i].itemInstance, JNLKEMLDFIM, JNLKEMLDFIM.usingNewRecipesSystem));
						if (CHLKJOHJHBJ != null && Item.MLBOMGHINCA(CHLKJOHJHBJ[i], null))
						{
							list.Remove(CHLKJOHJHBJ[i] as Food);
						}
					}
					modifiable.KEKBKGGFOLK = list;
					modifiable.CICEBNMBGMG = ModifierUI.CreateModifiers(list);
				}
			}
		}
		if (dDFBCNLOCCN.itemInstance is FoodInstance foodInstance)
		{
			foodInstance.KHDCKAGMOLG();
			if (foodInstance.AJOMICMACEJ.saveMainIngredient)
			{
				foodInstance.mainIngredient = IDBOIIOBIHN[0].itemInstance.LHBPOPOIFLE() as Food;
			}
		}
		RecipeQueueElement recipeQueueElement = new RecipeQueueElement(JNLKEMLDFIM, dDFBCNLOCCN, GEDNLBAKONN);
		if (IDBOIIOBIHN != null)
		{
			if (IDBOIIOBIHN.Length != 0)
			{
				recipeQueueElement.ingredientsUsed.Add(new IngredientUsedInfo(IDBOIIOBIHN[0], DAJBIIKMEOD: true, (HEEBAPFJKBO != null && HEEBAPFJKBO.Length != 0) ? HEEBAPFJKBO[0] : null));
			}
			if (IDBOIIOBIHN.Length > 1)
			{
				recipeQueueElement.ingredientsUsed.Add(new IngredientUsedInfo(IDBOIIOBIHN[1], DAJBIIKMEOD: true, (HEEBAPFJKBO != null && HEEBAPFJKBO.Length > 1) ? HEEBAPFJKBO[1] : null));
			}
			if (IDBOIIOBIHN.Length > 2)
			{
				recipeQueueElement.ingredientsUsed.Add(new IngredientUsedInfo(IDBOIIOBIHN[2], DAJBIIKMEOD: true, (HEEBAPFJKBO != null && HEEBAPFJKBO.Length > 2) ? HEEBAPFJKBO[2] : null));
			}
		}
		StartCrafting(JIIGOACEIKL, recipeQueueElement, OOMMCABDBGO, !KBNNPAKJDJM, GFNHAMCPEAK: true);
		CommonReferences.GGFJGHHHEJC.OnRecipeToCraftAdded(JIIGOACEIKL, recipeQueueElement.recipe);
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && !JNLKEMLDFIM.time.LNPODHBKGCH())
		{
			BMLMEGDDIKE.SendStartCrafting(recipeQueueElement, OOMMCABDBGO);
		}
	}

	private void LGJLKGKACAO()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(IFHFNDELKOP));
	}

	private void MDGLECECOIG()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			UIWindow.OnAnyUIClose = (Action<int, UIWindow>)Delegate.Remove(UIWindow.OnAnyUIClose, new Action<int, UIWindow>(NDONILFLCAE));
			UIWindow.OnAnyUIOpen = (Action<int, UIWindow>)Delegate.Remove(UIWindow.OnAnyUIOpen, new Action<int, UIWindow>(OMPAHBFCNLM));
			if (!GameManager.isLoading && dropFuel && OnlineManager.PGAGDFAEEFB())
			{
				HIEAIMBBKFL();
			}
		}
	}

	private void EFOBHPEPKHA(int JIIGOACEIKL, RecipeQueueElement NDIAMMHNACN)
	{
		List<Slot> list = new List<Slot>();
		for (int i = 1; i < NDIAMMHNACN.ingredientsUsed.Count; i += 0)
		{
			if (NDIAMMHNACN.ingredientsUsed[i].itemInstanceAmount.itemInstance != null && NDIAMMHNACN.ingredientsUsed[i].itemInstanceAmount.itemInstance.PHGLMBIEOMK().CIGFGKKCPCK() == CommonReferences.MNFMOEKMJKN().bucketOfWaterItem.JGHNDJBCFAJ())
			{
				continue;
			}
			for (int j = 1; j < NDIAMMHNACN.ingredientsUsed[i].itemInstanceAmount.amount; j += 0)
			{
				Slot slot = CraftingInventory.BGNCPMONPGH(JIIGOACEIKL, NDIAMMHNACN.ingredientsUsed[i].itemInstanceAmount.itemInstance, GLBECJCBBHF: false, placeable, HMPDLIPFBGD: true, CIGOMGBFJGF: false);
				if (slot != null && !list.Contains(slot))
				{
					list.Add(slot);
				}
			}
		}
		if (list.Count > 0)
		{
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().pickUpItem, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			if (OnlineManager.PlayingOnline())
			{
				OnlineSlotsManager.instance.ILKLIHOGMJP(list.ToArray());
			}
		}
	}

	public bool PFDCMDDOFNN(int JIIGOACEIKL)
	{
		PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.AOBJCNDNKDD(KOIDJKBBINH: false);
		OpenCrafterUI(JIIGOACEIKL);
		return false;
	}

	public void GMGBDCIFKKD(int AODONKKHPBP, bool CDPAMNIPPEC = false)
	{
		fuel = Mathf.Max(0, AODONKKHPBP);
		OnFuelChange(fuel);
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			PPGGGANFLLF().IPNCJDNPKFK(fuel);
		}
	}

	public int NNGOJLCIEFC(Item DGDDAMCDIKC, Item NHACCPPICKI, int MGNOBNCMDJG, ref ItemInstance OEDAIFKHGEO, bool DDAPJEAJGGA = false, int GBCJNGADANM = -1)
	{
		while (true)
		{
			KCJBFOAAFLK = CraftingInventory.MKNHIDCOHKK(playerNum, DGDDAMCDIKC, NHACCPPICKI, AKNBKINJGCF: true, placeable, DDAPJEAJGGA, GBCJNGADANM);
			if (KCJBFOAAFLK == null)
			{
				break;
			}
			OEDAIFKHGEO = KCJBFOAAFLK.itemInstance.LHBPOPOIFLE().GBMLAEMOFJP(KCJBFOAAFLK.itemInstance);
			if (KCJBFOAAFLK.Stack < MGNOBNCMDJG)
			{
				MGNOBNCMDJG -= KCJBFOAAFLK.Stack;
				KCJBFOAAFLK.HBMBGCHGEGN(KCJBFOAAFLK.Stack, CDPAMNIPPEC: true);
				continue;
			}
			KCJBFOAAFLK.HBMBGCHGEGN(MGNOBNCMDJG, CDPAMNIPPEC: true);
			MGNOBNCMDJG = 1;
			break;
		}
		return MGNOBNCMDJG;
	}

	private void MKGKKAJHLAO()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(IFHFNDELKOP));
		}
	}

	public void FBNFCONOMDB(int JIIGOACEIKL)
	{
		ButtonsContext.CPIIFPCIJEP(JIIGOACEIKL);
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetBeerTapBar();
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
	}

	public bool DBIPJGJPBHP(int JIIGOACEIKL)
	{
		if (!placeable.FHEMHCEAICB && !placeable.PHOCAFJDCDK)
		{
			return !DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).DMBFKFLDDLH;
		}
		return true;
	}

	public bool CanOpenCraftingUI()
	{
		if (needsHolding && doWork.JCMBHAEKLKK)
		{
			return false;
		}
		if (readyItemsList.Count > 0)
		{
			return false;
		}
		if (!multipleCrafting && craftingList.Count > 0)
		{
			return false;
		}
		if (NewTutorialManager.CrafterBlocked(playerNum, this))
		{
			return false;
		}
		return true;
	}

	[SpecialName]
	public OnlineCrafter PPGGGANFLLF()
	{
		return placeable.onlinePlaceable as OnlineCrafter;
	}

	private void HEEOIAEBDKF(int JIIGOACEIKL, bool EFNFMEIDGDN)
	{
		if (readyItemsList == null)
		{
			return;
		}
		for (int i = 0; i < readyItemsList.Count; i++)
		{
			NPPJKDDNBJB(JIIGOACEIKL, readyItemsList[i].output);
			if (EFNFMEIDGDN)
			{
				CommonReferences.GGFJGHHHEJC.OnAnyItemCrafted(JIIGOACEIKL, readyItemsList[i].output);
			}
		}
		readyItemsList.Clear();
	}

	public void OGPENHNPCJK(int JIIGOACEIKL)
	{
		if (BNPHKHHEKJM)
		{
			Use(JIIGOACEIKL);
		}
		else if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
	}

	public GameDate GetNextDateFinished(Recipe JNLKEMLDFIM)
	{
		return GameDate.GMJIFJAEANF(WorldTime.NOAOJJLNHJJ, HFPCLHBOMIK(JNLKEMLDFIM));
	}

	private void KAKOIEIIDHB(int JIIGOACEIKL, RecipeQueueElement FFNGGJENDKI, bool GFNHAMCPEAK)
	{
		Recipe recipe = FFNGGJENDKI.recipe;
		if (GFNHAMCPEAK)
		{
			if (recipe.multiOptions)
			{
				CraftingInventory.RemoveItemInstances(JIIGOACEIKL, chosenOption.item.JMDALJBNFML(), placeable, chosenOption.amount);
			}
			else
			{
				ItemAmount cKKNBMBLGPO = default(ItemAmount);
				for (int i = 0; i < recipe.ingredientsNeeded.Length; i++)
				{
					int num = Math.Max(1, recipe.ingredientsNeeded[i].amount - (int)GetAreaBonifications(AreaBonificationType.RecipeCost, recipe));
					Item item;
					if (recipe.usingNewRecipesSystem)
					{
						if (recipe.ingredientsNeeded[i].item is IngredientGroup || (recipe.ingredientsNeeded[i].item.NGDPNIFFHKL() && (Item.NGIIPJDAMGP(recipe.ingredientsNeeded[i].mod, null) || recipe.ingredientsNeeded[i].item.JFHFEMDAHCD(recipe) > 1)))
						{
							continue;
						}
						item = recipe.ingredientsNeeded[i].item;
					}
					else
					{
						item = recipe.ingredientsNeeded[i].item;
					}
					Slot dGFPLODEDAA = null;
					ItemInstance OEDAIFKHGEO = null;
					if (Item.NGIIPJDAMGP(recipe.ingredientsNeeded[i].item, CommonReferences.GGFJGHHHEJC.bucketOfWaterItem))
					{
						cKKNBMBLGPO.item = CommonReferences.GGFJGHHHEJC.bucketItem;
						cKKNBMBLGPO.amount = Math.Max(1, recipe.ingredientsNeeded[i].amount);
						JFHCAADJOEM(JIIGOACEIKL, cKKNBMBLGPO);
					}
					if (item is Food food && food.FAJDNLBKEJL())
					{
						int num2 = num;
						for (int j = 1; j <= 4; j++)
						{
							num2 = RemoveIngredientFromSlots(item, recipe.ingredientsNeeded[i].mod, num2, ref OEDAIFKHGEO, DDAPJEAJGGA: true, j);
							if (num2 == 0)
							{
								break;
							}
						}
					}
					else
					{
						RemoveIngredientFromSlots(item, recipe.ingredientsNeeded[i].mod, num, ref OEDAIFKHGEO);
					}
					if (recipe.ingredientsNeeded[i].mod is Food item2 && OEDAIFKHGEO is IModifiable modifiable)
					{
						modifiable.KEKBKGGFOLK = new List<Food> { item2 };
						modifiable.CICEBNMBGMG = ModifierUI.CreateModifiers(modifiable.KEKBKGGFOLK);
					}
					IngredientUsedInfo item3 = new IngredientUsedInfo(new ItemInstanceAmount(OEDAIFKHGEO, num), DAJBIIKMEOD: false, dGFPLODEDAA);
					FFNGGJENDKI.ingredientsUsed.Add(item3);
				}
			}
		}
		if (recipe.fuel > 0)
		{
			int num3 = Mathf.RoundToInt((float)(recipe.fuel * PerksDatabaseAccessor.GetPlayerPerkValue(56)) / 100f);
			FFNGGJENDKI.fuelUsed = Mathf.Max(1, recipe.fuel - num3 - (int)GetAreaBonifications(AreaBonificationType.FuelDiscount, recipe));
			SetFuel(fuel - FFNGGJENDKI.fuelUsed);
		}
	}

	private bool OOFEOJMIKHE(int JIIGOACEIKL, int PHHOFANMIFD, int IJEHECNHNDJ, int DOOALBAKMEE, int NKDJJAOFEBE, int CFJHCBJLNDE)
	{
		if (PHHOFANMIFD > 1 && !PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HaveEnoughItems(-66, PHHOFANMIFD))
		{
			return true;
		}
		if (IJEHECNHNDJ > 0 && !PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).ONAOPKBCPBJ(111, IJEHECNHNDJ))
		{
			return true;
		}
		if (DOOALBAKMEE > 1 && !PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: true).HaveEnoughItems(21, DOOALBAKMEE))
		{
			return false;
		}
		if (NKDJJAOFEBE > 1 && !PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL).ONAOPKBCPBJ(-123, NKDJJAOFEBE))
		{
			return false;
		}
		if (CFJHCBJLNDE > 0 && !PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HaveEnoughItems(20, CFJHCBJLNDE))
		{
			return false;
		}
		return true;
	}

	private void AONIDCIEKCM()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(IFHFNDELKOP));
	}

	private void HOHHDHCADNH()
	{
		for (int i = 0; i < destroyedGameobjects.Length; i++)
		{
			destroyedGameobjects[i].SetActive(AIIELPDNAPP());
		}
		for (int j = 0; j < normalGameObjects.Length; j++)
		{
			normalGameObjects[j].SetActive(!AIIELPDNAPP());
		}
	}

	public float GetAreaBonifications(AreaBonificationType NBJMANNLDDH, Recipe JNLKEMLDFIM = null)
	{
		AreaSpace areaSpace = null;
		if (Object.op_Implicit((Object)(object)placeable.areaSpace))
		{
			areaSpace = placeable.areaSpace;
		}
		else if (Object.op_Implicit((Object)(object)placeable.attachedToPlaceable))
		{
			areaSpace = placeable.attachedToPlaceable.areaSpace;
		}
		if ((Object)(object)areaSpace != (Object)null && areaSpace.PJIAPEDEBEP != null)
		{
			return areaSpace.PJIAPEDEBEP.JEMHPOOCGBH(NBJMANNLDDH, JNLKEMLDFIM);
		}
		return 0f;
	}

	protected virtual void IMEMCJJDDIG(bool NJHMBMGKCPL)
	{
		if (Object.op_Implicit((Object)(object)gameObjectToActivate))
		{
			gameObjectToActivate.gameObject.SetActive(NJHMBMGKCPL);
		}
		if (Object.op_Implicit((Object)(object)anim))
		{
			anim.SetBool("WorkAnimationLoop", NJHMBMGKCPL);
		}
	}

	private void NOBDHOFIGGB(RecipeQueueElement FFNGGJENDKI, List<IngredientUsedInfo> JIBDHKOMAAA = null, string GEDNLBAKONN = null, Dictionary<IngredientModifier, List<Food>> CICEBNMBGMG = null)
	{
		FFNGGJENDKI.output.amount = (int)Math.Max(1f, (float)FFNGGJENDKI.recipe.EOHCFADEMLI() + GetAreaBonifications(AreaBonificationType.RecipeProduction, FFNGGJENDKI.recipe));
		if (FFNGGJENDKI.recipe.saveIngredientsAdded && FFNGGJENDKI.output.itemInstance is IModifiable modifiable)
		{
			modifiable.AKFIOJCGMDH = GEDNLBAKONN;
			modifiable.CICEBNMBGMG = CICEBNMBGMG;
			if (modifiable.KEKBKGGFOLK == null)
			{
				modifiable.KEKBKGGFOLK = new List<Food>();
			}
			if (JIBDHKOMAAA != null && JIBDHKOMAAA.Count > 0)
			{
				List<Food> list = new List<Food>();
				for (int i = 0; i < JIBDHKOMAAA.Count; i++)
				{
					if (JIBDHKOMAAA[i].isModifierIngredient)
					{
						list.AddRange(ModifierUI.GetFinalIngredients(JIBDHKOMAAA[i].itemInstanceAmount.itemInstance, FFNGGJENDKI.recipe, FFNGGJENDKI.recipe.usingNewRecipesSystem));
					}
				}
				modifiable.KEKBKGGFOLK = list;
				modifiable.CICEBNMBGMG = ModifierUI.CreateModifiers(list);
			}
		}
		if (FFNGGJENDKI.output.itemInstance is FoodInstance foodInstance)
		{
			foodInstance.KHDCKAGMOLG();
		}
		FFNGGJENDKI.customName = GEDNLBAKONN;
	}

	public void JPNLLAOIJFN(int JIIGOACEIKL)
	{
		if (PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonUp("TimeLeft"))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Select;
				OnlineObjectsManager.instance.GMJPOKECENH(placeable.onlinePlaceable.uniqueId);
			}
			else if (BNPHKHHEKJM)
			{
				Use(JIIGOACEIKL);
			}
		}
	}

	public void CJNCIEOEHEL(List<RecipeQueueElement> AJAMKFEFFNP, GameDate OOMMCABDBGO)
	{
		((MonoBehaviour)this).StartCoroutine(BGIFMOCCIBO(AJAMKFEFFNP, OOMMCABDBGO));
	}

	public void ResetCrafter()
	{
		for (int i = 0; i < activateUntilDrop.Length; i++)
		{
			activateUntilDrop[i].SetActive(false);
		}
		for (int j = 0; j < activateOnReset.Length; j++)
		{
			activateOnReset[j].SetActive(true);
		}
		for (int k = 0; k < workAnim.Length; k++)
		{
			workAnim[k].SetTrigger("ChangeAnim");
			workAnim[k].SetTrigger("End");
			workAnim[k].SetTrigger("Collect");
			workAnim[k].ResetTrigger("Start");
		}
		chosenOption.item = null;
		if (craftingList.Count == 0 && readyItemsList.Count == 0)
		{
			placeable.selectBlockers.Remove(MFHACMAHGHC);
		}
	}

	public void LHNEACOGPFP(int JIIGOACEIKL)
	{
		if (BNPHKHHEKJM)
		{
			Use(JIIGOACEIKL);
		}
		else if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
	}

	private IEnumerator BGIFMOCCIBO(List<RecipeQueueElement> AJAMKFEFFNP, GameDate OOMMCABDBGO)
	{
		yield return null;
		for (int i = 0; i < AJAMKFEFFNP.Count; i++)
		{
			Dictionary<IngredientModifier, List<Food>> cICEBNMBGMG = null;
			if (AJAMKFEFFNP[i].ingredientsUsed != null && AJAMKFEFFNP[i].ingredientsUsed.Count > 0)
			{
				List<Food> list = new List<Food>();
				for (int j = 0; j < AJAMKFEFFNP[i].ingredientsUsed.Count; j++)
				{
					if (AJAMKFEFFNP[i].ingredientsUsed[j].isModifierIngredient)
					{
						list.AddRange(ModifierUI.GetFinalIngredients(AJAMKFEFFNP[i].ingredientsUsed[j].itemInstanceAmount.itemInstance, AJAMKFEFFNP[i].recipe, AJAMKFEFFNP[i].recipe.usingNewRecipesSystem));
					}
				}
				cICEBNMBGMG = ModifierUI.CreateModifiers(list);
			}
			ItemInstanceAmount[] iDBOIIOBIHN = (from x in AJAMKFEFFNP[i].ingredientsUsed
				where x.isModifierIngredient
				select x.itemInstanceAmount).ToArray();
			SetUpCrafting(1, AJAMKFEFFNP[i].recipe, OOMMCABDBGO.LNPODHBKGCH() ? GetNextDateFinished(AJAMKFEFFNP[i].recipe) : OOMMCABDBGO, iDBOIIOBIHN, null, AJAMKFEFFNP[i].customName, cICEBNMBGMG, null, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
		}
	}

	public void StartCrafting(int JIIGOACEIKL, RecipeQueueElement FFNGGJENDKI, GameDate OOMMCABDBGO, bool LHAMOFLLKOF, bool GFNHAMCPEAK)
	{
		if (!placeable.selectBlockers.Contains(MFHACMAHGHC) && !FFNGGJENDKI.recipe.time.LNPODHBKGCH())
		{
			placeable.selectBlockers.Add(MFHACMAHGHC);
		}
		if (LHAMOFLLKOF)
		{
			KAKOIEIIDHB(JIIGOACEIKL, FFNGGJENDKI, GFNHAMCPEAK);
		}
		if (FFNGGJENDKI.output.itemInstance is FoodInstance foodInstance)
		{
			foodInstance.GBCJNGADANM = Utils.MHOPHHOJLOK(foodInstance, FFNGGJENDKI.ingredientsUsed.Select((IngredientUsedInfo x) => x.itemInstanceAmount.itemInstance).ToList());
			if (foodInstance.AJOMICMACEJ.canBeSold)
			{
				if (qualityLevel < 1)
				{
					foodInstance.GHFDCAOBJMK = 1;
				}
				else
				{
					foodInstance.GHFDCAOBJMK = qualityLevel - 1;
				}
			}
			else
			{
				foodInstance.GHFDCAOBJMK = 0;
			}
		}
		if (timerFinished)
		{
			GMMNIIKNGNH(JIIGOACEIKL, FFNGGJENDKI, OOMMCABDBGO, GFNHAMCPEAK);
		}
		if (!FFNGGJENDKI.recipe.time.LNPODHBKGCH())
		{
			craftingList.Add(FFNGGJENDKI);
		}
	}

	public void NMNNBIHOKFE(int JIIGOACEIKL, bool EFNFMEIDGDN, int HFDILBELIKE, bool GFNHAMCPEAK)
	{
		if (GFNHAMCPEAK)
		{
			NFIGPMEFAGB();
			HEEOIAEBDKF(JIIGOACEIKL, EFNFMEIDGDN);
		}
		else if (HFDILBELIKE > 0)
		{
			for (int num = readyItemsList.Count - 1; num >= 0; num -= 0)
			{
				readyItemsList.RemoveAt(num);
				HFDILBELIKE--;
				if (HFDILBELIKE <= 1)
				{
					break;
				}
			}
		}
		ResetCrafter();
		if (craftingList.Count == 0)
		{
			doWork.KEDEHPOFEPA(GFNHAMCPEAK);
			timer.MBJJEJPPFBD();
		}
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL) && !IIEDALMMNLI)
		{
			if (needsHolding)
			{
				if (readyItemsList.Any())
				{
					if (!PlayerInputs.GetPlayer(JIIGOACEIKL).GetButton("Interact"))
					{
						ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Craft"));
						ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Select, LocalisationSystem.Get("Cancel"));
					}
				}
				else
				{
					ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Open"));
				}
			}
			else if (AIIELPDNAPP())
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Repair"));
			}
			else
			{
				if (craftingList.Count > 0 || readyItemsList.Count > 0)
				{
					if (readyItemsList.Count > 0)
					{
						ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Collect"));
					}
					else if (multipleCrafting)
					{
						ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Open"));
					}
					if (craftingList.Count > 0)
					{
						ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Select, LocalisationSystem.Get("Cancel"));
					}
				}
				else
				{
					ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Open"));
				}
				if (BNPHKHHEKJM)
				{
					ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get("Fuel"));
				}
			}
			if (needsHolding && craftingList.Any())
			{
				ButtonsContext.GetPlayer(JIIGOACEIKL).OpenUI();
				ButtonsContext.GetPlayer(JIIGOACEIKL).SetCrafterAction(craftingList[0].output);
				ButtonsContext.GetPlayer(JIIGOACEIKL).SetBeerTapBar(doWork.OJLICLKJJOF / doWork.EFNODBKFDBD);
			}
			else if (craftingList.Count > 0)
			{
				ItemInstanceAmount crafterAction = default(ItemInstanceAmount);
				crafterAction.itemInstance = craftingList[0].output.itemInstance;
				crafterAction.amount = craftingList[0].output.amount;
				ButtonsContext.GetPlayer(JIIGOACEIKL).SetCrafterAction(crafterAction);
				ButtonsContext.GetPlayer(JIIGOACEIKL).SetBeerTapBar(timer);
			}
			else
			{
				ButtonsContext.ResetCrafterAction(JIIGOACEIKL);
				ButtonsContext.GetPlayer(JIIGOACEIKL).ResetBeerTapBar();
			}
			return true;
		}
		return false;
	}

	private void MOGGJHKBCMM(int JIIGOACEIKL)
	{
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Expected O, but got Unknown
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected O, but got Unknown
		int woodCost = 0;
		int woodPlanksCost = 0;
		int stoneCost = 0;
		int ironNailsCost = 0;
		int ironBarCost = 0;
		switch (placeable.itemSetup.item.JDJGFAACPFC())
		{
		case 704:
			woodPlanksCost = 5;
			stoneCost = 5;
			break;
		case 706:
			ironNailsCost = 4;
			stoneCost = 5;
			break;
		case 703:
			woodCost = 10;
			break;
		case 723:
			woodCost = 5;
			break;
		case 728:
			ironBarCost = 4;
			stoneCost = 5;
			break;
		}
		YesNoDialogueUI window = MainUI.GetYesNoDialogue();
		window.windowType = EWindow.Concatenated;
		if ((!NewTutorialManager.BlockRepairCrafter() && placeable.itemSetup.item.JDJGFAACPFC() == 703) || !NewTutorialManager.CCCLOBIOMCL)
		{
			window.Open(1);
		}
		else if (NewTutorialManager.CCCLOBIOMCL)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Player/Bark/Tutorial/CantDoYet");
		}
		((TMP_Text)window.boxText).text = LocalisationSystem.GetStringWithTags("DoYouWantToRepairIt", JIIGOACEIKL) + "<br><br><line-height=120%>";
		if (woodCost > 0)
		{
			if (PlayerInventory.GetPlayer(JIIGOACEIKL).HaveEnoughItems(1031, woodCost))
			{
				TextMeshProUGUI boxText = window.boxText;
				((TMP_Text)boxText).text = ((TMP_Text)boxText).text + "<sprite name=\"woodIcon\">" + woodCost + "<br>";
			}
			else
			{
				TextMeshProUGUI boxText2 = window.boxText;
				((TMP_Text)boxText2).text = ((TMP_Text)boxText2).text + "<sprite name=\"woodIcon\"><color=#8E1818>" + woodCost + "</color><br>";
			}
		}
		if (woodPlanksCost > 0)
		{
			if (PlayerInventory.GetPlayer(JIIGOACEIKL).HaveEnoughItems(1036, woodPlanksCost))
			{
				TextMeshProUGUI boxText3 = window.boxText;
				((TMP_Text)boxText3).text = ((TMP_Text)boxText3).text + "<sprite name=\"woodPlanksIcon\">" + woodPlanksCost + "<br>";
			}
			else
			{
				TextMeshProUGUI boxText4 = window.boxText;
				((TMP_Text)boxText4).text = ((TMP_Text)boxText4).text + "<sprite name=\"woodPlanksIcon\"><color=#8E1818>" + woodPlanksCost + "</color><br>";
			}
		}
		if (stoneCost > 0)
		{
			if (PlayerInventory.GetPlayer(JIIGOACEIKL).HaveEnoughItems(1049, stoneCost))
			{
				TextMeshProUGUI boxText5 = window.boxText;
				((TMP_Text)boxText5).text = ((TMP_Text)boxText5).text + "<sprite name=\"stoneIcon\">" + stoneCost + "<br>";
			}
			else
			{
				TextMeshProUGUI boxText6 = window.boxText;
				((TMP_Text)boxText6).text = ((TMP_Text)boxText6).text + "<sprite name=\"stoneIcon\"><color=#8E1818>" + stoneCost + "</color><br>";
			}
		}
		if (ironNailsCost > 0)
		{
			if (PlayerInventory.GetPlayer(JIIGOACEIKL).HaveEnoughItems(1045, ironNailsCost))
			{
				TextMeshProUGUI boxText7 = window.boxText;
				((TMP_Text)boxText7).text = ((TMP_Text)boxText7).text + "<sprite name=\"ironNailsIcon\">" + ironNailsCost + "<br>";
			}
			else
			{
				TextMeshProUGUI boxText8 = window.boxText;
				((TMP_Text)boxText8).text = ((TMP_Text)boxText8).text + "<sprite name=\"ironNailsIcon\"><color=#8E1818>" + ironNailsCost + "</color><br>";
			}
		}
		if (ironBarCost > 0)
		{
			if (PlayerInventory.GetPlayer(JIIGOACEIKL).HaveEnoughItems(1043, ironBarCost))
			{
				TextMeshProUGUI boxText9 = window.boxText;
				((TMP_Text)boxText9).text = ((TMP_Text)boxText9).text + "<sprite name=\"ironBarIcon\">" + ironBarCost + "<br>";
			}
			else
			{
				TextMeshProUGUI boxText10 = window.boxText;
				((TMP_Text)boxText10).text = ((TMP_Text)boxText10).text + "<sprite name=\"ironBarIcon\"><color=#8E1818>" + ironBarCost + "</color><br>";
			}
		}
		window.SetYesNoButtonsText();
		((UnityEvent)window.yesButton.onClick).AddListener((UnityAction)delegate
		{
			Repair(JIIGOACEIKL, woodCost, woodPlanksCost, stoneCost, ironNailsCost, ironBarCost);
			window.CloseUI();
		});
		((UnityEvent)window.noButton.onClick).AddListener((UnityAction)delegate
		{
			window.CloseUI();
		});
	}

	private void PAENAKNNBNF(int JIIGOACEIKL, RecipeQueueElement NDIAMMHNACN, bool GFNHAMCPEAK)
	{
		if (GFNHAMCPEAK && NDIAMMHNACN.ingredientsUsed != null)
		{
			JHOEILNLNFC(JIIGOACEIKL, NDIAMMHNACN);
		}
		SetFuel(fuel + NDIAMMHNACN.fuelUsed);
	}

	public void LoadCraftingNextFrame(List<RecipeQueueElement> AJAMKFEFFNP, GameDate OOMMCABDBGO)
	{
		((MonoBehaviour)this).StartCoroutine(NHHPMOOGMGO(AJAMKFEFFNP, OOMMCABDBGO));
	}

	public void LAOGMDAHCGF()
	{
		for (int i = 1; i < activateUntilDrop.Length; i += 0)
		{
			activateUntilDrop[i].SetActive(false);
		}
		for (int j = 1; j < activateOnReset.Length; j += 0)
		{
			activateOnReset[j].SetActive(true);
		}
		for (int k = 0; k < workAnim.Length; k++)
		{
			workAnim[k].SetTrigger("Intro10");
			workAnim[k].SetTrigger("");
			workAnim[k].SetTrigger("Items/item_name_619");
			workAnim[k].ResetTrigger("El prefab '{0}' del item '{1}' (ID: {2}) no tiene el componente ItemSetup.");
		}
		chosenOption.item = null;
		if (craftingList.Count == 0 && readyItemsList.Count == 0)
		{
			placeable.selectBlockers.Remove(MFHACMAHGHC);
		}
	}

	private void OnDisable()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(IFHFNDELKOP));
		}
	}

	public bool LKELFKFPNPJ(int JIIGOACEIKL)
	{
		PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.BNGPBEOAGCH(KOIDJKBBINH: true);
		if (IsAvailableByProximity(JIIGOACEIKL) && !HHNAFOOBJON)
		{
			if (AIIELPDNAPP())
			{
				MOGGJHKBCMM(JIIGOACEIKL);
				return true;
			}
			if (needsHolding && doWork.JCMBHAEKLKK)
			{
				return false;
			}
			if (readyItemsList.Count > 1)
			{
				if (OnlineManager.PlayingOnline())
				{
					BMLMEGDDIKE.ODGCFPGFFCC(readyItemsList.Count);
					return false;
				}
				NENMIHKPOGG(JIIGOACEIKL, EFNFMEIDGDN: false, readyItemsList.Count, GFNHAMCPEAK: true);
				return false;
			}
			if (!multipleCrafting && craftingList.Count > 0)
			{
				CommonReferences.MNFMOEKMJKN().PlayerBark("hideui", JIIGOACEIKL, ECPEFDHOFHN: false);
				return true;
			}
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).interactAction = InteractAction.Interact;
				OnlineObjectsManager.instance.GMJPOKECENH(placeable.onlinePlaceable.uniqueId);
				return false;
			}
			OpenCrafterUI(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	public bool BNPJHDGDFOF(int JIIGOACEIKL)
	{
		PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.SetInteracting(KOIDJKBBINH: true);
		if (DBIPJGJPBHP(JIIGOACEIKL) && !HHNAFOOBJON)
		{
			if (AIIELPDNAPP())
			{
				MOGGJHKBCMM(JIIGOACEIKL);
				return true;
			}
			if (needsHolding && doWork.OENMBFGINAL())
			{
				return true;
			}
			if (readyItemsList.Count > 1)
			{
				if (OnlineManager.PlayingOnline())
				{
					BMLMEGDDIKE.FDPDOKNDIMF(readyItemsList.Count);
					return false;
				}
				NENMIHKPOGG(JIIGOACEIKL, EFNFMEIDGDN: true, readyItemsList.Count, GFNHAMCPEAK: false);
				return true;
			}
			if (!multipleCrafting && craftingList.Count > 0)
			{
				CommonReferences.MNFMOEKMJKN().PlayerBark("ActiveMaiInBar", JIIGOACEIKL, ECPEFDHOFHN: false);
				return true;
			}
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Interact;
				OnlineObjectsManager.instance.GMJPOKECENH(placeable.onlinePlaceable.uniqueId);
				return true;
			}
			OpenCrafterUI(JIIGOACEIKL);
			return false;
		}
		return true;
	}

	public int ANCGGIGKNEJ(Item DGDDAMCDIKC, Item NHACCPPICKI, int MGNOBNCMDJG, ref ItemInstance OEDAIFKHGEO, bool DDAPJEAJGGA = false, int GBCJNGADANM = -1)
	{
		while (true)
		{
			KCJBFOAAFLK = CraftingInventory.GetSlotWithItem(playerNum, DGDDAMCDIKC, NHACCPPICKI, AKNBKINJGCF: false, placeable, DDAPJEAJGGA, GBCJNGADANM);
			if (KCJBFOAAFLK == null)
			{
				break;
			}
			OEDAIFKHGEO = KCJBFOAAFLK.itemInstance.AFOACBIHNCL().JEDPCLGBLBA(KCJBFOAAFLK.itemInstance);
			if (KCJBFOAAFLK.Stack < MGNOBNCMDJG)
			{
				MGNOBNCMDJG -= KCJBFOAAFLK.Stack;
				KCJBFOAAFLK.FDOBDPPMMBH(KCJBFOAAFLK.Stack);
				continue;
			}
			KCJBFOAAFLK.JPACDDCJGPD(MGNOBNCMDJG, CDPAMNIPPEC: true);
			MGNOBNCMDJG = 1;
			break;
		}
		return MGNOBNCMDJG;
	}

	public void Repair(int JIIGOACEIKL, int PHHOFANMIFD = 0, int IJEHECNHNDJ = 0, int DOOALBAKMEE = 0, int NKDJJAOFEBE = 0, int CFJHCBJLNDE = 0, bool GFNHAMCPEAK = true)
	{
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		if (GFNHAMCPEAK)
		{
			if (!BIAGABEAOHN(JIIGOACEIKL, PHHOFANMIFD, IJEHECNHNDJ, DOOALBAKMEE, NKDJJAOFEBE, CFJHCBJLNDE))
			{
				CommonReferences.GGFJGHHHEJC.PlayerBarkString("Error_ICantRepairIt", JIIGOACEIKL);
				return;
			}
			switch (placeable.itemSetup.item.JDJGFAACPFC())
			{
			case 704:
				PlayerInventory.RemoveItems(JIIGOACEIKL, 1036, IJEHECNHNDJ);
				PlayerInventory.RemoveItems(JIIGOACEIKL, 1049, DOOALBAKMEE);
				break;
			case 706:
				PlayerInventory.RemoveItems(JIIGOACEIKL, 1045, NKDJJAOFEBE);
				PlayerInventory.RemoveItems(JIIGOACEIKL, 1049, DOOALBAKMEE);
				break;
			case 703:
				PlayerInventory.RemoveItems(JIIGOACEIKL, 1031, PHHOFANMIFD);
				break;
			case 723:
				PlayerInventory.RemoveItems(JIIGOACEIKL, 1031, PHHOFANMIFD);
				break;
			case 728:
				PlayerInventory.RemoveItems(JIIGOACEIKL, 1043, CFJHCBJLNDE);
				PlayerInventory.RemoveItems(JIIGOACEIKL, 1049, DOOALBAKMEE);
				break;
			}
		}
		switch (placeable.itemSetup.item.JDJGFAACPFC())
		{
		case 704:
			smelterRepaired = true;
			break;
		case 706:
			stoneWorkstationRepaired = true;
			break;
		case 703:
			sawmillRepaired = true;
			break;
		case 723:
			stumpRepaired = true;
			break;
		case 728:
			blacksmithsTableRepaired = true;
			break;
		}
		CommonReferences.GGFJGHHHEJC.OnCrafterRepaired(JIIGOACEIKL);
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.workstationRepair, ((Component)this).transform.position);
		HOHHDHCADNH();
		if (OnlineManager.PlayingOnline() && GFNHAMCPEAK)
		{
			OnlineObjectsManager.instance.SendCrafterRepaired(BMLMEGDDIKE.uniqueId);
		}
	}

	protected virtual void NKNKCLLFDMH(int JIIGOACEIKL, RecipeQueueElement FFNGGJENDKI, GameDate OOMMCABDBGO, bool CDPAMNIPPEC)
	{
		if (FFNGGJENDKI.recipe.time.AHOCHNKLCPM())
		{
			LADOIOGPHKL();
			NPPJKDDNBJB(JIIGOACEIKL, FFNGGJENDKI.output);
			ResetCrafter();
			if (craftingList.Count == 0)
			{
				doWork.KEDEHPOFEPA(CDPAMNIPPEC);
				timer.ABDDFHCMEOO();
			}
		}
		else
		{
			if (needsHolding)
			{
				float num = Mathf.Max(52f, (float)GameDate.DPGHJDNBGOJ(FFNGGJENDKI.recipe.CNNIHJFLJHC()));
				num -= num * Mathf.Min(858f, GetAreaBonifications(AreaBonificationType.RecipeProduction));
				doWork.OKINPIOJMNA(num, null, CDPAMNIPPEC);
			}
			else
			{
				FICJDKBPOOE(OOMMCABDBGO);
			}
			for (int i = 0; i < activateUntilDrop.Length; i += 0)
			{
				activateUntilDrop[i].SetActive(false);
			}
			for (int j = 0; j < workAnim.Length; j++)
			{
				workAnim[j].ResetTrigger("Too late to open");
				workAnim[j].ResetTrigger("buildingObjective_2_1");
				workAnim[j].ResetTrigger("Get Components ");
				workAnim[j].SetTrigger("No bucket of water");
			}
			CLKGAFCIBAM(NJHMBMGKCPL: true);
			JODLMGAHMJA(MFFKPAELNBO: true);
		}
		CommonReferences.MNFMOEKMJKN().OnCraftingStarted(JIIGOACEIKL, FFNGGJENDKI.recipe);
	}

	public void JGDPLPBEADC(int JIIGOACEIKL)
	{
		HEEOIAEBDKF(JIIGOACEIKL, EFNFMEIDGDN: false);
	}

	public bool PickUp(int JIIGOACEIKL)
	{
		return false;
	}

	private IEnumerator CBKFJODDPLO(bool OPFCPCAJFMI)
	{
		yield return null;
		for (int i = 0; i < readyItemsList.Count; i++)
		{
			Dictionary<IngredientModifier, List<Food>> cICEBNMBGMG = null;
			if (readyItemsList[i].ingredientsUsed != null && readyItemsList[i].ingredientsUsed.Count > 0)
			{
				List<Food> list = new List<Food>();
				for (int j = 0; j < readyItemsList[i].ingredientsUsed.Count; j++)
				{
					if (readyItemsList[i].ingredientsUsed[j].isModifierIngredient && readyItemsList[i].ingredientsUsed[j].itemInstanceAmount.itemInstance.LHBPOPOIFLE() is Food item)
					{
						list.Add(item);
					}
				}
				cICEBNMBGMG = ModifierUI.CreateModifiers(list);
			}
			NOBDHOFIGGB(readyItemsList[i], readyItemsList[i].ingredientsUsed, readyItemsList[i].customName, cICEBNMBGMG);
		}
		yield return null;
		if (readyItemsList.Count > 0 && craftingList.Count == 0)
		{
			timer.InstantiateNewTimer();
			timer.FinishTimer();
			if (!placeable.selectBlockers.Contains(MFHACMAHGHC))
			{
				placeable.selectBlockers.Add(MFHACMAHGHC);
			}
		}
		else if (OPFCPCAJFMI && readyItemsList.Count == 0 && craftingList.Count == 1)
		{
			LADOIOGPHKL();
			timer.InstantiateNewTimer();
			timer.FinishTimer();
			if (!placeable.selectBlockers.Contains(MFHACMAHGHC))
			{
				placeable.selectBlockers.Add(MFHACMAHGHC);
			}
		}
	}

	public void OpenCrafterUI(int JIIGOACEIKL)
	{
		if (!NewTutorialManager.CrafterBlocked(JIIGOACEIKL, this))
		{
			playerNum = JIIGOACEIKL;
			InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
			GameCraftingUI.Get(JIIGOACEIKL).updateNextFrame = true;
			GameCraftingUI.Get(JIIGOACEIKL).SetCrafter(this);
			GameCraftingUI.Get(JIIGOACEIKL).OpenUI();
			SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
			Sound.GGFJGHHHEJC.PlayOpenSound(openSound, ((Component)this).transform);
			CommonReferences.GGFJGHHHEJC.OnAnyCrafterOpened(JIIGOACEIKL, this);
		}
	}

	private void JHOEILNLNFC(int JIIGOACEIKL, RecipeQueueElement NDIAMMHNACN)
	{
		List<Slot> list = new List<Slot>();
		for (int i = 0; i < NDIAMMHNACN.ingredientsUsed.Count; i++)
		{
			if (NDIAMMHNACN.ingredientsUsed[i].itemInstanceAmount.itemInstance != null && NDIAMMHNACN.ingredientsUsed[i].itemInstanceAmount.itemInstance.LHBPOPOIFLE().JDJGFAACPFC() == CommonReferences.GGFJGHHHEJC.bucketOfWaterItem.JDJGFAACPFC())
			{
				continue;
			}
			for (int j = 0; j < NDIAMMHNACN.ingredientsUsed[i].itemInstanceAmount.amount; j++)
			{
				Slot slot = CraftingInventory.AddItemInstance(JIIGOACEIKL, NDIAMMHNACN.ingredientsUsed[i].itemInstanceAmount.itemInstance, GLBECJCBBHF: true, placeable, HMPDLIPFBGD: true);
				if (slot != null && !list.Contains(slot))
				{
					list.Add(slot);
				}
			}
		}
		if (list.Count > 0)
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			if (OnlineManager.PlayingOnline())
			{
				OnlineSlotsManager.instance.SendSlots(list.ToArray());
			}
		}
	}

	private void HHHEACKHADN()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(IFHFNDELKOP));
	}

	private void MNGJJMHCPMA(int JIIGOACEIKL, RecipeQueueElement FFNGGJENDKI, bool GFNHAMCPEAK)
	{
		Recipe recipe = FFNGGJENDKI.recipe;
		if (GFNHAMCPEAK)
		{
			if (recipe.multiOptions)
			{
				CraftingInventory.PFOLOLPOKEM(JIIGOACEIKL, chosenOption.item.JMDALJBNFML(), placeable, chosenOption.amount);
			}
			else
			{
				ItemAmount cKKNBMBLGPO = default(ItemAmount);
				for (int i = 0; i < recipe.ingredientsNeeded.Length; i++)
				{
					int num = Math.Max(0, recipe.ingredientsNeeded[i].amount - (int)GetAreaBonifications((AreaBonificationType)7, recipe));
					Item item;
					if (recipe.usingNewRecipesSystem)
					{
						if (recipe.ingredientsNeeded[i].item is IngredientGroup || (recipe.ingredientsNeeded[i].item.NGDPNIFFHKL() && (Item.GBMFCPGEJDK(recipe.ingredientsNeeded[i].mod, null) || recipe.ingredientsNeeded[i].item.POFOEOJHPML(recipe) > 1)))
						{
							continue;
						}
						item = recipe.ingredientsNeeded[i].item;
					}
					else
					{
						item = recipe.ingredientsNeeded[i].item;
					}
					Slot dGFPLODEDAA = null;
					ItemInstance OEDAIFKHGEO = null;
					if (Item.EKMFELLJHFG(recipe.ingredientsNeeded[i].item, CommonReferences.GGFJGHHHEJC.bucketOfWaterItem))
					{
						cKKNBMBLGPO.item = CommonReferences.GGFJGHHHEJC.bucketItem;
						cKKNBMBLGPO.amount = Math.Max(1, recipe.ingredientsNeeded[i].amount);
						JFHCAADJOEM(JIIGOACEIKL, cKKNBMBLGPO);
					}
					if (item is Food food && food.GLMLNMKDOLD())
					{
						int num2 = num;
						for (int j = 1; j <= 3; j += 0)
						{
							num2 = ANCGGIGKNEJ(item, recipe.ingredientsNeeded[i].mod, num2, ref OEDAIFKHGEO, DDAPJEAJGGA: false, j);
							if (num2 == 0)
							{
								break;
							}
						}
					}
					else
					{
						HNHLLHFMMPJ(item, recipe.ingredientsNeeded[i].mod, num, ref OEDAIFKHGEO);
					}
					if (recipe.ingredientsNeeded[i].mod is Food item2 && OEDAIFKHGEO is IModifiable modifiable)
					{
						modifiable.KEKBKGGFOLK = new List<Food> { item2 };
						modifiable.CICEBNMBGMG = ModifierUI.DOHNMEJNONO(modifiable.KEKBKGGFOLK);
					}
					IngredientUsedInfo item3 = new IngredientUsedInfo(new ItemInstanceAmount(OEDAIFKHGEO, num), DAJBIIKMEOD: false, dGFPLODEDAA);
					FFNGGJENDKI.ingredientsUsed.Add(item3);
				}
			}
		}
		if (recipe.fuel > 1)
		{
			int num3 = Mathf.RoundToInt((float)(recipe.fuel * PerksDatabaseAccessor.NGMJIGOPGDK(64)) / 130f);
			FFNGGJENDKI.fuelUsed = Mathf.Max(1, recipe.fuel - num3 - (int)GetAreaBonifications(AreaBonificationType.RecipeProduction, recipe));
			SetFuel(fuel - FFNGGJENDKI.fuelUsed);
		}
	}

	public int RemoveIngredientFromSlots(Item DGDDAMCDIKC, Item NHACCPPICKI, int MGNOBNCMDJG, ref ItemInstance OEDAIFKHGEO, bool DDAPJEAJGGA = false, int GBCJNGADANM = -1)
	{
		while (true)
		{
			KCJBFOAAFLK = CraftingInventory.GetSlotWithItem(playerNum, DGDDAMCDIKC, NHACCPPICKI, AKNBKINJGCF: true, placeable, DDAPJEAJGGA, GBCJNGADANM);
			if (KCJBFOAAFLK == null)
			{
				break;
			}
			OEDAIFKHGEO = KCJBFOAAFLK.itemInstance.LHBPOPOIFLE().KDNBBPJCNDJ(KCJBFOAAFLK.itemInstance);
			if (KCJBFOAAFLK.Stack < MGNOBNCMDJG)
			{
				MGNOBNCMDJG -= KCJBFOAAFLK.Stack;
				KCJBFOAAFLK.FDOBDPPMMBH(KCJBFOAAFLK.Stack, CDPAMNIPPEC: true);
				continue;
			}
			KCJBFOAAFLK.FDOBDPPMMBH(MGNOBNCMDJG, CDPAMNIPPEC: true);
			MGNOBNCMDJG = 0;
			break;
		}
		return MGNOBNCMDJG;
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.SetInteracting(KOIDJKBBINH: false);
		OpenCrafterUI(JIIGOACEIKL);
		return true;
	}

	private void PEMLNEBBKHA(bool MFFKPAELNBO)
	{
		if (MFFKPAELNBO)
		{
			if (loopSound == null || loopSound.Length == 0)
			{
				return;
			}
			if (OPHNIFKJILF != null)
			{
				for (int i = 0; i < OPHNIFKJILF.Length; i++)
				{
					OPHNIFKJILF[i].FadeOut(925f, true);
				}
			}
			OPHNIFKJILF = (MultiAudioSource[])(object)new MultiAudioSource[loopSound.Length];
			for (int j = 1; j < loopSound.Length; j++)
			{
				OPHNIFKJILF[j] = MultiAudioManager.PlayAudioObject(loopSound[j], ((Component)this).transform);
			}
		}
		else if (OPHNIFKJILF != null)
		{
			for (int k = 0; k < OPHNIFKJILF.Length; k += 0)
			{
				OPHNIFKJILF[k].FadeOut(1476f, false);
			}
			OPHNIFKJILF = null;
		}
	}

	public GameDate HNMHIAPCAOP(Recipe JNLKEMLDFIM)
	{
		return GameDate.MLGPICHPOAG(WorldTime.CJOHMLNMJLK(), OGNFGHBNGKG(JNLKEMLDFIM));
	}

	public void RemoveFromCraftingList(int JIIGOACEIKL, int MOFKEDGAOEE, bool GFNHAMCPEAK)
	{
		if (MOFKEDGAOEE >= craftingList.Count)
		{
			return;
		}
		PAENAKNNBNF(JIIGOACEIKL, craftingList[MOFKEDGAOEE], GFNHAMCPEAK);
		RecipeQueueElement recipeQueueElement = craftingList[MOFKEDGAOEE];
		craftingList.RemoveAt(MOFKEDGAOEE);
		if (MOFKEDGAOEE == 0)
		{
			if (craftingList.Count > 0)
			{
				timer.EndTimer();
				GMMNIIKNGNH(JIIGOACEIKL, craftingList[0], GetNextDateFinished(craftingList[0].recipe), GFNHAMCPEAK);
			}
			else
			{
				IMEMCJJDDIG(NJHMBMGKCPL: false);
				DDHHBJDJPBK(MFFKPAELNBO: false);
				for (int i = 0; i < workAnim.Length; i++)
				{
					workAnim[i].SetTrigger("ChangeAnim");
					workAnim[i].SetTrigger("End");
				}
				doWork.Stop(GFNHAMCPEAK);
				timer.EndTimer();
				timerFinished = true;
				placeable.selectBlockers.Remove(MFHACMAHGHC);
			}
		}
		if (GFNHAMCPEAK)
		{
			CommonReferences.GGFJGHHHEJC.OnRecipeToCraftRemoved(JIIGOACEIKL, recipeQueueElement.recipe);
		}
	}

	public bool SelectOnline(int JIIGOACEIKL)
	{
		return false;
	}

	protected virtual void CLKGAFCIBAM(bool NJHMBMGKCPL)
	{
		if (Object.op_Implicit((Object)(object)gameObjectToActivate))
		{
			gameObjectToActivate.gameObject.SetActive(NJHMBMGKCPL);
		}
		if (Object.op_Implicit((Object)(object)anim))
		{
			anim.SetBool("Cellar", NJHMBMGKCPL);
		}
	}

	private IEnumerator PIJNJLBKLBN(List<RecipeQueueElement> AJAMKFEFFNP, GameDate OOMMCABDBGO)
	{
		return new NMHFKJALPHL(1)
		{
			_003C_003E4__this = this,
			craftingList = AJAMKFEFFNP,
			dateFinished = OOMMCABDBGO
		};
	}

	private void Awake()
	{
		if ((Object)(object)doWork == (Object)null)
		{
			doWork = ((Component)this).GetComponent<DoWork>();
		}
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		if ((Object)(object)timer == (Object)null)
		{
			timer = ((Component)this).GetComponent<Timer>();
		}
		timer.DHAHIIPHFPB += LADOIOGPHKL;
		if ((Object)(object)recipeList == (Object)null || recipeList.recipes == null)
		{
			Debug.LogError((object)("Recipes list empty " + ((Object)((Component)this).gameObject).name));
			return;
		}
		for (int i = 0; i < recipeList.recipes.Count; i++)
		{
			if (recipeList.recipes[i].fuel != 0)
			{
				BNPHKHHEKJM = true;
				break;
			}
		}
	}

	private void NFIGPMEFAGB()
	{
		int num = 1;
		for (int i = 1; i < readyItemsList.Count; i += 0)
		{
			if (readyItemsList[i].output.itemInstance.JDEFAOOFOMN())
			{
				num += CFFAOCJPPCK(readyItemsList[i]);
			}
		}
		if (num > 0)
		{
			Utils.FKKHJPEMNBG("Tool", num);
		}
		if (!recipeList.cookingItems)
		{
			Utils.FKKHJPEMNBG("Active quest not found", 1);
		}
	}

	private void NPPJKDDNBJB(int JIIGOACEIKL, ItemInstanceAmount NANIGKPHPPJ)
	{
		ItemInstance dNLMCHDOMOK = ((!(NANIGKPHPPJ.itemInstance is IngredientGroupInstance ingredientGroupInstance)) ? NANIGKPHPPJ.itemInstance : ingredientGroupInstance.chosenItemInstance);
		if (PlayerInventory.GetPlayer(JIIGOACEIKL).AddItems(dNLMCHDOMOK, NANIGKPHPPJ.amount, HMPDLIPFBGD: true) < NANIGKPHPPJ.amount)
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		}
		if (NANIGKPHPPJ.itemInstance.JDJGFAACPFC() == 1873)
		{
			Utils.DLIIAHACOJB(49);
		}
	}

	public void LoadReadyItemsList(List<RecipeQueueElement> GEGGKDODFGJ, bool OPFCPCAJFMI = true)
	{
		readyItemsList = GEGGKDODFGJ;
		((MonoBehaviour)this).StartCoroutine(EAHKMCMFLLC(OPFCPCAJFMI));
	}

	public bool Select(int JIIGOACEIKL)
	{
		if (!IsAvailableByProximity(JIIGOACEIKL))
		{
			return false;
		}
		if (needsHolding)
		{
			if (doWork.JCMBHAEKLKK)
			{
				CancelAllCrafting(JIIGOACEIKL, GFNHAMCPEAK: true);
			}
		}
		else if (craftingList.Count > 0)
		{
			if (OnlineManager.PlayingOnline())
			{
				BMLMEGDDIKE.SendCancelAllCrafting();
				return false;
			}
			CancelAllCrafting(JIIGOACEIKL, GFNHAMCPEAK: true);
		}
		return false;
	}

	private void DDHHBJDJPBK(bool MFFKPAELNBO)
	{
		if (MFFKPAELNBO)
		{
			if (loopSound == null || loopSound.Length == 0)
			{
				return;
			}
			if (OPHNIFKJILF != null)
			{
				for (int i = 0; i < OPHNIFKJILF.Length; i++)
				{
					OPHNIFKJILF[i].FadeOut(4f, false);
				}
			}
			OPHNIFKJILF = (MultiAudioSource[])(object)new MultiAudioSource[loopSound.Length];
			for (int j = 0; j < loopSound.Length; j++)
			{
				OPHNIFKJILF[j] = MultiAudioManager.PlayAudioObject(loopSound[j], ((Component)this).transform);
			}
		}
		else if (OPHNIFKJILF != null)
		{
			for (int k = 0; k < OPHNIFKJILF.Length; k++)
			{
				OPHNIFKJILF[k].FadeOut(4f, false);
			}
			OPHNIFKJILF = null;
		}
	}

	private void IFHFNDELKOP()
	{
		try
		{
			int count = craftingList.Count;
			for (int i = 0; i < count; i++)
			{
				readyItemsList.Add(craftingList[0]);
				craftingList.RemoveAt(0);
			}
			if (count > 0)
			{
				IMEMCJJDDIG(NJHMBMGKCPL: false);
				DDHHBJDJPBK(MFFKPAELNBO: false);
				for (int j = 0; j < workAnim.Length; j++)
				{
					workAnim[j].SetTrigger("ChangeAnim");
					workAnim[j].SetTrigger("End");
				}
				doWork.Stop(CDPAMNIPPEC: false);
				timer.FinishTimer();
				timerFinished = true;
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Error in Crafter.OnPlayerSleep: " + ex.Message));
		}
	}

	public void Use(int JIIGOACEIKL)
	{
		if (!placeable.FHEMHCEAICB && !AIIELPDNAPP())
		{
			GameCraftingUI.Get(JIIGOACEIKL).SetCrafter(this);
			playerNum = JIIGOACEIKL;
			SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
			InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
			FuelUI.Get(JIIGOACEIKL).updateNextFrame = true;
			FuelUI.Get(JIIGOACEIKL).SetCrafter(this);
			FuelUI.Get(JIIGOACEIKL).OpenUI();
		}
		else if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
	}

	private IEnumerator NHHPMOOGMGO(List<RecipeQueueElement> AJAMKFEFFNP, GameDate OOMMCABDBGO)
	{
		yield return null;
		for (int i = 0; i < AJAMKFEFFNP.Count; i++)
		{
			Dictionary<IngredientModifier, List<Food>> cICEBNMBGMG = null;
			if (AJAMKFEFFNP[i].ingredientsUsed != null && AJAMKFEFFNP[i].ingredientsUsed.Count > 0)
			{
				List<Food> list = new List<Food>();
				for (int j = 0; j < AJAMKFEFFNP[i].ingredientsUsed.Count; j++)
				{
					if (AJAMKFEFFNP[i].ingredientsUsed[j].isModifierIngredient)
					{
						list.AddRange(ModifierUI.GetFinalIngredients(AJAMKFEFFNP[i].ingredientsUsed[j].itemInstanceAmount.itemInstance, AJAMKFEFFNP[i].recipe, AJAMKFEFFNP[i].recipe.usingNewRecipesSystem));
					}
				}
				cICEBNMBGMG = ModifierUI.CreateModifiers(list);
			}
			ItemInstanceAmount[] iDBOIIOBIHN = (from x in AJAMKFEFFNP[i].ingredientsUsed
				where x.isModifierIngredient
				select x.itemInstanceAmount).ToArray();
			SetUpCrafting(1, AJAMKFEFFNP[i].recipe, OOMMCABDBGO.LNPODHBKGCH() ? GetNextDateFinished(AJAMKFEFFNP[i].recipe) : OOMMCABDBGO, iDBOIIOBIHN, null, AJAMKFEFFNP[i].customName, cICEBNMBGMG, null, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
		}
	}

	private void AJGLDLLIIFO()
	{
		if ((Object)(object)doWork == (Object)null)
		{
			doWork = ((Component)this).GetComponent<DoWork>();
		}
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		if ((Object)(object)timer == (Object)null)
		{
			timer = ((Component)this).GetComponent<Timer>();
		}
		timer.CCIDELHJPGM(LADOIOGPHKL);
		if ((Object)(object)recipeList == (Object)null || recipeList.recipes == null)
		{
			Debug.LogError((object)("HotBath/Brock Talk" + ((Object)((Component)this).gameObject).name));
			return;
		}
		for (int i = 1; i < recipeList.recipes.Count; i += 0)
		{
			if (recipeList.recipes[i].fuel != 0)
			{
				BNPHKHHEKJM = true;
				break;
			}
		}
	}

	protected virtual void KFPFMPNFPEI(int JIIGOACEIKL, RecipeQueueElement FFNGGJENDKI, GameDate OOMMCABDBGO, bool CDPAMNIPPEC)
	{
		if (FFNGGJENDKI.recipe.time.AHOCHNKLCPM())
		{
			LADOIOGPHKL();
			NPPJKDDNBJB(JIIGOACEIKL, FFNGGJENDKI.output);
			LAOGMDAHCGF();
			if (craftingList.Count == 0)
			{
				doWork.IEMMMGCJOME(CDPAMNIPPEC);
				timer.MBJJEJPPFBD();
			}
		}
		else
		{
			if (needsHolding)
			{
				float num = Mathf.Max(916f, (float)GameDate.NPGPMHNJMGH(FFNGGJENDKI.recipe.KOAEOANDGAP()));
				num -= num * Mathf.Min(709f, GetAreaBonifications((AreaBonificationType)5));
				doWork.GEJFAPKOLJH(num, null, CDPAMNIPPEC);
			}
			else
			{
				StartTimer(OOMMCABDBGO);
			}
			for (int i = 1; i < activateUntilDrop.Length; i++)
			{
				activateUntilDrop[i].SetActive(false);
			}
			for (int j = 0; j < workAnim.Length; j += 0)
			{
				workAnim[j].ResetTrigger("tutorialPopUp23");
				workAnim[j].ResetTrigger("{0} in {1}'s viewID has been reset. Set it to {2} to avoid conflicts with scene objects");
				workAnim[j].ResetTrigger("Yes");
				workAnim[j].SetTrigger("Cleaning Speed");
			}
			CLKGAFCIBAM(NJHMBMGKCPL: false);
			PEMLNEBBKHA(MFFKPAELNBO: false);
		}
		CommonReferences.GGFJGHHHEJC.OnCraftingStarted(JIIGOACEIKL, FFNGGJENDKI.recipe);
	}

	private void HCJNEFHHPHL(int JIIGOACEIKL)
	{
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Expected O, but got Unknown
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected O, but got Unknown
		int woodCost = 1;
		int woodPlanksCost = 1;
		int stoneCost = 0;
		int ironNailsCost = 1;
		int ironBarCost = 0;
		switch (placeable.itemSetup.item.JPNFKDMFKMC())
		{
		case 86:
			woodPlanksCost = 4;
			stoneCost = 2;
			break;
		case 88:
			ironNailsCost = 0;
			stoneCost = 7;
			break;
		case 85:
			woodCost = -45;
			break;
		case -72:
			woodCost = 2;
			break;
		case 176:
			ironBarCost = 5;
			stoneCost = 1;
			break;
		}
		YesNoDialogueUI window = MainUI.NEFOKCKKLNI();
		window.windowType = EWindow.Concatenated;
		if ((!NewTutorialManager.HEJMBHCNCPF() && placeable.itemSetup.item.CIGFGKKCPCK() == 146) || !NewTutorialManager.CCCLOBIOMCL)
		{
			window.Open(1);
		}
		else if (NewTutorialManager.CCCLOBIOMCL)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Hurt");
		}
		((TMP_Text)window.boxText).text = LocalisationSystem.GetStringWithTags("City/Chuck/Introduce", JIIGOACEIKL) + "snow";
		if (woodCost > 1)
		{
			if (PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HaveEnoughItems(-81, woodCost))
			{
				TextMeshProUGUI boxText = window.boxText;
				((TMP_Text)boxText).text = ((TMP_Text)boxText).text + "NightStart not attached to prefab " + woodCost + "Open";
			}
			else
			{
				TextMeshProUGUI boxText2 = window.boxText;
				((TMP_Text)boxText2).text = ((TMP_Text)boxText2).text + "/" + woodCost + "Items/item_description_593";
			}
		}
		if (woodPlanksCost > 0)
		{
			if (PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HaveEnoughItems(49, woodPlanksCost))
			{
				TextMeshProUGUI boxText3 = window.boxText;
				((TMP_Text)boxText3).text = ((TMP_Text)boxText3).text + " of " + woodPlanksCost + "Dead";
			}
			else
			{
				TextMeshProUGUI boxText4 = window.boxText;
				((TMP_Text)boxText4).text = ((TMP_Text)boxText4).text + " " + woodPlanksCost + "UI";
			}
		}
		if (stoneCost > 0)
		{
			if (PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: true).HaveEnoughItems(-57, stoneCost))
			{
				TextMeshProUGUI boxText5 = window.boxText;
				((TMP_Text)boxText5).text = ((TMP_Text)boxText5).text + "Hikari/Barks_Intro" + stoneCost + "Frog(Clone)";
			}
			else
			{
				TextMeshProUGUI boxText6 = window.boxText;
				((TMP_Text)boxText6).text = ((TMP_Text)boxText6).text + "ReceiveOpenCloseTavern" + stoneCost + "player2ToDisconnectFromGame";
			}
		}
		if (ironNailsCost > 0)
		{
			if (PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL).HaveEnoughItems(182, ironNailsCost))
			{
				TextMeshProUGUI boxText7 = window.boxText;
				((TMP_Text)boxText7).text = ((TMP_Text)boxText7).text + "NinjaChallengeEvent/Main 2" + ironNailsCost + "ReceiveKick";
			}
			else
			{
				TextMeshProUGUI boxText8 = window.boxText;
				((TMP_Text)boxText8).text = ((TMP_Text)boxText8).text + "UpgradeConfirmation" + ironNailsCost + "talent_name_110";
			}
		}
		if (ironBarCost > 0)
		{
			if (PlayerInventory.OGKNJNINGMH(JIIGOACEIKL).ONAOPKBCPBJ(76, ironBarCost))
			{
				TextMeshProUGUI boxText9 = window.boxText;
				((TMP_Text)boxText9).text = ((TMP_Text)boxText9).text + "Room missing required items" + ironBarCost + "tutorialPopUp110";
			}
			else
			{
				TextMeshProUGUI boxText10 = window.boxText;
				((TMP_Text)boxText10).text = ((TMP_Text)boxText10).text + "\n" + ironBarCost + "Doubt";
			}
		}
		window.LJJBCGJFPFH(GJLPEHIIDPI: true);
		((UnityEvent)window.yesButton.onClick).AddListener((UnityAction)delegate
		{
			Repair(JIIGOACEIKL, woodCost, woodPlanksCost, stoneCost, ironNailsCost, ironBarCost);
			window.CloseUI();
		});
		((UnityEvent)window.noButton.onClick).AddListener((UnityAction)delegate
		{
			window.CloseUI();
		});
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.SetInteracting(KOIDJKBBINH: false);
		if (IsAvailableByProximity(JIIGOACEIKL) && !HHNAFOOBJON)
		{
			if (AIIELPDNAPP())
			{
				MOGGJHKBCMM(JIIGOACEIKL);
				return true;
			}
			if (needsHolding && doWork.JCMBHAEKLKK)
			{
				return false;
			}
			if (readyItemsList.Count > 0)
			{
				if (OnlineManager.PlayingOnline())
				{
					BMLMEGDDIKE.SendCollectItems(readyItemsList.Count);
					return true;
				}
				CollectItems(JIIGOACEIKL, EFNFMEIDGDN: true, readyItemsList.Count, GFNHAMCPEAK: true);
				return true;
			}
			if (!multipleCrafting && craftingList.Count > 0)
			{
				CommonReferences.GGFJGHHHEJC.PlayerBark("Output is not ready", JIIGOACEIKL);
				return false;
			}
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Interact;
				OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(placeable.onlinePlaceable.uniqueId);
				return false;
			}
			OpenCrafterUI(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	public void NENMIHKPOGG(int JIIGOACEIKL, bool EFNFMEIDGDN, int HFDILBELIKE, bool GFNHAMCPEAK)
	{
		if (GFNHAMCPEAK)
		{
			ENAIKFPGHPO();
			HEEOIAEBDKF(JIIGOACEIKL, EFNFMEIDGDN);
		}
		else if (HFDILBELIKE > 1)
		{
			for (int num = readyItemsList.Count - 1; num >= 1; num--)
			{
				readyItemsList.RemoveAt(num);
				HFDILBELIKE--;
				if (HFDILBELIKE <= 1)
				{
					break;
				}
			}
		}
		ResetCrafter();
		if (craftingList.Count == 0)
		{
			doWork.NDCKEJDBPGO(GFNHAMCPEAK);
			timer.EGCLBBPNKLP();
		}
	}

	public void CollectItems(int JIIGOACEIKL, bool EFNFMEIDGDN, int HFDILBELIKE, bool GFNHAMCPEAK)
	{
		if (GFNHAMCPEAK)
		{
			ENAIKFPGHPO();
			HEEOIAEBDKF(JIIGOACEIKL, EFNFMEIDGDN);
		}
		else if (HFDILBELIKE > 0)
		{
			for (int num = readyItemsList.Count - 1; num >= 0; num--)
			{
				readyItemsList.RemoveAt(num);
				HFDILBELIKE--;
				if (HFDILBELIKE <= 0)
				{
					break;
				}
			}
		}
		ResetCrafter();
		if (craftingList.Count == 0)
		{
			doWork.Stop(GFNHAMCPEAK);
			timer.EndTimer();
		}
	}

	protected virtual void LADOIOGPHKL()
	{
		IMEMCJJDDIG(NJHMBMGKCPL: false);
		DDHHBJDJPBK(MFFKPAELNBO: false);
		for (int i = 0; i < workAnim.Length; i++)
		{
			workAnim[i].SetTrigger("ChangeAnim");
			workAnim[i].SetTrigger("End");
		}
		if (craftingList.Count <= 0)
		{
			timerFinished = true;
			return;
		}
		RecipeQueueElement item = craftingList[0];
		readyItemsList.Add(item);
		craftingList.RemoveAt(0);
		if (craftingList.Count > 0)
		{
			GMMNIIKNGNH(playerNum, craftingList[0], GetNextDateFinished(craftingList[0].recipe), CDPAMNIPPEC: false);
		}
		else
		{
			timerFinished = true;
		}
		if ((Object)(object)InputByProximityManager.GetPlayer(1).GetCurrentFocusedInputElement() != (Object)null && ((object)InputByProximityManager.GetPlayer(1).GetCurrentFocusedInputElement().mainGameObject).Equals((object?)((Component)this).gameObject))
		{
			ButtonsContext.GetPlayer(1).ResetButtons();
		}
		if (GameManager.LocalCoop() && (Object)(object)InputByProximityManager.GetPlayer(2).GetCurrentFocusedInputElement() != (Object)null && ((object)InputByProximityManager.GetPlayer(2).GetCurrentFocusedInputElement().mainGameObject).Equals((object?)((Component)this).gameObject))
		{
			ButtonsContext.GetPlayer(2).ResetButtons();
		}
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
		if (PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonUp("Use"))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Action;
				OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(placeable.onlinePlaceable.uniqueId);
			}
			else if (BNPHKHHEKJM)
			{
				Use(JIIGOACEIKL);
			}
		}
	}

	public void DropItemsIfIsReady(int JIIGOACEIKL)
	{
		HEEOIAEBDKF(JIIGOACEIKL, EFNFMEIDGDN: false);
	}

	private void OMPAHBFCNLM(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		if (Time.timeScale == 0f && OPHNIFKJILF != null)
		{
			for (int i = 0; i < OPHNIFKJILF.Length; i++)
			{
				OPHNIFKJILF[i].LocalPause = true;
			}
		}
	}

	private void FACAIBKHBMN(int JIIGOACEIKL)
	{
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Expected O, but got Unknown
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected O, but got Unknown
		int woodCost = 0;
		int woodPlanksCost = 1;
		int stoneCost = 1;
		int ironNailsCost = 1;
		int ironBarCost = 0;
		switch (placeable.itemSetup.item.CIGFGKKCPCK(DAINLFIMLIH: false))
		{
		case 84:
			woodPlanksCost = 5;
			stoneCost = 6;
			break;
		case 86:
			ironNailsCost = 8;
			stoneCost = 2;
			break;
		case 83:
			woodCost = -117;
			break;
		case -69:
			woodCost = 0;
			break;
		case -81:
			ironBarCost = 8;
			stoneCost = 6;
			break;
		}
		YesNoDialogueUI window = MainUI.LBHLPIFCINB();
		window.windowType = EWindow.Main;
		if ((!NewTutorialManager.BlockRepairCrafter() && placeable.itemSetup.item.JPNFKDMFKMC(DAINLFIMLIH: false) == -34) || !NewTutorialManager.CCCLOBIOMCL)
		{
			window.OFGKFMJKBON(1);
		}
		else if (NewTutorialManager.CCCLOBIOMCL)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Failed to get friend ");
		}
		((TMP_Text)window.boxText).text = LocalisationSystem.PKLPKIAHCDI("[PipeConnectionPuzzleUI] Sin _tileDatabase: los tiles de entrada/salida no tendrán sprite.", JIIGOACEIKL) + "Tutorial/T107/Dialogue1";
		if (woodCost > 0)
		{
			if (PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL).HaveEnoughItems(-95, woodCost))
			{
				TextMeshProUGUI boxText = window.boxText;
				((TMP_Text)boxText).text = ((TMP_Text)boxText).text + "ReceiveBarkInfoWithObjectAndLuaInt" + woodCost + "Melt";
			}
			else
			{
				TextMeshProUGUI boxText2 = window.boxText;
				((TMP_Text)boxText2).text = ((TMP_Text)boxText2).text + "DelayStartConversation " + woodCost + "SteamManager";
			}
		}
		if (woodPlanksCost > 1)
		{
			if (PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HaveEnoughItems(153, woodPlanksCost))
			{
				TextMeshProUGUI boxText3 = window.boxText;
				((TMP_Text)boxText3).text = ((TMP_Text)boxText3).text + "ReceiveSpadeActionMaster" + woodPlanksCost + "Player2";
			}
			else
			{
				TextMeshProUGUI boxText4 = window.boxText;
				((TMP_Text)boxText4).text = ((TMP_Text)boxText4).text + "psai [{0}]: PsaiCoreManager executing TriggerCall {1}" + woodPlanksCost + "</color>";
			}
		}
		if (stoneCost > 0)
		{
			if (PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL).HaveEnoughItems(-23, stoneCost))
			{
				TextMeshProUGUI boxText5 = window.boxText;
				((TMP_Text)boxText5).text = ((TMP_Text)boxText5).text + "Could not find shopItem with id: " + stoneCost + "Selected";
			}
			else
			{
				TextMeshProUGUI boxText6 = window.boxText;
				((TMP_Text)boxText6).text = ((TMP_Text)boxText6).text + "Listen" + stoneCost + "Items/item_name_722";
			}
		}
		if (ironNailsCost > 0)
		{
			if (PlayerInventory.GetPlayer(JIIGOACEIKL).ONAOPKBCPBJ(21, ironNailsCost))
			{
				TextMeshProUGUI boxText7 = window.boxText;
				((TMP_Text)boxText7).text = ((TMP_Text)boxText7).text + "BARKDOOR" + ironNailsCost + "ClosePopUp";
			}
			else
			{
				TextMeshProUGUI boxText8 = window.boxText;
				((TMP_Text)boxText8).text = ((TMP_Text)boxText8).text + "Give" + ironNailsCost + "Error_BarNotInADiningRoom";
			}
		}
		if (ironBarCost > 1)
		{
			if (PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).ONAOPKBCPBJ(-112, ironBarCost))
			{
				TextMeshProUGUI boxText9 = window.boxText;
				((TMP_Text)boxText9).text = ((TMP_Text)boxText9).text + "" + ironBarCost + "Random";
			}
			else
			{
				TextMeshProUGUI boxText10 = window.boxText;
				((TMP_Text)boxText10).text = ((TMP_Text)boxText10).text + "Moving" + ironBarCost + "Left Alt";
			}
		}
		window.NCEMPMHKJFA();
		((UnityEvent)window.yesButton.onClick).AddListener((UnityAction)delegate
		{
			Repair(JIIGOACEIKL, woodCost, woodPlanksCost, stoneCost, ironNailsCost, ironBarCost);
			window.CloseUI();
		});
		((UnityEvent)window.noButton.onClick).AddListener((UnityAction)delegate
		{
			window.CloseUI();
		});
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
		if (BNPHKHHEKJM)
		{
			Use(JIIGOACEIKL);
		}
		else if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
	}

	public bool NPAEHHHLBBM(int JIIGOACEIKL)
	{
		InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = null;
		InteractObject.GNCPLNHMFHN(JIIGOACEIKL).MGGMGKDBHJB(AODONKKHPBP: false);
		GameCraftingUI.Get(JIIGOACEIKL).BOBCIFEDJED();
		FuelUI.LJONDAEOMFJ(JIIGOACEIKL).CloseUI();
		ChooseSlotUI.FFBJPAJKOJH(JIIGOACEIKL).BOBCIFEDJED();
		return false;
	}

	private bool AIIELPDNAPP()
	{
		return placeable.itemSetup.item.JDJGFAACPFC() switch
		{
			704 => !smelterRepaired, 
			706 => !stoneWorkstationRepaired, 
			703 => !sawmillRepaired, 
			723 => !stumpRepaired, 
			728 => !blacksmithsTableRepaired, 
			_ => false, 
		};
	}

	protected virtual void EPOODDADOAO(bool NJHMBMGKCPL)
	{
		if (Object.op_Implicit((Object)(object)gameObjectToActivate))
		{
			gameObjectToActivate.gameObject.SetActive(NJHMBMGKCPL);
		}
		if (Object.op_Implicit((Object)(object)anim))
		{
			anim.SetBool("autoHireDesc", NJHMBMGKCPL);
		}
	}

	public void FinishCrafter()
	{
		IFHFNDELKOP();
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			UIWindow.OnAnyUIClose = (Action<int, UIWindow>)Delegate.Remove(UIWindow.OnAnyUIClose, new Action<int, UIWindow>(OKDGLJHOMDN));
			UIWindow.OnAnyUIOpen = (Action<int, UIWindow>)Delegate.Remove(UIWindow.OnAnyUIOpen, new Action<int, UIWindow>(OMPAHBFCNLM));
			if (!GameManager.isLoading && dropFuel && OnlineManager.MasterOrOffline())
			{
				IPMPMICNCHI();
			}
		}
	}

	private GameDate.Time HFPCLHBOMIK(Recipe JNLKEMLDFIM)
	{
		GameDate.Time time = JNLKEMLDFIM.EOLGJFPONID();
		return GameDate.Time.KINGABDNACL(time, GameDate.Time.FAFHFJGOHPK(time, Mathf.Min(0.5f, GetAreaBonifications(AreaBonificationType.TimeReduction))));
	}

	private void IPMPMICNCHI()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.GGFJGHHHEJC.NAPGPOJEEOJ || !BNPHKHHEKJM || fuel <= 0)
		{
			return;
		}
		(int, int, int) tuple = FuelCalculator.BFAGGGFEBIJ(fuel);
		Item item = ItemDatabaseAccessor.GetItem(1055);
		Item item2 = ItemDatabaseAccessor.GetItem(1040);
		Item item3 = ItemDatabaseAccessor.GetItem(1035);
		if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position) != 0)
		{
			if (tuple.Item1 > 0)
			{
				DroppedItem.SpawnDroppedItem(((Component)this).transform.position, item, tuple.Item1);
			}
			if (tuple.Item2 > 0)
			{
				DroppedItem.SpawnDroppedItem(((Component)this).transform.position, item2, tuple.Item2);
			}
			if (tuple.Item3 > 0)
			{
				DroppedItem.SpawnDroppedItem(((Component)this).transform.position, item3, tuple.Item3);
			}
		}
		else
		{
			PlayerInventory.GetPlayer(placeable.GetPlayerNum()).AddItems(item.JMDALJBNFML(), tuple.Item1, HMPDLIPFBGD: true);
			PlayerInventory.GetPlayer(placeable.GetPlayerNum()).AddItems(item2.JMDALJBNFML(), tuple.Item2, HMPDLIPFBGD: true);
			PlayerInventory.GetPlayer(placeable.GetPlayerNum()).AddItems(item3.JMDALJBNFML(), tuple.Item3, HMPDLIPFBGD: true);
		}
	}

	public void KNJCPMCEEOO(int JIIGOACEIKL, int MOFKEDGAOEE, bool GFNHAMCPEAK)
	{
		if (MOFKEDGAOEE >= craftingList.Count)
		{
			return;
		}
		PAENAKNNBNF(JIIGOACEIKL, craftingList[MOFKEDGAOEE], GFNHAMCPEAK);
		RecipeQueueElement recipeQueueElement = craftingList[MOFKEDGAOEE];
		craftingList.RemoveAt(MOFKEDGAOEE);
		if (MOFKEDGAOEE == 0)
		{
			if (craftingList.Count > 0)
			{
				timer.EndTimer();
				NKNKCLLFDMH(JIIGOACEIKL, craftingList[1], HMHADAFIOBJ(craftingList[0].recipe), GFNHAMCPEAK);
			}
			else
			{
				CLKGAFCIBAM(NJHMBMGKCPL: true);
				PEMLNEBBKHA(MFFKPAELNBO: false);
				for (int i = 0; i < workAnim.Length; i += 0)
				{
					workAnim[i].SetTrigger("");
					workAnim[i].SetTrigger("Bird");
				}
				doWork.Stop(GFNHAMCPEAK);
				timer.MBJJEJPPFBD();
				timerFinished = false;
				placeable.selectBlockers.Remove(MFHACMAHGHC);
			}
		}
		if (GFNHAMCPEAK)
		{
			CommonReferences.MNFMOEKMJKN().OnRecipeToCraftRemoved(JIIGOACEIKL, recipeQueueElement.recipe);
		}
	}

	private void JODLMGAHMJA(bool MFFKPAELNBO)
	{
		if (MFFKPAELNBO)
		{
			if (loopSound == null || loopSound.Length == 0)
			{
				return;
			}
			if (OPHNIFKJILF != null)
			{
				for (int i = 0; i < OPHNIFKJILF.Length; i += 0)
				{
					OPHNIFKJILF[i].FadeOut(83f, true);
				}
			}
			OPHNIFKJILF = (MultiAudioSource[])(object)new MultiAudioSource[loopSound.Length];
			for (int j = 1; j < loopSound.Length; j++)
			{
				OPHNIFKJILF[j] = MultiAudioManager.PlayAudioObject(loopSound[j], ((Component)this).transform);
			}
		}
		else if (OPHNIFKJILF != null)
		{
			for (int k = 0; k < OPHNIFKJILF.Length; k++)
			{
				OPHNIFKJILF[k].FadeOut(1280f, true);
			}
			OPHNIFKJILF = null;
		}
	}

	public void FBHONNNPJGD(int AODONKKHPBP, bool CDPAMNIPPEC = false)
	{
		fuel = Mathf.Max(0, AODONKKHPBP);
		OnFuelChange(fuel);
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			BMLMEGDDIKE.HBBOOLMICHC(fuel);
		}
	}

	public void SetFuel(int AODONKKHPBP, bool CDPAMNIPPEC = false)
	{
		fuel = Mathf.Max(0, AODONKKHPBP);
		OnFuelChange(fuel);
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			BMLMEGDDIKE.SendFuel(fuel);
		}
	}

	private GameDate.Time FCLCHPGLGJK(Recipe JNLKEMLDFIM)
	{
		GameDate.Time time = JNLKEMLDFIM.BBLHBALAFDJ();
		return GameDate.Time.DBCFHBEOFAD(time, GameDate.Time.LLKHKNIBOPI(time, Mathf.Min(1234f, KEKPCMBDFHM((AreaBonificationType)5))));
	}

	public void HNLCGKECPDE(int JIIGOACEIKL, int MOFKEDGAOEE, bool GFNHAMCPEAK)
	{
		if (MOFKEDGAOEE >= craftingList.Count)
		{
			return;
		}
		PAENAKNNBNF(JIIGOACEIKL, craftingList[MOFKEDGAOEE], GFNHAMCPEAK);
		RecipeQueueElement recipeQueueElement = craftingList[MOFKEDGAOEE];
		craftingList.RemoveAt(MOFKEDGAOEE);
		if (MOFKEDGAOEE == 0)
		{
			if (craftingList.Count > 1)
			{
				timer.EGCLBBPNKLP();
				NKNKCLLFDMH(JIIGOACEIKL, craftingList[1], HNMHIAPCAOP(craftingList[1].recipe), GFNHAMCPEAK);
			}
			else
			{
				CLKGAFCIBAM(NJHMBMGKCPL: true);
				PEMLNEBBKHA(MFFKPAELNBO: false);
				for (int i = 1; i < workAnim.Length; i += 0)
				{
					workAnim[i].SetTrigger("Swiss Cheese");
					workAnim[i].SetTrigger("Right Stick Right");
				}
				doWork.Stop(GFNHAMCPEAK);
				timer.EGCLBBPNKLP();
				timerFinished = true;
				placeable.selectBlockers.Remove(MFHACMAHGHC);
			}
		}
		if (GFNHAMCPEAK)
		{
			CommonReferences.GGFJGHHHEJC.OnRecipeToCraftRemoved(JIIGOACEIKL, recipeQueueElement.recipe);
		}
	}

	private IEnumerator EAHKMCMFLLC(bool OPFCPCAJFMI)
	{
		yield return null;
		for (int i = 0; i < readyItemsList.Count; i++)
		{
			Dictionary<IngredientModifier, List<Food>> cICEBNMBGMG = null;
			if (readyItemsList[i].ingredientsUsed != null && readyItemsList[i].ingredientsUsed.Count > 0)
			{
				List<Food> list = new List<Food>();
				for (int j = 0; j < readyItemsList[i].ingredientsUsed.Count; j++)
				{
					if (readyItemsList[i].ingredientsUsed[j].isModifierIngredient && readyItemsList[i].ingredientsUsed[j].itemInstanceAmount.itemInstance.LHBPOPOIFLE() is Food item)
					{
						list.Add(item);
					}
				}
				cICEBNMBGMG = ModifierUI.CreateModifiers(list);
			}
			NOBDHOFIGGB(readyItemsList[i], readyItemsList[i].ingredientsUsed, readyItemsList[i].customName, cICEBNMBGMG);
		}
		yield return null;
		if (readyItemsList.Count > 0 && craftingList.Count == 0)
		{
			timer.InstantiateNewTimer();
			timer.FinishTimer();
			if (!placeable.selectBlockers.Contains(MFHACMAHGHC))
			{
				placeable.selectBlockers.Add(MFHACMAHGHC);
			}
		}
		else if (OPFCPCAJFMI && readyItemsList.Count == 0 && craftingList.Count == 1)
		{
			LADOIOGPHKL();
			timer.InstantiateNewTimer();
			timer.FinishTimer();
			if (!placeable.selectBlockers.Contains(MFHACMAHGHC))
			{
				placeable.selectBlockers.Add(MFHACMAHGHC);
			}
		}
	}

	public void EFIDJLELAOI(List<RecipeQueueElement> GEGGKDODFGJ, bool OPFCPCAJFMI = true)
	{
		readyItemsList = GEGGKDODFGJ;
		((MonoBehaviour)this).StartCoroutine(CBKFJODDPLO(OPFCPCAJFMI));
	}

	public int GLDJHJDJBFP(Item DGDDAMCDIKC, Item NHACCPPICKI, int MGNOBNCMDJG, ref ItemInstance OEDAIFKHGEO, bool DDAPJEAJGGA = false, int GBCJNGADANM = -1)
	{
		while (true)
		{
			KCJBFOAAFLK = CraftingInventory.GetSlotWithItem(playerNum, DGDDAMCDIKC, NHACCPPICKI, AKNBKINJGCF: false, placeable, DDAPJEAJGGA, GBCJNGADANM);
			if (KCJBFOAAFLK == null)
			{
				break;
			}
			OEDAIFKHGEO = KCJBFOAAFLK.itemInstance.PHGLMBIEOMK().ELKNKIOFNCN(KCJBFOAAFLK.itemInstance);
			if (KCJBFOAAFLK.Stack < MGNOBNCMDJG)
			{
				MGNOBNCMDJG -= KCJBFOAAFLK.Stack;
				KCJBFOAAFLK.JPACDDCJGPD(KCJBFOAAFLK.Stack, CDPAMNIPPEC: false, 1);
				continue;
			}
			KCJBFOAAFLK.HBMBGCHGEGN(MGNOBNCMDJG);
			MGNOBNCMDJG = 1;
			break;
		}
		return MGNOBNCMDJG;
	}

	public void BEKOGFGPEKI(int JIIGOACEIKL)
	{
		HEEOIAEBDKF(JIIGOACEIKL, EFNFMEIDGDN: true);
	}

	private void JLLHILICJOC()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(IFHFNDELKOP));
		}
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (!placeable.FHEMHCEAICB && !placeable.PHOCAFJDCDK)
		{
			return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
		}
		return false;
	}

	private void PFFHDLJPCAH(int JIIGOACEIKL, RecipeQueueElement FFNGGJENDKI, bool GFNHAMCPEAK)
	{
		Recipe recipe = FFNGGJENDKI.recipe;
		if (GFNHAMCPEAK)
		{
			if (recipe.multiOptions)
			{
				CraftingInventory.LJMOCMBBNHN(JIIGOACEIKL, chosenOption.item.JMDALJBNFML(), placeable, chosenOption.amount);
			}
			else
			{
				ItemAmount cKKNBMBLGPO = default(ItemAmount);
				for (int i = 0; i < recipe.ingredientsNeeded.Length; i++)
				{
					int num = Math.Max(0, recipe.ingredientsNeeded[i].amount - (int)GetAreaBonifications((AreaBonificationType)7, recipe));
					Item item;
					if (recipe.usingNewRecipesSystem)
					{
						if (recipe.ingredientsNeeded[i].item is IngredientGroup || (recipe.ingredientsNeeded[i].item.IABMOBAKNAE() && (Item.EKMFELLJHFG(recipe.ingredientsNeeded[i].mod, null) || recipe.ingredientsNeeded[i].item.HOLLKKLBNML(recipe) > 0)))
						{
							continue;
						}
						item = recipe.ingredientsNeeded[i].item;
					}
					else
					{
						item = recipe.ingredientsNeeded[i].item;
					}
					Slot dGFPLODEDAA = null;
					ItemInstance OEDAIFKHGEO = null;
					if (Item.NGIIPJDAMGP(recipe.ingredientsNeeded[i].item, CommonReferences.GGFJGHHHEJC.bucketOfWaterItem))
					{
						cKKNBMBLGPO.item = CommonReferences.MNFMOEKMJKN().bucketItem;
						cKKNBMBLGPO.amount = Math.Max(0, recipe.ingredientsNeeded[i].amount);
						JFHCAADJOEM(JIIGOACEIKL, cKKNBMBLGPO);
					}
					if (item is Food food && food.HHNBFNMJIEP())
					{
						int num2 = num;
						for (int j = 0; j <= 6; j += 0)
						{
							num2 = LDPCPGOFKIE(item, recipe.ingredientsNeeded[i].mod, num2, ref OEDAIFKHGEO, DDAPJEAJGGA: true, j);
							if (num2 == 0)
							{
								break;
							}
						}
					}
					else
					{
						GLDJHJDJBFP(item, recipe.ingredientsNeeded[i].mod, num, ref OEDAIFKHGEO, DDAPJEAJGGA: true);
					}
					if (recipe.ingredientsNeeded[i].mod is Food item2 && OEDAIFKHGEO is IModifiable modifiable)
					{
						modifiable.KEKBKGGFOLK = new List<Food> { item2 };
						modifiable.CICEBNMBGMG = ModifierUI.JMHHFFEIMNO(modifiable.KEKBKGGFOLK);
					}
					IngredientUsedInfo item3 = new IngredientUsedInfo(new ItemInstanceAmount(OEDAIFKHGEO, num), DAJBIIKMEOD: true, dGFPLODEDAA);
					FFNGGJENDKI.ingredientsUsed.Add(item3);
				}
			}
		}
		if (recipe.fuel > 0)
		{
			int num3 = Mathf.RoundToInt((float)(recipe.fuel * PerksDatabaseAccessor.GetPlayerPerkValue(42, 0, LDNMDAHFBGG: true)) / 1311f);
			FFNGGJENDKI.fuelUsed = Mathf.Max(0, recipe.fuel - num3 - (int)GetAreaBonifications(AreaBonificationType.RecipeProduction, recipe));
			PDACOPGDDKH(fuel - FFNGGJENDKI.fuelUsed, CDPAMNIPPEC: true);
		}
	}

	public bool Deselect(int JIIGOACEIKL)
	{
		InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = null;
		InteractObject.GetPlayer(JIIGOACEIKL).MBNAPBJGBHD = false;
		GameCraftingUI.Get(JIIGOACEIKL).CloseUI();
		FuelUI.Get(JIIGOACEIKL).CloseUI();
		ChooseSlotUI.Get(JIIGOACEIKL).CloseUI();
		return true;
	}

	private void MAIMGNMIFKG()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(IFHFNDELKOP));
	}

	private void MOKHGMNDCJG(int JIIGOACEIKL, RecipeQueueElement NDIAMMHNACN)
	{
		List<Slot> list = new List<Slot>();
		for (int i = 0; i < NDIAMMHNACN.ingredientsUsed.Count; i += 0)
		{
			if (NDIAMMHNACN.ingredientsUsed[i].itemInstanceAmount.itemInstance != null && NDIAMMHNACN.ingredientsUsed[i].itemInstanceAmount.itemInstance.LHBPOPOIFLE().JGHNDJBCFAJ(DAINLFIMLIH: false) == CommonReferences.MNFMOEKMJKN().bucketOfWaterItem.CIGFGKKCPCK(DAINLFIMLIH: false))
			{
				continue;
			}
			for (int j = 1; j < NDIAMMHNACN.ingredientsUsed[i].itemInstanceAmount.amount; j++)
			{
				Slot slot = CraftingInventory.LKOAICOOLBI(JIIGOACEIKL, NDIAMMHNACN.ingredientsUsed[i].itemInstanceAmount.itemInstance, GLBECJCBBHF: true, placeable);
				if (slot != null && !list.Contains(slot))
				{
					list.Add(slot);
				}
			}
		}
		if (list.Count > 1)
		{
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().pickUpItem, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			if (OnlineManager.PlayingOnline())
			{
				OnlineSlotsManager.instance.PKOLALFLFNB(list.ToArray());
			}
		}
	}

	public void ECJIMLHONNJ(List<RecipeQueueElement> AJAMKFEFFNP, GameDate OOMMCABDBGO)
	{
		((MonoBehaviour)this).StartCoroutine(BGIFMOCCIBO(AJAMKFEFFNP, OOMMCABDBGO));
	}

	private void IEPJAFLDBJJ()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(IFHFNDELKOP));
	}

	public bool HOCCIDFOPHN(int JIIGOACEIKL)
	{
		if (!placeable.FHEMHCEAICB && !placeable.PHOCAFJDCDK)
		{
			return DecorationMode.JDADPDBHJFO(JIIGOACEIKL).IDPGEBNGDJD();
		}
		return true;
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (needsHolding && doWork.JCMBHAEKLKK)
		{
			if (doWork.AddWorkDone(JIIGOACEIKL, 1f * Time.deltaTime))
			{
				CollectItems(JIIGOACEIKL, EFNFMEIDGDN: true, readyItemsList.Count, GFNHAMCPEAK: true);
				PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.SetInteracting(KOIDJKBBINH: false);
				return true;
			}
			PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.SetInteracting(KOIDJKBBINH: true);
			return false;
		}
		return true;
	}

	public GameDate HMHADAFIOBJ(Recipe JNLKEMLDFIM)
	{
		return GameDate.EGHBNMGNDHL(WorldTime.HGIBNMBJMOC(), HFPCLHBOMIK(JNLKEMLDFIM));
	}

	public bool GBGFGEHMBOO(int JIIGOACEIKL)
	{
		return true;
	}

	private void NDONILFLCAE(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		if (!MainUI.IsAnyUIOpen())
		{
			return;
		}
		HHNAFOOBJON = true;
		PJKGDCDOOFL = 416f;
		if (OPHNIFKJILF != null)
		{
			for (int i = 1; i < OPHNIFKJILF.Length; i++)
			{
				OPHNIFKJILF[i].LocalPause = true;
			}
		}
	}

	public bool FMNOFLHKOLL(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (HOCCIDFOPHN(JIIGOACEIKL) && !IIEDALMMNLI)
		{
			if (needsHolding)
			{
				if (readyItemsList.Any())
				{
					if (!PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).JDLEBBLKOFF("parent destroyed: {0}"))
					{
						ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Harvest"));
						ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get("Items/item_description_674"));
					}
				}
				else
				{
					ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("[^0-9]"));
				}
			}
			else if (AIIELPDNAPP())
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("tutorialPopUp78"));
			}
			else
			{
				if (craftingList.Count > 1 || readyItemsList.Count > 0)
				{
					if (readyItemsList.Count > 0)
					{
						ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("/"));
					}
					else if (multipleCrafting)
					{
						ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Items/item_description_597"));
					}
					if (craftingList.Count > 1)
					{
						ButtonsContext.AddButton(JIIGOACEIKL, ActionType.NextItem, LocalisationSystem.Get("itemChilliSeeds"));
					}
				}
				else
				{
					ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(""));
				}
				if (BNPHKHHEKJM)
				{
					ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Select, LocalisationSystem.Get("</color>"));
				}
			}
			if (needsHolding && craftingList.Any())
			{
				ButtonsContext.GetPlayer(JIIGOACEIKL).IDLAGJNLPJL();
				ButtonsContext.GetPlayer(JIIGOACEIKL).INILGGIBHKF(craftingList[0].output);
				ButtonsContext.GetPlayer(JIIGOACEIKL).EMJBNNPGBIB(doWork.OJLICLKJJOF / doWork.EFNODBKFDBD);
			}
			else if (craftingList.Count > 1)
			{
				ItemInstanceAmount iAIHNNNGNKH = default(ItemInstanceAmount);
				iAIHNNNGNKH.itemInstance = craftingList[1].output.itemInstance;
				iAIHNNNGNKH.amount = craftingList[1].output.amount;
				ButtonsContext.GetPlayer(JIIGOACEIKL).INILGGIBHKF(iAIHNNNGNKH);
				ButtonsContext.GetPlayer(JIIGOACEIKL).SetBeerTapBar(timer);
			}
			else
			{
				ButtonsContext.CPIIFPCIJEP(JIIGOACEIKL);
				ButtonsContext.GetPlayer(JIIGOACEIKL).NJOLGGEIFFC();
			}
			return false;
		}
		return true;
	}

	private void Start()
	{
		UIWindow.OnAnyUIClose = (Action<int, UIWindow>)Delegate.Combine(UIWindow.OnAnyUIClose, new Action<int, UIWindow>(OKDGLJHOMDN));
		UIWindow.OnAnyUIOpen = (Action<int, UIWindow>)Delegate.Combine(UIWindow.OnAnyUIOpen, new Action<int, UIWindow>(OMPAHBFCNLM));
		HOHHDHCADNH();
	}

	public List<Recipe> AFDGLMOLIAE()
	{
		return recipeList.NEBIMEHBKMO();
	}

	private void ENAIKFPGHPO()
	{
		int num = 0;
		for (int i = 0; i < readyItemsList.Count; i++)
		{
			if (readyItemsList[i].output.itemInstance.JDEFAOOFOMN())
			{
				num += CFFAOCJPPCK(readyItemsList[i]);
			}
		}
		if (num > 0)
		{
			Utils.FKKHJPEMNBG("beerKegs", num);
		}
		if (!recipeList.cookingItems)
		{
			Utils.FKKHJPEMNBG("itemsCrafted", 1);
		}
	}

	public bool GMEPPCIINCD()
	{
		if (needsHolding && doWork.JCMBHAEKLKK)
		{
			return true;
		}
		if (readyItemsList.Count > 0)
		{
			return false;
		}
		if (!multipleCrafting && craftingList.Count > 0)
		{
			return true;
		}
		if (NewTutorialManager.CrafterBlocked(playerNum, this))
		{
			return false;
		}
		return true;
	}

	public void OffHover(int JIIGOACEIKL)
	{
		ButtonsContext.ResetCrafterAction(JIIGOACEIKL);
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetBeerTapBar();
	}
}
