package crc64a23aa9ae577aa84f;


public class SplashPage
	extends mvvmcross.platforms.android.views.MvxSplashScreenActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("MyOwnAppMvx.Droid.SplashPage, MyOwnAppMvx.Droid", SplashPage.class, __md_methods);
	}


	public SplashPage ()
	{
		super ();
		if (getClass () == SplashPage.class)
			mono.android.TypeManager.Activate ("MyOwnAppMvx.Droid.SplashPage, MyOwnAppMvx.Droid", "", this, new java.lang.Object[] {  });
	}


	public SplashPage (int p0)
	{
		super (p0);
		if (getClass () == SplashPage.class)
			mono.android.TypeManager.Activate ("MyOwnAppMvx.Droid.SplashPage, MyOwnAppMvx.Droid", "System.Int32, mscorlib", this, new java.lang.Object[] { p0 });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
