using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;

public class SnowMonticle : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class PLKPOGOBLAB : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SnowMonticle _003C_003E4__this;

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
		public PLKPOGOBLAB(int _003C_003E1__state)
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
			SnowMonticle snowMonticle = _003C_003E4__this;
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
				((Renderer)snowMonticle.monticleRenderer).enabled = false;
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

	public SpriteRenderer monticleRenderer;

	[HideInInspector]
	public bool monticleIsFrozen;

	public GameObject particles;

	public Collider2D colliderMonticle;

	public float verticalOffset = -0.25f;

	private void PBFAEPOEKPG()
	{
		Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(PJDBLLIIEDG));
		PPFAJNOOAND();
	}

	private void EIMIDCDEIDD()
	{
		monticleIsFrozen = true;
		if ((Object)(object)colliderMonticle == (Object)null)
		{
			colliderMonticle = ((Component)this).GetComponent<Collider2D>();
		}
	}

	private void JAEFECCLFAK()
	{
		((Renderer)monticleRenderer).enabled = false;
		monticleIsFrozen = false;
		((Behaviour)colliderMonticle).enabled = true;
	}

	private void DNBGIIGAKMJ()
	{
		monticleIsFrozen = false;
		if ((Object)(object)colliderMonticle == (Object)null)
		{
			colliderMonticle = ((Component)this).GetComponent<Collider2D>();
		}
	}

	private void OnDestroy()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(LDJONNBEPMH));
	}

	private void GECHJIGBPEN()
	{
		monticleIsFrozen = true;
		if ((Object)(object)colliderMonticle == (Object)null)
		{
			colliderMonticle = ((Component)this).GetComponent<Collider2D>();
		}
	}

	private IEnumerator LKOLPMPAJNM()
	{
		yield return CommonReferences.wait02;
		((Renderer)monticleRenderer).enabled = false;
	}

	private void KFJJOPNFPND()
	{
		((Renderer)monticleRenderer).enabled = false;
		monticleIsFrozen = true;
		((Behaviour)colliderMonticle).enabled = true;
	}

	private void ICLHMIDJBLE()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(KFJJOPNFPND));
	}

	private void EEFKKLDCGAE(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Items/item_name_1049") || ((Component)HANHCHBHHEH).CompareTag("Price of ") || ((Component)HANHCHBHHEH).CompareTag(" ("))
		{
			JGBIMFPLLLB();
		}
	}

	private IEnumerator BCPAKMIJFFG()
	{
		yield return CommonReferences.wait02;
		((Renderer)monticleRenderer).enabled = false;
	}

	private IEnumerator DHLFABGLMEE()
	{
		yield return CommonReferences.wait02;
		((Renderer)monticleRenderer).enabled = false;
	}

	private void MJKDLOHNECA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(" (versionOfCropsAndRecipes)") || ((Component)HANHCHBHHEH).CompareTag("bartenderDesc") || ((Component)HANHCHBHHEH).CompareTag("Pants_R"))
		{
			OGFLMFPGBJB();
		}
	}

	public void UnfrozenMonticle()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		Object.Instantiate<GameObject>(particles, Vector2.op_Implicit(new Vector2(((Component)this).transform.position.x, ((Component)this).transform.position.y + verticalOffset)), ((Component)this).transform.rotation);
		monticleIsFrozen = false;
		((Behaviour)colliderMonticle).enabled = false;
		((MonoBehaviour)this).StartCoroutine(MIPOAFODFHC());
		if (Object.op_Implicit((Object)(object)Sound.GGFJGHHHEJC.snowHit))
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.snowHit, ((Component)this).transform.position);
		}
	}

	private void ADIGNNPBACJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Alpha") || ((Component)HANHCHBHHEH).CompareTag("INeedWater") || ((Component)HANHCHBHHEH).CompareTag("Farm/Arthur/Main"))
		{
			JFPJDAGHFKP();
		}
	}

	private void EEKCJAAGFHM()
	{
		((Renderer)monticleRenderer).enabled = true;
		monticleIsFrozen = true;
		((Behaviour)colliderMonticle).enabled = true;
	}

	private void HCEDMLJNOBL()
	{
		Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(PJDBLLIIEDG));
		KFJJOPNFPND();
	}

	private void APEIPGIHEKP()
	{
		Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(IACHHJLBPNE));
		GIOKADKLGKA();
	}

	private void NDGFPPOBCNP()
	{
		Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(JKMIFEAIKGM));
		AMDKNKJIKFP();
	}

	private void CFHOODNCOLK()
	{
		Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(MFPJMNDJNIF));
		IIAGABOLAGJ();
	}

	private void AGPONCCIFHC()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(EACGHGFJFLO));
	}

	private IEnumerator EPBPICMFOEJ()
	{
		return new PLKPOGOBLAB(1)
		{
			_003C_003E4__this = this
		};
	}

	public void EEFJOOOJDOP()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		Object.Instantiate<GameObject>(particles, Vector2.op_Implicit(new Vector2(((Component)this).transform.position.x, ((Component)this).transform.position.y + verticalOffset)), ((Component)this).transform.rotation);
		monticleIsFrozen = false;
		((Behaviour)colliderMonticle).enabled = false;
		((MonoBehaviour)this).StartCoroutine(DHLFABGLMEE());
		if (Object.op_Implicit((Object)(object)Sound.DIHCEGINELM().snowHit))
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.snowHit, ((Component)this).transform.position);
		}
	}

	private void PDCJGGJMPCN(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Checking is DLC ") || ((Component)HANHCHBHHEH).CompareTag("Items/item_name_1119") || ((Component)HANHCHBHHEH).CompareTag(" "))
		{
			CBOJDKCLMFF();
		}
	}

	private void CDFMNDEKBJE()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(PKALGBAEPGE));
	}

	private void BGIPELPEKJD()
	{
		((Renderer)monticleRenderer).enabled = false;
		monticleIsFrozen = false;
		((Behaviour)colliderMonticle).enabled = false;
	}

	private IEnumerator JFOCLIJEDEB()
	{
		return new PLKPOGOBLAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void KJOJLHCDFPP()
	{
		Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(EEKCJAAGFHM));
		JKMIFEAIKGM();
	}

	public void HFMPPOBDMHK()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		Object.Instantiate<GameObject>(particles, Vector2.op_Implicit(new Vector2(((Component)this).transform.position.x, ((Component)this).transform.position.y + verticalOffset)), ((Component)this).transform.rotation);
		monticleIsFrozen = false;
		((Behaviour)colliderMonticle).enabled = false;
		((MonoBehaviour)this).StartCoroutine(PBEHDEAFFJH());
		if (Object.op_Implicit((Object)(object)Sound.GGFJGHHHEJC.snowHit))
		{
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().snowHit, ((Component)this).transform.position);
		}
	}

	private void GOOPOBMDALA()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(MFPJMNDJNIF));
	}

	private void Start()
	{
		Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(LDJONNBEPMH));
		LDJONNBEPMH();
	}

	private void PKILBBEDHBH()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(KFJJOPNFPND));
	}

	private IEnumerator PMHCGNLABHD()
	{
		return new PLKPOGOBLAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void MPGPLILIJOD()
	{
		monticleIsFrozen = false;
		if ((Object)(object)colliderMonticle == (Object)null)
		{
			colliderMonticle = ((Component)this).GetComponent<Collider2D>();
		}
	}

	private void PKKBPKPMMJG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("HarvestableDuringTwoMonths") || ((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/10/Dialogue Text") || ((Component)HANHCHBHHEH).CompareTag("Tutorial_Main_"))
		{
			KADFDNOHAIC();
		}
	}

	private IEnumerator MNAAMOCOKKM()
	{
		yield return CommonReferences.wait02;
		((Renderer)monticleRenderer).enabled = false;
	}

	private void MNABONMMFFB()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(EEKCJAAGFHM));
	}

	private void HOKPMNHKANO(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("RecalculatingAllWallTiles (ONLINE) [client]") || ((Component)HANHCHBHHEH).CompareTag("End") || ((Component)HANHCHBHHEH).CompareTag("Cat"))
		{
			KADFDNOHAIC();
		}
	}

	private void JPPEHGAHBCN()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(IACHHJLBPNE));
	}

	private IEnumerator MFAGALHOEAK()
	{
		return new PLKPOGOBLAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void MFPJMNDJNIF()
	{
		((Renderer)monticleRenderer).enabled = false;
		monticleIsFrozen = false;
		((Behaviour)colliderMonticle).enabled = false;
	}

	public void KDAKPCJFGGD()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		Object.Instantiate<GameObject>(particles, Vector2.op_Implicit(new Vector2(((Component)this).transform.position.x, ((Component)this).transform.position.y + verticalOffset)), ((Component)this).transform.rotation);
		monticleIsFrozen = true;
		((Behaviour)colliderMonticle).enabled = true;
		((MonoBehaviour)this).StartCoroutine(KGNHNMHIABF());
		if (Object.op_Implicit((Object)(object)Sound.GGFJGHHHEJC.snowHit))
		{
			MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().snowHit, ((Component)this).transform.position);
		}
	}

	private IEnumerator AMHIAJNGDCP()
	{
		yield return CommonReferences.wait02;
		((Renderer)monticleRenderer).enabled = false;
	}

	private void DEOPBEHPEIN(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Left Alt") || ((Component)HANHCHBHHEH).CompareTag("==============================") || ((Component)HANHCHBHHEH).CompareTag("========================================================================================"))
		{
			FEKFCFHMKHH();
		}
	}

	public void AALIFPBNJBC()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		Object.Instantiate<GameObject>(particles, Vector2.op_Implicit(new Vector2(((Component)this).transform.position.x, ((Component)this).transform.position.y + verticalOffset)), ((Component)this).transform.rotation);
		monticleIsFrozen = true;
		((Behaviour)colliderMonticle).enabled = true;
		((MonoBehaviour)this).StartCoroutine(MIPOAFODFHC());
		if (Object.op_Implicit((Object)(object)Sound.MAIDHAPANEB().snowHit))
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.snowHit, ((Component)this).transform.position);
		}
	}

	public void AAKABBNDIMD()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		Object.Instantiate<GameObject>(particles, Vector2.op_Implicit(new Vector2(((Component)this).transform.position.x, ((Component)this).transform.position.y + verticalOffset)), ((Component)this).transform.rotation);
		monticleIsFrozen = true;
		((Behaviour)colliderMonticle).enabled = true;
		((MonoBehaviour)this).StartCoroutine(FENDDEIOKOF());
		if (Object.op_Implicit((Object)(object)Sound.OKAPNFPFPFP().snowHit))
		{
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().snowHit, ((Component)this).transform.position);
		}
	}

	private void LEEOKPCIOGA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("[SelectSpawnersByMaxDistance] Candidate {0} score:{1:F1} (entrance:{2:F1} mutual:{3:F1} altar:{4:F1} exit:{5:F1})") || ((Component)HANHCHBHHEH).CompareTag("Wall") || ((Component)HANHCHBHHEH).CompareTag("tutorialCompleted"))
		{
			HFMPPOBDMHK();
		}
	}

	private IEnumerator KJILPDDMNGK()
	{
		return new PLKPOGOBLAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JLFLCGHFLPB()
	{
		((Renderer)monticleRenderer).enabled = true;
		monticleIsFrozen = false;
		((Behaviour)colliderMonticle).enabled = true;
	}

	private void FJOGFDEEOAG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("BeginChatFade") || ((Component)HANHCHBHHEH).CompareTag("itemGrog") || ((Component)HANHCHBHHEH).CompareTag("Tutorial/T134/Dialogue1"))
		{
			HFBMNPNPLKP();
		}
	}

	private void LDJONNBEPMH()
	{
		((Renderer)monticleRenderer).enabled = true;
		monticleIsFrozen = true;
		((Behaviour)colliderMonticle).enabled = true;
	}

	private void OnTriggerEnter2D(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Player") || ((Component)HANHCHBHHEH).CompareTag("Player2") || ((Component)HANHCHBHHEH).CompareTag("Animal"))
		{
			UnfrozenMonticle();
		}
	}

	private IEnumerator HGCFAJBODNC()
	{
		yield return CommonReferences.wait02;
		((Renderer)monticleRenderer).enabled = false;
	}

	public void CLFLCADMJMC()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		Object.Instantiate<GameObject>(particles, Vector2.op_Implicit(new Vector2(((Component)this).transform.position.x, ((Component)this).transform.position.y + verticalOffset)), ((Component)this).transform.rotation);
		monticleIsFrozen = false;
		((Behaviour)colliderMonticle).enabled = false;
		((MonoBehaviour)this).StartCoroutine(FENDDEIOKOF());
		if (Object.op_Implicit((Object)(object)Sound.BNBMNOMFFBE().snowHit))
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.snowHit, ((Component)this).transform.position);
		}
	}

	private void KGPOCJEHHHH()
	{
		Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(PJDBLLIIEDG));
		BGIPELPEKJD();
	}

	private void BDMEBLBLPIA()
	{
		Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(EEKCJAAGFHM));
		JAEFECCLFAK();
	}

	private void JBBHDOMALDB()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(JKMIFEAIKGM));
	}

	private void NJHPBIEELLK()
	{
		((Renderer)monticleRenderer).enabled = false;
		monticleIsFrozen = false;
		((Behaviour)colliderMonticle).enabled = false;
	}

	private void AGILHHEMEFC()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(LDJONNBEPMH));
	}

	public void PPOFNPJOJLI()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		Object.Instantiate<GameObject>(particles, Vector2.op_Implicit(new Vector2(((Component)this).transform.position.x, ((Component)this).transform.position.y + verticalOffset)), ((Component)this).transform.rotation);
		monticleIsFrozen = true;
		((Behaviour)colliderMonticle).enabled = true;
		((MonoBehaviour)this).StartCoroutine(JFOCLIJEDEB());
		if (Object.op_Implicit((Object)(object)Sound.MAIDHAPANEB().snowHit))
		{
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().snowHit, ((Component)this).transform.position);
		}
	}

	private void LJJDGAJNNCH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("") || ((Component)HANHCHBHHEH).CompareTag("LE_18") || ((Component)HANHCHBHHEH).CompareTag("[PlayerGender="))
		{
			HFBMNPNPLKP();
		}
	}

	private IEnumerator FENDDEIOKOF()
	{
		yield return CommonReferences.wait02;
		((Renderer)monticleRenderer).enabled = false;
	}

	public void BHKMNMHDCLB()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		Object.Instantiate<GameObject>(particles, Vector2.op_Implicit(new Vector2(((Component)this).transform.position.x, ((Component)this).transform.position.y + verticalOffset)), ((Component)this).transform.rotation);
		monticleIsFrozen = false;
		((Behaviour)colliderMonticle).enabled = false;
		((MonoBehaviour)this).StartCoroutine(FBMGIGFLAOP());
		if (Object.op_Implicit((Object)(object)Sound.MAIDHAPANEB().snowHit))
		{
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().snowHit, ((Component)this).transform.position);
		}
	}

	private void EBNKNEIDDDI()
	{
		Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(ADCKLHKAOBC));
		EACGHGFJFLO();
	}

	private void JHBBABPAJJC()
	{
		Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(OFGIFNGNGLE));
		LDJONNBEPMH();
	}

	private void GLMENOJADEF(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Shovah3D") || ((Component)HANHCHBHHEH).CompareTag("Cancel") || ((Component)HANHCHBHHEH).CompareTag("Updating Path Nodes "))
		{
			KADFDNOHAIC();
		}
	}

	private IEnumerator NEJHLNKONLG()
	{
		yield return CommonReferences.wait02;
		((Renderer)monticleRenderer).enabled = false;
	}

	private void PFIONHCONDI(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("[PipeConnectionPuzzleUI] Sin _tileDatabase: los tiles de entrada/salida no tendrán sprite.") || ((Component)HANHCHBHHEH).CompareTag(":") || ((Component)HANHCHBHHEH).CompareTag("Items/item_name_1176"))
		{
			JGKGIODKKHM();
		}
	}

	private void AMDKNKJIKFP()
	{
		((Renderer)monticleRenderer).enabled = false;
		monticleIsFrozen = false;
		((Behaviour)colliderMonticle).enabled = false;
	}

	private void OBHFJIDKBJN()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(BGIPELPEKJD));
	}

	public void CBOJDKCLMFF()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		Object.Instantiate<GameObject>(particles, Vector2.op_Implicit(new Vector2(((Component)this).transform.position.x, ((Component)this).transform.position.y + verticalOffset)), ((Component)this).transform.rotation);
		monticleIsFrozen = false;
		((Behaviour)colliderMonticle).enabled = false;
		((MonoBehaviour)this).StartCoroutine(BCPAKMIJFFG());
		if (Object.op_Implicit((Object)(object)Sound.OKAPNFPFPFP().snowHit))
		{
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().snowHit, ((Component)this).transform.position);
		}
	}

	private void PKHMNNJFLAA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("CultivableDuringThreeMonths") || ((Component)HANHCHBHHEH).CompareTag("Rest") || ((Component)HANHCHBHHEH).CompareTag("TermasInterior/Kenta/Stand"))
		{
			MDLNJPDLBMF();
		}
	}

	public void JGKGIODKKHM()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		Object.Instantiate<GameObject>(particles, Vector2.op_Implicit(new Vector2(((Component)this).transform.position.x, ((Component)this).transform.position.y + verticalOffset)), ((Component)this).transform.rotation);
		monticleIsFrozen = false;
		((Behaviour)colliderMonticle).enabled = true;
		((MonoBehaviour)this).StartCoroutine(PMHCGNLABHD());
		if (Object.op_Implicit((Object)(object)Sound.GGFJGHHHEJC.snowHit))
		{
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().snowHit, ((Component)this).transform.position);
		}
	}

	private void GNAJBACLEKG()
	{
		monticleIsFrozen = true;
		if ((Object)(object)colliderMonticle == (Object)null)
		{
			colliderMonticle = ((Component)this).GetComponent<Collider2D>();
		}
	}

	private void ADCKLHKAOBC()
	{
		((Renderer)monticleRenderer).enabled = true;
		monticleIsFrozen = false;
		((Behaviour)colliderMonticle).enabled = true;
	}

	public void JGBIMFPLLLB()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		Object.Instantiate<GameObject>(particles, Vector2.op_Implicit(new Vector2(((Component)this).transform.position.x, ((Component)this).transform.position.y + verticalOffset)), ((Component)this).transform.rotation);
		monticleIsFrozen = true;
		((Behaviour)colliderMonticle).enabled = false;
		((MonoBehaviour)this).StartCoroutine(BCPAKMIJFFG());
		if (Object.op_Implicit((Object)(object)Sound.BNBMNOMFFBE().snowHit))
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.snowHit, ((Component)this).transform.position);
		}
	}

	private void GIOKADKLGKA()
	{
		((Renderer)monticleRenderer).enabled = false;
		monticleIsFrozen = true;
		((Behaviour)colliderMonticle).enabled = true;
	}

	private void KFBCJNFMPIL()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(IIAGABOLAGJ));
	}

	private void PFLBPMIEKGF()
	{
		Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(NKDHCHLEFNP));
		BGIPELPEKJD();
	}

	private void MDIENLHEDGE()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(JAEFECCLFAK));
	}

	private void FJEKAKFLJJM(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("MineState") || ((Component)HANHCHBHHEH).CompareTag("OnFloor") || ((Component)HANHCHBHHEH).CompareTag("ChocolateAleAbbreviation"))
		{
			AALIFPBNJBC();
		}
	}

	private void CBPBPBAFPPL()
	{
		((Renderer)monticleRenderer).enabled = false;
		monticleIsFrozen = false;
		((Behaviour)colliderMonticle).enabled = true;
	}

	public void KJPNFACLHIF()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		Object.Instantiate<GameObject>(particles, Vector2.op_Implicit(new Vector2(((Component)this).transform.position.x, ((Component)this).transform.position.y + verticalOffset)), ((Component)this).transform.rotation);
		monticleIsFrozen = true;
		((Behaviour)colliderMonticle).enabled = true;
		((MonoBehaviour)this).StartCoroutine(EPBPICMFOEJ());
		if (Object.op_Implicit((Object)(object)Sound.ABDJJBFNLBJ().snowHit))
		{
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().snowHit, ((Component)this).transform.position);
		}
	}

	private IEnumerator PBEHDEAFFJH()
	{
		yield return CommonReferences.wait02;
		((Renderer)monticleRenderer).enabled = false;
	}

	private void FFAECPIMMIL(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("KlaynNPC: ChangeState called with invalid state: ") || ((Component)HANHCHBHHEH).CompareTag("Trying to get friend ") || ((Component)HANHCHBHHEH).CompareTag("Could not find GetDecoTile with id: "))
		{
			CLFLCADMJMC();
		}
	}

	private void PKALGBAEPGE()
	{
		((Renderer)monticleRenderer).enabled = true;
		monticleIsFrozen = false;
		((Behaviour)colliderMonticle).enabled = true;
	}

	private void GOJKOBEEMNA()
	{
		monticleIsFrozen = true;
		if ((Object)(object)colliderMonticle == (Object)null)
		{
			colliderMonticle = ((Component)this).GetComponent<Collider2D>();
		}
	}

	private void JCHMICLODGM()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(PJDBLLIIEDG));
	}

	public void FEKFCFHMKHH()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		Object.Instantiate<GameObject>(particles, Vector2.op_Implicit(new Vector2(((Component)this).transform.position.x, ((Component)this).transform.position.y + verticalOffset)), ((Component)this).transform.rotation);
		monticleIsFrozen = true;
		((Behaviour)colliderMonticle).enabled = false;
		((MonoBehaviour)this).StartCoroutine(OIDLLIBBDBD());
		if (Object.op_Implicit((Object)(object)Sound.GGFJGHHHEJC.snowHit))
		{
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().snowHit, ((Component)this).transform.position);
		}
	}

	private void AAENCDNIBFJ()
	{
		monticleIsFrozen = true;
		if ((Object)(object)colliderMonticle == (Object)null)
		{
			colliderMonticle = ((Component)this).GetComponent<Collider2D>();
		}
	}

	public void JFPJDAGHFKP()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		Object.Instantiate<GameObject>(particles, Vector2.op_Implicit(new Vector2(((Component)this).transform.position.x, ((Component)this).transform.position.y + verticalOffset)), ((Component)this).transform.rotation);
		monticleIsFrozen = false;
		((Behaviour)colliderMonticle).enabled = false;
		((MonoBehaviour)this).StartCoroutine(PMHCGNLABHD());
		if (Object.op_Implicit((Object)(object)Sound.BNBMNOMFFBE().snowHit))
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.snowHit, ((Component)this).transform.position);
		}
	}

	private void Awake()
	{
		monticleIsFrozen = true;
		if ((Object)(object)colliderMonticle == (Object)null)
		{
			colliderMonticle = ((Component)this).GetComponent<Collider2D>();
		}
	}

	private void JKMIFEAIKGM()
	{
		((Renderer)monticleRenderer).enabled = true;
		monticleIsFrozen = true;
		((Behaviour)colliderMonticle).enabled = false;
	}

	private void IHICKHAABJH()
	{
		monticleIsFrozen = true;
		if ((Object)(object)colliderMonticle == (Object)null)
		{
			colliderMonticle = ((Component)this).GetComponent<Collider2D>();
		}
	}

	private IEnumerator FLPEKCFHNAF()
	{
		return new PLKPOGOBLAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void CABLNGODDKN()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(PJDBLLIIEDG));
	}

	private void DONGKOKMGMM()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(JLFLCGHFLPB));
	}

	private void HBMJKMEKIPD()
	{
		Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(ADCKLHKAOBC));
		MFPJMNDJNIF();
	}

	private void PDCKFGAJDJP(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Private Example Method") || ((Component)HANHCHBHHEH).CompareTag("") || ((Component)HANHCHBHHEH).CompareTag("Miners/Mine/Ferro/Explosion"))
		{
			AAKABBNDIMD();
		}
	}

	public void MCDFJMCOBIN()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		Object.Instantiate<GameObject>(particles, Vector2.op_Implicit(new Vector2(((Component)this).transform.position.x, ((Component)this).transform.position.y + verticalOffset)), ((Component)this).transform.rotation);
		monticleIsFrozen = false;
		((Behaviour)colliderMonticle).enabled = true;
		((MonoBehaviour)this).StartCoroutine(KJILPDDMNGK());
		if (Object.op_Implicit((Object)(object)Sound.OKAPNFPFPFP().snowHit))
		{
			MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().snowHit, ((Component)this).transform.position);
		}
	}

	private void HJMGMIKGPOI(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("AceT_Quest") || ((Component)HANHCHBHHEH).CompareTag("</color>") || ((Component)HANHCHBHHEH).CompareTag("Crop with ID "))
		{
			MCDFJMCOBIN();
		}
	}

	private void CEOEHODJAJK()
	{
		monticleIsFrozen = true;
		if ((Object)(object)colliderMonticle == (Object)null)
		{
			colliderMonticle = ((Component)this).GetComponent<Collider2D>();
		}
	}

	private void FLFBLIOOLMA()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(EACGHGFJFLO));
	}

	public void JKKIEJBKLAK()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		Object.Instantiate<GameObject>(particles, Vector2.op_Implicit(new Vector2(((Component)this).transform.position.x, ((Component)this).transform.position.y + verticalOffset)), ((Component)this).transform.rotation);
		monticleIsFrozen = false;
		((Behaviour)colliderMonticle).enabled = false;
		((MonoBehaviour)this).StartCoroutine(LKOLPMPAJNM());
		if (Object.op_Implicit((Object)(object)Sound.ABDJJBFNLBJ().snowHit))
		{
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().snowHit, ((Component)this).transform.position);
		}
	}

	private IEnumerator MIPOAFODFHC()
	{
		yield return CommonReferences.wait02;
		((Renderer)monticleRenderer).enabled = false;
	}

	private void GHOKECKAICE()
	{
		monticleIsFrozen = true;
		if ((Object)(object)colliderMonticle == (Object)null)
		{
			colliderMonticle = ((Component)this).GetComponent<Collider2D>();
		}
	}

	private void OJJCGNICMBD()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(EACGHGFJFLO));
	}

	private void FJMBOFEILBN()
	{
		Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(MFPJMNDJNIF));
		NJHPBIEELLK();
	}

	private void CFNJNAFKNAP()
	{
		Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(AMDKNKJIKFP));
		JLFLCGHFLPB();
	}

	private void FHOCCEBKHJI()
	{
		monticleIsFrozen = true;
		if ((Object)(object)colliderMonticle == (Object)null)
		{
			colliderMonticle = ((Component)this).GetComponent<Collider2D>();
		}
	}

	private void PJDBLLIIEDG()
	{
		((Renderer)monticleRenderer).enabled = false;
		monticleIsFrozen = true;
		((Behaviour)colliderMonticle).enabled = true;
	}

	private void FFHIGDJEFJE()
	{
		monticleIsFrozen = true;
		if ((Object)(object)colliderMonticle == (Object)null)
		{
			colliderMonticle = ((Component)this).GetComponent<Collider2D>();
		}
	}

	public void MDLNJPDLBMF()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		Object.Instantiate<GameObject>(particles, Vector2.op_Implicit(new Vector2(((Component)this).transform.position.x, ((Component)this).transform.position.y + verticalOffset)), ((Component)this).transform.rotation);
		monticleIsFrozen = false;
		((Behaviour)colliderMonticle).enabled = true;
		((MonoBehaviour)this).StartCoroutine(MHGPBKOHKLH());
		if (Object.op_Implicit((Object)(object)Sound.MAIDHAPANEB().snowHit))
		{
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().snowHit, ((Component)this).transform.position);
		}
	}

	private void AFCIKJPPLFA()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(PKALGBAEPGE));
	}

	private void HIMBLFNCDLL(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Default") || ((Component)HANHCHBHHEH).CompareTag("Can't afford") || ((Component)HANHCHBHHEH).CompareTag("Talk"))
		{
			UnfrozenMonticle();
		}
	}

	private void NIJMGMDEGLE()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(IACHHJLBPNE));
	}

	private void LJLKBKEADGI()
	{
		Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(EEKCJAAGFHM));
		PPFAJNOOAND();
	}

	private void KKKPAADHJCL()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(JKMIFEAIKGM));
	}

	private IEnumerator AIFIHIIIMMK()
	{
		return new PLKPOGOBLAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void EKPNPAHGAIP(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Sh3ik") || ((Component)HANHCHBHHEH).CompareTag("DismissWorker?") || ((Component)HANHCHBHHEH).CompareTag("Furniture"))
		{
			JFPJDAGHFKP();
		}
	}

	private void KLAONDKEGLP(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("TavernInConstruction") || ((Component)HANHCHBHHEH).CompareTag("wilson") || ((Component)HANHCHBHHEH).CompareTag("LE_4"))
		{
			CBOJDKCLMFF();
		}
	}

	public void OGFLMFPGBJB()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		Object.Instantiate<GameObject>(particles, Vector2.op_Implicit(new Vector2(((Component)this).transform.position.x, ((Component)this).transform.position.y + verticalOffset)), ((Component)this).transform.rotation);
		monticleIsFrozen = false;
		((Behaviour)colliderMonticle).enabled = false;
		((MonoBehaviour)this).StartCoroutine(AIFIHIIIMMK());
		if (Object.op_Implicit((Object)(object)Sound.DIHCEGINELM().snowHit))
		{
			MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().snowHit, ((Component)this).transform.position);
		}
	}

	private void ACLLIGOCDNN(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("ReceiveRemoveTableOrderBanquetCustomer") || ((Component)HANHCHBHHEH).CompareTag("") || ((Component)HANHCHBHHEH).CompareTag(" "))
		{
			UnfrozenMonticle();
		}
	}

	private void GELMGKDMJFE()
	{
		Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(PPFAJNOOAND));
		EEKCJAAGFHM();
	}

	private void JCNGGPIICIN()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(NJHPBIEELLK));
	}

	private void FENIMKBJEEO(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Quit to title screen?") || ((Component)HANHCHBHHEH).CompareTag("Player2") || ((Component)HANHCHBHHEH).CompareTag("Destroying dropped item..."))
		{
			JGBIMFPLLLB();
		}
	}

	private void BKJFLMPOLCH()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(PKALGBAEPGE));
	}

	private void NLFHFPHDNCF()
	{
		Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(JAEFECCLFAK));
		BGIPELPEKJD();
	}

	private void OFGIFNGNGLE()
	{
		((Renderer)monticleRenderer).enabled = false;
		monticleIsFrozen = true;
		((Behaviour)colliderMonticle).enabled = true;
	}

	private void LNPDALMANFB()
	{
		monticleIsFrozen = false;
		if ((Object)(object)colliderMonticle == (Object)null)
		{
			colliderMonticle = ((Component)this).GetComponent<Collider2D>();
		}
	}

	private void IIAGABOLAGJ()
	{
		((Renderer)monticleRenderer).enabled = true;
		monticleIsFrozen = true;
		((Behaviour)colliderMonticle).enabled = false;
	}

	private void IACHHJLBPNE()
	{
		((Renderer)monticleRenderer).enabled = true;
		monticleIsFrozen = false;
		((Behaviour)colliderMonticle).enabled = false;
	}

	private void CLLAKJADGIH()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(NJHPBIEELLK));
	}

	private void EACGHGFJFLO()
	{
		((Renderer)monticleRenderer).enabled = true;
		monticleIsFrozen = true;
		((Behaviour)colliderMonticle).enabled = false;
	}

	private void IGHMMOKFINH()
	{
		monticleIsFrozen = true;
		if ((Object)(object)colliderMonticle == (Object)null)
		{
			colliderMonticle = ((Component)this).GetComponent<Collider2D>();
		}
	}

	private IEnumerator MHGPBKOHKLH()
	{
		return new PLKPOGOBLAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CIDHENPKGJH()
	{
		return new PLKPOGOBLAB(1)
		{
			_003C_003E4__this = this
		};
	}

	public void HDEMGKNPEBN()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		Object.Instantiate<GameObject>(particles, Vector2.op_Implicit(new Vector2(((Component)this).transform.position.x, ((Component)this).transform.position.y + verticalOffset)), ((Component)this).transform.rotation);
		monticleIsFrozen = false;
		((Behaviour)colliderMonticle).enabled = true;
		((MonoBehaviour)this).StartCoroutine(FLPEKCFHNAF());
		if (Object.op_Implicit((Object)(object)Sound.OKAPNFPFPFP().snowHit))
		{
			MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().snowHit, ((Component)this).transform.position);
		}
	}

	private void GFEOBIGKDMG()
	{
		Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(JAEFECCLFAK));
		IIAGABOLAGJ();
	}

	private IEnumerator KGNHNMHIABF()
	{
		yield return CommonReferences.wait02;
		((Renderer)monticleRenderer).enabled = false;
	}

	private IEnumerator OIDLLIBBDBD()
	{
		yield return CommonReferences.wait02;
		((Renderer)monticleRenderer).enabled = false;
	}

	private IEnumerator FBMGIGFLAOP()
	{
		yield return CommonReferences.wait02;
		((Renderer)monticleRenderer).enabled = false;
	}

	private void NKDHCHLEFNP()
	{
		((Renderer)monticleRenderer).enabled = true;
		monticleIsFrozen = true;
		((Behaviour)colliderMonticle).enabled = false;
	}

	private void AAOFFIJHHIB(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Error_OccupiedRoom") || ((Component)HANHCHBHHEH).CompareTag("UIAddRemove") || ((Component)HANHCHBHHEH).CompareTag("Attack/MainEvent 4"))
		{
			KADFDNOHAIC();
		}
	}

	private void PPFAJNOOAND()
	{
		((Renderer)monticleRenderer).enabled = false;
		monticleIsFrozen = true;
		((Behaviour)colliderMonticle).enabled = false;
	}

	private void BGFEBEAJOCG()
	{
		Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(OFGIFNGNGLE));
		PPFAJNOOAND();
	}

	private void PCKOHAIPHFI()
	{
		monticleIsFrozen = true;
		if ((Object)(object)colliderMonticle == (Object)null)
		{
			colliderMonticle = ((Component)this).GetComponent<Collider2D>();
		}
	}

	private void KHJALBJMLHP()
	{
		monticleIsFrozen = true;
		if ((Object)(object)colliderMonticle == (Object)null)
		{
			colliderMonticle = ((Component)this).GetComponent<Collider2D>();
		}
	}

	public void HFBMNPNPLKP()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		Object.Instantiate<GameObject>(particles, Vector2.op_Implicit(new Vector2(((Component)this).transform.position.x, ((Component)this).transform.position.y + verticalOffset)), ((Component)this).transform.rotation);
		monticleIsFrozen = true;
		((Behaviour)colliderMonticle).enabled = false;
		((MonoBehaviour)this).StartCoroutine(AMHIAJNGDCP());
		if (Object.op_Implicit((Object)(object)Sound.DIHCEGINELM().snowHit))
		{
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().snowHit, ((Component)this).transform.position);
		}
	}

	private void KILDJCPLOPP()
	{
		Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(MFPJMNDJNIF));
		IIAGABOLAGJ();
	}

	private void ALCJOABPBMA()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(KFJJOPNFPND));
	}

	private void EDKFNAPDMCN()
	{
		monticleIsFrozen = false;
		if ((Object)(object)colliderMonticle == (Object)null)
		{
			colliderMonticle = ((Component)this).GetComponent<Collider2D>();
		}
	}

	private void DEKJGPJMAPC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(" value ") || ((Component)HANHCHBHHEH).CompareTag("LicenciaDeApertura/LucenDialogue 06") || ((Component)HANHCHBHHEH).CompareTag("ReceiveEmployeeWorking"))
		{
			AALIFPBNJBC();
		}
	}

	private void KPILPDFCHBG()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(LDJONNBEPMH));
	}

	public void KADFDNOHAIC()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		Object.Instantiate<GameObject>(particles, Vector2.op_Implicit(new Vector2(((Component)this).transform.position.x, ((Component)this).transform.position.y + verticalOffset)), ((Component)this).transform.rotation);
		monticleIsFrozen = false;
		((Behaviour)colliderMonticle).enabled = true;
		((MonoBehaviour)this).StartCoroutine(MNAAMOCOKKM());
		if (Object.op_Implicit((Object)(object)Sound.DIHCEGINELM().snowHit))
		{
			MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().snowHit, ((Component)this).transform.position);
		}
	}
}
