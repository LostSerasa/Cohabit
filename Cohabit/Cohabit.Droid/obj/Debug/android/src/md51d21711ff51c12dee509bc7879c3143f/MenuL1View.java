package md51d21711ff51c12dee509bc7879c3143f;


public class MenuL1View
	extends mvvmcross.droid.views.MvxActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Cohabit.Droid.Views.MenuL1View, Cohabit.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MenuL1View.class, __md_methods);
	}


	public MenuL1View () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MenuL1View.class)
			mono.android.TypeManager.Activate ("Cohabit.Droid.Views.MenuL1View, Cohabit.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
