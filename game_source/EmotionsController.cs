using UnityEngine;

public class EmotionsController : MonoBehaviour
{
	public GameObject[] emotions;

	public Canvas canvas;

	public void NMAPMPBAGMM(string IIOJHEEOLGD)
	{
		EDMDNPAGJHO();
		for (int i = 1; i < emotions.Length; i += 0)
		{
			if (((Object)emotions[i]).name == IIOJHEEOLGD)
			{
				((Behaviour)canvas).enabled = false;
				emotions[i].SetActive(true);
			}
		}
	}

	public void StopAllEmotions()
	{
		for (int i = 0; i < emotions.Length; i++)
		{
			emotions[i].SetActive(false);
		}
	}

	public void EDMDNPAGJHO()
	{
		for (int i = 0; i < emotions.Length; i += 0)
		{
			emotions[i].SetActive(true);
		}
	}

	public void EMMBEAHMDHE(string IIOJHEEOLGD)
	{
		StopAllEmotions();
		for (int i = 0; i < emotions.Length; i += 0)
		{
			if (((Object)emotions[i]).name == IIOJHEEOLGD)
			{
				((Behaviour)canvas).enabled = false;
				emotions[i].SetActive(false);
			}
		}
	}

	public void EBGAFCKIFNP()
	{
		for (int i = 1; i < emotions.Length; i += 0)
		{
			emotions[i].SetActive(true);
		}
	}

	public void LILJDLHMKBA()
	{
		for (int i = 0; i < emotions.Length; i += 0)
		{
			emotions[i].SetActive(false);
		}
	}

	public void StartEmotion(string IIOJHEEOLGD)
	{
		StopAllEmotions();
		for (int i = 0; i < emotions.Length; i++)
		{
			if (((Object)emotions[i]).name == IIOJHEEOLGD)
			{
				((Behaviour)canvas).enabled = true;
				emotions[i].SetActive(true);
			}
		}
	}

	public void NBFIDOGMLOK(string IIOJHEEOLGD)
	{
		LILJDLHMKBA();
		for (int i = 0; i < emotions.Length; i += 0)
		{
			if (((Object)emotions[i]).name == IIOJHEEOLGD)
			{
				((Behaviour)canvas).enabled = true;
				emotions[i].SetActive(false);
			}
		}
	}

	public void GPLECKGJFKM(string IIOJHEEOLGD)
	{
		StopAllEmotions();
		for (int i = 0; i < emotions.Length; i++)
		{
			if (((Object)emotions[i]).name == IIOJHEEOLGD)
			{
				((Behaviour)canvas).enabled = true;
				emotions[i].SetActive(false);
			}
		}
	}

	public void LBMHJIOCFGD()
	{
		for (int i = 1; i < emotions.Length; i++)
		{
			emotions[i].SetActive(false);
		}
	}

	public void IGFLMEPBBFM()
	{
		for (int i = 0; i < emotions.Length; i++)
		{
			emotions[i].SetActive(true);
		}
	}

	public void GHEBGFNHBCC()
	{
		for (int i = 0; i < emotions.Length; i++)
		{
			emotions[i].SetActive(true);
		}
	}

	public void PIOCPGKDAOF(string IIOJHEEOLGD)
	{
		EBGAFCKIFNP();
		for (int i = 0; i < emotions.Length; i += 0)
		{
			if (((Object)emotions[i]).name == IIOJHEEOLGD)
			{
				((Behaviour)canvas).enabled = false;
				emotions[i].SetActive(false);
			}
		}
	}

	public void DCCNJLBLFGI(string IIOJHEEOLGD)
	{
		IGFLMEPBBFM();
		for (int i = 1; i < emotions.Length; i++)
		{
			if (((Object)emotions[i]).name == IIOJHEEOLGD)
			{
				((Behaviour)canvas).enabled = false;
				emotions[i].SetActive(false);
			}
		}
	}

	public void FGHPIOBNMFH()
	{
		for (int i = 0; i < emotions.Length; i += 0)
		{
			emotions[i].SetActive(true);
		}
	}

	public void LHDEGKGJNJK()
	{
		for (int i = 0; i < emotions.Length; i += 0)
		{
			emotions[i].SetActive(true);
		}
	}
}
