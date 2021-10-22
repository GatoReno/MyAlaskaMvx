package mono.android.app;

public class ApplicationRegistration {

	public static void registerApplications ()
	{
				// Application and Instrumentation ACWs must be registered first.
		mono.android.Runtime.register ("MyOwnAppMvx.Droid.MainApplication, MyOwnAppMvx.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", crc64a23aa9ae577aa84f.MainApplication.class, crc64a23aa9ae577aa84f.MainApplication.__md_methods);
		mono.android.Runtime.register ("MvvmCross.Platforms.Android.Views.MvxAndroidApplication, MvvmCross, Version=8.0.2.0, Culture=neutral, PublicKeyToken=null", crc6466d8e86b1ec8bfa8.MvxAndroidApplication.class, crc6466d8e86b1ec8bfa8.MvxAndroidApplication.__md_methods);
		mono.android.Runtime.register ("MvvmCross.Platforms.Android.Views.MvxAndroidApplication`2, MvvmCross, Version=8.0.2.0, Culture=neutral, PublicKeyToken=null", crc6466d8e86b1ec8bfa8.MvxAndroidApplication_2.class, crc6466d8e86b1ec8bfa8.MvxAndroidApplication_2.__md_methods);
		mono.android.Runtime.register ("MvvmCross.Droid.Support.V7.AppCompat.MvxAppCompatApplication`2, MvvmCross.Droid.Support.V7.AppCompat, Version=6.4.2.0, Culture=neutral, PublicKeyToken=null", crc648d9adcc6b772c31e.MvxAppCompatApplication_2.class, crc648d9adcc6b772c31e.MvxAppCompatApplication_2.__md_methods);
		
	}
}
