//
// This test does not pass peverify because we dont return properly
// from catch blocks
//

class X {

	bool v ()
	{
		try {
			throw new Exception ();
		} catch {
			return false;
		}
		return true;
	}

	static int Main ()
	{
		return 0;
	}		
}
