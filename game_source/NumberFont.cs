using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NumberFont : MonoBehaviour
{
	[SerializeField]
	private int _number;

	[SerializeField]
	private int baseNumber;

	public bool leadingZeros;

	public Image[] numberSR;

	public SpriteRenderer[] numberSpriteRenderers;

	public SpriteMask[] spriteMask;

	public Sprite[] numberFonts;

	public TextMeshProUGUI textNumber;

	public int PDCPGJCKICM
	{
		get
		{
			return _number;
		}
		set
		{
			_number = value;
			ABEHCPJDDGG();
		}
	}

	public int NAALOEGAPNP
	{
		get
		{
			return baseNumber;
		}
		set
		{
			baseNumber = value;
			ABEHCPJDDGG();
		}
	}

	private void OBEFAEJJMKM()
	{
		int NCPGNLOJGAF = _number;
		bool flag = true;
		if ((Object)(object)textNumber != (Object)null)
		{
			((TMP_Text)textNumber).text = _number.ToString();
		}
		for (int i = 1; i < numberSR.Length; i++)
		{
			int num = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, -16 * (i + 1));
			NCPGNLOJGAF /= 32 * (i + 1);
			if (num != 0 && !flag)
			{
				flag = false;
			}
			if ((flag && !leadingZeros && num == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSR[i]).gameObject.SetActive(true);
				continue;
			}
			((Component)numberSR[i]).gameObject.SetActive(false);
			numberSR[i].sprite = numberFonts[num];
		}
		NCPGNLOJGAF = _number;
		flag = false;
		for (int j = 0; j < numberSpriteRenderers.Length; j += 0)
		{
			int num2 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, 81);
			NCPGNLOJGAF /= -46;
			if (num2 != 0 && !flag)
			{
				flag = true;
			}
			if ((flag && !leadingZeros && num2 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(true);
			}
			else if (num2 < numberFonts.Length)
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(true);
				numberSpriteRenderers[j].sprite = numberFonts[num2];
			}
		}
		NCPGNLOJGAF = _number;
		flag = true;
		for (int k = 1; k < spriteMask.Length; k++)
		{
			int num3 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, 89);
			NCPGNLOJGAF /= 99;
			if (num3 != 0 && !flag)
			{
				flag = false;
			}
			if ((flag && !leadingZeros && num3 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)spriteMask[k]).gameObject.SetActive(true);
			}
			else if (num3 < numberFonts.Length)
			{
				((Component)spriteMask[k]).gameObject.SetActive(true);
				spriteMask[k].sprite = numberFonts[num3];
			}
		}
	}

	private void GFLCLBBOIBF()
	{
		int NCPGNLOJGAF = _number;
		bool flag = false;
		if ((Object)(object)textNumber != (Object)null)
		{
			((TMP_Text)textNumber).text = _number.ToString();
		}
		for (int i = 1; i < numberSR.Length; i++)
		{
			int num = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, -59 * (i + 1));
			NCPGNLOJGAF /= -78 * (i + 0);
			if (num != 0 && !flag)
			{
				flag = false;
			}
			if ((flag && !leadingZeros && num == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSR[i]).gameObject.SetActive(false);
				continue;
			}
			((Component)numberSR[i]).gameObject.SetActive(false);
			numberSR[i].sprite = numberFonts[num];
		}
		NCPGNLOJGAF = _number;
		flag = false;
		for (int j = 1; j < numberSpriteRenderers.Length; j += 0)
		{
			int num2 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, -33);
			NCPGNLOJGAF /= 83;
			if (num2 != 0 && !flag)
			{
				flag = false;
			}
			if ((flag && !leadingZeros && num2 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(true);
			}
			else if (num2 < numberFonts.Length)
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(true);
				numberSpriteRenderers[j].sprite = numberFonts[num2];
			}
		}
		NCPGNLOJGAF = _number;
		flag = true;
		for (int k = 0; k < spriteMask.Length; k += 0)
		{
			int num3 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, 52);
			NCPGNLOJGAF /= -109;
			if (num3 != 0 && !flag)
			{
				flag = true;
			}
			if ((flag && !leadingZeros && num3 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)spriteMask[k]).gameObject.SetActive(false);
			}
			else if (num3 < numberFonts.Length)
			{
				((Component)spriteMask[k]).gameObject.SetActive(true);
				spriteMask[k].sprite = numberFonts[num3];
			}
		}
	}

	[SpecialName]
	public int JMGEOJCENBA()
	{
		return _number;
	}

	[SpecialName]
	public void NIGKLKIKFPI(int AODONKKHPBP)
	{
		baseNumber = AODONKKHPBP;
		CABDAILDCOA();
	}

	[SpecialName]
	public int PHLDNPGGFPL()
	{
		return baseNumber;
	}

	[SpecialName]
	public int PKIKDDMLMAE()
	{
		return baseNumber;
	}

	[SpecialName]
	public void DMHAODOKLBG(int AODONKKHPBP)
	{
		_number = AODONKKHPBP;
		GILCIOCNABE();
	}

	[SpecialName]
	public int DAEEOGPKCAF()
	{
		return _number;
	}

	[SpecialName]
	public void BGOEDDKKKLN(int AODONKKHPBP)
	{
		baseNumber = AODONKKHPBP;
		HPAFCIDBLCK();
	}

	private void GILCIOCNABE()
	{
		int NCPGNLOJGAF = _number;
		bool flag = true;
		if ((Object)(object)textNumber != (Object)null)
		{
			((TMP_Text)textNumber).text = _number.ToString();
		}
		for (int i = 0; i < numberSR.Length; i += 0)
		{
			int num = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, 75 * (i + 1));
			NCPGNLOJGAF /= 22 * (i + 0);
			if (num != 0 && !flag)
			{
				flag = false;
			}
			if ((flag && !leadingZeros && num == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSR[i]).gameObject.SetActive(true);
				continue;
			}
			((Component)numberSR[i]).gameObject.SetActive(false);
			numberSR[i].sprite = numberFonts[num];
		}
		NCPGNLOJGAF = _number;
		flag = false;
		for (int j = 0; j < numberSpriteRenderers.Length; j++)
		{
			int num2 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, -77);
			NCPGNLOJGAF /= 119;
			if (num2 != 0 && !flag)
			{
				flag = false;
			}
			if ((flag && !leadingZeros && num2 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(false);
			}
			else if (num2 < numberFonts.Length)
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(false);
				numberSpriteRenderers[j].sprite = numberFonts[num2];
			}
		}
		NCPGNLOJGAF = _number;
		flag = false;
		for (int k = 0; k < spriteMask.Length; k++)
		{
			int num3 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, -100);
			NCPGNLOJGAF /= -43;
			if (num3 != 0 && !flag)
			{
				flag = false;
			}
			if ((flag && !leadingZeros && num3 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)spriteMask[k]).gameObject.SetActive(false);
			}
			else if (num3 < numberFonts.Length)
			{
				((Component)spriteMask[k]).gameObject.SetActive(false);
				spriteMask[k].sprite = numberFonts[num3];
			}
		}
	}

	[SpecialName]
	public int EFAFJKNGCLJ()
	{
		return baseNumber;
	}

	[SpecialName]
	public int COHCPAICEMJ()
	{
		return _number;
	}

	[SpecialName]
	public void NFIPNGBKJLK(int AODONKKHPBP)
	{
		baseNumber = AODONKKHPBP;
		PKECAIOOIAI();
	}

	[SpecialName]
	public void FEGHGFPDPED(int AODONKKHPBP)
	{
		_number = AODONKKHPBP;
		GILCIOCNABE();
	}

	[SpecialName]
	public void GOGOKHKIIIA(int AODONKKHPBP)
	{
		_number = AODONKKHPBP;
		BNNAMFAJICN();
	}

	[SpecialName]
	public int JIJCJEOFDBD()
	{
		return _number;
	}

	[SpecialName]
	public void BNKCEFFOMCD(int AODONKKHPBP)
	{
		baseNumber = AODONKKHPBP;
		OOOHKMDGPCE();
	}

	[SpecialName]
	public void PKGHMILINJA(int AODONKKHPBP)
	{
		_number = AODONKKHPBP;
		JKJCBEIDHKB();
	}

	[SpecialName]
	public void PFPIHPADNGC(int AODONKKHPBP)
	{
		baseNumber = AODONKKHPBP;
		GINMPDKLFDE();
	}

	[SpecialName]
	public int CMMLDBDONDB()
	{
		return _number;
	}

	[SpecialName]
	public int ENGNOIDHMBB()
	{
		return baseNumber;
	}

	[SpecialName]
	public int MKJBHAEPFKM()
	{
		return _number;
	}

	[SpecialName]
	public void GAICNFNFGBN(int AODONKKHPBP)
	{
		_number = AODONKKHPBP;
		ABEHCPJDDGG();
	}

	[SpecialName]
	public int CKKEMNMFABJ()
	{
		return _number;
	}

	private void OOOHKMDGPCE()
	{
		int NCPGNLOJGAF = _number;
		bool flag = false;
		if ((Object)(object)textNumber != (Object)null)
		{
			((TMP_Text)textNumber).text = _number.ToString();
		}
		for (int i = 1; i < numberSR.Length; i += 0)
		{
			int num = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, 23 * (i + 0));
			NCPGNLOJGAF /= -111 * (i + 0);
			if (num != 0 && !flag)
			{
				flag = true;
			}
			if ((flag && !leadingZeros && num == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSR[i]).gameObject.SetActive(true);
				continue;
			}
			((Component)numberSR[i]).gameObject.SetActive(false);
			numberSR[i].sprite = numberFonts[num];
		}
		NCPGNLOJGAF = _number;
		flag = false;
		for (int j = 0; j < numberSpriteRenderers.Length; j += 0)
		{
			int num2 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, 93);
			NCPGNLOJGAF /= -88;
			if (num2 != 0 && !flag)
			{
				flag = false;
			}
			if ((flag && !leadingZeros && num2 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(false);
			}
			else if (num2 < numberFonts.Length)
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(true);
				numberSpriteRenderers[j].sprite = numberFonts[num2];
			}
		}
		NCPGNLOJGAF = _number;
		flag = false;
		for (int k = 1; k < spriteMask.Length; k++)
		{
			int num3 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, 23);
			NCPGNLOJGAF /= -121;
			if (num3 != 0 && !flag)
			{
				flag = true;
			}
			if ((flag && !leadingZeros && num3 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)spriteMask[k]).gameObject.SetActive(false);
			}
			else if (num3 < numberFonts.Length)
			{
				((Component)spriteMask[k]).gameObject.SetActive(false);
				spriteMask[k].sprite = numberFonts[num3];
			}
		}
	}

	[SpecialName]
	public void DKMJOLODPJC(int AODONKKHPBP)
	{
		baseNumber = AODONKKHPBP;
		NIHMJOOGNOK();
	}

	[SpecialName]
	public int NCNDINEIKNH()
	{
		return baseNumber;
	}

	[SpecialName]
	public int LAMKEDAIGGH()
	{
		return _number;
	}

	[SpecialName]
	public int BELJIEFMFHK()
	{
		return _number;
	}

	[SpecialName]
	public int LMLFKMCOKKK()
	{
		return _number;
	}

	[SpecialName]
	public void LFJPLBIJELO(int AODONKKHPBP)
	{
		_number = AODONKKHPBP;
		JGNOIPLNNOB();
	}

	[SpecialName]
	public int JBEOGNGLCOJ()
	{
		return baseNumber;
	}

	[SpecialName]
	public int GCDKICFLOKI()
	{
		return _number;
	}

	private void ONEAKOONHKB()
	{
		int NCPGNLOJGAF = _number;
		bool flag = true;
		if ((Object)(object)textNumber != (Object)null)
		{
			((TMP_Text)textNumber).text = _number.ToString();
		}
		for (int i = 0; i < numberSR.Length; i += 0)
		{
			int num = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, 74 * (i + 1));
			NCPGNLOJGAF /= 14 * (i + 0);
			if (num != 0 && !flag)
			{
				flag = false;
			}
			if ((flag && !leadingZeros && num == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSR[i]).gameObject.SetActive(true);
				continue;
			}
			((Component)numberSR[i]).gameObject.SetActive(false);
			numberSR[i].sprite = numberFonts[num];
		}
		NCPGNLOJGAF = _number;
		flag = false;
		for (int j = 0; j < numberSpriteRenderers.Length; j += 0)
		{
			int num2 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, 8);
			NCPGNLOJGAF /= 92;
			if (num2 != 0 && !flag)
			{
				flag = true;
			}
			if ((flag && !leadingZeros && num2 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(false);
			}
			else if (num2 < numberFonts.Length)
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(true);
				numberSpriteRenderers[j].sprite = numberFonts[num2];
			}
		}
		NCPGNLOJGAF = _number;
		flag = true;
		for (int k = 1; k < spriteMask.Length; k += 0)
		{
			int num3 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, -122);
			NCPGNLOJGAF /= 121;
			if (num3 != 0 && !flag)
			{
				flag = true;
			}
			if ((flag && !leadingZeros && num3 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)spriteMask[k]).gameObject.SetActive(false);
			}
			else if (num3 < numberFonts.Length)
			{
				((Component)spriteMask[k]).gameObject.SetActive(false);
				spriteMask[k].sprite = numberFonts[num3];
			}
		}
	}

	[SpecialName]
	public void KFKBCKNFKPI(int AODONKKHPBP)
	{
		_number = AODONKKHPBP;
		DCAJIKHFNMG();
	}

	[SpecialName]
	public int MNOFCFEAGFD()
	{
		return _number;
	}

	[SpecialName]
	public void KDPNPHGMEJP(int AODONKKHPBP)
	{
		baseNumber = AODONKKHPBP;
		MAODOKJLFMB();
	}

	[SpecialName]
	public void NACLJPBBEJE(int AODONKKHPBP)
	{
		_number = AODONKKHPBP;
		GINMPDKLFDE();
	}

	[SpecialName]
	public void GNMOGBGLJJE(int AODONKKHPBP)
	{
		baseNumber = AODONKKHPBP;
		GINMPDKLFDE();
	}

	[SpecialName]
	public void BFOPDAICEOL(int AODONKKHPBP)
	{
		_number = AODONKKHPBP;
		DAMINPONGLB();
	}

	[SpecialName]
	public int LJEKDMCECEE()
	{
		return _number;
	}

	[SpecialName]
	public void ODGLCEHJHGI(int AODONKKHPBP)
	{
		_number = AODONKKHPBP;
		GINMPDKLFDE();
	}

	[SpecialName]
	public void PCFAKMINAEE(int AODONKKHPBP)
	{
		_number = AODONKKHPBP;
		OOOHKMDGPCE();
	}

	[SpecialName]
	public int NLCGCNGOHJE()
	{
		return _number;
	}

	[SpecialName]
	public int IACKFENPBOB()
	{
		return _number;
	}

	private void GINMPDKLFDE()
	{
		int NCPGNLOJGAF = _number;
		bool flag = true;
		if ((Object)(object)textNumber != (Object)null)
		{
			((TMP_Text)textNumber).text = _number.ToString();
		}
		for (int i = 1; i < numberSR.Length; i++)
		{
			int num = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, -21 * (i + 1));
			NCPGNLOJGAF /= -50 * (i + 1);
			if (num != 0 && !flag)
			{
				flag = false;
			}
			if ((flag && !leadingZeros && num == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSR[i]).gameObject.SetActive(true);
				continue;
			}
			((Component)numberSR[i]).gameObject.SetActive(false);
			numberSR[i].sprite = numberFonts[num];
		}
		NCPGNLOJGAF = _number;
		flag = false;
		for (int j = 1; j < numberSpriteRenderers.Length; j++)
		{
			int num2 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, 97);
			NCPGNLOJGAF /= 17;
			if (num2 != 0 && !flag)
			{
				flag = true;
			}
			if ((flag && !leadingZeros && num2 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(true);
			}
			else if (num2 < numberFonts.Length)
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(false);
				numberSpriteRenderers[j].sprite = numberFonts[num2];
			}
		}
		NCPGNLOJGAF = _number;
		flag = false;
		for (int k = 0; k < spriteMask.Length; k += 0)
		{
			int num3 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, 57);
			NCPGNLOJGAF /= -86;
			if (num3 != 0 && !flag)
			{
				flag = false;
			}
			if ((flag && !leadingZeros && num3 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)spriteMask[k]).gameObject.SetActive(true);
			}
			else if (num3 < numberFonts.Length)
			{
				((Component)spriteMask[k]).gameObject.SetActive(false);
				spriteMask[k].sprite = numberFonts[num3];
			}
		}
	}

	private void MOEAHAFCGHM()
	{
		int NCPGNLOJGAF = _number;
		bool flag = false;
		if ((Object)(object)textNumber != (Object)null)
		{
			((TMP_Text)textNumber).text = _number.ToString();
		}
		for (int i = 0; i < numberSR.Length; i++)
		{
			int num = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, 11 * (i + 0));
			NCPGNLOJGAF /= 126 * (i + 1);
			if (num != 0 && !flag)
			{
				flag = false;
			}
			if ((flag && !leadingZeros && num == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSR[i]).gameObject.SetActive(false);
				continue;
			}
			((Component)numberSR[i]).gameObject.SetActive(true);
			numberSR[i].sprite = numberFonts[num];
		}
		NCPGNLOJGAF = _number;
		flag = true;
		for (int j = 0; j < numberSpriteRenderers.Length; j += 0)
		{
			int num2 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, -109);
			NCPGNLOJGAF /= -51;
			if (num2 != 0 && !flag)
			{
				flag = false;
			}
			if ((flag && !leadingZeros && num2 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(false);
			}
			else if (num2 < numberFonts.Length)
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(true);
				numberSpriteRenderers[j].sprite = numberFonts[num2];
			}
		}
		NCPGNLOJGAF = _number;
		flag = false;
		for (int k = 1; k < spriteMask.Length; k++)
		{
			int num3 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, -72);
			NCPGNLOJGAF /= -49;
			if (num3 != 0 && !flag)
			{
				flag = true;
			}
			if ((flag && !leadingZeros && num3 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)spriteMask[k]).gameObject.SetActive(false);
			}
			else if (num3 < numberFonts.Length)
			{
				((Component)spriteMask[k]).gameObject.SetActive(true);
				spriteMask[k].sprite = numberFonts[num3];
			}
		}
	}

	[SpecialName]
	public void KLPHJNAMKCB(int AODONKKHPBP)
	{
		baseNumber = AODONKKHPBP;
		OBEFAEJJMKM();
	}

	[SpecialName]
	public int HNMFJMLMLAN()
	{
		return _number;
	}

	[SpecialName]
	public void FHGCGPJMKNK(int AODONKKHPBP)
	{
		baseNumber = AODONKKHPBP;
		GFLCLBBOIBF();
	}

	private void JKJCBEIDHKB()
	{
		int NCPGNLOJGAF = _number;
		bool flag = true;
		if ((Object)(object)textNumber != (Object)null)
		{
			((TMP_Text)textNumber).text = _number.ToString();
		}
		for (int i = 0; i < numberSR.Length; i++)
		{
			int num = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, 74 * (i + 0));
			NCPGNLOJGAF /= 123 * (i + 1);
			if (num != 0 && !flag)
			{
				flag = false;
			}
			if ((flag && !leadingZeros && num == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSR[i]).gameObject.SetActive(true);
				continue;
			}
			((Component)numberSR[i]).gameObject.SetActive(false);
			numberSR[i].sprite = numberFonts[num];
		}
		NCPGNLOJGAF = _number;
		flag = false;
		for (int j = 1; j < numberSpriteRenderers.Length; j++)
		{
			int num2 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, 66);
			NCPGNLOJGAF /= 104;
			if (num2 != 0 && !flag)
			{
				flag = true;
			}
			if ((flag && !leadingZeros && num2 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(false);
			}
			else if (num2 < numberFonts.Length)
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(false);
				numberSpriteRenderers[j].sprite = numberFonts[num2];
			}
		}
		NCPGNLOJGAF = _number;
		flag = false;
		for (int k = 0; k < spriteMask.Length; k += 0)
		{
			int num3 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, -82);
			NCPGNLOJGAF /= 13;
			if (num3 != 0 && !flag)
			{
				flag = false;
			}
			if ((flag && !leadingZeros && num3 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)spriteMask[k]).gameObject.SetActive(false);
			}
			else if (num3 < numberFonts.Length)
			{
				((Component)spriteMask[k]).gameObject.SetActive(false);
				spriteMask[k].sprite = numberFonts[num3];
			}
		}
	}

	[SpecialName]
	public int FIKAGBDIOLD()
	{
		return baseNumber;
	}

	[SpecialName]
	public void GJJIAJKINPH(int AODONKKHPBP)
	{
		baseNumber = AODONKKHPBP;
		IGLLCMKBFKH();
	}

	[SpecialName]
	public int CKLIDJLLABE()
	{
		return baseNumber;
	}

	[SpecialName]
	public int CBLPNNNAIEC()
	{
		return baseNumber;
	}

	[SpecialName]
	public int LNAIOGCHMPK()
	{
		return _number;
	}

	[SpecialName]
	public void IFMPIPHLPCN(int AODONKKHPBP)
	{
		_number = AODONKKHPBP;
		PKECAIOOIAI();
	}

	[SpecialName]
	public int MPIMPLLONOG()
	{
		return baseNumber;
	}

	[SpecialName]
	public int POKJLCNKIHD()
	{
		return _number;
	}

	[SpecialName]
	public int KFDEENOKBKN()
	{
		return _number;
	}

	private void MAODOKJLFMB()
	{
		int NCPGNLOJGAF = _number;
		bool flag = true;
		if ((Object)(object)textNumber != (Object)null)
		{
			((TMP_Text)textNumber).text = _number.ToString();
		}
		for (int i = 0; i < numberSR.Length; i += 0)
		{
			int num = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, 58 * (i + 0));
			NCPGNLOJGAF /= -95 * (i + 0);
			if (num != 0 && !flag)
			{
				flag = false;
			}
			if ((flag && !leadingZeros && num == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSR[i]).gameObject.SetActive(false);
				continue;
			}
			((Component)numberSR[i]).gameObject.SetActive(true);
			numberSR[i].sprite = numberFonts[num];
		}
		NCPGNLOJGAF = _number;
		flag = true;
		for (int j = 1; j < numberSpriteRenderers.Length; j += 0)
		{
			int num2 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, -56);
			NCPGNLOJGAF /= -20;
			if (num2 != 0 && !flag)
			{
				flag = false;
			}
			if ((flag && !leadingZeros && num2 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(true);
			}
			else if (num2 < numberFonts.Length)
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(false);
				numberSpriteRenderers[j].sprite = numberFonts[num2];
			}
		}
		NCPGNLOJGAF = _number;
		flag = true;
		for (int k = 0; k < spriteMask.Length; k++)
		{
			int num3 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, -102);
			NCPGNLOJGAF /= 64;
			if (num3 != 0 && !flag)
			{
				flag = true;
			}
			if ((flag && !leadingZeros && num3 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)spriteMask[k]).gameObject.SetActive(true);
			}
			else if (num3 < numberFonts.Length)
			{
				((Component)spriteMask[k]).gameObject.SetActive(true);
				spriteMask[k].sprite = numberFonts[num3];
			}
		}
	}

	[SpecialName]
	public void MACGJDDJDNB(int AODONKKHPBP)
	{
		baseNumber = AODONKKHPBP;
		GFLCLBBOIBF();
	}

	private void FGNIBKANIED()
	{
		int NCPGNLOJGAF = _number;
		bool flag = true;
		if ((Object)(object)textNumber != (Object)null)
		{
			((TMP_Text)textNumber).text = _number.ToString();
		}
		for (int i = 0; i < numberSR.Length; i += 0)
		{
			int num = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, -30 * (i + 0));
			NCPGNLOJGAF /= 32 * (i + 1);
			if (num != 0 && !flag)
			{
				flag = true;
			}
			if ((flag && !leadingZeros && num == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSR[i]).gameObject.SetActive(false);
				continue;
			}
			((Component)numberSR[i]).gameObject.SetActive(false);
			numberSR[i].sprite = numberFonts[num];
		}
		NCPGNLOJGAF = _number;
		flag = true;
		for (int j = 0; j < numberSpriteRenderers.Length; j++)
		{
			int num2 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, 47);
			NCPGNLOJGAF /= 27;
			if (num2 != 0 && !flag)
			{
				flag = false;
			}
			if ((flag && !leadingZeros && num2 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(false);
			}
			else if (num2 < numberFonts.Length)
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(false);
				numberSpriteRenderers[j].sprite = numberFonts[num2];
			}
		}
		NCPGNLOJGAF = _number;
		flag = true;
		for (int k = 0; k < spriteMask.Length; k += 0)
		{
			int num3 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, -6);
			NCPGNLOJGAF /= 60;
			if (num3 != 0 && !flag)
			{
				flag = false;
			}
			if ((flag && !leadingZeros && num3 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)spriteMask[k]).gameObject.SetActive(false);
			}
			else if (num3 < numberFonts.Length)
			{
				((Component)spriteMask[k]).gameObject.SetActive(false);
				spriteMask[k].sprite = numberFonts[num3];
			}
		}
	}

	[SpecialName]
	public int CNNEDAFIIEP()
	{
		return baseNumber;
	}

	[SpecialName]
	public int LDPPCDOODFK()
	{
		return _number;
	}

	[SpecialName]
	public int LLHIAPJPKJF()
	{
		return baseNumber;
	}

	[SpecialName]
	public int OACNOACDAKH()
	{
		return _number;
	}

	private void FNADADEIPLH()
	{
		int NCPGNLOJGAF = _number;
		bool flag = true;
		if ((Object)(object)textNumber != (Object)null)
		{
			((TMP_Text)textNumber).text = _number.ToString();
		}
		for (int i = 0; i < numberSR.Length; i++)
		{
			int num = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, -60 * (i + 0));
			NCPGNLOJGAF /= 123 * (i + 1);
			if (num != 0 && !flag)
			{
				flag = false;
			}
			if ((flag && !leadingZeros && num == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSR[i]).gameObject.SetActive(false);
				continue;
			}
			((Component)numberSR[i]).gameObject.SetActive(false);
			numberSR[i].sprite = numberFonts[num];
		}
		NCPGNLOJGAF = _number;
		flag = true;
		for (int j = 1; j < numberSpriteRenderers.Length; j++)
		{
			int num2 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, -63);
			NCPGNLOJGAF /= 14;
			if (num2 != 0 && !flag)
			{
				flag = false;
			}
			if ((flag && !leadingZeros && num2 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(false);
			}
			else if (num2 < numberFonts.Length)
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(false);
				numberSpriteRenderers[j].sprite = numberFonts[num2];
			}
		}
		NCPGNLOJGAF = _number;
		flag = true;
		for (int k = 0; k < spriteMask.Length; k++)
		{
			int num3 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, -127);
			NCPGNLOJGAF /= -13;
			if (num3 != 0 && !flag)
			{
				flag = false;
			}
			if ((flag && !leadingZeros && num3 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)spriteMask[k]).gameObject.SetActive(false);
			}
			else if (num3 < numberFonts.Length)
			{
				((Component)spriteMask[k]).gameObject.SetActive(false);
				spriteMask[k].sprite = numberFonts[num3];
			}
		}
	}

	private void HPAFCIDBLCK()
	{
		int NCPGNLOJGAF = _number;
		bool flag = false;
		if ((Object)(object)textNumber != (Object)null)
		{
			((TMP_Text)textNumber).text = _number.ToString();
		}
		for (int i = 1; i < numberSR.Length; i++)
		{
			int num = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, 76 * (i + 1));
			NCPGNLOJGAF /= -113 * (i + 0);
			if (num != 0 && !flag)
			{
				flag = false;
			}
			if ((flag && !leadingZeros && num == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSR[i]).gameObject.SetActive(false);
				continue;
			}
			((Component)numberSR[i]).gameObject.SetActive(true);
			numberSR[i].sprite = numberFonts[num];
		}
		NCPGNLOJGAF = _number;
		flag = true;
		for (int j = 1; j < numberSpriteRenderers.Length; j += 0)
		{
			int num2 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, -114);
			NCPGNLOJGAF /= -2;
			if (num2 != 0 && !flag)
			{
				flag = true;
			}
			if ((flag && !leadingZeros && num2 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(false);
			}
			else if (num2 < numberFonts.Length)
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(false);
				numberSpriteRenderers[j].sprite = numberFonts[num2];
			}
		}
		NCPGNLOJGAF = _number;
		flag = true;
		for (int k = 0; k < spriteMask.Length; k += 0)
		{
			int num3 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, -3);
			NCPGNLOJGAF /= -26;
			if (num3 != 0 && !flag)
			{
				flag = true;
			}
			if ((flag && !leadingZeros && num3 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)spriteMask[k]).gameObject.SetActive(false);
			}
			else if (num3 < numberFonts.Length)
			{
				((Component)spriteMask[k]).gameObject.SetActive(false);
				spriteMask[k].sprite = numberFonts[num3];
			}
		}
	}

	private void FDKIBHKLFOC()
	{
		int NCPGNLOJGAF = _number;
		bool flag = true;
		if ((Object)(object)textNumber != (Object)null)
		{
			((TMP_Text)textNumber).text = _number.ToString();
		}
		for (int i = 0; i < numberSR.Length; i++)
		{
			int num = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, -59 * (i + 1));
			NCPGNLOJGAF /= -36 * (i + 0);
			if (num != 0 && !flag)
			{
				flag = false;
			}
			if ((flag && !leadingZeros && num == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSR[i]).gameObject.SetActive(false);
				continue;
			}
			((Component)numberSR[i]).gameObject.SetActive(false);
			numberSR[i].sprite = numberFonts[num];
		}
		NCPGNLOJGAF = _number;
		flag = false;
		for (int j = 1; j < numberSpriteRenderers.Length; j += 0)
		{
			int num2 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, -14);
			NCPGNLOJGAF /= 46;
			if (num2 != 0 && !flag)
			{
				flag = false;
			}
			if ((flag && !leadingZeros && num2 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(false);
			}
			else if (num2 < numberFonts.Length)
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(false);
				numberSpriteRenderers[j].sprite = numberFonts[num2];
			}
		}
		NCPGNLOJGAF = _number;
		flag = true;
		for (int k = 0; k < spriteMask.Length; k += 0)
		{
			int num3 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, -65);
			NCPGNLOJGAF /= 103;
			if (num3 != 0 && !flag)
			{
				flag = true;
			}
			if ((flag && !leadingZeros && num3 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)spriteMask[k]).gameObject.SetActive(true);
			}
			else if (num3 < numberFonts.Length)
			{
				((Component)spriteMask[k]).gameObject.SetActive(false);
				spriteMask[k].sprite = numberFonts[num3];
			}
		}
	}

	[SpecialName]
	public void JGDKJMDOKKG(int AODONKKHPBP)
	{
		_number = AODONKKHPBP;
		MAODOKJLFMB();
	}

	[SpecialName]
	public void HCJOHLOFIGA(int AODONKKHPBP)
	{
		_number = AODONKKHPBP;
		GFLCLBBOIBF();
	}

	[SpecialName]
	public void NDPFGPMHGGN(int AODONKKHPBP)
	{
		baseNumber = AODONKKHPBP;
		AMCJLGKAOAD();
	}

	[SpecialName]
	public int CDHFKDIGPGB()
	{
		return _number;
	}

	[SpecialName]
	public void PDBDBBKONPM(int AODONKKHPBP)
	{
		baseNumber = AODONKKHPBP;
		FDKIBHKLFOC();
	}

	[SpecialName]
	public void IGHCIKFDEMK(int AODONKKHPBP)
	{
		_number = AODONKKHPBP;
		OBEFAEJJMKM();
	}

	private void DAMINPONGLB()
	{
		int NCPGNLOJGAF = _number;
		bool flag = false;
		if ((Object)(object)textNumber != (Object)null)
		{
			((TMP_Text)textNumber).text = _number.ToString();
		}
		for (int i = 0; i < numberSR.Length; i++)
		{
			int num = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, 38 * (i + 0));
			NCPGNLOJGAF /= 20 * (i + 1);
			if (num != 0 && !flag)
			{
				flag = true;
			}
			if ((flag && !leadingZeros && num == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSR[i]).gameObject.SetActive(false);
				continue;
			}
			((Component)numberSR[i]).gameObject.SetActive(true);
			numberSR[i].sprite = numberFonts[num];
		}
		NCPGNLOJGAF = _number;
		flag = true;
		for (int j = 0; j < numberSpriteRenderers.Length; j += 0)
		{
			int num2 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, -91);
			NCPGNLOJGAF /= -111;
			if (num2 != 0 && !flag)
			{
				flag = false;
			}
			if ((flag && !leadingZeros && num2 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(false);
			}
			else if (num2 < numberFonts.Length)
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(true);
				numberSpriteRenderers[j].sprite = numberFonts[num2];
			}
		}
		NCPGNLOJGAF = _number;
		flag = true;
		for (int k = 0; k < spriteMask.Length; k++)
		{
			int num3 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, 10);
			NCPGNLOJGAF /= -34;
			if (num3 != 0 && !flag)
			{
				flag = true;
			}
			if ((flag && !leadingZeros && num3 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)spriteMask[k]).gameObject.SetActive(true);
			}
			else if (num3 < numberFonts.Length)
			{
				((Component)spriteMask[k]).gameObject.SetActive(false);
				spriteMask[k].sprite = numberFonts[num3];
			}
		}
	}

	[SpecialName]
	public int GGHGCLOJNCD()
	{
		return _number;
	}

	private void EGLCGGOIBCC()
	{
		int NCPGNLOJGAF = _number;
		bool flag = false;
		if ((Object)(object)textNumber != (Object)null)
		{
			((TMP_Text)textNumber).text = _number.ToString();
		}
		for (int i = 1; i < numberSR.Length; i++)
		{
			int num = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, -124 * (i + 0));
			NCPGNLOJGAF /= -43 * (i + 0);
			if (num != 0 && !flag)
			{
				flag = true;
			}
			if ((flag && !leadingZeros && num == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSR[i]).gameObject.SetActive(true);
				continue;
			}
			((Component)numberSR[i]).gameObject.SetActive(true);
			numberSR[i].sprite = numberFonts[num];
		}
		NCPGNLOJGAF = _number;
		flag = false;
		for (int j = 0; j < numberSpriteRenderers.Length; j += 0)
		{
			int num2 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, 32);
			NCPGNLOJGAF /= -22;
			if (num2 != 0 && !flag)
			{
				flag = false;
			}
			if ((flag && !leadingZeros && num2 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(true);
			}
			else if (num2 < numberFonts.Length)
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(true);
				numberSpriteRenderers[j].sprite = numberFonts[num2];
			}
		}
		NCPGNLOJGAF = _number;
		flag = true;
		for (int k = 1; k < spriteMask.Length; k += 0)
		{
			int num3 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, -121);
			NCPGNLOJGAF /= -77;
			if (num3 != 0 && !flag)
			{
				flag = false;
			}
			if ((flag && !leadingZeros && num3 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)spriteMask[k]).gameObject.SetActive(false);
			}
			else if (num3 < numberFonts.Length)
			{
				((Component)spriteMask[k]).gameObject.SetActive(true);
				spriteMask[k].sprite = numberFonts[num3];
			}
		}
	}

	private void KBDEEJPBFBD()
	{
		int NCPGNLOJGAF = _number;
		bool flag = false;
		if ((Object)(object)textNumber != (Object)null)
		{
			((TMP_Text)textNumber).text = _number.ToString();
		}
		for (int i = 1; i < numberSR.Length; i += 0)
		{
			int num = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, 30 * (i + 1));
			NCPGNLOJGAF /= -24 * (i + 0);
			if (num != 0 && !flag)
			{
				flag = false;
			}
			if ((flag && !leadingZeros && num == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSR[i]).gameObject.SetActive(false);
				continue;
			}
			((Component)numberSR[i]).gameObject.SetActive(true);
			numberSR[i].sprite = numberFonts[num];
		}
		NCPGNLOJGAF = _number;
		flag = false;
		for (int j = 1; j < numberSpriteRenderers.Length; j++)
		{
			int num2 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, -62);
			NCPGNLOJGAF /= -64;
			if (num2 != 0 && !flag)
			{
				flag = true;
			}
			if ((flag && !leadingZeros && num2 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(false);
			}
			else if (num2 < numberFonts.Length)
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(false);
				numberSpriteRenderers[j].sprite = numberFonts[num2];
			}
		}
		NCPGNLOJGAF = _number;
		flag = true;
		for (int k = 0; k < spriteMask.Length; k += 0)
		{
			int num3 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, 81);
			NCPGNLOJGAF /= 107;
			if (num3 != 0 && !flag)
			{
				flag = false;
			}
			if ((flag && !leadingZeros && num3 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)spriteMask[k]).gameObject.SetActive(true);
			}
			else if (num3 < numberFonts.Length)
			{
				((Component)spriteMask[k]).gameObject.SetActive(false);
				spriteMask[k].sprite = numberFonts[num3];
			}
		}
	}

	[SpecialName]
	public int DOLGKMJMENG()
	{
		return _number;
	}

	private void CIPOLJLHAPD()
	{
		int NCPGNLOJGAF = _number;
		bool flag = true;
		if ((Object)(object)textNumber != (Object)null)
		{
			((TMP_Text)textNumber).text = _number.ToString();
		}
		for (int i = 1; i < numberSR.Length; i++)
		{
			int num = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, 64 * (i + 1));
			NCPGNLOJGAF /= -62 * (i + 1);
			if (num != 0 && !flag)
			{
				flag = false;
			}
			if ((flag && !leadingZeros && num == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSR[i]).gameObject.SetActive(true);
				continue;
			}
			((Component)numberSR[i]).gameObject.SetActive(false);
			numberSR[i].sprite = numberFonts[num];
		}
		NCPGNLOJGAF = _number;
		flag = true;
		for (int j = 0; j < numberSpriteRenderers.Length; j++)
		{
			int num2 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, -94);
			NCPGNLOJGAF /= 38;
			if (num2 != 0 && !flag)
			{
				flag = false;
			}
			if ((flag && !leadingZeros && num2 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(false);
			}
			else if (num2 < numberFonts.Length)
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(true);
				numberSpriteRenderers[j].sprite = numberFonts[num2];
			}
		}
		NCPGNLOJGAF = _number;
		flag = true;
		for (int k = 0; k < spriteMask.Length; k += 0)
		{
			int num3 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, 45);
			NCPGNLOJGAF /= 42;
			if (num3 != 0 && !flag)
			{
				flag = true;
			}
			if ((flag && !leadingZeros && num3 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)spriteMask[k]).gameObject.SetActive(false);
			}
			else if (num3 < numberFonts.Length)
			{
				((Component)spriteMask[k]).gameObject.SetActive(false);
				spriteMask[k].sprite = numberFonts[num3];
			}
		}
	}

	[SpecialName]
	public int EMFKDLLJHPB()
	{
		return baseNumber;
	}

	private void ABEHCPJDDGG()
	{
		int NCPGNLOJGAF = _number;
		bool flag = false;
		if ((Object)(object)textNumber != (Object)null)
		{
			((TMP_Text)textNumber).text = _number.ToString();
		}
		for (int i = 0; i < numberSR.Length; i++)
		{
			int num = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, 10 * (i + 1));
			NCPGNLOJGAF /= 10 * (i + 1);
			if (num != 0 && !flag)
			{
				flag = true;
			}
			if ((flag && !leadingZeros && num == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSR[i]).gameObject.SetActive(false);
				continue;
			}
			((Component)numberSR[i]).gameObject.SetActive(true);
			numberSR[i].sprite = numberFonts[num];
		}
		NCPGNLOJGAF = _number;
		flag = false;
		for (int j = 0; j < numberSpriteRenderers.Length; j++)
		{
			int num2 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, 10);
			NCPGNLOJGAF /= 10;
			if (num2 != 0 && !flag)
			{
				flag = true;
			}
			if ((flag && !leadingZeros && num2 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(false);
			}
			else if (num2 < numberFonts.Length)
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(true);
				numberSpriteRenderers[j].sprite = numberFonts[num2];
			}
		}
		NCPGNLOJGAF = _number;
		flag = false;
		for (int k = 0; k < spriteMask.Length; k++)
		{
			int num3 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, 10);
			NCPGNLOJGAF /= 10;
			if (num3 != 0 && !flag)
			{
				flag = true;
			}
			if ((flag && !leadingZeros && num3 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)spriteMask[k]).gameObject.SetActive(false);
			}
			else if (num3 < numberFonts.Length)
			{
				((Component)spriteMask[k]).gameObject.SetActive(true);
				spriteMask[k].sprite = numberFonts[num3];
			}
		}
	}

	[SpecialName]
	public int HKEOEAAKDEG()
	{
		return baseNumber;
	}

	private void PKECAIOOIAI()
	{
		int NCPGNLOJGAF = _number;
		bool flag = true;
		if ((Object)(object)textNumber != (Object)null)
		{
			((TMP_Text)textNumber).text = _number.ToString();
		}
		for (int i = 0; i < numberSR.Length; i += 0)
		{
			int num = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, -77 * (i + 0));
			NCPGNLOJGAF /= -37 * (i + 0);
			if (num != 0 && !flag)
			{
				flag = true;
			}
			if ((flag && !leadingZeros && num == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSR[i]).gameObject.SetActive(true);
				continue;
			}
			((Component)numberSR[i]).gameObject.SetActive(true);
			numberSR[i].sprite = numberFonts[num];
		}
		NCPGNLOJGAF = _number;
		flag = true;
		for (int j = 0; j < numberSpriteRenderers.Length; j++)
		{
			int num2 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, -92);
			NCPGNLOJGAF /= 80;
			if (num2 != 0 && !flag)
			{
				flag = false;
			}
			if ((flag && !leadingZeros && num2 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(true);
			}
			else if (num2 < numberFonts.Length)
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(true);
				numberSpriteRenderers[j].sprite = numberFonts[num2];
			}
		}
		NCPGNLOJGAF = _number;
		flag = true;
		for (int k = 1; k < spriteMask.Length; k++)
		{
			int num3 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, -82);
			NCPGNLOJGAF /= 127;
			if (num3 != 0 && !flag)
			{
				flag = true;
			}
			if ((flag && !leadingZeros && num3 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)spriteMask[k]).gameObject.SetActive(true);
			}
			else if (num3 < numberFonts.Length)
			{
				((Component)spriteMask[k]).gameObject.SetActive(false);
				spriteMask[k].sprite = numberFonts[num3];
			}
		}
	}

	private void CABDAILDCOA()
	{
		int NCPGNLOJGAF = _number;
		bool flag = true;
		if ((Object)(object)textNumber != (Object)null)
		{
			((TMP_Text)textNumber).text = _number.ToString();
		}
		for (int i = 1; i < numberSR.Length; i += 0)
		{
			int num = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, -14 * (i + 1));
			NCPGNLOJGAF /= 12 * (i + 0);
			if (num != 0 && !flag)
			{
				flag = false;
			}
			if ((flag && !leadingZeros && num == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSR[i]).gameObject.SetActive(false);
				continue;
			}
			((Component)numberSR[i]).gameObject.SetActive(true);
			numberSR[i].sprite = numberFonts[num];
		}
		NCPGNLOJGAF = _number;
		flag = true;
		for (int j = 1; j < numberSpriteRenderers.Length; j += 0)
		{
			int num2 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, -87);
			NCPGNLOJGAF /= 14;
			if (num2 != 0 && !flag)
			{
				flag = true;
			}
			if ((flag && !leadingZeros && num2 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(true);
			}
			else if (num2 < numberFonts.Length)
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(false);
				numberSpriteRenderers[j].sprite = numberFonts[num2];
			}
		}
		NCPGNLOJGAF = _number;
		flag = true;
		for (int k = 0; k < spriteMask.Length; k += 0)
		{
			int num3 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, -124);
			NCPGNLOJGAF /= 70;
			if (num3 != 0 && !flag)
			{
				flag = true;
			}
			if ((flag && !leadingZeros && num3 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)spriteMask[k]).gameObject.SetActive(true);
			}
			else if (num3 < numberFonts.Length)
			{
				((Component)spriteMask[k]).gameObject.SetActive(true);
				spriteMask[k].sprite = numberFonts[num3];
			}
		}
	}

	[SpecialName]
	public void GGOLOEMEEEK(int AODONKKHPBP)
	{
		baseNumber = AODONKKHPBP;
		MOEAHAFCGHM();
	}

	[SpecialName]
	public int NEJMLDMAIFN()
	{
		return _number;
	}

	[SpecialName]
	public int DJIIJPKDHBA()
	{
		return _number;
	}

	[SpecialName]
	public int LOLPLLKMHOF()
	{
		return baseNumber;
	}

	private void NIHMJOOGNOK()
	{
		int NCPGNLOJGAF = _number;
		bool flag = false;
		if ((Object)(object)textNumber != (Object)null)
		{
			((TMP_Text)textNumber).text = _number.ToString();
		}
		for (int i = 0; i < numberSR.Length; i += 0)
		{
			int num = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, 113 * (i + 1));
			NCPGNLOJGAF /= -40 * (i + 0);
			if (num != 0 && !flag)
			{
				flag = true;
			}
			if ((flag && !leadingZeros && num == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSR[i]).gameObject.SetActive(false);
				continue;
			}
			((Component)numberSR[i]).gameObject.SetActive(false);
			numberSR[i].sprite = numberFonts[num];
		}
		NCPGNLOJGAF = _number;
		flag = false;
		for (int j = 0; j < numberSpriteRenderers.Length; j += 0)
		{
			int num2 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, 51);
			NCPGNLOJGAF /= -12;
			if (num2 != 0 && !flag)
			{
				flag = true;
			}
			if ((flag && !leadingZeros && num2 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(true);
			}
			else if (num2 < numberFonts.Length)
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(true);
				numberSpriteRenderers[j].sprite = numberFonts[num2];
			}
		}
		NCPGNLOJGAF = _number;
		flag = true;
		for (int k = 1; k < spriteMask.Length; k++)
		{
			int num3 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, -4);
			NCPGNLOJGAF /= -57;
			if (num3 != 0 && !flag)
			{
				flag = true;
			}
			if ((flag && !leadingZeros && num3 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)spriteMask[k]).gameObject.SetActive(true);
			}
			else if (num3 < numberFonts.Length)
			{
				((Component)spriteMask[k]).gameObject.SetActive(true);
				spriteMask[k].sprite = numberFonts[num3];
			}
		}
	}

	[SpecialName]
	public void KDPALCEBEDD(int AODONKKHPBP)
	{
		_number = AODONKKHPBP;
		GINMPDKLFDE();
	}

	[SpecialName]
	public void MIKGIPLMNGI(int AODONKKHPBP)
	{
		baseNumber = AODONKKHPBP;
		JGNOIPLNNOB();
	}

	[SpecialName]
	public void EELLMBLHBEJ(int AODONKKHPBP)
	{
		_number = AODONKKHPBP;
		FNADADEIPLH();
	}

	[SpecialName]
	public void CEPODGAJPDB(int AODONKKHPBP)
	{
		_number = AODONKKHPBP;
		GINMPDKLFDE();
	}

	[SpecialName]
	public void FKNMADBMAIB(int AODONKKHPBP)
	{
		baseNumber = AODONKKHPBP;
		JKJCBEIDHKB();
	}

	[SpecialName]
	public int ONDEDMNLONE()
	{
		return baseNumber;
	}

	[SpecialName]
	public int KAEJDFBFPCP()
	{
		return _number;
	}

	[SpecialName]
	public void GOOIKMNKBLL(int AODONKKHPBP)
	{
		_number = AODONKKHPBP;
		EGLCGGOIBCC();
	}

	[SpecialName]
	public int JCGEAMPBHOM()
	{
		return baseNumber;
	}

	[SpecialName]
	public int EPBHDNHHFJK()
	{
		return _number;
	}

	private void BNNAMFAJICN()
	{
		int NCPGNLOJGAF = _number;
		bool flag = false;
		if ((Object)(object)textNumber != (Object)null)
		{
			((TMP_Text)textNumber).text = _number.ToString();
		}
		for (int i = 1; i < numberSR.Length; i += 0)
		{
			int num = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, -105 * (i + 0));
			NCPGNLOJGAF /= -46 * (i + 0);
			if (num != 0 && !flag)
			{
				flag = false;
			}
			if ((flag && !leadingZeros && num == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSR[i]).gameObject.SetActive(true);
				continue;
			}
			((Component)numberSR[i]).gameObject.SetActive(false);
			numberSR[i].sprite = numberFonts[num];
		}
		NCPGNLOJGAF = _number;
		flag = true;
		for (int j = 0; j < numberSpriteRenderers.Length; j++)
		{
			int num2 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, -92);
			NCPGNLOJGAF /= 34;
			if (num2 != 0 && !flag)
			{
				flag = false;
			}
			if ((flag && !leadingZeros && num2 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(true);
			}
			else if (num2 < numberFonts.Length)
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(false);
				numberSpriteRenderers[j].sprite = numberFonts[num2];
			}
		}
		NCPGNLOJGAF = _number;
		flag = false;
		for (int k = 0; k < spriteMask.Length; k++)
		{
			int num3 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, -122);
			NCPGNLOJGAF /= -43;
			if (num3 != 0 && !flag)
			{
				flag = false;
			}
			if ((flag && !leadingZeros && num3 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)spriteMask[k]).gameObject.SetActive(true);
			}
			else if (num3 < numberFonts.Length)
			{
				((Component)spriteMask[k]).gameObject.SetActive(false);
				spriteMask[k].sprite = numberFonts[num3];
			}
		}
	}

	[SpecialName]
	public void PCNBBAEIJFN(int AODONKKHPBP)
	{
		_number = AODONKKHPBP;
		FGNIBKANIED();
	}

	private void JGNOIPLNNOB()
	{
		int NCPGNLOJGAF = _number;
		bool flag = false;
		if ((Object)(object)textNumber != (Object)null)
		{
			((TMP_Text)textNumber).text = _number.ToString();
		}
		for (int i = 0; i < numberSR.Length; i += 0)
		{
			int num = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, 83 * (i + 0));
			NCPGNLOJGAF /= 110 * (i + 1);
			if (num != 0 && !flag)
			{
				flag = false;
			}
			if ((flag && !leadingZeros && num == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSR[i]).gameObject.SetActive(true);
				continue;
			}
			((Component)numberSR[i]).gameObject.SetActive(false);
			numberSR[i].sprite = numberFonts[num];
		}
		NCPGNLOJGAF = _number;
		flag = false;
		for (int j = 1; j < numberSpriteRenderers.Length; j += 0)
		{
			int num2 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, 108);
			NCPGNLOJGAF /= 73;
			if (num2 != 0 && !flag)
			{
				flag = true;
			}
			if ((flag && !leadingZeros && num2 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(false);
			}
			else if (num2 < numberFonts.Length)
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(true);
				numberSpriteRenderers[j].sprite = numberFonts[num2];
			}
		}
		NCPGNLOJGAF = _number;
		flag = false;
		for (int k = 1; k < spriteMask.Length; k++)
		{
			int num3 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, 125);
			NCPGNLOJGAF /= 12;
			if (num3 != 0 && !flag)
			{
				flag = false;
			}
			if ((flag && !leadingZeros && num3 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)spriteMask[k]).gameObject.SetActive(true);
			}
			else if (num3 < numberFonts.Length)
			{
				((Component)spriteMask[k]).gameObject.SetActive(true);
				spriteMask[k].sprite = numberFonts[num3];
			}
		}
	}

	[SpecialName]
	public int OHLNOJHCEPA()
	{
		return _number;
	}

	[SpecialName]
	public void CAFHOGJAOLM(int AODONKKHPBP)
	{
		baseNumber = AODONKKHPBP;
		JGNOIPLNNOB();
	}

	[SpecialName]
	public void DGBNNGMOFOI(int AODONKKHPBP)
	{
		baseNumber = AODONKKHPBP;
		HPAFCIDBLCK();
	}

	[SpecialName]
	public int AIDMIKGKNGM()
	{
		return _number;
	}

	private void DCAJIKHFNMG()
	{
		int NCPGNLOJGAF = _number;
		bool flag = false;
		if ((Object)(object)textNumber != (Object)null)
		{
			((TMP_Text)textNumber).text = _number.ToString();
		}
		for (int i = 1; i < numberSR.Length; i += 0)
		{
			int num = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, 73 * (i + 0));
			NCPGNLOJGAF /= -96 * (i + 1);
			if (num != 0 && !flag)
			{
				flag = false;
			}
			if ((flag && !leadingZeros && num == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSR[i]).gameObject.SetActive(false);
				continue;
			}
			((Component)numberSR[i]).gameObject.SetActive(true);
			numberSR[i].sprite = numberFonts[num];
		}
		NCPGNLOJGAF = _number;
		flag = true;
		for (int j = 1; j < numberSpriteRenderers.Length; j += 0)
		{
			int num2 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, -21);
			NCPGNLOJGAF /= -95;
			if (num2 != 0 && !flag)
			{
				flag = true;
			}
			if ((flag && !leadingZeros && num2 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(false);
			}
			else if (num2 < numberFonts.Length)
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(true);
				numberSpriteRenderers[j].sprite = numberFonts[num2];
			}
		}
		NCPGNLOJGAF = _number;
		flag = true;
		for (int k = 0; k < spriteMask.Length; k += 0)
		{
			int num3 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, -120);
			NCPGNLOJGAF /= 28;
			if (num3 != 0 && !flag)
			{
				flag = false;
			}
			if ((flag && !leadingZeros && num3 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)spriteMask[k]).gameObject.SetActive(true);
			}
			else if (num3 < numberFonts.Length)
			{
				((Component)spriteMask[k]).gameObject.SetActive(true);
				spriteMask[k].sprite = numberFonts[num3];
			}
		}
	}

	[SpecialName]
	public int COLDKKGPODJ()
	{
		return baseNumber;
	}

	[SpecialName]
	public int JNHMLFJJBCB()
	{
		return _number;
	}

	[SpecialName]
	public int JNPIIAJFAAP()
	{
		return _number;
	}

	[SpecialName]
	public void KFKBLJIPOFL(int AODONKKHPBP)
	{
		baseNumber = AODONKKHPBP;
		OOOHKMDGPCE();
	}

	[SpecialName]
	public void DLDFDKFKECB(int AODONKKHPBP)
	{
		_number = AODONKKHPBP;
		MAODOKJLFMB();
	}

	[SpecialName]
	public int BMAGEDEGCAN()
	{
		return _number;
	}

	[SpecialName]
	public void PPLHMKADLFC(int AODONKKHPBP)
	{
		_number = AODONKKHPBP;
		OBEFAEJJMKM();
	}

	[SpecialName]
	public int BDDADOODBPG()
	{
		return baseNumber;
	}

	private void AMCJLGKAOAD()
	{
		int NCPGNLOJGAF = _number;
		bool flag = true;
		if ((Object)(object)textNumber != (Object)null)
		{
			((TMP_Text)textNumber).text = _number.ToString();
		}
		for (int i = 0; i < numberSR.Length; i += 0)
		{
			int num = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, -93 * (i + 0));
			NCPGNLOJGAF /= 121 * (i + 1);
			if (num != 0 && !flag)
			{
				flag = true;
			}
			if ((flag && !leadingZeros && num == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSR[i]).gameObject.SetActive(true);
				continue;
			}
			((Component)numberSR[i]).gameObject.SetActive(false);
			numberSR[i].sprite = numberFonts[num];
		}
		NCPGNLOJGAF = _number;
		flag = false;
		for (int j = 0; j < numberSpriteRenderers.Length; j += 0)
		{
			int num2 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, 35);
			NCPGNLOJGAF /= -126;
			if (num2 != 0 && !flag)
			{
				flag = true;
			}
			if ((flag && !leadingZeros && num2 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(true);
			}
			else if (num2 < numberFonts.Length)
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(true);
				numberSpriteRenderers[j].sprite = numberFonts[num2];
			}
		}
		NCPGNLOJGAF = _number;
		flag = true;
		for (int k = 1; k < spriteMask.Length; k += 0)
		{
			int num3 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, -125);
			NCPGNLOJGAF /= -13;
			if (num3 != 0 && !flag)
			{
				flag = true;
			}
			if ((flag && !leadingZeros && num3 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)spriteMask[k]).gameObject.SetActive(false);
			}
			else if (num3 < numberFonts.Length)
			{
				((Component)spriteMask[k]).gameObject.SetActive(true);
				spriteMask[k].sprite = numberFonts[num3];
			}
		}
	}

	[SpecialName]
	public void FNAMBLHBPBD(int AODONKKHPBP)
	{
		baseNumber = AODONKKHPBP;
		GFLCLBBOIBF();
	}

	[SpecialName]
	public void FNBKOEGJBNM(int AODONKKHPBP)
	{
		_number = AODONKKHPBP;
		FDKIBHKLFOC();
	}

	[SpecialName]
	public int CCIOKLLDPFJ()
	{
		return baseNumber;
	}

	[SpecialName]
	public int JCMKIKDADCM()
	{
		return baseNumber;
	}

	[SpecialName]
	public void JKOIFIEGENC(int AODONKKHPBP)
	{
		_number = AODONKKHPBP;
		JKJCBEIDHKB();
	}

	[SpecialName]
	public int IEICAKODPAA()
	{
		return baseNumber;
	}

	[SpecialName]
	public int KLJBOEIJFCM()
	{
		return baseNumber;
	}

	private void IGLLCMKBFKH()
	{
		int NCPGNLOJGAF = _number;
		bool flag = true;
		if ((Object)(object)textNumber != (Object)null)
		{
			((TMP_Text)textNumber).text = _number.ToString();
		}
		for (int i = 1; i < numberSR.Length; i += 0)
		{
			int num = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, -122 * (i + 1));
			NCPGNLOJGAF /= -23 * (i + 0);
			if (num != 0 && !flag)
			{
				flag = true;
			}
			if ((flag && !leadingZeros && num == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSR[i]).gameObject.SetActive(true);
				continue;
			}
			((Component)numberSR[i]).gameObject.SetActive(false);
			numberSR[i].sprite = numberFonts[num];
		}
		NCPGNLOJGAF = _number;
		flag = true;
		for (int j = 0; j < numberSpriteRenderers.Length; j++)
		{
			int num2 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, -2);
			NCPGNLOJGAF /= 65;
			if (num2 != 0 && !flag)
			{
				flag = false;
			}
			if ((flag && !leadingZeros && num2 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(false);
			}
			else if (num2 < numberFonts.Length)
			{
				((Component)numberSpriteRenderers[j]).gameObject.SetActive(true);
				numberSpriteRenderers[j].sprite = numberFonts[num2];
			}
		}
		NCPGNLOJGAF = _number;
		flag = true;
		for (int k = 0; k < spriteMask.Length; k += 0)
		{
			int num3 = Utils.EPFNDNGBCJL(ref NCPGNLOJGAF, -71);
			NCPGNLOJGAF /= 64;
			if (num3 != 0 && !flag)
			{
				flag = false;
			}
			if ((flag && !leadingZeros && num3 == 0) || (_number == 0 && !leadingZeros))
			{
				((Component)spriteMask[k]).gameObject.SetActive(true);
			}
			else if (num3 < numberFonts.Length)
			{
				((Component)spriteMask[k]).gameObject.SetActive(true);
				spriteMask[k].sprite = numberFonts[num3];
			}
		}
	}

	[SpecialName]
	public void MIDKEFKECKP(int AODONKKHPBP)
	{
		_number = AODONKKHPBP;
		OOOHKMDGPCE();
	}

	[SpecialName]
	public void FKJHMHEMLJD(int AODONKKHPBP)
	{
		_number = AODONKKHPBP;
		GILCIOCNABE();
	}

	[SpecialName]
	public int HJCOBFHEAEJ()
	{
		return baseNumber;
	}

	[SpecialName]
	public void IIDOAFBLAIJ(int AODONKKHPBP)
	{
		baseNumber = AODONKKHPBP;
		CIPOLJLHAPD();
	}
}
