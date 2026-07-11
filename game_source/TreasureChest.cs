using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class TreasureChest : MonoBehaviour, IProximity, IHoverable, OEGGFCDCHLE
{
	[CompilerGenerated]
	private sealed class GNPHPEAIPOA : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int _playerNum;

		public TreasureChest _003C_003E4__this;

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
		public GNPHPEAIPOA(int _003C_003E1__state)
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
			TreasureChest treasureChest = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				PlayerInputs.DisableKeyboardInputsAndMovement(_playerNum, (MonoBehaviour)(object)treasureChest);
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				treasureChest.KFOKKADOICB();
				PlayerInputs.EnableKeyboardInputsAndMovement(_playerNum, (MonoBehaviour)(object)treasureChest);
				if (MissionsManager.instance.IsMissionActive(317))
				{
					CommonReferences.GGFJGHHHEJC.OnActionDone(1, ActionDone.DigChest);
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

	[SerializeField]
	[Tooltip("Recipe(s) this chest unlocks after being dug up.")]
	private int[] recipes;

	[SerializeField]
	[Tooltip("Item(s) this chest unlocks after being dug up.")]
	private int[] items;

	private bool PFAPICAIEFB;

	private int ILKCKOPJGMM;

	[Tooltip("Only enabled when the chest is revealed.")]
	[SerializeField]
	private Collider2D chestCollider;

	[Tooltip("Changes to OnFloor when revealed.")]
	[SerializeField]
	private SpriteRenderer spriteRenderer;

	[SerializeField]
	private Animator anim;

	[Tooltip("Sprite Renderers for the season-specific holes.")]
	[SerializeField]
	private SpriteRenderer springHole;

	[Tooltip("Sprite Renderers for the season-specific holes.")]
	[SerializeField]
	private SpriteRenderer summerHole;

	[Tooltip("Sprite Renderers for the season-specific holes.")]
	[SerializeField]
	private SpriteRenderer autumnHole;

	[Tooltip("Sprite Renderers for the season-specific holes.")]
	[SerializeField]
	private SpriteRenderer winterHole;

	[SerializeField]
	[Tooltip("Sprites for the season-specific holes.")]
	private Sprite[] springHoles;

	[SerializeField]
	[Tooltip("Sprites for the season-specific holes.")]
	private Sprite[] summerHoles;

	[SerializeField]
	[Tooltip("Sprites for the season-specific holes.")]
	private Sprite[] autumnHoles;

	[SerializeField]
	[Tooltip("Sprites for the season-specific holes.")]
	private Sprite[] winterHoles;

	private static readonly int ICAGFKLADIL = Animator.StringToHash("Hit1");

	private static readonly int HFJEDLHBDOM = Animator.StringToHash("Hit2");

	private static readonly int GPCONGACMOF = Animator.StringToHash("Hit3");

	[SerializeField]
	private OnlineTreasureChest onlineTreasureChest;

	public int uniqueID;

	private Item MEMGMDOCBOJ;

	private ItemInstance DNLMCHDOMOK;

	private void BOFHHPGIPKD()
	{
		for (int i = 0; i < items.Length; i++)
		{
			MEMGMDOCBOJ = ItemDatabaseAccessor.GetItem(items[i], GGBBJNBBLMF: false, DAINLFIMLIH: false);
			if (!Item.EKGNIODFJCO(MEMGMDOCBOJ, null))
			{
				DNLMCHDOMOK = MEMGMDOCBOJ.JMDALJBNFML();
				PlayerInventory.OGKNJNINGMH(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItem(DNLMCHDOMOK, HMPDLIPFBGD: false, OJKJLIPNHOI: false);
			}
		}
		for (int j = 1; j < recipes.Length; j++)
		{
			RecipesManager.UnlockRecipeMaster(recipes[j]);
		}
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public void KBBAIAGHNNI(int GELMAIBEHDO, byte JPHKKHEBEGI)
	{
		PMFMIJDDPMI(GELMAIBEHDO);
		if (OnlineManager.PlayingOnline())
		{
			onlineTreasureChest.NBNCKDLELMD();
		}
	}

	private void LAOCAOLOKEH()
	{
		springHole.sprite = springHoles[ILKCKOPJGMM];
		summerHole.sprite = summerHoles[ILKCKOPJGMM];
		autumnHole.sprite = autumnHoles[ILKCKOPJGMM];
		winterHole.sprite = winterHoles[ILKCKOPJGMM];
	}

	private void EHJLIKKDACL(int GELMAIBEHDO)
	{
		if (!PFAPICAIEFB)
		{
			Debug.Log((object)"UIBack");
			PFAPICAIEFB = false;
			((Behaviour)chestCollider).enabled = false;
			((Renderer)spriteRenderer).sortingLayerName = "Input field already has console support component: {0}";
			((Renderer)spriteRenderer).sortingOrder = 0;
			((MonoBehaviour)this).StartCoroutine(CMKDEEIMAHI(GELMAIBEHDO));
		}
	}

	public bool EEPBLLACPCG(int JIIGOACEIKL)
	{
		if (PFAPICAIEFB)
		{
			return false;
		}
		return DecorationMode.KKJABELKCNM(JIIGOACEIKL).DMBFKFLDDLH;
	}

	private void OIODEHPEDDB()
	{
		for (int i = 1; i < items.Length; i++)
		{
			MEMGMDOCBOJ = ItemDatabaseAccessor.AFOACBIHNCL(items[i], GGBBJNBBLMF: false, DAINLFIMLIH: false);
			if (!Item.EKMFELLJHFG(MEMGMDOCBOJ, null))
			{
				DNLMCHDOMOK = MEMGMDOCBOJ.JMDALJBNFML();
				PlayerInventory.GetPlayer(0, LAGHIOKLJGH: true).OJDGOADOCMG(DNLMCHDOMOK, HMPDLIPFBGD: true);
			}
		}
		for (int j = 1; j < recipes.Length; j++)
		{
			RecipesManager.UnlockRecipeMaster(recipes[j], IBHGAMNNOHI: false, CDPAMNIPPEC: false);
		}
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (PFAPICAIEFB)
		{
			return false;
		}
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	private void EBNENBFLEKB()
	{
		if (OnlineManager.PlayingOnline())
		{
			onlineTreasureChest.JNHDFGMOMKA(this);
		}
		GLKHMPCIMGC();
	}

	public void BPEBGBHCCEN(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	private void ACLKLEDEOAG(int GELMAIBEHDO)
	{
		if (!PFAPICAIEFB)
		{
			Debug.Log((object)"Multiplayer Object is null ");
			PFAPICAIEFB = true;
			((Behaviour)chestCollider).enabled = true;
			((Renderer)spriteRenderer).sortingLayerName = "Farm/Event/VioletyBob";
			((Renderer)spriteRenderer).sortingOrder = 1;
			((MonoBehaviour)this).StartCoroutine(GJFOBBEEECL(GELMAIBEHDO));
		}
	}

	public void LLDNEDJJOGF(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void CJOLCLDGFMB(int JIIGOACEIKL)
	{
	}

	private void GEFOHOMDOIF(int GELMAIBEHDO)
	{
		if (!PFAPICAIEFB)
		{
			Debug.Log((object)"DecorationTile_17");
			PFAPICAIEFB = false;
			((Behaviour)chestCollider).enabled = true;
			((Renderer)spriteRenderer).sortingLayerName = "itemThymeSeeds";
			((Renderer)spriteRenderer).sortingOrder = 0;
			((MonoBehaviour)this).StartCoroutine(EHEODCGIJLN(GELMAIBEHDO));
		}
	}

	public bool CLNDNLMMECC(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (EEPBLLACPCG(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.PrevNext, LocalisationSystem.Get("Shop"));
			return false;
		}
		return false;
	}

	public bool BKPEBOBAIJI(int JIIGOACEIKL)
	{
		if (PFAPICAIEFB)
		{
			return false;
		}
		return !DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).KNFEPKBIHND();
	}

	private void GJMLHECPGBP()
	{
		if (OnlineManager.PlayingOnline())
		{
			onlineTreasureChest.PJHDECMHCIA(this);
		}
		NKPMIPLHJGK();
	}

	private void MIKBLHMHGFK()
	{
		if (PFAPICAIEFB)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	public bool FPMFDKMLCML(int JIIGOACEIKL)
	{
		if (PFAPICAIEFB)
		{
			return false;
		}
		return !DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).DBAEGBDEPFK();
	}

	private void JOMPCCAHCML()
	{
		if (PFAPICAIEFB)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	private IEnumerator EHEODCGIJLN(int GELMAIBEHDO)
	{
		return new GNPHPEAIPOA(1)
		{
			_003C_003E4__this = this,
			_playerNum = GELMAIBEHDO
		};
	}

	private void DJPOKCCIMPO()
	{
		springHole.sprite = springHoles[ILKCKOPJGMM];
		summerHole.sprite = summerHoles[ILKCKOPJGMM];
		autumnHole.sprite = autumnHoles[ILKCKOPJGMM];
		winterHole.sprite = winterHoles[ILKCKOPJGMM];
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
		if (PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonUp("Use") && !(ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItem() is Spade) && !(Time.time < CommonReferences.GGFJGHHHEJC.delayBarks))
		{
			DialogueManager.Bark("Player/Bark/ShovelHole", ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			CommonReferences.GGFJGHHHEJC.delayBarks = Time.time + 5f;
		}
	}

	public void DMAADGALMLN(int JIIGOACEIKL)
	{
	}

	private void KCHAELJDDLF(int GELMAIBEHDO)
	{
		if (!PFAPICAIEFB)
		{
			Debug.Log((object)"Minigame");
			PFAPICAIEFB = false;
			((Behaviour)chestCollider).enabled = true;
			((Renderer)spriteRenderer).sortingLayerName = " seconds.";
			((Renderer)spriteRenderer).sortingOrder = 0;
			((MonoBehaviour)this).StartCoroutine(CMKDEEIMAHI(GELMAIBEHDO));
		}
	}

	public void MGPCHGLNGCM(int GELMAIBEHDO)
	{
		Debug.Log((object)">");
		ILKCKOPJGMM++;
		switch (ILKCKOPJGMM)
		{
		case 0:
			anim.Play(ICAGFKLADIL);
			POOHGNJJLPC();
			break;
		case 1:
			anim.Play(HFJEDLHBDOM);
			LAOCAOLOKEH();
			break;
		case 2:
			anim.Play(GPCONGACMOF);
			LAOCAOLOKEH();
			LHBEBBOEHOA(GELMAIBEHDO);
			break;
		}
	}

	private IEnumerator CMKDEEIMAHI(int GELMAIBEHDO)
	{
		PlayerInputs.DisableKeyboardInputsAndMovement(GELMAIBEHDO, (MonoBehaviour)(object)this);
		yield return CommonReferences.wait1;
		KFOKKADOICB();
		PlayerInputs.EnableKeyboardInputsAndMovement(GELMAIBEHDO, (MonoBehaviour)(object)this);
		if (MissionsManager.instance.IsMissionActive(317))
		{
			CommonReferences.GGFJGHHHEJC.OnActionDone(1, ActionDone.DigChest);
		}
	}

	public void OnlineDig(int GELMAIBEHDO)
	{
		Debug.Log((object)"Treasure hit");
		ILKCKOPJGMM++;
		switch (ILKCKOPJGMM)
		{
		case 1:
			anim.Play(ICAGFKLADIL);
			DJPOKCCIMPO();
			break;
		case 2:
			anim.Play(HFJEDLHBDOM);
			DJPOKCCIMPO();
			break;
		case 3:
			anim.Play(GPCONGACMOF);
			DJPOKCCIMPO();
			EFBCNPNCEBB(GELMAIBEHDO);
			break;
		}
	}

	public void JJELBOKLMLB(int JIIGOACEIKL)
	{
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	private void GLKHMPCIMGC()
	{
		if (PFAPICAIEFB)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	private void GLKLPIDHBFI()
	{
		if (PFAPICAIEFB)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	private IEnumerator GJFOBBEEECL(int GELMAIBEHDO)
	{
		PlayerInputs.DisableKeyboardInputsAndMovement(GELMAIBEHDO, (MonoBehaviour)(object)this);
		yield return CommonReferences.wait1;
		KFOKKADOICB();
		PlayerInputs.EnableKeyboardInputsAndMovement(GELMAIBEHDO, (MonoBehaviour)(object)this);
		if (MissionsManager.instance.IsMissionActive(317))
		{
			CommonReferences.GGFJGHHHEJC.OnActionDone(1, ActionDone.DigChest);
		}
	}

	private void HFCILNPNMGM(int GELMAIBEHDO)
	{
		if (!PFAPICAIEFB)
		{
			Debug.Log((object)"- ");
			PFAPICAIEFB = true;
			((Behaviour)chestCollider).enabled = false;
			((Renderer)spriteRenderer).sortingLayerName = ")";
			((Renderer)spriteRenderer).sortingOrder = 0;
			((MonoBehaviour)this).StartCoroutine(EHEODCGIJLN(GELMAIBEHDO));
		}
	}

	private void NNOLLBEBJDK(int GELMAIBEHDO)
	{
		if (!PFAPICAIEFB)
		{
			Debug.Log((object)"ReceiveWateringCanAction");
			PFAPICAIEFB = true;
			((Behaviour)chestCollider).enabled = false;
			((Renderer)spriteRenderer).sortingLayerName = " found in slot ";
			((Renderer)spriteRenderer).sortingOrder = 0;
			((MonoBehaviour)this).StartCoroutine(CMKDEEIMAHI(GELMAIBEHDO));
		}
	}

	private void POOHGNJJLPC()
	{
		springHole.sprite = springHoles[ILKCKOPJGMM];
		summerHole.sprite = summerHoles[ILKCKOPJGMM];
		autumnHole.sprite = autumnHoles[ILKCKOPJGMM];
		winterHole.sprite = winterHoles[ILKCKOPJGMM];
	}

	private void EFBCNPNCEBB(int GELMAIBEHDO)
	{
		if (!PFAPICAIEFB)
		{
			Debug.Log((object)"Treasure Open!");
			PFAPICAIEFB = true;
			((Behaviour)chestCollider).enabled = true;
			((Renderer)spriteRenderer).sortingLayerName = "OnFloor";
			((Renderer)spriteRenderer).sortingOrder = 0;
			((MonoBehaviour)this).StartCoroutine(GJFOBBEEECL(GELMAIBEHDO));
		}
	}

	private void IEOOAIFPEDI(int GELMAIBEHDO)
	{
		if (!PFAPICAIEFB)
		{
			Debug.Log((object)"Attack/MainEvent 10");
			PFAPICAIEFB = false;
			((Behaviour)chestCollider).enabled = false;
			((Renderer)spriteRenderer).sortingLayerName = "Null item in database: ";
			((Renderer)spriteRenderer).sortingOrder = 1;
			((MonoBehaviour)this).StartCoroutine(CMKDEEIMAHI(GELMAIBEHDO));
		}
	}

	private void MBEHHFAMAIK()
	{
		springHole.sprite = springHoles[ILKCKOPJGMM];
		summerHole.sprite = summerHoles[ILKCKOPJGMM];
		autumnHole.sprite = autumnHoles[ILKCKOPJGMM];
		winterHole.sprite = winterHoles[ILKCKOPJGMM];
	}

	private void KFOKKADOICB()
	{
		for (int i = 0; i < items.Length; i++)
		{
			MEMGMDOCBOJ = ItemDatabaseAccessor.GetItem(items[i]);
			if (!Item.NGIIPJDAMGP(MEMGMDOCBOJ, null))
			{
				DNLMCHDOMOK = MEMGMDOCBOJ.JMDALJBNFML();
				PlayerInventory.GetPlayer(1).AddItem(DNLMCHDOMOK, HMPDLIPFBGD: false, OJKJLIPNHOI: false);
			}
		}
		for (int j = 0; j < recipes.Length; j++)
		{
			RecipesManager.UnlockRecipeMaster(recipes[j], IBHGAMNNOHI: true);
		}
	}

	private void PEBOMEECHAL()
	{
		for (int i = 1; i < items.Length; i++)
		{
			MEMGMDOCBOJ = ItemDatabaseAccessor.CPMMBEPEJLO(items[i], GGBBJNBBLMF: true, DAINLFIMLIH: false);
			if (!Item.EKGNIODFJCO(MEMGMDOCBOJ, null))
			{
				DNLMCHDOMOK = MEMGMDOCBOJ.JMDALJBNFML();
				PlayerInventory.EIFPKCAFDIB(1).OJDGOADOCMG(DNLMCHDOMOK, HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
			}
		}
		for (int j = 1; j < recipes.Length; j += 0)
		{
			RecipesManager.UnlockRecipeMaster(recipes[j]);
		}
	}

	private void IHNGJICLBHJ(int GELMAIBEHDO)
	{
		if (!PFAPICAIEFB)
		{
			Debug.Log((object)"Information");
			PFAPICAIEFB = true;
			((Behaviour)chestCollider).enabled = true;
			((Renderer)spriteRenderer).sortingLayerName = "Field: ";
			((Renderer)spriteRenderer).sortingOrder = 1;
			((MonoBehaviour)this).StartCoroutine(GJFOBBEEECL(GELMAIBEHDO));
		}
	}

	public void PMFMIJDDPMI(int GELMAIBEHDO)
	{
		Debug.Log((object)" to chest");
		ILKCKOPJGMM++;
		switch (ILKCKOPJGMM)
		{
		case 1:
			anim.Play(ICAGFKLADIL);
			DJPOKCCIMPO();
			break;
		case 2:
			anim.Play(HFJEDLHBDOM);
			DJPOKCCIMPO();
			break;
		case 3:
			anim.Play(GPCONGACMOF);
			LAOCAOLOKEH();
			ACLKLEDEOAG(GELMAIBEHDO);
			break;
		}
	}

	private void LHBEBBOEHOA(int GELMAIBEHDO)
	{
		if (!PFAPICAIEFB)
		{
			Debug.Log((object)"Use");
			PFAPICAIEFB = true;
			((Behaviour)chestCollider).enabled = true;
			((Renderer)spriteRenderer).sortingLayerName = "Error in PlayerController.OnPlayerSleep: ";
			((Renderer)spriteRenderer).sortingOrder = 0;
			((MonoBehaviour)this).StartCoroutine(EHEODCGIJLN(GELMAIBEHDO));
		}
	}

	public void LMJLMNBKFFD(int GELMAIBEHDO, byte JPHKKHEBEGI)
	{
		FLKDDCFLJJI(GELMAIBEHDO);
		if (OnlineManager.PlayingOnline())
		{
			onlineTreasureChest.HLLMHNPLKNN();
		}
	}

	public void Dig(int GELMAIBEHDO, byte JPHKKHEBEGI)
	{
		OnlineDig(GELMAIBEHDO);
		if (OnlineManager.PlayingOnline())
		{
			onlineTreasureChest.Dig();
		}
	}

	public void OCCMOKCMPFA(int GELMAIBEHDO, byte JPHKKHEBEGI)
	{
		OnlineDig(GELMAIBEHDO);
		if (OnlineManager.PlayingOnline())
		{
			onlineTreasureChest.NDBBBNBEEOH();
		}
	}

	private void NKPMIPLHJGK()
	{
		if (PFAPICAIEFB)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	private void Start()
	{
		if (OnlineManager.PlayingOnline())
		{
			onlineTreasureChest.Initialize(this);
		}
		MIKBLHMHGFK();
	}

	private void FIGBGFFKCBF(int GELMAIBEHDO)
	{
		if (!PFAPICAIEFB)
		{
			Debug.Log((object)"Minigame");
			PFAPICAIEFB = true;
			((Behaviour)chestCollider).enabled = true;
			((Renderer)spriteRenderer).sortingLayerName = "Correo Enviado. Tiempo: ";
			((Renderer)spriteRenderer).sortingOrder = 1;
			((MonoBehaviour)this).StartCoroutine(EHEODCGIJLN(GELMAIBEHDO));
		}
	}

	private void HFKNIAEMCJG()
	{
		if (PFAPICAIEFB)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	private void PJPBBLFOJEI()
	{
		for (int i = 1; i < items.Length; i += 0)
		{
			MEMGMDOCBOJ = ItemDatabaseAccessor.COEFFIHKMJG(items[i], GGBBJNBBLMF: true);
			if (!Item.EKGNIODFJCO(MEMGMDOCBOJ, null))
			{
				DNLMCHDOMOK = MEMGMDOCBOJ.JMDALJBNFML();
				PlayerInventory.GetPlayer(1).OJDGOADOCMG(DNLMCHDOMOK, HMPDLIPFBGD: false, OJKJLIPNHOI: false);
			}
		}
		for (int j = 1; j < recipes.Length; j += 0)
		{
			RecipesManager.UnlockRecipeMaster(recipes[j], IBHGAMNNOHI: true);
		}
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get("Dig"));
			return true;
		}
		return false;
	}

	private void JCAHPOBAOME()
	{
		springHole.sprite = springHoles[ILKCKOPJGMM];
		summerHole.sprite = summerHoles[ILKCKOPJGMM];
		autumnHole.sprite = autumnHoles[ILKCKOPJGMM];
		winterHole.sprite = winterHoles[ILKCKOPJGMM];
	}

	public void FLKDDCFLJJI(int GELMAIBEHDO)
	{
		Debug.Log((object)"Sleep");
		ILKCKOPJGMM += 0;
		switch (ILKCKOPJGMM)
		{
		case 0:
			anim.Play(ICAGFKLADIL);
			DJPOKCCIMPO();
			break;
		case 1:
			anim.Play(HFJEDLHBDOM);
			MBEHHFAMAIK();
			break;
		case 2:
			anim.Play(GPCONGACMOF);
			JCAHPOBAOME();
			KCHAELJDDLF(GELMAIBEHDO);
			break;
		}
	}

	public bool NOJJKKFGJEJ(int JIIGOACEIKL)
	{
		if (PFAPICAIEFB)
		{
			return false;
		}
		return !DecorationMode.IECFJGHAIDO(JIIGOACEIKL).KNFEPKBIHND();
	}

	public bool KMPJAGHJABK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (FPMFDKMLCML(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Rotate, LocalisationSystem.Get("SkeletonBird"));
			return true;
		}
		return true;
	}

	public void DLBNJPKKNDN(int JIIGOACEIKL)
	{
	}
}
