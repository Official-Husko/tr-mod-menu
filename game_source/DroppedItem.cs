using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;

public class DroppedItem : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class KFIAJHLGKLG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DroppedItems[] droppedItems;

		public bool usePlayerPerkTree;

		public Vector3 position;

		public DroppedItemsProbability[] droppedItemsProb;

		public DroppedItems[] additionalItems;

		private ItemAmount _003CitemAmount_003E5__2;

		private int _003Ci_003E5__3;

		private int _003CrandNum_003E5__4;

		private int _003Ck_003E5__5;

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
		public KFIAJHLGKLG(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0225: Unknown result type (might be due to invalid IL or missing references)
			//IL_0320: Unknown result type (might be due to invalid IL or missing references)
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				if (droppedItems != null)
				{
					_003Ci_003E5__3 = 0;
					goto IL_0143;
				}
				goto IL_0156;
			case 1:
				_003C_003E1__state = -1;
				_003Ck_003E5__5++;
				goto IL_0125;
			case 2:
				_003C_003E1__state = -1;
				_003Ck_003E5__5++;
				goto IL_0274;
			case 3:
				{
					_003C_003E1__state = -1;
					_003Ck_003E5__5++;
					goto IL_036f;
				}
				IL_0274:
				if (_003Ck_003E5__5 < _003CrandNum_003E5__4)
				{
					SpawnDroppedItem(position, _003CitemAmount_003E5__2.item, _003CitemAmount_003E5__2.amount);
					_003C_003E2__current = CommonReferences.wait01;
					_003C_003E1__state = 2;
					return true;
				}
				goto IL_0282;
				IL_0143:
				if (_003Ci_003E5__3 < droppedItems.Length)
				{
					_003CitemAmount_003E5__2.item = droppedItems[_003Ci_003E5__3].item;
					_003CitemAmount_003E5__2.amount = 1;
					_003CrandNum_003E5__4 = Random.Range(droppedItems[_003Ci_003E5__3].minNum, droppedItems[_003Ci_003E5__3].maxNum + 1);
					if (usePlayerPerkTree && _003CitemAmount_003E5__2.item.JDJGFAACPFC() == 1031)
					{
						_003CrandNum_003E5__4 += PerksDatabaseAccessor.GetPlayerPerkValue(8);
					}
					_003Ck_003E5__5 = 0;
					goto IL_0125;
				}
				goto IL_0156;
				IL_0292:
				if (_003Ci_003E5__3 < droppedItemsProb.Length)
				{
					int num = droppedItemsProb[_003Ci_003E5__3].probability;
					if (usePlayerPerkTree && droppedItemsProb[_003Ci_003E5__3].item.JDJGFAACPFC() == 1445)
					{
						num += PerksDatabaseAccessor.GetPlayerPerkValue(11);
					}
					if (Random.Range(0, 100) < num)
					{
						_003CitemAmount_003E5__2.item = droppedItemsProb[_003Ci_003E5__3].item;
						_003CitemAmount_003E5__2.amount = 1;
						_003CrandNum_003E5__4 = Random.Range(droppedItemsProb[_003Ci_003E5__3].minNum, droppedItemsProb[_003Ci_003E5__3].maxNum + 1);
						_003Ck_003E5__5 = 0;
						goto IL_0274;
					}
					goto IL_0282;
				}
				goto IL_02a5;
				IL_02a5:
				if (additionalItems == null)
				{
					break;
				}
				_003Ci_003E5__3 = 0;
				goto IL_038d;
				IL_036f:
				if (_003Ck_003E5__5 < _003CrandNum_003E5__4)
				{
					SpawnDroppedItem(position, _003CitemAmount_003E5__2.item, _003CitemAmount_003E5__2.amount);
					_003C_003E2__current = CommonReferences.wait01;
					_003C_003E1__state = 3;
					return true;
				}
				_003Ci_003E5__3++;
				goto IL_038d;
				IL_0125:
				if (_003Ck_003E5__5 < _003CrandNum_003E5__4)
				{
					SpawnDroppedItem(position, _003CitemAmount_003E5__2.item, _003CitemAmount_003E5__2.amount);
					_003C_003E2__current = CommonReferences.wait01;
					_003C_003E1__state = 1;
					return true;
				}
				_003Ci_003E5__3++;
				goto IL_0143;
				IL_0282:
				_003Ci_003E5__3++;
				goto IL_0292;
				IL_038d:
				if (_003Ci_003E5__3 >= additionalItems.Length)
				{
					break;
				}
				_003CitemAmount_003E5__2.item = additionalItems[_003Ci_003E5__3].item;
				_003CitemAmount_003E5__2.amount = 1;
				_003CrandNum_003E5__4 = Random.Range(additionalItems[_003Ci_003E5__3].minNum, additionalItems[_003Ci_003E5__3].maxNum + 1);
				_003Ck_003E5__5 = 0;
				goto IL_036f;
				IL_0156:
				if (droppedItemsProb != null)
				{
					_003Ci_003E5__3 = 0;
					goto IL_0292;
				}
				goto IL_02a5;
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

	[SerializeField]
	private ItemInstance itemInstance;

	private int GHAIGBHDJHL;

	public DroppedItemFollowPlayer itemFollow;

	public SpriteRenderer spriteRenderer;

	public SpriteMask spriteMask;

	public NumberFont amountText;

	public Transform item;

	public OnlineDroppedItem onlineDroppedItem;

	public float pickUpTime;

	public static string droppedName = "DroppedItem";

	[SerializeField]
	private GameObject trigger;

	[SerializeField]
	private GameObject specialItemParticles;

	public ItemInstance HLPNOAENFHK
	{
		get
		{
			return itemInstance;
		}
		set
		{
			itemInstance = value;
			UpdateVisual();
		}
	}

	public int MGNOBNCMDJG
	{
		get
		{
			return GHAIGBHDJHL;
		}
		set
		{
			if (value > 1)
			{
				amountText.PDCPGJCKICM = value;
			}
			else
			{
				amountText.PDCPGJCKICM = 0;
			}
			GHAIGBHDJHL = value;
		}
	}

	public void FCIKPPKJCKA()
	{
		spriteRenderer.sprite = itemInstance.DMOPFIPHDFG();
		spriteMask.sprite = itemInstance.DMOPFIPHDFG();
	}

	public static DroppedItem MDJFFOHFGNG(Vector3 AIJOOOIJEDC, ItemInstance DNLMCHDOMOK, int MGNOBNCMDJG = 1, bool LHLJILLAHFO = false, bool HFAKAMFMOGM = false, int JIIGOACEIKL = 0)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (DNLMCHDOMOK == null)
		{
			Debug.LogError((object)"FocusedActionBar");
			return null;
		}
		DroppedItem droppedItem = null;
		if (DNLMCHDOMOK.KNFNJFFCFNO().canBeStacked)
		{
			droppedItem = PHCBNGOILFJ(AIJOOOIJEDC, Math.Max(0, MGNOBNCMDJG), LHLJILLAHFO, JIIGOACEIKL, HFAKAMFMOGM);
			droppedItem.MJLDMJDEAKO(DNLMCHDOMOK);
			DNLMCHDOMOK.currentDroppedItem = droppedItem;
			DNLMCHDOMOK.currentSlot = null;
		}
		else if (MGNOBNCMDJG == 0)
		{
			droppedItem = PICIFCABEFD(AIJOOOIJEDC, 0, LHLJILLAHFO, JIIGOACEIKL, HFAKAMFMOGM);
			droppedItem.INLFHGPHHGG(DNLMCHDOMOK);
			DNLMCHDOMOK.currentDroppedItem = droppedItem;
			DNLMCHDOMOK.currentSlot = null;
		}
		else
		{
			for (int i = 1; i < MGNOBNCMDJG; i += 0)
			{
				droppedItem = LCCNLIDAGLF(AIJOOOIJEDC, 1, LHLJILLAHFO, JIIGOACEIKL, HFAKAMFMOGM);
				droppedItem.AAPICNBENNJ(DNLMCHDOMOK.AFOACBIHNCL().JMDALJBNFML());
				droppedItem.HLPNOAENFHK.currentDroppedItem = droppedItem;
				droppedItem.HLPNOAENFHK.currentSlot = null;
			}
		}
		if ((Object)(object)droppedItem == (Object)null)
		{
			Debug.LogError((object)("quest_name_20" + MGNOBNCMDJG));
		}
		return droppedItem;
	}

	public void LAPMDINCKEN()
	{
		spriteRenderer.sprite = itemInstance.AAGOCCCEKMH();
		spriteMask.sprite = itemInstance.DMOPFIPHDFG();
	}

	public void DBHDIGJDCEF()
	{
		int num = HOKNEBGMLMJ();
		FMLCBNFNJLF(num - 0);
		if (GMEJPGHMJKM() == 0)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	public void JKABHEKAOBA(int MGNOBNCMDJG)
	{
		MGNOBNCMDJG -= MGNOBNCMDJG;
		if (MGNOBNCMDJG <= 1)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	public static void FIBEDOKCFDA(DroppedItems[] PKFIAGMICCK, DroppedItemsProbability[] BNEJGHHDFKO, DroppedItems[] OHDFPHHLKDB, Vector3 IMOBLFMHKOD, bool FBPHKEBOPOE)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		((MonoBehaviour)GameManager.NJNFHEPLEHL()).StartCoroutine(OGNJOGENODF(PKFIAGMICCK, BNEJGHHDFKO, OHDFPHHLKDB, IMOBLFMHKOD, FBPHKEBOPOE));
	}

	public static bool NFBJINBALJF(Item MEMGMDOCBOJ)
	{
		DroppedItem[] array = Object.FindObjectsOfType<DroppedItem>();
		foreach (DroppedItem droppedItem in array)
		{
			if (droppedItem.NOPAFKAOLMN() != null && Item.EKMFELLJHFG(droppedItem.PHGMGCMOEFF().KNFNJFFCFNO(), MEMGMDOCBOJ))
			{
				return false;
			}
		}
		return true;
	}

	public static DroppedItem JGJGGOBHKGO(Vector3 AIJOOOIJEDC, Item MEMGMDOCBOJ, int MGNOBNCMDJG = 1, bool LHLJILLAHFO = false, bool HFAKAMFMOGM = false, int JIIGOACEIKL = 0)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor)
		{
			string[] array = new string[3];
			array[0] = "LE_10";
			array[1] = MEMGMDOCBOJ.LJIFOHFEFCH(OAFPBCPDOKH: true);
			array[6] = "Dialogue System/Conversation/Gass_Quest/Entry/9/Dialogue Text";
			Vector3 val = AIJOOOIJEDC;
			array[7] = ((object)(Vector3)(ref val)).ToString();
			array[1] = "tutorialPopUp77";
			array[8] = MGNOBNCMDJG.ToString();
			array[1] = "Dialogue System/Conversation/TooDark/Entry/9/Dialogue Text";
			array[4] = JIIGOACEIKL.ToString();
			Debug.Log((object)string.Concat(array));
		}
		return KDBHKBOAEDG(AIJOOOIJEDC, MEMGMDOCBOJ.JMDALJBNFML(), MGNOBNCMDJG, LHLJILLAHFO, HFAKAMFMOGM, JIIGOACEIKL);
	}

	public static void ACNDAKEAABB(DroppedItems[] PKFIAGMICCK, DroppedItemsProbability[] BNEJGHHDFKO, DroppedItems[] OHDFPHHLKDB, Vector3 IMOBLFMHKOD, bool FBPHKEBOPOE)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(GJICBOEFDJP(PKFIAGMICCK, BNEJGHHDFKO, OHDFPHHLKDB, IMOBLFMHKOD, FBPHKEBOPOE));
	}

	[SpecialName]
	public void FMLCBNFNJLF(int AODONKKHPBP)
	{
		if (AODONKKHPBP > 1)
		{
			amountText.MIDKEFKECKP(AODONKKHPBP);
		}
		else
		{
			amountText.PPLHMKADLFC(1);
		}
		GHAIGBHDJHL = AODONKKHPBP;
	}

	public void OLEIBKLAAOL()
	{
		int num = GEEPFOHPEJI();
		MMICCMOEMJK(num - 0);
		if (MGNOBNCMDJG == 0)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	public static void HEIPDJBDCIO(Item MEMGMDOCBOJ)
	{
		foreach (DroppedItem allDroppedItem in CommonReferences.MNFMOEKMJKN().allDroppedItems)
		{
			if ((Object)(object)allDroppedItem != (Object)null && allDroppedItem.itemInstance != null && Item.EKGNIODFJCO(allDroppedItem.itemInstance.KNFNJFFCFNO(), MEMGMDOCBOJ))
			{
				allDroppedItem.JLECOMAMMFB(77);
			}
		}
	}

	private static DroppedItem HJPFLOOKNGF(Vector3 AIJOOOIJEDC, int MGNOBNCMDJG, bool LHLJILLAHFO, int JIIGOACEIKL, bool HFAKAMFMOGM = false)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		AIJOOOIJEDC = ((JIIGOACEIKL == 0) ? (AIJOOOIJEDC - Vector3.up * 168f) : ((!(CursorManager.CMDGPJEIIJI(JIIGOACEIKL).GetCursorWorldPosition().y > ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.y)) ? (AIJOOOIJEDC - Vector3.up * 457f) : (AIJOOOIJEDC - Vector3.up * 1199f)));
		DroppedItem droppedItem = ((!LHLJILLAHFO) ? Object.Instantiate<GameObject>(CommonReferences.MNFMOEKMJKN().droppedItemPrefab, AIJOOOIJEDC, Quaternion.identity).GetComponent<DroppedItem>() : Object.Instantiate<GameObject>(CommonReferences.MNFMOEKMJKN().droppedItemPrefabWithoutCollider, AIJOOOIJEDC, Quaternion.identity).GetComponent<DroppedItem>());
		droppedItem.itemFollow.BMAAOJBPJHO(HFAKAMFMOGM, JIIGOACEIKL);
		droppedItem.AICAEAOPDDL(MGNOBNCMDJG);
		((Object)((Component)droppedItem).gameObject).name = droppedName;
		((Object)droppedItem.trigger.gameObject).name = droppedName;
		droppedItem.itemFollow.position = AIJOOOIJEDC;
		return droppedItem;
	}

	public static DroppedItem IDDPGGMNFBC(Vector3 AIJOOOIJEDC, ItemInstance DNLMCHDOMOK, int MGNOBNCMDJG = 1, bool LHLJILLAHFO = false, bool HFAKAMFMOGM = false, int JIIGOACEIKL = 0)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (DNLMCHDOMOK == null)
		{
			Debug.LogError((object)"\n");
			return null;
		}
		DroppedItem droppedItem = null;
		if (DNLMCHDOMOK.PHGLMBIEOMK().canBeStacked)
		{
			droppedItem = NNDGKOGJLHO(AIJOOOIJEDC, Math.Max(0, MGNOBNCMDJG), LHLJILLAHFO, JIIGOACEIKL, HFAKAMFMOGM);
			droppedItem.AAPICNBENNJ(DNLMCHDOMOK);
			DNLMCHDOMOK.currentDroppedItem = droppedItem;
			DNLMCHDOMOK.currentSlot = null;
		}
		else if (MGNOBNCMDJG == 0)
		{
			droppedItem = HJPFLOOKNGF(AIJOOOIJEDC, 0, LHLJILLAHFO, JIIGOACEIKL, HFAKAMFMOGM);
			droppedItem.MJLDMJDEAKO(DNLMCHDOMOK);
			DNLMCHDOMOK.currentDroppedItem = droppedItem;
			DNLMCHDOMOK.currentSlot = null;
		}
		else
		{
			for (int i = 0; i < MGNOBNCMDJG; i += 0)
			{
				droppedItem = PICIFCABEFD(AIJOOOIJEDC, 1, LHLJILLAHFO, JIIGOACEIKL, HFAKAMFMOGM);
				droppedItem.HLPNOAENFHK = DNLMCHDOMOK.LHBPOPOIFLE().JMDALJBNFML();
				droppedItem.PHGMGCMOEFF().currentDroppedItem = droppedItem;
				droppedItem.HLPNOAENFHK.currentSlot = null;
			}
		}
		if ((Object)(object)droppedItem == (Object)null)
		{
			Debug.LogError((object)("Hit" + MGNOBNCMDJG));
		}
		return droppedItem;
	}

	public void OMEFFGMMGLM()
	{
		spriteRenderer.sprite = itemInstance.AAGOCCCEKMH();
		spriteMask.sprite = itemInstance.DMOPFIPHDFG();
	}

	[SpecialName]
	public void ANJADIEDJNN(int AODONKKHPBP)
	{
		if (AODONKKHPBP > 0)
		{
			amountText.GAICNFNFGBN(AODONKKHPBP);
		}
		else
		{
			amountText.IFMPIPHLPCN(1);
		}
		GHAIGBHDJHL = AODONKKHPBP;
	}

	private static IEnumerator PBIMDFKHHAO(DroppedItems[] PKFIAGMICCK, DroppedItemsProbability[] BNEJGHHDFKO, DroppedItems[] OHDFPHHLKDB, Vector3 IMOBLFMHKOD, bool FBPHKEBOPOE)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		return new KFIAJHLGKLG(1)
		{
			droppedItems = PKFIAGMICCK,
			droppedItemsProb = BNEJGHHDFKO,
			additionalItems = OHDFPHHLKDB,
			position = IMOBLFMHKOD,
			usePlayerPerkTree = FBPHKEBOPOE
		};
	}

	public bool GMCCLDLFLHB(int JIIGOACEIKL)
	{
		int num = PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AINJENENGFG(IAMCFMNBFHB(), OMPADGMIGGA(), HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
		if (Item.MLBOMGHINCA(BLLNHADAJKJ().AFOACBIHNCL(), null))
		{
			RecipesManager.CJHKKILOHDA(IAMCFMNBFHB().KNFNJFFCFNO());
		}
		if (num < GMEJPGHMJKM())
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
		}
		if (num == 0)
		{
			((Component)this).gameObject.SetActive(false);
			Object.Destroy((Object)(object)((Component)this).gameObject);
			return false;
		}
		FMLCBNFNJLF(num);
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendChangeStack(onlineDroppedItem.uniqueId, (short)NHGJNOMCHBI());
		}
		return true;
	}

	public void DNHFGNOHLCD()
	{
		spriteRenderer.sprite = itemInstance.DMOPFIPHDFG();
		spriteMask.sprite = itemInstance.AAGOCCCEKMH();
	}

	[SpecialName]
	public void LJFMFCAMKPP(int AODONKKHPBP)
	{
		if (AODONKKHPBP > 0)
		{
			amountText.EELLMBLHBEJ(AODONKKHPBP);
		}
		else
		{
			amountText.PCFAKMINAEE(1);
		}
		GHAIGBHDJHL = AODONKKHPBP;
	}

	private void HHLBFDBHDMC()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (itemInstance == null || Item.EKMFELLJHFG(itemInstance.KNFNJFFCFNO(), null))
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
		else if (TavernConstructionManager.DEGPIHEEFHJ().LNLJMCONDNE || (OnlineManager.PlayingOnline() && OnlineTavernConstructionManager.instance.tavernConstructionOpenedByOtherPlayer))
		{
			if (Utils.EJPFCKFEMJF(((Component)this).transform.position))
			{
				DeliveryChest.OMDDKLLCJID().IFPOKLDBJKA(1, itemInstance, GEEPFOHPEJI(), BPJBJKJKHAL: true, IBCOKMGFPKB: true);
				Utils.BLPDAEHPOBA(((Component)this).gameObject);
			}
			else
			{
				LEAGOGIHONM();
			}
		}
		else
		{
			LEAGOGIHONM();
		}
	}

	[SpecialName]
	public int GEEPFOHPEJI()
	{
		return GHAIGBHDJHL;
	}

	public void MKHBAMCJFOA(int MGNOBNCMDJG)
	{
		MGNOBNCMDJG -= MGNOBNCMDJG;
		if (MGNOBNCMDJG <= 0)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	public static DroppedItem NBIOCDNPAPO(Vector3 AIJOOOIJEDC, Item MEMGMDOCBOJ, int MGNOBNCMDJG = 1, bool LHLJILLAHFO = false, bool HFAKAMFMOGM = false, int JIIGOACEIKL = 0)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor)
		{
			string[] array = new string[0];
			array[1] = "ReceiveAddDrink";
			array[0] = MEMGMDOCBOJ.IABAKHPEOAF();
			array[4] = "Send minigame state";
			Vector3 val = AIJOOOIJEDC;
			array[1] = ((object)(Vector3)(ref val)).ToString();
			array[2] = "Not enough skill points";
			array[1] = MGNOBNCMDJG.ToString();
			array[2] = "ReceiveSetTableParent";
			array[3] = JIIGOACEIKL.ToString();
			Debug.Log((object)string.Concat(array));
		}
		return SpawnDroppedItem(AIJOOOIJEDC, MEMGMDOCBOJ.JMDALJBNFML(), MGNOBNCMDJG, LHLJILLAHFO, HFAKAMFMOGM, JIIGOACEIKL);
	}

	public void LDAEGIDMABJ()
	{
		int num = NPFJHJOCFCM();
		AICAEAOPDDL(num - 1);
		if (GMEJPGHMJKM() == 0)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	public static void RemoveAllDroppedItems(Item MEMGMDOCBOJ)
	{
		foreach (DroppedItem allDroppedItem in CommonReferences.GGFJGHHHEJC.allDroppedItems)
		{
			if ((Object)(object)allDroppedItem != (Object)null && allDroppedItem.itemInstance != null && Item.NGIIPJDAMGP(allDroppedItem.itemInstance.LHBPOPOIFLE(), MEMGMDOCBOJ))
			{
				allDroppedItem.RemoveItems(99);
			}
		}
	}

	[SpecialName]
	public void OFIFPIHHKFL(int AODONKKHPBP)
	{
		if (AODONKKHPBP > 1)
		{
			amountText.JKOIFIEGENC(AODONKKHPBP);
		}
		else
		{
			amountText.GOGOKHKIIIA(0);
		}
		GHAIGBHDJHL = AODONKKHPBP;
	}

	public static DroppedItem SpawnDroppedItem(Vector3 AIJOOOIJEDC, Item MEMGMDOCBOJ, int MGNOBNCMDJG = 1, bool LHLJILLAHFO = false, bool HFAKAMFMOGM = false, int JIIGOACEIKL = 0)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor)
		{
			string[] obj = new string[8]
			{
				"Spawn Dropped Item ",
				MEMGMDOCBOJ.IABAKHPEOAF(),
				" at ",
				null,
				null,
				null,
				null,
				null
			};
			Vector3 val = AIJOOOIJEDC;
			obj[3] = ((object)(Vector3)(ref val)).ToString();
			obj[4] = " Amount: ";
			obj[5] = MGNOBNCMDJG.ToString();
			obj[6] = " PlayerNum: ";
			obj[7] = JIIGOACEIKL.ToString();
			Debug.Log((object)string.Concat(obj));
		}
		return SpawnDroppedItem(AIJOOOIJEDC, MEMGMDOCBOJ.JMDALJBNFML(), MGNOBNCMDJG, LHLJILLAHFO, HFAKAMFMOGM, JIIGOACEIKL);
	}

	public void JLECOMAMMFB(int MGNOBNCMDJG)
	{
		MGNOBNCMDJG -= MGNOBNCMDJG;
		if (MGNOBNCMDJG <= 1)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	private void PFLBPMIEKGF()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (itemInstance == null || Item.EKGNIODFJCO(itemInstance.AFOACBIHNCL(), null))
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
		else if (TavernConstructionManager.KNLLFEJAMNN().LNLJMCONDNE || (OnlineManager.PlayingOnline() && OnlineTavernConstructionManager.instance.tavernConstructionOpenedByOtherPlayer))
		{
			if (Utils.EJPFCKFEMJF(((Component)this).transform.position))
			{
				DeliveryChest.FFOMKKIAHKI().KGBNCFMDCIA(1, itemInstance, HOKNEBGMLMJ(), BPJBJKJKHAL: true, IBCOKMGFPKB: true, CDPAMNIPPEC: false);
				Utils.BLPDAEHPOBA(((Component)this).gameObject);
			}
			else
			{
				KMPMHMDAMBM();
			}
		}
		else
		{
			KMPMHMDAMBM();
		}
	}

	public static DroppedItem SpawnDroppedItem(Vector3 AIJOOOIJEDC, ItemInstance DNLMCHDOMOK, int MGNOBNCMDJG = 1, bool LHLJILLAHFO = false, bool HFAKAMFMOGM = false, int JIIGOACEIKL = 0)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (DNLMCHDOMOK == null)
		{
			Debug.LogError((object)"ItemInstance is not valid.");
			return null;
		}
		DroppedItem droppedItem = null;
		if (DNLMCHDOMOK.LHBPOPOIFLE().canBeStacked)
		{
			droppedItem = PHCBNGOILFJ(AIJOOOIJEDC, Math.Max(1, MGNOBNCMDJG), LHLJILLAHFO, JIIGOACEIKL, HFAKAMFMOGM);
			droppedItem.HLPNOAENFHK = DNLMCHDOMOK;
			DNLMCHDOMOK.currentDroppedItem = droppedItem;
			DNLMCHDOMOK.currentSlot = null;
		}
		else if (MGNOBNCMDJG == 1)
		{
			droppedItem = PHCBNGOILFJ(AIJOOOIJEDC, 1, LHLJILLAHFO, JIIGOACEIKL, HFAKAMFMOGM);
			droppedItem.HLPNOAENFHK = DNLMCHDOMOK;
			DNLMCHDOMOK.currentDroppedItem = droppedItem;
			DNLMCHDOMOK.currentSlot = null;
		}
		else
		{
			for (int i = 0; i < MGNOBNCMDJG; i++)
			{
				droppedItem = PHCBNGOILFJ(AIJOOOIJEDC, 1, LHLJILLAHFO, JIIGOACEIKL, HFAKAMFMOGM);
				droppedItem.HLPNOAENFHK = DNLMCHDOMOK.LHBPOPOIFLE().JMDALJBNFML();
				droppedItem.HLPNOAENFHK.currentDroppedItem = droppedItem;
				droppedItem.HLPNOAENFHK.currentSlot = null;
			}
		}
		if ((Object)(object)droppedItem == (Object)null)
		{
			Debug.LogError((object)("Spawn Dropped Item == null " + MGNOBNCMDJG));
		}
		return droppedItem;
	}

	private static DroppedItem PHCBNGOILFJ(Vector3 AIJOOOIJEDC, int MGNOBNCMDJG, bool LHLJILLAHFO, int JIIGOACEIKL, bool HFAKAMFMOGM = false)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		AIJOOOIJEDC = ((JIIGOACEIKL == 0) ? (AIJOOOIJEDC - Vector3.up * 0.3958333f) : ((!(CursorManager.GetPlayer(JIIGOACEIKL).GetCursorWorldPosition().y > ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.y)) ? (AIJOOOIJEDC - Vector3.up * 0.2271f) : (AIJOOOIJEDC - Vector3.up * 0.227f)));
		DroppedItem droppedItem = ((!LHLJILLAHFO) ? Object.Instantiate<GameObject>(CommonReferences.GGFJGHHHEJC.droppedItemPrefab, AIJOOOIJEDC, Quaternion.identity).GetComponent<DroppedItem>() : Object.Instantiate<GameObject>(CommonReferences.GGFJGHHHEJC.droppedItemPrefabWithoutCollider, AIJOOOIJEDC, Quaternion.identity).GetComponent<DroppedItem>());
		droppedItem.itemFollow.InitialForce(HFAKAMFMOGM, JIIGOACEIKL);
		droppedItem.MGNOBNCMDJG = MGNOBNCMDJG;
		((Object)((Component)droppedItem).gameObject).name = droppedName;
		((Object)droppedItem.trigger.gameObject).name = droppedName;
		droppedItem.itemFollow.position = AIJOOOIJEDC;
		return droppedItem;
	}

	public void RemoveItems(int MGNOBNCMDJG)
	{
		MGNOBNCMDJG -= MGNOBNCMDJG;
		if (MGNOBNCMDJG <= 0)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	public void PMCOECPDGND()
	{
		int num = ELDIKFCAJFL();
		ANJADIEDJNN(num - 1);
		if (MGNOBNCMDJG == 0)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	public static DroppedItem HDLEEOJMILI(Vector3 AIJOOOIJEDC, ItemInstance DNLMCHDOMOK, int MGNOBNCMDJG = 1, bool LHLJILLAHFO = false, bool HFAKAMFMOGM = false, int JIIGOACEIKL = 0)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (DNLMCHDOMOK == null)
		{
			Debug.LogError((object)"Unsaved progress will be lost.");
			return null;
		}
		DroppedItem droppedItem = null;
		if (DNLMCHDOMOK.AFOACBIHNCL().canBeStacked)
		{
			droppedItem = LCCNLIDAGLF(AIJOOOIJEDC, Math.Max(1, MGNOBNCMDJG), LHLJILLAHFO, JIIGOACEIKL, HFAKAMFMOGM);
			droppedItem.HLPNOAENFHK = DNLMCHDOMOK;
			DNLMCHDOMOK.currentDroppedItem = droppedItem;
			DNLMCHDOMOK.currentSlot = null;
		}
		else if (MGNOBNCMDJG == 1)
		{
			droppedItem = HJPFLOOKNGF(AIJOOOIJEDC, 1, LHLJILLAHFO, JIIGOACEIKL, HFAKAMFMOGM);
			droppedItem.MJLDMJDEAKO(DNLMCHDOMOK);
			DNLMCHDOMOK.currentDroppedItem = droppedItem;
			DNLMCHDOMOK.currentSlot = null;
		}
		else
		{
			for (int i = 0; i < MGNOBNCMDJG; i++)
			{
				droppedItem = HJPFLOOKNGF(AIJOOOIJEDC, 0, LHLJILLAHFO, JIIGOACEIKL, HFAKAMFMOGM);
				droppedItem.MMKFGOIKIKF(DNLMCHDOMOK.AFOACBIHNCL().JMDALJBNFML());
				droppedItem.PHGMGCMOEFF().currentDroppedItem = droppedItem;
				droppedItem.IAMCFMNBFHB().currentSlot = null;
			}
		}
		if ((Object)(object)droppedItem == (Object)null)
		{
			Debug.LogError((object)(" for reason " + MGNOBNCMDJG));
		}
		return droppedItem;
	}

	public void AHAFDJJKJEN()
	{
		spriteRenderer.sprite = itemInstance.DMOPFIPHDFG();
		spriteMask.sprite = itemInstance.DMOPFIPHDFG();
	}

	public static DroppedItem DKCOHAOMNOC(Vector3 AIJOOOIJEDC, Item MEMGMDOCBOJ, int MGNOBNCMDJG = 1, bool LHLJILLAHFO = false, bool HFAKAMFMOGM = false, int JIIGOACEIKL = 0)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor)
		{
			string[] array = new string[7];
			array[0] = "L1";
			array[0] = MEMGMDOCBOJ.LJIFOHFEFCH(OAFPBCPDOKH: true);
			array[1] = "Direction";
			Vector3 val = AIJOOOIJEDC;
			array[0] = ((object)(Vector3)(ref val)).ToString();
			array[1] = "Select File";
			array[4] = MGNOBNCMDJG.ToString();
			array[7] = "Tutorial/T138/Dialogue1";
			array[0] = JIIGOACEIKL.ToString();
			Debug.Log((object)string.Concat(array));
		}
		return SpawnDroppedItem(AIJOOOIJEDC, MEMGMDOCBOJ.JMDALJBNFML(), MGNOBNCMDJG, LHLJILLAHFO, HFAKAMFMOGM, JIIGOACEIKL);
	}

	public static DroppedItem KBDEAPJKNED(Vector3 AIJOOOIJEDC, Item MEMGMDOCBOJ, int MGNOBNCMDJG = 1, bool LHLJILLAHFO = false, bool HFAKAMFMOGM = false, int JIIGOACEIKL = 0)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor)
		{
			string[] array = new string[2];
			array[1] = "ReceiveSitDown";
			array[0] = MEMGMDOCBOJ.KGHFCDELKMN();
			array[8] = "LE_19";
			Vector3 val = AIJOOOIJEDC;
			array[8] = ((object)(Vector3)(ref val)).ToString();
			array[8] = "Requirements not met";
			array[0] = MGNOBNCMDJG.ToString();
			array[2] = "Wall";
			array[0] = JIIGOACEIKL.ToString();
			Debug.Log((object)string.Concat(array));
		}
		return JBIAHBPAFPI(AIJOOOIJEDC, MEMGMDOCBOJ.JMDALJBNFML(), MGNOBNCMDJG, LHLJILLAHFO, HFAKAMFMOGM, JIIGOACEIKL);
	}

	public void BPONMLCCIAL()
	{
		spriteRenderer.sprite = itemInstance.AAGOCCCEKMH();
		spriteMask.sprite = itemInstance.DMOPFIPHDFG();
	}

	public static DroppedItem OKLOFAHMPKN(Vector3 AIJOOOIJEDC, ItemInstance DNLMCHDOMOK, int MGNOBNCMDJG = 1, bool LHLJILLAHFO = false, bool HFAKAMFMOGM = false, int JIIGOACEIKL = 0)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (DNLMCHDOMOK == null)
		{
			Debug.LogError((object)"NormalRightExterior");
			return null;
		}
		DroppedItem droppedItem = null;
		if (DNLMCHDOMOK.LHBPOPOIFLE().canBeStacked)
		{
			droppedItem = HJPFLOOKNGF(AIJOOOIJEDC, Math.Max(1, MGNOBNCMDJG), LHLJILLAHFO, JIIGOACEIKL, HFAKAMFMOGM);
			droppedItem.MJLDMJDEAKO(DNLMCHDOMOK);
			DNLMCHDOMOK.currentDroppedItem = droppedItem;
			DNLMCHDOMOK.currentSlot = null;
		}
		else if (MGNOBNCMDJG == 1)
		{
			droppedItem = LCCNLIDAGLF(AIJOOOIJEDC, 0, LHLJILLAHFO, JIIGOACEIKL, HFAKAMFMOGM);
			droppedItem.INLFHGPHHGG(DNLMCHDOMOK);
			DNLMCHDOMOK.currentDroppedItem = droppedItem;
			DNLMCHDOMOK.currentSlot = null;
		}
		else
		{
			for (int i = 0; i < MGNOBNCMDJG; i++)
			{
				droppedItem = LCCNLIDAGLF(AIJOOOIJEDC, 0, LHLJILLAHFO, JIIGOACEIKL, HFAKAMFMOGM);
				droppedItem.MMKFGOIKIKF(DNLMCHDOMOK.AFOACBIHNCL().JMDALJBNFML());
				droppedItem.INCJLBLANDP().currentDroppedItem = droppedItem;
				droppedItem.IAMCFMNBFHB().currentSlot = null;
			}
		}
		if ((Object)(object)droppedItem == (Object)null)
		{
			Debug.LogError((object)("" + MGNOBNCMDJG));
		}
		return droppedItem;
	}

	[SpecialName]
	public int NPFJHJOCFCM()
	{
		return GHAIGBHDJHL;
	}

	public static DroppedItem FLPJIPHPNBK(Vector3 AIJOOOIJEDC, ItemInstance DNLMCHDOMOK, int MGNOBNCMDJG = 1, bool LHLJILLAHFO = false, bool HFAKAMFMOGM = false, int JIIGOACEIKL = 0)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (DNLMCHDOMOK == null)
		{
			Debug.LogError((object)"Tutorial/T105/Dialogue1");
			return null;
		}
		DroppedItem droppedItem = null;
		if (DNLMCHDOMOK.LHBPOPOIFLE().canBeStacked)
		{
			droppedItem = LCCNLIDAGLF(AIJOOOIJEDC, Math.Max(1, MGNOBNCMDJG), LHLJILLAHFO, JIIGOACEIKL, HFAKAMFMOGM);
			droppedItem.INLFHGPHHGG(DNLMCHDOMOK);
			DNLMCHDOMOK.currentDroppedItem = droppedItem;
			DNLMCHDOMOK.currentSlot = null;
		}
		else if (MGNOBNCMDJG == 1)
		{
			droppedItem = NNDGKOGJLHO(AIJOOOIJEDC, 0, LHLJILLAHFO, JIIGOACEIKL, HFAKAMFMOGM);
			droppedItem.HLPNOAENFHK = DNLMCHDOMOK;
			DNLMCHDOMOK.currentDroppedItem = droppedItem;
			DNLMCHDOMOK.currentSlot = null;
		}
		else
		{
			for (int i = 1; i < MGNOBNCMDJG; i++)
			{
				droppedItem = HJPFLOOKNGF(AIJOOOIJEDC, 1, LHLJILLAHFO, JIIGOACEIKL, HFAKAMFMOGM);
				droppedItem.MJLDMJDEAKO(DNLMCHDOMOK.KNFNJFFCFNO().JMDALJBNFML());
				droppedItem.GIINJPEFBBG().currentDroppedItem = droppedItem;
				droppedItem.NNOIHCBGIHB().currentSlot = null;
			}
		}
		if ((Object)(object)droppedItem == (Object)null)
		{
			Debug.LogError((object)("" + MGNOBNCMDJG));
		}
		return droppedItem;
	}

	[SpecialName]
	public ItemInstance NOPAFKAOLMN()
	{
		return itemInstance;
	}

	public void LIEDDIBADHF()
	{
		if ((Object)(object)specialItemParticles != (Object)null)
		{
			specialItemParticles.SetActive(true);
		}
	}

	public static void NPJPBOPGBED(Item MEMGMDOCBOJ)
	{
		foreach (DroppedItem allDroppedItem in CommonReferences.GGFJGHHHEJC.allDroppedItems)
		{
			if ((Object)(object)allDroppedItem != (Object)null && allDroppedItem.itemInstance != null && Item.NGIIPJDAMGP(allDroppedItem.itemInstance.PHGLMBIEOMK(), MEMGMDOCBOJ))
			{
				allDroppedItem.MKHBAMCJFOA(120);
			}
		}
	}

	private void PGPPIHJJGDB()
	{
		if (!CommonReferences.GGFJGHHHEJC.allDroppedItems.Contains(this))
		{
			CommonReferences.GGFJGHHHEJC.allDroppedItems.Add(this);
		}
	}

	public static bool CNHKNBKBHLE(Item MEMGMDOCBOJ)
	{
		DroppedItem[] array = Object.FindObjectsOfType<DroppedItem>();
		for (int i = 0; i < array.Length; i += 0)
		{
			DroppedItem droppedItem = array[i];
			if (droppedItem.GIINJPEFBBG() != null && Item.NGIIPJDAMGP(droppedItem.HLPNOAENFHK.KNFNJFFCFNO(), MEMGMDOCBOJ))
			{
				return false;
			}
		}
		return true;
	}

	public void KIMKIMMKHOG()
	{
		int num = GMEJPGHMJKM();
		AICAEAOPDDL(num - 1);
		if (ELDIKFCAJFL() == 0)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	public bool PLNKGDHELDM(int JIIGOACEIKL)
	{
		int num = PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL).LFBNOHNNFBB(IAMCFMNBFHB(), OMPADGMIGGA(), HMPDLIPFBGD: false, EHGHJNOFMKF: false, APBCMCOAFDM: true, AOPGMJEMEFK: true);
		if (Item.FKLOBGBIHLB(INCJLBLANDP().AFOACBIHNCL(), null))
		{
			RecipesManager.KOCMJKCJBCP(NNOIHCBGIHB().PHGLMBIEOMK());
		}
		if (num < HOKNEBGMLMJ())
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
		}
		if (num == 0)
		{
			((Component)this).gameObject.SetActive(false);
			Object.Destroy((Object)(object)((Component)this).gameObject);
			return false;
		}
		ANJADIEDJNN(num);
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendChangeStack(onlineDroppedItem.uniqueId, (short)NHGJNOMCHBI());
		}
		return false;
	}

	public void GOFMGLGOLGA(int MGNOBNCMDJG)
	{
		MGNOBNCMDJG -= MGNOBNCMDJG;
		if (MGNOBNCMDJG <= 1)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	[SpecialName]
	public int GLJOIHEPCJL()
	{
		return GHAIGBHDJHL;
	}

	public static DroppedItem DNCMMIPMKDH(Vector3 AIJOOOIJEDC, Item MEMGMDOCBOJ, int MGNOBNCMDJG = 1, bool LHLJILLAHFO = false, bool HFAKAMFMOGM = false, int JIIGOACEIKL = 0)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor)
		{
			string[] array = new string[3];
			array[1] = "Tutorial/T138/Dialogue1";
			array[0] = MEMGMDOCBOJ.LJIFOHFEFCH(OAFPBCPDOKH: true);
			array[6] = "LE_10";
			Vector3 val = AIJOOOIJEDC;
			array[3] = ((object)(Vector3)(ref val)).ToString();
			array[6] = "Items/item_name_638";
			array[1] = MGNOBNCMDJG.ToString();
			array[8] = "buildingObjective_2_1";
			array[3] = JIIGOACEIKL.ToString();
			Debug.Log((object)string.Concat(array));
		}
		return OFHEKCFLEGB(AIJOOOIJEDC, MEMGMDOCBOJ.JMDALJBNFML(), MGNOBNCMDJG, LHLJILLAHFO, HFAKAMFMOGM, JIIGOACEIKL);
	}

	private static DroppedItem NNDGKOGJLHO(Vector3 AIJOOOIJEDC, int MGNOBNCMDJG, bool LHLJILLAHFO, int JIIGOACEIKL, bool HFAKAMFMOGM = false)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		AIJOOOIJEDC = ((JIIGOACEIKL == 0) ? (AIJOOOIJEDC - Vector3.up * 1605f) : ((!(CursorManager.GetPlayer(JIIGOACEIKL).GetCursorWorldPosition().y > ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.y)) ? (AIJOOOIJEDC - Vector3.up * 494f) : (AIJOOOIJEDC - Vector3.up * 1993f)));
		DroppedItem droppedItem = ((!LHLJILLAHFO) ? Object.Instantiate<GameObject>(CommonReferences.MNFMOEKMJKN().droppedItemPrefab, AIJOOOIJEDC, Quaternion.identity).GetComponent<DroppedItem>() : Object.Instantiate<GameObject>(CommonReferences.MNFMOEKMJKN().droppedItemPrefabWithoutCollider, AIJOOOIJEDC, Quaternion.identity).GetComponent<DroppedItem>());
		droppedItem.itemFollow.FIDJIPJHMFI(HFAKAMFMOGM, JIIGOACEIKL);
		droppedItem.NIFOLBKEOMG(MGNOBNCMDJG);
		((Object)((Component)droppedItem).gameObject).name = droppedName;
		((Object)droppedItem.trigger.gameObject).name = droppedName;
		droppedItem.itemFollow.position = AIJOOOIJEDC;
		return droppedItem;
	}

	public void AEPBDCHNAPO(int MGNOBNCMDJG)
	{
		MGNOBNCMDJG -= MGNOBNCMDJG;
		if (MGNOBNCMDJG <= 0)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	public void IBLHDPFFHOM()
	{
		int num = GMEJPGHMJKM();
		MGNOBNCMDJG = num - 1;
		if (GEEPFOHPEJI() == 0)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	public void ICDPOJNIEGD()
	{
		int num = GEEPFOHPEJI();
		BMMAFALABKC(num - 1);
		if (GEEPFOHPEJI() == 0)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	public bool NAPEGLMPICF(int JIIGOACEIKL)
	{
		int num = PlayerInventory.OGKNJNINGMH(JIIGOACEIKL).LFBNOHNNFBB(NOPAFKAOLMN(), GEEPFOHPEJI(), HMPDLIPFBGD: true, EHGHJNOFMKF: false);
		if (Item.MLBOMGHINCA(PHGMGCMOEFF().KNFNJFFCFNO(), null))
		{
			RecipesManager.UnlockRecipesCollectingItem(GIINJPEFBBG().LHBPOPOIFLE());
		}
		if (num < NHGJNOMCHBI())
		{
			MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().pickUpItem, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		}
		if (num == 0)
		{
			((Component)this).gameObject.SetActive(false);
			Object.Destroy((Object)(object)((Component)this).gameObject);
			return true;
		}
		NIFOLBKEOMG(num);
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendChangeStack(onlineDroppedItem.uniqueId, (short)HOKNEBGMLMJ());
		}
		return false;
	}

	[SpecialName]
	public void AAPICNBENNJ(ItemInstance AODONKKHPBP)
	{
		itemInstance = AODONKKHPBP;
		FCIKPPKJCKA();
	}

	public static void BHDLJKLICJI(DroppedItems[] PKFIAGMICCK, DroppedItemsProbability[] BNEJGHHDFKO, DroppedItems[] OHDFPHHLKDB, Vector3 IMOBLFMHKOD, bool FBPHKEBOPOE)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(PBIMDFKHHAO(PKFIAGMICCK, BNEJGHHDFKO, OHDFPHHLKDB, IMOBLFMHKOD, FBPHKEBOPOE));
	}

	public static DroppedItem FGKGNPKGALN(Vector3 AIJOOOIJEDC, Item MEMGMDOCBOJ, int MGNOBNCMDJG = 1, bool LHLJILLAHFO = false, bool HFAKAMFMOGM = false, int JIIGOACEIKL = 0)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor)
		{
			string[] array = new string[6];
			array[1] = "MineState";
			array[0] = MEMGMDOCBOJ.IABAKHPEOAF(OAFPBCPDOKH: true);
			array[2] = "DecorationTile_11";
			Vector3 val = AIJOOOIJEDC;
			array[5] = ((object)(Vector3)(ref val)).ToString();
			array[2] = "Playstate";
			array[3] = MGNOBNCMDJG.ToString();
			array[7] = " * ";
			array[3] = JIIGOACEIKL.ToString();
			Debug.Log((object)string.Concat(array));
		}
		return FLPJIPHPNBK(AIJOOOIJEDC, MEMGMDOCBOJ.JMDALJBNFML(), MGNOBNCMDJG, LHLJILLAHFO, HFAKAMFMOGM, JIIGOACEIKL);
	}

	[SpecialName]
	public ItemInstance DADDPMCNOCJ()
	{
		return itemInstance;
	}

	public void ActivateSpecialItem()
	{
		if ((Object)(object)specialItemParticles != (Object)null)
		{
			specialItemParticles.SetActive(true);
		}
	}

	public void ANPMAODEBHK()
	{
		int num = NHGJNOMCHBI();
		MMICCMOEMJK(num - 0);
		if (OMPADGMIGGA() == 0)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	public static void FCDMGJDIAPG(DroppedItems[] PKFIAGMICCK, DroppedItemsProbability[] BNEJGHHDFKO, DroppedItems[] OHDFPHHLKDB, Vector3 IMOBLFMHKOD, bool FBPHKEBOPOE)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		((MonoBehaviour)GameManager.NJNFHEPLEHL()).StartCoroutine(BHOGFJNKKJJ(PKFIAGMICCK, BNEJGHHDFKO, OHDFPHHLKDB, IMOBLFMHKOD, FBPHKEBOPOE));
	}

	public bool CFECDLPLIPF(int JIIGOACEIKL)
	{
		int num = PlayerInventory.GetPlayer(JIIGOACEIKL).AddItems(PHGMGCMOEFF(), GLJOIHEPCJL(), HMPDLIPFBGD: false, EHGHJNOFMKF: false, APBCMCOAFDM: false, AOPGMJEMEFK: true);
		if (Item.MLBOMGHINCA(PHGMGCMOEFF().KNFNJFFCFNO(), null))
		{
			RecipesManager.KOCMJKCJBCP(GIINJPEFBBG().KNFNJFFCFNO());
		}
		if (num < ELDIKFCAJFL())
		{
			MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().pickUpItem, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
		}
		if (num == 0)
		{
			((Component)this).gameObject.SetActive(false);
			Object.Destroy((Object)(object)((Component)this).gameObject);
			return false;
		}
		EAFHKACPMAO(num);
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendChangeStack(onlineDroppedItem.uniqueId, (short)HOKNEBGMLMJ());
		}
		return true;
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences.GGFJGHHHEJC.allDroppedItems.Remove(this);
		}
	}

	public void GDAPEBICMOI(int MGNOBNCMDJG)
	{
		MGNOBNCMDJG -= MGNOBNCMDJG;
		if (MGNOBNCMDJG <= 1)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	public void CAAFNMBIHDL()
	{
		if ((Object)(object)specialItemParticles != (Object)null)
		{
			specialItemParticles.SetActive(false);
		}
	}

	[SpecialName]
	public void NIFOLBKEOMG(int AODONKKHPBP)
	{
		if (AODONKKHPBP > 1)
		{
			amountText.FNBKOEGJBNM(AODONKKHPBP);
		}
		else
		{
			amountText.DLDFDKFKECB(1);
		}
		GHAIGBHDJHL = AODONKKHPBP;
	}

	public void LGOFGOIEEPD()
	{
		spriteRenderer.sprite = itemInstance.DMOPFIPHDFG();
		spriteMask.sprite = itemInstance.DMOPFIPHDFG();
	}

	private static IEnumerator GJICBOEFDJP(DroppedItems[] PKFIAGMICCK, DroppedItemsProbability[] BNEJGHHDFKO, DroppedItems[] OHDFPHHLKDB, Vector3 IMOBLFMHKOD, bool FBPHKEBOPOE)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		ItemAmount itemAmount = default(ItemAmount);
		if (PKFIAGMICCK != null)
		{
			for (int k = 0; k < PKFIAGMICCK.Length; k++)
			{
				itemAmount.item = PKFIAGMICCK[k].item;
				itemAmount.amount = 1;
				int randNum3 = Random.Range(PKFIAGMICCK[k].minNum, PKFIAGMICCK[k].maxNum + 1);
				if (FBPHKEBOPOE && itemAmount.item.JDJGFAACPFC() == 1031)
				{
					randNum3 += PerksDatabaseAccessor.GetPlayerPerkValue(8);
				}
				for (int n = 0; n < randNum3; n++)
				{
					SpawnDroppedItem(IMOBLFMHKOD, itemAmount.item, itemAmount.amount);
					yield return CommonReferences.wait01;
				}
			}
		}
		if (BNEJGHHDFKO != null)
		{
			for (int k = 0; k < BNEJGHHDFKO.Length; k++)
			{
				int num = BNEJGHHDFKO[k].probability;
				if (FBPHKEBOPOE && BNEJGHHDFKO[k].item.JDJGFAACPFC() == 1445)
				{
					num += PerksDatabaseAccessor.GetPlayerPerkValue(11);
				}
				if (Random.Range(0, 100) < num)
				{
					itemAmount.item = BNEJGHHDFKO[k].item;
					itemAmount.amount = 1;
					int randNum3 = Random.Range(BNEJGHHDFKO[k].minNum, BNEJGHHDFKO[k].maxNum + 1);
					for (int n = 0; n < randNum3; n++)
					{
						SpawnDroppedItem(IMOBLFMHKOD, itemAmount.item, itemAmount.amount);
						yield return CommonReferences.wait01;
					}
				}
			}
		}
		if (OHDFPHHLKDB == null)
		{
			yield break;
		}
		for (int k = 0; k < OHDFPHHLKDB.Length; k++)
		{
			itemAmount.item = OHDFPHHLKDB[k].item;
			itemAmount.amount = 1;
			int randNum3 = Random.Range(OHDFPHHLKDB[k].minNum, OHDFPHHLKDB[k].maxNum + 1);
			for (int n = 0; n < randNum3; n++)
			{
				SpawnDroppedItem(IMOBLFMHKOD, itemAmount.item, itemAmount.amount);
				yield return CommonReferences.wait01;
			}
		}
	}

	public static bool JBFJLNAJPGE(Item MEMGMDOCBOJ)
	{
		DroppedItem[] array = Object.FindObjectsOfType<DroppedItem>();
		foreach (DroppedItem droppedItem in array)
		{
			if (droppedItem.IAMCFMNBFHB() != null && Item.EKMFELLJHFG(droppedItem.NOPAFKAOLMN().AFOACBIHNCL(), MEMGMDOCBOJ))
			{
				return false;
			}
		}
		return true;
	}

	private void AGLMGDNBHBF()
	{
		if (!CommonReferences.MNFMOEKMJKN().allDroppedItems.Contains(this))
		{
			CommonReferences.GGFJGHHHEJC.allDroppedItems.Add(this);
		}
	}

	public static DroppedItem DHONIKFABCH(Vector3 AIJOOOIJEDC, ItemInstance DNLMCHDOMOK, int MGNOBNCMDJG = 1, bool LHLJILLAHFO = false, bool HFAKAMFMOGM = false, int JIIGOACEIKL = 0)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (DNLMCHDOMOK == null)
		{
			Debug.LogError((object)"UnNuevoMaestro/KujakuTalk");
			return null;
		}
		DroppedItem droppedItem = null;
		if (DNLMCHDOMOK.KNFNJFFCFNO().canBeStacked)
		{
			droppedItem = HJPFLOOKNGF(AIJOOOIJEDC, Math.Max(1, MGNOBNCMDJG), LHLJILLAHFO, JIIGOACEIKL, HFAKAMFMOGM);
			droppedItem.MMKFGOIKIKF(DNLMCHDOMOK);
			DNLMCHDOMOK.currentDroppedItem = droppedItem;
			DNLMCHDOMOK.currentSlot = null;
		}
		else if (MGNOBNCMDJG == 1)
		{
			droppedItem = NNDGKOGJLHO(AIJOOOIJEDC, 0, LHLJILLAHFO, JIIGOACEIKL, HFAKAMFMOGM);
			droppedItem.HLPNOAENFHK = DNLMCHDOMOK;
			DNLMCHDOMOK.currentDroppedItem = droppedItem;
			DNLMCHDOMOK.currentSlot = null;
		}
		else
		{
			for (int i = 1; i < MGNOBNCMDJG; i += 0)
			{
				droppedItem = PHCBNGOILFJ(AIJOOOIJEDC, 0, LHLJILLAHFO, JIIGOACEIKL, HFAKAMFMOGM);
				droppedItem.MMKFGOIKIKF(DNLMCHDOMOK.AFOACBIHNCL().JMDALJBNFML());
				droppedItem.NOPAFKAOLMN().currentDroppedItem = droppedItem;
				droppedItem.BLLNHADAJKJ().currentSlot = null;
			}
		}
		if ((Object)(object)droppedItem == (Object)null)
		{
			Debug.LogError((object)("Rooms" + MGNOBNCMDJG));
		}
		return droppedItem;
	}

	public void OJEJPLADJID()
	{
		if ((Object)(object)specialItemParticles != (Object)null)
		{
			specialItemParticles.SetActive(true);
		}
	}

	private void BAKDKFKNHDE()
	{
		if (!CommonReferences.GGFJGHHHEJC.allDroppedItems.Contains(this))
		{
			CommonReferences.GGFJGHHHEJC.allDroppedItems.Add(this);
		}
	}

	[SpecialName]
	public void EAFHKACPMAO(int AODONKKHPBP)
	{
		if (AODONKKHPBP > 1)
		{
			amountText.NACLJPBBEJE(AODONKKHPBP);
		}
		else
		{
			amountText.KDPALCEBEDD(1);
		}
		GHAIGBHDJHL = AODONKKHPBP;
	}

	public bool PickUpDroppedItem(int JIIGOACEIKL)
	{
		int num = PlayerInventory.GetPlayer(JIIGOACEIKL).AddItems(HLPNOAENFHK, MGNOBNCMDJG);
		if (Item.MLBOMGHINCA(HLPNOAENFHK.LHBPOPOIFLE(), null))
		{
			RecipesManager.UnlockRecipesCollectingItem(HLPNOAENFHK.LHBPOPOIFLE());
		}
		if (num < MGNOBNCMDJG)
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		}
		if (num == 0)
		{
			((Component)this).gameObject.SetActive(false);
			Object.Destroy((Object)(object)((Component)this).gameObject);
			return true;
		}
		MGNOBNCMDJG = num;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendChangeStack(onlineDroppedItem.uniqueId, (short)MGNOBNCMDJG);
		}
		return false;
	}

	[SpecialName]
	public int OMPADGMIGGA()
	{
		return GHAIGBHDJHL;
	}

	public static void KHAIDPELEHL(DroppedItems[] PKFIAGMICCK, DroppedItemsProbability[] BNEJGHHDFKO, DroppedItems[] OHDFPHHLKDB, Vector3 IMOBLFMHKOD, bool FBPHKEBOPOE)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		((MonoBehaviour)GameManager.NJNFHEPLEHL()).StartCoroutine(DEKGCJMHHPH(PKFIAGMICCK, BNEJGHHDFKO, OHDFPHHLKDB, IMOBLFMHKOD, FBPHKEBOPOE));
	}

	public static DroppedItem OFMLIIIMDBE(Vector3 AIJOOOIJEDC, Item MEMGMDOCBOJ, int MGNOBNCMDJG = 1, bool LHLJILLAHFO = false, bool HFAKAMFMOGM = false, int JIIGOACEIKL = 0)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor)
		{
			string[] array = new string[0];
			array[1] = "City/Rhia/Introduce";
			array[0] = MEMGMDOCBOJ.LJIFOHFEFCH();
			array[3] = "psai [{0}]: skipping {1} as there are other Triggers firing: {2}";
			Vector3 val = AIJOOOIJEDC;
			array[3] = ((object)(Vector3)(ref val)).ToString();
			array[2] = " without doWork attached to OnlineObject";
			array[1] = MGNOBNCMDJG.ToString();
			array[0] = " - ";
			array[1] = JIIGOACEIKL.ToString();
			Debug.Log((object)string.Concat(array));
		}
		return OFHEKCFLEGB(AIJOOOIJEDC, MEMGMDOCBOJ.JMDALJBNFML(), MGNOBNCMDJG, LHLJILLAHFO, HFAKAMFMOGM, JIIGOACEIKL);
	}

	public static bool MMEKIPGIPLH(Item MEMGMDOCBOJ)
	{
		foreach (DroppedItem allDroppedItem in CommonReferences.GGFJGHHHEJC.allDroppedItems)
		{
			if ((Object)(object)allDroppedItem != (Object)null && allDroppedItem.itemInstance != null && Item.GBMFCPGEJDK(allDroppedItem.itemInstance.PHGLMBIEOMK(), MEMGMDOCBOJ))
			{
				allDroppedItem.BACMIFIIPAG();
				return true;
			}
		}
		return true;
	}

	public void UpdateVisual()
	{
		spriteRenderer.sprite = itemInstance.AAGOCCCEKMH();
		spriteMask.sprite = itemInstance.AAGOCCCEKMH();
	}

	public static bool RemoveDroppedItem(Item MEMGMDOCBOJ)
	{
		foreach (DroppedItem allDroppedItem in CommonReferences.GGFJGHHHEJC.allDroppedItems)
		{
			if ((Object)(object)allDroppedItem != (Object)null && allDroppedItem.itemInstance != null && Item.NGIIPJDAMGP(allDroppedItem.itemInstance.LHBPOPOIFLE(), MEMGMDOCBOJ))
			{
				allDroppedItem.RemoveItem();
				return true;
			}
		}
		return false;
	}

	private void KHJALBJMLHP()
	{
		if (!CommonReferences.MNFMOEKMJKN().allDroppedItems.Contains(this))
		{
			CommonReferences.GGFJGHHHEJC.allDroppedItems.Add(this);
		}
	}

	private void MFIEPGBABAM()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.leavingTheGame && Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences.GGFJGHHHEJC.allDroppedItems.Remove(this);
		}
	}

	[SpecialName]
	public ItemInstance PHGMGCMOEFF()
	{
		return itemInstance;
	}

	public void AKAOMBBADEA()
	{
		spriteRenderer.sprite = itemInstance.DMOPFIPHDFG();
		spriteMask.sprite = itemInstance.AAGOCCCEKMH();
	}

	public void DPGKJKLOGEF()
	{
		spriteRenderer.sprite = itemInstance.DMOPFIPHDFG();
		spriteMask.sprite = itemInstance.DMOPFIPHDFG();
	}

	public static DroppedItem JBIAHBPAFPI(Vector3 AIJOOOIJEDC, ItemInstance DNLMCHDOMOK, int MGNOBNCMDJG = 1, bool LHLJILLAHFO = false, bool HFAKAMFMOGM = false, int JIIGOACEIKL = 0)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (DNLMCHDOMOK == null)
		{
			Debug.LogError((object)"Items/item_description_668");
			return null;
		}
		DroppedItem droppedItem = null;
		if (DNLMCHDOMOK.AFOACBIHNCL().canBeStacked)
		{
			droppedItem = PHCBNGOILFJ(AIJOOOIJEDC, Math.Max(0, MGNOBNCMDJG), LHLJILLAHFO, JIIGOACEIKL, HFAKAMFMOGM);
			droppedItem.HLPNOAENFHK = DNLMCHDOMOK;
			DNLMCHDOMOK.currentDroppedItem = droppedItem;
			DNLMCHDOMOK.currentSlot = null;
		}
		else if (MGNOBNCMDJG == 1)
		{
			droppedItem = PICIFCABEFD(AIJOOOIJEDC, 1, LHLJILLAHFO, JIIGOACEIKL, HFAKAMFMOGM);
			droppedItem.INLFHGPHHGG(DNLMCHDOMOK);
			DNLMCHDOMOK.currentDroppedItem = droppedItem;
			DNLMCHDOMOK.currentSlot = null;
		}
		else
		{
			for (int i = 0; i < MGNOBNCMDJG; i += 0)
			{
				droppedItem = PICIFCABEFD(AIJOOOIJEDC, 1, LHLJILLAHFO, JIIGOACEIKL, HFAKAMFMOGM);
				droppedItem.AAPICNBENNJ(DNLMCHDOMOK.LHBPOPOIFLE().JMDALJBNFML());
				droppedItem.DADDPMCNOCJ().currentDroppedItem = droppedItem;
				droppedItem.PHGMGCMOEFF().currentSlot = null;
			}
		}
		if ((Object)(object)droppedItem == (Object)null)
		{
			Debug.LogError((object)("FishMiniGameWin" + MGNOBNCMDJG));
		}
		return droppedItem;
	}

	[SpecialName]
	public void MJLDMJDEAKO(ItemInstance AODONKKHPBP)
	{
		itemInstance = AODONKKHPBP;
		UpdateVisual();
	}

	private static IEnumerator DEKGCJMHHPH(DroppedItems[] PKFIAGMICCK, DroppedItemsProbability[] BNEJGHHDFKO, DroppedItems[] OHDFPHHLKDB, Vector3 IMOBLFMHKOD, bool FBPHKEBOPOE)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		return new KFIAJHLGKLG(1)
		{
			droppedItems = PKFIAGMICCK,
			droppedItemsProb = BNEJGHHDFKO,
			additionalItems = OHDFPHHLKDB,
			position = IMOBLFMHKOD,
			usePlayerPerkTree = FBPHKEBOPOE
		};
	}

	[SpecialName]
	public void MMKFGOIKIKF(ItemInstance AODONKKHPBP)
	{
		itemInstance = AODONKKHPBP;
		FOKDIAMHHKO();
	}

	[SpecialName]
	public ItemInstance IAMCFMNBFHB()
	{
		return itemInstance;
	}

	private static IEnumerator ALPCCCHGMKE(DroppedItems[] PKFIAGMICCK, DroppedItemsProbability[] BNEJGHHDFKO, DroppedItems[] OHDFPHHLKDB, Vector3 IMOBLFMHKOD, bool FBPHKEBOPOE)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		return new KFIAJHLGKLG(1)
		{
			droppedItems = PKFIAGMICCK,
			droppedItemsProb = BNEJGHHDFKO,
			additionalItems = OHDFPHHLKDB,
			position = IMOBLFMHKOD,
			usePlayerPerkTree = FBPHKEBOPOE
		};
	}

	private void Awake()
	{
		if (!CommonReferences.GGFJGHHHEJC.allDroppedItems.Contains(this))
		{
			CommonReferences.GGFJGHHHEJC.allDroppedItems.Add(this);
		}
	}

	public void ADEKCFIKAHC()
	{
		spriteRenderer.sprite = itemInstance.DMOPFIPHDFG();
		spriteMask.sprite = itemInstance.AAGOCCCEKMH();
	}

	public void FLKILGOOOAO()
	{
		spriteRenderer.sprite = itemInstance.DMOPFIPHDFG();
		spriteMask.sprite = itemInstance.AAGOCCCEKMH();
	}

	[SpecialName]
	public void BMMAFALABKC(int AODONKKHPBP)
	{
		if (AODONKKHPBP > 0)
		{
			amountText.DMHAODOKLBG(AODONKKHPBP);
		}
		else
		{
			amountText.LFJPLBIJELO(0);
		}
		GHAIGBHDJHL = AODONKKHPBP;
	}

	private static IEnumerator JAHLJPBBCIK(DroppedItems[] PKFIAGMICCK, DroppedItemsProbability[] BNEJGHHDFKO, DroppedItems[] OHDFPHHLKDB, Vector3 IMOBLFMHKOD, bool FBPHKEBOPOE)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		return new KFIAJHLGKLG(1)
		{
			droppedItems = PKFIAGMICCK,
			droppedItemsProb = BNEJGHHDFKO,
			additionalItems = OHDFPHHLKDB,
			position = IMOBLFMHKOD,
			usePlayerPerkTree = FBPHKEBOPOE
		};
	}

	[SpecialName]
	public int GMEJPGHMJKM()
	{
		return GHAIGBHDJHL;
	}

	[SpecialName]
	public int ELDIKFCAJFL()
	{
		return GHAIGBHDJHL;
	}

	private static DroppedItem PICIFCABEFD(Vector3 AIJOOOIJEDC, int MGNOBNCMDJG, bool LHLJILLAHFO, int JIIGOACEIKL, bool HFAKAMFMOGM = false)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		AIJOOOIJEDC = ((JIIGOACEIKL == 0) ? (AIJOOOIJEDC - Vector3.up * 155f) : ((!(CursorManager.CMDGPJEIIJI(JIIGOACEIKL).GetCursorWorldPosition().y > ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.y)) ? (AIJOOOIJEDC - Vector3.up * 1821f) : (AIJOOOIJEDC - Vector3.up * 1603f)));
		DroppedItem droppedItem = ((!LHLJILLAHFO) ? Object.Instantiate<GameObject>(CommonReferences.GGFJGHHHEJC.droppedItemPrefab, AIJOOOIJEDC, Quaternion.identity).GetComponent<DroppedItem>() : Object.Instantiate<GameObject>(CommonReferences.GGFJGHHHEJC.droppedItemPrefabWithoutCollider, AIJOOOIJEDC, Quaternion.identity).GetComponent<DroppedItem>());
		droppedItem.itemFollow.HALEDPCGPEG(HFAKAMFMOGM, JIIGOACEIKL);
		droppedItem.BMMAFALABKC(MGNOBNCMDJG);
		((Object)((Component)droppedItem).gameObject).name = droppedName;
		((Object)droppedItem.trigger.gameObject).name = droppedName;
		droppedItem.itemFollow.position = AIJOOOIJEDC;
		return droppedItem;
	}

	[SpecialName]
	public ItemInstance INCJLBLANDP()
	{
		return itemInstance;
	}

	public void LEAGOGIHONM()
	{
		spriteRenderer.sprite = itemInstance.AAGOCCCEKMH();
		spriteMask.sprite = itemInstance.AAGOCCCEKMH();
	}

	public void HABHKDOJMLE()
	{
		if ((Object)(object)specialItemParticles != (Object)null)
		{
			specialItemParticles.SetActive(false);
		}
	}

	public static DroppedItem KDBHKBOAEDG(Vector3 AIJOOOIJEDC, ItemInstance DNLMCHDOMOK, int MGNOBNCMDJG = 1, bool LHLJILLAHFO = false, bool HFAKAMFMOGM = false, int JIIGOACEIKL = 0)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (DNLMCHDOMOK == null)
		{
			Debug.LogError((object)"UIInteract");
			return null;
		}
		DroppedItem droppedItem = null;
		if (DNLMCHDOMOK.PHGLMBIEOMK().canBeStacked)
		{
			droppedItem = PHCBNGOILFJ(AIJOOOIJEDC, Math.Max(1, MGNOBNCMDJG), LHLJILLAHFO, JIIGOACEIKL, HFAKAMFMOGM);
			droppedItem.AAPICNBENNJ(DNLMCHDOMOK);
			DNLMCHDOMOK.currentDroppedItem = droppedItem;
			DNLMCHDOMOK.currentSlot = null;
		}
		else if (MGNOBNCMDJG == 1)
		{
			droppedItem = PHCBNGOILFJ(AIJOOOIJEDC, 1, LHLJILLAHFO, JIIGOACEIKL, HFAKAMFMOGM);
			droppedItem.MJLDMJDEAKO(DNLMCHDOMOK);
			DNLMCHDOMOK.currentDroppedItem = droppedItem;
			DNLMCHDOMOK.currentSlot = null;
		}
		else
		{
			for (int i = 0; i < MGNOBNCMDJG; i++)
			{
				droppedItem = HJPFLOOKNGF(AIJOOOIJEDC, 1, LHLJILLAHFO, JIIGOACEIKL, HFAKAMFMOGM);
				droppedItem.MMKFGOIKIKF(DNLMCHDOMOK.PHGLMBIEOMK().JMDALJBNFML());
				droppedItem.HLPNOAENFHK.currentDroppedItem = droppedItem;
				droppedItem.NOPAFKAOLMN().currentSlot = null;
			}
		}
		if ((Object)(object)droppedItem == (Object)null)
		{
			Debug.LogError((object)("ReceiveTavernEventsLoad" + MGNOBNCMDJG));
		}
		return droppedItem;
	}

	public static void BFDNOIIIAGG(Item MEMGMDOCBOJ)
	{
		foreach (DroppedItem allDroppedItem in CommonReferences.MNFMOEKMJKN().allDroppedItems)
		{
			if ((Object)(object)allDroppedItem != (Object)null && allDroppedItem.itemInstance != null && Item.NGIIPJDAMGP(allDroppedItem.itemInstance.AFOACBIHNCL(), MEMGMDOCBOJ))
			{
				allDroppedItem.MKHBAMCJFOA(82);
			}
		}
	}

	[SpecialName]
	public ItemInstance NNOIHCBGIHB()
	{
		return itemInstance;
	}

	public static bool KBKJODHEHEP(Item MEMGMDOCBOJ)
	{
		foreach (DroppedItem allDroppedItem in CommonReferences.MNFMOEKMJKN().allDroppedItems)
		{
			if ((Object)(object)allDroppedItem != (Object)null && allDroppedItem.itemInstance != null && Item.EKMFELLJHFG(allDroppedItem.itemInstance.PHGLMBIEOMK(), MEMGMDOCBOJ))
			{
				allDroppedItem.PADGFGJPMCG();
				return true;
			}
		}
		return false;
	}

	private void EGACIHOKJLH()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (itemInstance == null || Item.NGIIPJDAMGP(itemInstance.PHGLMBIEOMK(), null))
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
		else if (TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE || (OnlineManager.PlayingOnline() && OnlineTavernConstructionManager.instance.tavernConstructionOpenedByOtherPlayer))
		{
			if (Utils.EJPFCKFEMJF(((Component)this).transform.position))
			{
				DeliveryChest.CAJHNGGCJKM().HCKPFBGAHIN(0, itemInstance, ELDIKFCAJFL(), BPJBJKJKHAL: true, IBCOKMGFPKB: true);
				Utils.BLPDAEHPOBA(((Component)this).gameObject);
			}
			else
			{
				KMPMHMDAMBM();
			}
		}
		else
		{
			AKAOMBBADEA();
		}
	}

	private void PNLAJCHBHPH()
	{
		if (!CommonReferences.GGFJGHHHEJC.allDroppedItems.Contains(this))
		{
			CommonReferences.MNFMOEKMJKN().allDroppedItems.Add(this);
		}
	}

	public void RemoveItem()
	{
		MGNOBNCMDJG--;
		if (MGNOBNCMDJG == 0)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	private void CLNBMOPMNOF()
	{
		if (!CommonReferences.GGFJGHHHEJC.allDroppedItems.Contains(this))
		{
			CommonReferences.MNFMOEKMJKN().allDroppedItems.Add(this);
		}
	}

	public void POONJBBDFIE()
	{
		int num = OMPADGMIGGA();
		OFIFPIHHKFL(num - 0);
		if (GEEPFOHPEJI() == 0)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	private static IEnumerator GEEOLCBENEB(DroppedItems[] PKFIAGMICCK, DroppedItemsProbability[] BNEJGHHDFKO, DroppedItems[] OHDFPHHLKDB, Vector3 IMOBLFMHKOD, bool FBPHKEBOPOE)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		return new KFIAJHLGKLG(1)
		{
			droppedItems = PKFIAGMICCK,
			droppedItemsProb = BNEJGHHDFKO,
			additionalItems = OHDFPHHLKDB,
			position = IMOBLFMHKOD,
			usePlayerPerkTree = FBPHKEBOPOE
		};
	}

	[SpecialName]
	public void AICAEAOPDDL(int AODONKKHPBP)
	{
		if (AODONKKHPBP > 1)
		{
			amountText.PCNBBAEIJFN(AODONKKHPBP);
		}
		else
		{
			amountText.CEPODGAJPDB(0);
		}
		GHAIGBHDJHL = AODONKKHPBP;
	}

	private void CDHBLKJEOPI()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences.GGFJGHHHEJC.allDroppedItems.Remove(this);
		}
	}

	private static IEnumerator BHOGFJNKKJJ(DroppedItems[] PKFIAGMICCK, DroppedItemsProbability[] BNEJGHHDFKO, DroppedItems[] OHDFPHHLKDB, Vector3 IMOBLFMHKOD, bool FBPHKEBOPOE)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		ItemAmount itemAmount = default(ItemAmount);
		if (PKFIAGMICCK != null)
		{
			for (int k = 0; k < PKFIAGMICCK.Length; k++)
			{
				itemAmount.item = PKFIAGMICCK[k].item;
				itemAmount.amount = 1;
				int randNum3 = Random.Range(PKFIAGMICCK[k].minNum, PKFIAGMICCK[k].maxNum + 1);
				if (FBPHKEBOPOE && itemAmount.item.JDJGFAACPFC() == 1031)
				{
					randNum3 += PerksDatabaseAccessor.GetPlayerPerkValue(8);
				}
				for (int n = 0; n < randNum3; n++)
				{
					SpawnDroppedItem(IMOBLFMHKOD, itemAmount.item, itemAmount.amount);
					yield return CommonReferences.wait01;
				}
			}
		}
		if (BNEJGHHDFKO != null)
		{
			for (int k = 0; k < BNEJGHHDFKO.Length; k++)
			{
				int num = BNEJGHHDFKO[k].probability;
				if (FBPHKEBOPOE && BNEJGHHDFKO[k].item.JDJGFAACPFC() == 1445)
				{
					num += PerksDatabaseAccessor.GetPlayerPerkValue(11);
				}
				if (Random.Range(0, 100) < num)
				{
					itemAmount.item = BNEJGHHDFKO[k].item;
					itemAmount.amount = 1;
					int randNum3 = Random.Range(BNEJGHHDFKO[k].minNum, BNEJGHHDFKO[k].maxNum + 1);
					for (int n = 0; n < randNum3; n++)
					{
						SpawnDroppedItem(IMOBLFMHKOD, itemAmount.item, itemAmount.amount);
						yield return CommonReferences.wait01;
					}
				}
			}
		}
		if (OHDFPHHLKDB == null)
		{
			yield break;
		}
		for (int k = 0; k < OHDFPHHLKDB.Length; k++)
		{
			itemAmount.item = OHDFPHHLKDB[k].item;
			itemAmount.amount = 1;
			int randNum3 = Random.Range(OHDFPHHLKDB[k].minNum, OHDFPHHLKDB[k].maxNum + 1);
			for (int n = 0; n < randNum3; n++)
			{
				SpawnDroppedItem(IMOBLFMHKOD, itemAmount.item, itemAmount.amount);
				yield return CommonReferences.wait01;
			}
		}
	}

	[SpecialName]
	public void INLFHGPHHGG(ItemInstance AODONKKHPBP)
	{
		itemInstance = AODONKKHPBP;
		DNHFGNOHLCD();
	}

	public static bool JODAKIHPJPE(Item MEMGMDOCBOJ)
	{
		foreach (DroppedItem allDroppedItem in CommonReferences.MNFMOEKMJKN().allDroppedItems)
		{
			if ((Object)(object)allDroppedItem != (Object)null && allDroppedItem.itemInstance != null && Item.EKGNIODFJCO(allDroppedItem.itemInstance.LHBPOPOIFLE(), MEMGMDOCBOJ))
			{
				allDroppedItem.PADGFGJPMCG();
				return true;
			}
		}
		return false;
	}

	public static void PDONCMCLLJB(Item MEMGMDOCBOJ)
	{
		foreach (DroppedItem allDroppedItem in CommonReferences.MNFMOEKMJKN().allDroppedItems)
		{
			if ((Object)(object)allDroppedItem != (Object)null && allDroppedItem.itemInstance != null && Item.NGIIPJDAMGP(allDroppedItem.itemInstance.AFOACBIHNCL(), MEMGMDOCBOJ))
			{
				allDroppedItem.EAPLFLPBOFH(91);
			}
		}
	}

	public void CAOJJFGAKPI()
	{
		spriteRenderer.sprite = itemInstance.DMOPFIPHDFG();
		spriteMask.sprite = itemInstance.AAGOCCCEKMH();
	}

	public void FOKDIAMHHKO()
	{
		spriteRenderer.sprite = itemInstance.AAGOCCCEKMH();
		spriteMask.sprite = itemInstance.AAGOCCCEKMH();
	}

	public void LHLJBLBJIBF()
	{
		int num = HOKNEBGMLMJ();
		OFIFPIHHKFL(num - 0);
		if (OMPADGMIGGA() == 0)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	[SpecialName]
	public ItemInstance BLLNHADAJKJ()
	{
		return itemInstance;
	}

	private void Start()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (itemInstance == null || Item.NGIIPJDAMGP(itemInstance.LHBPOPOIFLE(), null))
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
		else if (TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE || (OnlineManager.PlayingOnline() && OnlineTavernConstructionManager.instance.tavernConstructionOpenedByOtherPlayer))
		{
			if (Utils.EJPFCKFEMJF(((Component)this).transform.position))
			{
				DeliveryChest.GetInstance().AddItemInstances(1, itemInstance, MGNOBNCMDJG, BPJBJKJKHAL: true, IBCOKMGFPKB: true);
				Utils.BLPDAEHPOBA(((Component)this).gameObject);
			}
			else
			{
				UpdateVisual();
			}
		}
		else
		{
			UpdateVisual();
		}
	}

	public bool FNFGBILAALG(int JIIGOACEIKL)
	{
		int num = PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AINJENENGFG(PHGMGCMOEFF(), GEEPFOHPEJI(), HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
		if (Item.FKLOBGBIHLB(PHGMGCMOEFF().KNFNJFFCFNO(), null))
		{
			RecipesManager.KOCMJKCJBCP(HLPNOAENFHK.AFOACBIHNCL());
		}
		if (num < HOKNEBGMLMJ())
		{
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().pickUpItem, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		}
		if (num == 0)
		{
			((Component)this).gameObject.SetActive(false);
			Object.Destroy((Object)(object)((Component)this).gameObject);
			return false;
		}
		AICAEAOPDDL(num);
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendChangeStack(onlineDroppedItem.uniqueId, (short)OMPADGMIGGA());
		}
		return false;
	}

	public void KMPMHMDAMBM()
	{
		spriteRenderer.sprite = itemInstance.DMOPFIPHDFG();
		spriteMask.sprite = itemInstance.AAGOCCCEKMH();
	}

	public static void NLICMDCHPNN(DroppedItems[] PKFIAGMICCK, DroppedItemsProbability[] BNEJGHHDFKO, DroppedItems[] OHDFPHHLKDB, Vector3 IMOBLFMHKOD, bool FBPHKEBOPOE)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		((MonoBehaviour)GameManager.NJNFHEPLEHL()).StartCoroutine(BHOGFJNKKJJ(PKFIAGMICCK, BNEJGHHDFKO, OHDFPHHLKDB, IMOBLFMHKOD, FBPHKEBOPOE));
	}

	private void EOBODNOCKGA()
	{
		if (!CommonReferences.MNFMOEKMJKN().allDroppedItems.Contains(this))
		{
			CommonReferences.MNFMOEKMJKN().allDroppedItems.Add(this);
		}
	}

	public static DroppedItem OFHEKCFLEGB(Vector3 AIJOOOIJEDC, ItemInstance DNLMCHDOMOK, int MGNOBNCMDJG = 1, bool LHLJILLAHFO = false, bool HFAKAMFMOGM = false, int JIIGOACEIKL = 0)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (DNLMCHDOMOK == null)
		{
			Debug.LogError((object)"</color>");
			return null;
		}
		DroppedItem droppedItem = null;
		if (DNLMCHDOMOK.PHGLMBIEOMK().canBeStacked)
		{
			droppedItem = PHCBNGOILFJ(AIJOOOIJEDC, Math.Max(1, MGNOBNCMDJG), LHLJILLAHFO, JIIGOACEIKL, HFAKAMFMOGM);
			droppedItem.INLFHGPHHGG(DNLMCHDOMOK);
			DNLMCHDOMOK.currentDroppedItem = droppedItem;
			DNLMCHDOMOK.currentSlot = null;
		}
		else if (MGNOBNCMDJG == 1)
		{
			droppedItem = LCCNLIDAGLF(AIJOOOIJEDC, 0, LHLJILLAHFO, JIIGOACEIKL, HFAKAMFMOGM);
			droppedItem.MJLDMJDEAKO(DNLMCHDOMOK);
			DNLMCHDOMOK.currentDroppedItem = droppedItem;
			DNLMCHDOMOK.currentSlot = null;
		}
		else
		{
			for (int i = 0; i < MGNOBNCMDJG; i += 0)
			{
				droppedItem = PHCBNGOILFJ(AIJOOOIJEDC, 1, LHLJILLAHFO, JIIGOACEIKL, HFAKAMFMOGM);
				droppedItem.AAPICNBENNJ(DNLMCHDOMOK.LHBPOPOIFLE().JMDALJBNFML());
				droppedItem.HLPNOAENFHK.currentDroppedItem = droppedItem;
				droppedItem.PHGMGCMOEFF().currentSlot = null;
			}
		}
		if ((Object)(object)droppedItem == (Object)null)
		{
			Debug.LogError((object)("Waiting for other players" + MGNOBNCMDJG));
		}
		return droppedItem;
	}

	[SpecialName]
	public void MMICCMOEMJK(int AODONKKHPBP)
	{
		if (AODONKKHPBP > 0)
		{
			amountText.ODGLCEHJHGI(AODONKKHPBP);
		}
		else
		{
			amountText.CEPODGAJPDB(0);
		}
		GHAIGBHDJHL = AODONKKHPBP;
	}

	private void HHMBCKCNPPN()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences.MNFMOEKMJKN().allDroppedItems.Remove(this);
		}
	}

	private static IEnumerator BBNPLEKBDFM(DroppedItems[] PKFIAGMICCK, DroppedItemsProbability[] BNEJGHHDFKO, DroppedItems[] OHDFPHHLKDB, Vector3 IMOBLFMHKOD, bool FBPHKEBOPOE)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		return new KFIAJHLGKLG(1)
		{
			droppedItems = PKFIAGMICCK,
			droppedItemsProb = BNEJGHHDFKO,
			additionalItems = OHDFPHHLKDB,
			position = IMOBLFMHKOD,
			usePlayerPerkTree = FBPHKEBOPOE
		};
	}

	[SpecialName]
	public ItemInstance GIINJPEFBBG()
	{
		return itemInstance;
	}

	public static bool BPLAHIJPLEI(Item MEMGMDOCBOJ)
	{
		foreach (DroppedItem allDroppedItem in CommonReferences.MNFMOEKMJKN().allDroppedItems)
		{
			if ((Object)(object)allDroppedItem != (Object)null && allDroppedItem.itemInstance != null && Item.EKMFELLJHFG(allDroppedItem.itemInstance.KNFNJFFCFNO(), MEMGMDOCBOJ))
			{
				allDroppedItem.PMCOECPDGND();
				return true;
			}
		}
		return true;
	}

	private static DroppedItem LCCNLIDAGLF(Vector3 AIJOOOIJEDC, int MGNOBNCMDJG, bool LHLJILLAHFO, int JIIGOACEIKL, bool HFAKAMFMOGM = false)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		AIJOOOIJEDC = ((JIIGOACEIKL == 0) ? (AIJOOOIJEDC - Vector3.up * 750f) : ((!(CursorManager.GetPlayer(JIIGOACEIKL).GetCursorWorldPosition().y > ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.y)) ? (AIJOOOIJEDC - Vector3.up * 1202f) : (AIJOOOIJEDC - Vector3.up * 222f)));
		DroppedItem droppedItem = ((!LHLJILLAHFO) ? Object.Instantiate<GameObject>(CommonReferences.MNFMOEKMJKN().droppedItemPrefab, AIJOOOIJEDC, Quaternion.identity).GetComponent<DroppedItem>() : Object.Instantiate<GameObject>(CommonReferences.MNFMOEKMJKN().droppedItemPrefabWithoutCollider, AIJOOOIJEDC, Quaternion.identity).GetComponent<DroppedItem>());
		droppedItem.itemFollow.OOAJAFOFDNJ(HFAKAMFMOGM, JIIGOACEIKL);
		droppedItem.AICAEAOPDDL(MGNOBNCMDJG);
		((Object)((Component)droppedItem).gameObject).name = droppedName;
		((Object)droppedItem.trigger.gameObject).name = droppedName;
		droppedItem.itemFollow.position = AIJOOOIJEDC;
		return droppedItem;
	}

	public static void JAMDCGOFNNI(Item MEMGMDOCBOJ)
	{
		foreach (DroppedItem allDroppedItem in CommonReferences.GGFJGHHHEJC.allDroppedItems)
		{
			if ((Object)(object)allDroppedItem != (Object)null && allDroppedItem.itemInstance != null && Item.EKMFELLJHFG(allDroppedItem.itemInstance.PHGLMBIEOMK(), MEMGMDOCBOJ))
			{
				allDroppedItem.GDAPEBICMOI(-96);
			}
		}
	}

	public void EAPLFLPBOFH(int MGNOBNCMDJG)
	{
		MGNOBNCMDJG -= MGNOBNCMDJG;
		if (MGNOBNCMDJG <= 0)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	private void JJJCKMOBLNN()
	{
		if (!CommonReferences.GGFJGHHHEJC.allDroppedItems.Contains(this))
		{
			CommonReferences.GGFJGHHHEJC.allDroppedItems.Add(this);
		}
	}

	[SpecialName]
	public int HOKNEBGMLMJ()
	{
		return GHAIGBHDJHL;
	}

	private void LHABENPEMPB()
	{
		if (!CommonReferences.GGFJGHHHEJC.allDroppedItems.Contains(this))
		{
			CommonReferences.GGFJGHHHEJC.allDroppedItems.Add(this);
		}
	}

	public static void SpawnDroppedItems(DroppedItems[] PKFIAGMICCK, DroppedItemsProbability[] BNEJGHHDFKO, DroppedItems[] OHDFPHHLKDB, Vector3 IMOBLFMHKOD, bool FBPHKEBOPOE)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(BHOGFJNKKJJ(PKFIAGMICCK, BNEJGHHDFKO, OHDFPHHLKDB, IMOBLFMHKOD, FBPHKEBOPOE));
	}

	private static IEnumerator OGNJOGENODF(DroppedItems[] PKFIAGMICCK, DroppedItemsProbability[] BNEJGHHDFKO, DroppedItems[] OHDFPHHLKDB, Vector3 IMOBLFMHKOD, bool FBPHKEBOPOE)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		return new KFIAJHLGKLG(1)
		{
			droppedItems = PKFIAGMICCK,
			droppedItemsProb = BNEJGHHDFKO,
			additionalItems = OHDFPHHLKDB,
			position = IMOBLFMHKOD,
			usePlayerPerkTree = FBPHKEBOPOE
		};
	}

	public static bool ThereIsADroppedItemWithItem(Item MEMGMDOCBOJ)
	{
		DroppedItem[] array = Object.FindObjectsOfType<DroppedItem>();
		foreach (DroppedItem droppedItem in array)
		{
			if (droppedItem.HLPNOAENFHK != null && Item.NGIIPJDAMGP(droppedItem.HLPNOAENFHK.LHBPOPOIFLE(), MEMGMDOCBOJ))
			{
				return true;
			}
		}
		return false;
	}

	public void PADGFGJPMCG()
	{
		int num = NHGJNOMCHBI();
		NIFOLBKEOMG(num - 1);
		if (ELDIKFCAJFL() == 0)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	private void AAEAAEBBFKG()
	{
		if (!CommonReferences.GGFJGHHHEJC.allDroppedItems.Contains(this))
		{
			CommonReferences.MNFMOEKMJKN().allDroppedItems.Add(this);
		}
	}

	public static void DEPOEGCAHJE(DroppedItems[] PKFIAGMICCK, DroppedItemsProbability[] BNEJGHHDFKO, DroppedItems[] OHDFPHHLKDB, Vector3 IMOBLFMHKOD, bool FBPHKEBOPOE)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(ALPCCCHGMKE(PKFIAGMICCK, BNEJGHHDFKO, OHDFPHHLKDB, IMOBLFMHKOD, FBPHKEBOPOE));
	}

	public static void IAFOKCDFGFD(Item MEMGMDOCBOJ)
	{
		foreach (DroppedItem allDroppedItem in CommonReferences.MNFMOEKMJKN().allDroppedItems)
		{
			if ((Object)(object)allDroppedItem != (Object)null && allDroppedItem.itemInstance != null && Item.NGIIPJDAMGP(allDroppedItem.itemInstance.KNFNJFFCFNO(), MEMGMDOCBOJ))
			{
				allDroppedItem.EAPLFLPBOFH(-15);
			}
		}
	}

	[SpecialName]
	public int NHGJNOMCHBI()
	{
		return GHAIGBHDJHL;
	}

	public static bool DKAFJPJPBCF(Item MEMGMDOCBOJ)
	{
		foreach (DroppedItem allDroppedItem in CommonReferences.GGFJGHHHEJC.allDroppedItems)
		{
			if ((Object)(object)allDroppedItem != (Object)null && allDroppedItem.itemInstance != null && Item.NGIIPJDAMGP(allDroppedItem.itemInstance.PHGLMBIEOMK(), MEMGMDOCBOJ))
			{
				allDroppedItem.LDAEGIDMABJ();
				return true;
			}
		}
		return false;
	}

	public void BACMIFIIPAG()
	{
		int num = ELDIKFCAJFL();
		EAFHKACPMAO(num - 1);
		if (GLJOIHEPCJL() == 0)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}
}
