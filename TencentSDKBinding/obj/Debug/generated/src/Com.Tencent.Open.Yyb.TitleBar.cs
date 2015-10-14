using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Open.Yyb {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='TitleBar']"
	[global::Android.Runtime.Register ("com/tencent/open/yyb/TitleBar", DoNotGenerateAcw=true)]
	public partial class TitleBar : global::Android.Widget.RelativeLayout {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='TitleBar']/field[@name='BACKBTN_LEFT_MARGIN']"
		[Register ("BACKBTN_LEFT_MARGIN")]
		public const float BackbtnLeftMargin = (float) 20.000000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='TitleBar']/field[@name='SHAREBTN_RIGHT_MARGIN']"
		[Register ("SHAREBTN_RIGHT_MARGIN")]
		public const float SharebtnRightMargin = (float) 10.000000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='TitleBar']/field[@name='TITLEBAR_HEIGHT']"
		[Register ("TITLEBAR_HEIGHT")]
		public const float TitlebarHeight = (float) 51.000000;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/open/yyb/TitleBar", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TitleBar); }
		}

		protected TitleBar (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='TitleBar']/constructor[@name='TitleBar' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe TitleBar (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (TitleBar)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_getBackBtn;
#pragma warning disable 0169
		static Delegate GetGetBackBtnHandler ()
		{
			if (cb_getBackBtn == null)
				cb_getBackBtn = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBackBtn);
			return cb_getBackBtn;
		}

		static IntPtr n_GetBackBtn (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Open.Yyb.TitleBar __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Yyb.TitleBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BackBtn);
		}
#pragma warning restore 0169

		static IntPtr id_getBackBtn;
		public virtual unsafe global::Android.Widget.RelativeLayout BackBtn {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='TitleBar']/method[@name='getBackBtn' and count(parameter)=0]"
			[Register ("getBackBtn", "()Landroid/widget/RelativeLayout;", "GetGetBackBtnHandler")]
			get {
				if (id_getBackBtn == IntPtr.Zero)
					id_getBackBtn = JNIEnv.GetMethodID (class_ref, "getBackBtn", "()Landroid/widget/RelativeLayout;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Widget.RelativeLayout> (JNIEnv.CallObjectMethod  (Handle, id_getBackBtn), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Widget.RelativeLayout> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBackBtn", "()Landroid/widget/RelativeLayout;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSharBtn;
#pragma warning disable 0169
		static Delegate GetGetSharBtnHandler ()
		{
			if (cb_getSharBtn == null)
				cb_getSharBtn = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSharBtn);
			return cb_getSharBtn;
		}

		static IntPtr n_GetSharBtn (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Open.Yyb.TitleBar __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Yyb.TitleBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SharBtn);
		}
#pragma warning restore 0169

		static IntPtr id_getSharBtn;
		public virtual unsafe global::Android.Widget.ImageView SharBtn {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='TitleBar']/method[@name='getSharBtn' and count(parameter)=0]"
			[Register ("getSharBtn", "()Landroid/widget/ImageView;", "GetGetSharBtnHandler")]
			get {
				if (id_getSharBtn == IntPtr.Zero)
					id_getSharBtn = JNIEnv.GetMethodID (class_ref, "getSharBtn", "()Landroid/widget/ImageView;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (JNIEnv.CallObjectMethod  (Handle, id_getSharBtn), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSharBtn", "()Landroid/widget/ImageView;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_setTitle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTitle_Ljava_lang_String_Handler ()
		{
			if (cb_setTitle_Ljava_lang_String_ == null)
				cb_setTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTitle_Ljava_lang_String_);
			return cb_setTitle_Ljava_lang_String_;
		}

		static void n_SetTitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Open.Yyb.TitleBar __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Yyb.TitleBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetTitle (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTitle_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='TitleBar']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTitle", "(Ljava/lang/String;)V", "GetSetTitle_Ljava_lang_String_Handler")]
		public virtual unsafe void SetTitle (string p0)
		{
			if (id_setTitle_Ljava_lang_String_ == IntPtr.Zero)
				id_setTitle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTitle", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTitle_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTitle", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
