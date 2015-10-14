using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Connect.Avatar {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.connect.avatar']/class[@name='ImageActivity']"
	[global::Android.Runtime.Register ("com/tencent/connect/avatar/ImageActivity", DoNotGenerateAcw=true)]
	public partial class ImageActivity : global::Android.App.Activity {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.connect.avatar']/class[@name='ImageActivity.QQAvatarImp']"
		[global::Android.Runtime.Register ("com/tencent/connect/avatar/ImageActivity$QQAvatarImp", DoNotGenerateAcw=true)]
		public partial class QQAvatarImp : global::Com.Tencent.Connect.Common.BaseApi {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/connect/avatar/ImageActivity$QQAvatarImp", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (QQAvatarImp); }
			}

			protected QQAvatarImp (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_tencent_connect_avatar_ImageActivity_Lcom_tencent_connect_auth_QQToken_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.connect.avatar']/class[@name='ImageActivity.QQAvatarImp']/constructor[@name='ImageActivity.QQAvatarImp' and count(parameter)=2 and parameter[1][@type='com.tencent.connect.avatar.ImageActivity'] and parameter[2][@type='com.tencent.connect.auth.QQToken']]"
			[Register (".ctor", "(Lcom/tencent/connect/avatar/ImageActivity;Lcom/tencent/connect/auth/QQToken;)V", "")]
			public unsafe QQAvatarImp (global::Com.Tencent.Connect.Avatar.ImageActivity __self, global::Com.Tencent.Connect.Auth.QQToken p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (QQAvatarImp)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/tencent/connect/auth/QQToken;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/tencent/connect/auth/QQToken;)V", __args);
						return;
					}

					if (id_ctor_Lcom_tencent_connect_avatar_ImageActivity_Lcom_tencent_connect_auth_QQToken_ == IntPtr.Zero)
						id_ctor_Lcom_tencent_connect_avatar_ImageActivity_Lcom_tencent_connect_auth_QQToken_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/tencent/connect/avatar/ImageActivity;Lcom/tencent/connect/auth/QQToken;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_tencent_connect_avatar_ImageActivity_Lcom_tencent_connect_auth_QQToken_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_tencent_connect_avatar_ImageActivity_Lcom_tencent_connect_auth_QQToken_, __args);
				} finally {
				}
			}

			static Delegate cb_setAvator_Landroid_graphics_Bitmap_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
			static Delegate GetSetAvator_Landroid_graphics_Bitmap_Lcom_tencent_tauth_IUiListener_Handler ()
			{
				if (cb_setAvator_Landroid_graphics_Bitmap_Lcom_tencent_tauth_IUiListener_ == null)
					cb_setAvator_Landroid_graphics_Bitmap_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAvator_Landroid_graphics_Bitmap_Lcom_tencent_tauth_IUiListener_);
				return cb_setAvator_Landroid_graphics_Bitmap_Lcom_tencent_tauth_IUiListener_;
			}

			static void n_SetAvator_Landroid_graphics_Bitmap_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Tencent.Connect.Avatar.ImageActivity.QQAvatarImp __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Avatar.ImageActivity.QQAvatarImp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Tencent.Tauth.IUiListener p1 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.SetAvator (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_setAvator_Landroid_graphics_Bitmap_Lcom_tencent_tauth_IUiListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.avatar']/class[@name='ImageActivity.QQAvatarImp']/method[@name='setAvator' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='com.tencent.tauth.IUiListener']]"
			[Register ("setAvator", "(Landroid/graphics/Bitmap;Lcom/tencent/tauth/IUiListener;)V", "GetSetAvator_Landroid_graphics_Bitmap_Lcom_tencent_tauth_IUiListener_Handler")]
			public virtual unsafe void SetAvator (global::Android.Graphics.Bitmap p0, global::Com.Tencent.Tauth.IUiListener p1)
			{
				if (id_setAvator_Landroid_graphics_Bitmap_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
					id_setAvator_Landroid_graphics_Bitmap_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "setAvator", "(Landroid/graphics/Bitmap;Lcom/tencent/tauth/IUiListener;)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setAvator_Landroid_graphics_Bitmap_Lcom_tencent_tauth_IUiListener_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAvator", "(Landroid/graphics/Bitmap;Lcom/tencent/tauth/IUiListener;)V"), __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/connect/avatar/ImageActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageActivity); }
		}

		protected ImageActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.connect.avatar']/class[@name='ImageActivity']/constructor[@name='ImageActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ImageActivity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ImageActivity)) {
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

		static Delegate cb_a_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetA_Ljava_lang_String_JHandler ()
		{
			if (cb_a_Ljava_lang_String_J == null)
				cb_a_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_A_Ljava_lang_String_J);
			return cb_a_Ljava_lang_String_J;
		}

		static void n_A_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.Tencent.Connect.Avatar.ImageActivity __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Avatar.ImageActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.A (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_a_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.avatar']/class[@name='ImageActivity']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("a", "(Ljava/lang/String;J)V", "GetA_Ljava_lang_String_JHandler")]
		public virtual unsafe void A (string p0, long p1)
		{
			if (id_a_Ljava_lang_String_J == IntPtr.Zero)
				id_a_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;J)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_lang_String_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Ljava/lang/String;J)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onCreate_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnCreate_Landroid_os_Bundle_Handler ()
		{
			if (cb_onCreate_Landroid_os_Bundle_ == null)
				cb_onCreate_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCreate_Landroid_os_Bundle_);
			return cb_onCreate_Landroid_os_Bundle_;
		}

		static void n_OnCreate_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Connect.Avatar.ImageActivity __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Avatar.ImageActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCreate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onCreate_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.avatar']/class[@name='ImageActivity']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onCreate", "(Landroid/os/Bundle;)V", "GetOnCreate_Landroid_os_Bundle_Handler")]
		public virtual unsafe void OnCreate (global::Android.OS.Bundle p0)
		{
			if (id_onCreate_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onCreate_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onCreate", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onCreate_Landroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCreate", "(Landroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

	}
}
