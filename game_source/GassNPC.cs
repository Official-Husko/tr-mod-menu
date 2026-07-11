using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PixelCrushers;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class GassNPC : DialogueNPCBase
{
	[CompilerGenerated]
	private sealed class DIDANDDLLCB : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SpriteRenderer sr;

		public float endValue;

		public float duration;

		private float _003Ctime_003E5__2;

		private float _003CstartValue_003E5__3;

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
		public DIDANDDLLCB(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003Ctime_003E5__2 = 0f;
				_003CstartValue_003E5__3 = sr.color.a;
				break;
			case 1:
				_003C_003E1__state = -1;
				break;
			}
			if (_003Ctime_003E5__2 < duration)
			{
				_003Ctime_003E5__2 += Time.deltaTime;
				float num = Mathf.Lerp(_003CstartValue_003E5__3, endValue, _003Ctime_003E5__2 / duration);
				sr.color = new Color(sr.color.r, sr.color.g, sr.color.b, num);
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
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

	private static GassNPC IADEMLIIDPC;

	public GassStateBase currentGassState;

	public SpriteRenderer gassSprite;

	public SpriteRenderer shadowSprite;

	public GassAnimation gassAnimation;

	public GameObject[] walkPoints;

	private float FDBCHJMHBKF;

	private float IEIHJNPHGAJ;

	private float IFGFABPMGGK = 3.5f;

	private float PMCKBLAPLKK = 1.5f;

	private float JPBMJHCACOD = 2.5f;

	private bool HCCBOAMEEIJ = true;

	private bool DAOGEILONMP = true;

	private float NAJICNEDGLD;

	private int HKKKNMIKPCM;

	private int IIAIJJFNNAO;

	private string HDFMHCKKJJG = "LE_2";

	public static GassNPC GGFJGHHHEJC => IADEMLIIDPC;

	public IEnumerator HKDLFHGFMAA(SpriteRenderer ECOGJIGAMMA, float BMEBKODLPLF, float OMHCOLMFGNJ)
	{
		float time = 0f;
		float startValue = ECOGJIGAMMA.color.a;
		while (time < OMHCOLMFGNJ)
		{
			time += Time.deltaTime;
			float num = Mathf.Lerp(startValue, BMEBKODLPLF, time / OMHCOLMFGNJ);
			ECOGJIGAMMA.color = new Color(ECOGJIGAMMA.color.r, ECOGJIGAMMA.color.g, ECOGJIGAMMA.color.b, num);
			yield return null;
		}
	}

	private void JFFKPAIPKLI()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(0)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.OPHDCMJLLEC(3) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.GetPlayer(1)).transform.position, ((Component)this).transform.position);
		}
		if (DAOGEILONMP)
		{
			if (FDBCHJMHBKF < JPBMJHCACOD || ((Object)(object)PlayerController.GetPlayer(3) != (Object)null && IEIHJNPHGAJ < JPBMJHCACOD))
			{
				((MonoBehaviour)this).StartCoroutine(HKDLFHGFMAA(gassSprite, 1500f, 1791f));
				((MonoBehaviour)this).StartCoroutine(JJBBFCGJAGL(shadowSprite, 1852f, 315f));
				DAOGEILONMP = true;
			}
		}
		else if ((Object)(object)PlayerController.GetPlayer(7) != (Object)null)
		{
			if (FDBCHJMHBKF > JPBMJHCACOD && IEIHJNPHGAJ > JPBMJHCACOD)
			{
				((MonoBehaviour)this).StartCoroutine(HKDLFHGFMAA(gassSprite, 1000f, 1688f));
				((MonoBehaviour)this).StartCoroutine(HKDLFHGFMAA(shadowSprite, 888f, 1491f));
				DAOGEILONMP = false;
			}
		}
		else if (FDBCHJMHBKF > JPBMJHCACOD)
		{
			((MonoBehaviour)this).StartCoroutine(MBDKADLLPMO(gassSprite, 1307f, 179f));
			((MonoBehaviour)this).StartCoroutine(INEGGBILPON(shadowSprite, 1374f, 808f));
			DAOGEILONMP = false;
		}
		if (HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				behaviour.SetTrigger("Intro08");
				gassAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(0)).gameObject, MAPFDGCKBLD: false);
				HCCBOAMEEIJ = false;
			}
			else if ((Object)(object)PlayerController.OPHDCMJLLEC(4) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
			{
				behaviour.SetTrigger("Order quest");
				gassAnimation.LookAtObject(((Component)PlayerController.GetPlayer(2)).gameObject, MAPFDGCKBLD: false);
				HCCBOAMEEIJ = false;
			}
		}
		else if ((Object)(object)PlayerController.GetPlayer(4) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				behaviour.SetTrigger("NextItem");
				HCCBOAMEEIJ = false;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			behaviour.SetTrigger("Error_IsBlockingChanges");
			HCCBOAMEEIJ = true;
		}
	}

	public void NOCPFIHMCLH(int questId)
	{
		Quest quest = QuestDatabaseAccessor.HMMFCOFIGMN(questId);
		if (Object.op_Implicit((Object)(object)quest))
		{
			QuestManager.OPILDPFDFKJ().NCCOAJOOBAP(quest, 1, FFJBIGFADBJ: true, CDPAMNIPPEC: false);
			QuestHighlightUI.FFIMPAEIABH(quest);
		}
		else
		{
			Debug.LogError((object)("\n</color>" + questId));
		}
	}

	public void Stuggle()
	{
		GGFJGHHHEJC.gassAnimation.Struggle();
	}

	public void UnlockRecipe(int recipeId)
	{
		if (RecipesManager.CanUnlockRecipe(recipeId))
		{
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.questComplete));
		}
		RecipesManager.UnlockRecipe(recipeId);
	}

	[SpecialName]
	public static GassNPC KNOKBLFFNLM()
	{
		return IADEMLIIDPC;
	}

	private void PDHHDGGKBHA()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(0)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.OPHDCMJLLEC(7) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(8)).transform.position, ((Component)this).transform.position);
		}
		if (DAOGEILONMP)
		{
			if (FDBCHJMHBKF < JPBMJHCACOD || ((Object)(object)PlayerController.GetPlayer(5) != (Object)null && IEIHJNPHGAJ < JPBMJHCACOD))
			{
				((MonoBehaviour)this).StartCoroutine(MBDKADLLPMO(gassSprite, 1081f, 734f));
				((MonoBehaviour)this).StartCoroutine(MBDKADLLPMO(shadowSprite, 756f, 1519f));
				DAOGEILONMP = true;
			}
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(6) != (Object)null)
		{
			if (FDBCHJMHBKF > JPBMJHCACOD && IEIHJNPHGAJ > JPBMJHCACOD)
			{
				((MonoBehaviour)this).StartCoroutine(NPOAPDLIEBI(gassSprite, 1709f, 263f));
				((MonoBehaviour)this).StartCoroutine(MBDKADLLPMO(shadowSprite, 1217f, 1053f));
				DAOGEILONMP = true;
			}
		}
		else if (FDBCHJMHBKF > JPBMJHCACOD)
		{
			((MonoBehaviour)this).StartCoroutine(SpriteFade(gassSprite, 1791f, 6f));
			((MonoBehaviour)this).StartCoroutine(INEGGBILPON(shadowSprite, 1439f, 906f));
			DAOGEILONMP = true;
		}
		if (HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				behaviour.SetTrigger("talent_name_102");
				gassAnimation.LookAtObject(((Component)PlayerController.GetPlayer(0)).gameObject, MAPFDGCKBLD: false);
				HCCBOAMEEIJ = true;
			}
			else if ((Object)(object)PlayerController.GetPlayer(7) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
			{
				behaviour.SetTrigger("Freshwater");
				gassAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(4)).gameObject, MAPFDGCKBLD: false);
				HCCBOAMEEIJ = true;
			}
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(7) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				behaviour.SetTrigger("[Action");
				HCCBOAMEEIJ = true;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			behaviour.SetTrigger("Stop");
			HCCBOAMEEIJ = true;
		}
	}

	public void EIBOMLNHNLP()
	{
		ShopUI.EAONFFENMCE(JCMKNNOEONP().EHHOHCPHAAO).shop = shop;
		ShopUI.IEKODILKIHJ(MIGKKKELOJO().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	public void FixedUpdate()
	{
		if (Object.op_Implicit((Object)(object)currentGassState))
		{
			currentGassState.DLKMCEIBAFG();
		}
		KCNFAHCOPJI();
	}

	public IEnumerator NPOAPDLIEBI(SpriteRenderer ECOGJIGAMMA, float BMEBKODLPLF, float OMHCOLMFGNJ)
	{
		float time = 0f;
		float startValue = ECOGJIGAMMA.color.a;
		while (time < OMHCOLMFGNJ)
		{
			time += Time.deltaTime;
			float num = Mathf.Lerp(startValue, BMEBKODLPLF, time / OMHCOLMFGNJ);
			ECOGJIGAMMA.color = new Color(ECOGJIGAMMA.color.r, ECOGJIGAMMA.color.g, ECOGJIGAMMA.color.b, num);
			yield return null;
		}
	}

	public void OBHLPNEJGOJ()
	{
		JCMKNNOEONP().gassAnimation.FOKICCNEFDM();
	}

	public void FONPBMGLOIN(int questId)
	{
		Quest quest = QuestDatabaseAccessor.GetQuest(questId);
		if (Object.op_Implicit((Object)(object)quest))
		{
			QuestManager.OPILDPFDFKJ().NJDDJJEGOAF(quest, 1, FFJBIGFADBJ: false, CDPAMNIPPEC: false);
			QuestHighlightUI.NDABOMBDJFH(quest);
		}
		else
		{
			Debug.LogError((object)("Tutorial/T" + questId));
		}
	}

	[SpecialName]
	public static GassNPC OJJDNLEFNPJ()
	{
		return IADEMLIIDPC;
	}

	public void LGOKBJEJDKK(string emotion)
	{
		JCMKNNOEONP().emotionsController.PIOCPGKDAOF(emotion);
	}

	public void PCPNEJOIKAN()
	{
		if (Object.op_Implicit((Object)(object)currentGassState))
		{
			currentGassState.GOHGKFHDMDJ();
		}
		KCNFAHCOPJI();
	}

	public void OpenShop()
	{
		ShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).shop = shop;
		ShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).OpenUI();
	}

	public void JFOHHPNCOIG()
	{
		ShopUI.JCBPABNCBPI(KGPJPILAHDE().EHHOHCPHAAO).shop = shop;
		ShopUI.NALKHGMLALJ(GGFJGHHHEJC.EHHOHCPHAAO).IDLAGJNLPJL();
	}

	public void OBJHHNMMCGF()
	{
		if (Object.op_Implicit((Object)(object)currentGassState))
		{
			currentGassState.AMDAIJOHAEM();
		}
		BPPBLHOOEDE();
	}

	[SpecialName]
	public static GassNPC DEGPIHEEFHJ()
	{
		return IADEMLIIDPC;
	}

	protected override void OnConversationEnd(Transform actor)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationEnd(actor);
		if (Time.time > NAJICNEDGLD)
		{
			DialogueManager.Bark("Gass_Barks_Bye", ((Component)this).transform);
			NAJICNEDGLD = (float)Random.Range(15, 25) + Time.time;
		}
		if (OnlineManager.PlayingOnline())
		{
			int hKKKNMIKPCM = HKKKNMIKPCM;
			Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (hKKKNMIKPCM != ((Result)(ref variable)).asInt)
			{
				OnlineDialogueManager instance = OnlineDialogueManager.instance;
				string hDFMHCKKJJG = HDFMHCKKJJG;
				variable = DialogueLua.GetVariable(HDFMHCKKJJG);
				instance.SendDialogueInfo(hDFMHCKKJJG, ((Result)(ref variable)).asInt);
			}
			int iIAIJJFNNAO = IIAIJJFNNAO;
			variable = DialogueLua.GetVariable("Gass_CoctelQuest");
			if (iIAIJJFNNAO != ((Result)(ref variable)).asInt)
			{
				OnlineDialogueManager instance2 = OnlineDialogueManager.instance;
				variable = DialogueLua.GetVariable("Gass_CoctelQuest");
				instance2.SendDialogueInfo("Gass_CoctelQuest", ((Result)(ref variable)).asInt);
			}
		}
	}

	public void NJBPKDJJIEG()
	{
		if (FDBCHJMHBKF < PMCKBLAPLKK)
		{
			gassAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(1)).gameObject, MAPFDGCKBLD: false);
		}
		else if ((Object)(object)PlayerController.GetPlayer(3) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
		{
			gassAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(7)).gameObject, MAPFDGCKBLD: false);
		}
	}

	public void INJPCOODGOI()
	{
		ShopUI.EAONFFENMCE(POINNCPMEIG().EHHOHCPHAAO).shop = shop;
		ShopUI.JCBPABNCBPI(DEGPIHEEFHJ().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	public void JFEIHMJHBAG(int recipeId)
	{
		if (RecipesManager.CanUnlockRecipe(recipeId))
		{
			Sound.DIHCEGINELM().LNCINHJELIG(Utils.CPDCJAHJOPE(Sound.DIHCEGINELM().questComplete), HOMFPAFAOGD: false, null, null, 507f);
		}
		RecipesManager.UnlockRecipe(recipeId, IBHGAMNNOHI: true);
	}

	[SpecialName]
	public static GassNPC JCMKNNOEONP()
	{
		return IADEMLIIDPC;
	}

	private void HEANIMJDIJJ()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.GetPlayer(0)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.OPHDCMJLLEC(1) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(2)).transform.position, ((Component)this).transform.position);
		}
		if (DAOGEILONMP)
		{
			if (FDBCHJMHBKF < JPBMJHCACOD || ((Object)(object)PlayerController.OPHDCMJLLEC(7) != (Object)null && IEIHJNPHGAJ < JPBMJHCACOD))
			{
				((MonoBehaviour)this).StartCoroutine(JJBBFCGJAGL(gassSprite, 937f, 362f));
				((MonoBehaviour)this).StartCoroutine(JJBBFCGJAGL(shadowSprite, 472f, 804f));
				DAOGEILONMP = false;
			}
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(6) != (Object)null)
		{
			if (FDBCHJMHBKF > JPBMJHCACOD && IEIHJNPHGAJ > JPBMJHCACOD)
			{
				((MonoBehaviour)this).StartCoroutine(NPOAPDLIEBI(gassSprite, 378f, 340f));
				((MonoBehaviour)this).StartCoroutine(MBDKADLLPMO(shadowSprite, 1291f, 850f));
				DAOGEILONMP = false;
			}
		}
		else if (FDBCHJMHBKF > JPBMJHCACOD)
		{
			((MonoBehaviour)this).StartCoroutine(NPOAPDLIEBI(gassSprite, 1598f, 1165f));
			((MonoBehaviour)this).StartCoroutine(JJBBFCGJAGL(shadowSprite, 417f, 141f));
			DAOGEILONMP = true;
		}
		if (HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				behaviour.SetTrigger("Pause");
				gassAnimation.DGJJGINNOOH(((Component)PlayerController.OPHDCMJLLEC(1)).gameObject);
				HCCBOAMEEIJ = true;
			}
			else if ((Object)(object)PlayerController.OPHDCMJLLEC(0) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
			{
				behaviour.SetTrigger("Menu Mode Settings");
				gassAnimation.LookAtObject(((Component)PlayerController.GetPlayer(0)).gameObject);
				HCCBOAMEEIJ = true;
			}
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(0) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				behaviour.SetTrigger("buildingObjective_17_0");
				HCCBOAMEEIJ = true;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			behaviour.SetTrigger("ReceiveStopWork");
			HCCBOAMEEIJ = false;
		}
	}

	public void GBNAPIEBJEJ(int recipeId)
	{
		if (RecipesManager.CanUnlockRecipe(recipeId))
		{
			Sound.MAIDHAPANEB().PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.OKAPNFPFPFP().questComplete), HOMFPAFAOGD: false, null, null, 1470f);
		}
		RecipesManager.EGEAPNOMMFG(recipeId, IBHGAMNNOHI: true);
	}

	private void KCNFAHCOPJI()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.GetPlayer(1)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.GetPlayer(2) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.GetPlayer(2)).transform.position, ((Component)this).transform.position);
		}
		if (DAOGEILONMP)
		{
			if (FDBCHJMHBKF < JPBMJHCACOD || ((Object)(object)PlayerController.GetPlayer(2) != (Object)null && IEIHJNPHGAJ < JPBMJHCACOD))
			{
				((MonoBehaviour)this).StartCoroutine(SpriteFade(gassSprite, 1f, 1f));
				((MonoBehaviour)this).StartCoroutine(SpriteFade(shadowSprite, 0.4117647f, 1f));
				DAOGEILONMP = false;
			}
		}
		else if ((Object)(object)PlayerController.GetPlayer(2) != (Object)null)
		{
			if (FDBCHJMHBKF > JPBMJHCACOD && IEIHJNPHGAJ > JPBMJHCACOD)
			{
				((MonoBehaviour)this).StartCoroutine(SpriteFade(gassSprite, 0f, 1f));
				((MonoBehaviour)this).StartCoroutine(SpriteFade(shadowSprite, 0f, 1f));
				DAOGEILONMP = true;
			}
		}
		else if (FDBCHJMHBKF > JPBMJHCACOD)
		{
			((MonoBehaviour)this).StartCoroutine(SpriteFade(gassSprite, 0f, 1f));
			((MonoBehaviour)this).StartCoroutine(SpriteFade(shadowSprite, 0f, 1f));
			DAOGEILONMP = true;
		}
		if (HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				behaviour.SetTrigger("Idle");
				gassAnimation.LookAtObject(((Component)PlayerController.GetPlayer(1)).gameObject);
				HCCBOAMEEIJ = false;
			}
			else if ((Object)(object)PlayerController.GetPlayer(2) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
			{
				behaviour.SetTrigger("Idle");
				gassAnimation.LookAtObject(((Component)PlayerController.GetPlayer(2)).gameObject);
				HCCBOAMEEIJ = false;
			}
		}
		else if ((Object)(object)PlayerController.GetPlayer(2) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				behaviour.SetTrigger("Walk");
				HCCBOAMEEIJ = true;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			behaviour.SetTrigger("Walk");
			HCCBOAMEEIJ = true;
		}
	}

	[SpecialName]
	public static GassNPC POINNCPMEIG()
	{
		return IADEMLIIDPC;
	}

	public void HMEFIIDEMOL(string emotion)
	{
		POINNCPMEIG().emotionsController.EMMBEAHMDHE(emotion);
	}

	public void GDEEGJFFBKN(string emotion)
	{
		ABHIDHPMLLD().emotionsController.NBFIDOGMLOK(emotion);
	}

	public void NECPHEOHFOF()
	{
		ShopUI.EAONFFENMCE(ABHIDHPMLLD().EHHOHCPHAAO).shop = shop;
		ShopUI.AGNKKAPMHLN(OJJDNLEFNPJ().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	public void ELOGEIPBKDJ(int questId)
	{
		Quest quest = QuestDatabaseAccessor.GetQuest(questId);
		if (Object.op_Implicit((Object)(object)quest))
		{
			QuestManager.GJFMMOPOKGJ().NJDDJJEGOAF(quest, 0, FFJBIGFADBJ: true, CDPAMNIPPEC: false);
			QuestHighlightUI.NDABOMBDJFH(quest);
		}
		else
		{
			Debug.LogError((object)("Open" + questId));
		}
	}

	public override bool MouseUp(int JIIGOACEIKL)
	{
		if (base.MouseUp(JIIGOACEIKL))
		{
			CommonReferences.GGFJGHHHEJC.OnActionDone(JIIGOACEIKL, ActionDone.TalkWithGass);
			LookAtPlayer();
			return true;
		}
		return false;
	}

	public void MPDPPEBFKFP(int questId)
	{
		Quest quest = QuestDatabaseAccessor.GetQuest(questId);
		if (Object.op_Implicit((Object)(object)quest))
		{
			QuestManager.GGFJGHHHEJC.AddQuest(quest, 0, FFJBIGFADBJ: true, CDPAMNIPPEC: true, FIKMGOKHAPG: true);
			QuestHighlightUI.DFLEEAJJOBD(quest);
		}
		else
		{
			Debug.LogError((object)("[" + questId));
		}
	}

	public void LookAtPlayer()
	{
		if (FDBCHJMHBKF < PMCKBLAPLKK)
		{
			gassAnimation.LookAtObject(((Component)PlayerController.GetPlayer(1)).gameObject);
		}
		else if ((Object)(object)PlayerController.GetPlayer(2) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
		{
			gassAnimation.LookAtObject(((Component)PlayerController.GetPlayer(2)).gameObject);
		}
	}

	public IEnumerator SpriteFade(SpriteRenderer ECOGJIGAMMA, float BMEBKODLPLF, float OMHCOLMFGNJ)
	{
		float time = 0f;
		float startValue = ECOGJIGAMMA.color.a;
		while (time < OMHCOLMFGNJ)
		{
			time += Time.deltaTime;
			float num = Mathf.Lerp(startValue, BMEBKODLPLF, time / OMHCOLMFGNJ);
			ECOGJIGAMMA.color = new Color(ECOGJIGAMMA.color.r, ECOGJIGAMMA.color.g, ECOGJIGAMMA.color.b, num);
			yield return null;
		}
	}

	public void DEFIFMAOPCM()
	{
		if (Object.op_Implicit((Object)(object)currentGassState))
		{
			currentGassState.IKFMHHJOKHD();
		}
		BPPBLHOOEDE();
	}

	public void JCLAFBPPEIP()
	{
		if (FDBCHJMHBKF < PMCKBLAPLKK)
		{
			gassAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(0)).gameObject);
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(7) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
		{
			gassAnimation.LookAtObject(((Component)PlayerController.GetPlayer(3)).gameObject);
		}
	}

	private void HCNJECBKNKM()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.GetPlayer(1)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.GetPlayer(0) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.GetPlayer(0)).transform.position, ((Component)this).transform.position);
		}
		if (DAOGEILONMP)
		{
			if (FDBCHJMHBKF < JPBMJHCACOD || ((Object)(object)PlayerController.OPHDCMJLLEC(7) != (Object)null && IEIHJNPHGAJ < JPBMJHCACOD))
			{
				((MonoBehaviour)this).StartCoroutine(NPOAPDLIEBI(gassSprite, 169f, 974f));
				((MonoBehaviour)this).StartCoroutine(JJBBFCGJAGL(shadowSprite, 1859f, 1341f));
				DAOGEILONMP = false;
			}
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(8) != (Object)null)
		{
			if (FDBCHJMHBKF > JPBMJHCACOD && IEIHJNPHGAJ > JPBMJHCACOD)
			{
				((MonoBehaviour)this).StartCoroutine(HKDLFHGFMAA(gassSprite, 1243f, 1707f));
				((MonoBehaviour)this).StartCoroutine(JJBBFCGJAGL(shadowSprite, 1862f, 1356f));
				DAOGEILONMP = true;
			}
		}
		else if (FDBCHJMHBKF > JPBMJHCACOD)
		{
			((MonoBehaviour)this).StartCoroutine(HKDLFHGFMAA(gassSprite, 1943f, 63f));
			((MonoBehaviour)this).StartCoroutine(NPOAPDLIEBI(shadowSprite, 1892f, 185f));
			DAOGEILONMP = false;
		}
		if (HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				behaviour.SetTrigger("Error_BarNotInADiningRoom");
				gassAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(1)).gameObject);
				HCCBOAMEEIJ = true;
			}
			else if ((Object)(object)PlayerController.GetPlayer(1) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
			{
				behaviour.SetTrigger(")");
				gassAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(1)).gameObject);
				HCCBOAMEEIJ = true;
			}
		}
		else if ((Object)(object)PlayerController.GetPlayer(2) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				behaviour.SetTrigger("Achievements definitions could not be retrived for reason: ");
				HCCBOAMEEIJ = true;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			behaviour.SetTrigger("UI2");
			HCCBOAMEEIJ = false;
		}
	}

	[SpecialName]
	public static GassNPC KGPJPILAHDE()
	{
		return IADEMLIIDPC;
	}

	public void KDKEDKDAAFK(int questId)
	{
		Quest quest = QuestDatabaseAccessor.MGGNBIOLKDH(questId);
		if (Object.op_Implicit((Object)(object)quest))
		{
			QuestManager.GGFJGHHHEJC.AddQuest(quest, 1);
			QuestHighlightUI.OMDBOEAJLGA(quest);
		}
		else
		{
			Debug.LogError((object)("MineState" + questId));
		}
	}

	public void BAGCFNLJFDJ()
	{
		DEGPIHEEFHJ().gassAnimation.MGCAOHFOELI();
	}

	public void FJIJNLKJGKC()
	{
		if (Object.op_Implicit((Object)(object)currentGassState))
		{
			currentGassState.DCMAEDKOBIP();
		}
		DNCCDPKOJPB();
	}

	protected override void OnConversationStart(Transform actor)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationStart(actor);
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		HKKKNMIKPCM = ((Result)(ref variable)).asInt;
		variable = DialogueLua.GetVariable("Gass_CoctelQuest");
		IIAIJJFNNAO = ((Result)(ref variable)).asInt;
		if (PlayerInputs.IsGamepadActive(base.EHHOHCPHAAO))
		{
			InputDeviceManager.instance.inputDevice = (InputDevice)0;
		}
		else
		{
			InputDeviceManager.instance.inputDevice = (InputDevice)2;
		}
	}

	public void JFPGKDBBANJ(int questId)
	{
		Quest quest = QuestDatabaseAccessor.DJMDLPHMPEL(questId);
		if (Object.op_Implicit((Object)(object)quest))
		{
			QuestManager.OPILDPFDFKJ().NJDDJJEGOAF(quest, 0, FFJBIGFADBJ: true);
			QuestHighlightUI.HKKOKBMHLEJ(quest);
		}
		else
		{
			Debug.LogError((object)("itemGreenPepper" + questId));
		}
	}

	[SpecialName]
	public static GassNPC OAPOJCODNCO()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static GassNPC MIGKKKELOJO()
	{
		return IADEMLIIDPC;
	}

	public IEnumerator INEGGBILPON(SpriteRenderer ECOGJIGAMMA, float BMEBKODLPLF, float OMHCOLMFGNJ)
	{
		float time = 0f;
		float startValue = ECOGJIGAMMA.color.a;
		while (time < OMHCOLMFGNJ)
		{
			time += Time.deltaTime;
			float num = Mathf.Lerp(startValue, BMEBKODLPLF, time / OMHCOLMFGNJ);
			ECOGJIGAMMA.color = new Color(ECOGJIGAMMA.color.r, ECOGJIGAMMA.color.g, ECOGJIGAMMA.color.b, num);
			yield return null;
		}
	}

	private void NBADGIFFEFE()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.GetPlayer(1)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.OPHDCMJLLEC(8) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.GetPlayer(3)).transform.position, ((Component)this).transform.position);
		}
		if (DAOGEILONMP)
		{
			if (FDBCHJMHBKF < JPBMJHCACOD || ((Object)(object)PlayerController.GetPlayer(8) != (Object)null && IEIHJNPHGAJ < JPBMJHCACOD))
			{
				((MonoBehaviour)this).StartCoroutine(INEGGBILPON(gassSprite, 1763f, 1221f));
				((MonoBehaviour)this).StartCoroutine(MBDKADLLPMO(shadowSprite, 1486f, 1916f));
				DAOGEILONMP = false;
			}
		}
		else if ((Object)(object)PlayerController.GetPlayer(0) != (Object)null)
		{
			if (FDBCHJMHBKF > JPBMJHCACOD && IEIHJNPHGAJ > JPBMJHCACOD)
			{
				((MonoBehaviour)this).StartCoroutine(HKDLFHGFMAA(gassSprite, 72f, 1665f));
				((MonoBehaviour)this).StartCoroutine(MBDKADLLPMO(shadowSprite, 538f, 461f));
				DAOGEILONMP = false;
			}
		}
		else if (FDBCHJMHBKF > JPBMJHCACOD)
		{
			((MonoBehaviour)this).StartCoroutine(SpriteFade(gassSprite, 1389f, 1432f));
			((MonoBehaviour)this).StartCoroutine(INEGGBILPON(shadowSprite, 1829f, 1298f));
			DAOGEILONMP = false;
		}
		if (HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				behaviour.SetTrigger("Dialogue System/Conversation/TooDark/Entry/9/Dialogue Text");
				gassAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(1)).gameObject);
				HCCBOAMEEIJ = true;
			}
			else if ((Object)(object)PlayerController.OPHDCMJLLEC(1) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
			{
				behaviour.SetTrigger("Building");
				gassAnimation.LookAtObject(((Component)PlayerController.GetPlayer(2)).gameObject);
				HCCBOAMEEIJ = false;
			}
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(6) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				behaviour.SetTrigger("LE_14");
				HCCBOAMEEIJ = true;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			behaviour.SetTrigger("Current crafting:");
			HCCBOAMEEIJ = false;
		}
	}

	public void FBHIKLNIADH()
	{
		OJJDNLEFNPJ().gassAnimation.NPODAOACKCD();
	}

	private void BPPBLHOOEDE()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.GetPlayer(1) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position, ((Component)this).transform.position);
		}
		if (DAOGEILONMP)
		{
			if (FDBCHJMHBKF < JPBMJHCACOD || ((Object)(object)PlayerController.GetPlayer(2) != (Object)null && IEIHJNPHGAJ < JPBMJHCACOD))
			{
				((MonoBehaviour)this).StartCoroutine(MBDKADLLPMO(gassSprite, 832f, 694f));
				((MonoBehaviour)this).StartCoroutine(JJBBFCGJAGL(shadowSprite, 555f, 1219f));
				DAOGEILONMP = false;
			}
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(4) != (Object)null)
		{
			if (FDBCHJMHBKF > JPBMJHCACOD && IEIHJNPHGAJ > JPBMJHCACOD)
			{
				((MonoBehaviour)this).StartCoroutine(SpriteFade(gassSprite, 100f, 290f));
				((MonoBehaviour)this).StartCoroutine(INEGGBILPON(shadowSprite, 385f, 1400f));
				DAOGEILONMP = true;
			}
		}
		else if (FDBCHJMHBKF > JPBMJHCACOD)
		{
			((MonoBehaviour)this).StartCoroutine(SpriteFade(gassSprite, 606f, 978f));
			((MonoBehaviour)this).StartCoroutine(HKDLFHGFMAA(shadowSprite, 1258f, 420f));
			DAOGEILONMP = true;
		}
		if (HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				behaviour.SetTrigger("LE_10");
				gassAnimation.DGJJGINNOOH(((Component)PlayerController.OPHDCMJLLEC(0)).gameObject);
				HCCBOAMEEIJ = false;
			}
			else if ((Object)(object)PlayerController.GetPlayer(5) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
			{
				behaviour.SetTrigger("Right");
				gassAnimation.LookAtObject(((Component)PlayerController.GetPlayer(3)).gameObject, MAPFDGCKBLD: false);
				HCCBOAMEEIJ = true;
			}
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(1) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				behaviour.SetTrigger("\n");
				HCCBOAMEEIJ = true;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			behaviour.SetTrigger("City Update 0.6.5.0: Removing temple recipes with higher reputation level (");
			HCCBOAMEEIJ = true;
		}
	}

	public void JAPMKIPJBKH(int recipeId)
	{
		if (RecipesManager.CanUnlockRecipe(recipeId))
		{
			Sound.MAIDHAPANEB().CHFFLKLLNNJ(Utils.CPDCJAHJOPE(Sound.DIHCEGINELM().questComplete), HOMFPAFAOGD: false, null, null, 589f);
		}
		RecipesManager.EGEAPNOMMFG(recipeId);
	}

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	public void LHHNHMJNHDD(int questId)
	{
		Quest quest = QuestDatabaseAccessor.MFCLBOPPEBB(questId);
		if (Object.op_Implicit((Object)(object)quest))
		{
			QuestManager.GJFMMOPOKGJ().AddQuest(quest, 1, FFJBIGFADBJ: false, CDPAMNIPPEC: false);
			QuestHighlightUI.OMDBOEAJLGA(quest, LFBJCGLGEIN: false);
		}
		else
		{
			Debug.LogError((object)("Turn Off" + questId));
		}
	}

	public void PGFPLDCFLCE()
	{
		OJJDNLEFNPJ().gassAnimation.NPODAOACKCD();
	}

	public void EGLJIADCAHH()
	{
		ShopUI.FKFNANNBIAM(MIGKKKELOJO().EHHOHCPHAAO).shop = shop;
		ShopUI.Get(OFLELHKKNKC().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	public void NBNCMOAPDOG()
	{
		if (Object.op_Implicit((Object)(object)currentGassState))
		{
			currentGassState.ALCKBMMCBBF();
		}
		HEANIMJDIJJ();
	}

	public void PBCJJIHONNC()
	{
		OAPOJCODNCO().gassAnimation.GEDCKBLDAFG();
	}

	public void GJCOIDOIBKM(int recipeId)
	{
		if (RecipesManager.CanUnlockRecipe(recipeId))
		{
			Sound.MAIDHAPANEB().PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.OKAPNFPFPFP().questComplete), HOMFPAFAOGD: false, null, null, 830f);
		}
		RecipesManager.EGEAPNOMMFG(recipeId);
	}

	public IEnumerator JJBBFCGJAGL(SpriteRenderer ECOGJIGAMMA, float BMEBKODLPLF, float OMHCOLMFGNJ)
	{
		float time = 0f;
		float startValue = ECOGJIGAMMA.color.a;
		while (time < OMHCOLMFGNJ)
		{
			time += Time.deltaTime;
			float num = Mathf.Lerp(startValue, BMEBKODLPLF, time / OMHCOLMFGNJ);
			ECOGJIGAMMA.color = new Color(ECOGJIGAMMA.color.r, ECOGJIGAMMA.color.g, ECOGJIGAMMA.color.b, num);
			yield return null;
		}
	}

	public void GAFBMGIJGHM(int recipeId)
	{
		if (RecipesManager.OECEJEDHHNK(recipeId))
		{
			Sound.OKAPNFPFPFP().PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.OKAPNFPFPFP().questComplete), HOMFPAFAOGD: true, null, null, 525f);
		}
		RecipesManager.UnlockRecipe(recipeId, IBHGAMNNOHI: true);
	}

	public void NGFCBKIGJJA()
	{
		if (FDBCHJMHBKF < PMCKBLAPLKK)
		{
			gassAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(1)).gameObject);
		}
		else if ((Object)(object)PlayerController.GetPlayer(1) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
		{
			gassAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(0)).gameObject);
		}
	}

	public void BPDPPBDHJEL(string emotion)
	{
		OFLELHKKNKC().emotionsController.DCCNJLBLFGI(emotion);
	}

	public void IEMCJPLDAMN(int recipeId)
	{
		if (RecipesManager.CanUnlockRecipe(recipeId))
		{
			Sound.BNBMNOMFFBE().MFBBFAINMHG(Utils.CPDCJAHJOPE(Sound.ABDJJBFNLBJ().questComplete), HOMFPAFAOGD: false, null, null, 664f);
		}
		RecipesManager.UnlockRecipe(recipeId, IBHGAMNNOHI: true);
	}

	private void DNCCDPKOJPB()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.GetPlayer(0)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.GetPlayer(5) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(7)).transform.position, ((Component)this).transform.position);
		}
		if (DAOGEILONMP)
		{
			if (FDBCHJMHBKF < JPBMJHCACOD || ((Object)(object)PlayerController.GetPlayer(4) != (Object)null && IEIHJNPHGAJ < JPBMJHCACOD))
			{
				((MonoBehaviour)this).StartCoroutine(SpriteFade(gassSprite, 244f, 891f));
				((MonoBehaviour)this).StartCoroutine(NPOAPDLIEBI(shadowSprite, 1984f, 1368f));
				DAOGEILONMP = true;
			}
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(6) != (Object)null)
		{
			if (FDBCHJMHBKF > JPBMJHCACOD && IEIHJNPHGAJ > JPBMJHCACOD)
			{
				((MonoBehaviour)this).StartCoroutine(JJBBFCGJAGL(gassSprite, 993f, 1638f));
				((MonoBehaviour)this).StartCoroutine(INEGGBILPON(shadowSprite, 1399f, 1750f));
				DAOGEILONMP = true;
			}
		}
		else if (FDBCHJMHBKF > JPBMJHCACOD)
		{
			((MonoBehaviour)this).StartCoroutine(MBDKADLLPMO(gassSprite, 998f, 1525f));
			((MonoBehaviour)this).StartCoroutine(MBDKADLLPMO(shadowSprite, 1259f, 1872f));
			DAOGEILONMP = true;
		}
		if (HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				behaviour.SetTrigger("Prefab not found for item with id ");
				gassAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(0)).gameObject);
				HCCBOAMEEIJ = false;
			}
			else if ((Object)(object)PlayerController.GetPlayer(6) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
			{
				behaviour.SetTrigger(" for reason ");
				gassAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(7)).gameObject);
				HCCBOAMEEIJ = false;
			}
		}
		else if ((Object)(object)PlayerController.GetPlayer(7) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				behaviour.SetTrigger("Dig");
				HCCBOAMEEIJ = false;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			behaviour.SetTrigger("piratescave");
			HCCBOAMEEIJ = false;
		}
	}

	[SpecialName]
	public static GassNPC ABHIDHPMLLD()
	{
		return IADEMLIIDPC;
	}

	public void DMMKBJELFNB()
	{
		if (FDBCHJMHBKF < PMCKBLAPLKK)
		{
			gassAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(0)).gameObject, MAPFDGCKBLD: false);
		}
		else if ((Object)(object)PlayerController.GetPlayer(5) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
		{
			gassAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(2)).gameObject, MAPFDGCKBLD: false);
		}
	}

	[SpecialName]
	public static GassNPC OFLELHKKNKC()
	{
		return IADEMLIIDPC;
	}

	public void NLOEGNNLKKE()
	{
		if (Object.op_Implicit((Object)(object)currentGassState))
		{
			currentGassState.BIKCLEKAMBD();
		}
		PDHHDGGKBHA();
	}

	public void AddQuest(int questId)
	{
		Quest quest = QuestDatabaseAccessor.GetQuest(questId);
		if (Object.op_Implicit((Object)(object)quest))
		{
			QuestManager.GGFJGHHHEJC.AddQuest(quest);
			QuestHighlightUI.ShowNewQuestAvailable(quest, LFBJCGLGEIN: false);
		}
		else
		{
			Debug.LogError((object)("Quest not found with ID " + questId));
		}
	}

	private void EOBOKEELKMN()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.GetPlayer(1)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.GetPlayer(3) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.GetPlayer(8)).transform.position, ((Component)this).transform.position);
		}
		if (DAOGEILONMP)
		{
			if (FDBCHJMHBKF < JPBMJHCACOD || ((Object)(object)PlayerController.OPHDCMJLLEC(0) != (Object)null && IEIHJNPHGAJ < JPBMJHCACOD))
			{
				((MonoBehaviour)this).StartCoroutine(HKDLFHGFMAA(gassSprite, 1026f, 677f));
				((MonoBehaviour)this).StartCoroutine(MBDKADLLPMO(shadowSprite, 1341f, 758f));
				DAOGEILONMP = false;
			}
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(0) != (Object)null)
		{
			if (FDBCHJMHBKF > JPBMJHCACOD && IEIHJNPHGAJ > JPBMJHCACOD)
			{
				((MonoBehaviour)this).StartCoroutine(MBDKADLLPMO(gassSprite, 282f, 1609f));
				((MonoBehaviour)this).StartCoroutine(MBDKADLLPMO(shadowSprite, 1286f, 54f));
				DAOGEILONMP = false;
			}
		}
		else if (FDBCHJMHBKF > JPBMJHCACOD)
		{
			((MonoBehaviour)this).StartCoroutine(NPOAPDLIEBI(gassSprite, 377f, 130f));
			((MonoBehaviour)this).StartCoroutine(HKDLFHGFMAA(shadowSprite, 772f, 1954f));
			DAOGEILONMP = false;
		}
		if (HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				behaviour.SetTrigger("Juicy");
				gassAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(0)).gameObject, MAPFDGCKBLD: false);
				HCCBOAMEEIJ = true;
			}
			else if ((Object)(object)PlayerController.GetPlayer(4) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
			{
				behaviour.SetTrigger("Visita Nocturna/MaiDialogue 01");
				gassAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(6)).gameObject, MAPFDGCKBLD: false);
				HCCBOAMEEIJ = false;
			}
		}
		else if ((Object)(object)PlayerController.GetPlayer(7) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				behaviour.SetTrigger("-1");
				HCCBOAMEEIJ = true;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			behaviour.SetTrigger("ReceiveHit");
			HCCBOAMEEIJ = false;
		}
	}

	protected override void NJJCCIBDAPM()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Gass_CoctelQuest");
		if (((Result)(ref variable)).asInt == 0)
		{
			variable = DialogueLua.GetVariable("LE_2");
			if (((Result)(ref variable)).asInt == 0)
			{
				dialogue.conversation = "Gass_Introduce";
			}
			else
			{
				dialogue.conversation = "Gass_Stand";
			}
		}
		else
		{
			dialogue.conversation = "Gass_Quest";
		}
	}

	public IEnumerator MBDKADLLPMO(SpriteRenderer ECOGJIGAMMA, float BMEBKODLPLF, float OMHCOLMFGNJ)
	{
		return new DIDANDDLLCB(1)
		{
			sr = ECOGJIGAMMA,
			endValue = BMEBKODLPLF,
			duration = OMHCOLMFGNJ
		};
	}

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	public void NODDNBFDJGO()
	{
		if (Object.op_Implicit((Object)(object)currentGassState))
		{
			currentGassState.JKHEHPLBHMK();
		}
		BPPBLHOOEDE();
	}

	public void HKPCGIDDBOE()
	{
		KGPJPILAHDE().gassAnimation.LDAJDPGICED();
	}

	public void DNIKLLFLPKA()
	{
		OFLELHKKNKC().gassAnimation.EDPPCEBPLMH();
	}

	public void EFOEDOJOFEH(string emotion)
	{
		DEGPIHEEFHJ().emotionsController.NMAPMPBAGMM(emotion);
	}

	public void EDFIMPHDOAD()
	{
		OAPOJCODNCO().gassAnimation.HKBACCPFJFF();
	}

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
		NJJCCIBDAPM();
		behaviour.SetTrigger("Walk");
	}

	[SpecialName]
	public static GassNPC BIIOFAHFNPA()
	{
		return IADEMLIIDPC;
	}
}
