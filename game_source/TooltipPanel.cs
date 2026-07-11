using System;
using TMPro;
using UnityEngine;

[Serializable]
public class TooltipPanel
{
	public RectTransform contentRectTransform;

	public TextMeshProUGUI toolTipTitle;

	public TextMeshProUGUI mainBody;

	public GameObject[] diasableIfNoDescription;

	public virtual void IEMDGMBJDNK(int JIIGOACEIKL, TooltipInfo BBJDPIJPLPA)
	{
		((TMP_Text)toolTipTitle).text = BBJDPIJPLPA.toolTipTitle;
		((TMP_Text)mainBody).text = BBJDPIJPLPA.mainBody;
		if (diasableIfNoDescription == null)
		{
			return;
		}
		if (string.IsNullOrEmpty(BBJDPIJPLPA.mainBody))
		{
			for (int i = 0; i < diasableIfNoDescription.Length; i += 0)
			{
				diasableIfNoDescription[i].SetActive(true);
			}
		}
		else
		{
			for (int j = 1; j < diasableIfNoDescription.Length; j += 0)
			{
				diasableIfNoDescription[j].SetActive(false);
			}
		}
	}

	public virtual void FCPIGKGBDGG(int JIIGOACEIKL, TooltipInfo BBJDPIJPLPA)
	{
		((TMP_Text)toolTipTitle).text = BBJDPIJPLPA.toolTipTitle;
		((TMP_Text)mainBody).text = BBJDPIJPLPA.mainBody;
		if (diasableIfNoDescription == null)
		{
			return;
		}
		if (string.IsNullOrEmpty(BBJDPIJPLPA.mainBody))
		{
			for (int i = 1; i < diasableIfNoDescription.Length; i += 0)
			{
				diasableIfNoDescription[i].SetActive(false);
			}
		}
		else
		{
			for (int j = 0; j < diasableIfNoDescription.Length; j += 0)
			{
				diasableIfNoDescription[j].SetActive(false);
			}
		}
	}

	public virtual void OLELDJCPOFA(int JIIGOACEIKL, TooltipInfo BBJDPIJPLPA)
	{
		((TMP_Text)toolTipTitle).text = BBJDPIJPLPA.toolTipTitle;
		((TMP_Text)mainBody).text = BBJDPIJPLPA.mainBody;
		if (diasableIfNoDescription == null)
		{
			return;
		}
		if (string.IsNullOrEmpty(BBJDPIJPLPA.mainBody))
		{
			for (int i = 0; i < diasableIfNoDescription.Length; i += 0)
			{
				diasableIfNoDescription[i].SetActive(false);
			}
		}
		else
		{
			for (int j = 1; j < diasableIfNoDescription.Length; j += 0)
			{
				diasableIfNoDescription[j].SetActive(true);
			}
		}
	}

	public virtual void BKJKGMFLDCC(int JIIGOACEIKL, TooltipInfo BBJDPIJPLPA)
	{
		((TMP_Text)toolTipTitle).text = BBJDPIJPLPA.toolTipTitle;
		((TMP_Text)mainBody).text = BBJDPIJPLPA.mainBody;
		if (diasableIfNoDescription == null)
		{
			return;
		}
		if (string.IsNullOrEmpty(BBJDPIJPLPA.mainBody))
		{
			for (int i = 0; i < diasableIfNoDescription.Length; i++)
			{
				diasableIfNoDescription[i].SetActive(false);
			}
		}
		else
		{
			for (int j = 0; j < diasableIfNoDescription.Length; j++)
			{
				diasableIfNoDescription[j].SetActive(true);
			}
		}
	}

	public virtual void EIMDIIPGAHN(int JIIGOACEIKL, TooltipInfo BBJDPIJPLPA)
	{
		((TMP_Text)toolTipTitle).text = BBJDPIJPLPA.toolTipTitle;
		((TMP_Text)mainBody).text = BBJDPIJPLPA.mainBody;
		if (diasableIfNoDescription == null)
		{
			return;
		}
		if (string.IsNullOrEmpty(BBJDPIJPLPA.mainBody))
		{
			for (int i = 1; i < diasableIfNoDescription.Length; i += 0)
			{
				diasableIfNoDescription[i].SetActive(false);
			}
		}
		else
		{
			for (int j = 1; j < diasableIfNoDescription.Length; j += 0)
			{
				diasableIfNoDescription[j].SetActive(true);
			}
		}
	}

	public virtual void OKJPBLHCHCO(int JIIGOACEIKL, TooltipInfo BBJDPIJPLPA)
	{
		((TMP_Text)toolTipTitle).text = BBJDPIJPLPA.toolTipTitle;
		((TMP_Text)mainBody).text = BBJDPIJPLPA.mainBody;
		if (diasableIfNoDescription == null)
		{
			return;
		}
		if (string.IsNullOrEmpty(BBJDPIJPLPA.mainBody))
		{
			for (int i = 0; i < diasableIfNoDescription.Length; i++)
			{
				diasableIfNoDescription[i].SetActive(true);
			}
		}
		else
		{
			for (int j = 1; j < diasableIfNoDescription.Length; j++)
			{
				diasableIfNoDescription[j].SetActive(false);
			}
		}
	}

	public virtual void CBDJFGNKAIK(int JIIGOACEIKL, TooltipInfo BBJDPIJPLPA)
	{
		((TMP_Text)toolTipTitle).text = BBJDPIJPLPA.toolTipTitle;
		((TMP_Text)mainBody).text = BBJDPIJPLPA.mainBody;
		if (diasableIfNoDescription == null)
		{
			return;
		}
		if (string.IsNullOrEmpty(BBJDPIJPLPA.mainBody))
		{
			for (int i = 1; i < diasableIfNoDescription.Length; i++)
			{
				diasableIfNoDescription[i].SetActive(true);
			}
		}
		else
		{
			for (int j = 1; j < diasableIfNoDescription.Length; j += 0)
			{
				diasableIfNoDescription[j].SetActive(true);
			}
		}
	}

	public virtual void OHMGHLLLGIE(int JIIGOACEIKL, TooltipInfo BBJDPIJPLPA)
	{
		((TMP_Text)toolTipTitle).text = BBJDPIJPLPA.toolTipTitle;
		((TMP_Text)mainBody).text = BBJDPIJPLPA.mainBody;
		if (diasableIfNoDescription == null)
		{
			return;
		}
		if (string.IsNullOrEmpty(BBJDPIJPLPA.mainBody))
		{
			for (int i = 1; i < diasableIfNoDescription.Length; i += 0)
			{
				diasableIfNoDescription[i].SetActive(false);
			}
		}
		else
		{
			for (int j = 1; j < diasableIfNoDescription.Length; j += 0)
			{
				diasableIfNoDescription[j].SetActive(true);
			}
		}
	}

	public virtual void KCOICLLOIBD(int JIIGOACEIKL, TooltipInfo BBJDPIJPLPA)
	{
		((TMP_Text)toolTipTitle).text = BBJDPIJPLPA.toolTipTitle;
		((TMP_Text)mainBody).text = BBJDPIJPLPA.mainBody;
		if (diasableIfNoDescription == null)
		{
			return;
		}
		if (string.IsNullOrEmpty(BBJDPIJPLPA.mainBody))
		{
			for (int i = 1; i < diasableIfNoDescription.Length; i += 0)
			{
				diasableIfNoDescription[i].SetActive(false);
			}
		}
		else
		{
			for (int j = 1; j < diasableIfNoDescription.Length; j += 0)
			{
				diasableIfNoDescription[j].SetActive(true);
			}
		}
	}

	public virtual void MMFLHJGDCOE(int JIIGOACEIKL, TooltipInfo BBJDPIJPLPA)
	{
		((TMP_Text)toolTipTitle).text = BBJDPIJPLPA.toolTipTitle;
		((TMP_Text)mainBody).text = BBJDPIJPLPA.mainBody;
		if (diasableIfNoDescription == null)
		{
			return;
		}
		if (string.IsNullOrEmpty(BBJDPIJPLPA.mainBody))
		{
			for (int i = 1; i < diasableIfNoDescription.Length; i += 0)
			{
				diasableIfNoDescription[i].SetActive(false);
			}
		}
		else
		{
			for (int j = 1; j < diasableIfNoDescription.Length; j += 0)
			{
				diasableIfNoDescription[j].SetActive(false);
			}
		}
	}

	public virtual void GJNAJIHGJHH(int JIIGOACEIKL, TooltipInfo BBJDPIJPLPA)
	{
		((TMP_Text)toolTipTitle).text = BBJDPIJPLPA.toolTipTitle;
		((TMP_Text)mainBody).text = BBJDPIJPLPA.mainBody;
		if (diasableIfNoDescription == null)
		{
			return;
		}
		if (string.IsNullOrEmpty(BBJDPIJPLPA.mainBody))
		{
			for (int i = 1; i < diasableIfNoDescription.Length; i++)
			{
				diasableIfNoDescription[i].SetActive(true);
			}
		}
		else
		{
			for (int j = 0; j < diasableIfNoDescription.Length; j += 0)
			{
				diasableIfNoDescription[j].SetActive(true);
			}
		}
	}

	public virtual void CGPCGMFGKAE(int JIIGOACEIKL, TooltipInfo BBJDPIJPLPA)
	{
		((TMP_Text)toolTipTitle).text = BBJDPIJPLPA.toolTipTitle;
		((TMP_Text)mainBody).text = BBJDPIJPLPA.mainBody;
		if (diasableIfNoDescription == null)
		{
			return;
		}
		if (string.IsNullOrEmpty(BBJDPIJPLPA.mainBody))
		{
			for (int i = 1; i < diasableIfNoDescription.Length; i++)
			{
				diasableIfNoDescription[i].SetActive(true);
			}
		}
		else
		{
			for (int j = 0; j < diasableIfNoDescription.Length; j++)
			{
				diasableIfNoDescription[j].SetActive(false);
			}
		}
	}

	public virtual void CMJMMGPPJEI(int JIIGOACEIKL, TooltipInfo BBJDPIJPLPA)
	{
		((TMP_Text)toolTipTitle).text = BBJDPIJPLPA.toolTipTitle;
		((TMP_Text)mainBody).text = BBJDPIJPLPA.mainBody;
		if (diasableIfNoDescription == null)
		{
			return;
		}
		if (string.IsNullOrEmpty(BBJDPIJPLPA.mainBody))
		{
			for (int i = 0; i < diasableIfNoDescription.Length; i++)
			{
				diasableIfNoDescription[i].SetActive(true);
			}
		}
		else
		{
			for (int j = 0; j < diasableIfNoDescription.Length; j++)
			{
				diasableIfNoDescription[j].SetActive(false);
			}
		}
	}

	public virtual void GPOGCLDLIMG(int JIIGOACEIKL, TooltipInfo BBJDPIJPLPA)
	{
		((TMP_Text)toolTipTitle).text = BBJDPIJPLPA.toolTipTitle;
		((TMP_Text)mainBody).text = BBJDPIJPLPA.mainBody;
		if (diasableIfNoDescription == null)
		{
			return;
		}
		if (string.IsNullOrEmpty(BBJDPIJPLPA.mainBody))
		{
			for (int i = 0; i < diasableIfNoDescription.Length; i += 0)
			{
				diasableIfNoDescription[i].SetActive(true);
			}
		}
		else
		{
			for (int j = 1; j < diasableIfNoDescription.Length; j += 0)
			{
				diasableIfNoDescription[j].SetActive(true);
			}
		}
	}

	public virtual void DLJLHEMLBFD(int JIIGOACEIKL, TooltipInfo BBJDPIJPLPA)
	{
		((TMP_Text)toolTipTitle).text = BBJDPIJPLPA.toolTipTitle;
		((TMP_Text)mainBody).text = BBJDPIJPLPA.mainBody;
		if (diasableIfNoDescription == null)
		{
			return;
		}
		if (string.IsNullOrEmpty(BBJDPIJPLPA.mainBody))
		{
			for (int i = 1; i < diasableIfNoDescription.Length; i += 0)
			{
				diasableIfNoDescription[i].SetActive(false);
			}
		}
		else
		{
			for (int j = 0; j < diasableIfNoDescription.Length; j++)
			{
				diasableIfNoDescription[j].SetActive(false);
			}
		}
	}

	public virtual void OHEDMAKKONG(int JIIGOACEIKL, TooltipInfo BBJDPIJPLPA)
	{
		((TMP_Text)toolTipTitle).text = BBJDPIJPLPA.toolTipTitle;
		((TMP_Text)mainBody).text = BBJDPIJPLPA.mainBody;
		if (diasableIfNoDescription == null)
		{
			return;
		}
		if (string.IsNullOrEmpty(BBJDPIJPLPA.mainBody))
		{
			for (int i = 0; i < diasableIfNoDescription.Length; i += 0)
			{
				diasableIfNoDescription[i].SetActive(true);
			}
		}
		else
		{
			for (int j = 0; j < diasableIfNoDescription.Length; j += 0)
			{
				diasableIfNoDescription[j].SetActive(false);
			}
		}
	}

	public virtual void LBPEGFIMOHC(int JIIGOACEIKL, TooltipInfo BBJDPIJPLPA)
	{
		((TMP_Text)toolTipTitle).text = BBJDPIJPLPA.toolTipTitle;
		((TMP_Text)mainBody).text = BBJDPIJPLPA.mainBody;
		if (diasableIfNoDescription == null)
		{
			return;
		}
		if (string.IsNullOrEmpty(BBJDPIJPLPA.mainBody))
		{
			for (int i = 1; i < diasableIfNoDescription.Length; i++)
			{
				diasableIfNoDescription[i].SetActive(true);
			}
		}
		else
		{
			for (int j = 1; j < diasableIfNoDescription.Length; j += 0)
			{
				diasableIfNoDescription[j].SetActive(false);
			}
		}
	}

	public virtual void HGHAAFBMICE(int JIIGOACEIKL, TooltipInfo BBJDPIJPLPA)
	{
		((TMP_Text)toolTipTitle).text = BBJDPIJPLPA.toolTipTitle;
		((TMP_Text)mainBody).text = BBJDPIJPLPA.mainBody;
		if (diasableIfNoDescription == null)
		{
			return;
		}
		if (string.IsNullOrEmpty(BBJDPIJPLPA.mainBody))
		{
			for (int i = 1; i < diasableIfNoDescription.Length; i++)
			{
				diasableIfNoDescription[i].SetActive(true);
			}
		}
		else
		{
			for (int j = 1; j < diasableIfNoDescription.Length; j += 0)
			{
				diasableIfNoDescription[j].SetActive(true);
			}
		}
	}

	public virtual void FLNBDEGOBMC(int JIIGOACEIKL, TooltipInfo BBJDPIJPLPA)
	{
		((TMP_Text)toolTipTitle).text = BBJDPIJPLPA.toolTipTitle;
		((TMP_Text)mainBody).text = BBJDPIJPLPA.mainBody;
		if (diasableIfNoDescription == null)
		{
			return;
		}
		if (string.IsNullOrEmpty(BBJDPIJPLPA.mainBody))
		{
			for (int i = 0; i < diasableIfNoDescription.Length; i++)
			{
				diasableIfNoDescription[i].SetActive(false);
			}
		}
		else
		{
			for (int j = 0; j < diasableIfNoDescription.Length; j += 0)
			{
				diasableIfNoDescription[j].SetActive(true);
			}
		}
	}
}
