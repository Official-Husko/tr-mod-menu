using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;

public class CrabNPC : NPC
{
	[CompilerGenerated]
	private sealed class LHCACICNMFD : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CrabNPC _003C_003E4__this;

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
		public LHCACICNMFD(int _003C_003E1__state)
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
			CrabNPC crabNPC = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				crabNPC.crabSprite.color = Color.red;
				_003C_003E2__current = CommonReferences.wait01;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				crabNPC.crabSprite.color = Color.white;
				_003C_003E2__current = CommonReferences.wait01;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				crabNPC.crabSprite.color = Color.red;
				_003C_003E2__current = CommonReferences.wait01;
				_003C_003E1__state = 3;
				return true;
			case 3:
				_003C_003E1__state = -1;
				crabNPC.crabSprite.color = Color.white;
				if (OnlineManager.MasterOrOffline())
				{
					crabNPC.hitCollider.SetActive(false);
					crabNPC.rb.bodyType = (RigidbodyType2D)1;
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
	private sealed class EHDJHGDAADL : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CrabNPC _003C_003E4__this;

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
		public EHDJHGDAADL(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_012a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0135: Unknown result type (might be due to invalid IL or missing references)
			//IL_017d: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			CrabNPC crabNPC = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				if (OnlineManager.MasterOrOffline())
				{
					crabNPC.crabAnimation.SetBool(NPC.PFGHDNAOKBK, EGFGNGJGBOP: false);
					if (OnlineManager.PlayingOnline())
					{
						crabNPC.onlineTurkey.SendBool(DMBFKFLDDLH: false);
					}
					Vector3 val = ((Component)crabNPC).transform.position - crabNPC.hitPosition;
					crabNPC.rb.bodyType = (RigidbodyType2D)0;
					crabNPC.rb.velocity = Vector2.zero;
					crabNPC.rb.AddForce(Vector2.op_Implicit(val * 300f));
				}
				crabNPC.crabAnimation.SetBool(NPC.PFGHDNAOKBK, EGFGNGJGBOP: true);
				if (OnlineManager.PlayingOnline())
				{
					crabNPC.onlineTurkey.SendBool(DMBFKFLDDLH: true);
				}
				MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.heavyPunch, ((Component)crabNPC).transform);
				((MonoBehaviour)crabNPC).StartCoroutine(crabNPC.AAGGGBAPFGJ());
				if (OnlineManager.MasterOrOffline())
				{
					crabNPC.behaviour.SetTrigger(NPC.LHDAIEDAFGL);
				}
				_003C_003E2__current = CommonReferences.wait04;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				crabNPC.MOBFJEDPIPM = Object.Instantiate<GameObject>(crabNPC.deathFx, ((Component)crabNPC).transform.position, ((Component)crabNPC).transform.rotation);
				_003C_003E2__current = CommonReferences.wait02;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				if (OnlineManager.MasterOrOffline())
				{
					crabNPC.hitCollider.SetActive(false);
					DroppedItem.SpawnDroppedItem(((Component)crabNPC).gameObject.transform.position, crabNPC.crabDrop.item, crabNPC.crabDrop.amount);
					MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)crabNPC).transform);
					crabNPC.poolObject.ReturnToPool();
				}
				crabNPC.BEGCPKOAJCP = null;
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

	public CrabAnimation crabAnimation;

	public float runSpeed = 2.5f;

	public SpriteRenderer spriteRenderer;

	public CrabStateBase currentCrabState;

	public Animator behaviour;

	[HideInInspector]
	public int walkingAgainCount;

	public Coroutine waitToWalkCoroutine;

	public ItemAmount crabDrop;

	public SpriteRenderer crabSprite;

	public PoolObject poolObject;

	public GameObject deathFx;

	public GameObject hitFx;

	public GameObject hitCollider;

	[SerializeField]
	private int lives = 3;

	private GameObject MOBFJEDPIPM;

	private Coroutine BEGCPKOAJCP;

	public OnlineTurkey onlineTurkey;

	[HideInInspector]
	public Vector3 hitPosition;

	private void DBELBNPLGOF()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		hitFx.SetActive(false);
		crabAnimation.SetBool(NPC.PFGHDNAOKBK, EGFGNGJGBOP: false);
		if (OnlineManager.PlayingOnline())
		{
			onlineTurkey.GMJDHEANFGH(DMBFKFLDDLH: false);
		}
		if (OnlineManager.PGAGDFAEEFB())
		{
			Vector3 val = ((Component)this).transform.position - hitPosition;
			rb.bodyType = (RigidbodyType2D)0;
			rb.velocity = Vector2.zero;
			rb.AddForce(Vector2.op_Implicit(val * 455f));
			hitCollider.SetActive(true);
			walkTo.isActive = false;
		}
		hitFx.SetActive(false);
		crabAnimation.SetBool(NPC.PFGHDNAOKBK, EGFGNGJGBOP: false);
		if (OnlineManager.PlayingOnline())
		{
			onlineTurkey.NNOLGPDBFML(DMBFKFLDDLH: true);
		}
		MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().heavyPunch, ((Component)this).transform);
		((MonoBehaviour)this).StartCoroutine(CBGMBMFHEHK());
		if (OnlineManager.PGAGDFAEEFB())
		{
			behaviour.SetTrigger(NPC.LHDAIEDAFGL);
		}
	}

	private void KJOCGLKMMOM()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			_ = GameManager.isLoading;
		}
	}

	private void CCLJDIFEFPK()
	{
		PPICAMAGNME();
	}

	public void EEBNOILEJAC(Vector3 DDBOKLAGCDL, bool CDPAMNIPPEC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB() || !CDPAMNIPPEC)
		{
			hitPosition = DDBOKLAGCDL;
			PLPIMMJDMBJ(1);
			if (lives > 1)
			{
				FNFDDCPKOLI();
			}
			else if (BEGCPKOAJCP == null)
			{
				BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(JBIPHPFNPFJ());
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

	public void NNMEEOKBILL()
	{
		behaviour.SetTrigger(NPC.AEOKENCHHPL);
	}

	public void IDHOFEDOELN(HitDetection NOCOHCGPMFF)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)NOCOHCGPMFF))
		{
			BGFDGFPEOLO(((Component)PlayerController.OPHDCMJLLEC(NOCOHCGPMFF.playerNum)).transform.position, CDPAMNIPPEC: true);
		}
		else
		{
			FEABMPCBCGO(((Component)PlayerController.OPHDCMJLLEC(0)).transform.position, CDPAMNIPPEC: false);
		}
	}

	private void MIEGHADMMKH()
	{
		ENPJHFLIALN();
	}

	private IEnumerator MNKNHAGEHDD()
	{
		return new EHDJHGDAADL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void GKCKLIAANHA()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(NFNHFEHHOFD));
		}
		else
		{
			PLIFJBMCANA();
		}
		IMJLMHODDNP();
	}

	public void KIKGPOIMPAC(int MGNOBNCMDJG, bool CDPAMNIPPEC)
	{
		lives = MGNOBNCMDJG;
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineTurkey.FEDLEKGBEKO(MGNOBNCMDJG);
		}
	}

	private IEnumerator CBGMBMFHEHK()
	{
		crabSprite.color = Color.red;
		yield return CommonReferences.wait01;
		crabSprite.color = Color.white;
		yield return CommonReferences.wait01;
		crabSprite.color = Color.red;
		yield return CommonReferences.wait01;
		crabSprite.color = Color.white;
		if (OnlineManager.MasterOrOffline())
		{
			hitCollider.SetActive(false);
			rb.bodyType = (RigidbodyType2D)1;
		}
	}

	private void FJEAHPPLGFJ()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		hitFx.SetActive(true);
		crabAnimation.SetBool(NPC.PFGHDNAOKBK, EGFGNGJGBOP: true, HALNIEBONKH: true);
		if (OnlineManager.PlayingOnline())
		{
			onlineTurkey.GMJDHEANFGH(DMBFKFLDDLH: false);
		}
		if (OnlineManager.PGAGDFAEEFB())
		{
			Vector3 val = ((Component)this).transform.position - hitPosition;
			rb.bodyType = (RigidbodyType2D)0;
			rb.velocity = Vector2.zero;
			rb.AddForce(Vector2.op_Implicit(val * 22f));
			hitCollider.SetActive(false);
			walkTo.isActive = false;
		}
		hitFx.SetActive(false);
		crabAnimation.SetBool(NPC.PFGHDNAOKBK, EGFGNGJGBOP: true, HALNIEBONKH: true);
		if (OnlineManager.PlayingOnline())
		{
			onlineTurkey.EMEJJDCGOPF(DMBFKFLDDLH: false);
		}
		MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().heavyPunch, ((Component)this).transform);
		((MonoBehaviour)this).StartCoroutine(HCMKPKLIICM());
		if (OnlineManager.MasterOrOffline())
		{
			behaviour.SetTrigger(NPC.LHDAIEDAFGL);
		}
	}

	public void SetLife(int MGNOBNCMDJG, bool CDPAMNIPPEC)
	{
		lives = MGNOBNCMDJG;
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineTurkey.SendSetLife(MGNOBNCMDJG);
		}
	}

	public void MANFMMAOKNE(int MGNOBNCMDJG, bool CDPAMNIPPEC)
	{
		lives = MGNOBNCMDJG;
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineTurkey.LJIAKIALGPP(MGNOBNCMDJG);
		}
	}

	public void EFLGMHJJMJF(int MGNOBNCMDJG, bool CDPAMNIPPEC)
	{
		lives = MGNOBNCMDJG;
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineTurkey.KCJECFFFDPM(MGNOBNCMDJG);
		}
	}

	public void FOIGFCMPAAO()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentCrabState))
		{
			currentCrabState.ADNGOJKJNFJ();
		}
	}

	public void PJNCNFMLAPE()
	{
		behaviour.SetTrigger(NPC.AEOKENCHHPL);
	}

	private void ANOLEDBMHON()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			_ = GameManager.isLoading;
		}
	}

	private void COFLIBFIHGL()
	{
		ENPJHFLIALN();
	}

	private IEnumerator HCMKPKLIICM()
	{
		crabSprite.color = Color.red;
		yield return CommonReferences.wait01;
		crabSprite.color = Color.white;
		yield return CommonReferences.wait01;
		crabSprite.color = Color.red;
		yield return CommonReferences.wait01;
		crabSprite.color = Color.white;
		if (OnlineManager.MasterOrOffline())
		{
			hitCollider.SetActive(false);
			rb.bodyType = (RigidbodyType2D)1;
		}
	}

	private IEnumerator AJGBPMMHPGN()
	{
		return new EHDJHGDAADL(1)
		{
			_003C_003E4__this = this
		};
	}

	public void DPPKJMGCNGG(int MGNOBNCMDJG, bool CDPAMNIPPEC)
	{
		lives = MGNOBNCMDJG;
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineTurkey.ILCOBOECIDB(MGNOBNCMDJG);
		}
	}

	public void IOOOOOECBNP()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentCrabState))
		{
			currentCrabState.CDCDBGGEFJA();
		}
	}

	public void ReduceLife(int MGNOBNCMDJG)
	{
		lives -= MGNOBNCMDJG;
	}

	public int BNLBIHEKGKP()
	{
		return lives;
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

	public void PHCHKDFJJOI(Vector3 DDBOKLAGCDL, bool CDPAMNIPPEC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline() || !CDPAMNIPPEC)
		{
			hitPosition = DDBOKLAGCDL;
			PLPIMMJDMBJ(0);
			if (lives > 0)
			{
				PGADFNKIPBD();
			}
			else if (BEGCPKOAJCP == null)
			{
				BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(GPKPNHHLIHA());
			}
			if (OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
			{
				onlineTurkey.IFPGELEBJNN(DDBOKLAGCDL);
			}
		}
		else
		{
			onlineTurkey.POOBOLNBDJN(DDBOKLAGCDL);
		}
	}

	public void AFKGJCIANOF()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentCrabState))
		{
			currentCrabState.OCHFEKECIDD();
		}
	}

	public void PKCKLIPCCAL(Vector3 DDBOKLAGCDL, bool CDPAMNIPPEC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB() || !CDPAMNIPPEC)
		{
			hitPosition = DDBOKLAGCDL;
			NJEMCGGPHEN(1);
			if (lives > 1)
			{
				PGADFNKIPBD();
			}
			else if (BEGCPKOAJCP == null)
			{
				BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(AJGBPMMHPGN());
			}
			if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
			{
				onlineTurkey.OHCHFJDNCOC(DDBOKLAGCDL);
			}
		}
		else
		{
			onlineTurkey.AHMDDNJGAFE(DDBOKLAGCDL);
		}
	}

	private IEnumerator JBIPHPFNPFJ()
	{
		return new EHDJHGDAADL(1)
		{
			_003C_003E4__this = this
		};
	}

	public void EDPDFAIOHDO(Vector3 DDBOKLAGCDL, bool CDPAMNIPPEC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB() || !CDPAMNIPPEC)
		{
			hitPosition = DDBOKLAGCDL;
			NJEMCGGPHEN(1);
			if (lives > 1)
			{
				PGADFNKIPBD();
			}
			else if (BEGCPKOAJCP == null)
			{
				BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(HNOCJLLBNHH());
			}
			if (OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
			{
				onlineTurkey.IFGFKKDLACB(DDBOKLAGCDL);
			}
		}
		else
		{
			onlineTurkey.AHMDDNJGAFE(DDBOKLAGCDL);
		}
	}

	public void NNGIDOAHFLF()
	{
		behaviour.SetTrigger(NPC.AEOKENCHHPL);
	}

	public int JOHPCLLAFPI()
	{
		return lives;
	}

	public void MGMJCAKILCO()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentCrabState))
		{
			currentCrabState.HCGFJOFPLKL();
		}
	}

	public void KBOFHCAJELA()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentCrabState))
		{
			currentCrabState.IKOHALFABFG();
		}
	}

	public void FEABMPCBCGO(Vector3 DDBOKLAGCDL, bool CDPAMNIPPEC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline() || !CDPAMNIPPEC)
		{
			hitPosition = DDBOKLAGCDL;
			NFGNFBBMLFP(1);
			if (lives > 1)
			{
				EAEHECFBDLI();
			}
			else if (BEGCPKOAJCP == null)
			{
				BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(EHGFNKIMPBD());
			}
			if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
			{
				onlineTurkey.ACJIELGLAJB(DDBOKLAGCDL);
			}
		}
		else
		{
			onlineTurkey.IMKOOOLLAOF(DDBOKLAGCDL);
		}
	}

	private IEnumerator OPLAPPGONKI()
	{
		return new LHCACICNMFD(1)
		{
			_003C_003E4__this = this
		};
	}

	private void OnDisable()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			_ = GameManager.isLoading;
		}
	}

	private IEnumerator AAGGGBAPFGJ()
	{
		crabSprite.color = Color.red;
		yield return CommonReferences.wait01;
		crabSprite.color = Color.white;
		yield return CommonReferences.wait01;
		crabSprite.color = Color.red;
		yield return CommonReferences.wait01;
		crabSprite.color = Color.white;
		if (OnlineManager.MasterOrOffline())
		{
			hitCollider.SetActive(false);
			rb.bodyType = (RigidbodyType2D)1;
		}
	}

	public int GetLives()
	{
		return lives;
	}

	public void LEDLCAEHBME(int MGNOBNCMDJG)
	{
		lives -= MGNOBNCMDJG;
	}

	public void NHMPNFHGFJL()
	{
		behaviour.SetTrigger(NPC.AEOKENCHHPL);
	}

	public void NJEMCGGPHEN(int MGNOBNCMDJG)
	{
		lives -= MGNOBNCMDJG;
	}

	public void FixedUpdate()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentCrabState))
		{
			currentCrabState.ACBBHJIMGCC();
		}
	}

	public void JDIHPFKOAID(Vector3 DDBOKLAGCDL, bool CDPAMNIPPEC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline() || !CDPAMNIPPEC)
		{
			hitPosition = DDBOKLAGCDL;
			MOKLMJDMHAB(1);
			if (lives > 0)
			{
				JLFBBOJGCKN();
			}
			else if (BEGCPKOAJCP == null)
			{
				BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(JPKGMMBKBNO());
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

	public void PADLLFOACJM(Vector3 DDBOKLAGCDL, bool CDPAMNIPPEC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline() || !CDPAMNIPPEC)
		{
			hitPosition = DDBOKLAGCDL;
			MAGPALABAAJ(1);
			if (lives > 0)
			{
				NLDFNJNAMOP();
			}
			else if (BEGCPKOAJCP == null)
			{
				BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(GPKPNHHLIHA());
			}
			if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
			{
				onlineTurkey.SendHitToOthers(DDBOKLAGCDL);
			}
		}
		else
		{
			onlineTurkey.AHMDDNJGAFE(DDBOKLAGCDL);
		}
	}

	private void IMGDEEFHDEH()
	{
		JEMFMIHMAOI();
	}

	private void EHPFHLHAHMH()
	{
		HJCOAJEIABK();
	}

	public void JAKECGMLHJN()
	{
		behaviour.SetTrigger(NPC.AEOKENCHHPL);
	}

	public void MOKLMJDMHAB(int MGNOBNCMDJG)
	{
		lives -= MGNOBNCMDJG;
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
			PLPIMMJDMBJ(1);
			if (lives > 0)
			{
				AIIPDDFFBIH();
			}
			else if (BEGCPKOAJCP == null)
			{
				BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(CNAFMGAFEHK());
			}
			if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
			{
				onlineTurkey.FJIMOOMFBOK(DDBOKLAGCDL);
			}
		}
		else
		{
			onlineTurkey.IMKOOOLLAOF(DDBOKLAGCDL);
		}
	}

	public void ODNAEFLANHB(Vector3 DDBOKLAGCDL, bool CDPAMNIPPEC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline() || !CDPAMNIPPEC)
		{
			hitPosition = DDBOKLAGCDL;
			ReduceLife(0);
			if (lives > 0)
			{
				FJEAHPPLGFJ();
			}
			else if (BEGCPKOAJCP == null)
			{
				BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(EHGFNKIMPBD());
			}
			if (OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
			{
				onlineTurkey.FHJNDIDBCIP(DDBOKLAGCDL);
			}
		}
		else
		{
			onlineTurkey.AHMDDNJGAFE(DDBOKLAGCDL);
		}
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

	public void MHNEJNCCJDM()
	{
		behaviour.SetTrigger(NPC.AEOKENCHHPL);
	}

	public void EBKELGLKDBH(Vector3 DDBOKLAGCDL, bool CDPAMNIPPEC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline() || !CDPAMNIPPEC)
		{
			hitPosition = DDBOKLAGCDL;
			PLPIMMJDMBJ(1);
			if (lives > 0)
			{
				ODBIFMNDMHA();
			}
			else if (BEGCPKOAJCP == null)
			{
				BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(AJGBPMMHPGN());
			}
			if (OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
			{
				onlineTurkey.OHCHFJDNCOC(DDBOKLAGCDL);
			}
		}
		else
		{
			onlineTurkey.SendHit(DDBOKLAGCDL);
		}
	}

	public void GAIGAOMIMJF(int MGNOBNCMDJG)
	{
		lives -= MGNOBNCMDJG;
	}

	public int EFKIMLPHEJM()
	{
		return lives;
	}

	private void ICBCMLAIIPF()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(ALHJNAAGGEJ));
		}
		else
		{
			PPICAMAGNME();
		}
		JAKECGMLHJN();
	}

	private void JMAHDPMEEHM()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			_ = GameManager.isLoading;
		}
	}

	public void LAJOCEHPGBP()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentCrabState))
		{
			currentCrabState.LFDEDNGACNG();
		}
	}

	protected override void Awake()
	{
	}

	public void AEHPMEMJEAI(int MGNOBNCMDJG, bool CDPAMNIPPEC)
	{
		lives = MGNOBNCMDJG;
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineTurkey.CAGMIALCHFL(MGNOBNCMDJG);
		}
	}

	public void MCBPDGAEAIG(HitDetection NOCOHCGPMFF)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)NOCOHCGPMFF))
		{
			BGFDGFPEOLO(((Component)PlayerController.OPHDCMJLLEC(NOCOHCGPMFF.playerNum)).transform.position, CDPAMNIPPEC: false);
		}
		else
		{
			EDPDFAIOHDO(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position, CDPAMNIPPEC: false);
		}
	}

	private void OCIHCODJBGC()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(EHPFHLHAHMH));
		}
		else
		{
			PLIFJBMCANA();
		}
		NNMEEOKBILL();
	}

	public void OCNNEIFIDNO(int MGNOBNCMDJG)
	{
		lives -= MGNOBNCMDJG;
	}

	public void CNHEMKHJPPN()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentCrabState))
		{
			currentCrabState.KBCAMBLCAAJ();
		}
	}

	public int IAGFJODCDBJ()
	{
		return lives;
	}

	public void MNJKOGMJJMD()
	{
		behaviour.SetTrigger(NPC.AEOKENCHHPL);
	}

	private IEnumerator JHNIMJDFBPE()
	{
		if (OnlineManager.MasterOrOffline())
		{
			crabAnimation.SetBool(NPC.PFGHDNAOKBK, EGFGNGJGBOP: false);
			if (OnlineManager.PlayingOnline())
			{
				onlineTurkey.SendBool(DMBFKFLDDLH: false);
			}
			Vector3 val = ((Component)this).transform.position - hitPosition;
			rb.bodyType = (RigidbodyType2D)0;
			rb.velocity = Vector2.zero;
			rb.AddForce(Vector2.op_Implicit(val * 300f));
		}
		crabAnimation.SetBool(NPC.PFGHDNAOKBK, EGFGNGJGBOP: true);
		if (OnlineManager.PlayingOnline())
		{
			onlineTurkey.SendBool(DMBFKFLDDLH: true);
		}
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.heavyPunch, ((Component)this).transform);
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
			DroppedItem.SpawnDroppedItem(((Component)this).gameObject.transform.position, crabDrop.item, crabDrop.amount);
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)this).transform);
			poolObject.ReturnToPool();
		}
		BEGCPKOAJCP = null;
	}

	private void OHLENFCHGOD()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		hitFx.SetActive(false);
		crabAnimation.SetBool(NPC.PFGHDNAOKBK, EGFGNGJGBOP: true, HALNIEBONKH: true);
		if (OnlineManager.PlayingOnline())
		{
			onlineTurkey.SendBool(DMBFKFLDDLH: true);
		}
		if (OnlineManager.PGAGDFAEEFB())
		{
			Vector3 val = ((Component)this).transform.position - hitPosition;
			rb.bodyType = (RigidbodyType2D)1;
			rb.velocity = Vector2.zero;
			rb.AddForce(Vector2.op_Implicit(val * 1481f));
			hitCollider.SetActive(false);
			walkTo.isActive = true;
		}
		hitFx.SetActive(true);
		crabAnimation.SetBool(NPC.PFGHDNAOKBK, EGFGNGJGBOP: false);
		if (OnlineManager.PlayingOnline())
		{
			onlineTurkey.MICLDCIGCCE(DMBFKFLDDLH: false);
		}
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.heavyPunch, ((Component)this).transform);
		((MonoBehaviour)this).StartCoroutine(HCMKPKLIICM());
		if (OnlineManager.PGAGDFAEEFB())
		{
			behaviour.SetTrigger(NPC.LHDAIEDAFGL);
		}
	}

	public void PIEAKAIHNNN()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentCrabState))
		{
			currentCrabState.LKNBDIEAPKD();
		}
	}

	private IEnumerator JPKGMMBKBNO()
	{
		if (OnlineManager.MasterOrOffline())
		{
			crabAnimation.SetBool(NPC.PFGHDNAOKBK, EGFGNGJGBOP: false);
			if (OnlineManager.PlayingOnline())
			{
				onlineTurkey.SendBool(DMBFKFLDDLH: false);
			}
			Vector3 val = ((Component)this).transform.position - hitPosition;
			rb.bodyType = (RigidbodyType2D)0;
			rb.velocity = Vector2.zero;
			rb.AddForce(Vector2.op_Implicit(val * 300f));
		}
		crabAnimation.SetBool(NPC.PFGHDNAOKBK, EGFGNGJGBOP: true);
		if (OnlineManager.PlayingOnline())
		{
			onlineTurkey.SendBool(DMBFKFLDDLH: true);
		}
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.heavyPunch, ((Component)this).transform);
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
			DroppedItem.SpawnDroppedItem(((Component)this).gameObject.transform.position, crabDrop.item, crabDrop.amount);
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)this).transform);
			poolObject.ReturnToPool();
		}
		BEGCPKOAJCP = null;
	}

	private void NMMGFOGBHJO()
	{
		ENPJHFLIALN();
	}

	public void IADCOIKCBFD(int MGNOBNCMDJG, bool CDPAMNIPPEC)
	{
		lives = MGNOBNCMDJG;
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineTurkey.DJNIGDCGOFM(MGNOBNCMDJG);
		}
	}

	public void CJCEKLCIDGH()
	{
		behaviour.SetTrigger(NPC.AEOKENCHHPL);
	}

	private void LJDDMNADNPF()
	{
		CPFDLKMCBCB();
	}

	public void IAIGDKLHGCP(Vector3 DDBOKLAGCDL, bool CDPAMNIPPEC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline() || !CDPAMNIPPEC)
		{
			hitPosition = DDBOKLAGCDL;
			GAIGAOMIMJF(1);
			if (lives > 1)
			{
				FNFDDCPKOLI();
			}
			else if (BEGCPKOAJCP == null)
			{
				BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(JHNIMJDFBPE());
			}
			if (OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
			{
				onlineTurkey.FHJNDIDBCIP(DDBOKLAGCDL);
			}
		}
		else
		{
			onlineTurkey.SendHit(DDBOKLAGCDL);
		}
	}

	private void JHKLCLMMOGC()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(EHPFHLHAHMH));
		}
		else
		{
			ENPJHFLIALN();
		}
		NNGIDOAHFLF();
	}

	private IEnumerator LANCGBODAMN()
	{
		crabSprite.color = Color.red;
		yield return CommonReferences.wait01;
		crabSprite.color = Color.white;
		yield return CommonReferences.wait01;
		crabSprite.color = Color.red;
		yield return CommonReferences.wait01;
		crabSprite.color = Color.white;
		if (OnlineManager.MasterOrOffline())
		{
			hitCollider.SetActive(false);
			rb.bodyType = (RigidbodyType2D)1;
		}
	}

	private IEnumerator ICNJGIHJEHO()
	{
		return new EHDJHGDAADL(1)
		{
			_003C_003E4__this = this
		};
	}

	public void APAEBDOGJMN(int MGNOBNCMDJG, bool CDPAMNIPPEC)
	{
		lives = MGNOBNCMDJG;
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineTurkey.DJNIGDCGOFM(MGNOBNCMDJG);
		}
	}

	private void ALHJNAAGGEJ()
	{
		PLIFJBMCANA();
	}

	private IEnumerator HOHCFJOFLIF()
	{
		return new EHDJHGDAADL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator KDJILNBNJKJ()
	{
		return new EHDJHGDAADL(1)
		{
			_003C_003E4__this = this
		};
	}

	public void BKHGLCBEIPJ()
	{
		behaviour.SetTrigger(NPC.AEOKENCHHPL);
	}

	public void CLONALNHIIO(HitDetection NOCOHCGPMFF)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)NOCOHCGPMFF))
		{
			CDCGNLAKHNM(((Component)PlayerController.OPHDCMJLLEC(NOCOHCGPMFF.playerNum)).transform.position, CDPAMNIPPEC: false);
		}
		else
		{
			IAIGDKLHGCP(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position, CDPAMNIPPEC: false);
		}
	}

	public void FJMAEEKNAOH()
	{
		behaviour.SetTrigger(NPC.AEOKENCHHPL);
	}

	private void JLFBBOJGCKN()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		hitFx.SetActive(false);
		crabAnimation.SetBool(NPC.PFGHDNAOKBK, EGFGNGJGBOP: false);
		if (OnlineManager.PlayingOnline())
		{
			onlineTurkey.MICLDCIGCCE(DMBFKFLDDLH: false);
		}
		if (OnlineManager.MasterOrOffline())
		{
			Vector3 val = ((Component)this).transform.position - hitPosition;
			rb.bodyType = (RigidbodyType2D)1;
			rb.velocity = Vector2.zero;
			rb.AddForce(Vector2.op_Implicit(val * 307f));
			hitCollider.SetActive(false);
			walkTo.isActive = false;
		}
		hitFx.SetActive(true);
		crabAnimation.SetBool(NPC.PFGHDNAOKBK, EGFGNGJGBOP: false);
		if (OnlineManager.PlayingOnline())
		{
			onlineTurkey.IPBBGJHIAAE(DMBFKFLDDLH: true);
		}
		MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().heavyPunch, ((Component)this).transform);
		((MonoBehaviour)this).StartCoroutine(LNDDAPPPODO());
		if (OnlineManager.PGAGDFAEEFB())
		{
			behaviour.SetTrigger(NPC.LHDAIEDAFGL);
		}
	}

	public void PMJIGBGALPF(HitDetection NOCOHCGPMFF)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)NOCOHCGPMFF))
		{
			CDCGNLAKHNM(((Component)PlayerController.OPHDCMJLLEC(NOCOHCGPMFF.playerNum)).transform.position, CDPAMNIPPEC: false);
		}
		else
		{
			ODNAEFLANHB(((Component)PlayerController.OPHDCMJLLEC(0)).transform.position, CDPAMNIPPEC: false);
		}
	}

	private void BJOOCKCBPLJ()
	{
		if (OnlineManager.ClientOnline())
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(NMMGFOGBHJO));
		}
		else
		{
			CPFDLKMCBCB();
		}
		MNJKOGMJJMD();
	}

	public void BGFDGFPEOLO(Vector3 DDBOKLAGCDL, bool CDPAMNIPPEC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline() || !CDPAMNIPPEC)
		{
			hitPosition = DDBOKLAGCDL;
			MAGPALABAAJ(0);
			if (lives > 1)
			{
				DBELBNPLGOF();
			}
			else if (BEGCPKOAJCP == null)
			{
				BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(DIECNFEFKPP());
			}
			if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
			{
				onlineTurkey.ACJIELGLAJB(DDBOKLAGCDL);
			}
		}
		else
		{
			onlineTurkey.IMKOOOLLAOF(DDBOKLAGCDL);
		}
	}

	private IEnumerator LNDDAPPPODO()
	{
		crabSprite.color = Color.red;
		yield return CommonReferences.wait01;
		crabSprite.color = Color.white;
		yield return CommonReferences.wait01;
		crabSprite.color = Color.red;
		yield return CommonReferences.wait01;
		crabSprite.color = Color.white;
		if (OnlineManager.MasterOrOffline())
		{
			hitCollider.SetActive(false);
			rb.bodyType = (RigidbodyType2D)1;
		}
	}

	private IEnumerator GPKPNHHLIHA()
	{
		return new EHDJHGDAADL(1)
		{
			_003C_003E4__this = this
		};
	}

	[CompilerGenerated]
	private void JHFOKANCFAC()
	{
		CPFDLKMCBCB();
	}

	public void PLPIMMJDMBJ(int MGNOBNCMDJG)
	{
		lives -= MGNOBNCMDJG;
	}

	public int JAODKLKBMDP()
	{
		return lives;
	}

	public void HAHFKJCIPKH()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentCrabState))
		{
			currentCrabState.CDCDBGGEFJA();
		}
	}

	private IEnumerator HDPMDOGJMLB()
	{
		crabSprite.color = Color.red;
		yield return CommonReferences.wait01;
		crabSprite.color = Color.white;
		yield return CommonReferences.wait01;
		crabSprite.color = Color.red;
		yield return CommonReferences.wait01;
		crabSprite.color = Color.white;
		if (OnlineManager.MasterOrOffline())
		{
			hitCollider.SetActive(false);
			rb.bodyType = (RigidbodyType2D)1;
		}
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
			if (lives > 0)
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

	public void ONKHBDGNKAE(int MGNOBNCMDJG, bool CDPAMNIPPEC)
	{
		lives = MGNOBNCMDJG;
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineTurkey.CLHAOJKJGOL(MGNOBNCMDJG);
		}
	}

	private void FNFDDCPKOLI()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		hitFx.SetActive(false);
		crabAnimation.SetBool(NPC.PFGHDNAOKBK, EGFGNGJGBOP: false);
		if (OnlineManager.PlayingOnline())
		{
			onlineTurkey.SendBool(DMBFKFLDDLH: false);
		}
		if (OnlineManager.MasterOrOffline())
		{
			Vector3 val = ((Component)this).transform.position - hitPosition;
			rb.bodyType = (RigidbodyType2D)0;
			rb.velocity = Vector2.zero;
			rb.AddForce(Vector2.op_Implicit(val * 250f));
			hitCollider.SetActive(true);
			walkTo.isActive = false;
		}
		hitFx.SetActive(true);
		crabAnimation.SetBool(NPC.PFGHDNAOKBK, EGFGNGJGBOP: true);
		if (OnlineManager.PlayingOnline())
		{
			onlineTurkey.SendBool(DMBFKFLDDLH: true);
		}
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.heavyPunch, ((Component)this).transform);
		((MonoBehaviour)this).StartCoroutine(AAGGGBAPFGJ());
		if (OnlineManager.MasterOrOffline())
		{
			behaviour.SetTrigger(NPC.LHDAIEDAFGL);
		}
	}

	public int CICLHBNMPJF()
	{
		return lives;
	}

	public void PAJFOHKANCK(int MGNOBNCMDJG, bool CDPAMNIPPEC)
	{
		lives = MGNOBNCMDJG;
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineTurkey.HNINNFAHGLJ(MGNOBNCMDJG);
		}
	}

	public int HGBEAHBFAJL()
	{
		return lives;
	}

	public void HEAJPFFIHKC(int MGNOBNCMDJG, bool CDPAMNIPPEC)
	{
		lives = MGNOBNCMDJG;
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineTurkey.JGDALHDACDC(MGNOBNCMDJG);
		}
	}

	private void EAEHECFBDLI()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		hitFx.SetActive(true);
		crabAnimation.SetBool(NPC.PFGHDNAOKBK, EGFGNGJGBOP: false, HALNIEBONKH: true);
		if (OnlineManager.PlayingOnline())
		{
			onlineTurkey.MCHIMNKHDME(DMBFKFLDDLH: false);
		}
		if (OnlineManager.PGAGDFAEEFB())
		{
			Vector3 val = ((Component)this).transform.position - hitPosition;
			rb.bodyType = (RigidbodyType2D)1;
			rb.velocity = Vector2.zero;
			rb.AddForce(Vector2.op_Implicit(val * 1001f));
			hitCollider.SetActive(true);
			walkTo.isActive = true;
		}
		hitFx.SetActive(false);
		crabAnimation.SetBool(NPC.PFGHDNAOKBK, EGFGNGJGBOP: false, HALNIEBONKH: true);
		if (OnlineManager.PlayingOnline())
		{
			onlineTurkey.IPBBGJHIAAE(DMBFKFLDDLH: false);
		}
		MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().heavyPunch, ((Component)this).transform);
		((MonoBehaviour)this).StartCoroutine(LANCGBODAMN());
		if (OnlineManager.PGAGDFAEEFB())
		{
			behaviour.SetTrigger(NPC.LHDAIEDAFGL);
		}
	}

	private void DJHFENAGKPA()
	{
		ENPJHFLIALN();
	}

	private void PCCCFMEALCD()
	{
		ENPJHFLIALN();
	}

	private void NLDFNJNAMOP()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		hitFx.SetActive(false);
		crabAnimation.SetBool(NPC.PFGHDNAOKBK, EGFGNGJGBOP: true, HALNIEBONKH: true);
		if (OnlineManager.PlayingOnline())
		{
			onlineTurkey.GMJDHEANFGH(DMBFKFLDDLH: false);
		}
		if (OnlineManager.PGAGDFAEEFB())
		{
			Vector3 val = ((Component)this).transform.position - hitPosition;
			rb.bodyType = (RigidbodyType2D)0;
			rb.velocity = Vector2.zero;
			rb.AddForce(Vector2.op_Implicit(val * 374f));
			hitCollider.SetActive(false);
			walkTo.isActive = true;
		}
		hitFx.SetActive(false);
		crabAnimation.SetBool(NPC.PFGHDNAOKBK, EGFGNGJGBOP: false);
		if (OnlineManager.PlayingOnline())
		{
			onlineTurkey.NNOLGPDBFML(DMBFKFLDDLH: false);
		}
		MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().heavyPunch, ((Component)this).transform);
		((MonoBehaviour)this).StartCoroutine(HCMKPKLIICM());
		if (OnlineManager.MasterOrOffline())
		{
			behaviour.SetTrigger(NPC.LHDAIEDAFGL);
		}
	}

	public void IMJLMHODDNP()
	{
		behaviour.SetTrigger(NPC.AEOKENCHHPL);
	}

	public void DIECPKPDHAC(int MGNOBNCMDJG, bool CDPAMNIPPEC)
	{
		lives = MGNOBNCMDJG;
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineTurkey.HNINNFAHGLJ(MGNOBNCMDJG);
		}
	}

	private IEnumerator JGPAOHAOLJJ()
	{
		return new LHCACICNMFD(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator EHGFNKIMPBD()
	{
		if (OnlineManager.MasterOrOffline())
		{
			crabAnimation.SetBool(NPC.PFGHDNAOKBK, EGFGNGJGBOP: false);
			if (OnlineManager.PlayingOnline())
			{
				onlineTurkey.SendBool(DMBFKFLDDLH: false);
			}
			Vector3 val = ((Component)this).transform.position - hitPosition;
			rb.bodyType = (RigidbodyType2D)0;
			rb.velocity = Vector2.zero;
			rb.AddForce(Vector2.op_Implicit(val * 300f));
		}
		crabAnimation.SetBool(NPC.PFGHDNAOKBK, EGFGNGJGBOP: true);
		if (OnlineManager.PlayingOnline())
		{
			onlineTurkey.SendBool(DMBFKFLDDLH: true);
		}
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.heavyPunch, ((Component)this).transform);
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
			DroppedItem.SpawnDroppedItem(((Component)this).gameObject.transform.position, crabDrop.item, crabDrop.amount);
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)this).transform);
			poolObject.ReturnToPool();
		}
		BEGCPKOAJCP = null;
	}

	public void NDPIBEEEMGO()
	{
		behaviour.SetTrigger(NPC.AEOKENCHHPL);
	}

	private void NFNHFEHHOFD()
	{
		HJCOAJEIABK();
	}

	private void ODBIFMNDMHA()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		hitFx.SetActive(false);
		crabAnimation.SetBool(NPC.PFGHDNAOKBK, EGFGNGJGBOP: true, HALNIEBONKH: true);
		if (OnlineManager.PlayingOnline())
		{
			onlineTurkey.MICLDCIGCCE(DMBFKFLDDLH: false);
		}
		if (OnlineManager.PGAGDFAEEFB())
		{
			Vector3 val = ((Component)this).transform.position - hitPosition;
			rb.bodyType = (RigidbodyType2D)0;
			rb.velocity = Vector2.zero;
			rb.AddForce(Vector2.op_Implicit(val * 1582f));
			hitCollider.SetActive(false);
			walkTo.isActive = true;
		}
		hitFx.SetActive(false);
		crabAnimation.SetBool(NPC.PFGHDNAOKBK, EGFGNGJGBOP: true, HALNIEBONKH: true);
		if (OnlineManager.PlayingOnline())
		{
			onlineTurkey.IPBBGJHIAAE(DMBFKFLDDLH: true);
		}
		MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().heavyPunch, ((Component)this).transform);
		((MonoBehaviour)this).StartCoroutine(AAGGGBAPFGJ());
		if (OnlineManager.PGAGDFAEEFB())
		{
			behaviour.SetTrigger(NPC.LHDAIEDAFGL);
		}
	}

	private IEnumerator HNOCJLLBNHH()
	{
		return new EHDJHGDAADL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator DIECNFEFKPP()
	{
		return new EHDJHGDAADL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CNAFMGAFEHK()
	{
		if (OnlineManager.MasterOrOffline())
		{
			crabAnimation.SetBool(NPC.PFGHDNAOKBK, EGFGNGJGBOP: false);
			if (OnlineManager.PlayingOnline())
			{
				onlineTurkey.SendBool(DMBFKFLDDLH: false);
			}
			Vector3 val = ((Component)this).transform.position - hitPosition;
			rb.bodyType = (RigidbodyType2D)0;
			rb.velocity = Vector2.zero;
			rb.AddForce(Vector2.op_Implicit(val * 300f));
		}
		crabAnimation.SetBool(NPC.PFGHDNAOKBK, EGFGNGJGBOP: true);
		if (OnlineManager.PlayingOnline())
		{
			onlineTurkey.SendBool(DMBFKFLDDLH: true);
		}
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.heavyPunch, ((Component)this).transform);
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
			DroppedItem.SpawnDroppedItem(((Component)this).gameObject.transform.position, crabDrop.item, crabDrop.amount);
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)this).transform);
			poolObject.ReturnToPool();
		}
		BEGCPKOAJCP = null;
	}

	public void CDCGNLAKHNM(Vector3 DDBOKLAGCDL, bool CDPAMNIPPEC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline() || !CDPAMNIPPEC)
		{
			hitPosition = DDBOKLAGCDL;
			OCNNEIFIDNO(0);
			if (lives > 0)
			{
				AIIPDDFFBIH();
			}
			else if (BEGCPKOAJCP == null)
			{
				BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(DIECNFEFKPP());
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

	public void PJFEFLDGEOI(HitDetection NOCOHCGPMFF)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)NOCOHCGPMFF))
		{
			JEEOHKBAHDP(((Component)PlayerController.OPHDCMJLLEC(NOCOHCGPMFF.playerNum)).transform.position, CDPAMNIPPEC: true);
		}
		else
		{
			IAIGDKLHGCP(((Component)PlayerController.GetPlayer(0)).transform.position, CDPAMNIPPEC: false);
		}
	}

	public void GNEEBFMCPOH(HitDetection NOCOHCGPMFF)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)NOCOHCGPMFF))
		{
			EDPDFAIOHDO(((Component)PlayerController.GetPlayer(NOCOHCGPMFF.playerNum)).transform.position, CDPAMNIPPEC: true);
		}
		else
		{
			PKCKLIPCCAL(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position, CDPAMNIPPEC: true);
		}
	}

	private void DCCJBKGNAOP()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(MBAEOKJIFFG));
		}
		else
		{
			HJCOAJEIABK();
		}
		BKHGLCBEIPJ();
	}

	public void JEEOHKBAHDP(Vector3 DDBOKLAGCDL, bool CDPAMNIPPEC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline() || !CDPAMNIPPEC)
		{
			hitPosition = DDBOKLAGCDL;
			NFGNFBBMLFP(1);
			if (lives > 0)
			{
				OHLENFCHGOD();
			}
			else if (BEGCPKOAJCP == null)
			{
				BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(AJGBPMMHPGN());
			}
			if (OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
			{
				onlineTurkey.DMDKIMJEKNN(DDBOKLAGCDL);
			}
		}
		else
		{
			onlineTurkey.AHMDDNJGAFE(DDBOKLAGCDL);
		}
	}

	public void MAGPALABAAJ(int MGNOBNCMDJG)
	{
		lives -= MGNOBNCMDJG;
	}

	public void WalkAround()
	{
		behaviour.SetTrigger(NPC.AEOKENCHHPL);
	}

	public void PLMIJFDHDNB()
	{
		behaviour.SetTrigger(NPC.AEOKENCHHPL);
	}

	public void HIJOGDHBCOI()
	{
		behaviour.SetTrigger(NPC.AEOKENCHHPL);
	}

	private void MBAEOKJIFFG()
	{
		PPICAMAGNME();
	}

	private void NKGNABOCPDG()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			_ = GameManager.isLoading;
		}
	}

	protected override void CPFDLKMCBCB()
	{
		SetLife(3, CDPAMNIPPEC: true);
		currentCrabState = null;
		base.CPFDLKMCBCB();
	}

	public void OHGGFMHJJOL(HitDetection NOCOHCGPMFF)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)NOCOHCGPMFF))
		{
			ODNAEFLANHB(((Component)PlayerController.OPHDCMJLLEC(NOCOHCGPMFF.playerNum)).transform.position, CDPAMNIPPEC: true);
		}
		else
		{
			PKCKLIPCCAL(((Component)PlayerController.GetPlayer(0)).transform.position, CDPAMNIPPEC: false);
		}
	}

	public void NFGNFBBMLFP(int MGNOBNCMDJG)
	{
		lives -= MGNOBNCMDJG;
	}

	private void PGADFNKIPBD()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		hitFx.SetActive(false);
		crabAnimation.SetBool(NPC.PFGHDNAOKBK, EGFGNGJGBOP: true);
		if (OnlineManager.PlayingOnline())
		{
			onlineTurkey.IPBBGJHIAAE(DMBFKFLDDLH: true);
		}
		if (OnlineManager.PGAGDFAEEFB())
		{
			Vector3 val = ((Component)this).transform.position - hitPosition;
			rb.bodyType = (RigidbodyType2D)0;
			rb.velocity = Vector2.zero;
			rb.AddForce(Vector2.op_Implicit(val * 141f));
			hitCollider.SetActive(false);
			walkTo.isActive = false;
		}
		hitFx.SetActive(true);
		crabAnimation.SetBool(NPC.PFGHDNAOKBK, EGFGNGJGBOP: false);
		if (OnlineManager.PlayingOnline())
		{
			onlineTurkey.MICLDCIGCCE(DMBFKFLDDLH: false);
		}
		MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().heavyPunch, ((Component)this).transform);
		((MonoBehaviour)this).StartCoroutine(HDPMDOGJMLB());
		if (OnlineManager.MasterOrOffline())
		{
			behaviour.SetTrigger(NPC.LHDAIEDAFGL);
		}
	}

	public void JPAPOBCAMAB(HitDetection NOCOHCGPMFF)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)NOCOHCGPMFF))
		{
			EEBNOILEJAC(((Component)PlayerController.GetPlayer(NOCOHCGPMFF.playerNum)).transform.position, CDPAMNIPPEC: true);
		}
		else
		{
			ODNAEFLANHB(((Component)PlayerController.GetPlayer(0)).transform.position, CDPAMNIPPEC: false);
		}
	}

	private void AIIPDDFFBIH()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		hitFx.SetActive(false);
		crabAnimation.SetBool(NPC.PFGHDNAOKBK, EGFGNGJGBOP: false, HALNIEBONKH: true);
		if (OnlineManager.PlayingOnline())
		{
			onlineTurkey.MCHIMNKHDME(DMBFKFLDDLH: true);
		}
		if (OnlineManager.MasterOrOffline())
		{
			Vector3 val = ((Component)this).transform.position - hitPosition;
			rb.bodyType = (RigidbodyType2D)0;
			rb.velocity = Vector2.zero;
			rb.AddForce(Vector2.op_Implicit(val * 254f));
			hitCollider.SetActive(false);
			walkTo.isActive = true;
		}
		hitFx.SetActive(true);
		crabAnimation.SetBool(NPC.PFGHDNAOKBK, EGFGNGJGBOP: false);
		if (OnlineManager.PlayingOnline())
		{
			onlineTurkey.SendBool(DMBFKFLDDLH: false);
		}
		MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().heavyPunch, ((Component)this).transform);
		((MonoBehaviour)this).StartCoroutine(HCMKPKLIICM());
		if (OnlineManager.PGAGDFAEEFB())
		{
			behaviour.SetTrigger(NPC.LHDAIEDAFGL);
		}
	}
}
