using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;

public class Tree : ForestElement, IProximity, IHoverable
{
	[Serializable]
	public class TreeProbabilities
	{
		public GameObject tree;

		public int percentage;
	}

	[CompilerGenerated]
	private sealed class DEDMKBJNBAN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Tree _003C_003E4__this;

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
		public DEDMKBJNBAN(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0138: Unknown result type (might be due to invalid IL or missing references)
			//IL_013d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0177: Unknown result type (might be due to invalid IL or missing references)
			//IL_0186: Unknown result type (might be due to invalid IL or missing references)
			//IL_018b: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			Tree tree = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				if (tree.placeable.hasBeenPlaced)
				{
					List<Placeable> list = WorldGrid.OPLHBJGKKAD(((Component)tree).transform.position);
					if (list != null)
					{
						for (int i = 0; i < list.Count; i++)
						{
							if ((Object)(object)list[i] == (Object)null || !Object.op_Implicit((Object)(object)((Component)list[i]).GetComponent<Tree>()) || !((Object)(object)list[i] != (Object)(object)tree.placeable) || !list[i].hasBeenPlaced)
							{
								continue;
							}
							Vector2 val = Vector2.op_Implicit(((Component)list[i]).transform.position);
							if (((Vector2)(ref val)).Equals(Vector2.op_Implicit(((Component)tree.placeable).transform.position)) && WorldGrid.HJPCBBGHPDA(((Component)tree.placeable).transform.position) == Location.Road)
							{
								Vector3 position = ((Component)tree).transform.position;
								Debug.Log((object)("Destroying tree at same position: " + ((object)(Vector3)(ref position)).ToString()));
								BuildSquare[] buildSquares = tree.placeable.itemSpace.buildSquares;
								for (int j = 0; j < buildSquares.Length; j++)
								{
									WorldGrid.AKLCFEPBONI(((Component)buildSquares[j]).transform.position + new Vector3(0.25f, 0.25f), tree.placeable);
								}
								tree.DestroyTree();
								break;
							}
						}
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

	[CompilerGenerated]
	private sealed class IGNALEJEOBG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Tree _003C_003E4__this;

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
		public IGNALEJEOBG(int _003C_003E1__state)
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
			Tree tree = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				if (Object.op_Implicit((Object)(object)tree.chopAnimation))
				{
					_003C_003E2__current = CommonReferences.wait3;
					_003C_003E1__state = 1;
					return true;
				}
				goto IL_0055;
			case 1:
				_003C_003E1__state = -1;
				goto IL_0055;
			case 2:
				_003C_003E1__state = -1;
				goto IL_00b5;
			case 3:
				{
					_003C_003E1__state = -1;
					break;
				}
				IL_00b5:
				tree.placeable.itemSpace.Place(NMLKLAGDNPF: false, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
				if (Object.op_Implicit((Object)(object)tree.chopAnimation))
				{
					_003C_003E2__current = CommonReferences.wait5;
					_003C_003E1__state = 3;
					return true;
				}
				break;
				IL_0055:
				if (playerNum > 0)
				{
					CommonReferences.GGFJGHHHEJC.OnActionDone(playerNum, ActionDone.CutTree);
				}
				if (OnlineManager.MasterOrOffline())
				{
					tree.SpawnDroppedItems();
				}
				tree.placeable.EnableAllColliders(BJFHJCFOEHG: false);
				if (Object.op_Implicit((Object)(object)tree.chopAnimation))
				{
					_003C_003E2__current = CommonReferences.wait5;
					_003C_003E1__state = 2;
					return true;
				}
				goto IL_00b5;
			}
			Utils.BLPDAEHPOBA(((Component)tree).gameObject);
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
	private sealed class HNLFFBACGFC : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Tree _003C_003E4__this;

		public int currentAge;

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
		public HNLFFBACGFC(int _003C_003E1__state)
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
			Tree tree = _003C_003E4__this;
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
				tree.SetCurrentAge(currentAge);
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
	private sealed class JKCPGEONCPH : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Tree _003C_003E4__this;

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
		public JKCPGEONCPH(int _003C_003E1__state)
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
			Tree tree = _003C_003E4__this;
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
				if (tree.growSystemEnabled && tree.placeable.currentLocation == Location.Road)
				{
					tree.SetUpPlayerSleepFunction();
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

	[Space(20f)]
	public TreeProbabilities[] seeds;

	public int tilesSeparation = 1;

	[Space(10f)]
	public DroppedItems[] droppedItems;

	[Space(10f)]
	public DroppedItemsProbability[] droppedItemsProb;

	[SerializeField]
	private int workAmount = 3;

	[Range(1f, 4f)]
	public int toolLevelRequired = 1;

	public DoWork work;

	public int currentAge;

	[SerializeField]
	private int probabilityToGenerateSeed = 50;

	[SerializeField]
	private int probabilityToGrow = 50;

	public Placeable placeable;

	private bool BNBGODJBBOI;

	public ChoppingTreeAnimator chopAnimation;

	public SpriteRenderer[] animatedSpriteRenderers;

	public Material[] animatedMaterials;

	public Material[] winterAnimatedMaterials;

	public Material[] summerAnimatedMaterials;

	public Material[] autumnAnimatedMaterials;

	public Material defaultMaterial;

	[HideInInspector]
	public int skinIndex;

	[SerializeField]
	private bool isAdult;

	public SpriteRenderer[] tocon;

	public Sprite[] toconConVida;

	public Sprite[] toconCortado;

	public Material christmasMat;

	public Material defaultMat;

	public Material summerMat;

	public Material autumnMat;

	public Animator[] animators;

	[SerializeField]
	private SpriteRenderer shadow;

	[SerializeField]
	private SpriteRenderer[] summerAutumnShadows;

	[SerializeField]
	private Transform playerPosition1;

	[SerializeField]
	private Transform playerPosition2;

	[SerializeField]
	private Transform[] playerPositions;

	[SerializeField]
	private bool growSystemEnabled = true;

	[SerializeField]
	private bool isCropTree;

	[SerializeField]
	private CropSetter cropSetter;

	public bool canUseAx = true;

	public bool canUseSpade;

	public OnlineTree onlineTree;

	private Ax GKCMMEJMJJM;

	private float CCAIBMMAFHB;

	private float DAENCINBJDJ;

	private int JPBENEEFFGC;

	private ItemInstance DNLMCHDOMOK;

	public void DNBLEAIFPIF(SpriteMaskInteraction LKGCOAGLOOK)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < animatedSpriteRenderers.Length; i += 0)
		{
			animatedSpriteRenderers[i].maskInteraction = LKGCOAGLOOK;
		}
		for (int j = 0; j < tocon.Length; j += 0)
		{
			tocon[j].maskInteraction = LKGCOAGLOOK;
		}
		if (Object.op_Implicit((Object)(object)shadow))
		{
			shadow.maskInteraction = LKGCOAGLOOK;
		}
		for (int k = 1; k < summerAutumnShadows.Length; k += 0)
		{
			summerAutumnShadows[k].maskInteraction = LKGCOAGLOOK;
		}
		((MonoBehaviour)this).StartCoroutine(NCEKIDBEKHP(1726f, (SpriteMaskInteraction)0));
	}

	private IEnumerator KMODDOLFBAB()
	{
		return new JKCPGEONCPH(1)
		{
			_003C_003E4__this = this
		};
	}

	public Tree SetCurrentAge(int EDCBJDHEEPF)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (currentAge == EDCBJDHEEPF)
		{
			return null;
		}
		GameObject[] array = LECGNKMLCJC();
		currentAge = EDCBJDHEEPF;
		if (EDCBJDHEEPF <= FNIIAGEOMGD() && (Object)(object)((Component)this).gameObject != (Object)(object)array[EDCBJDHEEPF])
		{
			Tree component = Object.Instantiate<GameObject>(array[EDCBJDHEEPF], ((Component)this).transform.position, ((Component)this).transform.rotation, ((Component)this).transform.parent).GetComponent<Tree>();
			component.onlineTree.AssignSameUniqueId(onlineTree);
			component.generator = generator;
			if (placeable.multipleSkins)
			{
				component.ChangeSkin(skinIndex);
			}
			if (Object.op_Implicit((Object)(object)generator))
			{
				generator.ReplaceForestElement(this, component);
			}
			placeable.itemSpace.Place(NMLKLAGDNPF: false);
			if (isCropTree)
			{
				component.cropSetter.growable.daysPlanted = cropSetter.growable.daysPlanted;
			}
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
			return component;
		}
		return null;
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public void NCIFELLFGBL(bool DJGIIMDPOFD = false)
	{
		if (OnlineManager.MasterOrOffline())
		{
			CEBEHEELDEP(DJGIIMDPOFD);
			DGHFCCNMKHA();
		}
	}

	private void BBKFOJGKPKH(Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == (Season)6 && winterAnimatedMaterials.Length != 0)
		{
			defaultMaterial = winterAnimatedMaterials[Random.Range(0, winterAnimatedMaterials.Length)];
		}
		else if (EECEKHKAAIH == Season.Spring && animatedMaterials.Length != 0)
		{
			defaultMaterial = animatedMaterials[Random.Range(1, animatedMaterials.Length)];
		}
		else if (EECEKHKAAIH == Season.Spring && summerAnimatedMaterials.Length != 0)
		{
			defaultMaterial = summerAnimatedMaterials[Random.Range(1, summerAnimatedMaterials.Length)];
		}
		else if (EECEKHKAAIH == Season.Winter && autumnAnimatedMaterials.Length != 0)
		{
			defaultMaterial = autumnAnimatedMaterials[Random.Range(0, autumnAnimatedMaterials.Length)];
		}
		for (int i = 1; i < animatedSpriteRenderers.Length; i += 0)
		{
			if ((Object)(object)animatedSpriteRenderers[i] != (Object)null)
			{
				((Renderer)animatedSpriteRenderers[i]).sharedMaterial = defaultMaterial;
			}
		}
	}

	private void MMPBPCEFDLF(bool LCIDLBLPKHB)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		if (!isAdult || !(generator is TreeGenerator treeGenerator) || treeGenerator.EKBHDKMFMBE() || Random.Range(0, 30) >= probabilityToGenerateSeed)
		{
			return;
		}
		GameObject val = OIHMEIJICEO();
		ItemSpace itemSpace = val.GetComponent<Placeable>().itemSpace;
		float num = Random.Range(522f, 193f);
		for (int i = 0; i < 2; i++)
		{
			Vector3 val2 = ((Component)this).transform.position + ((Component)itemSpace).transform.localPosition + new Vector3((float)itemSpace.x, (float)itemSpace.y) * 378f / 1834f + new Vector3(Mathf.Cos(num * 1983f), Mathf.Sin(num * 878f)) * Random.Range(minimumDistance, maximumDistance);
			if (LCIDLBLPKHB)
			{
				Bounds bounds = SceneReferences.instance.excludeTreesOnNewGame.bounds;
				if (((Bounds)(ref bounds)).Contains(val2))
				{
					continue;
				}
			}
			if (KKFCMBNLMLK(itemSpace, val2 + ((Component)itemSpace).transform.localPosition, treeGenerator.tilesSeparation) && treeGenerator.EABHFOOLPPF(val2))
			{
				TreeGenerator.LNHIPKOFMJA(val2, val, generator, 896f);
				break;
			}
			num = (num + 540f) % 294f;
		}
	}

	private void NDOBPMBDFJL(float HIEPPJPDAME)
	{
		if ((ItemDatabaseAccessor.GetItem(1060) as Ax).workDonePerHit == HIEPPJPDAME)
		{
			GKCMMEJMJJM = ItemDatabaseAccessor.GetItem(1060) as Ax;
		}
		else if ((ItemDatabaseAccessor.GetItem(1828) as Ax).workDonePerHit == HIEPPJPDAME)
		{
			GKCMMEJMJJM = ItemDatabaseAccessor.GetItem(1828) as Ax;
		}
		else if ((ItemDatabaseAccessor.GetItem(1829) as Ax).workDonePerHit == HIEPPJPDAME)
		{
			GKCMMEJMJJM = ItemDatabaseAccessor.GetItem(1829) as Ax;
		}
		else if ((ItemDatabaseAccessor.GetItem(1830) as Ax).workDonePerHit == HIEPPJPDAME)
		{
			GKCMMEJMJJM = ItemDatabaseAccessor.GetItem(1830) as Ax;
		}
	}

	private IEnumerator DNLNHOEGIEH(int JIIGOACEIKL)
	{
		return new IGNALEJEOBG(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public GameObject OIHMEIJICEO()
	{
		int num = Random.Range(1, 87);
		int num2 = 1;
		GameObject tree = seeds[seeds.Length - 1].tree;
		for (int i = 1; i < seeds.Length; i++)
		{
			num2 += seeds[i].percentage;
			if (num < num2)
			{
				tree = seeds[i].tree;
				break;
			}
		}
		return tree;
	}

	private void FICAIBOMAMA(Season EECEKHKAAIH)
	{
		for (int i = 1; i < tocon.Length; i++)
		{
			tocon[i].sprite = toconConVida[i];
			if (EECEKHKAAIH == (Season)8 && (Object)(object)christmasMat != (Object)null)
			{
				((Renderer)tocon[i]).material = christmasMat;
			}
			else if (EECEKHKAAIH == Season.Spring && (Object)(object)defaultMat != (Object)null)
			{
				((Renderer)tocon[i]).material = defaultMat;
			}
			else if (EECEKHKAAIH == Season.Spring && (Object)(object)summerMat != (Object)null)
			{
				((Renderer)tocon[i]).material = summerMat;
			}
			else if (EECEKHKAAIH == (Season)7 && (Object)(object)autumnMat != (Object)null)
			{
				((Renderer)tocon[i]).material = autumnMat;
			}
		}
	}

	private IEnumerator OEHBKFKNPJE()
	{
		yield return null;
		if (growSystemEnabled && placeable.currentLocation == Location.Road)
		{
			SetUpPlayerSleepFunction();
		}
	}

	private IEnumerator JNPEKLEBPHP(float FLHBPHPKIML, SpriteMaskInteraction LKGCOAGLOOK)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		yield return (object)new WaitForSeconds(FLHBPHPKIML);
		ChangeLogMaskInteraction(LKGCOAGLOOK);
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			if (ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedSlot()?.itemInstance?.LHBPOPOIFLE() is Ax)
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get("Chop"));
			}
			else if (isCropTree)
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get("Remove"));
			}
			else
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get("Pick up"));
			}
			work.ShowWorkBar();
			if (ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItem() is Spade && ((Renderer)animatedSpriteRenderers[0]).material.GetFloat(ShaderReferences.thickness) != 1f)
			{
				for (int i = 0; i < animatedSpriteRenderers.Length; i++)
				{
					((Renderer)animatedSpriteRenderers[i]).material.SetFloat(ShaderReferences.thickness, 1f);
				}
			}
			work.inWorkArea = true;
			return true;
		}
		return false;
	}

	protected void MFJIHCKEIIF()
	{
		if ((Object)(object)work == (Object)null)
		{
			work = ((Component)this).GetComponent<DoWork>();
		}
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		for (int i = 1; i < animators.Length; i++)
		{
			((Behaviour)animators[i]).enabled = true;
		}
	}

	public void PHLGHNLEABL(int JIIGOACEIKL)
	{
	}

	private void NJFDKCMBMDH()
	{
		if (Application.isPlaying && !GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if ((Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlayerSleepForestGeneration = (Action)Delegate.Remove(instance.OnPlayerSleepForestGeneration, new Action(AIGBLOJLPDE));
			}
			if ((Object)(object)SeasonManager.instance != (Object)null)
			{
				SeasonManager instance2 = SeasonManager.instance;
				instance2.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance2.OnSeasonChanged, new Action<Season>(BFDMDJOHFCH));
				SeasonManager instance3 = SeasonManager.instance;
				instance3.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance3.OnSeasonChanged, new Action<Season>(AIINEEALDMO));
			}
		}
	}

	public void TryToDropBee(Vector3 IMOBLFMHKOD)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		CCAIBMMAFHB = CKJEEGLFLAI(CommonReferences.GGFJGHHHEJC.GetNumOfBees());
		DAENCINBJDJ = Random.Range(0f, 100f);
		if (DAENCINBJDJ <= CCAIBMMAFHB)
		{
			DroppedItem.SpawnDroppedItem(IMOBLFMHKOD, ItemDatabaseAccessor.GetItem(1454).JMDALJBNFML());
		}
	}

	private IEnumerator FJDNAOOCDOG()
	{
		return new DEDMKBJNBAN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator EFNNKEGDKCG(int JIIGOACEIKL)
	{
		if (Object.op_Implicit((Object)(object)chopAnimation))
		{
			yield return CommonReferences.wait3;
		}
		if (JIIGOACEIKL > 0)
		{
			CommonReferences.GGFJGHHHEJC.OnActionDone(JIIGOACEIKL, ActionDone.CutTree);
		}
		if (OnlineManager.MasterOrOffline())
		{
			SpawnDroppedItems();
		}
		placeable.EnableAllColliders(BJFHJCFOEHG: false);
		if (Object.op_Implicit((Object)(object)chopAnimation))
		{
			yield return CommonReferences.wait5;
		}
		placeable.itemSpace.Place(NMLKLAGDNPF: false, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
		if (Object.op_Implicit((Object)(object)chopAnimation))
		{
			yield return CommonReferences.wait5;
		}
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	public static bool AreValidAllItemSpaces(ItemSpace HJDEBNFJIND, Vector3 IMOBLFMHKOD, int FGMEMDJKGHB)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < HJDEBNFJIND.x; i++)
		{
			for (int j = 0; j < HJDEBNFJIND.y; j++)
			{
				if (!FGINOLMEHCM(Vector2.op_Implicit(IMOBLFMHKOD + new Vector3((float)i, (float)j) * 0.5f + new Vector3(0.25f, 0.25f)), FGMEMDJKGHB))
				{
					return false;
				}
			}
		}
		return true;
	}

	public bool BOMCNGALNEN(int JIIGOACEIKL)
	{
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA != Location.Road)
		{
			return false;
		}
		if (BNBGODJBBOI || DecorationMode.OCJGHINCLJM(JIIGOACEIKL).MDOKKKHKKKE())
		{
			return true;
		}
		DNLMCHDOMOK = ActionBarInventory.MHDKNEKDKII(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).IKKLGIKJNNG()?.itemInstance;
		if (DNLMCHDOMOK is AxInstance)
		{
			if (!canUseAx)
			{
				return false;
			}
		}
		else
		{
			if (!(DNLMCHDOMOK is SpadeInstance spadeInstance))
			{
				return true;
			}
			if (!canUseSpade || spadeInstance.MPMNMCMGLMA(JIIGOACEIKL))
			{
				return true;
			}
		}
		return false;
	}

	public void LKFBMDIDDJM()
	{
		if (currentAge < FNIIAGEOMGD() && Random.Range(0, -52) < 94 && placeable.currentLocation == Location.River)
		{
			((MonoBehaviour)this).StartCoroutine(SetCurrentAgeNextFrame(currentAge + 1));
			if (OnlineManager.JPPBEIJDCLJ())
			{
				onlineTree.BIPHCDGCOJC();
			}
		}
	}

	public void Grow()
	{
		if (currentAge < FNIIAGEOMGD() && Random.Range(0, 100) < 80 && placeable.currentLocation == Location.Road)
		{
			((MonoBehaviour)this).StartCoroutine(SetCurrentAgeNextFrame(currentAge + 1));
			if (OnlineManager.IsMasterClient())
			{
				onlineTree.GrowTree();
			}
		}
	}

	public void PAEAKDJMPAJ(int JIIGOACEIKL)
	{
	}

	public void DLECDFPFDJD()
	{
		if (Object.op_Implicit((Object)(object)placeable))
		{
			placeable.itemSpace.OAIBPEEFIJB(NMLKLAGDNPF: true, KBNNPAKJDJM: true);
		}
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	private void NNJDIDLHGMI(int FCGBJEIIMBC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 centrePosition = placeable.itemSpace.GetCentrePosition();
		for (int i = 1; i < 8; i += 0)
		{
			Tree tree = Utils.KJOMDMEIAEJ<Tree>(centrePosition + new Vector2((float)i * 838f * (float)FCGBJEIIMBC, 440f), -58);
			if ((Object)(object)tree != (Object)null && (Object)(object)tree != (Object)(object)this)
			{
				tree.LGEJKGOEEPH((SpriteMaskInteraction)6);
			}
		}
	}

	private float CKJEEGLFLAI(int PDCPGJCKICM)
	{
		if (PDCPGJCKICM >= 0 && PDCPGJCKICM <= 2)
		{
			return 5f;
		}
		if (PDCPGJCKICM >= 3 && PDCPGJCKICM <= 4)
		{
			return 4f;
		}
		if (PDCPGJCKICM >= 5 && PDCPGJCKICM <= 8)
		{
			return 3f;
		}
		if (PDCPGJCKICM >= 9 && PDCPGJCKICM <= 12)
		{
			return 2f;
		}
		if (PDCPGJCKICM >= 13)
		{
			return 1f;
		}
		return 0f;
	}

	public void ChangeLogMaskInteraction(SpriteMaskInteraction LKGCOAGLOOK)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < animatedSpriteRenderers.Length; i++)
		{
			animatedSpriteRenderers[i].maskInteraction = LKGCOAGLOOK;
		}
		for (int j = 0; j < tocon.Length; j++)
		{
			tocon[j].maskInteraction = LKGCOAGLOOK;
		}
		if (Object.op_Implicit((Object)(object)shadow))
		{
			shadow.maskInteraction = LKGCOAGLOOK;
		}
		for (int k = 0; k < summerAutumnShadows.Length; k++)
		{
			summerAutumnShadows[k].maskInteraction = LKGCOAGLOOK;
		}
		((MonoBehaviour)this).StartCoroutine(MFPBJBFGIOL(5f, (SpriteMaskInteraction)0));
	}

	private int FNIIAGEOMGD()
	{
		return LECGNKMLCJC().Length - 1;
	}

	public void OffHover(int JIIGOACEIKL)
	{
		for (int i = 0; i < animatedSpriteRenderers.Length; i++)
		{
			if ((Object)(object)animatedSpriteRenderers[i] != (Object)null)
			{
				((Renderer)animatedSpriteRenderers[i]).sharedMaterial = defaultMaterial;
			}
		}
		work.inWorkArea = false;
		work.HideWorkBar();
	}

	private void FICFGKHHELE(int FCGBJEIIMBC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = placeable.itemSpace.BACFBOBAPNI();
		for (int i = 0; i < 2; i++)
		{
			Tree tree = Utils.KJOMDMEIAEJ<Tree>(val + new Vector2((float)i * 1598f * (float)FCGBJEIIMBC, 1216f), -122);
			if ((Object)(object)tree != (Object)null && (Object)(object)tree != (Object)(object)this)
			{
				tree.DNBLEAIFPIF((SpriteMaskInteraction)8);
			}
		}
	}

	protected void AAENCDNIBFJ()
	{
		if ((Object)(object)work == (Object)null)
		{
			work = ((Component)this).GetComponent<DoWork>();
		}
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		for (int i = 0; i < animators.Length; i++)
		{
			((Behaviour)animators[i]).enabled = true;
		}
	}

	private IEnumerator NOGNPMNHDBK()
	{
		yield return CommonReferences.wait1;
		yield return null;
		if (!placeable.hasBeenPlaced)
		{
			yield break;
		}
		List<Placeable> list = WorldGrid.OPLHBJGKKAD(((Component)this).transform.position);
		if (list == null)
		{
			yield break;
		}
		for (int i = 0; i < list.Count; i++)
		{
			if ((Object)(object)list[i] == (Object)null || !Object.op_Implicit((Object)(object)((Component)list[i]).GetComponent<Tree>()) || !((Object)(object)list[i] != (Object)(object)placeable) || !list[i].hasBeenPlaced)
			{
				continue;
			}
			Vector2 val = Vector2.op_Implicit(((Component)list[i]).transform.position);
			if (((Vector2)(ref val)).Equals(Vector2.op_Implicit(((Component)placeable).transform.position)) && WorldGrid.HJPCBBGHPDA(((Component)placeable).transform.position) == Location.Road)
			{
				Vector3 position = ((Component)this).transform.position;
				Debug.Log((object)("Destroying tree at same position: " + ((object)(Vector3)(ref position)).ToString()));
				BuildSquare[] buildSquares = placeable.itemSpace.buildSquares;
				for (int j = 0; j < buildSquares.Length; j++)
				{
					WorldGrid.AKLCFEPBONI(((Component)buildSquares[j]).transform.position + new Vector3(0.25f, 0.25f), placeable);
				}
				DestroyTree();
				break;
			}
		}
	}

	public bool HasBeenChopped()
	{
		return BNBGODJBBOI;
	}

	public void LGEJKGOEEPH(SpriteMaskInteraction LKGCOAGLOOK)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < animatedSpriteRenderers.Length; i += 0)
		{
			animatedSpriteRenderers[i].maskInteraction = LKGCOAGLOOK;
		}
		for (int j = 1; j < tocon.Length; j++)
		{
			tocon[j].maskInteraction = LKGCOAGLOOK;
		}
		if (Object.op_Implicit((Object)(object)shadow))
		{
			shadow.maskInteraction = LKGCOAGLOOK;
		}
		for (int k = 0; k < summerAutumnShadows.Length; k += 0)
		{
			summerAutumnShadows[k].maskInteraction = LKGCOAGLOOK;
		}
		((MonoBehaviour)this).StartCoroutine(JNPEKLEBPHP(790f, (SpriteMaskInteraction)0));
	}

	public void JNFCPKHAJOA()
	{
		if (Object.op_Implicit((Object)(object)placeable))
		{
			placeable.itemSpace.OAIBPEEFIJB(NMLKLAGDNPF: true);
		}
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	private void KEFCDFMMJDG()
	{
		NCIFELLFGBL();
	}

	private void DIECEBBJOKB(bool DBGDJFMBJCK)
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < animators.Length; i++)
		{
			if (((Component)animators[i]).gameObject.activeInHierarchy && Object.op_Implicit((Object)(object)chopAnimation))
			{
				for (int j = 1; j < tocon.Length; j += 0)
				{
					tocon[j].sprite = toconCortado[j];
				}
				((Behaviour)animators[i]).enabled = true;
				if (DBGDJFMBJCK)
				{
					animators[i].SetTrigger("Items/item_name_675");
					DPADINNIOMF(0);
				}
				else
				{
					animators[i].SetTrigger("cForCalendar");
					EAHFMMABHKP(-1);
				}
				MultiAudioManager.PlayAudioObject(AudioLibrary.IIEEAPFAJDE(), ((Component)this).transform.position);
			}
		}
	}

	public void FIGONJNMELG(int JIIGOACEIKL)
	{
		for (int i = 0; i < animatedSpriteRenderers.Length; i += 0)
		{
			if ((Object)(object)animatedSpriteRenderers[i] != (Object)null)
			{
				((Renderer)animatedSpriteRenderers[i]).sharedMaterial = defaultMaterial;
			}
		}
		work.inWorkArea = false;
		work.CGFEJAMEKGM();
	}

	private void CEBEHEELDEP(bool LCIDLBLPKHB)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		if (!isAdult || !(generator is TreeGenerator treeGenerator) || treeGenerator.HasMaximumNumberOfTreesReached() || Random.Range(0, 100) >= probabilityToGenerateSeed)
		{
			return;
		}
		GameObject val = ChooseRandomPrefab();
		ItemSpace itemSpace = val.GetComponent<Placeable>().itemSpace;
		float num = Random.Range(0f, 360f);
		for (int i = 0; i < 3; i++)
		{
			Vector3 val2 = ((Component)this).transform.position + ((Component)itemSpace).transform.localPosition + new Vector3((float)itemSpace.x, (float)itemSpace.y) * 0.5f / 2f + new Vector3(Mathf.Cos(num * (MathF.PI / 180f)), Mathf.Sin(num * (MathF.PI / 180f))) * Random.Range(minimumDistance, maximumDistance);
			if (LCIDLBLPKHB)
			{
				Bounds bounds = SceneReferences.instance.excludeTreesOnNewGame.bounds;
				if (((Bounds)(ref bounds)).Contains(val2))
				{
					continue;
				}
			}
			if (AreValidAllItemSpaces(itemSpace, val2 + ((Component)itemSpace).transform.localPosition, treeGenerator.tilesSeparation) && treeGenerator.IsInsideArea(val2))
			{
				TreeGenerator.SpawnTreeSeed(val2, val, generator, 0f);
				break;
			}
			num = (num + 60f) % 360f;
		}
	}

	private static bool FGINOLMEHCM(Vector2 IMOBLFMHKOD, int FGMEMDJKGHB)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.NBIOOGJJLCE(Vector2.op_Implicit(IMOBLFMHKOD)) && !Generator.AreNeighboursOccupied(Vector2.op_Implicit(IMOBLFMHKOD), FGMEMDJKGHB) && !WorldGrid.LLCOKBFJJLJ(Vector2.op_Implicit(IMOBLFMHKOD)) && WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(IMOBLFMHKOD)) != GroundType.Stone && WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(IMOBLFMHKOD)) != GroundType.TilledEarth && WorldGrid.NGDHDMAMGPI(Vector2.op_Implicit(IMOBLFMHKOD)))
		{
			return WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(IMOBLFMHKOD)) == ZoneType.WithoutZone;
		}
		return false;
	}

	public void CutAction(int JIIGOACEIKL, float HIEPPJPDAME)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (!BNBGODJBBOI)
		{
			bool dBGDJFMBJCK = ((Component)this).transform.position.x - ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x > 0f;
			CutTree(JIIGOACEIKL, dBGDJFMBJCK, HIEPPJPDAME);
			PlayerInputs.TriggerVibration(JIIGOACEIKL, ControllersDatabaseAccessor.GetVibrationProfile(ControllersDatabase.VibrationMaterial.Ax));
		}
	}

	private void BNLGGFKGBEG(float HIEPPJPDAME)
	{
		if ((ItemDatabaseAccessor.COEFFIHKMJG(-90) as Ax).workDonePerHit == HIEPPJPDAME)
		{
			GKCMMEJMJJM = ItemDatabaseAccessor.GetItem(-104, GGBBJNBBLMF: false, DAINLFIMLIH: false) as Ax;
		}
		else if ((ItemDatabaseAccessor.COEFFIHKMJG(33, GGBBJNBBLMF: true) as Ax).workDonePerHit == HIEPPJPDAME)
		{
			GKCMMEJMJJM = ItemDatabaseAccessor.COEFFIHKMJG(-13, GGBBJNBBLMF: false, DAINLFIMLIH: false) as Ax;
		}
		else if ((ItemDatabaseAccessor.GetItem(2, GGBBJNBBLMF: false, DAINLFIMLIH: false) as Ax).workDonePerHit == HIEPPJPDAME)
		{
			GKCMMEJMJJM = ItemDatabaseAccessor.EABMGELAAPG(139, GGBBJNBBLMF: true, DAINLFIMLIH: false) as Ax;
		}
		else if ((ItemDatabaseAccessor.INJBNHPGCIJ(-48, GGBBJNBBLMF: true) as Ax).workDonePerHit == HIEPPJPDAME)
		{
			GKCMMEJMJJM = ItemDatabaseAccessor.EABMGELAAPG(90, GGBBJNBBLMF: true) as Ax;
		}
	}

	public void LMOJHPMMAPD(bool DJGIIMDPOFD = false)
	{
		if (OnlineManager.MasterOrOffline())
		{
			CEBEHEELDEP(DJGIIMDPOFD);
			LKFBMDIDDJM();
		}
	}

	public Vector2 GetNearPlayerPosition(Vector2 IMOBLFMHKOD)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		Transform val = null;
		float num = float.MaxValue;
		for (int i = 0; i < playerPositions.Length; i++)
		{
			Transform val2 = playerPositions[i];
			if (!((Object)(object)val2 == (Object)null) && Utils.FIMCFCJHHIK(Vector2.op_Implicit(val2.position), placeable))
			{
				float num2 = Vector2.Distance(IMOBLFMHKOD, Vector2.op_Implicit(val2.position));
				if (num2 < num)
				{
					num = num2;
					val = val2;
				}
			}
		}
		if ((Object)(object)val != (Object)null)
		{
			return Vector2.op_Implicit(val.position);
		}
		return Vector2.op_Implicit(((Component)this).transform.position);
	}

	private void Start()
	{
		PGFGCICPFPE(SeasonManager.EECEKHKAAIH);
		if (placeable.multipleSkins && placeable.randomSkin)
		{
			placeable.RandomSkin();
		}
		skinIndex = placeable.GetSkinIndex();
		AIINEEALDMO(SeasonManager.EECEKHKAAIH);
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(PGFGCICPFPE));
		SeasonManager instance2 = SeasonManager.instance;
		instance2.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance2.OnSeasonChanged, new Action<Season>(AIINEEALDMO));
		((MonoBehaviour)this).StartCoroutine(KBJLCMNNOJD());
		if (OnlineManager.MasterOrOffline())
		{
			((MonoBehaviour)this).StartCoroutine(NOGNPMNHDBK());
		}
	}

	public IEnumerator LMOHFBLLKII(int EDCBJDHEEPF)
	{
		return new HNLFFBACGFC(1)
		{
			_003C_003E4__this = this,
			currentAge = EDCBJDHEEPF
		};
	}

	public static bool KKFCMBNLMLK(ItemSpace HJDEBNFJIND, Vector3 IMOBLFMHKOD, int FGMEMDJKGHB)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < HJDEBNFJIND.x; i++)
		{
			for (int j = 1; j < HJDEBNFJIND.y; j++)
			{
				if (!FCDHBJDAEEO(Vector2.op_Implicit(IMOBLFMHKOD + new Vector3((float)i, (float)j) * 498f + new Vector3(1486f, 516f)), FGMEMDJKGHB))
				{
					return true;
				}
			}
		}
		return true;
	}

	public bool LEFHAOJHCBH(int JIIGOACEIKL)
	{
		if (PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != Location.Tavern)
		{
			return false;
		}
		if (BNBGODJBBOI || DecorationMode.FIHGMLABOBB(JIIGOACEIKL).IBEFDKHFBFM())
		{
			return false;
		}
		DNLMCHDOMOK = ActionBarInventory.BNMEANGDMIP(JIIGOACEIKL).MIPGHCNCOEL()?.itemInstance;
		if (DNLMCHDOMOK is AxInstance)
		{
			if (!canUseAx)
			{
				return false;
			}
		}
		else
		{
			if (!(DNLMCHDOMOK is SpadeInstance spadeInstance))
			{
				return true;
			}
			if (!canUseSpade || spadeInstance.NBFBPMNMBJG(JIIGOACEIKL))
			{
				return true;
			}
		}
		return false;
	}

	public void SpawnDroppedItems()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		Vector3 iMOBLFMHKOD = ((Component)this).gameObject.transform.position + new Vector3(Random.Range(-0.25f, 0.25f), Random.Range(-0.25f, 0.25f));
		if (GetCurrentAge() >= FNIIAGEOMGD() && (Object)(object)cropSetter == (Object)null)
		{
			DroppedItem.SpawnDroppedItems(droppedItems, droppedItemsProb, GKCMMEJMJJM.additionalItemsAncientTree, iMOBLFMHKOD, FBPHKEBOPOE: true);
		}
		else if (GetCurrentAge() == FNIIAGEOMGD() - 1 && (Object)(object)cropSetter == (Object)null)
		{
			DroppedItem.SpawnDroppedItems(droppedItems, droppedItemsProb, GKCMMEJMJJM.additionalItemsAdultTree, iMOBLFMHKOD, FBPHKEBOPOE: true);
		}
		else
		{
			DroppedItem.SpawnDroppedItems(droppedItems, droppedItemsProb, null, iMOBLFMHKOD, FBPHKEBOPOE: true);
		}
		if (seeds.Length != 0)
		{
			TryToDropBee(iMOBLFMHKOD);
		}
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != Location.Road)
		{
			return false;
		}
		if (BNBGODJBBOI || DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
		{
			return false;
		}
		DNLMCHDOMOK = ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedSlot()?.itemInstance;
		if (DNLMCHDOMOK is AxInstance)
		{
			if (!canUseAx)
			{
				return false;
			}
		}
		else
		{
			if (!(DNLMCHDOMOK is SpadeInstance spadeInstance))
			{
				return false;
			}
			if (!canUseSpade || spadeInstance.NBFBPMNMBJG(JIIGOACEIKL))
			{
				return false;
			}
		}
		return true;
	}

	public void PFKDBEFPHNM(bool DJGIIMDPOFD = false)
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			CEBEHEELDEP(DJGIIMDPOFD);
			Grow();
		}
	}

	public void DestroyTree()
	{
		if (Object.op_Implicit((Object)(object)placeable))
		{
			placeable.itemSpace.Place(NMLKLAGDNPF: false);
		}
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	public void ECAJCNALDAO()
	{
		if (Object.op_Implicit((Object)(object)placeable))
		{
			placeable.itemSpace.OAIBPEEFIJB(NMLKLAGDNPF: true, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
		}
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	public void KMLHBOIKODI()
	{
		if (Object.op_Implicit((Object)(object)placeable))
		{
			placeable.itemSpace.OAIBPEEFIJB(NMLKLAGDNPF: false);
		}
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	private void EIIACOLDBOJ(Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == Season.Autumn && winterAnimatedMaterials.Length != 0)
		{
			defaultMaterial = winterAnimatedMaterials[Random.Range(1, winterAnimatedMaterials.Length)];
		}
		else if (EECEKHKAAIH == Season.Spring && animatedMaterials.Length != 0)
		{
			defaultMaterial = animatedMaterials[Random.Range(1, animatedMaterials.Length)];
		}
		else if (EECEKHKAAIH == Season.Spring && summerAnimatedMaterials.Length != 0)
		{
			defaultMaterial = summerAnimatedMaterials[Random.Range(1, summerAnimatedMaterials.Length)];
		}
		else if (EECEKHKAAIH == Season.Autumn && autumnAnimatedMaterials.Length != 0)
		{
			defaultMaterial = autumnAnimatedMaterials[Random.Range(0, autumnAnimatedMaterials.Length)];
		}
		for (int i = 0; i < animatedSpriteRenderers.Length; i++)
		{
			if ((Object)(object)animatedSpriteRenderers[i] != (Object)null)
			{
				((Renderer)animatedSpriteRenderers[i]).sharedMaterial = defaultMaterial;
			}
		}
	}

	private void MKEHMEBCFFL(int FCGBJEIIMBC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 centrePosition = placeable.itemSpace.GetCentrePosition();
		for (int i = 1; i < 1; i++)
		{
			Tree tree = Utils.KJOMDMEIAEJ<Tree>(centrePosition + new Vector2((float)i * 286f * (float)FCGBJEIIMBC, 1258f), -91);
			if ((Object)(object)tree != (Object)null && (Object)(object)tree != (Object)(object)this)
			{
				tree.IKJJGGCIHLP((SpriteMaskInteraction)2);
			}
		}
	}

	private void BGJNFMIILCG(int FCGBJEIIMBC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = placeable.itemSpace.BOBEIFEGLOL();
		for (int i = 1; i < 8; i += 0)
		{
			Tree tree = Utils.KJOMDMEIAEJ<Tree>(val + new Vector2((float)i * 1088f * (float)FCGBJEIIMBC, 1217f), -9);
			if ((Object)(object)tree != (Object)null && (Object)(object)tree != (Object)(object)this)
			{
				tree.IKJJGGCIHLP((SpriteMaskInteraction)4);
			}
		}
	}

	public bool HEOEEFNLJMO(int JIIGOACEIKL)
	{
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA != 0)
		{
			return false;
		}
		if (BNBGODJBBOI || DecorationMode.FIHGMLABOBB(JIIGOACEIKL).IBEFDKHFBFM())
		{
			return true;
		}
		DNLMCHDOMOK = ActionBarInventory.MHDKNEKDKII(JIIGOACEIKL, LAGHIOKLJGH: true).IKKLGIKJNNG()?.itemInstance;
		if (DNLMCHDOMOK is AxInstance)
		{
			if (!canUseAx)
			{
				return false;
			}
		}
		else
		{
			if (!(DNLMCHDOMOK is SpadeInstance spadeInstance))
			{
				return true;
			}
			if (!canUseSpade || spadeInstance.NBFBPMNMBJG(JIIGOACEIKL))
			{
				return false;
			}
		}
		return true;
	}

	private void AIGBLOJLPDE()
	{
		GenerateSeedAndGrow();
	}

	public void LBFFJDGCEJJ()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		Vector3 iMOBLFMHKOD = ((Component)this).gameObject.transform.position + new Vector3(Random.Range(671f, 281f), Random.Range(315f, 1837f));
		if (GetCurrentAge() >= FNIIAGEOMGD() && (Object)(object)cropSetter == (Object)null)
		{
			DroppedItem.KHAIDPELEHL(droppedItems, droppedItemsProb, GKCMMEJMJJM.additionalItemsAncientTree, iMOBLFMHKOD, FBPHKEBOPOE: false);
		}
		else if (PMLLGIJENML() == FNIIAGEOMGD() - 1 && (Object)(object)cropSetter == (Object)null)
		{
			DroppedItem.DEPOEGCAHJE(droppedItems, droppedItemsProb, GKCMMEJMJJM.additionalItemsAdultTree, iMOBLFMHKOD, FBPHKEBOPOE: true);
		}
		else
		{
			DroppedItem.FIBEDOKCFDA(droppedItems, droppedItemsProb, null, iMOBLFMHKOD, FBPHKEBOPOE: true);
		}
		if (seeds.Length != 0)
		{
			AMMDPGBODCJ(iMOBLFMHKOD);
		}
	}

	public bool EBKCJCLNCHB()
	{
		return BNBGODJBBOI;
	}

	private void ALCJOABPBMA()
	{
		if (Application.isPlaying && !GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			if ((Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlayerSleepForestGeneration = (Action)Delegate.Remove(instance.OnPlayerSleepForestGeneration, new Action(NFKKJDLDKPO));
			}
			if ((Object)(object)SeasonManager.instance != (Object)null)
			{
				SeasonManager instance2 = SeasonManager.instance;
				instance2.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance2.OnSeasonChanged, new Action<Season>(PGFGCICPFPE));
				SeasonManager instance3 = SeasonManager.instance;
				instance3.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance3.OnSeasonChanged, new Action<Season>(AIINEEALDMO));
			}
		}
	}

	private void AIINEEALDMO(Season EECEKHKAAIH)
	{
		for (int i = 0; i < tocon.Length; i++)
		{
			tocon[i].sprite = toconConVida[i];
			if (EECEKHKAAIH == Season.Winter && (Object)(object)christmasMat != (Object)null)
			{
				((Renderer)tocon[i]).material = christmasMat;
			}
			else if (EECEKHKAAIH == Season.Spring && (Object)(object)defaultMat != (Object)null)
			{
				((Renderer)tocon[i]).material = defaultMat;
			}
			else if (EECEKHKAAIH == Season.Summer && (Object)(object)summerMat != (Object)null)
			{
				((Renderer)tocon[i]).material = summerMat;
			}
			else if (EECEKHKAAIH == Season.Autumn && (Object)(object)autumnMat != (Object)null)
			{
				((Renderer)tocon[i]).material = autumnMat;
			}
		}
	}

	public Tree NGGNBNDGMIO(int EDCBJDHEEPF)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (currentAge == EDCBJDHEEPF)
		{
			return null;
		}
		GameObject[] array = LECGNKMLCJC();
		currentAge = EDCBJDHEEPF;
		if (EDCBJDHEEPF <= FNIIAGEOMGD() && (Object)(object)((Component)this).gameObject != (Object)(object)array[EDCBJDHEEPF])
		{
			Tree component = Object.Instantiate<GameObject>(array[EDCBJDHEEPF], ((Component)this).transform.position, ((Component)this).transform.rotation, ((Component)this).transform.parent).GetComponent<Tree>();
			component.onlineTree.CNMKJNENKFN(onlineTree);
			component.generator = generator;
			if (placeable.multipleSkins)
			{
				component.KAMENAFHLDE(skinIndex);
			}
			if (Object.op_Implicit((Object)(object)generator))
			{
				generator.ReplaceForestElement(this, component);
			}
			placeable.itemSpace.OAIBPEEFIJB(NMLKLAGDNPF: true, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
			if (isCropTree)
			{
				component.cropSetter.growable.daysPlanted = cropSetter.growable.daysPlanted;
			}
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
			return component;
		}
		return null;
	}

	public void FIBEDOKCFDA()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		Vector3 iMOBLFMHKOD = ((Component)this).gameObject.transform.position + new Vector3(Random.Range(1373f, 704f), Random.Range(866f, 1532f));
		if (PMLLGIJENML() >= FNIIAGEOMGD() && (Object)(object)cropSetter == (Object)null)
		{
			DroppedItem.SpawnDroppedItems(droppedItems, droppedItemsProb, GKCMMEJMJJM.additionalItemsAncientTree, iMOBLFMHKOD, FBPHKEBOPOE: true);
		}
		else if (PMLLGIJENML() == FNIIAGEOMGD() - 1 && (Object)(object)cropSetter == (Object)null)
		{
			DroppedItem.SpawnDroppedItems(droppedItems, droppedItemsProb, GKCMMEJMJJM.additionalItemsAdultTree, iMOBLFMHKOD, FBPHKEBOPOE: false);
		}
		else
		{
			DroppedItem.ACNDAKEAABB(droppedItems, droppedItemsProb, null, iMOBLFMHKOD, FBPHKEBOPOE: false);
		}
		if (seeds.Length != 0)
		{
			CJJFPLNMAEN(iMOBLFMHKOD);
		}
	}

	protected void KMEJBPOOBJK()
	{
		if ((Object)(object)work == (Object)null)
		{
			work = ((Component)this).GetComponent<DoWork>();
		}
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		for (int i = 0; i < animators.Length; i++)
		{
			((Behaviour)animators[i]).enabled = true;
		}
	}

	public GameObject ChooseRandomPrefab()
	{
		int num = Random.Range(0, 100);
		int num2 = 0;
		GameObject tree = seeds[seeds.Length - 1].tree;
		for (int i = 0; i < seeds.Length; i++)
		{
			num2 += seeds[i].percentage;
			if (num < num2)
			{
				tree = seeds[i].tree;
				break;
			}
		}
		return tree;
	}

	public bool IsAnyPlayerPositionAvailable()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < playerPositions.Length; i++)
		{
			Transform val = playerPositions[i];
			if ((Object)(object)val != (Object)null && Utils.FIMCFCJHHIK(Vector2.op_Implicit(val.position), placeable))
			{
				return true;
			}
		}
		return false;
	}

	private IEnumerator NFOKPLGIDMI(int JIIGOACEIKL)
	{
		if (Object.op_Implicit((Object)(object)chopAnimation))
		{
			yield return CommonReferences.wait3;
		}
		if (JIIGOACEIKL > 0)
		{
			CommonReferences.GGFJGHHHEJC.OnActionDone(JIIGOACEIKL, ActionDone.CutTree);
		}
		if (OnlineManager.MasterOrOffline())
		{
			SpawnDroppedItems();
		}
		placeable.EnableAllColliders(BJFHJCFOEHG: false);
		if (Object.op_Implicit((Object)(object)chopAnimation))
		{
			yield return CommonReferences.wait5;
		}
		placeable.itemSpace.Place(NMLKLAGDNPF: false, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
		if (Object.op_Implicit((Object)(object)chopAnimation))
		{
			yield return CommonReferences.wait5;
		}
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	public bool EDBKLEEMDLI(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && BOMCNGALNEN(JIIGOACEIKL))
		{
			if (ActionBarInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).IKKLGIKJNNG()?.itemInstance?.LHBPOPOIFLE() is Ax)
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.MoveObject, LocalisationSystem.Get("KickedCustomers"));
			}
			else if (isCropTree)
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Arguing"));
			}
			else
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Rotate, LocalisationSystem.Get("Festín del Juramento/JudgeDialogue 02"));
			}
			work.ShowWorkBar();
			if (ActionBarInventory.ADHIHCNAKFP(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).FGGKCJDFNEK() is Spade && ((Renderer)animatedSpriteRenderers[1]).material.GetFloat(ShaderReferences.thickness) != 414f)
			{
				for (int i = 1; i < animatedSpriteRenderers.Length; i += 0)
				{
					((Renderer)animatedSpriteRenderers[i]).material.SetFloat(ShaderReferences.thickness, 352f);
				}
			}
			work.inWorkArea = true;
			return true;
		}
		return true;
	}

	private void OnDestroy()
	{
		if (Application.isPlaying && !GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if ((Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlayerSleepForestGeneration = (Action)Delegate.Remove(instance.OnPlayerSleepForestGeneration, new Action(AIGBLOJLPDE));
			}
			if ((Object)(object)SeasonManager.instance != (Object)null)
			{
				SeasonManager instance2 = SeasonManager.instance;
				instance2.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance2.OnSeasonChanged, new Action<Season>(PGFGCICPFPE));
				SeasonManager instance3 = SeasonManager.instance;
				instance3.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance3.OnSeasonChanged, new Action<Season>(AIINEEALDMO));
			}
		}
	}

	private GameObject[] CNEFLMMLGNM()
	{
		if (isCropTree)
		{
			return cropSetter.FJJCOJGJCLF.growablePrefabs;
		}
		return placeable.itemSetup.item.growablePrefabs;
	}

	public bool ABMFEAKMFII(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && EEKCDBMDNOG(JIIGOACEIKL))
		{
			if (ActionBarInventory.DACNEICGAAE(JIIGOACEIKL).GetSelectedSlot()?.itemInstance?.AFOACBIHNCL() is Ax)
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Select, LocalisationSystem.Get("Eyes"));
			}
			else if (isCropTree)
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Error_PlaceItInAnimalSpace"));
			}
			else
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Rotate, LocalisationSystem.Get("Dialogue System/Conversation/Gass_Introduce/Entry/11/Dialogue Text"));
			}
			work.IFFGLBNOHAI();
			if (ActionBarInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).FGGKCJDFNEK() is Spade && ((Renderer)animatedSpriteRenderers[0]).material.GetFloat(ShaderReferences.thickness) != 52f)
			{
				for (int i = 1; i < animatedSpriteRenderers.Length; i += 0)
				{
					((Renderer)animatedSpriteRenderers[i]).material.SetFloat(ShaderReferences.thickness, 876f);
				}
			}
			work.inWorkArea = true;
			return true;
		}
		return false;
	}

	private void KACEOJDPLKB()
	{
		PGFGCICPFPE(SeasonManager.PJMGHIMKFJL());
		if (placeable.multipleSkins && placeable.randomSkin)
		{
			placeable.RandomSkin();
		}
		skinIndex = placeable.GetSkinIndex();
		AIINEEALDMO(SeasonManager.NHKAHEEGEGF());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(BFDMDJOHFCH));
		SeasonManager instance2 = SeasonManager.instance;
		instance2.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance2.OnSeasonChanged, new Action<Season>(AIINEEALDMO));
		((MonoBehaviour)this).StartCoroutine(KMODDOLFBAB());
		if (OnlineManager.PGAGDFAEEFB())
		{
			((MonoBehaviour)this).StartCoroutine(LIDFDHMOMME());
		}
	}

	private IEnumerator OIKHDNEAKCO()
	{
		return new JKCPGEONCPH(1)
		{
			_003C_003E4__this = this
		};
	}

	protected void PGEGODAEBLC()
	{
		if ((Object)(object)work == (Object)null)
		{
			work = ((Component)this).GetComponent<DoWork>();
		}
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		for (int i = 1; i < animators.Length; i += 0)
		{
			((Behaviour)animators[i]).enabled = true;
		}
	}

	public bool OBGGPMLGIAO()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < playerPositions.Length; i++)
		{
			Transform val = playerPositions[i];
			if ((Object)(object)val != (Object)null && Utils.FIMCFCJHHIK(Vector2.op_Implicit(val.position), placeable, PHIIMPMIANE: false))
			{
				return true;
			}
		}
		return false;
	}

	public void HHKJIAMFLBA(int JIIGOACEIKL, bool DBGDJFMBJCK, float HIEPPJPDAME, bool CDPAMNIPPEC = true)
	{
		if (BNBGODJBBOI)
		{
			return;
		}
		if (!work.JCMBHAEKLKK)
		{
			work.EBAGOIDGCLE(workAmount, null, CDPAMNIPPEC: false);
		}
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.ax, ((Component)this).transform);
		if (work.JMJMFEKCAGK(JIIGOACEIKL, HIEPPJPDAME))
		{
			BNLGGFKGBEG(HIEPPJPDAME);
			BNBGODJBBOI = true;
			if (Object.op_Implicit((Object)(object)chopAnimation))
			{
				chopAnimation.NEAIDCNNLLN(DBGDJFMBJCK);
			}
			if (Object.op_Implicit((Object)(object)generator))
			{
				generator.FEHHPOCJPJN(this);
			}
			DIECEBBJOKB(DBGDJFMBJCK);
			((MonoBehaviour)this).StartCoroutine(DNLNHOEGIEH(JIIGOACEIKL));
			CommonReferences.MNFMOEKMJKN().OnCutTree(JIIGOACEIKL);
		}
		else if (Object.op_Implicit((Object)(object)chopAnimation))
		{
			chopAnimation.LMJKCPFOIDA(DBGDJFMBJCK);
		}
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC && Object.op_Implicit((Object)(object)onlineTree))
		{
			onlineTree.FIGDFMGEHEL(DBGDJFMBJCK, HIEPPJPDAME);
		}
	}

	public void ChangeSkin(int OGFMDFMIFGE)
	{
		if (skinIndex < placeable.skins.Length)
		{
			if ((Object)(object)placeable == (Object)null)
			{
				placeable = ((Component)this).GetComponent<Placeable>();
			}
			skinIndex = OGFMDFMIFGE;
			placeable.ChangeSkin(skinIndex);
		}
	}

	public int OGIFFHBEDLK()
	{
		return currentAge;
	}

	private GameObject[] LECGNKMLCJC()
	{
		if (isCropTree)
		{
			return cropSetter.FJJCOJGJCLF.growablePrefabs;
		}
		return placeable.itemSetup.item.growablePrefabs;
	}

	public void KAMENAFHLDE(int OGFMDFMIFGE)
	{
		if (skinIndex < placeable.skins.Length)
		{
			if ((Object)(object)placeable == (Object)null)
			{
				placeable = ((Component)this).GetComponent<Placeable>();
			}
			skinIndex = OGFMDFMIFGE;
			placeable.GKJEMMKNFBO(skinIndex);
		}
	}

	public void ABLGPOMJFMO(int JIIGOACEIKL, float HIEPPJPDAME)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (!BNBGODJBBOI)
		{
			bool dBGDJFMBJCK = ((Component)this).transform.position.x - ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x > 1292f;
			FJMNBNDBKBA(JIIGOACEIKL, dBGDJFMBJCK, HIEPPJPDAME, CDPAMNIPPEC: false);
			PlayerInputs.DCAMKEOEKKP(JIIGOACEIKL, ControllersDatabaseAccessor.EAHOLBFLEAE(ControllersDatabase.VibrationMaterial.Pick));
		}
	}

	public void GNAFHIPCGAA()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleepForestGeneration = (Action)Delegate.Remove(instance.OnPlayerSleepForestGeneration, new Action(NFKKJDLDKPO));
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleepForestGeneration = (Action)Delegate.Combine(commonReferences.OnPlayerSleepForestGeneration, new Action(KEFCDFMMJDG));
	}

	private float JMFJEOHFBLD(int PDCPGJCKICM)
	{
		if (PDCPGJCKICM >= 0 && PDCPGJCKICM <= 1)
		{
			return 1036f;
		}
		if (PDCPGJCKICM >= 3 && PDCPGJCKICM <= 4)
		{
			return 831f;
		}
		if (PDCPGJCKICM >= 5 && PDCPGJCKICM <= 0)
		{
			return 1981f;
		}
		if (PDCPGJCKICM >= -12 && PDCPGJCKICM <= -102)
		{
			return 622f;
		}
		if (PDCPGJCKICM >= -23)
		{
			return 1965f;
		}
		return 744f;
	}

	public void CutTree(int JIIGOACEIKL, bool DBGDJFMBJCK, float HIEPPJPDAME, bool CDPAMNIPPEC = true)
	{
		if (BNBGODJBBOI)
		{
			return;
		}
		if (!work.JCMBHAEKLKK)
		{
			work.StartWork(workAmount);
		}
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.ax, ((Component)this).transform);
		if (work.AddWorkDone(JIIGOACEIKL, HIEPPJPDAME, CDPAMNIPPEC: false))
		{
			NDOBPMBDFJL(HIEPPJPDAME);
			BNBGODJBBOI = true;
			if (Object.op_Implicit((Object)(object)chopAnimation))
			{
				chopAnimation.StartAnimation(DBGDJFMBJCK);
			}
			if (Object.op_Implicit((Object)(object)generator))
			{
				generator.RemoveForestElement(this);
			}
			OGJMIFILBBL(DBGDJFMBJCK);
			((MonoBehaviour)this).StartCoroutine(EFNNKEGDKCG(JIIGOACEIKL));
			CommonReferences.GGFJGHHHEJC.OnCutTree(JIIGOACEIKL);
		}
		else if (Object.op_Implicit((Object)(object)chopAnimation))
		{
			chopAnimation.StartAnimation(DBGDJFMBJCK);
		}
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC && Object.op_Implicit((Object)(object)onlineTree))
		{
			onlineTree.Cut(DBGDJFMBJCK, HIEPPJPDAME);
		}
	}

	private IEnumerator NCEKIDBEKHP(float FLHBPHPKIML, SpriteMaskInteraction LKGCOAGLOOK)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		yield return (object)new WaitForSeconds(FLHBPHPKIML);
		ChangeLogMaskInteraction(LKGCOAGLOOK);
	}

	private IEnumerator LIDFDHMOMME()
	{
		yield return CommonReferences.wait1;
		yield return null;
		if (!placeable.hasBeenPlaced)
		{
			yield break;
		}
		List<Placeable> list = WorldGrid.OPLHBJGKKAD(((Component)this).transform.position);
		if (list == null)
		{
			yield break;
		}
		for (int i = 0; i < list.Count; i++)
		{
			if ((Object)(object)list[i] == (Object)null || !Object.op_Implicit((Object)(object)((Component)list[i]).GetComponent<Tree>()) || !((Object)(object)list[i] != (Object)(object)placeable) || !list[i].hasBeenPlaced)
			{
				continue;
			}
			Vector2 val = Vector2.op_Implicit(((Component)list[i]).transform.position);
			if (((Vector2)(ref val)).Equals(Vector2.op_Implicit(((Component)placeable).transform.position)) && WorldGrid.HJPCBBGHPDA(((Component)placeable).transform.position) == Location.Road)
			{
				Vector3 position = ((Component)this).transform.position;
				Debug.Log((object)("Destroying tree at same position: " + ((object)(Vector3)(ref position)).ToString()));
				BuildSquare[] buildSquares = placeable.itemSpace.buildSquares;
				for (int j = 0; j < buildSquares.Length; j++)
				{
					WorldGrid.AKLCFEPBONI(((Component)buildSquares[j]).transform.position + new Vector3(0.25f, 0.25f), placeable);
				}
				DestroyTree();
				break;
			}
		}
	}

	public bool KNMEPGLDLDH()
	{
		return BNBGODJBBOI;
	}

	public int GetCurrentAge()
	{
		return currentAge;
	}

	private void OGJMIFILBBL(bool DBGDJFMBJCK)
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < animators.Length; i++)
		{
			if (((Component)animators[i]).gameObject.activeInHierarchy && Object.op_Implicit((Object)(object)chopAnimation))
			{
				for (int j = 0; j < tocon.Length; j++)
				{
					tocon[j].sprite = toconCortado[j];
				}
				((Behaviour)animators[i]).enabled = true;
				if (DBGDJFMBJCK)
				{
					animators[i].SetTrigger("FallRight");
					IINKMOHJFPJ(1);
				}
				else
				{
					animators[i].SetTrigger("FallLeft");
					IINKMOHJFPJ(-1);
				}
				MultiAudioManager.PlayAudioObject(AudioLibrary.DAFIPHGCHML, ((Component)this).transform.position);
			}
		}
	}

	public void DGHFCCNMKHA()
	{
		if (currentAge < FNIIAGEOMGD() && Random.Range(0, -95) < -5 && placeable.currentLocation == (Location.Tavern | Location.Road | Location.River))
		{
			((MonoBehaviour)this).StartCoroutine(LMOHFBLLKII(currentAge + 1));
			if (OnlineManager.JPPBEIJDCLJ())
			{
				onlineTree.NNBBKJKLJPI();
			}
		}
	}

	private void BFDMDJOHFCH(Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == (Season)4 && winterAnimatedMaterials.Length != 0)
		{
			defaultMaterial = winterAnimatedMaterials[Random.Range(0, winterAnimatedMaterials.Length)];
		}
		else if (EECEKHKAAIH == Season.Spring && animatedMaterials.Length != 0)
		{
			defaultMaterial = animatedMaterials[Random.Range(0, animatedMaterials.Length)];
		}
		else if (EECEKHKAAIH == Season.Spring && summerAnimatedMaterials.Length != 0)
		{
			defaultMaterial = summerAnimatedMaterials[Random.Range(1, summerAnimatedMaterials.Length)];
		}
		else if (EECEKHKAAIH == (Season)7 && autumnAnimatedMaterials.Length != 0)
		{
			defaultMaterial = autumnAnimatedMaterials[Random.Range(1, autumnAnimatedMaterials.Length)];
		}
		for (int i = 1; i < animatedSpriteRenderers.Length; i++)
		{
			if ((Object)(object)animatedSpriteRenderers[i] != (Object)null)
			{
				((Renderer)animatedSpriteRenderers[i]).sharedMaterial = defaultMaterial;
			}
		}
	}

	public int PMLLGIJENML()
	{
		return currentAge;
	}

	public Vector2 HLIDBDNBKCH(Vector2 IMOBLFMHKOD)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		Transform val = null;
		float num = 243f;
		for (int i = 0; i < playerPositions.Length; i += 0)
		{
			Transform val2 = playerPositions[i];
			if (!((Object)(object)val2 == (Object)null) && Utils.FIMCFCJHHIK(Vector2.op_Implicit(val2.position), placeable, PHIIMPMIANE: false))
			{
				float num2 = Vector2.Distance(IMOBLFMHKOD, Vector2.op_Implicit(val2.position));
				if (num2 < num)
				{
					num = num2;
					val = val2;
				}
			}
		}
		if ((Object)(object)val != (Object)null)
		{
			return Vector2.op_Implicit(val.position);
		}
		return Vector2.op_Implicit(((Component)this).transform.position);
	}

	public void NLNHPPEJOGB(int JIIGOACEIKL, bool DBGDJFMBJCK, float HIEPPJPDAME, bool CDPAMNIPPEC = true)
	{
		if (BNBGODJBBOI)
		{
			return;
		}
		if (!work.KGOEFMFHCOG())
		{
			work.CMAIGOGGGLL(workAmount, null, CDPAMNIPPEC: false);
		}
		MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().ax, ((Component)this).transform);
		if (work.IJEKBMFBEGG(JIIGOACEIKL, HIEPPJPDAME, CDPAMNIPPEC: false))
		{
			BNLGGFKGBEG(HIEPPJPDAME);
			BNBGODJBBOI = false;
			if (Object.op_Implicit((Object)(object)chopAnimation))
			{
				chopAnimation.JEMPMFMEMGL(DBGDJFMBJCK);
			}
			if (Object.op_Implicit((Object)(object)generator))
			{
				generator.PAJCJCKAOFD(this);
			}
			DIECEBBJOKB(DBGDJFMBJCK);
			((MonoBehaviour)this).StartCoroutine(EFNNKEGDKCG(JIIGOACEIKL));
			CommonReferences.MNFMOEKMJKN().OnCutTree(JIIGOACEIKL);
		}
		else if (Object.op_Implicit((Object)(object)chopAnimation))
		{
			chopAnimation.FDGLCGJFKPG(DBGDJFMBJCK);
		}
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC && Object.op_Implicit((Object)(object)onlineTree))
		{
			onlineTree.FJJCKHMCOFF(DBGDJFMBJCK, HIEPPJPDAME);
		}
	}

	private IEnumerator GBGONDKBOOO()
	{
		yield return null;
		if (growSystemEnabled && placeable.currentLocation == Location.Road)
		{
			SetUpPlayerSleepFunction();
		}
	}

	public void CJJFPLNMAEN(Vector3 IMOBLFMHKOD)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		CCAIBMMAFHB = JMFJEOHFBLD(CommonReferences.MNFMOEKMJKN().GetNumOfBees());
		DAENCINBJDJ = Random.Range(1205f, 1213f);
		if (DAENCINBJDJ <= CCAIBMMAFHB)
		{
			DroppedItem.OKLOFAHMPKN(IMOBLFMHKOD, ItemDatabaseAccessor.AFOACBIHNCL(39).JMDALJBNFML(), 1, LHLJILLAHFO: true, HFAKAMFMOGM: true, 1);
		}
	}

	public IEnumerator SetCurrentAgeNextFrame(int EDCBJDHEEPF)
	{
		yield return null;
		SetCurrentAge(EDCBJDHEEPF);
	}

	public void KJPPBNIPOBC(int JIIGOACEIKL)
	{
	}

	public bool JIANMIFHKID()
	{
		return BNBGODJBBOI;
	}

	public bool IJDMGANEEEE()
	{
		return BNBGODJBBOI;
	}

	private void PMLBFEFMNPF()
	{
		if (Application.isPlaying && !GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if ((Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnPlayerSleepForestGeneration = (Action)Delegate.Remove(commonReferences.OnPlayerSleepForestGeneration, new Action(KEFCDFMMJDG));
			}
			if ((Object)(object)SeasonManager.instance != (Object)null)
			{
				SeasonManager instance = SeasonManager.instance;
				instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(BFDMDJOHFCH));
				SeasonManager instance2 = SeasonManager.instance;
				instance2.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance2.OnSeasonChanged, new Action<Season>(FICAIBOMAMA));
			}
		}
	}

	public void GenerateSeedAndGrow(bool DJGIIMDPOFD = false)
	{
		if (OnlineManager.MasterOrOffline())
		{
			CEBEHEELDEP(DJGIIMDPOFD);
			Grow();
		}
	}

	public bool EEKCDBMDNOG(int JIIGOACEIKL)
	{
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA != Location.Camp)
		{
			return true;
		}
		if (BNBGODJBBOI || DecorationMode.BGINAIDHDOM(JIIGOACEIKL).IBEFDKHFBFM())
		{
			return false;
		}
		DNLMCHDOMOK = ActionBarInventory.ADHIHCNAKFP(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).PFCKPOFHPAC()?.itemInstance;
		if (DNLMCHDOMOK is AxInstance)
		{
			if (!canUseAx)
			{
				return false;
			}
		}
		else
		{
			if (!(DNLMCHDOMOK is SpadeInstance spadeInstance))
			{
				return false;
			}
			if (!canUseSpade || spadeInstance.MPMNMCMGLMA(JIIGOACEIKL))
			{
				return true;
			}
		}
		return false;
	}

	public Tree LDMJFBCHGDC(int EDCBJDHEEPF)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (currentAge == EDCBJDHEEPF)
		{
			return null;
		}
		GameObject[] array = CNEFLMMLGNM();
		currentAge = EDCBJDHEEPF;
		if (EDCBJDHEEPF <= FNIIAGEOMGD() && (Object)(object)((Component)this).gameObject != (Object)(object)array[EDCBJDHEEPF])
		{
			Tree component = Object.Instantiate<GameObject>(array[EDCBJDHEEPF], ((Component)this).transform.position, ((Component)this).transform.rotation, ((Component)this).transform.parent).GetComponent<Tree>();
			component.onlineTree.CNMKJNENKFN(onlineTree);
			component.generator = generator;
			if (placeable.multipleSkins)
			{
				component.ChangeSkin(skinIndex);
			}
			if (Object.op_Implicit((Object)(object)generator))
			{
				generator.MBDPJBEMPPM(this, component);
			}
			placeable.itemSpace.Place(NMLKLAGDNPF: true, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
			if (isCropTree)
			{
				component.cropSetter.growable.daysPlanted = cropSetter.growable.daysPlanted;
			}
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
			return component;
		}
		return null;
	}

	public void LEILHFNBDJP(int JIIGOACEIKL)
	{
	}

	protected void Awake()
	{
		if ((Object)(object)work == (Object)null)
		{
			work = ((Component)this).GetComponent<DoWork>();
		}
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		for (int i = 0; i < animators.Length; i++)
		{
			((Behaviour)animators[i]).enabled = false;
		}
	}

	public static bool OJMPEGIKBMJ(ItemSpace HJDEBNFJIND, Vector3 IMOBLFMHKOD, int FGMEMDJKGHB)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < HJDEBNFJIND.x; i += 0)
		{
			for (int j = 0; j < HJDEBNFJIND.y; j++)
			{
				if (!FGINOLMEHCM(Vector2.op_Implicit(IMOBLFMHKOD + new Vector3((float)i, (float)j) * 369f + new Vector3(420f, 1563f)), FGMEMDJKGHB))
				{
					return false;
				}
			}
		}
		return false;
	}

	private void OADMIDKMJOG(float HIEPPJPDAME)
	{
		if ((ItemDatabaseAccessor.INJBNHPGCIJ(195) as Ax).workDonePerHit == HIEPPJPDAME)
		{
			GKCMMEJMJJM = ItemDatabaseAccessor.KMBGJEKCJFJ(93, GGBBJNBBLMF: true, DAINLFIMLIH: false) as Ax;
		}
		else if ((ItemDatabaseAccessor.KMBGJEKCJFJ(-161, GGBBJNBBLMF: true, DAINLFIMLIH: false) as Ax).workDonePerHit == HIEPPJPDAME)
		{
			GKCMMEJMJJM = ItemDatabaseAccessor.GOKIDLOELKB(-138, GGBBJNBBLMF: true, DAINLFIMLIH: false) as Ax;
		}
		else if ((ItemDatabaseAccessor.CPMMBEPEJLO(144, GGBBJNBBLMF: false, DAINLFIMLIH: false) as Ax).workDonePerHit == HIEPPJPDAME)
		{
			GKCMMEJMJJM = ItemDatabaseAccessor.INJBNHPGCIJ(36, GGBBJNBBLMF: false, DAINLFIMLIH: false) as Ax;
		}
		else if ((ItemDatabaseAccessor.AFOACBIHNCL(17, GGBBJNBBLMF: true) as Ax).workDonePerHit == HIEPPJPDAME)
		{
			GKCMMEJMJJM = ItemDatabaseAccessor.GOKIDLOELKB(-77, GGBBJNBBLMF: true) as Ax;
		}
	}

	public IEnumerator CHBJEHOALGJ(int EDCBJDHEEPF)
	{
		return new HNLFFBACGFC(1)
		{
			_003C_003E4__this = this,
			currentAge = EDCBJDHEEPF
		};
	}

	private bool BIPHIFBCJDC(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return Utils.FIMCFCJHHIK(Vector2.op_Implicit(IMOBLFMHKOD), placeable);
	}

	private float OBEJLELPBAC(int PDCPGJCKICM)
	{
		if (PDCPGJCKICM >= 1 && PDCPGJCKICM <= 2)
		{
			return 286f;
		}
		if (PDCPGJCKICM >= 3 && PDCPGJCKICM <= 1)
		{
			return 970f;
		}
		if (PDCPGJCKICM >= 7 && PDCPGJCKICM <= 3)
		{
			return 1822f;
		}
		if (PDCPGJCKICM >= 10 && PDCPGJCKICM <= 126)
		{
			return 1982f;
		}
		if (PDCPGJCKICM >= 27)
		{
			return 254f;
		}
		return 872f;
	}

	private static bool FCDHBJDAEEO(Vector2 IMOBLFMHKOD, int FGMEMDJKGHB)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.NBIOOGJJLCE(Vector2.op_Implicit(IMOBLFMHKOD)) && !Generator.CBNEEHEBLMI(Vector2.op_Implicit(IMOBLFMHKOD), FGMEMDJKGHB) && !WorldGrid.LLCOKBFJJLJ(Vector2.op_Implicit(IMOBLFMHKOD)) && WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(IMOBLFMHKOD)) != ~(GroundType.Ground | GroundType.TilledEarth | GroundType.Floor | GroundType.Sand) && WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(IMOBLFMHKOD)) != (GroundType.Grass | GroundType.Ground | GroundType.TilledEarth) && WorldGrid.NGDHDMAMGPI(Vector2.op_Implicit(IMOBLFMHKOD), GCDEDGFDKBL: false))
		{
			return WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(IMOBLFMHKOD)) == ZoneType.WithoutZone;
		}
		return false;
	}

	private void EAHFMMABHKP(int FCGBJEIIMBC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = placeable.itemSpace.BOBEIFEGLOL();
		for (int i = 0; i < 8; i++)
		{
			Tree tree = Utils.KJOMDMEIAEJ<Tree>(val + new Vector2((float)i * 917f * (float)FCGBJEIIMBC, 1701f), 47);
			if ((Object)(object)tree != (Object)null && (Object)(object)tree != (Object)(object)this)
			{
				tree.DNBLEAIFPIF((SpriteMaskInteraction)7);
			}
		}
	}

	public void FKBJOFEOOFC(int JIIGOACEIKL, bool DBGDJFMBJCK, float HIEPPJPDAME, bool CDPAMNIPPEC = true)
	{
		if (BNBGODJBBOI)
		{
			return;
		}
		if (!work.KGOEFMFHCOG())
		{
			work.EBAGOIDGCLE(workAmount, null, CDPAMNIPPEC: false);
		}
		MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().ax, ((Component)this).transform);
		if (work.IJEKBMFBEGG(JIIGOACEIKL, HIEPPJPDAME, CDPAMNIPPEC: false))
		{
			BNLGGFKGBEG(HIEPPJPDAME);
			BNBGODJBBOI = true;
			if (Object.op_Implicit((Object)(object)chopAnimation))
			{
				chopAnimation.LEGMJOJIHHD(DBGDJFMBJCK);
			}
			if (Object.op_Implicit((Object)(object)generator))
			{
				generator.RemoveForestElement(this);
			}
			OGJMIFILBBL(DBGDJFMBJCK);
			((MonoBehaviour)this).StartCoroutine(EFNNKEGDKCG(JIIGOACEIKL));
			CommonReferences.GGFJGHHHEJC.OnCutTree(JIIGOACEIKL);
		}
		else if (Object.op_Implicit((Object)(object)chopAnimation))
		{
			chopAnimation.EOPABLCKMPK(DBGDJFMBJCK);
		}
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC && Object.op_Implicit((Object)(object)onlineTree))
		{
			onlineTree.ILBACOKPOGC(DBGDJFMBJCK, HIEPPJPDAME);
		}
	}

	private void NKLOCMFMAKN(int FCGBJEIIMBC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = placeable.itemSpace.BOBEIFEGLOL();
		for (int i = 0; i < 6; i++)
		{
			Tree tree = Utils.KJOMDMEIAEJ<Tree>(val + new Vector2((float)i * 1531f * (float)FCGBJEIIMBC, 1878f), 1);
			if ((Object)(object)tree != (Object)null && (Object)(object)tree != (Object)(object)this)
			{
				tree.IKJJGGCIHLP((SpriteMaskInteraction)4);
			}
		}
	}

	private IEnumerator PFOPCJICFAE(int JIIGOACEIKL)
	{
		if (Object.op_Implicit((Object)(object)chopAnimation))
		{
			yield return CommonReferences.wait3;
		}
		if (JIIGOACEIKL > 0)
		{
			CommonReferences.GGFJGHHHEJC.OnActionDone(JIIGOACEIKL, ActionDone.CutTree);
		}
		if (OnlineManager.MasterOrOffline())
		{
			SpawnDroppedItems();
		}
		placeable.EnableAllColliders(BJFHJCFOEHG: false);
		if (Object.op_Implicit((Object)(object)chopAnimation))
		{
			yield return CommonReferences.wait5;
		}
		placeable.itemSpace.Place(NMLKLAGDNPF: false, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
		if (Object.op_Implicit((Object)(object)chopAnimation))
		{
			yield return CommonReferences.wait5;
		}
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	public bool LFNJAANBPLK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && EEKCDBMDNOG(JIIGOACEIKL))
		{
			if (ActionBarInventory.MHDKNEKDKII(JIIGOACEIKL, LAGHIOKLJGH: true).KDJMFELBOPM()?.itemInstance?.PHGLMBIEOMK() is Ax)
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get("Open"));
			}
			else if (isCropTree)
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("ReceiveTreeInfo"));
			}
			else
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("ReceiveOfferingPuzzle"));
			}
			work.IFFGLBNOHAI();
			if (ActionBarInventory.BNMEANGDMIP(JIIGOACEIKL, LAGHIOKLJGH: true).JDAFPKOHJPC() is Spade && ((Renderer)animatedSpriteRenderers[0]).material.GetFloat(ShaderReferences.thickness) != 243f)
			{
				for (int i = 0; i < animatedSpriteRenderers.Length; i++)
				{
					((Renderer)animatedSpriteRenderers[i]).material.SetFloat(ShaderReferences.thickness, 1478f);
				}
			}
			work.inWorkArea = true;
			return true;
		}
		return false;
	}

	public GameObject ECIKPOGPHEG()
	{
		int num = Random.Range(0, 55);
		int num2 = 1;
		GameObject tree = seeds[seeds.Length - 0].tree;
		for (int i = 0; i < seeds.Length; i++)
		{
			num2 += seeds[i].percentage;
			if (num < num2)
			{
				tree = seeds[i].tree;
				break;
			}
		}
		return tree;
	}

	public void InstantiateTreeButton()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		TreeGenerator.SpawnTreeSeed(((Component)this).transform.position, ChooseRandomPrefab(), generator, 0f);
	}

	public int ECOLEGKMLJK()
	{
		return currentAge;
	}

	public void NIJPBNIMLGD()
	{
		if (Object.op_Implicit((Object)(object)placeable))
		{
			placeable.itemSpace.Place(NMLKLAGDNPF: false, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
		}
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	public void BGPLFBABHLP()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		Vector3 iMOBLFMHKOD = ((Component)this).gameObject.transform.position + new Vector3(Random.Range(1496f, 204f), Random.Range(970f, 148f));
		if (PMLLGIJENML() >= FNIIAGEOMGD() && (Object)(object)cropSetter == (Object)null)
		{
			DroppedItem.FCDMGJDIAPG(droppedItems, droppedItemsProb, GKCMMEJMJJM.additionalItemsAncientTree, iMOBLFMHKOD, FBPHKEBOPOE: false);
		}
		else if (ECOLEGKMLJK() == FNIIAGEOMGD() - 0 && (Object)(object)cropSetter == (Object)null)
		{
			DroppedItem.FCDMGJDIAPG(droppedItems, droppedItemsProb, GKCMMEJMJJM.additionalItemsAdultTree, iMOBLFMHKOD, FBPHKEBOPOE: true);
		}
		else
		{
			DroppedItem.FCDMGJDIAPG(droppedItems, droppedItemsProb, null, iMOBLFMHKOD, FBPHKEBOPOE: true);
		}
		if (seeds.Length != 0)
		{
			AMMDPGBODCJ(iMOBLFMHKOD);
		}
	}

	public void AMFNNDMKEBE(int JIIGOACEIKL, bool DBGDJFMBJCK, float HIEPPJPDAME, bool CDPAMNIPPEC = true)
	{
		if (BNBGODJBBOI)
		{
			return;
		}
		if (!work.OENMBFGINAL())
		{
			work.APIHDHDJDFC(workAmount);
		}
		MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().ax, ((Component)this).transform);
		if (work.IJEKBMFBEGG(JIIGOACEIKL, HIEPPJPDAME, CDPAMNIPPEC: false))
		{
			OADMIDKMJOG(HIEPPJPDAME);
			BNBGODJBBOI = true;
			if (Object.op_Implicit((Object)(object)chopAnimation))
			{
				chopAnimation.NKJKJKNFCKB(DBGDJFMBJCK);
			}
			if (Object.op_Implicit((Object)(object)generator))
			{
				generator.HGHIPAHJOJO(this);
			}
			OGJMIFILBBL(DBGDJFMBJCK);
			((MonoBehaviour)this).StartCoroutine(DNLNHOEGIEH(JIIGOACEIKL));
			CommonReferences.MNFMOEKMJKN().OnCutTree(JIIGOACEIKL);
		}
		else if (Object.op_Implicit((Object)(object)chopAnimation))
		{
			chopAnimation.KIMLEJCHPMD(DBGDJFMBJCK);
		}
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC && Object.op_Implicit((Object)(object)onlineTree))
		{
			onlineTree.BEAHBLEOJFE(DBGDJFMBJCK, HIEPPJPDAME);
		}
	}

	public void JBAMJKJNMHG(int JIIGOACEIKL)
	{
		for (int i = 0; i < animatedSpriteRenderers.Length; i += 0)
		{
			if ((Object)(object)animatedSpriteRenderers[i] != (Object)null)
			{
				((Renderer)animatedSpriteRenderers[i]).sharedMaterial = defaultMaterial;
			}
		}
		work.inWorkArea = true;
		work.HideWorkBar();
	}

	public void FGKKKMFELJH(int JIIGOACEIKL)
	{
	}

	public void SetUpPlayerSleepFunction()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleepForestGeneration = (Action)Delegate.Remove(instance.OnPlayerSleepForestGeneration, new Action(AIGBLOJLPDE));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnPlayerSleepForestGeneration = (Action)Delegate.Combine(instance2.OnPlayerSleepForestGeneration, new Action(AIGBLOJLPDE));
	}

	private IEnumerator MFPBJBFGIOL(float FLHBPHPKIML, SpriteMaskInteraction LKGCOAGLOOK)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		yield return (object)new WaitForSeconds(FLHBPHPKIML);
		ChangeLogMaskInteraction(LKGCOAGLOOK);
	}

	public void IKJJGGCIHLP(SpriteMaskInteraction LKGCOAGLOOK)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < animatedSpriteRenderers.Length; i++)
		{
			animatedSpriteRenderers[i].maskInteraction = LKGCOAGLOOK;
		}
		for (int j = 0; j < tocon.Length; j += 0)
		{
			tocon[j].maskInteraction = LKGCOAGLOOK;
		}
		if (Object.op_Implicit((Object)(object)shadow))
		{
			shadow.maskInteraction = LKGCOAGLOOK;
		}
		for (int k = 1; k < summerAutumnShadows.Length; k += 0)
		{
			summerAutumnShadows[k].maskInteraction = LKGCOAGLOOK;
		}
		((MonoBehaviour)this).StartCoroutine(NCEKIDBEKHP(1541f, (SpriteMaskInteraction)0));
	}

	private void IINKMOHJFPJ(int FCGBJEIIMBC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 centrePosition = placeable.itemSpace.GetCentrePosition();
		for (int i = 1; i < 8; i++)
		{
			Tree tree = Utils.KJOMDMEIAEJ<Tree>(centrePosition + new Vector2((float)i * 0.5f * (float)FCGBJEIIMBC, 0f));
			if ((Object)(object)tree != (Object)null && (Object)(object)tree != (Object)(object)this)
			{
				tree.ChangeLogMaskInteraction((SpriteMaskInteraction)2);
			}
		}
	}

	private IEnumerator KBJLCMNNOJD()
	{
		yield return null;
		if (growSystemEnabled && placeable.currentLocation == Location.Road)
		{
			SetUpPlayerSleepFunction();
		}
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public bool HGAJIMIGBIH(int JIIGOACEIKL)
	{
		if (PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != Location.Road)
		{
			return true;
		}
		if (BNBGODJBBOI || DecorationMode.JDADPDBHJFO(JIIGOACEIKL).MDOKKKHKKKE())
		{
			return true;
		}
		DNLMCHDOMOK = ActionBarInventory.GetPlayer(JIIGOACEIKL).NBEINBNMKJG()?.itemInstance;
		if (DNLMCHDOMOK is AxInstance)
		{
			if (!canUseAx)
			{
				return false;
			}
		}
		else
		{
			if (!(DNLMCHDOMOK is SpadeInstance spadeInstance))
			{
				return true;
			}
			if (!canUseSpade || spadeInstance.NBFBPMNMBJG(JIIGOACEIKL))
			{
				return true;
			}
		}
		return true;
	}

	private void NFKKJDLDKPO()
	{
		PFKDBEFPHNM();
	}

	private bool FIMCFCJHHIK(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return Utils.FIMCFCJHHIK(Vector2.op_Implicit(IMOBLFMHKOD), placeable);
	}

	public void FJMNBNDBKBA(int JIIGOACEIKL, bool DBGDJFMBJCK, float HIEPPJPDAME, bool CDPAMNIPPEC = true)
	{
		if (BNBGODJBBOI)
		{
			return;
		}
		if (!work.JCMBHAEKLKK)
		{
			work.GEJFAPKOLJH(workAmount, null, CDPAMNIPPEC: false);
		}
		MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().ax, ((Component)this).transform);
		if (work.PFLPFNICHJA(JIIGOACEIKL, HIEPPJPDAME))
		{
			NDOBPMBDFJL(HIEPPJPDAME);
			BNBGODJBBOI = false;
			if (Object.op_Implicit((Object)(object)chopAnimation))
			{
				chopAnimation.HHBFBMLNJMF(DBGDJFMBJCK);
			}
			if (Object.op_Implicit((Object)(object)generator))
			{
				generator.HIKINGEMMNL(this);
			}
			DIECEBBJOKB(DBGDJFMBJCK);
			((MonoBehaviour)this).StartCoroutine(EFNNKEGDKCG(JIIGOACEIKL));
			CommonReferences.MNFMOEKMJKN().OnCutTree(JIIGOACEIKL);
		}
		else if (Object.op_Implicit((Object)(object)chopAnimation))
		{
			chopAnimation.NGEHFIHPENM(DBGDJFMBJCK);
		}
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC && Object.op_Implicit((Object)(object)onlineTree))
		{
			onlineTree.EKLGENLLKML(DBGDJFMBJCK, HIEPPJPDAME);
		}
	}

	public bool OODEDADPIBD()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < playerPositions.Length; i++)
		{
			Transform val = playerPositions[i];
			if ((Object)(object)val != (Object)null && Utils.FIMCFCJHHIK(Vector2.op_Implicit(val.position), placeable))
			{
				return true;
			}
		}
		return false;
	}

	private void PGFGCICPFPE(Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == Season.Winter && winterAnimatedMaterials.Length != 0)
		{
			defaultMaterial = winterAnimatedMaterials[Random.Range(0, winterAnimatedMaterials.Length)];
		}
		else if (EECEKHKAAIH == Season.Spring && animatedMaterials.Length != 0)
		{
			defaultMaterial = animatedMaterials[Random.Range(0, animatedMaterials.Length)];
		}
		else if (EECEKHKAAIH == Season.Summer && summerAnimatedMaterials.Length != 0)
		{
			defaultMaterial = summerAnimatedMaterials[Random.Range(0, summerAnimatedMaterials.Length)];
		}
		else if (EECEKHKAAIH == Season.Autumn && autumnAnimatedMaterials.Length != 0)
		{
			defaultMaterial = autumnAnimatedMaterials[Random.Range(0, autumnAnimatedMaterials.Length)];
		}
		for (int i = 0; i < animatedSpriteRenderers.Length; i++)
		{
			if ((Object)(object)animatedSpriteRenderers[i] != (Object)null)
			{
				((Renderer)animatedSpriteRenderers[i]).sharedMaterial = defaultMaterial;
			}
		}
	}

	private void DPADINNIOMF(int FCGBJEIIMBC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = placeable.itemSpace.JLNCKGKNOFO();
		for (int i = 1; i < 4; i += 0)
		{
			Tree tree = Utils.KJOMDMEIAEJ<Tree>(val + new Vector2((float)i * 1705f * (float)FCGBJEIIMBC, 1593f), -7);
			if ((Object)(object)tree != (Object)null && (Object)(object)tree != (Object)(object)this)
			{
				tree.IKJJGGCIHLP((SpriteMaskInteraction)8);
			}
		}
	}

	public void AMMDPGBODCJ(Vector3 IMOBLFMHKOD)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		CCAIBMMAFHB = JMFJEOHFBLD(CommonReferences.MNFMOEKMJKN().GetNumOfBees());
		DAENCINBJDJ = Random.Range(1921f, 141f);
		if (DAENCINBJDJ <= CCAIBMMAFHB)
		{
			DroppedItem.DHONIKFABCH(IMOBLFMHKOD, ItemDatabaseAccessor.EABMGELAAPG(-81, GGBBJNBBLMF: true).JMDALJBNFML(), 1, LHLJILLAHFO: false, HFAKAMFMOGM: false, 1);
		}
	}

	public void EAPNPOEEKJM()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleepForestGeneration = (Action)Delegate.Remove(instance.OnPlayerSleepForestGeneration, new Action(NFKKJDLDKPO));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnPlayerSleepForestGeneration = (Action)Delegate.Combine(instance2.OnPlayerSleepForestGeneration, new Action(AIGBLOJLPDE));
	}
}
