using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class VioletNPC : DialogueNPCBase
{
	[CompilerGenerated]
	private sealed class HKLPIFBJEEC : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string bark;

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
		public HKLPIFBJEEC(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				switch (bark)
				{
				case "Farm/Event/VioletyBob":
					break;
				case "Farm/Event/PiedrasVioletyArthur":
					goto IL_00eb;
				case "Farm/Event/SwordVioletArthur":
					goto IL_014c;
				default:
					goto IL_01aa;
				}
				goto IL_008a;
			case 1:
				_003C_003E1__state = -1;
				goto IL_008a;
			case 2:
				_003C_003E1__state = -1;
				GGFJGHHHEJC.Bark(bark, CDPAMNIPPEC: false);
				break;
			case 3:
				_003C_003E1__state = -1;
				goto IL_00eb;
			case 4:
				_003C_003E1__state = -1;
				GGFJGHHHEJC.Bark(bark, CDPAMNIPPEC: false);
				break;
			case 5:
				_003C_003E1__state = -1;
				goto IL_014c;
			case 6:
				_003C_003E1__state = -1;
				GGFJGHHHEJC.Bark(bark, CDPAMNIPPEC: false);
				break;
			case 7:
				_003C_003E1__state = -1;
				goto IL_01aa;
			case 8:
				{
					_003C_003E1__state = -1;
					GGFJGHHHEJC.Bark(bark, CDPAMNIPPEC: false);
					break;
				}
				IL_01aa:
				if (GGFJGHHHEJC.inBark)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 7;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait01;
				_003C_003E1__state = 8;
				return true;
				IL_00eb:
				if (GGFJGHHHEJC.inBark || ArthurNPC.GGFJGHHHEJC.inBark)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 3;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait01;
				_003C_003E1__state = 4;
				return true;
				IL_014c:
				if (GGFJGHHHEJC.inBark || ArthurNPC.GGFJGHHHEJC.inBark)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 5;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait01;
				_003C_003E1__state = 6;
				return true;
				IL_008a:
				if (GGFJGHHHEJC.inBark || BobNPC.GGFJGHHHEJC.inBark)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait01;
				_003C_003E1__state = 2;
				return true;
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

	private static VioletNPC IADEMLIIDPC;

	public VioletStateBase currentVioletState;

	public NPCAnimation violetAnimation;

	public Coroutine waitToWalkCoroutine;

	public Collider2D violetCollider;

	private float FDBCHJMHBKF;

	private float IEIHJNPHGAJ;

	private float IFGFABPMGGK = 2f;

	private float PMCKBLAPLKK = 1f;

	private bool HCCBOAMEEIJ;

	private int HKKKNMIKPCM;

	private string HDFMHCKKJJG = "LE_7";

	public static VioletNPC GGFJGHHHEJC => IADEMLIIDPC;

	public void ADJMGPNBDGF()
	{
		if (Object.op_Implicit((Object)(object)currentVioletState))
		{
			currentVioletState.IBCFOBGAHKH();
		}
		NEOINFACLAG();
	}

	public void BAEEAHKCNNB(string bark)
	{
		((MonoBehaviour)ABHIDHPMLLD()).StartCoroutine(OAFFKIGJNDA(bark));
	}

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	private IEnumerator DPOFPOOOEHD(string GAGJHPKONIC)
	{
		switch (GAGJHPKONIC)
		{
		case "Farm/Event/VioletyBob":
			while (GGFJGHHHEJC.inBark || BobNPC.GGFJGHHHEJC.inBark)
			{
				yield return null;
			}
			yield return CommonReferences.wait01;
			GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
			yield break;
		case "Farm/Event/PiedrasVioletyArthur":
			while (GGFJGHHHEJC.inBark || ArthurNPC.GGFJGHHHEJC.inBark)
			{
				yield return null;
			}
			yield return CommonReferences.wait01;
			GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
			yield break;
		case "Farm/Event/SwordVioletArthur":
			while (GGFJGHHHEJC.inBark || ArthurNPC.GGFJGHHHEJC.inBark)
			{
				yield return null;
			}
			yield return CommonReferences.wait01;
			GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
			yield break;
		}
		while (GGFJGHHHEJC.inBark)
		{
			yield return null;
		}
		yield return CommonReferences.wait01;
		GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
	}

	private void LLLEALLKBMH()
	{
		inBark = true;
		inInteractiveBark = true;
	}

	private void DBHEEEIFOKH()
	{
		inBark = true;
		inInteractiveBark = false;
	}

	private IEnumerator APALKMBOJMD(string GAGJHPKONIC)
	{
		switch (GAGJHPKONIC)
		{
		case "Farm/Event/VioletyBob":
			while (GGFJGHHHEJC.inBark || BobNPC.GGFJGHHHEJC.inBark)
			{
				yield return null;
			}
			yield return CommonReferences.wait01;
			GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
			yield break;
		case "Farm/Event/PiedrasVioletyArthur":
			while (GGFJGHHHEJC.inBark || ArthurNPC.GGFJGHHHEJC.inBark)
			{
				yield return null;
			}
			yield return CommonReferences.wait01;
			GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
			yield break;
		case "Farm/Event/SwordVioletArthur":
			while (GGFJGHHHEJC.inBark || ArthurNPC.GGFJGHHHEJC.inBark)
			{
				yield return null;
			}
			yield return CommonReferences.wait01;
			GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
			yield break;
		}
		while (GGFJGHHHEJC.inBark)
		{
			yield return null;
		}
		yield return CommonReferences.wait01;
		GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
	}

	private IEnumerator BEGMJLGDBAD(string GAGJHPKONIC)
	{
		switch (GAGJHPKONIC)
		{
		case "Farm/Event/VioletyBob":
			while (GGFJGHHHEJC.inBark || BobNPC.GGFJGHHHEJC.inBark)
			{
				yield return null;
			}
			yield return CommonReferences.wait01;
			GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
			yield break;
		case "Farm/Event/PiedrasVioletyArthur":
			while (GGFJGHHHEJC.inBark || ArthurNPC.GGFJGHHHEJC.inBark)
			{
				yield return null;
			}
			yield return CommonReferences.wait01;
			GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
			yield break;
		case "Farm/Event/SwordVioletArthur":
			while (GGFJGHHHEJC.inBark || ArthurNPC.GGFJGHHHEJC.inBark)
			{
				yield return null;
			}
			yield return CommonReferences.wait01;
			GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
			yield break;
		}
		while (GGFJGHHHEJC.inBark)
		{
			yield return null;
		}
		yield return CommonReferences.wait01;
		GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
	}

	[SpecialName]
	public static VioletNPC EFPJLFMBPLL()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static VioletNPC ABHIDHPMLLD()
	{
		return IADEMLIIDPC;
	}

	public void BDLLGEDIHPA(string emotion)
	{
		OACNNJCLEDE().emotionsController.PIOCPGKDAOF(emotion);
	}

	[SpecialName]
	public static VioletNPC OACNNJCLEDE()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static VioletNPC MNFMOEKMJKN()
	{
		return IADEMLIIDPC;
	}

	public void KGDLOHIGOHI()
	{
		if (FDBCHJMHBKF < PMCKBLAPLKK)
		{
			violetAnimation.LookAtObject(((Component)PlayerController.GetPlayer(1)).gameObject, MAPFDGCKBLD: false);
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(1) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
		{
			violetAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(7)).gameObject);
		}
	}

	public void BarkSequence(string bark)
	{
		((MonoBehaviour)GGFJGHHHEJC).StartCoroutine(BEGMJLGDBAD(bark));
	}

	public void NBDEKLHHGPL()
	{
		if (FDBCHJMHBKF < PMCKBLAPLKK)
		{
			violetAnimation.DGJJGINNOOH(((Component)PlayerController.OPHDCMJLLEC(1)).gameObject);
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(5) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
		{
			violetAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(1)).gameObject, MAPFDGCKBLD: false);
		}
	}

	private void ECHMKEAGFFO()
	{
		inBark = true;
		inInteractiveBark = false;
	}

	private void FAKNILODPNH()
	{
		inBark = false;
		inInteractiveBark = false;
	}

	public void BKILDJBIIHL(string emotion)
	{
		PDECKLKPKCG().emotionsController.DCCNJLBLFGI(emotion);
	}

	private void IHCAMKKLDDF()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.CAGIBNLHJBN())
		{
			return;
		}
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.GetPlayer(1)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.GetPlayer(5) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.GetPlayer(4)).transform.position, ((Component)this).transform.position);
		}
		if (violetAnimation.LHGMJFGOHFD() && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.MNFMOEKMJKN().IsInDialogue(1) && PlayerController.OPHDCMJLLEC(0).characterAnimation.animator.GetBool("Items/item_name_675"))
				{
					violetAnimation.LookAtObject(((Component)PlayerController.GetPlayer(1)).gameObject, MAPFDGCKBLD: false);
					busy = true;
					HCCBOAMEEIJ = true;
				}
			}
			else if ((Object)(object)PlayerController.OPHDCMJLLEC(0) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.MNFMOEKMJKN().IJNMEDJNHDG(3) && PlayerController.GetPlayer(3).characterAnimation.animator.GetBool(" - Activating variant object "))
			{
				violetAnimation.LookAtObject(((Component)PlayerController.GetPlayer(0)).gameObject, MAPFDGCKBLD: false);
				busy = true;
				HCCBOAMEEIJ = false;
			}
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(2) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				busy = true;
				HCCBOAMEEIJ = true;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			busy = true;
			HCCBOAMEEIJ = false;
		}
	}

	private void PPHECNNMCNF()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.OPGGPLEOGCG())
		{
			return;
		}
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(0)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.OPHDCMJLLEC(4) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.GetPlayer(5)).transform.position, ((Component)this).transform.position);
		}
		if (violetAnimation.LHGMJFGOHFD() && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.MNFMOEKMJKN().CIHFKAGPIEG(0) && PlayerController.OPHDCMJLLEC(1).characterAnimation.animator.GetBool("/Female/"))
				{
					violetAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(0)).gameObject, MAPFDGCKBLD: false);
					busy = false;
					HCCBOAMEEIJ = true;
				}
			}
			else if ((Object)(object)PlayerController.OPHDCMJLLEC(0) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.GGFJGHHHEJC.KOIDFLPJKJK(7) && PlayerController.OPHDCMJLLEC(8).characterAnimation.animator.GetBool("Float {0} changed to {1} on {2}'s animator. Sending RPC."))
			{
				violetAnimation.DGJJGINNOOH(((Component)PlayerController.OPHDCMJLLEC(6)).gameObject);
				busy = false;
				HCCBOAMEEIJ = false;
			}
		}
		else if ((Object)(object)PlayerController.GetPlayer(1) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				busy = true;
				HCCBOAMEEIJ = false;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			busy = true;
			HCCBOAMEEIJ = false;
		}
	}

	public void APGNMAGFPOO(string bark)
	{
		((MonoBehaviour)LADDMEMMJFP()).StartCoroutine(OAFFKIGJNDA(bark));
	}

	public void FixedUpdate()
	{
		if (Object.op_Implicit((Object)(object)currentVioletState))
		{
			currentVioletState.NDMAAEFLPEL();
		}
		KCNFAHCOPJI();
	}

	public void EIOFKDODGKK()
	{
		if (Object.op_Implicit((Object)(object)currentVioletState))
		{
			currentVioletState.CONJLPFIDHN();
		}
		CIOJGCODGPA();
	}

	private void OFJIMLOLIDP()
	{
		inBark = false;
		inInteractiveBark = false;
	}

	public void BOKOLOCCLEN()
	{
		if (Object.op_Implicit((Object)(object)currentVioletState))
		{
			currentVioletState.CFBMPHGDDIB();
		}
		BPPBLHOOEDE();
	}

	public void CEPMMHGFDEH(string bark)
	{
		((MonoBehaviour)OACNNJCLEDE()).StartCoroutine(JIFONDBOEOK(bark));
	}

	private void NEOINFACLAG()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.OPGGPLEOGCG())
		{
			return;
		}
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.GetPlayer(0)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.GetPlayer(8) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(0)).transform.position, ((Component)this).transform.position);
		}
		if (violetAnimation.LHGMJFGOHFD() && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.MNFMOEKMJKN().CIHFKAGPIEG(1) && PlayerController.GetPlayer(0).characterAnimation.animator.GetBool("Dialogue System/Conversation/Crowly_Introduce/Entry/27/Dialogue Text"))
				{
					violetAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(1)).gameObject);
					busy = false;
					HCCBOAMEEIJ = true;
				}
			}
			else if ((Object)(object)PlayerController.GetPlayer(1) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.GGFJGHHHEJC.IJNMEDJNHDG(4) && PlayerController.GetPlayer(2).characterAnimation.animator.GetBool("ReceiveSelectPerkLevel"))
			{
				violetAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(1)).gameObject);
				busy = true;
				HCCBOAMEEIJ = true;
			}
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(0) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				busy = false;
				HCCBOAMEEIJ = true;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			busy = false;
			HCCBOAMEEIJ = false;
		}
	}

	public void GOLGBIFLEDM(string emotion)
	{
		EFPJLFMBPLL().emotionsController.NBFIDOGMLOK(emotion);
	}

	private void CACPOGPOKOJ()
	{
		inBark = false;
		inInteractiveBark = false;
	}

	public void GFABFDHPJOK()
	{
		if (Object.op_Implicit((Object)(object)currentVioletState))
		{
			currentVioletState.AAFKAJEJIOC();
		}
		DNDCIKJJPJB();
	}

	public void AAOEFHODHHA(string emotion)
	{
		ABHIDHPMLLD().emotionsController.DCCNJLBLFGI(emotion);
	}

	[SpecialName]
	public static VioletNPC JFNOOMJMHCB()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator HKIJDDGKIBD(string GAGJHPKONIC)
	{
		return new HKLPIFBJEEC(1)
		{
			bark = GAGJHPKONIC
		};
	}

	private IEnumerator JDHLCHDKFLL(string GAGJHPKONIC)
	{
		return new HKLPIFBJEEC(1)
		{
			bark = GAGJHPKONIC
		};
	}

	public void IKPEHMKBBAH(string bark)
	{
		((MonoBehaviour)MAIDHAPANEB()).StartCoroutine(AKBOLKGMHEL(bark));
	}

	public void CPNKHIHKNEC(string bark)
	{
		((MonoBehaviour)PDECKLKPKCG()).StartCoroutine(BEGMJLGDBAD(bark));
	}

	[SpecialName]
	public static VioletNPC DOIKFJDLKJP()
	{
		return IADEMLIIDPC;
	}

	public void JAPFDIEHKPI()
	{
		if (Object.op_Implicit((Object)(object)currentVioletState))
		{
			currentVioletState.BKLKAPJFMJA();
		}
		MMCHEPFLBLE();
	}

	private void OnDisable()
	{
		inBark = false;
		inInteractiveBark = false;
	}

	public void FEMKLLPFODJ(string bark)
	{
		((MonoBehaviour)ABHIDHPMLLD()).StartCoroutine(JDHLCHDKFLL(bark));
	}

	private IEnumerator ABKMELCPJMN(string GAGJHPKONIC)
	{
		return new HKLPIFBJEEC(1)
		{
			bark = GAGJHPKONIC
		};
	}

	private void CIOJGCODGPA()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.OPGGPLEOGCG())
		{
			return;
		}
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.GetPlayer(1)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.GetPlayer(7) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.GetPlayer(4)).transform.position, ((Component)this).transform.position);
		}
		if (violetAnimation.LHGMJFGOHFD() && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.GGFJGHHHEJC.IsInDialogue(1) && PlayerController.GetPlayer(1).characterAnimation.animator.GetBool("ReceiveItemSlotPlayerInventory"))
				{
					violetAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(0)).gameObject, MAPFDGCKBLD: false);
					busy = false;
					HCCBOAMEEIJ = false;
				}
			}
			else if ((Object)(object)PlayerController.GetPlayer(6) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.GGFJGHHHEJC.IJNMEDJNHDG(2) && PlayerController.OPHDCMJLLEC(4).characterAnimation.animator.GetBool("  fallingChest:       "))
			{
				violetAnimation.DGJJGINNOOH(((Component)PlayerController.OPHDCMJLLEC(8)).gameObject);
				busy = false;
				HCCBOAMEEIJ = true;
			}
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(7) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				busy = true;
				HCCBOAMEEIJ = true;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			busy = true;
			HCCBOAMEEIJ = false;
		}
	}

	private void JBMAHNFMJHL()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.NoPlayers())
		{
			return;
		}
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.GetPlayer(1)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.OPHDCMJLLEC(6) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.GetPlayer(8)).transform.position, ((Component)this).transform.position);
		}
		if (violetAnimation.LHGMJFGOHFD() && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.MNFMOEKMJKN().KOIDFLPJKJK(0) && PlayerController.GetPlayer(1).characterAnimation.animator.GetBool("contentLockRepMessage"))
				{
					violetAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(1)).gameObject);
					busy = true;
					HCCBOAMEEIJ = true;
				}
			}
			else if ((Object)(object)PlayerController.GetPlayer(4) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.GGFJGHHHEJC.IsInDialogue(1) && PlayerController.GetPlayer(8).characterAnimation.animator.GetBool("F2"))
			{
				violetAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(8)).gameObject, MAPFDGCKBLD: false);
				busy = false;
				HCCBOAMEEIJ = false;
			}
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(8) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				busy = false;
				HCCBOAMEEIJ = false;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			busy = true;
			HCCBOAMEEIJ = false;
		}
	}

	[SpecialName]
	public static VioletNPC MAIDHAPANEB()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator OAFFKIGJNDA(string GAGJHPKONIC)
	{
		switch (GAGJHPKONIC)
		{
		case "Farm/Event/VioletyBob":
			while (GGFJGHHHEJC.inBark || BobNPC.GGFJGHHHEJC.inBark)
			{
				yield return null;
			}
			yield return CommonReferences.wait01;
			GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
			yield break;
		case "Farm/Event/PiedrasVioletyArthur":
			while (GGFJGHHHEJC.inBark || ArthurNPC.GGFJGHHHEJC.inBark)
			{
				yield return null;
			}
			yield return CommonReferences.wait01;
			GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
			yield break;
		case "Farm/Event/SwordVioletArthur":
			while (GGFJGHHHEJC.inBark || ArthurNPC.GGFJGHHHEJC.inBark)
			{
				yield return null;
			}
			yield return CommonReferences.wait01;
			GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
			yield break;
		}
		while (GGFJGHHHEJC.inBark)
		{
			yield return null;
		}
		yield return CommonReferences.wait01;
		GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
	}

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	private IEnumerator FDCNFAFFKJH(string GAGJHPKONIC)
	{
		return new HKLPIFBJEEC(1)
		{
			bark = GAGJHPKONIC
		};
	}

	private IEnumerator IEELOHIGOEC(string GAGJHPKONIC)
	{
		return new HKLPIFBJEEC(1)
		{
			bark = GAGJHPKONIC
		};
	}

	private void ECKFAJHJHMG()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.OPGGPLEOGCG())
		{
			return;
		}
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.GetPlayer(0)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.GetPlayer(7) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.GetPlayer(6)).transform.position, ((Component)this).transform.position);
		}
		if (violetAnimation.CNKHDCIKHCO && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.MNFMOEKMJKN().KOIDFLPJKJK(0) && PlayerController.OPHDCMJLLEC(0).characterAnimation.animator.GetBool("ReceiveGroundType"))
				{
					violetAnimation.DGJJGINNOOH(((Component)PlayerController.OPHDCMJLLEC(1)).gameObject);
					busy = false;
					HCCBOAMEEIJ = false;
				}
			}
			else if ((Object)(object)PlayerController.OPHDCMJLLEC(3) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.GGFJGHHHEJC.IsInDialogue(5) && PlayerController.GetPlayer(3).characterAnimation.animator.GetBool("Run"))
			{
				violetAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(0)).gameObject, MAPFDGCKBLD: false);
				busy = true;
				HCCBOAMEEIJ = false;
			}
		}
		else if ((Object)(object)PlayerController.GetPlayer(3) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				busy = false;
				HCCBOAMEEIJ = true;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			busy = false;
			HCCBOAMEEIJ = true;
		}
	}

	private void ANOLEDBMHON()
	{
		inBark = false;
		inInteractiveBark = true;
	}

	protected override void OnConversationStart(Transform actor)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationStart(actor);
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		HKKKNMIKPCM = ((Result)(ref variable)).asInt;
	}

	public void NDJGLEMAAJF(string bark)
	{
		((MonoBehaviour)ABHIDHPMLLD()).StartCoroutine(ABKMELCPJMN(bark));
	}

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
		NJJCCIBDAPM();
	}

	private void MMCHEPFLBLE()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.OPGGPLEOGCG())
		{
			return;
		}
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(0)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.GetPlayer(7) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(3)).transform.position, ((Component)this).transform.position);
		}
		if (violetAnimation.CNKHDCIKHCO && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.MNFMOEKMJKN().CIHFKAGPIEG(1) && PlayerController.GetPlayer(0).characterAnimation.animator.GetBool("Waiting for players to finish their transitions..."))
				{
					violetAnimation.DGJJGINNOOH(((Component)PlayerController.OPHDCMJLLEC(1)).gameObject);
					busy = false;
					HCCBOAMEEIJ = false;
				}
			}
			else if ((Object)(object)PlayerController.OPHDCMJLLEC(1) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.GGFJGHHHEJC.IJNMEDJNHDG(2) && PlayerController.GetPlayer(8).characterAnimation.animator.GetBool("Items/item_name_622"))
			{
				violetAnimation.LookAtObject(((Component)PlayerController.GetPlayer(3)).gameObject, MAPFDGCKBLD: false);
				busy = true;
				HCCBOAMEEIJ = true;
			}
		}
		else if ((Object)(object)PlayerController.GetPlayer(8) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				busy = true;
				HCCBOAMEEIJ = true;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			busy = false;
			HCCBOAMEEIJ = false;
		}
	}

	private void PDAFINABOBC()
	{
		inBark = true;
		inInteractiveBark = false;
	}

	public void NJBPKDJJIEG()
	{
		if (FDBCHJMHBKF < PMCKBLAPLKK)
		{
			violetAnimation.DGJJGINNOOH(((Component)PlayerController.OPHDCMJLLEC(1)).gameObject);
		}
		else if ((Object)(object)PlayerController.GetPlayer(4) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
		{
			violetAnimation.DGJJGINNOOH(((Component)PlayerController.OPHDCMJLLEC(4)).gameObject, MAPFDGCKBLD: false);
		}
	}

	public void JJNMAGKMFEJ()
	{
		if (FDBCHJMHBKF < PMCKBLAPLKK)
		{
			violetAnimation.DGJJGINNOOH(((Component)PlayerController.OPHDCMJLLEC(1)).gameObject, MAPFDGCKBLD: false);
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(1) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
		{
			violetAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(4)).gameObject);
		}
	}

	public void HKOFLOPDCEJ()
	{
		if (Object.op_Implicit((Object)(object)currentVioletState))
		{
			currentVioletState.NDMAAEFLPEL();
		}
		ECKFAJHJHMG();
	}

	[SpecialName]
	public static VioletNPC LADDMEMMJFP()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator EHBGBHNFEGI(string GAGJHPKONIC)
	{
		return new HKLPIFBJEEC(1)
		{
			bark = GAGJHPKONIC
		};
	}

	public void DBNAJMBFJEG()
	{
		if (Object.op_Implicit((Object)(object)currentVioletState))
		{
			currentVioletState.BKLKAPJFMJA();
		}
		JBMAHNFMJHL();
	}

	private void HEOAIGHOLLD()
	{
		inBark = false;
		inInteractiveBark = false;
	}

	private IEnumerator BMIAIANJHDD(string GAGJHPKONIC)
	{
		return new HKLPIFBJEEC(1)
		{
			bark = GAGJHPKONIC
		};
	}

	public void IGNLHLAAMMN()
	{
		if (Object.op_Implicit((Object)(object)currentVioletState))
		{
			currentVioletState.FFBCLHJEDBL();
		}
		MMCHEPFLBLE();
	}

	public void KIBCBNHKGDL(string bark)
	{
		((MonoBehaviour)LADDMEMMJFP()).StartCoroutine(IKOJJCNGOHM(bark));
	}

	[SpecialName]
	public static VioletNPC PDECKLKPKCG()
	{
		return IADEMLIIDPC;
	}

	public void KICLABHJNIE()
	{
		if (FDBCHJMHBKF < PMCKBLAPLKK)
		{
			violetAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(0)).gameObject);
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(8) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
		{
			violetAnimation.DGJJGINNOOH(((Component)PlayerController.OPHDCMJLLEC(0)).gameObject, MAPFDGCKBLD: false);
		}
	}

	private IEnumerator FCBLIFMAHMC(string GAGJHPKONIC)
	{
		return new HKLPIFBJEEC(1)
		{
			bark = GAGJHPKONIC
		};
	}

	private void MKGKKAJHLAO()
	{
		inBark = false;
		inInteractiveBark = true;
	}

	private IEnumerator IKOJJCNGOHM(string GAGJHPKONIC)
	{
		switch (GAGJHPKONIC)
		{
		case "Farm/Event/VioletyBob":
			while (GGFJGHHHEJC.inBark || BobNPC.GGFJGHHHEJC.inBark)
			{
				yield return null;
			}
			yield return CommonReferences.wait01;
			GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
			yield break;
		case "Farm/Event/PiedrasVioletyArthur":
			while (GGFJGHHHEJC.inBark || ArthurNPC.GGFJGHHHEJC.inBark)
			{
				yield return null;
			}
			yield return CommonReferences.wait01;
			GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
			yield break;
		case "Farm/Event/SwordVioletArthur":
			while (GGFJGHHHEJC.inBark || ArthurNPC.GGFJGHHHEJC.inBark)
			{
				yield return null;
			}
			yield return CommonReferences.wait01;
			GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
			yield break;
		}
		while (GGFJGHHHEJC.inBark)
		{
			yield return null;
		}
		yield return CommonReferences.wait01;
		GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
	}

	private void BONEKIAPEIK()
	{
		inBark = false;
		inInteractiveBark = true;
	}

	public void GJFGJJGFBLN(string bark)
	{
		((MonoBehaviour)MNFMOEKMJKN()).StartCoroutine(ABKMELCPJMN(bark));
	}

	public void LALLOOCBCAL(string bark)
	{
		((MonoBehaviour)EFPJLFMBPLL()).StartCoroutine(AKBOLKGMHEL(bark));
	}

	public void JLFNGOAPGOM(string emotion)
	{
		ABHIDHPMLLD().emotionsController.PIOCPGKDAOF(emotion);
	}

	protected override void OnConversationEnd(Transform actor)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationEnd(actor);
		int hKKKNMIKPCM = HKKKNMIKPCM;
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		if (hKKKNMIKPCM != ((Result)(ref variable)).asInt && OnlineManager.PlayingOnline())
		{
			OnlineDialogueManager instance = OnlineDialogueManager.instance;
			string hDFMHCKKJJG = HDFMHCKKJJG;
			variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			instance.SendDialogueInfo(hDFMHCKKJJG, ((Result)(ref variable)).asInt);
		}
	}

	public void KGABNOLDJDN()
	{
		if (FDBCHJMHBKF < PMCKBLAPLKK)
		{
			violetAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(0)).gameObject);
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(8) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
		{
			violetAnimation.LookAtObject(((Component)PlayerController.GetPlayer(2)).gameObject);
		}
	}

	private void DJJENHCMCBN()
	{
		inBark = false;
		inInteractiveBark = true;
	}

	private void BPPBLHOOEDE()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.CAGIBNLHJBN())
		{
			return;
		}
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.OPHDCMJLLEC(0) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.GetPlayer(4)).transform.position, ((Component)this).transform.position);
		}
		if (violetAnimation.CNKHDCIKHCO && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.GGFJGHHHEJC.CIHFKAGPIEG(1) && PlayerController.OPHDCMJLLEC(0).characterAnimation.animator.GetBool("Decor"))
				{
					violetAnimation.DGJJGINNOOH(((Component)PlayerController.OPHDCMJLLEC(0)).gameObject);
					busy = true;
					HCCBOAMEEIJ = true;
				}
			}
			else if ((Object)(object)PlayerController.OPHDCMJLLEC(0) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.GGFJGHHHEJC.KOIDFLPJKJK(6) && PlayerController.OPHDCMJLLEC(2).characterAnimation.animator.GetBool("Precision/HikariTalk"))
			{
				violetAnimation.LookAtObject(((Component)PlayerController.GetPlayer(6)).gameObject);
				busy = false;
				HCCBOAMEEIJ = true;
			}
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(1) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				busy = false;
				HCCBOAMEEIJ = true;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			busy = false;
			HCCBOAMEEIJ = false;
		}
	}

	protected override void NJJCCIBDAPM()
	{
		dialogue.conversation = "Farm/Violet/Main";
	}

	public void FACKKGAODPO(string emotion)
	{
		MAIDHAPANEB().emotionsController.DCCNJLBLFGI(emotion);
	}

	public void JBABHOJPFPG()
	{
		if (Object.op_Implicit((Object)(object)currentVioletState))
		{
			currentVioletState.CGPJNKMFHDD();
		}
		NCLKGHHKHLJ();
	}

	public void EMCHLKPPLOC(string bark)
	{
		((MonoBehaviour)GGFJGHHHEJC).StartCoroutine(DPOFPOOOEHD(bark));
	}

	public void FKCOPHFELKD()
	{
		if (Object.op_Implicit((Object)(object)currentVioletState))
		{
			currentVioletState.NJMJGAGCNCA();
		}
		NCLKGHHKHLJ();
	}

	private void HKFGIKEBNJN()
	{
		inBark = false;
		inInteractiveBark = true;
	}

	private void DNDCIKJJPJB()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.NoPlayers())
		{
			return;
		}
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.GetPlayer(0)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.GetPlayer(1) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(6)).transform.position, ((Component)this).transform.position);
		}
		if (violetAnimation.CNKHDCIKHCO && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.GGFJGHHHEJC.IJNMEDJNHDG(1) && PlayerController.GetPlayer(1).characterAnimation.animator.GetBool(" from actor "))
				{
					violetAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(1)).gameObject, MAPFDGCKBLD: false);
					busy = true;
					HCCBOAMEEIJ = false;
				}
			}
			else if ((Object)(object)PlayerController.GetPlayer(2) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.GGFJGHHHEJC.KOIDFLPJKJK(1) && PlayerController.GetPlayer(1).characterAnimation.animator.GetBool("Signing user in..."))
			{
				violetAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(8)).gameObject, MAPFDGCKBLD: false);
				busy = false;
				HCCBOAMEEIJ = true;
			}
		}
		else if ((Object)(object)PlayerController.GetPlayer(6) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				busy = true;
				HCCBOAMEEIJ = false;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			busy = true;
			HCCBOAMEEIJ = false;
		}
	}

	public void PGJLFLKDLAE()
	{
		if (Object.op_Implicit((Object)(object)currentVioletState))
		{
			currentVioletState.DCHPOOBFGLO();
		}
		CIOJGCODGPA();
	}

	private void MMAMJDLONFA()
	{
		inBark = false;
		inInteractiveBark = false;
	}

	public void LookAtPlayer()
	{
		if (FDBCHJMHBKF < PMCKBLAPLKK)
		{
			violetAnimation.LookAtObject(((Component)PlayerController.GetPlayer(1)).gameObject);
		}
		else if ((Object)(object)PlayerController.GetPlayer(2) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
		{
			violetAnimation.LookAtObject(((Component)PlayerController.GetPlayer(2)).gameObject);
		}
	}

	private IEnumerator AKBOLKGMHEL(string GAGJHPKONIC)
	{
		switch (GAGJHPKONIC)
		{
		case "Farm/Event/VioletyBob":
			while (GGFJGHHHEJC.inBark || BobNPC.GGFJGHHHEJC.inBark)
			{
				yield return null;
			}
			yield return CommonReferences.wait01;
			GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
			yield break;
		case "Farm/Event/PiedrasVioletyArthur":
			while (GGFJGHHHEJC.inBark || ArthurNPC.GGFJGHHHEJC.inBark)
			{
				yield return null;
			}
			yield return CommonReferences.wait01;
			GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
			yield break;
		case "Farm/Event/SwordVioletArthur":
			while (GGFJGHHHEJC.inBark || ArthurNPC.GGFJGHHHEJC.inBark)
			{
				yield return null;
			}
			yield return CommonReferences.wait01;
			GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
			yield break;
		}
		while (GGFJGHHHEJC.inBark)
		{
			yield return null;
		}
		yield return CommonReferences.wait01;
		GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
	}

	private IEnumerator JIFONDBOEOK(string GAGJHPKONIC)
	{
		return new HKLPIFBJEEC(1)
		{
			bark = GAGJHPKONIC
		};
	}

	private void KCNFAHCOPJI()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.NoPlayers())
		{
			return;
		}
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.GetPlayer(1)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.GetPlayer(2) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.GetPlayer(2)).transform.position, ((Component)this).transform.position);
		}
		if (violetAnimation.CNKHDCIKHCO && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.GGFJGHHHEJC.IsInDialogue(1) && PlayerController.GetPlayer(1).characterAnimation.animator.GetBool("Moving"))
				{
					violetAnimation.LookAtObject(((Component)PlayerController.GetPlayer(1)).gameObject);
					busy = true;
					HCCBOAMEEIJ = false;
				}
			}
			else if ((Object)(object)PlayerController.GetPlayer(2) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.GGFJGHHHEJC.IsInDialogue(2) && PlayerController.GetPlayer(2).characterAnimation.animator.GetBool("Moving"))
			{
				violetAnimation.LookAtObject(((Component)PlayerController.GetPlayer(2)).gameObject);
				busy = true;
				HCCBOAMEEIJ = false;
			}
		}
		else if ((Object)(object)PlayerController.GetPlayer(2) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				busy = false;
				HCCBOAMEEIJ = true;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			busy = false;
			HCCBOAMEEIJ = true;
		}
	}

	private void JAKILILIBIM()
	{
		inBark = true;
		inInteractiveBark = false;
	}

	public void FPEBFCFHMPI(string bark)
	{
		((MonoBehaviour)DOIKFJDLKJP()).StartCoroutine(FDCNFAFFKJH(bark));
	}

	[SpecialName]
	public static VioletNPC OFLELHKKNKC()
	{
		return IADEMLIIDPC;
	}

	private void ANLHPMPMBFM()
	{
		inBark = true;
		inInteractiveBark = true;
	}

	private void BELHMNMGLHC()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.NoPlayers())
		{
			return;
		}
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.GetPlayer(1)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.OPHDCMJLLEC(1) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.GetPlayer(4)).transform.position, ((Component)this).transform.position);
		}
		if (violetAnimation.CNKHDCIKHCO && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.GGFJGHHHEJC.IJNMEDJNHDG(1) && PlayerController.OPHDCMJLLEC(0).characterAnimation.animator.GetBool("LearnMettle"))
				{
					violetAnimation.LookAtObject(((Component)PlayerController.GetPlayer(0)).gameObject, MAPFDGCKBLD: false);
					busy = false;
					HCCBOAMEEIJ = true;
				}
			}
			else if ((Object)(object)PlayerController.OPHDCMJLLEC(8) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.MNFMOEKMJKN().CIHFKAGPIEG(2) && PlayerController.GetPlayer(8).characterAnimation.animator.GetBool("ReciveResetDialogueULiaRhia"))
			{
				violetAnimation.DGJJGINNOOH(((Component)PlayerController.OPHDCMJLLEC(4)).gameObject, MAPFDGCKBLD: false);
				busy = false;
				HCCBOAMEEIJ = true;
			}
		}
		else if ((Object)(object)PlayerController.GetPlayer(0) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				busy = false;
				HCCBOAMEEIJ = true;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			busy = false;
			HCCBOAMEEIJ = true;
		}
	}

	public override bool MouseUp(int JIIGOACEIKL)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		if (!CommonReferences.GGFJGHHHEJC.IsInDialogue(JIIGOACEIKL) && !inUse && !inEvent && canTalk && IsAvailableByProximity(JIIGOACEIKL))
		{
			AnimatorStateInfo currentAnimatorStateInfo = violetAnimation.animator.GetCurrentAnimatorStateInfo(0);
			if (((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsTag("Idle"))
			{
				LookAtPlayer();
			}
		}
		base.MouseUp(JIIGOACEIKL);
		return false;
	}

	private void NCLKGHHKHLJ()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.NoPlayers())
		{
			return;
		}
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.GetPlayer(0)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.GetPlayer(4) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.GetPlayer(3)).transform.position, ((Component)this).transform.position);
		}
		if (violetAnimation.LHGMJFGOHFD() && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.GGFJGHHHEJC.KOIDFLPJKJK(1) && PlayerController.GetPlayer(0).characterAnimation.animator.GetBool("Puente_EA/Talk 2"))
				{
					violetAnimation.LookAtObject(((Component)PlayerController.GetPlayer(0)).gameObject);
					busy = true;
					HCCBOAMEEIJ = false;
				}
			}
			else if ((Object)(object)PlayerController.OPHDCMJLLEC(5) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.MNFMOEKMJKN().IsInDialogue(7) && PlayerController.OPHDCMJLLEC(6).characterAnimation.animator.GetBool(""))
			{
				violetAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(2)).gameObject);
				busy = true;
				HCCBOAMEEIJ = true;
			}
		}
		else if ((Object)(object)PlayerController.GetPlayer(6) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				busy = true;
				HCCBOAMEEIJ = false;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			busy = true;
			HCCBOAMEEIJ = false;
		}
	}

	[SpecialName]
	public static VioletNPC HLMGBEGEAPC()
	{
		return IADEMLIIDPC;
	}
}
