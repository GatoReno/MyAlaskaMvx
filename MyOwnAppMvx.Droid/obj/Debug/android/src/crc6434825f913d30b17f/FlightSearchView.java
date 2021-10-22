package crc6434825f913d30b17f;


public class FlightSearchView
	extends crc6434825f913d30b17f.BaseView_1
	implements
		mono.android.IGCUserPeer,
		com.google.android.material.datepicker.MaterialPickerOnPositiveButtonClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onDestroy:()V:GetOnDestroyHandler\n" +
			"n_onPositiveButtonClick:(Ljava/lang/Object;)V:GetOnPositiveButtonClick_Ljava_lang_Object_Handler:Google.Android.Material.DatePicker.IMaterialPickerOnPositiveButtonClickListenerInvoker, Xamarin.Google.Android.Material\n" +
			"";
		mono.android.Runtime.register ("MyOwnAppMvx.Droid.Views.FlightSearchView, MyOwnAppMvx.Droid", FlightSearchView.class, __md_methods);
	}


	public FlightSearchView ()
	{
		super ();
		if (getClass () == FlightSearchView.class)
			mono.android.TypeManager.Activate ("MyOwnAppMvx.Droid.Views.FlightSearchView, MyOwnAppMvx.Droid", "", this, new java.lang.Object[] {  });
	}


	public FlightSearchView (int p0)
	{
		super (p0);
		if (getClass () == FlightSearchView.class)
			mono.android.TypeManager.Activate ("MyOwnAppMvx.Droid.Views.FlightSearchView, MyOwnAppMvx.Droid", "System.Int32, mscorlib", this, new java.lang.Object[] { p0 });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void onDestroy ()
	{
		n_onDestroy ();
	}

	private native void n_onDestroy ();


	public void onPositiveButtonClick (java.lang.Object p0)
	{
		n_onPositiveButtonClick (p0);
	}

	private native void n_onPositiveButtonClick (java.lang.Object p0);

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
