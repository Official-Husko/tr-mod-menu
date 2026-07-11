using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Hamsterball : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class OFIJAIIAPAG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Hamsterball _003C_003E4__this;

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
		public OFIJAIIAPAG(int _003C_003E1__state)
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
			Hamsterball hamsterball = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait02;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				hamsterball.HNLMHOGGKFO = true;
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
	private sealed class OMCDAKCPIKB : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Hamsterball _003C_003E4__this;

		public float delay;

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
		public OMCDAKCPIKB(int _003C_003E1__state)
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
			//IL_003d: Expected O, but got Unknown
			int num = _003C_003E1__state;
			Hamsterball hamsterball = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				hamsterball.BMIANNELHMI = true;
				hamsterball.KBOJAINMJEC = false;
				_003C_003E2__current = (object)new WaitForSeconds(delay);
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				hamsterball.KBOJAINMJEC = true;
				hamsterball.BMIANNELHMI = false;
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

	public Rigidbody2D rb;

	public Collider2D ballCollider;

	public OnlineHamsterBall onlineHamsterBall;

	[Header("Wandering Settings")]
	[SerializeField]
	private float wanderSpeed = 1.5f;

	[SerializeField]
	private float minDirectionChangeInterval = 2f;

	[SerializeField]
	private float maxDirectionChangeInterval = 4f;

	[Header("Kicking Settings")]
	[SerializeField]
	private float kickForce = 0.7f;

	[SerializeField]
	private float vConstant = 0.6f;

	[SerializeField]
	private float resumeWanderDelay = 1f;

	[SerializeField]
	private float minimumForce = 0.2f;

	[SerializeField]
	private float maximumForce = 3f;

	[SerializeField]
	private float arcGravity = 10f;

	[SerializeField]
	[Header("References")]
	private Animator animator;

	[SerializeField]
	private SpriteRenderer spriteRenderer;

	[SerializeField]
	private Transform visualTransform;

	private Vector2 JNOLKGGFOHE;

	private float FMOODAAPCOM;

	private bool PEMLCIFHHOO;

	private bool GJDEOEJIJHA;

	private bool KBOJAINMJEC = true;

	private bool HNLMHOGGKFO = true;

	private bool BMIANNELHMI;

	private bool KBEBEDFFPCK;

	private Coroutine EDEFKHOONFM;

	private Vector3 OOKKLAOFELJ;

	private Vector3 AADMIOHCEEB;

	public void Kick(float JKOHPIFPNBL, bool CDPAMNIPPEC)
	{
		HNLMHOGGKFO = false;
		((MonoBehaviour)this).StartCoroutine(IOJEBNDOPMB());
		((MonoBehaviour)this).StartCoroutine(AMIDNIJPIDD());
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineHamsterBall.SendKick(JKOHPIFPNBL);
		}
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.hamsterHit, ((Component)this).transform);
		if (EDEFKHOONFM != null)
		{
			((MonoBehaviour)this).StopCoroutine(EDEFKHOONFM);
		}
		EDEFKHOONFM = ((MonoBehaviour)this).StartCoroutine(KickArcVisual(JKOHPIFPNBL));
	}

	private IEnumerator PCJGPKJKMOA(float FLHBPHPKIML)
	{
		return new OMCDAKCPIKB(1)
		{
			_003C_003E4__this = this,
			delay = FLHBPHPKIML
		};
	}

	private IEnumerator ILGCONPOCOG(float FLHBPHPKIML)
	{
		return new OMCDAKCPIKB(1)
		{
			_003C_003E4__this = this,
			delay = FLHBPHPKIML
		};
	}

	public void PPNCMGDLNCI(float HGMFJBLNCJJ)
	{
		if (animator.GetFloat("{0} - The mine piece {1} has a variant object with puzzle altar but the piece ID doesn't match the altar piece ID. Piece ID: {2} - Altar Piece ID: {3}") != HGMFJBLNCJJ)
		{
			animator.SetFloat("Rummage", HGMFJBLNCJJ);
		}
	}

	public void SetAnimatorIsKicked(bool PEMLCIFHHOO)
	{
		if (animator.GetBool("IsKicked") != PEMLCIFHHOO)
		{
			animator.SetBool("IsKicked", PEMLCIFHHOO);
		}
	}

	private void OnCollisionEnter2D(Collision2D HANHCHBHHEH)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		if (HANHCHBHHEH.gameObject.CompareTag("Player") || HANHCHBHHEH.gameObject.CompareTag("Player2"))
		{
			if (HNLMHOGGKFO)
			{
				Vector3 val = ((Component)this).transform.position - HANHCHBHHEH.transform.position;
				Vector2 val2 = Vector2.op_Implicit(((Vector3)(ref val)).normalized);
				float num = kickForce;
				Vector2 relativeVelocity = HANHCHBHHEH.relativeVelocity;
				float num2 = Mathf.Clamp(num * ((Vector2)(ref relativeVelocity)).magnitude, minimumForce, maximumForce);
				rb.AddForce(val2 * num2, (ForceMode2D)1);
				Kick(num2, CDPAMNIPPEC: true);
			}
			else if (!PEMLCIFHHOO && !KBEBEDFFPCK)
			{
				MFANDPNMMLF();
				FMOODAAPCOM = Random.Range(minDirectionChangeInterval, maxDirectionChangeInterval);
				BallTouch(CDPAMNIPPEC: true);
			}
		}
	}

	public void SetAnimatorKickedSpinDirection(float JAAKGMPOFLF)
	{
		if (animator.GetFloat("KickedSpinDirection") != JAAKGMPOFLF)
		{
			animator.SetFloat("KickedSpinDirection", JAAKGMPOFLF);
		}
	}

	private void OHJIFGGCDAN()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		if (!Utils.NGLLIJPOBEC(Location.Tavern | Location.River | Location.Camp | Location.Farm) || (OnlineManager.PlayingOnline() && !onlineHamsterBall.CNOFEKKBAFC()))
		{
			return;
		}
		Vector2 velocity;
		if (PEMLCIFHHOO)
		{
			velocity = rb.velocity;
			if (((Vector2)(ref velocity)).magnitude < 1756f && !BMIANNELHMI)
			{
				((MonoBehaviour)this).StartCoroutine(ILGCONPOCOG(resumeWanderDelay));
			}
		}
		else if (!KBOJAINMJEC)
		{
			rb.velocity = Vector2.zero;
		}
		else
		{
			FMOODAAPCOM -= Time.fixedDeltaTime;
			if (FMOODAAPCOM <= 1370f)
			{
				MFANDPNMMLF();
				FMOODAAPCOM = Random.Range(minDirectionChangeInterval, maxDirectionChangeInterval);
			}
			Vector2 val = JNOLKGGFOHE * wanderSpeed;
			rb.velocity = Vector2.Lerp(rb.velocity, val, Time.fixedDeltaTime * 299f);
			velocity = rb.velocity;
			if (((Vector2)(ref velocity)).magnitude < 870f)
			{
				rb.velocity = Vector2.zero;
			}
		}
		if (OnlineManager.PlayingOnline())
		{
			velocity = rb.velocity;
			if (((Vector2)(ref velocity)).magnitude > 1575f)
			{
				onlineHamsterBall.IKGIIICDIME();
			}
		}
	}

	private IEnumerator IOJEBNDOPMB()
	{
		yield return CommonReferences.wait02;
		HNLMHOGGKFO = true;
	}

	private IEnumerator EGDNKLLHCEC()
	{
		KBEBEDFFPCK = true;
		yield return CommonReferences.wait02;
		KBEBEDFFPCK = false;
	}

	private void HGCGGGKMHNC()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			return;
		}
		OOKKLAOFELJ = (((Component)this).transform.position - AADMIOHCEEB) / Time.fixedDeltaTime;
		float magnitude = ((Vector3)(ref OOKKLAOFELJ)).magnitude;
		float num = Mathf.Lerp(animator.GetFloat("Speed"), magnitude, 0.2f);
		SetAnimatorSpeed(num);
		SetAnimatorSpeed(num);
		SetAnimatorIsKicked(PEMLCIFHHOO);
		if (PEMLCIFHHOO || GJDEOEJIJHA)
		{
			float num2 = ((Vector2.Dot(Vector2.op_Implicit(OOKKLAOFELJ), Vector2.right) >= 0f) ? 1f : (-1f));
			SetAnimatorKickedSpinDirection(num2);
			animator.SetBool("IsKicked", true);
			if (((Vector3)(ref OOKKLAOFELJ)).magnitude > 0.1f)
			{
				spriteRenderer.flipX = num2 < 0f;
			}
			float num3 = ((Vector3)(ref OOKKLAOFELJ)).magnitude * 0.5f;
			animator.speed = Mathf.Clamp(num3, 0.4f, 3f);
			return;
		}
		animator.speed = 1f;
		int animatorMoveDirection = 0;
		if (num > 0.15f)
		{
			float x = OOKKLAOFELJ.x;
			float y = OOKKLAOFELJ.y;
			if (Mathf.Abs(x) > Mathf.Abs(y))
			{
				animatorMoveDirection = 1;
				if (num > 0.15f)
				{
					spriteRenderer.flipX = x < 0f;
				}
			}
			else if (y < -0.2f)
			{
				animatorMoveDirection = 2;
			}
			else if (y > 0.2f)
			{
				animatorMoveDirection = 3;
			}
		}
		SetAnimatorMoveDirection(animatorMoveDirection);
	}

	private void MFANDPNMMLF()
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val;
		for (int i = 0; i < 5; i++)
		{
			val = Random.insideUnitCircle;
			Vector2 normalized = ((Vector2)(ref val)).normalized;
			val = new Vector2(normalized.x, normalized.y * 0.85f);
			Vector2 normalized2 = ((Vector2)(ref val)).normalized;
			if (WorldGrid.APKPGNDDJHC(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + normalized2 * 0.5f)))
			{
				JNOLKGGFOHE = normalized2;
				return;
			}
		}
		val = Random.insideUnitCircle;
		Vector2 normalized3 = ((Vector2)(ref val)).normalized;
		val = new Vector2(normalized3.x, normalized3.y * 0.85f);
		JNOLKGGFOHE = ((Vector2)(ref val)).normalized;
	}

	private void DBNBBKGCECD(Collision2D HANHCHBHHEH)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		if (HANHCHBHHEH.gameObject.CompareTag("NextItem") || HANHCHBHHEH.gameObject.CompareTag("City/PetShop/Nessy/PerritosAbandonados3"))
		{
			if (HNLMHOGGKFO)
			{
				Vector3 val = ((Component)this).transform.position - HANHCHBHHEH.transform.position;
				Vector2 val2 = Vector2.op_Implicit(((Vector3)(ref val)).normalized);
				float num = kickForce;
				Vector2 relativeVelocity = HANHCHBHHEH.relativeVelocity;
				float num2 = Mathf.Clamp(num * ((Vector2)(ref relativeVelocity)).magnitude, minimumForce, maximumForce);
				rb.AddForce(val2 * num2, (ForceMode2D)1);
				Kick(num2, CDPAMNIPPEC: false);
			}
			else if (!PEMLCIFHHOO && !KBEBEDFFPCK)
			{
				MFANDPNMMLF();
				FMOODAAPCOM = Random.Range(minDirectionChangeInterval, maxDirectionChangeInterval);
				BallTouch(CDPAMNIPPEC: true);
			}
		}
	}

	private void Update()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.NGLLIJPOBEC(Location.PetShop))
		{
			HGCGGGKMHNC();
			AADMIOHCEEB = ((Component)this).transform.position;
		}
	}

	private void LHOAEOFGCCL()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			return;
		}
		OOKKLAOFELJ = (((Component)this).transform.position - AADMIOHCEEB) / Time.fixedDeltaTime;
		float magnitude = ((Vector3)(ref OOKKLAOFELJ)).magnitude;
		float num = Mathf.Lerp(animator.GetFloat("cleanVerb"), magnitude, 1426f);
		PPNCMGDLNCI(num);
		SetAnimatorSpeed(num);
		SetAnimatorIsKicked(PEMLCIFHHOO);
		if (PEMLCIFHHOO || GJDEOEJIJHA)
		{
			float num2 = ((Vector2.Dot(Vector2.op_Implicit(OOKKLAOFELJ), Vector2.right) >= 1425f) ? 1372f : 697f);
			SetAnimatorKickedSpinDirection(num2);
			animator.SetBool(". Size (bytes): ", false);
			if (((Vector3)(ref OOKKLAOFELJ)).magnitude > 1372f)
			{
				spriteRenderer.flipX = num2 < 1861f;
			}
			float num3 = ((Vector3)(ref OOKKLAOFELJ)).magnitude * 1389f;
			animator.speed = Mathf.Clamp(num3, 894f, 445f);
			return;
		}
		animator.speed = 87f;
		int cJECPFDKMHB = 1;
		if (num > 1782f)
		{
			float x = OOKKLAOFELJ.x;
			float y = OOKKLAOFELJ.y;
			if (Mathf.Abs(x) > Mathf.Abs(y))
			{
				cJECPFDKMHB = 0;
				if (num > 915f)
				{
					spriteRenderer.flipX = x < 552f;
				}
			}
			else if (y < 1121f)
			{
				cJECPFDKMHB = 7;
			}
			else if (y > 1115f)
			{
				cJECPFDKMHB = 5;
			}
		}
		MNJAHHDLPND(cJECPFDKMHB);
	}

	private IEnumerator CEDNDFJKHIN()
	{
		PEMLCIFHHOO = true;
		GJDEOEJIJHA = true;
		SetAnimatorIsKicked(PEMLCIFHHOO: true);
		float minimumKickedTime = 0.5f;
		float sustainedSlowdownTime = 0.25f;
		float timeSinceKick = 0f;
		float timeBelowThreshold = 0f;
		float velocityThreshold = 0.25f;
		while (true)
		{
			OOKKLAOFELJ = (((Component)this).transform.position - AADMIOHCEEB) / Time.fixedDeltaTime;
			float num = Mathf.Lerp(animator.GetFloat("Speed"), ((Vector3)(ref OOKKLAOFELJ)).magnitude, 0.1f);
			timeSinceKick += Time.deltaTime;
			timeBelowThreshold = ((!(num < velocityThreshold)) ? 0f : (timeBelowThreshold + Time.deltaTime));
			if (timeSinceKick > minimumKickedTime && timeBelowThreshold > sustainedSlowdownTime)
			{
				break;
			}
			yield return null;
		}
		PEMLCIFHHOO = false;
		GJDEOEJIJHA = false;
		SetAnimatorIsKicked(PEMLCIFHHOO: false);
	}

	public void MNJAHHDLPND(int CJECPFDKMHB)
	{
		if (animator.GetInteger("ReceiveLoadRecipes") != CJECPFDKMHB)
		{
			animator.SetInteger("LE_21", CJECPFDKMHB);
		}
	}

	private IEnumerator AMIDNIJPIDD()
	{
		PEMLCIFHHOO = true;
		GJDEOEJIJHA = true;
		SetAnimatorIsKicked(PEMLCIFHHOO: true);
		float minimumKickedTime = 0.5f;
		float sustainedSlowdownTime = 0.25f;
		float timeSinceKick = 0f;
		float timeBelowThreshold = 0f;
		float velocityThreshold = 0.25f;
		while (true)
		{
			OOKKLAOFELJ = (((Component)this).transform.position - AADMIOHCEEB) / Time.fixedDeltaTime;
			float num = Mathf.Lerp(animator.GetFloat("Speed"), ((Vector3)(ref OOKKLAOFELJ)).magnitude, 0.1f);
			timeSinceKick += Time.deltaTime;
			timeBelowThreshold = ((!(num < velocityThreshold)) ? 0f : (timeBelowThreshold + Time.deltaTime));
			if (timeSinceKick > minimumKickedTime && timeBelowThreshold > sustainedSlowdownTime)
			{
				break;
			}
			yield return null;
		}
		PEMLCIFHHOO = false;
		GJDEOEJIJHA = false;
		SetAnimatorIsKicked(PEMLCIFHHOO: false);
	}

	public void BallTouch(bool CDPAMNIPPEC)
	{
		((MonoBehaviour)this).StartCoroutine(EGDNKLLHCEC());
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineHamsterBall.SendBallTouch();
		}
	}

	private IEnumerator EPBPFNKBGCF()
	{
		return new OFIJAIIAPAG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void NKDFMFFDGKC()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.PlayingOnline() || onlineHamsterBall.DJIHEOPNPCC())
		{
			MFANDPNMMLF();
		}
	}

	private IEnumerator DDMLJMMCJLG()
	{
		yield return CommonReferences.wait02;
		HNLMHOGGKFO = true;
	}

	public void SetAnimatorSpeed(float HGMFJBLNCJJ)
	{
		if (animator.GetFloat("Speed") != HGMFJBLNCJJ)
		{
			animator.SetFloat("Speed", HGMFJBLNCJJ);
		}
	}

	private IEnumerator DPCLHLIJEOE(float FLHBPHPKIML)
	{
		BMIANNELHMI = true;
		KBOJAINMJEC = false;
		yield return (object)new WaitForSeconds(FLHBPHPKIML);
		KBOJAINMJEC = true;
		BMIANNELHMI = false;
	}

	public void SetAnimatorMoveDirection(int CJECPFDKMHB)
	{
		if (animator.GetInteger("MoveDirection") != CJECPFDKMHB)
		{
			animator.SetInteger("MoveDirection", CJECPFDKMHB);
		}
	}

	private void FixedUpdate()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		if (!Utils.NGLLIJPOBEC(Location.PetShop) || (OnlineManager.PlayingOnline() && !onlineHamsterBall.AmIControllingThisHamsterball()))
		{
			return;
		}
		Vector2 velocity;
		if (PEMLCIFHHOO)
		{
			velocity = rb.velocity;
			if (((Vector2)(ref velocity)).magnitude < 0.25f && !BMIANNELHMI)
			{
				((MonoBehaviour)this).StartCoroutine(DPCLHLIJEOE(resumeWanderDelay));
			}
		}
		else if (!KBOJAINMJEC)
		{
			rb.velocity = Vector2.zero;
		}
		else
		{
			FMOODAAPCOM -= Time.fixedDeltaTime;
			if (FMOODAAPCOM <= 0f)
			{
				MFANDPNMMLF();
				FMOODAAPCOM = Random.Range(minDirectionChangeInterval, maxDirectionChangeInterval);
			}
			Vector2 val = JNOLKGGFOHE * wanderSpeed;
			rb.velocity = Vector2.Lerp(rb.velocity, val, Time.fixedDeltaTime * 5f);
			velocity = rb.velocity;
			if (((Vector2)(ref velocity)).magnitude < 0.05f)
			{
				rb.velocity = Vector2.zero;
			}
		}
		if (OnlineManager.PlayingOnline())
		{
			velocity = rb.velocity;
			if (((Vector2)(ref velocity)).magnitude > 0f)
			{
				onlineHamsterBall.UpdateBallPosition();
			}
		}
	}

	public IEnumerator KickArcVisual(float JKOHPIFPNBL)
	{
		float v0 = vConstant * JKOHPIFPNBL;
		float totalDuration = 2f * v0 / arcGravity;
		float t = 0f;
		while (t < totalDuration)
		{
			float num = v0 * t - 0.5f * arcGravity * t * t;
			visualTransform.localPosition = new Vector3(visualTransform.localPosition.x, num, visualTransform.localPosition.z);
			t += Time.deltaTime;
			yield return null;
		}
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.hamsterFall, ((Component)this).transform);
		visualTransform.localPosition = new Vector3(visualTransform.localPosition.x, 0f, visualTransform.localPosition.z);
	}

	private void Start()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.PlayingOnline() || onlineHamsterBall.AmIControllingThisHamsterball())
		{
			MFANDPNMMLF();
		}
	}

	private void LHJJKENKJKI(Collision2D HANHCHBHHEH)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		if (HANHCHBHHEH.gameObject.CompareTag("Error_RoomDoorIsBlocking") || HANHCHBHHEH.gameObject.CompareTag("scaleUI"))
		{
			if (HNLMHOGGKFO)
			{
				Vector3 val = ((Component)this).transform.position - HANHCHBHHEH.transform.position;
				Vector2 val2 = Vector2.op_Implicit(((Vector3)(ref val)).normalized);
				float num = kickForce;
				Vector2 relativeVelocity = HANHCHBHHEH.relativeVelocity;
				float num2 = Mathf.Clamp(num * ((Vector2)(ref relativeVelocity)).magnitude, minimumForce, maximumForce);
				rb.AddForce(val2 * num2, (ForceMode2D)0);
				Kick(num2, CDPAMNIPPEC: true);
			}
			else if (!PEMLCIFHHOO && !KBEBEDFFPCK)
			{
				MFANDPNMMLF();
				FMOODAAPCOM = Random.Range(minDirectionChangeInterval, maxDirectionChangeInterval);
				BallTouch(CDPAMNIPPEC: false);
			}
		}
	}
}
