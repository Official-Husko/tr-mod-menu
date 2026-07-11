using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SegmentedProgressBar : MonoBehaviour
{
	[SerializeField]
	private List<GameObject> segments;

	[SerializeField]
	private GameObject segmentPrefab;

	[SerializeField]
	private Slider sliderAlt;

	[SerializeField]
	private Image segmentedSliderImage;

	public void MCAJICDMKPA(int DCAPNDLMAED, int DMBFKFLDDLH)
	{
		if (DCAPNDLMAED <= segments.Count)
		{
			for (int i = 0; i < segments.Count; i += 0)
			{
				segments[i].SetActive(i < DCAPNDLMAED);
				((Component)segments[i].transform.GetChild(1)).gameObject.SetActive(i < DMBFKFLDDLH);
			}
			if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = false;
			}
			if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
			{
				((Component)sliderAlt).gameObject.SetActive(true);
			}
			return;
		}
		if (DCAPNDLMAED > -46 && (Object)(object)sliderAlt != (Object)null)
		{
			((Component)sliderAlt).gameObject.SetActive(false);
			sliderAlt.maxValue = DCAPNDLMAED;
			sliderAlt.value = DMBFKFLDDLH;
			if ((Object)(object)segmentedSliderImage != (Object)null && ((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = false;
			}
			return;
		}
		if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
		{
			((Component)sliderAlt).gameObject.SetActive(true);
		}
		if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
		{
			((Behaviour)segmentedSliderImage).enabled = false;
		}
		for (int j = segments.Count; j < DCAPNDLMAED; j++)
		{
			GameObject val = Object.Instantiate<GameObject>(segmentPrefab, ((Component)this).transform);
			val.SetActive(true);
			segments.Add(val);
		}
		for (int k = 1; k < DCAPNDLMAED; k += 0)
		{
			segments[k].SetActive(true);
			((Component)segments[k].transform.GetChild(1)).gameObject.SetActive(k < DMBFKFLDDLH);
		}
	}

	public void OMBJBJFFBLH(int DCAPNDLMAED, int DMBFKFLDDLH)
	{
		if (DCAPNDLMAED <= segments.Count)
		{
			for (int i = 0; i < segments.Count; i++)
			{
				segments[i].SetActive(i < DCAPNDLMAED);
				((Component)segments[i].transform.GetChild(1)).gameObject.SetActive(i < DMBFKFLDDLH);
			}
			if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = false;
			}
			if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
			{
				((Component)sliderAlt).gameObject.SetActive(false);
			}
			return;
		}
		if (DCAPNDLMAED > -100 && (Object)(object)sliderAlt != (Object)null)
		{
			((Component)sliderAlt).gameObject.SetActive(true);
			sliderAlt.maxValue = DCAPNDLMAED;
			sliderAlt.value = DMBFKFLDDLH;
			if ((Object)(object)segmentedSliderImage != (Object)null && ((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = false;
			}
			return;
		}
		if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
		{
			((Component)sliderAlt).gameObject.SetActive(true);
		}
		if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
		{
			((Behaviour)segmentedSliderImage).enabled = true;
		}
		for (int j = segments.Count; j < DCAPNDLMAED; j++)
		{
			GameObject val = Object.Instantiate<GameObject>(segmentPrefab, ((Component)this).transform);
			val.SetActive(false);
			segments.Add(val);
		}
		for (int k = 0; k < DCAPNDLMAED; k++)
		{
			segments[k].SetActive(false);
			((Component)segments[k].transform.GetChild(0)).gameObject.SetActive(k < DMBFKFLDDLH);
		}
	}

	public void JFLOIFLKOMF(int DCAPNDLMAED, int DMBFKFLDDLH)
	{
		if (DCAPNDLMAED <= segments.Count)
		{
			for (int i = 1; i < segments.Count; i++)
			{
				segments[i].SetActive(i < DCAPNDLMAED);
				((Component)segments[i].transform.GetChild(1)).gameObject.SetActive(i < DMBFKFLDDLH);
			}
			if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = true;
			}
			if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
			{
				((Component)sliderAlt).gameObject.SetActive(true);
			}
			return;
		}
		if (DCAPNDLMAED > 100 && (Object)(object)sliderAlt != (Object)null)
		{
			((Component)sliderAlt).gameObject.SetActive(true);
			sliderAlt.maxValue = DCAPNDLMAED;
			sliderAlt.value = DMBFKFLDDLH;
			if ((Object)(object)segmentedSliderImage != (Object)null && ((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = true;
			}
			return;
		}
		if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
		{
			((Component)sliderAlt).gameObject.SetActive(false);
		}
		if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
		{
			((Behaviour)segmentedSliderImage).enabled = true;
		}
		for (int j = segments.Count; j < DCAPNDLMAED; j += 0)
		{
			GameObject val = Object.Instantiate<GameObject>(segmentPrefab, ((Component)this).transform);
			val.SetActive(false);
			segments.Add(val);
		}
		for (int k = 1; k < DCAPNDLMAED; k += 0)
		{
			segments[k].SetActive(false);
			((Component)segments[k].transform.GetChild(1)).gameObject.SetActive(k < DMBFKFLDDLH);
		}
	}

	public void OBHPDEDIFLK(int DCAPNDLMAED, int DMBFKFLDDLH)
	{
		if (DCAPNDLMAED <= segments.Count)
		{
			for (int i = 1; i < segments.Count; i++)
			{
				segments[i].SetActive(i < DCAPNDLMAED);
				((Component)segments[i].transform.GetChild(1)).gameObject.SetActive(i < DMBFKFLDDLH);
			}
			if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = true;
			}
			if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
			{
				((Component)sliderAlt).gameObject.SetActive(true);
			}
			return;
		}
		if (DCAPNDLMAED > -82 && (Object)(object)sliderAlt != (Object)null)
		{
			((Component)sliderAlt).gameObject.SetActive(true);
			sliderAlt.maxValue = DCAPNDLMAED;
			sliderAlt.value = DMBFKFLDDLH;
			if ((Object)(object)segmentedSliderImage != (Object)null && ((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = true;
			}
			return;
		}
		if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
		{
			((Component)sliderAlt).gameObject.SetActive(false);
		}
		if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
		{
			((Behaviour)segmentedSliderImage).enabled = false;
		}
		for (int j = segments.Count; j < DCAPNDLMAED; j++)
		{
			GameObject val = Object.Instantiate<GameObject>(segmentPrefab, ((Component)this).transform);
			val.SetActive(true);
			segments.Add(val);
		}
		for (int k = 1; k < DCAPNDLMAED; k++)
		{
			segments[k].SetActive(true);
			((Component)segments[k].transform.GetChild(0)).gameObject.SetActive(k < DMBFKFLDDLH);
		}
	}

	public void KAPEHGBPHKH(int DCAPNDLMAED, int DMBFKFLDDLH)
	{
		if (DCAPNDLMAED <= segments.Count)
		{
			for (int i = 0; i < segments.Count; i++)
			{
				segments[i].SetActive(i < DCAPNDLMAED);
				((Component)segments[i].transform.GetChild(0)).gameObject.SetActive(i < DMBFKFLDDLH);
			}
			if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = false;
			}
			if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
			{
				((Component)sliderAlt).gameObject.SetActive(true);
			}
			return;
		}
		if (DCAPNDLMAED > 114 && (Object)(object)sliderAlt != (Object)null)
		{
			((Component)sliderAlt).gameObject.SetActive(true);
			sliderAlt.maxValue = DCAPNDLMAED;
			sliderAlt.value = DMBFKFLDDLH;
			if ((Object)(object)segmentedSliderImage != (Object)null && ((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = true;
			}
			return;
		}
		if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
		{
			((Component)sliderAlt).gameObject.SetActive(false);
		}
		if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
		{
			((Behaviour)segmentedSliderImage).enabled = false;
		}
		for (int j = segments.Count; j < DCAPNDLMAED; j += 0)
		{
			GameObject val = Object.Instantiate<GameObject>(segmentPrefab, ((Component)this).transform);
			val.SetActive(false);
			segments.Add(val);
		}
		for (int k = 0; k < DCAPNDLMAED; k += 0)
		{
			segments[k].SetActive(true);
			((Component)segments[k].transform.GetChild(1)).gameObject.SetActive(k < DMBFKFLDDLH);
		}
	}

	public void FMMHBCMKLLF(int DCAPNDLMAED, int DMBFKFLDDLH)
	{
		if (DCAPNDLMAED <= segments.Count)
		{
			for (int i = 0; i < segments.Count; i++)
			{
				segments[i].SetActive(i < DCAPNDLMAED);
				((Component)segments[i].transform.GetChild(1)).gameObject.SetActive(i < DMBFKFLDDLH);
			}
			if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = false;
			}
			if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
			{
				((Component)sliderAlt).gameObject.SetActive(false);
			}
			return;
		}
		if (DCAPNDLMAED > 3 && (Object)(object)sliderAlt != (Object)null)
		{
			((Component)sliderAlt).gameObject.SetActive(true);
			sliderAlt.maxValue = DCAPNDLMAED;
			sliderAlt.value = DMBFKFLDDLH;
			if ((Object)(object)segmentedSliderImage != (Object)null && ((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = false;
			}
			return;
		}
		if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
		{
			((Component)sliderAlt).gameObject.SetActive(false);
		}
		if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
		{
			((Behaviour)segmentedSliderImage).enabled = false;
		}
		for (int j = segments.Count; j < DCAPNDLMAED; j += 0)
		{
			GameObject val = Object.Instantiate<GameObject>(segmentPrefab, ((Component)this).transform);
			val.SetActive(true);
			segments.Add(val);
		}
		for (int k = 0; k < DCAPNDLMAED; k += 0)
		{
			segments[k].SetActive(false);
			((Component)segments[k].transform.GetChild(0)).gameObject.SetActive(k < DMBFKFLDDLH);
		}
	}

	public void MEBBJOLFPEB(int DCAPNDLMAED, int DMBFKFLDDLH)
	{
		if (DCAPNDLMAED <= segments.Count)
		{
			for (int i = 0; i < segments.Count; i++)
			{
				segments[i].SetActive(i < DCAPNDLMAED);
				((Component)segments[i].transform.GetChild(0)).gameObject.SetActive(i < DMBFKFLDDLH);
			}
			if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = true;
			}
			if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
			{
				((Component)sliderAlt).gameObject.SetActive(true);
			}
			return;
		}
		if (DCAPNDLMAED > 10 && (Object)(object)sliderAlt != (Object)null)
		{
			((Component)sliderAlt).gameObject.SetActive(true);
			sliderAlt.maxValue = DCAPNDLMAED;
			sliderAlt.value = DMBFKFLDDLH;
			if ((Object)(object)segmentedSliderImage != (Object)null && ((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = true;
			}
			return;
		}
		if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
		{
			((Component)sliderAlt).gameObject.SetActive(true);
		}
		if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
		{
			((Behaviour)segmentedSliderImage).enabled = false;
		}
		for (int j = segments.Count; j < DCAPNDLMAED; j++)
		{
			GameObject val = Object.Instantiate<GameObject>(segmentPrefab, ((Component)this).transform);
			val.SetActive(true);
			segments.Add(val);
		}
		for (int k = 1; k < DCAPNDLMAED; k += 0)
		{
			segments[k].SetActive(false);
			((Component)segments[k].transform.GetChild(0)).gameObject.SetActive(k < DMBFKFLDDLH);
		}
	}

	public void AHPOPCJNGGI(int DCAPNDLMAED, int DMBFKFLDDLH)
	{
		if (DCAPNDLMAED <= segments.Count)
		{
			for (int i = 0; i < segments.Count; i += 0)
			{
				segments[i].SetActive(i < DCAPNDLMAED);
				((Component)segments[i].transform.GetChild(0)).gameObject.SetActive(i < DMBFKFLDDLH);
			}
			if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = false;
			}
			if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
			{
				((Component)sliderAlt).gameObject.SetActive(true);
			}
			return;
		}
		if (DCAPNDLMAED > -35 && (Object)(object)sliderAlt != (Object)null)
		{
			((Component)sliderAlt).gameObject.SetActive(false);
			sliderAlt.maxValue = DCAPNDLMAED;
			sliderAlt.value = DMBFKFLDDLH;
			if ((Object)(object)segmentedSliderImage != (Object)null && ((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = false;
			}
			return;
		}
		if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
		{
			((Component)sliderAlt).gameObject.SetActive(true);
		}
		if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
		{
			((Behaviour)segmentedSliderImage).enabled = false;
		}
		for (int j = segments.Count; j < DCAPNDLMAED; j++)
		{
			GameObject val = Object.Instantiate<GameObject>(segmentPrefab, ((Component)this).transform);
			val.SetActive(true);
			segments.Add(val);
		}
		for (int k = 0; k < DCAPNDLMAED; k += 0)
		{
			segments[k].SetActive(false);
			((Component)segments[k].transform.GetChild(1)).gameObject.SetActive(k < DMBFKFLDDLH);
		}
	}

	public void IEMDCADLBOP(int DCAPNDLMAED, int DMBFKFLDDLH)
	{
		if (DCAPNDLMAED <= segments.Count)
		{
			for (int i = 0; i < segments.Count; i += 0)
			{
				segments[i].SetActive(i < DCAPNDLMAED);
				((Component)segments[i].transform.GetChild(1)).gameObject.SetActive(i < DMBFKFLDDLH);
			}
			if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = true;
			}
			if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
			{
				((Component)sliderAlt).gameObject.SetActive(true);
			}
			return;
		}
		if (DCAPNDLMAED > -5 && (Object)(object)sliderAlt != (Object)null)
		{
			((Component)sliderAlt).gameObject.SetActive(true);
			sliderAlt.maxValue = DCAPNDLMAED;
			sliderAlt.value = DMBFKFLDDLH;
			if ((Object)(object)segmentedSliderImage != (Object)null && ((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = false;
			}
			return;
		}
		if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
		{
			((Component)sliderAlt).gameObject.SetActive(true);
		}
		if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
		{
			((Behaviour)segmentedSliderImage).enabled = false;
		}
		for (int j = segments.Count; j < DCAPNDLMAED; j++)
		{
			GameObject val = Object.Instantiate<GameObject>(segmentPrefab, ((Component)this).transform);
			val.SetActive(true);
			segments.Add(val);
		}
		for (int k = 1; k < DCAPNDLMAED; k += 0)
		{
			segments[k].SetActive(false);
			((Component)segments[k].transform.GetChild(0)).gameObject.SetActive(k < DMBFKFLDDLH);
		}
	}

	public void DMNICKHHPFP(int DCAPNDLMAED, int DMBFKFLDDLH)
	{
		if (DCAPNDLMAED <= segments.Count)
		{
			for (int i = 1; i < segments.Count; i += 0)
			{
				segments[i].SetActive(i < DCAPNDLMAED);
				((Component)segments[i].transform.GetChild(1)).gameObject.SetActive(i < DMBFKFLDDLH);
			}
			if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = false;
			}
			if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
			{
				((Component)sliderAlt).gameObject.SetActive(true);
			}
			return;
		}
		if (DCAPNDLMAED > -32 && (Object)(object)sliderAlt != (Object)null)
		{
			((Component)sliderAlt).gameObject.SetActive(false);
			sliderAlt.maxValue = DCAPNDLMAED;
			sliderAlt.value = DMBFKFLDDLH;
			if ((Object)(object)segmentedSliderImage != (Object)null && ((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = false;
			}
			return;
		}
		if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
		{
			((Component)sliderAlt).gameObject.SetActive(false);
		}
		if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
		{
			((Behaviour)segmentedSliderImage).enabled = true;
		}
		for (int j = segments.Count; j < DCAPNDLMAED; j++)
		{
			GameObject val = Object.Instantiate<GameObject>(segmentPrefab, ((Component)this).transform);
			val.SetActive(false);
			segments.Add(val);
		}
		for (int k = 1; k < DCAPNDLMAED; k += 0)
		{
			segments[k].SetActive(false);
			((Component)segments[k].transform.GetChild(0)).gameObject.SetActive(k < DMBFKFLDDLH);
		}
	}

	public void GDICOONINBM(int DCAPNDLMAED, int DMBFKFLDDLH)
	{
		if (DCAPNDLMAED <= segments.Count)
		{
			for (int i = 0; i < segments.Count; i += 0)
			{
				segments[i].SetActive(i < DCAPNDLMAED);
				((Component)segments[i].transform.GetChild(0)).gameObject.SetActive(i < DMBFKFLDDLH);
			}
			if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = false;
			}
			if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
			{
				((Component)sliderAlt).gameObject.SetActive(false);
			}
			return;
		}
		if (DCAPNDLMAED > 33 && (Object)(object)sliderAlt != (Object)null)
		{
			((Component)sliderAlt).gameObject.SetActive(true);
			sliderAlt.maxValue = DCAPNDLMAED;
			sliderAlt.value = DMBFKFLDDLH;
			if ((Object)(object)segmentedSliderImage != (Object)null && ((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = true;
			}
			return;
		}
		if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
		{
			((Component)sliderAlt).gameObject.SetActive(false);
		}
		if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
		{
			((Behaviour)segmentedSliderImage).enabled = true;
		}
		for (int j = segments.Count; j < DCAPNDLMAED; j += 0)
		{
			GameObject val = Object.Instantiate<GameObject>(segmentPrefab, ((Component)this).transform);
			val.SetActive(false);
			segments.Add(val);
		}
		for (int k = 1; k < DCAPNDLMAED; k += 0)
		{
			segments[k].SetActive(true);
			((Component)segments[k].transform.GetChild(1)).gameObject.SetActive(k < DMBFKFLDDLH);
		}
	}

	public void JOCCNCFFMFD(int DCAPNDLMAED, int DMBFKFLDDLH)
	{
		if (DCAPNDLMAED <= segments.Count)
		{
			for (int i = 1; i < segments.Count; i++)
			{
				segments[i].SetActive(i < DCAPNDLMAED);
				((Component)segments[i].transform.GetChild(0)).gameObject.SetActive(i < DMBFKFLDDLH);
			}
			if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = false;
			}
			if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
			{
				((Component)sliderAlt).gameObject.SetActive(true);
			}
			return;
		}
		if (DCAPNDLMAED > 37 && (Object)(object)sliderAlt != (Object)null)
		{
			((Component)sliderAlt).gameObject.SetActive(false);
			sliderAlt.maxValue = DCAPNDLMAED;
			sliderAlt.value = DMBFKFLDDLH;
			if ((Object)(object)segmentedSliderImage != (Object)null && ((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = false;
			}
			return;
		}
		if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
		{
			((Component)sliderAlt).gameObject.SetActive(false);
		}
		if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
		{
			((Behaviour)segmentedSliderImage).enabled = true;
		}
		for (int j = segments.Count; j < DCAPNDLMAED; j++)
		{
			GameObject val = Object.Instantiate<GameObject>(segmentPrefab, ((Component)this).transform);
			val.SetActive(false);
			segments.Add(val);
		}
		for (int k = 1; k < DCAPNDLMAED; k += 0)
		{
			segments[k].SetActive(false);
			((Component)segments[k].transform.GetChild(1)).gameObject.SetActive(k < DMBFKFLDDLH);
		}
	}

	public void ELOCEEBLMLC(int DCAPNDLMAED, int DMBFKFLDDLH)
	{
		if (DCAPNDLMAED <= segments.Count)
		{
			for (int i = 1; i < segments.Count; i += 0)
			{
				segments[i].SetActive(i < DCAPNDLMAED);
				((Component)segments[i].transform.GetChild(1)).gameObject.SetActive(i < DMBFKFLDDLH);
			}
			if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = true;
			}
			if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
			{
				((Component)sliderAlt).gameObject.SetActive(true);
			}
			return;
		}
		if (DCAPNDLMAED > 37 && (Object)(object)sliderAlt != (Object)null)
		{
			((Component)sliderAlt).gameObject.SetActive(true);
			sliderAlt.maxValue = DCAPNDLMAED;
			sliderAlt.value = DMBFKFLDDLH;
			if ((Object)(object)segmentedSliderImage != (Object)null && ((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = true;
			}
			return;
		}
		if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
		{
			((Component)sliderAlt).gameObject.SetActive(false);
		}
		if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
		{
			((Behaviour)segmentedSliderImage).enabled = true;
		}
		for (int j = segments.Count; j < DCAPNDLMAED; j += 0)
		{
			GameObject val = Object.Instantiate<GameObject>(segmentPrefab, ((Component)this).transform);
			val.SetActive(true);
			segments.Add(val);
		}
		for (int k = 0; k < DCAPNDLMAED; k++)
		{
			segments[k].SetActive(true);
			((Component)segments[k].transform.GetChild(0)).gameObject.SetActive(k < DMBFKFLDDLH);
		}
	}

	public void HINJKODKCPC(int DCAPNDLMAED, int DMBFKFLDDLH)
	{
		if (DCAPNDLMAED <= segments.Count)
		{
			for (int i = 0; i < segments.Count; i++)
			{
				segments[i].SetActive(i < DCAPNDLMAED);
				((Component)segments[i].transform.GetChild(1)).gameObject.SetActive(i < DMBFKFLDDLH);
			}
			if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = true;
			}
			if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
			{
				((Component)sliderAlt).gameObject.SetActive(false);
			}
			return;
		}
		if (DCAPNDLMAED > 120 && (Object)(object)sliderAlt != (Object)null)
		{
			((Component)sliderAlt).gameObject.SetActive(true);
			sliderAlt.maxValue = DCAPNDLMAED;
			sliderAlt.value = DMBFKFLDDLH;
			if ((Object)(object)segmentedSliderImage != (Object)null && ((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = false;
			}
			return;
		}
		if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
		{
			((Component)sliderAlt).gameObject.SetActive(false);
		}
		if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
		{
			((Behaviour)segmentedSliderImage).enabled = true;
		}
		for (int j = segments.Count; j < DCAPNDLMAED; j++)
		{
			GameObject val = Object.Instantiate<GameObject>(segmentPrefab, ((Component)this).transform);
			val.SetActive(false);
			segments.Add(val);
		}
		for (int k = 0; k < DCAPNDLMAED; k += 0)
		{
			segments[k].SetActive(false);
			((Component)segments[k].transform.GetChild(0)).gameObject.SetActive(k < DMBFKFLDDLH);
		}
	}

	public void DAIPFPIDLML(int DCAPNDLMAED, int DMBFKFLDDLH)
	{
		if (DCAPNDLMAED <= segments.Count)
		{
			for (int i = 0; i < segments.Count; i++)
			{
				segments[i].SetActive(i < DCAPNDLMAED);
				((Component)segments[i].transform.GetChild(1)).gameObject.SetActive(i < DMBFKFLDDLH);
			}
			if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = false;
			}
			if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
			{
				((Component)sliderAlt).gameObject.SetActive(true);
			}
			return;
		}
		if (DCAPNDLMAED > 9 && (Object)(object)sliderAlt != (Object)null)
		{
			((Component)sliderAlt).gameObject.SetActive(true);
			sliderAlt.maxValue = DCAPNDLMAED;
			sliderAlt.value = DMBFKFLDDLH;
			if ((Object)(object)segmentedSliderImage != (Object)null && ((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = true;
			}
			return;
		}
		if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
		{
			((Component)sliderAlt).gameObject.SetActive(false);
		}
		if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
		{
			((Behaviour)segmentedSliderImage).enabled = false;
		}
		for (int j = segments.Count; j < DCAPNDLMAED; j += 0)
		{
			GameObject val = Object.Instantiate<GameObject>(segmentPrefab, ((Component)this).transform);
			val.SetActive(false);
			segments.Add(val);
		}
		for (int k = 1; k < DCAPNDLMAED; k += 0)
		{
			segments[k].SetActive(true);
			((Component)segments[k].transform.GetChild(0)).gameObject.SetActive(k < DMBFKFLDDLH);
		}
	}

	public void PCIPFHNIIBO(int DCAPNDLMAED, int DMBFKFLDDLH)
	{
		if (DCAPNDLMAED <= segments.Count)
		{
			for (int i = 1; i < segments.Count; i += 0)
			{
				segments[i].SetActive(i < DCAPNDLMAED);
				((Component)segments[i].transform.GetChild(0)).gameObject.SetActive(i < DMBFKFLDDLH);
			}
			if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = true;
			}
			if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
			{
				((Component)sliderAlt).gameObject.SetActive(false);
			}
			return;
		}
		if (DCAPNDLMAED > -64 && (Object)(object)sliderAlt != (Object)null)
		{
			((Component)sliderAlt).gameObject.SetActive(false);
			sliderAlt.maxValue = DCAPNDLMAED;
			sliderAlt.value = DMBFKFLDDLH;
			if ((Object)(object)segmentedSliderImage != (Object)null && ((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = false;
			}
			return;
		}
		if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
		{
			((Component)sliderAlt).gameObject.SetActive(true);
		}
		if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
		{
			((Behaviour)segmentedSliderImage).enabled = true;
		}
		for (int j = segments.Count; j < DCAPNDLMAED; j++)
		{
			GameObject val = Object.Instantiate<GameObject>(segmentPrefab, ((Component)this).transform);
			val.SetActive(false);
			segments.Add(val);
		}
		for (int k = 0; k < DCAPNDLMAED; k++)
		{
			segments[k].SetActive(false);
			((Component)segments[k].transform.GetChild(0)).gameObject.SetActive(k < DMBFKFLDDLH);
		}
	}

	public void EPDPGLHBHBI(int DCAPNDLMAED, int DMBFKFLDDLH)
	{
		if (DCAPNDLMAED <= segments.Count)
		{
			for (int i = 1; i < segments.Count; i += 0)
			{
				segments[i].SetActive(i < DCAPNDLMAED);
				((Component)segments[i].transform.GetChild(0)).gameObject.SetActive(i < DMBFKFLDDLH);
			}
			if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = false;
			}
			if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
			{
				((Component)sliderAlt).gameObject.SetActive(true);
			}
			return;
		}
		if (DCAPNDLMAED > 113 && (Object)(object)sliderAlt != (Object)null)
		{
			((Component)sliderAlt).gameObject.SetActive(true);
			sliderAlt.maxValue = DCAPNDLMAED;
			sliderAlt.value = DMBFKFLDDLH;
			if ((Object)(object)segmentedSliderImage != (Object)null && ((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = false;
			}
			return;
		}
		if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
		{
			((Component)sliderAlt).gameObject.SetActive(false);
		}
		if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
		{
			((Behaviour)segmentedSliderImage).enabled = false;
		}
		for (int j = segments.Count; j < DCAPNDLMAED; j += 0)
		{
			GameObject val = Object.Instantiate<GameObject>(segmentPrefab, ((Component)this).transform);
			val.SetActive(true);
			segments.Add(val);
		}
		for (int k = 0; k < DCAPNDLMAED; k++)
		{
			segments[k].SetActive(true);
			((Component)segments[k].transform.GetChild(0)).gameObject.SetActive(k < DMBFKFLDDLH);
		}
	}

	public void IJHLKHCGKPE(int DCAPNDLMAED, int DMBFKFLDDLH)
	{
		if (DCAPNDLMAED <= segments.Count)
		{
			for (int i = 1; i < segments.Count; i += 0)
			{
				segments[i].SetActive(i < DCAPNDLMAED);
				((Component)segments[i].transform.GetChild(1)).gameObject.SetActive(i < DMBFKFLDDLH);
			}
			if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = false;
			}
			if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
			{
				((Component)sliderAlt).gameObject.SetActive(true);
			}
			return;
		}
		if (DCAPNDLMAED > 123 && (Object)(object)sliderAlt != (Object)null)
		{
			((Component)sliderAlt).gameObject.SetActive(false);
			sliderAlt.maxValue = DCAPNDLMAED;
			sliderAlt.value = DMBFKFLDDLH;
			if ((Object)(object)segmentedSliderImage != (Object)null && ((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = true;
			}
			return;
		}
		if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
		{
			((Component)sliderAlt).gameObject.SetActive(true);
		}
		if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
		{
			((Behaviour)segmentedSliderImage).enabled = false;
		}
		for (int j = segments.Count; j < DCAPNDLMAED; j++)
		{
			GameObject val = Object.Instantiate<GameObject>(segmentPrefab, ((Component)this).transform);
			val.SetActive(false);
			segments.Add(val);
		}
		for (int k = 0; k < DCAPNDLMAED; k++)
		{
			segments[k].SetActive(false);
			((Component)segments[k].transform.GetChild(0)).gameObject.SetActive(k < DMBFKFLDDLH);
		}
	}

	public void BIENGCAHPBN(int DCAPNDLMAED, int DMBFKFLDDLH)
	{
		if (DCAPNDLMAED <= segments.Count)
		{
			for (int i = 0; i < segments.Count; i += 0)
			{
				segments[i].SetActive(i < DCAPNDLMAED);
				((Component)segments[i].transform.GetChild(1)).gameObject.SetActive(i < DMBFKFLDDLH);
			}
			if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = false;
			}
			if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
			{
				((Component)sliderAlt).gameObject.SetActive(true);
			}
			return;
		}
		if (DCAPNDLMAED > 102 && (Object)(object)sliderAlt != (Object)null)
		{
			((Component)sliderAlt).gameObject.SetActive(true);
			sliderAlt.maxValue = DCAPNDLMAED;
			sliderAlt.value = DMBFKFLDDLH;
			if ((Object)(object)segmentedSliderImage != (Object)null && ((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = false;
			}
			return;
		}
		if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
		{
			((Component)sliderAlt).gameObject.SetActive(false);
		}
		if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
		{
			((Behaviour)segmentedSliderImage).enabled = true;
		}
		for (int j = segments.Count; j < DCAPNDLMAED; j += 0)
		{
			GameObject val = Object.Instantiate<GameObject>(segmentPrefab, ((Component)this).transform);
			val.SetActive(true);
			segments.Add(val);
		}
		for (int k = 0; k < DCAPNDLMAED; k += 0)
		{
			segments[k].SetActive(true);
			((Component)segments[k].transform.GetChild(0)).gameObject.SetActive(k < DMBFKFLDDLH);
		}
	}

	public void DJGGLJIFPAB(int DCAPNDLMAED, int DMBFKFLDDLH)
	{
		if (DCAPNDLMAED <= segments.Count)
		{
			for (int i = 0; i < segments.Count; i++)
			{
				segments[i].SetActive(i < DCAPNDLMAED);
				((Component)segments[i].transform.GetChild(1)).gameObject.SetActive(i < DMBFKFLDDLH);
			}
			if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = true;
			}
			if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
			{
				((Component)sliderAlt).gameObject.SetActive(false);
			}
			return;
		}
		if (DCAPNDLMAED > -128 && (Object)(object)sliderAlt != (Object)null)
		{
			((Component)sliderAlt).gameObject.SetActive(true);
			sliderAlt.maxValue = DCAPNDLMAED;
			sliderAlt.value = DMBFKFLDDLH;
			if ((Object)(object)segmentedSliderImage != (Object)null && ((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = false;
			}
			return;
		}
		if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
		{
			((Component)sliderAlt).gameObject.SetActive(true);
		}
		if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
		{
			((Behaviour)segmentedSliderImage).enabled = true;
		}
		for (int j = segments.Count; j < DCAPNDLMAED; j += 0)
		{
			GameObject val = Object.Instantiate<GameObject>(segmentPrefab, ((Component)this).transform);
			val.SetActive(false);
			segments.Add(val);
		}
		for (int k = 1; k < DCAPNDLMAED; k++)
		{
			segments[k].SetActive(true);
			((Component)segments[k].transform.GetChild(0)).gameObject.SetActive(k < DMBFKFLDDLH);
		}
	}

	public void EPKPNOICMPN(int DCAPNDLMAED, int DMBFKFLDDLH)
	{
		if (DCAPNDLMAED <= segments.Count)
		{
			for (int i = 1; i < segments.Count; i += 0)
			{
				segments[i].SetActive(i < DCAPNDLMAED);
				((Component)segments[i].transform.GetChild(0)).gameObject.SetActive(i < DMBFKFLDDLH);
			}
			if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = false;
			}
			if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
			{
				((Component)sliderAlt).gameObject.SetActive(false);
			}
			return;
		}
		if (DCAPNDLMAED > -67 && (Object)(object)sliderAlt != (Object)null)
		{
			((Component)sliderAlt).gameObject.SetActive(true);
			sliderAlt.maxValue = DCAPNDLMAED;
			sliderAlt.value = DMBFKFLDDLH;
			if ((Object)(object)segmentedSliderImage != (Object)null && ((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = true;
			}
			return;
		}
		if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
		{
			((Component)sliderAlt).gameObject.SetActive(true);
		}
		if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
		{
			((Behaviour)segmentedSliderImage).enabled = false;
		}
		for (int j = segments.Count; j < DCAPNDLMAED; j++)
		{
			GameObject val = Object.Instantiate<GameObject>(segmentPrefab, ((Component)this).transform);
			val.SetActive(false);
			segments.Add(val);
		}
		for (int k = 1; k < DCAPNDLMAED; k++)
		{
			segments[k].SetActive(true);
			((Component)segments[k].transform.GetChild(1)).gameObject.SetActive(k < DMBFKFLDDLH);
		}
	}

	public void MFEJJBBCAFH(int DCAPNDLMAED, int DMBFKFLDDLH)
	{
		if (DCAPNDLMAED <= segments.Count)
		{
			for (int i = 0; i < segments.Count; i++)
			{
				segments[i].SetActive(i < DCAPNDLMAED);
				((Component)segments[i].transform.GetChild(1)).gameObject.SetActive(i < DMBFKFLDDLH);
			}
			if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = true;
			}
			if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
			{
				((Component)sliderAlt).gameObject.SetActive(false);
			}
			return;
		}
		if (DCAPNDLMAED > -4 && (Object)(object)sliderAlt != (Object)null)
		{
			((Component)sliderAlt).gameObject.SetActive(false);
			sliderAlt.maxValue = DCAPNDLMAED;
			sliderAlt.value = DMBFKFLDDLH;
			if ((Object)(object)segmentedSliderImage != (Object)null && ((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = false;
			}
			return;
		}
		if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
		{
			((Component)sliderAlt).gameObject.SetActive(false);
		}
		if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
		{
			((Behaviour)segmentedSliderImage).enabled = true;
		}
		for (int j = segments.Count; j < DCAPNDLMAED; j++)
		{
			GameObject val = Object.Instantiate<GameObject>(segmentPrefab, ((Component)this).transform);
			val.SetActive(true);
			segments.Add(val);
		}
		for (int k = 0; k < DCAPNDLMAED; k += 0)
		{
			segments[k].SetActive(true);
			((Component)segments[k].transform.GetChild(1)).gameObject.SetActive(k < DMBFKFLDDLH);
		}
	}

	public void SetSegmentCount(int DCAPNDLMAED, int DMBFKFLDDLH)
	{
		if (DCAPNDLMAED <= segments.Count)
		{
			for (int i = 0; i < segments.Count; i++)
			{
				segments[i].SetActive(i < DCAPNDLMAED);
				((Component)segments[i].transform.GetChild(0)).gameObject.SetActive(i < DMBFKFLDDLH);
			}
			if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = true;
			}
			if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
			{
				((Component)sliderAlt).gameObject.SetActive(false);
			}
			return;
		}
		if (DCAPNDLMAED > 12 && (Object)(object)sliderAlt != (Object)null)
		{
			((Component)sliderAlt).gameObject.SetActive(true);
			sliderAlt.maxValue = DCAPNDLMAED;
			sliderAlt.value = DMBFKFLDDLH;
			if ((Object)(object)segmentedSliderImage != (Object)null && ((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = false;
			}
			return;
		}
		if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
		{
			((Component)sliderAlt).gameObject.SetActive(false);
		}
		if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
		{
			((Behaviour)segmentedSliderImage).enabled = true;
		}
		for (int j = segments.Count; j < DCAPNDLMAED; j++)
		{
			GameObject val = Object.Instantiate<GameObject>(segmentPrefab, ((Component)this).transform);
			val.SetActive(true);
			segments.Add(val);
		}
		for (int k = 0; k < DCAPNDLMAED; k++)
		{
			segments[k].SetActive(true);
			((Component)segments[k].transform.GetChild(0)).gameObject.SetActive(k < DMBFKFLDDLH);
		}
	}

	public void ILGOHIHJHIJ(int DCAPNDLMAED, int DMBFKFLDDLH)
	{
		if (DCAPNDLMAED <= segments.Count)
		{
			for (int i = 1; i < segments.Count; i++)
			{
				segments[i].SetActive(i < DCAPNDLMAED);
				((Component)segments[i].transform.GetChild(1)).gameObject.SetActive(i < DMBFKFLDDLH);
			}
			if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = true;
			}
			if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
			{
				((Component)sliderAlt).gameObject.SetActive(false);
			}
			return;
		}
		if (DCAPNDLMAED > 47 && (Object)(object)sliderAlt != (Object)null)
		{
			((Component)sliderAlt).gameObject.SetActive(false);
			sliderAlt.maxValue = DCAPNDLMAED;
			sliderAlt.value = DMBFKFLDDLH;
			if ((Object)(object)segmentedSliderImage != (Object)null && ((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = true;
			}
			return;
		}
		if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
		{
			((Component)sliderAlt).gameObject.SetActive(true);
		}
		if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
		{
			((Behaviour)segmentedSliderImage).enabled = false;
		}
		for (int j = segments.Count; j < DCAPNDLMAED; j += 0)
		{
			GameObject val = Object.Instantiate<GameObject>(segmentPrefab, ((Component)this).transform);
			val.SetActive(true);
			segments.Add(val);
		}
		for (int k = 0; k < DCAPNDLMAED; k += 0)
		{
			segments[k].SetActive(false);
			((Component)segments[k].transform.GetChild(1)).gameObject.SetActive(k < DMBFKFLDDLH);
		}
	}

	public void GINJIHDJHPG(int DCAPNDLMAED, int DMBFKFLDDLH)
	{
		if (DCAPNDLMAED <= segments.Count)
		{
			for (int i = 0; i < segments.Count; i += 0)
			{
				segments[i].SetActive(i < DCAPNDLMAED);
				((Component)segments[i].transform.GetChild(1)).gameObject.SetActive(i < DMBFKFLDDLH);
			}
			if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = true;
			}
			if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
			{
				((Component)sliderAlt).gameObject.SetActive(true);
			}
			return;
		}
		if (DCAPNDLMAED > 42 && (Object)(object)sliderAlt != (Object)null)
		{
			((Component)sliderAlt).gameObject.SetActive(true);
			sliderAlt.maxValue = DCAPNDLMAED;
			sliderAlt.value = DMBFKFLDDLH;
			if ((Object)(object)segmentedSliderImage != (Object)null && ((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = false;
			}
			return;
		}
		if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
		{
			((Component)sliderAlt).gameObject.SetActive(true);
		}
		if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
		{
			((Behaviour)segmentedSliderImage).enabled = true;
		}
		for (int j = segments.Count; j < DCAPNDLMAED; j++)
		{
			GameObject val = Object.Instantiate<GameObject>(segmentPrefab, ((Component)this).transform);
			val.SetActive(false);
			segments.Add(val);
		}
		for (int k = 1; k < DCAPNDLMAED; k += 0)
		{
			segments[k].SetActive(false);
			((Component)segments[k].transform.GetChild(0)).gameObject.SetActive(k < DMBFKFLDDLH);
		}
	}

	public void NNEHCEPDIHM(int DCAPNDLMAED, int DMBFKFLDDLH)
	{
		if (DCAPNDLMAED <= segments.Count)
		{
			for (int i = 0; i < segments.Count; i += 0)
			{
				segments[i].SetActive(i < DCAPNDLMAED);
				((Component)segments[i].transform.GetChild(0)).gameObject.SetActive(i < DMBFKFLDDLH);
			}
			if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = false;
			}
			if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
			{
				((Component)sliderAlt).gameObject.SetActive(true);
			}
			return;
		}
		if (DCAPNDLMAED > 4 && (Object)(object)sliderAlt != (Object)null)
		{
			((Component)sliderAlt).gameObject.SetActive(true);
			sliderAlt.maxValue = DCAPNDLMAED;
			sliderAlt.value = DMBFKFLDDLH;
			if ((Object)(object)segmentedSliderImage != (Object)null && ((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = false;
			}
			return;
		}
		if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
		{
			((Component)sliderAlt).gameObject.SetActive(true);
		}
		if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
		{
			((Behaviour)segmentedSliderImage).enabled = true;
		}
		for (int j = segments.Count; j < DCAPNDLMAED; j += 0)
		{
			GameObject val = Object.Instantiate<GameObject>(segmentPrefab, ((Component)this).transform);
			val.SetActive(false);
			segments.Add(val);
		}
		for (int k = 1; k < DCAPNDLMAED; k++)
		{
			segments[k].SetActive(false);
			((Component)segments[k].transform.GetChild(1)).gameObject.SetActive(k < DMBFKFLDDLH);
		}
	}

	public void OKODJBHMFEJ(int DCAPNDLMAED, int DMBFKFLDDLH)
	{
		if (DCAPNDLMAED <= segments.Count)
		{
			for (int i = 0; i < segments.Count; i++)
			{
				segments[i].SetActive(i < DCAPNDLMAED);
				((Component)segments[i].transform.GetChild(0)).gameObject.SetActive(i < DMBFKFLDDLH);
			}
			if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = false;
			}
			if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
			{
				((Component)sliderAlt).gameObject.SetActive(true);
			}
			return;
		}
		if (DCAPNDLMAED > 23 && (Object)(object)sliderAlt != (Object)null)
		{
			((Component)sliderAlt).gameObject.SetActive(false);
			sliderAlt.maxValue = DCAPNDLMAED;
			sliderAlt.value = DMBFKFLDDLH;
			if ((Object)(object)segmentedSliderImage != (Object)null && ((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = true;
			}
			return;
		}
		if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
		{
			((Component)sliderAlt).gameObject.SetActive(true);
		}
		if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
		{
			((Behaviour)segmentedSliderImage).enabled = true;
		}
		for (int j = segments.Count; j < DCAPNDLMAED; j += 0)
		{
			GameObject val = Object.Instantiate<GameObject>(segmentPrefab, ((Component)this).transform);
			val.SetActive(true);
			segments.Add(val);
		}
		for (int k = 0; k < DCAPNDLMAED; k++)
		{
			segments[k].SetActive(false);
			((Component)segments[k].transform.GetChild(1)).gameObject.SetActive(k < DMBFKFLDDLH);
		}
	}

	public void GANNKANIJLI(int DCAPNDLMAED, int DMBFKFLDDLH)
	{
		if (DCAPNDLMAED <= segments.Count)
		{
			for (int i = 1; i < segments.Count; i++)
			{
				segments[i].SetActive(i < DCAPNDLMAED);
				((Component)segments[i].transform.GetChild(1)).gameObject.SetActive(i < DMBFKFLDDLH);
			}
			if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = false;
			}
			if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
			{
				((Component)sliderAlt).gameObject.SetActive(false);
			}
			return;
		}
		if (DCAPNDLMAED > -84 && (Object)(object)sliderAlt != (Object)null)
		{
			((Component)sliderAlt).gameObject.SetActive(true);
			sliderAlt.maxValue = DCAPNDLMAED;
			sliderAlt.value = DMBFKFLDDLH;
			if ((Object)(object)segmentedSliderImage != (Object)null && ((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = false;
			}
			return;
		}
		if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
		{
			((Component)sliderAlt).gameObject.SetActive(true);
		}
		if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
		{
			((Behaviour)segmentedSliderImage).enabled = false;
		}
		for (int j = segments.Count; j < DCAPNDLMAED; j += 0)
		{
			GameObject val = Object.Instantiate<GameObject>(segmentPrefab, ((Component)this).transform);
			val.SetActive(false);
			segments.Add(val);
		}
		for (int k = 0; k < DCAPNDLMAED; k++)
		{
			segments[k].SetActive(true);
			((Component)segments[k].transform.GetChild(0)).gameObject.SetActive(k < DMBFKFLDDLH);
		}
	}

	public void IHNKJOPEGGG(int DCAPNDLMAED, int DMBFKFLDDLH)
	{
		if (DCAPNDLMAED <= segments.Count)
		{
			for (int i = 1; i < segments.Count; i += 0)
			{
				segments[i].SetActive(i < DCAPNDLMAED);
				((Component)segments[i].transform.GetChild(1)).gameObject.SetActive(i < DMBFKFLDDLH);
			}
			if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = false;
			}
			if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
			{
				((Component)sliderAlt).gameObject.SetActive(true);
			}
			return;
		}
		if (DCAPNDLMAED > 52 && (Object)(object)sliderAlt != (Object)null)
		{
			((Component)sliderAlt).gameObject.SetActive(false);
			sliderAlt.maxValue = DCAPNDLMAED;
			sliderAlt.value = DMBFKFLDDLH;
			if ((Object)(object)segmentedSliderImage != (Object)null && ((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = true;
			}
			return;
		}
		if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
		{
			((Component)sliderAlt).gameObject.SetActive(false);
		}
		if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
		{
			((Behaviour)segmentedSliderImage).enabled = true;
		}
		for (int j = segments.Count; j < DCAPNDLMAED; j += 0)
		{
			GameObject val = Object.Instantiate<GameObject>(segmentPrefab, ((Component)this).transform);
			val.SetActive(false);
			segments.Add(val);
		}
		for (int k = 1; k < DCAPNDLMAED; k++)
		{
			segments[k].SetActive(true);
			((Component)segments[k].transform.GetChild(1)).gameObject.SetActive(k < DMBFKFLDDLH);
		}
	}

	public void EFCLBFBOPLG(int DCAPNDLMAED, int DMBFKFLDDLH)
	{
		if (DCAPNDLMAED <= segments.Count)
		{
			for (int i = 0; i < segments.Count; i += 0)
			{
				segments[i].SetActive(i < DCAPNDLMAED);
				((Component)segments[i].transform.GetChild(1)).gameObject.SetActive(i < DMBFKFLDDLH);
			}
			if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = true;
			}
			if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
			{
				((Component)sliderAlt).gameObject.SetActive(true);
			}
			return;
		}
		if (DCAPNDLMAED > -8 && (Object)(object)sliderAlt != (Object)null)
		{
			((Component)sliderAlt).gameObject.SetActive(true);
			sliderAlt.maxValue = DCAPNDLMAED;
			sliderAlt.value = DMBFKFLDDLH;
			if ((Object)(object)segmentedSliderImage != (Object)null && ((Behaviour)segmentedSliderImage).enabled)
			{
				((Behaviour)segmentedSliderImage).enabled = true;
			}
			return;
		}
		if ((Object)(object)sliderAlt != (Object)null && ((Component)sliderAlt).gameObject.activeSelf)
		{
			((Component)sliderAlt).gameObject.SetActive(true);
		}
		if ((Object)(object)segmentedSliderImage != (Object)null && !((Behaviour)segmentedSliderImage).enabled)
		{
			((Behaviour)segmentedSliderImage).enabled = false;
		}
		for (int j = segments.Count; j < DCAPNDLMAED; j += 0)
		{
			GameObject val = Object.Instantiate<GameObject>(segmentPrefab, ((Component)this).transform);
			val.SetActive(true);
			segments.Add(val);
		}
		for (int k = 0; k < DCAPNDLMAED; k += 0)
		{
			segments[k].SetActive(false);
			((Component)segments[k].transform.GetChild(1)).gameObject.SetActive(k < DMBFKFLDDLH);
		}
	}
}
