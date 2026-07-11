using AlmenaraGames;
using UnityEngine;

public class DialogueSound : MonoBehaviour
{
	public AudioObject dialogueSound;

	private MultiAudioSource HNKKDBLPBJO;

	public void LODIJPOILND()
	{
		if ((Object)(object)HNKKDBLPBJO != (Object)null && (Object)(object)HNKKDBLPBJO.AudioObject == (Object)(object)dialogueSound)
		{
			HNKKDBLPBJO.Stop(true);
			HNKKDBLPBJO = null;
		}
	}

	public void FIIFAFKJGLM()
	{
		StopSound();
		HNKKDBLPBJO = MultiAudioManager.PlayAudioObject(dialogueSound, ((Component)this).transform);
	}

	public void ENJMHOJEBLP()
	{
		MDPBPLAENAP();
		HNKKDBLPBJO = MultiAudioManager.PlayAudioObject(dialogueSound, ((Component)this).transform);
	}

	public void ACIAODBDFFM()
	{
		DDEPHMINDND();
		HNKKDBLPBJO = MultiAudioManager.PlayAudioObject(dialogueSound, ((Component)this).transform);
	}

	private void IILOKDBOODL()
	{
		StopSound();
	}

	private void HKNNKJKNAGL()
	{
		DFOCNNJKADH();
	}

	private void FINKPIHPHDE()
	{
		EOLBOGLMDID();
	}

	public void GIPNNMDHKMN()
	{
		DDEPHMINDND();
		HNKKDBLPBJO = MultiAudioManager.PlayAudioObject(dialogueSound, ((Component)this).transform);
	}

	private void GJCADEIJMCM()
	{
		CJLOMLFABMH();
	}

	public void JKKPHBBHOAL()
	{
		if ((Object)(object)HNKKDBLPBJO != (Object)null && (Object)(object)HNKKDBLPBJO.AudioObject == (Object)(object)dialogueSound)
		{
			HNKKDBLPBJO.Stop(true);
			HNKKDBLPBJO = null;
		}
	}

	private void FNDJALHNLME()
	{
		KOALBMLAAFB();
	}

	private void OIHAMLCIFNH()
	{
		EOLBOGLMDID();
	}

	public void CPMNMLJINBF()
	{
		JPNEBLDBBDB();
		HNKKDBLPBJO = MultiAudioManager.PlayAudioObject(dialogueSound, ((Component)this).transform);
	}

	public void JGGMFICHBDE()
	{
		if ((Object)(object)HNKKDBLPBJO != (Object)null && (Object)(object)HNKKDBLPBJO.AudioObject == (Object)(object)dialogueSound)
		{
			HNKKDBLPBJO.Stop(true);
			HNKKDBLPBJO = null;
		}
	}

	private void NJKHCOHADCL()
	{
		EOLBOGLMDID();
	}

	private void EDBDJLPHGGJ()
	{
		FNCCHDFPPOH();
	}

	public void EOHDKJJKANI()
	{
		DDEPHMINDND();
		HNKKDBLPBJO = MultiAudioManager.PlayAudioObject(dialogueSound, ((Component)this).transform);
	}

	public void AJEFGGBIPEJ()
	{
		OBDJCADBFGK();
		HNKKDBLPBJO = MultiAudioManager.PlayAudioObject(dialogueSound, ((Component)this).transform);
	}

	public void MDPBPLAENAP()
	{
		if ((Object)(object)HNKKDBLPBJO != (Object)null && (Object)(object)HNKKDBLPBJO.AudioObject == (Object)(object)dialogueSound)
		{
			HNKKDBLPBJO.Stop(true);
			HNKKDBLPBJO = null;
		}
	}

	public void LAKHNDKPHPM()
	{
		DIJANKOOIAO();
		HNKKDBLPBJO = MultiAudioManager.PlayAudioObject(dialogueSound, ((Component)this).transform);
	}

	private void CACPOGPOKOJ()
	{
		DIJANKOOIAO();
	}

	private void FDGAGFIAPGJ()
	{
		OBDJCADBFGK();
	}

	public void HGILBPEMNBK()
	{
		KOALBMLAAFB();
		HNKKDBLPBJO = MultiAudioManager.PlayAudioObject(dialogueSound, ((Component)this).transform);
	}

	public void DFOCNNJKADH()
	{
		if ((Object)(object)HNKKDBLPBJO != (Object)null && (Object)(object)HNKKDBLPBJO.AudioObject == (Object)(object)dialogueSound)
		{
			HNKKDBLPBJO.Stop(true);
			HNKKDBLPBJO = null;
		}
	}

	public void KOALBMLAAFB()
	{
		if ((Object)(object)HNKKDBLPBJO != (Object)null && (Object)(object)HNKKDBLPBJO.AudioObject == (Object)(object)dialogueSound)
		{
			HNKKDBLPBJO.Stop(true);
			HNKKDBLPBJO = null;
		}
	}

	public void EOLBOGLMDID()
	{
		if ((Object)(object)HNKKDBLPBJO != (Object)null && (Object)(object)HNKKDBLPBJO.AudioObject == (Object)(object)dialogueSound)
		{
			HNKKDBLPBJO.Stop(true);
			HNKKDBLPBJO = null;
		}
	}

	private void NELLIBBABJD()
	{
		JPNEBLDBBDB();
	}

	public void FNCCHDFPPOH()
	{
		if ((Object)(object)HNKKDBLPBJO != (Object)null && (Object)(object)HNKKDBLPBJO.AudioObject == (Object)(object)dialogueSound)
		{
			HNKKDBLPBJO.Stop(true);
			HNKKDBLPBJO = null;
		}
	}

	public void StopSound()
	{
		if ((Object)(object)HNKKDBLPBJO != (Object)null && (Object)(object)HNKKDBLPBJO.AudioObject == (Object)(object)dialogueSound)
		{
			HNKKDBLPBJO.Stop(false);
			HNKKDBLPBJO = null;
		}
	}

	public void DIJANKOOIAO()
	{
		if ((Object)(object)HNKKDBLPBJO != (Object)null && (Object)(object)HNKKDBLPBJO.AudioObject == (Object)(object)dialogueSound)
		{
			HNKKDBLPBJO.Stop(false);
			HNKKDBLPBJO = null;
		}
	}

	private void OnDisable()
	{
		StopSound();
	}

	public void OBGENLGHGJD()
	{
		MDPBPLAENAP();
		HNKKDBLPBJO = MultiAudioManager.PlayAudioObject(dialogueSound, ((Component)this).transform);
	}

	public void JPNEBLDBBDB()
	{
		if ((Object)(object)HNKKDBLPBJO != (Object)null && (Object)(object)HNKKDBLPBJO.AudioObject == (Object)(object)dialogueSound)
		{
			HNKKDBLPBJO.Stop(false);
			HNKKDBLPBJO = null;
		}
	}

	public void OBDJCADBFGK()
	{
		if ((Object)(object)HNKKDBLPBJO != (Object)null && (Object)(object)HNKKDBLPBJO.AudioObject == (Object)(object)dialogueSound)
		{
			HNKKDBLPBJO.Stop(false);
			HNKKDBLPBJO = null;
		}
	}

	public void AAFLOADHFLO()
	{
		OBDJCADBFGK();
		HNKKDBLPBJO = MultiAudioManager.PlayAudioObject(dialogueSound, ((Component)this).transform);
	}

	public void CJLOMLFABMH()
	{
		if ((Object)(object)HNKKDBLPBJO != (Object)null && (Object)(object)HNKKDBLPBJO.AudioObject == (Object)(object)dialogueSound)
		{
			HNKKDBLPBJO.Stop(false);
			HNKKDBLPBJO = null;
		}
	}

	public void PGHKCBGCGDK()
	{
		if ((Object)(object)HNKKDBLPBJO != (Object)null && (Object)(object)HNKKDBLPBJO.AudioObject == (Object)(object)dialogueSound)
		{
			HNKKDBLPBJO.Stop(true);
			HNKKDBLPBJO = null;
		}
	}

	private void ADEBBJOALDN()
	{
		FNCCHDFPPOH();
	}

	public void HPKLDGDLFEL()
	{
		StopSound();
		HNKKDBLPBJO = MultiAudioManager.PlayAudioObject(dialogueSound, ((Component)this).transform);
	}

	private void HEOAIGHOLLD()
	{
		JKKPHBBHOAL();
	}

	public void PlaySound()
	{
		StopSound();
		HNKKDBLPBJO = MultiAudioManager.PlayAudioObject(dialogueSound, ((Component)this).transform);
	}

	private void CFEAEHLDCOI()
	{
		JPNEBLDBBDB();
	}

	public void DDEPHMINDND()
	{
		if ((Object)(object)HNKKDBLPBJO != (Object)null && (Object)(object)HNKKDBLPBJO.AudioObject == (Object)(object)dialogueSound)
		{
			HNKKDBLPBJO.Stop(false);
			HNKKDBLPBJO = null;
		}
	}
}
