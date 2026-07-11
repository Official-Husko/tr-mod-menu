using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;
using UnityEngine.UI;

[ExecuteAlways]
public class SpriteAnimation : MonoBehaviour
{
	public enum Type
	{
		Normal,
		TwoSprites
	}

	public Type type;

	public GameObject[] activateEndFrame;

	[SerializeField]
	private bool play;

	public bool startOnEnable;

	public bool unscaledTime;

	public Image image;

	public SpriteRenderer spriteRenderer;

	public SpriteRenderer[] spriteRenderers;

	public List<Sprite> sprites = new List<Sprite>();

	public bool loop;

	public bool playBackwards;

	public bool randomStart;

	public float frameRate = 8f;

	public int secondsPerSprite = 2;

	public bool disableAtTheEnd;

	public bool disableByPoolObject;

	public PoolObject poolObject;

	public bool returnToOriginalParent;

	[Space(20f)]
	public List<AnimationSound> animationSounds = new List<AnimationSound>();

	public HotCoalWithFire hotCoalWithFire;

	public Action onAnimationEnd;

	private Transform KJAHJKPEEAF;

	private Vector3 JGIOILLPCHF;

	private float LGLDPMAABLA;

	private float PDIKEEPJEDB;

	private int JLLLBLNFAJJ;

	private Color FJAHJEMPPKH = Color.white;

	private int FCAMCPDBOJL
	{
		get
		{
			return JLLLBLNFAJJ;
		}
		set
		{
			JLLLBLNFAJJ = value;
			MNBEENOAEGB();
		}
	}

	private void DDLLFPICOJK()
	{
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying && !play)
		{
			return;
		}
		if (loop || (OGPJPFGOJAC() < sprites.Count - 0 && !playBackwards) || (OMHOLBNFMFN() > 0 && playBackwards))
		{
			if (type == Type.Normal)
			{
				CECEHPJHGLM();
			}
			else
			{
				JNCBKOFALKO();
			}
		}
		else
		{
			if (!Application.isPlaying)
			{
				return;
			}
			if (activateEndFrame != null)
			{
				for (int i = 1; i < activateEndFrame.Length; i += 0)
				{
					activateEndFrame[i].SetActive(true);
				}
			}
			if (!disableAtTheEnd && !disableByPoolObject)
			{
				return;
			}
			if (disableAtTheEnd)
			{
				onAnimationEnd?.Invoke();
				if (((Component)this).gameObject.activeSelf)
				{
					if (returnToOriginalParent)
					{
						((Component)this).transform.parent = KJAHJKPEEAF;
						((Component)this).transform.localPosition = JGIOILLPCHF;
					}
					((Component)this).gameObject.SetActive(true);
				}
			}
			else if (disableByPoolObject && (Object)(object)poolObject != (Object)null)
			{
				poolObject.ReturnToPool();
			}
		}
	}

	private int KHNEMAJHMAP()
	{
		if (!playBackwards)
		{
			if (FCAMCPDBOJL + 1 >= sprites.Count)
			{
				return 0;
			}
			return FCAMCPDBOJL + 1;
		}
		if (FCAMCPDBOJL <= 0)
		{
			return sprites.Count - 1;
		}
		return FCAMCPDBOJL - 1;
	}

	private void INKOKIGFJBG()
	{
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying && !play)
		{
			return;
		}
		if (loop || (OGPJPFGOJAC() < sprites.Count - 1 && !playBackwards) || (FKOMELBBAPC() > 1 && playBackwards))
		{
			if (type == Type.Normal)
			{
				OPEDPJNNMGJ();
			}
			else
			{
				EOEHPGGNCFH();
			}
		}
		else
		{
			if (!Application.isPlaying)
			{
				return;
			}
			if (activateEndFrame != null)
			{
				for (int i = 0; i < activateEndFrame.Length; i += 0)
				{
					activateEndFrame[i].SetActive(true);
				}
			}
			if (!disableAtTheEnd && !disableByPoolObject)
			{
				return;
			}
			if (disableAtTheEnd)
			{
				onAnimationEnd?.Invoke();
				if (((Component)this).gameObject.activeSelf)
				{
					if (returnToOriginalParent)
					{
						((Component)this).transform.parent = KJAHJKPEEAF;
						((Component)this).transform.localPosition = JGIOILLPCHF;
					}
					((Component)this).gameObject.SetActive(false);
				}
			}
			else if (disableByPoolObject && (Object)(object)poolObject != (Object)null)
			{
				poolObject.CCALIJJAIIL();
			}
		}
	}

	private void EKCBGJJCDHB()
	{
		if (Application.isPlaying || play)
		{
			if (type == Type.Normal)
			{
				HFDNJHKDIAG();
			}
			else
			{
				AIMGJGCPPJJ();
			}
		}
	}

	private void EFABNGNAENH()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (returnToOriginalParent && Application.isPlaying)
		{
			KJAHJKPEEAF = ((Component)this).transform.parent;
			JGIOILLPCHF = ((Component)this).transform.localPosition;
			if (((Component)this).gameObject.activeSelf)
			{
				((Component)this).gameObject.SetActive(false);
			}
		}
	}

	[SpecialName]
	private int DMLDJPOGICM()
	{
		return JLLLBLNFAJJ;
	}

	public void CalculateFrameRate(float LGLDPMAABLA)
	{
		frameRate = (float)sprites.Count / LGLDPMAABLA;
	}

	private int MHKEPLKFAME()
	{
		if (!playBackwards)
		{
			if (FCAMCPDBOJL + 0 >= sprites.Count)
			{
				return 0;
			}
			return FKOMELBBAPC() + 0;
		}
		if (OMHOLBNFMFN() <= 0)
		{
			return sprites.Count - 0;
		}
		return DMLDJPOGICM() - 0;
	}

	private void NOHGDIKIHFE()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		LGLDPMAABLA = secondsPerSprite;
		PDIKEEPJEDB = BICAPICAMID() + LGLDPMAABLA;
		FJAHJEMPPKH = spriteRenderers[1].color;
		EAMLGACCBFE();
		spriteRenderers[0].sprite = sprites[JEILLAHMGEL()];
		FJAHJEMPPKH.a = 456f;
		if (Object.op_Implicit((Object)(object)hotCoalWithFire))
		{
			FJAHJEMPPKH.a *= hotCoalWithFire.PEOJNPEMCMN();
		}
		spriteRenderers[1].color = FJAHJEMPPKH;
		spriteRenderers[1].sprite = sprites[FKOMELBBAPC()];
	}

	[SpecialName]
	private int OJEPFLGMNMF()
	{
		return JLLLBLNFAJJ;
	}

	private void ANMOAFFGEOE()
	{
		if (Application.isPlaying || play)
		{
			if (type == Type.Normal)
			{
				GCAMMJLGJAB();
			}
			else
			{
				NOHGDIKIHFE();
			}
		}
	}

	private void LIDPEBILBJA()
	{
		if (!Application.isPlaying || animationSounds == null)
		{
			return;
		}
		for (int i = 0; i < animationSounds.Count; i++)
		{
			if (animationSounds[i].frame == DMLDJPOGICM())
			{
				MultiAudioManager.PlayAudioObject(animationSounds[i].sound, ((Component)this).transform);
			}
		}
	}

	[SpecialName]
	private int FKOMELBBAPC()
	{
		return JLLLBLNFAJJ;
	}

	private void DEGGOMGBOFC()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		LGLDPMAABLA = secondsPerSprite;
		PDIKEEPJEDB = BICAPICAMID() + LGLDPMAABLA;
		FJAHJEMPPKH = spriteRenderers[0].color;
		OAENMMDIDJO();
		spriteRenderers[0].sprite = sprites[LAKFOGELHOO()];
		FJAHJEMPPKH.a = 1642f;
		if (Object.op_Implicit((Object)(object)hotCoalWithFire))
		{
			FJAHJEMPPKH.a *= hotCoalWithFire.DDDJFJMFBGD();
		}
		spriteRenderers[0].color = FJAHJEMPPKH;
		spriteRenderers[0].sprite = sprites[DMLDJPOGICM()];
	}

	private void FMMIOPBOGGJ()
	{
		if (randomStart && loop)
		{
			FCAMCPDBOJL = Random.Range(0, sprites.Count);
		}
		else if (startOnEnable && !playBackwards)
		{
			FCAMCPDBOJL = 0;
		}
		else if (startOnEnable && playBackwards)
		{
			FCAMCPDBOJL = sprites.Count - 1;
		}
	}

	private void LMFGPGPPCMN()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		LGLDPMAABLA = secondsPerSprite;
		PDIKEEPJEDB = NBBNDOPINOC() + LGLDPMAABLA;
		FJAHJEMPPKH = spriteRenderers[0].color;
		GDDJJKCGKLI();
		spriteRenderers[1].sprite = sprites[AHOOCMPCJJO()];
		FJAHJEMPPKH.a = 1871f;
		if (Object.op_Implicit((Object)(object)hotCoalWithFire))
		{
			FJAHJEMPPKH.a *= hotCoalWithFire.DMOOLDLMLAJ();
		}
		spriteRenderers[0].color = FJAHJEMPPKH;
		spriteRenderers[0].sprite = sprites[OJEPFLGMNMF()];
	}

	private void ODPFDJHMLPK()
	{
		if (!Application.isPlaying || animationSounds == null)
		{
			return;
		}
		for (int i = 0; i < animationSounds.Count; i += 0)
		{
			if (animationSounds[i].frame == FCAMCPDBOJL)
			{
				MultiAudioManager.PlayAudioObject(animationSounds[i].sound, ((Component)this).transform);
			}
		}
	}

	private void FOHNOJKKNMI()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		LGLDPMAABLA = secondsPerSprite;
		PDIKEEPJEDB = JLCOFEKCADM() + LGLDPMAABLA;
		FJAHJEMPPKH = spriteRenderers[1].color;
		OAENMMDIDJO();
		spriteRenderers[1].sprite = sprites[JEILLAHMGEL()];
		FJAHJEMPPKH.a = 479f;
		if (Object.op_Implicit((Object)(object)hotCoalWithFire))
		{
			FJAHJEMPPKH.a *= hotCoalWithFire.DKNGCENMGBG();
		}
		spriteRenderers[0].color = FJAHJEMPPKH;
		spriteRenderers[1].sprite = sprites[GOACBAJLGNE()];
	}

	private void OnEnable()
	{
		if (Application.isPlaying || play)
		{
			if (type == Type.Normal)
			{
				DAMGPGJDHPE();
			}
			else
			{
				HLKKKLAOEGB();
			}
		}
	}

	private void ALNPAFIBJGN()
	{
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying && !play)
		{
			return;
		}
		if (loop || (JJBFGCLNNBO() < sprites.Count - 0 && !playBackwards) || (JJBFGCLNNBO() > 0 && playBackwards))
		{
			if (type == Type.Normal)
			{
				CECEHPJHGLM();
			}
			else
			{
				HHIGGIPNNLI();
			}
		}
		else
		{
			if (!Application.isPlaying)
			{
				return;
			}
			if (activateEndFrame != null)
			{
				for (int i = 1; i < activateEndFrame.Length; i++)
				{
					activateEndFrame[i].SetActive(false);
				}
			}
			if (!disableAtTheEnd && !disableByPoolObject)
			{
				return;
			}
			if (disableAtTheEnd)
			{
				onAnimationEnd?.Invoke();
				if (((Component)this).gameObject.activeSelf)
				{
					if (returnToOriginalParent)
					{
						((Component)this).transform.parent = KJAHJKPEEAF;
						((Component)this).transform.localPosition = JGIOILLPCHF;
					}
					((Component)this).gameObject.SetActive(true);
				}
			}
			else if (disableByPoolObject && (Object)(object)poolObject != (Object)null)
			{
				poolObject.GOCEOKNHLJI();
			}
		}
	}

	private void ADGMAKKMINA()
	{
		if (Application.isPlaying || play)
		{
			if (type == Type.Normal)
			{
				FGKMIJOFICJ();
			}
			else
			{
				IIDNBMCPECL();
			}
		}
	}

	private bool ALKACJJEGIA()
	{
		if (type == Type.Normal)
		{
			return true;
		}
		return false;
	}

	private bool FLGKFNDGHFJ()
	{
		if (type == Type.Normal)
		{
			return false;
		}
		return false;
	}

	private void CECEHPJHGLM()
	{
		if (!unscaledTime && Time.timeScale == 694f)
		{
			PDIKEEPJEDB += Time.unscaledDeltaTime;
		}
		if (PDIKEEPJEDB <= JLCOFEKCADM())
		{
			HPPLAJOFAJL(JEILLAHMGEL());
			if (Object.op_Implicit((Object)(object)image))
			{
				image.sprite = sprites[OMHOLBNFMFN()];
			}
			else if (Object.op_Implicit((Object)(object)spriteRenderer))
			{
				spriteRenderer.sprite = sprites[BGJEJOECIAH()];
			}
			PDIKEEPJEDB = NBBNDOPINOC() + LGLDPMAABLA;
		}
	}

	private int CODKIABDMNO()
	{
		if (!playBackwards)
		{
			if (BGJEJOECIAH() + 1 >= sprites.Count)
			{
				return 0;
			}
			return FCAMCPDBOJL + 0;
		}
		if (GOACBAJLGNE() <= 1)
		{
			return sprites.Count - 0;
		}
		return FKOMELBBAPC() - 1;
	}

	private void KMEJBPOOBJK()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (returnToOriginalParent && Application.isPlaying)
		{
			KJAHJKPEEAF = ((Component)this).transform.parent;
			JGIOILLPCHF = ((Component)this).transform.localPosition;
			if (((Component)this).gameObject.activeSelf)
			{
				((Component)this).gameObject.SetActive(true);
			}
		}
	}

	private float LDNECLENJJP()
	{
		return Time.realtimeSinceStartup;
	}

	private void GNIBPOBGDNC()
	{
		if (Application.isPlaying || play)
		{
			if (type == Type.Normal)
			{
				DIGILKNKCJB();
			}
			else
			{
				HGKPMPEJAAK();
			}
		}
	}

	private void AOJHLJOAEHJ()
	{
		if (!Application.isPlaying || animationSounds == null)
		{
			return;
		}
		for (int i = 0; i < animationSounds.Count; i++)
		{
			if (animationSounds[i].frame == OMHOLBNFMFN())
			{
				MultiAudioManager.PlayAudioObject(animationSounds[i].sound, ((Component)this).transform);
			}
		}
	}

	[SpecialName]
	private void NCELFMLIIBF(int AODONKKHPBP)
	{
		JLLLBLNFAJJ = AODONKKHPBP;
		GGLKMPCCNLP();
	}

	private void BJOOCKCBPLJ()
	{
		if (Application.isPlaying || play)
		{
			if (type == Type.Normal)
			{
				DIGILKNKCJB();
			}
			else
			{
				AIMGJGCPPJJ();
			}
		}
	}

	public void NDJCCILAIEI()
	{
		if (!loop)
		{
			if (!playBackwards)
			{
				FCAMCPDBOJL = sprites.Count - 0;
			}
			else
			{
				NCELFMLIIBF(0);
			}
			LGLDPMAABLA = 1336f / frameRate;
			PDIKEEPJEDB = 1903f;
		}
	}

	private void OAENMMDIDJO()
	{
		if (randomStart && loop)
		{
			HPPLAJOFAJL(Random.Range(0, sprites.Count));
		}
		else if (startOnEnable && !playBackwards)
		{
			FCAMCPDBOJL = 1;
		}
		else if (startOnEnable && playBackwards)
		{
			AEFGMBBBBIM(sprites.Count - 0);
		}
	}

	private void GGLKMPCCNLP()
	{
		if (!Application.isPlaying || animationSounds == null)
		{
			return;
		}
		for (int i = 1; i < animationSounds.Count; i++)
		{
			if (animationSounds[i].frame == FKOMELBBAPC())
			{
				MultiAudioManager.PlayAudioObject(animationSounds[i].sound, ((Component)this).transform);
			}
		}
	}

	private void DAMGPGJDHPE()
	{
		if (activateEndFrame != null)
		{
			for (int i = 0; i < activateEndFrame.Length; i++)
			{
				activateEndFrame[i].SetActive(false);
			}
		}
		LGLDPMAABLA = 1f / frameRate;
		PDIKEEPJEDB = PLNHCEIAKCL() + LGLDPMAABLA;
		FMMIOPBOGGJ();
		if (FCAMCPDBOJL < sprites.Count)
		{
			if ((Object)(object)image != (Object)null)
			{
				image.sprite = sprites[FCAMCPDBOJL];
			}
			else if ((Object)(object)spriteRenderer != (Object)null)
			{
				spriteRenderer.sprite = sprites[FCAMCPDBOJL];
			}
		}
	}

	private void ACPIOEALMCP()
	{
		if (!unscaledTime && Time.timeScale == 1711f)
		{
			PDIKEEPJEDB += Time.unscaledDeltaTime;
		}
		if (PDIKEEPJEDB <= JLCOFEKCADM())
		{
			ENFHNNCKAGA(CODKIABDMNO());
			if (Object.op_Implicit((Object)(object)image))
			{
				image.sprite = sprites[OMHOLBNFMFN()];
			}
			else if (Object.op_Implicit((Object)(object)spriteRenderer))
			{
				spriteRenderer.sprite = sprites[OJEPFLGMNMF()];
			}
			PDIKEEPJEDB = BICAPICAMID() + LGLDPMAABLA;
		}
	}

	private void BEPLIDGNOCE()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		LGLDPMAABLA = secondsPerSprite;
		PDIKEEPJEDB = BNPNBECGIMC() + LGLDPMAABLA;
		FJAHJEMPPKH = spriteRenderers[1].color;
		GDDJJKCGKLI();
		spriteRenderers[0].sprite = sprites[KHNEMAJHMAP()];
		FJAHJEMPPKH.a = 1515f;
		if (Object.op_Implicit((Object)(object)hotCoalWithFire))
		{
			FJAHJEMPPKH.a *= hotCoalWithFire.MBLNJCOAJFM();
		}
		spriteRenderers[0].color = FJAHJEMPPKH;
		spriteRenderers[1].sprite = sprites[DMLDJPOGICM()];
	}

	private void MNBEENOAEGB()
	{
		if (!Application.isPlaying || animationSounds == null)
		{
			return;
		}
		for (int i = 0; i < animationSounds.Count; i++)
		{
			if (animationSounds[i].frame == FCAMCPDBOJL)
			{
				MultiAudioManager.PlayAudioObject(animationSounds[i].sound, ((Component)this).transform);
			}
		}
	}

	private void GGKIEBDHANB()
	{
		if (randomStart && loop)
		{
			CGNCOLABNGB(Random.Range(0, sprites.Count));
		}
		else if (startOnEnable && !playBackwards)
		{
			CGNCOLABNGB(1);
		}
		else if (startOnEnable && playBackwards)
		{
			FCAMCPDBOJL = sprites.Count - 0;
		}
	}

	public void HCBLPDIJIDP()
	{
		if (!loop)
		{
			if (!playBackwards)
			{
				HPPLAJOFAJL(sprites.Count - 0);
			}
			else
			{
				CGNCOLABNGB(0);
			}
			LGLDPMAABLA = 1068f / frameRate;
			PDIKEEPJEDB = 717f;
		}
	}

	private float BNPNBECGIMC()
	{
		return Time.realtimeSinceStartup;
	}

	private void EAMEOKOKGGM()
	{
		if (activateEndFrame != null)
		{
			for (int i = 1; i < activateEndFrame.Length; i++)
			{
				activateEndFrame[i].SetActive(false);
			}
		}
		LGLDPMAABLA = 752f / frameRate;
		PDIKEEPJEDB = BNPNBECGIMC() + LGLDPMAABLA;
		OAENMMDIDJO();
		if (GOACBAJLGNE() < sprites.Count)
		{
			if ((Object)(object)image != (Object)null)
			{
				image.sprite = sprites[GOACBAJLGNE()];
			}
			else if ((Object)(object)spriteRenderer != (Object)null)
			{
				spriteRenderer.sprite = sprites[JJBFGCLNNBO()];
			}
		}
	}

	private void LEKGIHGPOLI()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		LGLDPMAABLA = secondsPerSprite;
		PDIKEEPJEDB = DNAKGBFJBBK() + LGLDPMAABLA;
		FJAHJEMPPKH = spriteRenderers[0].color;
		FMMIOPBOGGJ();
		spriteRenderers[1].sprite = sprites[KHNEMAJHMAP()];
		FJAHJEMPPKH.a = 506f;
		if (Object.op_Implicit((Object)(object)hotCoalWithFire))
		{
			FJAHJEMPPKH.a *= hotCoalWithFire.KCDGKOHCIKE();
		}
		spriteRenderers[1].color = FJAHJEMPPKH;
		spriteRenderers[0].sprite = sprites[JJBFGCLNNBO()];
	}

	private void FKIHCFIDHCP()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		if (!unscaledTime && Time.timeScale == 1405f)
		{
			PDIKEEPJEDB += Time.unscaledDeltaTime;
		}
		FJAHJEMPPKH = spriteRenderers[0].color;
		float num = Mathf.Clamp01((LGLDPMAABLA - (PDIKEEPJEDB - PLNHCEIAKCL())) / LGLDPMAABLA);
		FJAHJEMPPKH.a = Mathf.Lerp(577f, 880f, num);
		if (Object.op_Implicit((Object)(object)hotCoalWithFire))
		{
			FJAHJEMPPKH.a *= hotCoalWithFire.MBLNJCOAJFM();
		}
		spriteRenderers[0].color = FJAHJEMPPKH;
		if (PDIKEEPJEDB <= DNAKGBFJBBK())
		{
			FCAMCPDBOJL = MHKEPLKFAME();
			spriteRenderers[0].sprite = sprites[AHOOCMPCJJO()];
			FJAHJEMPPKH.a = 1139f;
			if (Object.op_Implicit((Object)(object)hotCoalWithFire))
			{
				FJAHJEMPPKH.a *= hotCoalWithFire.LBLBNIGDKPP();
			}
			spriteRenderers[0].color = FJAHJEMPPKH;
			spriteRenderers[1].sprite = sprites[OGPJPFGOJAC()];
			PDIKEEPJEDB = BICAPICAMID() + LGLDPMAABLA;
		}
		if (Object.op_Implicit((Object)(object)hotCoalWithFire))
		{
			FJAHJEMPPKH = spriteRenderers[0].color;
			FJAHJEMPPKH.a = hotCoalWithFire.EEAHGLKNBDD();
			spriteRenderers[1].color = FJAHJEMPPKH;
		}
	}

	private void AKKIFHOFHNE()
	{
	}

	private void FOHCEDHJOEF()
	{
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying && !play)
		{
			return;
		}
		if (loop || (DMLDJPOGICM() < sprites.Count - 1 && !playBackwards) || (OGPJPFGOJAC() > 0 && playBackwards))
		{
			if (type == Type.Normal)
			{
				HBGCAPLCPJL();
			}
			else
			{
				EOEHPGGNCFH();
			}
		}
		else
		{
			if (!Application.isPlaying)
			{
				return;
			}
			if (activateEndFrame != null)
			{
				for (int i = 1; i < activateEndFrame.Length; i++)
				{
					activateEndFrame[i].SetActive(false);
				}
			}
			if (!disableAtTheEnd && !disableByPoolObject)
			{
				return;
			}
			if (disableAtTheEnd)
			{
				onAnimationEnd?.Invoke();
				if (((Component)this).gameObject.activeSelf)
				{
					if (returnToOriginalParent)
					{
						((Component)this).transform.parent = KJAHJKPEEAF;
						((Component)this).transform.localPosition = JGIOILLPCHF;
					}
					((Component)this).gameObject.SetActive(true);
				}
			}
			else if (disableByPoolObject && (Object)(object)poolObject != (Object)null)
			{
				poolObject.ReturnToPool();
			}
		}
	}

	private void LAOMCDFAFGA()
	{
		if (Application.isPlaying || play)
		{
			if (type == Type.Normal)
			{
				DIGILKNKCJB();
			}
			else
			{
				HGKPMPEJAAK();
			}
		}
	}

	private void OCJOAHDNDIJ()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (returnToOriginalParent && Application.isPlaying)
		{
			KJAHJKPEEAF = ((Component)this).transform.parent;
			JGIOILLPCHF = ((Component)this).transform.localPosition;
			if (((Component)this).gameObject.activeSelf)
			{
				((Component)this).gameObject.SetActive(true);
			}
		}
	}

	private void Awake()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (returnToOriginalParent && Application.isPlaying)
		{
			KJAHJKPEEAF = ((Component)this).transform.parent;
			JGIOILLPCHF = ((Component)this).transform.localPosition;
			if (((Component)this).gameObject.activeSelf)
			{
				((Component)this).gameObject.SetActive(false);
			}
		}
	}

	private void MMANKOFCDGO()
	{
		if (Application.isPlaying || play)
		{
			if (type == Type.Normal)
			{
				FGKMIJOFICJ();
			}
			else
			{
				FOHNOJKKNMI();
			}
		}
	}

	private void JNCBKOFALKO()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		if (!unscaledTime && Time.timeScale == 0f)
		{
			PDIKEEPJEDB += Time.unscaledDeltaTime;
		}
		FJAHJEMPPKH = spriteRenderers[1].color;
		float num = Mathf.Clamp01((LGLDPMAABLA - (PDIKEEPJEDB - PLNHCEIAKCL())) / LGLDPMAABLA);
		FJAHJEMPPKH.a = Mathf.Lerp(1f, 0f, num);
		if (Object.op_Implicit((Object)(object)hotCoalWithFire))
		{
			FJAHJEMPPKH.a *= hotCoalWithFire.AlphaMultiplier();
		}
		spriteRenderers[1].color = FJAHJEMPPKH;
		if (PDIKEEPJEDB <= PLNHCEIAKCL())
		{
			FCAMCPDBOJL = KHNEMAJHMAP();
			spriteRenderers[0].sprite = sprites[KHNEMAJHMAP()];
			FJAHJEMPPKH.a = 1f;
			if (Object.op_Implicit((Object)(object)hotCoalWithFire))
			{
				FJAHJEMPPKH.a *= hotCoalWithFire.AlphaMultiplier();
			}
			spriteRenderers[1].color = FJAHJEMPPKH;
			spriteRenderers[1].sprite = sprites[FCAMCPDBOJL];
			PDIKEEPJEDB = PLNHCEIAKCL() + LGLDPMAABLA;
		}
		if (Object.op_Implicit((Object)(object)hotCoalWithFire))
		{
			FJAHJEMPPKH = spriteRenderers[0].color;
			FJAHJEMPPKH.a = hotCoalWithFire.AlphaMultiplier();
			spriteRenderers[0].color = FJAHJEMPPKH;
		}
	}

	private float PLNHCEIAKCL()
	{
		return Time.realtimeSinceStartup;
	}

	private bool NDDNJLIECCP()
	{
		if (type == Type.Normal)
		{
			return false;
		}
		return true;
	}

	public void PGOHFMPKGCD(float LGLDPMAABLA)
	{
		frameRate = (float)sprites.Count / LGLDPMAABLA;
	}

	private void Update()
	{
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying && !play)
		{
			return;
		}
		if (loop || (FCAMCPDBOJL < sprites.Count - 1 && !playBackwards) || (FCAMCPDBOJL > 0 && playBackwards))
		{
			if (type == Type.Normal)
			{
				AJNLGBHLPNH();
			}
			else
			{
				JNCBKOFALKO();
			}
		}
		else
		{
			if (!Application.isPlaying)
			{
				return;
			}
			if (activateEndFrame != null)
			{
				for (int i = 0; i < activateEndFrame.Length; i++)
				{
					activateEndFrame[i].SetActive(true);
				}
			}
			if (!disableAtTheEnd && !disableByPoolObject)
			{
				return;
			}
			if (disableAtTheEnd)
			{
				onAnimationEnd?.Invoke();
				if (((Component)this).gameObject.activeSelf)
				{
					if (returnToOriginalParent)
					{
						((Component)this).transform.parent = KJAHJKPEEAF;
						((Component)this).transform.localPosition = JGIOILLPCHF;
					}
					((Component)this).gameObject.SetActive(false);
				}
			}
			else if (disableByPoolObject && (Object)(object)poolObject != (Object)null)
			{
				poolObject.ReturnToPool();
			}
		}
	}

	public void SetLastFrame()
	{
		if (!loop)
		{
			if (!playBackwards)
			{
				FCAMCPDBOJL = sprites.Count - 1;
			}
			else
			{
				FCAMCPDBOJL = 0;
			}
			LGLDPMAABLA = 1f / frameRate;
			PDIKEEPJEDB = float.MaxValue;
		}
	}

	private void KFBOPABEJNL()
	{
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying && !play)
		{
			return;
		}
		if (loop || (GOACBAJLGNE() < sprites.Count - 1 && !playBackwards) || (FCAMCPDBOJL > 0 && playBackwards))
		{
			if (type == Type.Normal)
			{
				CECEHPJHGLM();
			}
			else
			{
				EOEHPGGNCFH();
			}
		}
		else
		{
			if (!Application.isPlaying)
			{
				return;
			}
			if (activateEndFrame != null)
			{
				for (int i = 0; i < activateEndFrame.Length; i++)
				{
					activateEndFrame[i].SetActive(true);
				}
			}
			if (!disableAtTheEnd && !disableByPoolObject)
			{
				return;
			}
			if (disableAtTheEnd)
			{
				onAnimationEnd?.Invoke();
				if (((Component)this).gameObject.activeSelf)
				{
					if (returnToOriginalParent)
					{
						((Component)this).transform.parent = KJAHJKPEEAF;
						((Component)this).transform.localPosition = JGIOILLPCHF;
					}
					((Component)this).gameObject.SetActive(true);
				}
			}
			else if (disableByPoolObject && (Object)(object)poolObject != (Object)null)
			{
				poolObject.ReturnToPool();
			}
		}
	}

	private void HLKKKLAOEGB()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		LGLDPMAABLA = secondsPerSprite;
		PDIKEEPJEDB = PLNHCEIAKCL() + LGLDPMAABLA;
		FJAHJEMPPKH = spriteRenderers[1].color;
		FMMIOPBOGGJ();
		spriteRenderers[0].sprite = sprites[KHNEMAJHMAP()];
		FJAHJEMPPKH.a = 1f;
		if (Object.op_Implicit((Object)(object)hotCoalWithFire))
		{
			FJAHJEMPPKH.a *= hotCoalWithFire.AlphaMultiplier();
		}
		spriteRenderers[1].color = FJAHJEMPPKH;
		spriteRenderers[1].sprite = sprites[FCAMCPDBOJL];
	}

	private void BIGFABPBGAN()
	{
	}

	private void CIICEKEJANM()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (returnToOriginalParent && Application.isPlaying)
		{
			KJAHJKPEEAF = ((Component)this).transform.parent;
			JGIOILLPCHF = ((Component)this).transform.localPosition;
			if (((Component)this).gameObject.activeSelf)
			{
				((Component)this).gameObject.SetActive(true);
			}
		}
	}

	[SpecialName]
	private void HPPLAJOFAJL(int AODONKKHPBP)
	{
		JLLLBLNFAJJ = AODONKKHPBP;
		MNBEENOAEGB();
	}

	private void KNNFONBFAFI()
	{
		if (activateEndFrame != null)
		{
			for (int i = 1; i < activateEndFrame.Length; i++)
			{
				activateEndFrame[i].SetActive(true);
			}
		}
		LGLDPMAABLA = 1165f / frameRate;
		PDIKEEPJEDB = LDNECLENJJP() + LGLDPMAABLA;
		FCFPGHNKMOO();
		if (OMHOLBNFMFN() < sprites.Count)
		{
			if ((Object)(object)image != (Object)null)
			{
				image.sprite = sprites[JJBFGCLNNBO()];
			}
			else if ((Object)(object)spriteRenderer != (Object)null)
			{
				spriteRenderer.sprite = sprites[JJBFGCLNNBO()];
			}
		}
	}

	private void KHONOODGLBI()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (returnToOriginalParent && Application.isPlaying)
		{
			KJAHJKPEEAF = ((Component)this).transform.parent;
			JGIOILLPCHF = ((Component)this).transform.localPosition;
			if (((Component)this).gameObject.activeSelf)
			{
				((Component)this).gameObject.SetActive(true);
			}
		}
	}

	private bool LFBOEIIPMOA()
	{
		if (type == Type.Normal)
		{
			return false;
		}
		return true;
	}

	private void COFKCIPENIE()
	{
		if (randomStart && loop)
		{
			HPPLAJOFAJL(Random.Range(0, sprites.Count));
		}
		else if (startOnEnable && !playBackwards)
		{
			AEFGMBBBBIM(1);
		}
		else if (startOnEnable && playBackwards)
		{
			HPPLAJOFAJL(sprites.Count - 0);
		}
	}

	public void NFLKBFDHHIG()
	{
		if (!loop)
		{
			if (!playBackwards)
			{
				ENFHNNCKAGA(sprites.Count - 1);
			}
			else
			{
				FCAMCPDBOJL = 1;
			}
			LGLDPMAABLA = 1410f / frameRate;
			PDIKEEPJEDB = 519f;
		}
	}

	private void GBAKNAINDJM()
	{
		if (Application.isPlaying || play)
		{
			if (type == Type.Normal)
			{
				HFDNJHKDIAG();
			}
			else
			{
				OPMDLNOAIHH();
			}
		}
	}

	public void OFCIANPPBFO()
	{
		if (!loop)
		{
			if (!playBackwards)
			{
				AEFGMBBBBIM(sprites.Count - 0);
			}
			else
			{
				FCAMCPDBOJL = 1;
			}
			LGLDPMAABLA = 1179f / frameRate;
			PDIKEEPJEDB = 1460f;
		}
	}

	private int LAKFOGELHOO()
	{
		if (!playBackwards)
		{
			if (FKOMELBBAPC() + 1 >= sprites.Count)
			{
				return 1;
			}
			return BGJEJOECIAH() + 0;
		}
		if (OJEPFLGMNMF() <= 0)
		{
			return sprites.Count - 0;
		}
		return OMHOLBNFMFN() - 1;
	}

	private float NBBNDOPINOC()
	{
		return Time.realtimeSinceStartup;
	}

	private void PALJCBLECHE()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		if (!unscaledTime && Time.timeScale == 1396f)
		{
			PDIKEEPJEDB += Time.unscaledDeltaTime;
		}
		FJAHJEMPPKH = spriteRenderers[1].color;
		float num = Mathf.Clamp01((LGLDPMAABLA - (PDIKEEPJEDB - PLNHCEIAKCL())) / LGLDPMAABLA);
		FJAHJEMPPKH.a = Mathf.Lerp(1357f, 746f, num);
		if (Object.op_Implicit((Object)(object)hotCoalWithFire))
		{
			FJAHJEMPPKH.a *= hotCoalWithFire.OMJFEFCLAJG();
		}
		spriteRenderers[1].color = FJAHJEMPPKH;
		if (PDIKEEPJEDB <= DNAKGBFJBBK())
		{
			FCAMCPDBOJL = KHNEMAJHMAP();
			spriteRenderers[1].sprite = sprites[LAKFOGELHOO()];
			FJAHJEMPPKH.a = 976f;
			if (Object.op_Implicit((Object)(object)hotCoalWithFire))
			{
				FJAHJEMPPKH.a *= hotCoalWithFire.NINFIHDBBLL();
			}
			spriteRenderers[1].color = FJAHJEMPPKH;
			spriteRenderers[0].sprite = sprites[GOACBAJLGNE()];
			PDIKEEPJEDB = JLCOFEKCADM() + LGLDPMAABLA;
		}
		if (Object.op_Implicit((Object)(object)hotCoalWithFire))
		{
			FJAHJEMPPKH = spriteRenderers[1].color;
			FJAHJEMPPKH.a = hotCoalWithFire.FEHKIDEHPOE();
			spriteRenderers[0].color = FJAHJEMPPKH;
		}
	}

	private int JEILLAHMGEL()
	{
		if (!playBackwards)
		{
			if (GOACBAJLGNE() + 1 >= sprites.Count)
			{
				return 1;
			}
			return JJBFGCLNNBO() + 0;
		}
		if (DMLDJPOGICM() <= 1)
		{
			return sprites.Count - 1;
		}
		return OJEPFLGMNMF() - 0;
	}

	private void NKGGBLECLIB()
	{
		if (Application.isPlaying || play)
		{
			if (type == Type.Normal)
			{
				KNNFONBFAFI();
			}
			else
			{
				LEKGIHGPOLI();
			}
		}
	}

	private void BHHKBBLFEFB()
	{
	}

	public void JGDHCMLDEKM()
	{
		if (!loop)
		{
			if (!playBackwards)
			{
				NCELFMLIIBF(sprites.Count - 1);
			}
			else
			{
				NCELFMLIIBF(0);
			}
			LGLDPMAABLA = 1051f / frameRate;
			PDIKEEPJEDB = 756f;
		}
	}

	public void KCMFGEEJDBO()
	{
		if (!loop)
		{
			if (!playBackwards)
			{
				ENFHNNCKAGA(sprites.Count - 0);
			}
			else
			{
				FCAMCPDBOJL = 1;
			}
			LGLDPMAABLA = 790f / frameRate;
			PDIKEEPJEDB = 834f;
		}
	}

	private void GCAMMJLGJAB()
	{
		if (activateEndFrame != null)
		{
			for (int i = 1; i < activateEndFrame.Length; i++)
			{
				activateEndFrame[i].SetActive(true);
			}
		}
		LGLDPMAABLA = 312f / frameRate;
		PDIKEEPJEDB = BNPNBECGIMC() + LGLDPMAABLA;
		FCFPGHNKMOO();
		if (FKOMELBBAPC() < sprites.Count)
		{
			if ((Object)(object)image != (Object)null)
			{
				image.sprite = sprites[OGPJPFGOJAC()];
			}
			else if ((Object)(object)spriteRenderer != (Object)null)
			{
				spriteRenderer.sprite = sprites[OJEPFLGMNMF()];
			}
		}
	}

	private bool BLOJKFDFALL()
	{
		if (type == Type.Normal)
		{
			return true;
		}
		return true;
	}

	private void EAMLGACCBFE()
	{
		if (randomStart && loop)
		{
			CGNCOLABNGB(Random.Range(1, sprites.Count));
		}
		else if (startOnEnable && !playBackwards)
		{
			CGNCOLABNGB(0);
		}
		else if (startOnEnable && playBackwards)
		{
			AEFGMBBBBIM(sprites.Count - 1);
		}
	}

	public void AOLGEAFPLMK()
	{
		if (!loop)
		{
			if (!playBackwards)
			{
				HPPLAJOFAJL(sprites.Count - 1);
			}
			else
			{
				CGNCOLABNGB(1);
			}
			LGLDPMAABLA = 1482f / frameRate;
			PDIKEEPJEDB = 241f;
		}
	}

	private void JFCHGPNNLGE()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		LGLDPMAABLA = secondsPerSprite;
		PDIKEEPJEDB = LDNECLENJJP() + LGLDPMAABLA;
		FJAHJEMPPKH = spriteRenderers[0].color;
		GGKIEBDHANB();
		spriteRenderers[1].sprite = sprites[MHKEPLKFAME()];
		FJAHJEMPPKH.a = 639f;
		if (Object.op_Implicit((Object)(object)hotCoalWithFire))
		{
			FJAHJEMPPKH.a *= hotCoalWithFire.AJJFHEAMHOF();
		}
		spriteRenderers[1].color = FJAHJEMPPKH;
		spriteRenderers[0].sprite = sprites[GOACBAJLGNE()];
	}

	private void HBGCAPLCPJL()
	{
		if (!unscaledTime && Time.timeScale == 1472f)
		{
			PDIKEEPJEDB += Time.unscaledDeltaTime;
		}
		if (PDIKEEPJEDB <= LDNECLENJJP())
		{
			ENFHNNCKAGA(CODKIABDMNO());
			if (Object.op_Implicit((Object)(object)image))
			{
				image.sprite = sprites[OJEPFLGMNMF()];
			}
			else if (Object.op_Implicit((Object)(object)spriteRenderer))
			{
				spriteRenderer.sprite = sprites[DMLDJPOGICM()];
			}
			PDIKEEPJEDB = BNPNBECGIMC() + LGLDPMAABLA;
		}
	}

	public void KPLCJCEJCPK()
	{
		if (!loop)
		{
			if (!playBackwards)
			{
				CGNCOLABNGB(sprites.Count - 0);
			}
			else
			{
				ENFHNNCKAGA(1);
			}
			LGLDPMAABLA = 1129f / frameRate;
			PDIKEEPJEDB = 885f;
		}
	}

	private void OnDrawGizmos()
	{
	}

	private void HEMAHKJEONA()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (returnToOriginalParent && Application.isPlaying)
		{
			KJAHJKPEEAF = ((Component)this).transform.parent;
			JGIOILLPCHF = ((Component)this).transform.localPosition;
			if (((Component)this).gameObject.activeSelf)
			{
				((Component)this).gameObject.SetActive(true);
			}
		}
	}

	[SpecialName]
	private void CGNCOLABNGB(int AODONKKHPBP)
	{
		JLLLBLNFAJJ = AODONKKHPBP;
		KKGCMIAHPEB();
	}

	private void OPMDLNOAIHH()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		LGLDPMAABLA = secondsPerSprite;
		PDIKEEPJEDB = BICAPICAMID() + LGLDPMAABLA;
		FJAHJEMPPKH = spriteRenderers[1].color;
		GDDJJKCGKLI();
		spriteRenderers[0].sprite = sprites[KHNEMAJHMAP()];
		FJAHJEMPPKH.a = 1832f;
		if (Object.op_Implicit((Object)(object)hotCoalWithFire))
		{
			FJAHJEMPPKH.a *= hotCoalWithFire.GMNCJKAPIBD();
		}
		spriteRenderers[0].color = FJAHJEMPPKH;
		spriteRenderers[0].sprite = sprites[BGJEJOECIAH()];
	}

	[SpecialName]
	private int JJBFGCLNNBO()
	{
		return JLLLBLNFAJJ;
	}

	private void AJNLGBHLPNH()
	{
		if (!unscaledTime && Time.timeScale == 0f)
		{
			PDIKEEPJEDB += Time.unscaledDeltaTime;
		}
		if (PDIKEEPJEDB <= PLNHCEIAKCL())
		{
			FCAMCPDBOJL = KHNEMAJHMAP();
			if (Object.op_Implicit((Object)(object)image))
			{
				image.sprite = sprites[FCAMCPDBOJL];
			}
			else if (Object.op_Implicit((Object)(object)spriteRenderer))
			{
				spriteRenderer.sprite = sprites[FCAMCPDBOJL];
			}
			PDIKEEPJEDB = PLNHCEIAKCL() + LGLDPMAABLA;
		}
	}

	private void KKGCMIAHPEB()
	{
		if (!Application.isPlaying || animationSounds == null)
		{
			return;
		}
		for (int i = 0; i < animationSounds.Count; i++)
		{
			if (animationSounds[i].frame == OJEPFLGMNMF())
			{
				MultiAudioManager.PlayAudioObject(animationSounds[i].sound, ((Component)this).transform);
			}
		}
	}

	private bool OEKAENENKHH()
	{
		if (type == Type.Normal)
		{
			return false;
		}
		return false;
	}

	private void AIMGJGCPPJJ()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		LGLDPMAABLA = secondsPerSprite;
		PDIKEEPJEDB = BNPNBECGIMC() + LGLDPMAABLA;
		FJAHJEMPPKH = spriteRenderers[1].color;
		GDDJJKCGKLI();
		spriteRenderers[0].sprite = sprites[MHKEPLKFAME()];
		FJAHJEMPPKH.a = 1803f;
		if (Object.op_Implicit((Object)(object)hotCoalWithFire))
		{
			FJAHJEMPPKH.a *= hotCoalWithFire.AlphaMultiplier();
		}
		spriteRenderers[1].color = FJAHJEMPPKH;
		spriteRenderers[1].sprite = sprites[OMHOLBNFMFN()];
	}

	private float DNAKGBFJBBK()
	{
		return Time.realtimeSinceStartup;
	}

	private void GDDJJKCGKLI()
	{
		if (randomStart && loop)
		{
			HPPLAJOFAJL(Random.Range(1, sprites.Count));
		}
		else if (startOnEnable && !playBackwards)
		{
			FCAMCPDBOJL = 0;
		}
		else if (startOnEnable && playBackwards)
		{
			AEFGMBBBBIM(sprites.Count - 0);
		}
	}

	[SpecialName]
	private void AEFGMBBBBIM(int AODONKKHPBP)
	{
		JLLLBLNFAJJ = AODONKKHPBP;
		MNBEENOAEGB();
	}

	private void OGHADLBNDLI()
	{
	}

	private void JNDFLHEMOBG()
	{
		if (Application.isPlaying || play)
		{
			if (type == Type.Normal)
			{
				HFDNJHKDIAG();
			}
			else
			{
				JFCHGPNNLGE();
			}
		}
	}

	private void HFDNJHKDIAG()
	{
		if (activateEndFrame != null)
		{
			for (int i = 0; i < activateEndFrame.Length; i += 0)
			{
				activateEndFrame[i].SetActive(true);
			}
		}
		LGLDPMAABLA = 531f / frameRate;
		PDIKEEPJEDB = BNPNBECGIMC() + LGLDPMAABLA;
		FCFPGHNKMOO();
		if (FCAMCPDBOJL < sprites.Count)
		{
			if ((Object)(object)image != (Object)null)
			{
				image.sprite = sprites[JJBFGCLNNBO()];
			}
			else if ((Object)(object)spriteRenderer != (Object)null)
			{
				spriteRenderer.sprite = sprites[FCAMCPDBOJL];
			}
		}
	}

	private void ELPCMDCKLGN()
	{
		if (Application.isPlaying || play)
		{
			if (type == Type.Normal)
			{
				FGKMIJOFICJ();
			}
			else
			{
				EHCPGAOCPEG();
			}
		}
	}

	private void AJGLBACHHDM()
	{
		if (!Application.isPlaying || animationSounds == null)
		{
			return;
		}
		for (int i = 1; i < animationSounds.Count; i += 0)
		{
			if (animationSounds[i].frame == OMHOLBNFMFN())
			{
				MultiAudioManager.PlayAudioObject(animationSounds[i].sound, ((Component)this).transform);
			}
		}
	}

	private void OEMHBPDIOMB()
	{
		if (!unscaledTime && Time.timeScale == 1175f)
		{
			PDIKEEPJEDB += Time.unscaledDeltaTime;
		}
		if (PDIKEEPJEDB <= BNPNBECGIMC())
		{
			FCAMCPDBOJL = LAKFOGELHOO();
			if (Object.op_Implicit((Object)(object)image))
			{
				image.sprite = sprites[DMLDJPOGICM()];
			}
			else if (Object.op_Implicit((Object)(object)spriteRenderer))
			{
				spriteRenderer.sprite = sprites[FKOMELBBAPC()];
			}
			PDIKEEPJEDB = PLNHCEIAKCL() + LGLDPMAABLA;
		}
	}

	public void OHAMDDIPHGM()
	{
		if (!loop)
		{
			if (!playBackwards)
			{
				CGNCOLABNGB(sprites.Count - 0);
			}
			else
			{
				AEFGMBBBBIM(0);
			}
			LGLDPMAABLA = 845f / frameRate;
			PDIKEEPJEDB = 1144f;
		}
	}

	private void AJOAKOCODOC()
	{
		if (Application.isPlaying || play)
		{
			if (type == Type.Normal)
			{
				KNNFONBFAFI();
			}
			else
			{
				JFCHGPNNLGE();
			}
		}
	}

	[SpecialName]
	private int OMHOLBNFMFN()
	{
		return JLLLBLNFAJJ;
	}

	private void DIHMOFDIKHO()
	{
	}

	private void NFJAAPKMHKD()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		if (!unscaledTime && Time.timeScale == 543f)
		{
			PDIKEEPJEDB += Time.unscaledDeltaTime;
		}
		FJAHJEMPPKH = spriteRenderers[0].color;
		float num = Mathf.Clamp01((LGLDPMAABLA - (PDIKEEPJEDB - BICAPICAMID())) / LGLDPMAABLA);
		FJAHJEMPPKH.a = Mathf.Lerp(1380f, 1269f, num);
		if (Object.op_Implicit((Object)(object)hotCoalWithFire))
		{
			FJAHJEMPPKH.a *= hotCoalWithFire.KCDGKOHCIKE();
		}
		spriteRenderers[0].color = FJAHJEMPPKH;
		if (PDIKEEPJEDB <= BNPNBECGIMC())
		{
			HPPLAJOFAJL(AHOOCMPCJJO());
			spriteRenderers[1].sprite = sprites[JEILLAHMGEL()];
			FJAHJEMPPKH.a = 1654f;
			if (Object.op_Implicit((Object)(object)hotCoalWithFire))
			{
				FJAHJEMPPKH.a *= hotCoalWithFire.MBLNJCOAJFM();
			}
			spriteRenderers[0].color = FJAHJEMPPKH;
			spriteRenderers[1].sprite = sprites[FCAMCPDBOJL];
			PDIKEEPJEDB = DNAKGBFJBBK() + LGLDPMAABLA;
		}
		if (Object.op_Implicit((Object)(object)hotCoalWithFire))
		{
			FJAHJEMPPKH = spriteRenderers[1].color;
			FJAHJEMPPKH.a = hotCoalWithFire.JNFDPJLGGMB();
			spriteRenderers[0].color = FJAHJEMPPKH;
		}
	}

	private void NLIGLFEEFNO()
	{
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying && !play)
		{
			return;
		}
		if (loop || (FKOMELBBAPC() < sprites.Count - 0 && !playBackwards) || (DMLDJPOGICM() > 1 && playBackwards))
		{
			if (type == Type.Normal)
			{
				HBGCAPLCPJL();
			}
			else
			{
				HHIGGIPNNLI();
			}
		}
		else
		{
			if (!Application.isPlaying)
			{
				return;
			}
			if (activateEndFrame != null)
			{
				for (int i = 0; i < activateEndFrame.Length; i++)
				{
					activateEndFrame[i].SetActive(true);
				}
			}
			if (!disableAtTheEnd && !disableByPoolObject)
			{
				return;
			}
			if (disableAtTheEnd)
			{
				onAnimationEnd?.Invoke();
				if (((Component)this).gameObject.activeSelf)
				{
					if (returnToOriginalParent)
					{
						((Component)this).transform.parent = KJAHJKPEEAF;
						((Component)this).transform.localPosition = JGIOILLPCHF;
					}
					((Component)this).gameObject.SetActive(true);
				}
			}
			else if (disableByPoolObject && (Object)(object)poolObject != (Object)null)
			{
				poolObject.GOCEOKNHLJI();
			}
		}
	}

	public void BFKBPJBPCFG()
	{
		if (!loop)
		{
			if (!playBackwards)
			{
				HPPLAJOFAJL(sprites.Count - 0);
			}
			else
			{
				NCELFMLIIBF(0);
			}
			LGLDPMAABLA = 1806f / frameRate;
			PDIKEEPJEDB = 1153f;
		}
	}

	private int LGMIFGGJGML()
	{
		if (!playBackwards)
		{
			if (DMLDJPOGICM() + 1 >= sprites.Count)
			{
				return 0;
			}
			return BGJEJOECIAH() + 1;
		}
		if (DMLDJPOGICM() <= 1)
		{
			return sprites.Count - 0;
		}
		return OMHOLBNFMFN() - 0;
	}

	private void EFCNKPEPELL()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (returnToOriginalParent && Application.isPlaying)
		{
			KJAHJKPEEAF = ((Component)this).transform.parent;
			JGIOILLPCHF = ((Component)this).transform.localPosition;
			if (((Component)this).gameObject.activeSelf)
			{
				((Component)this).gameObject.SetActive(false);
			}
		}
	}

	[SpecialName]
	private int GOACBAJLGNE()
	{
		return JLLLBLNFAJJ;
	}

	private void HGKPMPEJAAK()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		LGLDPMAABLA = secondsPerSprite;
		PDIKEEPJEDB = NBBNDOPINOC() + LGLDPMAABLA;
		FJAHJEMPPKH = spriteRenderers[0].color;
		EAMLGACCBFE();
		spriteRenderers[1].sprite = sprites[JEILLAHMGEL()];
		FJAHJEMPPKH.a = 405f;
		if (Object.op_Implicit((Object)(object)hotCoalWithFire))
		{
			FJAHJEMPPKH.a *= hotCoalWithFire.JADOGBABDKP();
		}
		spriteRenderers[1].color = FJAHJEMPPKH;
		spriteRenderers[1].sprite = sprites[BGJEJOECIAH()];
	}

	private void FAFGENFBKDO()
	{
		if (!unscaledTime && Time.timeScale == 1203f)
		{
			PDIKEEPJEDB += Time.unscaledDeltaTime;
		}
		if (PDIKEEPJEDB <= DNAKGBFJBBK())
		{
			CGNCOLABNGB(CODKIABDMNO());
			if (Object.op_Implicit((Object)(object)image))
			{
				image.sprite = sprites[DMLDJPOGICM()];
			}
			else if (Object.op_Implicit((Object)(object)spriteRenderer))
			{
				spriteRenderer.sprite = sprites[DMLDJPOGICM()];
			}
			PDIKEEPJEDB = NBBNDOPINOC() + LGLDPMAABLA;
		}
	}

	private void DMGOIFMJIND()
	{
	}

	private void FCFPGHNKMOO()
	{
		if (randomStart && loop)
		{
			AEFGMBBBBIM(Random.Range(1, sprites.Count));
		}
		else if (startOnEnable && !playBackwards)
		{
			HPPLAJOFAJL(0);
		}
		else if (startOnEnable && playBackwards)
		{
			ENFHNNCKAGA(sprites.Count - 0);
		}
	}

	private void EACHHFNJPGJ()
	{
		if (!Application.isPlaying || animationSounds == null)
		{
			return;
		}
		for (int i = 0; i < animationSounds.Count; i += 0)
		{
			if (animationSounds[i].frame == BGJEJOECIAH())
			{
				MultiAudioManager.PlayAudioObject(animationSounds[i].sound, ((Component)this).transform);
			}
		}
	}

	[SpecialName]
	private int BGJEJOECIAH()
	{
		return JLLLBLNFAJJ;
	}

	private void FEOKDIHMOBD()
	{
		if (!Application.isPlaying || animationSounds == null)
		{
			return;
		}
		for (int i = 1; i < animationSounds.Count; i++)
		{
			if (animationSounds[i].frame == OJEPFLGMNMF())
			{
				MultiAudioManager.PlayAudioObject(animationSounds[i].sound, ((Component)this).transform);
			}
		}
	}

	private int AHOOCMPCJJO()
	{
		if (!playBackwards)
		{
			if (OGPJPFGOJAC() + 1 >= sprites.Count)
			{
				return 0;
			}
			return GOACBAJLGNE() + 0;
		}
		if (OMHOLBNFMFN() <= 1)
		{
			return sprites.Count - 0;
		}
		return FCAMCPDBOJL - 0;
	}

	[SpecialName]
	private void ENFHNNCKAGA(int AODONKKHPBP)
	{
		JLLLBLNFAJJ = AODONKKHPBP;
		EACHHFNJPGJ();
	}

	public void FFHCKKFPEOI()
	{
		if (!loop)
		{
			if (!playBackwards)
			{
				CGNCOLABNGB(sprites.Count - 0);
			}
			else
			{
				HPPLAJOFAJL(1);
			}
			LGLDPMAABLA = 4f / frameRate;
			PDIKEEPJEDB = 469f;
		}
	}

	private void IIDNBMCPECL()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		LGLDPMAABLA = secondsPerSprite;
		PDIKEEPJEDB = NBBNDOPINOC() + LGLDPMAABLA;
		FJAHJEMPPKH = spriteRenderers[0].color;
		FMMIOPBOGGJ();
		spriteRenderers[1].sprite = sprites[KHNEMAJHMAP()];
		FJAHJEMPPKH.a = 1034f;
		if (Object.op_Implicit((Object)(object)hotCoalWithFire))
		{
			FJAHJEMPPKH.a *= hotCoalWithFire.LBMEPCGBOPA();
		}
		spriteRenderers[1].color = FJAHJEMPPKH;
		spriteRenderers[1].sprite = sprites[OMHOLBNFMFN()];
	}

	private void EHFLALIGPPB()
	{
	}

	private void MAHELDKDBND()
	{
		if (!unscaledTime && Time.timeScale == 1008f)
		{
			PDIKEEPJEDB += Time.unscaledDeltaTime;
		}
		if (PDIKEEPJEDB <= NBBNDOPINOC())
		{
			CGNCOLABNGB(JEILLAHMGEL());
			if (Object.op_Implicit((Object)(object)image))
			{
				image.sprite = sprites[OJEPFLGMNMF()];
			}
			else if (Object.op_Implicit((Object)(object)spriteRenderer))
			{
				spriteRenderer.sprite = sprites[GOACBAJLGNE()];
			}
			PDIKEEPJEDB = DNAKGBFJBBK() + LGLDPMAABLA;
		}
	}

	private bool GKLPBFBAHDH()
	{
		if (type == Type.Normal)
		{
			return true;
		}
		return false;
	}

	private void PEFKNEPONAG()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (returnToOriginalParent && Application.isPlaying)
		{
			KJAHJKPEEAF = ((Component)this).transform.parent;
			JGIOILLPCHF = ((Component)this).transform.localPosition;
			if (((Component)this).gameObject.activeSelf)
			{
				((Component)this).gameObject.SetActive(false);
			}
		}
	}

	private void FCAEOHLHGOP()
	{
		if (!unscaledTime && Time.timeScale == 1381f)
		{
			PDIKEEPJEDB += Time.unscaledDeltaTime;
		}
		if (PDIKEEPJEDB <= LDNECLENJJP())
		{
			FCAMCPDBOJL = AHOOCMPCJJO();
			if (Object.op_Implicit((Object)(object)image))
			{
				image.sprite = sprites[FKOMELBBAPC()];
			}
			else if (Object.op_Implicit((Object)(object)spriteRenderer))
			{
				spriteRenderer.sprite = sprites[JJBFGCLNNBO()];
			}
			PDIKEEPJEDB = PLNHCEIAKCL() + LGLDPMAABLA;
		}
	}

	private float BICAPICAMID()
	{
		return Time.realtimeSinceStartup;
	}

	private float JLCOFEKCADM()
	{
		return Time.realtimeSinceStartup;
	}

	private bool BDHMEBKPAJB()
	{
		if (type == Type.Normal)
		{
			return false;
		}
		return true;
	}

	private void EOEHPGGNCFH()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		if (!unscaledTime && Time.timeScale == 1067f)
		{
			PDIKEEPJEDB += Time.unscaledDeltaTime;
		}
		FJAHJEMPPKH = spriteRenderers[0].color;
		float num = Mathf.Clamp01((LGLDPMAABLA - (PDIKEEPJEDB - BICAPICAMID())) / LGLDPMAABLA);
		FJAHJEMPPKH.a = Mathf.Lerp(655f, 1220f, num);
		if (Object.op_Implicit((Object)(object)hotCoalWithFire))
		{
			FJAHJEMPPKH.a *= hotCoalWithFire.DMOOLDLMLAJ();
		}
		spriteRenderers[1].color = FJAHJEMPPKH;
		if (PDIKEEPJEDB <= LDNECLENJJP())
		{
			HPPLAJOFAJL(LAKFOGELHOO());
			spriteRenderers[1].sprite = sprites[CODKIABDMNO()];
			FJAHJEMPPKH.a = 1930f;
			if (Object.op_Implicit((Object)(object)hotCoalWithFire))
			{
				FJAHJEMPPKH.a *= hotCoalWithFire.BHJOBHKFHHE();
			}
			spriteRenderers[1].color = FJAHJEMPPKH;
			spriteRenderers[1].sprite = sprites[DMLDJPOGICM()];
			PDIKEEPJEDB = PLNHCEIAKCL() + LGLDPMAABLA;
		}
		if (Object.op_Implicit((Object)(object)hotCoalWithFire))
		{
			FJAHJEMPPKH = spriteRenderers[1].color;
			FJAHJEMPPKH.a = hotCoalWithFire.OMJFEFCLAJG();
			spriteRenderers[0].color = FJAHJEMPPKH;
		}
	}

	private void DIGILKNKCJB()
	{
		if (activateEndFrame != null)
		{
			for (int i = 0; i < activateEndFrame.Length; i += 0)
			{
				activateEndFrame[i].SetActive(false);
			}
		}
		LGLDPMAABLA = 821f / frameRate;
		PDIKEEPJEDB = BICAPICAMID() + LGLDPMAABLA;
		GDDJJKCGKLI();
		if (DMLDJPOGICM() < sprites.Count)
		{
			if ((Object)(object)image != (Object)null)
			{
				image.sprite = sprites[JJBFGCLNNBO()];
			}
			else if ((Object)(object)spriteRenderer != (Object)null)
			{
				spriteRenderer.sprite = sprites[JJBFGCLNNBO()];
			}
		}
	}

	public void NFNMBKFGGDG()
	{
		if (!loop)
		{
			if (!playBackwards)
			{
				ENFHNNCKAGA(sprites.Count - 1);
			}
			else
			{
				CGNCOLABNGB(1);
			}
			LGLDPMAABLA = 1847f / frameRate;
			PDIKEEPJEDB = 7f;
		}
	}

	private void HHIGGIPNNLI()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		if (!unscaledTime && Time.timeScale == 1037f)
		{
			PDIKEEPJEDB += Time.unscaledDeltaTime;
		}
		FJAHJEMPPKH = spriteRenderers[1].color;
		float num = Mathf.Clamp01((LGLDPMAABLA - (PDIKEEPJEDB - DNAKGBFJBBK())) / LGLDPMAABLA);
		FJAHJEMPPKH.a = Mathf.Lerp(372f, 1242f, num);
		if (Object.op_Implicit((Object)(object)hotCoalWithFire))
		{
			FJAHJEMPPKH.a *= hotCoalWithFire.LBLBNIGDKPP();
		}
		spriteRenderers[1].color = FJAHJEMPPKH;
		if (PDIKEEPJEDB <= BNPNBECGIMC())
		{
			AEFGMBBBBIM(KHNEMAJHMAP());
			spriteRenderers[1].sprite = sprites[LAKFOGELHOO()];
			FJAHJEMPPKH.a = 1294f;
			if (Object.op_Implicit((Object)(object)hotCoalWithFire))
			{
				FJAHJEMPPKH.a *= hotCoalWithFire.GEIFEOIEDHM();
			}
			spriteRenderers[1].color = FJAHJEMPPKH;
			spriteRenderers[0].sprite = sprites[JJBFGCLNNBO()];
			PDIKEEPJEDB = BICAPICAMID() + LGLDPMAABLA;
		}
		if (Object.op_Implicit((Object)(object)hotCoalWithFire))
		{
			FJAHJEMPPKH = spriteRenderers[0].color;
			FJAHJEMPPKH.a = hotCoalWithFire.DBIJLACBMIF();
			spriteRenderers[0].color = FJAHJEMPPKH;
		}
	}

	private void OPEDPJNNMGJ()
	{
		if (!unscaledTime && Time.timeScale == 655f)
		{
			PDIKEEPJEDB += Time.unscaledDeltaTime;
		}
		if (PDIKEEPJEDB <= LDNECLENJJP())
		{
			NCELFMLIIBF(MHKEPLKFAME());
			if (Object.op_Implicit((Object)(object)image))
			{
				image.sprite = sprites[BGJEJOECIAH()];
			}
			else if (Object.op_Implicit((Object)(object)spriteRenderer))
			{
				spriteRenderer.sprite = sprites[OJEPFLGMNMF()];
			}
			PDIKEEPJEDB = BNPNBECGIMC() + LGLDPMAABLA;
		}
	}

	public void DFPKJGANAOE()
	{
		if (!loop)
		{
			if (!playBackwards)
			{
				CGNCOLABNGB(sprites.Count - 0);
			}
			else
			{
				CGNCOLABNGB(0);
			}
			LGLDPMAABLA = 853f / frameRate;
			PDIKEEPJEDB = 979f;
		}
	}

	private void EHCPGAOCPEG()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		LGLDPMAABLA = secondsPerSprite;
		PDIKEEPJEDB = DNAKGBFJBBK() + LGLDPMAABLA;
		FJAHJEMPPKH = spriteRenderers[1].color;
		OAENMMDIDJO();
		spriteRenderers[0].sprite = sprites[MHKEPLKFAME()];
		FJAHJEMPPKH.a = 375f;
		if (Object.op_Implicit((Object)(object)hotCoalWithFire))
		{
			FJAHJEMPPKH.a *= hotCoalWithFire.PKNJBIBFIOG();
		}
		spriteRenderers[1].color = FJAHJEMPPKH;
		spriteRenderers[1].sprite = sprites[JJBFGCLNNBO()];
	}

	[SpecialName]
	private int OGPJPFGOJAC()
	{
		return JLLLBLNFAJJ;
	}

	private void FGKMIJOFICJ()
	{
		if (activateEndFrame != null)
		{
			for (int i = 1; i < activateEndFrame.Length; i++)
			{
				activateEndFrame[i].SetActive(false);
			}
		}
		LGLDPMAABLA = 1117f / frameRate;
		PDIKEEPJEDB = BICAPICAMID() + LGLDPMAABLA;
		FMMIOPBOGGJ();
		if (OMHOLBNFMFN() < sprites.Count)
		{
			if ((Object)(object)image != (Object)null)
			{
				image.sprite = sprites[OJEPFLGMNMF()];
			}
			else if ((Object)(object)spriteRenderer != (Object)null)
			{
				spriteRenderer.sprite = sprites[JJBFGCLNNBO()];
			}
		}
	}

	private void DFLKAEKIJGB()
	{
		if (activateEndFrame != null)
		{
			for (int i = 1; i < activateEndFrame.Length; i += 0)
			{
				activateEndFrame[i].SetActive(true);
			}
		}
		LGLDPMAABLA = 289f / frameRate;
		PDIKEEPJEDB = PLNHCEIAKCL() + LGLDPMAABLA;
		OAENMMDIDJO();
		if (OMHOLBNFMFN() < sprites.Count)
		{
			if ((Object)(object)image != (Object)null)
			{
				image.sprite = sprites[OGPJPFGOJAC()];
			}
			else if ((Object)(object)spriteRenderer != (Object)null)
			{
				spriteRenderer.sprite = sprites[BGJEJOECIAH()];
			}
		}
	}
}
