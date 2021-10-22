package mvvmcross.droidx;


public class MvxSwipeRefreshLayout
	extends androidx.swiperefreshlayout.widget.SwipeRefreshLayout
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("MvvmCross.DroidX.MvxSwipeRefreshLayout, MvvmCross.DroidX.SwipeRefreshLayout", MvxSwipeRefreshLayout.class, __md_methods);
	}


	public MvxSwipeRefreshLayout (android.content.Context p0)
	{
		super (p0);
		if (getClass () == MvxSwipeRefreshLayout.class)
			mono.android.TypeManager.Activate ("MvvmCross.DroidX.MvxSwipeRefreshLayout, MvvmCross.DroidX.SwipeRefreshLayout", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public MvxSwipeRefreshLayout (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == MvxSwipeRefreshLayout.class)
			mono.android.TypeManager.Activate ("MvvmCross.DroidX.MvxSwipeRefreshLayout, MvvmCross.DroidX.SwipeRefreshLayout", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
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
