using UnityEngine;

namespace psai.net;

public class UnityVersionComparer
{
	public enum UnityVersionType
	{
		unknown,
		beta,
		final,
		patch
	}

	public enum ComparisonResult
	{
		unknown,
		earlier,
		equal,
		later
	}

	public class UnityVersion
	{
		public int MajorVersionNumber { get; private set; }

		public int MiddleVersionNumber { get; private set; }

		public int MinorVersionNumber { get; private set; }

		public UnityVersionType UnityVersionType { get; private set; }

		public int PatchOrBetaVersion { get; private set; }

		public UnityVersion(int major, int middle, int minor, int patchOrBetaVersion = 0, UnityVersionType versionType = UnityVersionType.final)
		{
			MajorVersionNumber = major;
			MiddleVersionNumber = middle;
			MinorVersionNumber = minor;
			PatchOrBetaVersion = patchOrBetaVersion;
			UnityVersionType = versionType;
		}

		public UnityVersion(string unityVersionString = "")
		{
			if (unityVersionString == "")
			{
				unityVersionString = Application.unityVersion;
			}
			UnityVersionType = UnityVersionType.unknown;
			int result = -1;
			int result2 = -1;
			int result3 = -1;
			int result4 = -1;
			string[] array = unityVersionString.Split('.');
			if (array.Length != 3)
			{
				return;
			}
			int.TryParse(array[0], out result);
			int.TryParse(array[1], out result2);
			char[] separator = new char[3] { 'b', 'f', 'p' };
			string[] array2 = array[2].Split(separator);
			if (array2.Length != 0)
			{
				if (int.TryParse(array2[0], out result3))
				{
					UnityVersionType = UnityVersionType.final;
					result4 = 0;
				}
				if (array2.Length > 1 && int.TryParse(array2[1], out result4))
				{
					if (array[2].Contains("f"))
					{
						UnityVersionType = UnityVersionType.final;
					}
					else if (array[2].Contains("b"))
					{
						UnityVersionType = UnityVersionType.beta;
					}
					else if (array[2].Contains("p"))
					{
						UnityVersionType = UnityVersionType.patch;
					}
				}
			}
			else
			{
				result4 = 0;
				UnityVersionType = UnityVersionType.final;
			}
			MajorVersionNumber = result;
			MiddleVersionNumber = result2;
			MinorVersionNumber = result3;
			PatchOrBetaVersion = result4;
		}
	}

	public static ComparisonResult CompareCurrentVersionAgainst(string versionString)
	{
		UnityVersion first = new UnityVersion(Application.unityVersion);
		UnityVersion second = new UnityVersion(versionString);
		return CompareUnityVersions(first, second);
	}

	public static ComparisonResult CompareUnityVersions(string firstVersionString, string secondVersionString)
	{
		UnityVersion first = new UnityVersion(firstVersionString);
		UnityVersion second = new UnityVersion(secondVersionString);
		return CompareUnityVersions(first, second);
	}

	public static ComparisonResult CompareUnityVersions(UnityVersion first, UnityVersion second, bool ignorePatchVersion = false)
	{
		if (first.MajorVersionNumber <= 0 || second.MajorVersionNumber <= 0)
		{
			return ComparisonResult.unknown;
		}
		ComparisonResult comparisonResult = CompareSubVersion(first.MajorVersionNumber, second.MajorVersionNumber);
		if (comparisonResult != ComparisonResult.equal)
		{
			return comparisonResult;
		}
		ComparisonResult comparisonResult2 = CompareSubVersion(first.MiddleVersionNumber, second.MiddleVersionNumber);
		if (comparisonResult2 != ComparisonResult.equal)
		{
			return comparisonResult2;
		}
		ComparisonResult comparisonResult3 = CompareSubVersion(first.MinorVersionNumber, second.MinorVersionNumber);
		if (comparisonResult3 != ComparisonResult.equal)
		{
			return comparisonResult3;
		}
		if (ignorePatchVersion)
		{
			return ComparisonResult.equal;
		}
		return CompareBetaOrPatch(first, second);
	}

	private static ComparisonResult CompareBetaOrPatch(UnityVersion first, UnityVersion second)
	{
		if (first.UnityVersionType == UnityVersionType.unknown || second.UnityVersionType == UnityVersionType.unknown)
		{
			return ComparisonResult.unknown;
		}
		int num = ((int)first.UnityVersionType).CompareTo((int)second.UnityVersionType);
		if (num == 0)
		{
			return CompareSubVersion(first.PatchOrBetaVersion, second.PatchOrBetaVersion);
		}
		if (num > 0)
		{
			return ComparisonResult.later;
		}
		return ComparisonResult.earlier;
	}

	private static ComparisonResult CompareSubVersion(int first, int second)
	{
		if (first == second)
		{
			return ComparisonResult.equal;
		}
		if (first < second)
		{
			return ComparisonResult.earlier;
		}
		return ComparisonResult.later;
	}
}
