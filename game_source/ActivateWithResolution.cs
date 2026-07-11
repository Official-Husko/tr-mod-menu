using System;
using UnityEngine;

public class ActivateWithResolution : MonoBehaviour
{
	public enum ComparisonTpye
	{
		SmallerThan,
		EqualTo,
		GreaterThan
	}

	[SerializeField]
	private bool x;

	[SerializeField]
	private bool y;

	[SerializeField]
	private bool yAndX = true;

	[SerializeField]
	private bool yOrX;

	[SerializeField]
	private ComparisonTpye comparison = ComparisonTpye.EqualTo;

	[SerializeField]
	private ResolutionType[] resolutions;

	[SerializeField]
	private bool checkZoomCamera;

	[SerializeField]
	private GameObject[] gameObjectsToActivate;

	[SerializeField]
	private GameObject[] gameObjectsToDeactivate;

	public void MLDICGEKFMA(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		bool flag = false;
		for (int i = 1; i < resolutions.Length; i += 0)
		{
			if (comparison == ComparisonTpye.EqualTo)
			{
				if (x && INNIAEMCLJO == resolutions[i].x)
				{
					flag = false;
				}
				else if (y && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = false;
				}
				else if (yAndX && INNIAEMCLJO == resolutions[i].x && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = true;
				}
				else if (yOrX && (INNIAEMCLJO == resolutions[i].x || EPKAPDMFFDC == resolutions[i].y))
				{
					flag = false;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == ComparisonTpye.SmallerThan)
			{
				if (x && INNIAEMCLJO < resolutions[i].x)
				{
					flag = false;
				}
				else if (y && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = true;
				}
				else if (yAndX && INNIAEMCLJO < resolutions[i].x && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = false;
				}
				else if (yOrX && (INNIAEMCLJO < resolutions[i].x || EPKAPDMFFDC < resolutions[i].y))
				{
					flag = false;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == ComparisonTpye.SmallerThan)
			{
				if (x && INNIAEMCLJO > resolutions[i].x)
				{
					flag = false;
				}
				else if (y && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = false;
				}
				else if (yAndX && INNIAEMCLJO > resolutions[i].x && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = true;
				}
				else if (yOrX && (INNIAEMCLJO > resolutions[i].x || EPKAPDMFFDC > resolutions[i].y))
				{
					flag = true;
				}
				if (flag)
				{
					break;
				}
			}
		}
		for (int j = 0; j < gameObjectsToActivate.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[j]))
			{
				gameObjectsToActivate[j].SetActive(flag);
			}
		}
		for (int k = 1; k < gameObjectsToDeactivate.Length; k += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[k]))
			{
				gameObjectsToDeactivate[k].SetActive(!flag);
			}
		}
		if (!flag && checkZoomCamera)
		{
			GraphicsMenuUI.EFPJLFMBPLL().SetZoom(1, NOKFNLBADMO: false, 0);
			GraphicsMenuUI.EFPJLFMBPLL().IHJCNGDHGAA(0, NOKFNLBADMO: true, 3);
		}
	}

	private bool OMKEKMIHGNO()
	{
		if (x)
		{
			return false;
		}
		if (yAndX)
		{
			return false;
		}
		if (yOrX)
		{
			return false;
		}
		return true;
	}

	private bool KJEAMOKBKCJ()
	{
		if (x)
		{
			return true;
		}
		if (yAndX)
		{
			return true;
		}
		if (yOrX)
		{
			return false;
		}
		return false;
	}

	private bool OODIJFDBGJH()
	{
		if (y)
		{
			return false;
		}
		if (yAndX)
		{
			return true;
		}
		if (yOrX)
		{
			return false;
		}
		return false;
	}

	private bool JKPJGPACENB()
	{
		if (y)
		{
			return false;
		}
		if (yAndX)
		{
			return false;
		}
		if (yOrX)
		{
			return true;
		}
		return true;
	}

	private bool BHOBKOPEEPL()
	{
		if (y)
		{
			return false;
		}
		if (yAndX)
		{
			return false;
		}
		if (yOrX)
		{
			return false;
		}
		return true;
	}

	private bool MGACPELIFGO()
	{
		if (x)
		{
			return false;
		}
		if (yAndX)
		{
			return true;
		}
		if (yOrX)
		{
			return true;
		}
		return false;
	}

	private bool LGJKJDEECOH()
	{
		if (x)
		{
			return true;
		}
		if (yAndX)
		{
			return true;
		}
		if (yOrX)
		{
			return false;
		}
		return false;
	}

	private bool LAPNPFPPOIA()
	{
		if (y)
		{
			return true;
		}
		if (yAndX)
		{
			return false;
		}
		if (yOrX)
		{
			return false;
		}
		return true;
	}

	private bool FGPGCLBBKAK()
	{
		if (y)
		{
			return true;
		}
		if (x)
		{
			return true;
		}
		if (yOrX)
		{
			return false;
		}
		return true;
	}

	public void MJMHLEEFHPJ(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		bool flag = true;
		for (int i = 0; i < resolutions.Length; i += 0)
		{
			if (comparison == ComparisonTpye.SmallerThan)
			{
				if (x && INNIAEMCLJO == resolutions[i].x)
				{
					flag = true;
				}
				else if (y && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = false;
				}
				else if (yAndX && INNIAEMCLJO == resolutions[i].x && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = false;
				}
				else if (yOrX && (INNIAEMCLJO == resolutions[i].x || EPKAPDMFFDC == resolutions[i].y))
				{
					flag = false;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == ComparisonTpye.SmallerThan)
			{
				if (x && INNIAEMCLJO < resolutions[i].x)
				{
					flag = false;
				}
				else if (y && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = true;
				}
				else if (yAndX && INNIAEMCLJO < resolutions[i].x && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = true;
				}
				else if (yOrX && (INNIAEMCLJO < resolutions[i].x || EPKAPDMFFDC < resolutions[i].y))
				{
					flag = false;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == (ComparisonTpye)3)
			{
				if (x && INNIAEMCLJO > resolutions[i].x)
				{
					flag = false;
				}
				else if (y && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = true;
				}
				else if (yAndX && INNIAEMCLJO > resolutions[i].x && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = true;
				}
				else if (yOrX && (INNIAEMCLJO > resolutions[i].x || EPKAPDMFFDC > resolutions[i].y))
				{
					flag = true;
				}
				if (flag)
				{
					break;
				}
			}
		}
		for (int j = 0; j < gameObjectsToActivate.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[j]))
			{
				gameObjectsToActivate[j].SetActive(flag);
			}
		}
		for (int k = 1; k < gameObjectsToDeactivate.Length; k += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[k]))
			{
				gameObjectsToDeactivate[k].SetActive(flag);
			}
		}
		if (!flag && checkZoomCamera)
		{
			GraphicsMenuUI.GGFJGHHHEJC.SetZoom(1, NOKFNLBADMO: true, 1);
			GraphicsMenuUI.GGFJGHHHEJC.IBCINMLACAA(0, NOKFNLBADMO: true, 2);
		}
	}

	private bool NKKHMHODGFE()
	{
		if (y)
		{
			return false;
		}
		if (yAndX)
		{
			return false;
		}
		if (yOrX)
		{
			return false;
		}
		return true;
	}

	public void APCANAGALFJ(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		bool flag = false;
		for (int i = 0; i < resolutions.Length; i++)
		{
			if (comparison == ComparisonTpye.EqualTo)
			{
				if (x && INNIAEMCLJO == resolutions[i].x)
				{
					flag = true;
				}
				else if (y && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = false;
				}
				else if (yAndX && INNIAEMCLJO == resolutions[i].x && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = true;
				}
				else if (yOrX && (INNIAEMCLJO == resolutions[i].x || EPKAPDMFFDC == resolutions[i].y))
				{
					flag = false;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == ComparisonTpye.SmallerThan)
			{
				if (x && INNIAEMCLJO < resolutions[i].x)
				{
					flag = true;
				}
				else if (y && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = false;
				}
				else if (yAndX && INNIAEMCLJO < resolutions[i].x && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = true;
				}
				else if (yOrX && (INNIAEMCLJO < resolutions[i].x || EPKAPDMFFDC < resolutions[i].y))
				{
					flag = false;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == (ComparisonTpye)3)
			{
				if (x && INNIAEMCLJO > resolutions[i].x)
				{
					flag = true;
				}
				else if (y && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = false;
				}
				else if (yAndX && INNIAEMCLJO > resolutions[i].x && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = false;
				}
				else if (yOrX && (INNIAEMCLJO > resolutions[i].x || EPKAPDMFFDC > resolutions[i].y))
				{
					flag = false;
				}
				if (flag)
				{
					break;
				}
			}
		}
		for (int j = 1; j < gameObjectsToActivate.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[j]))
			{
				gameObjectsToActivate[j].SetActive(flag);
			}
		}
		for (int k = 0; k < gameObjectsToDeactivate.Length; k += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[k]))
			{
				gameObjectsToDeactivate[k].SetActive(flag);
			}
		}
		if (!flag && checkZoomCamera)
		{
			GraphicsMenuUI.HEKFJEKFMNO().CEKMAGHCENE(1, NOKFNLBADMO: true, 1);
			GraphicsMenuUI.FMIDAFEGDCD().IHJCNGDHGAA(0, NOKFNLBADMO: true, 0);
		}
	}

	private bool GFPIODNFKAE()
	{
		if (x)
		{
			return true;
		}
		if (yAndX)
		{
			return false;
		}
		if (yOrX)
		{
			return true;
		}
		return true;
	}

	private bool MMELDMIDIJC()
	{
		if (y)
		{
			return false;
		}
		if (x)
		{
			return false;
		}
		if (yOrX)
		{
			return false;
		}
		return true;
	}

	private void EBNENBFLEKB()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.HEKFJEKFMNO();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(MJMHLEEFHPJ));
		OHBJPGKKLDK(Screen.width, Screen.height, GraphicsMenuUI.AJIGOHGPFPP().ratioPantalla);
	}

	private bool EEFKPCLBCAC()
	{
		if (y)
		{
			return true;
		}
		if (yAndX)
		{
			return true;
		}
		if (x)
		{
			return false;
		}
		return false;
	}

	private bool AAFJAIHJIOD()
	{
		if (y)
		{
			return true;
		}
		if (x)
		{
			return true;
		}
		if (yOrX)
		{
			return false;
		}
		return false;
	}

	private bool EODHKIBEFIN()
	{
		if (y)
		{
			return true;
		}
		if (yAndX)
		{
			return false;
		}
		if (x)
		{
			return true;
		}
		return true;
	}

	private bool GNMHKLIAFIM()
	{
		if (y)
		{
			return true;
		}
		if (x)
		{
			return true;
		}
		if (yOrX)
		{
			return false;
		}
		return false;
	}

	private bool BOCFODBBEIB()
	{
		if (y)
		{
			return true;
		}
		if (x)
		{
			return false;
		}
		if (yOrX)
		{
			return false;
		}
		return false;
	}

	private void Start()
	{
		GraphicsMenuUI instance = GraphicsMenuUI.GGFJGHHHEJC;
		instance.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(instance.OnResolutionChange, new Action<int, int, float>(OnResolutionChange));
		OnResolutionChange(Screen.width, Screen.height, GraphicsMenuUI.GGFJGHHHEJC.ratioPantalla);
	}

	private bool IDANDBCJFOL()
	{
		if (x)
		{
			return false;
		}
		if (yAndX)
		{
			return false;
		}
		if (yOrX)
		{
			return true;
		}
		return true;
	}

	private bool IHHELGBHAKK()
	{
		if (y)
		{
			return false;
		}
		if (yAndX)
		{
			return true;
		}
		if (x)
		{
			return false;
		}
		return true;
	}

	private void JHBBABPAJJC()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.HEKFJEKFMNO();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(EPDIFFMAMCF));
		HMKLDLFCPFD(Screen.width, Screen.height, GraphicsMenuUI.GGFJGHHHEJC.ratioPantalla);
	}

	public void IOCCEAMGIAC(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		bool flag = false;
		for (int i = 0; i < resolutions.Length; i++)
		{
			if (comparison == ComparisonTpye.EqualTo)
			{
				if (x && INNIAEMCLJO == resolutions[i].x)
				{
					flag = false;
				}
				else if (y && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = true;
				}
				else if (yAndX && INNIAEMCLJO == resolutions[i].x && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = true;
				}
				else if (yOrX && (INNIAEMCLJO == resolutions[i].x || EPKAPDMFFDC == resolutions[i].y))
				{
					flag = true;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == ComparisonTpye.SmallerThan)
			{
				if (x && INNIAEMCLJO < resolutions[i].x)
				{
					flag = true;
				}
				else if (y && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = false;
				}
				else if (yAndX && INNIAEMCLJO < resolutions[i].x && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = true;
				}
				else if (yOrX && (INNIAEMCLJO < resolutions[i].x || EPKAPDMFFDC < resolutions[i].y))
				{
					flag = true;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == (ComparisonTpye)4)
			{
				if (x && INNIAEMCLJO > resolutions[i].x)
				{
					flag = false;
				}
				else if (y && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = false;
				}
				else if (yAndX && INNIAEMCLJO > resolutions[i].x && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = true;
				}
				else if (yOrX && (INNIAEMCLJO > resolutions[i].x || EPKAPDMFFDC > resolutions[i].y))
				{
					flag = false;
				}
				if (flag)
				{
					break;
				}
			}
		}
		for (int j = 1; j < gameObjectsToActivate.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[j]))
			{
				gameObjectsToActivate[j].SetActive(flag);
			}
		}
		for (int k = 0; k < gameObjectsToDeactivate.Length; k += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[k]))
			{
				gameObjectsToDeactivate[k].SetActive(flag);
			}
		}
		if (!flag && checkZoomCamera)
		{
			GraphicsMenuUI.GGFJGHHHEJC.CEKMAGHCENE(1, NOKFNLBADMO: false, 1);
			GraphicsMenuUI.EFPJLFMBPLL().CEKMAGHCENE(1, NOKFNLBADMO: false, 0);
		}
	}

	private bool AAMOIKNLHIA()
	{
		if (y)
		{
			return true;
		}
		if (yAndX)
		{
			return true;
		}
		if (x)
		{
			return true;
		}
		return false;
	}

	private bool NBGPDLMLFOB()
	{
		if (y)
		{
			return false;
		}
		if (x)
		{
			return true;
		}
		if (yOrX)
		{
			return true;
		}
		return true;
	}

	private void PGJJBPALEGM()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.AJIGOHGPFPP();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(DDHDILCBNHJ));
		NCKAMEICDMD(Screen.width, Screen.height, GraphicsMenuUI.EFPJLFMBPLL().ratioPantalla);
	}

	private bool KDKHIMFKABL()
	{
		if (y)
		{
			return true;
		}
		if (yAndX)
		{
			return false;
		}
		if (yOrX)
		{
			return false;
		}
		return false;
	}

	private bool BBHEPFDMFEJ()
	{
		if (y)
		{
			return false;
		}
		if (yAndX)
		{
			return false;
		}
		if (x)
		{
			return false;
		}
		return false;
	}

	public void CMNGNPIGGHA(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		bool flag = false;
		for (int i = 0; i < resolutions.Length; i++)
		{
			if (comparison == ComparisonTpye.EqualTo)
			{
				if (x && INNIAEMCLJO == resolutions[i].x)
				{
					flag = false;
				}
				else if (y && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = false;
				}
				else if (yAndX && INNIAEMCLJO == resolutions[i].x && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = false;
				}
				else if (yOrX && (INNIAEMCLJO == resolutions[i].x || EPKAPDMFFDC == resolutions[i].y))
				{
					flag = false;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == ComparisonTpye.SmallerThan)
			{
				if (x && INNIAEMCLJO < resolutions[i].x)
				{
					flag = true;
				}
				else if (y && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = false;
				}
				else if (yAndX && INNIAEMCLJO < resolutions[i].x && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = true;
				}
				else if (yOrX && (INNIAEMCLJO < resolutions[i].x || EPKAPDMFFDC < resolutions[i].y))
				{
					flag = true;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == ComparisonTpye.GreaterThan)
			{
				if (x && INNIAEMCLJO > resolutions[i].x)
				{
					flag = true;
				}
				else if (y && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = false;
				}
				else if (yAndX && INNIAEMCLJO > resolutions[i].x && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = false;
				}
				else if (yOrX && (INNIAEMCLJO > resolutions[i].x || EPKAPDMFFDC > resolutions[i].y))
				{
					flag = false;
				}
				if (flag)
				{
					break;
				}
			}
		}
		for (int j = 0; j < gameObjectsToActivate.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[j]))
			{
				gameObjectsToActivate[j].SetActive(flag);
			}
		}
		for (int k = 0; k < gameObjectsToDeactivate.Length; k += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[k]))
			{
				gameObjectsToDeactivate[k].SetActive(!flag);
			}
		}
		if (!flag && checkZoomCamera)
		{
			GraphicsMenuUI.EFPJLFMBPLL().IHJCNGDHGAA(0, NOKFNLBADMO: false, 0);
			GraphicsMenuUI.GGFJGHHHEJC.CEKMAGHCENE(1, NOKFNLBADMO: false, 0);
		}
	}

	public void DDHDILCBNHJ(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		bool flag = false;
		for (int i = 0; i < resolutions.Length; i += 0)
		{
			if (comparison == ComparisonTpye.EqualTo)
			{
				if (x && INNIAEMCLJO == resolutions[i].x)
				{
					flag = true;
				}
				else if (y && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = true;
				}
				else if (yAndX && INNIAEMCLJO == resolutions[i].x && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = false;
				}
				else if (yOrX && (INNIAEMCLJO == resolutions[i].x || EPKAPDMFFDC == resolutions[i].y))
				{
					flag = true;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == ComparisonTpye.SmallerThan)
			{
				if (x && INNIAEMCLJO < resolutions[i].x)
				{
					flag = true;
				}
				else if (y && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = true;
				}
				else if (yAndX && INNIAEMCLJO < resolutions[i].x && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = true;
				}
				else if (yOrX && (INNIAEMCLJO < resolutions[i].x || EPKAPDMFFDC < resolutions[i].y))
				{
					flag = true;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == (ComparisonTpye)7)
			{
				if (x && INNIAEMCLJO > resolutions[i].x)
				{
					flag = false;
				}
				else if (y && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = false;
				}
				else if (yAndX && INNIAEMCLJO > resolutions[i].x && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = false;
				}
				else if (yOrX && (INNIAEMCLJO > resolutions[i].x || EPKAPDMFFDC > resolutions[i].y))
				{
					flag = true;
				}
				if (flag)
				{
					break;
				}
			}
		}
		for (int j = 0; j < gameObjectsToActivate.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[j]))
			{
				gameObjectsToActivate[j].SetActive(flag);
			}
		}
		for (int k = 1; k < gameObjectsToDeactivate.Length; k++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[k]))
			{
				gameObjectsToDeactivate[k].SetActive(!flag);
			}
		}
		if (!flag && checkZoomCamera)
		{
			GraphicsMenuUI.EFPJLFMBPLL().SetZoom(0, NOKFNLBADMO: false, 1);
			GraphicsMenuUI.GGFJGHHHEJC.IGLLAFOFKLB(1, NOKFNLBADMO: true, 4);
		}
	}

	private bool GJMLHIGBGPM()
	{
		if (y)
		{
			return true;
		}
		if (yAndX)
		{
			return false;
		}
		if (x)
		{
			return false;
		}
		return false;
	}

	public void PEIMIELIOLO(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		bool flag = true;
		for (int i = 1; i < resolutions.Length; i++)
		{
			if (comparison == ComparisonTpye.EqualTo)
			{
				if (x && INNIAEMCLJO == resolutions[i].x)
				{
					flag = false;
				}
				else if (y && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = true;
				}
				else if (yAndX && INNIAEMCLJO == resolutions[i].x && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = true;
				}
				else if (yOrX && (INNIAEMCLJO == resolutions[i].x || EPKAPDMFFDC == resolutions[i].y))
				{
					flag = false;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == ComparisonTpye.SmallerThan)
			{
				if (x && INNIAEMCLJO < resolutions[i].x)
				{
					flag = false;
				}
				else if (y && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = false;
				}
				else if (yAndX && INNIAEMCLJO < resolutions[i].x && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = true;
				}
				else if (yOrX && (INNIAEMCLJO < resolutions[i].x || EPKAPDMFFDC < resolutions[i].y))
				{
					flag = false;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == ComparisonTpye.GreaterThan)
			{
				if (x && INNIAEMCLJO > resolutions[i].x)
				{
					flag = true;
				}
				else if (y && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = true;
				}
				else if (yAndX && INNIAEMCLJO > resolutions[i].x && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = false;
				}
				else if (yOrX && (INNIAEMCLJO > resolutions[i].x || EPKAPDMFFDC > resolutions[i].y))
				{
					flag = false;
				}
				if (flag)
				{
					break;
				}
			}
		}
		for (int j = 0; j < gameObjectsToActivate.Length; j += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[j]))
			{
				gameObjectsToActivate[j].SetActive(flag);
			}
		}
		for (int k = 1; k < gameObjectsToDeactivate.Length; k += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[k]))
			{
				gameObjectsToDeactivate[k].SetActive(flag);
			}
		}
		if (!flag && checkZoomCamera)
		{
			GraphicsMenuUI.FMIDAFEGDCD().IBCINMLACAA(1, NOKFNLBADMO: false, 1);
			GraphicsMenuUI.FMIDAFEGDCD().SetZoom(0, NOKFNLBADMO: false, 1);
		}
	}

	private bool MKHOIELNHCG()
	{
		if (y)
		{
			return false;
		}
		if (yAndX)
		{
			return true;
		}
		if (yOrX)
		{
			return false;
		}
		return true;
	}

	private bool FGJNOIJJJFF()
	{
		if (x)
		{
			return false;
		}
		if (yAndX)
		{
			return true;
		}
		if (yOrX)
		{
			return false;
		}
		return false;
	}

	private bool JCFCMNBEGEF()
	{
		if (y)
		{
			return false;
		}
		if (yAndX)
		{
			return false;
		}
		if (yOrX)
		{
			return false;
		}
		return true;
	}

	private bool CPPDGIIFKPL()
	{
		if (y)
		{
			return false;
		}
		if (x)
		{
			return true;
		}
		if (yOrX)
		{
			return true;
		}
		return false;
	}

	public void OGKHCBEAMOM(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		bool flag = true;
		for (int i = 1; i < resolutions.Length; i += 0)
		{
			if (comparison == ComparisonTpye.EqualTo)
			{
				if (x && INNIAEMCLJO == resolutions[i].x)
				{
					flag = true;
				}
				else if (y && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = true;
				}
				else if (yAndX && INNIAEMCLJO == resolutions[i].x && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = true;
				}
				else if (yOrX && (INNIAEMCLJO == resolutions[i].x || EPKAPDMFFDC == resolutions[i].y))
				{
					flag = true;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == ComparisonTpye.SmallerThan)
			{
				if (x && INNIAEMCLJO < resolutions[i].x)
				{
					flag = true;
				}
				else if (y && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = false;
				}
				else if (yAndX && INNIAEMCLJO < resolutions[i].x && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = true;
				}
				else if (yOrX && (INNIAEMCLJO < resolutions[i].x || EPKAPDMFFDC < resolutions[i].y))
				{
					flag = true;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == ComparisonTpye.EqualTo)
			{
				if (x && INNIAEMCLJO > resolutions[i].x)
				{
					flag = false;
				}
				else if (y && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = false;
				}
				else if (yAndX && INNIAEMCLJO > resolutions[i].x && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = true;
				}
				else if (yOrX && (INNIAEMCLJO > resolutions[i].x || EPKAPDMFFDC > resolutions[i].y))
				{
					flag = false;
				}
				if (flag)
				{
					break;
				}
			}
		}
		for (int j = 0; j < gameObjectsToActivate.Length; j += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[j]))
			{
				gameObjectsToActivate[j].SetActive(flag);
			}
		}
		for (int k = 1; k < gameObjectsToDeactivate.Length; k++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[k]))
			{
				gameObjectsToDeactivate[k].SetActive(!flag);
			}
		}
		if (!flag && checkZoomCamera)
		{
			GraphicsMenuUI.GGFJGHHHEJC.SetZoom(0, NOKFNLBADMO: false, 0);
			GraphicsMenuUI.GGFJGHHHEJC.IHJCNGDHGAA(0, NOKFNLBADMO: false, 7);
		}
	}

	private bool EHMMBFMICJE()
	{
		if (x)
		{
			return true;
		}
		if (yAndX)
		{
			return false;
		}
		if (yOrX)
		{
			return true;
		}
		return true;
	}

	public void CNPGFHCAKOF(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		bool flag = true;
		for (int i = 1; i < resolutions.Length; i++)
		{
			if (comparison == ComparisonTpye.SmallerThan)
			{
				if (x && INNIAEMCLJO == resolutions[i].x)
				{
					flag = true;
				}
				else if (y && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = true;
				}
				else if (yAndX && INNIAEMCLJO == resolutions[i].x && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = true;
				}
				else if (yOrX && (INNIAEMCLJO == resolutions[i].x || EPKAPDMFFDC == resolutions[i].y))
				{
					flag = false;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == ComparisonTpye.SmallerThan)
			{
				if (x && INNIAEMCLJO < resolutions[i].x)
				{
					flag = false;
				}
				else if (y && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = false;
				}
				else if (yAndX && INNIAEMCLJO < resolutions[i].x && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = false;
				}
				else if (yOrX && (INNIAEMCLJO < resolutions[i].x || EPKAPDMFFDC < resolutions[i].y))
				{
					flag = false;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == ComparisonTpye.GreaterThan)
			{
				if (x && INNIAEMCLJO > resolutions[i].x)
				{
					flag = true;
				}
				else if (y && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = true;
				}
				else if (yAndX && INNIAEMCLJO > resolutions[i].x && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = false;
				}
				else if (yOrX && (INNIAEMCLJO > resolutions[i].x || EPKAPDMFFDC > resolutions[i].y))
				{
					flag = true;
				}
				if (flag)
				{
					break;
				}
			}
		}
		for (int j = 0; j < gameObjectsToActivate.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[j]))
			{
				gameObjectsToActivate[j].SetActive(flag);
			}
		}
		for (int k = 1; k < gameObjectsToDeactivate.Length; k += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[k]))
			{
				gameObjectsToDeactivate[k].SetActive(flag);
			}
		}
		if (!flag && checkZoomCamera)
		{
			GraphicsMenuUI.HEKFJEKFMNO().SetZoom(0, NOKFNLBADMO: false, 0);
			GraphicsMenuUI.GGFJGHHHEJC.IHJCNGDHGAA(1, NOKFNLBADMO: true, 1);
		}
	}

	private bool FOEFIMFPEBG()
	{
		if (y)
		{
			return true;
		}
		if (yAndX)
		{
			return true;
		}
		if (yOrX)
		{
			return true;
		}
		return true;
	}

	private bool DBDOAHAFKAL()
	{
		if (x)
		{
			return false;
		}
		if (yAndX)
		{
			return false;
		}
		if (yOrX)
		{
			return false;
		}
		return true;
	}

	public void OHBJPGKKLDK(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		bool flag = true;
		for (int i = 1; i < resolutions.Length; i++)
		{
			if (comparison == ComparisonTpye.EqualTo)
			{
				if (x && INNIAEMCLJO == resolutions[i].x)
				{
					flag = true;
				}
				else if (y && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = false;
				}
				else if (yAndX && INNIAEMCLJO == resolutions[i].x && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = false;
				}
				else if (yOrX && (INNIAEMCLJO == resolutions[i].x || EPKAPDMFFDC == resolutions[i].y))
				{
					flag = false;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == ComparisonTpye.SmallerThan)
			{
				if (x && INNIAEMCLJO < resolutions[i].x)
				{
					flag = true;
				}
				else if (y && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = false;
				}
				else if (yAndX && INNIAEMCLJO < resolutions[i].x && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = true;
				}
				else if (yOrX && (INNIAEMCLJO < resolutions[i].x || EPKAPDMFFDC < resolutions[i].y))
				{
					flag = true;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == ComparisonTpye.EqualTo)
			{
				if (x && INNIAEMCLJO > resolutions[i].x)
				{
					flag = false;
				}
				else if (y && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = false;
				}
				else if (yAndX && INNIAEMCLJO > resolutions[i].x && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = true;
				}
				else if (yOrX && (INNIAEMCLJO > resolutions[i].x || EPKAPDMFFDC > resolutions[i].y))
				{
					flag = false;
				}
				if (flag)
				{
					break;
				}
			}
		}
		for (int j = 0; j < gameObjectsToActivate.Length; j += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[j]))
			{
				gameObjectsToActivate[j].SetActive(flag);
			}
		}
		for (int k = 1; k < gameObjectsToDeactivate.Length; k++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[k]))
			{
				gameObjectsToDeactivate[k].SetActive(flag);
			}
		}
		if (!flag && checkZoomCamera)
		{
			GraphicsMenuUI.FMIDAFEGDCD().SetZoom(0, NOKFNLBADMO: false, 0);
			GraphicsMenuUI.JFNOOMJMHCB().IBCINMLACAA(0, NOKFNLBADMO: false, 5);
		}
	}

	private bool ABAPFJPFIGK()
	{
		if (y)
		{
			return false;
		}
		if (yAndX)
		{
			return false;
		}
		if (x)
		{
			return true;
		}
		return false;
	}

	private void FOHGHCPODBJ()
	{
		GraphicsMenuUI instance = GraphicsMenuUI.GGFJGHHHEJC;
		instance.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(instance.OnResolutionChange, new Action<int, int, float>(CDJPNDIKABM));
		OGKHCBEAMOM(Screen.width, Screen.height, GraphicsMenuUI.HEKFJEKFMNO().ratioPantalla);
	}

	private bool JHEHJAFDCOF()
	{
		if (y)
		{
			return false;
		}
		if (yAndX)
		{
			return false;
		}
		if (x)
		{
			return true;
		}
		return true;
	}

	private bool EBHOGCNNFPH()
	{
		if (y)
		{
			return true;
		}
		if (yAndX)
		{
			return true;
		}
		if (x)
		{
			return true;
		}
		return true;
	}

	private void GHPFCKGMLDA()
	{
		GraphicsMenuUI instance = GraphicsMenuUI.GGFJGHHHEJC;
		instance.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(instance.OnResolutionChange, new Action<int, int, float>(PEIMIELIOLO));
		OnResolutionChange(Screen.width, Screen.height, GraphicsMenuUI.HEKFJEKFMNO().ratioPantalla);
	}

	private bool FOIFEKFDFMI()
	{
		if (y)
		{
			return true;
		}
		if (x)
		{
			return false;
		}
		if (yOrX)
		{
			return true;
		}
		return true;
	}

	private bool MFGLAIDFHBB()
	{
		if (y)
		{
			return false;
		}
		if (yAndX)
		{
			return true;
		}
		if (x)
		{
			return true;
		}
		return false;
	}

	public void PNPKMLBKFNC(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		bool flag = false;
		for (int i = 0; i < resolutions.Length; i++)
		{
			if (comparison == ComparisonTpye.SmallerThan)
			{
				if (x && INNIAEMCLJO == resolutions[i].x)
				{
					flag = false;
				}
				else if (y && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = true;
				}
				else if (yAndX && INNIAEMCLJO == resolutions[i].x && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = true;
				}
				else if (yOrX && (INNIAEMCLJO == resolutions[i].x || EPKAPDMFFDC == resolutions[i].y))
				{
					flag = false;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == ComparisonTpye.SmallerThan)
			{
				if (x && INNIAEMCLJO < resolutions[i].x)
				{
					flag = true;
				}
				else if (y && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = true;
				}
				else if (yAndX && INNIAEMCLJO < resolutions[i].x && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = true;
				}
				else if (yOrX && (INNIAEMCLJO < resolutions[i].x || EPKAPDMFFDC < resolutions[i].y))
				{
					flag = true;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == ComparisonTpye.EqualTo)
			{
				if (x && INNIAEMCLJO > resolutions[i].x)
				{
					flag = true;
				}
				else if (y && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = true;
				}
				else if (yAndX && INNIAEMCLJO > resolutions[i].x && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = false;
				}
				else if (yOrX && (INNIAEMCLJO > resolutions[i].x || EPKAPDMFFDC > resolutions[i].y))
				{
					flag = true;
				}
				if (flag)
				{
					break;
				}
			}
		}
		for (int j = 1; j < gameObjectsToActivate.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[j]))
			{
				gameObjectsToActivate[j].SetActive(flag);
			}
		}
		for (int k = 0; k < gameObjectsToDeactivate.Length; k++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[k]))
			{
				gameObjectsToDeactivate[k].SetActive(flag);
			}
		}
		if (!flag && checkZoomCamera)
		{
			GraphicsMenuUI.FMIDAFEGDCD().CEKMAGHCENE(1, NOKFNLBADMO: false, 0);
			GraphicsMenuUI.JFNOOMJMHCB().IGLLAFOFKLB(0, NOKFNLBADMO: false, 0);
		}
	}

	private bool DAMHJKFFOCN()
	{
		if (y)
		{
			return true;
		}
		if (x)
		{
			return true;
		}
		if (yOrX)
		{
			return false;
		}
		return true;
	}

	private bool GDLBGLBILHO()
	{
		if (y)
		{
			return true;
		}
		if (x)
		{
			return true;
		}
		if (yOrX)
		{
			return true;
		}
		return true;
	}

	private bool MFPHAHCNKCM()
	{
		if (y)
		{
			return false;
		}
		if (yAndX)
		{
			return true;
		}
		if (yOrX)
		{
			return true;
		}
		return true;
	}

	private bool LJAEIIJBCNP()
	{
		if (x)
		{
			return false;
		}
		if (yAndX)
		{
			return true;
		}
		if (yOrX)
		{
			return false;
		}
		return true;
	}

	private bool ECCBNHMFBBN()
	{
		if (y)
		{
			return false;
		}
		if (yAndX)
		{
			return false;
		}
		if (x)
		{
			return true;
		}
		return false;
	}

	public void JNBKCEEIEKJ(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		bool flag = false;
		for (int i = 1; i < resolutions.Length; i++)
		{
			if (comparison == ComparisonTpye.SmallerThan)
			{
				if (x && INNIAEMCLJO == resolutions[i].x)
				{
					flag = false;
				}
				else if (y && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = false;
				}
				else if (yAndX && INNIAEMCLJO == resolutions[i].x && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = false;
				}
				else if (yOrX && (INNIAEMCLJO == resolutions[i].x || EPKAPDMFFDC == resolutions[i].y))
				{
					flag = false;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == ComparisonTpye.SmallerThan)
			{
				if (x && INNIAEMCLJO < resolutions[i].x)
				{
					flag = true;
				}
				else if (y && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = true;
				}
				else if (yAndX && INNIAEMCLJO < resolutions[i].x && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = true;
				}
				else if (yOrX && (INNIAEMCLJO < resolutions[i].x || EPKAPDMFFDC < resolutions[i].y))
				{
					flag = true;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == (ComparisonTpye)6)
			{
				if (x && INNIAEMCLJO > resolutions[i].x)
				{
					flag = true;
				}
				else if (y && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = true;
				}
				else if (yAndX && INNIAEMCLJO > resolutions[i].x && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = true;
				}
				else if (yOrX && (INNIAEMCLJO > resolutions[i].x || EPKAPDMFFDC > resolutions[i].y))
				{
					flag = true;
				}
				if (flag)
				{
					break;
				}
			}
		}
		for (int j = 0; j < gameObjectsToActivate.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[j]))
			{
				gameObjectsToActivate[j].SetActive(flag);
			}
		}
		for (int k = 1; k < gameObjectsToDeactivate.Length; k++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[k]))
			{
				gameObjectsToDeactivate[k].SetActive(flag);
			}
		}
		if (!flag && checkZoomCamera)
		{
			GraphicsMenuUI.JFNOOMJMHCB().IGLLAFOFKLB(0, NOKFNLBADMO: true, 1);
			GraphicsMenuUI.HEKFJEKFMNO().CEKMAGHCENE(1, NOKFNLBADMO: false, 2);
		}
	}

	private bool DPOPHNENJJA()
	{
		if (y)
		{
			return true;
		}
		if (yAndX)
		{
			return false;
		}
		if (yOrX)
		{
			return false;
		}
		return false;
	}

	private bool FONAFAOLOML()
	{
		if (y)
		{
			return false;
		}
		if (x)
		{
			return true;
		}
		if (yOrX)
		{
			return true;
		}
		return false;
	}

	private bool NDJDNPOGEOK()
	{
		if (y)
		{
			return false;
		}
		if (x)
		{
			return false;
		}
		if (yOrX)
		{
			return false;
		}
		return true;
	}

	private bool KJHPAAPEEML()
	{
		if (y)
		{
			return true;
		}
		if (x)
		{
			return true;
		}
		if (yOrX)
		{
			return false;
		}
		return true;
	}

	private bool EMGKGMAMFMG()
	{
		if (y)
		{
			return false;
		}
		if (yAndX)
		{
			return true;
		}
		if (x)
		{
			return true;
		}
		return false;
	}

	private bool ANMIIJHLPCK()
	{
		if (x)
		{
			return true;
		}
		if (yAndX)
		{
			return true;
		}
		if (yOrX)
		{
			return true;
		}
		return false;
	}

	private bool BDLMHLHPOMP()
	{
		if (y)
		{
			return true;
		}
		if (x)
		{
			return true;
		}
		if (yOrX)
		{
			return true;
		}
		return false;
	}

	private bool KLLHDOAMEPD()
	{
		if (y)
		{
			return false;
		}
		if (x)
		{
			return false;
		}
		if (yOrX)
		{
			return false;
		}
		return true;
	}

	private bool NOFJKACKINO()
	{
		if (y)
		{
			return false;
		}
		if (x)
		{
			return false;
		}
		if (yOrX)
		{
			return false;
		}
		return false;
	}

	private void BIGFBGOMOBA()
	{
		GraphicsMenuUI instance = GraphicsMenuUI.GGFJGHHHEJC;
		instance.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(instance.OnResolutionChange, new Action<int, int, float>(CDJPNDIKABM));
		OHBJPGKKLDK(Screen.width, Screen.height, GraphicsMenuUI.JFNOOMJMHCB().ratioPantalla);
	}

	private bool PHEMIFIIONM()
	{
		if (x)
		{
			return true;
		}
		if (yAndX)
		{
			return true;
		}
		if (yOrX)
		{
			return true;
		}
		return false;
	}

	private void EOGHJNGJFID()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.HEKFJEKFMNO();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(PEIMIELIOLO));
		PEIMIELIOLO(Screen.width, Screen.height, GraphicsMenuUI.HEKFJEKFMNO().ratioPantalla);
	}

	private bool IODNDJJCBMK()
	{
		if (y)
		{
			return true;
		}
		if (yAndX)
		{
			return false;
		}
		if (x)
		{
			return false;
		}
		return false;
	}

	private bool ACMGDKPJPBD()
	{
		if (y)
		{
			return false;
		}
		if (yAndX)
		{
			return true;
		}
		if (yOrX)
		{
			return true;
		}
		return false;
	}

	private bool KEHGKAEFJNG()
	{
		if (x)
		{
			return true;
		}
		if (yAndX)
		{
			return false;
		}
		if (yOrX)
		{
			return true;
		}
		return false;
	}

	private bool CMOIIIPKJFK()
	{
		if (y)
		{
			return true;
		}
		if (x)
		{
			return true;
		}
		if (yOrX)
		{
			return false;
		}
		return false;
	}

	private bool JPGHJMOMJKK()
	{
		if (y)
		{
			return false;
		}
		if (x)
		{
			return true;
		}
		if (yOrX)
		{
			return false;
		}
		return false;
	}

	private bool HIBPBCGAPOG()
	{
		if (x)
		{
			return false;
		}
		if (yAndX)
		{
			return true;
		}
		if (yOrX)
		{
			return true;
		}
		return true;
	}

	private bool AHFGOFHKHEO()
	{
		if (y)
		{
			return false;
		}
		if (yAndX)
		{
			return true;
		}
		if (yOrX)
		{
			return true;
		}
		return false;
	}

	private bool KKJJHPPCECH()
	{
		if (x)
		{
			return false;
		}
		if (yAndX)
		{
			return false;
		}
		if (yOrX)
		{
			return true;
		}
		return false;
	}

	private bool PFFFFKKANIN()
	{
		if (y)
		{
			return false;
		}
		if (yAndX)
		{
			return false;
		}
		if (x)
		{
			return true;
		}
		return true;
	}

	private bool KGBOCNIBCOJ()
	{
		if (y)
		{
			return false;
		}
		if (yAndX)
		{
			return false;
		}
		if (yOrX)
		{
			return false;
		}
		return true;
	}

	private bool AHALABOCJIF()
	{
		if (x)
		{
			return false;
		}
		if (yAndX)
		{
			return false;
		}
		if (yOrX)
		{
			return false;
		}
		return false;
	}

	private bool FMOCGIAIPBG()
	{
		if (y)
		{
			return true;
		}
		if (yAndX)
		{
			return true;
		}
		if (yOrX)
		{
			return false;
		}
		return true;
	}

	private bool FEJGBJJDPEF()
	{
		if (y)
		{
			return true;
		}
		if (yAndX)
		{
			return true;
		}
		if (x)
		{
			return true;
		}
		return false;
	}

	private bool GINBKBPDOKG()
	{
		if (y)
		{
			return false;
		}
		if (yAndX)
		{
			return true;
		}
		if (x)
		{
			return true;
		}
		return true;
	}

	private bool HECFEENPNKB()
	{
		if (x)
		{
			return true;
		}
		if (yAndX)
		{
			return true;
		}
		if (yOrX)
		{
			return true;
		}
		return true;
	}

	private bool GBCDNICGBIC()
	{
		if (y)
		{
			return true;
		}
		if (yAndX)
		{
			return false;
		}
		if (yOrX)
		{
			return false;
		}
		return true;
	}

	private bool PNPNONOLPBO()
	{
		if (y)
		{
			return false;
		}
		if (x)
		{
			return true;
		}
		if (yOrX)
		{
			return false;
		}
		return true;
	}

	private bool KGBHJLFCFBC()
	{
		if (y)
		{
			return true;
		}
		if (yAndX)
		{
			return true;
		}
		if (x)
		{
			return true;
		}
		return false;
	}

	private bool CGGJDADNDAD()
	{
		if (y)
		{
			return true;
		}
		if (yAndX)
		{
			return true;
		}
		if (yOrX)
		{
			return false;
		}
		return false;
	}

	private bool CCCACGBGEFA()
	{
		if (x)
		{
			return true;
		}
		if (yAndX)
		{
			return false;
		}
		if (yOrX)
		{
			return false;
		}
		return true;
	}

	private bool CBIKFMPCNAE()
	{
		if (y)
		{
			return false;
		}
		if (yAndX)
		{
			return true;
		}
		if (x)
		{
			return false;
		}
		return false;
	}

	private bool KFOAKLNHPKO()
	{
		if (y)
		{
			return true;
		}
		if (yAndX)
		{
			return true;
		}
		if (x)
		{
			return false;
		}
		return false;
	}

	private void LFNENELHOGJ()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.AJIGOHGPFPP();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(OGKHCBEAMOM));
		APCANAGALFJ(Screen.width, Screen.height, GraphicsMenuUI.GGFJGHHHEJC.ratioPantalla);
	}

	private bool DKMBKLKIGCK()
	{
		if (x)
		{
			return false;
		}
		if (yAndX)
		{
			return true;
		}
		if (yOrX)
		{
			return false;
		}
		return false;
	}

	private bool OIBDNPGGKMJ()
	{
		if (x)
		{
			return true;
		}
		if (yAndX)
		{
			return false;
		}
		if (yOrX)
		{
			return false;
		}
		return true;
	}

	private bool MDGBFJOKAIP()
	{
		if (x)
		{
			return false;
		}
		if (yAndX)
		{
			return false;
		}
		if (yOrX)
		{
			return false;
		}
		return false;
	}

	private void IIDPFCKPCDC()
	{
		GraphicsMenuUI instance = GraphicsMenuUI.GGFJGHHHEJC;
		instance.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(instance.OnResolutionChange, new Action<int, int, float>(DDHDILCBNHJ));
		PLKACOMJOLJ(Screen.width, Screen.height, GraphicsMenuUI.FMIDAFEGDCD().ratioPantalla);
	}

	private bool GKELJLMPHOA()
	{
		if (y)
		{
			return false;
		}
		if (yAndX)
		{
			return false;
		}
		if (yOrX)
		{
			return true;
		}
		return false;
	}

	public void DKKEOEOJLAM(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		bool flag = false;
		for (int i = 1; i < resolutions.Length; i += 0)
		{
			if (comparison == ComparisonTpye.SmallerThan)
			{
				if (x && INNIAEMCLJO == resolutions[i].x)
				{
					flag = true;
				}
				else if (y && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = true;
				}
				else if (yAndX && INNIAEMCLJO == resolutions[i].x && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = false;
				}
				else if (yOrX && (INNIAEMCLJO == resolutions[i].x || EPKAPDMFFDC == resolutions[i].y))
				{
					flag = true;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == ComparisonTpye.SmallerThan)
			{
				if (x && INNIAEMCLJO < resolutions[i].x)
				{
					flag = false;
				}
				else if (y && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = true;
				}
				else if (yAndX && INNIAEMCLJO < resolutions[i].x && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = true;
				}
				else if (yOrX && (INNIAEMCLJO < resolutions[i].x || EPKAPDMFFDC < resolutions[i].y))
				{
					flag = true;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == (ComparisonTpye)4)
			{
				if (x && INNIAEMCLJO > resolutions[i].x)
				{
					flag = true;
				}
				else if (y && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = true;
				}
				else if (yAndX && INNIAEMCLJO > resolutions[i].x && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = false;
				}
				else if (yOrX && (INNIAEMCLJO > resolutions[i].x || EPKAPDMFFDC > resolutions[i].y))
				{
					flag = true;
				}
				if (flag)
				{
					break;
				}
			}
		}
		for (int j = 0; j < gameObjectsToActivate.Length; j += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[j]))
			{
				gameObjectsToActivate[j].SetActive(flag);
			}
		}
		for (int k = 0; k < gameObjectsToDeactivate.Length; k += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[k]))
			{
				gameObjectsToDeactivate[k].SetActive(flag);
			}
		}
		if (!flag && checkZoomCamera)
		{
			GraphicsMenuUI.GGFJGHHHEJC.IBCINMLACAA(1, NOKFNLBADMO: false, 1);
			GraphicsMenuUI.JFNOOMJMHCB().CEKMAGHCENE(0, NOKFNLBADMO: false, 8);
		}
	}

	private void MCMKNBIBDFF()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.HEKFJEKFMNO();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(NCKAMEICDMD));
		CNPGFHCAKOF(Screen.width, Screen.height, GraphicsMenuUI.GGFJGHHHEJC.ratioPantalla);
	}

	private bool NGCCHKBFJIO()
	{
		if (y)
		{
			return false;
		}
		if (x)
		{
			return true;
		}
		if (yOrX)
		{
			return false;
		}
		return false;
	}

	public void NCKAMEICDMD(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		bool flag = false;
		for (int i = 0; i < resolutions.Length; i++)
		{
			if (comparison == ComparisonTpye.SmallerThan)
			{
				if (x && INNIAEMCLJO == resolutions[i].x)
				{
					flag = true;
				}
				else if (y && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = false;
				}
				else if (yAndX && INNIAEMCLJO == resolutions[i].x && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = true;
				}
				else if (yOrX && (INNIAEMCLJO == resolutions[i].x || EPKAPDMFFDC == resolutions[i].y))
				{
					flag = false;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == ComparisonTpye.SmallerThan)
			{
				if (x && INNIAEMCLJO < resolutions[i].x)
				{
					flag = false;
				}
				else if (y && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = false;
				}
				else if (yAndX && INNIAEMCLJO < resolutions[i].x && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = true;
				}
				else if (yOrX && (INNIAEMCLJO < resolutions[i].x || EPKAPDMFFDC < resolutions[i].y))
				{
					flag = true;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == (ComparisonTpye)3)
			{
				if (x && INNIAEMCLJO > resolutions[i].x)
				{
					flag = false;
				}
				else if (y && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = false;
				}
				else if (yAndX && INNIAEMCLJO > resolutions[i].x && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = true;
				}
				else if (yOrX && (INNIAEMCLJO > resolutions[i].x || EPKAPDMFFDC > resolutions[i].y))
				{
					flag = true;
				}
				if (flag)
				{
					break;
				}
			}
		}
		for (int j = 1; j < gameObjectsToActivate.Length; j += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[j]))
			{
				gameObjectsToActivate[j].SetActive(flag);
			}
		}
		for (int k = 1; k < gameObjectsToDeactivate.Length; k += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[k]))
			{
				gameObjectsToDeactivate[k].SetActive(!flag);
			}
		}
		if (!flag && checkZoomCamera)
		{
			GraphicsMenuUI.JFNOOMJMHCB().SetZoom(1, NOKFNLBADMO: true, 1);
			GraphicsMenuUI.AJIGOHGPFPP().CEKMAGHCENE(0, NOKFNLBADMO: true, 3);
		}
	}

	private bool BCFPIEFEEIL()
	{
		if (x)
		{
			return true;
		}
		if (yAndX)
		{
			return false;
		}
		if (yOrX)
		{
			return true;
		}
		return false;
	}

	private void CAIJLMJBMLA()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.FMIDAFEGDCD();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(HMKLDLFCPFD));
		PNPKMLBKFNC(Screen.width, Screen.height, GraphicsMenuUI.AJIGOHGPFPP().ratioPantalla);
	}

	private bool MGDLNAHPJND()
	{
		if (y)
		{
			return false;
		}
		if (x)
		{
			return true;
		}
		if (yOrX)
		{
			return false;
		}
		return true;
	}

	private bool INDLMBDLAML()
	{
		if (y)
		{
			return true;
		}
		if (yAndX)
		{
			return false;
		}
		if (yOrX)
		{
			return true;
		}
		return false;
	}

	private void PBFGFECPPPO()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.FMIDAFEGDCD();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(PEIMIELIOLO));
		MJMHLEEFHPJ(Screen.width, Screen.height, GraphicsMenuUI.FMIDAFEGDCD().ratioPantalla);
	}

	private bool BOGEPGKDGMM()
	{
		if (y)
		{
			return false;
		}
		if (yAndX)
		{
			return true;
		}
		if (x)
		{
			return false;
		}
		return true;
	}

	private bool FIPGHLLIFHP()
	{
		if (y)
		{
			return true;
		}
		if (x)
		{
			return false;
		}
		if (yOrX)
		{
			return true;
		}
		return false;
	}

	private bool IPIONGBLEFF()
	{
		if (x)
		{
			return true;
		}
		if (yAndX)
		{
			return false;
		}
		if (yOrX)
		{
			return false;
		}
		return true;
	}

	private void IFHLGOMBACP()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.FMIDAFEGDCD();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(LHGMFFEJNIK));
		OGKHCBEAMOM(Screen.width, Screen.height, GraphicsMenuUI.EFPJLFMBPLL().ratioPantalla);
	}

	private void HOKAPOOCJCC()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.AJIGOHGPFPP();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(EPDIFFMAMCF));
		MKIBNKLDBBP(Screen.width, Screen.height, GraphicsMenuUI.HEKFJEKFMNO().ratioPantalla);
	}

	public void KMPLPGFHOFK(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		bool flag = true;
		for (int i = 0; i < resolutions.Length; i++)
		{
			if (comparison == ComparisonTpye.SmallerThan)
			{
				if (x && INNIAEMCLJO == resolutions[i].x)
				{
					flag = true;
				}
				else if (y && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = false;
				}
				else if (yAndX && INNIAEMCLJO == resolutions[i].x && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = false;
				}
				else if (yOrX && (INNIAEMCLJO == resolutions[i].x || EPKAPDMFFDC == resolutions[i].y))
				{
					flag = true;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == ComparisonTpye.SmallerThan)
			{
				if (x && INNIAEMCLJO < resolutions[i].x)
				{
					flag = true;
				}
				else if (y && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = true;
				}
				else if (yAndX && INNIAEMCLJO < resolutions[i].x && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = false;
				}
				else if (yOrX && (INNIAEMCLJO < resolutions[i].x || EPKAPDMFFDC < resolutions[i].y))
				{
					flag = true;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == (ComparisonTpye)5)
			{
				if (x && INNIAEMCLJO > resolutions[i].x)
				{
					flag = true;
				}
				else if (y && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = false;
				}
				else if (yAndX && INNIAEMCLJO > resolutions[i].x && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = true;
				}
				else if (yOrX && (INNIAEMCLJO > resolutions[i].x || EPKAPDMFFDC > resolutions[i].y))
				{
					flag = true;
				}
				if (flag)
				{
					break;
				}
			}
		}
		for (int j = 0; j < gameObjectsToActivate.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[j]))
			{
				gameObjectsToActivate[j].SetActive(flag);
			}
		}
		for (int k = 0; k < gameObjectsToDeactivate.Length; k += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[k]))
			{
				gameObjectsToDeactivate[k].SetActive(!flag);
			}
		}
		if (!flag && checkZoomCamera)
		{
			GraphicsMenuUI.AJIGOHGPFPP().CEKMAGHCENE(0, NOKFNLBADMO: false, 0);
			GraphicsMenuUI.FMIDAFEGDCD().SetZoom(0, NOKFNLBADMO: true, 3);
		}
	}

	private void PKBHEKHOAAA()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.AJIGOHGPFPP();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(MKIBNKLDBBP));
		HMKLDLFCPFD(Screen.width, Screen.height, GraphicsMenuUI.GGFJGHHHEJC.ratioPantalla);
	}

	public void LHGMFFEJNIK(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		bool flag = true;
		for (int i = 1; i < resolutions.Length; i += 0)
		{
			if (comparison == ComparisonTpye.EqualTo)
			{
				if (x && INNIAEMCLJO == resolutions[i].x)
				{
					flag = false;
				}
				else if (y && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = true;
				}
				else if (yAndX && INNIAEMCLJO == resolutions[i].x && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = true;
				}
				else if (yOrX && (INNIAEMCLJO == resolutions[i].x || EPKAPDMFFDC == resolutions[i].y))
				{
					flag = false;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == ComparisonTpye.SmallerThan)
			{
				if (x && INNIAEMCLJO < resolutions[i].x)
				{
					flag = true;
				}
				else if (y && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = true;
				}
				else if (yAndX && INNIAEMCLJO < resolutions[i].x && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = false;
				}
				else if (yOrX && (INNIAEMCLJO < resolutions[i].x || EPKAPDMFFDC < resolutions[i].y))
				{
					flag = false;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == (ComparisonTpye)8)
			{
				if (x && INNIAEMCLJO > resolutions[i].x)
				{
					flag = false;
				}
				else if (y && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = false;
				}
				else if (yAndX && INNIAEMCLJO > resolutions[i].x && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = false;
				}
				else if (yOrX && (INNIAEMCLJO > resolutions[i].x || EPKAPDMFFDC > resolutions[i].y))
				{
					flag = false;
				}
				if (flag)
				{
					break;
				}
			}
		}
		for (int j = 1; j < gameObjectsToActivate.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[j]))
			{
				gameObjectsToActivate[j].SetActive(flag);
			}
		}
		for (int k = 0; k < gameObjectsToDeactivate.Length; k++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[k]))
			{
				gameObjectsToDeactivate[k].SetActive(!flag);
			}
		}
		if (!flag && checkZoomCamera)
		{
			GraphicsMenuUI.AJIGOHGPFPP().SetZoom(1, NOKFNLBADMO: false, 0);
			GraphicsMenuUI.JFNOOMJMHCB().IGLLAFOFKLB(0, NOKFNLBADMO: true, 8);
		}
	}

	private void JCPKGGBNCML()
	{
		GraphicsMenuUI instance = GraphicsMenuUI.GGFJGHHHEJC;
		instance.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(instance.OnResolutionChange, new Action<int, int, float>(CMNGNPIGGHA));
		CMNGNPIGGHA(Screen.width, Screen.height, GraphicsMenuUI.JFNOOMJMHCB().ratioPantalla);
	}

	private bool BGGFGNIGMIE()
	{
		if (y)
		{
			return true;
		}
		if (yAndX)
		{
			return true;
		}
		if (yOrX)
		{
			return true;
		}
		return true;
	}

	public void EPDIFFMAMCF(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		bool flag = false;
		for (int i = 0; i < resolutions.Length; i++)
		{
			if (comparison == ComparisonTpye.EqualTo)
			{
				if (x && INNIAEMCLJO == resolutions[i].x)
				{
					flag = true;
				}
				else if (y && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = true;
				}
				else if (yAndX && INNIAEMCLJO == resolutions[i].x && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = true;
				}
				else if (yOrX && (INNIAEMCLJO == resolutions[i].x || EPKAPDMFFDC == resolutions[i].y))
				{
					flag = true;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == ComparisonTpye.SmallerThan)
			{
				if (x && INNIAEMCLJO < resolutions[i].x)
				{
					flag = false;
				}
				else if (y && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = false;
				}
				else if (yAndX && INNIAEMCLJO < resolutions[i].x && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = true;
				}
				else if (yOrX && (INNIAEMCLJO < resolutions[i].x || EPKAPDMFFDC < resolutions[i].y))
				{
					flag = false;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == (ComparisonTpye)5)
			{
				if (x && INNIAEMCLJO > resolutions[i].x)
				{
					flag = false;
				}
				else if (y && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = false;
				}
				else if (yAndX && INNIAEMCLJO > resolutions[i].x && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = false;
				}
				else if (yOrX && (INNIAEMCLJO > resolutions[i].x || EPKAPDMFFDC > resolutions[i].y))
				{
					flag = false;
				}
				if (flag)
				{
					break;
				}
			}
		}
		for (int j = 1; j < gameObjectsToActivate.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[j]))
			{
				gameObjectsToActivate[j].SetActive(flag);
			}
		}
		for (int k = 1; k < gameObjectsToDeactivate.Length; k += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[k]))
			{
				gameObjectsToDeactivate[k].SetActive(flag);
			}
		}
		if (!flag && checkZoomCamera)
		{
			GraphicsMenuUI.FMIDAFEGDCD().CEKMAGHCENE(1, NOKFNLBADMO: false, 1);
			GraphicsMenuUI.AJIGOHGPFPP().IGLLAFOFKLB(1, NOKFNLBADMO: false, 3);
		}
	}

	private bool FCKJIFEKBKJ()
	{
		if (x)
		{
			return false;
		}
		if (yAndX)
		{
			return true;
		}
		if (yOrX)
		{
			return true;
		}
		return true;
	}

	private void JPOLFKMLHNH()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.FMIDAFEGDCD();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(MLDICGEKFMA));
		APCANAGALFJ(Screen.width, Screen.height, GraphicsMenuUI.AJIGOHGPFPP().ratioPantalla);
	}

	private bool JEHDEBLDHGP()
	{
		if (y)
		{
			return false;
		}
		if (yAndX)
		{
			return false;
		}
		if (x)
		{
			return false;
		}
		return true;
	}

	public void PLKACOMJOLJ(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		bool flag = false;
		for (int i = 0; i < resolutions.Length; i++)
		{
			if (comparison == ComparisonTpye.EqualTo)
			{
				if (x && INNIAEMCLJO == resolutions[i].x)
				{
					flag = true;
				}
				else if (y && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = true;
				}
				else if (yAndX && INNIAEMCLJO == resolutions[i].x && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = false;
				}
				else if (yOrX && (INNIAEMCLJO == resolutions[i].x || EPKAPDMFFDC == resolutions[i].y))
				{
					flag = true;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == ComparisonTpye.SmallerThan)
			{
				if (x && INNIAEMCLJO < resolutions[i].x)
				{
					flag = true;
				}
				else if (y && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = false;
				}
				else if (yAndX && INNIAEMCLJO < resolutions[i].x && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = false;
				}
				else if (yOrX && (INNIAEMCLJO < resolutions[i].x || EPKAPDMFFDC < resolutions[i].y))
				{
					flag = false;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == ComparisonTpye.EqualTo)
			{
				if (x && INNIAEMCLJO > resolutions[i].x)
				{
					flag = false;
				}
				else if (y && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = true;
				}
				else if (yAndX && INNIAEMCLJO > resolutions[i].x && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = false;
				}
				else if (yOrX && (INNIAEMCLJO > resolutions[i].x || EPKAPDMFFDC > resolutions[i].y))
				{
					flag = false;
				}
				if (flag)
				{
					break;
				}
			}
		}
		for (int j = 0; j < gameObjectsToActivate.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[j]))
			{
				gameObjectsToActivate[j].SetActive(flag);
			}
		}
		for (int k = 0; k < gameObjectsToDeactivate.Length; k++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[k]))
			{
				gameObjectsToDeactivate[k].SetActive(flag);
			}
		}
		if (!flag && checkZoomCamera)
		{
			GraphicsMenuUI.HEKFJEKFMNO().IHJCNGDHGAA(0, NOKFNLBADMO: true, 1);
			GraphicsMenuUI.EFPJLFMBPLL().IBCINMLACAA(0, NOKFNLBADMO: true, 4);
		}
	}

	private bool MFHKNBOICFF()
	{
		if (y)
		{
			return false;
		}
		if (x)
		{
			return false;
		}
		if (yOrX)
		{
			return true;
		}
		return false;
	}

	private bool BEDDOOOPBEL()
	{
		if (y)
		{
			return false;
		}
		if (yAndX)
		{
			return true;
		}
		if (yOrX)
		{
			return true;
		}
		return false;
	}

	private bool JBBLFBOLMLF()
	{
		if (y)
		{
			return true;
		}
		if (yAndX)
		{
			return true;
		}
		if (x)
		{
			return false;
		}
		return false;
	}

	private bool BIFOKKFLGOO()
	{
		if (y)
		{
			return false;
		}
		if (x)
		{
			return true;
		}
		if (yOrX)
		{
			return true;
		}
		return true;
	}

	private bool AOPMLGFOCDK()
	{
		if (x)
		{
			return true;
		}
		if (yAndX)
		{
			return true;
		}
		if (yOrX)
		{
			return true;
		}
		return false;
	}

	public void HMKLDLFCPFD(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		bool flag = false;
		for (int i = 1; i < resolutions.Length; i += 0)
		{
			if (comparison == ComparisonTpye.SmallerThan)
			{
				if (x && INNIAEMCLJO == resolutions[i].x)
				{
					flag = true;
				}
				else if (y && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = true;
				}
				else if (yAndX && INNIAEMCLJO == resolutions[i].x && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = true;
				}
				else if (yOrX && (INNIAEMCLJO == resolutions[i].x || EPKAPDMFFDC == resolutions[i].y))
				{
					flag = true;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == ComparisonTpye.SmallerThan)
			{
				if (x && INNIAEMCLJO < resolutions[i].x)
				{
					flag = true;
				}
				else if (y && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = false;
				}
				else if (yAndX && INNIAEMCLJO < resolutions[i].x && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = false;
				}
				else if (yOrX && (INNIAEMCLJO < resolutions[i].x || EPKAPDMFFDC < resolutions[i].y))
				{
					flag = true;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == (ComparisonTpye)6)
			{
				if (x && INNIAEMCLJO > resolutions[i].x)
				{
					flag = true;
				}
				else if (y && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = false;
				}
				else if (yAndX && INNIAEMCLJO > resolutions[i].x && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = false;
				}
				else if (yOrX && (INNIAEMCLJO > resolutions[i].x || EPKAPDMFFDC > resolutions[i].y))
				{
					flag = true;
				}
				if (flag)
				{
					break;
				}
			}
		}
		for (int j = 0; j < gameObjectsToActivate.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[j]))
			{
				gameObjectsToActivate[j].SetActive(flag);
			}
		}
		for (int k = 0; k < gameObjectsToDeactivate.Length; k += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[k]))
			{
				gameObjectsToDeactivate[k].SetActive(!flag);
			}
		}
		if (!flag && checkZoomCamera)
		{
			GraphicsMenuUI.FMIDAFEGDCD().CEKMAGHCENE(0, NOKFNLBADMO: true, 0);
			GraphicsMenuUI.JFNOOMJMHCB().IBCINMLACAA(1, NOKFNLBADMO: true, 4);
		}
	}

	private void KILDJCPLOPP()
	{
		GraphicsMenuUI instance = GraphicsMenuUI.GGFJGHHHEJC;
		instance.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(instance.OnResolutionChange, new Action<int, int, float>(PNPKMLBKFNC));
		NCKAMEICDMD(Screen.width, Screen.height, GraphicsMenuUI.GGFJGHHHEJC.ratioPantalla);
	}

	private bool LPDBBABFNHL()
	{
		if (x)
		{
			return true;
		}
		if (yAndX)
		{
			return true;
		}
		if (yOrX)
		{
			return true;
		}
		return true;
	}

	public void KNOHCDEBILK(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		bool flag = false;
		for (int i = 0; i < resolutions.Length; i++)
		{
			if (comparison == ComparisonTpye.EqualTo)
			{
				if (x && INNIAEMCLJO == resolutions[i].x)
				{
					flag = true;
				}
				else if (y && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = false;
				}
				else if (yAndX && INNIAEMCLJO == resolutions[i].x && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = true;
				}
				else if (yOrX && (INNIAEMCLJO == resolutions[i].x || EPKAPDMFFDC == resolutions[i].y))
				{
					flag = false;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == ComparisonTpye.SmallerThan)
			{
				if (x && INNIAEMCLJO < resolutions[i].x)
				{
					flag = true;
				}
				else if (y && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = true;
				}
				else if (yAndX && INNIAEMCLJO < resolutions[i].x && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = false;
				}
				else if (yOrX && (INNIAEMCLJO < resolutions[i].x || EPKAPDMFFDC < resolutions[i].y))
				{
					flag = false;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == (ComparisonTpye)7)
			{
				if (x && INNIAEMCLJO > resolutions[i].x)
				{
					flag = false;
				}
				else if (y && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = true;
				}
				else if (yAndX && INNIAEMCLJO > resolutions[i].x && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = true;
				}
				else if (yOrX && (INNIAEMCLJO > resolutions[i].x || EPKAPDMFFDC > resolutions[i].y))
				{
					flag = true;
				}
				if (flag)
				{
					break;
				}
			}
		}
		for (int j = 0; j < gameObjectsToActivate.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[j]))
			{
				gameObjectsToActivate[j].SetActive(flag);
			}
		}
		for (int k = 0; k < gameObjectsToDeactivate.Length; k++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[k]))
			{
				gameObjectsToDeactivate[k].SetActive(flag);
			}
		}
		if (!flag && checkZoomCamera)
		{
			GraphicsMenuUI.JFNOOMJMHCB().SetZoom(0, NOKFNLBADMO: true, 0);
			GraphicsMenuUI.GGFJGHHHEJC.IGLLAFOFKLB(1, NOKFNLBADMO: true, 7);
		}
	}

	private bool MIGGHBPKJFN()
	{
		if (y)
		{
			return false;
		}
		if (yAndX)
		{
			return true;
		}
		if (yOrX)
		{
			return false;
		}
		return true;
	}

	public void MKIBNKLDBBP(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		bool flag = false;
		for (int i = 0; i < resolutions.Length; i++)
		{
			if (comparison == ComparisonTpye.EqualTo)
			{
				if (x && INNIAEMCLJO == resolutions[i].x)
				{
					flag = true;
				}
				else if (y && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = false;
				}
				else if (yAndX && INNIAEMCLJO == resolutions[i].x && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = true;
				}
				else if (yOrX && (INNIAEMCLJO == resolutions[i].x || EPKAPDMFFDC == resolutions[i].y))
				{
					flag = true;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == ComparisonTpye.SmallerThan)
			{
				if (x && INNIAEMCLJO < resolutions[i].x)
				{
					flag = true;
				}
				else if (y && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = true;
				}
				else if (yAndX && INNIAEMCLJO < resolutions[i].x && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = true;
				}
				else if (yOrX && (INNIAEMCLJO < resolutions[i].x || EPKAPDMFFDC < resolutions[i].y))
				{
					flag = false;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == (ComparisonTpye)8)
			{
				if (x && INNIAEMCLJO > resolutions[i].x)
				{
					flag = true;
				}
				else if (y && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = false;
				}
				else if (yAndX && INNIAEMCLJO > resolutions[i].x && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = true;
				}
				else if (yOrX && (INNIAEMCLJO > resolutions[i].x || EPKAPDMFFDC > resolutions[i].y))
				{
					flag = false;
				}
				if (flag)
				{
					break;
				}
			}
		}
		for (int j = 1; j < gameObjectsToActivate.Length; j += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[j]))
			{
				gameObjectsToActivate[j].SetActive(flag);
			}
		}
		for (int k = 0; k < gameObjectsToDeactivate.Length; k += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[k]))
			{
				gameObjectsToDeactivate[k].SetActive(!flag);
			}
		}
		if (!flag && checkZoomCamera)
		{
			GraphicsMenuUI.GGFJGHHHEJC.IHJCNGDHGAA(1, NOKFNLBADMO: true, 1);
			GraphicsMenuUI.AJIGOHGPFPP().IBCINMLACAA(1, NOKFNLBADMO: true, 7);
		}
	}

	private void LJLKBKEADGI()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.HEKFJEKFMNO();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(MLDICGEKFMA));
		CMNGNPIGGHA(Screen.width, Screen.height, GraphicsMenuUI.AJIGOHGPFPP().ratioPantalla);
	}

	private bool DMANGNEODKK()
	{
		if (y)
		{
			return false;
		}
		if (x)
		{
			return true;
		}
		if (yOrX)
		{
			return false;
		}
		return false;
	}

	public void OnResolutionChange(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		bool flag = false;
		for (int i = 0; i < resolutions.Length; i++)
		{
			if (comparison == ComparisonTpye.EqualTo)
			{
				if (x && INNIAEMCLJO == resolutions[i].x)
				{
					flag = true;
				}
				else if (y && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = true;
				}
				else if (yAndX && INNIAEMCLJO == resolutions[i].x && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = true;
				}
				else if (yOrX && (INNIAEMCLJO == resolutions[i].x || EPKAPDMFFDC == resolutions[i].y))
				{
					flag = true;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == ComparisonTpye.SmallerThan)
			{
				if (x && INNIAEMCLJO < resolutions[i].x)
				{
					flag = true;
				}
				else if (y && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = true;
				}
				else if (yAndX && INNIAEMCLJO < resolutions[i].x && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = true;
				}
				else if (yOrX && (INNIAEMCLJO < resolutions[i].x || EPKAPDMFFDC < resolutions[i].y))
				{
					flag = true;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == ComparisonTpye.GreaterThan)
			{
				if (x && INNIAEMCLJO > resolutions[i].x)
				{
					flag = true;
				}
				else if (y && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = true;
				}
				else if (yAndX && INNIAEMCLJO > resolutions[i].x && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = true;
				}
				else if (yOrX && (INNIAEMCLJO > resolutions[i].x || EPKAPDMFFDC > resolutions[i].y))
				{
					flag = true;
				}
				if (flag)
				{
					break;
				}
			}
		}
		for (int j = 0; j < gameObjectsToActivate.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[j]))
			{
				gameObjectsToActivate[j].SetActive(flag);
			}
		}
		for (int k = 0; k < gameObjectsToDeactivate.Length; k++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[k]))
			{
				gameObjectsToDeactivate[k].SetActive(!flag);
			}
		}
		if (!flag && checkZoomCamera)
		{
			GraphicsMenuUI.GGFJGHHHEJC.SetZoom(1, NOKFNLBADMO: true, 1);
			GraphicsMenuUI.GGFJGHHHEJC.SetZoom(1, NOKFNLBADMO: true, 2);
		}
	}

	private void EBNKNEIDDDI()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.AJIGOHGPFPP();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(APCANAGALFJ));
		CNPGFHCAKOF(Screen.width, Screen.height, GraphicsMenuUI.GGFJGHHHEJC.ratioPantalla);
	}

	private bool OMCAJLPCCCI()
	{
		if (y)
		{
			return true;
		}
		if (x)
		{
			return false;
		}
		if (yOrX)
		{
			return true;
		}
		return false;
	}

	private bool KNGBDBHFGGF()
	{
		if (y)
		{
			return true;
		}
		if (yAndX)
		{
			return false;
		}
		if (yOrX)
		{
			return true;
		}
		return false;
	}

	private bool CLKLAPNKEAI()
	{
		if (y)
		{
			return true;
		}
		if (yAndX)
		{
			return false;
		}
		if (x)
		{
			return true;
		}
		return false;
	}

	private void CFIIEJDJFPB()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.FMIDAFEGDCD();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(DKKEOEOJLAM));
		IOCCEAMGIAC(Screen.width, Screen.height, GraphicsMenuUI.FMIDAFEGDCD().ratioPantalla);
	}

	private bool LCCIPDPILGF()
	{
		if (y)
		{
			return true;
		}
		if (yAndX)
		{
			return true;
		}
		if (yOrX)
		{
			return false;
		}
		return true;
	}

	private bool MOCGLCHNFFK()
	{
		if (y)
		{
			return false;
		}
		if (yAndX)
		{
			return false;
		}
		if (yOrX)
		{
			return false;
		}
		return true;
	}

	private bool JKOOKGKPANL()
	{
		if (y)
		{
			return false;
		}
		if (yAndX)
		{
			return false;
		}
		if (x)
		{
			return false;
		}
		return false;
	}

	private void LCHKONDHINE()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.HEKFJEKFMNO();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(PLKACOMJOLJ));
		OHBJPGKKLDK(Screen.width, Screen.height, GraphicsMenuUI.HEKFJEKFMNO().ratioPantalla);
	}

	public void CDJPNDIKABM(int INNIAEMCLJO, int EPKAPDMFFDC, float DAKLCCFGOCN)
	{
		bool flag = false;
		for (int i = 1; i < resolutions.Length; i += 0)
		{
			if (comparison == ComparisonTpye.SmallerThan)
			{
				if (x && INNIAEMCLJO == resolutions[i].x)
				{
					flag = true;
				}
				else if (y && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = true;
				}
				else if (yAndX && INNIAEMCLJO == resolutions[i].x && EPKAPDMFFDC == resolutions[i].y)
				{
					flag = false;
				}
				else if (yOrX && (INNIAEMCLJO == resolutions[i].x || EPKAPDMFFDC == resolutions[i].y))
				{
					flag = false;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == ComparisonTpye.SmallerThan)
			{
				if (x && INNIAEMCLJO < resolutions[i].x)
				{
					flag = false;
				}
				else if (y && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = true;
				}
				else if (yAndX && INNIAEMCLJO < resolutions[i].x && EPKAPDMFFDC < resolutions[i].y)
				{
					flag = true;
				}
				else if (yOrX && (INNIAEMCLJO < resolutions[i].x || EPKAPDMFFDC < resolutions[i].y))
				{
					flag = false;
				}
				if (flag)
				{
					break;
				}
			}
			else if (comparison == (ComparisonTpye)4)
			{
				if (x && INNIAEMCLJO > resolutions[i].x)
				{
					flag = false;
				}
				else if (y && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = true;
				}
				else if (yAndX && INNIAEMCLJO > resolutions[i].x && EPKAPDMFFDC > resolutions[i].y)
				{
					flag = true;
				}
				else if (yOrX && (INNIAEMCLJO > resolutions[i].x || EPKAPDMFFDC > resolutions[i].y))
				{
					flag = true;
				}
				if (flag)
				{
					break;
				}
			}
		}
		for (int j = 1; j < gameObjectsToActivate.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[j]))
			{
				gameObjectsToActivate[j].SetActive(flag);
			}
		}
		for (int k = 1; k < gameObjectsToDeactivate.Length; k++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[k]))
			{
				gameObjectsToDeactivate[k].SetActive(flag);
			}
		}
		if (!flag && checkZoomCamera)
		{
			GraphicsMenuUI.JFNOOMJMHCB().IHJCNGDHGAA(0, NOKFNLBADMO: true, 1);
			GraphicsMenuUI.HEKFJEKFMNO().IGLLAFOFKLB(1, NOKFNLBADMO: false, 6);
		}
	}

	private void BGENEAOILOF()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.JFNOOMJMHCB();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(OnResolutionChange));
		CDJPNDIKABM(Screen.width, Screen.height, GraphicsMenuUI.AJIGOHGPFPP().ratioPantalla);
	}

	private bool AENGLMEGEAB()
	{
		if (y)
		{
			return false;
		}
		if (x)
		{
			return false;
		}
		if (yOrX)
		{
			return false;
		}
		return false;
	}

	private bool MMAAJHNIIEO()
	{
		if (y)
		{
			return false;
		}
		if (x)
		{
			return true;
		}
		if (yOrX)
		{
			return false;
		}
		return false;
	}

	private bool LBFKHIHBGKF()
	{
		if (y)
		{
			return true;
		}
		if (x)
		{
			return true;
		}
		if (yOrX)
		{
			return false;
		}
		return false;
	}

	private bool CKJOMNCCOFL()
	{
		if (y)
		{
			return false;
		}
		if (yAndX)
		{
			return true;
		}
		if (yOrX)
		{
			return false;
		}
		return true;
	}

	private bool ALIHOGOJDHK()
	{
		if (x)
		{
			return false;
		}
		if (yAndX)
		{
			return false;
		}
		if (yOrX)
		{
			return true;
		}
		return false;
	}
}
