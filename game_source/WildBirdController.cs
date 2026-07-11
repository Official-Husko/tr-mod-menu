using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;

public class WildBirdController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class NLLHKMPNBKH : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WildBirdController _003C_003E4__this;

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
		public NLLHKMPNBKH(int _003C_003E1__state)
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
			WildBirdController wildBirdController = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait5;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				Utils.BLPDAEHPOBA(((Component)wildBirdController).gameObject);
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
	private sealed class IJHMBMPPNHO : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WildBirdController _003C_003E4__this;

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
		public IJHMBMPPNHO(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_010a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			WildBirdController wildBirdController = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
			{
				_003C_003E1__state = -1;
				Vector3 val = ((Component)PlayerController.GetPlayer(playerNum)).transform.position - ((Component)wildBirdController).transform.position;
				wildBirdController.FCGBJEIIMBC = Vector2.op_Implicit(((Vector3)(ref val)).normalized);
				wildBirdController.FCGBJEIIMBC *= -1f;
				wildBirdController.FCGBJEIIMBC.y = Random.Range(0.5f, 1f);
				if (wildBirdController.FCGBJEIIMBC.x < 0f)
				{
					wildBirdController.anim.SetInteger("Direction", 3);
					((Component)wildBirdController).transform.localScale = new Vector3(-1f, 1f, 1f);
				}
				else
				{
					wildBirdController.anim.SetInteger("Direction", 2);
					((Component)wildBirdController).transform.localScale = new Vector3(1f, 1f, 1f);
				}
				wildBirdController.GFJIJLHFNAL = wildBirdController.FCGBJEIIMBC * wildBirdController.HGMFJBLNCJJ * Time.deltaTime;
				wildBirdController.anim.SetTrigger("Fly");
				_003C_003E2__current = CommonReferences.wait02;
				_003C_003E1__state = 1;
				return true;
			}
			case 1:
				_003C_003E1__state = -1;
				((Component)wildBirdController).transform.parent = null;
				((Renderer)wildBirdController.sprite).sortingLayerName = "Top";
				((Renderer)wildBirdController.sprite).sortingOrder = 50;
				((MonoBehaviour)wildBirdController).StartCoroutine(wildBirdController.NMLIOAKGHOO());
				MultiAudioManager.PlayAudioObject(wildBirdController.flyAwaySound, ((Component)wildBirdController).transform);
				wildBirdController.AKHBNMLKKPI = true;
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

	public Animator anim;

	public SpriteRenderer sprite;

	public SpriteRenderer shadow;

	public Material[] birdMaterials;

	public AudioObject birdSound;

	public AudioObject flyAwaySound;

	private float HGMFJBLNCJJ = 3f;

	private Vector2 FCGBJEIIMBC;

	private Vector2 GFJIJLHFNAL;

	private bool AKHBNMLKKPI;

	private float GFLMCJKKDBI = 1f;

	private Color KDEHDOHOILE;

	private Coroutine BEGCPKOAJCP;

	private float AAKMHDIDAME;

	private void DKNMGFDFLKL()
	{
		if (Time.time > AAKMHDIDAME)
		{
			MultiAudioManager.PlayAudioObject(birdSound, ((Component)this).transform);
			AAKMHDIDAME = Time.time + Random.Range(767f, 1357f);
		}
	}

	private void FixedUpdate()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		if (AKHBNMLKKPI)
		{
			((Component)this).transform.Translate(Vector2.op_Implicit(GFJIJLHFNAL));
			((Component)shadow).transform.Translate(Vector2.op_Implicit(new Vector2(0f, -1f) * Time.deltaTime));
			float num = Mathf.Clamp01(Time.deltaTime / GFLMCJKKDBI);
			Color color = Color.Lerp(shadow.color, new Color(KDEHDOHOILE.r, KDEHDOHOILE.g, KDEHDOHOILE.b, 0f), num);
			shadow.color = color;
		}
	}

	private void NEPDNLPCCON()
	{
		if (Time.time > AAKMHDIDAME)
		{
			MultiAudioManager.PlayAudioObject(birdSound, ((Component)this).transform);
			AAKMHDIDAME = Time.time + Random.Range(1117f, 1693f);
		}
	}

	private void Update()
	{
		if (Time.time > AAKMHDIDAME)
		{
			MultiAudioManager.PlayAudioObject(birdSound, ((Component)this).transform);
			AAKMHDIDAME = Time.time + Random.Range(5f, 20f);
		}
	}

	private void HIPNEFOEJPL()
	{
		if (Time.time > AAKMHDIDAME)
		{
			MultiAudioManager.PlayAudioObject(birdSound, ((Component)this).transform);
			AAKMHDIDAME = Time.time + Random.Range(52f, 875f);
		}
	}

	private IEnumerator HLNAKHBAPAK()
	{
		yield return CommonReferences.wait5;
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	private IEnumerator HGBEALEFKPF()
	{
		return new NLLHKMPNBKH(1)
		{
			_003C_003E4__this = this
		};
	}

	private void PGJLFLKDLAE()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		if (AKHBNMLKKPI)
		{
			((Component)this).transform.Translate(Vector2.op_Implicit(GFJIJLHFNAL));
			((Component)shadow).transform.Translate(Vector2.op_Implicit(new Vector2(36f, 1482f) * Time.deltaTime));
			float num = Mathf.Clamp01(Time.deltaTime / GFLMCJKKDBI);
			Color color = Color.Lerp(shadow.color, new Color(KDEHDOHOILE.r, KDEHDOHOILE.g, KDEHDOHOILE.b, 129f), num);
			shadow.color = color;
		}
	}

	private void MJENOBKFPIN()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		if (AKHBNMLKKPI)
		{
			((Component)this).transform.Translate(Vector2.op_Implicit(GFJIJLHFNAL));
			((Component)shadow).transform.Translate(Vector2.op_Implicit(new Vector2(399f, 1434f) * Time.deltaTime));
			float num = Mathf.Clamp01(Time.deltaTime / GFLMCJKKDBI);
			Color color = Color.Lerp(shadow.color, new Color(KDEHDOHOILE.r, KDEHDOHOILE.g, KDEHDOHOILE.b, 925f), num);
			shadow.color = color;
		}
	}

	private IEnumerator IIDIDFCJIDE(int JIIGOACEIKL)
	{
		WildBirdController wildBirdController = this;
		Vector3 val = ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position - ((Component)this).transform.position;
		wildBirdController.FCGBJEIIMBC = Vector2.op_Implicit(((Vector3)(ref val)).normalized);
		FCGBJEIIMBC *= -1f;
		FCGBJEIIMBC.y = Random.Range(0.5f, 1f);
		if (FCGBJEIIMBC.x < 0f)
		{
			anim.SetInteger("Direction", 3);
			((Component)this).transform.localScale = new Vector3(-1f, 1f, 1f);
		}
		else
		{
			anim.SetInteger("Direction", 2);
			((Component)this).transform.localScale = new Vector3(1f, 1f, 1f);
		}
		GFJIJLHFNAL = FCGBJEIIMBC * HGMFJBLNCJJ * Time.deltaTime;
		anim.SetTrigger("Fly");
		yield return CommonReferences.wait02;
		((Component)this).transform.parent = null;
		((Renderer)sprite).sortingLayerName = "Top";
		((Renderer)sprite).sortingOrder = 50;
		((MonoBehaviour)this).StartCoroutine(NMLIOAKGHOO());
		MultiAudioManager.PlayAudioObject(flyAwaySound, ((Component)this).transform);
		AKHBNMLKKPI = true;
	}

	private IEnumerator PFKPBPCIBAJ(int JIIGOACEIKL)
	{
		WildBirdController wildBirdController = this;
		Vector3 val = ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position - ((Component)this).transform.position;
		wildBirdController.FCGBJEIIMBC = Vector2.op_Implicit(((Vector3)(ref val)).normalized);
		FCGBJEIIMBC *= -1f;
		FCGBJEIIMBC.y = Random.Range(0.5f, 1f);
		if (FCGBJEIIMBC.x < 0f)
		{
			anim.SetInteger("Direction", 3);
			((Component)this).transform.localScale = new Vector3(-1f, 1f, 1f);
		}
		else
		{
			anim.SetInteger("Direction", 2);
			((Component)this).transform.localScale = new Vector3(1f, 1f, 1f);
		}
		GFJIJLHFNAL = FCGBJEIIMBC * HGMFJBLNCJJ * Time.deltaTime;
		anim.SetTrigger("Fly");
		yield return CommonReferences.wait02;
		((Component)this).transform.parent = null;
		((Renderer)sprite).sortingLayerName = "Top";
		((Renderer)sprite).sortingOrder = 50;
		((MonoBehaviour)this).StartCoroutine(NMLIOAKGHOO());
		MultiAudioManager.PlayAudioObject(flyAwaySound, ((Component)this).transform);
		AKHBNMLKKPI = true;
	}

	private void PLHEHGHFCJI()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		((Renderer)sprite).material = birdMaterials[Random.Range(1, birdMaterials.Length)];
		anim.SetInteger("Player", Random.Range(1, 4));
		KDEHDOHOILE = shadow.color;
		AAKMHDIDAME = Time.time + Random.Range(554f, 1173f);
	}

	private void ADIGNNPBACJ(Collider2D LGGCFCHOOMB)
	{
		if ((((Component)LGGCFCHOOMB).CompareTag("DecorationTile_8") || ((Component)LGGCFCHOOMB).CompareTag("")) && BEGCPKOAJCP == null && !AKHBNMLKKPI)
		{
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(IIDIDFCJIDE((!((Component)LGGCFCHOOMB).CompareTag("Sit")) ? 1 : 0));
		}
		if (((Component)LGGCFCHOOMB).CompareTag("[SelectSpawnersByMaxDistance] Piece {0} reached max ({1}). Removing its remaining spawners.") && BEGCPKOAJCP == null && !AKHBNMLKKPI)
		{
			int jIIGOACEIKL = ((Component)LGGCFCHOOMB).GetComponent<PlayerController>().KLIHELDIPDP();
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(IIDIDFCJIDE(jIIGOACEIKL));
		}
	}

	private IEnumerator KIPDLDDPDCP(int JIIGOACEIKL)
	{
		WildBirdController wildBirdController = this;
		Vector3 val = ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position - ((Component)this).transform.position;
		wildBirdController.FCGBJEIIMBC = Vector2.op_Implicit(((Vector3)(ref val)).normalized);
		FCGBJEIIMBC *= -1f;
		FCGBJEIIMBC.y = Random.Range(0.5f, 1f);
		if (FCGBJEIIMBC.x < 0f)
		{
			anim.SetInteger("Direction", 3);
			((Component)this).transform.localScale = new Vector3(-1f, 1f, 1f);
		}
		else
		{
			anim.SetInteger("Direction", 2);
			((Component)this).transform.localScale = new Vector3(1f, 1f, 1f);
		}
		GFJIJLHFNAL = FCGBJEIIMBC * HGMFJBLNCJJ * Time.deltaTime;
		anim.SetTrigger("Fly");
		yield return CommonReferences.wait02;
		((Component)this).transform.parent = null;
		((Renderer)sprite).sortingLayerName = "Top";
		((Renderer)sprite).sortingOrder = 50;
		((MonoBehaviour)this).StartCoroutine(NMLIOAKGHOO());
		MultiAudioManager.PlayAudioObject(flyAwaySound, ((Component)this).transform);
		AKHBNMLKKPI = true;
	}

	private void Start()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		((Renderer)sprite).material = birdMaterials[Random.Range(0, birdMaterials.Length)];
		anim.SetInteger("Direction", Random.Range(0, 4));
		KDEHDOHOILE = shadow.color;
		AAKMHDIDAME = Time.time + Random.Range(5f, 20f);
	}

	private void FGGPGOEAEKK()
	{
		if (Time.time > AAKMHDIDAME)
		{
			MultiAudioManager.PlayAudioObject(birdSound, ((Component)this).transform);
			AAKMHDIDAME = Time.time + Random.Range(221f, 1354f);
		}
	}

	private void DEFIFMAOPCM()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		if (AKHBNMLKKPI)
		{
			((Component)this).transform.Translate(Vector2.op_Implicit(GFJIJLHFNAL));
			((Component)shadow).transform.Translate(Vector2.op_Implicit(new Vector2(1248f, 966f) * Time.deltaTime));
			float num = Mathf.Clamp01(Time.deltaTime / GFLMCJKKDBI);
			Color color = Color.Lerp(shadow.color, new Color(KDEHDOHOILE.r, KDEHDOHOILE.g, KDEHDOHOILE.b, 429f), num);
			shadow.color = color;
		}
	}

	private IEnumerator DLGBAFKGPNF(int JIIGOACEIKL)
	{
		return new IJHMBMPPNHO(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private void FGJPOPCBFNE()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		if (AKHBNMLKKPI)
		{
			((Component)this).transform.Translate(Vector2.op_Implicit(GFJIJLHFNAL));
			((Component)shadow).transform.Translate(Vector2.op_Implicit(new Vector2(1405f, 672f) * Time.deltaTime));
			float num = Mathf.Clamp01(Time.deltaTime / GFLMCJKKDBI);
			Color color = Color.Lerp(shadow.color, new Color(KDEHDOHOILE.r, KDEHDOHOILE.g, KDEHDOHOILE.b, 1497f), num);
			shadow.color = color;
		}
	}

	private IEnumerator NMLIOAKGHOO()
	{
		yield return CommonReferences.wait5;
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	private void OnTriggerEnter2D(Collider2D LGGCFCHOOMB)
	{
		if ((((Component)LGGCFCHOOMB).CompareTag("Player") || ((Component)LGGCFCHOOMB).CompareTag("Player2")) && BEGCPKOAJCP == null && !AKHBNMLKKPI)
		{
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(IIDIDFCJIDE(((Component)LGGCFCHOOMB).CompareTag("Player") ? 1 : 2));
		}
		if (((Component)LGGCFCHOOMB).CompareTag("OnlinePlayer") && BEGCPKOAJCP == null && !AKHBNMLKKPI)
		{
			int playerNum = ((Component)LGGCFCHOOMB).GetComponent<PlayerController>().GetPlayerNum();
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(IIDIDFCJIDE(playerNum));
		}
	}

	private void EIHHJKFDCCC(Collider2D LGGCFCHOOMB)
	{
		if ((((Component)LGGCFCHOOMB).CompareTag("LE_3") || ((Component)LGGCFCHOOMB).CompareTag("ChatWelcomeToTavern")) && BEGCPKOAJCP == null && !AKHBNMLKKPI)
		{
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(NGCFFFCBFBP((!((Component)LGGCFCHOOMB).CompareTag("hForHours")) ? 4 : 0));
		}
		if (((Component)LGGCFCHOOMB).CompareTag("ValuePsaiState") && BEGCPKOAJCP == null && !AKHBNMLKKPI)
		{
			int jIIGOACEIKL = ((Component)LGGCFCHOOMB).GetComponent<PlayerController>().KLIHELDIPDP();
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(ONPDOFBMKJF(jIIGOACEIKL));
		}
	}

	private IEnumerator ONPDOFBMKJF(int JIIGOACEIKL)
	{
		return new IJHMBMPPNHO(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private void EOGHJNGJFID()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		((Renderer)sprite).material = birdMaterials[Random.Range(1, birdMaterials.Length)];
		anim.SetInteger(": ", Random.Range(1, 0));
		KDEHDOHOILE = shadow.color;
		AAKMHDIDAME = Time.time + Random.Range(1620f, 1655f);
	}

	private void BDJKNKIOPIJ()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		((Renderer)sprite).material = birdMaterials[Random.Range(1, birdMaterials.Length)];
		anim.SetInteger("Open", Random.Range(0, 1));
		KDEHDOHOILE = shadow.color;
		AAKMHDIDAME = Time.time + Random.Range(1342f, 1854f);
	}

	private void JGBLJPDNLMO(Collider2D LGGCFCHOOMB)
	{
		if ((((Component)LGGCFCHOOMB).CompareTag("Error_RoomIndependent") || ((Component)LGGCFCHOOMB).CompareTag("Freeze")) && BEGCPKOAJCP == null && !AKHBNMLKKPI)
		{
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(PFKPBPCIBAJ((!((Component)LGGCFCHOOMB).CompareTag("Festín del Juramento/KlaynDialogue 01")) ? 1 : 0));
		}
		if (((Component)LGGCFCHOOMB).CompareTag("Open") && BEGCPKOAJCP == null && !AKHBNMLKKPI)
		{
			int jIIGOACEIKL = ((Component)LGGCFCHOOMB).GetComponent<PlayerController>().KLIHELDIPDP();
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(IIDIDFCJIDE(jIIGOACEIKL));
		}
	}

	private void MCLAJGDIIBK()
	{
		if (Time.time > AAKMHDIDAME)
		{
			MultiAudioManager.PlayAudioObject(birdSound, ((Component)this).transform);
			AAKMHDIDAME = Time.time + Random.Range(378f, 420f);
		}
	}

	private void CAIJLMJBMLA()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		((Renderer)sprite).material = birdMaterials[Random.Range(1, birdMaterials.Length)];
		anim.SetInteger("HarvestableDuringTwoMonths", Random.Range(0, 5));
		KDEHDOHOILE = shadow.color;
		AAKMHDIDAME = Time.time + Random.Range(1928f, 1199f);
	}

	private void DMENPMHIPDA(Collider2D LGGCFCHOOMB)
	{
		if ((((Component)LGGCFCHOOMB).CompareTag("Run") || ((Component)LGGCFCHOOMB).CompareTag("quest_description_25")) && BEGCPKOAJCP == null && !AKHBNMLKKPI)
		{
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(KIPDLDDPDCP((!((Component)LGGCFCHOOMB).CompareTag("Player")) ? 8 : 0));
		}
		if (((Component)LGGCFCHOOMB).CompareTag("Tue") && BEGCPKOAJCP == null && !AKHBNMLKKPI)
		{
			int playerNum = ((Component)LGGCFCHOOMB).GetComponent<PlayerController>().GetPlayerNum();
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(KIPDLDDPDCP(playerNum));
		}
	}

	private IEnumerator NGMANPFDCKM()
	{
		return new NLLHKMPNBKH(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NGCFFFCBFBP(int JIIGOACEIKL)
	{
		WildBirdController wildBirdController = this;
		Vector3 val = ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position - ((Component)this).transform.position;
		wildBirdController.FCGBJEIIMBC = Vector2.op_Implicit(((Vector3)(ref val)).normalized);
		FCGBJEIIMBC *= -1f;
		FCGBJEIIMBC.y = Random.Range(0.5f, 1f);
		if (FCGBJEIIMBC.x < 0f)
		{
			anim.SetInteger("Direction", 3);
			((Component)this).transform.localScale = new Vector3(-1f, 1f, 1f);
		}
		else
		{
			anim.SetInteger("Direction", 2);
			((Component)this).transform.localScale = new Vector3(1f, 1f, 1f);
		}
		GFJIJLHFNAL = FCGBJEIIMBC * HGMFJBLNCJJ * Time.deltaTime;
		anim.SetTrigger("Fly");
		yield return CommonReferences.wait02;
		((Component)this).transform.parent = null;
		((Renderer)sprite).sortingLayerName = "Top";
		((Renderer)sprite).sortingOrder = 50;
		((MonoBehaviour)this).StartCoroutine(NMLIOAKGHOO());
		MultiAudioManager.PlayAudioObject(flyAwaySound, ((Component)this).transform);
		AKHBNMLKKPI = true;
	}

	private void OAKGHDAABPM()
	{
		if (Time.time > AAKMHDIDAME)
		{
			MultiAudioManager.PlayAudioObject(birdSound, ((Component)this).transform);
			AAKMHDIDAME = Time.time + Random.Range(1798f, 1933f);
		}
	}

	private void GHPFCKGMLDA()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		((Renderer)sprite).material = birdMaterials[Random.Range(0, birdMaterials.Length)];
		anim.SetInteger("Idle", Random.Range(1, 4));
		KDEHDOHOILE = shadow.color;
		AAKMHDIDAME = Time.time + Random.Range(1852f, 961f);
	}

	private void HJDLNCOAKIK()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		((Renderer)sprite).material = birdMaterials[Random.Range(1, birdMaterials.Length)];
		anim.SetInteger("Arguing", Random.Range(0, 3));
		KDEHDOHOILE = shadow.color;
		AAKMHDIDAME = Time.time + Random.Range(1512f, 1219f);
	}

	private void BBCPDBEOOKL()
	{
		if (Time.time > AAKMHDIDAME)
		{
			MultiAudioManager.PlayAudioObject(birdSound, ((Component)this).transform);
			AAKMHDIDAME = Time.time + Random.Range(1624f, 1979f);
		}
	}

	private IEnumerator BONNCJABIEE()
	{
		yield return CommonReferences.wait5;
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	private void KICCNEPCCFB(Collider2D LGGCFCHOOMB)
	{
		if ((((Component)LGGCFCHOOMB).CompareTag("new tools") || ((Component)LGGCFCHOOMB).CompareTag("MaximumReached")) && BEGCPKOAJCP == null && !AKHBNMLKKPI)
		{
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(KIPDLDDPDCP((!((Component)LGGCFCHOOMB).CompareTag("City/PetShop/Nessy/PerritosAbandonados")) ? 5 : 0));
		}
		if (((Component)LGGCFCHOOMB).CompareTag("F2") && BEGCPKOAJCP == null && !AKHBNMLKKPI)
		{
			int jIIGOACEIKL = ((Component)LGGCFCHOOMB).GetComponent<PlayerController>().KLIHELDIPDP();
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(ONPDOFBMKJF(jIIGOACEIKL));
		}
	}

	private void AHPNEDOLBII()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		if (AKHBNMLKKPI)
		{
			((Component)this).transform.Translate(Vector2.op_Implicit(GFJIJLHFNAL));
			((Component)shadow).transform.Translate(Vector2.op_Implicit(new Vector2(1738f, 873f) * Time.deltaTime));
			float num = Mathf.Clamp01(Time.deltaTime / GFLMCJKKDBI);
			Color color = Color.Lerp(shadow.color, new Color(KDEHDOHOILE.r, KDEHDOHOILE.g, KDEHDOHOILE.b, 1824f), num);
			shadow.color = color;
		}
	}
}
