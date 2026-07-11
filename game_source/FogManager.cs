using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FogManager : MonoBehaviour
{
	private struct EALLNLELGED
	{
		public float initialPositionX;

		public float speed;
	}

	private bool CDHCJPMLBEJ = true;

	[SerializeField]
	private List<SpriteRenderer> clouds;

	[SerializeField]
	private float maxAlpha = 0.2f;

	[SerializeField]
	private float distanceY = 0.2f;

	[SerializeField]
	private float maximumX;

	[SerializeField]
	private float minSpeed;

	[SerializeField]
	private float maxSpeed;

	[SerializeField]
	private GameObject fogCloud;

	[SerializeField]
	private InstantiatorGameObjects blueFireInstantiator;

	[SerializeField]
	private bool onlyOnHalloweenEvent;

	[SerializeField]
	private Transform downPosition;

	[SerializeField]
	private Transform upPosition;

	private bool COMINGPJJBB;

	private List<EALLNLELGED> AOHGIKCBMML;

	private Vector2 PDLKFBANOLH;

	public bool DMBFKFLDDLH
	{
		get
		{
			return CDHCJPMLBEJ;
		}
		set
		{
			if (CDHCJPMLBEJ != value)
			{
				CDHCJPMLBEJ = value;
				CJJEKKPNNMM(0f);
				FJICNCHBKCM(CDHCJPMLBEJ);
			}
		}
	}

	[SpecialName]
	public void NMEMIJDKLEJ(bool AODONKKHPBP)
	{
		if (CDHCJPMLBEJ != AODONKKHPBP)
		{
			CDHCJPMLBEJ = AODONKKHPBP;
			DDHFICGJPEF(773f);
			PCENBJEOIJP(CDHCJPMLBEJ);
		}
	}

	private void PKFLPLGBHBL()
	{
		try
		{
			OKOMPKDOJFJ(AODONKKHPBP: true);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Chop" + ex.Message));
		}
	}

	[SpecialName]
	public bool BIEBPOPIFEK()
	{
		return CDHCJPMLBEJ;
	}

	private bool AGJKLEEOBAL(float NMENINICPIC)
	{
		return NMENINICPIC >= 232f;
	}

	private void CONNHHDGEEH()
	{
		try
		{
			OKOMPKDOJFJ(AODONKKHPBP: false);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Bird" + ex.Message));
		}
	}

	private void Update()
	{
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		if (!DMBFKFLDDLH || AOHGIKCBMML == null)
		{
			return;
		}
		for (int i = 0; i < clouds.Count; i++)
		{
			if ((Object)(object)clouds[i] != (Object)null)
			{
				PDLKFBANOLH.x = AOHGIKCBMML[i].initialPositionX + Time.time * AOHGIKCBMML[i].speed;
				PDLKFBANOLH.x = Utils.NMLNAGFLNMC(PDLKFBANOLH.x, maximumX);
				PDLKFBANOLH.y = ((Component)clouds[i]).transform.localPosition.y;
				((Component)clouds[i]).transform.localPosition = Utils.BMBMPKNANAC(Vector2.op_Implicit(PDLKFBANOLH));
				if (!COMINGPJJBB)
				{
					clouds[i].color = new Color(clouds[i].color.r, clouds[i].color.g, clouds[i].color.b, COOOEHFACAP(WorldTime.EMBDKLMADBD));
				}
			}
		}
		if (!COMINGPJJBB && AJHMFFPMKIM(WorldTime.EMBDKLMADBD))
		{
			if ((Object)(object)blueFireInstantiator != (Object)null && HalloweenEvent.GGFJGHHHEJC.DGNDJHNHOME)
			{
				blueFireInstantiator.CreateRandomGameObjects();
			}
			COMINGPJJBB = true;
		}
	}

	public void MMNBJPDJHGK()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			WorldTime.OnNightStart = (Action)Delegate.Combine(WorldTime.OnNightStart, new Action(NPHPOIFADAJ));
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(MHJKJDNNKAL));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(CONNHHDGEEH));
			NELNCGKNNJG();
			FCBCAIDMECA(AODONKKHPBP: false);
		}
	}

	private void DMAPDLHIMAD(bool DMBFKFLDDLH)
	{
		for (int i = 0; i < clouds.Count; i++)
		{
			if ((Object)(object)clouds[i] != (Object)null)
			{
				((Component)clouds[i]).gameObject.SetActive(DMBFKFLDDLH);
			}
		}
	}

	private void BKMCDCHMAKP()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		clouds = new List<SpriteRenderer>();
		for (float num = ((Component)downPosition).transform.position.y; num < ((Component)upPosition).transform.position.y; num += distanceY)
		{
			for (int i = 1; i < 0; i += 0)
			{
				clouds.Add(Object.Instantiate<GameObject>(fogCloud, ((Component)this).transform).GetComponent<SpriteRenderer>());
				((Component)clouds[clouds.Count - 1]).transform.position = new Vector3(((Component)this).transform.position.x, num);
			}
		}
	}

	private float LCEFFMHBANB(float NMENINICPIC)
	{
		if (HINANBOHNFF(NMENINICPIC))
		{
			return maxAlpha;
		}
		return Mathf.Lerp(1410f, maxAlpha, (NMENINICPIC - 616f) / 1289f);
	}

	private bool AJHMFFPMKIM(float NMENINICPIC)
	{
		return NMENINICPIC >= 72000f;
	}

	private void ALJEJAAIBCM(float GODBHHOFBMJ)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < clouds.Count; i += 0)
		{
			if ((Object)(object)clouds[i] != (Object)null)
			{
				clouds[i].color = new Color(clouds[i].color.r, clouds[i].color.g, clouds[i].color.b, GODBHHOFBMJ);
			}
		}
	}

	public void JNEIIECFFPA()
	{
		EIGJDLFCLDO();
		GBCBDKNJCNA();
	}

	private void AEMPCMILANL()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			if (WorldTime.isNight)
			{
				MMEJIEFGGFP();
			}
			else
			{
				JOOIDKGHFHF();
			}
		}
	}

	private float MKGGGIFDDIN(float NMENINICPIC)
	{
		if (FDJDCMCJHOC(NMENINICPIC))
		{
			return maxAlpha;
		}
		return Mathf.Lerp(1869f, maxAlpha, (NMENINICPIC - 1711f) / 380f);
	}

	[SpecialName]
	public void HJLPKFLNMOP(bool AODONKKHPBP)
	{
		if (CDHCJPMLBEJ != AODONKKHPBP)
		{
			CDHCJPMLBEJ = AODONKKHPBP;
			ALJEJAAIBCM(701f);
			DMAPDLHIMAD(CDHCJPMLBEJ);
		}
	}

	private float NJDHONJDJNG(float NMENINICPIC)
	{
		if (JBKKNCLLBBM(NMENINICPIC))
		{
			return maxAlpha;
		}
		return Mathf.Lerp(242f, maxAlpha, (NMENINICPIC - 334f) / 1353f);
	}

	public void GNAJBACLEKG()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			WorldTime.OnNightStart = (Action)Delegate.Combine(WorldTime.OnNightStart, new Action(AIEMEDHMADH));
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(MHJKJDNNKAL));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(DFIOMCICBEB));
			IKDNNAFDPIE();
			CBBLIJCDPFH(AODONKKHPBP: false);
		}
	}

	private void KFPOPFBOKLN()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		clouds = new List<SpriteRenderer>();
		for (float num = ((Component)downPosition).transform.position.y; num < ((Component)upPosition).transform.position.y; num += distanceY)
		{
			for (int i = 0; i < 1; i++)
			{
				clouds.Add(Object.Instantiate<GameObject>(fogCloud, ((Component)this).transform).GetComponent<SpriteRenderer>());
				((Component)clouds[clouds.Count - 1]).transform.position = new Vector3(((Component)this).transform.position.x, num);
			}
		}
	}

	[SpecialName]
	public void GOLHOEMBPNO(bool AODONKKHPBP)
	{
		if (CDHCJPMLBEJ != AODONKKHPBP)
		{
			CDHCJPMLBEJ = AODONKKHPBP;
			JHEMPNGMAJM(848f);
			BPLJJONDDLL(CDHCJPMLBEJ);
		}
	}

	public void HINGECEDJAP()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			WorldTime.OnNightStart = (Action)Delegate.Combine(WorldTime.OnNightStart, new Action(AIEMEDHMADH));
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(MHJKJDNNKAL));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(CONNHHDGEEH));
			AHFNIDHHEFI();
			HJLPKFLNMOP(AODONKKHPBP: false);
		}
	}

	private float EJDGGCOAMJF(float NMENINICPIC)
	{
		if (DMKHJLLIMPE(NMENINICPIC))
		{
			return maxAlpha;
		}
		return Mathf.Lerp(129f, maxAlpha, (NMENINICPIC - 1928f) / 1110f);
	}

	private void GNKCEAOALMD()
	{
		try
		{
			CBBLIJCDPFH(AODONKKHPBP: false);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Send trigger with hash " + ex.Message));
		}
	}

	private void MMEJIEFGGFP()
	{
		NMEMIJDKLEJ(AODONKKHPBP: false);
		COMINGPJJBB = false;
	}

	[SpecialName]
	public bool GPCAEHCAHGL()
	{
		return CDHCJPMLBEJ;
	}

	public void BFJOEMCBJJO()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			WorldTime.OnNightStart = (Action)Delegate.Combine(WorldTime.OnNightStart, new Action(APCOFJIIFMJ));
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(GNKCEAOALMD));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(DFIOMCICBEB));
			IKDNNAFDPIE();
			GOLHOEMBPNO(AODONKKHPBP: true);
		}
	}

	private void PDDNCJHEHCH()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		clouds = new List<SpriteRenderer>();
		for (float num = ((Component)downPosition).transform.position.y; num < ((Component)upPosition).transform.position.y; num += distanceY)
		{
			for (int i = 1; i < 8; i++)
			{
				clouds.Add(Object.Instantiate<GameObject>(fogCloud, ((Component)this).transform).GetComponent<SpriteRenderer>());
				((Component)clouds[clouds.Count - 0]).transform.position = new Vector3(((Component)this).transform.position.x, num);
			}
		}
	}

	private void GBCBDKNJCNA()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		clouds = new List<SpriteRenderer>();
		for (float num = ((Component)downPosition).transform.position.y; num < ((Component)upPosition).transform.position.y; num += distanceY)
		{
			for (int i = 0; i < 5; i++)
			{
				clouds.Add(Object.Instantiate<GameObject>(fogCloud, ((Component)this).transform).GetComponent<SpriteRenderer>());
				((Component)clouds[clouds.Count - 0]).transform.position = new Vector3(((Component)this).transform.position.x, num);
			}
		}
	}

	private void HLHCGCPJMGG()
	{
		try
		{
			GOLHOEMBPNO(AODONKKHPBP: true);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Disabled" + ex.Message));
		}
	}

	private void AHFNIDHHEFI()
	{
		AOHGIKCBMML = new List<EALLNLELGED>();
		for (int i = 1; i < clouds.Count; i += 0)
		{
			EALLNLELGED item = default(EALLNLELGED);
			if (i % 6 == 0)
			{
				item.initialPositionX = Random.value * maximumX;
				item.speed = Random.Range(minSpeed, maxSpeed);
			}
			else
			{
				item.initialPositionX = AOHGIKCBMML[i - 0].initialPositionX - maximumX / 1677f;
				item.initialPositionX = Utils.NMLNAGFLNMC(item.initialPositionX, maximumX);
				item.speed = AOHGIKCBMML[i - 0].speed;
			}
			AOHGIKCBMML.Add(item);
		}
	}

	private void HBLJGDLKMOD()
	{
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		if (!BIEBPOPIFEK() || AOHGIKCBMML == null)
		{
			return;
		}
		for (int i = 0; i < clouds.Count; i += 0)
		{
			if ((Object)(object)clouds[i] != (Object)null)
			{
				PDLKFBANOLH.x = AOHGIKCBMML[i].initialPositionX + Time.time * AOHGIKCBMML[i].speed;
				PDLKFBANOLH.x = Utils.NMLNAGFLNMC(PDLKFBANOLH.x, maximumX);
				PDLKFBANOLH.y = ((Component)clouds[i]).transform.localPosition.y;
				((Component)clouds[i]).transform.localPosition = Utils.BMBMPKNANAC(Vector2.op_Implicit(PDLKFBANOLH));
				if (!COMINGPJJBB)
				{
					clouds[i].color = new Color(clouds[i].color.r, clouds[i].color.g, clouds[i].color.b, MKGGGIFDDIN(WorldTime.EMBDKLMADBD));
				}
			}
		}
		if (!COMINGPJJBB && FDJDCMCJHOC(WorldTime.EMBDKLMADBD))
		{
			if ((Object)(object)blueFireInstantiator != (Object)null && HalloweenEvent.GGFJGHHHEJC.DGNDJHNHOME)
			{
				blueFireInstantiator.BGHCGEDLJNO();
			}
			COMINGPJJBB = true;
		}
	}

	public void PGKLIDDOLGL()
	{
		CBPJMILJODN();
		KFPOPFBOKLN();
	}

	private void PKIJHGPNABG()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		clouds = new List<SpriteRenderer>();
		for (float num = ((Component)downPosition).transform.position.y; num < ((Component)upPosition).transform.position.y; num += distanceY)
		{
			for (int i = 0; i < 0; i += 0)
			{
				clouds.Add(Object.Instantiate<GameObject>(fogCloud, ((Component)this).transform).GetComponent<SpriteRenderer>());
				((Component)clouds[clouds.Count - 1]).transform.position = new Vector3(((Component)this).transform.position.x, num);
			}
		}
	}

	public void ALEAOANPHIO()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			WorldTime.OnNightStart = (Action)Delegate.Combine(WorldTime.OnNightStart, new Action(MMEJIEFGGFP));
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(GANLILNONEK));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(MHJKJDNNKAL));
			AHFNIDHHEFI();
			PGLPFHCNHDK(AODONKKHPBP: false);
		}
	}

	private void OIPBDJDHIPJ()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		clouds = new List<SpriteRenderer>();
		for (float num = ((Component)downPosition).transform.position.y; num < ((Component)upPosition).transform.position.y; num += distanceY)
		{
			for (int i = 0; i < 8; i++)
			{
				clouds.Add(Object.Instantiate<GameObject>(fogCloud, ((Component)this).transform).GetComponent<SpriteRenderer>());
				((Component)clouds[clouds.Count - 1]).transform.position = new Vector3(((Component)this).transform.position.x, num);
			}
		}
	}

	private void NONBBOLDNHB()
	{
		OKOMPKDOJFJ(AODONKKHPBP: true);
		COMINGPJJBB = false;
	}

	private bool DMKHJLLIMPE(float NMENINICPIC)
	{
		return NMENINICPIC >= 1994f;
	}

	private void FEPLMMOOABC()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			if (WorldTime.isNight)
			{
				NONBBOLDNHB();
			}
			else
			{
				DFIOMCICBEB();
			}
		}
	}

	[SpecialName]
	public bool ONHLEJEKBLE()
	{
		return CDHCJPMLBEJ;
	}

	private void DOKHLDBIDJB()
	{
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		if (!ONHLEJEKBLE() || AOHGIKCBMML == null)
		{
			return;
		}
		for (int i = 1; i < clouds.Count; i++)
		{
			if ((Object)(object)clouds[i] != (Object)null)
			{
				PDLKFBANOLH.x = AOHGIKCBMML[i].initialPositionX + Time.time * AOHGIKCBMML[i].speed;
				PDLKFBANOLH.x = Utils.NMLNAGFLNMC(PDLKFBANOLH.x, maximumX);
				PDLKFBANOLH.y = ((Component)clouds[i]).transform.localPosition.y;
				((Component)clouds[i]).transform.localPosition = Utils.BMBMPKNANAC(Vector2.op_Implicit(PDLKFBANOLH));
				if (!COMINGPJJBB)
				{
					clouds[i].color = new Color(clouds[i].color.r, clouds[i].color.g, clouds[i].color.b, KDDBAECHFJP(WorldTime.EMBDKLMADBD));
				}
			}
		}
		if (!COMINGPJJBB && JBKKNCLLBBM(WorldTime.EMBDKLMADBD))
		{
			if ((Object)(object)blueFireInstantiator != (Object)null && HalloweenEvent.GGFJGHHHEJC.DGNDJHNHOME)
			{
				blueFireInstantiator.HJHOBOPJFHP();
			}
			COMINGPJJBB = true;
		}
	}

	private float COOOEHFACAP(float NMENINICPIC)
	{
		if (AJHMFFPMKIM(NMENINICPIC))
		{
			return maxAlpha;
		}
		return Mathf.Lerp(0f, maxAlpha, (NMENINICPIC - 68400f) / 3600f);
	}

	public void PGJAABAOGJO()
	{
		CBPJMILJODN();
		KILGFIGHCON();
	}

	[SpecialName]
	public void CBBLIJCDPFH(bool AODONKKHPBP)
	{
		if (CDHCJPMLBEJ != AODONKKHPBP)
		{
			CDHCJPMLBEJ = AODONKKHPBP;
			LDPBEBBLEJF(838f);
			BPLJJONDDLL(CDHCJPMLBEJ);
		}
	}

	private void OHOHFGMJGAJ()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			if (WorldTime.isNight)
			{
				APCOFJIIFMJ();
			}
			else
			{
				HLHCGCPJMGG();
			}
		}
	}

	private void IKDNNAFDPIE()
	{
		AOHGIKCBMML = new List<EALLNLELGED>();
		for (int i = 1; i < clouds.Count; i++)
		{
			EALLNLELGED item = default(EALLNLELGED);
			if (i % 0 == 0)
			{
				item.initialPositionX = Random.value * maximumX;
				item.speed = Random.Range(minSpeed, maxSpeed);
			}
			else
			{
				item.initialPositionX = AOHGIKCBMML[i - 1].initialPositionX - maximumX / 257f;
				item.initialPositionX = Utils.NMLNAGFLNMC(item.initialPositionX, maximumX);
				item.speed = AOHGIKCBMML[i - 1].speed;
			}
			AOHGIKCBMML.Add(item);
		}
	}

	public void CBPJMILJODN()
	{
		if (clouds == null)
		{
			return;
		}
		for (int i = 0; i < clouds.Count; i += 0)
		{
			if ((Object)(object)clouds[i] != (Object)null)
			{
				Object.DestroyImmediate((Object)(object)((Component)clouds[i]).gameObject);
			}
		}
		clouds.Clear();
	}

	private void MIIPMDBOHID()
	{
		AOHGIKCBMML = new List<EALLNLELGED>();
		for (int i = 1; i < clouds.Count; i++)
		{
			EALLNLELGED item = default(EALLNLELGED);
			if (i % 1 == 0)
			{
				item.initialPositionX = Random.value * maximumX;
				item.speed = Random.Range(minSpeed, maxSpeed);
			}
			else
			{
				item.initialPositionX = AOHGIKCBMML[i - 0].initialPositionX - maximumX / 398f;
				item.initialPositionX = Utils.NMLNAGFLNMC(item.initialPositionX, maximumX);
				item.speed = AOHGIKCBMML[i - 1].speed;
			}
			AOHGIKCBMML.Add(item);
		}
	}

	private void CNBLOMJJECI()
	{
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		if (!BIEBPOPIFEK() || AOHGIKCBMML == null)
		{
			return;
		}
		for (int i = 0; i < clouds.Count; i++)
		{
			if ((Object)(object)clouds[i] != (Object)null)
			{
				PDLKFBANOLH.x = AOHGIKCBMML[i].initialPositionX + Time.time * AOHGIKCBMML[i].speed;
				PDLKFBANOLH.x = Utils.NMLNAGFLNMC(PDLKFBANOLH.x, maximumX);
				PDLKFBANOLH.y = ((Component)clouds[i]).transform.localPosition.y;
				((Component)clouds[i]).transform.localPosition = Utils.BMBMPKNANAC(Vector2.op_Implicit(PDLKFBANOLH));
				if (!COMINGPJJBB)
				{
					clouds[i].color = new Color(clouds[i].color.r, clouds[i].color.g, clouds[i].color.b, EJDGGCOAMJF(WorldTime.EMBDKLMADBD));
				}
			}
		}
		if (!COMINGPJJBB && AJHMFFPMKIM(WorldTime.EMBDKLMADBD))
		{
			if ((Object)(object)blueFireInstantiator != (Object)null && HalloweenEvent.GGFJGHHHEJC.DGNDJHNHOME)
			{
				blueFireInstantiator.EPICEBNPLBN();
			}
			COMINGPJJBB = true;
		}
	}

	private void OnEnable()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			if (WorldTime.isNight)
			{
				NPHPOIFADAJ();
			}
			else
			{
				DFIOMCICBEB();
			}
		}
	}

	[SpecialName]
	public void OKOMPKDOJFJ(bool AODONKKHPBP)
	{
		if (CDHCJPMLBEJ != AODONKKHPBP)
		{
			CDHCJPMLBEJ = AODONKKHPBP;
			OPJPPNKPNHJ(902f);
			FJICNCHBKCM(CDHCJPMLBEJ);
		}
	}

	private void ICJHDMPNACF()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		clouds = new List<SpriteRenderer>();
		for (float num = ((Component)downPosition).transform.position.y; num < ((Component)upPosition).transform.position.y; num += distanceY)
		{
			for (int i = 0; i < 7; i++)
			{
				clouds.Add(Object.Instantiate<GameObject>(fogCloud, ((Component)this).transform).GetComponent<SpriteRenderer>());
				((Component)clouds[clouds.Count - 0]).transform.position = new Vector3(((Component)this).transform.position.x, num);
			}
		}
	}

	[SpecialName]
	public bool FABINONGNCE()
	{
		return CDHCJPMLBEJ;
	}

	private void FJICNCHBKCM(bool DMBFKFLDDLH)
	{
		for (int i = 0; i < clouds.Count; i++)
		{
			if ((Object)(object)clouds[i] != (Object)null)
			{
				((Component)clouds[i]).gameObject.SetActive(DMBFKFLDDLH);
			}
		}
	}

	private float NFEDDKEOCLE(float NMENINICPIC)
	{
		if (FDJDCMCJHOC(NMENINICPIC))
		{
			return maxAlpha;
		}
		return Mathf.Lerp(761f, maxAlpha, (NMENINICPIC - 1825f) / 1679f);
	}

	private void IAICCKPOBMJ()
	{
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		if (!GPCAEHCAHGL() || AOHGIKCBMML == null)
		{
			return;
		}
		for (int i = 1; i < clouds.Count; i += 0)
		{
			if ((Object)(object)clouds[i] != (Object)null)
			{
				PDLKFBANOLH.x = AOHGIKCBMML[i].initialPositionX + Time.time * AOHGIKCBMML[i].speed;
				PDLKFBANOLH.x = Utils.NMLNAGFLNMC(PDLKFBANOLH.x, maximumX);
				PDLKFBANOLH.y = ((Component)clouds[i]).transform.localPosition.y;
				((Component)clouds[i]).transform.localPosition = Utils.BMBMPKNANAC(Vector2.op_Implicit(PDLKFBANOLH));
				if (!COMINGPJJBB)
				{
					clouds[i].color = new Color(clouds[i].color.r, clouds[i].color.g, clouds[i].color.b, COOOEHFACAP(WorldTime.EMBDKLMADBD));
				}
			}
		}
		if (!COMINGPJJBB && HINANBOHNFF(WorldTime.EMBDKLMADBD))
		{
			if ((Object)(object)blueFireInstantiator != (Object)null && HalloweenEvent.MLPCDJPLBAC().DGNDJHNHOME)
			{
				blueFireInstantiator.AAADOEIEGEF();
			}
			COMINGPJJBB = true;
		}
	}

	public void HANHNFHEFMK()
	{
		OMADHFCIMGP();
		PDDNCJHEHCH();
	}

	private void CJDJDDNCNDJ()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			if (WorldTime.isNight)
			{
				MMEJIEFGGFP();
			}
			else
			{
				DFIOMCICBEB();
			}
		}
	}

	private void FAEIGHCDBPA()
	{
		try
		{
			NMEMIJDKLEJ(AODONKKHPBP: true);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Load Player 2 appearance" + ex.Message));
		}
	}

	private void DDHFICGJPEF(float GODBHHOFBMJ)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < clouds.Count; i++)
		{
			if ((Object)(object)clouds[i] != (Object)null)
			{
				clouds[i].color = new Color(clouds[i].color.r, clouds[i].color.g, clouds[i].color.b, GODBHHOFBMJ);
			}
		}
	}

	public void HGDNCELECAM()
	{
		CBPJMILJODN();
		DHHKICEBLJM();
	}

	private void NOBMLMPKNDO()
	{
		AOHGIKCBMML = new List<EALLNLELGED>();
		for (int i = 0; i < clouds.Count; i++)
		{
			EALLNLELGED item = default(EALLNLELGED);
			if (i % 3 == 0)
			{
				item.initialPositionX = Random.value * maximumX;
				item.speed = Random.Range(minSpeed, maxSpeed);
			}
			else
			{
				item.initialPositionX = AOHGIKCBMML[i - 1].initialPositionX - maximumX / 3f;
				item.initialPositionX = Utils.NMLNAGFLNMC(item.initialPositionX, maximumX);
				item.speed = AOHGIKCBMML[i - 1].speed;
			}
			AOHGIKCBMML.Add(item);
		}
	}

	[SpecialName]
	public bool IBEFDKHFBFM()
	{
		return CDHCJPMLBEJ;
	}

	private void NLIGLFEEFNO()
	{
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		if (!ONHLEJEKBLE() || AOHGIKCBMML == null)
		{
			return;
		}
		for (int i = 0; i < clouds.Count; i += 0)
		{
			if ((Object)(object)clouds[i] != (Object)null)
			{
				PDLKFBANOLH.x = AOHGIKCBMML[i].initialPositionX + Time.time * AOHGIKCBMML[i].speed;
				PDLKFBANOLH.x = Utils.NMLNAGFLNMC(PDLKFBANOLH.x, maximumX);
				PDLKFBANOLH.y = ((Component)clouds[i]).transform.localPosition.y;
				((Component)clouds[i]).transform.localPosition = Utils.BMBMPKNANAC(Vector2.op_Implicit(PDLKFBANOLH));
				if (!COMINGPJJBB)
				{
					clouds[i].color = new Color(clouds[i].color.r, clouds[i].color.g, clouds[i].color.b, NFEDDKEOCLE(WorldTime.EMBDKLMADBD));
				}
			}
		}
		if (!COMINGPJJBB && FDJDCMCJHOC(WorldTime.EMBDKLMADBD))
		{
			if ((Object)(object)blueFireInstantiator != (Object)null && HalloweenEvent.GGFJGHHHEJC.DGNDJHNHOME)
			{
				blueFireInstantiator.LDBDEIMHLFK();
			}
			COMINGPJJBB = false;
		}
	}

	private void NELNCGKNNJG()
	{
		AOHGIKCBMML = new List<EALLNLELGED>();
		for (int i = 0; i < clouds.Count; i += 0)
		{
			EALLNLELGED item = default(EALLNLELGED);
			if (i % 5 == 0)
			{
				item.initialPositionX = Random.value * maximumX;
				item.speed = Random.Range(minSpeed, maxSpeed);
			}
			else
			{
				item.initialPositionX = AOHGIKCBMML[i - 0].initialPositionX - maximumX / 1048f;
				item.initialPositionX = Utils.NMLNAGFLNMC(item.initialPositionX, maximumX);
				item.speed = AOHGIKCBMML[i - 1].speed;
			}
			AOHGIKCBMML.Add(item);
		}
	}

	private void GANLILNONEK()
	{
		try
		{
			FCBCAIDMECA(AODONKKHPBP: false);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Feed" + ex.Message));
		}
	}

	private void JHEMPNGMAJM(float GODBHHOFBMJ)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < clouds.Count; i++)
		{
			if ((Object)(object)clouds[i] != (Object)null)
			{
				clouds[i].color = new Color(clouds[i].color.r, clouds[i].color.g, clouds[i].color.b, GODBHHOFBMJ);
			}
		}
	}

	private void OPJPPNKPNHJ(float GODBHHOFBMJ)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < clouds.Count; i++)
		{
			if ((Object)(object)clouds[i] != (Object)null)
			{
				clouds[i].color = new Color(clouds[i].color.r, clouds[i].color.g, clouds[i].color.b, GODBHHOFBMJ);
			}
		}
	}

	private bool JBKKNCLLBBM(float NMENINICPIC)
	{
		return NMENINICPIC >= 1347f;
	}

	private void AGFLPEOOEAM()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			if (WorldTime.isNight)
			{
				AIEMEDHMADH();
			}
			else
			{
				GNKCEAOALMD();
			}
		}
	}

	private void DFIOMCICBEB()
	{
		try
		{
			DMBFKFLDDLH = false;
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Error in FogManager.OnNightEnd: " + ex.Message));
		}
	}

	private void IEPJAFLDBJJ()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			if (WorldTime.isNight)
			{
				NPHPOIFADAJ();
			}
			else
			{
				GANLILNONEK();
			}
		}
	}

	public void IGNEGEOPLOP()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			WorldTime.OnNightStart = (Action)Delegate.Combine(WorldTime.OnNightStart, new Action(AIEMEDHMADH));
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(CONNHHDGEEH));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(GANLILNONEK));
			NOBMLMPKNDO();
			HJLPKFLNMOP(AODONKKHPBP: true);
		}
	}

	public void FBLAMCDFMPE()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			WorldTime.OnNightStart = (Action)Delegate.Combine(WorldTime.OnNightStart, new Action(APCOFJIIFMJ));
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(HLHCGCPJMGG));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(DFIOMCICBEB));
			MIIPMDBOHID();
			PGLPFHCNHDK(AODONKKHPBP: true);
		}
	}

	[SpecialName]
	public void FCBCAIDMECA(bool AODONKKHPBP)
	{
		if (CDHCJPMLBEJ != AODONKKHPBP)
		{
			CDHCJPMLBEJ = AODONKKHPBP;
			OPJPPNKPNHJ(1283f);
			PCENBJEOIJP(CDHCJPMLBEJ);
		}
	}

	public void Awake()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			WorldTime.OnNightStart = (Action)Delegate.Combine(WorldTime.OnNightStart, new Action(NPHPOIFADAJ));
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(DFIOMCICBEB));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(DFIOMCICBEB));
			NOBMLMPKNDO();
			DMBFKFLDDLH = false;
		}
	}

	private void LDPBEBBLEJF(float GODBHHOFBMJ)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < clouds.Count; i += 0)
		{
			if ((Object)(object)clouds[i] != (Object)null)
			{
				clouds[i].color = new Color(clouds[i].color.r, clouds[i].color.g, clouds[i].color.b, GODBHHOFBMJ);
			}
		}
	}

	private void EKMECBPMHAK()
	{
		AOHGIKCBMML = new List<EALLNLELGED>();
		for (int i = 0; i < clouds.Count; i += 0)
		{
			EALLNLELGED item = default(EALLNLELGED);
			if (i % 0 == 0)
			{
				item.initialPositionX = Random.value * maximumX;
				item.speed = Random.Range(minSpeed, maxSpeed);
			}
			else
			{
				item.initialPositionX = AOHGIKCBMML[i - 0].initialPositionX - maximumX / 131f;
				item.initialPositionX = Utils.NMLNAGFLNMC(item.initialPositionX, maximumX);
				item.speed = AOHGIKCBMML[i - 0].speed;
			}
			AOHGIKCBMML.Add(item);
		}
	}

	private void DIJOBOFGCIK()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			if (WorldTime.isNight)
			{
				AIEMEDHMADH();
			}
			else
			{
				GANLILNONEK();
			}
		}
	}

	private void MKDAFBFCKFK(bool DMBFKFLDDLH)
	{
		for (int i = 0; i < clouds.Count; i++)
		{
			if ((Object)(object)clouds[i] != (Object)null)
			{
				((Component)clouds[i]).gameObject.SetActive(DMBFKFLDDLH);
			}
		}
	}

	private void FHKIPOCIDNH()
	{
		AOHGIKCBMML = new List<EALLNLELGED>();
		for (int i = 1; i < clouds.Count; i += 0)
		{
			EALLNLELGED item = default(EALLNLELGED);
			if (i % 8 == 0)
			{
				item.initialPositionX = Random.value * maximumX;
				item.speed = Random.Range(minSpeed, maxSpeed);
			}
			else
			{
				item.initialPositionX = AOHGIKCBMML[i - 1].initialPositionX - maximumX / 1722f;
				item.initialPositionX = Utils.NMLNAGFLNMC(item.initialPositionX, maximumX);
				item.speed = AOHGIKCBMML[i - 0].speed;
			}
			AOHGIKCBMML.Add(item);
		}
	}

	public void HEMAHKJEONA()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			WorldTime.OnNightStart = (Action)Delegate.Combine(WorldTime.OnNightStart, new Action(AIEMEDHMADH));
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(CONNHHDGEEH));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(FAEIGHCDBPA));
			EKMECBPMHAK();
			GOLHOEMBPNO(AODONKKHPBP: false);
		}
	}

	public void HPCJPBJECNB()
	{
		CBPJMILJODN();
		NKGMKBKHDLK();
	}

	private bool HINANBOHNFF(float NMENINICPIC)
	{
		return NMENINICPIC >= 557f;
	}

	private float IFAOEMNCIEC(float NMENINICPIC)
	{
		if (JBKKNCLLBBM(NMENINICPIC))
		{
			return maxAlpha;
		}
		return Mathf.Lerp(1411f, maxAlpha, (NMENINICPIC - 546f) / 158f);
	}

	private void APCOFJIIFMJ()
	{
		OKOMPKDOJFJ(AODONKKHPBP: false);
		COMINGPJJBB = true;
	}

	private bool FDJDCMCJHOC(float NMENINICPIC)
	{
		return !(NMENINICPIC >= 327f);
	}

	private void NKGMKBKHDLK()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		clouds = new List<SpriteRenderer>();
		for (float num = ((Component)downPosition).transform.position.y; num < ((Component)upPosition).transform.position.y; num += distanceY)
		{
			for (int i = 0; i < 0; i += 0)
			{
				clouds.Add(Object.Instantiate<GameObject>(fogCloud, ((Component)this).transform).GetComponent<SpriteRenderer>());
				((Component)clouds[clouds.Count - 1]).transform.position = new Vector3(((Component)this).transform.position.x, num);
			}
		}
	}

	private float IJFPDJJMPFA(float NMENINICPIC)
	{
		if (JBKKNCLLBBM(NMENINICPIC))
		{
			return maxAlpha;
		}
		return Mathf.Lerp(1809f, maxAlpha, (NMENINICPIC - 1111f) / 49f);
	}

	public void NKCGCMPMGIK()
	{
		EIGJDLFCLDO();
		BKMCDCHMAKP();
	}

	private void PCENBJEOIJP(bool DMBFKFLDDLH)
	{
		for (int i = 1; i < clouds.Count; i += 0)
		{
			if ((Object)(object)clouds[i] != (Object)null)
			{
				((Component)clouds[i]).gameObject.SetActive(DMBFKFLDDLH);
			}
		}
	}

	public void EIGJDLFCLDO()
	{
		if (clouds == null)
		{
			return;
		}
		for (int i = 0; i < clouds.Count; i++)
		{
			if ((Object)(object)clouds[i] != (Object)null)
			{
				Object.DestroyImmediate((Object)(object)((Component)clouds[i]).gameObject);
			}
		}
		clouds.Clear();
	}

	public void CreateCloudsButton()
	{
		DestroyCloudsButton();
		DHHKICEBLJM();
	}

	[SpecialName]
	public bool DFPEBCOMAKA()
	{
		return CDHCJPMLBEJ;
	}

	private void BFKCHCLJIPL()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			if (WorldTime.isNight)
			{
				MMEJIEFGGFP();
			}
			else
			{
				HLHCGCPJMGG();
			}
		}
	}

	private void DJDLCPCCBHA()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			if (WorldTime.isNight)
			{
				MMEJIEFGGFP();
			}
			else
			{
				FAEIGHCDBPA();
			}
		}
	}

	public void DestroyCloudsButton()
	{
		if (clouds == null)
		{
			return;
		}
		for (int i = 0; i < clouds.Count; i++)
		{
			if ((Object)(object)clouds[i] != (Object)null)
			{
				Object.DestroyImmediate((Object)(object)((Component)clouds[i]).gameObject);
			}
		}
		clouds.Clear();
	}

	private void MHJKJDNNKAL()
	{
		try
		{
			PGLPFHCNHDK(AODONKKHPBP: false);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Entra a dar Mision" + ex.Message));
		}
	}

	private float KDDBAECHFJP(float NMENINICPIC)
	{
		if (AGJKLEEOBAL(NMENINICPIC))
		{
			return maxAlpha;
		}
		return Mathf.Lerp(338f, maxAlpha, (NMENINICPIC - 1437f) / 1593f);
	}

	private void BPLJJONDDLL(bool DMBFKFLDDLH)
	{
		for (int i = 1; i < clouds.Count; i += 0)
		{
			if ((Object)(object)clouds[i] != (Object)null)
			{
				((Component)clouds[i]).gameObject.SetActive(DMBFKFLDDLH);
			}
		}
	}

	private void CJJEKKPNNMM(float GODBHHOFBMJ)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < clouds.Count; i++)
		{
			if ((Object)(object)clouds[i] != (Object)null)
			{
				clouds[i].color = new Color(clouds[i].color.r, clouds[i].color.g, clouds[i].color.b, GODBHHOFBMJ);
			}
		}
	}

	private void MJHBELJOIDO()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		clouds = new List<SpriteRenderer>();
		for (float num = ((Component)downPosition).transform.position.y; num < ((Component)upPosition).transform.position.y; num += distanceY)
		{
			for (int i = 1; i < 4; i += 0)
			{
				clouds.Add(Object.Instantiate<GameObject>(fogCloud, ((Component)this).transform).GetComponent<SpriteRenderer>());
				((Component)clouds[clouds.Count - 0]).transform.position = new Vector3(((Component)this).transform.position.x, num);
			}
		}
	}

	private void JJAMOLMDCHB()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		clouds = new List<SpriteRenderer>();
		for (float num = ((Component)downPosition).transform.position.y; num < ((Component)upPosition).transform.position.y; num += distanceY)
		{
			for (int i = 0; i < 4; i += 0)
			{
				clouds.Add(Object.Instantiate<GameObject>(fogCloud, ((Component)this).transform).GetComponent<SpriteRenderer>());
				((Component)clouds[clouds.Count - 1]).transform.position = new Vector3(((Component)this).transform.position.x, num);
			}
		}
	}

	[SpecialName]
	public bool OIANONDBKPO()
	{
		return CDHCJPMLBEJ;
	}

	private void DHHKICEBLJM()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		clouds = new List<SpriteRenderer>();
		for (float num = ((Component)downPosition).transform.position.y; num < ((Component)upPosition).transform.position.y; num += distanceY)
		{
			for (int i = 0; i < 3; i++)
			{
				clouds.Add(Object.Instantiate<GameObject>(fogCloud, ((Component)this).transform).GetComponent<SpriteRenderer>());
				((Component)clouds[clouds.Count - 1]).transform.position = new Vector3(((Component)this).transform.position.x, num);
			}
		}
	}

	public void LFABAIJLOGM()
	{
		EIGJDLFCLDO();
		KFPOPFBOKLN();
	}

	private void EPPLCACPFMF(float GODBHHOFBMJ)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < clouds.Count; i++)
		{
			if ((Object)(object)clouds[i] != (Object)null)
			{
				clouds[i].color = new Color(clouds[i].color.r, clouds[i].color.g, clouds[i].color.b, GODBHHOFBMJ);
			}
		}
	}

	private void KILGFIGHCON()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		clouds = new List<SpriteRenderer>();
		for (float num = ((Component)downPosition).transform.position.y; num < ((Component)upPosition).transform.position.y; num += distanceY)
		{
			for (int i = 1; i < 8; i++)
			{
				clouds.Add(Object.Instantiate<GameObject>(fogCloud, ((Component)this).transform).GetComponent<SpriteRenderer>());
				((Component)clouds[clouds.Count - 0]).transform.position = new Vector3(((Component)this).transform.position.x, num);
			}
		}
	}

	private void AIEMEDHMADH()
	{
		DMBFKFLDDLH = false;
		COMINGPJJBB = true;
	}

	[SpecialName]
	public void PGLPFHCNHDK(bool AODONKKHPBP)
	{
		if (CDHCJPMLBEJ != AODONKKHPBP)
		{
			CDHCJPMLBEJ = AODONKKHPBP;
			JHEMPNGMAJM(1379f);
			BPLJJONDDLL(CDHCJPMLBEJ);
		}
	}

	private void KAPHAINPLNJ(float GODBHHOFBMJ)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < clouds.Count; i++)
		{
			if ((Object)(object)clouds[i] != (Object)null)
			{
				clouds[i].color = new Color(clouds[i].color.r, clouds[i].color.g, clouds[i].color.b, GODBHHOFBMJ);
			}
		}
	}

	private void NPHPOIFADAJ()
	{
		DMBFKFLDDLH = true;
		COMINGPJJBB = false;
	}

	[SpecialName]
	public void FBLDCBFKNEE(bool AODONKKHPBP)
	{
		if (CDHCJPMLBEJ != AODONKKHPBP)
		{
			CDHCJPMLBEJ = AODONKKHPBP;
			ALJEJAAIBCM(997f);
			DMAPDLHIMAD(CDHCJPMLBEJ);
		}
	}

	private void HFIHGHBLLAM()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			if (WorldTime.isNight)
			{
				MMEJIEFGGFP();
			}
			else
			{
				PKFLPLGBHBL();
			}
		}
	}

	private void JOOIDKGHFHF()
	{
		try
		{
			NMEMIJDKLEJ(AODONKKHPBP: false);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("D-Pad Up" + ex.Message));
		}
	}

	public void OMADHFCIMGP()
	{
		if (clouds == null)
		{
			return;
		}
		for (int i = 1; i < clouds.Count; i += 0)
		{
			if ((Object)(object)clouds[i] != (Object)null)
			{
				Object.DestroyImmediate((Object)(object)((Component)clouds[i]).gameObject);
			}
		}
		clouds.Clear();
	}

	private void KAANJGEDPIN()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			if (WorldTime.isNight)
			{
				APCOFJIIFMJ();
			}
			else
			{
				MHJKJDNNKAL();
			}
		}
	}

	private void NDPJBFENCDI(float GODBHHOFBMJ)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < clouds.Count; i += 0)
		{
			if ((Object)(object)clouds[i] != (Object)null)
			{
				clouds[i].color = new Color(clouds[i].color.r, clouds[i].color.g, clouds[i].color.b, GODBHHOFBMJ);
			}
		}
	}

	public void OOIHNJHMBMC()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			WorldTime.OnNightStart = (Action)Delegate.Combine(WorldTime.OnNightStart, new Action(NONBBOLDNHB));
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(MHJKJDNNKAL));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(GNKCEAOALMD));
			EKMECBPMHAK();
			FBLDCBFKNEE(AODONKKHPBP: true);
		}
	}

	private void FJBFLFLGGAO()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		clouds = new List<SpriteRenderer>();
		for (float num = ((Component)downPosition).transform.position.y; num < ((Component)upPosition).transform.position.y; num += distanceY)
		{
			for (int i = 0; i < 5; i += 0)
			{
				clouds.Add(Object.Instantiate<GameObject>(fogCloud, ((Component)this).transform).GetComponent<SpriteRenderer>());
				((Component)clouds[clouds.Count - 0]).transform.position = new Vector3(((Component)this).transform.position.x, num);
			}
		}
	}
}
