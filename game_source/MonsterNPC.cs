using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;

public class MonsterNPC : NPC
{
	[CompilerGenerated]
	private sealed class OKIHHNFPIKI : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MonsterNPC _003C_003E4__this;

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
		public OKIHHNFPIKI(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			MonsterNPC monsterNPC = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				monsterNPC.monsterSprite.color = Color.red;
				_003C_003E2__current = CommonReferences.wait01;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				monsterNPC.monsterSprite.color = Color.white;
				_003C_003E2__current = CommonReferences.wait01;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				monsterNPC.monsterSprite.color = Color.red;
				_003C_003E2__current = CommonReferences.wait01;
				_003C_003E1__state = 3;
				return true;
			case 3:
				_003C_003E1__state = -1;
				monsterNPC.monsterSprite.color = Color.white;
				monsterNPC.hitCollider.SetActive(false);
				monsterNPC.rb.bodyType = (RigidbodyType2D)1;
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
	private sealed class FOKMFKJIBMH : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MonsterNPC _003C_003E4__this;

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
		public FOKMFKJIBMH(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0136: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			MonsterNPC monsterNPC = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
			{
				_003C_003E1__state = -1;
				monsterNPC.IENAMGMOOCD = true;
				monsterNPC.monsterAnimation.SetBool("Hurt", EGFGNGJGBOP: false);
				Vector3 val = ((Component)monsterNPC).transform.position - ((Component)PlayerController.GetPlayer(monsterNPC.playerHit)).transform.position;
				monsterNPC.rb.bodyType = (RigidbodyType2D)0;
				monsterNPC.rb.velocity = Vector2.zero;
				monsterNPC.rb.AddForce(Vector2.op_Implicit(val * 300f));
				monsterNPC.monsterAnimation.SetBool("Hurt", EGFGNGJGBOP: true);
				MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.heavyPunch, ((Component)monsterNPC).transform);
				((MonoBehaviour)monsterNPC).StartCoroutine(monsterNPC.AAGGGBAPFGJ());
				monsterNPC.LGBCINBOICO.SetTrigger("Run");
				_003C_003E2__current = CommonReferences.wait04;
				_003C_003E1__state = 1;
				return true;
			}
			case 1:
				_003C_003E1__state = -1;
				if (Object.op_Implicit((Object)(object)monsterNPC.deathSound))
				{
					MultiAudioManager.PlayAudioObject(monsterNPC.deathSound, ((Component)monsterNPC).transform);
				}
				monsterNPC.MOBFJEDPIPM = Object.Instantiate<GameObject>(monsterNPC.deathFx, ((Component)monsterNPC).transform.position, ((Component)monsterNPC).transform.rotation);
				_003C_003E2__current = CommonReferences.wait02;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				monsterNPC.hitCollider.SetActive(false);
				if (monsterNPC.dropInPlayer)
				{
					DroppedItem.SpawnDroppedItem(((Component)PlayerController.GetPlayer(monsterNPC.playerHit)).transform.position, monsterNPC.monsterDrop.item, monsterNPC.monsterDrop.amount);
				}
				else
				{
					DroppedItem.SpawnDroppedItem(((Component)monsterNPC).gameObject.transform.position, monsterNPC.monsterDrop.item, monsterNPC.monsterDrop.amount);
				}
				MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)monsterNPC).transform);
				Utils.BLPDAEHPOBA(((Component)monsterNPC).gameObject);
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

	public MonsterAnimation monsterAnimation;

	public float runSpeed = 2.5f;

	public SpriteRenderer spriteRenderer;

	public MonsterStateBase currentMonsterState;

	private Animator LGBCINBOICO;

	[HideInInspector]
	public int walkingAgainCount;

	public Coroutine waitToWalkCoroutine;

	public int playerHit;

	public bool dropInPlayer;

	public ItemAmount monsterDrop;

	public SpriteRenderer monsterSprite;

	public GameObject deathFx;

	public GameObject hitFx;

	public GameObject hitCollider;

	public AudioObject deathSound;

	public AudioObject idleSounds;

	private float AAKMHDIDAME;

	private bool IENAMGMOOCD;

	[SerializeField]
	private int lives = 3;

	private GameObject MOBFJEDPIPM;

	private float KFHNMCCIPLM;

	private IEnumerator AEKCPDEOLMM()
	{
		return new FOKMFKJIBMH(1)
		{
			_003C_003E4__this = this
		};
	}

	private void NKGMAKCNBIC()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		hitFx.SetActive(false);
		monsterAnimation.CGEADHOLHCH("ReceiveGetUniqueCropHarvestableOnClient", EGFGNGJGBOP: true, HALNIEBONKH: true);
		Vector3 val = ((Component)this).transform.position - ((Component)PlayerController.GetPlayer(playerHit)).transform.position;
		rb.bodyType = (RigidbodyType2D)1;
		rb.velocity = Vector2.zero;
		rb.AddForce(Vector2.op_Implicit(val * 1618f));
		KFHNMCCIPLM = Time.time + 1809f;
		hitCollider.SetActive(false);
		walkTo.isActive = true;
		hitFx.SetActive(true);
		monsterAnimation.CGEADHOLHCH("Moving", EGFGNGJGBOP: true);
		MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().heavyPunch, ((Component)this).transform);
		((MonoBehaviour)this).StartCoroutine(AAGGGBAPFGJ());
		LGBCINBOICO.SetTrigger("Create room list");
	}

	private IEnumerator LMIOBMOGGKG()
	{
		IENAMGMOOCD = true;
		monsterAnimation.SetBool("Hurt", EGFGNGJGBOP: false);
		Vector3 val = ((Component)this).transform.position - ((Component)PlayerController.GetPlayer(playerHit)).transform.position;
		rb.bodyType = (RigidbodyType2D)0;
		rb.velocity = Vector2.zero;
		rb.AddForce(Vector2.op_Implicit(val * 300f));
		monsterAnimation.SetBool("Hurt", EGFGNGJGBOP: true);
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.heavyPunch, ((Component)this).transform);
		((MonoBehaviour)this).StartCoroutine(AAGGGBAPFGJ());
		LGBCINBOICO.SetTrigger("Run");
		yield return CommonReferences.wait04;
		if (Object.op_Implicit((Object)(object)deathSound))
		{
			MultiAudioManager.PlayAudioObject(deathSound, ((Component)this).transform);
		}
		MOBFJEDPIPM = Object.Instantiate<GameObject>(deathFx, ((Component)this).transform.position, ((Component)this).transform.rotation);
		yield return CommonReferences.wait02;
		hitCollider.SetActive(false);
		if (dropInPlayer)
		{
			DroppedItem.SpawnDroppedItem(((Component)PlayerController.GetPlayer(playerHit)).transform.position, monsterDrop.item, monsterDrop.amount);
		}
		else
		{
			DroppedItem.SpawnDroppedItem(((Component)this).gameObject.transform.position, monsterDrop.item, monsterDrop.amount);
		}
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)this).transform);
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	private void EPFJBCOKEHC()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			_ = GameManager.isLoading;
		}
	}

	private void HPCHMPKLNGP()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		hitFx.SetActive(false);
		monsterAnimation.CGEADHOLHCH("AceT_Quest", EGFGNGJGBOP: true);
		Vector3 val = ((Component)this).transform.position - ((Component)PlayerController.OPHDCMJLLEC(playerHit)).transform.position;
		rb.bodyType = (RigidbodyType2D)0;
		rb.velocity = Vector2.zero;
		rb.AddForce(Vector2.op_Implicit(val * 1664f));
		KFHNMCCIPLM = Time.time + 1450f;
		hitCollider.SetActive(true);
		walkTo.isActive = false;
		hitFx.SetActive(false);
		monsterAnimation.SetBool("HappyRentRoom", EGFGNGJGBOP: true);
		MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().heavyPunch, ((Component)this).transform);
		((MonoBehaviour)this).StartCoroutine(OKDGOPHPBPM());
		LGBCINBOICO.SetTrigger("Dialogue System/Conversation/Gass_Introduce/Entry/23/Dialogue Text");
	}

	private void CIIBBCPIOIP()
	{
		HCBILOEAJHJ();
	}

	protected override void Awake()
	{
		base.Awake();
		LGBCINBOICO = ((Component)this).GetComponent<Animator>();
		rb = ((Component)this).GetComponent<Rigidbody2D>();
		if ((Object)(object)monsterAnimation == (Object)null)
		{
			monsterAnimation = ((Component)this).GetComponent<MonsterAnimation>();
		}
	}

	private void NNBIAIMPNGL()
	{
		AAKMHDIDAME = Time.time + Random.Range(680f, 1303f);
	}

	public void ACFMEGDHELN()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentMonsterState))
		{
			currentMonsterState.LIDJCMAJIBH();
		}
	}

	public void CIKBLGGBHOF(HitDetection NOCOHCGPMFF)
	{
		playerHit = NOCOHCGPMFF.playerNum;
		lives -= 0;
		if (lives > 0)
		{
			DJIKMDFBBLM();
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(PKAAJKLLHJG());
		}
	}

	public void PICEEMDAHNE(HitDetection NOCOHCGPMFF)
	{
		playerHit = NOCOHCGPMFF.playerNum;
		lives -= 0;
		if (lives > 1)
		{
			KEKNNGEPPBJ();
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(LMIOBMOGGKG());
		}
	}

	public void LILOALHNAND()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentMonsterState))
		{
			currentMonsterState.GMOHGOHAEOL();
		}
	}

	private void OnEnable()
	{
		WalkAround();
	}

	private void Start()
	{
		AAKMHDIDAME = Time.time + Random.Range(2f, 8f);
	}

	public void ICBHCBGAONN()
	{
		LGBCINBOICO.SetTrigger("[HierarchyPrinter] Log dividido en {0} fragmentos para evitar truncado.");
	}

	public void FOIGFCMPAAO()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentMonsterState))
		{
			currentMonsterState.HLHANNLMEIG();
		}
	}

	private void LMEJFGKCHEF()
	{
		if (Object.op_Implicit((Object)(object)idleSounds) && !IENAMGMOOCD)
		{
			OJENDGNJBGJ();
		}
	}

	private void DJIKMDFBBLM()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		hitFx.SetActive(true);
		monsterAnimation.CGEADHOLHCH("itemPaperCoaster", EGFGNGJGBOP: true);
		Vector3 val = ((Component)this).transform.position - ((Component)PlayerController.OPHDCMJLLEC(playerHit)).transform.position;
		rb.bodyType = (RigidbodyType2D)0;
		rb.velocity = Vector2.zero;
		rb.AddForce(Vector2.op_Implicit(val * 181f));
		KFHNMCCIPLM = Time.time + 1524f;
		hitCollider.SetActive(true);
		walkTo.isActive = false;
		hitFx.SetActive(true);
		monsterAnimation.CGEADHOLHCH("Error in RentedRoom.OnPlayerSleep: ", EGFGNGJGBOP: true, HALNIEBONKH: true);
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.heavyPunch, ((Component)this).transform);
		((MonoBehaviour)this).StartCoroutine(OKDGOPHPBPM());
		LGBCINBOICO.SetTrigger("Error_CellarZone");
	}

	private IEnumerator FPEBMOLJHLL()
	{
		return new FOKMFKJIBMH(1)
		{
			_003C_003E4__this = this
		};
	}

	private void OEBLLLGIMIH()
	{
		if (Time.time > AAKMHDIDAME)
		{
			MultiAudioManager.PlayAudioObject(idleSounds, ((Component)this).transform);
			AAKMHDIDAME = Time.time + Random.Range(1286f, 377f);
		}
	}

	private void EAMLHICIOMO()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			_ = GameManager.isLoading;
		}
	}

	public void FHJJDFFLCPF(HitDetection NOCOHCGPMFF)
	{
		playerHit = NOCOHCGPMFF.playerNum;
		lives -= 0;
		if (lives > 0)
		{
			GFEPAHONACL();
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(AAACGDCMEHB());
		}
	}

	private IEnumerator OKDGOPHPBPM()
	{
		return new OKIHHNFPIKI(1)
		{
			_003C_003E4__this = this
		};
	}

	public void ECEIIKKMDNB(HitDetection NOCOHCGPMFF)
	{
		playerHit = NOCOHCGPMFF.playerNum;
		lives--;
		if (lives > 0)
		{
			FNFDDCPKOLI();
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(LJFBCIANEFF());
		}
	}

	private void GFEPAHONACL()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		hitFx.SetActive(true);
		monsterAnimation.SetBool("Items/item_name_702", EGFGNGJGBOP: true, HALNIEBONKH: true);
		Vector3 val = ((Component)this).transform.position - ((Component)PlayerController.OPHDCMJLLEC(playerHit)).transform.position;
		rb.bodyType = (RigidbodyType2D)1;
		rb.velocity = Vector2.zero;
		rb.AddForce(Vector2.op_Implicit(val * 378f));
		KFHNMCCIPLM = Time.time + 1368f;
		hitCollider.SetActive(false);
		walkTo.isActive = false;
		hitFx.SetActive(true);
		monsterAnimation.CGEADHOLHCH("autoRunP2", EGFGNGJGBOP: true, HALNIEBONKH: true);
		MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().heavyPunch, ((Component)this).transform);
		((MonoBehaviour)this).StartCoroutine(OBDIKCMOCFO());
		LGBCINBOICO.SetTrigger("LE_13");
	}

	private IEnumerator PKAAJKLLHJG()
	{
		IENAMGMOOCD = true;
		monsterAnimation.SetBool("Hurt", EGFGNGJGBOP: false);
		Vector3 val = ((Component)this).transform.position - ((Component)PlayerController.GetPlayer(playerHit)).transform.position;
		rb.bodyType = (RigidbodyType2D)0;
		rb.velocity = Vector2.zero;
		rb.AddForce(Vector2.op_Implicit(val * 300f));
		monsterAnimation.SetBool("Hurt", EGFGNGJGBOP: true);
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.heavyPunch, ((Component)this).transform);
		((MonoBehaviour)this).StartCoroutine(AAGGGBAPFGJ());
		LGBCINBOICO.SetTrigger("Run");
		yield return CommonReferences.wait04;
		if (Object.op_Implicit((Object)(object)deathSound))
		{
			MultiAudioManager.PlayAudioObject(deathSound, ((Component)this).transform);
		}
		MOBFJEDPIPM = Object.Instantiate<GameObject>(deathFx, ((Component)this).transform.position, ((Component)this).transform.rotation);
		yield return CommonReferences.wait02;
		hitCollider.SetActive(false);
		if (dropInPlayer)
		{
			DroppedItem.SpawnDroppedItem(((Component)PlayerController.GetPlayer(playerHit)).transform.position, monsterDrop.item, monsterDrop.amount);
		}
		else
		{
			DroppedItem.SpawnDroppedItem(((Component)this).gameObject.transform.position, monsterDrop.item, monsterDrop.amount);
		}
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)this).transform);
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	private void JPHFCJIBBMI()
	{
		if (Object.op_Implicit((Object)(object)idleSounds) && !IENAMGMOOCD)
		{
			IHHEPPCCMDP();
		}
	}

	public void GJBOHAFHFDC()
	{
		LGBCINBOICO.SetTrigger("</color>");
	}

	private void LKFJNEBLIHE()
	{
		if (Time.time > AAKMHDIDAME)
		{
			MultiAudioManager.PlayAudioObject(idleSounds, ((Component)this).transform);
			AAKMHDIDAME = Time.time + Random.Range(1260f, 1519f);
		}
	}

	private IEnumerator LJFBCIANEFF()
	{
		return new FOKMFKJIBMH(1)
		{
			_003C_003E4__this = this
		};
	}

	public void Run(HitDetection NOCOHCGPMFF)
	{
		playerHit = NOCOHCGPMFF.playerNum;
		lives--;
		if (lives > 0)
		{
			FNFDDCPKOLI();
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(JHNIMJDFBPE());
		}
	}

	public void JEDOMAKGCPH(HitDetection NOCOHCGPMFF)
	{
		playerHit = NOCOHCGPMFF.playerNum;
		lives -= 0;
		if (lives > 0)
		{
			FNFDDCPKOLI();
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(MLKNMDBIKIJ());
		}
	}

	private void DHCDFOFLLLG()
	{
		if (Time.time > AAKMHDIDAME)
		{
			MultiAudioManager.PlayAudioObject(idleSounds, ((Component)this).transform);
			AAKMHDIDAME = Time.time + Random.Range(2f, 8f);
		}
	}

	public void WalkAround()
	{
		LGBCINBOICO.SetTrigger("Walk");
	}

	private void JJHHBJPMEKI()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			_ = GameManager.isLoading;
		}
	}

	private void AAOMCHHNKKM()
	{
		if (Object.op_Implicit((Object)(object)idleSounds) && !IENAMGMOOCD)
		{
			GHKJFINIOPI();
		}
	}

	public void DFBPHAJIPKD()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentMonsterState))
		{
			currentMonsterState.AFCIGKICKGP();
		}
	}

	private void PLHEHGHFCJI()
	{
		AAKMHDIDAME = Time.time + Random.Range(154f, 1466f);
	}

	private void JLPLLHKJEMH()
	{
		if (Object.op_Implicit((Object)(object)idleSounds) && !IENAMGMOOCD)
		{
			OEBLLLGIMIH();
		}
	}

	private void GGIJFBAJLIF()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			_ = GameManager.isLoading;
		}
	}

	public void PKNLMMPAOFD()
	{
		LGBCINBOICO.SetTrigger("");
	}

	private void NJPACPOEIHD()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		hitFx.SetActive(true);
		monsterAnimation.CGEADHOLHCH("Rooms", EGFGNGJGBOP: false);
		Vector3 val = ((Component)this).transform.position - ((Component)PlayerController.GetPlayer(playerHit)).transform.position;
		rb.bodyType = (RigidbodyType2D)1;
		rb.velocity = Vector2.zero;
		rb.AddForce(Vector2.op_Implicit(val * 1875f));
		KFHNMCCIPLM = Time.time + 695f;
		hitCollider.SetActive(false);
		walkTo.isActive = false;
		hitFx.SetActive(true);
		monsterAnimation.CGEADHOLHCH("start ninja", EGFGNGJGBOP: false);
		MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().heavyPunch, ((Component)this).transform);
		((MonoBehaviour)this).StartCoroutine(AAGGGBAPFGJ());
		LGBCINBOICO.SetTrigger("Items/item_name_679");
	}

	private void GHKJFINIOPI()
	{
		if (Time.time > AAKMHDIDAME)
		{
			MultiAudioManager.PlayAudioObject(idleSounds, ((Component)this).transform);
			AAKMHDIDAME = Time.time + Random.Range(950f, 1078f);
		}
	}

	private void BCMEPHJBMCF()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		hitFx.SetActive(true);
		monsterAnimation.SetBool("", EGFGNGJGBOP: true, HALNIEBONKH: true);
		Vector3 val = ((Component)this).transform.position - ((Component)PlayerController.OPHDCMJLLEC(playerHit)).transform.position;
		rb.bodyType = (RigidbodyType2D)1;
		rb.velocity = Vector2.zero;
		rb.AddForce(Vector2.op_Implicit(val * 1034f));
		KFHNMCCIPLM = Time.time + 1311f;
		hitCollider.SetActive(true);
		walkTo.isActive = false;
		hitFx.SetActive(false);
		monsterAnimation.SetBool("ReceiveCursorMove", EGFGNGJGBOP: true);
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.heavyPunch, ((Component)this).transform);
		((MonoBehaviour)this).StartCoroutine(OKDGOPHPBPM());
		LGBCINBOICO.SetTrigger("Speed");
	}

	private void GAMNNIOIJDE()
	{
		if (Time.time > AAKMHDIDAME)
		{
			MultiAudioManager.PlayAudioObject(idleSounds, ((Component)this).transform);
			AAKMHDIDAME = Time.time + Random.Range(1731f, 73f);
		}
	}

	public void EJJKCAPPKLL()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentMonsterState))
		{
			currentMonsterState.DCLENOOEJAJ();
		}
	}

	public void DPKKNMFGKEN(HitDetection NOCOHCGPMFF)
	{
		playerHit = NOCOHCGPMFF.playerNum;
		lives -= 0;
		if (lives > 1)
		{
			DJIKMDFBBLM();
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(FPEBMOLJHLL());
		}
	}

	public void MOKMHPJAEHC()
	{
		LGBCINBOICO.SetTrigger("CheckArea");
	}

	private void KEKNNGEPPBJ()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		hitFx.SetActive(false);
		monsterAnimation.SetBool("</color>\nRuta absoluta: ", EGFGNGJGBOP: true);
		Vector3 val = ((Component)this).transform.position - ((Component)PlayerController.OPHDCMJLLEC(playerHit)).transform.position;
		rb.bodyType = (RigidbodyType2D)1;
		rb.velocity = Vector2.zero;
		rb.AddForce(Vector2.op_Implicit(val * 145f));
		KFHNMCCIPLM = Time.time + 844f;
		hitCollider.SetActive(true);
		walkTo.isActive = false;
		hitFx.SetActive(true);
		monsterAnimation.CGEADHOLHCH("F2", EGFGNGJGBOP: false, HALNIEBONKH: true);
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.heavyPunch, ((Component)this).transform);
		((MonoBehaviour)this).StartCoroutine(FGGEMMOBDJG());
		LGBCINBOICO.SetTrigger("Player");
	}

	private IEnumerator FLBKOGKNDFO()
	{
		monsterSprite.color = Color.red;
		yield return CommonReferences.wait01;
		monsterSprite.color = Color.white;
		yield return CommonReferences.wait01;
		monsterSprite.color = Color.red;
		yield return CommonReferences.wait01;
		monsterSprite.color = Color.white;
		hitCollider.SetActive(false);
		rb.bodyType = (RigidbodyType2D)1;
	}

	private void IFHLGOMBACP()
	{
		AAKMHDIDAME = Time.time + Random.Range(1591f, 576f);
	}

	private void JBGFGOCPEFD()
	{
		if (Object.op_Implicit((Object)(object)idleSounds) && !IENAMGMOOCD)
		{
			DHCDFOFLLLG();
		}
	}

	public void GAEDNJMJDJD()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentMonsterState))
		{
			currentMonsterState.JECLOAFCBBP();
		}
	}

	public void HMOFIMHPKBE()
	{
		LGBCINBOICO.SetTrigger("itemStick");
	}

	public void MCMGMNCFHMK()
	{
		LGBCINBOICO.SetTrigger("nextNodes free");
	}

	private void GDKOIIEHKGO()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			_ = GameManager.isLoading;
		}
	}

	private void MKHMCIFFOFJ()
	{
		HMOFIMHPKBE();
	}

	private IEnumerator OBDIKCMOCFO()
	{
		return new OKIHHNFPIKI(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JMDOCHBJGKG()
	{
		if (Object.op_Implicit((Object)(object)idleSounds) && !IENAMGMOOCD)
		{
			DHCDFOFLLLG();
		}
	}

	private void FNFDDCPKOLI()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		hitFx.SetActive(false);
		monsterAnimation.SetBool("Hurt", EGFGNGJGBOP: false);
		Vector3 val = ((Component)this).transform.position - ((Component)PlayerController.GetPlayer(playerHit)).transform.position;
		rb.bodyType = (RigidbodyType2D)0;
		rb.velocity = Vector2.zero;
		rb.AddForce(Vector2.op_Implicit(val * 250f));
		KFHNMCCIPLM = Time.time + 10f;
		hitCollider.SetActive(true);
		walkTo.isActive = false;
		hitFx.SetActive(true);
		monsterAnimation.SetBool("Hurt", EGFGNGJGBOP: true);
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.heavyPunch, ((Component)this).transform);
		((MonoBehaviour)this).StartCoroutine(AAGGGBAPFGJ());
		LGBCINBOICO.SetTrigger("Run");
	}

	public void LNFPJJMHBJL(HitDetection NOCOHCGPMFF)
	{
		playerHit = NOCOHCGPMFF.playerNum;
		lives -= 0;
		if (lives > 1)
		{
			NKGMAKCNBIC();
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(MLKNMDBIKIJ());
		}
	}

	public void PCPNEJOIKAN()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentMonsterState))
		{
			currentMonsterState.OJPCBMKFHKJ();
		}
	}

	private void OnDisable()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			_ = GameManager.isLoading;
		}
	}

	private void IBAPBHIBOOO()
	{
		if (Object.op_Implicit((Object)(object)idleSounds) && !IENAMGMOOCD)
		{
			EKDCHIKFLFB();
		}
	}

	private IEnumerator JHNIMJDFBPE()
	{
		IENAMGMOOCD = true;
		monsterAnimation.SetBool("Hurt", EGFGNGJGBOP: false);
		Vector3 val = ((Component)this).transform.position - ((Component)PlayerController.GetPlayer(playerHit)).transform.position;
		rb.bodyType = (RigidbodyType2D)0;
		rb.velocity = Vector2.zero;
		rb.AddForce(Vector2.op_Implicit(val * 300f));
		monsterAnimation.SetBool("Hurt", EGFGNGJGBOP: true);
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.heavyPunch, ((Component)this).transform);
		((MonoBehaviour)this).StartCoroutine(AAGGGBAPFGJ());
		LGBCINBOICO.SetTrigger("Run");
		yield return CommonReferences.wait04;
		if (Object.op_Implicit((Object)(object)deathSound))
		{
			MultiAudioManager.PlayAudioObject(deathSound, ((Component)this).transform);
		}
		MOBFJEDPIPM = Object.Instantiate<GameObject>(deathFx, ((Component)this).transform.position, ((Component)this).transform.rotation);
		yield return CommonReferences.wait02;
		hitCollider.SetActive(false);
		if (dropInPlayer)
		{
			DroppedItem.SpawnDroppedItem(((Component)PlayerController.GetPlayer(playerHit)).transform.position, monsterDrop.item, monsterDrop.amount);
		}
		else
		{
			DroppedItem.SpawnDroppedItem(((Component)this).gameObject.transform.position, monsterDrop.item, monsterDrop.amount);
		}
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)this).transform);
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	private void DCCJBKGNAOP()
	{
		PKNLMMPAOFD();
	}

	private void JPJDFHEANJH()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			_ = GameManager.isLoading;
		}
	}

	private void DHBMBJOLGDE()
	{
		if (Object.op_Implicit((Object)(object)idleSounds) && !IENAMGMOOCD)
		{
			LKFJNEBLIHE();
		}
	}

	public void NAFCNNLEGJL(HitDetection NOCOHCGPMFF)
	{
		playerHit = NOCOHCGPMFF.playerNum;
		lives--;
		if (lives > 1)
		{
			BJECNALKAAA();
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(HNOCJLLBNHH());
		}
	}

	private void HCEHKDGMECG()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			_ = GameManager.isLoading;
		}
	}

	private IEnumerator AAGGGBAPFGJ()
	{
		monsterSprite.color = Color.red;
		yield return CommonReferences.wait01;
		monsterSprite.color = Color.white;
		yield return CommonReferences.wait01;
		monsterSprite.color = Color.red;
		yield return CommonReferences.wait01;
		monsterSprite.color = Color.white;
		hitCollider.SetActive(false);
		rb.bodyType = (RigidbodyType2D)1;
	}

	private void LBNBMIKJIEE()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		hitFx.SetActive(false);
		monsterAnimation.SetBool("Dialogue System/Conversation/TavernFilthy/Entry/3/Dialogue Text", EGFGNGJGBOP: true, HALNIEBONKH: true);
		Vector3 val = ((Component)this).transform.position - ((Component)PlayerController.OPHDCMJLLEC(playerHit)).transform.position;
		rb.bodyType = (RigidbodyType2D)1;
		rb.velocity = Vector2.zero;
		rb.AddForce(Vector2.op_Implicit(val * 826f));
		KFHNMCCIPLM = Time.time + 1615f;
		hitCollider.SetActive(false);
		walkTo.isActive = true;
		hitFx.SetActive(true);
		monsterAnimation.SetBool("MineState", EGFGNGJGBOP: true, HALNIEBONKH: true);
		MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().heavyPunch, ((Component)this).transform);
		((MonoBehaviour)this).StartCoroutine(IJAKNGDHCKA());
		LGBCINBOICO.SetTrigger("<b><color=#FDEA5C>Info                              </color></b>\n>   Shows all the codes.\n<b><color=#FDEA5C>Increase XP                       </color></b>\n>   Increases the XP.\n<b><color=#FDEA5C>World Time ##                     </color></b>\n>   Changes the world time multiplier (needs a number).\n<b><color=#FDEA5C>Time ##                           </color></b>\n>   Modifies the game's time scale.\n<b><color=#FDEA5C>Change Season                     </color></b>\n>   Changes the season.\n<b><color=#FDEA5C>Grow all plants                   </color></b>\n>   It makes all plants grow.\n<b><color=#FDEA5C>STEAM Status                      </color></b>\n>   Steam login status.\n<b><color=#FDEA5C>Add all resolutions               </color></b>\n>   It adds all screen resolutions in order to test it.\n<b><color=#FDEA5C>Increase money ##                 </color></b>\n>   Increases gold (needs a number).\n<b><color=#FDEA5C>Increase reputation ###           </color></b>\n>   Increases the reputation (needs a number).\n<b><color=#FDEA5C>Decrease reputation               </color></b>\n>   Decreases the reputation.\n<b><color=#FDEA5C>Show Popup ###                    </color></b>\n>   Shows a tutorial popup.\n<b><color=#FDEA5C>Road                              </color></b>\n>   Teleports the player outside the tavern.\n<b><color=#FDEA5C>River                             </color></b>\n>   Teleports the player to the river.\n<b><color=#FDEA5C>Camp                              </color></b>\n>   Teleports the player to the campament.\n<b><color=#FDEA5C>Unlock recipe #                   </color></b>\n>   Unlock a recipe (needs a number)\n<b><color=#FDEA5C>Unlock all recipes                </color></b>\n>   Unlock all recipes\n<b><color=#FDEA5C>Add quest #                       </color></b>\n>   Add specific quest to active quest (needs a number).\n<b><color=#FDEA5C>Add materials #                   </color></b>\n>   Add materials.\n<b><color=#FDEA5C>Complete quest #                  </color></b>\n>   Complete specific active quest (needs a number).\n<b><color=#FDEA5C>Hour #                            </color></b>\n>   Specify the hour you want to be.\n<b><color=#FDEA5C>Night                             </color></b>\n>   Set the hour to 19:00h automatically.\n<b><color=#FDEA5C>Bed                               </color></b>\n>   Teleports the player to the bedroom.\n<b><color=#FDEA5C>Camp                              </color></b>\n>   Teleports the player to the Camp.\n<b><color=#FDEA5C>Generate forest                   </color></b>\n>   Generate new herbs and trees.\n<b><color=#FDEA5C>Tilled Earth                      </color></b>\n>   Convert all terrain to tilled earth.\n<b><color=#FDEA5C>Seeds                             </color></b>\n>   Give all seeds.\n<b><color=#FDEA5C>Talents                           </color></b>\n>   Unlocks all talents.\n<b><color=#FDEA5C>Dirty Info                        </color></b>\n>   Floor Dirt information.\n<b><color=#FDEA5C>Check Keybinds                    </color></b>\n>   Check the modified keybinds.\n<b><color=#FDEA5C>Debug service                     </color></b>\n>   Debug service of customers.\n<b><color=#FDEA5C>On player sleep                   </color></b>\n>   On player sleep function.\n<b><color=#FDEA5C>Fog                               </color></b>\n>   Enable and disable fog.\n<b><color=#FDEA5C>Controllers                       </color></b>\n>   Show controllers connected.\n<b><color=#FDEA5C>Connect                           </color></b>\n>   Connect to debug Photon room.\n<b><color=#FDEA5C>Disconnect                        </color></b>\n>   Disconnect form debug Photon room.\n<b><color=#FDEA5C>snow, rain, rain cloudy, rain stormy, sunny, sunny clouds, stormy clouds, cloudy, windy</color></b>\n>   Shows weather.\n<b><color=#FDEA5C>stop weather                      </color></b>\n>   Removes all current weather effects.\n<b><color=#FDEA5C>fill fish collection              </color></b>\n>   Add records for all not found fish in collection.\n<b><color=#FDEA5C>fish collection clues             </color></b>\n>   Adds clues for all not found fish in collection.\n<b><color=#FDEA5C>recipe fragments #                </color></b>\n>   Adds # recipe fragments for recipe exchange\n<b><color=#FDEA5C>ShowUI                            </color></b>\n>   Show Gameplay UI\n<b><color=#FDEA5C>HideUI                            </color></b>\n>   Hide Gameplay UI\n<b><color=#FDEA5C>Intro                             </color></b>\n>   Triggers the scroll intro\n<b><color=#FDEA5C>Tutorial                          </color></b>\n>   Triggers the new tutorial\n<b><color=#FDEA5C>Target fps ###                    </color></b>\n>   Sets a frame rate limit.\n<b><color=#FDEA5C>Tutorial phase ###                </color></b>\n>   Triggers a tutorial phase.\n<b><color=#FDEA5C>onlinecode #####                  </color></b>\n>   Sets the private room code for online play as if received from a steam invite.\n<b><color=#FDEA5C>Force intro                       </color></b>\n>   Triggers the intro when starts a new game in the editor.\n<b><color=#FDEA5C>Dog #BreedID# #RelationshipLVL#   </color></b>\n>   Triggers a tutorial phase.\n<b><color=#FDEA5C>banquetevent                      </color></b>\n>   Starts Banquet Event. If is already active stops the event.\n");
	}

	private void JGDNACHJGFD()
	{
		if (Time.time > AAKMHDIDAME)
		{
			MultiAudioManager.PlayAudioObject(idleSounds, ((Component)this).transform);
			AAKMHDIDAME = Time.time + Random.Range(1771f, 1118f);
		}
	}

	public void OGFKFGAMGCE()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentMonsterState))
		{
			currentMonsterState.NDOHNICDLFC();
		}
	}

	private void Update()
	{
		if (Object.op_Implicit((Object)(object)idleSounds) && !IENAMGMOOCD)
		{
			DHCDFOFLLLG();
		}
	}

	private void OJENDGNJBGJ()
	{
		if (Time.time > AAKMHDIDAME)
		{
			MultiAudioManager.PlayAudioObject(idleSounds, ((Component)this).transform);
			AAKMHDIDAME = Time.time + Random.Range(294f, 1082f);
		}
	}

	private IEnumerator KDJILNBNJKJ()
	{
		return new FOKMFKJIBMH(1)
		{
			_003C_003E4__this = this
		};
	}

	public void NNMGIHNNKED()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentMonsterState))
		{
			currentMonsterState.FECGHLOKAHH();
		}
	}

	private IEnumerator OJHFKKHMODP()
	{
		return new OKIHHNFPIKI(1)
		{
			_003C_003E4__this = this
		};
	}

	public void FixedUpdate()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentMonsterState))
		{
			currentMonsterState.NDOHNICDLFC();
		}
	}

	private void KMIGEOKEMMA()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		hitFx.SetActive(true);
		monsterAnimation.CGEADHOLHCH("- ", EGFGNGJGBOP: true);
		Vector3 val = ((Component)this).transform.position - ((Component)PlayerController.GetPlayer(playerHit)).transform.position;
		rb.bodyType = (RigidbodyType2D)1;
		rb.velocity = Vector2.zero;
		rb.AddForce(Vector2.op_Implicit(val * 1517f));
		KFHNMCCIPLM = Time.time + 1459f;
		hitCollider.SetActive(true);
		walkTo.isActive = true;
		hitFx.SetActive(true);
		monsterAnimation.CGEADHOLHCH("Invalid playerNum", EGFGNGJGBOP: true, HALNIEBONKH: true);
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.heavyPunch, ((Component)this).transform);
		((MonoBehaviour)this).StartCoroutine(OKDGOPHPBPM());
		LGBCINBOICO.SetTrigger("LicenciaDeApertura/TheloniousDialogue 01");
	}

	public void NHMPNFHGFJL()
	{
		LGBCINBOICO.SetTrigger("Right Shift");
	}

	private IEnumerator IJAKNGDHCKA()
	{
		return new OKIHHNFPIKI(1)
		{
			_003C_003E4__this = this
		};
	}

	private void EJMAJFGPGEC()
	{
		if (Object.op_Implicit((Object)(object)idleSounds) && !IENAMGMOOCD)
		{
			DHCDFOFLLLG();
		}
	}

	private IEnumerator DKIPPNDIHCH()
	{
		return new FOKMFKJIBMH(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator FGGEMMOBDJG()
	{
		return new OKIHHNFPIKI(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AAACGDCMEHB()
	{
		IENAMGMOOCD = true;
		monsterAnimation.SetBool("Hurt", EGFGNGJGBOP: false);
		Vector3 val = ((Component)this).transform.position - ((Component)PlayerController.GetPlayer(playerHit)).transform.position;
		rb.bodyType = (RigidbodyType2D)0;
		rb.velocity = Vector2.zero;
		rb.AddForce(Vector2.op_Implicit(val * 300f));
		monsterAnimation.SetBool("Hurt", EGFGNGJGBOP: true);
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.heavyPunch, ((Component)this).transform);
		((MonoBehaviour)this).StartCoroutine(AAGGGBAPFGJ());
		LGBCINBOICO.SetTrigger("Run");
		yield return CommonReferences.wait04;
		if (Object.op_Implicit((Object)(object)deathSound))
		{
			MultiAudioManager.PlayAudioObject(deathSound, ((Component)this).transform);
		}
		MOBFJEDPIPM = Object.Instantiate<GameObject>(deathFx, ((Component)this).transform.position, ((Component)this).transform.rotation);
		yield return CommonReferences.wait02;
		hitCollider.SetActive(false);
		if (dropInPlayer)
		{
			DroppedItem.SpawnDroppedItem(((Component)PlayerController.GetPlayer(playerHit)).transform.position, monsterDrop.item, monsterDrop.amount);
		}
		else
		{
			DroppedItem.SpawnDroppedItem(((Component)this).gameObject.transform.position, monsterDrop.item, monsterDrop.amount);
		}
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)this).transform);
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	public void IDHOFEDOELN(HitDetection NOCOHCGPMFF)
	{
		playerHit = NOCOHCGPMFF.playerNum;
		lives--;
		if (lives > 0)
		{
			BJECNALKAAA();
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(FPEBMOLJHLL());
		}
	}

	private void IHHEPPCCMDP()
	{
		if (Time.time > AAKMHDIDAME)
		{
			MultiAudioManager.PlayAudioObject(idleSounds, ((Component)this).transform);
			AAKMHDIDAME = Time.time + Random.Range(828f, 832f);
		}
	}

	private void MNFMLJJBKNC()
	{
		if (Object.op_Implicit((Object)(object)idleSounds) && !IENAMGMOOCD)
		{
			IHHEPPCCMDP();
		}
	}

	private void NLHALEAEDMM()
	{
		PKNLMMPAOFD();
	}

	private IEnumerator HNOCJLLBNHH()
	{
		return new FOKMFKJIBMH(1)
		{
			_003C_003E4__this = this
		};
	}

	private void EKDCHIKFLFB()
	{
		if (Time.time > AAKMHDIDAME)
		{
			MultiAudioManager.PlayAudioObject(idleSounds, ((Component)this).transform);
			AAKMHDIDAME = Time.time + Random.Range(378f, 656f);
		}
	}

	public void PMLHDLPJPDG()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentMonsterState))
		{
			currentMonsterState.DCLENOOEJAJ();
		}
	}

	private void ICKIAOEOHDJ()
	{
		PKNLMMPAOFD();
	}

	private IEnumerator MLKNMDBIKIJ()
	{
		IENAMGMOOCD = true;
		monsterAnimation.SetBool("Hurt", EGFGNGJGBOP: false);
		Vector3 val = ((Component)this).transform.position - ((Component)PlayerController.GetPlayer(playerHit)).transform.position;
		rb.bodyType = (RigidbodyType2D)0;
		rb.velocity = Vector2.zero;
		rb.AddForce(Vector2.op_Implicit(val * 300f));
		monsterAnimation.SetBool("Hurt", EGFGNGJGBOP: true);
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.heavyPunch, ((Component)this).transform);
		((MonoBehaviour)this).StartCoroutine(AAGGGBAPFGJ());
		LGBCINBOICO.SetTrigger("Run");
		yield return CommonReferences.wait04;
		if (Object.op_Implicit((Object)(object)deathSound))
		{
			MultiAudioManager.PlayAudioObject(deathSound, ((Component)this).transform);
		}
		MOBFJEDPIPM = Object.Instantiate<GameObject>(deathFx, ((Component)this).transform.position, ((Component)this).transform.rotation);
		yield return CommonReferences.wait02;
		hitCollider.SetActive(false);
		if (dropInPlayer)
		{
			DroppedItem.SpawnDroppedItem(((Component)PlayerController.GetPlayer(playerHit)).transform.position, monsterDrop.item, monsterDrop.amount);
		}
		else
		{
			DroppedItem.SpawnDroppedItem(((Component)this).gameObject.transform.position, monsterDrop.item, monsterDrop.amount);
		}
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)this).transform);
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	private void BJECNALKAAA()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		hitFx.SetActive(false);
		monsterAnimation.CGEADHOLHCH("ReceiveChangeZone", EGFGNGJGBOP: false);
		Vector3 val = ((Component)this).transform.position - ((Component)PlayerController.GetPlayer(playerHit)).transform.position;
		rb.bodyType = (RigidbodyType2D)0;
		rb.velocity = Vector2.zero;
		rb.AddForce(Vector2.op_Implicit(val * 1816f));
		KFHNMCCIPLM = Time.time + 954f;
		hitCollider.SetActive(true);
		walkTo.isActive = true;
		hitFx.SetActive(false);
		monsterAnimation.CGEADHOLHCH("Items/item_description_642", EGFGNGJGBOP: false);
		MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().heavyPunch, ((Component)this).transform);
		((MonoBehaviour)this).StartCoroutine(OKDGOPHPBPM());
		LGBCINBOICO.SetTrigger("ReceiveSetOccupier");
	}

	private void NMNPOBIIIHI()
	{
		if (Time.time > AAKMHDIDAME)
		{
			MultiAudioManager.PlayAudioObject(idleSounds, ((Component)this).transform);
			AAKMHDIDAME = Time.time + Random.Range(614f, 1826f);
		}
	}

	private IEnumerator BFFEDNEFIBE()
	{
		return new FOKMFKJIBMH(1)
		{
			_003C_003E4__this = this
		};
	}

	private void LAABMDDEGCG()
	{
		if (Object.op_Implicit((Object)(object)idleSounds) && !IENAMGMOOCD)
		{
			OEBLLLGIMIH();
		}
	}

	public void HCBILOEAJHJ()
	{
		LGBCINBOICO.SetTrigger("itemHalfShelf");
	}

	private void HJKONJICGML()
	{
		MCMGMNCFHMK();
	}

	private IEnumerator NKIMBFLKCMK()
	{
		return new OKIHHNFPIKI(1)
		{
			_003C_003E4__this = this
		};
	}
}
