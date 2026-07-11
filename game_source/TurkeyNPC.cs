using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;

public class TurkeyNPC : NPC
{
	[CompilerGenerated]
	private sealed class HBCDOGNJHCM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TurkeyNPC _003C_003E4__this;

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
		public HBCDOGNJHCM(int _003C_003E1__state)
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
			TurkeyNPC turkeyNPC = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				turkeyNPC.turkeySprite.color = Color.red;
				_003C_003E2__current = CommonReferences.wait01;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				turkeyNPC.turkeySprite.color = Color.white;
				_003C_003E2__current = CommonReferences.wait01;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				turkeyNPC.turkeySprite.color = Color.red;
				_003C_003E2__current = CommonReferences.wait01;
				_003C_003E1__state = 3;
				return true;
			case 3:
				_003C_003E1__state = -1;
				turkeyNPC.turkeySprite.color = Color.white;
				if (OnlineManager.MasterOrOffline())
				{
					turkeyNPC.hitCollider.SetActive(false);
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
	private sealed class HELDHCPLPOJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TurkeyNPC _003C_003E4__this;

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
		public HELDHCPLPOJ(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_010a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0115: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_017f: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			TurkeyNPC turkeyNPC = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				if (OnlineManager.MasterOrOffline())
				{
					turkeyNPC.turkeyAnimation.SetBool(NPC.LHDAIEDAFGL, EGFGNGJGBOP: false);
					Vector3 val = ((Component)turkeyNPC).transform.position - turkeyNPC.hitPosition;
					turkeyNPC.rb.velocity = Vector2.zero;
					turkeyNPC.rb.AddForce(Vector2.op_Implicit(val * 300f));
				}
				turkeyNPC.turkeyAnimation.SetTrigger(NPC.PFGHDNAOKBK);
				if (OnlineManager.PlayingOnline())
				{
					turkeyNPC.onlineTurkey.SendTrigger(OnlineTurkey.TriggerName.Hurt);
				}
				MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.turkey, ((Component)turkeyNPC).transform);
				((MonoBehaviour)turkeyNPC).StartCoroutine(turkeyNPC.AAGGGBAPFGJ());
				if (OnlineManager.MasterOrOffline())
				{
					turkeyNPC.behaviour.SetTrigger(NPC.LHDAIEDAFGL);
				}
				_003C_003E2__current = CommonReferences.wait04;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				turkeyNPC.MOBFJEDPIPM = Object.Instantiate<GameObject>(turkeyNPC.deathFx, ((Component)turkeyNPC).transform.position, ((Component)turkeyNPC).transform.rotation);
				_003C_003E2__current = CommonReferences.wait02;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				if (OnlineManager.MasterOrOffline())
				{
					turkeyNPC.hitCollider.SetActive(false);
					int num2 = turkeyNPC.turkeyDrop.amount;
					if (Random.Range(0, 100) < PerksDatabaseAccessor.GetPlayerPerkValue(3))
					{
						num2++;
					}
					DroppedItem.SpawnDroppedItem(((Component)turkeyNPC).gameObject.transform.position, turkeyNPC.turkeyDrop.item, num2);
					MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)turkeyNPC).transform);
					turkeyNPC.poolObject.ReturnToPool();
				}
				turkeyNPC.BEGCPKOAJCP = null;
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

	public float runSpeed = 2.5f;

	public SpriteRenderer spriteRenderer;

	public Coroutine waitToWalkCoroutine;

	public TurkeyAnimationState turkeyAnimationState;

	public OnlineTurkey onlineTurkey;

	public ItemAmount turkeyDrop;

	public SpriteRenderer turkeySprite;

	public TurkeyAnimation turkeyAnimation;

	public Animator behaviour;

	public PoolObject poolObject;

	public GameObject deathFx;

	public GameObject hitFx;

	public GameObject hitCollider;

	[HideInInspector]
	public TurkeyStateBase currentTurkeyState;

	[HideInInspector]
	public int walkingAgainCount;

	[HideInInspector]
	public Vector3 hitPosition;

	private int PANEOJGCKIO = 3;

	private GameObject MOBFJEDPIPM;

	private Coroutine BEGCPKOAJCP;

	private IEnumerator EJNCBMPKJPC()
	{
		return new HELDHCPLPOJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public void HEDGGNKENPB()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentTurkeyState))
		{
			currentTurkeyState.MLMCJEPPJHA();
		}
	}

	public void BDEDPGDNEJF()
	{
		behaviour.SetTrigger(NPC.AEOKENCHHPL);
	}

	public void KKLHGELALKH(HitDetection NOCOHCGPMFF)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)NOCOHCGPMFF))
		{
			IJFDGKDAEGC(((Component)PlayerController.GetPlayer(NOCOHCGPMFF.playerNum)).transform.position, CDPAMNIPPEC: false);
		}
		else
		{
			IINOENFPAGN(((Component)PlayerController.OPHDCMJLLEC(0)).transform.position, CDPAMNIPPEC: true);
		}
	}

	public void DFBPHAJIPKD()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentTurkeyState))
		{
			currentTurkeyState.EHBJGKOOOFF();
		}
	}

	public bool HIPOJDFNOOB()
	{
		if (turkeyAnimationState.safeMovement)
		{
			return false;
		}
		return false;
	}

	private void GFEPAHONACL()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		hitFx.SetActive(true);
		if (OnlineManager.MasterOrOffline())
		{
			turkeyAnimation.SetBool(NPC.LHDAIEDAFGL, EGFGNGJGBOP: true);
			Vector3 val = ((Component)this).transform.position - hitPosition;
			rb.velocity = Vector2.zero;
			rb.AddForce(Vector2.op_Implicit(val * 832f));
			hitCollider.SetActive(false);
			walkTo.isActive = true;
		}
		hitFx.SetActive(false);
		turkeyAnimation.SetTrigger(NPC.PFGHDNAOKBK, HALNIEBONKH: true);
		if (OnlineManager.PlayingOnline())
		{
			onlineTurkey.JBDJOIACLKJ(OnlineTurkey.TriggerName.Peek);
		}
		MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().turkey, ((Component)this).transform);
		((MonoBehaviour)this).StartCoroutine(MHAPDFLHCEK());
		if (OnlineManager.MasterOrOffline())
		{
			behaviour.SetTrigger(NPC.LHDAIEDAFGL);
		}
	}

	private IEnumerator BPPBODKNDNA()
	{
		turkeySprite.color = Color.red;
		yield return CommonReferences.wait01;
		turkeySprite.color = Color.white;
		yield return CommonReferences.wait01;
		turkeySprite.color = Color.red;
		yield return CommonReferences.wait01;
		turkeySprite.color = Color.white;
		if (OnlineManager.MasterOrOffline())
		{
			hitCollider.SetActive(false);
		}
	}

	public bool DNIGJFCJGHF()
	{
		if (turkeyAnimationState.safeMovement)
		{
			return false;
		}
		return false;
	}

	private IEnumerator FHLHNJHOBOA()
	{
		return new HBCDOGNJHCM(1)
		{
			_003C_003E4__this = this
		};
	}

	public void GMAHMPCJGFN(HitDetection NOCOHCGPMFF)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)NOCOHCGPMFF))
		{
			LJDIKGJKMBD(((Component)PlayerController.OPHDCMJLLEC(NOCOHCGPMFF.playerNum)).transform.position, CDPAMNIPPEC: true);
		}
		else
		{
			KPANGFOLIEK(((Component)PlayerController.OPHDCMJLLEC(0)).transform.position, CDPAMNIPPEC: false);
		}
	}

	private IEnumerator CBAJPAIEDLF()
	{
		turkeySprite.color = Color.red;
		yield return CommonReferences.wait01;
		turkeySprite.color = Color.white;
		yield return CommonReferences.wait01;
		turkeySprite.color = Color.red;
		yield return CommonReferences.wait01;
		turkeySprite.color = Color.white;
		if (OnlineManager.MasterOrOffline())
		{
			hitCollider.SetActive(false);
		}
	}

	private IEnumerator NNIJCPBIBGJ()
	{
		if (OnlineManager.MasterOrOffline())
		{
			turkeyAnimation.SetBool(NPC.LHDAIEDAFGL, EGFGNGJGBOP: false);
			Vector3 val = ((Component)this).transform.position - hitPosition;
			rb.velocity = Vector2.zero;
			rb.AddForce(Vector2.op_Implicit(val * 300f));
		}
		turkeyAnimation.SetTrigger(NPC.PFGHDNAOKBK);
		if (OnlineManager.PlayingOnline())
		{
			onlineTurkey.SendTrigger(OnlineTurkey.TriggerName.Hurt);
		}
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.turkey, ((Component)this).transform);
		((MonoBehaviour)this).StartCoroutine(AAGGGBAPFGJ());
		if (OnlineManager.MasterOrOffline())
		{
			behaviour.SetTrigger(NPC.LHDAIEDAFGL);
		}
		yield return CommonReferences.wait04;
		MOBFJEDPIPM = Object.Instantiate<GameObject>(deathFx, ((Component)this).transform.position, ((Component)this).transform.rotation);
		yield return CommonReferences.wait02;
		if (OnlineManager.MasterOrOffline())
		{
			hitCollider.SetActive(false);
			int num = turkeyDrop.amount;
			if (Random.Range(0, 100) < PerksDatabaseAccessor.GetPlayerPerkValue(3))
			{
				num++;
			}
			DroppedItem.SpawnDroppedItem(((Component)this).gameObject.transform.position, turkeyDrop.item, num);
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)this).transform);
			poolObject.ReturnToPool();
		}
		BEGCPKOAJCP = null;
	}

	private IEnumerator LIPHOPPAOCF()
	{
		return new HBCDOGNJHCM(1)
		{
			_003C_003E4__this = this
		};
	}

	public bool BNCHJPOJOIL()
	{
		if (turkeyAnimationState.safeMovement)
		{
			return false;
		}
		return false;
	}

	public bool LKPCJNPKAGO()
	{
		if (turkeyAnimationState.safeMovement)
		{
			return false;
		}
		return true;
	}

	private void OnDisable()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			_ = GameManager.isLoading;
		}
	}

	private IEnumerator PICBEPOPBPG()
	{
		if (OnlineManager.MasterOrOffline())
		{
			turkeyAnimation.SetBool(NPC.LHDAIEDAFGL, EGFGNGJGBOP: false);
			Vector3 val = ((Component)this).transform.position - hitPosition;
			rb.velocity = Vector2.zero;
			rb.AddForce(Vector2.op_Implicit(val * 300f));
		}
		turkeyAnimation.SetTrigger(NPC.PFGHDNAOKBK);
		if (OnlineManager.PlayingOnline())
		{
			onlineTurkey.SendTrigger(OnlineTurkey.TriggerName.Hurt);
		}
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.turkey, ((Component)this).transform);
		((MonoBehaviour)this).StartCoroutine(AAGGGBAPFGJ());
		if (OnlineManager.MasterOrOffline())
		{
			behaviour.SetTrigger(NPC.LHDAIEDAFGL);
		}
		yield return CommonReferences.wait04;
		MOBFJEDPIPM = Object.Instantiate<GameObject>(deathFx, ((Component)this).transform.position, ((Component)this).transform.rotation);
		yield return CommonReferences.wait02;
		if (OnlineManager.MasterOrOffline())
		{
			hitCollider.SetActive(false);
			int num = turkeyDrop.amount;
			if (Random.Range(0, 100) < PerksDatabaseAccessor.GetPlayerPerkValue(3))
			{
				num++;
			}
			DroppedItem.SpawnDroppedItem(((Component)this).gameObject.transform.position, turkeyDrop.item, num);
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)this).transform);
			poolObject.ReturnToPool();
		}
		BEGCPKOAJCP = null;
	}

	public void KLAKFLIHPNN()
	{
		behaviour.SetTrigger(NPC.AEOKENCHHPL);
	}

	public void HKOFLOPDCEJ()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentTurkeyState))
		{
			currentTurkeyState.LJBAGHCBAGC();
		}
	}

	private void HKIFLGPJDPJ()
	{
		HJCOAJEIABK();
	}

	private void OFDANFDIFAM()
	{
		ENPJHFLIALN();
	}

	public void OBMFCPMFECG(HitDetection NOCOHCGPMFF)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)NOCOHCGPMFF))
		{
			FGBHCDMMNLL(((Component)PlayerController.GetPlayer(NOCOHCGPMFF.playerNum)).transform.position, CDPAMNIPPEC: true);
		}
		else
		{
			FGBHCDMMNLL(((Component)PlayerController.OPHDCMJLLEC(0)).transform.position, CDPAMNIPPEC: false);
		}
	}

	private IEnumerator JHNIMJDFBPE()
	{
		if (OnlineManager.MasterOrOffline())
		{
			turkeyAnimation.SetBool(NPC.LHDAIEDAFGL, EGFGNGJGBOP: false);
			Vector3 val = ((Component)this).transform.position - hitPosition;
			rb.velocity = Vector2.zero;
			rb.AddForce(Vector2.op_Implicit(val * 300f));
		}
		turkeyAnimation.SetTrigger(NPC.PFGHDNAOKBK);
		if (OnlineManager.PlayingOnline())
		{
			onlineTurkey.SendTrigger(OnlineTurkey.TriggerName.Hurt);
		}
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.turkey, ((Component)this).transform);
		((MonoBehaviour)this).StartCoroutine(AAGGGBAPFGJ());
		if (OnlineManager.MasterOrOffline())
		{
			behaviour.SetTrigger(NPC.LHDAIEDAFGL);
		}
		yield return CommonReferences.wait04;
		MOBFJEDPIPM = Object.Instantiate<GameObject>(deathFx, ((Component)this).transform.position, ((Component)this).transform.rotation);
		yield return CommonReferences.wait02;
		if (OnlineManager.MasterOrOffline())
		{
			hitCollider.SetActive(false);
			int num = turkeyDrop.amount;
			if (Random.Range(0, 100) < PerksDatabaseAccessor.GetPlayerPerkValue(3))
			{
				num++;
			}
			DroppedItem.SpawnDroppedItem(((Component)this).gameObject.transform.position, turkeyDrop.item, num);
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)this).transform);
			poolObject.ReturnToPool();
		}
		BEGCPKOAJCP = null;
	}

	public int NPDACNHIAAI()
	{
		return PANEOJGCKIO;
	}

	private void HNOKPGCBLOA()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			_ = GameManager.isLoading;
		}
	}

	public void KPANGFOLIEK(Vector3 DDBOKLAGCDL, bool CDPAMNIPPEC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline() || !CDPAMNIPPEC)
		{
			hitPosition = DDBOKLAGCDL;
			ENJGGOIOHCM(0);
			if (PANEOJGCKIO > 0)
			{
				FNFDDCPKOLI();
			}
			else if (BEGCPKOAJCP == null)
			{
				BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(JHNIMJDFBPE());
			}
			if (OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
			{
				onlineTurkey.MHMGKIJCLCD(DDBOKLAGCDL);
			}
		}
		else
		{
			onlineTurkey.IMKOOOLLAOF(DDBOKLAGCDL);
		}
	}

	public int ENJONALDAHE()
	{
		return PANEOJGCKIO;
	}

	public void GKPIMLNJDLO(int MGNOBNCMDJG, bool CDPAMNIPPEC)
	{
		PANEOJGCKIO = MGNOBNCMDJG;
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineTurkey.CAGMIALCHFL(MGNOBNCMDJG);
		}
	}

	private void IANGDMHMCEL()
	{
		if (OnlineManager.ClientOnline())
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(LGILFFNKNAO));
		}
		else
		{
			PLIFJBMCANA();
		}
		GPIBCICAMFA();
	}

	private void NLHALEAEDMM()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(HKIFLGPJDPJ));
		}
		else
		{
			CPFDLKMCBCB();
		}
		KLAKFLIHPNN();
	}

	public void NMGBKFBOEGI(Vector3 DDBOKLAGCDL, bool CDPAMNIPPEC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline() || !CDPAMNIPPEC)
		{
			hitPosition = DDBOKLAGCDL;
			GCOPKGKNMPA(0);
			if (PANEOJGCKIO > 0)
			{
				AADJLOMNPMG();
			}
			else if (BEGCPKOAJCP == null)
			{
				BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(JHNIMJDFBPE());
			}
			if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
			{
				onlineTurkey.MHMGKIJCLCD(DDBOKLAGCDL);
			}
		}
		else
		{
			onlineTurkey.SendHit(DDBOKLAGCDL);
		}
	}

	private void DMEEIHDDALH()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(OJKPGIFAMML));
		}
		else
		{
			JEMFMIHMAOI();
		}
		MACNHBILJBI();
	}

	public bool ELEBLJHFHHA()
	{
		if (turkeyAnimationState.safeMovement)
		{
			return true;
		}
		return false;
	}

	public void HIJOGDHBCOI()
	{
		behaviour.SetTrigger(NPC.AEOKENCHHPL);
	}

	private void FIIEBCCFGJE()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			_ = GameManager.isLoading;
		}
	}

	public void GPIBCICAMFA()
	{
		behaviour.SetTrigger(NPC.AEOKENCHHPL);
	}

	public int JJPJCADMGBI()
	{
		return PANEOJGCKIO;
	}

	public bool BIECMHAHDCG()
	{
		if (turkeyAnimationState.safeMovement)
		{
			return false;
		}
		return false;
	}

	private void OJKPGIFAMML()
	{
		ENPJHFLIALN();
	}

	public void NFADIDBOFMC(HitDetection NOCOHCGPMFF)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)NOCOHCGPMFF))
		{
			NMGBKFBOEGI(((Component)PlayerController.GetPlayer(NOCOHCGPMFF.playerNum)).transform.position, CDPAMNIPPEC: true);
		}
		else
		{
			LJDIKGJKMBD(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position, CDPAMNIPPEC: true);
		}
	}

	public bool CMNFOPCLCNN()
	{
		if (turkeyAnimationState.safeMovement)
		{
			return true;
		}
		return true;
	}

	private IEnumerator JNKEKIOLOAL()
	{
		turkeySprite.color = Color.red;
		yield return CommonReferences.wait01;
		turkeySprite.color = Color.white;
		yield return CommonReferences.wait01;
		turkeySprite.color = Color.red;
		yield return CommonReferences.wait01;
		turkeySprite.color = Color.white;
		if (OnlineManager.MasterOrOffline())
		{
			hitCollider.SetActive(false);
		}
	}

	public void CIKBLGGBHOF(HitDetection NOCOHCGPMFF)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)NOCOHCGPMFF))
		{
			NBOLODPBMEA(((Component)PlayerController.OPHDCMJLLEC(NOCOHCGPMFF.playerNum)).transform.position, CDPAMNIPPEC: true);
		}
		else
		{
			BLHEKDCEDHN(((Component)PlayerController.OPHDCMJLLEC(0)).transform.position, CDPAMNIPPEC: false);
		}
	}

	private IEnumerator FPKKGDFKOPM()
	{
		return new HELDHCPLPOJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public void ABDMCMPDBAC()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentTurkeyState))
		{
			currentTurkeyState.CFFNKGEKKDA();
		}
	}

	public void IJFDGKDAEGC(Vector3 DDBOKLAGCDL, bool CDPAMNIPPEC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB() || !CDPAMNIPPEC)
		{
			hitPosition = DDBOKLAGCDL;
			ICLHEHPINPH(0);
			if (PANEOJGCKIO > 1)
			{
				NJPACPOEIHD();
			}
			else if (BEGCPKOAJCP == null)
			{
				BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(JHNIMJDFBPE());
			}
			if (OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
			{
				onlineTurkey.SendHitToOthers(DDBOKLAGCDL);
			}
		}
		else
		{
			onlineTurkey.AHMDDNJGAFE(DDBOKLAGCDL);
		}
	}

	private IEnumerator FOCABKCBIFC()
	{
		turkeySprite.color = Color.red;
		yield return CommonReferences.wait01;
		turkeySprite.color = Color.white;
		yield return CommonReferences.wait01;
		turkeySprite.color = Color.red;
		yield return CommonReferences.wait01;
		turkeySprite.color = Color.white;
		if (OnlineManager.MasterOrOffline())
		{
			hitCollider.SetActive(false);
		}
	}

	private void JMMBKMOBAFB()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			_ = GameManager.isLoading;
		}
	}

	public void DNOBJBALJED()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentTurkeyState))
		{
			currentTurkeyState.DLLEGKJNFFM();
		}
	}

	public void OHGGFMHJJOL(HitDetection NOCOHCGPMFF)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)NOCOHCGPMFF))
		{
			IJFDGKDAEGC(((Component)PlayerController.GetPlayer(NOCOHCGPMFF.playerNum)).transform.position, CDPAMNIPPEC: true);
		}
		else
		{
			MHLAECBKKEL(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position, CDPAMNIPPEC: true);
		}
	}

	public bool CanWalk()
	{
		if (turkeyAnimationState.safeMovement)
		{
			return true;
		}
		return false;
	}

	protected override void Awake()
	{
	}

	public void GCOPKGKNMPA(int MGNOBNCMDJG)
	{
		PANEOJGCKIO -= MGNOBNCMDJG;
	}

	public void HAHFKJCIPKH()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentTurkeyState))
		{
			currentTurkeyState.NNHMECCLBJJ();
		}
	}

	private void NJPACPOEIHD()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		hitFx.SetActive(true);
		if (OnlineManager.PGAGDFAEEFB())
		{
			turkeyAnimation.SetBool(NPC.LHDAIEDAFGL, EGFGNGJGBOP: false);
			Vector3 val = ((Component)this).transform.position - hitPosition;
			rb.velocity = Vector2.zero;
			rb.AddForce(Vector2.op_Implicit(val * 1604f));
			hitCollider.SetActive(false);
			walkTo.isActive = true;
		}
		hitFx.SetActive(true);
		turkeyAnimation.FHOAPHBOOAH(NPC.PFGHDNAOKBK);
		if (OnlineManager.PlayingOnline())
		{
			onlineTurkey.GJENKGNLLMG(OnlineTurkey.TriggerName.Peek);
		}
		MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().turkey, ((Component)this).transform);
		((MonoBehaviour)this).StartCoroutine(FOCABKCBIFC());
		if (OnlineManager.MasterOrOffline())
		{
			behaviour.SetTrigger(NPC.LHDAIEDAFGL);
		}
	}

	public bool MLBPKDEPIPN()
	{
		if (turkeyAnimationState.safeMovement)
		{
			return true;
		}
		return false;
	}

	private void MEFFGGKAALB()
	{
		if (OnlineManager.ClientOnline())
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(PDHLBGEMPPG));
		}
		else
		{
			PPICAMAGNME();
		}
		OMGFFLJEADK();
	}

	private void GGDKDFOLKOF()
	{
		CPFDLKMCBCB();
	}

	public bool AMOBOLLOEDH()
	{
		if (turkeyAnimationState.safeMovement)
		{
			return false;
		}
		return false;
	}

	private void PBNHJCJLGMJ()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			_ = GameManager.isLoading;
		}
	}

	protected override void CPFDLKMCBCB()
	{
		SetLife(3, CDPAMNIPPEC: true);
		currentTurkeyState = null;
		base.CPFDLKMCBCB();
	}

	public void GJJNHPMJKLK(HitDetection NOCOHCGPMFF)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)NOCOHCGPMFF))
		{
			MHLAECBKKEL(((Component)PlayerController.GetPlayer(NOCOHCGPMFF.playerNum)).transform.position, CDPAMNIPPEC: false);
		}
		else
		{
			NMGBKFBOEGI(((Component)PlayerController.GetPlayer(1)).transform.position, CDPAMNIPPEC: false);
		}
	}

	private IEnumerator GNBNAFCCLCK()
	{
		if (OnlineManager.MasterOrOffline())
		{
			turkeyAnimation.SetBool(NPC.LHDAIEDAFGL, EGFGNGJGBOP: false);
			Vector3 val = ((Component)this).transform.position - hitPosition;
			rb.velocity = Vector2.zero;
			rb.AddForce(Vector2.op_Implicit(val * 300f));
		}
		turkeyAnimation.SetTrigger(NPC.PFGHDNAOKBK);
		if (OnlineManager.PlayingOnline())
		{
			onlineTurkey.SendTrigger(OnlineTurkey.TriggerName.Hurt);
		}
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.turkey, ((Component)this).transform);
		((MonoBehaviour)this).StartCoroutine(AAGGGBAPFGJ());
		if (OnlineManager.MasterOrOffline())
		{
			behaviour.SetTrigger(NPC.LHDAIEDAFGL);
		}
		yield return CommonReferences.wait04;
		MOBFJEDPIPM = Object.Instantiate<GameObject>(deathFx, ((Component)this).transform.position, ((Component)this).transform.rotation);
		yield return CommonReferences.wait02;
		if (OnlineManager.MasterOrOffline())
		{
			hitCollider.SetActive(false);
			int num = turkeyDrop.amount;
			if (Random.Range(0, 100) < PerksDatabaseAccessor.GetPlayerPerkValue(3))
			{
				num++;
			}
			DroppedItem.SpawnDroppedItem(((Component)this).gameObject.transform.position, turkeyDrop.item, num);
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)this).transform);
			poolObject.ReturnToPool();
		}
		BEGCPKOAJCP = null;
	}

	public void MHLAECBKKEL(Vector3 DDBOKLAGCDL, bool CDPAMNIPPEC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline() || !CDPAMNIPPEC)
		{
			hitPosition = DDBOKLAGCDL;
			KOFHDMINABC(1);
			if (PANEOJGCKIO > 1)
			{
				JGLBNDKDKOM();
			}
			else if (BEGCPKOAJCP == null)
			{
				BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(NNIJCPBIBGJ());
			}
			if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
			{
				onlineTurkey.ACJIELGLAJB(DDBOKLAGCDL);
			}
		}
		else
		{
			onlineTurkey.SendHit(DDBOKLAGCDL);
		}
	}

	public void DAFOLIIBHPP(int MGNOBNCMDJG, bool CDPAMNIPPEC)
	{
		PANEOJGCKIO = MGNOBNCMDJG;
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineTurkey.LJIAKIALGPP(MGNOBNCMDJG);
		}
	}

	public void PMBKHMNPEMP()
	{
		behaviour.SetTrigger(NPC.AEOKENCHHPL);
	}

	public void PODKNIMOACM()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentTurkeyState))
		{
			currentTurkeyState.KGKNBFLMFEI();
		}
	}

	public bool AHLIDNGJHOJ()
	{
		if (turkeyAnimationState.safeMovement)
		{
			return true;
		}
		return true;
	}

	private IEnumerator GLPLODDGDAD()
	{
		turkeySprite.color = Color.red;
		yield return CommonReferences.wait01;
		turkeySprite.color = Color.white;
		yield return CommonReferences.wait01;
		turkeySprite.color = Color.red;
		yield return CommonReferences.wait01;
		turkeySprite.color = Color.white;
		if (OnlineManager.MasterOrOffline())
		{
			hitCollider.SetActive(false);
		}
	}

	private IEnumerator DKIPPNDIHCH()
	{
		if (OnlineManager.MasterOrOffline())
		{
			turkeyAnimation.SetBool(NPC.LHDAIEDAFGL, EGFGNGJGBOP: false);
			Vector3 val = ((Component)this).transform.position - hitPosition;
			rb.velocity = Vector2.zero;
			rb.AddForce(Vector2.op_Implicit(val * 300f));
		}
		turkeyAnimation.SetTrigger(NPC.PFGHDNAOKBK);
		if (OnlineManager.PlayingOnline())
		{
			onlineTurkey.SendTrigger(OnlineTurkey.TriggerName.Hurt);
		}
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.turkey, ((Component)this).transform);
		((MonoBehaviour)this).StartCoroutine(AAGGGBAPFGJ());
		if (OnlineManager.MasterOrOffline())
		{
			behaviour.SetTrigger(NPC.LHDAIEDAFGL);
		}
		yield return CommonReferences.wait04;
		MOBFJEDPIPM = Object.Instantiate<GameObject>(deathFx, ((Component)this).transform.position, ((Component)this).transform.rotation);
		yield return CommonReferences.wait02;
		if (OnlineManager.MasterOrOffline())
		{
			hitCollider.SetActive(false);
			int num = turkeyDrop.amount;
			if (Random.Range(0, 100) < PerksDatabaseAccessor.GetPlayerPerkValue(3))
			{
				num++;
			}
			DroppedItem.SpawnDroppedItem(((Component)this).gameObject.transform.position, turkeyDrop.item, num);
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)this).transform);
			poolObject.ReturnToPool();
		}
		BEGCPKOAJCP = null;
	}

	public void ALDACDEGNDB(int MGNOBNCMDJG, bool CDPAMNIPPEC)
	{
		PANEOJGCKIO = MGNOBNCMDJG;
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineTurkey.JGDALHDACDC(MGNOBNCMDJG);
		}
	}

	private void FNFDDCPKOLI()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		hitFx.SetActive(false);
		if (OnlineManager.MasterOrOffline())
		{
			turkeyAnimation.SetBool(NPC.LHDAIEDAFGL, EGFGNGJGBOP: false);
			Vector3 val = ((Component)this).transform.position - hitPosition;
			rb.velocity = Vector2.zero;
			rb.AddForce(Vector2.op_Implicit(val * 250f));
			hitCollider.SetActive(true);
			walkTo.isActive = false;
		}
		hitFx.SetActive(true);
		turkeyAnimation.SetTrigger(NPC.PFGHDNAOKBK);
		if (OnlineManager.PlayingOnline())
		{
			onlineTurkey.SendTrigger(OnlineTurkey.TriggerName.Hurt);
		}
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.turkey, ((Component)this).transform);
		((MonoBehaviour)this).StartCoroutine(AAGGGBAPFGJ());
		if (OnlineManager.MasterOrOffline())
		{
			behaviour.SetTrigger(NPC.LHDAIEDAFGL);
		}
	}

	private void HPAEMFFFLFH()
	{
		HJCOAJEIABK();
	}

	public void ECPINCPHACH()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentTurkeyState))
		{
			currentTurkeyState.IEHAIBNPBDJ();
		}
	}

	public void OMGFFLJEADK()
	{
		behaviour.SetTrigger(NPC.AEOKENCHHPL);
	}

	private void BLPEOCMNCAK()
	{
		HJCOAJEIABK();
	}

	public bool CNOLGDHBCHA()
	{
		if (turkeyAnimationState.safeMovement)
		{
			return false;
		}
		return false;
	}

	public void KOFHDMINABC(int MGNOBNCMDJG)
	{
		PANEOJGCKIO -= MGNOBNCMDJG;
	}

	public int GetLives()
	{
		return PANEOJGCKIO;
	}

	[CompilerGenerated]
	private void EEFDNFJOLPI()
	{
		CPFDLKMCBCB();
	}

	public bool AGBBICJHODG()
	{
		if (turkeyAnimationState.safeMovement)
		{
			return true;
		}
		return false;
	}

	private IEnumerator MHAPDFLHCEK()
	{
		turkeySprite.color = Color.red;
		yield return CommonReferences.wait01;
		turkeySprite.color = Color.white;
		yield return CommonReferences.wait01;
		turkeySprite.color = Color.red;
		yield return CommonReferences.wait01;
		turkeySprite.color = Color.white;
		if (OnlineManager.MasterOrOffline())
		{
			hitCollider.SetActive(false);
		}
	}

	public void LJDIKGJKMBD(Vector3 DDBOKLAGCDL, bool CDPAMNIPPEC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB() || !CDPAMNIPPEC)
		{
			hitPosition = DDBOKLAGCDL;
			BBLJNILGGAO(1);
			if (PANEOJGCKIO > 0)
			{
				GFEPAHONACL();
			}
			else if (BEGCPKOAJCP == null)
			{
				BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(IPDEAMNPDND());
			}
			if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
			{
				onlineTurkey.IFGFKKDLACB(DDBOKLAGCDL);
			}
		}
		else
		{
			onlineTurkey.AHMDDNJGAFE(DDBOKLAGCDL);
		}
	}

	public void NMGADFKMNAO(HitDetection NOCOHCGPMFF)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)NOCOHCGPMFF))
		{
			NBOLODPBMEA(((Component)PlayerController.OPHDCMJLLEC(NOCOHCGPMFF.playerNum)).transform.position, CDPAMNIPPEC: true);
		}
		else
		{
			LJDIKGJKMBD(((Component)PlayerController.OPHDCMJLLEC(0)).transform.position, CDPAMNIPPEC: false);
		}
	}

	public int OELMMGELMHL()
	{
		return PANEOJGCKIO;
	}

	private void JGLBNDKDKOM()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		hitFx.SetActive(false);
		if (OnlineManager.MasterOrOffline())
		{
			turkeyAnimation.SetBool(NPC.LHDAIEDAFGL, EGFGNGJGBOP: false, HALNIEBONKH: true);
			Vector3 val = ((Component)this).transform.position - hitPosition;
			rb.velocity = Vector2.zero;
			rb.AddForce(Vector2.op_Implicit(val * 17f));
			hitCollider.SetActive(true);
			walkTo.isActive = true;
		}
		hitFx.SetActive(true);
		turkeyAnimation.IDNHDBIKNKP(NPC.PFGHDNAOKBK, HALNIEBONKH: true);
		if (OnlineManager.PlayingOnline())
		{
			onlineTurkey.GJENKGNLLMG(OnlineTurkey.TriggerName.Hurt);
		}
		MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().turkey, ((Component)this).transform);
		((MonoBehaviour)this).StartCoroutine(FOCABKCBIFC());
		if (OnlineManager.PGAGDFAEEFB())
		{
			behaviour.SetTrigger(NPC.LHDAIEDAFGL);
		}
	}

	private IEnumerator IOPDNGMMIKJ()
	{
		turkeySprite.color = Color.red;
		yield return CommonReferences.wait01;
		turkeySprite.color = Color.white;
		yield return CommonReferences.wait01;
		turkeySprite.color = Color.red;
		yield return CommonReferences.wait01;
		turkeySprite.color = Color.white;
		if (OnlineManager.MasterOrOffline())
		{
			hitCollider.SetActive(false);
		}
	}

	public void FKCOPHFELKD()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentTurkeyState))
		{
			currentTurkeyState.ODPGGKEGKFK();
		}
	}

	private IEnumerator MNKNHAGEHDD()
	{
		return new HELDHCPLPOJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public void FGBHCDMMNLL(Vector3 DDBOKLAGCDL, bool CDPAMNIPPEC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB() || !CDPAMNIPPEC)
		{
			hitPosition = DDBOKLAGCDL;
			MAGPALABAAJ(1);
			if (PANEOJGCKIO > 1)
			{
				FNFDDCPKOLI();
			}
			else if (BEGCPKOAJCP == null)
			{
				BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(JHNIMJDFBPE());
			}
			if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
			{
				onlineTurkey.OHCHFJDNCOC(DDBOKLAGCDL);
			}
		}
		else
		{
			onlineTurkey.SendHit(DDBOKLAGCDL);
		}
	}

	public void LPDLEDLIHGL(int MGNOBNCMDJG, bool CDPAMNIPPEC)
	{
		PANEOJGCKIO = MGNOBNCMDJG;
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineTurkey.KCJECFFFDPM(MGNOBNCMDJG);
		}
	}

	public void HHMCAODPCJD(int MGNOBNCMDJG)
	{
		PANEOJGCKIO -= MGNOBNCMDJG;
	}

	private void AADJLOMNPMG()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		hitFx.SetActive(false);
		if (OnlineManager.PGAGDFAEEFB())
		{
			turkeyAnimation.SetBool(NPC.LHDAIEDAFGL, EGFGNGJGBOP: false, HALNIEBONKH: true);
			Vector3 val = ((Component)this).transform.position - hitPosition;
			rb.velocity = Vector2.zero;
			rb.AddForce(Vector2.op_Implicit(val * 76f));
			hitCollider.SetActive(false);
			walkTo.isActive = false;
		}
		hitFx.SetActive(false);
		turkeyAnimation.SetTrigger(NPC.PFGHDNAOKBK, HALNIEBONKH: true);
		if (OnlineManager.PlayingOnline())
		{
			onlineTurkey.FANGKFNHAPC(OnlineTurkey.TriggerName.Peek);
		}
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.turkey, ((Component)this).transform);
		((MonoBehaviour)this).StartCoroutine(EJCCAEDGKAG());
		if (OnlineManager.PGAGDFAEEFB())
		{
			behaviour.SetTrigger(NPC.LHDAIEDAFGL);
		}
	}

	private void PDHLBGEMPPG()
	{
		HJCOAJEIABK();
	}

	public void ReduceLife(int MGNOBNCMDJG)
	{
		PANEOJGCKIO -= MGNOBNCMDJG;
	}

	public void OKABHFANCHC()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentTurkeyState))
		{
			currentTurkeyState.MLMCJEPPJHA();
		}
	}

	public bool ABDLDIMDJEN()
	{
		if (turkeyAnimationState.safeMovement)
		{
			return false;
		}
		return true;
	}

	public void PAPACFMNKLP(int MGNOBNCMDJG)
	{
		PANEOJGCKIO -= MGNOBNCMDJG;
	}

	private void HMLHKJCIFLC()
	{
		if (OnlineManager.ClientOnline())
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, (Action)delegate
			{
				CPFDLKMCBCB();
			});
		}
		else
		{
			PPICAMAGNME();
		}
		GPIBCICAMFA();
	}

	public void CDKIGHCAGAN()
	{
		behaviour.SetTrigger(NPC.AEOKENCHHPL);
	}

	private IEnumerator EOMKJKBGNAG()
	{
		return new HBCDOGNJHCM(1)
		{
			_003C_003E4__this = this
		};
	}

	public void SetLife(int MGNOBNCMDJG, bool CDPAMNIPPEC)
	{
		PANEOJGCKIO = MGNOBNCMDJG;
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineTurkey.SendSetLife(MGNOBNCMDJG);
		}
	}

	public void KEBPJOHPMCF(HitDetection NOCOHCGPMFF)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)NOCOHCGPMFF))
		{
			IINOENFPAGN(((Component)PlayerController.OPHDCMJLLEC(NOCOHCGPMFF.playerNum)).transform.position, CDPAMNIPPEC: true);
		}
		else
		{
			NBOLODPBMEA(((Component)PlayerController.GetPlayer(1)).transform.position, CDPAMNIPPEC: true);
		}
	}

	private IEnumerator JCNEPPLONOF()
	{
		return new HBCDOGNJHCM(1)
		{
			_003C_003E4__this = this
		};
	}

	public void JBMJKMMILAI(HitDetection NOCOHCGPMFF)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)NOCOHCGPMFF))
		{
			NBOLODPBMEA(((Component)PlayerController.GetPlayer(NOCOHCGPMFF.playerNum)).transform.position, CDPAMNIPPEC: true);
		}
		else
		{
			KPEMDKAOANI(((Component)PlayerController.GetPlayer(1)).transform.position, CDPAMNIPPEC: false);
		}
	}

	private void MFPANPIMFPC()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		hitFx.SetActive(true);
		if (OnlineManager.MasterOrOffline())
		{
			turkeyAnimation.SetBool(NPC.LHDAIEDAFGL, EGFGNGJGBOP: false);
			Vector3 val = ((Component)this).transform.position - hitPosition;
			rb.velocity = Vector2.zero;
			rb.AddForce(Vector2.op_Implicit(val * 1032f));
			hitCollider.SetActive(true);
			walkTo.isActive = true;
		}
		hitFx.SetActive(false);
		turkeyAnimation.IDNHDBIKNKP(NPC.PFGHDNAOKBK);
		if (OnlineManager.PlayingOnline())
		{
			onlineTurkey.FANGKFNHAPC(OnlineTurkey.TriggerName.Peek);
		}
		MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().turkey, ((Component)this).transform);
		((MonoBehaviour)this).StartCoroutine(FOCABKCBIFC());
		if (OnlineManager.MasterOrOffline())
		{
			behaviour.SetTrigger(NPC.LHDAIEDAFGL);
		}
	}

	public void DLCNHNFGMDO(HitDetection NOCOHCGPMFF)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)NOCOHCGPMFF))
		{
			FGBHCDMMNLL(((Component)PlayerController.OPHDCMJLLEC(NOCOHCGPMFF.playerNum)).transform.position, CDPAMNIPPEC: false);
		}
		else
		{
			KPANGFOLIEK(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position, CDPAMNIPPEC: true);
		}
	}

	private void OONFGLELCPD()
	{
		CPFDLKMCBCB();
	}

	private void ALAAGNALDKF()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		hitFx.SetActive(false);
		if (OnlineManager.PGAGDFAEEFB())
		{
			turkeyAnimation.SetBool(NPC.LHDAIEDAFGL, EGFGNGJGBOP: false);
			Vector3 val = ((Component)this).transform.position - hitPosition;
			rb.velocity = Vector2.zero;
			rb.AddForce(Vector2.op_Implicit(val * 1654f));
			hitCollider.SetActive(false);
			walkTo.isActive = false;
		}
		hitFx.SetActive(false);
		turkeyAnimation.SetTrigger(NPC.PFGHDNAOKBK, HALNIEBONKH: true);
		if (OnlineManager.PlayingOnline())
		{
			onlineTurkey.JBDJOIACLKJ(OnlineTurkey.TriggerName.Peek);
		}
		MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().turkey, ((Component)this).transform);
		((MonoBehaviour)this).StartCoroutine(EJCCAEDGKAG());
		if (OnlineManager.MasterOrOffline())
		{
			behaviour.SetTrigger(NPC.LHDAIEDAFGL);
		}
	}

	private void AIPEJKKBIKL()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		hitFx.SetActive(false);
		if (OnlineManager.MasterOrOffline())
		{
			turkeyAnimation.SetBool(NPC.LHDAIEDAFGL, EGFGNGJGBOP: true);
			Vector3 val = ((Component)this).transform.position - hitPosition;
			rb.velocity = Vector2.zero;
			rb.AddForce(Vector2.op_Implicit(val * 1075f));
			hitCollider.SetActive(false);
			walkTo.isActive = true;
		}
		hitFx.SetActive(false);
		turkeyAnimation.IDNHDBIKNKP(NPC.PFGHDNAOKBK, HALNIEBONKH: true);
		if (OnlineManager.PlayingOnline())
		{
			onlineTurkey.COMHPHBBLOH(OnlineTurkey.TriggerName.Peek);
		}
		MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().turkey, ((Component)this).transform);
		((MonoBehaviour)this).StartCoroutine(IOPDNGMMIKJ());
		if (OnlineManager.PGAGDFAEEFB())
		{
			behaviour.SetTrigger(NPC.LHDAIEDAFGL);
		}
	}

	public void MCOFBNHNCDC(HitDetection NOCOHCGPMFF)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)NOCOHCGPMFF))
		{
			MHLAECBKKEL(((Component)PlayerController.GetPlayer(NOCOHCGPMFF.playerNum)).transform.position, CDPAMNIPPEC: false);
		}
		else
		{
			LJDIKGJKMBD(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position, CDPAMNIPPEC: false);
		}
	}

	public void BCADNMEPOFM(int MGNOBNCMDJG)
	{
		PANEOJGCKIO -= MGNOBNCMDJG;
	}

	public void FOIGFCMPAAO()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentTurkeyState))
		{
			currentTurkeyState.EHBJGKOOOFF();
		}
	}

	public void ICLHEHPINPH(int MGNOBNCMDJG)
	{
		PANEOJGCKIO -= MGNOBNCMDJG;
	}

	public void NCAKMJPLBHK()
	{
		behaviour.SetTrigger(NPC.AEOKENCHHPL);
	}

	public void NBOLODPBMEA(Vector3 DDBOKLAGCDL, bool CDPAMNIPPEC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB() || !CDPAMNIPPEC)
		{
			hitPosition = DDBOKLAGCDL;
			GCOPKGKNMPA(0);
			if (PANEOJGCKIO > 1)
			{
				FNFDDCPKOLI();
			}
			else if (BEGCPKOAJCP == null)
			{
				BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(GNBNAFCCLCK());
			}
			if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
			{
				onlineTurkey.LGHGEJCFOOH(DDBOKLAGCDL);
			}
		}
		else
		{
			onlineTurkey.SendHit(DDBOKLAGCDL);
		}
	}

	public void IINOENFPAGN(Vector3 DDBOKLAGCDL, bool CDPAMNIPPEC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB() || !CDPAMNIPPEC)
		{
			hitPosition = DDBOKLAGCDL;
			GNIIEICPJLI(1);
			if (PANEOJGCKIO > 1)
			{
				MFPANPIMFPC();
			}
			else if (BEGCPKOAJCP == null)
			{
				BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(GNBNAFCCLCK());
			}
			if (OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
			{
				onlineTurkey.SendHitToOthers(DDBOKLAGCDL);
			}
		}
		else
		{
			onlineTurkey.POOBOLNBDJN(DDBOKLAGCDL);
		}
	}

	public void GNIIEICPJLI(int MGNOBNCMDJG)
	{
		PANEOJGCKIO -= MGNOBNCMDJG;
	}

	public void OHHNEEJJBKP(int MGNOBNCMDJG)
	{
		PANEOJGCKIO -= MGNOBNCMDJG;
	}

	public void MAGPALABAAJ(int MGNOBNCMDJG)
	{
		PANEOJGCKIO -= MGNOBNCMDJG;
	}

	private IEnumerator EJCCAEDGKAG()
	{
		return new HBCDOGNJHCM(1)
		{
			_003C_003E4__this = this
		};
	}

	public void FAFLOANGNLE()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentTurkeyState))
		{
			currentTurkeyState.FBAFAOMLKMG();
		}
	}

	private void BFGLJCMADMI()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			_ = GameManager.isLoading;
		}
	}

	public void WalkAround()
	{
		behaviour.SetTrigger(NPC.AEOKENCHHPL);
	}

	private void OBLCKPMAADM()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			_ = GameManager.isLoading;
		}
	}

	private void LGILFFNKNAO()
	{
		JEMFMIHMAOI();
	}

	public void Run(Vector3 DDBOKLAGCDL, bool CDPAMNIPPEC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline() || !CDPAMNIPPEC)
		{
			hitPosition = DDBOKLAGCDL;
			ReduceLife(1);
			if (PANEOJGCKIO > 0)
			{
				FNFDDCPKOLI();
			}
			else if (BEGCPKOAJCP == null)
			{
				BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(JHNIMJDFBPE());
			}
			if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
			{
				onlineTurkey.SendHitToOthers(DDBOKLAGCDL);
			}
		}
		else
		{
			onlineTurkey.SendHit(DDBOKLAGCDL);
		}
	}

	private IEnumerator CANBLNBJHDG()
	{
		return new HBCDOGNJHCM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AAGGGBAPFGJ()
	{
		turkeySprite.color = Color.red;
		yield return CommonReferences.wait01;
		turkeySprite.color = Color.white;
		yield return CommonReferences.wait01;
		turkeySprite.color = Color.red;
		yield return CommonReferences.wait01;
		turkeySprite.color = Color.white;
		if (OnlineManager.MasterOrOffline())
		{
			hitCollider.SetActive(false);
		}
	}

	private void GLPFNIFNGKC()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			_ = GameManager.isLoading;
		}
	}

	public void CEGBBGNEFLI()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentTurkeyState))
		{
			currentTurkeyState.LJBAGHCBAGC();
		}
	}

	public void IBJCGGLDGBL()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentTurkeyState))
		{
			currentTurkeyState.CFFNKGEKKDA();
		}
	}

	public void ANILJIIEAKG(int MGNOBNCMDJG, bool CDPAMNIPPEC)
	{
		PANEOJGCKIO = MGNOBNCMDJG;
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineTurkey.LJIAKIALGPP(MGNOBNCMDJG);
		}
	}

	private void NOBICADACAP()
	{
		CPFDLKMCBCB();
	}

	public void MACNHBILJBI()
	{
		behaviour.SetTrigger(NPC.AEOKENCHHPL);
	}

	private void LJDFEDLDKCD()
	{
		CPFDLKMCBCB();
	}

	public bool CGLMMNIGGHG()
	{
		if (turkeyAnimationState.safeMovement)
		{
			return true;
		}
		return false;
	}

	public int EFGHIDBEKKL()
	{
		return PANEOJGCKIO;
	}

	public void BBLJNILGGAO(int MGNOBNCMDJG)
	{
		PANEOJGCKIO -= MGNOBNCMDJG;
	}

	public void ENJGGOIOHCM(int MGNOBNCMDJG)
	{
		PANEOJGCKIO -= MGNOBNCMDJG;
	}

	private void FIINFIJNGPO()
	{
		JEMFMIHMAOI();
	}

	public void Run(HitDetection NOCOHCGPMFF)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)NOCOHCGPMFF))
		{
			Run(((Component)PlayerController.GetPlayer(NOCOHCGPMFF.playerNum)).transform.position, CDPAMNIPPEC: true);
		}
		else
		{
			Run(((Component)PlayerController.GetPlayer(1)).transform.position, CDPAMNIPPEC: true);
		}
	}

	public int MFDIPEAFJFO()
	{
		return PANEOJGCKIO;
	}

	public void BLHEKDCEDHN(Vector3 DDBOKLAGCDL, bool CDPAMNIPPEC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB() || !CDPAMNIPPEC)
		{
			hitPosition = DDBOKLAGCDL;
			HHMCAODPCJD(0);
			if (PANEOJGCKIO > 1)
			{
				NJPACPOEIHD();
			}
			else if (BEGCPKOAJCP == null)
			{
				BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(FPKKGDFKOPM());
			}
			if (OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
			{
				onlineTurkey.FJIMOOMFBOK(DDBOKLAGCDL);
			}
		}
		else
		{
			onlineTurkey.SendHit(DDBOKLAGCDL);
		}
	}

	public bool IBHGMICJDCC()
	{
		if (turkeyAnimationState.safeMovement)
		{
			return true;
		}
		return false;
	}

	private void OnEnable()
	{
		if (OnlineManager.ClientOnline())
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, (Action)delegate
			{
				CPFDLKMCBCB();
			});
		}
		else
		{
			CPFDLKMCBCB();
		}
		WalkAround();
	}

	private void AHCPFICKFHA()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			_ = GameManager.isLoading;
		}
	}

	public bool BPKOPPAAOMO()
	{
		if (turkeyAnimationState.safeMovement)
		{
			return false;
		}
		return false;
	}

	public void KPEMDKAOANI(Vector3 DDBOKLAGCDL, bool CDPAMNIPPEC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB() || !CDPAMNIPPEC)
		{
			hitPosition = DDBOKLAGCDL;
			BCADNMEPOFM(1);
			if (PANEOJGCKIO > 0)
			{
				FNFDDCPKOLI();
			}
			else if (BEGCPKOAJCP == null)
			{
				BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(JHNIMJDFBPE());
			}
			if (OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
			{
				onlineTurkey.IFPGELEBJNN(DDBOKLAGCDL);
			}
		}
		else
		{
			onlineTurkey.SendHit(DDBOKLAGCDL);
		}
	}

	private void IPNIMLHIAPJ()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		hitFx.SetActive(true);
		if (OnlineManager.PGAGDFAEEFB())
		{
			turkeyAnimation.SetBool(NPC.LHDAIEDAFGL, EGFGNGJGBOP: true, HALNIEBONKH: true);
			Vector3 val = ((Component)this).transform.position - hitPosition;
			rb.velocity = Vector2.zero;
			rb.AddForce(Vector2.op_Implicit(val * 1361f));
			hitCollider.SetActive(true);
			walkTo.isActive = false;
		}
		hitFx.SetActive(true);
		turkeyAnimation.FHOAPHBOOAH(NPC.PFGHDNAOKBK, HALNIEBONKH: true);
		if (OnlineManager.PlayingOnline())
		{
			onlineTurkey.OGECCJPBDPC(OnlineTurkey.TriggerName.Hurt);
		}
		MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().turkey, ((Component)this).transform);
		((MonoBehaviour)this).StartCoroutine(BPPBODKNDNA());
		if (OnlineManager.MasterOrOffline())
		{
			behaviour.SetTrigger(NPC.LHDAIEDAFGL);
		}
	}

	private IEnumerator CECCLOGPCAE()
	{
		turkeySprite.color = Color.red;
		yield return CommonReferences.wait01;
		turkeySprite.color = Color.white;
		yield return CommonReferences.wait01;
		turkeySprite.color = Color.red;
		yield return CommonReferences.wait01;
		turkeySprite.color = Color.white;
		if (OnlineManager.MasterOrOffline())
		{
			hitCollider.SetActive(false);
		}
	}

	private void EEAKGHLCFOM()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			_ = GameManager.isLoading;
		}
	}

	public int BHDPPEMCKFA()
	{
		return PANEOJGCKIO;
	}

	private void KCOFAJBKHAO()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(NOBICADACAP));
		}
		else
		{
			CPFDLKMCBCB();
		}
		CDKIGHCAGAN();
	}

	private IEnumerator PMMAFJHAJFJ()
	{
		return new HELDHCPLPOJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public bool NKFBPGONLGL()
	{
		if (turkeyAnimationState.safeMovement)
		{
			return false;
		}
		return false;
	}

	public void FixedUpdate()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentTurkeyState))
		{
			currentTurkeyState.EHBJGKOOOFF();
		}
	}

	public bool FADAMDJHOGF()
	{
		if (turkeyAnimationState.safeMovement)
		{
			return true;
		}
		return true;
	}

	public void JIGKCIBNAAG(HitDetection NOCOHCGPMFF)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)NOCOHCGPMFF))
		{
			Run(((Component)PlayerController.OPHDCMJLLEC(NOCOHCGPMFF.playerNum)).transform.position, CDPAMNIPPEC: true);
		}
		else
		{
			LJDIKGJKMBD(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position, CDPAMNIPPEC: false);
		}
	}

	private IEnumerator IPDEAMNPDND()
	{
		return new HELDHCPLPOJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public void CHOJDAOBKOI()
	{
		behaviour.SetTrigger(NPC.AEOKENCHHPL);
	}

	public void LOPPJEADGGK(int MGNOBNCMDJG, bool CDPAMNIPPEC)
	{
		PANEOJGCKIO = MGNOBNCMDJG;
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineTurkey.PANGIAFLIJH(MGNOBNCMDJG);
		}
	}

	private void DIEKBCKJMPH()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			_ = GameManager.isLoading;
		}
	}
}
