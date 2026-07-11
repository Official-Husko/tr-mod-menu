using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;

public class SeagullController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class JNKLJMLDHPD : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SeagullController _003C_003E4__this;

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
		public JNKLJMLDHPD(int _003C_003E1__state)
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
			SeagullController seagullController = _003C_003E4__this;
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
				Utils.BLPDAEHPOBA(((Component)seagullController).gameObject);
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
	private sealed class GKEAFGCDMMF : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SeagullController _003C_003E4__this;

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
		public GKEAFGCDMMF(int _003C_003E1__state)
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
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			SeagullController seagullController = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
			{
				_003C_003E1__state = -1;
				Vector3 val = ((Component)PlayerController.GetPlayer(playerNum)).transform.position - ((Component)seagullController).transform.position;
				seagullController.FCGBJEIIMBC = Vector2.op_Implicit(((Vector3)(ref val)).normalized);
				seagullController.FCGBJEIIMBC *= -1f;
				seagullController.FCGBJEIIMBC.y = Random.Range(0.5f, 1f);
				if (seagullController.FCGBJEIIMBC.x < 0f)
				{
					((Component)seagullController).transform.localScale = new Vector3(-1f, 1f, 1f);
				}
				else
				{
					((Component)seagullController).transform.localScale = new Vector3(1f, 1f, 1f);
				}
				seagullController.GFJIJLHFNAL = seagullController.FCGBJEIIMBC * seagullController.HGMFJBLNCJJ * Time.deltaTime;
				seagullController.anim.SetTrigger("Flight");
				seagullController.anim.SetBool("Loop", true);
				_003C_003E2__current = CommonReferences.wait02;
				_003C_003E1__state = 1;
				return true;
			}
			case 1:
				_003C_003E1__state = -1;
				((Component)seagullController).transform.parent = null;
				((Renderer)seagullController.sprite).sortingLayerName = "Top";
				((MonoBehaviour)seagullController).StartCoroutine(seagullController.NMLIOAKGHOO());
				MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.seagull, ((Component)seagullController).transform);
				seagullController.AKHBNMLKKPI = true;
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

	private float HGMFJBLNCJJ = 3f;

	private Vector2 FCGBJEIIMBC;

	private Vector2 GFJIJLHFNAL;

	private bool AKHBNMLKKPI;

	private float GFLMCJKKDBI = 1f;

	private Color KDEHDOHOILE;

	private Coroutine BEGCPKOAJCP;

	private float AAKMHDIDAME;

	private void PFIONHCONDI(Collider2D LGGCFCHOOMB)
	{
		if ((((Component)LGGCFCHOOMB).CompareTag("") || ((Component)LGGCFCHOOMB).CompareTag("cheeseAgeingRackPopUp")) && BEGCPKOAJCP == null && !AKHBNMLKKPI)
		{
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(JEINIMCFBEO((!((Component)LGGCFCHOOMB).CompareTag("ItemDatabaseSO o su lista de items es nula.")) ? 6 : 0));
		}
		if (((Component)LGGCFCHOOMB).CompareTag("OnBecameInvisible") && BEGCPKOAJCP == null && !AKHBNMLKKPI)
		{
			int jIIGOACEIKL = ((Component)LGGCFCHOOMB).GetComponent<PlayerController>().KLIHELDIPDP();
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(LLCNDABAOMJ(jIIGOACEIKL));
		}
	}

	private IEnumerator JMEPBCKPOBG()
	{
		yield return CommonReferences.wait5;
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	private IEnumerator IMJIJNLPAJB()
	{
		yield return CommonReferences.wait5;
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	private void BHLHCOALABE()
	{
		if (Time.time > AAKMHDIDAME)
		{
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().seagull, ((Component)this).transform);
			AAKMHDIDAME = Time.time + Random.Range(1123f, 1403f);
		}
	}

	private void PIOMHOLIHKH(Collider2D LGGCFCHOOMB)
	{
		if ((((Component)LGGCFCHOOMB).CompareTag("SelectPermissionAccepted") || ((Component)LGGCFCHOOMB).CompareTag("VerticalMove")) && BEGCPKOAJCP == null && !AKHBNMLKKPI)
		{
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(PABKEECIJLG(((Component)LGGCFCHOOMB).CompareTag("Tutorial/T116/Dialogue1") ? 1 : 5));
		}
		if (((Component)LGGCFCHOOMB).CompareTag("popUpBuilding6") && BEGCPKOAJCP == null && !AKHBNMLKKPI)
		{
			int jIIGOACEIKL = ((Component)LGGCFCHOOMB).GetComponent<PlayerController>().KLIHELDIPDP();
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(PABKEECIJLG(jIIGOACEIKL));
		}
	}

	private void Start()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		KDEHDOHOILE = shadow.color;
		AAKMHDIDAME = Time.time + Random.Range(5f, 20f);
	}

	private void FBFAGHMJAJD()
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
			((Component)shadow).transform.Translate(Vector2.op_Implicit(new Vector2(656f, 1123f) * Time.deltaTime));
			float num = Mathf.Clamp01(Time.deltaTime / GFLMCJKKDBI);
			Color color = Color.Lerp(shadow.color, new Color(KDEHDOHOILE.r, KDEHDOHOILE.g, KDEHDOHOILE.b, 1362f), num);
			shadow.color = color;
		}
	}

	private IEnumerator BONNCJABIEE()
	{
		yield return CommonReferences.wait5;
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	private void DGIFHBIJDDE()
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
			((Component)shadow).transform.Translate(Vector2.op_Implicit(new Vector2(1045f, 1294f) * Time.deltaTime));
			float num = Mathf.Clamp01(Time.deltaTime / GFLMCJKKDBI);
			Color color = Color.Lerp(shadow.color, new Color(KDEHDOHOILE.r, KDEHDOHOILE.g, KDEHDOHOILE.b, 848f), num);
			shadow.color = color;
		}
	}

	private IEnumerator JEINIMCFBEO(int JIIGOACEIKL)
	{
		SeagullController seagullController = this;
		Vector3 val = ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position - ((Component)this).transform.position;
		seagullController.FCGBJEIIMBC = Vector2.op_Implicit(((Vector3)(ref val)).normalized);
		FCGBJEIIMBC *= -1f;
		FCGBJEIIMBC.y = Random.Range(0.5f, 1f);
		if (FCGBJEIIMBC.x < 0f)
		{
			((Component)this).transform.localScale = new Vector3(-1f, 1f, 1f);
		}
		else
		{
			((Component)this).transform.localScale = new Vector3(1f, 1f, 1f);
		}
		GFJIJLHFNAL = FCGBJEIIMBC * HGMFJBLNCJJ * Time.deltaTime;
		anim.SetTrigger("Flight");
		anim.SetBool("Loop", true);
		yield return CommonReferences.wait02;
		((Component)this).transform.parent = null;
		((Renderer)sprite).sortingLayerName = "Top";
		((MonoBehaviour)this).StartCoroutine(NMLIOAKGHOO());
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.seagull, ((Component)this).transform);
		AKHBNMLKKPI = true;
	}

	private void NDADMKEDAAK()
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
			((Component)shadow).transform.Translate(Vector2.op_Implicit(new Vector2(43f, 831f) * Time.deltaTime));
			float num = Mathf.Clamp01(Time.deltaTime / GFLMCJKKDBI);
			Color color = Color.Lerp(shadow.color, new Color(KDEHDOHOILE.r, KDEHDOHOILE.g, KDEHDOHOILE.b, 1948f), num);
			shadow.color = color;
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

	private IEnumerator HCGPGNBKGDL()
	{
		yield return CommonReferences.wait5;
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	private void EFLEPALELDJ()
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
			((Component)shadow).transform.Translate(Vector2.op_Implicit(new Vector2(786f, 927f) * Time.deltaTime));
			float num = Mathf.Clamp01(Time.deltaTime / GFLMCJKKDBI);
			Color color = Color.Lerp(shadow.color, new Color(KDEHDOHOILE.r, KDEHDOHOILE.g, KDEHDOHOILE.b, 4f), num);
			shadow.color = color;
		}
	}

	private void OGBGFLMKFHH()
	{
		if (Time.time > AAKMHDIDAME)
		{
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().seagull, ((Component)this).transform);
			AAKMHDIDAME = Time.time + Random.Range(387f, 450f);
		}
	}

	private IEnumerator LLCNDABAOMJ(int JIIGOACEIKL)
	{
		return new GKEAFGCDMMF(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private IEnumerator AMMBCHEINMI(int JIIGOACEIKL)
	{
		SeagullController seagullController = this;
		Vector3 val = ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position - ((Component)this).transform.position;
		seagullController.FCGBJEIIMBC = Vector2.op_Implicit(((Vector3)(ref val)).normalized);
		FCGBJEIIMBC *= -1f;
		FCGBJEIIMBC.y = Random.Range(0.5f, 1f);
		if (FCGBJEIIMBC.x < 0f)
		{
			((Component)this).transform.localScale = new Vector3(-1f, 1f, 1f);
		}
		else
		{
			((Component)this).transform.localScale = new Vector3(1f, 1f, 1f);
		}
		GFJIJLHFNAL = FCGBJEIIMBC * HGMFJBLNCJJ * Time.deltaTime;
		anim.SetTrigger("Flight");
		anim.SetBool("Loop", true);
		yield return CommonReferences.wait02;
		((Component)this).transform.parent = null;
		((Renderer)sprite).sortingLayerName = "Top";
		((MonoBehaviour)this).StartCoroutine(NMLIOAKGHOO());
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.seagull, ((Component)this).transform);
		AKHBNMLKKPI = true;
	}

	private void IDPHKHGHJGN()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		KDEHDOHOILE = shadow.color;
		AAKMHDIDAME = Time.time + Random.Range(1384f, 694f);
	}

	private void PPJEJKCPCLC(Collider2D LGGCFCHOOMB)
	{
		if ((((Component)LGGCFCHOOMB).CompareTag("") || ((Component)LGGCFCHOOMB).CompareTag("\\[SinglePlayer=[^\\]]*\\]")) && BEGCPKOAJCP == null && !AKHBNMLKKPI)
		{
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(JEINIMCFBEO(((Component)LGGCFCHOOMB).CompareTag("City/Carpenters/Ash/Stand") ? 1 : 5));
		}
		if (((Component)LGGCFCHOOMB).CompareTag(" (") && BEGCPKOAJCP == null && !AKHBNMLKKPI)
		{
			int jIIGOACEIKL = ((Component)LGGCFCHOOMB).GetComponent<PlayerController>().KLIHELDIPDP();
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(IIDIDFCJIDE(jIIGOACEIKL));
		}
	}

	private IEnumerator HDJACFFANDO()
	{
		yield return CommonReferences.wait5;
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	private void FGGPGOEAEKK()
	{
		if (Time.time > AAKMHDIDAME)
		{
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().seagull, ((Component)this).transform);
			AAKMHDIDAME = Time.time + Random.Range(224f, 1538f);
		}
	}

	private void MFMMHDPGCBO()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		KDEHDOHOILE = shadow.color;
		AAKMHDIDAME = Time.time + Random.Range(694f, 835f);
	}

	private IEnumerator HLNAKHBAPAK()
	{
		yield return CommonReferences.wait5;
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	private IEnumerator AALFMNMPBHK()
	{
		return new JNKLJMLDHPD(1)
		{
			_003C_003E4__this = this
		};
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
			((Component)shadow).transform.Translate(Vector2.op_Implicit(new Vector2(1191f, 1648f) * Time.deltaTime));
			float num = Mathf.Clamp01(Time.deltaTime / GFLMCJKKDBI);
			Color color = Color.Lerp(shadow.color, new Color(KDEHDOHOILE.r, KDEHDOHOILE.g, KDEHDOHOILE.b, 139f), num);
			shadow.color = color;
		}
	}

	private void IDPJLIBONPF(Collider2D LGGCFCHOOMB)
	{
		if ((((Component)LGGCFCHOOMB).CompareTag("Meditation") || ((Component)LGGCFCHOOMB).CompareTag(" downloaded, written with name ")) && BEGCPKOAJCP == null && !AKHBNMLKKPI)
		{
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(IIDIDFCJIDE((!((Component)LGGCFCHOOMB).CompareTag("ReceiveBarkInfo")) ? 1 : 0));
		}
		if (((Component)LGGCFCHOOMB).CompareTag("Interact") && BEGCPKOAJCP == null && !AKHBNMLKKPI)
		{
			int playerNum = ((Component)LGGCFCHOOMB).GetComponent<PlayerController>().GetPlayerNum();
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(AMMBCHEINMI(playerNum));
		}
	}

	private IEnumerator JIKNLEMKLAG()
	{
		yield return CommonReferences.wait5;
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	private void PDCJGGJMPCN(Collider2D LGGCFCHOOMB)
	{
		if ((((Component)LGGCFCHOOMB).CompareTag("Resolucion: ") || ((Component)LGGCFCHOOMB).CompareTag("Return to castle corroutine is null")) && BEGCPKOAJCP == null && !AKHBNMLKKPI)
		{
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(PABKEECIJLG(((Component)LGGCFCHOOMB).CompareTag("<color=black>") ? 1 : 2));
		}
		if (((Component)LGGCFCHOOMB).CompareTag("PanelToggleUI") && BEGCPKOAJCP == null && !AKHBNMLKKPI)
		{
			int jIIGOACEIKL = ((Component)LGGCFCHOOMB).GetComponent<PlayerController>().KLIHELDIPDP();
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(AMMBCHEINMI(jIIGOACEIKL));
		}
	}

	private IEnumerator IIDIDFCJIDE(int JIIGOACEIKL)
	{
		SeagullController seagullController = this;
		Vector3 val = ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position - ((Component)this).transform.position;
		seagullController.FCGBJEIIMBC = Vector2.op_Implicit(((Vector3)(ref val)).normalized);
		FCGBJEIIMBC *= -1f;
		FCGBJEIIMBC.y = Random.Range(0.5f, 1f);
		if (FCGBJEIIMBC.x < 0f)
		{
			((Component)this).transform.localScale = new Vector3(-1f, 1f, 1f);
		}
		else
		{
			((Component)this).transform.localScale = new Vector3(1f, 1f, 1f);
		}
		GFJIJLHFNAL = FCGBJEIIMBC * HGMFJBLNCJJ * Time.deltaTime;
		anim.SetTrigger("Flight");
		anim.SetBool("Loop", true);
		yield return CommonReferences.wait02;
		((Component)this).transform.parent = null;
		((Renderer)sprite).sortingLayerName = "Top";
		((MonoBehaviour)this).StartCoroutine(NMLIOAKGHOO());
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.seagull, ((Component)this).transform);
		AKHBNMLKKPI = true;
	}

	private IEnumerator KNDMPAPILBH()
	{
		yield return CommonReferences.wait5;
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	private void FBNHGAOGDJE()
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
			((Component)shadow).transform.Translate(Vector2.op_Implicit(new Vector2(1206f, 1592f) * Time.deltaTime));
			float num = Mathf.Clamp01(Time.deltaTime / GFLMCJKKDBI);
			Color color = Color.Lerp(shadow.color, new Color(KDEHDOHOILE.r, KDEHDOHOILE.g, KDEHDOHOILE.b, 139f), num);
			shadow.color = color;
		}
	}

	private void NFDJLCGELJM(Collider2D LGGCFCHOOMB)
	{
		if ((((Component)LGGCFCHOOMB).CompareTag("Right Stick Up") || ((Component)LGGCFCHOOMB).CompareTag("Changing seed ")) && BEGCPKOAJCP == null && !AKHBNMLKKPI)
		{
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(JEINIMCFBEO(((Component)LGGCFCHOOMB).CompareTag("Dialogue System/Conversation/Gass_Stand/Entry/20/Dialogue Text") ? 1 : 4));
		}
		if (((Component)LGGCFCHOOMB).CompareTag("Dialogue System/Conversation/Gass_Introduce/Entry/5/Dialogue Text") && BEGCPKOAJCP == null && !AKHBNMLKKPI)
		{
			int playerNum = ((Component)LGGCFCHOOMB).GetComponent<PlayerController>().GetPlayerNum();
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(AMMBCHEINMI(playerNum));
		}
	}

	private void Update()
	{
		if (Time.time > AAKMHDIDAME)
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.seagull, ((Component)this).transform);
			AAKMHDIDAME = Time.time + Random.Range(5f, 20f);
		}
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
			((Component)shadow).transform.Translate(Vector2.op_Implicit(new Vector2(713f, 919f) * Time.deltaTime));
			float num = Mathf.Clamp01(Time.deltaTime / GFLMCJKKDBI);
			Color color = Color.Lerp(shadow.color, new Color(KDEHDOHOILE.r, KDEHDOHOILE.g, KDEHDOHOILE.b, 1075f), num);
			shadow.color = color;
		}
	}

	private void IAAGKLPMAMK()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		KDEHDOHOILE = shadow.color;
		AAKMHDIDAME = Time.time + Random.Range(1156f, 1926f);
	}

	private void MAGACCHLAOE()
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
			((Component)shadow).transform.Translate(Vector2.op_Implicit(new Vector2(1814f, 553f) * Time.deltaTime));
			float num = Mathf.Clamp01(Time.deltaTime / GFLMCJKKDBI);
			Color color = Color.Lerp(shadow.color, new Color(KDEHDOHOILE.r, KDEHDOHOILE.g, KDEHDOHOILE.b, 1921f), num);
			shadow.color = color;
		}
	}

	private void BELOIFKPNMM()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		KDEHDOHOILE = shadow.color;
		AAKMHDIDAME = Time.time + Random.Range(1412f, 651f);
	}

	private void OGFKFGAMGCE()
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
			((Component)shadow).transform.Translate(Vector2.op_Implicit(new Vector2(1825f, 1358f) * Time.deltaTime));
			float num = Mathf.Clamp01(Time.deltaTime / GFLMCJKKDBI);
			Color color = Color.Lerp(shadow.color, new Color(KDEHDOHOILE.r, KDEHDOHOILE.g, KDEHDOHOILE.b, 312f), num);
			shadow.color = color;
		}
	}

	private IEnumerator NPIOLCKFCHC()
	{
		yield return CommonReferences.wait5;
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	private IEnumerator PABKEECIJLG(int JIIGOACEIKL)
	{
		return new GKEAFGCDMMF(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private IEnumerator EANDHOPMLON()
	{
		return new JNKLJMLDHPD(1)
		{
			_003C_003E4__this = this
		};
	}

	private void IIOHMDNGFDH()
	{
		if (Time.time > AAKMHDIDAME)
		{
			MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().seagull, ((Component)this).transform);
			AAKMHDIDAME = Time.time + Random.Range(1684f, 1845f);
		}
	}

	private void KIGPIILBDAC()
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
			((Component)shadow).transform.Translate(Vector2.op_Implicit(new Vector2(66f, 1706f) * Time.deltaTime));
			float num = Mathf.Clamp01(Time.deltaTime / GFLMCJKKDBI);
			Color color = Color.Lerp(shadow.color, new Color(KDEHDOHOILE.r, KDEHDOHOILE.g, KDEHDOHOILE.b, 1971f), num);
			shadow.color = color;
		}
	}

	private void HCPKBJDHLAC()
	{
		if (Time.time > AAKMHDIDAME)
		{
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().seagull, ((Component)this).transform);
			AAKMHDIDAME = Time.time + Random.Range(226f, 988f);
		}
	}

	private void ADHFFJDEBMK()
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
			((Component)shadow).transform.Translate(Vector2.op_Implicit(new Vector2(729f, 1242f) * Time.deltaTime));
			float num = Mathf.Clamp01(Time.deltaTime / GFLMCJKKDBI);
			Color color = Color.Lerp(shadow.color, new Color(KDEHDOHOILE.r, KDEHDOHOILE.g, KDEHDOHOILE.b, 67f), num);
			shadow.color = color;
		}
	}

	private IEnumerator NMLIOAKGHOO()
	{
		yield return CommonReferences.wait5;
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	private IEnumerator NGMANPFDCKM()
	{
		return new JNKLJMLDHPD(1)
		{
			_003C_003E4__this = this
		};
	}

	private void ADJMGPNBDGF()
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
			((Component)shadow).transform.Translate(Vector2.op_Implicit(new Vector2(1586f, 1551f) * Time.deltaTime));
			float num = Mathf.Clamp01(Time.deltaTime / GFLMCJKKDBI);
			Color color = Color.Lerp(shadow.color, new Color(KDEHDOHOILE.r, KDEHDOHOILE.g, KDEHDOHOILE.b, 1238f), num);
			shadow.color = color;
		}
	}

	private IEnumerator DAMLLADAKEF()
	{
		yield return CommonReferences.wait5;
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	private void AKLEFPLEGKK()
	{
		if (Time.time > AAKMHDIDAME)
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.seagull, ((Component)this).transform);
			AAKMHDIDAME = Time.time + Random.Range(1353f, 787f);
		}
	}

	private void BNIKICAEIND()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		KDEHDOHOILE = shadow.color;
		AAKMHDIDAME = Time.time + Random.Range(122f, 857f);
	}

	private void AHKDANJMEMC(Collider2D LGGCFCHOOMB)
	{
		if ((((Component)LGGCFCHOOMB).CompareTag("Back") || ((Component)LGGCFCHOOMB).CompareTag("Miners/Mine/Ferro/Stand")) && BEGCPKOAJCP == null && !AKHBNMLKKPI)
		{
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(IIDIDFCJIDE((!((Component)LGGCFCHOOMB).CompareTag("ERROR: The object ")) ? 2 : 0));
		}
		if (((Component)LGGCFCHOOMB).CompareTag("Items/item_name_629") && BEGCPKOAJCP == null && !AKHBNMLKKPI)
		{
			int jIIGOACEIKL = ((Component)LGGCFCHOOMB).GetComponent<PlayerController>().KLIHELDIPDP();
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(PABKEECIJLG(jIIGOACEIKL));
		}
	}

	private IEnumerator IMLNDILHHDI()
	{
		return new JNKLJMLDHPD(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BPFHPDMJMPB()
	{
		yield return CommonReferences.wait5;
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	private void MGMLDHPOLGK()
	{
		if (Time.time > AAKMHDIDAME)
		{
			MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().seagull, ((Component)this).transform);
			AAKMHDIDAME = Time.time + Random.Range(583f, 1622f);
		}
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
}
