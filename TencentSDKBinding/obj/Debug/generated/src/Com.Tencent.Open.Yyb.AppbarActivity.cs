using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Open.Yyb {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarActivity']"
	[global::Android.Runtime.Register ("com/tencent/open/yyb/AppbarActivity", DoNotGenerateAcw=true)]
	public partial class AppbarActivity : global::Android.App.Activity, global::Android.Views.View.IOnClickListener {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarActivity']/field[@name='MYAPP_CACHE_PATH']"
		[Register ("MYAPP_CACHE_PATH")]
		public const string MyappCachePath = (string) "/tencent/tassistant";

		static IntPtr mProgressDialog_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarActivity']/field[@name='mProgressDialog']"
		[Register ("mProgressDialog")]
		protected global::Android.App.ProgressDialog MProgressDialog {
			get {
				if (mProgressDialog_jfieldId == IntPtr.Zero)
					mProgressDialog_jfieldId = JNIEnv.GetFieldID (class_ref, "mProgressDialog", "Landroid/app/ProgressDialog;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mProgressDialog_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.App.ProgressDialog> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mProgressDialog_jfieldId == IntPtr.Zero)
					mProgressDialog_jfieldId = JNIEnv.GetFieldID (class_ref, "mProgressDialog", "Landroid/app/ProgressDialog;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, mProgressDialog_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/open/yyb/AppbarActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AppbarActivity); }
		}

		protected AppbarActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarActivity']/constructor[@name='AppbarActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AppbarActivity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AppbarActivity)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_login;
#pragma warning disable 0169
		static Delegate GetLoginHandler ()
		{
			if (cb_login == null)
				cb_login = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Login);
			return cb_login;
		}

		static void n_Login (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Open.Yyb.AppbarActivity __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Yyb.AppbarActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Login ();
		}
#pragma warning restore 0169

		static IntPtr id_login;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarActivity']/method[@name='login' and count(parameter)=0]"
		[Register ("login", "()V", "GetLoginHandler")]
		public virtual unsafe void Login ()
		{
			if (id_login == IntPtr.Zero)
				id_login = JNIEnv.GetMethodID (class_ref, "login", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_login);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "login", "()V"));
			} finally {
			}
		}

		static Delegate cb_onClick_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnClick_Landroid_view_View_Handler ()
		{
			if (cb_onClick_Landroid_view_View_ == null)
				cb_onClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnClick_Landroid_view_View_);
			return cb_onClick_Landroid_view_View_;
		}

		static void n_OnClick_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Open.Yyb.AppbarActivity __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Yyb.AppbarActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnClick (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onClick_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarActivity']/method[@name='onClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("onClick", "(Landroid/view/View;)V", "GetOnClick_Landroid_view_View_Handler")]
		public virtual unsafe void OnClick (global::Android.Views.View p0)
		{
			if (id_onClick_Landroid_view_View_ == IntPtr.Zero)
				id_onClick_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onClick", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onClick_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onClick", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setAppbarTitle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAppbarTitle_Ljava_lang_String_Handler ()
		{
			if (cb_setAppbarTitle_Ljava_lang_String_ == null)
				cb_setAppbarTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAppbarTitle_Ljava_lang_String_);
			return cb_setAppbarTitle_Ljava_lang_String_;
		}

		static void n_SetAppbarTitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Open.Yyb.AppbarActivity __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Yyb.AppbarActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAppbarTitle (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAppbarTitle_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarActivity']/method[@name='setAppbarTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAppbarTitle", "(Ljava/lang/String;)V", "GetSetAppbarTitle_Ljava_lang_String_Handler")]
		public virtual unsafe void SetAppbarTitle (string p0)
		{
			if (id_setAppbarTitle_Ljava_lang_String_ == IntPtr.Zero)
				id_setAppbarTitle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAppbarTitle", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAppbarTitle_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAppbarTitle", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setShareModel_Lcom_tencent_open_yyb_ShareModel_;
#pragma warning disable 0169
		static Delegate GetSetShareModel_Lcom_tencent_open_yyb_ShareModel_Handler ()
		{
			if (cb_setShareModel_Lcom_tencent_open_yyb_ShareModel_ == null)
				cb_setShareModel_Lcom_tencent_open_yyb_ShareModel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetShareModel_Lcom_tencent_open_yyb_ShareModel_);
			return cb_setShareModel_Lcom_tencent_open_yyb_ShareModel_;
		}

		static void n_SetShareModel_Lcom_tencent_open_yyb_ShareModel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Open.Yyb.AppbarActivity __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Yyb.AppbarActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Open.Yyb.ShareModel p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Yyb.ShareModel> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetShareModel (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setShareModel_Lcom_tencent_open_yyb_ShareModel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarActivity']/method[@name='setShareModel' and count(parameter)=1 and parameter[1][@type='com.tencent.open.yyb.ShareModel']]"
		[Register ("setShareModel", "(Lcom/tencent/open/yyb/ShareModel;)V", "GetSetShareModel_Lcom_tencent_open_yyb_ShareModel_Handler")]
		public virtual unsafe void SetShareModel (global::Com.Tencent.Open.Yyb.ShareModel p0)
		{
			if (id_setShareModel_Lcom_tencent_open_yyb_ShareModel_ == IntPtr.Zero)
				id_setShareModel_Lcom_tencent_open_yyb_ShareModel_ = JNIEnv.GetMethodID (class_ref, "setShareModel", "(Lcom/tencent/open/yyb/ShareModel;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setShareModel_Lcom_tencent_open_yyb_ShareModel_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShareModel", "(Lcom/tencent/open/yyb/ShareModel;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setShareVisibility_Z;
#pragma warning disable 0169
		static Delegate GetSetShareVisibility_ZHandler ()
		{
			if (cb_setShareVisibility_Z == null)
				cb_setShareVisibility_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetShareVisibility_Z);
			return cb_setShareVisibility_Z;
		}

		static void n_SetShareVisibility_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Tencent.Open.Yyb.AppbarActivity __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Yyb.AppbarActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetShareVisibility (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setShareVisibility_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarActivity']/method[@name='setShareVisibility' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setShareVisibility", "(Z)V", "GetSetShareVisibility_ZHandler")]
		public virtual unsafe void SetShareVisibility (bool p0)
		{
			if (id_setShareVisibility_Z == IntPtr.Zero)
				id_setShareVisibility_Z = JNIEnv.GetMethodID (class_ref, "setShareVisibility", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setShareVisibility_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShareVisibility", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_shareToQQ;
#pragma warning disable 0169
		static Delegate GetShareToQQHandler ()
		{
			if (cb_shareToQQ == null)
				cb_shareToQQ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShareToQQ);
			return cb_shareToQQ;
		}

		static void n_ShareToQQ (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Open.Yyb.AppbarActivity __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Yyb.AppbarActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShareToQQ ();
		}
#pragma warning restore 0169

		static IntPtr id_shareToQQ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarActivity']/method[@name='shareToQQ' and count(parameter)=0]"
		[Register ("shareToQQ", "()V", "GetShareToQQHandler")]
		public virtual unsafe void ShareToQQ ()
		{
			if (id_shareToQQ == IntPtr.Zero)
				id_shareToQQ = JNIEnv.GetMethodID (class_ref, "shareToQQ", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_shareToQQ);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shareToQQ", "()V"));
			} finally {
			}
		}

		static Delegate cb_shareToQzone;
#pragma warning disable 0169
		static Delegate GetShareToQzoneHandler ()
		{
			if (cb_shareToQzone == null)
				cb_shareToQzone = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShareToQzone);
			return cb_shareToQzone;
		}

		static void n_ShareToQzone (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Open.Yyb.AppbarActivity __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Yyb.AppbarActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShareToQzone ();
		}
#pragma warning restore 0169

		static IntPtr id_shareToQzone;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarActivity']/method[@name='shareToQzone' and count(parameter)=0]"
		[Register ("shareToQzone", "()V", "GetShareToQzoneHandler")]
		public virtual unsafe void ShareToQzone ()
		{
			if (id_shareToQzone == IntPtr.Zero)
				id_shareToQzone = JNIEnv.GetMethodID (class_ref, "shareToQzone", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_shareToQzone);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shareToQzone", "()V"));
			} finally {
			}
		}

		static Delegate cb_shareToTimeline;
#pragma warning disable 0169
		static Delegate GetShareToTimelineHandler ()
		{
			if (cb_shareToTimeline == null)
				cb_shareToTimeline = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShareToTimeline);
			return cb_shareToTimeline;
		}

		static void n_ShareToTimeline (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Open.Yyb.AppbarActivity __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Yyb.AppbarActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShareToTimeline ();
		}
#pragma warning restore 0169

		static IntPtr id_shareToTimeline;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarActivity']/method[@name='shareToTimeline' and count(parameter)=0]"
		[Register ("shareToTimeline", "()V", "GetShareToTimelineHandler")]
		public virtual unsafe void ShareToTimeline ()
		{
			if (id_shareToTimeline == IntPtr.Zero)
				id_shareToTimeline = JNIEnv.GetMethodID (class_ref, "shareToTimeline", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_shareToTimeline);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shareToTimeline", "()V"));
			} finally {
			}
		}

		static Delegate cb_shareToWX;
#pragma warning disable 0169
		static Delegate GetShareToWXHandler ()
		{
			if (cb_shareToWX == null)
				cb_shareToWX = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShareToWX);
			return cb_shareToWX;
		}

		static void n_ShareToWX (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Open.Yyb.AppbarActivity __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Yyb.AppbarActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShareToWX ();
		}
#pragma warning restore 0169

		static IntPtr id_shareToWX;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarActivity']/method[@name='shareToWX' and count(parameter)=0]"
		[Register ("shareToWX", "()V", "GetShareToWXHandler")]
		public virtual unsafe void ShareToWX ()
		{
			if (id_shareToWX == IntPtr.Zero)
				id_shareToWX = JNIEnv.GetMethodID (class_ref, "shareToWX", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_shareToWX);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shareToWX", "()V"));
			} finally {
			}
		}

		static Delegate cb_showFloatingDialog;
#pragma warning disable 0169
		static Delegate GetShowFloatingDialogHandler ()
		{
			if (cb_showFloatingDialog == null)
				cb_showFloatingDialog = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShowFloatingDialog);
			return cb_showFloatingDialog;
		}

		static void n_ShowFloatingDialog (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Open.Yyb.AppbarActivity __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Yyb.AppbarActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowFloatingDialog ();
		}
#pragma warning restore 0169

		static IntPtr id_showFloatingDialog;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarActivity']/method[@name='showFloatingDialog' and count(parameter)=0]"
		[Register ("showFloatingDialog", "()V", "GetShowFloatingDialogHandler")]
		public virtual unsafe void ShowFloatingDialog ()
		{
			if (id_showFloatingDialog == IntPtr.Zero)
				id_showFloatingDialog = JNIEnv.GetMethodID (class_ref, "showFloatingDialog", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_showFloatingDialog);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showFloatingDialog", "()V"));
			} finally {
			}
		}

		static Delegate cb_showProgressDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetShowProgressDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_showProgressDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_showProgressDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ShowProgressDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_);
			return cb_showProgressDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_ShowProgressDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Open.Yyb.AppbarActivity __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Yyb.AppbarActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.ShowProgressDialog (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_showProgressDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarActivity']/method[@name='showProgressDialog' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("showProgressDialog", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "GetShowProgressDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected virtual unsafe void ShowProgressDialog (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_showProgressDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_showProgressDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "showProgressDialog", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_showProgressDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showProgressDialog", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
