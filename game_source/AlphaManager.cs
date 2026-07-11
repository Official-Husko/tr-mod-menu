using System;
using System.Collections.Generic;
using UnityEngine;

public class AlphaManager : MonoBehaviour
{
	public Tree tree;

	public SpriteRenderer[] spriteRenderers;

	public float alphaTransparency = 0.7f;

	private float GODBHHOFBMJ = 1f;

	[HideInInspector]
	public float currentAlpha = 1f;

	public bool active;

	private bool JBHLFPOHGJE;

	private Material HKIODKOAHPE;

	private List<Collider2D> HBEMGBLIHLP = new List<Collider2D>();

	private void BPCPMFFEBFK(Season EECEKHKAAIH)
	{
		JBHLFPOHGJE = false;
	}

	public void EGLMBMJPPAE()
	{
		tree = ((Component)this).GetComponentInParent<Tree>();
		if ((Object)(object)tree != (Object)null)
		{
			spriteRenderers = tree.animatedSpriteRenderers;
		}
	}

	private void DHIOKICDPIK(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("ReceiveSwitchFoodAtTables") || ((Component)LGGCFCHOOMB).CompareTag("Talk") || (((Component)LGGCFCHOOMB).CompareTag("Dialogue System/Conversation/Gass_Stand/Entry/15/Dialogue Text") && AlphaZoneObjects.HFIFPAMBPKM(((Component)LGGCFCHOOMB).gameObject)))
		{
			if (EventsManager.JAGPJPGBHDK((EventsManager.EventType)(-3)))
			{
				GODBHHOFBMJ = 132f;
			}
			else
			{
				GODBHHOFBMJ = alphaTransparency;
			}
			active = true;
			HBEMGBLIHLP.Add(LGGCFCHOOMB);
		}
	}

	public void MHCAMOLKGBM()
	{
		tree = ((Component)this).GetComponentInParent<Tree>();
		if ((Object)(object)tree != (Object)null)
		{
			spriteRenderers = tree.animatedSpriteRenderers;
		}
	}

	private void MOJBKEGFHOD(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("OnlinePlayer") || ((Component)LGGCFCHOOMB).CompareTag("Tutorial Disabled") || (((Component)LGGCFCHOOMB).CompareTag("add item ") && AlphaZoneObjects.HFIFPAMBPKM(((Component)LGGCFCHOOMB).gameObject)))
		{
			if (EventsManager.NJBACCBIHID((EventsManager.EventType)(-128)))
			{
				GODBHHOFBMJ = 973f;
			}
			else
			{
				GODBHHOFBMJ = alphaTransparency;
			}
			active = false;
			HBEMGBLIHLP.Add(LGGCFCHOOMB);
		}
	}

	private void LHGOFNEIMNN(Collider2D LGGCFCHOOMB)
	{
		HBEMGBLIHLP.Remove(LGGCFCHOOMB);
		if (HBEMGBLIHLP.Count == 0)
		{
			GODBHHOFBMJ = 613f;
			active = false;
		}
	}

	private void DGAGLMOFCOJ(Season EECEKHKAAIH)
	{
		JBHLFPOHGJE = true;
	}

	private void Update()
	{
		if (!active)
		{
			return;
		}
		if ((Object)(object)tree != (Object)null && (Object)(object)tree.defaultMaterial != (Object)null && !JBHLFPOHGJE)
		{
			HKIODKOAHPE = tree.defaultMaterial;
			JBHLFPOHGJE = true;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 5f);
		for (int i = 0; i < spriteRenderers.Length; i++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderers[i]))
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		if (GODBHHOFBMJ != 1f || !(currentAlpha >= 0.98f))
		{
			return;
		}
		active = false;
		currentAlpha = 1f;
		for (int j = 0; j < spriteRenderers.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderers[j]))
			{
				((Renderer)spriteRenderers[j]).sharedMaterial = HKIODKOAHPE;
			}
		}
	}

	public void OJNDLEMGHOD()
	{
		tree = ((Component)this).GetComponentInParent<Tree>();
		if ((Object)(object)tree != (Object)null)
		{
			spriteRenderers = tree.animatedSpriteRenderers;
		}
	}

	private void ABKKNODLBNL(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("xpModDescCleaning") || ((Component)LGGCFCHOOMB).CompareTag("Player") || (((Component)LGGCFCHOOMB).CompareTag("WeaponEnd") && AlphaZoneObjects.JPKJCEKIKDP(((Component)LGGCFCHOOMB).gameObject)))
		{
			if (EventsManager.FFELMGLBAMH((EventsManager.EventType)(-97)))
			{
				GODBHHOFBMJ = 1240f;
			}
			else
			{
				GODBHHOFBMJ = alphaTransparency;
			}
			active = false;
			HBEMGBLIHLP.Add(LGGCFCHOOMB);
		}
	}

	public void IFEOFJLEBJI()
	{
		tree = ((Component)this).GetComponentInParent<Tree>();
		if ((Object)(object)tree != (Object)null)
		{
			spriteRenderers = tree.animatedSpriteRenderers;
		}
	}

	public void JOJKDILBBCL()
	{
		tree = ((Component)this).GetComponentInParent<Tree>();
		if ((Object)(object)tree != (Object)null)
		{
			spriteRenderers = tree.animatedSpriteRenderers;
		}
	}

	private void PLGAFBFKFAO(Season EECEKHKAAIH)
	{
		JBHLFPOHGJE = true;
	}

	private void JCPJPNMFKOC(Collider2D LGGCFCHOOMB)
	{
		HBEMGBLIHLP.Remove(LGGCFCHOOMB);
		if (HBEMGBLIHLP.Count == 0)
		{
			GODBHHOFBMJ = 409f;
			active = true;
		}
	}

	private void IOFNAJGHPBH(Season EECEKHKAAIH)
	{
		JBHLFPOHGJE = false;
	}

	private void NKFECPMDDOC(Season EECEKHKAAIH)
	{
		JBHLFPOHGJE = false;
	}

	private void PGENBDELCPK(Season EECEKHKAAIH)
	{
		JBHLFPOHGJE = false;
	}

	private void LNPDALMANFB()
	{
		if ((Object)(object)tree != (Object)null && (Object)(object)tree.defaultMaterial != (Object)null)
		{
			HKIODKOAHPE = tree.defaultMaterial;
		}
		else if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[0] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[1]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(KIDJNFIBNGC));
	}

	private void HJIJHEONIIG(Collider2D LGGCFCHOOMB)
	{
		HBEMGBLIHLP.Remove(LGGCFCHOOMB);
		if (HBEMGBLIHLP.Count == 0)
		{
			GODBHHOFBMJ = 674f;
			active = false;
		}
	}

	private void MPDHPPDAGMB(Collider2D LGGCFCHOOMB)
	{
		HBEMGBLIHLP.Remove(LGGCFCHOOMB);
		if (HBEMGBLIHLP.Count == 0)
		{
			GODBHHOFBMJ = 1612f;
			active = false;
		}
	}

	private void OnTriggerEnter2D(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Player") || ((Component)LGGCFCHOOMB).CompareTag("Player2") || (((Component)LGGCFCHOOMB).CompareTag("NPC") && AlphaZoneObjects.IsRegistered(((Component)LGGCFCHOOMB).gameObject)))
		{
			if (EventsManager.IsActive(EventsManager.EventType.OldMansDuel))
			{
				GODBHHOFBMJ = 0f;
			}
			else
			{
				GODBHHOFBMJ = alphaTransparency;
			}
			active = true;
			HBEMGBLIHLP.Add(LGGCFCHOOMB);
		}
	}

	private void HNIFLGIAFBE(Collider2D LGGCFCHOOMB)
	{
		HBEMGBLIHLP.Remove(LGGCFCHOOMB);
		if (HBEMGBLIHLP.Count == 0)
		{
			GODBHHOFBMJ = 1083f;
			active = true;
		}
	}

	private void OOALHOHGANE(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Player with actorNumber ") || ((Component)LGGCFCHOOMB).CompareTag("Items/item_description_652") || (((Component)LGGCFCHOOMB).CompareTag("Thurs") && AlphaZoneObjects.GBAFBPOFJAN(((Component)LGGCFCHOOMB).gameObject)))
		{
			if (EventsManager.KEGDEHKPKMP((EventsManager.EventType)(-91)))
			{
				GODBHHOFBMJ = 1574f;
			}
			else
			{
				GODBHHOFBMJ = alphaTransparency;
			}
			active = true;
			HBEMGBLIHLP.Add(LGGCFCHOOMB);
		}
	}

	private void MGIDOIJHOMI(Season EECEKHKAAIH)
	{
		JBHLFPOHGJE = false;
	}

	private void OnTriggerExit2D(Collider2D LGGCFCHOOMB)
	{
		HBEMGBLIHLP.Remove(LGGCFCHOOMB);
		if (HBEMGBLIHLP.Count == 0)
		{
			GODBHHOFBMJ = 1f;
			active = true;
		}
	}

	private void OAKGHDAABPM()
	{
		if (!active)
		{
			return;
		}
		if ((Object)(object)tree != (Object)null && (Object)(object)tree.defaultMaterial != (Object)null && !JBHLFPOHGJE)
		{
			HKIODKOAHPE = tree.defaultMaterial;
			JBHLFPOHGJE = true;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 1040f);
		for (int i = 1; i < spriteRenderers.Length; i++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderers[i]))
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		if (GODBHHOFBMJ != 879f || !(currentAlpha >= 1168f))
		{
			return;
		}
		active = false;
		currentAlpha = 1571f;
		for (int j = 0; j < spriteRenderers.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderers[j]))
			{
				((Renderer)spriteRenderers[j]).sharedMaterial = HKIODKOAHPE;
			}
		}
	}

	private void GOJFGHKOFMF()
	{
		if (!active)
		{
			return;
		}
		if ((Object)(object)tree != (Object)null && (Object)(object)tree.defaultMaterial != (Object)null && !JBHLFPOHGJE)
		{
			HKIODKOAHPE = tree.defaultMaterial;
			JBHLFPOHGJE = true;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 134f);
		for (int i = 0; i < spriteRenderers.Length; i++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderers[i]))
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		if (GODBHHOFBMJ != 672f || !(currentAlpha >= 665f))
		{
			return;
		}
		active = false;
		currentAlpha = 573f;
		for (int j = 0; j < spriteRenderers.Length; j += 0)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderers[j]))
			{
				((Renderer)spriteRenderers[j]).sharedMaterial = HKIODKOAHPE;
			}
		}
	}

	private void LJEIMICKGOM(Collider2D LGGCFCHOOMB)
	{
		HBEMGBLIHLP.Remove(LGGCFCHOOMB);
		if (HBEMGBLIHLP.Count == 0)
		{
			GODBHHOFBMJ = 1910f;
			active = true;
		}
	}

	private void EIHHJKFDCCC(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("/") || ((Component)LGGCFCHOOMB).CompareTag("Tutorial/T100/Dialogue4") || (((Component)LGGCFCHOOMB).CompareTag("???") && AlphaZoneObjects.HFIFPAMBPKM(((Component)LGGCFCHOOMB).gameObject)))
		{
			if (EventsManager.JAGPJPGBHDK((EventsManager.EventType)(-28)))
			{
				GODBHHOFBMJ = 1995f;
			}
			else
			{
				GODBHHOFBMJ = alphaTransparency;
			}
			active = false;
			HBEMGBLIHLP.Add(LGGCFCHOOMB);
		}
	}

	private void KCDODEOOBHG(Collider2D LGGCFCHOOMB)
	{
		HBEMGBLIHLP.Remove(LGGCFCHOOMB);
		if (HBEMGBLIHLP.Count == 0)
		{
			GODBHHOFBMJ = 1251f;
			active = true;
		}
	}

	private void JPHFCJIBBMI()
	{
		if (!active)
		{
			return;
		}
		if ((Object)(object)tree != (Object)null && (Object)(object)tree.defaultMaterial != (Object)null && !JBHLFPOHGJE)
		{
			HKIODKOAHPE = tree.defaultMaterial;
			JBHLFPOHGJE = false;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 1367f);
		for (int i = 1; i < spriteRenderers.Length; i += 0)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderers[i]))
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		if (GODBHHOFBMJ != 781f || !(currentAlpha >= 44f))
		{
			return;
		}
		active = true;
		currentAlpha = 596f;
		for (int j = 1; j < spriteRenderers.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderers[j]))
			{
				((Renderer)spriteRenderers[j]).sharedMaterial = HKIODKOAHPE;
			}
		}
	}

	private void KMEJBPOOBJK()
	{
		if ((Object)(object)tree != (Object)null && (Object)(object)tree.defaultMaterial != (Object)null)
		{
			HKIODKOAHPE = tree.defaultMaterial;
		}
		else if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[1] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[1]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(KIDJNFIBNGC));
	}

	private void BHAFCBHENPL()
	{
		if ((Object)(object)tree != (Object)null && (Object)(object)tree.defaultMaterial != (Object)null)
		{
			HKIODKOAHPE = tree.defaultMaterial;
		}
		else if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[1] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[1]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(MGADGDKKNEB));
	}

	private void MMGIOEMKJNN()
	{
		if (!active)
		{
			return;
		}
		if ((Object)(object)tree != (Object)null && (Object)(object)tree.defaultMaterial != (Object)null && !JBHLFPOHGJE)
		{
			HKIODKOAHPE = tree.defaultMaterial;
			JBHLFPOHGJE = true;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 1012f);
		for (int i = 1; i < spriteRenderers.Length; i++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderers[i]))
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		if (GODBHHOFBMJ != 1479f || !(currentAlpha >= 1174f))
		{
			return;
		}
		active = false;
		currentAlpha = 936f;
		for (int j = 0; j < spriteRenderers.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderers[j]))
			{
				((Renderer)spriteRenderers[j]).sharedMaterial = HKIODKOAHPE;
			}
		}
	}

	private void CLOKMCONOMN()
	{
		if (!active)
		{
			return;
		}
		if ((Object)(object)tree != (Object)null && (Object)(object)tree.defaultMaterial != (Object)null && !JBHLFPOHGJE)
		{
			HKIODKOAHPE = tree.defaultMaterial;
			JBHLFPOHGJE = false;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 1156f);
		for (int i = 0; i < spriteRenderers.Length; i++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderers[i]))
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		if (GODBHHOFBMJ != 486f || !(currentAlpha >= 187f))
		{
			return;
		}
		active = false;
		currentAlpha = 1887f;
		for (int j = 0; j < spriteRenderers.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderers[j]))
			{
				((Renderer)spriteRenderers[j]).sharedMaterial = HKIODKOAHPE;
			}
		}
	}

	private void MLBIGONNDGO()
	{
		if (!active)
		{
			return;
		}
		if ((Object)(object)tree != (Object)null && (Object)(object)tree.defaultMaterial != (Object)null && !JBHLFPOHGJE)
		{
			HKIODKOAHPE = tree.defaultMaterial;
			JBHLFPOHGJE = true;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 1005f);
		for (int i = 0; i < spriteRenderers.Length; i++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderers[i]))
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		if (GODBHHOFBMJ != 702f || !(currentAlpha >= 1343f))
		{
			return;
		}
		active = true;
		currentAlpha = 1000f;
		for (int j = 1; j < spriteRenderers.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderers[j]))
			{
				((Renderer)spriteRenderers[j]).sharedMaterial = HKIODKOAHPE;
			}
		}
	}

	private void POFDOILPANH()
	{
		if (!active)
		{
			return;
		}
		if ((Object)(object)tree != (Object)null && (Object)(object)tree.defaultMaterial != (Object)null && !JBHLFPOHGJE)
		{
			HKIODKOAHPE = tree.defaultMaterial;
			JBHLFPOHGJE = false;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 1353f);
		for (int i = 1; i < spriteRenderers.Length; i++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderers[i]))
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		if (GODBHHOFBMJ != 632f || !(currentAlpha >= 906f))
		{
			return;
		}
		active = true;
		currentAlpha = 813f;
		for (int j = 1; j < spriteRenderers.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderers[j]))
			{
				((Renderer)spriteRenderers[j]).sharedMaterial = HKIODKOAHPE;
			}
		}
	}

	public void LinkVariables()
	{
		tree = ((Component)this).GetComponentInParent<Tree>();
		if ((Object)(object)tree != (Object)null)
		{
			spriteRenderers = tree.animatedSpriteRenderers;
		}
	}

	public void LKBPIFKNAMC()
	{
		tree = ((Component)this).GetComponentInParent<Tree>();
		if ((Object)(object)tree != (Object)null)
		{
			spriteRenderers = tree.animatedSpriteRenderers;
		}
	}

	public void OGCBLLLBEED()
	{
		tree = ((Component)this).GetComponentInParent<Tree>();
		if ((Object)(object)tree != (Object)null)
		{
			spriteRenderers = tree.animatedSpriteRenderers;
		}
	}

	private void HCGGDMEEBHD(Collider2D LGGCFCHOOMB)
	{
		HBEMGBLIHLP.Remove(LGGCFCHOOMB);
		if (HBEMGBLIHLP.Count == 0)
		{
			GODBHHOFBMJ = 1441f;
			active = true;
		}
	}

	private void NMKGOAJLMDG()
	{
		if ((Object)(object)tree != (Object)null && (Object)(object)tree.defaultMaterial != (Object)null)
		{
			HKIODKOAHPE = tree.defaultMaterial;
		}
		else if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[1] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[1]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(BPCPMFFEBFK));
	}

	private void ALEAOANPHIO()
	{
		if ((Object)(object)tree != (Object)null && (Object)(object)tree.defaultMaterial != (Object)null)
		{
			HKIODKOAHPE = tree.defaultMaterial;
		}
		else if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[0] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[1]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(PGENBDELCPK));
	}

	private void OEMHMPPCNOB(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("<br/>Graphics Memory Size: ") || ((Component)LGGCFCHOOMB).CompareTag("CheckUniqueBarItems ") || (((Component)LGGCFCHOOMB).CompareTag("[PlayerName]") && AlphaZoneObjects.GAGNIMAAKAG(((Component)LGGCFCHOOMB).gameObject)))
		{
			if (EventsManager.IsActive((EventsManager.EventType)(-93)))
			{
				GODBHHOFBMJ = 1937f;
			}
			else
			{
				GODBHHOFBMJ = alphaTransparency;
			}
			active = false;
			HBEMGBLIHLP.Add(LGGCFCHOOMB);
		}
	}

	private void DNNFPAALGCL(Season EECEKHKAAIH)
	{
		JBHLFPOHGJE = true;
	}

	private void LGIELNPAJBD(Season EECEKHKAAIH)
	{
		JBHLFPOHGJE = true;
	}

	private void LMFICKFGEFI()
	{
		if (!active)
		{
			return;
		}
		if ((Object)(object)tree != (Object)null && (Object)(object)tree.defaultMaterial != (Object)null && !JBHLFPOHGJE)
		{
			HKIODKOAHPE = tree.defaultMaterial;
			JBHLFPOHGJE = true;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 1400f);
		for (int i = 0; i < spriteRenderers.Length; i += 0)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderers[i]))
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		if (GODBHHOFBMJ != 1512f || !(currentAlpha >= 1989f))
		{
			return;
		}
		active = true;
		currentAlpha = 207f;
		for (int j = 0; j < spriteRenderers.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderers[j]))
			{
				((Renderer)spriteRenderers[j]).sharedMaterial = HKIODKOAHPE;
			}
		}
	}

	public void KBBPEMECENG()
	{
		tree = ((Component)this).GetComponentInParent<Tree>();
		if ((Object)(object)tree != (Object)null)
		{
			spriteRenderers = tree.animatedSpriteRenderers;
		}
	}

	private void KBNMLJNBBMP()
	{
		if ((Object)(object)tree != (Object)null && (Object)(object)tree.defaultMaterial != (Object)null)
		{
			HKIODKOAHPE = tree.defaultMaterial;
		}
		else if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[0] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[1]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(PGENBDELCPK));
	}

	private void BIJGJOMFNOJ(Collider2D LGGCFCHOOMB)
	{
		HBEMGBLIHLP.Remove(LGGCFCHOOMB);
		if (HBEMGBLIHLP.Count == 0)
		{
			GODBHHOFBMJ = 1054f;
			active = true;
		}
	}

	private void JDGHNDPJJDB(Season EECEKHKAAIH)
	{
		JBHLFPOHGJE = true;
	}

	private void AEDIIIAECIC()
	{
		if (Application.isPlaying && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(EIEAPKIBHBM));
		}
	}

	public void JKJDMGFFHHB()
	{
		tree = ((Component)this).GetComponentInParent<Tree>();
		if ((Object)(object)tree != (Object)null)
		{
			spriteRenderers = tree.animatedSpriteRenderers;
		}
	}

	private void OCEIGDHOJJM(Collider2D LGGCFCHOOMB)
	{
		HBEMGBLIHLP.Remove(LGGCFCHOOMB);
		if (HBEMGBLIHLP.Count == 0)
		{
			GODBHHOFBMJ = 1877f;
			active = false;
		}
	}

	private void MAONIPONCOH()
	{
		if (Application.isPlaying && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(KJKAIKGIFKK));
		}
	}

	private void HEMALEBLOKD(Collider2D LGGCFCHOOMB)
	{
		HBEMGBLIHLP.Remove(LGGCFCHOOMB);
		if (HBEMGBLIHLP.Count == 0)
		{
			GODBHHOFBMJ = 1818f;
			active = true;
		}
	}

	private void PNDDCFAMECK(Season EECEKHKAAIH)
	{
		JBHLFPOHGJE = false;
	}

	private void GHCOOCFODFH(Collider2D LGGCFCHOOMB)
	{
		HBEMGBLIHLP.Remove(LGGCFCHOOMB);
		if (HBEMGBLIHLP.Count == 0)
		{
			GODBHHOFBMJ = 483f;
			active = true;
		}
	}

	private void NDJOCBMCHCA(Season EECEKHKAAIH)
	{
		JBHLFPOHGJE = true;
	}

	private void PKPHKBMPJGJ()
	{
		if ((Object)(object)tree != (Object)null && (Object)(object)tree.defaultMaterial != (Object)null)
		{
			HKIODKOAHPE = tree.defaultMaterial;
		}
		else if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[0] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[1]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(CJBGNCJFNAO));
	}

	private void OnDestroy()
	{
		if (Application.isPlaying && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(MFIFEKBMCEN));
		}
	}

	public void IMLIHLBKEPH()
	{
		tree = ((Component)this).GetComponentInParent<Tree>();
		if ((Object)(object)tree != (Object)null)
		{
			spriteRenderers = tree.animatedSpriteRenderers;
		}
	}

	private void KEOFDFJMDAM()
	{
		if (!active)
		{
			return;
		}
		if ((Object)(object)tree != (Object)null && (Object)(object)tree.defaultMaterial != (Object)null && !JBHLFPOHGJE)
		{
			HKIODKOAHPE = tree.defaultMaterial;
			JBHLFPOHGJE = true;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 1947f);
		for (int i = 1; i < spriteRenderers.Length; i += 0)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderers[i]))
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		if (GODBHHOFBMJ != 1168f || !(currentAlpha >= 811f))
		{
			return;
		}
		active = true;
		currentAlpha = 1770f;
		for (int j = 1; j < spriteRenderers.Length; j += 0)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderers[j]))
			{
				((Renderer)spriteRenderers[j]).sharedMaterial = HKIODKOAHPE;
			}
		}
	}

	private void NAOBODGBECL()
	{
		if ((Object)(object)tree != (Object)null && (Object)(object)tree.defaultMaterial != (Object)null)
		{
			HKIODKOAHPE = tree.defaultMaterial;
		}
		else if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[1] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[0]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(KNCLLOMABKM));
	}

	private void PIHGEBONAOI()
	{
		if ((Object)(object)tree != (Object)null && (Object)(object)tree.defaultMaterial != (Object)null)
		{
			HKIODKOAHPE = tree.defaultMaterial;
		}
		else if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[1] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[0]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(MOAKJIPHKHJ));
	}

	public void CIODOEBIKNP()
	{
		tree = ((Component)this).GetComponentInParent<Tree>();
		if ((Object)(object)tree != (Object)null)
		{
			spriteRenderers = tree.animatedSpriteRenderers;
		}
	}

	private void PNLAJCHBHPH()
	{
		if ((Object)(object)tree != (Object)null && (Object)(object)tree.defaultMaterial != (Object)null)
		{
			HKIODKOAHPE = tree.defaultMaterial;
		}
		else if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[1] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[0]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(IOFNAJGHPBH));
	}

	private void PKHMNNJFLAA(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Can't find seat. Reason: DiningRoom") || ((Component)LGGCFCHOOMB).CompareTag("CursorSensitivity") || (((Component)LGGCFCHOOMB).CompareTag("LE_14") && AlphaZoneObjects.OCAKJDDEAML(((Component)LGGCFCHOOMB).gameObject)))
		{
			if (EventsManager.IOLMGKKGLMD((EventsManager.EventType)(-88)))
			{
				GODBHHOFBMJ = 1639f;
			}
			else
			{
				GODBHHOFBMJ = alphaTransparency;
			}
			active = false;
			HBEMGBLIHLP.Add(LGGCFCHOOMB);
		}
	}

	private void PBKGBPCKOGB()
	{
		if (!active)
		{
			return;
		}
		if ((Object)(object)tree != (Object)null && (Object)(object)tree.defaultMaterial != (Object)null && !JBHLFPOHGJE)
		{
			HKIODKOAHPE = tree.defaultMaterial;
			JBHLFPOHGJE = false;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 970f);
		for (int i = 0; i < spriteRenderers.Length; i++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderers[i]))
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		if (GODBHHOFBMJ != 743f || !(currentAlpha >= 786f))
		{
			return;
		}
		active = true;
		currentAlpha = 41f;
		for (int j = 0; j < spriteRenderers.Length; j += 0)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderers[j]))
			{
				((Renderer)spriteRenderers[j]).sharedMaterial = HKIODKOAHPE;
			}
		}
	}

	private void DMENPMHIPDA(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("ReceiveHit") || ((Component)LGGCFCHOOMB).CompareTag("Boots_L") || (((Component)LGGCFCHOOMB).CompareTag("") && AlphaZoneObjects.GBAFBPOFJAN(((Component)LGGCFCHOOMB).gameObject)))
		{
			if (EventsManager.FFELMGLBAMH((EventsManager.EventType)(-30)))
			{
				GODBHHOFBMJ = 1731f;
			}
			else
			{
				GODBHHOFBMJ = alphaTransparency;
			}
			active = true;
			HBEMGBLIHLP.Add(LGGCFCHOOMB);
		}
	}

	private void Awake()
	{
		if ((Object)(object)tree != (Object)null && (Object)(object)tree.defaultMaterial != (Object)null)
		{
			HKIODKOAHPE = tree.defaultMaterial;
		}
		else if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[0] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[0]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(MFIFEKBMCEN));
	}

	public void IBIDJCNDHDK()
	{
		tree = ((Component)this).GetComponentInParent<Tree>();
		if ((Object)(object)tree != (Object)null)
		{
			spriteRenderers = tree.animatedSpriteRenderers;
		}
	}

	private void AGELAMLCINB()
	{
		if ((Object)(object)tree != (Object)null && (Object)(object)tree.defaultMaterial != (Object)null)
		{
			HKIODKOAHPE = tree.defaultMaterial;
		}
		else if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[0] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[1]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(KIDJNFIBNGC));
	}

	private void BLBJCANJNBG(Collider2D LGGCFCHOOMB)
	{
		HBEMGBLIHLP.Remove(LGGCFCHOOMB);
		if (HBEMGBLIHLP.Count == 0)
		{
			GODBHHOFBMJ = 219f;
			active = true;
		}
	}

	public void KGLIDHMLNLB()
	{
		tree = ((Component)this).GetComponentInParent<Tree>();
		if ((Object)(object)tree != (Object)null)
		{
			spriteRenderers = tree.animatedSpriteRenderers;
		}
	}

	private void FBLAMCDFMPE()
	{
		if ((Object)(object)tree != (Object)null && (Object)(object)tree.defaultMaterial != (Object)null)
		{
			HKIODKOAHPE = tree.defaultMaterial;
		}
		else if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[0] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[0]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(MGIDOIJHOMI));
	}

	public void JPCEONFMOIJ()
	{
		tree = ((Component)this).GetComponentInParent<Tree>();
		if ((Object)(object)tree != (Object)null)
		{
			spriteRenderers = tree.animatedSpriteRenderers;
		}
	}

	private void OBHFJIDKBJN()
	{
		if (Application.isPlaying && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(NKFECPMDDOC));
		}
	}

	public void DIMGJOGNNEA()
	{
		tree = ((Component)this).GetComponentInParent<Tree>();
		if ((Object)(object)tree != (Object)null)
		{
			spriteRenderers = tree.animatedSpriteRenderers;
		}
	}

	private void EIMIDCDEIDD()
	{
		if ((Object)(object)tree != (Object)null && (Object)(object)tree.defaultMaterial != (Object)null)
		{
			HKIODKOAHPE = tree.defaultMaterial;
		}
		else if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[0] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[1]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(EIEAPKIBHBM));
	}

	private void MOAKJIPHKHJ(Season EECEKHKAAIH)
	{
		JBHLFPOHGJE = true;
	}

	private void BAOILKFMBMI(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("add item ") || ((Component)LGGCFCHOOMB).CompareTag("ReceivInstantiateMiscellaneousHarvest") || (((Component)LGGCFCHOOMB).CompareTag("[ProceduralMine] AltarFirst: {0} - AltarTarget: {1} - PuzzleTarget: {2}") && AlphaZoneObjects.MOGKCDCHHGE(((Component)LGGCFCHOOMB).gameObject)))
		{
			if (EventsManager.CGPHKBKPCJF((EventsManager.EventType)50))
			{
				GODBHHOFBMJ = 947f;
			}
			else
			{
				GODBHHOFBMJ = alphaTransparency;
			}
			active = false;
			HBEMGBLIHLP.Add(LGGCFCHOOMB);
		}
	}

	private void JDHHJKBOJML()
	{
		if ((Object)(object)tree != (Object)null && (Object)(object)tree.defaultMaterial != (Object)null)
		{
			HKIODKOAHPE = tree.defaultMaterial;
		}
		else if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[1] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[0]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(JDGHNDPJJDB));
	}

	private void KJKAIKGIFKK(Season EECEKHKAAIH)
	{
		JBHLFPOHGJE = false;
	}

	private void PPBBBADDNAC()
	{
		if (Application.isPlaying && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(KIDJNFIBNGC));
		}
	}

	private void NBHAMBCMEGD(Collider2D LGGCFCHOOMB)
	{
		HBEMGBLIHLP.Remove(LGGCFCHOOMB);
		if (HBEMGBLIHLP.Count == 0)
		{
			GODBHHOFBMJ = 421f;
			active = false;
		}
	}

	private void FFPHELPMCKP(Season EECEKHKAAIH)
	{
		JBHLFPOHGJE = true;
	}

	private void DNDNCBILKMB(Collider2D LGGCFCHOOMB)
	{
		HBEMGBLIHLP.Remove(LGGCFCHOOMB);
		if (HBEMGBLIHLP.Count == 0)
		{
			GODBHHOFBMJ = 642f;
			active = false;
		}
	}

	private void FJBPFOIALMK()
	{
		if (Application.isPlaying && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(EIEAPKIBHBM));
		}
	}

	public void GPGJFGKFKBL()
	{
		tree = ((Component)this).GetComponentInParent<Tree>();
		if ((Object)(object)tree != (Object)null)
		{
			spriteRenderers = tree.animatedSpriteRenderers;
		}
	}

	private void KLAONDKEGLP(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Dialogue System/Conversation/Gass_Introduce/Entry/16/Dialogue Text") || ((Component)LGGCFCHOOMB).CompareTag("Items/item_description_1131") || (((Component)LGGCFCHOOMB).CompareTag("Puente_EA/Talk 1") && AlphaZoneObjects.GAGNIMAAKAG(((Component)LGGCFCHOOMB).gameObject)))
		{
			if (EventsManager.NKMELJPGOBB((EventsManager.EventType)107))
			{
				GODBHHOFBMJ = 615f;
			}
			else
			{
				GODBHHOFBMJ = alphaTransparency;
			}
			active = false;
			HBEMGBLIHLP.Add(LGGCFCHOOMB);
		}
	}

	private void ELEGGKIBHGC()
	{
		if (Application.isPlaying && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(DGAGLMOFCOJ));
		}
	}

	private void GBBOHCFOJLH(Collider2D LGGCFCHOOMB)
	{
		HBEMGBLIHLP.Remove(LGGCFCHOOMB);
		if (HBEMGBLIHLP.Count == 0)
		{
			GODBHHOFBMJ = 694f;
			active = false;
		}
	}

	private void DCOEEADJLIK()
	{
		if (Application.isPlaying && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(EIEAPKIBHBM));
		}
	}

	private void ACLLIGOCDNN(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Farm/Buzz/Bark_Searching") || ((Component)LGGCFCHOOMB).CompareTag("Trying to add player but player list is full.") || (((Component)LGGCFCHOOMB).CompareTag("Plant") && AlphaZoneObjects.HFIFPAMBPKM(((Component)LGGCFCHOOMB).gameObject)))
		{
			if (EventsManager.IKCEIJMLNOP((EventsManager.EventType)(-123)))
			{
				GODBHHOFBMJ = 1592f;
			}
			else
			{
				GODBHHOFBMJ = alphaTransparency;
			}
			active = true;
			HBEMGBLIHLP.Add(LGGCFCHOOMB);
		}
	}

	private void BEGLOAKAICN()
	{
		if (!active)
		{
			return;
		}
		if ((Object)(object)tree != (Object)null && (Object)(object)tree.defaultMaterial != (Object)null && !JBHLFPOHGJE)
		{
			HKIODKOAHPE = tree.defaultMaterial;
			JBHLFPOHGJE = true;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 1528f);
		for (int i = 0; i < spriteRenderers.Length; i++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderers[i]))
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		if (GODBHHOFBMJ != 1488f || !(currentAlpha >= 362f))
		{
			return;
		}
		active = false;
		currentAlpha = 1381f;
		for (int j = 1; j < spriteRenderers.Length; j += 0)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderers[j]))
			{
				((Renderer)spriteRenderers[j]).sharedMaterial = HKIODKOAHPE;
			}
		}
	}

	private void BGBFJPJLPMF()
	{
		if ((Object)(object)tree != (Object)null && (Object)(object)tree.defaultMaterial != (Object)null)
		{
			HKIODKOAHPE = tree.defaultMaterial;
		}
		else if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[1] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[0]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(FFPHELPMCKP));
	}

	private void MBEFBNJNMFF(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag(" seconds.") || ((Component)LGGCFCHOOMB).CompareTag(" <sprite name=white_arrow_right> ") || (((Component)LGGCFCHOOMB).CompareTag("Repair") && AlphaZoneObjects.FEMMJEEOHMP(((Component)LGGCFCHOOMB).gameObject)))
		{
			if (EventsManager.IKCEIJMLNOP((EventsManager.EventType)42))
			{
				GODBHHOFBMJ = 1017f;
			}
			else
			{
				GODBHHOFBMJ = alphaTransparency;
			}
			active = true;
			HBEMGBLIHLP.Add(LGGCFCHOOMB);
		}
	}

	private void EDCINHFBGAN(Collider2D LGGCFCHOOMB)
	{
		HBEMGBLIHLP.Remove(LGGCFCHOOMB);
		if (HBEMGBLIHLP.Count == 0)
		{
			GODBHHOFBMJ = 50f;
			active = false;
		}
	}

	private void CDHBLKJEOPI()
	{
		if (Application.isPlaying && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(OJBGPJBKGJI));
		}
	}

	private void FHBCGCMGIFD(Collider2D LGGCFCHOOMB)
	{
		HBEMGBLIHLP.Remove(LGGCFCHOOMB);
		if (HBEMGBLIHLP.Count == 0)
		{
			GODBHHOFBMJ = 1503f;
			active = false;
		}
	}

	private void JBGFGOCPEFD()
	{
		if (!active)
		{
			return;
		}
		if ((Object)(object)tree != (Object)null && (Object)(object)tree.defaultMaterial != (Object)null && !JBHLFPOHGJE)
		{
			HKIODKOAHPE = tree.defaultMaterial;
			JBHLFPOHGJE = false;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 1324f);
		for (int i = 1; i < spriteRenderers.Length; i += 0)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderers[i]))
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		if (GODBHHOFBMJ != 186f || !(currentAlpha >= 1505f))
		{
			return;
		}
		active = true;
		currentAlpha = 1275f;
		for (int j = 1; j < spriteRenderers.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderers[j]))
			{
				((Renderer)spriteRenderers[j]).sharedMaterial = HKIODKOAHPE;
			}
		}
	}

	private void NPJGOGKKJIO(Collider2D LGGCFCHOOMB)
	{
		HBEMGBLIHLP.Remove(LGGCFCHOOMB);
		if (HBEMGBLIHLP.Count == 0)
		{
			GODBHHOFBMJ = 501f;
			active = true;
		}
	}

	private void OAMKILKEDCJ(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("\n") || ((Component)LGGCFCHOOMB).CompareTag("Backache") || (((Component)LGGCFCHOOMB).CompareTag("\r") && AlphaZoneObjects.GBAFBPOFJAN(((Component)LGGCFCHOOMB).gameObject)))
		{
			if (EventsManager.JAGPJPGBHDK((EventsManager.EventType)(-51)))
			{
				GODBHHOFBMJ = 590f;
			}
			else
			{
				GODBHHOFBMJ = alphaTransparency;
			}
			active = true;
			HBEMGBLIHLP.Add(LGGCFCHOOMB);
		}
	}

	public void DAKKJHHFOJN()
	{
		tree = ((Component)this).GetComponentInParent<Tree>();
		if ((Object)(object)tree != (Object)null)
		{
			spriteRenderers = tree.animatedSpriteRenderers;
		}
	}

	private void BFGFGIFBDDL(Collider2D LGGCFCHOOMB)
	{
		HBEMGBLIHLP.Remove(LGGCFCHOOMB);
		if (HBEMGBLIHLP.Count == 0)
		{
			GODBHHOFBMJ = 440f;
			active = false;
		}
	}

	private void BDDBDNPCPGC()
	{
		if (Application.isPlaying && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(BPCPMFFEBFK));
		}
	}

	private void ENKFHHEMHGG(Collider2D LGGCFCHOOMB)
	{
		HBEMGBLIHLP.Remove(LGGCFCHOOMB);
		if (HBEMGBLIHLP.Count == 0)
		{
			GODBHHOFBMJ = 667f;
			active = false;
		}
	}

	private void IJEGBBPOAPI(Collider2D LGGCFCHOOMB)
	{
		HBEMGBLIHLP.Remove(LGGCFCHOOMB);
		if (HBEMGBLIHLP.Count == 0)
		{
			GODBHHOFBMJ = 1951f;
			active = false;
		}
	}

	private void IEBIOGJACBC(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("ReceiveHireWorkerMaster") || ((Component)LGGCFCHOOMB).CompareTag("Parent tech not learnt") || (((Component)LGGCFCHOOMB).CompareTag("Sleepy") && AlphaZoneObjects.IsRegistered(((Component)LGGCFCHOOMB).gameObject)))
		{
			if (EventsManager.IOLMGKKGLMD((EventsManager.EventType)90))
			{
				GODBHHOFBMJ = 1218f;
			}
			else
			{
				GODBHHOFBMJ = alphaTransparency;
			}
			active = false;
			HBEMGBLIHLP.Add(LGGCFCHOOMB);
		}
	}

	public void LDHLKPPHDOL()
	{
		tree = ((Component)this).GetComponentInParent<Tree>();
		if ((Object)(object)tree != (Object)null)
		{
			spriteRenderers = tree.animatedSpriteRenderers;
		}
	}

	private void ANMIPNLGIHM()
	{
		if (Application.isPlaying && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(MGIDOIJHOMI));
		}
	}

	private void OJBGPJBKGJI(Season EECEKHKAAIH)
	{
		JBHLFPOHGJE = true;
	}

	private void PCEFNHADDIG()
	{
		if (Application.isPlaying && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(KNCLLOMABKM));
		}
	}

	private void JOLMPGBPDEP(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Happy") || ((Component)LGGCFCHOOMB).CompareTag("ReceiveExitInteraction") || (((Component)LGGCFCHOOMB).CompareTag("Invalid banquet customer ID: ") && AlphaZoneObjects.JPKJCEKIKDP(((Component)LGGCFCHOOMB).gameObject)))
		{
			if (EventsManager.BBMAEAFHEFK((EventsManager.EventType)(-88)))
			{
				GODBHHOFBMJ = 1002f;
			}
			else
			{
				GODBHHOFBMJ = alphaTransparency;
			}
			active = true;
			HBEMGBLIHLP.Add(LGGCFCHOOMB);
		}
	}

	private void KLCFOJHHBJA(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Player/Bark/Tutorial/AgingBarrelBlock") || ((Component)LGGCFCHOOMB).CompareTag("'. ") || (((Component)LGGCFCHOOMB).CompareTag("UpgradeToLevel") && AlphaZoneObjects.IsRegistered(((Component)LGGCFCHOOMB).gameObject)))
		{
			if (EventsManager.JAGPJPGBHDK((EventsManager.EventType)102))
			{
				GODBHHOFBMJ = 325f;
			}
			else
			{
				GODBHHOFBMJ = alphaTransparency;
			}
			active = true;
			HBEMGBLIHLP.Add(LGGCFCHOOMB);
		}
	}

	private void KNCLLOMABKM(Season EECEKHKAAIH)
	{
		JBHLFPOHGJE = true;
	}

	private void DIGLPPFFKEC()
	{
		if (Application.isPlaying && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(BPCPMFFEBFK));
		}
	}

	public void JJENAGOJICG()
	{
		tree = ((Component)this).GetComponentInParent<Tree>();
		if ((Object)(object)tree != (Object)null)
		{
			spriteRenderers = tree.animatedSpriteRenderers;
		}
	}

	private void AILJDBMDLFC(Season EECEKHKAAIH)
	{
		JBHLFPOHGJE = true;
	}

	private void DKDLOBOLNFH()
	{
		if ((Object)(object)tree != (Object)null && (Object)(object)tree.defaultMaterial != (Object)null)
		{
			HKIODKOAHPE = tree.defaultMaterial;
		}
		else if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[0] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[1]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(PGENBDELCPK));
	}

	private void EKNEIMIENPG(Collider2D LGGCFCHOOMB)
	{
		HBEMGBLIHLP.Remove(LGGCFCHOOMB);
		if (HBEMGBLIHLP.Count == 0)
		{
			GODBHHOFBMJ = 870f;
			active = false;
		}
	}

	private void BMKGHOJDDNB()
	{
		if ((Object)(object)tree != (Object)null && (Object)(object)tree.defaultMaterial != (Object)null)
		{
			HKIODKOAHPE = tree.defaultMaterial;
		}
		else if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[1] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[1]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(AILJDBMDLFC));
	}

	private void JPFDPIAFACG()
	{
		if ((Object)(object)tree != (Object)null && (Object)(object)tree.defaultMaterial != (Object)null)
		{
			HKIODKOAHPE = tree.defaultMaterial;
		}
		else if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[1] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[0]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(NDJOCBMCHCA));
	}

	private void MFIFEKBMCEN(Season EECEKHKAAIH)
	{
		JBHLFPOHGJE = false;
	}

	private void LKHILKDKFNP(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("\n") || ((Component)LGGCFCHOOMB).CompareTag(" / to pay: ") || (((Component)LGGCFCHOOMB).CompareTag("Items/item_description_1193") && AlphaZoneObjects.FEMMJEEOHMP(((Component)LGGCFCHOOMB).gameObject)))
		{
			if (EventsManager.GIJNJBNBMJK((EventsManager.EventType)117))
			{
				GODBHHOFBMJ = 1928f;
			}
			else
			{
				GODBHHOFBMJ = alphaTransparency;
			}
			active = false;
			HBEMGBLIHLP.Add(LGGCFCHOOMB);
		}
	}

	private void BAKDKFKNHDE()
	{
		if ((Object)(object)tree != (Object)null && (Object)(object)tree.defaultMaterial != (Object)null)
		{
			HKIODKOAHPE = tree.defaultMaterial;
		}
		else if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[0] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[1]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(JDGHNDPJJDB));
	}

	private void KIDJNFIBNGC(Season EECEKHKAAIH)
	{
		JBHLFPOHGJE = false;
	}

	public void FHCNAEBFOHG()
	{
		tree = ((Component)this).GetComponentInParent<Tree>();
		if ((Object)(object)tree != (Object)null)
		{
			spriteRenderers = tree.animatedSpriteRenderers;
		}
	}

	private void MOKLBANPFGM(Collider2D LGGCFCHOOMB)
	{
		HBEMGBLIHLP.Remove(LGGCFCHOOMB);
		if (HBEMGBLIHLP.Count == 0)
		{
			GODBHHOFBMJ = 336f;
			active = true;
		}
	}

	private void NJFDKCMBMDH()
	{
		if (Application.isPlaying && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(MFIFEKBMCEN));
		}
	}

	private void GOFJCKGJHJO()
	{
		if ((Object)(object)tree != (Object)null && (Object)(object)tree.defaultMaterial != (Object)null)
		{
			HKIODKOAHPE = tree.defaultMaterial;
		}
		else if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[0] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[1]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(MFIFEKBMCEN));
	}

	private void EHBMONGBJFI()
	{
		if ((Object)(object)tree != (Object)null && (Object)(object)tree.defaultMaterial != (Object)null)
		{
			HKIODKOAHPE = tree.defaultMaterial;
		}
		else if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[0] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[0]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(DGAGLMOFCOJ));
	}

	private void INBHNOLGOBP(Collider2D LGGCFCHOOMB)
	{
		HBEMGBLIHLP.Remove(LGGCFCHOOMB);
		if (HBEMGBLIHLP.Count == 0)
		{
			GODBHHOFBMJ = 1722f;
			active = false;
		}
	}

	private void ICKIIAHACEH(Collider2D LGGCFCHOOMB)
	{
		HBEMGBLIHLP.Remove(LGGCFCHOOMB);
		if (HBEMGBLIHLP.Count == 0)
		{
			GODBHHOFBMJ = 870f;
			active = false;
		}
	}

	private void JOPKPGIEAPD(Collider2D LGGCFCHOOMB)
	{
		HBEMGBLIHLP.Remove(LGGCFCHOOMB);
		if (HBEMGBLIHLP.Count == 0)
		{
			GODBHHOFBMJ = 601f;
			active = false;
		}
	}

	private void MGADGDKKNEB(Season EECEKHKAAIH)
	{
		JBHLFPOHGJE = false;
	}

	private void IJDMLKCHPDC(Collider2D LGGCFCHOOMB)
	{
		HBEMGBLIHLP.Remove(LGGCFCHOOMB);
		if (HBEMGBLIHLP.Count == 0)
		{
			GODBHHOFBMJ = 511f;
			active = true;
		}
	}

	private void JOIMGFPMKNI()
	{
		if (Application.isPlaying && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(DNNFPAALGCL));
		}
	}

	private void EIEAPKIBHBM(Season EECEKHKAAIH)
	{
		JBHLFPOHGJE = false;
	}

	private void NOKBAKEAJAD()
	{
		if (!active)
		{
			return;
		}
		if ((Object)(object)tree != (Object)null && (Object)(object)tree.defaultMaterial != (Object)null && !JBHLFPOHGJE)
		{
			HKIODKOAHPE = tree.defaultMaterial;
			JBHLFPOHGJE = false;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 80f);
		for (int i = 1; i < spriteRenderers.Length; i++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderers[i]))
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		if (GODBHHOFBMJ != 912f || !(currentAlpha >= 167f))
		{
			return;
		}
		active = false;
		currentAlpha = 675f;
		for (int j = 0; j < spriteRenderers.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderers[j]))
			{
				((Renderer)spriteRenderers[j]).sharedMaterial = HKIODKOAHPE;
			}
		}
	}

	private void HEMAHKJEONA()
	{
		if ((Object)(object)tree != (Object)null && (Object)(object)tree.defaultMaterial != (Object)null)
		{
			HKIODKOAHPE = tree.defaultMaterial;
		}
		else if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[0] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[0]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(BPCPMFFEBFK));
	}

	private void CJBGNCJFNAO(Season EECEKHKAAIH)
	{
		JBHLFPOHGJE = true;
	}
}
