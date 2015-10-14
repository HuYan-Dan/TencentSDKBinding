using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Connect.Auth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthMap']"
	[global::Android.Runtime.Register ("com/tencent/connect/auth/AuthMap", DoNotGenerateAcw=true)]
	public partial class AuthMap : global::Java.Lang.Object {


		static IntPtr KEY_CHAR_LIST_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthMap']/field[@name='KEY_CHAR_LIST']"
		[Register ("KEY_CHAR_LIST")]
		public string KeyCharList {
			get {
				if (KEY_CHAR_LIST_jfieldId == IntPtr.Zero)
					KEY_CHAR_LIST_jfieldId = JNIEnv.GetFieldID (class_ref, "KEY_CHAR_LIST", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, KEY_CHAR_LIST_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (KEY_CHAR_LIST_jfieldId == IntPtr.Zero)
					KEY_CHAR_LIST_jfieldId = JNIEnv.GetFieldID (class_ref, "KEY_CHAR_LIST", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, KEY_CHAR_LIST_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr authMap_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthMap']/field[@name='authMap']"
		[Register ("authMap")]
		public global::System.Collections.IDictionary authMap_ {
			get {
				if (authMap_jfieldId == IntPtr.Zero)
					authMap_jfieldId = JNIEnv.GetFieldID (class_ref, "authMap", "Ljava/util/HashMap;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, authMap_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (authMap_jfieldId == IntPtr.Zero)
					authMap_jfieldId = JNIEnv.GetFieldID (class_ref, "authMap", "Ljava/util/HashMap;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, authMap_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr sInstance_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthMap']/field[@name='sInstance']"
		[Register ("sInstance")]
		public static global::Com.Tencent.Connect.Auth.AuthMap SInstance {
			get {
				if (sInstance_jfieldId == IntPtr.Zero)
					sInstance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "sInstance", "Lcom/tencent/connect/auth/AuthMap;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, sInstance_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.AuthMap> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (sInstance_jfieldId == IntPtr.Zero)
					sInstance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "sInstance", "Lcom/tencent/connect/auth/AuthMap;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, sInstance_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthMap.Auth']"
		[global::Android.Runtime.Register ("com/tencent/connect/auth/AuthMap$Auth", DoNotGenerateAcw=true)]
		public partial class Auth : global::Java.Lang.Object {


			static IntPtr dialog_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthMap.Auth']/field[@name='dialog']"
			[Register ("dialog")]
			public global::Com.Tencent.Connect.Auth.AuthDialog Dialog {
				get {
					if (dialog_jfieldId == IntPtr.Zero)
						dialog_jfieldId = JNIEnv.GetFieldID (class_ref, "dialog", "Lcom/tencent/connect/auth/AuthDialog;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, dialog_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.AuthDialog> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (dialog_jfieldId == IntPtr.Zero)
						dialog_jfieldId = JNIEnv.GetFieldID (class_ref, "dialog", "Lcom/tencent/connect/auth/AuthDialog;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (Handle, dialog_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr key_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthMap.Auth']/field[@name='key']"
			[Register ("key")]
			public string Key {
				get {
					if (key_jfieldId == IntPtr.Zero)
						key_jfieldId = JNIEnv.GetFieldID (class_ref, "key", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, key_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (key_jfieldId == IntPtr.Zero)
						key_jfieldId = JNIEnv.GetFieldID (class_ref, "key", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (Handle, key_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr listener_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthMap.Auth']/field[@name='listener']"
			[Register ("listener")]
			public global::Com.Tencent.Tauth.IUiListener Listener {
				get {
					if (listener_jfieldId == IntPtr.Zero)
						listener_jfieldId = JNIEnv.GetFieldID (class_ref, "listener", "Lcom/tencent/tauth/IUiListener;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, listener_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (listener_jfieldId == IntPtr.Zero)
						listener_jfieldId = JNIEnv.GetFieldID (class_ref, "listener", "Lcom/tencent/tauth/IUiListener;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (Handle, listener_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/connect/auth/AuthMap$Auth", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Auth); }
			}

			protected Auth (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthMap.Auth']/constructor[@name='AuthMap.Auth' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Auth ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Auth)) {
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

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/connect/auth/AuthMap", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AuthMap); }
		}

		protected AuthMap (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthMap']/constructor[@name='AuthMap' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AuthMap ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AuthMap)) {
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

		static IntPtr id_getInstance;
		public static unsafe global::Com.Tencent.Connect.Auth.AuthMap Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthMap']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/tencent/connect/auth/AuthMap;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/tencent/connect/auth/AuthMap;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.AuthMap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSerial;
		public static unsafe int Serial {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthMap']/method[@name='getSerial' and count(parameter)=0]"
			[Register ("getSerial", "()I", "GetGetSerialHandler")]
			get {
				if (id_getSerial == IntPtr.Zero)
					id_getSerial = JNIEnv.GetStaticMethodID (class_ref, "getSerial", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getSerial);
				} finally {
				}
			}
		}

		static Delegate cb_decode_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDecode_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_decode_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_decode_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Decode_Ljava_lang_String_Ljava_lang_String_);
			return cb_decode_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_Decode_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Connect.Auth.AuthMap __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.AuthMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Decode (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decode_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthMap']/method[@name='decode' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("decode", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetDecode_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string Decode (string p0, string p1)
		{
			if (id_decode_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_decode_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "decode", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_decode_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decode", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_get_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Handler ()
		{
			if (cb_get_Ljava_lang_String_ == null)
				cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_String_);
			return cb_get_Ljava_lang_String_;
		}

		static IntPtr n_Get_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Connect.Auth.AuthMap __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.AuthMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthMap']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Lcom/tencent/connect/auth/AuthMap$Auth;", "GetGet_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Tencent.Connect.Auth.AuthMap.Auth Get (string p0)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;)Lcom/tencent/connect/auth/AuthMap$Auth;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Tencent.Connect.Auth.AuthMap.Auth __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.AuthMap.Auth> (JNIEnv.CallObjectMethod  (Handle, id_get_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.AuthMap.Auth> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Ljava/lang/String;)Lcom/tencent/connect/auth/AuthMap$Auth;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_makeKey;
#pragma warning disable 0169
		static Delegate GetMakeKeyHandler ()
		{
			if (cb_makeKey == null)
				cb_makeKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_MakeKey);
			return cb_makeKey;
		}

		static IntPtr n_MakeKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Connect.Auth.AuthMap __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.AuthMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MakeKey ());
		}
#pragma warning restore 0169

		static IntPtr id_makeKey;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthMap']/method[@name='makeKey' and count(parameter)=0]"
		[Register ("makeKey", "()Ljava/lang/String;", "GetMakeKeyHandler")]
		public virtual unsafe string MakeKey ()
		{
			if (id_makeKey == IntPtr.Zero)
				id_makeKey = JNIEnv.GetMethodID (class_ref, "makeKey", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_makeKey), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "makeKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_remove_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemove_Ljava_lang_String_Handler ()
		{
			if (cb_remove_Ljava_lang_String_ == null)
				cb_remove_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Remove_Ljava_lang_String_);
			return cb_remove_Ljava_lang_String_;
		}

		static void n_Remove_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Connect.Auth.AuthMap __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.AuthMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Remove (p0);
		}
#pragma warning restore 0169

		static IntPtr id_remove_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthMap']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("remove", "(Ljava/lang/String;)V", "GetRemove_Ljava_lang_String_Handler")]
		public virtual unsafe void Remove (string p0)
		{
			if (id_remove_Ljava_lang_String_ == IntPtr.Zero)
				id_remove_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_remove_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_set_Lcom_tencent_connect_auth_AuthMap_Auth_;
#pragma warning disable 0169
		static Delegate GetSet_Lcom_tencent_connect_auth_AuthMap_Auth_Handler ()
		{
			if (cb_set_Lcom_tencent_connect_auth_AuthMap_Auth_ == null)
				cb_set_Lcom_tencent_connect_auth_AuthMap_Auth_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Set_Lcom_tencent_connect_auth_AuthMap_Auth_);
			return cb_set_Lcom_tencent_connect_auth_AuthMap_Auth_;
		}

		static IntPtr n_Set_Lcom_tencent_connect_auth_AuthMap_Auth_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Connect.Auth.AuthMap __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.AuthMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Connect.Auth.AuthMap.Auth p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.AuthMap.Auth> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Set (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_set_Lcom_tencent_connect_auth_AuthMap_Auth_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthMap']/method[@name='set' and count(parameter)=1 and parameter[1][@type='com.tencent.connect.auth.AuthMap.Auth']]"
		[Register ("set", "(Lcom/tencent/connect/auth/AuthMap$Auth;)Ljava/lang/String;", "GetSet_Lcom_tencent_connect_auth_AuthMap_Auth_Handler")]
		public virtual unsafe string Set (global::Com.Tencent.Connect.Auth.AuthMap.Auth p0)
		{
			if (id_set_Lcom_tencent_connect_auth_AuthMap_Auth_ == IntPtr.Zero)
				id_set_Lcom_tencent_connect_auth_AuthMap_Auth_ = JNIEnv.GetMethodID (class_ref, "set", "(Lcom/tencent/connect/auth/AuthMap$Auth;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_set_Lcom_tencent_connect_auth_AuthMap_Auth_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set", "(Lcom/tencent/connect/auth/AuthMap$Auth;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
