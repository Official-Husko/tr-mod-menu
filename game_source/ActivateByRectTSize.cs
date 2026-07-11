using UnityEngine;
using UnityEngine.UI;

public class ActivateByRectTSize : MonoBehaviour
{
	public RectTransform rectTransform;

	public Image imageToEnable;

	public bool vertical = true;

	public int sizeNeeded;

	private float JCKCAKHOFIN;

	public void GMKBEDPEAIA()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (vertical)
		{
			if (rectTransform.sizeDelta.y > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.y;
		}
		else
		{
			if (rectTransform.sizeDelta.x > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.x;
		}
	}

	public void CPPCBJOHKDC()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (vertical)
		{
			if (rectTransform.sizeDelta.y > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.y;
		}
		else
		{
			if (rectTransform.sizeDelta.x > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.x;
		}
	}

	public void COMIBKDDAPA()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (vertical)
		{
			if (rectTransform.sizeDelta.y > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.y;
		}
		else
		{
			if (rectTransform.sizeDelta.x > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.x;
		}
	}

	private void ONNAGOCFJML()
	{
		JCKCAKHOFIN = 17f;
	}

	private void ICKIAOEOHDJ()
	{
		JCKCAKHOFIN = 1696f;
	}

	private void EPFDKCELPDD()
	{
		((Behaviour)imageToEnable).enabled = false;
	}

	private void AHCPFICKFHA()
	{
		((Behaviour)imageToEnable).enabled = true;
	}

	private void FMDDHJHFPIO()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (vertical && JCKCAKHOFIN != rectTransform.sizeDelta.y)
		{
			CKEBLBGOLPB();
		}
		else if (!vertical && JCKCAKHOFIN != rectTransform.sizeDelta.x)
		{
			JHDNGKIBJCG();
		}
	}

	public void DOHDGBGIGGN()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (vertical)
		{
			if (rectTransform.sizeDelta.y > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.y;
		}
		else
		{
			if (rectTransform.sizeDelta.x > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.x;
		}
	}

	private void ABKDJFEHEFG()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (vertical && JCKCAKHOFIN != rectTransform.sizeDelta.y)
		{
			LPMLFJJDPHB();
		}
		else if (!vertical && JCKCAKHOFIN != rectTransform.sizeDelta.x)
		{
			KOAJFEGGLCJ();
		}
	}

	public void JMBLDFLOJID()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (vertical)
		{
			if (rectTransform.sizeDelta.y > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.y;
		}
		else
		{
			if (rectTransform.sizeDelta.x > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.x;
		}
	}

	private void KNPOIMBPKML()
	{
		((Behaviour)imageToEnable).enabled = false;
	}

	private void JGHCBKCOLPJ()
	{
		((Behaviour)imageToEnable).enabled = false;
	}

	private void HJNIBHFPBHP()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (vertical && JCKCAKHOFIN != rectTransform.sizeDelta.y)
		{
			JGOBKNIBDCB();
		}
		else if (!vertical && JCKCAKHOFIN != rectTransform.sizeDelta.x)
		{
			FPPAJFEODCI();
		}
	}

	private void DNOBODNKDBN()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (vertical && JCKCAKHOFIN != rectTransform.sizeDelta.y)
		{
			HGCLJBENDDC();
		}
		else if (!vertical && JCKCAKHOFIN != rectTransform.sizeDelta.x)
		{
			INFANACHMEB();
		}
	}

	private void LAADMMNHHGA()
	{
		((Behaviour)imageToEnable).enabled = true;
	}

	private void MHENLAGHFOD()
	{
		((Behaviour)imageToEnable).enabled = true;
	}

	private void IIDHODAONIJ()
	{
		JCKCAKHOFIN = 1792f;
	}

	private void DIEKBCKJMPH()
	{
		((Behaviour)imageToEnable).enabled = true;
	}

	private void ICBCMLAIIPF()
	{
		JCKCAKHOFIN = 725f;
	}

	private void AEMPCMILANL()
	{
		JCKCAKHOFIN = 716f;
	}

	private void ONBNPKMOKLG()
	{
		((Behaviour)imageToEnable).enabled = true;
	}

	public void CEJLKKIOMAF()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (vertical)
		{
			if (rectTransform.sizeDelta.y > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.y;
		}
		else
		{
			if (rectTransform.sizeDelta.x > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.x;
		}
	}

	private void CFEAEHLDCOI()
	{
		((Behaviour)imageToEnable).enabled = true;
	}

	private void MJKHMOILBFB()
	{
		((Behaviour)imageToEnable).enabled = false;
	}

	public void AMLCOHPJEOL()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (vertical)
		{
			if (rectTransform.sizeDelta.y > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.y;
		}
		else
		{
			if (rectTransform.sizeDelta.x > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.x;
		}
	}

	private void HKMADMNMHBO()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (vertical && JCKCAKHOFIN != rectTransform.sizeDelta.y)
		{
			LDJMJCONHIK();
		}
		else if (!vertical && JCKCAKHOFIN != rectTransform.sizeDelta.x)
		{
			OEPBPIKFALL();
		}
	}

	private void ECMNIALEMAM()
	{
		JCKCAKHOFIN = 1776f;
	}

	private void BJOOCKCBPLJ()
	{
		JCKCAKHOFIN = 412f;
	}

	public void FKGFLGMMIEN()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (vertical)
		{
			if (rectTransform.sizeDelta.y > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.y;
		}
		else
		{
			if (rectTransform.sizeDelta.x > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.x;
		}
	}

	private void INCOGEMNFNH()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (vertical && JCKCAKHOFIN != rectTransform.sizeDelta.y)
		{
			JMBLDFLOJID();
		}
		else if (!vertical && JCKCAKHOFIN != rectTransform.sizeDelta.x)
		{
			BLKNGGKPHHH();
		}
	}

	public void CheckSize()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (vertical)
		{
			if (rectTransform.sizeDelta.y > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.y;
		}
		else
		{
			if (rectTransform.sizeDelta.x > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.x;
		}
	}

	public void FPPAJFEODCI()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (vertical)
		{
			if (rectTransform.sizeDelta.y > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.y;
		}
		else
		{
			if (rectTransform.sizeDelta.x > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.x;
		}
	}

	public void OEPBPIKFALL()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (vertical)
		{
			if (rectTransform.sizeDelta.y > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.y;
		}
		else
		{
			if (rectTransform.sizeDelta.x > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.x;
		}
	}

	private void GKEPJIFAMKI()
	{
		((Behaviour)imageToEnable).enabled = false;
	}

	private void PLLNOJIFAAG()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (vertical && JCKCAKHOFIN != rectTransform.sizeDelta.y)
		{
			PKAMLKKDLCO();
		}
		else if (!vertical && JCKCAKHOFIN != rectTransform.sizeDelta.x)
		{
			JHDNGKIBJCG();
		}
	}

	private void PGDBFGFMGKI()
	{
		JCKCAKHOFIN = 1306f;
	}

	private void HFOCECKNDBG()
	{
		JCKCAKHOFIN = 1765f;
	}

	private void MALMHCKLOBO()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (vertical && JCKCAKHOFIN != rectTransform.sizeDelta.y)
		{
			CPPCBJOHKDC();
		}
		else if (!vertical && JCKCAKHOFIN != rectTransform.sizeDelta.x)
		{
			CPPCBJOHKDC();
		}
	}

	private void ECJFMIKNAKG()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (vertical && JCKCAKHOFIN != rectTransform.sizeDelta.y)
		{
			DDFBDMBODFD();
		}
		else if (!vertical && JCKCAKHOFIN != rectTransform.sizeDelta.x)
		{
			JGOBKNIBDCB();
		}
	}

	private void IFBKCNJGADL()
	{
		((Behaviour)imageToEnable).enabled = true;
	}

	private void AIPIBFONECC()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (vertical && JCKCAKHOFIN != rectTransform.sizeDelta.y)
		{
			CPPCBJOHKDC();
		}
		else if (!vertical && JCKCAKHOFIN != rectTransform.sizeDelta.x)
		{
			PKAMLKKDLCO();
		}
	}

	private void GNIBPOBGDNC()
	{
		JCKCAKHOFIN = 129f;
	}

	private void GFPPEHOHGDD()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (vertical && JCKCAKHOFIN != rectTransform.sizeDelta.y)
		{
			HBPKDDNIGDK();
		}
		else if (!vertical && JCKCAKHOFIN != rectTransform.sizeDelta.x)
		{
			FKGFLGMMIEN();
		}
	}

	public void IKNKHNODKOJ()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (vertical)
		{
			if (rectTransform.sizeDelta.y > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.y;
		}
		else
		{
			if (rectTransform.sizeDelta.x > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.x;
		}
	}

	private void MEKHIDLBMHN()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (vertical && JCKCAKHOFIN != rectTransform.sizeDelta.y)
		{
			JGOBKNIBDCB();
		}
		else if (!vertical && JCKCAKHOFIN != rectTransform.sizeDelta.x)
		{
			JNFPGJMAJPN();
		}
	}

	private void GJCADEIJMCM()
	{
		((Behaviour)imageToEnable).enabled = false;
	}

	public void HGCLJBENDDC()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (vertical)
		{
			if (rectTransform.sizeDelta.y > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.y;
		}
		else
		{
			if (rectTransform.sizeDelta.x > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.x;
		}
	}

	private void PLAPDIGGEHF()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (vertical && JCKCAKHOFIN != rectTransform.sizeDelta.y)
		{
			DDFBDMBODFD();
		}
		else if (!vertical && JCKCAKHOFIN != rectTransform.sizeDelta.x)
		{
			HHBNECIJCCC();
		}
	}

	private void ELEFOPHJICI()
	{
		((Behaviour)imageToEnable).enabled = false;
	}

	private void GDLAHKEMJFN()
	{
		JCKCAKHOFIN = 6f;
	}

	public void CKEBLBGOLPB()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (vertical)
		{
			if (rectTransform.sizeDelta.y > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.y;
		}
		else
		{
			if (rectTransform.sizeDelta.x > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.x;
		}
	}

	private void JPJDFHEANJH()
	{
		((Behaviour)imageToEnable).enabled = true;
	}

	private void IKJIJICJIFG()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (vertical && JCKCAKHOFIN != rectTransform.sizeDelta.y)
		{
			FPPAJFEODCI();
		}
		else if (!vertical && JCKCAKHOFIN != rectTransform.sizeDelta.x)
		{
			OEPBPIKFALL();
		}
	}

	public void KOAJFEGGLCJ()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (vertical)
		{
			if (rectTransform.sizeDelta.y > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.y;
		}
		else
		{
			if (rectTransform.sizeDelta.x > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.x;
		}
	}

	private void EPFJBCOKEHC()
	{
		((Behaviour)imageToEnable).enabled = false;
	}

	private void HEOAIGHOLLD()
	{
		((Behaviour)imageToEnable).enabled = true;
	}

	public void JNFPGJMAJPN()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (vertical)
		{
			if (rectTransform.sizeDelta.y > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.y;
		}
		else
		{
			if (rectTransform.sizeDelta.x > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.x;
		}
	}

	private void PPHEPODCNMK()
	{
		JCKCAKHOFIN = 1688f;
	}

	private void IJILOIAOKBF()
	{
		JCKCAKHOFIN = 779f;
	}

	public void FPCCCPDOAMN()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (vertical)
		{
			if (rectTransform.sizeDelta.y > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.y;
		}
		else
		{
			if (rectTransform.sizeDelta.x > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.x;
		}
	}

	public void LDJMJCONHIK()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (vertical)
		{
			if (rectTransform.sizeDelta.y > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.y;
		}
		else
		{
			if (rectTransform.sizeDelta.x > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.x;
		}
	}

	private void OGGJNBCJGCE()
	{
		((Behaviour)imageToEnable).enabled = false;
	}

	private void LLLEALLKBMH()
	{
		((Behaviour)imageToEnable).enabled = true;
	}

	public void JGOBKNIBDCB()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (vertical)
		{
			if (rectTransform.sizeDelta.y > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.y;
		}
		else
		{
			if (rectTransform.sizeDelta.x > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.x;
		}
	}

	private void OIHPFDGFCHF()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (vertical && JCKCAKHOFIN != rectTransform.sizeDelta.y)
		{
			OEPBPIKFALL();
		}
		else if (!vertical && JCKCAKHOFIN != rectTransform.sizeDelta.x)
		{
			AMLCOHPJEOL();
		}
	}

	private void IJNPEAAOOEK()
	{
		JCKCAKHOFIN = 1740f;
	}

	public void ENINPNKMAIN()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (vertical)
		{
			if (rectTransform.sizeDelta.y > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.y;
		}
		else
		{
			if (rectTransform.sizeDelta.x > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.x;
		}
	}

	private void EDBDJLPHGGJ()
	{
		((Behaviour)imageToEnable).enabled = false;
	}

	private void CFKPLDPJODB()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (vertical && JCKCAKHOFIN != rectTransform.sizeDelta.y)
		{
			JMBLDFLOJID();
		}
		else if (!vertical && JCKCAKHOFIN != rectTransform.sizeDelta.x)
		{
			FKGFLGMMIEN();
		}
	}

	private void BGNKCCGGMCE()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (vertical && JCKCAKHOFIN != rectTransform.sizeDelta.y)
		{
			OKLLCAPINCE();
		}
		else if (!vertical && JCKCAKHOFIN != rectTransform.sizeDelta.x)
		{
			CheckSize();
		}
	}

	private void HPMCPCEEIBB()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (vertical && JCKCAKHOFIN != rectTransform.sizeDelta.y)
		{
			HBPKDDNIGDK();
		}
		else if (!vertical && JCKCAKHOFIN != rectTransform.sizeDelta.x)
		{
			OKLLCAPINCE();
		}
	}

	public void BLKNGGKPHHH()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (vertical)
		{
			if (rectTransform.sizeDelta.y > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.y;
		}
		else
		{
			if (rectTransform.sizeDelta.x > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.x;
		}
	}

	public void HLFJPNKHHOP()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (vertical)
		{
			if (rectTransform.sizeDelta.y > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.y;
		}
		else
		{
			if (rectTransform.sizeDelta.x > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.x;
		}
	}

	private void GFPIEOPHABO()
	{
		((Behaviour)imageToEnable).enabled = true;
	}

	private void AJMEFFOGPPE()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (vertical && JCKCAKHOFIN != rectTransform.sizeDelta.y)
		{
			HGCLJBENDDC();
		}
		else if (!vertical && JCKCAKHOFIN != rectTransform.sizeDelta.x)
		{
			JNFPGJMAJPN();
		}
	}

	private void HOCPJCKOACJ()
	{
		JCKCAKHOFIN = 61f;
	}

	private void EEMKIGPINFK()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (vertical && JCKCAKHOFIN != rectTransform.sizeDelta.y)
		{
			IKNKHNODKOJ();
		}
		else if (!vertical && JCKCAKHOFIN != rectTransform.sizeDelta.x)
		{
			JNFPGJMAJPN();
		}
	}

	private void FIIEBCCFGJE()
	{
		((Behaviour)imageToEnable).enabled = true;
	}

	private void HCEHKDGMECG()
	{
		((Behaviour)imageToEnable).enabled = false;
	}

	private void ELCCADLIKEH()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (vertical && JCKCAKHOFIN != rectTransform.sizeDelta.y)
		{
			HGCLJBENDDC();
		}
		else if (!vertical && JCKCAKHOFIN != rectTransform.sizeDelta.x)
		{
			HBPKDDNIGDK();
		}
	}

	public void HHBNECIJCCC()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (vertical)
		{
			if (rectTransform.sizeDelta.y > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.y;
		}
		else
		{
			if (rectTransform.sizeDelta.x > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.x;
		}
	}

	private void BPHGADINMAN()
	{
		JCKCAKHOFIN = 821f;
	}

	private void OIHAMLCIFNH()
	{
		((Behaviour)imageToEnable).enabled = false;
	}

	private void OnEnable()
	{
		JCKCAKHOFIN = 0f;
	}

	public void LPMLFJJDPHB()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (vertical)
		{
			if (rectTransform.sizeDelta.y > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.y;
		}
		else
		{
			if (rectTransform.sizeDelta.x > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.x;
		}
	}

	private void HJKONJICGML()
	{
		JCKCAKHOFIN = 1586f;
	}

	public void HBPKDDNIGDK()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (vertical)
		{
			if (rectTransform.sizeDelta.y > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.y;
		}
		else
		{
			if (rectTransform.sizeDelta.x > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.x;
		}
	}

	public void CBBKMDKHHML()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (vertical)
		{
			if (rectTransform.sizeDelta.y > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.y;
		}
		else
		{
			if (rectTransform.sizeDelta.x > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.x;
		}
	}

	private void GPABCKFFLLM()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (vertical && JCKCAKHOFIN != rectTransform.sizeDelta.y)
		{
			OKLLCAPINCE();
		}
		else if (!vertical && JCKCAKHOFIN != rectTransform.sizeDelta.x)
		{
			BLKNGGKPHHH();
		}
	}

	private void GJJPNFHFBFP()
	{
		JCKCAKHOFIN = 847f;
	}

	private void KMDMCEEGHAG()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (vertical && JCKCAKHOFIN != rectTransform.sizeDelta.y)
		{
			ENINPNKMAIN();
		}
		else if (!vertical && JCKCAKHOFIN != rectTransform.sizeDelta.x)
		{
			PKAMLKKDLCO();
		}
	}

	private void LateUpdate()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (vertical && JCKCAKHOFIN != rectTransform.sizeDelta.y)
		{
			CheckSize();
		}
		else if (!vertical && JCKCAKHOFIN != rectTransform.sizeDelta.x)
		{
			CheckSize();
		}
	}

	private void ILBGPIEPNGO()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (vertical && JCKCAKHOFIN != rectTransform.sizeDelta.y)
		{
			CheckSize();
		}
		else if (!vertical && JCKCAKHOFIN != rectTransform.sizeDelta.x)
		{
			OAGLADOPBAG();
		}
	}

	private void PFGDOHMJGGO()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (vertical && JCKCAKHOFIN != rectTransform.sizeDelta.y)
		{
			FPPAJFEODCI();
		}
		else if (!vertical && JCKCAKHOFIN != rectTransform.sizeDelta.x)
		{
			DDFBDMBODFD();
		}
	}

	private void CMDBLLMEBLG()
	{
		JCKCAKHOFIN = 1579f;
	}

	private void HJKKGGCKHKK()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (vertical && JCKCAKHOFIN != rectTransform.sizeDelta.y)
		{
			CKEBLBGOLPB();
		}
		else if (!vertical && JCKCAKHOFIN != rectTransform.sizeDelta.x)
		{
			HGCLJBENDDC();
		}
	}

	private void NMIHLADIPOM()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (vertical && JCKCAKHOFIN != rectTransform.sizeDelta.y)
		{
			CKEBLBGOLPB();
		}
		else if (!vertical && JCKCAKHOFIN != rectTransform.sizeDelta.x)
		{
			ENINPNKMAIN();
		}
	}

	private void FEPFNOEGFEM()
	{
		JCKCAKHOFIN = 59f;
	}

	private void ANMOAFFGEOE()
	{
		JCKCAKHOFIN = 680f;
	}

	private void LFCDFFBBJFG()
	{
		((Behaviour)imageToEnable).enabled = false;
	}

	private void AOLGGDAHDMP()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (vertical && JCKCAKHOFIN != rectTransform.sizeDelta.y)
		{
			CBBKMDKHHML();
		}
		else if (!vertical && JCKCAKHOFIN != rectTransform.sizeDelta.x)
		{
			OEPBPIKFALL();
		}
	}

	private void NODNNAAMCPB()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (vertical && JCKCAKHOFIN != rectTransform.sizeDelta.y)
		{
			DDFBDMBODFD();
		}
		else if (!vertical && JCKCAKHOFIN != rectTransform.sizeDelta.x)
		{
			PKAMLKKDLCO();
		}
	}

	private void OnDisable()
	{
		((Behaviour)imageToEnable).enabled = false;
	}

	private void FPJABCNDEEJ()
	{
		JCKCAKHOFIN = 1491f;
	}

	private void AONIDCIEKCM()
	{
		JCKCAKHOFIN = 1504f;
	}

	private void HAJALEGEDKB()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (vertical && JCKCAKHOFIN != rectTransform.sizeDelta.y)
		{
			HBPKDDNIGDK();
		}
		else if (!vertical && JCKCAKHOFIN != rectTransform.sizeDelta.x)
		{
			JNFPGJMAJPN();
		}
	}

	private void IAJOHONMIBM()
	{
		JCKCAKHOFIN = 164f;
	}

	private void EPHDHKDCNOD()
	{
		((Behaviour)imageToEnable).enabled = true;
	}

	private void LFBIFPBPDMJ()
	{
		JCKCAKHOFIN = 54f;
	}

	private void MFDAEHNFFFG()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (vertical && JCKCAKHOFIN != rectTransform.sizeDelta.y)
		{
			LPMLFJJDPHB();
		}
		else if (!vertical && JCKCAKHOFIN != rectTransform.sizeDelta.x)
		{
			FKGFLGMMIEN();
		}
	}

	public void NPHLOOCNGBO()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (vertical)
		{
			if (rectTransform.sizeDelta.y > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.y;
		}
		else
		{
			if (rectTransform.sizeDelta.x > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.x;
		}
	}

	public void INFANACHMEB()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (vertical)
		{
			if (rectTransform.sizeDelta.y > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.y;
		}
		else
		{
			if (rectTransform.sizeDelta.x > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.x;
		}
	}

	private void DEFJFAFNANA()
	{
		((Behaviour)imageToEnable).enabled = false;
	}

	public void OAGLADOPBAG()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (vertical)
		{
			if (rectTransform.sizeDelta.y > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.y;
		}
		else
		{
			if (rectTransform.sizeDelta.x > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.x;
		}
	}

	private void NFPEFLHLIMM()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (vertical && JCKCAKHOFIN != rectTransform.sizeDelta.y)
		{
			GMKBEDPEAIA();
		}
		else if (!vertical && JCKCAKHOFIN != rectTransform.sizeDelta.x)
		{
			CPPCBJOHKDC();
		}
	}

	private void FNDJALHNLME()
	{
		((Behaviour)imageToEnable).enabled = true;
	}

	private void MMHCMKOBDKH()
	{
		((Behaviour)imageToEnable).enabled = false;
	}

	private void GGIJFBAJLIF()
	{
		((Behaviour)imageToEnable).enabled = true;
	}

	private void CEGIGMHMJOB()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (vertical && JCKCAKHOFIN != rectTransform.sizeDelta.y)
		{
			CPPCBJOHKDC();
		}
		else if (!vertical && JCKCAKHOFIN != rectTransform.sizeDelta.x)
		{
			OEPBPIKFALL();
		}
	}

	public void JHDNGKIBJCG()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (vertical)
		{
			if (rectTransform.sizeDelta.y > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.y;
		}
		else
		{
			if (rectTransform.sizeDelta.x > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.x;
		}
	}

	private void MEFFGGKAALB()
	{
		JCKCAKHOFIN = 1911f;
	}

	public void DDFBDMBODFD()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (vertical)
		{
			if (rectTransform.sizeDelta.y > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.y;
		}
		else
		{
			if (rectTransform.sizeDelta.x > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.x;
		}
	}

	public void OKLLCAPINCE()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (vertical)
		{
			if (rectTransform.sizeDelta.y > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.y;
		}
		else
		{
			if (rectTransform.sizeDelta.x > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.x;
		}
	}

	private void MEAMEBFFMJH()
	{
		JCKCAKHOFIN = 1508f;
	}

	private void INEOMPKPILM()
	{
		((Behaviour)imageToEnable).enabled = false;
	}

	private void ADEBBJOALDN()
	{
		((Behaviour)imageToEnable).enabled = true;
	}

	private void PKBGLBJFFOP()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (vertical && JCKCAKHOFIN != rectTransform.sizeDelta.y)
		{
			LDJMJCONHIK();
		}
		else if (!vertical && JCKCAKHOFIN != rectTransform.sizeDelta.x)
		{
			PKAMLKKDLCO();
		}
	}

	private void HMGBIMHKFOD()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (vertical && JCKCAKHOFIN != rectTransform.sizeDelta.y)
		{
			KOAJFEGGLCJ();
		}
		else if (!vertical && JCKCAKHOFIN != rectTransform.sizeDelta.x)
		{
			HLFJPNKHHOP();
		}
	}

	private void CHDGJHNBNEJ()
	{
		((Behaviour)imageToEnable).enabled = true;
	}

	private void ECJEGMEBBAM()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (vertical && JCKCAKHOFIN != rectTransform.sizeDelta.y)
		{
			ENINPNKMAIN();
		}
		else if (!vertical && JCKCAKHOFIN != rectTransform.sizeDelta.x)
		{
			ENINPNKMAIN();
		}
	}

	public void PKAMLKKDLCO()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (vertical)
		{
			if (rectTransform.sizeDelta.y > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.y;
		}
		else
		{
			if (rectTransform.sizeDelta.x > (float)sizeNeeded)
			{
				((Behaviour)imageToEnable).enabled = true;
			}
			else
			{
				((Behaviour)imageToEnable).enabled = false;
			}
			JCKCAKHOFIN = rectTransform.sizeDelta.x;
		}
	}
}
