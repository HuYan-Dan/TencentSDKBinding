using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Connect.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='UIListenerManager']"
	[global::Android.Runtime.Register ("com/tencent/connect/common/UIListenerManager", DoNotGenerateAcw=true)]
	public partial class UIListenerManager : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='UIListenerManager.ApiTask']"
		[global::Android.Runtime.Register ("com/tencent/connect/common/UIListenerManager$ApiTask", DoNotGenerateAcw=true)]
		public partial class ApiTask : global::Java.Lang.Object {


			static IntPtr mListener_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='UIListenerManager.ApiTask']/field[@name='mListener']"
			[Register ("mListener")]
			public global::Com.Tencent.Tauth.IUiListener MListener {
				get {
					if (mListener_jfieldId == IntPtr.Zero)
						mListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mListener", "Lcom/tencent/tauth/IUiListener;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, mListener_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (mListener_jfieldId == IntPtr.Zero)
						mListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mListener", "Lcom/tencent/tauth/IUiListener;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (Handle, mListener_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr mRequestCode_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='UIListenerManager.ApiTask']/field[@name='mRequestCode']"
			[Register ("mRequestCode")]
			public int MRequestCode {
				get {
					if (mRequestCode_jfieldId == IntPtr.Zero)
						mRequestCode_jfieldId = JNIEnv.GetFieldID (class_ref, "mRequestCode", "I");
					return JNIEnv.GetIntField (Handle, mRequestCode_jfieldId);
				}
				set {
					if (mRequestCode_jfieldId == IntPtr.Zero)
						mRequestCode_jfieldId = JNIEnv.GetFieldID (class_ref, "mRequestCode", "I");
					try {
						JNIEnv.SetField (Handle, mRequestCode_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/connect/common/UIListenerManager$ApiTask", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ApiTask); }
			}

			protected ApiTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_tencent_connect_common_UIListenerManager_ILcom_tencent_tauth_IUiListener_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='UIListenerManager.ApiTask']/constructor[@name='UIListenerManager.ApiTask' and count(parameter)=3 and parameter[1][@type='com.tencent.connect.common.UIListenerManager'] and parameter[2][@type='int'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
			[Register (".ctor", "(Lcom/tencent/connect/common/UIListenerManager;ILcom/tencent/tauth/IUiListener;)V", "")]
			public unsafe ApiTask (global::Com.Tencent.Connect.Common.UIListenerManager __self, int p1, global::Com.Tencent.Tauth.IUiListener p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					if (GetType () != typeof (ApiTask)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";ILcom/tencent/tauth/IUiListener;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";ILcom/tencent/tauth/IUiListener;)V", __args);
						return;
					}

					if (id_ctor_Lcom_tencent_connect_common_UIListenerManager_ILcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
						id_ctor_Lcom_tencent_connect_common_UIListenerManager_ILcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/tencent/connect/common/UIListenerManager;ILcom/tencent/tauth/IUiListener;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_tencent_connect_common_UIListenerManager_ILcom_tencent_tauth_IUiListener_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_tencent_connect_common_UIListenerManager_ILcom_tencent_tauth_IUiListener_, __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/connect/common/UIListenerManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UIListenerManager); }
		}

		protected UIListenerManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Tencent.Connect.Common.UIListenerManager Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='UIListenerManager']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/tencent/connect/common/UIListenerManager;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/tencent/connect/common/UIListenerManager;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Common.UIListenerManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getListnerWithAction_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetListnerWithAction_Ljava_lang_String_Handler ()
		{
			if (cb_getListnerWithAction_Ljava_lang_String_ == null)
				cb_getListnerWithAction_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetListnerWithAction_Ljava_lang_String_);
			return cb_getListnerWithAction_Ljava_lang_String_;
		}

		static IntPtr n_GetListnerWithAction_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Connect.Common.UIListenerManager __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Common.UIListenerManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetListnerWithAction (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getListnerWithAction_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='UIListenerManager']/method[@name='getListnerWithAction' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getListnerWithAction", "(Ljava/lang/String;)Lcom/tencent/tauth/IUiListener;", "GetGetListnerWithAction_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Tencent.Tauth.IUiListener GetListnerWithAction (string p0)
		{
			if (id_getListnerWithAction_Ljava_lang_String_ == IntPtr.Zero)
				id_getListnerWithAction_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getListnerWithAction", "(Ljava/lang/String;)Lcom/tencent/tauth/IUiListener;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Tencent.Tauth.IUiListener __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (JNIEnv.CallObjectMethod  (Handle, id_getListnerWithAction_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getListnerWithAction", "(Ljava/lang/String;)Lcom/tencent/tauth/IUiListener;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getListnerWithRequestCode_I;
#pragma warning disable 0169
		static Delegate GetGetListnerWithRequestCode_IHandler ()
		{
			if (cb_getListnerWithRequestCode_I == null)
				cb_getListnerWithRequestCode_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetListnerWithRequestCode_I);
			return cb_getListnerWithRequestCode_I;
		}

		static IntPtr n_GetListnerWithRequestCode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Connect.Common.UIListenerManager __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Common.UIListenerManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetListnerWithRequestCode (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getListnerWithRequestCode_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='UIListenerManager']/method[@name='getListnerWithRequestCode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getListnerWithRequestCode", "(I)Lcom/tencent/tauth/IUiListener;", "GetGetListnerWithRequestCode_IHandler")]
		public virtual unsafe global::Com.Tencent.Tauth.IUiListener GetListnerWithRequestCode (int p0)
		{
			if (id_getListnerWithRequestCode_I == IntPtr.Zero)
				id_getListnerWithRequestCode_I = JNIEnv.GetMethodID (class_ref, "getListnerWithRequestCode", "(I)Lcom/tencent/tauth/IUiListener;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (JNIEnv.CallObjectMethod  (Handle, id_getListnerWithRequestCode_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getListnerWithRequestCode", "(I)Lcom/tencent/tauth/IUiListener;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_handleDataToListener_Landroid_content_Intent_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetHandleDataToListener_Landroid_content_Intent_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_handleDataToListener_Landroid_content_Intent_Lcom_tencent_tauth_IUiListener_ == null)
				cb_handleDataToListener_Landroid_content_Intent_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_HandleDataToListener_Landroid_content_Intent_Lcom_tencent_tauth_IUiListener_);
			return cb_handleDataToListener_Landroid_content_Intent_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_HandleDataToListener_Landroid_content_Intent_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Connect.Common.UIListenerManager __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Common.UIListenerManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p1 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.HandleDataToListener (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_handleDataToListener_Landroid_content_Intent_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='UIListenerManager']/method[@name='handleDataToListener' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='com.tencent.tauth.IUiListener']]"
		[Register ("handleDataToListener", "(Landroid/content/Intent;Lcom/tencent/tauth/IUiListener;)V", "GetHandleDataToListener_Landroid_content_Intent_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void HandleDataToListener (global::Android.Content.Intent p0, global::Com.Tencent.Tauth.IUiListener p1)
		{
			if (id_handleDataToListener_Landroid_content_Intent_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_handleDataToListener_Landroid_content_Intent_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "handleDataToListener", "(Landroid/content/Intent;Lcom/tencent/tauth/IUiListener;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_handleDataToListener_Landroid_content_Intent_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleDataToListener", "(Landroid/content/Intent;Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onActivityResult_IILandroid_content_Intent_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetOnActivityResult_IILandroid_content_Intent_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_onActivityResult_IILandroid_content_Intent_Lcom_tencent_tauth_IUiListener_ == null)
				cb_onActivityResult_IILandroid_content_Intent_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, IntPtr, bool>) n_OnActivityResult_IILandroid_content_Intent_Lcom_tencent_tauth_IUiListener_);
			return cb_onActivityResult_IILandroid_content_Intent_Lcom_tencent_tauth_IUiListener_;
		}

		static bool n_OnActivityResult_IILandroid_content_Intent_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Tencent.Connect.Common.UIListenerManager __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Common.UIListenerManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p2 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p3 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnActivityResult (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onActivityResult_IILandroid_content_Intent_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='UIListenerManager']/method[@name='onActivityResult' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.content.Intent'] and parameter[4][@type='com.tencent.tauth.IUiListener']]"
		[Register ("onActivityResult", "(IILandroid/content/Intent;Lcom/tencent/tauth/IUiListener;)Z", "GetOnActivityResult_IILandroid_content_Intent_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe bool OnActivityResult (int p0, int p1, global::Android.Content.Intent p2, global::Com.Tencent.Tauth.IUiListener p3)
		{
			if (id_onActivityResult_IILandroid_content_Intent_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_onActivityResult_IILandroid_content_Intent_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "onActivityResult", "(IILandroid/content/Intent;Lcom/tencent/tauth/IUiListener;)Z");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_onActivityResult_IILandroid_content_Intent_Lcom_tencent_tauth_IUiListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivityResult", "(IILandroid/content/Intent;Lcom/tencent/tauth/IUiListener;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setListenerWithRequestcode_ILcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetSetListenerWithRequestcode_ILcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_setListenerWithRequestcode_ILcom_tencent_tauth_IUiListener_ == null)
				cb_setListenerWithRequestcode_ILcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SetListenerWithRequestcode_ILcom_tencent_tauth_IUiListener_);
			return cb_setListenerWithRequestcode_ILcom_tencent_tauth_IUiListener_;
		}

		static IntPtr n_SetListenerWithRequestcode_ILcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Tencent.Connect.Common.UIListenerManager __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Common.UIListenerManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p1 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetListenerWithRequestcode (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setListenerWithRequestcode_ILcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='UIListenerManager']/method[@name='setListenerWithRequestcode' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.tencent.tauth.IUiListener']]"
		[Register ("setListenerWithRequestcode", "(ILcom/tencent/tauth/IUiListener;)Ljava/lang/Object;", "GetSetListenerWithRequestcode_ILcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe global::Java.Lang.Object SetListenerWithRequestcode (int p0, global::Com.Tencent.Tauth.IUiListener p1)
		{
			if (id_setListenerWithRequestcode_ILcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_setListenerWithRequestcode_ILcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "setListenerWithRequestcode", "(ILcom/tencent/tauth/IUiListener;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_setListenerWithRequestcode_ILcom_tencent_tauth_IUiListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setListenerWithRequestcode", "(ILcom/tencent/tauth/IUiListener;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setListnerWithAction_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetSetListnerWithAction_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_setListnerWithAction_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ == null)
				cb_setListnerWithAction_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetListnerWithAction_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_);
			return cb_setListnerWithAction_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		}

		static IntPtr n_SetListnerWithAction_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Connect.Common.UIListenerManager __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Common.UIListenerManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p1 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetListnerWithAction (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setListnerWithAction_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='UIListenerManager']/method[@name='setListnerWithAction' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.tencent.tauth.IUiListener']]"
		[Register ("setListnerWithAction", "(Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)Ljava/lang/Object;", "GetSetListnerWithAction_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe global::Java.Lang.Object SetListnerWithAction (string p0, global::Com.Tencent.Tauth.IUiListener p1)
		{
			if (id_setListnerWithAction_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_setListnerWithAction_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "setListnerWithAction", "(Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_setListnerWithAction_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setListnerWithAction", "(Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
