using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Open.Weiyun {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='RecordManager']"
	[global::Android.Runtime.Register ("com/tencent/open/weiyun/RecordManager", DoNotGenerateAcw=true)]
	public partial class RecordManager : global::Com.Tencent.Connect.Common.BaseApi {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/open/weiyun/RecordManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RecordManager); }
		}

		protected RecordManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQAuth_Lcom_tencent_connect_auth_QQToken_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='RecordManager']/constructor[@name='RecordManager' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.tencent.connect.auth.QQAuth'] and parameter[3][@type='com.tencent.connect.auth.QQToken']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/tencent/connect/auth/QQAuth;Lcom/tencent/connect/auth/QQToken;)V", "")]
		public unsafe RecordManager (global::Android.Content.Context p0, global::Com.Tencent.Connect.Auth.QQAuth p1, global::Com.Tencent.Connect.Auth.QQToken p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (RecordManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lcom/tencent/connect/auth/QQAuth;Lcom/tencent/connect/auth/QQToken;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lcom/tencent/connect/auth/QQAuth;Lcom/tencent/connect/auth/QQToken;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQAuth_Lcom_tencent_connect_auth_QQToken_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQAuth_Lcom_tencent_connect_auth_QQToken_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/tencent/connect/auth/QQAuth;Lcom/tencent/connect/auth/QQToken;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQAuth_Lcom_tencent_connect_auth_QQToken_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQAuth_Lcom_tencent_connect_auth_QQToken_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQToken_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='RecordManager']/constructor[@name='RecordManager' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.tencent.connect.auth.QQToken']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/tencent/connect/auth/QQToken;)V", "")]
		public unsafe RecordManager (global::Android.Content.Context p0, global::Com.Tencent.Connect.Auth.QQToken p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (RecordManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lcom/tencent/connect/auth/QQToken;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lcom/tencent/connect/auth/QQToken;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQToken_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQToken_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/tencent/connect/auth/QQToken;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQToken_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQToken_, __args);
			} finally {
			}
		}

		static Delegate cb_checkRecord_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetCheckRecord_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_checkRecord_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ == null)
				cb_checkRecord_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CheckRecord_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_);
			return cb_checkRecord_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_CheckRecord_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Open.Weiyun.RecordManager __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.RecordManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p1 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CheckRecord (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_checkRecord_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='RecordManager']/method[@name='checkRecord' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.tencent.tauth.IUiListener']]"
		[Register ("checkRecord", "(Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V", "GetCheckRecord_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void CheckRecord (string p0, global::Com.Tencent.Tauth.IUiListener p1)
		{
			if (id_checkRecord_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_checkRecord_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "checkRecord", "(Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_checkRecord_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkRecord", "(Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_createRecord_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetCreateRecord_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_createRecord_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ == null)
				cb_createRecord_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateRecord_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_);
			return cb_createRecord_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_CreateRecord_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Open.Weiyun.RecordManager __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.RecordManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.CreateRecord (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_createRecord_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='RecordManager']/method[@name='createRecord' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
		[Register ("createRecord", "(Ljava/lang/String;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V", "GetCreateRecord_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void CreateRecord (string p0, string p1, global::Com.Tencent.Tauth.IUiListener p2)
		{
			if (id_createRecord_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_createRecord_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "createRecord", "(Ljava/lang/String;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_createRecord_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createRecord", "(Ljava/lang/String;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_deleteRecord_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetDeleteRecord_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_deleteRecord_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ == null)
				cb_deleteRecord_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DeleteRecord_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_);
			return cb_deleteRecord_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_DeleteRecord_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Open.Weiyun.RecordManager __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.RecordManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p1 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.DeleteRecord (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_deleteRecord_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='RecordManager']/method[@name='deleteRecord' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.tencent.tauth.IUiListener']]"
		[Register ("deleteRecord", "(Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V", "GetDeleteRecord_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void DeleteRecord (string p0, global::Com.Tencent.Tauth.IUiListener p1)
		{
			if (id_deleteRecord_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_deleteRecord_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "deleteRecord", "(Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_deleteRecord_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteRecord", "(Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getRecord_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetGetRecord_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_getRecord_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ == null)
				cb_getRecord_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetRecord_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_);
			return cb_getRecord_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_GetRecord_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Open.Weiyun.RecordManager __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.RecordManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p1 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetRecord (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_getRecord_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='RecordManager']/method[@name='getRecord' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.tencent.tauth.IUiListener']]"
		[Register ("getRecord", "(Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V", "GetGetRecord_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void GetRecord (string p0, global::Com.Tencent.Tauth.IUiListener p1)
		{
			if (id_getRecord_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_getRecord_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "getRecord", "(Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_getRecord_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRecord", "(Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_modifyRecord_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetModifyRecord_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_modifyRecord_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ == null)
				cb_modifyRecord_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ModifyRecord_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_);
			return cb_modifyRecord_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_ModifyRecord_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Open.Weiyun.RecordManager __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.RecordManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.ModifyRecord (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_modifyRecord_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='RecordManager']/method[@name='modifyRecord' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
		[Register ("modifyRecord", "(Ljava/lang/String;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V", "GetModifyRecord_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void ModifyRecord (string p0, string p1, global::Com.Tencent.Tauth.IUiListener p2)
		{
			if (id_modifyRecord_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_modifyRecord_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "modifyRecord", "(Ljava/lang/String;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_modifyRecord_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "modifyRecord", "(Ljava/lang/String;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_queryAllRecord_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetQueryAllRecord_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_queryAllRecord_Lcom_tencent_tauth_IUiListener_ == null)
				cb_queryAllRecord_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_QueryAllRecord_Lcom_tencent_tauth_IUiListener_);
			return cb_queryAllRecord_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_QueryAllRecord_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Open.Weiyun.RecordManager __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.RecordManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p0 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.QueryAllRecord (p0);
		}
#pragma warning restore 0169

		static IntPtr id_queryAllRecord_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='RecordManager']/method[@name='queryAllRecord' and count(parameter)=1 and parameter[1][@type='com.tencent.tauth.IUiListener']]"
		[Register ("queryAllRecord", "(Lcom/tencent/tauth/IUiListener;)V", "GetQueryAllRecord_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void QueryAllRecord (global::Com.Tencent.Tauth.IUiListener p0)
		{
			if (id_queryAllRecord_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_queryAllRecord_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "queryAllRecord", "(Lcom/tencent/tauth/IUiListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_queryAllRecord_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "queryAllRecord", "(Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
			}
		}

	}
}
