using System;


namespace R5T.Z0016
{
	public class Justifications : IJustifications
	{
		#region Infrastructure

	    public static IJustifications Instance { get; } = new Justifications();

	    private Justifications()
	    {
        }

	    #endregion
	}
}