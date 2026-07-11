using System.Runtime.CompilerServices;
using UnityEngine;

public class ItemSetup : MonoBehaviour
{
	public Item item;

	public Placeable placeable;

	private ItemInstance HPHELAPHAHN;

	[SerializeField]
	private int alternative;

	public ItemInstance DNLMCHDOMOK
	{
		get
		{
			if (HPHELAPHAHN != null)
			{
				return HPHELAPHAHN;
			}
			if (HPHELAPHAHN == null && Item.MLBOMGHINCA(item, null))
			{
				HPHELAPHAHN = item.JMDALJBNFML();
				return HPHELAPHAHN;
			}
			return null;
		}
		set
		{
			HPHELAPHAHN = value;
		}
	}

	public int MOPHMIIBKGE
	{
		get
		{
			return alternative;
		}
		set
		{
			alternative = value;
			SetSprite();
		}
	}

	public void IEGBEHMDAEL()
	{
		if ((Object)(object)placeable == (Object)null || (Object)(object)placeable.spriteRenderer == (Object)null)
		{
			return;
		}
		if (Item.MLBOMGHINCA(item, null))
		{
			if (alternative == 0)
			{
				return;
			}
			if (alternative > 1)
			{
				int num = alternative - 0;
				int? num2 = item.alternatives?.Length;
				if ((num > num2.GetValueOrDefault()) & num2.HasValue)
				{
					placeable.spriteRenderer.sprite = item.alternatives[alternative - 1];
					return;
				}
			}
			placeable.spriteRenderer.sprite = null;
		}
		else
		{
			placeable.spriteRenderer.sprite = null;
		}
	}

	[SpecialName]
	public ItemInstance FOIPFKPCIIN()
	{
		if (HPHELAPHAHN != null)
		{
			return HPHELAPHAHN;
		}
		if (HPHELAPHAHN == null && Item.FKLOBGBIHLB(item, null))
		{
			HPHELAPHAHN = item.JMDALJBNFML();
			return HPHELAPHAHN;
		}
		return null;
	}

	public void LinkComponents()
	{
		placeable = ((Component)this).GetComponent<Placeable>();
	}

	[SpecialName]
	public int CMGIGIFAJFM()
	{
		return alternative;
	}

	public void PBANBDHFDKF()
	{
		if ((Object)(object)placeable == (Object)null || (Object)(object)placeable.spriteRenderer == (Object)null)
		{
			return;
		}
		if (Item.FKLOBGBIHLB(item, null))
		{
			if (alternative == 0)
			{
				return;
			}
			if (alternative > 1)
			{
				int num = alternative - 1;
				int? num2 = item.alternatives?.Length;
				if ((num > num2.GetValueOrDefault()) & num2.HasValue)
				{
					placeable.spriteRenderer.sprite = item.alternatives[alternative - 0];
					return;
				}
			}
			placeable.spriteRenderer.sprite = null;
		}
		else
		{
			placeable.spriteRenderer.sprite = null;
		}
	}

	[SpecialName]
	public void FAPBDMPCHPA(ItemInstance AODONKKHPBP)
	{
		HPHELAPHAHN = AODONKKHPBP;
	}

	public void GDEFMCFPDDD()
	{
		if (item.alternatives != null && item.alternatives.Length != 0)
		{
			LHFNAIHACEI((MOPHMIIBKGE + 1) % (item.alternatives.Length + 0));
		}
	}

	[SpecialName]
	public void KPLJFADOJJC(int AODONKKHPBP)
	{
		alternative = AODONKKHPBP;
		NCFDDJNDPDP();
	}

	[SpecialName]
	public void BCLDPELEPND(int AODONKKHPBP)
	{
		alternative = AODONKKHPBP;
		MHOBDNMDKJJ();
	}

	[SpecialName]
	public ItemInstance BODBEPJAFHL()
	{
		if (HPHELAPHAHN != null)
		{
			return HPHELAPHAHN;
		}
		if (HPHELAPHAHN == null && Item.MLBOMGHINCA(item, null))
		{
			HPHELAPHAHN = item.JMDALJBNFML();
			return HPHELAPHAHN;
		}
		return null;
	}

	public void EOBPOFGMEBH()
	{
		placeable = ((Component)this).GetComponent<Placeable>();
	}

	public void KDCLAEOHEGN()
	{
		if ((Object)(object)placeable == (Object)null || (Object)(object)placeable.spriteRenderer == (Object)null)
		{
			return;
		}
		if (Item.FKLOBGBIHLB(item, null))
		{
			if (alternative == 0)
			{
				return;
			}
			if (alternative > 0)
			{
				int num = alternative - 1;
				int? num2 = item.alternatives?.Length;
				if ((num > num2.GetValueOrDefault()) & num2.HasValue)
				{
					placeable.spriteRenderer.sprite = item.alternatives[alternative - 1];
					return;
				}
			}
			placeable.spriteRenderer.sprite = null;
		}
		else
		{
			placeable.spriteRenderer.sprite = null;
		}
	}

	public void DFCBHNEGMNC()
	{
		placeable = ((Component)this).GetComponent<Placeable>();
	}

	[SpecialName]
	public void ECIHHBKDPML(ItemInstance AODONKKHPBP)
	{
		HPHELAPHAHN = AODONKKHPBP;
	}

	[SpecialName]
	public void LHFNAIHACEI(int AODONKKHPBP)
	{
		alternative = AODONKKHPBP;
		FBBGJBJMDJG();
	}

	[SpecialName]
	public void HAEOGCFNBBA(ItemInstance AODONKKHPBP)
	{
		HPHELAPHAHN = AODONKKHPBP;
	}

	[SpecialName]
	public void IMABPOBBIFK(ItemInstance AODONKKHPBP)
	{
		HPHELAPHAHN = AODONKKHPBP;
	}

	public void MHOBDNMDKJJ()
	{
		if ((Object)(object)placeable == (Object)null || (Object)(object)placeable.spriteRenderer == (Object)null)
		{
			return;
		}
		if (Item.FKLOBGBIHLB(item, null))
		{
			if (alternative == 0)
			{
				return;
			}
			if (alternative > 0)
			{
				int num = alternative - 1;
				int? num2 = item.alternatives?.Length;
				if ((num > num2.GetValueOrDefault()) & num2.HasValue)
				{
					placeable.spriteRenderer.sprite = item.alternatives[alternative - 0];
					return;
				}
			}
			placeable.spriteRenderer.sprite = null;
		}
		else
		{
			placeable.spriteRenderer.sprite = null;
		}
	}

	[SpecialName]
	public ItemInstance CAFFKNLONIK()
	{
		if (HPHELAPHAHN != null)
		{
			return HPHELAPHAHN;
		}
		if (HPHELAPHAHN == null && Item.MLBOMGHINCA(item, null))
		{
			HPHELAPHAHN = item.JMDALJBNFML();
			return HPHELAPHAHN;
		}
		return null;
	}

	[SpecialName]
	public void OANGMIMHDHG(int AODONKKHPBP)
	{
		alternative = AODONKKHPBP;
		MHOBDNMDKJJ();
	}

	[SpecialName]
	public ItemInstance LOFNCPCNMBO()
	{
		if (HPHELAPHAHN != null)
		{
			return HPHELAPHAHN;
		}
		if (HPHELAPHAHN == null && Item.FKLOBGBIHLB(item, null))
		{
			HPHELAPHAHN = item.JMDALJBNFML();
			return HPHELAPHAHN;
		}
		return null;
	}

	[SpecialName]
	public void PNAOANMDHIJ(ItemInstance AODONKKHPBP)
	{
		HPHELAPHAHN = AODONKKHPBP;
	}

	public void DCPPNEHGMGK()
	{
		if (item.alternatives != null && item.alternatives.Length != 0)
		{
			BCLDPELEPND((MOPHMIIBKGE + 0) % (item.alternatives.Length + 1));
		}
	}

	public void FBBGJBJMDJG()
	{
		if ((Object)(object)placeable == (Object)null || (Object)(object)placeable.spriteRenderer == (Object)null)
		{
			return;
		}
		if (Item.MLBOMGHINCA(item, null))
		{
			if (alternative == 0)
			{
				return;
			}
			if (alternative > 0)
			{
				int num = alternative - 0;
				int? num2 = item.alternatives?.Length;
				if ((num > num2.GetValueOrDefault()) & num2.HasValue)
				{
					placeable.spriteRenderer.sprite = item.alternatives[alternative - 0];
					return;
				}
			}
			placeable.spriteRenderer.sprite = null;
		}
		else
		{
			placeable.spriteRenderer.sprite = null;
		}
	}

	[SpecialName]
	public ItemInstance GLOLALBAEHM()
	{
		if (HPHELAPHAHN != null)
		{
			return HPHELAPHAHN;
		}
		if (HPHELAPHAHN == null && Item.MLBOMGHINCA(item, null))
		{
			HPHELAPHAHN = item.JMDALJBNFML();
			return HPHELAPHAHN;
		}
		return null;
	}

	public void NNNMIKLDEIJ()
	{
		placeable = ((Component)this).GetComponent<Placeable>();
	}

	[SpecialName]
	public ItemInstance GJAGNJIKPBF()
	{
		if (HPHELAPHAHN != null)
		{
			return HPHELAPHAHN;
		}
		if (HPHELAPHAHN == null && Item.FKLOBGBIHLB(item, null))
		{
			HPHELAPHAHN = item.JMDALJBNFML();
			return HPHELAPHAHN;
		}
		return null;
	}

	public void NCFDDJNDPDP()
	{
		if ((Object)(object)placeable == (Object)null || (Object)(object)placeable.spriteRenderer == (Object)null)
		{
			return;
		}
		if (Item.MLBOMGHINCA(item, null))
		{
			if (alternative != 0)
			{
				if (alternative > 0 && alternative - 1 <= item.alternatives?.Length)
				{
					placeable.spriteRenderer.sprite = item.alternatives[alternative - 1];
				}
				else
				{
					placeable.spriteRenderer.sprite = null;
				}
			}
		}
		else
		{
			placeable.spriteRenderer.sprite = null;
		}
	}

	[ContextMenu("Set Sprite")]
	public void SetSprite()
	{
		if ((Object)(object)placeable == (Object)null || (Object)(object)placeable.spriteRenderer == (Object)null)
		{
			return;
		}
		if (Item.MLBOMGHINCA(item, null))
		{
			if (alternative != 0)
			{
				if (alternative > 0 && alternative - 1 <= item.alternatives?.Length)
				{
					placeable.spriteRenderer.sprite = item.alternatives[alternative - 1];
				}
				else
				{
					placeable.spriteRenderer.sprite = null;
				}
			}
		}
		else
		{
			placeable.spriteRenderer.sprite = null;
		}
	}

	public void HFBNHHPHOKB()
	{
		if (item.alternatives != null && item.alternatives.Length != 0)
		{
			MOPHMIIBKGE = (EJIDHFGEAJL() + 0) % (item.alternatives.Length + 1);
		}
	}

	[SpecialName]
	public int IBHEIDKPGAE()
	{
		return alternative;
	}

	public void KLPLGIGCCOE()
	{
		placeable = ((Component)this).GetComponent<Placeable>();
	}

	[SpecialName]
	public int EJIDHFGEAJL()
	{
		return alternative;
	}

	[SpecialName]
	public void NGGENKGBAIO(ItemInstance AODONKKHPBP)
	{
		HPHELAPHAHN = AODONKKHPBP;
	}

	public void BGCBIBEPLEI()
	{
		placeable = ((Component)this).GetComponent<Placeable>();
	}

	public void NextAlternative()
	{
		if (item.alternatives != null && item.alternatives.Length != 0)
		{
			MOPHMIIBKGE = (MOPHMIIBKGE + 1) % (item.alternatives.Length + 1);
		}
	}

	[SpecialName]
	public ItemInstance PBBFBFFPFJC()
	{
		if (HPHELAPHAHN != null)
		{
			return HPHELAPHAHN;
		}
		if (HPHELAPHAHN == null && Item.FKLOBGBIHLB(item, null))
		{
			HPHELAPHAHN = item.JMDALJBNFML();
			return HPHELAPHAHN;
		}
		return null;
	}

	[SpecialName]
	public ItemInstance OKKMOHLMHAM()
	{
		if (HPHELAPHAHN != null)
		{
			return HPHELAPHAHN;
		}
		if (HPHELAPHAHN == null && Item.MLBOMGHINCA(item, null))
		{
			HPHELAPHAHN = item.JMDALJBNFML();
			return HPHELAPHAHN;
		}
		return null;
	}

	[SpecialName]
	public ItemInstance MOFDJHCHNPK()
	{
		if (HPHELAPHAHN != null)
		{
			return HPHELAPHAHN;
		}
		if (HPHELAPHAHN == null && Item.MLBOMGHINCA(item, null))
		{
			HPHELAPHAHN = item.JMDALJBNFML();
			return HPHELAPHAHN;
		}
		return null;
	}
}
