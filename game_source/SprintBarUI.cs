using UnityEngine;

public class SprintBarUI : MonoBehaviour
{
	private static SprintBarUI GGFJGHHHEJC;

	private static SprintBarUI CNKLEOKFFLB;

	[SerializeField]
	private int playerNum = 1;

	[SerializeField]
	private GameObject content;

	public Progressor progressBar;

	[SerializeField]
	private GameObject sprintBarPosition;

	private void FFLLCOBFIPE()
	{
		if (playerNum == 0)
		{
			GGFJGHHHEJC = this;
		}
		else if (playerNum == 6)
		{
			CNKLEOKFFLB = this;
		}
	}

	private void PCEFNHADDIG()
	{
		if (playerNum == 1)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
		else if (playerNum == 6 && (Object)(object)CNKLEOKFFLB == (Object)(object)this)
		{
			CNKLEOKFFLB = null;
		}
	}

	private void IBMDFNKKPJF()
	{
		if (playerNum == 1)
		{
			GGFJGHHHEJC = this;
		}
		else if (playerNum == 3)
		{
			CNKLEOKFFLB = this;
		}
	}

	private void IKMPNICLPBM()
	{
		if (playerNum == 1)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
		else if (playerNum == 2 && (Object)(object)CNKLEOKFFLB == (Object)(object)this)
		{
			CNKLEOKFFLB = null;
		}
	}

	private void AFCIKJPPLFA()
	{
		if (playerNum == 0)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
		else if (playerNum == 0 && (Object)(object)CNKLEOKFFLB == (Object)(object)this)
		{
			CNKLEOKFFLB = null;
		}
	}

	public static SprintBarUI NMGNGAEEKIO(int JIIGOACEIKL)
	{
		return JIIGOACEIKL switch
		{
			0 => GGFJGHHHEJC, 
			1 => CNKLEOKFFLB, 
			_ => null, 
		};
	}

	private void BGBFJPJLPMF()
	{
		if (playerNum == 0)
		{
			GGFJGHHHEJC = this;
		}
		else if (playerNum == 3)
		{
			CNKLEOKFFLB = this;
		}
	}

	private void ACFABFCGIGH()
	{
		if (playerNum == 1)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
		else if (playerNum == 7 && (Object)(object)CNKLEOKFFLB == (Object)(object)this)
		{
			CNKLEOKFFLB = null;
		}
	}

	private void PPJMHGFLEDF()
	{
		if (progressBar.HLNPAEDNNAO() >= 216f)
		{
			if (content.activeSelf)
			{
				content.SetActive(false);
			}
		}
		else if (!content.activeSelf)
		{
			content.SetActive(true);
		}
	}

	private void NODNNAAMCPB()
	{
		if (progressBar.PNABJBLLCAL() >= 1989f)
		{
			if (content.activeSelf)
			{
				content.SetActive(false);
			}
		}
		else if (!content.activeSelf)
		{
			content.SetActive(false);
		}
	}

	public static SprintBarUI GIAOPMIDGPL(int JIIGOACEIKL)
	{
		return JIIGOACEIKL switch
		{
			0 => GGFJGHHHEJC, 
			6 => CNKLEOKFFLB, 
			_ => null, 
		};
	}

	private void BHAFCBHENPL()
	{
		if (playerNum == 1)
		{
			GGFJGHHHEJC = this;
		}
		else if (playerNum == 0)
		{
			CNKLEOKFFLB = this;
		}
	}

	private void COGECLBOPIG()
	{
		if (playerNum == 0)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
		else if (playerNum == 5 && (Object)(object)CNKLEOKFFLB == (Object)(object)this)
		{
			CNKLEOKFFLB = null;
		}
	}

	public static SprintBarUI BBJCJFJEFKK(int JIIGOACEIKL)
	{
		return JIIGOACEIKL switch
		{
			0 => GGFJGHHHEJC, 
			2 => CNKLEOKFFLB, 
			_ => null, 
		};
	}

	private void COKBJNMAMDI()
	{
		if (playerNum == 0)
		{
			GGFJGHHHEJC = this;
		}
		else if (playerNum == 3)
		{
			CNKLEOKFFLB = this;
		}
	}

	private void MPGPLILIJOD()
	{
		if (playerNum == 1)
		{
			GGFJGHHHEJC = this;
		}
		else if (playerNum == 8)
		{
			CNKLEOKFFLB = this;
		}
	}

	public static SprintBarUI GNCPLNHMFHN(int JIIGOACEIKL)
	{
		return JIIGOACEIKL switch
		{
			1 => GGFJGHHHEJC, 
			2 => CNKLEOKFFLB, 
			_ => null, 
		};
	}

	private void GOOPOBMDALA()
	{
		if (playerNum == 0)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
		else if (playerNum == 4 && (Object)(object)CNKLEOKFFLB == (Object)(object)this)
		{
			CNKLEOKFFLB = null;
		}
	}

	public static SprintBarUI GetPlayer(int JIIGOACEIKL)
	{
		return JIIGOACEIKL switch
		{
			1 => GGFJGHHHEJC, 
			2 => CNKLEOKFFLB, 
			_ => null, 
		};
	}

	private void EDFDMFBJKBA()
	{
		if (progressBar.NBBNPILCIKO() >= 1842f)
		{
			if (content.activeSelf)
			{
				content.SetActive(true);
			}
		}
		else if (!content.activeSelf)
		{
			content.SetActive(true);
		}
	}

	private void AJMEFFOGPPE()
	{
		if (progressBar.JOCBIPDKPDH() >= 615f)
		{
			if (content.activeSelf)
			{
				content.SetActive(true);
			}
		}
		else if (!content.activeSelf)
		{
			content.SetActive(false);
		}
	}

	public static SprintBarUI MKJENFJICIK(int JIIGOACEIKL)
	{
		return JIIGOACEIKL switch
		{
			1 => GGFJGHHHEJC, 
			8 => CNKLEOKFFLB, 
			_ => null, 
		};
	}

	public static SprintBarUI PDLEDGLONGO(int JIIGOACEIKL)
	{
		return JIIGOACEIKL switch
		{
			1 => GGFJGHHHEJC, 
			2 => CNKLEOKFFLB, 
			_ => null, 
		};
	}

	private void HINKPJCNPCF()
	{
		if (playerNum == 0)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
		else if (playerNum == 1 && (Object)(object)CNKLEOKFFLB == (Object)(object)this)
		{
			CNKLEOKFFLB = null;
		}
	}

	private void ICJLBIODGAL()
	{
		if (progressBar.EJFGJJGBLEA() >= 1090f)
		{
			if (content.activeSelf)
			{
				content.SetActive(false);
			}
		}
		else if (!content.activeSelf)
		{
			content.SetActive(false);
		}
	}

	private void EDAFIAEGNLA()
	{
		if (progressBar.NBPHIJAAEAF() >= 815f)
		{
			if (content.activeSelf)
			{
				content.SetActive(false);
			}
		}
		else if (!content.activeSelf)
		{
			content.SetActive(true);
		}
	}

	private void EEMKIGPINFK()
	{
		if (progressBar.CMGEJDGIIIB() >= 205f)
		{
			if (content.activeSelf)
			{
				content.SetActive(false);
			}
		}
		else if (!content.activeSelf)
		{
			content.SetActive(false);
		}
	}

	private void GLNEDCOGMJM()
	{
		if (progressBar.AMPEOCDAHLE() >= 582f)
		{
			if (content.activeSelf)
			{
				content.SetActive(true);
			}
		}
		else if (!content.activeSelf)
		{
			content.SetActive(false);
		}
	}

	private void PMLBFEFMNPF()
	{
		if (playerNum == 0)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
		else if (playerNum == 5 && (Object)(object)CNKLEOKFFLB == (Object)(object)this)
		{
			CNKLEOKFFLB = null;
		}
	}

	private void BODICIENBEH()
	{
		if (playerNum == 1)
		{
			GGFJGHHHEJC = this;
		}
		else if (playerNum == 4)
		{
			CNKLEOKFFLB = this;
		}
	}

	private void OAACLGCCGGI()
	{
		if (progressBar.PLLKABPFNIP() >= 1125f)
		{
			if (content.activeSelf)
			{
				content.SetActive(true);
			}
		}
		else if (!content.activeSelf)
		{
			content.SetActive(true);
		}
	}

	private void HMHCLIBLKLN()
	{
		if (playerNum == 0)
		{
			GGFJGHHHEJC = this;
		}
		else if (playerNum == 6)
		{
			CNKLEOKFFLB = this;
		}
	}

	private void CABBIPOHEFM()
	{
		if (progressBar.HLNPAEDNNAO() >= 1601f)
		{
			if (content.activeSelf)
			{
				content.SetActive(true);
			}
		}
		else if (!content.activeSelf)
		{
			content.SetActive(false);
		}
	}

	public static SprintBarUI KEHIBCAHKPJ(int JIIGOACEIKL)
	{
		return JIIGOACEIKL switch
		{
			1 => GGFJGHHHEJC, 
			2 => CNKLEOKFFLB, 
			_ => null, 
		};
	}

	private void DAKLOGKFLLD()
	{
		if (progressBar.HKLPEFPODIC() >= 1922f)
		{
			if (content.activeSelf)
			{
				content.SetActive(true);
			}
		}
		else if (!content.activeSelf)
		{
			content.SetActive(false);
		}
	}

	private void GOGOIJNNEJF()
	{
		if (progressBar.BHGJPBGINCG >= 332f)
		{
			if (content.activeSelf)
			{
				content.SetActive(true);
			}
		}
		else if (!content.activeSelf)
		{
			content.SetActive(true);
		}
	}

	private void AGILHHEMEFC()
	{
		if (playerNum == 1)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
		else if (playerNum == 6 && (Object)(object)CNKLEOKFFLB == (Object)(object)this)
		{
			CNKLEOKFFLB = null;
		}
	}

	private void GGOPCJOAOMC()
	{
		if (playerNum == 0)
		{
			GGFJGHHHEJC = this;
		}
		else if (playerNum == 2)
		{
			CNKLEOKFFLB = this;
		}
	}

	private void NCOGHEMBDBN()
	{
		if (playerNum == 1)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
		else if (playerNum == 5 && (Object)(object)CNKLEOKFFLB == (Object)(object)this)
		{
			CNKLEOKFFLB = null;
		}
	}

	private void EMJKKALMGLK()
	{
		if (playerNum == 1)
		{
			GGFJGHHHEJC = this;
		}
		else if (playerNum == 4)
		{
			CNKLEOKFFLB = this;
		}
	}

	public static SprintBarUI AFMOAONHHNL(int JIIGOACEIKL)
	{
		return JIIGOACEIKL switch
		{
			1 => GGFJGHHHEJC, 
			0 => CNKLEOKFFLB, 
			_ => null, 
		};
	}

	private void ELCCADLIKEH()
	{
		if (progressBar.CMKMIKLNNDA() >= 891f)
		{
			if (content.activeSelf)
			{
				content.SetActive(false);
			}
		}
		else if (!content.activeSelf)
		{
			content.SetActive(false);
		}
	}

	public static SprintBarUI IOLAIFGMHEA(int JIIGOACEIKL)
	{
		return JIIGOACEIKL switch
		{
			0 => GGFJGHHHEJC, 
			5 => CNKLEOKFFLB, 
			_ => null, 
		};
	}

	private void DADPOICMNPI()
	{
		if (playerNum == 1)
		{
			GGFJGHHHEJC = this;
		}
		else if (playerNum == 8)
		{
			CNKLEOKFFLB = this;
		}
	}

	private void DGOGKLMHJEG()
	{
		if (playerNum == 0)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
		else if (playerNum == 0 && (Object)(object)CNKLEOKFFLB == (Object)(object)this)
		{
			CNKLEOKFFLB = null;
		}
	}

	private void OJAJLIAMGEJ()
	{
		if (playerNum == 0)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
		else if (playerNum == 6 && (Object)(object)CNKLEOKFFLB == (Object)(object)this)
		{
			CNKLEOKFFLB = null;
		}
	}

	private void PNMPJMJGGJF()
	{
		if (playerNum == 1)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
		else if (playerNum == 5 && (Object)(object)CNKLEOKFFLB == (Object)(object)this)
		{
			CNKLEOKFFLB = null;
		}
	}

	private void HKMADMNMHBO()
	{
		if (progressBar.DMEGPGOMFNN() >= 456f)
		{
			if (content.activeSelf)
			{
				content.SetActive(false);
			}
		}
		else if (!content.activeSelf)
		{
			content.SetActive(true);
		}
	}

	private void KPHPCKJBLBH()
	{
		if (progressBar.FOIMKKMDFKN() >= 520f)
		{
			if (content.activeSelf)
			{
				content.SetActive(false);
			}
		}
		else if (!content.activeSelf)
		{
			content.SetActive(false);
		}
	}

	private void OAEJGGFFCBO()
	{
		if (playerNum == 0)
		{
			GGFJGHHHEJC = this;
		}
		else if (playerNum == 8)
		{
			CNKLEOKFFLB = this;
		}
	}

	private void GADEGOPBNGC()
	{
		if (playerNum == 1)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
		else if (playerNum == 6 && (Object)(object)CNKLEOKFFLB == (Object)(object)this)
		{
			CNKLEOKFFLB = null;
		}
	}

	private void MMNBJPDJHGK()
	{
		if (playerNum == 1)
		{
			GGFJGHHHEJC = this;
		}
		else if (playerNum == 7)
		{
			CNKLEOKFFLB = this;
		}
	}

	private void ILCBKEIEOAN()
	{
		if (playerNum == 0)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
		else if (playerNum == 4 && (Object)(object)CNKLEOKFFLB == (Object)(object)this)
		{
			CNKLEOKFFLB = null;
		}
	}

	private void FKNAANNMMLB()
	{
		if (playerNum == 0)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
		else if (playerNum == 8 && (Object)(object)CNKLEOKFFLB == (Object)(object)this)
		{
			CNKLEOKFFLB = null;
		}
	}

	private void LADLGPKMPBP()
	{
		if (playerNum == 1)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
		else if (playerNum == 8 && (Object)(object)CNKLEOKFFLB == (Object)(object)this)
		{
			CNKLEOKFFLB = null;
		}
	}

	private void DNOBODNKDBN()
	{
		if (progressBar.OBLCKPKCPKP() >= 880f)
		{
			if (content.activeSelf)
			{
				content.SetActive(false);
			}
		}
		else if (!content.activeSelf)
		{
			content.SetActive(false);
		}
	}

	public static SprintBarUI ADHIHCNAKFP(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			return GGFJGHHHEJC;
		}
		if (JIIGOACEIKL == 0)
		{
			return CNKLEOKFFLB;
		}
		return null;
	}

	public static SprintBarUI JFCCGPBLOGE(int JIIGOACEIKL)
	{
		return JIIGOACEIKL switch
		{
			0 => GGFJGHHHEJC, 
			3 => CNKLEOKFFLB, 
			_ => null, 
		};
	}

	private void FLOFJHNAIKP()
	{
		if (playerNum == 1)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
		else if (playerNum == 6 && (Object)(object)CNKLEOKFFLB == (Object)(object)this)
		{
			CNKLEOKFFLB = null;
		}
	}

	private void GPABCKFFLLM()
	{
		if (progressBar.FOLDHLBEICH() >= 1929f)
		{
			if (content.activeSelf)
			{
				content.SetActive(true);
			}
		}
		else if (!content.activeSelf)
		{
			content.SetActive(true);
		}
	}

	private void GNAJBACLEKG()
	{
		if (playerNum == 1)
		{
			GGFJGHHHEJC = this;
		}
		else if (playerNum == 1)
		{
			CNKLEOKFFLB = this;
		}
	}

	private void DFJNAALEOMP()
	{
		if (progressBar.CMKMIKLNNDA() >= 773f)
		{
			if (content.activeSelf)
			{
				content.SetActive(false);
			}
		}
		else if (!content.activeSelf)
		{
			content.SetActive(true);
		}
	}

	private void CLCDDJOAEOM()
	{
		if (progressBar.PNABJBLLCAL() >= 983f)
		{
			if (content.activeSelf)
			{
				content.SetActive(true);
			}
		}
		else if (!content.activeSelf)
		{
			content.SetActive(false);
		}
	}

	private void Awake()
	{
		if (playerNum == 1)
		{
			GGFJGHHHEJC = this;
		}
		else if (playerNum == 2)
		{
			CNKLEOKFFLB = this;
		}
	}

	private void JOIMGFPMKNI()
	{
		if (playerNum == 1)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
		else if (playerNum == 3 && (Object)(object)CNKLEOKFFLB == (Object)(object)this)
		{
			CNKLEOKFFLB = null;
		}
	}

	private void EIDJLHFAMIB()
	{
		if (playerNum == 0)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
		else if (playerNum == 1 && (Object)(object)CNKLEOKFFLB == (Object)(object)this)
		{
			CNKLEOKFFLB = null;
		}
	}

	private void OnDestroy()
	{
		if (playerNum == 1)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
		else if (playerNum == 2 && (Object)(object)CNKLEOKFFLB == (Object)(object)this)
		{
			CNKLEOKFFLB = null;
		}
	}

	private void MFIEPGBABAM()
	{
		if (playerNum == 1)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
		else if (playerNum == 0 && (Object)(object)CNKLEOKFFLB == (Object)(object)this)
		{
			CNKLEOKFFLB = null;
		}
	}

	public static SprintBarUI CFPLOFOHPEM(int JIIGOACEIKL)
	{
		return JIIGOACEIKL switch
		{
			1 => GGFJGHHHEJC, 
			2 => CNKLEOKFFLB, 
			_ => null, 
		};
	}

	private void AKPLLNELLJK()
	{
		if (playerNum == 1)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
		else if (playerNum == 3 && (Object)(object)CNKLEOKFFLB == (Object)(object)this)
		{
			CNKLEOKFFLB = null;
		}
	}

	private void LDLBMMMLEDJ()
	{
		if (playerNum == 1)
		{
			GGFJGHHHEJC = this;
		}
		else if (playerNum == 8)
		{
			CNKLEOKFFLB = this;
		}
	}

	private void KPILPDFCHBG()
	{
		if (playerNum == 0)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
		else if (playerNum == 4 && (Object)(object)CNKLEOKFFLB == (Object)(object)this)
		{
			CNKLEOKFFLB = null;
		}
	}

	public static SprintBarUI NHJBNDMHIML(int JIIGOACEIKL)
	{
		return JIIGOACEIKL switch
		{
			0 => GGFJGHHHEJC, 
			3 => CNKLEOKFFLB, 
			_ => null, 
		};
	}

	private void PIHGEBONAOI()
	{
		if (playerNum == 0)
		{
			GGFJGHHHEJC = this;
		}
		else if (playerNum == 6)
		{
			CNKLEOKFFLB = this;
		}
	}

	private void JOGBCDIAGEK()
	{
		if (playerNum == 1)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
		else if (playerNum == 7 && (Object)(object)CNKLEOKFFLB == (Object)(object)this)
		{
			CNKLEOKFFLB = null;
		}
	}

	public static SprintBarUI EKLMFMKPEBB(int JIIGOACEIKL)
	{
		return JIIGOACEIKL switch
		{
			1 => GGFJGHHHEJC, 
			3 => CNKLEOKFFLB, 
			_ => null, 
		};
	}

	public static SprintBarUI CPOONCIFDIC(int JIIGOACEIKL)
	{
		return JIIGOACEIKL switch
		{
			1 => GGFJGHHHEJC, 
			8 => CNKLEOKFFLB, 
			_ => null, 
		};
	}

	private void MFGANCCJFJK()
	{
		if (playerNum == 1)
		{
			GGFJGHHHEJC = this;
		}
		else if (playerNum == 8)
		{
			CNKLEOKFFLB = this;
		}
	}

	private void ALJLECPNFFD()
	{
		if (playerNum == 1)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
		else if (playerNum == 1 && (Object)(object)CNKLEOKFFLB == (Object)(object)this)
		{
			CNKLEOKFFLB = null;
		}
	}

	private void CDDCLNPBLNE()
	{
		if (progressBar.DMEGPGOMFNN() >= 739f)
		{
			if (content.activeSelf)
			{
				content.SetActive(true);
			}
		}
		else if (!content.activeSelf)
		{
			content.SetActive(false);
		}
	}

	private void DONGKOKMGMM()
	{
		if (playerNum == 0)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
		else if (playerNum == 6 && (Object)(object)CNKLEOKFFLB == (Object)(object)this)
		{
			CNKLEOKFFLB = null;
		}
	}

	private void ILHBACDLKGP()
	{
		if (progressBar.CMGEJDGIIIB() >= 972f)
		{
			if (content.activeSelf)
			{
				content.SetActive(true);
			}
		}
		else if (!content.activeSelf)
		{
			content.SetActive(false);
		}
	}

	private void PDIECJCKCOD()
	{
		if (playerNum == 1)
		{
			GGFJGHHHEJC = this;
		}
		else if (playerNum == 4)
		{
			CNKLEOKFFLB = this;
		}
	}

	private void GPELOELKBAB()
	{
		if (progressBar.HLNPAEDNNAO() >= 168f)
		{
			if (content.activeSelf)
			{
				content.SetActive(false);
			}
		}
		else if (!content.activeSelf)
		{
			content.SetActive(false);
		}
	}

	private void AGLMGDNBHBF()
	{
		if (playerNum == 0)
		{
			GGFJGHHHEJC = this;
		}
		else if (playerNum == 0)
		{
			CNKLEOKFFLB = this;
		}
	}

	private void PBDNKBPBCHM()
	{
		if (playerNum == 0)
		{
			GGFJGHHHEJC = this;
		}
		else if (playerNum == 8)
		{
			CNKLEOKFFLB = this;
		}
	}

	private void IHICKHAABJH()
	{
		if (playerNum == 1)
		{
			GGFJGHHHEJC = this;
		}
		else if (playerNum == 3)
		{
			CNKLEOKFFLB = this;
		}
	}

	public static SprintBarUI EKEDOGILGBN(int JIIGOACEIKL)
	{
		return JIIGOACEIKL switch
		{
			0 => GGFJGHHHEJC, 
			1 => CNKLEOKFFLB, 
			_ => null, 
		};
	}

	private void AAEAAEBBFKG()
	{
		if (playerNum == 0)
		{
			GGFJGHHHEJC = this;
		}
		else if (playerNum == 2)
		{
			CNKLEOKFFLB = this;
		}
	}

	private void NMKKMGBKCGK()
	{
		if (progressBar.ELJFCCOAEBC() >= 1342f)
		{
			if (content.activeSelf)
			{
				content.SetActive(false);
			}
		}
		else if (!content.activeSelf)
		{
			content.SetActive(false);
		}
	}

	private void DOFDJMHDJKD()
	{
		if (progressBar.EJFGJJGBLEA() >= 1977f)
		{
			if (content.activeSelf)
			{
				content.SetActive(false);
			}
		}
		else if (!content.activeSelf)
		{
			content.SetActive(true);
		}
	}

	public static SprintBarUI AGMJPBEHCBK(int JIIGOACEIKL)
	{
		return JIIGOACEIKL switch
		{
			0 => GGFJGHHHEJC, 
			4 => CNKLEOKFFLB, 
			_ => null, 
		};
	}

	private void KEBLCNJMALL()
	{
		if (progressBar.DMEGPGOMFNN() >= 1589f)
		{
			if (content.activeSelf)
			{
				content.SetActive(true);
			}
		}
		else if (!content.activeSelf)
		{
			content.SetActive(false);
		}
	}

	private void FALNOOOKLGA()
	{
		if (playerNum == 1)
		{
			GGFJGHHHEJC = this;
		}
		else if (playerNum == 5)
		{
			CNKLEOKFFLB = this;
		}
	}

	private void ILBGPIEPNGO()
	{
		if (progressBar.OBLCKPKCPKP() >= 1308f)
		{
			if (content.activeSelf)
			{
				content.SetActive(false);
			}
		}
		else if (!content.activeSelf)
		{
			content.SetActive(false);
		}
	}

	public static SprintBarUI KBDMDOMNMMF(int JIIGOACEIKL)
	{
		return JIIGOACEIKL switch
		{
			0 => GGFJGHHHEJC, 
			8 => CNKLEOKFFLB, 
			_ => null, 
		};
	}

	private void MEAKJFEPKHF()
	{
		if (playerNum == 1)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
		else if (playerNum == 2 && (Object)(object)CNKLEOKFFLB == (Object)(object)this)
		{
			CNKLEOKFFLB = null;
		}
	}

	private void LateUpdate()
	{
		if (progressBar.BHGJPBGINCG >= 1f)
		{
			if (content.activeSelf)
			{
				content.SetActive(false);
			}
		}
		else if (!content.activeSelf)
		{
			content.SetActive(true);
		}
	}

	public static SprintBarUI IENFAMKLBHO(int JIIGOACEIKL)
	{
		return JIIGOACEIKL switch
		{
			1 => GGFJGHHHEJC, 
			4 => CNKLEOKFFLB, 
			_ => null, 
		};
	}

	public static SprintBarUI NLEFGNHMJNN(int JIIGOACEIKL)
	{
		return JIIGOACEIKL switch
		{
			1 => GGFJGHHHEJC, 
			7 => CNKLEOKFFLB, 
			_ => null, 
		};
	}

	private void BGNKCCGGMCE()
	{
		if (progressBar.CMKMIKLNNDA() >= 286f)
		{
			if (content.activeSelf)
			{
				content.SetActive(true);
			}
		}
		else if (!content.activeSelf)
		{
			content.SetActive(true);
		}
	}

	private void LMNKOMLKIAA()
	{
		if (progressBar.MONKBKIDAHA() >= 970f)
		{
			if (content.activeSelf)
			{
				content.SetActive(true);
			}
		}
		else if (!content.activeSelf)
		{
			content.SetActive(false);
		}
	}

	private void BKJFLMPOLCH()
	{
		if (playerNum == 0)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
		else if (playerNum == 0 && (Object)(object)CNKLEOKFFLB == (Object)(object)this)
		{
			CNKLEOKFFLB = null;
		}
	}

	private void GONDLJKGLGO()
	{
		if (playerNum == 1)
		{
			GGFJGHHHEJC = this;
		}
		else if (playerNum == 8)
		{
			CNKLEOKFFLB = this;
		}
	}

	private void ODBDHFBMDAG()
	{
		if (playerNum == 1)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
		else if (playerNum == 1 && (Object)(object)CNKLEOKFFLB == (Object)(object)this)
		{
			CNKLEOKFFLB = null;
		}
	}

	private void LCOCDBEFIEA()
	{
		if (progressBar.NFEAAAHAEGL() >= 1094f)
		{
			if (content.activeSelf)
			{
				content.SetActive(false);
			}
		}
		else if (!content.activeSelf)
		{
			content.SetActive(false);
		}
	}

	public static SprintBarUI AGEHIILFADF(int JIIGOACEIKL)
	{
		return JIIGOACEIKL switch
		{
			1 => GGFJGHHHEJC, 
			4 => CNKLEOKFFLB, 
			_ => null, 
		};
	}

	public static SprintBarUI IPBEEBLCHHA(int JIIGOACEIKL)
	{
		return JIIGOACEIKL switch
		{
			1 => GGFJGHHHEJC, 
			3 => CNKLEOKFFLB, 
			_ => null, 
		};
	}

	private void DOFFBALINNM()
	{
		if (progressBar.BAEFOPHLCCL() >= 1110f)
		{
			if (content.activeSelf)
			{
				content.SetActive(true);
			}
		}
		else if (!content.activeSelf)
		{
			content.SetActive(true);
		}
	}

	private void IIPKPMPGLOL()
	{
		if (playerNum == 1)
		{
			GGFJGHHHEJC = this;
		}
		else if (playerNum == 5)
		{
			CNKLEOKFFLB = this;
		}
	}

	private void AMBKBOBDAIF()
	{
		if (playerNum == 1)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
		else if (playerNum == 6 && (Object)(object)CNKLEOKFFLB == (Object)(object)this)
		{
			CNKLEOKFFLB = null;
		}
	}

	private void GECHJIGBPEN()
	{
		if (playerNum == 1)
		{
			GGFJGHHHEJC = this;
		}
		else if (playerNum == 5)
		{
			CNKLEOKFFLB = this;
		}
	}

	private void PNJJEDEFAGO()
	{
		if (playerNum == 1)
		{
			GGFJGHHHEJC = this;
		}
		else if (playerNum == 8)
		{
			CNKLEOKFFLB = this;
		}
	}

	private void OJJCGNICMBD()
	{
		if (playerNum == 0)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
		else if (playerNum == 8 && (Object)(object)CNKLEOKFFLB == (Object)(object)this)
		{
			CNKLEOKFFLB = null;
		}
	}

	public static SprintBarUI HHONLOCNFNC(int JIIGOACEIKL)
	{
		return JIIGOACEIKL switch
		{
			1 => GGFJGHHHEJC, 
			5 => CNKLEOKFFLB, 
			_ => null, 
		};
	}

	private void KLMNLEDKEOE()
	{
		if (playerNum == 0)
		{
			GGFJGHHHEJC = this;
		}
		else if (playerNum == 5)
		{
			CNKLEOKFFLB = this;
		}
	}

	private void GMNJJIGMJEG()
	{
		if (progressBar.FOLDHLBEICH() >= 378f)
		{
			if (content.activeSelf)
			{
				content.SetActive(false);
			}
		}
		else if (!content.activeSelf)
		{
			content.SetActive(false);
		}
	}

	private void NKGMEMEACNN()
	{
		if (playerNum == 0)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
		else if (playerNum == 1 && (Object)(object)CNKLEOKFFLB == (Object)(object)this)
		{
			CNKLEOKFFLB = null;
		}
	}
}
