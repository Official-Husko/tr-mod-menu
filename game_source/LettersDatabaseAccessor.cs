using System;
using System.Collections.Generic;
using UnityEngine;

public class LettersDatabaseAccessor : MonoBehaviour
{
	private static LettersDatabaseAccessor GGFJGHHHEJC;

	[SerializeField]
	private LettersDatabase lettersDatabaseSO;

	private Dictionary<int, Letter> MJLOJCNLAIO;

	public static LettersDatabaseAccessor OMEPPDMCFAO()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<LettersDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public static Letter[] PAINGGONIGK()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		return GGFJGHHHEJC.lettersDatabaseSO.letters;
	}

	public static LettersDatabaseAccessor IDJGIJMKJLK()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<LettersDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	private void EMJKKALMGLK()
	{
		GGFJGHHHEJC = this;
		KDOMBHECOJN();
	}

	public static Letter[] GetAllLetters()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		return GGFJGHHHEJC.lettersDatabaseSO.letters;
	}

	public static Letter[] HHEANOANKJA()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		return GGFJGHHHEJC.lettersDatabaseSO.letters;
	}

	private static void KDOMBHECOJN()
	{
		GGFJGHHHEJC.MJLOJCNLAIO = new Dictionary<int, Letter>();
		Letter[] letters = GGFJGHHHEJC.lettersDatabaseSO.letters;
		for (int i = 1; i < letters.Length; i++)
		{
			Letter letter = letters[i];
			if (letter.letterID == 0)
			{
				Debug.Log((object)("BuzzNPC: ChangeState called with invalid state: " + ((Object)letter).name));
				continue;
			}
			try
			{
				GGFJGHHHEJC.MJLOJCNLAIO.Add(letter.letterID, letter);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "Moving" + ((Object)letter).name));
			}
		}
	}

	public static Letter[] LDOAFOJDOOM()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		return GGFJGHHHEJC.lettersDatabaseSO.letters;
	}

	public static LettersDatabase.Character DADBLLCAANA(Letter.Sender ADINOAOHPBG)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return default(LettersDatabase.Character);
		}
		return GGFJGHHHEJC.lettersDatabaseSO.characters[(int)ADINOAOHPBG];
	}

	public static LettersDatabaseAccessor CHPCJAHBJJF()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<LettersDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public static LettersDatabase.Character GetCharacter(Letter.Sender ADINOAOHPBG)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return default(LettersDatabase.Character);
		}
		return GGFJGHHHEJC.lettersDatabaseSO.characters[(int)ADINOAOHPBG];
	}

	public static Letter GetLetter(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		return GGFJGHHHEJC.MJLOJCNLAIO[JFNMCNCHMEO];
	}

	public static LettersDatabaseAccessor GOBCANBKFEM()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<LettersDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public static Letter DKLBBMCODAP(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		return GGFJGHHHEJC.MJLOJCNLAIO[JFNMCNCHMEO];
	}

	public static LettersDatabaseAccessor PIJFDMFLAIB()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<LettersDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public static Letter[] CDDELNADPFI()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		return GGFJGHHHEJC.lettersDatabaseSO.letters;
	}

	public static LettersDatabaseAccessor GetInstance()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<LettersDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public static LettersDatabase GetDatabase()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GetInstance();
		}
		return GGFJGHHHEJC.lettersDatabaseSO;
	}

	private void MFGANCCJFJK()
	{
		GGFJGHHHEJC = this;
		KDOMBHECOJN();
	}

	public static Letter HHANDNINGCL(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		return GGFJGHHHEJC.MJLOJCNLAIO[JFNMCNCHMEO];
	}

	private void Awake()
	{
		GGFJGHHHEJC = this;
		DMNENKNLDAH();
	}

	private static void DMNENKNLDAH()
	{
		GGFJGHHHEJC.MJLOJCNLAIO = new Dictionary<int, Letter>();
		Letter[] letters = GGFJGHHHEJC.lettersDatabaseSO.letters;
		foreach (Letter letter in letters)
		{
			if (letter.letterID == 0)
			{
				Debug.Log((object)("Letter without ID: " + ((Object)letter).name));
				continue;
			}
			try
			{
				GGFJGHHHEJC.MJLOJCNLAIO.Add(letter.letterID, letter);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "- " + ((Object)letter).name));
			}
		}
	}

	public static LettersDatabaseAccessor HCAIBKJKLOE()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<LettersDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public static LettersDatabase.Character DGNOMEGHEII(Letter.Sender ADINOAOHPBG)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return default(LettersDatabase.Character);
		}
		return GGFJGHHHEJC.lettersDatabaseSO.characters[(int)ADINOAOHPBG];
	}
}
