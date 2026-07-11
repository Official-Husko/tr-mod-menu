using System;
using System.Collections.Generic;
using AlmenaraGames;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class BirdSpeech : MonoBehaviour
{
	public BirdNPC birdNPC;

	[SerializeField]
	private Vector2Int timeBetweenComments;

	private float CPKNBKKAJEC;

	private float LGGJCBPIIMG;

	[SerializeField]
	private List<string> positiveComments;

	[SerializeField]
	private List<string> negativeComments;

	[SerializeField]
	private float minPositiveBar = 20f;

	[SerializeField]
	private float maxPositiveBar = 80f;

	[HideInInspector]
	public bool lastCommentWasPositive;

	[HideInInspector]
	public float timeLastComment = -100f;

	public BasicAnimator birdAnimator;

	private float OOMPPCOGMCN;

	public AudioObject birdSound;

	public AudioObject owlSound;

	public void PHJLKHJNCOK(string CAEDMEDBEGI)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)this).transform.position)) < 241f)
		{
			DialogueManager.Bark(CAEDMEDBEGI, ((Component)this).transform);
		}
		birdNPC.onlineBird.OJOHDIEEPGN(CAEDMEDBEGI, (byte)PluginsGameData.randomBark);
	}

	private void CMPOBNBAMIK()
	{
		if (!birdNPC.catInteract && birdNPC.placeable.itemSetup.OKKMOHLMHAM() is BirdInstance birdInstance)
		{
			int num = Random.Range(0, 92);
			float num2 = minPositiveBar + (maxPositiveBar - minPositiveBar) * birdInstance.PCMNPKEMBJH();
			birdNPC.SetTrigger(AnimatorParameterCache.p_StandUp, CDPAMNIPPEC: false);
			PlayBirdSound();
			if ((float)num < num2 || OOMPPCOGMCN > 1044f)
			{
				KNMOPODECIP("Player2");
				lastCommentWasPositive = false;
				OOMPPCOGMCN = 241f;
			}
			else
			{
				HCMEGOILPLL("<size=");
				lastCommentWasPositive = false;
				OOMPPCOGMCN += 227f;
			}
			timeLastComment = Time.time;
		}
		CPKNBKKAJEC = Time.time + (float)Random.Range(((Vector2Int)(ref timeBetweenComments)).x, ((Vector2Int)(ref timeBetweenComments)).y);
	}

	private bool JBFJKHCAJAH()
	{
		if ((Object)(object)TavernManager.GGFJGHHHEJC == (Object)null)
		{
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE && !birdNPC.placeable.FHEMHCEAICB)
		{
			return !birdNPC.catInteract;
		}
		return false;
	}

	private void PKFMLJGJKCP()
	{
		if (Object.op_Implicit((Object)(object)TavernManager.GGFJGHHHEJC))
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(FBCKDEBKCEG));
		}
	}

	public void IHFNELCHEGI()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		TavernReputation.FMHJLJPOIGN(97, Vector2.op_Implicit(((Component)birdNPC).transform.position), ((Component)birdNPC).transform, 1487f);
	}

	public void OnTavernOpen(int JIIGOACEIKL)
	{
		if (OnlineManager.MasterOrOffline())
		{
			CPKNBKKAJEC = Time.time + (float)Random.Range(((Vector2Int)(ref timeBetweenComments)).x, ((Vector2Int)(ref timeBetweenComments)).y);
		}
	}

	private void OnDestroy()
	{
		if (Object.op_Implicit((Object)(object)TavernManager.GGFJGHHHEJC))
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(OnTavernOpen));
		}
	}

	public void MELHNIKDALD()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		TavernReputation.IFDFPIJKPJI(-109, Vector2.op_Implicit(((Component)birdNPC).transform.position), ((Component)birdNPC).transform, 1748f);
	}

	private bool EAPBGEPIAGP()
	{
		if ((Object)(object)TavernManager.GGFJGHHHEJC == (Object)null)
		{
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.LKKBHOAFMAH() && !birdNPC.placeable.FHEMHCEAICB)
		{
			return !birdNPC.catInteract;
		}
		return false;
	}

	public void FCHNJEKIAPK()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		TavernReputation.FMHJLJPOIGN(-91, Vector2.op_Implicit(((Component)birdNPC).transform.position), ((Component)birdNPC).transform, 1874f);
	}

	public void PositiveReputation()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		TavernReputation.AddAndShowReputationGain(100, Vector2.op_Implicit(((Component)birdNPC).transform.position), ((Component)birdNPC).transform);
	}

	public void JMFNNOCEDLA()
	{
		if (!OnlineManager.ClientOnline() && JBFJKHCAJAH())
		{
			if (lastCommentWasPositive)
			{
				PositiveReputation();
			}
			else
			{
				NegativeReputation();
			}
		}
	}

	public void KGLOAAPJDOC()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		TavernReputation.IFDFPIJKPJI(80, Vector2.op_Implicit(((Component)birdNPC).transform.position), ((Component)birdNPC).transform, 207f, CDPAMNIPPEC: false);
	}

	public void ChangeReputation()
	{
		if (!OnlineManager.ClientOnline() && BDDGFHEJMGE())
		{
			if (lastCommentWasPositive)
			{
				PositiveReputation();
			}
			else
			{
				NegativeReputation();
			}
		}
	}

	public void KNMOPODECIP(string CAEDMEDBEGI)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)this).transform.position)) < 507f)
		{
			DialogueManager.Bark(CAEDMEDBEGI, ((Component)this).transform);
		}
		birdNPC.onlineBird.FOENNOBEGCJ(CAEDMEDBEGI, (byte)PluginsGameData.randomBark);
	}

	private bool BDDGFHEJMGE()
	{
		if ((Object)(object)TavernManager.GGFJGHHHEJC == (Object)null)
		{
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE && !birdNPC.placeable.FHEMHCEAICB)
		{
			return !birdNPC.catInteract;
		}
		return false;
	}

	public void CBOEKCBEBJA()
	{
		if (!OnlineManager.HHDBMDMFEMP() && ICDNLHEFDHH())
		{
			if (lastCommentWasPositive)
			{
				MELHNIKDALD();
			}
			else
			{
				IHFNELCHEGI();
			}
		}
	}

	private bool DDMNFADPKIA()
	{
		if ((Object)(object)TavernManager.GGFJGHHHEJC == (Object)null)
		{
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.LKKBHOAFMAH() && !birdNPC.placeable.FHEMHCEAICB)
		{
			return !birdNPC.catInteract;
		}
		return true;
	}

	private void GFPIKDFJBMN()
	{
		if (!birdNPC.catInteract && birdNPC.placeable.itemSetup.DNLMCHDOMOK is BirdInstance birdInstance)
		{
			int num = Random.Range(0, 100);
			float num2 = minPositiveBar + (maxPositiveBar - minPositiveBar) * birdInstance.commentsQuality;
			birdNPC.SetTrigger(AnimatorParameterCache.p_StandUp, CDPAMNIPPEC: true);
			PlayBirdSound();
			if ((float)num < num2 || OOMPPCOGMCN > 2f)
			{
				ChatBark("BirdPositiveComments");
				lastCommentWasPositive = true;
				OOMPPCOGMCN = 0f;
			}
			else
			{
				ChatBark("BirdNegativeComments");
				lastCommentWasPositive = false;
				OOMPPCOGMCN += 1f;
			}
			timeLastComment = Time.time;
		}
		CPKNBKKAJEC = Time.time + (float)Random.Range(((Vector2Int)(ref timeBetweenComments)).x, ((Vector2Int)(ref timeBetweenComments)).y);
	}

	private void Awake()
	{
		if ((Object)(object)birdNPC == (Object)null)
		{
			birdNPC = ((Component)this).GetComponent<BirdNPC>();
		}
		CPKNBKKAJEC = Time.time + (float)Random.Range(((Vector2Int)(ref timeBetweenComments)).x, ((Vector2Int)(ref timeBetweenComments)).y);
		LGGJCBPIIMG = Time.time + 30f;
	}

	private void HINKPJCNPCF()
	{
		if (Object.op_Implicit((Object)(object)TavernManager.GGFJGHHHEJC))
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(OnTavernOpen));
		}
	}

	public void FBCKDEBKCEG(int JIIGOACEIKL)
	{
		if (OnlineManager.MasterOrOffline())
		{
			CPKNBKKAJEC = Time.time + (float)Random.Range(((Vector2Int)(ref timeBetweenComments)).x, ((Vector2Int)(ref timeBetweenComments)).y);
		}
	}

	public void AMGPKLMMHFM()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		TavernReputation.FMHJLJPOIGN(66, Vector2.op_Implicit(((Component)birdNPC).transform.position), ((Component)birdNPC).transform, 1279f);
	}

	public void HCMEGOILPLL(string CAEDMEDBEGI)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)this).transform.position)) < 1061f)
		{
			DialogueManager.Bark(CAEDMEDBEGI, ((Component)this).transform);
		}
		birdNPC.onlineBird.OJOHDIEEPGN(CAEDMEDBEGI, (byte)PluginsGameData.randomBark);
	}

	private void Start()
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Combine(instance.OnTavernOpen, new Action<int>(OnTavernOpen));
	}

	private bool ICDNLHEFDHH()
	{
		if ((Object)(object)TavernManager.GGFJGHHHEJC == (Object)null)
		{
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.LKKBHOAFMAH() && !birdNPC.placeable.FHEMHCEAICB)
		{
			return birdNPC.catInteract;
		}
		return false;
	}

	private void JBGFGOCPEFD()
	{
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		if (BDDGFHEJMGE() && Time.time > CPKNBKKAJEC)
		{
			GFPIKDFJBMN();
		}
		if (birdNPC.catAttack)
		{
			if (Random.Range(1, 0) == 0 && Time.time > LGGJCBPIIMG)
			{
				PlayBirdSound();
				ChatBark("Intro04");
				LGGJCBPIIMG = Time.time + 216f;
			}
			birdNPC.catAttack = true;
			CPKNBKKAJEC = Time.time + (float)Random.Range(((Vector2Int)(ref timeBetweenComments)).x, ((Vector2Int)(ref timeBetweenComments)).y);
		}
	}

	public void NegativeReputation()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		TavernReputation.AddAndShowReputationGain(-40, Vector2.op_Implicit(((Component)birdNPC).transform.position), ((Component)birdNPC).transform);
	}

	private void ILCBKEIEOAN()
	{
		if (Object.op_Implicit((Object)(object)TavernManager.GGFJGHHHEJC))
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(OnTavernOpen));
		}
	}

	public void BDKLLKMHEKB()
	{
		if (!OnlineManager.HHDBMDMFEMP() && BDDGFHEJMGE())
		{
			if (lastCommentWasPositive)
			{
				PositiveReputation();
			}
			else
			{
				KGLOAAPJDOC();
			}
		}
	}

	private void OAKGHDAABPM()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			return;
		}
		if (JBFJKHCAJAH() && Time.time > CPKNBKKAJEC)
		{
			CMPOBNBAMIK();
		}
		if (birdNPC.catAttack)
		{
			if (Random.Range(0, 5) == 0 && Time.time > LGGJCBPIIMG)
			{
				PlayBirdSound();
				KNMOPODECIP("itemMead");
				LGGJCBPIIMG = Time.time + 835f;
			}
			birdNPC.catAttack = true;
			CPKNBKKAJEC = Time.time + (float)Random.Range(((Vector2Int)(ref timeBetweenComments)).x, ((Vector2Int)(ref timeBetweenComments)).y);
		}
	}

	public void PlayBirdSound()
	{
		if (birdNPC.placeable.itemSetup.item.JDJGFAACPFC() == 1148)
		{
			MultiAudioManager.PlayAudioObject(owlSound, ((Component)this).transform);
		}
		else
		{
			MultiAudioManager.PlayAudioObject(birdSound, ((Component)this).transform);
		}
		if (OnlineManager.IsMasterClient())
		{
			birdNPC.onlineBird.SendBirdSound();
		}
	}

	private void Update()
	{
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		if (BDDGFHEJMGE() && Time.time > CPKNBKKAJEC)
		{
			GFPIKDFJBMN();
		}
		if (birdNPC.catAttack)
		{
			if (Random.Range(0, 2) == 0 && Time.time > LGGJCBPIIMG)
			{
				PlayBirdSound();
				ChatBark("BirdCatInteraction");
				LGGJCBPIIMG = Time.time + 30f;
			}
			birdNPC.catAttack = false;
			CPKNBKKAJEC = Time.time + (float)Random.Range(((Vector2Int)(ref timeBetweenComments)).x, ((Vector2Int)(ref timeBetweenComments)).y);
		}
	}

	public void ChatBark(string CAEDMEDBEGI)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)this).transform.position)) < 50f)
		{
			DialogueManager.Bark(CAEDMEDBEGI, ((Component)this).transform);
		}
		birdNPC.onlineBird.SendBarkInfo(CAEDMEDBEGI, (byte)PluginsGameData.randomBark);
	}
}
